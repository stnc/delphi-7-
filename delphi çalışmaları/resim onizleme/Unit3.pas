unit Unit3;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, ShellCtrls, StdCtrls, Buttons;

type
  TForm3 = class(TForm)
    ShellTreeView1: TShellTreeView;
    tamam: TBitBtn;
    iptal: TBitBtn;
    yol_klaor: TLabel;
    procedure tamamClick(Sender: TObject);
    procedure iptalClick(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form3: TForm3;

implementation

uses proje_unit;

{$R *.dfm}



procedure TForm3.tamamClick(Sender: TObject);
begin
yol_klaor.Caption :=ShellTreeView1.Path;
form3.Close;  // bellekten kaldýr
form1.Show ;  // form1 i göster
form1.Enabled :=true;  // form 1 i kullanlýr  yap

end;

procedure TForm3.iptalClick(Sender: TObject);
begin

form3.Close;  //kapatr formu
form1.Show ;  // form1 i göster
form1.Enabled :=true;  // form 1 i kullanlýr  yap

end;

end.
