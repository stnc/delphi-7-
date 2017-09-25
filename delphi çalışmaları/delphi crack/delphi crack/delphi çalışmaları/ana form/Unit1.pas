unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, mmsystem,Comobj, jpeg, XPMan, Buttons,ShellApi;

type
  TForm1 = class(TForm)
    Image2: TImage;
    Image3: TImage;
    Image1: TImage;
    Image4: TImage;
    XPManifest1: TXPManifest;
    Button1: TButton;
    Button2: TButton;
    SpeedButton1: TSpeedButton;
    Image5: TImage;
    procedure Image1MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);


    procedure Image2MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image1Click(Sender: TObject);
    procedure Image4Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Image5Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Image1MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;











procedure TForm1.Image2MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure TForm1.Image1Click(Sender: TObject);
begin
application.Minimize ;
end;

procedure TForm1.Image4Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
    MessageDlg('Edit Bilgisini Silmek Ýstediðinizden Emin misiniz?',mtConfirmation, [mbYes, mbNo], 0)

  
    end;

procedure TForm1.Button2Click(Sender: TObject);
begin
    ShowMessage('Web Browser Ýçeriði Boþ');
end;

procedure TForm1.Image5Click(Sender: TObject);
begin
ShellAbout(0,'Stnc Sistem Organizator','STNC Software',Application.Icon.Handle);
end;

end.
