Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bul
        bul = Dir(System.Environment.SystemDirectory + "\*.cpl")
        While bul <> ""
            'MsgBox(Bul)
            lstProcessesAddItem.Items.Add(System.Environment.SystemDirectory + "\" + bul)
            bul = Dir()
        End While
    End Sub

    Private Sub AddItems()
        ' You can add items individually to a list or combo box.
        ' Because you can add any type of object, it's up to you to determine
        ' which property of the object is to be displayed. Set the 
        ' DisplayMember property to indicate the name of the property to display.
        ' In this case, set the DisplayMember property to display the ProcessName
        ' property.

        ' ValueMember property only works if you specify the DataSource
        ' property of the control.

        Try
            Dim prc As Process
            ' Remove existing items from the control.
            ' Notice we clear the Items collection, rather then the ListBox
            lstProcessesAddItem.Items.Clear()

            ' Fill the control. Indicate which member of 
            ' the items added to the ListBox.DataSource should be
            ' displayed.
            lstProcessesAddItem.DisplayMember = "ProcessName"
            For Each prc In Process.GetProcesses
                lstProcessesAddItem.Items.Add(prc)
            Next
            lstProcessesAddItem.Sorted = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, Me.Text)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddItems()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    'Private Sub lstProcessesAddItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProcessesAddItem.SelectedIndexChanged
    
    '   Try
     
    '        If lstProcessesAddItem.SelectedIndex > -1 Then
    '          lblFileName1.Text = CType(lstProcessesAddItem.SelectedItem, Process).MainModule.FileName
    '         Else
    '            lblFileName1.Text = String.Empty
    '           End If
    '      Catch ex As Exception
    '
    '       lblFileName1.Text = String.Empty
    '    End Try
    ' End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' If lstProcessesAddItem.SelectedIndex = 1 Then
        Process.Start(lblFileName1.Text)

        'End If
        ' Process.Start(lstProcessesAddItem.SelectedIndex + System.Environment.SystemDirectory)
    End Sub

    Private Sub lstProcessesAddItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProcessesAddItem.SelectedIndexChanged
        Process.Start(lstProcessesAddItem.SelectedItem)
        MsgBox(lstProcessesAddItem.SelectedItem)
    End Sub

End Class
