unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs,registry, StdCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    ListBox1: TListBox;
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

procedure TForm1.Button1Click(Sender: TObject);

var
R:Tregistry;
begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall',false);
R.GetKeyNames(ListBox1.Items);
R.CloseKey;
R.free;
end;
procedure TForm1.Button2Click(Sender: TObject);

var
R:Tregistry;
begin
R:=TRegistry.Create;
R.RootKey:=HKEY_LOCAL_MACHINE;
R.OpenKey('\Yeni Anahtar',false);
if R.ValueExists('Delphi') then
 ShowMessage(R.ReadString('Delphi'))
 else
 ShowMessage('Dize bulunamadý');
R.CloseKey;
R.free;
end;

end.
