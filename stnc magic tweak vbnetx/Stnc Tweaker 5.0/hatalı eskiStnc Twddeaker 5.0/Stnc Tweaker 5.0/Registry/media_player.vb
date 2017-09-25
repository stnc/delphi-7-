Module media_player
    Sub media_player_Load()
        With Index
            .Medi_yazi_textbox.Text = My.Computer.Registry.GetValue _
            ("HKEY_CURRENT_USER\Software\Policies\Microsoft\WindowsMediaPlayer", "TitleBar", "")
        End With
    End Sub

    Sub kaydet_Click()
        With Index
            My.Computer.Registry.SetValue _
                    ("HKEY_CURRENT_USER\Software\Policies\Microsoft\WindowsMediaPlayer", "TitleBar", .Medi_yazi_textbox.Text)
            .Medi_yazi_textbox.Refresh()
        End With
    End Sub
End Module
