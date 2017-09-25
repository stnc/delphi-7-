unit araclar;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, jpeg;

type
  Taraclar_form = class(TForm)
    Label1: TLabel;
    Image1: TImage;
    Label2: TLabel;
    Label3: TLabel;
    Image2: TImage;
    Label4: TLabel;
    Label5: TLabel;
    Image3: TImage;
    Label6: TLabel;
    Image4: TImage;
    Label7: TLabel;
    Image5: TImage;
    Label8: TLabel;
    Image6: TImage;
    Label9: TLabel;
    Image7: TImage;
    Label10: TLabel;
    Image8: TImage;
    Image9: TImage;
    Label11: TLabel;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Image10: TImage;
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
    Image11: TImage;
    Image12: TImage;


    procedure Image1Click(Sender: TObject);
    procedure Image2Click(Sender: TObject);
   
    procedure Image3Click(Sender: TObject);
    procedure Image4Click(Sender: TObject);
    procedure Image5Click(Sender: TObject);
    procedure Image6Click(Sender: TObject);
    procedure Image7Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image10Click(Sender: TObject);
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
    procedure Image11Click(Sender: TObject);
    procedure Image12Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  araclar_form: Taraclar_form;

implementation

uses anamenu, baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, sistem_bil_unit, tweak_ui_unit, gorunum_unit,
  bil_soft_unit, donanim_unit, ag_unit, hakkinda, taskman_unit;

{$R *.dfm}



 Function GetWinDir: String;
var
  dir: array [0..max_path] of char;
begin
 GetWindowsDirectory(dir, max_path);
 Result:=StrPas(Dir);
end;


function GetSysDir: String;
var
  dir: array [0..max_path] of char;
begin
 GetSystemDirectory(dir, max_path);
 result:=StrPas(dir);
 end;
procedure Taraclar_form.Image3Click(Sender: TObject);
var
GetSystemDirectory: String ;
begin
WinExec(PChar(GetSystemDirectory+'cleanmgr.exe'), SW_SHOWNORMAL)
end;

procedure Taraclar_form.Image4Click(Sender: TObject);
  var
 GetWindowsDirectory:string;
begin
WinExec(PChar(GetWindowsDirectory+'regedit.exe'), SW_SHOWNORMAL)
end;

procedure Taraclar_form.Image5Click(Sender: TObject);
var
GetSystemDirectory: String ;
begin
WinExec(PChar(GetSystemDirectory+'drwtsn32.exe'), SW_SHOWNORMAL)
end;

procedure Taraclar_form.Image6Click(Sender: TObject);
var
GetSystemDirectory: String ;
begin
WinExec(PChar(GetSystemDirectory+'ntbackup.exe'), SW_SHOWNORMAL)
end;

procedure Taraclar_form.Image7Click(Sender: TObject);
  var
GetSystemDirectory: String ;
begin
WinExec(PChar(GetSystemDirectory+'dxdiag.exe'), SW_SHOWNORMAL)
end;

procedure Taraclar_form.FormCreate(Sender: TObject);
begin
image8.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;




procedure Taraclar_form.Image2Click(Sender: TObject);
  var
GetSystemDirectory: String ;
begin
WinExec(PChar(GetSystemDirectory+'telnet.exe'), SW_SHOWNORMAL)

end;














procedure Taraclar_form.Image1Click(Sender: TObject);
  var
GetSystemDirectory: String ;
 //GetWindowsDirectory:string;
begin

 //WinExec(PChar(GetWindowsDirectory+'regedit.exe'), SW_SHOWNORMAL) // açýklamada olan yer
 WinExec(PChar(GetSystemDirectory+'sysedit.exe'), SW_SHOWNORMAL )
end;

procedure Taraclar_form.Image10Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure Taraclar_form.Image18Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure Taraclar_form.Label17Click(Sender: TObject);
begin
araclar_form.Visible :=false;
ana_mnu.show;
end;

procedure Taraclar_form.Label18Click(Sender: TObject);
begin
araclar_form.Visible :=false;
baslat_form.show;
end;

procedure Taraclar_form.Label19Click(Sender: TObject);
begin
araclar_form.Visible :=false;
guvenlik.show;
end;

procedure Taraclar_form.Label20Click(Sender: TObject);
begin
araclar_form.Visible :=false;
guvenlik_2.show;
end;

procedure Taraclar_form.Label24Click(Sender: TObject);
begin
araclar_form.Visible :=false;
int_exp.show;
end;

procedure Taraclar_form.Label23Click(Sender: TObject);
begin
araclar_form.Visible :=false;
internet_bil.show;
end;

procedure Taraclar_form.Label21Click(Sender: TObject);
begin
araclar_form.Visible :=false;
sistem_bil.show;
end;

procedure Taraclar_form.Label22Click(Sender: TObject);
begin
araclar_form.Visible :=false;
tweak_ui.show;
end;

procedure Taraclar_form.Label25Click(Sender: TObject);
begin
araclar_form.Visible :=false;
gorunum.show;
end;

procedure Taraclar_form.Label26Click(Sender: TObject);
begin
araclar_form.Visible :=false;
bil_soft.show;
end;

procedure Taraclar_form.Label27Click(Sender: TObject);
begin
araclar_form.Visible :=false;
taskman_form.show;
end;

procedure Taraclar_form.Label28Click(Sender: TObject);
begin
araclar_form.Visible :=false;
donanim.show;
end;

procedure Taraclar_form.Label32Click(Sender: TObject);
begin
araclar_form.Visible :=false;
ag_net.show;
end;

procedure Taraclar_form.Label31Click(Sender: TObject);
begin
araclar_form.Visible :=false;
araclar_form.show;
end;

procedure Taraclar_form.Label29Click(Sender: TObject);
begin
//araclar_form.Visible :=false;
//ayarlar.show;
end;

procedure Taraclar_form.Label30Click(Sender: TObject);
begin
araclar_form.Visible :=false;
hakkinda_form.show;
end;

procedure Taraclar_form.Image11Click(Sender: TObject);
begin
araclar_form.Visible :=false;
ana_mnu.Show;
end;

procedure Taraclar_form.Image12Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
