Public Class outlook

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        'Dim process As Process = New Process
        Shell(My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Outlook Express\msimn.exe", AppWinStyle.NormalFocus)
        If Err.Number = 5 Then
            MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
        End If
    End Sub

    Private Sub outlook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        yazi_TextBox.Text = My.Computer.Registry.GetValue _
        ("HKEY_CURRENT_USER\Identities\{57FF4855-F63C-4503-97BD-C40AB1569259}\Software\Microsoft\Outlook Express\5.0", "WindowTitle", "")
    End Sub

    Private Sub Outlok_exprees_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Outlok_exprees_check.CheckedChanged
        If Outlok_exprees_check.Checked = True Then
            My.Computer.Registry.SetValue _
       ("HKEY_CURRENT_USER\Identities\{57FF4855-F63C-4503-97BD-C40AB1569259}\Software\Microsoft\Outlook Express\5.0", _
       "NoSplash", 0)
        Else
            My.Computer.Registry.SetValue _
            ("HKEY_CURRENT_USER\Identities\{57FF4855-F63C-4503-97BD-C40AB1569259}\Software\Microsoft\Outlook Express\5.0", _
       "NoSplash", 1)
        End If
    End Sub
End Class