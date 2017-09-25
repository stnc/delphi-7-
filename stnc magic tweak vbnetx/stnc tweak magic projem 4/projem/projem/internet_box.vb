Public Class internet_box
    Private Sub internet_box_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        baslik_yazi_oku() : int_exp_oku()
        oto_res_oku() : ie_dos_oku()
        ie_ozel_oku() : ie_cik_oku()
        web_sit_oku() : ie_sag_oku()
        no_mnu_oku() : d_yeni_oku()
        d_ac_oku() : farkli_oku() : ara_oku()

    End Sub

    '+---++++*******GENEL TABI ***---//+++++++

    '+++++++Ýnternet Explorer'ýn Üst Barýnda Bulunmasýný Ýstediðiniz Ýsmi Yazýnýz deger oku
    Private Sub baslik_yazi_oku()
        baslik_yazi_TextBox.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
        "Window title", "")
    End Sub


    Private Sub sil_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sil_Button.Click
        baslik_yazi_TextBox.Clear()
    End Sub
    '///////////Varsayýlan Arama Motoru Olarak Google Kullan deger yaz
    Private Sub var_arama_mot_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles var_arama_mot_CheckBox.CheckedChanged
        If var_arama_mot_CheckBox.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                  "Window title", "www.google.com")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                             "Window title", " ")
        End If
    End Sub

    '///////////Ýnternet Explorerýn Otomatik Update Yapmasýný Engelle deger yaz
    Private Sub int_exp_oto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles int_exp_oto.CheckedChanged
        If int_exp_oto.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
     "NoUpdateCheck", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
              "NoUpdateCheck", 0)
        End If
    End Sub
    '++++++++++++Ýnternet Explorerýn Otomatik Update Yapmasýný Engelle deger oku
    Private Sub int_exp_oku()
        Dim int As Object
        int = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
     "NoUpdateCheck", Nothing)
        If int = 1 Then
            int_exp_oto.Checked = True
        Else
            int_exp_oto.Checked = False
        End If
    End Sub

    '//////////////Otomatik Resim Boyutlandýrmayý Ýptal Et degr yaz
    Private Sub oto_res_boy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oto_res_boy.CheckedChanged
        If oto_res_boy.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                "Enable AutoImageResize", "yes")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                            "Enable AutoImageResize", "no")
        End If
    End Sub
    '+++++++++++++Otomatik Resim Boyutlandýrmayý Ýptal Et degr oku

    Private Sub oto_res_oku()
        Dim oto As Object
        oto = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
        "Enable AutoImageResize", Nothing)
        If oto = "yes" Then
            oto_res_boy.Checked = True
        Else
            oto_res_boy.Checked = False
        End If
    End Sub





    '*************---------------++++kýsýtlayýcý yaralar tabý---------"""""

    '////////////////// Ýnternet Explorer'ýn Dosya Ýndirme Özelliðini Devre Dýþý Býrak deger yaz

    Private Sub ie_dos_ind_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ie_dos_ind.CheckedChanged
        If ie_dos_ind.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", _
            "1803", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", _
            "1803", 0)
        End If
    End Sub
    '+++++++++++++++++++Ýnternet Explorer'ýn Dosya Ýndirme Özelliðini Devre Dýþý Býrak deger oku
    Private Sub ie_dos_oku()
        Dim ie As Object
        ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", _
            "1803", Nothing)
        If ie = 1 Then
            ie_dos_ind.Checked = True
        Else
            ie_dos_ind.Checked = False
        End If
    End Sub
    '////////////////Ýnternet Explorer Toolbar Özelleþtirillme Özelliðini Devre Dýþý Býrak deger yaz

    Private Sub ie_ozel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ie_ozel.CheckedChanged
        If ie_ozel.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoToolbarCustomize", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
 "NoToolbarCustomize", 0)
        End If
    End Sub
    '++++++++++++++++ Ýnternet Explorer Toolbar Özelleþtirillme Özelliðini Devre Dýþý Býrak deger oku
    Private Sub ie_ozel_oku()
        Dim ie As Object
        ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
 "NoToolbarCustomize", Nothing)
        If ie = 1 Then
            ie_ozel.Checked = True
        Else
            ie_ozel.Checked = False
        End If
    End Sub
    '//////////////Ýnternet Exlorer Çýkýþta Kapanma Özelliðini Devre Dýþý Býrak DEGER YAZ

    Private Sub ie_cik_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ie_cik.CheckedChanged
        If ie_cik.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoBrowserClose", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
        "NoBrowserClose", 0)
        End If
    End Sub
    '+++++++++++++++++++Ýnternet Exlorer Çýkýþta Kapanma Özelliðini Devre Dýþý Býrak DEGER OKU
    Private Sub ie_cik_oku()
        Dim ie As Object
        ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
        "NoBrowserClose", Nothing)
        If ie = 1 Then
            ie_cik.Checked = True
        Else
            ie_cik.Checked = False
        End If
    End Sub
    '///////Web Sitelerini Kaynak Dosyalarý Gösterilmesin deger yaz

    Private Sub web_sit_kaynak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web_sit_kaynak.CheckedChanged
        If web_sit_kaynak.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                    "NoViewSource", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                  "NoViewSource", 0)
        End If
    End Sub
    '+++++++Web Sitelerini Kaynak Dosyalarý Gösterilmesin deger oku
    Private Sub web_sit_oku()
        Dim web As Object
        web = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
        "NoViewSource", Nothing)
        If web = 1 Then
            web_sit_kaynak.Checked = True
        Else
            web_sit_kaynak.Checked = False
        End If
    End Sub


    '////////////Ýnternet Explorer'da Sað Týklamayla Gelen Ýçerik Menüsü Olmasýn deger yaz 

    Private Sub ie_sag_tik_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ie_sag_tik.CheckedChanged
        If ie_sag_tik.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                             "NoBrowserContextMenu", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                 "NoBrowserContextMenu", 0)
        End If
    End Sub
    ' ++++++++++++++++Ýnternet Explorer'da Sað Týklamayla Gelen Ýçerik Menüsü Olmasýn deger oku
    Private Sub ie_sag_oku()
        Dim ie As Object
        ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                             "NoBrowserContextMenu", Nothing)
        If ie = 1 Then
            ie_sag_tik.Checked = True
        Else
            ie_sag_tik.Checked = False
        End If
    End Sub
    '////////////Menüleri Kaldýr deger yaz 

    Private Sub no_mnu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_mnu.CheckedChanged
        If no_mnu.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoFileMenu", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoFileMenu", 0)
        End If
    End Sub
    '++++++++++++Menüleri Kaldýr deger oku
    Private Sub no_mnu_oku()
        Dim mnu As Object
        mnu = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoFileMenu", Nothing)
        If mnu = 1 Then
            no_mnu.Checked = True
        Else
            no_mnu.Checked = False
        End If
    End Sub
    '/////////////////Dosya -> Yeni Pencere Aç Engelle yaz
    Private Sub D_yeni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_yeni.CheckedChanged
        If D_yeni.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoFileNew", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoFileNew", 0)
        End If
    End Sub
    '++++++++++++++++++Dosya -> Yeni Pencere Aç Engelle oku
    Private Sub d_yeni_oku()
        Dim yeni As Object
        yeni = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoFileNew", Nothing)
        If yeni = 1 Then
            D_yeni.Checked = True
        Else
            D_yeni.Checked = False
        End If
    End Sub
    '/////////////////Dosya -> Aç Menüsünü Ýptal Et yaz

    Private Sub d_ac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_ac.CheckedChanged
        If d_ac.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
             "NoFileOpen", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoFileOpen", 0)
        End If
    End Sub
    '++++++++++++++++++Dosya -> Aç Menüsünü Ýptal Et oku
    Private Sub d_ac_oku()
        Dim ac As Object
        ac = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoFileOpen", Nothing)
        If ac = 1 Then
            d_ac.Checked = True
        Else
            d_ac.Checked = False
        End If

    End Sub
    '/////////////Dosya -> Farklý Kaydet i Ýptal Et yaz

    Private Sub d_fark_kay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_fark_kay.CheckedChanged
        If d_fark_kay.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
        "NoBrowserSaveAs", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
        "NoBrowserSaveAs", 0)
        End If
    End Sub
    '+++++++++++Dosya -> Farklý Kaydet i Ýptal Et oku
    Private Sub farkli_oku()
        Dim fr As Object
        fr = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
        "NoBrowserSaveAs", Nothing)
        If fr = 1 Then
            d_fark_kay.Checked = True
        Else
            d_fark_kay.Checked = False
        End If
    End Sub

    '////////////Araçlar -> Ýnternet Ayarlar Kullanýlmaz Hale Getir yaz

    Private Sub ara_int_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ara_int.CheckedChanged
        If ara_int.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
           "NoBrowserOptions", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
           "NoBrowserOptions", 0)
        End If
    End Sub

    '++++++++++++Araçlar -> Ýnternet Ayarlar Kullanýlmaz Hale Getir oku
    Private Sub ara_oku()
        Dim ara As Object
        ara = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
           "NoBrowserOptions", Nothing)
        If ara = 1 Then
            ara_int.Checked = True
        Else
            ara_int.Checked = False
        End If
    End Sub

 
    Private Sub int_oze_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim process As Process = New Process
        Diagnostics.Process.Start(System.Environment.SystemDirectory + "\inetcpl.cpl")
        If Err.Number = 5 Then
            MsgBox(" Belirtilen Program Bulunamadý", MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Hata")
        End If
    End Sub
End Class