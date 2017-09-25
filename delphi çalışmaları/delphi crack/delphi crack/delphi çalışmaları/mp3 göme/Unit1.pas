unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,mmsystem, MPlayer, XPMan;

type
  TForm1 = class(TForm)
    Button1: TButton;
    MediaPlayer1: TMediaPlayer;
    XPManifest1: TXPManifest;
    Button2: TButton;
    Button3: TButton;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);

  

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}
{$R sahin.RES}

procedure TForm1.Button1Click(Sender: TObject);
var
 rStream: TResourceStream;
 fStream: TFileStream;
 fname: string;
begin

 fname:=ExtractFileDir(Paramstr(0))+'sahin.mp3';
 rStream := TResourceStream.Create
           (hInstance, 'sahin', RT_RCDATA);
 try
  fStream := TFileStream.Create(fname, fmCreate);
  try
   fStream.CopyFrom(rStream, 0);
  finally
   fStream.Free;
  end;
 finally
  rStream.Free;
 end;

 MediaPlayer1.Close;
 MediaPlayer1.FileName:=fname;
 MediaPlayer1.Open;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
button1.Visible :=(false);
mediaplayer1.Visible:=(false);
button1.Click ;
mediaplayer1.Play ;
end;

end.

