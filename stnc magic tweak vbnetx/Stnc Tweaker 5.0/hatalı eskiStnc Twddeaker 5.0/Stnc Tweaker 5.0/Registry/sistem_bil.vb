Module sistem_bil
    'Public Class sistem_bil

    Sub sistem_bil_Load()
        is_sis_label_oku() : build() : version_oku() : kur_diz_TextBox_oku()
        ver_no_TextBox_oku() : sistem_diz() : product_TextBox_oku() : organization_textbox_oku()
    End Sub
    Sub is_sis_label_oku()
        With Index
            .is_sis_TextBox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "ProductName", Nothing)
        End With
    End Sub

    Sub build()
        With Index
            .build_TextBox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "BuildLab", Nothing)
        End With
    End Sub

    Sub version_oku()
        With Index
            .version_TextBox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "CurrentVersion", Nothing)
        End With
    End Sub
    Sub ver_no_TextBox_oku()
        With Index
            .ver_no_TextBox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "CurrentBuildNumber", Nothing)
        End With
    End Sub
    Sub sistem_diz()
        With Index
            .sistem_diz_TextBox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "SystemRoot", Nothing)
        End With
    End Sub
    Sub product_TextBox_oku()
        With Index
            .product_TextBox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "ProductId", Nothing)
        End With
    End Sub
    Sub kur_diz_TextBox_oku()
        With Index
            .kur_diz_TextBox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "SourcePath", Nothing)
        End With
    End Sub
    Sub organization_textbox_oku()
        With Index
            .organization_textbox.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", _
    "RegisteredOrganization", Nothing)
        End With
    End Sub
    'End Class
End Module
