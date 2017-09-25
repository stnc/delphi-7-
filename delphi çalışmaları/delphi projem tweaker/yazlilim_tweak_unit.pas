unit yazlilim_tweak_unit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, Buttons;

type
  Tyazilim_tweak = class(TForm)
    Image1: TImage;
    Edit1: TEdit;
    Edit2: TEdit;
    organization_label: TEdit;
    Edit4: TEdit;
    ger_don_isi: TEdit;
    outlook: TEdit;
    media_pla: TEdit;
    out_spla: TCheckBox;
    msn: TCheckBox;
    bil_adi_label: TLabel;
    labell: TLabel;
    label_: TLabel;
    csdver: TLabel;
    labelllll: TLabel;
    outlok: TLabel;
    Label7: TLabel;
    kaydet_out: TBitBtn;
    kaydet_media: TBitBtn;
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  yazilim_tweak: Tyazilim_tweak;

implementation

{$R *.dfm}

procedure Tyazilim_tweak.FormCreate(Sender: TObject);
begin
image1.Picture.Bitmap.LoadFromResourceName(HInstance,'SKK_1_RES');
end;

end.
