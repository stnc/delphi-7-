unit FmGifImg;
{ Exports main form for test program for TGifImage

 2 Aug 97: - added possibility to load bmp files and save gif files
}

interface

uses
  {WinProcs, WinTypes, {Windows,} Messages, SysUtils, Classes, Graphics,
  Controls, Forms, Dialogs, StdCtrls, ExtCtrls, Menus,
  GifDecl,
  GifImgs;

type
  TForm1 = class(TForm)
    OpenDialog: TOpenDialog;
    MainMenu1: TMainMenu;
    File1: TMenuItem;
    Open1: TMenuItem;
    Read1: TMenuItem;
    Animation1: TMenuItem;
    On1: TMenuItem;
    Off1: TMenuItem;
    Slower1: TMenuItem;
    Once1: TMenuItem;
    SaveDialog: TSaveDialog;
    Saveas1: TMenuItem;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Open1Click(Sender: TObject);
    procedure On1Click(Sender: TObject);
    procedure Off1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Slower1Click(Sender: TObject);
    procedure Once1Click(Sender: TObject);
    procedure Saveas1Click(Sender: TObject);
  private
    { Private declarations }
{$ifndef Installed}
    GifImage1: TGifImage;
{$endif Installed}
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.DFM}

const
  fname1 = 'd:\Project\Delphi2\Gif\Images\95week51.gif';

procedure TForm1.FormCreate(Sender: TObject);
begin { TForm1.FormCreate }
{$ifndef Installed}
  GifImage1 := TGifImage.Create(Self);
  GifImage1.Parent := Self;
  GifImage1.Left := 10;
  GifImage1.Top := 10;
  GifImage1.AutoSize := True;
{$endif Installed}
end;  { TForm1.FormCreate }

procedure TForm1.Button1Click(Sender: TObject);
begin
  GifImage1.LoadFromGifFile(fname1);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  GifImage1.Animating := not GifImage1.Animating
end;

procedure TForm1.Open1Click(Sender: TObject);
begin { TForm1.Open1Click }
  if OpenDialog.Execute
  then begin
    case CheckType(OpenDialog.Filename) of
      GIF: begin
        GifImage1.LoadFromGifFile(OpenDialog.Filename);
        OpenDialog.Filename := '*.gif'
      end;
      BMP: begin
        GifImage1.LoadFromBmpFile(OpenDialog.Filename);
        OpenDialog.Filename := '*.bmp'
      end;
      else ShowMessage(OpenDialog.Filename + ' not recognized as a '+
                       'valid gif or bmp file' )
    end; { case }
  end;
end;  { TForm1.Open1Click }

procedure TForm1.On1Click(Sender: TObject);
begin
  GifImage1.Animating := True;
  On1.Checked := True;
  Off1.Checked := False;
end;

procedure TForm1.Off1Click(Sender: TObject);
begin
  GifImage1.Animating := False;
  On1.Checked := False;
  Off1.Checked := True;
end;

procedure TForm1.Slower1Click(Sender: TObject);
begin
  GifImage1.Slower;
end;

procedure TForm1.Once1Click(Sender: TObject);
begin
  GifImage1.AnimateOnce;
end;

procedure TForm1.Saveas1Click(Sender: TObject);
begin
  if SaveDialog.Execute
  then GifImage1.SaveToFile(SaveDialog.Filename)
end;

end.
