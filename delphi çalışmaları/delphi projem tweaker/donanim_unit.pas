unit donanim_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,registry, jpeg, ExtCtrls;

type
  Tdonanim = class(TForm)
    iee: TCheckBox;
    lba: TCheckBox;
    intel: TCheckBox;
    Speak: TCheckBox;
    no_cd: TCheckBox;
    ana_sys: TCheckBox;
    ana_ag: TCheckBox;
    bellek: TCheckBox;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
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
    procedure ieeClick(Sender: TObject);
    procedure lbaClick(Sender: TObject);
    procedure intelClick(Sender: TObject);
    procedure SpeakClick(Sender: TObject);
    procedure no_cdClick(Sender: TObject);
    procedure ana_sysClick(Sender: TObject);
    procedure ana_agClick(Sender: TObject);
    procedure bellekClick(Sender: TObject);
    procedure Image9Click(Sender: TObject);
    procedure Image18Click(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure FormCreate(Sender: TObject);
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
  donanim: Tdonanim;

implementation

uses anamenu, baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, sistem_bil_unit, tweak_ui_unit, gorunum_unit,
  bil_soft_unit, taskman_unit, ag_unit, araclar, hakkinda;

{$R *.dfm}

procedure Tdonanim.ieeClick(Sender: TObject);
   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Services\dmadmin\Parameters',true);
  key0:= ('00');
  key1:= ('01');
   if iee.Checked=true  then
  reg.WriteInteger('EnableDynamicConversionFor1394',key0)
     else
       reg.WriteInteger('EnableDynamicConversionFor1394',key1) ;
     reg.Free;
       end;

procedure Tdonanim.lbaClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Services\atapi\Parameters',true);
  key0:= ('00');
  key1:= ('01');
   if lba.Checked=true  then
  reg.WriteInteger('EnableBigLba',key0)
     else
       reg.WriteInteger('EnableBigLba',key1) ;
     reg.Free;
       end;

procedure Tdonanim.intelClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Control\Class\{4D36E96A-E325-11CE-BFC1-08002BE10318}\0000',true);
  key0:= ('00');
  key1:= ('01');
   if intel.Checked=true  then
  reg.WriteInteger('EnableUDMA66',key0)
     else
       reg.WriteInteger('EnableUDMA66',key1) ;
     reg.Free;
       end;

procedure Tdonanim.SpeakClick(Sender: TObject);
   // farklý denenecek
    var
    reg : TRegistry;
        kayit1,kayit0 : String;
    begin
     kayit1:='Beep';
       kayit0:='Beep';
       reg:=TRegistry.Create;
    reg.RootKey:=HKEY_CURRENT_USER;
    reg.OpenKey('Control Panel\Sound',True);
    if Speak.Checked =true then
    reg.WriteString('yes',kayit1)
          else
    reg.WriteString('no',kayit0);
             reg.CloseKey;
   reg.Free;
   end;


procedure Tdonanim.no_cdClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if no_cd.Checked=true  then
  reg.WriteInteger('NoCDBurning',key0)
     else
       reg.WriteInteger('NoCDBurning',key1) ;
     reg.Free;
       end;
procedure Tdonanim.ana_sysClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Control\Session Manager\Memory Management',true);
  key0:= ('00');
  key1:= ('01');
   if ana_sys.Checked=true  then
  reg.WriteInteger('DisablePagingExecutive',key0)
     else
       reg.WriteInteger('DisablePagingExecutive',key1) ;
     reg.Free;
       end;

procedure Tdonanim.ana_agClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Services\Tcpip\Parameters',true);
  key0:= ('00');
  key1:= ('01');
   if ana_ag.Checked=true  then
  reg.WriteInteger('DisableTaskOffload',key0)
     else
       reg.WriteInteger('DisableTaskOffload',key1) ;
     reg.Free;
       end;

procedure Tdonanim.bellekClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Control\Session Manager\Memory Management',true);
  key0:= ('00');
  key1:= ('01');
   if bellek.Checked=true  then
  reg.WriteInteger('SecondLevelDataCache',key0)
     else
       reg.WriteInteger('SecondLevelDataCache',key1) ;
     reg.Free;
       end;

procedure Tdonanim.Image9Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Tdonanim.Image18Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure Tdonanim.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Tdonanim.FormCreate(Sender: TObject);
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

procedure Tdonanim.Label17Click(Sender: TObject);
begin
donanim.Visible:=false;
ana_mnu.show;

end;

procedure Tdonanim.Label18Click(Sender: TObject);
begin
donanim.Visible:=false;
baslat_form.show;

end;

procedure Tdonanim.Label19Click(Sender: TObject);
begin
donanim.Visible:=false;
guvenlik.show;

end;

procedure Tdonanim.Label20Click(Sender: TObject);
begin
donanim.Visible:=false;
guvenlik_2.show;

end;

procedure Tdonanim.Label24Click(Sender: TObject);
begin
  donanim.Visible:=false;
int_exp.show;

end;

procedure Tdonanim.Label23Click(Sender: TObject);
begin
donanim.Visible:=false;
internet_bil.show;

end;

procedure Tdonanim.Label21Click(Sender: TObject);
begin
donanim.Visible:=false;
sistem_bil.show;

end;

procedure Tdonanim.Label22Click(Sender: TObject);
begin
donanim.Visible:=false;
tweak_ui.show;

end;

procedure Tdonanim.Label25Click(Sender: TObject);
begin
donanim.Visible:=false;
gorunum.show;

end;

procedure Tdonanim.Label26Click(Sender: TObject);
begin
donanim.Visible:=false;
bil_soft.show;

end;

procedure Tdonanim.Label27Click(Sender: TObject);
begin
donanim.Visible:=false;
taskman_form.show;

end;

procedure Tdonanim.Label28Click(Sender: TObject);
begin
donanim.Visible:=false;
donanim.show;

end;

procedure Tdonanim.Label32Click(Sender: TObject);
begin

donanim.Visible:=false;
ag_net.show;

end;

procedure Tdonanim.Label31Click(Sender: TObject);
begin
donanim.Visible:=false;
araclar_form.show;

end;

procedure Tdonanim.Label29Click(Sender: TObject);
begin
//donanim.Visible:=false;
//ayarlar.show;

end;

procedure Tdonanim.Label30Click(Sender: TObject);
begin
donanim.Visible:=false;
hakkinda_form.show;

end;

procedure Tdonanim.Image4Click(Sender: TObject);
begin
donanim.Visible :=false;
ana_mnu.Show;
end;

procedure Tdonanim.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
