Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Const SHERB_NOCONFIRMATION As Short = &H1s
	Const SHERB_NOPROGRESSUI As Short = &H2s
	Const SHERB_NOSOUND As Short = &H4s
	Private Structure ULARGE_INTEGER
		Dim LowPart As Integer
		Dim HighPart As Integer
	End Structure
	Private Structure SHQUERYRBINFO
		Dim cbSize As Integer
		Dim i64Size As ULARGE_INTEGER
		Dim i64NumItems As ULARGE_INTEGER
	End Structure
	Private Declare Function SHEmptyRecycleBin Lib "shell32.dll"  Alias "SHEmptyRecycleBinA"(ByVal hwnd As Integer, ByVal pszRootPath As String, ByVal dwFlags As Integer) As Integer
	Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Integer
	'UPGRADE_WARNING: Structure SHQUERYRBINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function SHQueryRecycleBin Lib "shell32.dll"  Alias "SHQueryRecycleBinA"(ByVal pszRootPath As String, ByRef pSHQueryRBInfo As SHQUERYRBINFO) As Integer
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'KPD-Team 2000
		'URL: http://www.allapi.net/
		'E-Mail: KPDTeam@Allapi.net
		Dim RBinInfo As SHQUERYRBINFO
		Dim Msg As MsgBoxResult
		RBinInfo.cbSize = Len(RBinInfo)
		SHQueryRecycleBin(vbNullString, RBinInfo)
		If (RBinInfo.i64Size.LowPart And &H80000000) = &H80000000 Or RBinInfo.i64Size.HighPart > 0 Then
			Msg = MsgBox("Your Recycle Bin consumes over 2 gigabytes right now!" & vbCrLf & "Do you want to empty it?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
		Else
			Msg = MsgBox("Your Recycle Bin consumes" & Str(RBinInfo.i64Size.LowPart) & " bytes right now." & vbCrLf & "Do you want to empty it?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
		End If
		If Msg = MsgBoxResult.Yes Then
			SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, 0)
			SHUpdateRecycleBinIcon()
		End If
	End Sub
End Class