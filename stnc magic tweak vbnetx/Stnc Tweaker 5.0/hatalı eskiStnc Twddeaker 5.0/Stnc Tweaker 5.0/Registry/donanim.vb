Module donanim
    'Public Class donanim

    Sub donanim_Load()
        speaker_oku() : ana_sis_oku() : cd_yaz_oku()
        genis_oku() : buyuk_hdh_oku() : intel_oku()
        ieee_oku() : anakart_oku()
    End Sub



    '//////// Speaker Ses Çýkarmasýn deger yaz
    Sub speaker_ses_CheckedChanged()
        With Index
            If .speaker_ses.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Sound", "Beep", "yes")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Sound", "Beep", "no")
            End If
        End With
    End Sub
    '++++++++ Speaker Ses Çýkarmasýn deger oku
    Sub speaker_oku()
        With Index
            Dim ses As Object
            ses = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Sound", "Beep", Nothing)
            If ses = "yes" Then
                .speaker_ses.Checked = True
            Else
                .speaker_ses.Checked = False
            End If
        End With
    End Sub

    '/////Ana Sistem Performansýný Geliþtir deger yaz
    Sub ana_sis_check_CheckedChanged()
        With Index
            If .ana_sis_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "DisablePagingExecutive", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "DisablePagingExecutive", 0)
            End If
        End With
    End Sub
    '+++++++Ana Sistem Performansýný Geliþtir deger oku
    Sub ana_sis_oku()
        With Index
            Dim ana As Object
            ana = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "DisablePagingExecutive", Nothing)
            If ana = 1 Then
                .ana_sis_check.Checked = True
            Else
                .ana_sis_check.Checked = False
            End If
        End With
    End Sub



    '//////////// Cd'ye Yazma Özelliðini Devre Dýþý Býrak     deger yaz
    Sub cd_ye_yazma_CheckedChanged()
        With Index
            If .cd_ye_yazma.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 0)
            End If
        End With
    End Sub

    '+++++++++ Cd'ye Yazma Özelliðini Devre Dýþý Býrak     deger oku
    Sub cd_yaz_oku()
        With Index
            Dim cd As Object
            cd = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", Nothing)
            If cd = 1 Then
                .cd_ye_yazma.Checked = True
            Else
                .cd_ye_yazma.Checked = False
            End If
        End With
    End Sub



    '///////////////Geniþ Ýkinci Seviye Önbelleðini Optimize Et deger yaz
    Sub genis_ikinci_seviye_CheckedChanged()
        With Index
            If .genis_ikinci_seviye.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "SecondLevelDataCache", 512)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "SecondLevelDataCache", 0)

            End If
        End With
    End Sub
    '++++++++Geniþ Ýkinci Seviye Önbelleðini Optimize Et deger oku
    Sub genis_oku()
        With Index
            Dim gen As Object
            gen = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Memory Management", "SecondLevelDataCache", Nothing)
            If gen = 512 Then
                .genis_ikinci_seviye.Checked = True
            Else
                .genis_ikinci_seviye.Checked = False
            End If
        End With
    End Sub


    '////////// Büyük Harddiskler Ýçin 48 Bit Lba Desteðini Aç deger yaz
    Sub buyuk_hdd_CheckedChanged()
        With Index
            If .buyuk_hdd.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\atapi\Parameters", "EnableBigLba", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\atapi\Parameters", "EnableBigLba", 0)
            End If
        End With
    End Sub
    '+++++++++++++ Büyük Harddiskler Ýçin 48 Bit Lba Desteðini Aç deger oku
    Sub buyuk_hdh_oku()
        With Index
            Dim hdd As Object
            hdd = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\atapi\Parameters", "EnableBigLba", Nothing)
            If hdd = 1 Then
                .buyuk_hdd.Checked = True
            Else
                .buyuk_hdd.Checked = False
            End If
        End With
    End Sub

    '/////////////  Ýntel Chipsetlerde Udma66 Modunu Etkinleþtir deger yaz
    Sub intel_chipset_CheckedChanged()
        With Index
            If .intel_chipset.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4D36E96A-E325-11CE-BFC1-08002BE10318}\0000", "EnableUDMA66", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4D36E96A-E325-11CE-BFC1-08002BE10318}\0000", "EnableUDMA66", 0)

            End If
        End With
    End Sub
    '+++++++++++++  Ýntel Chipsetlerde Udma66 Modunu Etkinleþtir deger oku
    Sub intel_oku()
        With Index
            Dim intel As Object
            intel = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Class\{4D36E96A-E325-11CE-BFC1-08002BE10318}\0000", "EnableUDMA66", Nothing)
            If intel = 1 Then
                .intel_chipset.Checked = True
            Else
                .intel_chipset.Checked = False
            End If
        End With
    End Sub

    '//////////////////////AnaKartaki Bütünleþik Að Kartýný Devre Dýþý Býrak deger yaz
    Sub anakart_butun_CheckedChanged()
        With Index
            If .anakart_butun.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\Tcpip\Parameters", "DisableTaskOffload", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\Tcpip\Parameters", "DisableTaskOffload", 0)

            End If
        End With
    End Sub
    '+++++++++++++AnaKartaki Bütünleþik Að Kartýný Devre Dýþý Býrak deger oku
    Sub anakart_oku()
        With Index
            Dim ana As Object
            ana = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\Tcpip\Parameters", "DisableTaskOffload", Nothing)
            If ana = 1 Then
                .anakart_butun.Checked = True
            Else
                .anakart_butun.Checked = False
            End If
        End With
    End Sub

    '/////////////////// Ýeee 1394 Aygýtýný Dinamik Sürücüsüne Ters Çevir  deger yaz
    Sub ieee_1394_aygýtý_Checked()
        With Index
            If .ieee_1394_aygýtý.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\dmadmin\Parameters", "EnableDynamicConversionFor1394", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\dmadmin\Parameters", "EnableDynamicConversionFor1394", 0)
            End If
        End With
    End Sub
    '++++++ Ýeee 1394 Aygýtýný Dinamik Sürücüsüne Ters Çevir  deger oku
    Sub ieee_oku()
        With Index
            Dim ie As Object
            ie = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\dmadmin\Parameters", "EnableDynamicConversionFor1394", Nothing)
            If ie = 1 Then
                .ieee_1394_aygýtý.Checked = True
            Else
                .ieee_1394_aygýtý.Checked = False
            End If
        End With
    End Sub


    'End Class
End Module
