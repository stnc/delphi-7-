VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form FrmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "OEM Bilgileri Düzenleyicisi - Rifat ERDEMÝR"
   ClientHeight    =   3795
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6855
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3795
   ScaleWidth      =   6855
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command3 
      Caption         =   "ÇIKIÞ"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   6
      Top             =   3240
      Width           =   2655
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   1710
      Left            =   120
      Picture         =   "FrmMain.frx":0000
      ScaleHeight     =   1680
      ScaleWidth      =   2670
      TabIndex        =   3
      Top             =   600
      Width           =   2700
   End
   Begin MSComDlg.CommonDialog dia 
      Left            =   240
      Top             =   120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DialogTitle     =   "Logo Picture"
   End
   Begin VB.CommandButton Command2 
      Caption         =   "OEMLOGO Resime Gözat >>>"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   2400
      Width           =   2655
   End
   Begin VB.CommandButton Command1 
      Caption         =   "BÝLGÝLERÝ GÖNDER"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2880
      TabIndex        =   1
      Top             =   3240
      Width           =   3855
   End
   Begin VB.TextBox Text1 
      Appearance      =   0  'Flat
      Height          =   1695
      Left            =   2880
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Text            =   "FrmMain.frx":3222
      Top             =   1440
      Width           =   3855
   End
   Begin VB.Label Label3 
      Caption         =   "byalpacino@hotmail.com"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   2880
      Width           =   2655
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "OEM INFO GENERATOR - RÝFOCAN"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   14.25
         Charset         =   162
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Width           =   6615
   End
   Begin VB.Label Label1 
      Caption         =   $"FrmMain.frx":3329
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   2880
      TabIndex        =   4
      Top             =   600
      Width           =   3855
   End
End
Attribute VB_Name = "FrmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long

'bu programcýðýn yaptýðý deðiþiklikleri görmek için
'masaüsütnde iken Bilgisayarým simgesine fare ile sað
'týklayýp özellikler panelinde program ile gönderdiðiniz resimi
've o paneldeki Destek Bilgisi butonuna týklayýn ve
'yazdýðýnýz bilgileride burada göreceksiniz..

Private Sub Command1_Click()
Dim SysDir As String
Dim leng As Integer
Dim Bilgi As String
SysDir = Space(260)
leng = GetSystemDirectory(SysDir, 260)
SysDir = Mid(SysDir, 1, leng) & "\OEMBilgi.INI"
Bilgi = Text1.Text
Open SysDir For Binary Access Write As #1
Put #1, , Bilgi
Close #1
SavePicture Picture1.Image, Mid(SysDir, 1, leng) & "\OEMLOGO.BMP"
MsgBox "Tebrikler..."
End Sub

Private Sub Command2_Click()
FrmBrowse.Show 1

'dia.ShowOpen
'Picture1.Picture = LoadPicture(dia.FileName)
End Sub

Private Sub Command3_Click()
End
End Sub

Private Sub Form_Activate()
On Error Resume Next
Picture1.Picture = LoadPicture(FrmBrowse.Text1.Text)
End Sub

Private Sub Form_Unload(Cancel As Integer)
End
End Sub
