Module araclar_mod

    Sub Dxdiag_pic_Click()
        Dim calistir As Integer
        On Error Resume Next
        calistir = Shell(System.Environment.SystemDirectory + "\dxdiag.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Dxdiag Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Sub sistem_geri_pic_box_Click()
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\restore\rstrui.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Sistem Geri Yükleme Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Sub Regedit_pic_box_Click()
        Process.Start(System.Environment.SystemDirectory + "\dfrg.msc")

    End Sub

    Sub telnet_pic_Click()
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\telnet.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Telnet Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub


    Sub nt_backup_pic_box_Click()
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\ntbackup.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("NT Backup Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Sub sysedit_pic_box_Click()
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\sysedit.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Sysedit Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Sub cleanmgr_pic_box_Click()
        On Error Resume Next
        Process.Start(System.Environment.SystemDirectory + "\cleanmgr.exe")
        If Err.Number = 53 Then
            MsgBox("Disk Temizleme Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")

        End If
    End Sub

    Sub watson_pic_box_Click()
        On Error Resume Next
        Process.Start(System.Environment.SystemDirectory + "\drwtsn32.exe")
        If Err.Number = 53 Then
            MsgBox("Dr. Watson Hata Ayýklayýcý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

End Module
