unit Unit2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Buttons, ComCtrls, ShellCtrls;

type
  TForm2 = class(TForm)
    ShellTreeView1: TShellTreeView;
    tamam: TBitBtn;
    iptal: TBitBtn;
    Button1: TButton;

     procedure dosya_ara(StartDir, FileMask: string);

    procedure tamamClick(Sender: TObject);
    procedure iptalClick(Sender: TObject);// dosya aranýn delphi ye tanýtýlmasý gerek
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

uses proje_unit;

{$R *.dfm}


// klasor arama proceduru
procedure TForm2.dosya_ara(StartDir, FileMask: string);
var
  SR: TSearchRec;
  //DirList: TStringList;    //alt klasörleri de tarama için acýnýz
  IsFound: Boolean;
  //i: integer;              // alt klasörleri de tarama için acýnýz  alt kýsým
begin
  if StartDir[length(StartDir)] <> '\' then
    StartDir := StartDir + '\';


  IsFound :=
    FindFirst(StartDir+FileMask, faAnyFile-faDirectory, SR) = 0;
  while IsFound do begin

   form1. listbox1.Items.Add (StartDir + SR.Name);
    IsFound := FindNext(SR) = 0;
  end;
  FindClose(SR);
 // bu kýsmý acarsanýz sadece tek bir dizini degil onun altýndaki tüm dizinleri
 //tarayabilirsiniz
 { DirList := TStringList.Create;
  IsFound := FindFirst(StartDir+'*.*', faAnyFile, SR) = 0;
  while IsFound do begin
    if ((SR.Attr and faDirectory) <> 0) and
         (SR.Name[1] <> '.') then
      DirList.Add(StartDir + SR.Name);
    IsFound := FindNext(SR) = 0;
  end;
  FindClose(SR);

  for i := 0 to DirList.Count-1 do
    dosya_ara(DirList[i], FileMask);
  DirList.Free;  }
end; // klasör arama fonksiyonu sonu









procedure TForm2.tamamClick(Sender: TObject);

begin
form1.listbox1.Clear ; // listbox ý temizle
dosya_ara(ShellTreeView1.Path   ,'*bmp');//ShellTreeView de secilen klasoru
//form2.Free ;  // bellekten kaldýr
form2.Close ;// bu gereksiz ama beni kapat

form1.Enabled :=true;  // form 1 i kullanlýr  yap
form1.Show ;  // form1 i göster

//adýný al ve klasor ýcýnde ve alt dizinlerinde bmp dosyasý ara
end;

{procedure TForm2.Button2Click(Sender: TObject);
var
path: string;
begin
Path := ExtractFilePath(ParamStr(0));
Showmessage (path);   // test et mek isterseniz açýklmayý kaldýrýn
form1.listbox1.Clear ; // list box daki yuklü olanlarý temizle
dosya_ara(Path   ,'*bmp');// programýn çalýþtýgý klasördekileri yukle
end;  }


procedure TForm2.iptalClick(Sender: TObject);
begin
form2.Close ;//  beni kapat
//form2.Free ;  // bellekten kaldýr gereksiz acmayýn hata verrir bu durumda
form1.Enabled :=true;  // form 1 i kullanlýr  yap
form1.Show ;  // form1 i göster
end;

end.
