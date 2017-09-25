Module outlook
    Sub outlook_Load()
        With Index
            .yazi_TextBox.Text = My.Computer.Registry.GetValue _
            ("HKEY_CURRENT_USER\Identities\{57FF4855-F63C-4503-97BD-C40AB1569259}\Software\Microsoft\Outlook Express\5.0", "WindowTitle", "")
        End With
    End Sub
    Sub outlok_ac_Click()
        With Index
            On Error Resume Next
            'Dim process As Process = New Process
            Shell(My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Outlook Express\msimn.exe", AppWinStyle.NormalFocus)
            If Err.Number = 5 Then
                MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
            End If
        End With
    End Sub

    Sub Outlok_exprees_check_CheckedChanged()
        With Index
            If .Outlok_exprees_check.Checked = True Then
                My.Computer.Registry.SetValue _
           ("HKEY_CURRENT_USER\Identities\{57FF4855-F63C-4503-97BD-C40AB1569259}\Software\Microsoft\Outlook Express\5.0", _
           "NoSplash", 1)
            Else
                My.Computer.Registry.SetValue _
                ("HKEY_CURRENT_USER\Identities\{57FF4855-F63C-4503-97BD-C40AB1569259}\Software\Microsoft\Outlook Express\5.0", _
           "NoSplash", 0)
            End If
        End With
    End Sub
End Module
