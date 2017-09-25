Public Class sistem_dos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim islem As Process = New Process
        Process.Start("c:\boot.ini", "Notepad.exe")
    End Sub

    Private Sub sistem_dos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'boot_RichTextBox.LoadFile = ("c:\boot.ini")
    End Sub
End Class