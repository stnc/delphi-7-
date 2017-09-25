unit FMAPPE;

interface

uses {Windows,} SysUtils, Classes, Graphics, Forms, Controls, StdCtrls, 
  Buttons, ExtCtrls,
  GifDecl;

type
  TAPPEDialog = class(TForm)
    OKBtn: TButton;
    CancelBtn: TButton;
    Bevel1: TBevel;
    Label1: TLabel;
    AppIdentifierMemo: TMemo;
    Label2: TLabel;
    AppAuthenticationCodeMemo: TMemo;
    AppDataMemo: TMemo;
    Label3: TLabel;
  private
    { Private declarations }
  public
    { Public declarations }
    constructor Create(APPE: TApplicationExtension);
    function GetAPPE: TApplicationExtension;
  end;

var
  APPEDialog: TAPPEDialog;

implementation

{$R *.DFM}

constructor TAPPEDialog.Create(APPE: TApplicationExtension);
var i: Integer;
    IDLine: String;
begin { TAPPEDialog.Create }
  inherited Create(nil);
  with APPE
  do begin
    for i := 1 to 8
    do begin
      IDLine := '$'+IntToHex(APPE.ApplicationIdentifier[i], 2) + ' ' +
                         Chr(APPE.ApplicationIdentifier[i]);
      AppIdentifierMemo.Lines.Add(IDLine);
    end;
    for i := 1 to 3
    do begin
      IDLine := '$'+IntToHex(APPE.AppAuthenticationCode[i], 2) + ' ' +
                         Chr(APPE.AppAuthenticationCode[i]);
      AppAuthenticationCodeMemo.Lines.Add(IDLine);
    end;
    AppDataMemo.Lines := APPE.AppData;
  end;
end;  { TAPPEDialog.Create }

function TAPPEDialog.GetAPPE: TApplicationExtension;
var i, Value: Byte;
begin { TAPPEDialog.GetAPPE }
  with Result
  do begin
    for i := 1 to 8
    do begin
      Value := StrToInt(Copy(AppIdentifierMemo.Lines[i-1], 1, 3));
      Result.ApplicationIdentifier[i] := Value;
    end;
    for i := 1 to 3
    do begin
      Value := StrToInt(Copy(AppAuthenticationCodeMemo.Lines[i-1], 1, 3));
      Result.AppAuthenticationCode[i] := Value;
    end;
    Result.AppData := TStringList.Create;
    Result.AppData.Assign(AppDataMemo.Lines);
  end;
end;  { TAPPEDialog.GetAPPE }

end.
