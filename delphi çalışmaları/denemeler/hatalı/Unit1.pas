unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    ListBox1: TListBox;
    Label1: TLabel;
    CheckBox1: TCheckBox;
    Button2: TButton;
    Edit1: TEdit;
    Button3: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
var
olay :string;
begin
if CheckBox1.Checked then
{olay:=listbox1.Items.Strings[ListBox1.itemindex]; }
//Label1.Caption:=olay;
 //Label1.Caption:=IntToStr(ListBox1.Items.Strings [ListBox1.Items.Text]);



end;

procedure TForm1.Button2Click(Sender: TObject);
begin
listbox1.itemindex:=(listbox1.itemindex+1);
end;

procedure TForm1.Button3Click(Sender: TObject);
var
hata:Integer;
begin
  if  Edit1.text ='stnc' then

  begin
  if  hata =3 then
  Close;


end;
    end;
end.
