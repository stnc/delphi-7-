unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, jpeg, StdCtrls, XPMan, Menus,mmsystem,registry;

type
  TForm1 = class(TForm)
    Image1: TImage;
    XPManifest1: TXPManifest;
    patch: TButton;
    Button2: TButton;
    Button3: TButton;
    PopupMenu1: TPopupMenu;
    PATCH1: TMenuItem;
    Exit1: TMenuItem;
    Exit2: TMenuItem;
    Button1: TButton;
    procedure FormCreate(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Button2Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Exit1Click(Sender: TObject);
    procedure Exit2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure patchClick(Sender: TObject);
    procedure PATCH1Click(Sender: TObject);
  
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

procedure TForm1.FormCreate(Sender: TObject);
var
 region: HRgn;
begin
  { yuvarlak form olusturur
  region:=CreateEllipticRgn(5,5,200,2550);
  SetWindowRgn(handle, region, true); }
  form1.brush.style:=bsClear;
  button1.Visible :=false;
    button1.Click ;
end;



procedure TForm1.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
  releasecapture;
perform(wm_syscommand,$f012,0);
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
Application.MessageBox('www.paylasimweb.com','Cracked by Stnc',0) 
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure TForm1.Exit1Click(Sender: TObject);
begin
button2.Click ;
end;

procedure TForm1.Exit2Click(Sender: TObject);
begin
application.Terminate ;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
application.Minimize ;
application.Terminate ;
end;

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


procedure TForm1.patchClick(Sender: TObject);

   var
  reg:TRegistry;
begin
reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Ahead\Nero - Burning Rom\Info',true);
  Reg.WriteString('Serial6l','1A21-0809-9030-2256-9634-5919');
   Reg.WriteString('Serial6','1A21-0809-9030-2256-9634-5919');
     Reg.WriteString('Serial7l','4C82-0010-8011-0000-0213-4717-3333');
   Reg.WriteString('Serial7','4C82-0010-8011-0000-0213-4717-3333');
     Reg.WriteString('User','www.paylasimweb.com');
     Reg.WriteString('Company','www.paylasimweb.com');
  reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
  reg.OpenKey('SOFTWARE\Ahead\Plug-ins\BackItUp\Info',true);
  Reg.WriteString('Serial6l','1A42-0809-4030-2303-2284-9724');
         Reg.WriteString('User','www.paylasimweb.com');
       reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\Dolby Digital (5.1)\Info',true);
  Reg.WriteString('Serial6l','1A45-0609-4130-2410-0365-4874');
     Reg.WriteString('User','www.paylasimweb.com');
       reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\HE-AAC\Info',true);
  Reg.WriteString('Serial6l','1A42-0809-4030-2303-2284-9724');
     Reg.WriteString('User','www.paylasimweb.com');
       reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\MP3\Info',true);
  Reg.WriteString('Serial6l','1A40-0809-9130-2448-9832-3695');
     Reg.WriteString('User','www.paylasimweb.com');
              reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\mp3PRO\Info',true);
  Reg.WriteString('Serial6l','1A41-0609-9030-2231-0668-0731');
  Reg.WriteString('Serial7l','1C00-0010-8011-0000-3559-0840-6072');
  Reg.WriteString('Serial7','1C00-0010-8011-0000-3559-0840-6072');
     Reg.WriteString('User','www.paylasimweb.com');
                   reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\MPEG2/DVD\Info',true);
  Reg.WriteString('Serial6l','1A44-0809-9130-2200-9024-4341');
  Reg.WriteString('Serial7l','1C02-0010-8011-0000-0964-3916-2879');
  Reg.WriteString('Serial7','1C02-0010-8011-0000-0964-3916-2879');
     Reg.WriteString('User','www.paylasimweb.com');
                   reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\MPEG2/SVCD\Info',true);
  Reg.WriteString('Serial6l','1A43-0009-4030-2488-0470-7008');
     Reg.WriteString('User','www.paylasimweb.com');
                   reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\Multichannel\Info',true);
  Reg.WriteString('Serial6l','1A47-0609-9130-2406-1577-4097');
    Reg.WriteString('Serial7l','1C01-0010-8011-0000-8936-4487-5088');
      Reg.WriteString('Serial7','1C01-0010-8011-0000-8936-4487-5088');
     Reg.WriteString('User','www.paylasimweb.com');
                        reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\Nero Digital Universal\Info',true);
  Reg.WriteString('Serial6l','1A4A-0609-4030-2456-6701-5762');
     Reg.WriteString('User','www.paylasimweb.com');
                             reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\Parental Control\Info',true);
  Reg.WriteString('Serial6l','1A49-0809-9030-2261-1072-6768');
     Reg.WriteString('User','www.paylasimweb.com');
 reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\Windows Media Player\Info',true);
  Reg.WriteString('Serial6l','1A46-0809-9030-2412-6402-1825');
     Reg.WriteString('User','www.paylasimweb.com');
     reg:=TRegistry.Create;
  reg.RootKey:= HKEY_LOCAL_MACHINE;
 reg.OpenKey('SOFTWARE\Ahead\Plug-ins\Advanced Audio\Info',true);
  Reg.WriteString('Serial7l','1C03-0010-8011-0000-9095-7348-4886');
    Reg.WriteString('Serial7','1C03-0010-8011-0000-9095-7348-4886');
     Reg.WriteString('User','www.paylasimweb.com');
   Reg.Free;
  messagedlg ('PATCH SUCCESFUL',mtInformation ,[mbok],0)
end;





procedure TForm1.PATCH1Click(Sender: TObject);
begin
patch.Click ;
end;

end.
