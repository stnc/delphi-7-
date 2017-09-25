unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  Registry, StdCtrls;{Burada Delphi'ye Registry bileþenini tanýttým.}

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Button1: TButton;
    Label1: TLabel;
    Label2: TLabel;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  Reg:Tregistry; {Ýþim kolaylaþsýn diye burada Tregistry'i Reg deðiþkenine
                  atadým.}
  implementation

{$R *.DFM}

procedure TForm1.Button1Click(Sender: TObject);
begin
Reg:=Tregistry.Create; {Registry bileþenini yaratýldý.}
Reg.RootKey:=HKEY_LOCAL_MACHINE; {Kök Anahtarýmýz.}
Reg.OpenKey('\system\currentcontrolset\control',false);
{Açmak istediðim alt anahtarý girdim.}
{Eðer anahtarý bulamazsa, girilen anahtarý registry'de yaratmamasý için false
 parametresini ekledim.}
edit1.text:=reg.ReadString('current user');
{Okumasýný istediðim anahtarý yazdým.}
reg.OpenKey('\system\currentcontrolset\control\computername\computername',false);
edit2.text:=reg.ReadString('ComputerName');
end;

end.
