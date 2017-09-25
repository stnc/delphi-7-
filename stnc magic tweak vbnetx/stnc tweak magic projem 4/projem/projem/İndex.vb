Public Class Ýndex
    'WindowState = FormWindowState.Minimized









    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        denetim_masa.Show()
    
    End Sub

  

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub araclar_Picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles araclar_Picture.Click
        araclar.ShowDialog()
    End Sub

    Private Sub baslat_picture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baslat_picture.Click
        baslat_mnu.ShowDialog()
    End Sub
End Class