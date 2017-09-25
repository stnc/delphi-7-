unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs;

type
  TForm1 = class(TForm)
    procedure FormCreate(Sender: TObject);
       procedure WMHotKey(var Msg : TWMHotKey); message WM_HOTKEY;
    procedure FormDestroy(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation
   const right = 27;
{$R *.dfm}

    procedure TForm1.WMHotKey (var Msg : TWMHotKey);
begin
  if Msg.HotKey = right  then
    ShowMessage('right buuu');
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  RegisterHotKey(Form1.Handle,right,0,
                 VK_RIGHT );
end;

procedure TForm1.FormDestroy(Sender: TObject);
begin
    UnRegisterHotKey (Form1.Handle, right);
end;

end.
