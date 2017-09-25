unit FmSubImg;

interface

uses WinProcs, WinTypes, SysUtils, Classes, Graphics, Forms, Controls,
  StdCtrls, Buttons, ExtCtrls, Tabs, Spin,
  GifDecl,         { Imports TExtension }
  GifUnit,         { Imports TGifSubImage }
  ShowExt;         { Imports ShowExtension }

type
  TSubImageDialog = class(TForm)
    OKBtn: TButton;
    CancelBtn: TButton;
    TabSet: TTabSet;
    HasLocalColormapBox: TCheckBox;
    NoColorsEdit: TSpinEdit;
    Label8: TLabel;
    BitsPerPixelEdit: TSpinEdit;
    Label6: TLabel;
    GroupBox1: TGroupBox;
    LeftEdit: TSpinEdit;
    TopEdit: TSpinEdit;
    WidthEdit: TSpinEdit;
    HeightEdit: TSpinEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    ExtensionsButton: TButton;
    PackedFieldsEdit: TSpinEdit;
    Label5: TLabel;
    InterlacedBox: TCheckBox;
    Image: TImage;
    procedure TabSetChange(Sender: TObject; NewTab: Integer;
      var AllowChange: Boolean);
    procedure OKBtnClick(Sender: TObject);
    procedure CancelBtnClick(Sender: TObject);
    procedure InterlacedBoxClick(Sender: TObject);
    procedure ExtensionsButtonClick(Sender: TObject);
  private
    { Private declarations }
    FSubImages: TList;
    FCurrentSubImage: TGifSubImage;
  public
    { Public declarations }
    constructor Create(SubImages: TList);
    procedure ShowSubImage(SubImage: TGifSubImage);
  end; { TSubImageDialog }

var
  SubImageDialog: TSubImageDialog;

implementation

{$R *.DFM}

constructor TSubImageDialog.Create(SubImages: TList);
var
  TabNo: Integer;
begin { TSubImageDialog.Create }
  inherited Create(nil);
  for TabNo := 2 to SubImages.Count
  do TabSet.Tabs.Add('Subimage ' + IntToStr(TabNo));
  FSubImages := SubImages;
  ShowSubImage(SubImages[0]);
end;  { TSubImageDialog.Create }

procedure TSubImageDialog.ShowSubImage(SubImage: TGifSubImage);
begin { TSubImageDialog.ShowSubImage }
  FCurrentSubImage := SubImage;
  with SubImage
  do begin
    LeftEdit.Value := ImageDescriptor.ImageLeftPos;
    TopEdit.Value := ImageDescriptor.ImageTopPos;
    WidthEdit.Value := ImageDescriptor.ImageWidth;
    HeightEdit.Value := ImageDescriptor.ImageHeight;
    PackedFieldsEdit.Value := ImageDescriptor.PackedFields;
    HasLocalColormapBox.Checked := HasLocalColormap;
    InterlacedBox.Checked := Interlaced;
    BitsPerPixelEdit.Value := BitsPerPixel;
    if HasLocalColormap
    then NoColorsEdit.Value := LocalColormap.Count;
    if Extensions.Count = 1
    then ExtensionsButton.Caption := IntToStr(Extensions.Count) + ' Extension'
    else ExtensionsButton.Caption := IntToStr(Extensions.Count) + ' Extensions';
    Image.Picture.Bitmap := SubImage.AsBitmap;
  end;
end;  { TSubImageDialog.ShowSubImage }

procedure TSubImageDialog.InterlacedBoxClick(Sender: TObject);
begin { TSubImageDialog.InterlacedBoxClick }
  FCurrentSubImage.Interlaced := InterlacedBox.Checked;
  FCurrentSubImage.EncodeStatusByte;
  PackedFieldsEdit.Value := FCurrentSubImage.ImageDescriptor.PackedFields;
end;  { TSubImageDialog.InterlacedBoxClick }

procedure TSubImageDialog.TabSetChange(Sender: TObject; NewTab: Integer;
  var AllowChange: Boolean);
begin
  ShowSubImage(FSubImages[NewTab]);
end;  { TSubImageDialog.TabSetChange }

procedure TSubImageDialog.OKBtnClick(Sender: TObject);
begin
  Close;
end;  { TSubImageDialog.OKBtnClick }

procedure TSubImageDialog.CancelBtnClick(Sender: TObject);
begin
  Close;
end;  { TSubImageDialog.CancelBtnClick }

procedure TSubImageDialog.ExtensionsButtonClick(Sender: TObject);
var ExtNo: Integer;
    Extension: GifDecl.TExtension;
    Caption: String;
begin { TSubImageDialog.ExtensionsButtonClick }
  for ExtNo := 1 to FCurrentSubImage.Extensions.Count
  do begin
    Caption := 'Ext ' + IntToStr(ExtNo);
    Extension := FCurrentSubImage.Extensions[ExtNo-1];
    ShowExtension(Caption, Extension);
  end
end;  { TSubImageDialog.ExtensionsButtonClick }

end.
