Module sistem_ayar
    ' Public Class sistem
    Sub sistem_Load()
        clear_radio_oku() : satndart_radio_oku() : disk_oku()
    End Sub

    Sub disk_kapasite_CheckedChanged()
        With Index
            If .disk_kapasite.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoLowDiskSpaceChecks", 1)
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoLowDiskSpaceChecks", 0)
            End If
        End With
    End Sub
    Sub disk_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoLowDiskSpaceChecks", Nothing)
            If oku = 1 Then
                .disk_kapasite.Checked = True
            Else
                .disk_kapasite.Checked = False
            End If
        End With
    End Sub


    Sub standart_radio_CheckedChanged()
        With Index
            If .standart_radio.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", 1)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", "2")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", 2)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", "2")
            End If
        End With
    End Sub
    Sub satndart_radio_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", Nothing)
            If oku = 1 Then
                .standart_radio.Checked = True
            Else
                .standart_radio.Checked = False
            End If
        End With
    End Sub



    Sub cleartype_radio_CheckedChanged()
        With Index
            If .cleartype_radio.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", 2)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", "2")
            Else
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", 1)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", "2")

            End If
        End With
    End Sub

    Sub clear_radio_oku()
        With Index
            Dim oku As Object
            oku = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "FontSmoothingType", Nothing)
            If oku = 2 Then
                .cleartype_radio.Checked = True
            Else
                .cleartype_radio.Checked = False
            End If
        End With
    End Sub


    'End Class
End Module
