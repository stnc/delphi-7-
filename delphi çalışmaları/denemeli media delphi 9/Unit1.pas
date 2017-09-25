unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, MPlayer, ExtCtrls, XPMan;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Panel1: TPanel;
    XPManifest1: TXPManifest;
    Timer1: TTimer;
    MediaPlayer1: TMediaPlayer;
    dialog: TOpenDialog;
    s: TProgressBar;
    ScrollBar1: TScrollBar;
    procedure ScrollBar1Change(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Timer1Timer(Sender: TObject);
begin
ScrollBar1.OnChange:=nil;
ScrollBar1.Position:=MediaPlayer1.Position;
ScrollBar1.OnChange:=ScrollBar1.OnChange;


end;

procedure TForm1.Button1Click(Sender: TObject);
begin
if (dialog.Execute)then;
MediaPlayer1.FileName :=dialog.FileName;
Timer1.Enabled:=false;
MediaPlayer1.Display:=Panel1;
MediaPlayer1.DisplayRect:=Rect(0,0,Form1.ClientHeight,ClientWidth );
ScrollBar1.Max  :=MediaPlayer1.Length;


end;

procedure TForm1.ScrollBar1Change(Sender: TObject);
begin
MediaPlayer1.Pause;
ScrollBar1.Position:=MediaPlayer1.Position;
MediaPlayer1.Play;
end;

end.
