unit internet_explorer_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, jpeg,Registry;

type
  Tint_exp = class(TForm)
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
    CheckBox10: TCheckBox;
    CheckBox11: TCheckBox;
    CheckBox12: TCheckBox;
    CheckBox13: TCheckBox;
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
    procedure CheckBox10Click(Sender: TObject);
    procedure CheckBox11Click(Sender: TObject);
    procedure CheckBox12Click(Sender: TObject);
    procedure CheckBox13Click(Sender: TObject);
    procedure Image9Click(Sender: TObject);
    procedure Image18Click(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Label18Click(Sender: TObject);
    procedure Label17Click(Sender: TObject);
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
  int_exp: Tint_exp;

implementation

uses baslatUnit, anamenu, guvenlikUnit,guvenlik2, internet_unit,
  sistem_bil_unit, tweak_ui_unit, gorunum_unit, bil_soft_unit,
  taskman_unit, donanim_unit, ag_unit, araclar;

{$R *.dfm}

procedure Tint_exp.FormCreate(Sender: TObject);
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

procedure Tint_exp.CheckBox1Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox1.Checked=true  then
  reg.WriteInteger('ContentTab',key0)
     else
       reg.WriteInteger('ContentTab',key1) ;
     reg.Free;
       end;



procedure Tint_exp.CheckBox2Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox2.Checked=true  then
  reg.WriteInteger('ConnectionsTab',key0)
     else
       reg.WriteInteger('ConnectionsTab',key1) ;
     reg.Free;
       end;

procedure Tint_exp.CheckBox3Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox3.Checked=true  then
  reg.WriteInteger('SecurityTab',key0)
     else
       reg.WriteInteger('SecurityTab',key1) ;
     reg.Free;
       end;


       
procedure Tint_exp.CheckBox4Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox4.Checked=true  then
  reg.WriteInteger('AdvancedTab',key0)
     else
       reg.WriteInteger('AdvancedTab',key1) ;
     reg.Free;
       end;



procedure Tint_exp.CheckBox5Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox5.Checked=true  then
  reg.WriteInteger('PrivacyTab',key0)
     else
       reg.WriteInteger('PrivacyTab',key1) ;
     reg.Free;
       end;

       
procedure Tint_exp.CheckBox6Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox6.Checked=true  then
  reg.WriteInteger('ProgramsTab',key0)
     else
       reg.WriteInteger('ProgramsTab',key1) ;
     reg.Free;
       end;



procedure Tint_exp.CheckBox7Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Restrictions',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox7.Checked=true  then
  reg.WriteInteger('NoBrowserSaveAs',key0)
     else
       reg.WriteInteger('NoBrowserSaveAs',key1) ;
     reg.Free;
       end;

procedure Tint_exp.CheckBox8Click(Sender: TObject);
    var
    MyRegistry : TRegistry;
    //AM, PM : String;
    kayit1,kayit0 : String;
    begin
    kayit0:='proxy';
    kayit1:='proxy';
    //PM:='P.M.';
    MyRegistry:=TRegistry.Create;
    MyRegistry.RootKey:=HKEY_CURRENT_USER;
    MyRegistry.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',True);
   if CheckBox8.Checked =true then
       MyRegistry.WriteString('1',kayit1)
   else
       MyRegistry.WriteString('0',kayit0);
    MyRegistry.CloseKey;
    MyRegistry.Free;
 end;

procedure Tint_exp.CheckBox9Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox9.Checked=true  then
  reg.WriteInteger('GeneralTab',key0)
     else
       reg.WriteInteger('GeneralTab',key1) ;
     reg.Free;
       end;
procedure Tint_exp.CheckBox10Click(Sender: TObject);
// dene
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox9.Checked=true  then
  reg.WriteInteger('1803',key0)
     else
       reg.WriteInteger('1803',key1) ;
     reg.Free;
       end;

procedure Tint_exp.CheckBox11Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox11.Checked=true  then
  reg.WriteInteger('NoToolbarCustomize',key0)
     else
       reg.WriteInteger('NoToolbarCustomize',key1) ;
     reg.Free;
       end;

procedure Tint_exp.CheckBox12Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Internet Settings\Cache',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox12.Checked=true  then
  reg.WriteInteger('Persistent',key0)
     else
       reg.WriteInteger('Persistent',key1) ;
     reg.Free;
       end;

procedure Tint_exp.CheckBox13Click(Sender: TObject);
   var
 key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Policies\Microsoft\Internet Explorer\Control Panel',true);
  key0:= ('00');
  key1:= ('01');
   if CheckBox13.Checked=true  then
  reg.WriteInteger('Homepage',key0)
     else
       reg.WriteInteger('Homepage',key1) ;
     reg.Free;
       end;

procedure Tint_exp.Image9Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Tint_exp.Image18Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure Tint_exp.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Tint_exp.Label18Click(Sender: TObject);
begin
int_exp.Visible:=false;
baslat_form.show;

end;

procedure Tint_exp.Label17Click(Sender: TObject);
begin
int_exp.Visible:=false; 
ana_mnu.show;

end;

procedure Tint_exp.Label19Click(Sender: TObject);
begin
int_exp.Visible:=false;
guvenlik.show;

end;

procedure Tint_exp.Label20Click(Sender: TObject);
begin
int_exp.Visible:=false;
guvenlik_2.show;

end;

procedure Tint_exp.Label24Click(Sender: TObject);
begin
//int_exp.Visible:=false;
//int_exp.show;

end;

procedure Tint_exp.Label23Click(Sender: TObject);
begin
int_exp.Visible:=false;
internet_bil.show;

end;

procedure Tint_exp.Label21Click(Sender: TObject);
begin
int_exp.Visible:=false;
sistem_bil.show;

end;

procedure Tint_exp.Label22Click(Sender: TObject);
begin
int_exp.Visible:=false;
tweak_ui.show;

end;

procedure Tint_exp.Label25Click(Sender: TObject);
begin
int_exp.Visible:=false;
gorunum.show;

end;

procedure Tint_exp.Label26Click(Sender: TObject);
begin
int_exp.Visible:=false;
bil_soft.show;

end;

procedure Tint_exp.Label27Click(Sender: TObject);
begin
int_exp.Visible:=false;
taskman_form.show;

end;

procedure Tint_exp.Label28Click(Sender: TObject);
begin
int_exp.Visible:=false;
donanim.show;

end;

procedure Tint_exp.Label32Click(Sender: TObject);
begin
int_exp.Visible:=false;
ag_net.show;

end;

procedure Tint_exp.Label31Click(Sender: TObject);
begin
gorunum.Visible:=false;
araclar_form.show;

end;

procedure Tint_exp.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show;

end;

procedure Tint_exp.Label30Click(Sender: TObject);
begin
gorunum.Visible:=false;
int_exp.show;

end;

procedure Tint_exp.Image4Click(Sender: TObject);
begin
int_exp.Visible :=false;
ana_mnu.Show;
end;

procedure Tint_exp.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
