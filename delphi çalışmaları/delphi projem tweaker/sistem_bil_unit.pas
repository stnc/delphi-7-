unit sistem_bil_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls,registry;

type
  Tsistem_bil = class(TForm)
    Image1: TImage;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Edit6: TEdit;
    Edit7: TEdit;
    Edit8: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
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
    procedure Image9Click(Sender: TObject);
    procedure Image18Click(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
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
  sistem_bil: Tsistem_bil;

implementation

uses anamenu, baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, tweak_ui_unit, gorunum_unit, bil_soft_unit, taskman_unit,
  donanim_unit, ag_unit, araclar, hakkinda;

{$R *.dfm}

procedure Tsistem_bil.FormCreate(Sender: TObject);
var
R:Tregistry;
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');

begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('CurrentVersion') then
 edit2.Text:=(R.ReadString ('CurrentVersion'))
  else
edit2.Text:=('Dize bulunamadý');
R.CloseKey;
R.free;

begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('CurrentBuildNumber') then
 edit3.Text:=(R.ReadString ('CurrentBuildNumber'))
  else
edit3.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;


begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('ProductId') then
 edit4.Text:=(R.ReadString ('ProductId'))
  else
edit4.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;


 begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('ProductName') then
 edit1.Text:=(R.ReadString ('ProductName'))
  else
edit1.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;

 begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('SourcePath') then
 edit8.Text:=(R.ReadString ('SourcePath'))
  else
edit8.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;

begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('RegisteredOrganization') then
 edit6.Text:=(R.ReadString ('RegisteredOrganization'))
  else
edit6.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;


begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('PathName') then
 edit7.Text:=(R.ReadString ('PathName'))
  else
edit7.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;

begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('BuildLab') then
 edit5.Text:=(R.ReadString ('BuildLab'))
  else
edit5.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;

end;
end;
end;
end;
end;
end;
end;
end;
end;
procedure Tsistem_bil.Image9Click(Sender: TObject);
begin
application.Minimize;
end;

procedure Tsistem_bil.Image18Click(Sender: TObject);
begin
application.Terminate;
end;

procedure Tsistem_bil.Image1MouseMove(Sender: TObject; Shift: TShiftState;
  X, Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;



procedure Tsistem_bil.Label17Click(Sender: TObject);
begin
 sistem_bil.Visible:=false;
ana_mnu.show;

end;

procedure Tsistem_bil.Label18Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
baslat_form.show;

end;

procedure Tsistem_bil.Label19Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
guvenlik.show;

end;

procedure Tsistem_bil.Label20Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
guvenlik_2.show;

end;

procedure Tsistem_bil.Label24Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
int_exp.show;

end;

procedure Tsistem_bil.Label23Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
internet_bil.show;

end;

procedure Tsistem_bil.Label21Click(Sender: TObject);
begin
//sistem_bil.Visible:=false;
//sistem_bil.show;

end;

procedure Tsistem_bil.Label22Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
tweak_ui.show;

end;

procedure Tsistem_bil.Label25Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
gorunum.show;

end;

procedure Tsistem_bil.Label26Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
bil_soft.show;

end;

procedure Tsistem_bil.Label27Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
taskman_form.show;

end;

procedure Tsistem_bil.Label28Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
donanim.show;

end;

procedure Tsistem_bil.Label32Click(Sender: TObject);
begin
sistem_bil.Visible:=false;
ag_net.show;

end;

procedure Tsistem_bil.Label31Click(Sender: TObject);
begin
gorunum.Visible:=false;
araclar_form.show;

end;

procedure Tsistem_bil.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show;

end;

procedure Tsistem_bil.Label30Click(Sender: TObject);
begin
gorunum.Visible:=false;
hakkinda_form.show;

end;

procedure Tsistem_bil.Image4Click(Sender: TObject);
begin
sistem_bil.Visible :=false;
ana_mnu.Show ;
end;

procedure Tsistem_bil.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
