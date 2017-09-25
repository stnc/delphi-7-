unit hakkinda;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, jpeg, ExtCtrls, StdCtrls;

type
  Thakkinda_form = class(TForm)
    Image1: TImage;
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
  hakkinda_form: Thakkinda_form;

implementation

uses anamenu, baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, sistem_bil_unit, tweak_ui_unit, bil_soft_unit,
  taskman_unit, donanim_unit, ag_unit, gorunum_unit, araclar;

{$R *.dfm}

procedure Thakkinda_form.Label17Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
ana_mnu.show;

end;

procedure Thakkinda_form.Label18Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
baslat_form.show;

end;

procedure Thakkinda_form.Label19Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
guvenlik.show;

end;

procedure Thakkinda_form.Label20Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
guvenlik_2.show

end;

procedure Thakkinda_form.Label24Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
int_exp.show;


end;

procedure Thakkinda_form.Label23Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
internet_bil.show;

end;

procedure Thakkinda_form.Label21Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
sistem_bil.show;

end;

procedure Thakkinda_form.Label22Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
tweak_ui.show;

end;

procedure Thakkinda_form.Label25Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
gorunum.show;

end;

procedure Thakkinda_form.Label26Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
bil_soft.show;

end;

procedure Thakkinda_form.Label27Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
taskman_form.show;

end;

procedure Thakkinda_form.Label28Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
donanim.show ;

end;

procedure Thakkinda_form.Label32Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
ag_net.show;

end;

procedure Thakkinda_form.Label31Click(Sender: TObject);
begin
hakkinda_form.Visible:=false;
araclar_form.show;

end;

procedure Thakkinda_form.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show;

end;

procedure Thakkinda_form.Label30Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//hakkinda_form.show;

end;

procedure Thakkinda_form.Image4Click(Sender: TObject);
begin
hakkinda_form.Visible :=false;
ana_mnu.Show ;
end;

procedure Thakkinda_form.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
