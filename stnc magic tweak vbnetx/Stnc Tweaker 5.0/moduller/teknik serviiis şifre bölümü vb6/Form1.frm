VERSION 5.00
Begin VB.Form login 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Þifre Giriþi"
   ClientHeight    =   2760
   ClientLeft      =   3075
   ClientTop       =   240
   ClientWidth     =   4245
   FillColor       =   &H00C0C0C0&
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   162
      Weight          =   700
      Underline       =   0   'False
      Italic          =   -1  'True
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H80000001&
   HasDC           =   0   'False
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "Form1.frx":0442
   ScaleHeight     =   2760
   ScaleWidth      =   4245
   Begin VB.CommandButton tam_am 
      Caption         =   "Tamam"
      Default         =   -1  'True
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1560
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CheckBox Check1 
      BackColor       =   &H00FF8080&
      Caption         =   "Þifremi Hatýrla"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000007&
      Height          =   255
      Left            =   1680
      MaskColor       =   &H00404040&
      OLEDropMode     =   1  'Manual
      TabIndex        =   5
      Top             =   1920
      Width           =   1815
   End
   Begin VB.CommandButton cikis 
      Cancel          =   -1  'True
      Caption         =   "ÇIKIÞ"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   162
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3000
      MaskColor       =   &H80000014&
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   2280
      Width           =   1095
   End
   Begin VB.TextBox Text2 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   1680
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   1560
      Width           =   2295
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   162
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   1680
      TabIndex        =   2
      Top             =   1080
      Width           =   2295
   End
   Begin VB.Label sifre 
      BackStyle       =   0  'Transparent
      Caption         =   "Þifre :"
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
      Width           =   1215
   End
   Begin VB.Label Kul_ad 
      BackStyle       =   0  'Transparent
      Caption         =   "Kullanýcý Adý :"
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
      Width           =   1455
   End
   Begin VB.Image Image1 
      Height          =   870
      Left            =   0
      Picture         =   "Form1.frx":0D97
      Top             =   0
      Width           =   4545
   End
End
Attribute VB_Name = "login"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'*********************************************************************************
'bu programdaki kodlar 05 .aðustos 2005 tarihinde selman tunc tarafýndan yazýldý
'PROGRAMM BY:SELMAN TUNC
'NÝCK: STNC
'SÜRÜM TARÝHÝ: ?
'TAKIMI:NO-TR TEAM
'PROGRAM ADI:TEKNÝK SERVÝS TAKÝP
'SÜRÜM :1.05
'AMACI:BÝLGÝSAYAR TAMÝRÝ ÝÞYLE VE SATIÞIYLA ÝLGÝLENLERÝN BÝLGÝSAYAR SORUNLARI VE MÜÞTERÝLERÝNÝ TAKÝP ETMESÝ ÝÇÝN YAZILDI
'FÝYATI :ÞU AN ÝLK SÜRÜM OLDUGU ÝÇÝN ÜCRETSÝZ OLASI DÜÞÜNÜLÜYOR
'SON OLARAK  :
'EKÝP ARAKADAÞLARI:
'SON BÝR HATIRA DAHA CHECK1.VALUE KONTROLUNU NERO YA KEYGEN NASIL YAZARIM DERKEN ÖGRENDÝM
'******************************************************************************************

Private Sub Check1_Click()
Dim users As String
Dim keys As String
'Static hatali As Integer 'güvenligi kapatmak içn açýlabilir 'bu deger hatali deðerine gönderme yapar
If Check1.Value = 1 Then 'YANÝ KULLANICI eger check i iþaerledi ise -->
've þifreler dogru ise yani þu anki kontroller
users = getstring(HKEY_CURRENT_USER, "software\Stnc Software\", "User")
keys = getstring(HKEY_CURRENT_USER, "software\Stnc Software\", "Key")
users = coz(users)  'bunlar fonksiyon olarak daha önce bunlara sifre koymuþtuk
keys = coz(keys) 'coz fonksiyonu ile girilen þifreler regeditden gercege uygun olrak çözümlenir
'bu kodlama genel olarak programa girmek isteyenlerin þifreyi regeditden görememesi içindir

If (Text1.Text = users And Text2.Text = keys) Then  'burada ise þifreler text1deki þifre ile
Call savestring(HKEY_CURRENT_USER, "software\Stnc Software\", "Auto Start", Check1.Value) 'check1 olayýnýn regedite yazlýp okunmasýný saðlar
'text2 deki þifre ayný ise uyuþuyorsa aþagýdaki olaylar baþlar
'Me.Hide
'ayarlar.Show
Else 'eger þifreler uyuþmuyorsa


'BU KISIM GÜVENLÝÐÝ KAPATMAK ÝÇÝN AÇILABÝLÝR
'hatali = hatali + 1 'girilen veri yi her yanlýþda bir artýrýr
'tam_am.Caption = "Yanlýþ " & hatali 'hatalarý form daki tamam tusunda yazar

'If hatali = 3 Then 'eger hata sayýsý 3 olursa program aþagýdaki hata mesajýný verir ve kapanýr
'a = MsgBox("3 Defa Hatalý Giriþ Yaptýnýz", vbDefaultButton1 + vbOKOnly + vbInformation)
'End If
'BU KISIM GÜVENLÝÐÝ KAPATMAK ÝÇÝN AÇILABÝLÝR



Text1.SetFocus   'imleç text1 e gider oraya odaklanýr
a = MsgBox("Kullanýcý Adý Veya Þifre Yanlýþ", vbDefaultButton1 + vbOKOnly + vbInformation)
'ÇOK ÖNEMLÝ form load olaynda burdaki kýsýmdan regeditden check in o olup olmayacagýný kontrol edecek o ise burdaki text2 yi silecek
Text1.Text = Clear
Text2.Text = Clear
End If 'bu end if ler kaç tane if açtý isek o kadar koyarak kapatmak içindir
End If

End Sub

Private Sub cikis_Click()
'bu kodlar programlarý kapatýr
Dim Form As Form
For Each Form In Forms
   Unload Form
   Set Form = Nothing
Next Form
'bu kodlar programdaki kodlari kapatýr
End Sub
Private Sub Form_Load()
Move (Screen.Width - Width) / 2, (Screen.Height - Height) / 2 'her çözünürlükte formun tam ortada kalmasýný saðlar

'burdaki kodlar formun ilk açlýþýndaki yani programda
'þifre olup olmamasýný kontrol eder
Dim users As String
Dim keys As String
users = getstring(HKEY_CURRENT_USER, "Software\Stnc Software\", "User") 'regeditden user ý okur
keys = getstring(HKEY_CURRENT_USER, "Software\Stnc Software\", "Key") 'regedit den þifre yi okur
'MsgBox kul 'bu kod sadece deneme amaclý kullanýlabilir
If (users = "" And keys = "") Then 'Eger porgram da yani user ve       '
'kullanýcý boþ ise
'ayarlar.Text1 = ""
'Text1 = coz(Text1)
'ayarlar.Text2 = ""
'UNUTMA BURAYI KESÝNLÝKLE AÇ PROJE BÝTÝMÝNDE
'login.Hide  'þifre ekraný kaybolur
home.Show  'ana menü açýlýr   'DEÐÝÞEN 1

End If
    

'ÇOK ÖNEMLÝ burdaki kýsýmdan regeditden check in o olup olmayacagýný kontrol edecek o ise burdaki text2 yi silecek
Dim ShowAtStartup As Long
    
ShowAtStartup = getstring(HKEY_CURRENT_USER, "Software\Stnc Software\", "Auto Start") 'burasý programýn baþlangýç da görünüp görünmeyecegini kontrol eder
If ShowAtStartup = 1 Then 'eger regedit den okunan deger 1 ise yani checkbox iþaretli ise (yani value degeri 1 ise)
        
home.Show  'yukardaki ifadeler dogru ise þifre isteyen bölüm gizlenir
'Unload login 'bu da kullanýlabilir ama formu tamamen kapatabilir
login.Hide    'ana menüyü gösterir  'DEÐÝÞEN 2
'Unload login 'ayný modelin bu þekilde kullaným daha mantýklýdýr
Else 'yukarda þartlara uymuyorsa
ShowAtStartup = 0 'yani deger 0 ise
Check1.Value = 0 'check1 in degeri sýfýr olarak görülür
Exit Sub

' burasý regedt den okur yazar
Me.Check1.Value = vbChecked
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
'bu kodlar programlarý kapatýr
Dim Form As Form
For Each Form In Forms
   Unload Form
   Set Form = Nothing
Next Form
'bu kodlar programdaki formlarý kapatýr
End Sub

Private Sub tam_am_Click()
'kullanýcý tamam dediði zaman girilen þifreler regedit den sorgulanýr
'sorgulama komutu "getstring" dir
Dim users As String
Dim keys As String
Static hatali As Integer 'bu deger hatali deðerine gönderme yapar
'users = coz(users)  'bunlar fonksiyon olarak daha önce bunlara sifre koymuþtuk
'keys = coz(keys) 'coz fonksiyonu ile girilen þifreler regeditden gercege uygun olrak çözümlenir
users = getstring(HKEY_CURRENT_USER, "software\Stnc Software\", "User")
keys = getstring(HKEY_CURRENT_USER, "software\Stnc Software\", "Key")
users = coz(users)  'bunlar fonksiyon olarak daha önce bunlara sifre koymuþtuk
keys = coz(keys) 'coz fonksiyonu ile girilen þifreler regeditden gercege uygun olrak çözümlenir
'bu kodlama genel olarak programa girmek isteyenlerin þifreyi regeditden görememesi içindir
If (Text1.Text = users And Text2.Text = keys) Then  'burada ise þifreler text1deki þifre ile
'text2 deki þifre ayný ise uyuþuyorsa aþagýdaki olaylar baþlar
'Form2.Text1 = kul 'bunlar genel olrak gereksizdir sadece form 2 ye çözülen þifrelerin
'Form2.Text2 = sif 'form 2 nin text1 inde gözükmesini saðlar
users = coz(users)  'bunlar fonksiyon olarak daha önce bunlara sifre koymuþtuk
keys = coz(keys) 'coz fonksiyonu ile girilen þifreler regeditden gercege uygun olrak çözümlenir
login.Hide
home.Show

Else 'eger þifreler uyuþmuyorsa
Text1.Text = Clear 'text1 i temizler
Text2.Text = Clear 'text2 i temizler
Text1.SetFocus   'imleç text1 e gider oraya odaklanýr
hatali = hatali + 1 'girilen veri yi her yanlýþda bir artýrýr
tam_am.Caption = "Hata " & hatali 'hatalarý form daki tamam tusunda yazar
If hatali = 3 Then 'eger hata sayýsý 3 olursa program aþagýdaki hata mesajýný verir ve kapanýr
a = MsgBox("3 Defa Hatalý Giriþ Yaptýnýz", vbDefaultButton1 + vbOKOnly + vbInformation)
'bu kodlar programlarý kapatýr
Dim Form As Form
For Each Form In Forms
Unload Form
Set Form = Nothing
Next Form
'bu kodlar programdaki formlarý kapatýr

End If
End If
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
