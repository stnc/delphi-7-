unit guvenlik2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, jpeg, ExtCtrls,registry;

type
  Tguvenlik_2 = class(TForm)
    Image1: TImage;
    Image2: TImage;
    bil_yonet: TCheckBox;
    wi_gun: TCheckBox;
    registry: TCheckBox;
    yet_disk: TCheckBox;
    akilli_kaydir: TCheckBox;
    sak_dll: TCheckBox;
    Image18: TImage;
    Image9: TImage;
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
    procedure bil_yonetClick(Sender: TObject);
    procedure wi_gunClick(Sender: TObject);
    procedure registryClick(Sender: TObject);
    procedure yet_diskClick(Sender: TObject);
    procedure akilli_kaydirClick(Sender: TObject);
    procedure sak_dllClick(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Image9Click(Sender: TObject);
    procedure Image18Click(Sender: TObject);
    procedure Label17Click(Sender: TObject);
    procedure Label18Click(Sender: TObject);
    procedure Label19Click(Sender: TObject);
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
  guvenlik_2: Tguvenlik_2;

implementation

uses anamenu, baslatUnit, guvenlikUnit, internet_explorer_unit,
  internet_unit, bil_soft_unit, gorunum_unit, tweak_ui_unit, donanim_unit,
  ag_unit, araclar, hakkinda, taskman_unit;

{$R *.dfm}

procedure Tguvenlik_2.FormCreate(Sender: TObject);
begin
   image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

procedure Tguvenlik_2.bil_yonetClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if bil_yonet.Checked=true  then
  reg.WriteInteger('NoManageMyComputerVerb',key0)
     else
       reg.WriteInteger('NoManageMyComputerVerb',key1) ;
     reg.Free;
       end;

procedure Tguvenlik_2.wi_gunClick(Sender: TObject);
// farklý sýradan deðer
    var
    reg : TRegistry;
    //AM, PM : String;
    kayit1,kayit0 : String;
    begin
     kayit1:='RegDone';
       kayit0:='RegDone';
    //PM:='P.M.';
    reg:=TRegistry.Create;
   reg.RootKey:=HKEY_LOCAL_MACHINE;
    reg.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',True);
    if  wi_gun.Checked =true then
    reg.WriteString('1',kayit1)
          else
    reg.WriteString('0',kayit0);
          //MyRegistry.WriteString('s2359',PM);
    reg.CloseKey;
    reg.Free;
 end;


procedure Tguvenlik_2.registryClick(Sender: TObject);
  var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\System',true);
  key0:= ('00');
  key1:= ('01');
   if registry.Checked=true  then
  reg.WriteInteger('DisableRegistryTools',key0)
     else
       reg.WriteInteger('DisableRegistryTools',key1) ;
     reg.Free;
       end;

procedure Tguvenlik_2.yet_diskClick(Sender: TObject);
  var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if yet_disk.Checked=true  then
  reg.WriteInteger('NoLowDiskSpaceChecks',key0)
     else
       reg.WriteInteger('NoLowDiskSpaceChecks',key1) ;
     reg.Free;
       end;


procedure Tguvenlik_2.akilli_kaydirClick(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Control Panel\Desktop',true);
  key0:= ('00');
  key1:= ('01');
   if akilli_kaydir.Checked=true  then
  reg.WriteInteger('SmoothScroll',key0)
     else
       reg.WriteInteger('SmoothScroll',key1) ;
     reg.Free;
       end;

procedure Tguvenlik_2.sak_dllClick(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if sak_dll.Checked=true  then
  reg.WriteInteger('AlwaysUnloadDLL',key0)
     else
       reg.WriteInteger('AlwaysUnloadDLL',key1) ;
     reg.Free;
       end;

procedure Tguvenlik_2.Image1MouseMove(Sender: TObject; Shift: TShiftState;
  X, Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Tguvenlik_2.Image9Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Tguvenlik_2.Image18Click(Sender: TObject);
begin
application.Terminate;
end;

procedure Tguvenlik_2.Label17Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
ana_mnu.show;

end;

procedure Tguvenlik_2.Label18Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
baslat_form.show;

end;

procedure Tguvenlik_2.Label19Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
guvenlik.show;

end;

procedure Tguvenlik_2.Label24Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
int_exp.show;

end;

procedure Tguvenlik_2.Label23Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
internet_bil.show;

end;

procedure Tguvenlik_2.Label21Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
bil_soft.show;

end;

procedure Tguvenlik_2.Label22Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
bil_soft.show;

end;

procedure Tguvenlik_2.Label25Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
gorunum.show;

end;

procedure Tguvenlik_2.Label26Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
tweak_ui.show;

end;

procedure Tguvenlik_2.Label27Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
taskman_form.show;

end;

procedure Tguvenlik_2.Label28Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
donanim.show;

end;

procedure Tguvenlik_2.Label32Click(Sender: TObject);
begin
guvenlik_2.Visible:=false;
ag_net.show;

end;

procedure Tguvenlik_2.Label31Click(Sender: TObject);
begin
gorunum.Visible:=false;
araclar_form.show;

end;

procedure Tguvenlik_2.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show;

end;

procedure Tguvenlik_2.Label30Click(Sender: TObject);
begin
gorunum.Visible:=false;
hakkinda_form.show;

end;

procedure Tguvenlik_2.Image4Click(Sender: TObject);
begin
guvenlik_2.Visible :=false;
ana_mnu.Show;
end;

procedure Tguvenlik_2.Image5Click(Sender: TObject);
begin
application.Terminate;
end;

end.
