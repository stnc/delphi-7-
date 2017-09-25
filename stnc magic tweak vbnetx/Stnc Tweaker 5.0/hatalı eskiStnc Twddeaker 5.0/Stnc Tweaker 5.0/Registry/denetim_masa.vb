Module denetim_masa
    'Public Class denetim_masa
    '
    Sub denetim_masa_Load()
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
    Sub prg_deg_kal_chk_CheckedChanged()
        With Index
            If .prg_deg_kal_chk.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
                "NoRemovePage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
                "NoRemovePage", 0)
            End If
        End With
    End Sub
    '+++++Program Deðiþtir Veya Kaldýr Sayfasýný Gizle deger oku
    Sub prg_deg_oku()
        With Index
            Dim prgoku As Object
            prgoku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
     "NoRemovePage", Nothing)
            If prgoku = 1 Then
                .prg_deg_kal_chk.Checked = True
            Else
                .prg_deg_kal_chk.Checked = False
            End If
        End With
    End Sub


    '////////////Yeni Program Ekle Sayfasýný Gizle deger yaz
    Sub yeni_prg_Chk_CheckedChanged()
        With Index
            If .yeni_prg_Chk.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
        "NoAddPage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
                 "NoAddPage", 0)
            End If
        End With
    End Sub

    '+++++++++++Yeni Program Ekle Sayfasýný Gizle deger oku
    Sub yeni_prg_oku()
        With Index
            Dim prg As Object
            prg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
        "NoAddPage", Nothing)
            If prg = 1 Then
                .yeni_prg_Chk.Checked = True
            Else
                .yeni_prg_Chk.Checked = False
            End If
        End With
    End Sub

    '///////////////////Windows Bileþenlerini Ekle Veya Kaldýrý Gizle deger yaz
    Sub win_bil_chk_CheckedChanged()
        With Index
            If .win_bil_chk.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
               "NoWindowsSetupPage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
            "NoWindowsSetupPage", 0)
            End If
        End With
    End Sub

    '+++++++++++Windows Bileþenlerini Ekle Veya Kaldýrý Gizle deger oku
    Sub win_bil_oku()
        With Index
            Dim bil As Object
            bil = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
            "NoWindowsSetupPage", Nothing)
            If bil = 1 Then
                .win_bil_chk.Checked = True
            Else
                .win_bil_chk.Checked = False
            End If
        End With
    End Sub


    '///////////Program Eriþimi ve Varsayýlanlarý Ayarla Sayfasýný Gizle deger yaz
    Sub prg_eri_var_check_CheckedChanged()
        With Index
            If .prg_eri_var_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
             "NoChooseProgramsPage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
             "NoChooseProgramsPage", 0)
            End If
        End With
    End Sub
    '++++++++++Program Eriþimi ve Varsayýlanlarý Ayarla Sayfasýný Gizle deger oku
    Sub prg_eri_var_oku()
        With Index
            Dim prg As Object
            prg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
             "NoChooseProgramsPage", Nothing)
            If prg = 1 Then
                .prg_eri_var_check.Checked = True
            Else
                .prg_eri_var_check.Checked = False
            End If
        End With
    End Sub


    ' Program Ekle Kaldýrý Aç
    Sub prg_ekle_Button_Click()
        With Index
            'bu yöntem exe çalýþtýrýr
            'bu yöntem exe ve diðer dosya larýda çalýþtýrabilir
            On Error Resume Next
            Dim NewProcess As Process = New Process
            Process.Start(System.Environment.SystemDirectory + "\appwiz.cpl") 'her bilgisayrda sistem yolu farklý olabilir onun için sistem yolu bulma kullanýlýr
            If Err.Number = 5 Then
                MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
            End If
        End With
    End Sub



    '*****------//// GÖRÜNÜM TABI****------////


    '////// Temalar Sekmesini Gizle deger yaz
    Sub tema_sek_CheckedChanged()
        With Index
            If .tema_sek.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoThemesTab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoThemesTab", 0)
            End If
        End With
    End Sub

    '+++++ Temalar Sekmesini Gizle deger oku
    Sub tema_sek_oku()
        With Index
            Dim tema As Object
            tema = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoThemesTab", Nothing)
            If tema = 1 Then
                .tema_sek.Checked = True
            Else
                .tema_sek.Checked = False
            End If
        End With
    End Sub

    '////////////Masaüstü Sekmesini Gizle deger yaz
    Sub masa_ust_CheckedChanged()
        With Index
            If .masa_ust.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
    "NoDispBackgroundPage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
       "NoDispBackgroundPage", 0)
            End If
        End With
    End Sub
    '++++++++Masaüstü Sekmesini Gizle deger oku
    Sub masa_ust_oku()
        With Index
            Dim masa As Object
            masa = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
       "NoDispBackgroundPage", Nothing)
            If masa = 1 Then
                .masa_ust.Checked = True
            Else
                .masa_ust.Checked = False
            End If
        End With
    End Sub
    '////// Ekran Koruyucu Sekmesini Gizle deðer yaz
    Sub Screen_CheckedChanged()
        With Index
            If .Screen.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
               "NoDispScrSavPage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
             "NoDispScrSavPage", 0)
            End If
        End With
    End Sub
    '++++++ Ekran Koruyucu Sekmesini Gizle deðer oku
    Sub ekran_oku()
        With Index
            Dim ekran As Object
            ekran = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
             "NoDispScrSavPage", Nothing)
            If ekran = 1 Then
                .Screen.Checked = True
            Else
                .Screen.Checked = False
            End If
        End With
    End Sub


    '/////////////Görünüm Sekmesini Gizle deger yaz
    Sub gorunum_CheckedChanged()
        With Index
            If .gorunum.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "NoDispAppearancePage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "NoDispAppearancePage", 0)
            End If
        End With
    End Sub
    '++++++++++Görünüm Sekmesini Gizle deger oku
    Sub gorunum_oku()
        With Index
            Dim gor As Object
            gor = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "NoDispAppearancePage", Nothing)
            If gor = 1 Then
                .gorunum.Checked = True
            Else
                .gorunum.Checked = False
            End If
        End With
    End Sub


    '//////////// Ayarlar Sekmesini Gizle deger yaz 
    Sub Ayarlar_CheckedChanged()
        With Index
            If .Ayarlar.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
                "NoDispSettingsPage", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "NoDispSettingsPage", 0)
            End If
        End With
    End Sub
    '+++++++++ Ayarlar Sekmesini Gizle deger oku 
    Sub ayarlar_oku()
        With Index
            Dim ayar As Object
            ayar = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "NoDispSettingsPage", Nothing)
            If ayar = 1 Then
                .Ayarlar.Checked = True
            Else
                .Ayarlar.Checked = False
            End If
        End With
    End Sub

    '//////Görünüm Sekmesini Aç    butonu 
    Sub gor_sek_ac_but_Click()
        With Index
            On Error Resume Next
            Dim NewProcess As Process = New Process
            Process.Start(System.Environment.SystemDirectory + "\desk.cpl") 'her bilgisayrda sistem yolu farklý olabilir onun için sistem yolu bulma kullanýlýr
            If Err.Number = 5 Then
                MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
            End If
        End With
    End Sub


    '*****------////internet secenekleri TABI****------////

    '/////////////Genel Sekmesini Gizle deger yaz
    Sub genel_sek_check_CheckedChanged()
        With Index
            If .genel_sek_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
    "GeneralTab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "GeneralTab", 0)
            End If
        End With
    End Sub
    '+++++++++++++++Genel Sekmesini Gizle deger oku
    Sub genel_sek_oku()
        With Index
            Dim gen As Object
            gen = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "GeneralTab", Nothing)
            If gen = 1 Then
                .genel_sek_check.Checked = True
            Else
                .genel_sek_check.Checked = False
            End If
        End With
    End Sub


    '///////////////Güvenlik Sekmesini Gizle deger yaz
    Sub gvenlik_check_CheckedChanged()
        With Index
            If .gvenlik_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
        "SecurityTab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "SecurityTab", 0)
            End If
        End With
    End Sub
    '++++++++++++Güvenlik Sekmesini Gizle deger oku

    Sub guvenlik_oku()
        With Index
            Dim guv As Object
            guv = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "SecurityTab", Nothing)
            If guv = 1 Then
                .gvenlik_check.Checked = True
            Else
                .gvenlik_check.Checked = False
            End If
        End With
    End Sub
    '///////// Gizlilik Sekmesini Gizle deger yaz
    Sub gizlilik_check_CheckedChanged()
        With Index
            If .gizlilik_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
        "Privacytab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "Privacytab", 0)
            End If
        End With
    End Sub
    '+++++++++ Gizlilik Sekmesini Gizle deger oku
    Sub gizli_oku()
        With Index
            Dim gizli As Object
            gizli = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "Privacytab", Nothing)
            If gizli = 1 Then
                .gizlilik_check.Checked = True
            Else
                .gizlilik_check.Checked = False
            End If
        End With
    End Sub
    '/////////// Ýçerik Sekmesini Gizle deger yaz
    Sub icerik_check_CheckedChanged()
        With Index
            If .icerik_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
            "ContentTab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "ContentTab", 0)
            End If
        End With
    End Sub
    '++++++++ Ýçerik Sekmesini Gizle deger oku
    Sub icerik_oku()
        With Index
            Dim icer As Object
            icer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "ContentTab", Nothing)
            If icer Then
                .icerik_check.Checked = True
            Else
                .icerik_check.Checked = False
            End If
        End With
    End Sub
    '////////// Baðlantýlar Sekmesini Gizle deger yaz
    Sub bag_check_CheckedChanged()
        With Index
            If .bag_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
         "ConnectionsTab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "ConnectionsTab", 0)
            End If
        End With
    End Sub
    '++++++++Baðlantýlar Sekmesini Gizle deger oku
    Sub bag_oku()
        With Index
            Dim bag As Object
            bag = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "ConnectionsTab", Nothing)
            If bag = 1 Then
                .bag_check.Checked = True
            Else
                .bag_check.Checked = False
            End If
        End With
    End Sub
    '/////////// Programlar Sekmesini Gizle deger yaz
    Sub programlar_sek_check_CheckedChanged()
        With Index
            If .programlar_sek_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
                    "ProgramsTab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "ProgramsTab", 0)
            End If
        End With
    End Sub
    '++++++++++ Programlar Sekmesini Gizle deger oku
    Sub prg_sek_oku()
        With Index
            Dim prg As Object
            prg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "ProgramsTab", Nothing)
            If prg = 1 Then
                .programlar_sek_check.Checked = True
            Else
                .programlar_sek_check.Checked = False
            End If
        End With
    End Sub

    '////////////////Geliþmiþ Sekmesini Gizle deger yaz
    Sub gelismis_sek_check_CheckedChanged()
        With Index
            If .gelismis_sek_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
                             "AdvancedTab", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "AdvancedTab", 0)
            End If
        End With
    End Sub
    '+++++++++++Geliþmiþ Sekmesini Gizle deger oku
    Sub gel_sek_oku()
        With Index
            Dim gel As Object
            gel = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
           "AdvancedTab", Nothing)
            If gel = 1 Then
                .gelismis_sek_check.Checked = True
            Else
                .gelismis_sek_check.Checked = False
            End If
        End With
    End Sub



    'Ýnternet Özellikleri Sekmesini Aç   butonu
    Sub int_oze_button_Click()
        With Index
            On Error Resume Next
            Dim process As Process = New Process
            Diagnostics.Process.Start(System.Environment.SystemDirectory + "\inetcpl.cpl")
            If Err.Number = 5 Then
                MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
            End If
        End With
    End Sub


    'End Class



End Module
