unit guvenlikUnit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, jpeg, StdCtrls, registry;

type
  Tguvenlik = class(TForm)
    Image1: TImage;
    prg_ekle: TCheckBox;
    prg_erisim: TCheckBox;
    den_gor: TCheckBox;
    prg_win_bil: TCheckBox;
    denetim_masasi: TCheckBox;
    hat_gon: TCheckBox;
    kri_hata: TCheckBox;
    uz_masa: TCheckBox;
    oto_rest: TCheckBox;
    DisableThumbnailCache: TCheckBox;
    Prefetcher: TCheckBox;
    prg_ek_kal: TCheckBox;
    ctrl_alt: TCheckBox;
    msn_ou: TCheckBox;
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
    procedure prg_ekleClick(Sender: TObject);
    procedure prg_erisimClick(Sender: TObject);
    procedure den_gorClick(Sender: TObject);
    procedure prg_win_bilClick(Sender: TObject);
    procedure denetim_masasiClick(Sender: TObject);
    procedure hat_gonClick(Sender: TObject);
    procedure kri_hataClick(Sender: TObject);
    procedure uz_masaClick(Sender: TObject);
    procedure oto_restClick(Sender: TObject);
    procedure DisableThumbnailCacheClick(Sender: TObject);
    procedure PrefetcherClick(Sender: TObject);
    procedure prg_ek_kalClick(Sender: TObject);
    procedure ctrl_altClick(Sender: TObject);
    procedure msn_ouClick(Sender: TObject);
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
  guvenlik: Tguvenlik;
   
implementation

uses baslatUnit, anamenu, guvenlik2, internet_explorer_unit, internet_unit,
  sistem_bil_unit, tweak_ui_unit, bil_soft_unit, taskman_unit,
  donanim_unit, ag_unit, gorunum_unit, araclar, hakkinda;

{$R *.dfm}




procedure Tguvenlik.FormCreate(Sender: TObject);
begin
   image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

procedure Tguvenlik.prg_ekleClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall',true);
  key0:= ('00');
  key1:= ('01');
   if prg_ekle.Checked=true  then
  reg.WriteInteger('NoRemovePage',key0)
     else
       reg.WriteInteger('NoRemovePage',key1) ;
     reg.Free;
       end;

procedure Tguvenlik.prg_erisimClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall',true);
  key0:= ('00');
  key1:= ('01');
   if prg_erisim.Checked=true  then
  reg.WriteInteger('NoChooseProgramsPage',key0)
     else
       reg.WriteInteger('NoChooseProgramsPage',key1) ;
     reg.Free;
       end;

procedure Tguvenlik.den_gorClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\System',true);
  key0:= ('00');
  key1:= ('01');
   if den_gor.Checked=true  then
  reg.WriteInteger('NoDispCPL',key0)
     else
       reg.WriteInteger('NoDispCPL',key1) ;
     reg.Free;
       end;


procedure Tguvenlik.prg_win_bilClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall',true);
  key0:= ('00');
  key1:= ('01');
   if prg_win_bil.Checked=true  then
  reg.WriteInteger('NoWindowsSetupPage',key0)
     else
       reg.WriteInteger('NoWindowsSetupPage',key1) ;
     reg.Free;
       end;




       
procedure Tguvenlik.denetim_masasiClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Explorer',true);
  key0:= ('00');
  key1:= ('01');
   if denetim_masasi.Checked=true  then
  reg.WriteInteger('NoControlPanel',key0)
     else
       reg.WriteInteger('NoControlPanel',key1) ;
     reg.Free;
       end;

procedure Tguvenlik.hat_gonClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SOFTWARE\Microsoft\PCHealth\ErrorReporting',true);
  key0:= ('00');
  key1:= ('01');
   if hat_gon.Checked=true  then
  reg.WriteInteger('DoReport',key1)
     else
       reg.WriteInteger('DoReport',key0) ;
     reg.Free;
       end;

procedure Tguvenlik.kri_hataClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SOFTWARE\Microsoft\PCHealth\ErrorReporting',true);
  key0:= ('00');
  key1:= ('01');
   if kri_hata.Checked=true  then
  reg.WriteInteger('ShowUI',key0)
     else
       reg.WriteInteger('ShowUI',key1) ;
     reg.Free;
       end;

procedure Tguvenlik.uz_masaClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\CurrentControlSet\Control\Terminal Server',true);
  key0:= ('00');
  key1:= ('01');
   if uz_masa.Checked=true  then
  reg.WriteInteger('fAllowToGetHelp',key0)
     else
       reg.WriteInteger('fAllowToGetHelp',key1) ;
     reg.Free;
       end;

procedure Tguvenlik.oto_restClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\CurrentControlSet\Control\CrashControl',true);
  key0:= ('00');
  key1:= ('01');
   if oto_rest.Checked=true  then
  reg.WriteInteger('AutoReboot',key0)
     else
       reg.WriteInteger('AutoReboot',key1) ;
     reg.Free;
       end;

procedure Tguvenlik.DisableThumbnailCacheClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced',true);
  key0:= ('00');
  key1:= ('01');
   if DisableThumbnailCache.Checked=true  then
  reg.WriteInteger('DisableThumbnailCache',key0)
     else
       reg.WriteInteger('DisableThumbnailCache',key1) ;
     reg.Free;
       end;

procedure Tguvenlik.PrefetcherClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters',true);
  key0:= ('00');
  key1:= ('01');
   if Prefetcher.Checked=true  then
  reg.WriteInteger('EnablePrefetcher',key0)
     else
       reg.WriteInteger('EnablePrefetcher',key1) ;
     reg.Free;
       end;
procedure Tguvenlik.prg_ek_kalClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall',true);
  key0:= ('00');
  key1:= ('01');
    if prg_ek_kal.Checked=true  then
  reg.WriteInteger('NoAddRemovePrograms',key0)
     else
     reg.WriteInteger('NoAddRemovePrograms',key1) ;
      reg.Free;
  end;

procedure Tguvenlik.ctrl_altClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\System',true);
  key0:= ('00');
  key1:= ('01');
        if ctrl_alt.Checked=true  then
  reg.WriteInteger('DisableTaskMgr',key0)
        else
  reg.WriteInteger('DisableTaskMgr',key1) ;
    reg.Free;
        end;

procedure Tguvenlik.msn_ouClick(Sender: TObject);
 // buraya girilen deðerlerde yanlýþ olabilir
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Microsoft\Outlook Express',true);
  key0:= ('02');
  key1:= ('01');
      if msn_ou.Checked=true  then
  reg.WriteInteger('Hide Messenger',key0)
       else
  reg.WriteInteger('Hide Messenger',key1) ;
  reg.Free;
      end;

procedure Tguvenlik.Image9Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Tguvenlik.Image18Click(Sender: TObject);
begin
 application.Terminate ;
end;

procedure Tguvenlik.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Tguvenlik.Label17Click(Sender: TObject);
begin
guvenlik.Visible:=false;
ana_mnu.show;

end;

procedure Tguvenlik.Label18Click(Sender: TObject);
begin
guvenlik.Visible:=false;
baslat_form.show;

end;

procedure Tguvenlik.Label19Click(Sender: TObject);
begin
guvenlik.Visible:=false;
guvenlik.show;

end;

procedure Tguvenlik.Label20Click(Sender: TObject);
begin
guvenlik.Visible:=false;
guvenlik_2.show;

end;

procedure Tguvenlik.Label24Click(Sender: TObject);
begin
guvenlik.Visible:=false;
int_exp.show;

end;

procedure Tguvenlik.Label23Click(Sender: TObject);
begin
guvenlik.Visible:=false;
internet_bil.show;

end;

procedure Tguvenlik.Label21Click(Sender: TObject);
begin

guvenlik.Visible:=false;
sistem_bil.show;

end;

procedure Tguvenlik.Label22Click(Sender: TObject);
begin
guvenlik.Visible:=false;
tweak_ui.show;

end;

procedure Tguvenlik.Label25Click(Sender: TObject);
begin
guvenlik.Visible:=false;
gorunum.show;

end;

procedure Tguvenlik.Label26Click(Sender: TObject);
begin
guvenlik.Visible:=false;
bil_soft.show;

end;

procedure Tguvenlik.Label27Click(Sender: TObject);
begin
guvenlik.Visible:=false;
taskman_form.show;

end;

procedure Tguvenlik.Label28Click(Sender: TObject);
begin
guvenlik.Visible:=false;
donanim.show;

end;

procedure Tguvenlik.Label32Click(Sender: TObject);
begin
guvenlik.Visible:=false;
ag_net.show;

end;

procedure Tguvenlik.Label31Click(Sender: TObject);
begin
gorunum.Visible:=false;
araclar_form.show;

end;

procedure Tguvenlik.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show

end;

procedure Tguvenlik.Label30Click(Sender: TObject);
begin
gorunum.Visible:=false;
hakkinda_form.show;

end;

procedure Tguvenlik.Image4Click(Sender: TObject);
begin
guvenlik.Visible :=false;
ana_mnu.Show;
end;

procedure Tguvenlik.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.

