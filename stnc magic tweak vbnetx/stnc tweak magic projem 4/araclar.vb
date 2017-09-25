Public Class araclar
    Private Sub Dxdiag_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dxdiag_pic.Click
        Dim calistir As Integer
        On Error Resume Next
        calistir = Shell(System.Environment.SystemDirectory + "\dxdiag.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Dxdiag Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Private Sub sistem_geri_pic_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sistem_geri_pic_box.Click
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\restore\rstrui.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Sistem Geri Yükleme Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Private Sub Regedit_pic_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regedit_pic_box.Click
        Process.Start(System.Environment.SystemDirectory + "\dfrg.msc")

    End Sub

    Private Sub telnet_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles telnet_pic.Click
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\telnet.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Telnet Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub


    Private Sub nt_backup_pic_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nt_backup_pic_box.Click
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\ntbackup.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("NT Backup Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Private Sub sysedit_pic_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sysedit_pic_box.Click
        Dim run As Integer
        On Error Resume Next
        run = Shell(System.Environment.SystemDirectory + "\sysedit.exe", AppWinStyle.NormalFocus)
        If Err.Number = 53 Then
            MsgBox("Sysedit Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub

    Private Sub cleanmgr_pic_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cleanmgr_pic_box.Click

        On Error Resume Next
        Process.Start(System.Environment.SystemDirectory + "\cleanmgr.exe")
        If Err.Number = 53 Then
            MsgBox("Disk Temizleme Programý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")

        End If
    End Sub

    Private Sub watson_pic_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles watson_pic_box.Click
        On Error Resume Next
        Process.Start(System.Environment.SystemDirectory + "\drwtsn32.exe")
        If Err.Number = 53 Then
            MsgBox("Dr. Watson Hata Ayýklayýcý Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Uyarý")
        End If
    End Sub
End Class