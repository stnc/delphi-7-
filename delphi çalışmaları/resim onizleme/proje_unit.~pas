////////////////////////////////////////////////////////////////////////
//
//   oosssosoos    soooooooooooosooo  soooo     soooooooo     soooNNNtosso     
//  ossooossoss    sssssssssooooosss  ssssos     oooooooo   sssoNNtsotNtto
// sossssssossos   soooooossooooooso  oosssos     soooos   soNNoossssotNos    
// osoos   ssoos   ssossssssoosssoso  ssssssos    oooos   oMNoosss   sNos    
// ossos    osos   soos  sssoo   sso  ossssss     ooos   oNNooss      sos    
// sooss    ooos   s    osoos    ss   osssssos    ooos  oNNoos       sos
// oooooos  ooss        oooNo         oooosssoo   ooos  otMNoo        sos    
//  ooooooss   s        stNNo         otoooootss  otos  oMNMss               
//  soooottss           sNNNo         oNtosotNNos oNoo  oMMMss
//  sstttotoos          oNNNo         oNNosoNNNts oNos  sMMMss               
//    sstNNNNtos        sNNNo         sNNo  oNNNtooNoo  sMMMss               
//     oooNNNNos        sNMNo         oNNo  soNNNsoNos  oMMMs
// so   ssoNNNoo        sNMNo         oNMo   osNNNsNoo  oMMMss               
// sM      oMMNo        sNMNo         oMNo    ssNNNMss  stMMoo         os
// oMs     stMNo        oNMMo         oMNo     oNMNMos   oMMoo        sto    
// oMs     stMoos       oMMMo         oNNos     oMNNos   stMNNo      soos
// oMos    oNMsos       sNNMo         oNMo      soMMos    oNMMoos   ooMss    
// oMMNooosNMooo      oooMMMoos     sooMMooo   s soMss     soMMNMtootNtos
// otoooMMMosoos      ooooooooo     oooooooo      soos      oootMMttsoss
// oossooosossss      ssoooooos     soooooos       sss       ssoosooooss
//                                                             ssssss
//
//
////////////////////////////////////////////////////////////////////////


unit proje_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, Menus, ComCtrls, ShellCtrls, StdCtrls, XPMan, ExtDlgs,IniFiles,registry,
  Buttons,ShellApi,JPEG ;
   //jpeg i jpeg kutuphanesini tanýmlamak için koyduk // open dialoð yoksa açmýyor


type
  TForm1 = class(TForm)
    ust_image: TImage;
    kose_image: TImage;
    kapat_image: TImage;
    simge_image: TImage;
    Image1: TImage;
    Image2: TImage;
    arka_fon_res: TImage;
    Image4: TImage;
    PopupMenu1: TPopupMenu;
    hakknda1: TMenuItem;
    exit1: TMenuItem;
    Panel2: TPanel;
    Image3: TImage;
    ListBox1: TListBox;
    XPManifest1: TXPManifest;
    ColorDialog1: TColorDialog;
    Edit1: TEdit;
    OpenPictureDialog1: TOpenPictureDialog;
    Metin_ren_button: TBitBtn;
    aratalan_renk: TBitBtn;
    ozel_klasor: TBitBtn;
    kas_ac: TBitBtn;
    ayar_kaydet: TBitBtn;
    res_tara: TBitBtn;
    res_ac: TBitBtn;
    resim_yeri: TLabel;
    Edit2: TEdit;
    procedure FormCreate(Sender: TObject);
    procedure kapat_imageClick(Sender: TObject);
    procedure simge_imageClick(Sender: TObject);
    procedure ust_imageMouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure kose_imageClick(Sender: TObject);


    procedure ListBox1Click(Sender: TObject);
 
    procedure Metin_ren_buttonClick(Sender: TObject);
    procedure aratalan_renkClick(Sender: TObject);
    procedure res_acClick(Sender: TObject);
    procedure res_taraClick(Sender: TObject);
    procedure ayar_kaydetClick(Sender: TObject);
    procedure ozel_klasorClick(Sender: TObject);
    procedure kas_acClick(Sender: TObject);
    procedure FormShow(Sender: TObject);


  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

uses Unit2, Unit3;

{$R *.dfm}
{$R ust_ok.RES}
{$R arka.RES}

//{$R sag_kose.RES}
//{$R sol_kose.RES}
//{$R alt.RES}
//{$R kapat.RES}
//{$R mini.RES}
//{$R mp10.RES}

// fare uzerinde iken olusacak hareket
//{$R mini_fare.RES}
//{$R kose_ust.RES}
//{$R ustunde_kapat.RES}



// procedure kullandým cunku baska resim skin eklemeyi dsundum ilerisi için
// ve kod karmaþýklýgý istemedim
Procedure mp10_skin ();
begin
form1.arka_fon_res.Picture.Bitmap.LoadFromResourceName (HInstance,'arka');
form1.kose_image.Picture.Bitmap.LoadFromResourceName ( HInstance ,'ust_ok');
end;




// form aclýr acýlmaz olacak olaylar
procedure TForm1.FormCreate(Sender: TObject);
begin
Form1.Position := poScreenCenter;// formu ekranýn tam ortasýna ayarla
 // fomun aclýsýna animasyon verme
{
animatewindow(handle,500,aw_center);

500: kaç milisaniyede gelsin isterseniz... 500 yarým saniyedir

aw_center: buraya nasýl gelsin isterseniz onu yazýn..

yani "aw_" yazýn ctrl+space yapýn orada neler yazýlabilir görürsünüz..

ayrýca aralarýna or operatörü kullanabilirsiniz..  }

animatewindow(handle,500,aw_ver_positive or aw_ver_negative or aw_center);

form1.Show ;// kendini göster aktif et
begin
mp10_skin //mp10_skin   procedurune git ve bütün resimleri yukle
end;

begin
listbox1.Clear;  // list box ý temizle gereksiz aslýnda burda :)
//listbox1.Items.Add('Boþ');
form2.dosya_ara('C:\windows\' ,'*jpg');  //dosya ara
form2.dosya_ara('C:\windows\' ,'*jpeg');  //dosya ara
 form2.dosya_ara('C:\windows\' ,'*jpeg');  //dosya ara
 form2.dosya_ara('C:\windows\' ,'*wmf');  //dosya ara
 form2.dosya_ara('C:\windows\' ,'*ico');  //dosya ara
form2.dosya_ara('C:\windows\' ,'*bmp');  //dosya ara
form2.dosya_ara('C:\windows\' ,'*emf');  //dosya ara
end;
end;
//image1.Picture.LoadFromFile('c:\windows\stnc.bmp');


procedure TForm1.kapat_imageClick(Sender: TObject);
begin
halt; //application.terminate; // programý kapat
end;

procedure TForm1.simge_imageClick(Sender: TObject);
begin
application.Minimize ; //formu simge durumuna küçült
end;


procedure TForm1.ust_imageMouseMove(Sender: TObject; Shift: TShiftState; X,Y: Integer);
begin
// formu istenilen yere taþýr
//iki ve us tunde  formda sorun cýkarýyor
releasecapture;
perform(wm_syscommand,$f012,0);
end;



procedure TForm1.kose_imageClick(Sender: TObject);
begin
// PopupMenu1.Popup(p.x, p.y);  menüyü istenilen yere konumlama
// normlade pop up menu farenin sol tusuna basýnca cýkar  bunu bu kod engeller
PopupMenu1.Popup(Mouse.CursorPos.X,mouse.CursorPos.Y);
end;







// list box da týklama yapýlýnca olacak olaylar
procedure TForm1.ListBox1Click(Sender: TObject);
var
  JPG:TJPEGIMAGE;
olay:string;
begin  //basla1
olay:=listbox1.items.strings[listbox1.itemindex];  // list box daki secimin ne oldugu nu bulur
//secili oln resimi onizleme yapmak için iamge1 de onizlemeye koyar
image3.Picture.LoadFromFile(olay);
resim_yeri.Caption :=olay;
end;//bitir basla1












// rengi hex koduna cevirmek için
// ayrýca bunu geliþtirip programlarýn hex turunde kodlarýný alabilirsiniz edit nesnesi
//gizlenmiþtir ou kullanrak yapabilirsizni
procedure TForm1.Metin_ren_buttonClick(Sender: TObject);

var TheRgbValue : TColorRef;

begin
  if ColorDialog1.Execute then  //color dialog u calýstýr
  begin
    TheRgbValue := ColorToRGB(ColorDialog1.Color);//hangi renk secildigini ogren
    // ozel renkleri seçmek istemediðim için color dialog özelliklerinden
    //cd prevetnfulopen ý true yaptým

edit1.Text  := Format('0x00%.2x%.2x%.2x', //rengi hex koduna cevir


[GetRValue(TheRGBValue),
GetGValue(TheRGBValue),
GetBValue(TheRGBValue)]);
//alt ta kullandýgým kod aslýnda bunu hex ceviriken windows bunu yukardaki sekliyle cevirmiyor
// 5ve 6 karakter ile 9 ve 10 karekterin yerini deðiþmesi lazým
//bunun için copy komutu ile yerlerini deðiþtirdim aslýnda bunu bulmam uzun sürdü hala tecrübe kazanýyorum
//substring gibi uzun bir yol düþünmüþtüm fakat bu daha kýsa

edit1.Text := copy(edit1.Text,1,4)+copy(edit1.Text,9,2)+copy(edit1.Text,7,2)+copy (edit1.Text,5,2);
Metin_ren_button.Font.Color := ColorDialog1.Color;

  end;
    end;


procedure TForm1.aratalan_renkClick(Sender: TObject);
var TheRgbValue : TColorRef;

begin
  if ColorDialog1.Execute then  //color dialog u calýstýr
  begin
    TheRgbValue := ColorToRGB(ColorDialog1.Color);//hangi renk secildigini ogren
    // ozel renkleri seçmek istemediðim için color dialog özelliklerinden
    //cd prevetnfulopen ý true yaptým

edit2.Text  := Format('0x00%.2x%.2x%.2x', //rengi hex koduna cevir


[GetRValue(TheRGBValue),
GetGValue(TheRGBValue),
GetBValue(TheRGBValue)]);
//alt ta kullandýgým kod aslýnda bunu hex ceviriken windows bunu yukardaki sekliyle cevirmiyor
// 5ve 6 karakter ile 9 ve 10 karekterin yerini deðiþmesi lazým
//bunun için copy komutu ile yerlerini deðiþtirdim aslýnda bunu bulmam uzun sürdü hala tecrübe kazanýyorum
//substring gibi uzun bir yol düþünmüþtüm fakat bu daha kýsa

edit2.Text := copy(edit1.Text,1,4)+copy(edit1.Text,9,2)+copy(edit1.Text,7,2)+copy (edit1.Text,5,2);
aratalan_renk.Font.Color := ColorDialog1.Color;

  end;
 end;

procedure TForm1.res_acClick(Sender: TObject);
begin
if OpenPictureDialog1.Execute then  // open dialog kutusunu calýþtýr

image3.Picture.LoadFromFile( OpenPictureDialog1.FileName); //opendialogun calþmasý ile
//listbox1.Items.Add(openpicturedialog1.FileName );
resim_yeri.Caption := (openpicturedialog1.FileName );
//seçilen dosyanýn yolunu al sonra image1 de onizlemesini yap yani resmi göster

end;

procedure TForm1.res_taraClick(Sender: TObject);
begin
form2.Show ;
form1.Enabled :=false;
end;





procedure TForm1.ayar_kaydetClick(Sender: TObject);
var
ini_yaz:TIniFile;
uzn:integer;
//olay:string;
begin
//lenght fonksiyonu ifanin kaç karakter oldugunu soyler
//burda amacým her hangi bir klasor secildiyse o klasorunun yolunu form 3 de
//bulunan  yol_klaor isimli label a yazmak dý bu sekilde diger formdaki bilgiyi alabilirdim
//programcýlýkta careler tukenmiyor her þeyin bir uzun ve kýsa yolu var
//yol_klaor  isimli labelda bir yazý varsa onun uzunlugu sýfýrdan büyükse
//ini dosyasý yazma aktif hale gelir deðilse bir iþlem olmaz
uzn := length(form3.yol_klaor.Caption);   //ayar_kaydet.Caption   := inttostr (uzn);
if  uzn >0 then //bunu hata onlemek ve ratgele bir yere ini yazmasýný onlemek için yaptým 
begin
ini_yaz:=TIniFile.Create( form3.yol_klaor.Caption+'\Desktop.ini');  //c de ayarlar.ini dosyasý
//acar ve oraya kayýt yapar
//olay:=listbox1.items.strings[listbox1.itemindex];
ini_yaz.WriteString('ExtShellFolderViews','{BE098140-A513-11D0-A3A4-00C04FD706EC}','{BE098140-A513-11D0-A3A4-00C04FD706EC}');
ini_yaz.WriteString('{BE098140-A513-11D0-A3A4-00C04FD706EC}','Attributes','1');
ini_yaz.WriteString('{BE098140-A513-11D0-A3A4-00C04FD706EC}','IconArea_Image',resim_yeri.Caption );
ini_yaz.WriteString('{BE098140-A513-11D0-A3A4-00C04FD706EC}','IconArea_Text',edit1.Text );
ini_yaz.WriteString('{BE098140-A513-11D0-A3A4-00C04FD706EC}','IconArea_TextBackground',edit2.Text);
ini_yaz.WriteString('.ShellClassInfo','ConfirmFileOp','0');
ini_yaz.UpdateFile;  //kayýtý güncel tutar
ini_yaz.Free;
FileSetAttr (form3.yol_klaor.Caption+'\Desktop.ini',faSysFile  + faHidden); // bu bu kod tek basýna kullanýlýr dosya gizlemek salt okunur yapmak içindir

end
//else   // bununla ilgili teori dir
//deletefile(form3.yol_klaor.Caption+'\Desktop.ini'); // delete file dosya siler
//showmessage  ('boþ')   // test için


end;
 //[{BE098140-A513-11D0-A3A4-00C04FD706EC}]
{Attributes=1
IconArea_Image=C:\WINDOWS\Prairie Wind.bmp
IconArea_Text=0x004080FF
IconArea_TextBackground=0x00408000}





procedure TForm1.ozel_klasorClick(Sender: TObject);
begin
form3.Show ;
form1.Enabled :=false;
end;

procedure TForm1.kas_acClick(Sender: TObject);
 begin

ShellExecute(Handle, 'explore', PChar(form3.yol_klaor), nil, nil, SW_SHOW);

//WinExec('explore form3.yol_klaor', SW_SHOWNORMAL);
//ShellExecute(0,'explore', form3.yol_klaor,nil,nil,SW_SHOWNORMAL);
  end;
procedure TForm1.FormShow(Sender: TObject);
var
  parametre: string;
begin
{exe icerisine disaridan gelen Parametre
paramstr fonsiyonuna 1 ekleyenek bulunabilir.
Bu eklenen birinci Parametredir.
Örnek:
}
  parametre := ParamStr(1);
if Parametre = '/komut' then
begin
 showmessage (GetCurrentDir);
ozel_klasor.Visible  :=false;
kas_ac.Visible  :=false;
//ExtractFilePath(Application.ExeName) : gecerli kaloru verir bazenb calýþmaz
form3.yol_klaor.Caption :=GetCurrentDir ;

end;
end;
end.








