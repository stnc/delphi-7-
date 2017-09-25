unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, ExtDlgs;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Button1: TButton;
    Image1: TImage;
    SavePictureDialog1: TSavePictureDialog;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure GrabScreen;
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}
 procedure Tform1.GrabScreen;

var width, height : word;
    desktop : HDC;
begin
  width := Screen.Width;
  height := Screen.Height;
  desktop := GetWindowDC(GetDesktopWindow);
  Image1.Picture.Bitmap.Width := width;
  Image1.Picture.Bitmap.Height := height;
  BitBlt( Image1.Picture.Bitmap.Canvas.Handle, 0, 0,
          width, height, desktop, 0, 0, SRCCOPY );
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
     GrabScreen
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
if (SavePictureDialog1.Execute ) then
Image1.Picture.SaveToFile(SavePictureDialog1.FileName ); 
end;

end.
