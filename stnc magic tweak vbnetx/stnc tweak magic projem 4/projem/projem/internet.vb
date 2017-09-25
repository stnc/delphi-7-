Public Class internet

    Private Sub internet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ie_surum_text_box_oku()
        giris_sayfa_oku()
        ie_text_oku()
        ie_baslik_TextBox_oku()
    End Sub
    '++++++++++ie sürümü oku 
    Private Sub ie_surum_text_box_oku()
        ie_surum_text_box.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\Main", _
        "Wizard_Version", "")
    End Sub
    '++++++++++ie giriþ sayfasý oku
    Private Sub giris_sayfa_oku()
        ie_giris_TextBox.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
        "Start Page", "")
    End Sub
    'ie girþ sayfasýný deðiþtir
    Private Sub ie_giris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ie_giris.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
              "Start Page", ie_giris_TextBox.Text)
    End Sub
    '++++++ie arama sayfasýný oku
    Private Sub ie_text_oku()
        ie_text.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\Search", _
        "SearchAssistant", "")
    End Sub

    '++++++++++ie baþlýk oku
    Private Sub ie_baslik_TextBox_oku()
        ie_baslik_TextBox.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
        "Window title", "")

    End Sub
    'windows ie baslýk deðiþtir
    Private Sub kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kaydet.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
              "Window title", ie_baslik_TextBox.Text)
    End Sub


    Private Sub Google_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Google_button.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
               "Window title", "www.google.com")
        ie_text.Text = "www.google.com"
    End Sub

    Private Sub int_oze_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles int_oze_button.Click
        On Error Resume Next
        Dim process As Process = New Process
        Diagnostics.Process.Start(System.Environment.SystemDirectory + "\inetcpl.cpl")
        If Err.Number = 5 Then
            MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
        End If
    End Sub
End Class