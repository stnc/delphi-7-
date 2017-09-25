Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objStreamWriter As IO.StreamWriter

        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New IO.StreamWriter("C:\Test.txt")

        'Write a line of text.
        objStreamWriter.WriteLine("Hello World")

        'Write a second line of text.
        objStreamWriter.WriteLine("From the StreamWriter class")

        'Close the file.
        objStreamWriter.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objStreamWriter As IO.StreamWriter
        Dim x As Long

        'Open the file.
        objStreamWriter = New IO.StreamWriter("C:\Test2.txt", True)

        'Write out the numbers 1 through 10 on the same line.
        For x = 1 To 10
            objStreamWriter.Write(x)
        Next x

        'Close the file.
        objStreamWriter.Close()

    End Sub
End Class
