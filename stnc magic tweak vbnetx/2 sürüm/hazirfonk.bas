Attribute VB_Name = "hazirfonk"
'ses için gerekliler

Global q
Declare Function sndPlaySound Lib "WINMM.DLL" Alias "sndPlaySoundA" _
        (lpszSoundName As Any, ByVal uFlags As Long) As Long

Global Const SND_ASYNC = &H1
Global Const SND_NODEFAULT = &H2
Global Const SND_MEMORY = &H4

Global SoundBuffer() As Byte 'ses bitiþ

'regedit modülü baþlangýç
Public Const HKEY_CLASSES_ROOT = &H80000000
Public Const HKEY_CURRENT_USER = &H80000001
Public Const HKEY_LOCAL_MACHINE = &H80000002
Public Const HKEY_USERS = &H80000003
Public Const HKEY_PERFORMANCE_DATA = &H80000004
Public Const ERROR_SUCCESS = 0&
Public Const REG_BINARY = 8
Public Const REG_SZ = 1
Public Const REG_DWORD = 4

Declare Function WinExec Lib "kernel32" (ByVal lpCmdLine As String, ByVal nCmdShow As Long) As Long 'bu modül exe çalýþtýrmak için kullanýlýr
Public Declare Function CopyFile Lib "kernel32" Alias "CopyFileA" (ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal bFailIfExists As Long) As Long
'dosya silici modül
Public Declare Function DeleteFile Lib "kernel32" Alias "DeleteFileA" (ByVal lpFileName As String) As Long 'burasý dosya silmek için gerekli Api
'regedit fonk
Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Long) As Long
Declare Function RegCreateKey Lib "advapi32.dll" Alias "RegCreateKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, phkResult As Long) As Long
Declare Function RegDeleteKey Lib "advapi32.dll" Alias "RegDeleteKeyA" (ByVal hKey As Long, ByVal lpSubKey As String) As Long
Declare Function RegDeleteValue Lib "advapi32.dll" Alias "RegDeleteValueA" (ByVal hKey As Long, ByVal lpValueName As String) As Long
Declare Function RegOpenKey Lib "advapi32.dll" Alias "RegOpenKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, phkResult As Long) As Long
Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, lpData As Any, lpcbData As Long) As Long
Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal Reserved As Long, ByVal dwType As Long, lpData As Any, ByVal cbData As Long) As Long

Public Const HCR = HKEY_CLASSES_ROOT
Public Const HCU = HKEY_CURRENT_USER
Public Const HLM = HKEY_LOCAL_MACHINE
Public Const HU = HKEY_USERS
Public Const HPD = HKEY_PERFORMANCE_DATA
'Public Const HCC = HKEY_CURRENT_CONFIG
'Public Const HDD = HKEY_DYN_DATA

Public Sub savekey(hKey As Long, strPath As String)
Dim keyhand&
r = RegCreateKey(hKey, strPath, keyhand&)
r = RegCloseKey(keyhand&)
End Sub

Public Function getstring(hKey As Long, strPath As String, strValue As String)

Dim keyhand As Long
Dim datatype As Long
Dim lResult As Long
Dim strBuf As String
Dim lDataBufSize As Long
Dim intZeroPos As Integer
r = RegOpenKey(hKey, strPath, keyhand)
lResult = RegQueryValueEx(keyhand, strValue, 0&, lValueType, ByVal 0&, lDataBufSize)
If lValueType = REG_SZ Then
    strBuf = String(lDataBufSize, " ")
    lResult = RegQueryValueEx(keyhand, strValue, 0&, 0&, ByVal strBuf, lDataBufSize)
    If lResult = ERROR_SUCCESS Then
        intZeroPos = InStr(strBuf, Chr$(0))
        If intZeroPos > 0 Then
            getstring = Left$(strBuf, intZeroPos - 1)
        Else
            getstring = strBuf
        End If
    End If
End If
End Function


Public Sub savestring(hKey As Long, strPath As String, strValue As String, strData As String)
Dim keyhand As Long
Dim r As Long
r = RegCreateKey(hKey, strPath, keyhand)
r = RegSetValueEx(keyhand, strValue, 0, REG_SZ, ByVal strData, Len(strData))
r = RegCloseKey(keyhand)
End Sub


Function getdword(ByVal hKey As Long, ByVal strPath As String, ByVal strValueName As String) As Long
Dim lResult As Long
Dim lValueType As Long
Dim lBuf As Long
Dim lDataBufSize As Long
Dim r As Long
Dim keyhand As Long

r = RegOpenKey(hKey, strPath, keyhand)


lDataBufSize = 4
    
lResult = RegQueryValueEx(keyhand, strValueName, 0&, lValueType, lBuf, lDataBufSize)

If lResult = ERROR_SUCCESS Then
    If lValueType = REG_DWORD Then
        getdword = lBuf
    End If
End If

r = RegCloseKey(keyhand)
    
End Function

Function SaveDword(ByVal hKey As Long, ByVal strPath As String, ByVal strValueName As String, ByVal lData As Long)
    Dim lResult As Long
    Dim keyhand As Long
    Dim r As Long
    r = RegCreateKey(hKey, strPath, keyhand)
    lResult = RegSetValueEx(keyhand, strValueName, 0&, REG_DWORD, lData, 4)

    r = RegCloseKey(keyhand)
End Function

Public Function DeleteKey(ByVal hKey As Long, ByVal strKey As String)
Dim r As Long
r = RegDeleteKey(hKey, strKey)
End Function

Public Function DeleteValue(ByVal hKey As Long, ByVal strPath As String, ByVal strValue As String)
Dim keyhand As Long
r = RegOpenKey(hKey, strPath, keyhand)
r = RegDeleteValue(keyhand, strValue)
r = RegCloseKey(keyhand)
End Function 'regedit modülü bitiþ

'ses için gerekliler

Sub BeginPlaySound(ByVal ResourceId As Integer)
     SoundBuffer = LoadResData(ResourceId, "CUSTOM")
    sndPlaySound SoundBuffer(0), SND_ASYNC Or SND_NODEFAULT Or SND_MEMORY
End Sub

Sub EndPlaySound()
    sndPlaySound ByVal vbNullString, 0&
End Sub
'ses kontrol bitiþ


'******* bu deger aslýnda savestring in aynýsý dýr******************
'Public Sub DegerKaydet(hKey As Long, strPath As String, strValue As String, strData As String)
'Dim hkeycur As Long
'Dim RegDurum As Long
'RegDurum = RegCreateKey(hKey, strPath, hkeycur)
'RegDurum = RegSetValueEx(hkeycur, strValue, 0, REG_SZ, ByVal strData, Len(strData))
'If RegDurum <> ERROR_SUCCESS Then
'End If
'RegDurum = RegCloseKey(hkeycur)
'End Sub


