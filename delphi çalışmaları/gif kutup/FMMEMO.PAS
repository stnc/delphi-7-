unit fmMemo;
{
Exports OutForm and MemoForm and their type: TMemoForm

C.A. van Beest, R.P. Sterkenburg, TNO-PML, Rijswijk, The Netherlands

12 Mar 97: - Added method ClrLine
27 Mar 97: - Corrected method ClrLine
}

interface

uses
  SysUtils, WinTypes, WinProcs, Messages, Classes, Graphics, Controls,
  Forms, Dialogs, StdCtrls;

type
  TMemoForm = class(TForm)
    Memo: TMemo;
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
    NewLine: Boolean;
  public
    { Public declarations }
    procedure AddLine(Line: String);
    procedure Clear;
    procedure ClrLine;
    procedure Write(Line: String);
    procedure Writeln(Line: String);
  end; { TMemoForm }

var
  OutForm, MemoForm: TMemoForm;

implementation

{$R *.DFM}

uses
  MoreUtil;        { Imports FreeObject }

procedure TMemoForm.FormCreate(Sender: TObject);
begin
  NewLine := True;
end;  { TMemoForm.FormCreate }

procedure TMemoForm.AddLine(Line: String);
{ Adds a line to the content of the memo }
begin
  Memo.Lines.Add(Line);
end;  { TMemoForm.AddLine }

procedure TMemoForm.Clear;
begin
  Memo.Lines.Clear;
end;  { TMemoForm.Clear }

procedure TMemoForm.ClrLine;
{ Clears the line in the memo where the (imaginative) pointer is }
begin
  if not NewLine
  then Memo.Lines[Memo.Lines.Count - 1] := '';
end;  { TMemoForm.ClrLine }

procedure TMemoForm.Write(Line: String);
{ See also Writeln }
begin { TMemoForm.Write }
  Writeln(Line);
  NewLine := False;
end;  { TMemoForm.Write }

procedure TMemoForm.Writeln(Line: String);
{ Same as AddLine. This function makes transition from BP to Delphi
easier: replace Writeln by MemoForm.Writeln }
var OldLine: String;
begin { TMemoForm.Writeln }
  if NewLine
  then AddLine(Line)
  else begin
    OldLine := Memo.Lines[Memo.Lines.Count-1];
    OldLine := OldLine + Line;
    Memo.Lines[Memo.Lines.Count-1] := OldLine;
  end;
  NewLine := True;
end;  { TMemoForm.Writeln }

end.
