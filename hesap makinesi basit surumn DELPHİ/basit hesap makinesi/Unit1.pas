unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Button1: TButton;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    Edit3: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;

    procedure FormCreate(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
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

end.











































  {
procedure TForm1.Button1Click(Sender: TObject);
begin
if CheckBox1.Checked =True then
  begin
    x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x+y;
       edit3.Text:=('toplam  ='+inttostr (sonuc) );
       CheckBox1.Caption :=('toplam  ='+inttostr (sonuc) );
        end;

 if CheckBox2.Checked =True then
begin
      x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x-y;
       edit3.Text:=('çýkarma  ='+inttostr (sonuc) );
    CheckBox2.Caption :=('çýkarma  ='+inttostr (sonuc) );
       end;



    if CheckBox3.Checked=True then
   begin
      x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x*y;
       edit3.Text:=('çarpma  ='+inttostr (sonuc) );
   CheckBox3.Caption :=('çarpma  ='+inttostr (sonuc) );
            end;

 if CheckBox4.Checked=True then
   begin
      x:=strtoint (Edit1.Text );
       y:=strtoint (Edit2.Text );
       sonuc:=x div y;
      edit3.Text:=('bolme  ='+inttostr (sonuc) );
   CheckBox4.Caption :=('bolme  ='+inttostr (sonuc) );
            end;


               end;
               }
