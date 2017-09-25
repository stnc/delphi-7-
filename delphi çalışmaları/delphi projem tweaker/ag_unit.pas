unit ag_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls,Registry;

type
  TAg_net = class(TForm)
    Image1: TImage;
    ag_bile: TCheckBox;
    gel_me_aya: TCheckBox;
    lan_com: TCheckBox;
    ag_er_no: TCheckBox;
    uz_er_bag: TCheckBox;
    bag_ad: TCheckBox;
    lan_devre: TCheckBox;
    lan_etk_dev_oz: TCheckBox;
    eri_kont: TCheckBox;
    is_istas: TCheckBox;
    no_tar: TCheckBox;
    no_anao: TCheckBox;
    dhcp: TCheckBox;
    ag_son_pay: TCheckBox;
    no_key: TCheckBox;
    gel_ip: TCheckBox;
    yerel_bag_sih: TCheckBox;
    Image18: TImage;
    Image9: TImage;
    Image2: TImage;
    Image3: TImage;
    Label16: TLabel;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    Label21: TLabel;
    Label22: TLabel;
    Label23: TLabel;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    Label28: TLabel;
    Label29: TLabel;
    Label30: TLabel;
    Label1: TLabel;
    Image4: TImage;
    Image5: TImage;
    
    procedure gel_me_ayaClick(Sender: TObject);


  
    procedure ag_bileClick(Sender: TObject);
    procedure lan_comClick(Sender: TObject);
    procedure ag_er_noClick(Sender: TObject);
    procedure uz_er_bagClick(Sender: TObject);
    procedure bag_adClick(Sender: TObject);
    procedure lan_devreClick(Sender: TObject);
    procedure lan_etk_dev_ozClick(Sender: TObject);
    procedure eri_kontClick(Sender: TObject);
    procedure is_istasClick(Sender: TObject);
    procedure no_tarClick(Sender: TObject);
    procedure no_anaoClick(Sender: TObject);
    procedure dhcpClick(Sender: TObject);
    procedure ag_son_payClick(Sender: TObject);
    procedure no_keyClick(Sender: TObject);
    procedure gel_ipClick(Sender: TObject);
    procedure yerel_bag_sihClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Image9Click(Sender: TObject);
    procedure Image18Click(Sender: TObject);
    procedure Label16Click(Sender: TObject);
    procedure Label17Click(Sender: TObject);
    procedure Label18Click(Sender: TObject);
    procedure Label19Click(Sender: TObject);
    procedure Label20Click(Sender: TObject);
    procedure Label21Click(Sender: TObject);
    procedure Label22Click(Sender: TObject);
    procedure Label23Click(Sender: TObject);
    procedure Label24Click(Sender: TObject);
    procedure Label25Click(Sender: TObject);
    procedure Label26Click(Sender: TObject);
    procedure Label27Click(Sender: TObject);
    procedure Label28Click(Sender: TObject);
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
  Ag_net: TAg_net;

implementation

uses baslatUnit, guvenlikUnit, internet_explorer_unit, internet_unit,
  sistem_bil_unit, tweak_ui_unit, gorunum_unit, bil_soft_unit,
  taskman_unit, donanim_unit, araclar, hakkinda, guvenlik2, anamenu;

{$R *.dfm}



       procedure TAg_net.ag_bileClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key0:= ('01');
   if ag_bile.Checked=true  then
  reg.WriteInteger('NC_LanChangeProperties',key0)
     else
       reg.WriteInteger('NC_LanChangeProperties',key1) ;
     reg.Free;
end;


procedure TAg_net.gel_me_ayaClick(Sender: TObject);

   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key1:= ('01');
   if gel_me_aya.Checked=true  then
  reg.WriteInteger('NC_AdvancedSettings',key0)
     else
       reg.WriteInteger('NC_AdvancedSettings',key1) ;
     reg.Free;
       end;



procedure TAg_net.lan_comClick(Sender: TObject);
   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key1:= ('01');
   if lan_com.Checked=true  then
  reg.WriteInteger('NC_AddRemoveComponents',key0)
     else
       reg.WriteInteger('NC_AdvancedSettings',key1) ;
     reg.Free;
       end;

procedure TAg_net.ag_er_noClick(Sender: TObject);
   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key1:= ('01');
   if ag_er_no.Checked=true  then
  reg.WriteInteger('NC_LanProperties',key0)
     else
       reg.WriteInteger('NC_LanProperties',key1) ;
     reg.Free;
       end;

procedure TAg_net.uz_er_bagClick(Sender: TObject);
   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key1:= ('01');
   if uz_er_bag.Checked=true  then
  reg.WriteInteger('NC_RasChangeProperties',key0)
     else
       reg.WriteInteger('NC_RasChangeProperties',key1) ;
     reg.Free;
       end;


procedure TAg_net.bag_adClick(Sender: TObject);
   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key1:= ('01');
   if bag_ad.Checked=true  then
  reg.WriteInteger('NC_RenameLanConnection',key0)
     else
       reg.WriteInteger('NC_RenameLanConnection',key1) ;
     reg.Free;
       end;

procedure TAg_net.lan_devreClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key1:= ('01');
   if lan_devre.Checked=true  then
  reg.WriteInteger('NC_ChangeBindState',key0)
     else
       reg.WriteInteger('NC_ChangeBindState',key1) ;
     reg.Free;
       end;

procedure TAg_net.lan_etk_dev_ozClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key1:= ('01');
   if lan_etk_dev_oz.Checked=true  then
  reg.WriteInteger('NC_LanConnect',key0)
     else
       reg.WriteInteger('NC_LanConnect',key1) ;
     reg.Free;
       end;

procedure TAg_net.eri_kontClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\System',true);
  key0:= ('00');
  key1:= ('01');
   if eri_kont.Checked=true  then
  reg.WriteInteger('NoSecCpl',key0)
     else
       reg.WriteInteger('NoSecCpl',key1) ;
     reg.Free;
       end;

procedure TAg_net.is_istasClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\System',true);
  key0:= ('00');
  key1:= ('01');
   if is_istas.Checked=true  then
  reg.WriteInteger('DisableLockWorkstation',key0)
     else
       reg.WriteInteger('DisableLockWorkstation',key1) ;
     reg.Free;
       end;


procedure TAg_net.no_tarClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Services\lanmanserver\parameters',true);
  key0:= ('00');
  key1:= ('01');
   if no_tar.Checked=true  then
  reg.WriteInteger('Hidden',key0)
     else
       reg.WriteInteger('Hidden',key1) ;
     reg.Free;
       end;

procedure TAg_net.no_anaoClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Control\Lsa',true);
  key0:= ('00');
  key1:= ('01');
   if no_anao.Checked=true  then
  reg.WriteInteger('restrictanonymous',key0)
     else
       reg.WriteInteger('restrictanonymous',key1) ;
     reg.Free;
       end;

procedure TAg_net.dhcpClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SYSTEM\ControlSet001\Services\Tcpip\Parameters',true);
  key0:= ('00');
  key1:= ('01');
   if dhcp.Checked=true  then
  reg.WriteInteger('PerformRouterDiscovery',key0)
     else
       reg.WriteInteger('PerformRouterDiscovery',key1) ;
     reg.Free;
       end;

procedure TAg_net.ag_son_payClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\System',true);
  key0:= ('00');
  key1:= ('01');
   if ag_son_pay.Checked=true  then
  reg.WriteInteger('NoRecentDocsNetHood',key0)
     else
       reg.WriteInteger('NoRecentDocsNetHood',key1) ;
     reg.Free;
       end;

procedure TAg_net.no_keyClick(Sender: TObject);
  var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Microsoft\Windows\CurrentVersion\Policies\System',true);
  key0:= ('00');
  key1:= ('01');
   if no_key.Checked=true  then
  reg.WriteInteger('DisableChangePassword',key0)
     else
       reg.WriteInteger('DisableChangePassword',key1) ;
     reg.Free;
       end;

procedure TAg_net.gel_ipClick(Sender: TObject);
   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key0:= ('01');
   if gel_ip.Checked=true  then
  reg.WriteInteger('NC_AllowAdvancedTCPIPConfig',key0)
     else
       reg.WriteInteger('NC_AllowAdvancedTCPIPConfig',key1) ;
     reg.Free;
       end;
procedure TAg_net.yerel_bag_sihClick(Sender: TObject);
   var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Software\Policies\Microsoft\Windows\Network Connections',true);
  key0:= ('00');
  key0:= ('01');
   if yerel_bag_sih.Checked=true  then
  reg.WriteInteger('NC_NewConnectionWizard',key0)
     else
       reg.WriteInteger('NC_NewConnectionWizard',key1) ;
     reg.Free;
       end;
procedure TAg_net.FormCreate(Sender: TObject);
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

procedure TAg_net.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure TAg_net.Image9Click(Sender: TObject);
begin
application.Minimize;
end;

procedure TAg_net.Image18Click(Sender: TObject);
begin
application.Terminate;
end;

procedure TAg_net.Label16Click(Sender: TObject);
begin
ag_net.Visible:=false;
ana_mnu.show;
end;



procedure TAg_net.Label17Click(Sender: TObject);
begin
 ag_net.Visible:=false;
guvenlik.show;
end;

procedure TAg_net.Label18Click(Sender: TObject);
begin
ag_net.Visible:=false;
guvenlik_2.show;
end;

procedure TAg_net.Label19Click(Sender: TObject);
begin
ag_net.Visible:=false;
int_exp.show;
end;

procedure TAg_net.Label20Click(Sender: TObject);
begin
ag_net.Visible:=false;
internet_bil.show;
end;

procedure TAg_net.Label21Click(Sender: TObject);
begin
ag_net.Visible:=false;
sistem_bil.show;
end;

procedure TAg_net.Label22Click(Sender: TObject);
begin
ag_net.Visible:=false;
tweak_ui.show;
end;

procedure TAg_net.Label23Click(Sender: TObject);
begin
ag_net.Visible:=false;
gorunum.show;
end;

procedure TAg_net.Label24Click(Sender: TObject);
begin
 ag_net.Visible:=false;
bil_soft.show;
end;

procedure TAg_net.Label25Click(Sender: TObject);
begin
ag_net.Visible:=false;
taskman_form.show;
end;

procedure TAg_net.Label26Click(Sender: TObject);
begin
 ag_net.Visible:=false;
donanim.show;
end;

procedure TAg_net.Label27Click(Sender: TObject);
begin
//ag_net.Visible:=false;
//ag_net.show;
end;

procedure TAg_net.Label28Click(Sender: TObject);
begin
ag_net.Visible:=false;
araclar_form.show;
end;

procedure TAg_net.Label29Click(Sender: TObject);
begin
//ag_net.Visible:=false;
//ayarlar.show;
end;

procedure TAg_net.Label30Click(Sender: TObject);
begin
ag_net.Visible:=false;
hakkinda_form.show;
end;

procedure TAg_net.Image4Click(Sender: TObject);
begin
ag_net.Visible:=false;
ana_mnu.Show ;
end;

procedure TAg_net.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
