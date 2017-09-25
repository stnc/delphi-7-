Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FileOpen(1, "TESTFILE", OpenMode.Output) ' Open file for output.
        Write(1, "This is a test.")  ' Print text to file.
        WriteLine(1)  ' Print blank line to file.
        WriteLine(1, "Zone 1", TAB(), "Zone 2")   ' Print in two print zones.
        WriteLine(1, "Hello", " ", "World")     ' Separate strings with space.
        WriteLine(1, SPC(5), "5 leading spaces ")    ' Print five leading spaces.
        WriteLine(1, TAB(15), "Hello")   ' Print word at column 10.

        ' Assign Boolean, Date, and Error values.
        Dim aBool As Boolean
        Dim aDate As DateTime
        aBool = False
        aDate = DateTime.Parse("February 12, 1969")

        ' Dates and Booleans are translated using locale settings of 
        ' your system.
        WriteLine(1, aBool, " is a Boolean value")
        WriteLine(1, aDate, " is a date")
        FileClose(1)   ' Close file.
    End Sub
End Class
