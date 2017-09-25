Public Class hakkında

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.LinkLabel1.LinkVisited = True
        'Process.Start(my.Computer.FileSystem.SpecialDirectories.ProgramFiles  + "Internet Explorer\IEXPLORE.EXE"", "www.stnc.net.tr.tc")
    End Sub

    Private Sub hakkında_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = My.Computer.Info.OSFullName
        Label5.Text = My.Computer.Info.OSVersion
        Label7.Text = My.Computer.Info.OSPlatform

    End Sub
End Class