Module internet
    ' Public Class internet_box
    Sub internet_box_Load()
        baslik_yazi_oku() : int_exp_oku()
        oto_res_oku() : ie_dos_oku()
        ie_ozel_oku() : ie_cik_oku()
        web_sit_oku() : ie_sag_oku()
        no_mnu_oku() : d_yeni_oku()
        d_ac_oku() : farkli_oku() : ara_oku()

    End Sub

    '+---++++*******GENEL TABI ***---//+++++++

    '+++++++Ýnternet Explorer'ýn Üst Barýnda Bulunmasýný Ýstediðiniz Ýsmi Yazýnýz deger oku
    Sub baslik_yazi_oku()
        With Index
            .baslik_yazi_TextBox.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
            "Window title", "")
        End With
    End Sub

    Sub sil()
        With Index
            .baslik_yazi_TextBox.Clear()
        End With
    End Sub


    '///////////Varsayýlan Arama Motoru Olarak Google Kullan deger yaz
    Sub var_arama_mot_CheckBox_CheckedChanged()
        With Index
            If .var_arama_mot_CheckBox.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                      "Window title", "www.google.com")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                                 "Window title", " ")
            End If
        End With
    End Sub

    '///////////Ýnternet Explorerýn Otomatik Update Yapmasýný Engelle deger yaz
    Sub int_exp_oto_CheckedChanged()
        With Index
            If .int_exp_oto.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
         "NoUpdateCheck", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                  "NoUpdateCheck", 0)
            End If
        End With
    End Sub
    '++++++++++++Ýnternet Explorerýn Otomatik Update Yapmasýný Engelle deger oku
    Sub int_exp_oku()
        With Index
            Dim int As Object
            int = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
         "NoUpdateCheck", Nothing)
            If int = 1 Then
                .int_exp_oto.Checked = True
            Else
                .int_exp_oto.Checked = False
            End If
        End With
    End Sub

    '//////////////Otomatik Resim Boyutlandýrmayý Ýptal Et degr yaz
    Sub oto_res_boy_CheckedChanged()
        With Index
            If .oto_res_boy.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                    "Enable AutoImageResize", "yes")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
                                "Enable AutoImageResize", "no")
            End If
        End With
    End Sub
    '+++++++++++++Otomatik Resim Boyutlandýrmayý Ýptal Et degr oku

    Sub oto_res_oku()
        With Index
            Dim oto As Object
            oto = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main", _
            "Enable AutoImageResize", Nothing)
            If oto = "yes" Then
                .oto_res_boy.Checked = True
            Else
                .oto_res_boy.Checked = False
            End If
        End With
    End Sub





    '*************---------------++++kýsýtlayýcý yaralar tabý---------"""""

    '////////////////// Ýnternet Explorer'ýn Dosya Ýndirme Özelliðini Devre Dýþý Býrak deger yaz

    Sub ie_dos_ind_CheckedChanged()
        With Index
            If .ie_dos_ind.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", _
                "1803", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", _
                "1803", 0)
            End If
        End With
    End Sub
    '+++++++++++++++++++Ýnternet Explorer'ýn Dosya Ýndirme Özelliðini Devre Dýþý Býrak deger oku
    Sub ie_dos_oku()
        With Index
            Dim ie As Object
            ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", _
                "1803", Nothing)
            If ie = 1 Then
                .ie_dos_ind.Checked = True
            Else
                .ie_dos_ind.Checked = False
            End If
        End With
    End Sub
    '////////////////Ýnternet Explorer Toolbar Özelleþtirillme Özelliðini Devre Dýþý Býrak deger yaz

    Sub ie_ozel_CheckedChanged()
        With Index
            If .ie_ozel.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoToolbarCustomize", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
     "NoToolbarCustomize", 0)
            End If
        End With
    End Sub
    '++++++++++++++++ Ýnternet Explorer Toolbar Özelleþtirillme Özelliðini Devre Dýþý Býrak deger oku
    Sub ie_ozel_oku()
        With Index
            Dim ie As Object
            ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
     "NoToolbarCustomize", Nothing)
            If ie = 1 Then
                .ie_ozel.Checked = True
            Else
                .ie_ozel.Checked = False
            End If
        End With
    End Sub
    '//////////////Ýnternet Exlorer Çýkýþta Kapanma Özelliðini Devre Dýþý Býrak DEGER YAZ

    Sub ie_cik_CheckedChanged()
        With Index
            If .ie_cik.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                "NoBrowserClose", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoBrowserClose", 0)
            End If
        End With
    End Sub
    '+++++++++++++++++++Ýnternet Exlorer Çýkýþta Kapanma Özelliðini Devre Dýþý Býrak DEGER OKU
    Sub ie_cik_oku()
        With Index
            Dim ie As Object
            ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoBrowserClose", Nothing)
            If ie = 1 Then
                .ie_cik.Checked = True
            Else
                .ie_cik.Checked = False
            End If
        End With
    End Sub
    '///////Web Sitelerini Kaynak Dosyalarý Gösterilmesin deger yaz

    Sub web_sit_kaynak_CheckedChanged()
        With Index
            If .web_sit_kaynak.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                        "NoViewSource", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                      "NoViewSource", 0)
            End If
        End With
    End Sub
    '+++++++Web Sitelerini Kaynak Dosyalarý Gösterilmesin deger oku
    Sub web_sit_oku()
        With Index
            Dim web As Object
            web = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoViewSource", Nothing)
            If web = 1 Then
                .web_sit_kaynak.Checked = True
            Else
                .web_sit_kaynak.Checked = False
            End If
        End With
    End Sub


    '////////////Ýnternet Explorer'da Sað Týklamayla Gelen Ýçerik Menüsü Olmasýn deger yaz 

    Sub ie_sag_tik_CheckedChanged()
        With Index
            If .ie_sag_tik.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                                 "NoBrowserContextMenu", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                     "NoBrowserContextMenu", 0)
            End If
        End With
    End Sub
    ' ++++++++++++++++Ýnternet Explorer'da Sað Týklamayla Gelen Ýçerik Menüsü Olmasýn deger oku
    Sub ie_sag_oku()
        With Index
            Dim ie As Object
            ie = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                                 "NoBrowserContextMenu", Nothing)
            If ie = 1 Then
                .ie_sag_tik.Checked = True
            Else
                .ie_sag_tik.Checked = False
            End If
        End With
    End Sub
    '////////////Menüleri Kaldýr deger yaz 

    Sub no_mnu_CheckedChanged()
        With Index
            If .no_mnu.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoFileMenu", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoFileMenu", 0)
            End If
        End With
    End Sub
    '++++++++++++Menüleri Kaldýr deger oku
    Sub no_mnu_oku()
        With Index
            Dim mnu As Object
            mnu = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoFileMenu", Nothing)
            If mnu = 1 Then
                .no_mnu.Checked = True
            Else
                .no_mnu.Checked = False
            End If
        End With
    End Sub
    '/////////////////Dosya -> Yeni Pencere Aç Engelle yaz
    Sub D_yeni_CheckedChanged()
        With Index
            If .D_yeni.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                "NoFileNew", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                "NoFileNew", 0)
            End If
        End With
    End Sub
    '++++++++++++++++++Dosya -> Yeni Pencere Aç Engelle oku
    Sub d_yeni_oku()
        With Index
            Dim yeni As Object
            yeni = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                "NoFileNew", Nothing)
            If yeni = 1 Then
                .D_yeni.Checked = True
            Else
                .D_yeni.Checked = False
            End If
        End With
    End Sub
    '/////////////////Dosya -> Aç Menüsünü Ýptal Et yaz

    Sub d_ac_CheckedChanged()
        With Index
            If .d_ac.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                 "NoFileOpen", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                "NoFileOpen", 0)
            End If
        End With
    End Sub
    '++++++++++++++++++Dosya -> Aç Menüsünü Ýptal Et oku
    Sub d_ac_oku()
        With Index
            Dim ac As Object
            ac = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
                "NoFileOpen", Nothing)
            If ac = 1 Then
                .d_ac.Checked = True
            Else
                .d_ac.Checked = False
            End If
        End With
    End Sub
    '/////////////Dosya -> Farklý Kaydet i Ýptal Et yaz

    Sub d_fark_kay_CheckedChanged()
        With Index
            If .d_fark_kay.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoBrowserSaveAs", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoBrowserSaveAs", 0)
            End If
        End With
    End Sub
    '+++++++++++Dosya -> Farklý Kaydet i Ýptal Et oku
    Sub farkli_oku()
        With Index
            Dim fr As Object
            fr = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
            "NoBrowserSaveAs", Nothing)
            If fr = 1 Then
                .d_fark_kay.Checked = True
            Else
                .d_fark_kay.Checked = False
            End If
        End With
    End Sub

    '////////////Araçlar -> Ýnternet Ayarlar Kullanýlmaz Hale Getir yaz

    Sub ara_int_CheckedChanged()
        With Index
            If .ara_int.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
               "NoBrowserOptions", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
               "NoBrowserOptions", 0)
            End If
        End With
    End Sub

    '++++++++++++Araçlar -> Ýnternet Ayarlar Kullanýlmaz Hale Getir oku
    Private Sub ara_oku()
        With Index
            Dim ara As Object
            ara = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Internet Explorer\Restrictions", _
               "NoBrowserOptions", Nothing)
            If ara = 1 Then
                .ara_int.Checked = True
            Else
                .ara_int.Checked = False
            End If
        End With
    End Sub


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
