Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static hatali As Integer 'bu deger hatali deðerine gönderme yapar

        hatali = hatali + 1 'girilen veri yi her yanlýþda bir artýrýr
        Button1.Text = "Hata " & hatali 'hatalarý form daki tamam tusunda yazar
        'If hatali = 3 Then 'eger hata sayýsý 3 olursa program aþagýdaki hata mesajýný verir ve kapanýr
        'MsgBox("3 Defa Hatalý Giriþ Yaptýnýz", vbDefaultButton1 + vbOKOnly + vbInformation, "hatq")
        'End If
        Select Case hatali
            Case 1
                MsgBox("bir")
            Case 2
                MsgBox("iki")
            Case 3
                MsgBox("3")

        End Select


    End Sub
End Class
