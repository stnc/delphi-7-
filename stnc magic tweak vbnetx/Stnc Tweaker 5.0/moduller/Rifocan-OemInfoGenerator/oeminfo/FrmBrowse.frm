VERSION 5.00
Begin VB.Form FrmBrowse 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "RESÝME GÖZAT>>>"
   ClientHeight    =   5625
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7320
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5625
   ScaleWidth      =   7320
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   1710
      Left            =   4080
      Picture         =   "FrmBrowse.frx":0000
      ScaleHeight     =   1680
      ScaleWidth      =   2670
      TabIndex        =   6
      Top             =   960
      Width           =   2700
   End
   Begin VB.DirListBox Dir1 
      Appearance      =   0  'Flat
      Height          =   1890
      Left            =   120
      TabIndex        =   5
      Top             =   480
      Width           =   3495
   End
   Begin VB.DriveListBox Drive1 
      Appearance      =   0  'Flat
      Height          =   315
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   2535
   End
   Begin VB.FileListBox File1 
      Appearance      =   0  'Flat
      Height          =   2175
      Left            =   120
      TabIndex        =   3
      Top             =   2520
      Width           =   3495
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H00E0E0E0&
      Caption         =   "KAPAT"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3720
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton Command2 
      BackColor       =   &H00E0E0E0&
      Caption         =   "TAMAM"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5280
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   120
      Width           =   1935
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   2880
      TabIndex        =   0
      Text            =   "Text1"
      Top             =   120
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "OEMLOGO olacak hali :"
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
      Left            =   3960
      TabIndex        =   9
      Top             =   600
      Width           =   2055
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Tam Ekran Görüntüsü :"
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
      Left            =   3960
      TabIndex        =   8
      Top             =   2760
      Width           =   2415
   End
   Begin VB.Image Image1 
      Height          =   1575
      Left            =   3960
      Stretch         =   -1  'True
      Top             =   3000
      Width           =   3015
   End
   Begin VB.Label Label1 
      Caption         =   $"FrmBrowse.frx":3222
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      TabIndex        =   7
      Top             =   4800
      Width           =   7095
   End
End
Attribute VB_Name = "FrmBrowse"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Me.Hide
End Sub

Private Sub Command2_Click()
On Error Resume Next
FrmMain.Picture1.Picture = Image1.Picture
Me.Hide
End Sub

Private Sub Dir1_Change()
File1.Path = Dir1.Path
End Sub

Private Sub Drive1_Change()
On Error GoTo hata
Dir1.Path = Drive1.Drive
Exit Sub
hata:
MsgBox "Lütfen CD veya Disketin cihaz içinde olduðuna emin olun ", vbCritical, "Ulaþým Hatasý"
Drive1.Drive = Dir1.Path
Exit Sub
End Sub

Private Sub File1_Click()
On Error GoTo hata
Text1.Text = Dir1.Path & "\" & File1.FileName

Image1.Picture = LoadPicture(Text1.Text)
Picture1.Picture = LoadPicture(Text1.Text)
Exit Sub
hata:
MsgBox "Lütfen Görüntülenebilecek bir öðe seçin", vbInformation, "UYARI"
End Sub

