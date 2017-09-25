Public Class denetim_masa

    Private Sub denetim_masa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'burdaki oku ismiyle gecen ler degerlerin program 
        'acýldýgýnda regedtdeki degerini okur ve azar
        prg_deg_oku() : yeni_prg_oku()
        win_bil_oku() : prg_eri_var_oku()
        tema_sek_oku() : masa_ust_oku()
        ekran_oku() : gorunum_oku()
        ayarlar_oku() : genel_sek_oku()
        guvenlik_oku() : gizli_oku() : icerik_oku()
        bag_oku() : prg_sek_oku() : gel_sek_oku()
    End Sub


    '*****------//// PROGRAM EKLE KALDIR TABI****------////


    '/////Program Deðiþtir Veya Kaldýr Sayfasýný Gizle deger yaz
    Private Sub prg_deg_kal_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prg_deg_kal_chk.CheckedChanged
        If prg_deg_kal_chk.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
            "NoRemovePage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
            "NoRemovePage", 0)
        End If
    End Sub
    '+++++Program Deðiþtir Veya Kaldýr Sayfasýný Gizle deger oku
    Private Sub prg_deg_oku()
        Dim prgoku As Object
        prgoku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
 "NoRemovePage", Nothing)
        If prgoku = 1 Then
            prg_deg_kal_chk.Checked = True
        Else
            prg_deg_kal_chk.Checked = False
        End If
    End Sub


    '////////////Yeni Program Ekle Sayfasýný Gizle deger yaz
    Private Sub yeni_prg_Chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yeni_prg_Chk.CheckedChanged
        If yeni_prg_Chk.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
    "NoAddPage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
             "NoAddPage", 0)
        End If
    End Sub

    '+++++++++++Yeni Program Ekle Sayfasýný Gizle deger oku
    Private Sub yeni_prg_oku()
        Dim prg As Object
        prg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
    "NoAddPage", Nothing)
        If prg = 1 Then
            yeni_prg_Chk.Checked = True
        Else
            yeni_prg_Chk.Checked = False
        End If
    End Sub

    '///////////////////Windows Bileþenlerini Ekle Veya Kaldýrý Gizle deger yaz
    Private Sub win_bil_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles win_bil_chk.CheckedChanged
        If win_bil_chk.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
           "NoWindowsSetupPage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
        "NoWindowsSetupPage", 0)
        End If
    End Sub

    '+++++++++++Windows Bileþenlerini Ekle Veya Kaldýrý Gizle deger oku
    Private Sub win_bil_oku()
        Dim bil As Object
        bil = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
        "NoWindowsSetupPage", Nothing)
        If bil = 1 Then
            win_bil_chk.Checked = True
        Else
            win_bil_chk.Checked = False
        End If
    End Sub


    '///////////Program Eriþimi ve Varsayýlanlarý Ayarla Sayfasýný Gizle deger yaz
    Private Sub prg_eri_var_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prg_eri_var_check.CheckedChanged
        If prg_eri_var_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
         "NoChooseProgramsPage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
         "NoChooseProgramsPage", 0)
        End If
    End Sub
    '++++++++++Program Eriþimi ve Varsayýlanlarý Ayarla Sayfasýný Gizle deger oku
    Private Sub prg_eri_var_oku()
        Dim prg As Object
        prg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
         "NoChooseProgramsPage", Nothing)
        If prg = 1 Then
            prg_eri_var_check.Checked = True
        Else
            prg_eri_var_check.Checked = False
        End If
    End Sub


    ' Program Ekle Kaldýrý Aç
    Private Sub prg_ekle_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prg_ekle_Button.Click
        'bu yöntem exe çalýþtýrýr
        'bu yöntem exe ve diðer dosya larýda çalýþtýrabilir
        On Error Resume Next
        Dim NewProcess As Process = New Process
        Process.Start(System.Environment.SystemDirectory + "\appwiz.cpl") 'her bilgisayrda sistem yolu farklý olabilir onun için sistem yolu bulma kullanýlýr
        If Err.Number = 5 Then
            MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
        End If
    End Sub



    '*****------//// GÖRÜNÜM TABI****------////


    '////// Temalar Sekmesini Gizle deger yaz
    Private Sub tema_sek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tema_sek.CheckedChanged
        If tema_sek.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoThemesTab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoThemesTab", 0)
        End If
    End Sub

    '+++++ Temalar Sekmesini Gizle deger oku
    Private Sub tema_sek_oku()
        Dim tema As Object
        tema = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoThemesTab", Nothing)
        If tema = 1 Then
            tema_sek.Checked = True
        Else
            tema_sek.Checked = False
        End If
    End Sub

    '////////////Masaüstü Sekmesini Gizle deger yaz
    Private Sub masa_ust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles masa_ust.CheckedChanged
        If masa_ust.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
"NoDispBackgroundPage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
   "NoDispBackgroundPage", 0)
        End If
    End Sub
    '++++++++Masaüstü Sekmesini Gizle deger oku
    Private Sub masa_ust_oku()
        Dim masa As Object
        masa = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
   "NoDispBackgroundPage", Nothing)
        If masa = 1 Then
            masa_ust.Checked = True
        Else
            masa_ust.Checked = False
        End If
    End Sub
    '////// Ekran Koruyucu Sekmesini Gizle deðer yaz
    Private Sub Screen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Screen.CheckedChanged
        If Screen.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
           "NoDispScrSavPage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
         "NoDispScrSavPage", 0)
        End If
    End Sub
    '++++++ Ekran Koruyucu Sekmesini Gizle deðer oku
    Private Sub ekran_oku()
        Dim ekran As Object
        ekran = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
         "NoDispScrSavPage", Nothing)
        If ekran = 1 Then
            Screen.Checked = True
        Else
            Screen.Checked = False
        End If
    End Sub


    '/////////////Görünüm Sekmesini Gizle deger yaz
    Private Sub gorunum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gorunum.CheckedChanged
        If gorunum.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
        "NoDispAppearancePage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
        "NoDispAppearancePage", 0)
        End If
    End Sub
    '++++++++++Görünüm Sekmesini Gizle deger oku
    Private Sub gorunum_oku()
        Dim gor As Object
        gor = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
        "NoDispAppearancePage", Nothing)
        If gor = 1 Then
            gorunum.Checked = True
        Else
            gorunum.Checked = False
        End If
    End Sub


    '//////////// Ayarlar Sekmesini Gizle deger yaz 
    Private Sub Ayarlar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ayarlar.CheckedChanged
        If Ayarlar.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "NoDispSettingsPage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
        "NoDispSettingsPage", 0)
        End If
    End Sub
    '+++++++++ Ayarlar Sekmesini Gizle deger oku 
    Private Sub ayarlar_oku()
        Dim ayar As Object
        ayar = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
        "NoDispSettingsPage", Nothing)
        If ayar = 1 Then
            Ayarlar.Checked = True
        Else
            Ayarlar.Checked = False
        End If
    End Sub

    '//////Görünüm Sekmesini Aç    butonu 
    Private Sub gor_sek_ac_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gor_sek_ac_but.Click
        On Error Resume Next
        Dim NewProcess As Process = New Process
        Process.Start(System.Environment.SystemDirectory + "\desk.cpl") 'her bilgisayrda sistem yolu farklý olabilir onun için sistem yolu bulma kullanýlýr
        If Err.Number = 5 Then
            MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
        End If
    End Sub


    '*****------////internet secenekleri TABI****------////

    '/////////////Genel Sekmesini Gizle deger yaz
    Private Sub genel_sek_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genel_sek_check.CheckedChanged
        If genel_sek_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
"GeneralTab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "GeneralTab", 0)
        End If
    End Sub
    '+++++++++++++++Genel Sekmesini Gizle deger oku
    Private Sub genel_sek_oku()
        Dim gen As Object
        gen = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "GeneralTab", Nothing)
        If gen = 1 Then
            genel_sek_check.Checked = True
        Else
            genel_sek_check.Checked = False
        End If
    End Sub


    '///////////////Güvenlik Sekmesini Gizle deger yaz
    Private Sub gvenlik_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvenlik_check.CheckedChanged
        If gvenlik_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
    "SecurityTab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "SecurityTab", 0)
        End If
    End Sub
    '++++++++++++Güvenlik Sekmesini Gizle deger oku
    Private Sub guvenlik_oku()
        Dim guv As Object
        guv = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "SecurityTab", Nothing)
        If guv = 1 Then
            gvenlik_check.Checked = True
        Else
            gvenlik_check.Checked = False
        End If
    End Sub
    '///////// Gizlilik Sekmesini Gizle deger yaz
    Private Sub gizlilik_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gizlilik_check.CheckedChanged
        If gizlilik_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
    "Privacytab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "Privacytab", 0)
        End If
    End Sub
    '+++++++++ Gizlilik Sekmesini Gizle deger oku
    Private Sub gizli_oku()
        Dim gizli As Object
        gizli = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "Privacytab", Nothing)
        If gizli = 1 Then
            gizlilik_check.Checked = True
        Else
            gizlilik_check.Checked = False
        End If
    End Sub
    '/////////// Ýçerik Sekmesini Gizle deger yaz
    Private Sub icerik_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles icerik_check.CheckedChanged
        If icerik_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
        "ContentTab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "ContentTab", 0)
        End If
    End Sub
    '++++++++ Ýçerik Sekmesini Gizle deger oku
    Private Sub icerik_oku()
        Dim icer As Object
        icer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "ContentTab", Nothing)
        If icer Then
            icerik_check.Checked = True
        Else
            icerik_check.Checked = False
        End If

    End Sub
    '////////// Baðlantýlar Sekmesini Gizle deger yaz
    Private Sub bag_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bag_check.CheckedChanged
        If bag_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
     "ConnectionsTab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "ConnectionsTab", 0)
        End If
    End Sub
    '++++++++Baðlantýlar Sekmesini Gizle deger oku
    Private Sub bag_oku()
        Dim bag As Object
        bag = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "ConnectionsTab", Nothing)
        If bag = 1 Then
            bag_check.Checked = True
        Else
            bag_check.Checked = False
        End If
    End Sub
    '/////////// Programlar Sekmesini Gizle deger yaz
    Private Sub programlar_sek_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles programlar_sek_check.CheckedChanged
        If programlar_sek_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
                "ProgramsTab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "ProgramsTab", 0)
        End If
    End Sub
    '++++++++++ Programlar Sekmesini Gizle deger oku
    Private Sub prg_sek_oku()
        Dim prg As Object
        prg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "ProgramsTab", Nothing)
        If prg = 1 Then
            programlar_sek_check.Checked = True
        Else
            programlar_sek_check.Checked = False
        End If

    End Sub

    '////////////////Geliþmiþ Sekmesini Gizle deger yaz
    Private Sub gelismis_sek_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gelismis_sek_check.CheckedChanged
        If gelismis_sek_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
                         "AdvancedTab", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "AdvancedTab", 0)
        End If
    End Sub
    '+++++++++++Geliþmiþ Sekmesini Gizle deger oku
    Private Sub gel_sek_oku()
        Dim gel As Object
        gel = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
       "AdvancedTab", Nothing)
        If gel = 1 Then
            gelismis_sek_check.Checked = True
        Else
            gelismis_sek_check.Checked = False
        End If
    End Sub



    'Ýnternet Özellikleri Sekmesini Aç   butonu
    Private Sub int_oze_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles int_oze_button.Click
        On Error Resume Next
        Dim process As Process = New Process
        Diagnostics.Process.Start(System.Environment.SystemDirectory + "\inetcpl.cpl")
        If Err.Number = 5 Then
            MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
        End If
    End Sub


End Class


