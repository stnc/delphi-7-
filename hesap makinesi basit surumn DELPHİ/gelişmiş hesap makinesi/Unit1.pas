unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, XPMan;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    XPManifest1: TXPManifest;
    Button_4: TButton;
    Button_3: TButton;
    Button_6: TButton;
    Button_8: TButton;
    Button_2: TButton;
    Button_5: TButton;
    Button_7: TButton;
    Button_9: TButton;
    kapali: TButton;
    temizle: TButton;
    eksi: TButton;
    arti: TButton;
    carp: TButton;
    esittir: TButton;
    Button_0: TButton;
    Button_1: TButton;
    bolum: TButton;
    Button2: TButton;
    procedure Button_1Click(Sender: TObject);
    procedure Button_0Click(Sender: TObject);
    procedure Button_3Click(Sender: TObject);
    procedure Button_4Click(Sender: TObject);
    procedure Button_5Click(Sender: TObject);
    procedure Button_6Click(Sender: TObject);
    procedure Button_7Click(Sender: TObject);
    procedure Button_8Click(Sender: TObject);
    procedure Button_9Click(Sender: TObject);
    procedure artiClick(Sender: TObject);
    procedure esittirClick(Sender: TObject);
    procedure temizleClick(Sender: TObject);
    procedure kapaliClick(Sender: TObject);
    procedure Button_2Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure eksiClick(Sender: TObject);
    procedure carpClick(Sender: TObject);
    procedure bolumClick(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }

  end;
   // edit1.Text  := IntToHex(StrToInt64(edit1.Text ), 6);  // bu kod hex e �eviriri
var
  Form1: TForm1;
           x,y:real;
              sonuc:real;
toplam,cikan,carpan,bolen :Boolean;
implementation

{$R *.dfm}

procedure TForm1.Button_1Click(Sender: TObject);
begin
if edit1.text='0' then
  edit1.Text:='1'
else
  edit1.Text:=edit1.Text+'1'
end;

procedure TForm1.Button_0Click(Sender: TObject);
begin
if edit1.text='0' then
  edit1.Text:='0'
else
  edit1.Text:=edit1.Text+'0'
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
  edit1.Text:=edit1.Text+'8'
end;

procedure TForm1.Button_9Click(Sender: TObject);
begin
if edit1.text='0' then
  edit1.Text:='9'
else
  edit1.Text:=edit1.Text+'9'
end;


procedure TForm1.artiClick(Sender: TObject);
   begin
          toplam :=True;
           x:=strtoint (edit1.text );
           Edit1.Clear;
           bolum.Enabled :=False;
           arti.Enabled := False;
           carp.Enabled :=False ;
            eksi.Enabled :=False;
            Edit1.Focused ;

end;
{if Kontrol=1 then
 begin
  Islem:=1;
      IlkSayi:=strtofloat(Sonuc);
       Sonuc:=('0');
     SonucEkrani.Caption:=Sonuc;
                    end; }


procedure TForm1.esittirClick(Sender: TObject);
begin
if toplam=true then
 begin
 y:=strtocurr (Edit1.Text );
  sonuc:=x+y;
  edit1.Text:=('toplam  ='+floattostr (sonuc) );
       
           bolum.Enabled :=true;
           arti.Enabled := true;
           carp.Enabled :=true ;
            eksi.Enabled :=true;
             toplam:=false;
             cikan:=false;
             carpan:=false;
             bolen :=false;
 end;

 if cikan =true then
 begin
 y:=strtocurr (Edit1.Text );
  sonuc:=x-y;
  edit1.Text:=('��kan  ='+floattostr (sonuc) );
 end;

 if  carpan =True then
  begin
 y:=strtocurr(Edit1.Text );
  sonuc:=x*y;
  edit1.Text:=('carpan ='+floattostr (sonuc) );
       end;


 if bolen =True then
  begin
  y:=strtocurr (Edit1.Text );
  sonuc:=x / y;
  edit1.Text:=('bolum ='+floattostr (sonuc) );
       end;




end;

procedure TForm1.temizleClick(Sender: TObject);
begin
Edit1.Clear ;
  
           bolum.Enabled :=true;
           arti.Enabled := true;
           carp.Enabled :=true ;
            eksi.Enabled :=true;
             toplam:=false;
             cikan:=false;
             carpan:=false;
             bolen :=false;
end;

procedure TForm1.kapaliClick(Sender: TObject);
begin
Application.Terminate;
end;



procedure TForm1.Button1Click(Sender: TObject);
begin
     Edit1.Clear;
           bolum.Enabled :=true;
           arti.Enabled := true;
           carp.Enabled :=true ;
            eksi.Enabled :=true;
             toplam:=false;
             cikan:=false;
             carpan:=false;
             bolen :=false;
             

end;

procedure TForm1.eksiClick(Sender: TObject);
begin
          cikan  :=True;
           x:=strtoint (edit1.text );
           Edit1.Clear;
           bolum.Enabled :=False;
           arti.Enabled := False;
           carp.Enabled :=False ;
            eksi.Enabled :=False;

end;

procedure TForm1.carpClick(Sender: TObject);
begin
          carpan  :=True;
           x:=strtoint (edit1.text );
           Edit1.Clear;
           bolum.Enabled :=False;
           arti.Enabled := False;
           carp.Enabled :=False ;
            eksi.Enabled :=False;

end;

procedure TForm1.bolumClick(Sender: TObject);
begin
        
          bolen  :=True;
           x:=strtoint (edit1.text );
           Edit1.Clear;
           bolum.Enabled :=False;
           arti.Enabled := False;
           carp.Enabled :=False ;
            eksi.Enabled :=False;
         
end;



end.

