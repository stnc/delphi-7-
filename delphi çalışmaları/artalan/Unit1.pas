unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs,  ShlObj, StdCtrls, ComCtrls,JPEG,registry;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
  private
  DeskTopCanavas:TCanvas;
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
            JPG:TJPEGIMAGE;
implementation

{$R *.dfm}
// masa ustu yenile
   procedure RefreshDesktop1;
begin
  SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST, nil, nil);
end;
 // masaustu ne yazý yazar
procedure TForm1.Button1Click(Sender: TObject);
begin
DeskTopCanavas:=TCanvas.Create;
DeskTopCanavas.Handle:=GetDC(Hwnd_Desktop);
DeskTopCanavas.Font.Size:=35;

DeskTopCanavas.TextOut(50,80,'www.dronymc.cjb.net');

end;

procedure TForm1.Button2Click(Sender: TObject);

var
s: string;

begin
s := 'c:\windows\Gone Fishing.bmp';
SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, PChar(s),0);
  RefreshDesktop1;
end;

procedure TForm1.Button3Click(Sender: TObject);

var
  Reg: TRegIniFile;
begin
  Reg := TRegIniFile.Create('Control Panel');
  Reg.WriteString('desktop', 'Wallpaper',

       'c:\windows\Prairie Wind.bmp');
  Reg.WriteString('desktop', 'TileWallpaper', '3');
  Reg.Free;
  SystemParametersInfo(SPI_SETDESKWALLPAPER,0, nil, SPIF_SENDWININICHANGE);
end;


end.
