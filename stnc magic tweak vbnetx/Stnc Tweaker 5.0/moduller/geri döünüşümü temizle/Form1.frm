VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const SHERB_NOCONFIRMATION = &H1
Const SHERB_NOPROGRESSUI = &H2
Const SHERB_NOSOUND = &H4
Private Type ULARGE_INTEGER
  LowPart As Long
  HighPart As Long
End Type
Private Type SHQUERYRBINFO
  cbSize As Long
  i64Size As ULARGE_INTEGER
  i64NumItems As ULARGE_INTEGER
End Type
Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hwnd As Long, ByVal pszRootPath As String, ByVal dwFlags As Long) As Long
Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Long
Private Declare Function SHQueryRecycleBin Lib "shell32.dll" Alias "SHQueryRecycleBinA" (ByVal pszRootPath As String, pSHQueryRBInfo As SHQUERYRBINFO) As Long
Private Sub Form_Load()
    'KPD-Team 2000
    'URL: http://www.allapi.net/
    'E-Mail: KPDTeam@Allapi.net
    Dim RBinInfo As SHQUERYRBINFO, Msg As VbMsgBoxResult
    RBinInfo.cbSize = Len(RBinInfo)
    SHQueryRecycleBin vbNullString, RBinInfo
    If (RBinInfo.i64Size.LowPart And &H80000000) = &H80000000 Or RBinInfo.i64Size.HighPart > 0 Then
        Msg = MsgBox("Your Recycle Bin consumes over 2 gigabytes right now!" + vbCrLf + "Do you want to empty it?", vbYesNo + vbQuestion)
    Else
        Msg = MsgBox("Your Recycle Bin consumes" + Str$(RBinInfo.i64Size.LowPart) + " bytes right now." + vbCrLf + "Do you want to empty it?", vbYesNo + vbQuestion)
    End If
    If Msg = vbYes Then
        SHEmptyRecycleBin Me.hwnd, vbNullString, 0
        SHUpdateRecycleBinIcon
    End If
End Sub

