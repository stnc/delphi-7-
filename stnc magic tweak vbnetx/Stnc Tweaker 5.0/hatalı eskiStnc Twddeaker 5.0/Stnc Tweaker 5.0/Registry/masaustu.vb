Module masaustu
    ' Public Class masaustu

    Sub masaustu_Load()
        win_ver_oku() : masa() : aktif_oku()
        mas_oku() : mas_tem() : mas_duz_oku()
    End Sub

    '///// Masaüstünü Kullanýlmaz Hale Getir deger yaz
    Sub Msa_kul_hal_CheckedChanged()
        With Index
            If .Msa_kul_hal.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoDesktop", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                 "NoDesktop", 0)
            End If
        End With

    End Sub
    '+++++++ Masaüstünü Kullanýlmaz Hale Getir deger oku
    Sub masa()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
    "NoDesktop", Nothing)
            If oku = 1 Then
                .Msa_kul_hal.Checked = True
            Else
                .Msa_kul_hal.Checked = False
            End If
        End With
    End Sub

    '////////////Windows Version Numarasýný Göster yaz


    Sub win_ver_CheckedChanged()
        With Index
            If .win_ver.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", _
                "PaintDesktopVersion", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", _
                           "PaintDesktopVersion", 0)
            End If
        End With
    End Sub
    '+++++++++++Windows Version Numarasýný Göster oku
    Sub win_ver_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop", _
                           "PaintDesktopVersion", Nothing)
            If oku = 1 Then
                .win_ver.Checked = True
            Else
                .win_ver.Checked = False
            End If
        End With
    End Sub



  
    '//////////////Aktif Desktop u Kullanýlmaz Hale Getir yaz

    Sub Aktif_mas_chek_CheckedChanged()
        With Index
            If .Aktif_mas_chek.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
             "NoActiveDesktop", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                            "NoActiveDesktop", 0)
            End If
        End With
    End Sub
    '++++++++++++Aktif Desktop u Kullanýlmaz Hale Getir oku
    Sub aktif_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                            "NoActiveDesktop", Nothing)
            If oku = 1 Then
                .Aktif_mas_chek.Checked = True
            Else
                .Aktif_mas_chek.Checked = False
            End If
        End With
    End Sub



    '///////////Ýçerik Menüsünü Msaüstünde Göster yaz

    Sub Ýçerik_check_CheckedChanged()
        With Index
            If .Ýçerik_check.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoViewContextMenu", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                          "NoViewContextMenu", 0)
            End If
        End With
    End Sub
    '++++++++++Ýçerik Menüsünü Msaüstünde Göster oku
    Sub mas_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                          "NoViewContextMenu", Nothing)
            If oku = 1 Then
                .Ýçerik_check.Checked = True
            Else
                .Ýçerik_check.Checked = False
            End If
        End With
    End Sub

    '////////////masa üsüt temizleme aracý yaz

    Sub mas_tem_CheckBox_CheckedChanged()
        With Index
            If .mas_tem_CheckBox.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Desktop\CleanupWiz", _
                "NoRun", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Desktop\CleanupWiz", _
               "NoRun", 0)
            End If
        End With
    End Sub
    '++++++++++++ masa üsüt temizleme aracý oku
    Sub mas_tem()
        With Index
            Dim mas_tem As Object
            mas_tem = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Desktop\CleanupWiz", _
                        "NoRun", Nothing)
            If mas_tem = 1 Then
                .mas_tem_CheckBox.Checked = True
            Else
                .mas_tem_CheckBox.Checked = False
            End If
        End With
    End Sub

    '///////////////Masaüstü Ayarlarýný Kaydetme yaz

    Sub _mas_duzCheckBox_CheckedChanged()
        With Index
            If ._mas_duzCheckBox.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoSaveSettings", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                           "NoSaveSettings", 0)
            End If
        End With
    End Sub

    '+++++++++++++++Masaüstü Ayarlarýný Kaydetme oku
    Sub mas_duz_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", _
                "NoSaveSettings", Nothing)
            If oku = 1 Then
                ._mas_duzCheckBox.Checked = True
            Else
                ._mas_duzCheckBox.Checked = False
            End If
        End With
    End Sub


    'End Class
End Module
