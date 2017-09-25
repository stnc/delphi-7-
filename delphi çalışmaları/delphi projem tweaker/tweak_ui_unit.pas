unit tweak_ui_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, jpeg, StdCtrls, ExtCtrls,registry;

type
  Ttweak_ui = class(TForm)
    Image1: TImage;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    CheckBox5: TCheckBox;
    CheckBox6: TCheckBox;
    CheckBox7: TCheckBox;
    CheckBox8: TCheckBox;
    CheckBox9: TCheckBox;
    Image2: TImage;
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
    procedure CheckBox1Click(Sender: TObject);
    procedure CheckBox2Click(Sender: TObject);
    procedure CheckBox3Click(Sender: TObject);
    procedure CheckBox4Click(Sender: TObject);
    procedure CheckBox5Click(Sender: TObject);
    procedure CheckBox6Click(Sender: TObject);
    procedure CheckBox7Click(Sender: TObject);
    procedure CheckBox8Click(Sender: TObject);
    procedure CheckBox9Click(Sender: TObject);
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
  tweak_ui: Ttweak_ui;

implementation

uses anamenu, baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, bil_soft_unit, gorunum_unit, taskman_unit, donanim_unit,
  ag_unit, araclar, hakkinda;

{$R *.dfm}

procedure Ttweak_ui.FormCreate(Sender: TObject);
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

procedure Ttweak_ui.CheckBox1Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE;
  reg.OpenKey('SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox1.Checked=true  then
  reg.WriteInteger('EnableFirewall',key0)
     else
       reg.WriteInteger('EnableFirewall',key1) ;
     reg.Free;
       end;

procedure Ttweak_ui.CheckBox2Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox2.Checked=true  then
  reg.WriteInteger('HideFileExt',key0)
     else
       reg.WriteInteger('HideFileExt',key1) ;
     reg.Free;
       end;

procedure Ttweak_ui.CheckBox3Click(Sender: TObject);
    var
    reg : TRegistry;
    //AM, PM : String;
    kayit1,kayit0 : String;
    begin
     kayit1:='Shell Icon BPP';
       kayit0:='Shell Icon BPP';
    //PM:='P.M.';
   reg:=TRegistry.Create;
    reg.RootKey:=HKEY_LOCAL_MACHINE;
    reg.OpenKey('Control Panel\Desktop\WindowMetrics',True);
    if  CheckBox3.Checked =true then
    reg.WriteString('16',kayit1)
          else
    reg.WriteString('',kayit0);
          //MyRegistry.WriteString('s2359',PM);
   reg.CloseKey;
    reg.Free;
 end;

procedure Ttweak_ui.CheckBox4Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Control Panel\Desktop',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox4.Checked=true  then
  reg.WriteInteger('PaintDesktopVersion',key0)
     else
       reg.WriteInteger('PaintDesktopVersion',key1) ;
     reg.Free;
       end;

procedure Ttweak_ui.CheckBox5Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox5.Checked=true  then
  reg.WriteInteger('NoActiveDesktop',key0)
     else
       reg.WriteInteger('NoActiveDesktop',key1) ;
     reg.Free;
       end;

procedure Ttweak_ui.CheckBox6Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox6.Checked=true  then
  reg.WriteInteger('ShowInfoTip',key0)
     else
       reg.WriteInteger('ShowInfoTip',key1) ;
     reg.Free;
       end;

procedure Ttweak_ui.CheckBox7Click(Sender: TObject);
    // farklý denenecek
    var
    reg : TRegistry;
    //AM, PM : String;
    kayit1,kayit0 : String;
    begin
     kayit1:='InitialKeyboardIndicators';
       kayit0:='InitialKeyboardIndicators';
    //PM:='P.M.';
   reg:=TRegistry.Create;
    reg.RootKey:=HKEY_CURRENT_USER;
    reg.OpenKey('Control Panel\Keyboard',True);
    if  CheckBox7.Checked =true then
    reg.WriteString('2',kayit1)
          else
    reg.WriteString('0',kayit0);
          //MyRegistry.WriteString('s2359',PM);
    reg.CloseKey;
   reg.Free;
 end;

procedure Ttweak_ui.CheckBox8Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\NonEnum',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox8.Checked=true  then
  reg.WriteInteger('{645FF040-5081-101B-9F08-00AA002F954E}',key0)
     else
       reg.WriteInteger('{645FF040-5081-101B-9F08-00AA002F954E}',key1) ;
     reg.Free;
       end;


procedure Ttweak_ui.CheckBox9Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox9.Checked=true  then
  reg.WriteInteger('NoDesktop',key0)
     else
       reg.WriteInteger('NoDesktop',key1) ;
     reg.Free;
       end;

procedure Ttweak_ui.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Ttweak_ui.Image18Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure Ttweak_ui.Image9Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Ttweak_ui.Label17Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
ana_mnu.show;

end;

procedure Ttweak_ui.Label18Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
baslat_form.show;

end;

procedure Ttweak_ui.Label19Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
guvenlik.show;

end;

procedure Ttweak_ui.Label20Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
guvenlik_2.show;

end;

procedure Ttweak_ui.Label24Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
int_exp.show;

end;

procedure Ttweak_ui.Label23Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
internet_bil.show;

end;

procedure Ttweak_ui.Label21Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
bil_soft.show;

end;



procedure Ttweak_ui.Label25Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
gorunum.show;

end;

procedure Ttweak_ui.Label26Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
bil_soft.show;

end;

procedure Ttweak_ui.Label27Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
taskman_form.show;

end;

procedure Ttweak_ui.Label28Click(Sender: TObject);
begin
tweak_ui.Visible:=false;
donanim.show;

end;

procedure Ttweak_ui.Label32Click(Sender: TObject);
begin

tweak_ui.Visible:=false;
ag_net.show;

end;

procedure Ttweak_ui.Label31Click(Sender: TObject);
begin
gorunum.Visible:=false;
araclar_form.show;

end;

procedure Ttweak_ui.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show;

end;

procedure Ttweak_ui.Label30Click(Sender: TObject);
begin
gorunum.Visible:=false;
hakkinda_form.show;

end;

procedure Ttweak_ui.Image4Click(Sender: TObject);
begin
tweak_ui.Visible :=false;
ana_mnu.Show ;
end;

procedure Ttweak_ui.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
