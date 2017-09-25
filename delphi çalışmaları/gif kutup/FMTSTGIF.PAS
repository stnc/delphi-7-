unit FmTstGIF;
{ Exports TTestGifForm, which is the main form of the small test
program "TestGif" which demonstrates the TGifFile object of
the unit GifUnit.

By Reinier Sterkenburg, Delft, The Netherlands
10 Mar 97: - created
 3 Apr 97: - added Image Info option (using FmImInfo and FmSubImg)
 2 Aug 97: - adapted to changes in used units
}

interface

uses
  WinProcs, WinTypes, {Windows,} Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  Menus, ExtCtrls,
  ColorTbl,        { Imports TColorTable }
  DynArrB,         { Imports TByteArray2D }
  FmAbout,         { Imports AboutBox }
  GifDecl,         { Imports CheckType }
  GifUnit,         { Imports TGifFile }
  IniFiles;        { Imports TIniFile }


type
  TTestGifForm = class(TForm)
    MainMenu1: TMainMenu;
    File1: TMenuItem;
    Open1: TMenuItem;
    Save1: TMenuItem;
    Saveas1: TMenuItem;
    Exit1: TMenuItem;
    About1: TMenuItem;
    OpenDialog: TOpenDialog;
    SaveDialog: TSaveDialog;
    Image: TImage;
    Edit1: TMenuItem;
    Imageinfo1: TMenuItem;
    procedure Open1Click(Sender: TObject);
    procedure Save1Click(Sender: TObject);
    procedure Saveas1Click(Sender: TObject);
    procedure Exit1Click(Sender: TObject);
    procedure About1Click(Sender: TObject);
    procedure Imageinfo1Click(Sender: TObject);
  private
    { Private declarations }
    GifFile: TGifFile;
    Filename: String;
  public
    { Public declarations }
  end; { TTestGifForm }

var
  TestGifForm: TTestGifForm;

implementation

uses FmImInfo;

{$R *.DFM}

const
  CRLF = #13+#10;

procedure TTestGifForm.Open1Click(Sender: TObject);
var
  IniFilename: String;
  IniFile: TIniFile;
  Bitmap: TBitmap;
  Colormap: TColorTable;
  Pixels: TByteArray2D;
begin { TTestGifForm.Open1Click }
  IniFilename := Application.Exename;
  IniFilename := ChangeFileExt(Inifilename, '.ini');
  IniFile := TIniFile.Create(IniFilename);
  OpenDialog.InitialDir := Inifile.ReadString('History', 'Last directory for reading', '');
  if OpenDialog.Execute
  then begin
    case CheckType(OpenDialog.Filename) of
      GIF: begin
             GifFile := TGifFile.Create;
             GifFile.LoadFromFile(OpenDialog.Filename);
             Image.Picture.Bitmap := GifFile.AsBitmap;
             Filename := OpenDialog.Filename;
             Inifile.WriteString('History', 'Last directory for reading', ExtractFilePath(Filename));
           end;
      BMP: begin
             Bitmap := TBitmap.Create;
             Bitmap.LoadFromFile(OpenDialog.Filename);
             Image.Picture.Bitmap := Bitmap;
             BitmapToPixelmatrix(Bitmap, Colormap, Pixels);
             GifFile := TGifFile.Create;
             GifFile.AddSubImage(Colormap, Pixels);
             Inifile.WriteString('History', 'Last directory for reading', ExtractFilePath(Filename));
           end;
      else ShowMessage('Cannot read file type');
    end; { case }
  end;
  IniFile.Free;
end;  { TTestGifForm.Open1Click }

procedure TTestGifForm.Save1Click(Sender: TObject);
var CanSave: Boolean;
begin { TTestGifForm.Save1Click }
  if not FileExists(Filename)
  then CanSave := True
  else CanSave := MessageDlg('File '+Filename+' already exists, overwrite?',
                             mtConfirmation, [mbYes, mbNo], 0) = mrYes;
  if CanSave
  then GifFile.SaveToFile(Filename)
end;  { TTestGifForm.Save1Click }

procedure TTestGifForm.Saveas1Click(Sender: TObject);
var
  IniFile: TIniFile;
  IniFilename: String;
begin { TTestGifForm.Saveas1Click }
  IniFilename := Application.Exename;
  IniFilename := ChangeFileExt(Inifilename, '.ini');
  IniFile := TIniFile.Create(IniFilename);
  SaveDialog.InitialDir := Inifile.ReadString('History', 'Last directory for writing', '');
  if SaveDialog.Execute
  then begin
    Filename := SaveDialog.Filename;
    Save1Click(Sender);
    Inifile.WriteString('History', 'Last directory for writing', ExtractFilePath(Filename));
  end;
  IniFile.Free;
end;  { TTestGifForm.Saveas1Click }

procedure TTestGifForm.Exit1Click(Sender: TObject);
begin { TTestGifForm.Exit1Click }
  Close
end;  { TTestGifForm.Exit1Click }

procedure TTestGifForm.About1Click(Sender: TObject);
begin { TTestGifForm.About1Click }
  AboutBox.Show;
end;  { TTestGifForm.About1Click }

procedure TTestGifForm.Imageinfo1Click(Sender: TObject);
var GifImageInfoDialog: TGifImageInfoDialog;
begin { TTestGifForm.Imageinfo1Click }
  GifImageInfoDialog := TGifImageInfoDialog.Create(GifFile);
  GifImageInfoDialog.ShowModal;
  GifImageInfoDialog.Free;
end;  { TTestGifForm.Imageinfo1Click }

end.
