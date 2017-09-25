unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, XPMan, StdCtrls;

type
  TForm1 = class(TForm)
    Button_0: TButton;
    Button_1: TButton;
    Button_4: TButton;
    Button_3: TButton;
    Button_6: TButton;
    Button_8: TButton;
    nokta: TButton;
    Button_2: TButton;
    mr: TButton;
    Button_5: TButton;
    Button_7: TButton;
    Button_9: TButton;
    acik: TButton;
    kapali: TButton;
    m_arti: TButton;
    m_min: TButton;
    temizle: TButton;
    eksi: TButton;
    arti: TButton;
    carp: TButton;
    bolu: TButton;
    esittir: TButton;
    Edit1: TEdit;
    SonucEkrani: TLabel;
    XPManifest1: TXPManifest;
    procedure Button_1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button_1Click(Sender: TObject);

begin
if edit1.text='0' then
edit1.Text:='1'
else
edit1.Text:=edit1.Text+'1'
end;


end.
