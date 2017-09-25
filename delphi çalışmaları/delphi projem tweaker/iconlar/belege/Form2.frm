VERSION 5.00
Begin VB.Form Form2 
   Caption         =   "Form2"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form2"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
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
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' Make sure it's the right button.
    If Button And vbRightButton _
        Then PopupMenu mnuPopup
End Sub


