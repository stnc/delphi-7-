unit Unit1;
           {procedure...
var
  s: Integer;
begin
  for s := 0 to (ListBox1.Items.Count - 1) do begin
  try
    if ListBox1.Selected[s] then
    begin
    deletefile(listbox1.items.strings[s]);
    end;
   finally
   { do something here }



   //write('Kaçinci FIBONACCI sayisina kadar yazdirmak istiyorsunuz..=');
//readln(n);
//write(f1,' ',f2,' ');
interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    ListBox1: TListBox;
    Memo1: TMemo;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure ListBox1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);

var
birinci_deger,ikinci_deger:Integer;
n,adet,gecici_temp:integer;
olay:string;
begin
birinci_deger:=1;
ikinci_deger:=1;
adet:=2;
       Memo1.Clear;
 Memo1.Lines.Add(IntToStr(birinci_deger));
olay:=(listbox1.items.strings[listbox1.itemindex]);  // list box2deki daki secimin ne oldugu nu bulur
n:=StrToInt(olay);
repeat
gecici_temp:=birinci_deger;
birinci_deger:=ikinci_deger;
ikinci_deger:=gecici_temp+ikinci_deger;




Memo1.Lines.Add(IntToStr(ikinci_deger));
adet:=adet+1;
until adet=n;

     end;







procedure TForm1.ListBox1Click(Sender: TObject);
var
birinci_deger,ikinci_deger:Integer;
n,adet,gecici_temp:integer;
olay:string;
begin
birinci_deger:=1;
ikinci_deger:=1;
adet:=2;
       Memo1.Clear;
 Memo1.Lines.Add(IntToStr(birinci_deger));
olay:=(listbox1.items.strings[listbox1.itemindex]);  // list box2deki daki secimin ne oldugu nu bulur
n:=StrToInt(olay);
repeat
gecici_temp:=birinci_deger;
birinci_deger:=ikinci_deger;
ikinci_deger:=gecici_temp+ikinci_deger;




Memo1.Lines.Add(IntToStr(ikinci_deger));
adet:=adet+1;
until adet=n;
      end;
procedure TForm1.Button2Click(Sender: TObject);
var sayi:Integer;
begin
sayi:=StrToInt(InputBox('Sayý gir','sayi',''));
ListBox1.Items.Add(IntToStr (sayi));

end;

end.
