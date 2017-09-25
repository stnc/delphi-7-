VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.Image Image1 
      Height          =   1455
      Left            =   1320
      Picture         =   "Form1.frx":0000
      Stretch         =   -1  'True
      Top             =   960
      Width           =   2295
   End
   Begin VB.Menu mnuPopup 
      Caption         =   "menu"
      Visible         =   0   'False
      Begin VB.Menu b 
         Caption         =   "ser"
         Shortcut        =   {F1}
      End
      Begin VB.Menu vf 
         Caption         =   "dd"
         Checked         =   -1  'True
         Shortcut        =   {F2}
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' Make sure it's the right button.
    If Button And vbRightButton _
        Then PopupMenu mnuPopup
End Sub



Private Sub Image1_Click()
Form2.Show
End Sub
