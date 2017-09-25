unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,TlHelp32;

type
  TForm1 = class(TForm)
    Button1: TButton;
    ListBox1: TListBox;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
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
 procedure Module32List(S : TStrings);
var
 Module32 : TModuleEntry32;
 SS       : THandle;
 Next     : Bool;
begin
 //
 Module32.dwSize := SizeOf(TModuleEntry32);
 //
 SS := CreateToolHelp32Snapshot(TH32CS_SNAPMODULE, 0);
 //
 If Module32First(SS, Module32) then
  begin
 //
   S.Add(Module32.szExePath);
   Repeat
 //
    Next := Module32Next(SS, Module32);
 //
    If Next Then S.Add(Module32.szExePath);
   Until Not Next;
  end;
  CloseHandle(SS);
end;

procedure TForm1.Button1Click(Sender: TObject);

var cName : Array[0..63] of Char;
Handle: THandle;
begin
  ListBox1.Items.Clear;
  ListBox1.Sorted := True;
  Handle := Self.Handle;
  GetClassName(Self.Handle, cName, 64);
  ListBox1.Items.Add (StrPas(cName) + ' ('+IntToStr(Handle)+')');
  While Handle > 0 do begin
    Handle := GetNextWindow(Handle, GW_HWNDNEXT);
    GetClassName(Handle, cName, 64);
    ListBox1.Items.Add (StrPas(cName) + ' ('+IntToStr(Handle)+')');
  end;
   end;

procedure TForm1.FormCreate(Sender: TObject);
begin
 //
 Module32List(ListBox1.Items);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
 ListBox1.Items.Clear;
 //
 Module32List(ListBox1.Items);
end;

end.
