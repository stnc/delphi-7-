unit FmGCE;

interface

uses WinProcs, WinTypes, SysUtils, Classes, Graphics, Forms, Controls, StdCtrls,
  Buttons, ExtCtrls, Spin,
  GifDecl;

type
  TGCEDialog = class(TForm)
    OKBtn: TButton;
    CancelBtn: TButton;
    Bevel1: TBevel;
    PackedFieldsEdit: TSpinEdit;
    DelaytimeEdit: TSpinEdit;
    TransparentColorIndexEdit: TSpinEdit;
    TerminatorEdit: TSpinEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
  private
    { Private declarations }
  public
    { Public declarations }
    constructor Create(GCE: TGraphicControlExtension);
    function GetGCE: TGraphicControlExtension;
  end; { TGCEDialog }

var
  GCEDialog: TGCEDialog;

implementation

{$R *.DFM}

constructor TGCEDialog.Create(GCE: TGraphicControlExtension);
begin { TGCEDialog.Create }
  inherited Create(nil);
  with GCE
  do begin
    PackedFieldsEdit.Value := PackedFields;
    DelayTimeEdit.Value := DelayTime;
    TransparentColorIndexEdit.Value := TransparentColorIndex;
    TerminatorEdit.Value := Terminator;
  end;
end;  { TGCEDialog.Create }

function TGCEDialog.GetGCE: TGraphicControlExtension;
begin { TGCEDialog.GetGCE }
  with Result
  do begin
    PackedFields := PackedFieldsEdit.Value;
    DelayTime := DelayTimeEdit.Value;
    TransparentColorIndex := TransparentColorIndexEdit.Value;
    Terminator := TerminatorEdit.Value;
  end;
end;  { TGCEDialog.GetGCE }

end.  { unit FmGCE }
