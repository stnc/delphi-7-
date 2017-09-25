unit bil_soft_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls,registry, Buttons, jpeg;

type
  Tbil_soft = class(TForm)
    LabeledEdit1: TLabeledEdit;
    LabeledEdit2: TLabeledEdit;
    LabeledEdit3: TLabeledEdit;
    LabeledEdit4: TLabeledEdit;
    LabeledEdit5: TLabeledEdit;
    LabeledEdit6: TLabeledEdit;
    no_spla_ou: TCheckBox;
    msn_oto: TCheckBox;
    media: TLabeledEdit;
    Image1: TImage;
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    BitBtn3: TBitBtn;
    BitBtn4: TBitBtn;
    Image9: TImage;
    Image18: TImage;
    Image2: TImage;
    Image3: TImage;
    Image4: TImage;
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
    Image5: TImage;
    Image6: TImage;
    procedure FormCreate(Sender: TObject);
    procedure no_spla_ouClick(Sender: TObject);
    procedure msn_otoClick(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Image9Click(Sender: TObject);
    procedure Image18Click(Sender: TObject);
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
    procedure Image5Click(Sender: TObject);
    procedure Image6Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  bil_soft: Tbil_soft;

implementation

uses baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, sistem_bil_unit, tweak_ui_unit, gorunum_unit,
  taskman_unit, donanim_unit, ag_unit, anamenu, araclar, hakkinda;

{$R *.dfm}

procedure Tbil_soft.FormCreate(Sender: TObject);
 var
R:Tregistry;
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
 begin

//bilgisayar adýný okur
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName',false);
if R.ValueExists('ComputerName') then
 LabeledEdit1.Text:=(R.ReadString ('ComputerName')) ;
  //else
//LabeledEdit1.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;


//iþletim sistemin okur
begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('ProductName') then
 LabeledEdit3.Text:=(R.ReadString ('ProductName')) ;
  //else
//LabeledEdit3.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;

//  csd version u okur
begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('CSDVersion') then
 LabeledEdit4.Text:=(R.ReadString ('CSDVersion'));
  //else
//LabeledEdit4.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;


//organization okur
begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('SOFTWARE\Microsoft\Windows NT\CurrentVersion',false);
if R.ValueExists('RegisteredOrganization') then
 LabeledEdit2.Text:=(R.ReadString ('RegisteredOrganization'));
 // else
//LabeledEdit2.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;

//media palyer kutusuna okuma yapar
begin
R:=TRegistry.Create;
R.RootKey:=HKEY_CURRENT_USER;
R.OpenKey('Software\Policies\Microsoft\WindowsMediaPlayer',false);
if R.ValueExists('TitleBar') then
 media.Text:=(R.ReadString ('TitleBar')) ;
  //else
//media.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;


//outloo ekspress kutusuna yazý okur
begin
R:=TRegistry.Create;
R.RootKey:=HKEY_CURRENT_USER;
R.OpenKey('Identities\{960B67F7-36A2-4263-9E67-9F99981B3BCB}\Software\Microsoft\Outlook Express\5.0',false);
if R.ValueExists('WindowTitle') then
LabeledEdit6.Text:=(R.ReadString ('WindowTitle'));
  //else
//LabeledEdit6.Text:=('Deðer bulunamadý');
R.CloseKey;
R.free;


 end;
end;
end;
end;
  end;
   end;
    end;
procedure Tbil_soft.no_spla_ouClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_CURRENT_USER ;
  reg.OpenKey('Identities\{960B67F7-36A2-4263-9E67-9F99981B3BCB}\Software\Microsoft\Outlook Express\5.0',true);
  key0:= ('00');
  key1:= ('01');
   if no_spla_ou.Checked=true  then
  reg.WriteInteger('NoSplash',key0)
     else
       reg.WriteInteger('NoSplash',key1) ;
     reg.Free;
       //reg.Free;
end;

procedure Tbil_soft.msn_otoClick(Sender: TObject);
var
key0,key1: OleVariant;
reg:tregistry;
begin
  reg:=TRegistry.Create;
  reg.RootKey:=HKEY_LOCAL_MACHINE ;
  reg.OpenKey('SOFTWARE\Microsoft\Windows\CurrentVersion\Run',true);
  key0:= ('00');
  key1:= ('01');
   if msn_oto.Checked=true  then
  reg.WriteInteger('msnmsgr',key1)
     else
       reg.WriteInteger('msnmsgr',key0) ;
     reg.Free;
       //reg.Free;
end;

procedure Tbil_soft.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Tbil_soft.Image9Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Tbil_soft.Image18Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure Tbil_soft.Label17Click(Sender: TObject);
begin
bil_soft.Visible:=false;
ana_mnu.show;

end;

procedure Tbil_soft.Label18Click(Sender: TObject);
begin
bil_soft.Visible:=false;
baslat_form.show;


end;

procedure Tbil_soft.Label19Click(Sender: TObject);
begin
 bil_soft.Visible:=false;
guvenlik.show;

end;

procedure Tbil_soft.Label20Click(Sender: TObject);
begin
bil_soft.Visible:=false;
guvenlik_2.show;

end;

procedure Tbil_soft.Label24Click(Sender: TObject);
begin
bil_soft.Visible:=false;
int_exp.show;

end;

procedure Tbil_soft.Label23Click(Sender: TObject);
begin
bil_soft.Visible:=false;
internet_bil.show;

end;

procedure Tbil_soft.Label21Click(Sender: TObject);
begin
bil_soft.Visible:=false;
sistem_bil.show;

end;

procedure Tbil_soft.Label22Click(Sender: TObject);
begin

bil_soft.Visible:=false;
tweak_ui.show;

end;

procedure Tbil_soft.Label25Click(Sender: TObject);
begin
bil_soft.Visible:=false;
gorunum.show;

end;

procedure Tbil_soft.Label26Click(Sender: TObject);
begin
//bil_soft.Visible:=false;
//bil_soft.show;

end;

procedure Tbil_soft.Label27Click(Sender: TObject);
begin

bil_soft.Visible:=false;
taskman_form.show;

end;

procedure Tbil_soft.Label28Click(Sender: TObject);
begin
bil_soft.Visible:=false;
donanim.show;

end;

procedure Tbil_soft.Label32Click(Sender: TObject);
begin
bil_soft.Visible:=false;
ag_net.show;


end;

procedure Tbil_soft.Label31Click(Sender: TObject);
begin
bil_soft.Visible:=false;
araclar_form.show;

end;

procedure Tbil_soft.Label29Click(Sender: TObject);
begin
//bil_soft.Visible:=false;
//ayarlar.show;

end;

procedure Tbil_soft.Label30Click(Sender: TObject);
begin
bil_soft.Visible:=false;
hakkinda_form.show;
end;

procedure Tbil_soft.Image5Click(Sender: TObject);
begin
bil_soft.Visible :=false;
ana_mnu.Show;
end;

procedure Tbil_soft.Image6Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
