unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, XPMan;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    XPManifest1: TXPManifest;
    Button_4: TButton;
    Button_3: TButton;
    Button_6: TButton;
    Button_8: TButton;
    Button_2: TButton;
    Button_5: TButton;
    Button_7: TButton;
    Button_9: TButton;
    acik: TButton;
    kapali: TButton;
    temizle: TButton;
    eksi: TButton;
    arti: TButton;
    carp: TButton;
    bolu: TButton;
    esittir: TButton;
    Button_0: TButton;
    Button_1: TButton;
//    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button_1Click(Sender: TObject);
    procedure Button_2Click(Sender: TObject);
    procedure Button_3Click(Sender: TObject);
    procedure Button_0Click(Sender: TObject);
    procedure Button_4Click(Sender: TObject);
    procedure Button_5Click(Sender: TObject);
    procedure Button_6Click(Sender: TObject);
    procedure Button_7Click(Sender: TObject);
    procedure Button_8Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;
 var
 Form1: TForm1;
X,Y,sonuc:integer;
implementation

{$R *.dfm}


procedure TForm1.FormCreate(Sender: TObject);
begin
Form1.Font.Color :=clRed ;
Form1.Color :=clBlack;
end;

procedure TForm1.Button5Click(Sender: TObject);
begin
    x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x+y;
       edit3.Text:=('toplam  ='+inttostr (sonuc) );
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x-y;
       edit3.Text:=('çýkarma  ='+inttostr (sonuc) );
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
      x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x*y;
       edit3.Text:=('çarpma  ='+inttostr (sonuc) );
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
      x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x div y;
      edit3.Text:=('bolme  ='+inttostr (sonuc) );
end;

procedure TForm1.Button_1Click(Sender: TObject);

begin
if edit1.text='0' then edit1.Text:='1'
else edit1.Text:=edit1.Text+'1'
end;



procedure TForm1.Button_2Click(Sender: TObject);
begin
if edit1.text='0' then
edit1.Text:='2'
else
edit1.Text:=edit1.Text+'2'
end;

procedure TForm1.Button_3Click(Sender: TObject);
begin
if edit1.text='0' then
edit1.Text:='3'
else
edit1.Text:=edit1.Text+'3'
end;

procedure TForm1.Button_0Click(Sender: TObject);
begin
if edit1.text='0' then
edit1.Text:='0'
else
edit1.Text:=edit1.Text+'0'
end;

procedure TForm1.Button_4Click(Sender: TObject);
begin
if edit1.text='0' then
     edit1.Text:='4'
else
  edit1.Text:=edit1.Text+'4'
end;

procedure TForm1.Button_5Click(Sender: TObject);
begin
if edit1.text='0' then
     edit1.Text:='5'
else
    edit1.Text:=edit1.Text+'5'
end;

procedure TForm1.Button_6Click(Sender: TObject);
begin
     if edit1.text='0' then
     edit1.Text:='6'
else
edit1.Text:=edit1.Text+'6'
end;

procedure TForm1.Button_7Click(Sender: TObject);
begin
if edit1.text='0' then
     edit1.Text:='7'
else
    edit1.Text:=edit1.Text+'7'
end;

procedure TForm1.Button_8Click(Sender: TObject);
begin
if edit1.text='0' then
     edit1.Text:='8'
else
  edit1.Text:=edit1.Text+'9'
end;

end.

