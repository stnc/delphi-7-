Public Class media_player

    Private Sub media_player_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Medi_yazi_textbox.Text = My.Computer.Registry.GetValue _
        ("HKEY_CURRENT_USER\Software\Policies\Microsoft\WindowsMediaPlayer", "TitleBar", "")
    End Sub

    Private Sub kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kaydet.Click
        My.Computer.Registry.SetValue _
                ("HKEY_CURRENT_USER\Software\Policies\Microsoft\WindowsMediaPlayer", "TitleBar", Medi_yazi_textbox.Text)
        Medi_yazi_textbox.Refresh()
    End Sub
End Class