VERSION 5.00
Begin VB.UserControl StncTittle 
   ClientHeight    =   495
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   1215
   ControlContainer=   -1  'True
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ScaleHeight     =   33
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   81
End
Attribute VB_Name = "StncTittle"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Public Enum GRADIENT_DIRECT
    [Left to Right] = &H0
    [Top to Bottom] = &H1
End Enum

Private Type RECT
    Left As Long
    Top As Long
    Right As Long
    Bottom As Long
End Type

Private Type TRIVERTEX
   X As Long
   Y As Long
   Red As Integer
   Green As Integer
   Blue As Integer
   Alpha As Integer
End Type

Private Type GRADIENT_RECT
    UpperLeft As Long
    LowerRight As Long
End Type

Private Declare Function Rectangle Lib "gdi32" (ByVal hDC As Long, ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long
Private Declare Function RoundRect Lib "gdi32" (ByVal hDC As Long, ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long, ByVal X3 As Long, ByVal Y3 As Long) As Long
Private Declare Function CreateRoundRectRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long, ByVal X3 As Long, ByVal Y3 As Long) As Long
Private Declare Function CreateRectRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long
Private Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Long, ByVal hRgn As Long, ByVal bRedraw As Boolean) As Long
Private Declare Function GradientFillRect Lib "msimg32" Alias "GradientFill" (ByVal hDC As Long, pVertex As TRIVERTEX, ByVal dwNumVertex As Long, pMesh As GRADIENT_RECT, ByVal dwNumMesh As Long, ByVal dwMode As Long) As Long
Private Declare Function GradientFill Lib "msimg32" (ByVal hDC As Long, pVertex As Any, ByVal dwNumVertex As Long, pMesh As Any, ByVal dwNumMesh As Long, ByVal dwMode As Long) As Long
Private Declare Function SetRect Lib "user32" (lpRect As RECT, ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long) As Long

Public Event Click()
Public Event DoubleClick()
Public Event KeyDown(KeyCode As Integer, Shift As Integer)
Public Event KeyPress(KeyAscii As Integer)
Public Event KeyUp(KeyCode As Integer, Shift As Integer)
Public Event MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
Public Event MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Public Event MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)

Private oleBackColor As OLE_COLOR
Private oleBorderColor As OLE_COLOR
Private oleForeColor As OLE_COLOR
Private oleTitleGradStart As OLE_COLOR
Private oleTitleGradEnd As OLE_COLOR

Private fntFont As Font

Private lonRoundValue As Long

Private intTitleHeight As Integer

Private strCaption As String

Private udtAlign As AlignmentConstants
Private udtRect As RECT

Public Function hwnd() As Long
hwnd = UserControl.hwnd
End Function

Public Function hDC() As Long
hDC = UserControl.hDC
End Function

Private Sub DrawCaption()
Dim lonX As Long, lonY As Long

With UserControl
    .ForeColor = oleForeColor
    lonY = (intTitleHeight * 0.5) - (.TextHeight(strCaption) * 0.5)
    
    If udtAlign = vbLeftJustify Then
        lonX = 5
    ElseIf udtAlign = vbCenter Then
        lonX = (.ScaleWidth * 0.5) - (.TextWidth(strCaption) * 0.5)
    ElseIf udtAlign = vbRightJustify Then
        lonX = (.ScaleWidth - 5) - (.TextWidth(strCaption))
    End If
    
    .CurrentX = lonX
    .CurrentY = lonY
    UserControl.Print strCaption
End With
End Sub

Private Sub DrawPanel()
Dim lonRectRet As Long

With UserControl
    .Cls
    .BackColor = oleBackColor
    lonRectRet = CreateRoundRectRgn(0, 0, .ScaleWidth, .ScaleHeight, lonRoundValue, lonRoundValue)
    SetWindowRgn .hwnd, lonRectRet, True
    DefineRect 1, 1, .ScaleWidth - 2, intTitleHeight
    DrawGradient .hDC, [Top to Bottom], oleTitleGradStart, oleTitleGradEnd
    .ForeColor = oleBorderColor
    RoundRect .hDC, 0, 0, .ScaleWidth - 1, .ScaleHeight - 1, lonRoundValue, lonRoundValue
    UserControl.Line (0, intTitleHeight)-(.ScaleWidth, intTitleHeight), oleBorderColor
    DrawCaption
End With
End Sub

Public Property Get BackColor() As OLE_COLOR
BackColor = oleBackColor
End Property

Public Property Let BackColor(ByVal NewValue As OLE_COLOR)
oleBackColor = NewValue
PropertyChanged "BackColor"
DrawPanel
End Property

Public Property Get BorderColor() As OLE_COLOR
BorderColor = oleBorderColor
End Property

Public Property Let BorderColor(ByVal NewValue As OLE_COLOR)
oleBorderColor = NewValue
PropertyChanged "BorderColor"
DrawPanel
End Property

Public Property Get ForeColor() As OLE_COLOR
ForeColor = oleForeColor
End Property

Public Property Let ForeColor(ByVal NewValue As OLE_COLOR)
oleForeColor = NewValue
PropertyChanged "ForeColor"
DrawPanel
End Property

Public Property Get TitleGradientStart() As OLE_COLOR
TitleGradientStart = oleTitleGradStart
End Property

Public Property Let TitleGradientStart(ByVal NewValue As OLE_COLOR)
oleTitleGradStart = NewValue
PropertyChanged "TitleGradientStart"
DrawPanel
End Property

Public Property Get TitleGradientEnd() As OLE_COLOR
TitleGradientEnd = oleTitleGradEnd
End Property

Public Property Let TitleGradientEnd(ByVal NewValue As OLE_COLOR)
oleTitleGradEnd = NewValue
PropertyChanged "TitleGradientEnd"
DrawPanel
End Property

Public Property Get Font() As Font
Set Font = fntFont
End Property

Public Property Set Font(ByVal NewValue As Font)
Set fntFont = NewValue
Set UserControl.Font = fntFont
PropertyChanged "Font"
DrawPanel
End Property

Public Property Get RoundedCorners() As Long
RoundedCorners = lonRoundValue
End Property

Public Property Let RoundedCorners(ByVal NewValue As Long)
lonRoundValue = NewValue
PropertyChanged "RoundedCorners"
DrawPanel
End Property

Public Property Get TitleHeight() As Integer
TitleHeight = intTitleHeight
End Property

Public Property Let TitleHeight(ByVal NewValue As Integer)
intTitleHeight = NewValue
PropertyChanged "TitleHeight"
DrawPanel
End Property

Public Property Get Caption() As String
Caption = strCaption
End Property

Public Property Let Caption(ByVal NewValue As String)
strCaption = NewValue
PropertyChanged "Caption"
DrawPanel
End Property

Public Property Get Alignment() As AlignmentConstants
Alignment = udtAlign
End Property

Public Property Let Alignment(ByVal NewValue As AlignmentConstants)
udtAlign = NewValue
PropertyChanged "Alignment"
DrawPanel
End Property

Private Sub UserControl_Click()
RaiseEvent Click
End Sub

Private Sub UserControl_DblClick()
RaiseEvent DoubleClick
End Sub

Private Sub UserControl_KeyDown(KeyCode As Integer, Shift As Integer)
RaiseEvent KeyDown(KeyCode, Shift)
End Sub

Private Sub UserControl_KeyPress(KeyAscii As Integer)
RaiseEvent KeyPress(KeyAscii)
End Sub

Private Sub UserControl_KeyUp(KeyCode As Integer, Shift As Integer)
RaiseEvent KeyUp(KeyCode, Shift)
End Sub

Private Sub UserControl_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
RaiseEvent MouseDown(Button, Shift, X, Y)
End Sub

Private Sub UserControl_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RaiseEvent MouseMove(Button, Shift, X, Y)
End Sub

Private Sub UserControl_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
RaiseEvent MouseUp(Button, Shift, X, Y)
End Sub

Private Sub UserControl_Paint()
DrawPanel
End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
With PropBag
    Let BackColor = .ReadProperty("BackColor", vbButtonFace)
    Let BorderColor = .ReadProperty("BorderColor", 0)
    Let ForeColor = .ReadProperty("ForeColor", 0)
    Let TitleGradientStart = .ReadProperty("TitleGradientStart", vbWhite)
    Let TitleGradientEnd = .ReadProperty("TitleGradientEnd", RGB(0, 108, 217))
    Set Font = .ReadProperty("Font", Ambient.Font)
    Let RoundedCorners = .ReadProperty("RoundedCorners", 0)
    Let TitleHeight = .ReadProperty("TitleHeight", 18)
    Let Caption = .ReadProperty("Caption", Ambient.DisplayName)
    Let Alignment = .ReadProperty("Alignment", vbCenter)
End With
End Sub

Private Sub UserControl_Resize()
DrawPanel
End Sub

Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
With PropBag
    .WriteProperty "BackColor", oleBackColor, vbButtonFace
    .WriteProperty "BorderColor", oleBorderColor, 0
    .WriteProperty "ForeColor", oleForeColor, 0
    .WriteProperty "TitleGradientStart", oleTitleGradStart, vbWhite
    .WriteProperty "TitleGradientEnd", oleTitleGradEnd, RGB(0, 108, 217)
    .WriteProperty "Font", fntFont, Ambient.Font
    .WriteProperty "RoundedCorners", lonRoundValue, 0
    .WriteProperty "TitleHeight", intTitleHeight, 18
    .WriteProperty "Caption", strCaption, Ambient.DisplayName
    .WriteProperty "Alignment", udtAlign, vbCenter
End With
End Sub

Private Sub UserControl_InitProperties()
Let BackColor = vbButtonFace
Let BorderColor = 0
Let ForeColor = 0
Let TitleGradientStart = vbWhite
Let TitleGradientEnd = RGB(0, 108, 217)
Set Font = Ambient.Font
Let RoundedCorners = 0
Let TitleHeight = 18
Let Caption = Ambient.DisplayName
Let Alignment = vbCenter
End Sub

Private Function LongToSignedShort(ByVal Unsigned As Long) As Integer
If Unsigned < 32768 Then
    LongToSignedShort = CInt(Unsigned)
Else
    LongToSignedShort = CInt(Unsigned - &H10000)
End If
End Function

Private Sub DefineRect(ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long)
SetRect udtRect, X1, Y1, X2, Y2
End Sub

Private Sub DrawGradient(ByVal hDC As Long, Direction As GRADIENT_DIRECT, ByVal StartColor As Long, ByVal EndColor As Long)
Dim udtVert(1) As TRIVERTEX, udtGRect As GRADIENT_RECT

With udtVert(0)
    .X = udtRect.Left
    .Y = udtRect.Top
    .Red = LongToSignedShort(CLng((StartColor And &HFF&) * 256))
    .Green = LongToSignedShort(CLng(((StartColor And &HFF00&) \ &H100&) * 256))
    .Blue = LongToSignedShort(CLng(((StartColor And &HFF0000) \ &H10000) * 256))
    .Alpha = 0&
End With

With udtVert(1)
    .X = udtRect.Right
    .Y = udtRect.Bottom
    .Red = LongToSignedShort(CLng((EndColor And &HFF&) * 256))
    .Green = LongToSignedShort(CLng(((EndColor And &HFF00&) \ &H100&) * 256))
    .Blue = LongToSignedShort(CLng(((EndColor And &HFF0000) \ &H10000) * 256))
    .Alpha = 0&
End With

udtGRect.UpperLeft = 0
udtGRect.LowerRight = 1

GradientFillRect hDC, udtVert(0), 2, udtGRect, 1, Direction
End Sub

