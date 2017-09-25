Public Class baslat_mnu
    'formun yüklenirken okuyuacagý deðerler
    Private Sub baslat_mnu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bel_bag_oku() 'belgelerim e ait olan degerleri okur ona göre iþaretleme yapar
        muzigim_deger_oku() 'müzigime e ait olan degerleri okur ona göre iþaretleme yapar
        gecmis_deger_oku()
        bilgi_deger_oku()
        resim_deger_okuyucu()
        denetim_masasi_oku()
        '*****checkbox lý kutularýn degerini okuma
        ag_bag_oku()
        sik_kul_oku()
        yard_desk()
        yazici_oku()
        ara_deg_oku()
        calistir_oku()
        bil_kapat_oku()
        '*****checkbox lý kutularýn degerini bitiþ
        'tablarýn okuma ayarý
        baslat_menu_oku()
        baslat_balon_oku()
        gecmis_dos_oku()
        cik_gec_sil()
        uygulama_listele()
        benzer_gorev_oku()
        etkin_olmaya_oku()
    End Sub


    '/////////////BELGELERÝM//////////////////////////////
    Private Sub bel_bag_Radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bel_bag_Radio.CheckedChanged
        If bel_bag_Radio.Checked = True Then
            bel_menu_RadioButton.Checked = False
            bel_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
     "Start_ShowMyDocs", 1)
        End If
    End Sub
    Private Sub bel_menu_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bel_menu_RadioButton.CheckedChanged
        If bel_menu_RadioButton.Checked = True Then
            bel_bag_Radio.Checked = False
            bel_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
               "Start_ShowMyDocs", 2)
        End If
    End Sub

    Private Sub bel_no_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bel_no_RadioButton.CheckedChanged
        If bel_no_RadioButton.Checked = True Then
            bel_bag_Radio.Checked = False
            bel_menu_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
   "Start_ShowMyDocs", 0)
        End If
    End Sub
    '+++++++++++++++++++BELGELERÝM deðer okuyucu++++++++++++
    Private Sub bel_bag_oku()
        Dim belgeler_deger As Object  'veya Object  yerine integer kullanýn 
        belgeler_deger = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
           "Start_ShowMyDocs", Nothing)
        If belgeler_deger = 1 Then
            bel_bag_Radio.Checked = True
            bel_menu_RadioButton.Checked = False
            bel_no_RadioButton.Checked = False
        ElseIf belgeler_deger = 2 Then
            bel_menu_RadioButton.Checked = True
            bel_bag_Radio.Checked = False
            bel_no_RadioButton.Checked = False
        ElseIf belgeler_deger = 0 Then
            bel_no_RadioButton.Checked = True
            bel_bag_Radio.Checked = False
            bel_menu_RadioButton.Checked = False
        End If
    End Sub '/////////////BELGELERÝM BÝTÝÞ//////////////////////////////






    '//////////////MÜZÝGÝM/////////////////////////
    Private Sub muzik_bag_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muzik_bag_RadioButton.CheckedChanged
        If muzik_bag_RadioButton.Checked = True Then
            muz_menu_RadioButton.Checked = False
            muz_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                 "Start_ShowMyMusic", 1)

        End If
    End Sub

    Private Sub muz_menu_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muz_menu_RadioButton.CheckedChanged
        If muz_menu_RadioButton.Checked = True Then
            muzik_bag_RadioButton.Checked = False
            muz_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
     "Start_ShowMyMusic", 2)
        End If
    End Sub

    Private Sub muz_no_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muz_no_RadioButton.CheckedChanged
        If muz_no_RadioButton.Checked = True Then
            muzik_bag_RadioButton.Checked = False
            muz_menu_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
     "Start_ShowMyMusic", 0)
        End If
    End Sub
    '++++++++++++++++müzigim deger okuyucu+++++++++
    Private Sub muzigim_deger_oku()
        Dim muzigim_deger As Object
        muzigim_deger = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
     "Start_ShowMyMusic", Nothing)
        If muzigim_deger = 1 Then
            muzik_bag_RadioButton.Checked = True
            muz_menu_RadioButton.Checked = False
            muz_no_RadioButton.Checked = False
        ElseIf muzigim_deger = 2 Then
            muz_menu_RadioButton.Checked = True
            muzik_bag_RadioButton.Checked = False
            muz_no_RadioButton.Checked = False
        ElseIf muzigim_deger = 0 Then
            muz_no_RadioButton.Checked = True
            muzik_bag_RadioButton.Checked = False
            muz_menu_RadioButton.Checked = False
        End If
    End Sub '//////////////MÜZÝGÝM BÝTÝÞ/////////////////////////



    '///////////////GEÇMÝÞ BELGELER//////////////////
    Private Sub gec_bag_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gec_bag_RadioButton.CheckedChanged
        If gec_bag_RadioButton.Checked = True Then
            gec_menu_RadioButton.Checked = False
            gecmis_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "Start_ShowRecentDocs", 1)
        End If
    End Sub

    Private Sub gec_menu_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gec_menu_RadioButton.CheckedChanged
        If gec_menu_RadioButton.Checked = True Then
            gec_bag_RadioButton.Checked = False
            gecmis_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
    "Start_ShowRecentDocs", 2)
        End If
    End Sub

    Private Sub gecmis_no_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gecmis_no_RadioButton.CheckedChanged
        If gecmis_no_RadioButton.Checked = True Then
            gec_bag_RadioButton.Checked = False
            gec_menu_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
    "Start_ShowRecentDocs", 0)
        End If
    End Sub
    '++++++++++++gecmiþ deger okuyucu+++++++++++++++
    Private Sub gecmis_deger_oku()
        Dim gecmis_deg As Object
        gecmis_deg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
    "Start_ShowRecentDocs", Nothing)
        If gecmis_deg = 1 Then
            gec_bag_RadioButton.Checked = True
            gec_menu_RadioButton.Checked = False
            gecmis_no_RadioButton.Checked = False
        ElseIf gecmis_deg = 2 Then
            gec_menu_RadioButton.Checked = True
            gec_bag_RadioButton.Checked = False
            gecmis_no_RadioButton.Checked = False
        ElseIf gecmis_deg = 0 Then
            gecmis_no_RadioButton.Checked = True
            gec_bag_RadioButton.Checked = False
            gec_menu_RadioButton.Checked = False
        End If
    End Sub '///////////////GEÇMÝÞ BELGELER BÝTÝÞ//////////////////






    '////////////////////BÝLGÝSAYARIM ///////////////////
    Private Sub bilgisayarim_bag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bilgisayarim_bag.CheckedChanged
        If bilgisayarim_bag.Checked = True Then
            bil_mnu_RadioButton.Checked = False
            bil_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
               "Start_ShowMyComputer", 1)
        End If
    End Sub

    Private Sub bil_mnu_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bil_mnu_RadioButton.CheckedChanged
        If bil_mnu_RadioButton.Checked = True Then
            bilgisayarim_bag.Checked = False
            bil_no_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowMyComputer", 2)

        End If
    End Sub

    Private Sub bil_no_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bil_no_RadioButton.CheckedChanged
        If bil_no_RadioButton.Checked = True Then
            bilgisayarim_bag.Checked = False
            bil_mnu_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowMyComputer", 0)

        End If
    End Sub
    '++++ bilgisayarým bilgi okuyucu+++++++++++++++
    Private Sub bilgi_deger_oku()
        Dim bilgi_deger As Object
        bilgi_deger = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowMyComputer", Nothing)
        If bilgi_deger = 1 Then
            bilgisayarim_bag.Checked = True
            bil_mnu_RadioButton.Checked = False
            bil_no_RadioButton.Checked = False
        ElseIf bilgi_deger = 2 Then
            bil_mnu_RadioButton.Checked = True
            bilgisayarim_bag.Checked = False
            bil_no_RadioButton.Checked = False

        ElseIf bilgi_deger = 2 Then
            bil_no_RadioButton.Checked = True
            bilgisayarim_bag.Checked = False
            bil_mnu_RadioButton.Checked = False
        End If

    End Sub '////////////////////BÝLGÝSAYARIM BÝTÝÞ ///////////////////



    '////////////////////////RESÝMLER/////////////////////////

    Private Sub resimler_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resimler_RadioButton.CheckedChanged
        If resimler_RadioButton.Checked = True Then
            resim_mnu_Button.Checked = False
            resim_no_button.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowMyPics", 1)
        End If
    End Sub

    Private Sub resim_mnu_Button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resim_mnu_Button.CheckedChanged
        If resim_mnu_Button.Checked = True Then
            resimler_RadioButton.Checked = False
            resim_no_button.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowMyPics", 2)
        End If
    End Sub

    Private Sub resim_no_button_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resim_no_button.CheckedChanged
        If resim_no_button.Checked = True Then
            resimler_RadioButton.Checked = False
            resim_mnu_Button.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowMyPics", 0)
        End If
    End Sub
    '+++++++++++++++resimler deger okuyucu+++++++++++
    Private Sub resim_deger_okuyucu()
        Dim res_deg_oku As Object
        res_deg_oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
             "Start_ShowMyPics", Nothing)
        If res_deg_oku = 1 Then
            resimler_RadioButton.Checked = True
            resim_mnu_Button.Checked = False
            resim_no_button.Checked = False
        ElseIf res_deg_oku = 2 Then
            resim_mnu_Button.Checked = True
            resimler_RadioButton.Checked = False
            resim_no_button.Checked = False
        ElseIf res_deg_oku = 0 Then
            resim_no_button.Checked = True
            resimler_RadioButton.Checked = False
            resim_mnu_Button.Checked = False

        End If
    End Sub '////////////////////////RESÝMLER BÝTÝÞ/////////////////////////


    '//////////DENETÝM MASAI//////////
    Private Sub den_bag_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles den_bag_RadioButton.CheckedChanged
        If den_bag_RadioButton.Checked = True Then
            den_menu_RadioButton.Checked = False
            den_gosterme_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
          "Start_ShowControlPanel", 1)
        End If
    End Sub

    Private Sub den_menu_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles den_menu_RadioButton.CheckedChanged
        If den_menu_RadioButton.Checked = True Then
            den_bag_RadioButton.Checked = False
            den_gosterme_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
          "Start_ShowControlPanel", 2)
        End If
    End Sub

    Private Sub den_gosterme_RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles den_gosterme_RadioButton.CheckedChanged
        If den_gosterme_RadioButton.Checked = True Then
            den_bag_RadioButton.Checked = False
            den_menu_RadioButton.Checked = False
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
          "Start_ShowControlPanel", 0)
        End If
    End Sub
    '+++++++++++denetim masasi deger okuyucu+++++++++++++
    Private Sub denetim_masasi_oku()
        Dim den_deg As Object
        den_deg = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
          "Start_ShowControlPanel", Nothing)
        If den_deg = 1 Then
            den_bag_RadioButton.Checked = True
            den_menu_RadioButton.Checked = False
            den_gosterme_RadioButton.Checked = False
        ElseIf den_deg = 2 Then
            den_menu_RadioButton.Checked = True
            den_bag_RadioButton.Checked = False
            den_gosterme_RadioButton.Checked = False
        ElseIf den_deg = 0 Then
            den_gosterme_RadioButton.Checked = True
            den_bag_RadioButton.Checked = False
            den_menu_RadioButton.Checked = False
        End If
    End Sub '//////////DENETÝM MASAI BÝTÝÞ//////////



    '/////////////CHECK BOX LI KUTULAR////



    '///////ag baðlantýlarým deger kaydetici
    Private Sub ag_baglantýlarim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ag_baglantýlarim.CheckedChanged
        If ag_baglantýlarim.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                     "Start_ShowNetPlaces", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowNetPlaces", 0)
        End If
    End Sub
    '+++++að baðlantýlarým deger okuyucu
    Private Sub ag_bag_oku()
        Dim ag As Object
        ag = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                     "Start_ShowNetPlaces", Nothing)
        If ag = 1 Then
            ag_baglantýlarim.Checked = True
        Else
            ag_baglantýlarim.Checked = False
        End If
    End Sub


    '/////sýk kullanýlanlar deger kaydetici
    Private Sub sik_kulanilan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sik_kulanilan.CheckedChanged
        If sik_kulanilan.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "StartMenuFavorites", 2)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "StartMenuFavorites", 1)
        End If
    End Sub
    '+++sýk kullanýlanlar deger okuyucu
    Private Sub sik_kul_oku()
        Dim sik As Object
        sik = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "StartMenuFavorites", Nothing)
        If sik = 1 Then
            sik_kulanilan.Checked = True
        Else
            sik_kulanilan.Checked = False
        End If
    End Sub


    '//////yardim ve destek deger kaydet
    Private Sub yard_desktek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yard_desktek.CheckedChanged
        If yard_desktek.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
        "Start_ShowHelp", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowHelp", 0)
        End If
    End Sub
    '+++++++yardim ve destek deger okuyucu
    Private Sub yard_desk()
        Dim yardim As Object
        yardim = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowHelp", Nothing)
        If yardim = 1 Then
            yard_desktek.Checked = True
        Else
            yard_desktek.Checked = False
        End If
    End Sub

    '/////yazici ve fakslar deger kaydet////
    Private Sub yazici_faks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yazici_faks.CheckedChanged
        If yazici_faks.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
        "Start_ShowPrinters", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowPrinters", 0)
        End If
    End Sub
    '++++++yazici ve fakslar deger oku
    Private Sub yazici_oku()
        Dim yazici As Object
        yazici = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowPrinters", Nothing)
        If yazici = 1 Then
            yazici_faks.Checked = True
        Else
            yazici_faks.Checked = False
        End If
    End Sub


    '//////ara check ý deger yaz
    Private Sub Ara_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ara.CheckedChanged
        If Ara.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "Start_ShowSearch", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowSearch", 0)
        End If
    End Sub
    '+++++++++ara deger oku
    Private Sub ara_deg_oku()
        Dim ara_oku As Object
        ara_oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowSearch", Nothing)
        If ara_oku = 1 Then
            Ara.Checked = True
        Else
            Ara.Checked = False
        End If
    End Sub
    '////////////calistir deger yaz
    Private Sub Calistir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calistir.CheckedChanged
        If Calistir.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                       "Start_ShowRun", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowRun", 0)
        End If
    End Sub
    '++++++++çalýþtýr deger oku
    Private Sub calistir_oku()
        Dim cal As Object
        cal = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
         "Start_ShowRun", Nothing)
        If cal = 1 Then
            Calistir.Checked = True
        Else
            Calistir.Checked = False
        End If
    End Sub


    '/////oturumu kapat deger yaz
    Private Sub oturumu_kapat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oturumu_kapat.CheckedChanged
        If oturumu_kapat.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
"StartMenuLogoff", 0)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
          "StartMenuLogoff", 1)
        End If
    End Sub
    '++++++oturumu kapat deger oku
    Private Sub oturum_kapat()
        Dim oturum As Object
        oturum = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
          "StartMenuLogoff", Nothing)
        If oturum = 0 Then
            oturumu_kapat.Checked = True
        Else
            oturumu_kapat.Checked = False
        End If
    End Sub




    '////////bil_kapat deger yaz
    Private Sub bil_kapat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bil_kapat.CheckedChanged
        If bil_kapat.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
"NoClose", 0)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
          "NoClose", 1)
        End If
    End Sub
    '///bil kapat deger oku
    Private Sub bil_kapat_oku()
        Dim bil As Object
        bil = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
 "NoClose", Nothing)
        If bil = 0 Then
            bil_kapat.Checked = True
        Else
            bil_kapat.Checked = False
        End If
    End Sub



    '***///--- baþalat menüsü ayarlarý tabý*****////------





    '///////Baþlat Menüsünün Ýçerigini Gösterme deger yaz
    Private Sub baslat_menu_icerik_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baslat_menu_icerik_CheckBox.CheckedChanged
        If baslat_menu_icerik_CheckBox.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoChangeStartMenu", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
             "NoChangeStartMenu", 0)
        End If
    End Sub
    '++++++Baþlat Menüsünün Ýçerigini Gösterme deger oku
    Private Sub baslat_menu_oku()
        Dim baslat As Object
        baslat = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
             "NoChangeStartMenu", Nothing)
        If baslat = 1 Then
            baslat_menu_icerik_CheckBox.Checked = True
        Else
            baslat_menu_icerik_CheckBox.Checked = False
        End If
    End Sub



    '//////////////Baþlat Menüsündeki Balon Tipi Uyarýlarý Gösterme deger yaz
    Private Sub baslat_menusu_balon_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baslat_menusu_balon_check.CheckedChanged
        If baslat_menusu_balon_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
            "EnableBalloonTips", 0)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
          "EnableBalloonTips", 1)
        End If
    End Sub
    '++++++++++++++Baþlat Menüsündeki Balon Tipi Uyarýlarý Gösterme deger oku
    Private Sub baslat_balon_oku()
        Dim balon As Object
        balon = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
          "EnableBalloonTips", Nothing)
        If balon = 0 Then
            baslat_menusu_balon_check.Checked = True
        Else
            baslat_menusu_balon_check.Checked = False
        End If
    End Sub

    '///////Geçmiþ Dosyalarý Listeleme dger yaz
    Private Sub gecmis_dosyalar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gecmis_dosyalar.CheckedChanged
        If gecmis_dosyalar.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoRecentDocsHistory", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoRecentDocsHistory", 0)
        End If
    End Sub
    '++++++Geçmiþ Dosyalarý Listeleme dger oku
    Private Sub gecmis_dos_oku()
        Dim gec As Object
        gec = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoRecentDocsHistory", Nothing)
        If gec = 1 Then
            gecmis_dosyalar.Checked = True
        Else
            gecmis_dosyalar.Checked = False
        End If
    End Sub


    '///////Cýkýþda Geçmiþ Dosyalarý Sil   deger yaz
    Private Sub cikis_gecmis_sil_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cikis_gecmis_sil_check.CheckedChanged
        If cikis_gecmis_sil_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
        "ClearRecentDocsOnExit", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
         "ClearRecentDocsOnExit", 0)
        End If
    End Sub
    '++++++++Cýkýþda Geçmiþ Dosyalarý Sil   deger oku
    Private Sub cik_gec_sil()
        Dim cik As Object
        cik = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
         "ClearRecentDocsOnExit", Nothing)
        If cik = 1 Then
            cikis_gecmis_sil_check.Checked = True
        Else
            cikis_gecmis_sil_check.Checked = False
        End If
    End Sub
    '///////Uygulamalarý Listeleme Etkin Olmasýn deger yaz
    Private Sub uygul_liste_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uygul_liste_check.CheckedChanged
        If uygul_liste_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoStartMenuMFUprogramsList", 1)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoStartMenuMFUprogramsList", 0)
        End If
    End Sub
    '+++++++++Uygulamalarý Listeleme Etkin Olmasýn deger oku
    Private Sub uygulama_listele()
        Dim uygulama As Object
        uygulama = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
            "NoStartMenuMFUprogramsList", Nothing)
        If uygulama = 1 Then
            uygul_liste_check.Checked = True
        Else
            uygul_liste_check.Checked = False
        End If
    End Sub
    '/////////////////Benzer Görev Çubuðu Ögelerini Gizli deger yaz
    Private Sub benzer_gorev_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles benzer_gorev.CheckedChanged
        If benzer_gorev.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
            "TaskbarGlomming", 0)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
            "TaskbarGlomming", 1)
        End If
    End Sub
    '++++++++++++Benzer Görev Çubuðu Ögelerini Gizli deger oku
    Private Sub benzer_gorev_oku()
        Dim benzer As Object
        benzer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
     "TaskbarGlomming", Nothing)
        If benzer = 0 Then
            benzer_gorev.Checked = True
        Else
            benzer_gorev.Checked = False

        End If
    End Sub
    '/////////////////Etkin Olmayan Simgeleri Gizle deger yaz
    Private Sub etkin_olmayan_sim_check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etkin_olmayan_sim_check.CheckedChanged
        If etkin_olmayan_sim_check.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", _
            "EnableAutoTray", 0)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", _
            "EnableAutoTray", 1)
        End If
    End Sub
    '++++++++++Etkin Olmayan Simgeleri Gizle deger oku
    Private Sub etkin_olmaya_oku()
        Dim etkin As Object
        etkin = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", _
            "EnableAutoTray", Nothing)
        If etkin = 0 Then
            etkin_olmayan_sim_check.Checked = True
        Else
            etkin_olmayan_sim_check.Checked = False
        End If

    End Sub

End Class

