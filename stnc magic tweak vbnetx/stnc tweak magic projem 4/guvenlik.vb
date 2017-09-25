Public Class guvenlik_form


    Private Sub guvenlik_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        denetim_oku() : ie_oku() : klasor_oku() : gorev_yonet_oku()
        ger_don_oku() : msdos_oku() : regedit_oku() : reg_dos()
        bil_kapat_oku() : usb_sur() : ag_bag_oku() : prg_ekle_oku() : proxy_oku()
    End Sub


    '/////////////// Denetim Masasýna Eriþimi Yasakla deger yaz  

    Private Sub denetim_masa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles denetim_masa.CheckedChanged
        If denetim_masa.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
    "NoControlPanel", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
    "NoControlPanel", 0)
        End If
    End Sub
    '++++++++++++++ Denetim Masasýna Eriþimi Yasakla deger oku
    Private Sub denetim_oku()
        Dim dene As Object
        dene = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
    "NoControlPanel", Nothing)
        If dene = 1 Then
            denetim_masa.Checked = True
        Else
            denetim_masa.Checked = False
        End If
    End Sub

    '/////////////// ÝE Ana Sayfasýnýn Deðiþimini Engelle deger yaz  
    Private Sub ie_ana_sayfa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ie_ana_sayfa.CheckedChanged
        If ie_ana_sayfa.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
"HomePage", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
 "HomePage", 0)
        End If
    End Sub
    '++++++++++++++ ÝE Ana Sayfasýnýn Deðiþimini Engelle deger oku
    Private Sub ie_oku()
        Dim ie As Object
        ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
 "HomePage", Nothing)
        If ie = 1 Then
            ie_ana_sayfa.Checked = True
        Else
            ie_ana_sayfa.Checked = False
        End If
    End Sub
    '/////////////// Proxy Ayarlarýnýn Deðiþmesini Engelle deger yaz  

    Private Sub proxy_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proxy_CheckBox.CheckedChanged
        If proxy_CheckBox.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
 "proxy", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
"proxy", "0")
        End If
    End Sub

    '++++++++++++++ Proxy Ayarlarýnýn Deðiþmesini Engelle deger oku
    Private Sub proxy_oku()
        Dim proxys As Object
        proxys = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\control panel", _
"proxy", Nothing)
        If proxys = "0" Then
            proxy_CheckBox.Checked = True
        Else
            proxy_CheckBox.Checked = False
        End If
    End Sub

    '/////////////// Klasör Seçeneklerini Ýptal Et deger yaz  

    Private Sub aktif_desktop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aktif_desktop.CheckedChanged
        If aktif_desktop.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoFolderOptions", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoFolderOptions", 0)
        End If
    End Sub
    '++++++++++++++ Klasör Seçeneklerini Ýptal Et deger oku
    Private Sub klasor_oku()
        Dim klasor As Object
        klasor = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoFolderOptions", Nothing)
        If klasor = 1 Then
            aktif_desktop.Checked = True
        Else
            aktif_desktop.Checked = False
        End If
    End Sub
    '/////////////// Görev Yöneticisini Kullanýlmaz Hale Getir deger yaz  

    Private Sub gorev_yonetici_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gorev_yonetici.CheckedChanged
        If gorev_yonetici.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_USERS\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "DisableTaskMgr", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_USERS\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
"DisableTaskMgr", 0)
        End If
    End Sub
    '++++++++++++++ Görev Yöneticisini Kullanýlmaz Hale Getir deger oku
    Private Sub gorev_yonet_oku()
        Dim gorev As Object
        gorev = My.Computer.Registry.GetValue("HKEY_USERS\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
"DisableTaskMgr", Nothing)
        If gorev = 1 Then
            gorev_yonetici.Checked = True
        Else
            gorev_yonetici.Checked = False
        End If
    End Sub
    '/////////////// Geri Dönüþüm Kutusunu Özelikler Simgesini Gizle deger yaz  

    Private Sub geri_don_kutu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles geri_don_kutu.CheckedChanged
        If geri_don_kutu.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoPropertiesRecycleBin", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
          "NoPropertiesRecycleBin", 0)
        End If
    End Sub
    '++++++++++++++ Geri Dönüþüm Kutusunu Özelikler Simgesini Gizle deger oku
    Private Sub ger_don_oku()
        Dim geri As Object
        geri = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
          "NoPropertiesRecycleBin", Nothing)
        If geri = 1 Then
            geri_don_kutu.Checked = True
        Else
            geri_don_kutu.Checked = False
        End If
    End Sub
    '/////////////// Ms-Dos Command Arabirimine Ulaþýmý Engelle deger yaz  
    Private Sub ms_dos_arabirim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ms_dos_arabirim.CheckedChanged
        If ms_dos_arabirim.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\WinOldApp", _
            "Disabled", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\WinOldApp", _
         "Disabled", 0)
        End If
    End Sub
    '++++++++++++++ Ms-Dos Command Arabirimine Ulaþýmý Engelle deger oku
    Private Sub msdos_oku()
        Dim msd As Object
        msd = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\WinOldApp", _
         "Disabled", Nothing)
        If msd = 1 Then
            ms_dos_arabirim.Checked = True
        Else
            ms_dos_arabirim.Checked = False
        End If
    End Sub
    '/////////////// Registy Araçlarýnýn Registy Ulaþmasýný Engelle (Regedit.exe) deger yaz  
    Private Sub regedit_yasak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regedit_yasak.CheckedChanged
        If regedit_yasak.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
            "DisableRegistryTools", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
        "DisableRegistryTools", 0)
        End If
    End Sub
    '++++++++++++++ Registy Araçlarýnýn Registy Ulaþmasýný Engelle (Regedit.exe) deger oku
    Private Sub regedit_oku()
        Dim reg As Object
        reg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", _
        "DisableRegistryTools", Nothing)
        If reg = 1 Then
            regedit_yasak.Checked = True
        Else
            regedit_yasak.Checked = False
        End If
    End Sub

    '/////////////// Registry Dosyalarýný Dýþarý Verilmesini Engelle deger yaz  
    Private Sub reg_dos_dis_verme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_dos_dis_verme.CheckedChanged
        If reg_dos_dis_verme.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\.reg", "", "txtfile")
        Else
            My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\.reg", "", "regfile")
        End If
    End Sub
    '++++++++++++++ Registry Dosyalarýný Dýþarý Verilmesini Engelle deger oku
    Private Sub reg_dos()
        Dim reg As Object
        reg = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\.reg", "", Nothing)
        If reg = "txtfile" Then
            reg_dos_dis_verme.Checked = True
        Else
            reg_dos_dis_verme.Checked = False
        End If
    End Sub


    '/////////////// Bilgisayarý Kapat Simgesini Gizle deger yaz  
    Private Sub bil_kapat_sim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bil_kapat_sim.CheckedChanged
        If bil_kapat_sim.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoClose", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
"NoClose", 0)
        End If
    End Sub
    '++++++++++++++ Bilgisayarý Kapat Simgesini Gizle deger oku
    Private Sub bil_kapat_oku()
        Dim bil As Object
        bil = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
"NoClose", Nothing)
        If bil = 1 Then
            bil_kapat_sim.Checked = True
        Else
            bil_kapat_sim.Checked = False
        End If
    End Sub

    '/////////////// Usb Sürücülerine Eriþimi Engelle deger yaz  
    Private Sub usb_sur_gizle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usb_sur_gizle.CheckedChanged
        If usb_sur_gizle.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", _
            "Type", 4)
        Else
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", _
          "Type", 3)
        End If
    End Sub
    '++++++++++++++ Usb Sürücülerine Eriþimi Engelle deger oku
    Private Sub usb_sur()
        Dim usb As Object
        usb = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", _
          "Type", Nothing)
        If usb = 4 Then
            usb_sur_gizle.Checked = True
        ElseIf usb = 3 Then
            usb_sur_gizle.Checked = False
        End If
    End Sub



    '/////////////// Að Baðlantýlarým Ýconunu Gizle deger yaz  

    Private Sub ag_baglantilarim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ag_baglantilarim.CheckedChanged
        If ag_baglantilarim.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoNetHood", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
          "NoNetHood", 0)
        End If
    End Sub
    '++++++++++++++ Að Baðlantýlarým Ýconunu Gizle deger oku
    Private Sub ag_bag_oku()
        Dim ag As Object
        ag = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
          "NoNetHood", Nothing)
        If ag = 1 Then
            ag_baglantilarim.Checked = True
        Else
            ag_baglantilarim.Checked = False
        End If
    End Sub



    '/////////////// Program Ekle Kaldýr Olmasýn deger yaz  
    Private Sub prg_ekle_kaldir_olmasin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prg_ekle_kaldir_olmasin.CheckedChanged
        If prg_ekle_kaldir_olmasin.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
            "NoAddRemovePrograms", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
         "NoAddRemovePrograms", 0)
        End If
    End Sub
    '++++++++++++++ Program Ekle Kaldýr Olmasýn deger oku
    Private Sub prg_ekle_oku()
        Dim prg As Object
        prg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall", _
         "NoAddRemovePrograms", Nothing)
        If prg = 1 Then
            prg_ekle_kaldir_olmasin.Checked = True
        Else
            prg_ekle_kaldir_olmasin.Checked = False
        End If
    End Sub




End Class