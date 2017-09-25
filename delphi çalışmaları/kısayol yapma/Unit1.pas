unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, StdCtrls, Buttons;

type
  TForm1 = class(TForm)
    HotKey1: THotKey;
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
     procedure hotykey(var msg:TMessage); message WM_HOTKEY;
    procedure FormKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
//    procedure Button1Click(Sender: TObject);
//    procedure BitBtn1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;
var
  Form1: TForm1;
  id,id2:Integer;

implementation

{$R *.dfm}


 procedure TForm1.hotykey(var msg:TMessage);
begin
  if (msg.LParamLo=VK_PRIOR  )and (msg.LParamHi=21)  then
  begin
    ShowMessage('Ctrl + Q ');
  end;

  if (msg.LParamLo=MOD_CONTROL) and (msg.LParamHi=82) then
  begin
    ShowMessage('Ctrl + R ');
  end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  id:=GlobalAddAtom('hotkey');
  RegisterHotKey(handle,id,VK_PRIOR ,21);

  id2:=GlobalAddAtom('hotkey2');
  RegisterHotKey(handle,id2,mod_control,82);
end;

procedure TForm1.FormDestroy(Sender: TObject);
begin 
  id:=GlobalAddAtom('hotkey'); 
  RegisterHotKey(handle,id,mod_control,81); 

  id2:=GlobalAddAtom('hotkey2'); 
  RegisterHotKey(handle,id2,mod_control,82); 
end;

procedure TForm1.FormKeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);

  begin
if (ssCtrl in Shift) and (chr(Key) in ['A', 'a']) then

ShowMessage('Ctrl-A');
end;





end.
