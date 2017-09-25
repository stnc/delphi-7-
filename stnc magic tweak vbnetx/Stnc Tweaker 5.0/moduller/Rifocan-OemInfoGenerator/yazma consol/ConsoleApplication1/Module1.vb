Imports System.IO

Module Module1
    'Read a Text File


    Sub Main()
        Dim objStreamReader As StreamReader
        Dim strLine As String

        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader("C:\Testfile.txt")

        'Read the first line of text.
        strLine = objStreamReader.ReadLine

        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing

            'Write the line to the Console window.
            Console.WriteLine(strLine)

            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop

        'Close the file.
        objStreamReader.Close()

        Console.ReadLine()
    End Sub


End Module
