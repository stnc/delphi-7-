VERSION 5.00
Begin VB.Form home 
   BackColor       =   &H80000013&
   BorderStyle     =   0  'None
   ClientHeight    =   8400
   ClientLeft      =   1950
   ClientTop       =   -390
   ClientWidth     =   11760
   Icon            =   "home.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   8400
   ScaleWidth      =   11760
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame5 
      Height          =   7455
      Left            =   5160
      TabIndex        =   31
      Top             =   480
      Width           =   6135
   End
   Begin Project1.StncTittle StncTittle3 
      Height          =   255
      Left            =   3840
      TabIndex        =   30
      Top             =   1080
      Width           =   855
      _ExtentX        =   1508
      _ExtentY        =   450
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin Project1.StncTittle StncTittle2 
      Height          =   255
      Left            =   360
      TabIndex        =   28
      Top             =   6600
      Width           =   1815
      _ExtentX        =   3201
      _ExtentY        =   450
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Caption         =   "Araçlar Paneli"
   End
   Begin Project1.StncTittle StncTittle1 
      Height          =   255
      Left            =   360
      TabIndex        =   27
      Top             =   480
      Width           =   1815
      _ExtentX        =   3201
      _ExtentY        =   450
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Caption         =   ""
   End
   Begin VB.Frame Frame4 
      BackColor       =   &H00808080&
      Height          =   6135
      Left            =   2280
      TabIndex        =   13
      Top             =   840
      Width           =   1095
      Begin VB.CheckBox Check6 
         BackColor       =   &H00808080&
         Caption         =   "Güvenlik"
         DownPicture     =   "home.frx":0442
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Left            =   240
         Picture         =   "home.frx":1084
         Style           =   1  'Graphical
         TabIndex        =   29
         Top             =   3120
         Width           =   1215
      End
      Begin VB.CheckBox Check5 
         BackColor       =   &H00808080&
         Caption         =   "Tweak UI"
         DownPicture     =   "home.frx":1CC6
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         Picture         =   "home.frx":2908
         Style           =   1  'Graphical
         TabIndex        =   25
         Top             =   2160
         Width           =   1215
      End
      Begin VB.CheckBox Check12 
         BackColor       =   &H00808080&
         Caption         =   "Hakkýnda"
         DownPicture     =   "home.frx":354A
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         Picture         =   "home.frx":418C
         Style           =   1  'Graphical
         TabIndex        =   24
         Top             =   1200
         Width           =   1215
      End
      Begin VB.CheckBox Check2 
         BackColor       =   &H00808080&
         Caption         =   "Baþlat Menüsü"
         DownPicture     =   "home.frx":4DCE
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         Picture         =   "home.frx":5A10
         Style           =   1  'Graphical
         TabIndex        =   23
         Top             =   240
         Width           =   1215
      End
   End
   Begin VB.Frame Frame3 
      BackColor       =   &H00808080&
      Height          =   6135
      Left            =   3840
      TabIndex        =   12
      Top             =   1200
      Width           =   855
      Begin VB.CheckBox Check9 
         BackColor       =   &H00808080&
         Caption         =   "Ayarlar"
         DownPicture     =   "home.frx":6652
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         Picture         =   "home.frx":7294
         Style           =   1  'Graphical
         TabIndex        =   26
         Top             =   3480
         Width           =   1215
      End
      Begin VB.CheckBox Check3 
         BackColor       =   &H00808080&
         Caption         =   "Sistem"
         DownPicture     =   "home.frx":7ED6
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Left            =   240
         Picture         =   "home.frx":8B18
         Style           =   1  'Graphical
         TabIndex        =   22
         Top             =   2640
         Width           =   1215
      End
      Begin VB.CheckBox Check15 
         BackColor       =   &H00808080&
         Caption         =   "Araçlar"
         DownPicture     =   "home.frx":975A
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         Picture         =   "home.frx":A39C
         Style           =   1  'Graphical
         TabIndex        =   21
         Top             =   1560
         Width           =   1215
      End
      Begin VB.CheckBox Check14 
         BackColor       =   &H00808080&
         Caption         =   "Yedekleme"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         Picture         =   "home.frx":AFDE
         Style           =   1  'Graphical
         TabIndex        =   20
         Top             =   4560
         Width           =   1215
      End
      Begin VB.CheckBox Check13 
         BackColor       =   &H00808080&
         Caption         =   "Yardým"
         DownPicture     =   "home.frx":BC20
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   240
         Picture         =   "home.frx":C862
         Style           =   1  'Graphical
         TabIndex        =   19
         Top             =   480
         Width           =   1215
      End
   End
   Begin VB.CommandButton about 
      Height          =   255
      Left            =   10680
      Picture         =   "home.frx":D4A4
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   120
      UseMaskColor    =   -1  'True
      Width           =   375
   End
   Begin VB.CommandButton kapat 
      Cancel          =   -1  'True
      Height          =   255
      Left            =   11400
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   120
      Width           =   375
   End
   Begin VB.Frame Frame2 
      ClipControls    =   0   'False
      Height          =   735
      Left            =   480
      TabIndex        =   4
      Top             =   7320
      Width           =   3135
      Begin VB.CommandButton Command2 
         Caption         =   "APPLE"
         Height          =   615
         Left            =   1440
         TabIndex        =   11
         Top             =   960
         Width           =   975
      End
      Begin VB.CommandButton vista 
         Caption         =   "vista"
         Height          =   495
         Left            =   240
         TabIndex        =   10
         Top             =   240
         Width           =   975
      End
      Begin VB.CommandButton Command1 
         Caption         =   "corona"
         Height          =   495
         Left            =   1320
         TabIndex        =   8
         Top             =   240
         Width           =   1095
      End
      Begin VB.CommandButton xpstyle 
         Caption         =   "XP"
         Height          =   495
         Left            =   240
         TabIndex        =   7
         Top             =   960
         Width           =   1095
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Label1"
         Height          =   195
         Left            =   240
         TabIndex        =   9
         Top             =   2400
         Width           =   480
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00808080&
      Height          =   6135
      Left            =   360
      TabIndex        =   2
      Top             =   600
      Width           =   1815
      Begin VB.CheckBox Check11 
         BackColor       =   &H00808080&
         Caption         =   "Site Yasaklayýcý"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   360
         Picture         =   "home.frx":D91E
         Style           =   1  'Graphical
         TabIndex        =   18
         Top             =   3000
         Width           =   1095
      End
      Begin VB.CheckBox Check10 
         BackColor       =   &H00808080&
         Caption         =   "Sistem Dosya"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   360
         Picture         =   "home.frx":E560
         Style           =   1  'Graphical
         TabIndex        =   17
         Top             =   3960
         Width           =   1095
      End
      Begin VB.CheckBox Check8 
         BackColor       =   &H00808080&
         Caption         =   "Ýnternet Explorer"
         DownPicture     =   "home.frx":F1A2
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000007&
         Height          =   855
         Left            =   360
         MaskColor       =   &H00000000&
         OLEDropMode     =   1  'Manual
         Picture         =   "home.frx":FDE4
         Style           =   1  'Graphical
         TabIndex        =   16
         Top             =   2040
         Width           =   1095
      End
      Begin VB.CheckBox Check7 
         BackColor       =   &H00808080&
         Caption         =   "Autorun"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   360
         Picture         =   "home.frx":10A26
         Style           =   1  'Graphical
         TabIndex        =   15
         Top             =   4920
         Width           =   1095
      End
      Begin VB.CheckBox Check4 
         BackColor       =   &H00808080&
         Caption         =   "Denetim Masasý"
         DownPicture     =   "home.frx":11A68
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   360
         Picture         =   "home.frx":126AA
         Style           =   1  'Graphical
         TabIndex        =   14
         Top             =   1080
         Width           =   1095
      End
      Begin VB.CheckBox Check1 
         BackColor       =   &H00808080&
         Caption         =   "Masaüstü"
         DisabledPicture =   "home.frx":132EC
         DownPicture     =   "home.frx":1FD4E
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   162
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   735
         Left            =   360
         MaskColor       =   &H00808080&
         Picture         =   "home.frx":20990
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   240
         Width           =   1095
      End
   End
   Begin VB.CommandButton minimize 
      Height          =   255
      Left            =   11040
      Picture         =   "home.frx":215D2
      Style           =   1  'Graphical
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   120
      Width           =   375
   End
   Begin VB.Image arkapl 
      Height          =   7935
      Left            =   120
      Stretch         =   -1  'True
      Top             =   360
      Width           =   11535
   End
   Begin VB.Label baslýkyazisi 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Left            =   600
      TabIndex        =   1
      Top             =   120
      Width           =   555
   End
   Begin VB.Image dikeyskn6sag 
      Height          =   1455
      Left            =   11640
      Stretch         =   -1  'True
      Top             =   6840
      Width           =   135
   End
   Begin VB.Image dikeyskn5sag 
      Height          =   1335
      Left            =   11640
      Stretch         =   -1  'True
      Top             =   5520
      Width           =   135
   End
   Begin VB.Image dikeyskn4sag 
      Height          =   1455
      Left            =   11640
      Stretch         =   -1  'True
      Top             =   4080
      Width           =   135
   End
   Begin VB.Image dikeyskn3sag 
      Height          =   1575
      Left            =   11640
      Stretch         =   -1  'True
      Top             =   2640
      Width           =   135
   End
   Begin VB.Image dikeyskn2sag 
      Height          =   1335
      Left            =   11640
      Stretch         =   -1  'True
      Top             =   1440
      Width           =   135
   End
   Begin VB.Image dikeyskn1sag 
      Height          =   1815
      Left            =   11640
      Stretch         =   -1  'True
      Top             =   360
      Width           =   135
   End
   Begin VB.Image yatayskn10 
      Height          =   135
      Left            =   10440
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1335
   End
   Begin VB.Image yatayskn9 
      Height          =   135
      Left            =   9600
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1335
   End
   Begin VB.Image yatayskn8 
      Height          =   135
      Left            =   8400
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1215
   End
   Begin VB.Image yatayskn7 
      Height          =   135
      Left            =   7080
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1335
   End
   Begin VB.Image ust2 
      Height          =   375
      Left            =   3960
      Stretch         =   -1  'True
      Top             =   0
      Width           =   7815
   End
   Begin VB.Image ust1 
      Height          =   375
      Left            =   0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   3975
   End
   Begin VB.Image yatayskn6 
      Height          =   135
      Left            =   5880
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1215
   End
   Begin VB.Image yatayskn5 
      Height          =   135
      Left            =   4680
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1215
   End
   Begin VB.Image yatayskn4 
      Height          =   135
      Left            =   3480
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1215
   End
   Begin VB.Image yatayskn3 
      Height          =   135
      Left            =   2520
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   975
   End
   Begin VB.Image yatayskn2 
      Height          =   135
      Left            =   1440
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1095
   End
   Begin VB.Image yatayskn1 
      Height          =   135
      Left            =   0
      Stretch         =   -1  'True
      Top             =   8280
      Width           =   1455
   End
   Begin VB.Image dikeyskn6 
      Height          =   1470
      Left            =   0
      Stretch         =   -1  'True
      Top             =   7440
      Width           =   105
   End
   Begin VB.Image dikeyskn5 
      Height          =   1470
      Left            =   0
      Stretch         =   -1  'True
      Top             =   6120
      Width           =   105
   End
   Begin VB.Image dikeyskn4 
      Height          =   1470
      Left            =   0
      Stretch         =   -1  'True
      Top             =   4680
      Width           =   105
   End
   Begin VB.Image dikeyskn3 
      Height          =   1470
      Left            =   0
      Stretch         =   -1  'True
      Top             =   3240
      Width           =   105
   End
   Begin VB.Image dikeyskn2 
      Height          =   1470
      Left            =   0
      Stretch         =   -1  'True
      Top             =   1800
      Width           =   105
   End
   Begin VB.Image dikeyskn1 
      Height          =   1470
      Left            =   0
      Stretch         =   -1  'True
      Top             =   360
      Width           =   105
   End
End
Attribute VB_Name = "home"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
'kýsayol için gerekli komutlar (daha dogrusu alt f4 için)
Private Const MOD_ALT = &H1
Private Const MOD_CONTROL = &H2
Private Const MOD_SHIFT = &H4
Private Const PM_REMOVE = &H1
Private Const WM_HOTKEY = &H312
Private Type POINTAPI
    X As Long
    Y As Long
End Type
Private Type Msg
    hwnd As Long
    Message As Long
    wParam As Long
    lParam As Long
    time As Long
    pt As POINTAPI
End Type
Private Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As Long, ByVal id As Long, ByVal fsModifiers As Long, ByVal vk As Long) As Long
Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As Long, ByVal id As Long) As Long
Private Declare Function PeekMessage Lib "user32" Alias "PeekMessageA" (lpMsg As Msg, ByVal hwnd As Long, ByVal wMsgFilterMin As Long, ByVal wMsgFilterMax As Long, ByVal wRemoveMsg As Long) As Long
Private Declare Function WaitMessage Lib "user32" () As Long
Private bCancel As Boolean
'kýsayol için gerekli komutlar (daha dogrusu alt f4 için) bitiþ



'form hareket apileri
'bu kýsým da ki kodlar form normal de border style özelligi devre dýþý oldugu için yani kapat,minimize seçenkleri o yüzden
'üst kýsým görünmez ve hareket edemez bu üst kýsmý hareket ettirir
Private Declare Function ReleaseCapture Lib "user32" () As Long
Private Declare Function SendMessage Lib "user32" Alias _
"SendMessageA" (ByVal hwnd As Long, ByVal wMsg _
As Long, ByVal wParam As Long, lParam As Any) As Long
Private Const HTCAPTION = 2
Private Const WM_NCLBUTTONDOWN = &HA1
Private Const WM_SYSCOMMAND = &H112
'form hareket apileri bitiþi
Private Declare Function ShellAbout Lib "shell32.dll" Alias "ShellAboutA" (ByVal hwnd As Long, ByVal szApp As String, ByVal szOtherStuff As String, ByVal hIcon As Long) As Long 'windows un kendine özel kullandýgý hakkýnda apisi







Private Sub Check10_Click()
yordam10
End Sub

Private Sub Check11_Click()
yordam11
End Sub

Private Sub Check12_Click()
yordam12
End Sub

Private Sub Check13_Click()
yordam13
End Sub

Private Sub Check14_Click()
yordam14
End Sub

Private Sub Check15_Click()
yordam15
End Sub

Private Sub Check2_Click()
yordam2
End Sub

Private Sub Check3_Click()
yordam3
End Sub

Private Sub Check4_Click()
yordam4
End Sub

Private Sub Check5_Click()
yordam5
End Sub

Private Sub Check6_Click()
yordam6
End Sub

Private Sub Check7_Click()
yordam7
End Sub

Private Sub Check8_Click()
yordam8
End Sub

Private Sub Check9_Click()
yordam9
End Sub

Private Sub Command2_Click()
appleskin
End Sub
'kýsayol için gerekli sub
Private Sub ProcessMessages()
    Dim Message As Msg
    'loop until bCancel is set to True
    Do While Not bCancel
        'wait for a message
        WaitMessage
        'check if it's a HOTKEY-message
        If PeekMessage(Message, Me.hwnd, WM_HOTKEY, WM_HOTKEY, PM_REMOVE) Then
            'minimize the form
            'WindowState = vbMinimized
            End 'veya unload all form olayý
        End If
        'let the operating system process other events
        DoEvents
    Loop
End Sub

Private Sub kýsayol()
    'KPD-Team 2000
    'URL: http://www.allapi.net/
    'E-Mail: KPDTeam@Allapi.net
    Dim ret As Long
    bCancel = False
    'register the Ctrl-F hotkey
    'ret = RegisterHotKey(Me.hWnd, &HBFFF&, MOD_CONTROL + MOD_ALT, vbKeyF)
    ret = RegisterHotKey(Me.hwnd, &HBFFF&, MOD_ALT, vbKeyF4)
    'show some information
    Me.AutoRedraw = True
    'Me.Print "Press CTRL-F to minimize this form"
    'show the form and
    Show
    'process the Hotkey messages
    ProcessMessages
End Sub
'kýsayol bitiþi
Private Sub hotregkis()
 bCancel = True
    'unregister hotkey
    Call UnregisterHotKey(Me.hwnd, &HBFFF&)
End Sub



'bu kýsýmdaki kod tamame ykarýsý ile baðlantýlý yani image (ust 1)
'mouse basýlý tutuldgunda (MouseDown)formun hareket etmesini saðlar
'ayný durum bir alt daki içinda geçerlidir
Private Sub ust1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
Call ReleaseCapture
SendMessage Me.hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
End Sub

Private Sub ust2_MouseDown(Button As Integer, Shift As _
Integer, X As Single, Y As Single) 'dikkat edilirse burda starý sürdürme karakteri "_" var
Call ReleaseCapture
SendMessage Me.hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
End Sub
Private Sub baslýkyazisi_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
Call ReleaseCapture
SendMessage Me.hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
'bu kýsýmdaki kod tamame ykarýsý ile baðlantýlý yani image (ust 1)
'mouse basýlý tutuldgunda (MouseDown)formun hareket etmesini saðlar
'ayný durum bir alt daki içinda geçerlidir
End Sub

Private Sub Form_Load()
'flash
DefaultSkins
Baslýklar
ToolTipTextler
olaylarr
kýsayol 'kýsayol alt ve f4
hotregkis 'kýsayol kapanýþý
yerlesim1
Move (Screen.Width - Width) / 2, (Screen.Height - Height) / 2 'her çözünürlükte formun tam ortada kalmasýný saðlar api si yok
End Sub



'*******COMMAND BUTON KISIMLARI**********************
Private Sub kapat_Click()
End
End Sub
Private Sub minimize_Click()
WindowState = 1
End Sub
Private Sub About_Click()
    ShellAbout Me.hwnd, App.Title, "Stnc System Organizator", ByVal 0&
End Sub
Private Sub Command1_Click()
DefaultSkins
'minimize_Click
End Sub

Private Sub vista_Click()
vistaSkin
End Sub
Private Sub xpstyle_Click()
XpSkin
End Sub
                
                '***********CHECKLER************

Private Sub Check1_Click()
If Check1.Value = 1 Then
Frame2.Visible = False
Else
Frame2.Visible = True
End If
yordam1
End Sub



'**************BAÞLIKLAR VE TOOL TÝP TEXLER***************



Private Sub Baslýklar()
Me.Caption = "STNC Sistem Organizator" 'formun Kendi yazsý ayrýca minimize oldugunda çýkan yazý
baslýkyazisi.Caption = "Stnc Sistem Organizator 3.11" 'en üst de baþlýk da yazan yazý
'StncTittle.Caption = "Görevler"
End Sub
Private Sub ToolTipTextler()
kapat.ToolTipText = "Programý Kapat" 'programý kapat a ait
minimize.ToolTipText = "Simge Durumuna Küçült" 'programý simge düþüne ait
'baslýkyazisi = "" ''en üst de baþlýk da yazan yazý
'StncTittle.ToolTipText = "" 'mavili yerde ttile ým da yazan yere ait
End Sub

Private Sub olaylarr()
kapat.Default = False
End Sub





       '************SKÝNSLER*********************
Private Sub DefaultSkins()

arkapl.Picture = LoadResPicture("ALAN", 0)
'kapat.Picture = LoadResPicture("KAPAT", 0)
'minimize.Picture = LoadResPicture("MINI", 0)

kapat.Picture = LoadResPicture("NO", 0)
minimize.Picture = LoadResPicture("MINI", 0)

ust1.Picture = LoadResPicture("A1", 0)
ust2.Picture = LoadResPicture("A2", 0) 'bu komut res dosyasýndaki resimi okur

dikeyskn1sag.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn2sag.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn3sag.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn4sag.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn5sag.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn6sag.Picture = LoadResPicture("DIKEYSKN", 0)

dikeyskn1.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn2.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn3.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn4.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn5.Picture = LoadResPicture("DIKEYSKN", 0)
dikeyskn6.Picture = LoadResPicture("DIKEYSKN", 0)

yatayskn1.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn2.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn3.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn4.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn5.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn6.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn7.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn8.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn9.Picture = LoadResPicture("YATAYSKN", 0)
yatayskn10.Picture = LoadResPicture("YATAYSKN", 0)
End Sub


Private Sub vistaSkin()
On Error GoTo hatalý
arkapl.Picture = LoadPicture(App.Path & "\skins\vista\fon.skn")



On Error GoTo hatalý
ust1.Picture = LoadPicture(App.Path & "\skins\vista\usa.skn")
On Error GoTo hatalý
ust2.Picture = LoadPicture(App.Path & "\skins\vista\usa2.skn")

On Error GoTo hatalý
kapat.Picture = LoadPicture(App.Path & "\skins\vista\no.skn")
On Error GoTo hatalý
minimize.Picture = LoadPicture(App.Path & "\skins\vista\mini.skn")


On Error GoTo hatalý
dikeyskn1sag.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn2sag.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn3sag.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn4sag.Picture = LoadPicture(App.Path & "\skins\\vista\xy.skn")
On Error GoTo hatalý
dikeyskn5sag.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn6sag.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý

dikeyskn1.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn2.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn3.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn4.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn5.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý
dikeyskn6.Picture = LoadPicture(App.Path & "\skins\vista\xy.skn")
On Error GoTo hatalý

yatayskn1.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn2.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn3.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn4.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn5.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn6.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn7.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn8.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn9.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý
yatayskn10.Picture = LoadPicture(App.Path & "\skins\vista\yx.skn")
On Error GoTo hatalý


hatalý:
If Err.Number = 75 Then
Label1.Caption = "Skin Yolu Eksik Veya Hatalý"
DefaultSkins 'burdaki hata defaýult menu ona birþey yüklemiyor resourceden o yani
End If

If Err.Number = 53 Then
Label1.Caption = "Skin Eksik Veya Hatalý"
DefaultSkins 'burdaki hata defaýult menu ona birþey yüklemiyor resourceden o yani
End If

End Sub

Private Sub XpSkin()
On Error GoTo hatalý
arkapl.Picture = LoadPicture(App.Path & "\skins\Xp Style\fon.skn")



On Error GoTo hatalý
ust1.Picture = LoadPicture(App.Path & "\skins\Xp Style\usa.skn")
On Error GoTo hatalý
ust2.Picture = LoadPicture(App.Path & "\skins\Xp Style\usa2.skn")

On Error GoTo hatalý
kapat.Picture = LoadPicture(App.Path & "\skins\Xp Style\no.skn")
On Error GoTo hatalý
minimize.Picture = LoadPicture(App.Path & "\skins\xp style\mini.skn")


On Error GoTo hatalý
dikeyskn1sag.Picture = LoadPicture(App.Path & "\skins\Xp Style\xy.skn")
On Error GoTo hatalý
dikeyskn2sag.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn3sag.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn4sag.Picture = LoadPicture(App.Path & "\skins\\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn5sag.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn6sag.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn1.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn2.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn3.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn4.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn5.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý
dikeyskn6.Picture = LoadPicture(App.Path & "\skins\xp style\xy.skn")
On Error GoTo hatalý

yatayskn1.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn2.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn3.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn4.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn5.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn6.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn7.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn8.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn9.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý
yatayskn10.Picture = LoadPicture(App.Path & "\skins\xp style\yx.skn")
On Error GoTo hatalý

hatalý:
If Err.Number = 53 Then
Label1.Caption = "Skin Yolu Eksik Veya Hatalý"
DefaultSkins 'burdaki hata defaýult menu ona birþey yüklemiyor resourceden o yani
End If
'alan1.Picture = LoadResPicture("alan", 0)

'MsgBox App.Path  'bu App.Path uyuglamanýn bulundugu klasörün ismini verir
'burda iki tane hata var 53 ve 76
'Image1.Picture = LoadPicture(App.Path & "\skins\stnc.bmp")
'Image2.Picture = LoadPicture(App.Path & "\skins\res.bmp")
'Command1.Picture = LoadPicture(App.Path & "\skins\tus.skn")
'picDemo.Picture = LoadPicture(App.Path & "\Skins\" & List1.Text & ".demo")
End Sub



Private Sub appleskin()

On Error GoTo hatalý
arkapl.Picture = LoadPicture(App.Path & "\skins\apple\fon.skn")

On Error GoTo hatalý
kapat.Picture = LoadPicture(App.Path & "\skins\apple\no.skn")
On Error GoTo hatalý
minimize.Picture = LoadPicture(App.Path & "\skins\apple\mini.skn")

On Error GoTo hatalý
ust1.Picture = LoadPicture(App.Path & "\skins\Apple\usa.skn")
On Error GoTo hatalý
ust2.Picture = LoadPicture(App.Path & "\skins\Apple\usa.skn")

On Error GoTo hatalý
dikeyskn1sag.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn2sag.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn3sag.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn4sag.Picture = LoadPicture(App.Path & "\skins\\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn5sag.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn6sag.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn1.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn2.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn3.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn4.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn5.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý
dikeyskn6.Picture = LoadPicture(App.Path & "\skins\Apple\xy.skn")
On Error GoTo hatalý

yatayskn1.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn2.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn3.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn4.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn5.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn6.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn7.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn8.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn9.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý
yatayskn10.Picture = LoadPicture(App.Path & "\skins\Apple\yx.skn")
On Error GoTo hatalý



hatalý:
If Err.Number = 75 Then
Label1.Caption = "Skin Yolu Eksik Veya Hatalý"
DefaultSkins 'burdaki hata defaýult menu ona birþey yüklemiyor resourceden o yani
End If

If Err.Number = 53 Then
Label1.Caption = "Skin Eksik Veya Hatalý"
DefaultSkins 'burdaki hata defaýult menu ona birþey yüklemiyor resourceden o yani
End If


End Sub



Private Sub yordam1()
'Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub
Private Sub yordam4()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
'Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub
Private Sub yordam2()
Check1.Value = 0
'Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub


Private Sub yordam3()
Check1.Value = 0
Check2.Value = 0
'Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub
Private Sub yordam5()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
'Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub



Private Sub yordam6()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
'Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub



Private Sub yordam8()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
'Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub
Private Sub yordam7()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub


Private Sub yordam9()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
'Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
End Sub



Private Sub yordam10()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
'Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub



Private Sub yordam11()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
'Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub

Private Sub yordam12()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
'Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub

Private Sub yordam13()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
'Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub



Private Sub yordam14()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
'Check14.Value = 0
Check15.Value = 0
Check16.Value = 0
End Sub


Private Sub yordam15()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
'Check15.Value = 0
Check16.Value = 0
End Sub

Private Sub yordam16()
Check1.Value = 0
Check2.Value = 0
Check3.Value = 0
Check4.Value = 0
Check5.Value = 0
Check6.Value = 0
Check7.Value = 0
Check8.Value = 0
Check9.Value = 0
Check10.Value = 0
Check11.Value = 0
Check12.Value = 0
Check13.Value = 0
Check14.Value = 0
Check15.Value = 0
'Check16.Value = 0
End Sub

Private Sub yerlesim1()
StncTittle2.Top = 6720
StncTittle2.Left = 360
Check6.Left = 298
End Sub









'******************hazýr fonksiyonlar********************
'bütün forma yazý yazar ama burada iþe yaramaz
'Private Sub Form_Paint()
'FontSize = 15
'Me.Print " stnc yazýlým ",

'**bu bütün formun hareket ettirilmesini saglayan fonksiyon ama þu an bizim için gereksiz
'Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
'Dim lngReturnValue As Long
'pencere tutuluyor
'Call ReleaseCapture
' pencereye msj yollanýyor
'lngReturnValue = SendMessage(Me.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
'End Sub
'Private Sub flash()
'ShockwaveFlash1.Movie = (App.Path & "\stnc.dll")

'End Sub



'*******************eklentiler ***************

'Private Sub alt_del_Click(Index As Integer)
'With alt_del
'If .Value = 1 Then
'Call SaveDword(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1)
'Else
'Call DeleteValue(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")
'End If
'End With
'End Sub
Private Sub sun_bag_Click()
With sun_bag
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoChooseProgramsPage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoChooseProgramsPage", 0)
End If
End With
End Sub


Private Sub ctrl_alt_Click()
With ctrl_alt
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 0)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")
End If
End With
End Sub
Private Sub hiz_kap_Click()
'HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control
Set Reg = CreateObject("Wscript.Shell")
With hiz_kap
If .Value = 1 Then
Reg.RegWrite "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\WaitToKillServiceTimeout", "2000"
Else
Reg.RegWrite "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\WaitToKillServiceTimeout", "200"
End If
End With
End Sub

Private Sub guv_duv_Click()
With guv_duv
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile", "EnableFirewall", 0)
End If
End With
End Sub

Private Sub bil_uzant_Click()
With bil_uzant
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", 0)
End If
End With
End Sub

































Private Sub no_key_Click()
With no_key
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableChangePassword", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableChangePassword", 0)
End If
End With
End Sub



Private Sub save_geri_Click()
savestring HKEY_LOCAL_MACHINE, "SOFTWARE\Classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E}", "", geri_text
End Sub

Private Sub Slider1_Click()
Slider1.Refresh
Label11.Caption = Slider1.ToolTipText
End Sub





Private Sub zip_fon_Click()
With zip_fon
If .Value = 1 Then
Shell "regsvr32 /u zipfldr.dll", vbHide
Else
Shell "regsvr32 zipfldr.dll", vbHide
End If
End With
End Sub
Private Sub msn_oto_Click()
Call DeleteValue(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "msnmsgr")
If msn_oto.Value = 1 Then
MsgBox "Ýþleminiz Tamamlandý", vbInformation + vbDefaultButton1 + vbOKOnly, "UYARI"
End If
End Sub
Private Sub Command1_Click()
MsgBox "Lütfen Msn messenger ý kapatýn", vbOKOnly + vbInformation, "UYARI"
Shell "RunDLL32 advpack.dll,LaunchINFSection %windir%\INF\msmsgs.inf,BLC.Remove", vbHide
End Sub
Private Sub ag_bile_Click()
With ag_bile
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanChangeProperties", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanChangeProperties", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanChangeProperties")
End If
End With
End Sub
Private Sub uz_er_bag_Click()
With uz_er_bag
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_RasChangeProperties", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_RasChangeProperties", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_RasChangeProperties")
End If
End With
End Sub

Private Sub gel_ip_Click()
With gel_ip
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AllowAdvancedTCPIPConfig", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AllowAdvancedTCPIPConfig", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AllowAdvancedTCPIPConfig")
End If
End With
End Sub

Private Sub gel_me_aya_Click()
With gel_me_aya
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AdvancedSettings", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AdvancedSettings", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AdvancedSettings")
End If
End With
End Sub

Private Sub lan_com_Click()
With lan_com
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AddRemoveComponents", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AddRemoveComponents", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_AddRemoveComponents")
End If
End With
End Sub

Private Sub ag_er_no_Click()
With ag_er_no
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanProperties", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanProperties", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanProperties")
End If
End With
End Sub

Private Sub lan_devre_Click()
With lan_devre
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_ChangeBindState", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_ChangeBindState", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_ChangeBindState")
End If
End With
End Sub

Private Sub lan_etk_dev_oz_Click()
With lan_etk_dev_oz
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanConnect", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanConnect", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_LanConnect")
End If
End With
End Sub

Private Sub yerel_bag_sih_Click()
With yerel_bag_sih
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_NewConnectionWizard", 0)
Else
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NC_NewConnectionWizard")
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_NewConnectionWizard", 1)
End If
End With
End Sub

Private Sub bag_ad_Click()
With bag_ad
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_RenameLanConnection", 0)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_RenameLanConnection", 1)
'Call DeleteValue(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Windows\Network Connections", "NC_RenameLanConnection")
End If
End With
End Sub





'Private Sub alt_del_Click(Index As Integer)
'With alt_del
'If .Value = 1 Then
'Call SaveDword(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1)
'Else
'Call DeleteValue(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")
'End If
'End With
'End Sub





Private Sub bant_Click()
With bant
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Group Policy Objects\LocalMachine\Software\Policies\Microsoft\Windows\Psched", "NonBestEffortLimit", 0)
.Caption = "iþleminiz tamam"
Else
'Call DeleteValue(HLM, "SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 0)
Call DeleteValue(HCU, "Software\Microsoft\Windows\CurrentVersion\Group Policy Objects\LocalMachine\Software\Policies\Microsoft\Windows\Psched", "NonBestEffortLimit")
.Caption = "yok olmadý"
End If
End With
End Sub

Private Sub denetim_masai_Click()
With denetim_masai
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 0)
End If
End With
End Sub

Private Sub hat_gon_Click()
With hat_gon
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\PCHealth\ErrorReporting", "DoReport", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\PCHealth\ErrorReporting", "DoReport", 0)
End If
End With
End Sub

Private Sub kri_hata_Click()
With kri_hata
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\PCHealth\ErrorReporting", "ShowUI", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\PCHealth\ErrorReporting", "ShowUI", 0)
End If
End With
End Sub


Private Sub msn_ou_Click()
With msn_ou
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Outlook Express", "Hide Messenger", 2)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Outlook Express", "Hide Messenger", 1)
End If
End With
End Sub


Private Sub prg_ek_kal_Click()
With prg_ek_kal
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoAddRemovePrograms", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoAddRemovePrograms", 0)
End If
End With
End Sub
Private Sub prg_ekle_Click()
With prg_ekle
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoRemovePage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoRemovePage", 0)
End If
End With
End Sub
Private Sub prg_win_bil_Click()
With prg_win_bil
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoWindowsSetupPage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoWindowsSetupPage", 0)
End If
End With
End Sub
Private Sub prg_erisim_Click()
With prg_erisim
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoChooseProgramsPage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoChooseProgramsPage", 0)
End If
End With
End Sub
Private Sub den_gor_Click()
With den_gor
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispCPL", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispCPL", 0)
End If
End With
End Sub
Private Sub oto_rest_Click()
With oto_rest
If .Value = 1 Then
Call SaveDword(HLM, "SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 1)
Else
Call SaveDword(HLM, "SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 0)
'Call DeleteValue(HLM, "SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 0)
End If
End With
End Sub


Private Sub EnableBalloonTips_Click()
With EnableBalloonTips
If .Value = 1 Then
Call SaveDword(HCU, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "EnableBalloonTips", 1)
Else
Call SaveDword(HCU, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "EnableBalloonTips", 0)
End If
End With
End Sub
Private Sub DisableThumbnailCache_Click()
With DisableThumbnailCache
If .Value = 1 Then
Call SaveDword(HCU, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbnailCache", 1)
Else
Call SaveDword(HCU, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbnailCache", 0)
End If
End With
End Sub

Private Sub Prefetcher_Click()
With Prefetcher
If .Value = 1 Then
Call SaveDword(HLM, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters", "EnablePrefetcher", 1)
Else
Call SaveDword(HLM, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters", "EnablePrefetcher", 0)
End If
End With
End Sub


'Private Sub no_surucu_Click()
'With no_surucu

'End If
'End With
'End Sub

'*************ÝNTERNET ADININ BULUNDUGU SEKME ******************************
'******************************************************************************
'******************************************************************************


'Private Sub nobrowser_Click()
'With nobrowser
'If .Value = 1 Then
'Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoBrowserClose", 1)
'Else
'Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoBrowserClose", 0)
'Call DeleteValue(HLM, "SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 0)
'End If
'End With
'End Sub
Private Sub icerik_Click()
With icerik
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ContentTab", 1)
'.Caption = "Ýþlem Tamamlandý"
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ContentTab", 0)
'Call DeleteValue(HLM, "SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 0)
End If
End With
End Sub


Private Sub no_net_Click()
With no_net
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ConnectionsTab", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ConnectionsTab", 0)
End If
End With
End Sub


Private Sub güvenlik_Click()
With güvenlik
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "SecurityTab", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "SecurityTab", 0)
End If
End With
End Sub


Private Sub gelismissekmesi_Click()
With gelismissekmesi
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "AdvancedTab", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "AdvancedTab", 0)
End If
End With
End Sub
Private Sub gizli_sayfa_Click()
With gizli_sayfa
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "PrivacyTab", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "PrivacyTab", 0)
End If
End With
End Sub


Private Sub prgtab_Click()
With prgtab
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ProgramsTab", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ProgramsTab", 0)
End If
End With
End Sub
Private Sub gnel_sek_Click()
With gnel_sek
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "GeneralTab", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "GeneralTab", 0)
End If
End With
End Sub

Private Sub saveasint_Click()
With saveasint
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs", 0)
End If
End With
End Sub

'BUNLAR ÝNTERNET  ÖZELLÝKLERÝNE AÝT

Private Sub no_prox_Click()
Set Reg = CreateObject("Wscript.Shell")
If no_prox.Value = 1 Then
Reg.RegWrite "HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Control Panel\proxy", "1"
Else
Reg.RegWrite "HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Control Panel\proxy", "0"
End If
End Sub

Private Sub ie_noana_Click()
With ie_noana
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "Homepage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "Homepage", 0)
End If
End With
End Sub


Private Sub no_exit_Click()
With no_exit
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserClose", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserClose", 0)
End If
End With
End Sub

'** BUNLAR BÝLGÝSAYAR SEKMESÝNDEKÝLER********

Private Sub no_spla_ou_Click()
With no_spla_ou
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Identities\{960B67F7-36A2-4263-9E67-9F99981B3BCB}\Software\Microsoft\Outlook Express\5.0", "NoSplash", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Identities\{960B67F7-36A2-4263-9E67-9F99981B3BCB}\Software\Microsoft\Outlook Express\5.0", "NoSplash", 0)
End If
End With
End Sub
Private Sub okyazibu_Click()
savestring HKEY_CURRENT_USER, "Identities\{960B67F7-36A2-4263-9E67-9F99981B3BCB}\Software\Microsoft\Outlook Express\5.0", "WindowTitle", okyazi
End Sub

'***** BUNALR MEDÝA PLAYER A AÝT*******************

Private Sub media_yazi_tus_Click()
With media_yazi
savestring HCU, "Software\Policies\Microsoft\WindowsMediaPlayer", "TitleBar", media_yazi
'media_yazi.Locked = False
'media_yazi.Text = Clear
End With
End Sub

Private Sub Form_Load()
yeniler
oto_load
internet
stncloadinter
userinfor
'dword okuma



'dword okuma
'easy = getdword(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")
'normal deger okuma alttaki
'easy = getstring(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")

'If easy = 1 Then
'alt_del.Value = 1
'End If
End Sub


Private Sub internet()
ie_bas = getstring(HKEY_CURRENT_USER, "Software\Microsoft\Internet Explorer\Main", "Window title")
ie_suru = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Internet Explorer\Main", "Wizard_Version")
'ie_var = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Internet Explorer\Main", "Local Page")
ie_gir = getstring(HKEY_CURRENT_USER, "Software\Microsoft\Internet Explorer\Main", "Start Page")
ie_ara = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Internet Explorer\Search", "SearchAssistant")
ie_cache = getstring(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "Cache")
End Sub

Private Sub goog_Click()
'googd = savestring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Internet Explorer\Search", "SearchAssistant")
'googd = "http://www.google.com.tr" 'bu araþtýrýlýcak
Set Reg = CreateObject("Wscript.Shell")
Reg.RegWrite "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\Search\SearchAssistant", "http://www.google.com.tr"
'Set Reg = CreateObject("Wscript.Shell")
'Reg.RegWrite "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\acc", "C:\Program Files\acc\acc.exe"
MsgBox "Arama Sayfanýz Google olarak Deðiþtirildi", vbInformation + vbInformation, "Uyarý"
End Sub







Private Sub stncloadinter()
'keys = getstring(HKEY_CURRENT_USER, "software\Stnc Software\", "Key")
no_prox = getstring(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "proxy")
If no_prox = 1 Then
no_prox.Value = 1
End If
ana_sayfa = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "Homepage")
If ana_sayfa = 1 Then
ie_noana.Value = 1
End If
no_exit = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "Homepage")
If no_exit = 1 Then
no_exit.Value = 1
End If
okyazi2 = getstring(HKEY_CURRENT_USER, "Identities\{960B67F7-36A2-4263-9E67-9F99981B3BCB}\Software\Microsoft\Outlook Express\5.0", "WindowTitle")
okyazi.Text = okyazi2

no_spla_ou = getdword(HKEY_CURRENT_USER, "Identities\{960B67F7-36A2-4263-9E67-9F99981B3BCB}\Software\Microsoft\Outlook Express\5.0", "NoSplash")
If no_spla_ou = 1 Then
no_spla_ou.Value = 1
End If

End Sub






Private Sub oto_load()
denetim_masasý_olmasýn = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel")
'normal deger okuma alttaki
'easy = getstring(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")
If denetim_masasý_olmasýn = 1 Then
denetim_masai.Value = 1
End If


program_ekle_kaldýr_olmasýn = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoAddRemovePrograms")
If program_ekle_kaldýr_olmasýn = 1 Then
prg_ek_kal.Value = 1
End If




monitor.Text = getstring(HLM, "SYSTEM\ControlSet001\Enum\DISPLAY\PHL000D\5&14183971&0&22446688&01&00", "DeviceDesc")
monitor.Locked = True

media_yazi.Text = getstring(HCU, "Software\Policies\Microsoft\WindowsMediaPlayer", "TitleBar")
'media_yazi.Locked = True


programlarý_listele_olmasýn = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoRemovePage")
If programlarý_listele_olmasýn = 1 Then
prg_ekle.Value = 1
End If


windowsbileseni = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoWindowsSetupPage")
If windowsbileseni = 1 Then
prg_win_bil.Value = 1
End If

prgvarsayýlanlarý = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", "NoChooseProgramsPage")
If prgvarsayýlanlarý = 1 Then
prg_erisim.Value = 1
End If


denemasagörüntüolmasý = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispCPL")
If prgvarsayýlanlarý = 1 Then
den_gor.Value = 1
End If
'dword okuma
easy = getdword(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")
'normal deger okuma alttaki
'easy = getstring(HCU, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")

'If easy = 1 Then
'alt_del.Value = 1
'End If

With oto_rest
oto_rest = getdword(HLM, "SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot")
If oto_rest = 1 Then
.Value = 1
End If
End With

With EnableBalloonTips
EnableBalloonTip = getdword(HCU, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "EnableBalloonTips")
If EnableBalloonTip = 1 Then
.Value = 1
End If
End With


With DisableThumbnailCache
DisableThumbnailCach = getdword(HCU, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbnailCache")
If DisableThumbnailCach = 1 Then
.Value = 1
End If
End With

With Prefetcher
Prefetche = getdword(HLM, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters", "EnablePrefetcher")
If Prefetche = 1 Then
.Value = 1
End If
End With

With no_net
no_nett = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ConnectionsTab")
If no_nett = 1 Then
.Value = 1
End If
End With

With güvenlik
güvenliksek = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "SecurityTab")
If güvenliksek = 1 Then
.Value = 1
End If
End With

With icerik
iceriksek = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ContentTab")
If iceriksek = 1 Then
.Value = 1
End If
End With



With gelismissekmesi
gelismissekmes = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "AdvancedTab")
If gelismissekmes = 1 Then
.Value = 1
End If
End With


With gnel_sek
genelsek = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "GeneralTab")
If genelsek = 1 Then
.Value = 1
End If
End With

With gizli_sayfa
gizlisayfa = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "PrivacyTab")
If gizlisayfa = 1 Then
.Value = 1
End If
End With

With prgtab
prgtab = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Control Panel", "ProgramsTab")
If prgtabs = 1 Then
.Value = 1
End If
End With

With saveasint
saveasinternet = getdword(HKEY_CURRENT_USER, "Software\Policies\Microsoft\Internet Explorer\Restrictions", "NoBrowserSaveAs")
If saveasinternet = 1 Then
.Value = 1
End If
End With



With no_surucu
sürücüolmasýn = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoViewOnDrive")
If sürücüolmasýn = 91 Then
.Value = 1
End If
End With

With hat_gon
hatgonderme = getdword(HLM, "SOFTWARE\Microsoft\PCHealth\ErrorReporting", "DoReport")
If hatgonderme = 1 Then
.Value = 1
End If
End With

With kri_hata
kritikhata = getdword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\PCHealth\ErrorReporting", "ShowUI")
If kritikhata = 1 Then
.Value = 1
End If
End With

With uz_masa
uz_masaust = getdword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Control\Terminal Server", "fAllowToGetHelp")
If uz_masaust = 1 Then
.Value = 1
End If
End With

With pagefile
pagefileol = getdword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "ClearPageFileAtShutdown")
If pagefileol = 1 Then
.Value = 1
End If
End With


With msn_ou
msn_outlo = getdword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Outlook Express", "Hide Messenger")
If msn_outlo = 2 Then
.Value = 1
End If
End With

'********ag ayarlarý kýsmý******************
'With bant
'bantgent = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Group Policy Objects\LocalMachine\Software\Policies\Microsoft\Windows\Psched", "NonBestEffortLimit")
'If bantgent = 0 Then
'.Value = 1
'End If
'End With




With bil_adi
bil_adi.Text = getstring(HLM, "SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName", "ComputerName")
'.Text = bilgisayaradi
End With

With isletim_sis
isletim_sis.Text = getstring(HLM, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName")
'.Text = isletimsistemi
End With

'With sistem_klasr
'sistem_klasr.Text = getstring(HLM, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "SystemRoot")
'End With

With CSDVersion
.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CSDVersion")
.Locked = True
End With


With organization
.Text = getstring(HLM, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOrganization")
.Locked = True
End With
End Sub

Private Sub uz_masa_Click()
With uz_masa
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Control\Terminal Server", "fAllowToGetHelp", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Control\Terminal Server", "fAllowToGetHelp", 0)
End If
End With
End Sub

Private Sub pagefile_Click()
With pagefile
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "ClearPageFileAtShutdown", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "ClearPageFileAtShutdown", 0)
End If
End With
End Sub

Private Sub yeniler()
With ctrl_alt
crtlaltno = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr")
If crtlaltno = 1 Then
.Value = 1
End If
End With

With gor_ol
gorunumolmasin = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoThemesTab")
If gorunumolmasin = 1 Then
.Value = 1
End If
End With


With mas_ust
masustuolma = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispBackgroundPage")
If masustuolma = 1 Then
.Value = 1
End If
End With

With ekran_kor
ekran_korolma = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispScrSavPage")
If ekran_korolma = 1 Then
.Value = 1
End If
End With

With gor_tem
gor_tema = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispAppearancePage")
If gor_tema = 1 Then
.Value = 1
End If
End With

With ayarlar_gor
ayarlaol = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispSettingsPage")
If ayarlaol = 1 Then
.Value = 1
End If
End With

With geri_don_no
geri_don_olm = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{645FF040-5081-101B-9F08-00AA002F954E}")
If geri_don_olm = 1 Then
.Value = 1
End If
End With

End Sub


'***************gürrötü ayrlarý *********
Private Sub gor_ol_Click()
With gor_ol
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoThemesTab", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoThemesTab", 0)
End If
End With
End Sub


Private Sub mas_ust_Click()
With mas_ust
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispBackgroundPage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispBackgroundPage", 0)
End If
End With
End Sub

Private Sub ekran_kor_Click()
With ekran_kor
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispScrSavPage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispScrSavPage", 0)
End If
End With
End Sub

Private Sub gor_tem_Click()
With gor_tem
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispAppearancePage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispAppearancePage", 0)
End If
End With
End Sub

Private Sub ayarlar_gor_Click()
With ayarlar_gor
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispSettingsPage", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispSettingsPage", 0)
End If
End With
End Sub

'****** diger **
Private Sub geri_don_no_Click()
With geri_don_no
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{645FF040-5081-101B-9F08-00AA002F954E}", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{645FF040-5081-101B-9F08-00AA002F954E}", 0)
End If
End With
End Sub

Private Sub mas_res_Click()
With mas_res
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop", "NoChangingWallPaper", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop", "NoChangingWallPaper", 0)
End If
End With
End Sub


'********BAÞLAT MENÜSÜ***************************

Private Sub bil_sim_Click()
With bil_sim
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}", 0)
End If
End With
End Sub

Private Sub belgeler_menu_Click()
With belgeler_menu
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMMyDocs", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMMyDocs", 0)
End If
End With
End Sub

Private Sub no_ag_Click()
With no_ag
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoNetworkConnections", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoNetworkConnections", 0)
End If
End With
End Sub

Private Sub gecmis_Click()
With gecmis
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRecentDocsHistory", 1)
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer", "NoRecentDocsHistory", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRecentDocsHistory", 0)
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer", "NoRecentDocsHistory", 0)
End If
End With
End Sub

Private Sub den_massaý_Click()
With den_massaý
If .Value = 1 Then
'Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1)
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer", "NoControlPanel", 1)
Else
'Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 0)
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer", "NoControlPanel", 0)
End If
End With
End Sub

Private Sub sik_kull_Click()
With sik_kull
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 0)
End If
End With
End Sub
Private Sub no_help_Click()
With no_help
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMHelp", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMHelp", 0)
End If
End With
End Sub

Private Sub sur_birak_Click()
With sur_birak
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoChangeStartMenu", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoChangeStartMenu", 0)
End If
End With
End Sub

Private Sub win_dene_Click()
With win_dene
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1)
'Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer", "NoControlPanel", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 0)
'Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer", "NoControlPanel", 0)
End If
End With
End Sub

Private Sub win_bas_bul_Click()
With win_bas_bul
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoShellSearchButton", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoShellSearchButton", 0)
End If
End With
End Sub
Private Sub gezgn_bul_Click()
With gezgn_bul
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoShellSearchButton", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoShellSearchButton", 0)
End If
End With
End Sub

Private Sub no_kapat_Click()
With no_kapat
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoClose", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoClose", 0)
End If
End With
End Sub

Private Sub bas_no_kul_Click()
With bas_no_kul
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCommonGroups", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCommonGroups", 0)
End If
End With
End Sub
Private Sub int_dos_Click()
With bas_no_kul
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 3)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1803", 0)
End If
End With
End Sub

Private Sub arac_cub_Click()
With arac_cub
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoToolbarCustomize", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoToolbarCustomize", 0)
End If
End With
End Sub

Private Sub no_int_dizin_Click()
With no_int_dizin
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Cache", "Persistent", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Cache", "Persistent", 0)
End If
End With
End Sub
'ag özellikleri
Private Sub eri_kont_Click()
With eri_kont
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoSecCpl", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoSecCpl", 0)
End If
End With
End Sub

Private Sub is_istas_Click()
With is_istas
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableLockWorkstation", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableLockWorkstation", 0)
End If
End With
End Sub

Private Sub no_tar_Click()
With no_tar
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\lanmanserver\parameters", "Hidden", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\lanmanserver\parameters", "Hidden", 0)
End If
End With
End Sub
Private Sub no_anao_Click()
With no_anao
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Lsa", "restrictanonymous", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Lsa", "restrictanonymous", 0)
End If
End With
End Sub

Private Sub dhcp_Click()
With dhcp
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Tcpip\Parameters", "PerformRouterDiscovery", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Tcpip\Parameters", "PerformRouterDiscovery", 0)
End If
End With
End Sub


Private Sub ag_son_pay_Click()
With ag_son_pay
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoRecentDocsNetHood", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoRecentDocsNetHood", 0)
End If
End With
End Sub
Private Sub no_printer_Click()
With no_printer
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPrinterTabs", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPrinterTabs", 0)
End If
End With
End Sub
Private Sub no_user_printer_Click()
With no_user_printer
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDeletePrinter", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDeletePrinter", 0)
End If
End With
End Sub

Private Sub no_new_printer_Click()
With no_new_printer
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoAddPrinter", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoAddPrinter", 0)
End If
End With
End Sub

Private Sub no_pri_kul_Click()
With no_pri_kul
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPrinters", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPrinters", 0)
End If
End With
End Sub
Private Sub gor_sek_Click()
With gor_sek
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispCpl", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispCpl", 0)
End If
End With
End Sub

Private Sub no_anim_Click()
With no_anim
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoChangeAnimation", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoChangeAnimation", 0)
End If
End With
End Sub

Private Sub kla_nav_Click()
With kla_nav
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoChangeKeyboardNavigationIndicators", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoChangeKeyboardNavigationIndicators", 0)
End If
End With
End Sub

Private Sub bel_oto_tem_Click()
With bel_oto_tem
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "ClearRecentDocsOnExit", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "ClearRecentDocsOnExit", 0)
End If
End With
End Sub
Private Sub otu_kapa_Click()
With otu_kapa
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "StartmenuLogoff", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "StartmenuLogoff", 0)
End If
End With
End Sub

Private Sub bil_yonet_Click()
With bil_yonet
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoManageMyComputerVerb", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoManageMyComputerVerb", 0)
End If
End With
End Sub

Private Sub wi_gun_Click()
Set Reg = CreateObject("Wscript.Shell")
With wi_gun
If .Value = 1 Then
Reg.RegWrite "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\RegDone", "1"
Else
Reg.RegWrite "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\RegDone", "0"
End If
End With
End Sub


Private Sub registry_Click()
With registry
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0)
End If
End With
End Sub

Private Sub yet_disk_Click()
With yet_disk
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoLowDiskSpaceChecks", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoLowDiskSpaceChecks", 0)
End If
End With
End Sub

Private Sub akilli_kaydir_Click()
With akilli_kaydir
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Control Panel\Desktop", "SmoothScroll", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Control Panel\Desktop", "SmoothScroll", 0)
End If
End With
End Sub
Private Sub sak_dll_Click()
With yet_disk
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "AlwaysUnloadDLL", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "AlwaysUnloadDLL", 0)
End If
End With
End Sub



'********otomatik baþlayanlar için olna kýsým



Private Sub unknown_oto_Click()
With unknown_oto
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 0)
End If
End With
End Sub
Private Sub ana_dizin_Click()
With ana_dizin
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 2)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 0)
End If
End With
End Sub
Private Sub tas_sur_Click()
With tas_sur
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 4)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 0)
End If
End With
End Sub

Private Sub hdd_oto_Click()
With hdd_oto
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 12)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 0)
End If
End With
End Sub

Private Sub uz_oto_Click()
With uz_oto
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 16)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 0)
End If
End With
End Sub

Private Sub cdrom_oto_Click()
With cdrom_oto
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 32)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 0)
End If
End With
End Sub

Private Sub ram_disk_Click()
With ram_disk
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 64)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 0)
End If
End With
End Sub

Private Sub data_cd_Click()
With data_cd
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Cdrom", "AutoRun", 0)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Cdrom", "AutoRun", 0)
End If
End With

End Sub
Private Sub mp3_oto_Click()
'Set Reg = CreateObject("Wscript.Shell")
With mp3_oto
If .Value = 1 Then
'Reg.RegWrite "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\Cdrom\SOFTWARE\Classes\AudioCD\Shell", "1"
savestring HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Cdrom\SOFTWARE\Classes\AudioCD\Shell", "", "play"
savestring HKEY_CLASSES_ROOT, "AudioCD\shell", "", "play"
Else
'Reg.RegWrite "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\RegDone", "0"
savestring HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Cdrom\SOFTWARE\Classes\AudioCD\Shell", "", ""
savestring HKEY_CLASSES_ROOT, "AudioCD\shell", "", ""
End If
End With
End Sub

Private Sub iee_Click()
With iee
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\dmadmin\Parameters", "EnableDynamicConversionFor1394", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\dmadmin\Parameters", "EnableDynamicConversionFor1394", 0)
End If
End With
End Sub

Private Sub lba_Click()
With lba
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\atapi\Parameters", "EnableBigLba", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\atapi\Parameters", "EnableBigLba", 0)
End If
End With
End Sub
Private Sub intel_Click()
With intel
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Class\{4D36E96A-E325-11CE-BFC1-08002BE10318}\0000", "EnableUDMA66", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Class\{4D36E96A-E325-11CE-BFC1-08002BE10318}\0000", "EnableUDMA66", 0)
End If
End With
End Sub
Private Sub no_cd_Click()
With no_cd
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 0)
End If
End With
End Sub
Private Sub ana_sys_Click()
With ana_sys
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "DisablePagingExecutive", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "DisablePagingExecutive", 0)
End If
End With
End Sub

Private Sub onbellek_Click()
With onbellek
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "SecondLevelDataCache", 512)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "SecondLevelDataCache", 0)
End If
End With
End Sub
Private Sub ana_ag_Click()
With ana_ag
If .Value = 1 Then
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Tcpip\Parameters", "DisableTaskOffload", 1)
Else
Call SaveDword(HKEY_LOCAL_MACHINE, "SYSTEM\ControlSet001\Services\Tcpip\Parameters", "DisableTaskOffload", 0)
End If
End With
End Sub
Private Sub mas_sur_Click()
With mas_sur
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Control Panel\Desktop", "PaintDesktopVersion", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Control Panel\Desktop", "PaintDesktopVersion", 0)
End If
End With
End Sub
Private Sub mas_sim_Click()
With mas_sur
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDesktop", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDesktop", 0)
End If
End With
End Sub
Private Sub aktif_masa_Click()
With mas_sur
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoActiveDesktop", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoActiveDesktop", 0)
End If
End With
End Sub

Private Sub kisayol_bilgi_Click()
With kisayol_bilgi
If .Value = 1 Then
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowInfoTip", 1)
Else
Call SaveDword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowInfoTip", 1)
End If
End With
End Sub

Private Sub icon_renk_Click()
'Set Reg = CreateObject("Wscript.Shell")
With icon_renk
If .Value = 1 Then
'Reg.RegWrite "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\Cdrom\SOFTWARE\Classes\AudioCD\Shell", "1"
savestring HKEY_CURRENT_USER, "Control Panel\Desktop\WindowMetrics", "Shell Icon BPP", "16"
Else
Call DeleteValue(HKEY_CURRENT_USER, "Control Panel\Desktop\WindowMetrics", "Shell Icon BPP")
End If
End With
End Sub

Private Sub numlock_Click()
With numlock
If .Value = 1 Then
savestring HKEY_CURRENT_USER, "Control Panel\Keyboard", "InitialKeyboardIndicators", "2"
Else
savestring HKEY_CURRENT_USER, "Control Panel\Keyboard", "InitialKeyboardIndicators", "0"
End If
End With
End Sub

'***************kullanýcý bilgisi
Private Sub userinfor()
version_text.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentVersion")
ver_no.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuildNumber")
pro_ser.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductId")
isl_sis.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName")
kur_dizin.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "SourcePath")
organi.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOrganization")
sys_dizinn = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "PathName")
build.Text = getstring(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "BuildLab")
sys_dizinn.Locked = True
version_text.Locked = True
ver_no.Locked = True
pro_ser.Locked = True
isl_sis.Locked = True
kur_dizin.Locked = True
End Sub



Private Sub otooku()

With unknown_oto
bilinmeyensürücü = getdword(HKEY_CURRENT_USER, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun", 1)
If bilinmeyensürücü = 1 Then
.Value = 1
End With







End Sub



















