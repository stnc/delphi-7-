unit internet_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, XPMan, Buttons, jpeg;

type
  Tinternet_bil = class(TForm)
    Image1: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Label6: TLabel;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Image2: TImage;
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    BitBtn3: TBitBtn;
    BitBtn4: TBitBtn;
    BitBtn5: TBitBtn;
    XPManifest1: TXPManifest;
    Image9: TImage;
    Image18: TImage;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    Label22: TLabel;
    Label21: TLabel;
    Label23: TLabel;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    Label28: TLabel;
    Label30: TLabel;
    Label29: TLabel;
    Label31: TLabel;
    Label32: TLabel;
    Image4: TImage;
    Image5: TImage;
    procedure FormCreate(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Image18Click(Sender: TObject);
    procedure Image9Click(Sender: TObject);
    procedure Label17Click(Sender: TObject);
    procedure Label18Click(Sender: TObject);
    procedure Label19Click(Sender: TObject);
    procedure Label20Click(Sender: TObject);
    procedure Label24Click(Sender: TObject);
    procedure Label23Click(Sender: TObject);
    procedure Label21Click(Sender: TObject);
    procedure Label22Click(Sender: TObject);
    procedure Label25Click(Sender: TObject);
    procedure Label26Click(Sender: TObject);
    procedure Label27Click(Sender: TObject);
    procedure Label28Click(Sender: TObject);
    procedure Label32Click(Sender: TObject);
    procedure Label31Click(Sender: TObject);
    procedure Label29Click(Sender: TObject);
    procedure Label30Click(Sender: TObject);
    procedure Image4Click(Sender: TObject);
    procedure Image5Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  internet_bil: Tinternet_bil;

implementation

uses anamenu, baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  sistem_bil_unit, tweak_ui_unit, gorunum_unit, bil_soft_unit,
  taskman_unit, donanim_unit, ag_unit, araclar,registry;

{$R *.dfm}

procedure Tinternet_bil.FormCreate(Sender: TObject);
 var
R:Tregistry;
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');

R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Internet Explorer\Main',false);
if R.ValueExists('Wizard_Version') then
 Edit1.Text:=(R.ReadString ('Wizard_Version'));
  //else
//Edit1.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;
begin

R:=TRegistry.Create;
R.RootKey:=HKEY_CURRENT_USER;
R.OpenKey('Software\Microsoft\Internet Explorer\Main',false);
if R.ValueExists('Window title') then
 Edit6.Text:=(R.ReadString ('Window title')) ;
  //else
//Edit2.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;
 begin
 R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('Software\Microsoft\Internet Explorer\Main',false);
if R.ValueExists('Local Page') then
Edit2.Text:=(R.ReadString ('Local Page')) ;
R.CloseKey;
R.free;
 begin
 R:=TRegistry.Create;
R.RootKey:=HKEY_CURRENT_USER;
R.OpenKey('Software\Microsoft\Internet Explorer\Main',false);
if R.ValueExists('Start Page') then
Edit4.Text:=(R.ReadString ('Start Page')) ;
R.CloseKey;
R.free;
begin
 R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('Software\Microsoft\Internet Explorer\Search',false);
if R.ValueExists('SearchAssistant') then
Edit5.Text:=(R.ReadString ('SearchAssistant')) ;
R.CloseKey;
R.free;
begin
 R:=TRegistry.Create;
R.RootKey:=HKEY_CURRENT_USER;
R.OpenKey('Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders',false);
if R.ValueExists('Cache') then
Edit3.Text:=(R.ReadString ('Cache')) ;
R.CloseKey;
R.free;
end;
end;
end;
end;
end;
end;
procedure Tinternet_bil.Image1MouseMove(Sender: TObject;
  Shift: TShiftState; X, Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Tinternet_bil.Image18Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure Tinternet_bil.Image9Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Tinternet_bil.Label17Click(Sender: TObject);
begin
internet_bil.Visible:=false;
ana_mnu.show;

end;

procedure Tinternet_bil.Label18Click(Sender: TObject);
begin
internet_bil.Visible:=false;
baslat_form.show;

end;

procedure Tinternet_bil.Label19Click(Sender: TObject);
begin
//internet_bil.Visible:=false;
//guvenlik _2.show;

end;

procedure Tinternet_bil.Label20Click(Sender: TObject);
begin
internet_bil.Visible:=false;
guvenlik_2.show;

end;

procedure Tinternet_bil.Label24Click(Sender: TObject);
begin
//internet_bil.Visible:=false;
//internet_bil.show;

end;

procedure Tinternet_bil.Label23Click(Sender: TObject);
begin
internet_bil.Visible:=false;
int_exp.show

end;

procedure Tinternet_bil.Label21Click(Sender: TObject);
begin
internet_bil.Visible:=false;
sistem_bil.show;

end;

procedure Tinternet_bil.Label22Click(Sender: TObject);
begin
internet_bil.Visible:=false;
tweak_ui.show;

end;

procedure Tinternet_bil.Label25Click(Sender: TObject);
begin
internet_bil.Visible:=false;
gorunum.show;

end;

procedure Tinternet_bil.Label26Click(Sender: TObject);
begin
internet_bil.Visible:=false;
bil_soft.show;

end;

procedure Tinternet_bil.Label27Click(Sender: TObject);
begin
internet_bil.Visible:=false;
taskman_form.show;

end;

procedure Tinternet_bil.Label28Click(Sender: TObject);
begin
internet_bil.Visible:=false;
donanim.show;

end;

procedure Tinternet_bil.Label32Click(Sender: TObject);
begin
internet_bil.Visible:=false;
ag_net.show;

end;

procedure Tinternet_bil.Label31Click(Sender: TObject);
begin
gorunum.Visible:=false;
araclar_form.show;

end;

procedure Tinternet_bil.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show;

end;

procedure Tinternet_bil.Label30Click(Sender: TObject);
begin
gorunum.Visible:=false;
internet_bil.show;
end;

procedure Tinternet_bil.Image4Click(Sender: TObject);
begin
internet_bil.Visible :=false;
 ana_mnu.Show;
end;

procedure Tinternet_bil.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
