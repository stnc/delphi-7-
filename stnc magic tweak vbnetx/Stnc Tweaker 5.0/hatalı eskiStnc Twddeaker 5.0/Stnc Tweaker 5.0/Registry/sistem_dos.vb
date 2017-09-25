Module sistem_dos
    'Public Class sistem_dos
    Sub sistem_dos_Load()
        With Index
            On Error Resume Next
            .TextBox1.Text = (My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.ToString)
            .TextBox2.Text = (My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString)
            .TextBox3.Text = (My.Computer.FileSystem.SpecialDirectories.Desktop.ToString)
            .TextBox4.Text = (My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString)
            .TextBox5.Text = (My.Computer.FileSystem.SpecialDirectories.MyMusic.ToString)
            .TextBox6.Text = (My.Computer.FileSystem.SpecialDirectories.MyPictures.ToString)
            .TextBox7.Text = (My.Computer.FileSystem.SpecialDirectories.ProgramFiles.ToString)
            .TextBox8.Text = (My.Computer.FileSystem.SpecialDirectories.Programs.ToString)
            .TextBox9.Text = (My.Computer.FileSystem.SpecialDirectories.Temp.ToString)
            .TextBox10.Text = (System.Environment.SystemDirectory.ToString)
        End With
    End Sub


    Sub kullanici_klasor()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.ToString)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub cureetn_user()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub desktop()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Desktop)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub belgelerim()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub music()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyMusic)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub pictures()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyPictures)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub prg_files()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.ProgramFiles)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub programs()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Programs)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub
    Sub temp()
        On Error Resume Next
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub

    Sub system()
        On Error Resume Next
        Process.Start(System.Environment.SystemDirectory)
        If Err.Number = 76 Then
            MsgBox("Klasör Bulunamadý", MsgBoxStyle.Information, "Uyarý")
        End If
    End Sub
    'End Class
End Module
