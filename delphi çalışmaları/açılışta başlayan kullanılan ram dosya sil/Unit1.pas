unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,ShlOBJ,registry, ExtCtrls, Gauges, CheckLst, XPMan,
  ComCtrls;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Gauge1: TGauge;
    Label1: TLabel;
    Timer1: TTimer;
    CheckListBox1: TCheckListBox;
    ProgressBar1: TProgressBar;
    XPManifest1: TXPManifest;
    Label2: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure FormCreate(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  reg,reg2:Tregistry;
  a,b,c:integer;

implementation
const
x='\Software\Microsoft\Windows\CurrentVersion\Run';

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
SHAddToRecentDocs(SHARD_PATH, nil);

  SHAddToRecentDocs(SHARD_PATH, nil);
  ShowMessage('Temizlendi');

end;

procedure TForm1.Button2Click(Sender: TObject);

var
  DirInfo: TSearchRec;
  r : Integer;
begin
  r := FindFirst('C:\Documents and Settings\Admin\Local Settings\Temp\*.*', FaAnyfile, DirInfo);
  while r = 0 do  begin
    if ((DirInfo.Attr and FaDirectory <> FaDirectory) and
        (DirInfo.Attr and FaVolumeId <> FaVolumeID)) then
      if DeleteFile(pChar('C:\Documents and Settings\Admin\Local Settings\Temp\' + DirInfo.Name))
         = false then
       ShowMessage('C:\Documents and Settings\Admin\Local Settings\Temp\'+DirInfo.Name+' silinemiyor!!!');
    r := FindNext(DirInfo);
  end;
  SysUtils.FindClose(DirInfo);
  if RemoveDirectory('C:\Documents and Settings\Admin\Local Settings\Temp') = false then
    ShowMessage('C:\Documents and Settings\Admin\Local Settings\Temp klasörü silinemiyor!!!');
end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
var
s:string;
begin
reg2:=tregistry.Create;
reg2.RootKey:=HKEY_LOCAL_MACHINE;
reg2.openKey(x,true);
a:=CheckListBox1 .Items.Count;
   for b:=0 to (a-1) do
       begin
        if not CheckListBox1 .Checked[b]
        then
                begin
                s:=CheckListBox1 .Items.Strings[b];
                reg2.DeleteValue(s);
                end;
       end;
reg2.CloseKey;
reg2.Free;
end;

procedure TForm1.FormCreate(Sender: TObject);

   begin
reg:=tregistry.Create;
reg.RootKey:=HKEY_LOCAL_MACHINE;
reg.OpenKey(x,true);
reg.GetValueNames(CheckListBox1 .Items);
reg.CloseKey;
reg.Free;
a:=CheckListBox1 .Items.Capacity;
for b:=0 to (a-1)
  do
  CheckListBox1 .Checked[b]:=true;
end;





procedure TForm1.Button3Click(Sender: TObject);

begin
reg:=tregistry.Create;
reg.RootKey:=HKEY_LOCAL_MACHINE;
reg.OpenKey(x,true);
reg.GetValueNames(CheckListBox1 .Items);
reg.CloseKey;
reg.Free;
a:=CheckListBox1 .Items.Capacity;
for b:=0 to (a-1)
  do
  CheckListBox1 .Checked[b]:=true;
end;


procedure TForm1.Button4Click(Sender: TObject);

begin
reg2:=Tregistry.Create;
reg2.RootKey:=HKEY_CLASSES_ROOT;
reg2.OpenKey('\Unknown\shell\notePAD\COMMAND',true);
reg2.WriteString('','notepad.exe %1');
reg2.CloseKey;
reg2.Free;
end;


procedure TForm1.Timer1Timer(Sender: TObject);
var
m:tmemorystatus;
begin
globalmemorystatus (m);
label1.caption:='Ram inizin Kullanilan Kismi %'+inttostr(m.dwmemoryload);
gauge1.Progress:=m.dwMemoryLoad;
ProgressBar1.Position :=m.dwMemoryLoad ;
Label2.Caption:=ProgressBar1.Hint;
end;

end.
