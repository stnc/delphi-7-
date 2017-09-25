unit taskman_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  Ttaskman_form = class(TForm)
    ListBox1: TListBox;
    ListBox2: TListBox;
    Label1: TLabel;
    Label2: TLabel;
    Button1: TButton;
    Image1: TImage;
    Image9: TImage;
    Image18: TImage;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    Label22: TLabel;
    Label21: TLabel;
    Label23: TLabel;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    Label28: TLabel;
    Label30: TLabel;
    Label29: TLabel;
    Label31: TLabel;
    Label32: TLabel;
    Image4: TImage;
    Image5: TImage;
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Image18Click(Sender: TObject);
    procedure Image9Click(Sender: TObject);
    procedure Label17Click(Sender: TObject);
    procedure Label18Click(Sender: TObject);
    procedure Label19Click(Sender: TObject);
    procedure Label20Click(Sender: TObject);
    procedure Label24Click(Sender: TObject);
    procedure Label23Click(Sender: TObject);
    procedure Label21Click(Sender: TObject);
    procedure Label22Click(Sender: TObject);
    procedure Label25Click(Sender: TObject);
    procedure Label26Click(Sender: TObject);
    procedure Label27Click(Sender: TObject);
    procedure Label28Click(Sender: TObject);
    procedure Label32Click(Sender: TObject);
    procedure Label31Click(Sender: TObject);
    procedure Label29Click(Sender: TObject);
    procedure Label30Click(Sender: TObject);
    procedure Image4Click(Sender: TObject);
    procedure Image5Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  taskman_form: Ttaskman_form;

implementation

uses anamenu, baslatUnit, guvenlikUnit, guvenlik2, internet_explorer_unit,
  internet_unit, sistem_bil_unit, tweak_ui_unit, gorunum_unit,
  bil_soft_unit, donanim_unit, ag_unit, araclar, hakkinda;

{$R *.dfm}

function EnumWindowsProc(Wnd : HWnd;Form : Ttaskman_form) : Boolean; Export; {$ifdef Win32} StdCall; {$endif}
var
Buffer : Array[0..99] of char;
begin
GetWindowText(Wnd,Buffer,100);
if StrLen(Buffer) <> 0 then
Form.ListBox2.Items.Add(StrPas(Buffer));
Result := True;
end;

procedure Ttaskman_form.Button1Click(Sender: TObject);
var
          myClassName: Array[0..63] of Char;
          Handle: THandle;
        begin
          ListBox1.Items.Clear;
         // ListBox1.Font.Name := 'Courier';
          ListBox1.Items.Add(Format('%-7s %-64s',[' Handle','Class Name']));
          ListBox1.Items.Add(Format('%-7s %-64s',[' ------','----------']));

  {start off the list with the current application}

  Handle := Self.Handle;
          GetClassName(Self.Handle, myClassName, 64);
          ListBox1.Items.Add(Format('%7d %-64s',[Handle,StrPas(myClassName)]));

  {now list all the others}

  While Handle > 0 do
            begin
              Handle := GetNextWindow(Handle, GW_HWNDNEXT);
              GetClassName(Handle, myClassName, 64);
              if myClassName[0] <> '#' then
                ListBox1.Items.Add(
                  Format('%7d %-64s',[Handle,StrPas(myClassName)]));
            end;

end;


procedure Ttaskman_form.FormCreate(Sender: TObject);
begin
 button1.Visible :=false;
button1.Click;
EnumWindows(@EnumWindowsProc,LongInt(Self));
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

procedure Ttaskman_form.Image1MouseMove(Sender: TObject;
  Shift: TShiftState; X, Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure Ttaskman_form.Image18Click(Sender: TObject);
begin
 application.Terminate;
end;

procedure Ttaskman_form.Image9Click(Sender: TObject);
begin

application.Minimize ;
end;

procedure Ttaskman_form.Label17Click(Sender: TObject);
begin
taskman_form.Visible:=false;
ana_mnu.show;

end;

procedure Ttaskman_form.Label18Click(Sender: TObject);
begin
taskman_form.Visible:=false;
baslat_form.show;

end;

procedure Ttaskman_form.Label19Click(Sender: TObject);
begin
taskman_form.Visible:=false;
guvenlik.show;

end;

procedure Ttaskman_form.Label20Click(Sender: TObject);
begin
taskman_form.Visible:=false;
guvenlik_2.show;

end;

procedure Ttaskman_form.Label24Click(Sender: TObject);
begin
taskman_form.Visible:=false;
int_exp.show;


end;

procedure Ttaskman_form.Label23Click(Sender: TObject);
begin
taskman_form.Visible:=false;
internet_bil.show;

end;

procedure Ttaskman_form.Label21Click(Sender: TObject);
begin
taskman_form.Visible:=false;
sistem_bil.show;

end;

procedure Ttaskman_form.Label22Click(Sender: TObject);
begin
taskman_form.Visible:=false;
tweak_ui.show;

end;

procedure Ttaskman_form.Label25Click(Sender: TObject);
begin
taskman_form.Visible:=false;
gorunum.show;

end;

procedure Ttaskman_form.Label26Click(Sender: TObject);
begin
taskman_form.Visible:=false;
bil_soft.show;

end;

procedure Ttaskman_form.Label27Click(Sender: TObject);
begin
//taskman_form.Visible:=false;
//taskman_form.show;

end;

procedure Ttaskman_form.Label28Click(Sender: TObject);
begin
taskman_form.Visible:=false;
donanim.show;

end;

procedure Ttaskman_form.Label32Click(Sender: TObject);
begin
taskman_form.Visible:=false;
ag_net.show;

end;

procedure Ttaskman_form.Label31Click(Sender: TObject);
begin
gorunum.Visible:=false;
araclar_form.show;

end;

procedure Ttaskman_form.Label29Click(Sender: TObject);
begin
//gorunum.Visible:=false;
//ayarlar.show;

end;

procedure Ttaskman_form.Label30Click(Sender: TObject);
begin
gorunum.Visible:=false;
hakkinda_form.show;

end;

procedure Ttaskman_form.Image4Click(Sender: TObject);
begin
taskman_form.Visible :=false;
ana_mnu.Show ;
end;

procedure Ttaskman_form.Image5Click(Sender: TObject);
begin
application.Terminate ;
end;

end.
