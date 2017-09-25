VERSION 5.00
Begin VB.Form ayarlar 
   BackColor       =   &H00FFFFC0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Ayarlar"
   ClientHeight    =   2520
   ClientLeft      =   5160
   ClientTop       =   5535
   ClientWidth     =   6285
   Icon            =   "ayarlar.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   NegotiateMenus  =   0   'False
   Picture         =   "ayarlar.frx":08CA
   ScaleHeight     =   2520
   ScaleWidth      =   6285
   ShowInTaskbar   =   0   'False
   Begin VB.CheckBox Check1 
      Caption         =   "ÞÝFRE SORGULAMA KAPALI"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3840
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   1440
      Width           =   2295
   End
   Begin VB.CommandButton kaydet_save 
      Caption         =   "Kaydet"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5040
      TabIndex        =   8
      Top             =   960
      Width           =   1095
   End
   Begin VB.CommandButton cikis 
      Cancel          =   -1  'True
      Caption         =   "Kapat"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4560
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   2040
      Width           =   975
   End
   Begin VB.CommandButton yeni 
      Caption         =   "Yeni Þifre"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3840
      TabIndex        =   6
      Top             =   960
      Width           =   1095
   End
   Begin VB.TextBox Text4 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   1800
      PasswordChar    =   "*"
      TabIndex        =   5
      Top             =   2040
      Width           =   1935
   End
   Begin VB.TextBox Text3 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   1800
      PasswordChar    =   "*"
      TabIndex        =   4
      Top             =   1560
      Width           =   1935
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   1800
      TabIndex        =   3
      Top             =   1080
      Width           =   1935
   End
   Begin VB.Image Image1 
      Height          =   870
      Left            =   0
      Picture         =   "ayarlar.frx":152F
      Stretch         =   -1  'True
      Top             =   0
      Width           =   6285
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Yeni Þifre Tekrar :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   0
      TabIndex        =   2
      Top             =   2040
      Width           =   1815
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Yeni Þifre :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   0
      TabIndex        =   1
      Top             =   1560
      Width           =   1695
   End
   Begin VB.Label kul_label 
      BackStyle       =   0  'Transparent
      Caption         =   "Kullanýcý Adý:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   0
      TabIndex        =   0
      Top             =   1080
      Width           =   1695
   End
End
Attribute VB_Name = "ayarlar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Check1_Click()
'burasý check 1 iþaretlenice regedit e iþaretler
Call savestring(HKEY_CURRENT_USER, "software\Stnc Software\", "Auto Start", Check1.Value)
'burasý da check in iþaterli olup olmamasýna göre iþlem yapar
If Check1.Value = 0 Then
Check1.Caption = "ÞÝFRE SORGULAMA AÇIK"
Else
Check1.Value = 1
Check1.Caption = "ÞÝFRE SORGULAMA KAPALI"
End If
End Sub

Private Sub exit_Click()
'bu kodlar programlarý kapatýr
Dim Form As Form
For Each Form In Forms
   Unload Form
   Set Form = Nothing
Next Form
'bu kodlar programdaki kodlari kapatýr
End Sub

Private Sub cikis_Click()
home.Show
Me.Hide
End Sub

Private Sub Form_Load()
Move (Screen.Width - Width) / 2, (Screen.Height - Height) / 2 'her çözünürlükte formun tam ortada kalmasýný saðlar
'her çözünürlükte formun tam ortada kalmasýný saðlar
'bu kýsýmda aslýnda yapay zeka kullnýmý söz konusu yani form yüklendiði zaman
'text ler renk lerile kapalý ve iþlemexz görünür
Text1.Enabled = False
Text3.Enabled = False
Text4.Enabled = False
Text1.BackColor = &H80000000
Text3.BackColor = &H80000000
Text4.BackColor = &H80000000
kaydet_save.Enabled = False
Check1.ToolTipText = "Baþlangýçta Þifre Sorgusunun Aktif Olmasý Ýçin Kullanýlýr "

'Text1 = coz(Text1)
'Text2 = coz(Text2)
'Call savestring(HKEY_CURRENT_USER, "software\Stnc Software\", "User", Text1.Text)
'Call savestring(HKEY_CURRENT_USER, "software\Stnc Software\", "Key", Text3.Text)
 
 Dim ShowAtStartup As Long
    
    ShowAtStartup = getstring(HKEY_CURRENT_USER, "Software\Stnc Software\", "Auto Start")
    If ShowAtStartup = 0 Then
        login.Hide
        'Unload login  'deðiþen 4
     'ayarlar.Show 'deðiþen 5
     'Exit Sub
    End If
    
    
    
        
    ' Set the checkbox, this will force the value to be written back out to the registry
    Me.Check1.Value = vbChecked
End Sub

Private Sub Form_Unload(Cancel As Integer)
'BU KODLARI DAHA SONRA SÝL
'bu kodlar programlarý kapatýr
Dim Form As Form
For Each Form In Forms
   Unload Form
   Set Form = Nothing
Next Form
'bu kodlar programdaki kodlari kapatýr

End Sub

Private Sub kaydet_save_Click()
'TEXT ' E GÝRÝLEN SAYIYI KONTROL EDER
'bu kýsýmdaki kontrol text kutusuna
'kaç karakter grildiðiini kontrol eder
'bu kontrolu yapmamýzý saglayan LEN fonksiyonudur
'LEN fonksiyonu Girilen karakterin kaç karakter oldugunu bildirir
'BEN BURADA 20 E KADAR KOYDUM EGER GÝRÝLEN KARAKTER 20 DEN
'BÜYÜKSE KULLNICI YI UYARIR
'BUNUN BÖYEL OLMASININ NEDENÝ ÞÝFRE GÝRÝÞÝNDEKÝ FORM LOAD OLAYINDA
'KONTROL VAR ORDA BOÞLUK ALGILAMAMASI
'ASLI SEBEB GÜVENLÝKdir

'text1 e girilmeyen veya 20 den büyük karakter kontrolü

'TEXT ' E GÝRÝLEN SAYIYI KONTROL EDER BÝTÝÞ
texta1 = Text1.Text
If Len(texta1) >= 20 Then
a1 = MsgBox("Kullanýcý Adý Kýsmýna " & Chr(10) & "Girmiþ Olduðunuz Karakter Sayýsý " & Len(texta1) & Chr(10) & "Lütfen 20 Karakterden Küçük Bir Sayý Giriniz", vbDefaultButton1 + vbOKOnly + vbCritical, "Hata")
Text1.Text = Clear
Text1.SetFocus
End If

'text2 e girilmeyen veya 20 den büyük karakter kontrolü
'Dim textb
'Dim textb1
'textb = Text2.Text
'If Len(textb) <= 0 Then
'b = MsgBox("Lütfen Eski Þifreyi Boþ Býrakmayýnýz", vbDefaultButton1 + vbOKOnly + vbCritical, "Hata")
'Text2.SetFocus
'End If
'TEXT ' E GÝRÝLEN SAYIYI KONTROL EDER BÝTÝÞ
'textb1 = Text2.Text
'If Len(textb1) >= 20 Then
'b1 = MsgBox("Hata Eski Þifre Kýsmýna " & Chr(10) & "Girmiþ Olduðunuz Karakter Sayýsý " & Len(textb1) & Chr(10) & "Lütfen 20 Karakterden Küçük Bir Sayý Giriniz", vbDefaultButton1 + vbOKOnly + vbCritical, "Hata")
'Text2.Text = Clear
'Text2.SetFocus
'End If

'text3 e girilmeyen veya 20 den büyük karakter kontrolü

'bu kýsýmý kullanýcýnýn 4 den fazla rakam girmesini önlemek için kullnamyý düþündüm
'Dim textcc
'Dim textcc1
'textcc = Text3.Text
'If Len(textcc) <= 5 Then
'cc = MsgBox("güvenliginiz için en az 4 sayý giriniz", vbDefaultButton1 + vbOKOnly + vbCritical, "Hata")
'Text3.SetFocus
'End If

'TEXT ' E GÝRÝLEN SAYIYI KONTROL EDER BÝTÝÞ
textc1 = Text3.Text
If Len(textc1) >= 21 Then
c1 = MsgBox("Hata Yeni Þifre Kýsmýna " & Chr(10) & "Girmiþ Olduðunuz Karakter Sayýsý " & Len(textc1) & Chr(10) & "Lütfen 20 Karakterden Küçük Bir Sayý Giriniz", vbDefaultButton1 + vbOKOnly + vbCritical, "Hata")
Text3.Text = Clear
Text3.SetFocus

End If

'text4 e girilmeyen veya 20 den büyük karakter kontrolü

'TEXT ' E GÝRÝLEN SAYIYI KONTROL EDER BÝTÝÞ
textd1 = Text4.Text
If Len(textd1) >= 21 Then
d1 = MsgBox("Hata Eski Þifre Tekrar Kýsmýna " & Chr(10) & "Girmiþ Olduðunuz Karakter Sayýsý " & Len(textd1) & Chr(10) & "Lütfen 20 Karakterden Küçük Bir Sayý Giriniz", vbDefaultButton1 + vbOKOnly + vbCritical, "Hata")
Text4.Text = Clear
Text4.SetFocus
End If

Dim users As String
Dim keys As String
Text1 = Kodla(Text1)
Call savestring(HKEY_CURRENT_USER, "software\Stnc Software\", "User", Text1.Text)

Dim textt As String                   'buraya text ü kontrol etmek için regedit den deðer girilcek
Text3 = Kodla(Text3)
Text4 = Kodla(Text4)
If Text3.Text = Text4.Text Then
'c = MsgBox("baþarýlý", vbDefaultButton1 + vbInformation + vbOKOnly, "ok")
'Call savestring(HKEY_CURRENT_USER, "software\Stnc Software\", "Kullanici", Text1.Text) 'burasý gereksiz hatta programýn yanlýþ yapmasýna neden olur
Call savestring(HKEY_CURRENT_USER, "software\Stnc Software\", "Key", Text3.Text)
Text3 = Kodla(Text3)
Text4 = Kodla(Text4)
Text1 = coz(Text1) 'aslýnda bu çok önemli bir ayrýntý bunu böyle yaptým çünkü program çalýþtýgý zaman bu
'olmasa idi program yazaýlan kullanýcý adýný þifreli gösterecekti
stnc = MsgBox("Lütfen Baþlangýçta Þifre Sorulmasý Ýçin" & Chr(10) & "Þifre Sorgula'nýn Açýk Olmasýna Dikkat Ediniz", vbDefaultButton1 + vbInformation + vbOKOnly, "Ýþlem Tamamlandý")
Else
a = MsgBox("Yeni Þifre Ve Yeni Þifre Tekrarý Uyuþmamaktadýr", vbDefaultButton1 + vbOKOnly + vbCritical, "Hata")
Text3.SetFocus
Text3.Text = Clear
Text4.Text = Clear

End If
End Sub



Private Sub Text1_Click()
Text1.BackColor = &HFFFFC0
End Sub

Private Sub Text3_Click()
Text3.BackColor = &HC0E0FF
End Sub

Private Sub Text4_Click()
Text4.BackColor = &HC0E0FF
End Sub

Private Sub yeni_Click()
'yeni tuþuna basýlýnca formun load olayýnda olaylar iptal edilir
Text1.Enabled = True
Text3.Enabled = True
Text4.Enabled = True
Text1.BackColor = &H80000005
Text3.BackColor = &H80000005
Text4.BackColor = &H80000005
kaydet_save.Enabled = True
Text1.SetFocus

'yeni tuþuna basýlýnca formun load olayýnda olaylar iptal edilir


End Sub
'bu þifreleme fonksiyonu yani girilen þifreleri güvenlik için þifreler
Function Kodla(kelime As String)
For i = 1 To Len(kelime)
g = Mid(kelime, i, 1)
a = Asc(g)
b = a + 10
If b > 255 Then b = b - 255
Mid(kelime, i, 1) = Chr(b)
Next i
Kodla = kelime
End Function
'yukardaki þifreleme fonksiyonunu çözer
'yani veri okunurken çözülür program bunu ancak böyle anlar
Function coz(kelime As String)
For i = 1 To Len(kelime)
g = Mid(kelime, i, 1)
a = Asc(g)
b = a - 10
If b < 0 Then b = b + 255
Mid(kelime, i, 1) = Chr(b)
Next i
coz = kelime
End Function

