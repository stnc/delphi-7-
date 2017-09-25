unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,mmsystem;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
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
 {$R ses.RES}
procedure TForm1.Button1Click(Sender: TObject);
var
  hFind, hRes: THandle;
  Song: PChar;
begin
  hFind:=FindResource(HInstance, 'ses', 'WAVE');

 if hFind<>0 then begin
   hRes:=LoadResource(HInstance, hFind);
   if hRes<>0 then begin
     Song:=LockResource(hRes);
     if Assigned(Song) then
       SndPlaySound(Song, snd_ASync or snd_Memory or SND_LOOP or SND_NOSTOP);
     UnlockResource(hRes);

   end;
   FreeResource(hFind);
 end;
 end;
 procedure StopWav;
var buffer: array[0..2] of char;
begin
buffer[0] := #0;
PlaySound(Buffer, 0, SND_PURGE);
end;





procedure TForm1.Button2Click(Sender: TObject);
begin
StopWav;
    PlayWavFromResource(1);
   end;
end.
