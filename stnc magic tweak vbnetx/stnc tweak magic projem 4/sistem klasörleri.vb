Public Class sistem_klasörleri

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With ListBox1.Items
            .Add(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData())
            .Add(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData)
            .Add(My.Computer.FileSystem.SpecialDirectories.Desktop)
            .Add(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
            .Add(My.Computer.FileSystem.SpecialDirectories.MyMusic)
            .Add(My.Computer.FileSystem.SpecialDirectories.MyPictures)
            .Add(My.Computer.FileSystem.SpecialDirectories.ProgramFiles)
            .Add(My.Computer.FileSystem.SpecialDirectories.Programs)
            .Add(My.Computer.FileSystem.SpecialDirectories.Temp)
            .Add(System.Environment.SystemDirectory) 'sistem32 klasörü önemli
        End With
    End Sub

End Class