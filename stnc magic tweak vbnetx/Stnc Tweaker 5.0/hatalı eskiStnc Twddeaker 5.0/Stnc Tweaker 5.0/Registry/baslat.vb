Module baslat
    ' Public Class baslat_mnu

    'formun yüklenirken okuyuacagý deðerler
    Sub baslat_mnu_Load()
        bel_bag_oku() 'belgelerim e ait olan degerleri okur ona göre iþaretleme yapar
        muzigim_deger_oku() 'müzigime e ait olan degerleri okur ona göre iþaretleme yapar
        gecmis_deger_oku() : bilgi_deger_oku() : resim_deger_okuyucu()
        denetim_masasi_oku()
        '*****checkbox lý kutularýn degerini okuma
        ag_bag_oku() : sik_kul_oku() : yard_desk()
        yazici_oku() : ara_deg_oku() : calistir_oku() : bil_kapat_oku()
        '*****checkbox lý kutularýn degerini bitiþ
        'tablarýn okuma ayarý
        baslat_menu_oku() : baslat_balon_oku() : gecmis_dos_oku()
        cik_gec_sil() : uygulama_listele() : benzer_gorev_oku()
        etkin_olmaya_oku()
    End Sub


    '/////////////BELGELERÝM//////////////////////////////
    Sub bel_bag_Radio_CheckedChanged()
        With Index
            If .bel_bag_Radio.Checked = True Then
                .bel_menu_RadioButton.Checked = False
                .bel_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowMyDocs", 1)
            End If
        End With
    End Sub
    Sub bel_menu_RadioButton_CheckedChanged()
        With Index
            If .bel_menu_RadioButton.Checked = True Then
                .bel_bag_Radio.Checked = False
                .bel_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                   "Start_ShowMyDocs", 2)
            End If
        End With
    End Sub

    Sub bel_no_RadioButton_CheckedChanged()
        With Index
            If .bel_no_RadioButton.Checked = True Then
                .bel_bag_Radio.Checked = False
                .bel_menu_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
       "Start_ShowMyDocs", 0)
            End If
        End With
    End Sub
    '+++++++++++++++++++BELGELERÝM deðer okuyucu++++++++++++
    Sub bel_bag_oku()
        With Index
            Dim belgeler_deger As Object  'veya Object  yerine integer kullanýn 
            belgeler_deger = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
               "Start_ShowMyDocs", Nothing)
            If belgeler_deger = 1 Then
                .bel_bag_Radio.Checked = True
                .bel_menu_RadioButton.Checked = False
                .bel_no_RadioButton.Checked = False
            ElseIf belgeler_deger = 2 Then
                .bel_menu_RadioButton.Checked = True
                .bel_bag_Radio.Checked = False
                .bel_no_RadioButton.Checked = False
            ElseIf belgeler_deger = 0 Then
                .bel_no_RadioButton.Checked = True
                .bel_bag_Radio.Checked = False
                .bel_menu_RadioButton.Checked = False
            End If
        End With
    End Sub '/////////////BELGELERÝM BÝTÝÞ//////////////////////////////


    '//////////////MÜZÝGÝM/////////////////////////
    Sub muzik_bag_RadioButton_CheckedChanged()
        With Index
            If .muzik_bag_RadioButton.Checked = True Then
                .muz_menu_RadioButton.Checked = False
                .muz_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                     "Start_ShowMyMusic", 1)

            End If
        End With
    End Sub

    Sub muz_menu_RadioButton_CheckedChanged()
        With Index
            If .muz_menu_RadioButton.Checked = True Then
                .muzik_bag_RadioButton.Checked = False
                .muz_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowMyMusic", 2)
            End If
        End With
    End Sub

    Sub muz_no_RadioButton_CheckedChanged()
        With Index
            If .muz_no_RadioButton.Checked = True Then
                .muzik_bag_RadioButton.Checked = False
                .muz_menu_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowMyMusic", 0)
            End If
        End With
    End Sub
    '++++++++++++++++müzigim deger okuyucu+++++++++
    Sub muzigim_deger_oku()
        With Index
            Dim muzigim_deger As Object
            muzigim_deger = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowMyMusic", Nothing)
            If muzigim_deger = 1 Then
                .muzik_bag_RadioButton.Checked = True
                .muz_menu_RadioButton.Checked = False
                .muz_no_RadioButton.Checked = False
            ElseIf muzigim_deger = 2 Then
                .muz_menu_RadioButton.Checked = True
                .muzik_bag_RadioButton.Checked = False
                .muz_no_RadioButton.Checked = False
            ElseIf muzigim_deger = 0 Then
                .muz_no_RadioButton.Checked = True
                .muzik_bag_RadioButton.Checked = False
                .muz_menu_RadioButton.Checked = False

            End If
        End With
    End Sub '//////////////MÜZÝGÝM BÝTÝÞ/////////////////////////



    '///////////////GEÇMÝÞ BELGELER//////////////////
    Sub gec_bag_RadioButton_CheckedChanged()
        With Index
            If .gec_bag_RadioButton.Checked = True Then
                .gec_menu_RadioButton.Checked = False
                .gecmis_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                    "Start_ShowRecentDocs", 1)
            End If
        End With
    End Sub

    Sub gec_menu_RadioButton_CheckedChanged()
        With Index
            If .gec_menu_RadioButton.Checked = True Then
                .gec_bag_RadioButton.Checked = False
                .gecmis_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
        "Start_ShowRecentDocs", 2)
            End If
        End With
    End Sub

    Sub gecmis_no_RadioButton_CheckedChanged()
        With Index
            If .gecmis_no_RadioButton.Checked = True Then
                .gec_bag_RadioButton.Checked = False
                .gec_menu_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
        "Start_ShowRecentDocs", 0)
            End If
        End With
    End Sub
    '++++++++++++gecmiþ deger okuyucu+++++++++++++++
    Sub gecmis_deger_oku()
        With Index
            Dim gecmis_deg As Object
            gecmis_deg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
        "Start_ShowRecentDocs", Nothing)
            If gecmis_deg = 1 Then
                .gec_bag_RadioButton.Checked = True
                .gec_menu_RadioButton.Checked = False
                .gecmis_no_RadioButton.Checked = False
            ElseIf gecmis_deg = 2 Then
                .gec_menu_RadioButton.Checked = True
                .gec_bag_RadioButton.Checked = False
                .gecmis_no_RadioButton.Checked = False
            ElseIf gecmis_deg = 0 Then
                .gecmis_no_RadioButton.Checked = True
                .gec_bag_RadioButton.Checked = False
                .gec_menu_RadioButton.Checked = False
            End If
        End With
    End Sub '///////////////GEÇMÝÞ BELGELER BÝTÝÞ//////////////////






    '////////////////////BÝLGÝSAYARIM ///////////////////
    Sub bilgisayarim_bag_CheckedChanged()

        With Index
            If .bilgisayarim_bag.Checked = True Then
                .bil_mnu_RadioButton.Checked = False
                .bil_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                   "Start_ShowMyComputer", 1)
            End If
        End With
    End Sub

    Sub bil_mnu_RadioButton_CheckedChanged()
        With Index
            If .bil_mnu_RadioButton.Checked = True Then
                .bilgisayarim_bag.Checked = False
                .bil_no_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                  "Start_ShowMyComputer", 2)

            End If
        End With
    End Sub

    Sub bil_no_RadioButton_CheckedChanged()
        With Index
            If .bil_no_RadioButton.Checked = True Then
                .bilgisayarim_bag.Checked = False
                .bil_mnu_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                  "Start_ShowMyComputer", 0)

            End If
        End With
    End Sub
    '++++ bilgisayarým bilgi okuyucu+++++++++++++++
    Sub bilgi_deger_oku()
        With Index
            Dim bilgi_deger As Object
            bilgi_deger = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                  "Start_ShowMyComputer", Nothing)
            If bilgi_deger = 1 Then
                .bilgisayarim_bag.Checked = True
                .bil_mnu_RadioButton.Checked = False
                .bil_no_RadioButton.Checked = False
            ElseIf bilgi_deger = 2 Then
                .bil_mnu_RadioButton.Checked = True
                .bilgisayarim_bag.Checked = False
                .bil_no_RadioButton.Checked = False

            ElseIf bilgi_deger = 2 Then
                .bil_no_RadioButton.Checked = True
                .bilgisayarim_bag.Checked = False
                .bil_mnu_RadioButton.Checked = False
            End If
        End With
    End Sub '////////////////////BÝLGÝSAYARIM BÝTÝÞ ///////////////////



    '////////////////////////RESÝMLER/////////////////////////

    Sub resimler_RadioButton_CheckedChanged()
        With Index
            If .resimler_RadioButton.Checked = True Then
                .resim_mnu_Button.Checked = False
                .resim_no_button.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                 "Start_ShowMyPics", 1)
            End If
        End With
    End Sub

    Sub resim_mnu_Button_CheckedChanged()
        With Index
            If .resim_mnu_Button.Checked = True Then
                .resimler_RadioButton.Checked = False
                .resim_no_button.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                 "Start_ShowMyPics", 2)
            End If
        End With
    End Sub

    Sub resim_no_button_CheckedChanged()
        With Index
            If .resim_no_button.Checked = True Then
                .resimler_RadioButton.Checked = False
                .resim_mnu_Button.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                 "Start_ShowMyPics", 0)
            End If
        End With
    End Sub
    '+++++++++++++++resimler deger okuyucu+++++++++++
    Sub resim_deger_okuyucu()
        With Index
            Dim res_deg_oku As Object
            res_deg_oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                 "Start_ShowMyPics", Nothing)
            If res_deg_oku = 1 Then
                .resimler_RadioButton.Checked = True
                .resim_mnu_Button.Checked = False
                .resim_no_button.Checked = False
            ElseIf res_deg_oku = 2 Then
                .resim_mnu_Button.Checked = True
                .resimler_RadioButton.Checked = False
                .resim_no_button.Checked = False
            ElseIf res_deg_oku = 0 Then
                .resim_no_button.Checked = True
                .resimler_RadioButton.Checked = False
                .resim_mnu_Button.Checked = False

            End If
        End With
    End Sub '////////////////////////RESÝMLER BÝTÝÞ/////////////////////////


    '//////////DENETÝM MASAI//////////
    Sub den_bag_RadioButton_CheckedChanged()

        With Index
            If .den_bag_RadioButton.Checked = True Then
                .den_menu_RadioButton.Checked = False
                .den_gosterme_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowControlPanel", 1)
            End If
        End With
    End Sub

    Sub den_menu_RadioButton_CheckedChanged()
        With Index
            If .den_menu_RadioButton.Checked = True Then
                .den_bag_RadioButton.Checked = False
                .den_gosterme_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowControlPanel", 2)
            End If
        End With
    End Sub

    Sub den_gosterme_RadioButton_CheckedChanged()
        With Index
            If .den_gosterme_RadioButton.Checked = True Then
                .den_bag_RadioButton.Checked = False
                .den_menu_RadioButton.Checked = False
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowControlPanel", 0)
            End If
        End With
    End Sub
    '+++++++++++denetim masasi deger okuyucu+++++++++++++
    Sub denetim_masasi_oku()
        With Index
            Dim den_deg As Object
            den_deg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowControlPanel", Nothing)
            If den_deg = 1 Then
                .den_bag_RadioButton.Checked = True
                .den_menu_RadioButton.Checked = False
                .den_gosterme_RadioButton.Checked = False
            ElseIf den_deg = 2 Then
                .den_menu_RadioButton.Checked = True
                .den_bag_RadioButton.Checked = False
                .den_gosterme_RadioButton.Checked = False
            ElseIf den_deg = 0 Then
                .den_gosterme_RadioButton.Checked = True
                .den_bag_RadioButton.Checked = False
                .den_menu_RadioButton.Checked = False
            End If
        End With
    End Sub '//////////DENETÝM MASAI BÝTÝÞ//////////



    '/////////////CHECK BOX LI KUTULAR////



    '///////ag baðlantýlarým deger kaydetici
    Sub ag_baglantýlarim_CheckedChanged()
        With Index
            If .ag_baglantýlarim.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                         "Start_ShowNetPlaces", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowNetPlaces", 0)
            End If
        End With
    End Sub
    '+++++að baðlantýlarým deger okuyucu
    Sub ag_bag_oku()
        With Index
            Dim ag As Object
            ag = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                         "Start_ShowNetPlaces", Nothing)
            If ag = 1 Then
                .ag_baglantýlarim.Checked = True
            Else
                .ag_baglantýlarim.Checked = False
            End If
        End With
    End Sub


    '/////sýk kullanýlanlar deger kaydetici
    Sub sik_kulanilan_CheckedChanged()
        With Index
            If .sik_kulanilan.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "StartMenuFavorites", 2)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "StartMenuFavorites", 1)
            End If
        End With
    End Sub
    '+++sýk kullanýlanlar deger okuyucu
    Sub sik_kul_oku()
        With Index
            Dim sik As Object
            sik = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "StartMenuFavorites", Nothing)
            If sik = 1 Then
                .sik_kulanilan.Checked = True
            Else
                .sik_kulanilan.Checked = False
            End If
        End With
    End Sub


    '//////yardim ve destek deger kaydet
    Sub yard_desktek_CheckedChanged()
        With Index
            If .yard_desktek.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
            "Start_ShowHelp", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowHelp", 0)
            End If
        End With
    End Sub
    '+++++++yardim ve destek deger okuyucu
    Sub yard_desk()
        With Index
            Dim yardim As Object
            yardim = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowHelp", Nothing)
            If yardim = 1 Then
                .yard_desktek.Checked = True
            Else
                .yard_desktek.Checked = False
            End If
        End With
    End Sub

    '/////yazici ve fakslar deger kaydet////
    Sub yazici_faks_CheckedChanged()
        With Index
            If .yazici_faks.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
            "Start_ShowPrinters", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowPrinters", 0)
            End If
        End With
    End Sub
    '++++++yazici ve fakslar deger oku
    Sub yazici_oku()
        With Index
            Dim yazici As Object
            yazici = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowPrinters", Nothing)
            If yazici = 1 Then
                .yazici_faks.Checked = True
            Else
                .yazici_faks.Checked = False
            End If
        End With
    End Sub


    '//////ara check ý deger yaz
    Sub Ara_CheckedChanged()
        With Index
            If .Ara.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                  "Start_ShowSearch", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowSearch", 0)
            End If
        End With
    End Sub
    '+++++++++ara deger oku
    Sub ara_deg_oku()
        With Index
            Dim ara_oku As Object
            ara_oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowSearch", Nothing)
            If ara_oku = 1 Then
                .Ara.Checked = True
            Else
                .Ara.Checked = False
            End If
        End With
    End Sub
    '////////////calistir deger yaz
    Sub Calistir_CheckedChanged()
        With Index
            If .Calistir.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                           "Start_ShowRun", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowRun", 0)
            End If
        End With
    End Sub
    '++++++++çalýþtýr deger oku
    Sub calistir_oku()
        With Index
            Dim cal As Object
            cal = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowRun", Nothing)
            If cal = 1 Then
                .Calistir.Checked = True
            Else
                .Calistir.Checked = False
            End If
        End With
    End Sub


    '/////oturumu kapat deger yaz
    Sub oturumu_kapat_CheckedChanged()
        With Index
            If .oturumu_kapat.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
    "StartMenuLogoff", 0)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
              "StartMenuLogoff", 1)
            End If
        End With
    End Sub
    '++++++oturumu kapat deger oku
    Sub oturum_kapat()
        With Index
            Dim oturum As Object
            oturum = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
              "StartMenuLogoff", Nothing)
            If oturum = 0 Then
                .oturumu_kapat.Checked = True
            Else
                .oturumu_kapat.Checked = False
            End If
        End With
    End Sub




    '////////bil_kapat deger yaz
    Sub bil_kapat_CheckedChanged()
        With Index
            If .bil_kapat.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
    "NoClose", 0)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
              "NoClose", 1)
            End If
        End With
    End Sub
    '///bil kapat deger oku
    Sub bil_kapat_oku()
        With Index
            Dim bil As Object
            bil = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
     "NoClose", Nothing)
            If bil = 0 Then
                .bil_kapat.Checked = True
            Else
                .bil_kapat.Checked = False
            End If
        End With
    End Sub



    '***///--- baþalat menüsü ayarlarý tabý*****////------





    '///////Baþlat Menüsünün Ýçerigini Gösterme deger yaz
    Sub baslat_menu_icerik_CheckBox_CheckedChanged()
        With Index
            If .baslat_menu_icerik_CheckBox.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoChangeStartMenu", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                 "NoChangeStartMenu", 0)
            End If
        End With
    End Sub
    '++++++Baþlat Menüsünün Ýçerigini Gösterme deger oku
    Sub baslat_menu_oku()
        With Index
            Dim baslat As Object
            baslat = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                 "NoChangeStartMenu", Nothing)
            If baslat = 1 Then
                .baslat_menu_icerik_CheckBox.Checked = True
            Else
                .baslat_menu_icerik_CheckBox.Checked = False
            End If
        End With
    End Sub



    '//////////////Baþlat Menüsündeki Balon Tipi Uyarýlarý Gösterme deger yaz
    Sub baslat_menusu_balon_check_CheckedChanged()
        With Index
            If .baslat_menusu_balon_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "EnableBalloonTips", 0)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "EnableBalloonTips", 1)
            End If
        End With
    End Sub
    '++++++++++++++Baþlat Menüsündeki Balon Tipi Uyarýlarý Gösterme deger oku
    Sub baslat_balon_oku()
        With Index
            Dim balon As Object
            balon = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "EnableBalloonTips", Nothing)
            If balon = 0 Then
                .baslat_menusu_balon_check.Checked = True
            Else
                .baslat_menusu_balon_check.Checked = False
            End If
        End With
    End Sub

    '///////Geçmiþ Dosyalarý Listeleme dger yaz
    Sub gecmis_dosyalar_CheckedChanged()
        With Index
            If .gecmis_dosyalar.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoRecentDocsHistory", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoRecentDocsHistory", 0)
            End If
        End With
    End Sub
    '++++++Geçmiþ Dosyalarý Listeleme dger oku
    Sub gecmis_dos_oku()
        With Index
            Dim gec As Object
            gec = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoRecentDocsHistory", Nothing)
            If gec = 1 Then
                .gecmis_dosyalar.Checked = True
            Else
                .gecmis_dosyalar.Checked = False
            End If
        End With
    End Sub


    '///////Cýkýþda Geçmiþ Dosyalarý Sil   deger yaz
    Sub cikis_gecmis_sil_check_CheckedChanged()
        With Index
            If .cikis_gecmis_sil_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "ClearRecentDocsOnExit", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
             "ClearRecentDocsOnExit", 0)
            End If
        End With
    End Sub
    '++++++++Cýkýþda Geçmiþ Dosyalarý Sil   deger oku
    Sub cik_gec_sil()
        With Index
            Dim cik As Object
            cik = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
             "ClearRecentDocsOnExit", Nothing)
            If cik = 1 Then
                .cikis_gecmis_sil_check.Checked = True
            Else
                .cikis_gecmis_sil_check.Checked = False
            End If
        End With
    End Sub
    '///////Uygulamalarý Listeleme Etkin Olmasýn deger yaz
    Sub uygul_liste_check_CheckedChanged()
        With Index
            If .uygul_liste_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoStartMenuMFUprogramsList", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoStartMenuMFUprogramsList", 0)
            End If
        End With
    End Sub
    '+++++++++Uygulamalarý Listeleme Etkin Olmasýn deger oku
    Sub uygulama_listele()
        With Index
            Dim uygulama As Object
            uygulama = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoStartMenuMFUprogramsList", Nothing)
            If uygulama = 1 Then
                .uygul_liste_check.Checked = True
            Else
                .uygul_liste_check.Checked = False
            End If
        End With
    End Sub
    '/////////////////Benzer Görev Çubuðu Ögelerini Gizli deger yaz
    Sub benzer_gorev_CheckedChanged()
        With Index
            If .benzer_gorev.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "TaskbarGlomming", 0)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "TaskbarGlomming", 1)
            End If
        End With
    End Sub
    '++++++++++++Benzer Görev Çubuðu Ögelerini Gizli deger oku
    Sub benzer_gorev_oku()
        With Index
            Dim benzer As Object
            benzer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "TaskbarGlomming", Nothing)
            If benzer = 0 Then
                .benzer_gorev.Checked = True
            Else
                .benzer_gorev.Checked = False

            End If
        End With
    End Sub
    '/////////////////Etkin Olmayan Simgeleri Gizle deger yaz
    Sub etkin_olmayan_sim_check_CheckedChanged()
        With Index
            If .etkin_olmayan_sim_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", _
                "EnableAutoTray", 0)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", _
                "EnableAutoTray", 1)
            End If
        End With
    End Sub
    '++++++++++Etkin Olmayan Simgeleri Gizle deger oku
    Sub etkin_olmaya_oku()
        With Index
            Dim etkin As Object
            etkin = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", _
                "EnableAutoTray", Nothing)
            If etkin = 0 Then
                .etkin_olmayan_sim_check.Checked = True
            Else
                .etkin_olmayan_sim_check.Checked = False
            End If
        End With
    End Sub

    ' End Class


End Module
