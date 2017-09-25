Module tweak
    'Public Class tweak_tweak
    '/////////Ýconlarý Gerçek Modunda Göster yuaz

    Sub tweak_tweak_Load()
        icon_oku() : bilinen_uzantý_oku() 'yetersiz_alan()
        sakalna_oku() : ksayol_oku() : win_gun() : bil_acilis_oku() : resim_onbelle()
        msn_oku() : hata() : kritik_oku()
    End Sub
    Sub icon_gercek_Checked()
        With Index
            If .icon_gercek.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop\WindowMetrics", _
                "Shell Icon BPP", "16")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop\WindowMetrics", _
                "Shell Icon BPP", "")
            End If
        End With
    End Sub
    '++++++++Ýconlarý Gerçek Modunda Göster oku
    Sub icon_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop\WindowMetrics", _
                "Shell Icon BPP", "16")
            If oku = "16" Then
                .icon_gercek.Checked = True
            Else
                .icon_gercek.Checked = False
            End If
        End With
    End Sub

    '/////////   Bilinen Dosya Uzantýlarýný Göster yaz

    Sub bilinen_uzantý_CheckedChanged()
        With Index
            If .bilinen_uzantý.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "HideFileExt", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "HideFileExt", 0)
            End If
        End With
    End Sub
    '++++++++    Bilinen Dosya Uzantýlarýný Göster  oku
    Sub bilinen_uzantý_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "HideFileExt", Nothing)
            If oku = 1 Then
                .bilinen_uzantý.Checked = True
            Else
                .bilinen_uzantý.Checked = False
            End If
        End With
    End Sub
    '/////////  Yetersiz Disk alaný Uyarýsýný Kaldýr   oku
    Sub yetersiz_disk_CheckedChanged()
        With Index
            If .yetersiz_disk.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoLowDiskSpaceChecks", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
       "NoLowDiskSpaceChecks", 0)
            End If
        End With
    End Sub

    '++++++++   Yetersiz Disk alaný Uyarýsýný Kaldýr    yaz
    Sub yetersiz_alan_yaz()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoLowDiskSpaceChecks", Nothing)
            If oku = 1 Then
                .yetersiz_disk.Checked = True
            Else
                .yetersiz_disk.Checked = False
            End If
        End With
    End Sub

    '/////////  Saklanan Dll'leri Hafýzadan Kaldýr  yaz

    Sub saklanan_dll_CheckedChanged()
        With Index
            If .saklanan_dll.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AlwaysUnloadDLL", _
                "", "1")
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AlwaysUnloadDLL", _
                "", "0")
            End If
        End With
    End Sub
    '++++++++   Saklanan Dll'leri Hafýzadan Kaldýr    oku
    Sub sakalna_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AlwaysUnloadDLL", _
                "", Nothing)
            If oku = "1" Then
                .saklanan_dll.Checked = True
            Else
                .saklanan_dll.Checked = False
            End If
        End With
    End Sub


    '/////////   Kýsayollar için Bilgi Baloncuðu Gösterme  oku

    Sub kýsayol_bilgi_CheckedChanged()
        With Index
            If .kýsayol_bilgi.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "ShowInfoTip", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
              "ShowInfoTip", 0)
            End If
        End With
    End Sub
    '++++++++    Kýsayollar için Bilgi Baloncuðu Gösterme   yaz
    Sub ksayol_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "ShowInfoTip", Nothing)
            If oku = 1 Then
                .kýsayol_bilgi.Checked = True
            Else
                .kýsayol_bilgi.Checked = False
            End If

        End With
    End Sub

    '/////////  Windows Güncellemeyi Kayýt Olmadan Kullan   oku

    Sub windows_guncelle_CheckedChanged()
        With Index
            If .windows_guncelle.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
                "RegDone", "0")
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
                "RegDone", "1")

            End If
        End With
    End Sub
    '++++++++    Windows Güncellemeyi Kayýt Olmadan Kullan   oku
    Sub win_gun()
        With Index


            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
                        "RegDone", Nothing)
            If oku = "0" Then
                .windows_guncelle.Checked = True
            Else
                .windows_guncelle.Checked = False

            End If
        End With
    End Sub



    '///////// Bilgisayarýn Açýlýþýnda Num Lock Tuþu Aktif Olsun    oku

    Sub bil_acilis_CheckedChanged()
        With Index
            If .bil_acilis.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Keyboard", _
                "InitialKeyboardIndicators", "1")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Keyboard", _
    "InitialKeyboardIndicators", "0")

            End If
        End With
    End Sub
    '++++++++    Bilgisayarýn Açýlýþýnda Num Lock Tuþu Aktif Olsun   yaz
    Sub bil_acilis_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Keyboard", _
    "InitialKeyboardIndicators", Nothing)
            If oku = "1" Then
                .bil_acilis.Checked = True
            Else
                .bil_acilis.Checked = False
            End If
        End With
    End Sub

    '/////////   Resimleri Önbelleðe Alma  yaz

    Sub resim_onbellek_CheckedChanged()
        With Index
            If .resim_onbellek.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "DisableThumbnailCache", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "DisableThumbnailCache", 0)
            End If
        End With
    End Sub
    '++++++++    Resimleri Önbelleðe Alma   oku
    Sub resim_onbelle()
        With Index
            Dim res As Object
            res = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", _
                "DisableThumbnailCache", Nothing)
            If res = 1 Then
                .resim_onbellek.Checked = True
            Else
                .resim_onbellek.Checked = False
            End If
        End With
    End Sub
    '/////////  Msn Ve Outlook Baþlamasýn  yaz

    Sub msn_ouutlok_CheckedChanged()
        With Index
            If .msn_ouutlok.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Outlook Express", _
                "Hide Messenger", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Outlook Express", _
     "Hide Messenger", 0)
            End If
        End With
    End Sub
    '++++++++    Msn Ve Outlook Baþlamasýn   yaz
    Sub msn_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Outlook Express", _
                "Hide Messenger", Nothing)
            If oku = 1 Then
                .msn_ouutlok.Checked = True
            Else
                .msn_ouutlok.Checked = False
            End If
        End With
    End Sub


    '/////////   Hata Raporlarýný Devre Dýþý Býrak  oku

    Sub hata_rapor_CheckedChanged()
        With Index
            If .hata_rapor.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PCHealth\ErrorReporting", _
                "DoReport", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PCHealth\ErrorReporting", _
              "DoReport", 0)
            End If
        End With
    End Sub
    '++++++++     Hata Raporlarýný Devre Dýþý Býrak  oku
    Sub hata()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PCHealth\ErrorReporting", _
                "DoReport", Nothing)
            If oku = 1 Then
                .hata_rapor.Checked = True
            Else
                .hata_rapor.Checked = False
            End If
        End With
    End Sub
    '/////////   Kritik Hatalar Ýçin Hata Raporu Gönderme  oku

    Sub kritik_hata_CheckedChanged()
        With Index
            If .kritik_hata.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PCHealth\ErrorReporting", _
                         "ShowUI", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PCHealth\ErrorReporting", _
                       "ShowUI", 0)
            End If
        End With
    End Sub
    '++++++++     Kritik Hatalar Ýçin Hata Raporu Gönderme  yaz
    Sub kritik_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PCHealth\ErrorReporting", _
                         "ShowUI", Nothing)
            If oku = 1 Then
                .kritik_hata.Checked = True
            Else
                .kritik_hata.Checked = False
            End If
        End With
    End Sub

    'End Class
End Module
