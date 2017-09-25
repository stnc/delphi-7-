unit anamenu;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, jpeg;

type
  Tana_mnu = class(TForm)
    Image2: TImage;
    Image3: TImage;
    Image4: TImage;
    Image5: TImage;
    Image6: TImage;
    Image7: TImage;
    Image8: TImage;
    Image10: TImage;
    Image11: TImage;
    Image12: TImage;
    Image13: TImage;
    Image14: TImage;
    Image15: TImage;
    Image16: TImage;
    Image17: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Image9: TImage;
    Image18: TImage;
    Image1: TImage;
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Image2Click(Sender: TObject);
    procedure Label1Click(Sender: TObject);
    procedure Image18Click(Sender: TObject);
    procedure Image9Click(Sender: TObject);
    procedure Image3Click(Sender: TObject);
    procedure Label2Click(Sender: TObject);
    procedure Label3Click(Sender: TObject);
    procedure Image4Click(Sender: TObject);
    procedure Image5Click(Sender: TObject);
    procedure Label4Click(Sender: TObject);
    procedure Label5Click(Sender: TObject);
    procedure Image6Click(Sender: TObject);
    procedure Image7Click(Sender: TObject);
    procedure Label6Click(Sender: TObject);
    procedure Image15Click(Sender: TObject);
    procedure Label7Click(Sender: TObject);
    procedure Label8Click(Sender: TObject);
    procedure Image13Click(Sender: TObject);
    procedure Label9Click(Sender: TObject);
    procedure Image10Click(Sender: TObject);
    procedure Image14Click(Sender: TObject);
    procedure Label10Click(Sender: TObject);
    procedure Image11Click(Sender: TObject);
    procedure Label11Click(Sender: TObject);
    procedure Image12Click(Sender: TObject);
    procedure Label12Click(Sender: TObject);
    procedure Label14Click(Sender: TObject);
    procedure Image8Click(Sender: TObject);
    procedure Label13Click(Sender: TObject);
    procedure Image16Click(Sender: TObject);
    procedure Image17Click(Sender: TObject);
    procedure Label15Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  ana_mnu: Tana_mnu;

implementation

uses baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, sistem_bil_unit, tweak_ui_unit, gorunum_unit,
  bil_soft_unit, taskman_unit, donanim_unit, ag_unit, araclar,
  ayarlar_unit, hakkinda;

{$R *.dfm}
  {$R skin.res}


procedure Tana_mnu.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Tana_mnu.Image18Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure Tana_mnu.Image9Click(Sender: TObject);
begin
application.Minimize;
end;

procedure Tana_mnu.Image2Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
baslat_form.Show;
end;

procedure Tana_mnu.Label1Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
baslat_form.Show;
end;



procedure Tana_mnu.Image3Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
guvenlik.Show;
end;

procedure Tana_mnu.Label2Click(Sender: TObject);
begin
 ana_mnu.Visible :=false;
guvenlik.Show;
end;

procedure Tana_mnu.Label3Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
guvenlik_2.Show;
end;

procedure Tana_mnu.Image4Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
guvenlik_2.Show;
end;

procedure Tana_mnu.Image5Click(Sender: TObject);
begin
 ana_mnu.Visible :=false;
int_exp.Show;
end;

procedure Tana_mnu.Label4Click(Sender: TObject);
begin
 ana_mnu.Visible :=false;
int_exp.Show;
end;

procedure Tana_mnu.Label5Click(Sender: TObject);
begin
  ana_mnu.Visible :=false;
internet_bil.Show;
end;

procedure Tana_mnu.Image6Click(Sender: TObject);
begin
  ana_mnu.Visible :=false;
internet_bil.Show;
end;

procedure Tana_mnu.Image7Click(Sender: TObject);
begin
   ana_mnu.Visible :=false;
sistem_bil.Show;
end;

procedure Tana_mnu.Label6Click(Sender: TObject);
begin
   ana_mnu.Visible :=false;
sistem_bil.Show;
end;

procedure Tana_mnu.Image15Click(Sender: TObject);
begin
     ana_mnu.Visible :=false;
tweak_ui.Show;
end;

procedure Tana_mnu.Label7Click(Sender: TObject);
begin
      ana_mnu.Visible :=false;
tweak_ui.Show;
end;

procedure Tana_mnu.Label8Click(Sender: TObject);
begin
      ana_mnu.Visible :=false;
gorunum.Show;
end;

procedure Tana_mnu.Image13Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
gorunum.Show;
end;

procedure Tana_mnu.Label9Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
bil_soft.Show;
end;

procedure Tana_mnu.Image10Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
bil_soft.Show;
end;

procedure Tana_mnu.Image14Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
taskman_form.Show;
end;

procedure Tana_mnu.Label10Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
taskman_form.Show;
end;

procedure Tana_mnu.Image11Click(Sender: TObject);
begin
 ana_mnu.Visible :=false;
donanim.Show;
end;

procedure Tana_mnu.Label11Click(Sender: TObject);
begin
 ana_mnu.Visible :=false;
donanim.Show;
end;

procedure Tana_mnu.Image12Click(Sender: TObject);
begin
  ana_mnu.Visible :=false;
ag_net.Show;
end;

procedure Tana_mnu.Label12Click(Sender: TObject);
begin
  ana_mnu.Visible :=false;
ag_net.Show;
end;

procedure Tana_mnu.Label14Click(Sender: TObject);
begin
   ana_mnu.Visible :=false;
araclar_form.Show;
end;

procedure Tana_mnu.Image8Click(Sender: TObject);
begin
   ana_mnu.Visible :=false;
araclar_form.Show;
end;

procedure Tana_mnu.Label13Click(Sender: TObject);
begin
//ana_mnu.Visible :=false;
//ayarlar.Show;
end;

procedure Tana_mnu.Image16Click(Sender: TObject);
begin
//ana_mnu.Visible :=false;
//ayarlar.Show;
end;

procedure Tana_mnu.Image17Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
hakkinda_form.Show;
end;

procedure Tana_mnu.Label15Click(Sender: TObject);
begin
ana_mnu.Visible :=false;
hakkinda_form.Show;
end;

procedure Tana_mnu.FormCreate(Sender: TObject);
begin
MyBmp := TBitmap.Create;
   image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

end.
