Public Class Form1
    ' Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpString As Integer, ByVal lpFileName As String) As Long    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpString As Integer, ByVal lpFileName As String) As Long    Private Declare Function GetProfileInt Lib "kernel32" Alias "GetProfileIntA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal nDefault As Long) As Long    Private Declare Function WriteProfileString Lib "kernel32" Alias "WriteProfileStringA" (ByVal lpszSection As String, ByVal lpszKeyName As String, ByVal lpszString As String) As Long
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        MsgBox(My.Computer.FileSystem.SpecialDirectories.Temp)
        My.Computer.FileSystem.DeleteDirectory _
        (My.Computer.FileSystem.SpecialDirectories.Temp, FileIO.DeleteDirectoryOption.DeleteAllContents)
        MsgBox(Err.HelpContext)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Write a number 2001 on WIN.INI        Call WriteProfileString("rBnwares", "Year", "2001")        'Display the number, no need to convert the value returned        MsgBox(GetProfileInt("rBnwares", "Year", 0))
    End Sub
End Class
