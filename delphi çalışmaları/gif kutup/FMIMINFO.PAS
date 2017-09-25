unit FmImInfo;

interface

uses WinProcs, WinTypes, SysUtils, Classes, Graphics, Forms, Controls,
  StdCtrls, Buttons, ExtCtrls, Spin,
  GifUnit, FmSubImg;


type
  TGifImageInfoDialog = class(TForm)
    OKBtn: TButton;
    CancelBtn: TButton;
    Bevel1: TBevel;
    V87a: TRadioButton;
    V89a: TRadioButton;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    WidthEdit: TSpinEdit;
    HeightEdit: TSpinEdit;
    PackedFieldsEdit: TSpinEdit;
    BgColorIndexEdit: TSpinEdit;
    AspectRatioEdit: TSpinEdit;
    HasGlobalColormapBox: TCheckBox;
    BitsPerPixelEdit: TSpinEdit;
    Label6: TLabel;
    NoSubImagesEdit: TSpinEdit;
    Label7: TLabel;
    Button1: TButton;
    NoColorsEdit: TSpinEdit;
    Label8: TLabel;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
    SubImageDialog: TSubImageDialog;
  public
    { Public declarations }
    constructor Create(GifImage: TGifFile);
  end;

var
  GifImageInfoDialog: TGifImageInfoDialog;

implementation

{$R *.DFM}

constructor TGifImageInfoDialog.Create(GifImage: TGifFile);
begin { TGifImageInfoDialog.Create }
  inherited Create(nil);
  with GifImage
  do begin
    if Header.Version[1] = '7'
    then V87a.Checked := True
    else V89a.Checked := True;
    WidthEdit.Value := ScreenDescriptor.ScreenWidth;
    HeightEdit.Value := ScreenDescriptor.ScreenHeight;
    PackedFieldsEdit.Value := ScreenDescriptor.PackedFields;
    BgColorIndexEdit.Value := ScreenDescriptor.BackgroundColorIndex;
    AspectRatioEdit.Value := ScreenDescriptor.AspectRatio;
    HasGlobalColormapBox.Checked := HasGlobalColormap;
    BitsPerPixelEdit.Value := BitsPerPixel;
    NoSubImagesEdit.value := SubImages.Count;
    if HasGlobalColormap
    then NoColorsEdit.Value := GlobalColormap.Count;
    SubImageDialog := TSubImageDialog.Create(SubImages);
  end;
end;  { TGifImageInfoDialog.Create }

procedure TGifImageInfoDialog.Button1Click(Sender: TObject);
begin
  SubImageDialog.Show;
end;

end.
