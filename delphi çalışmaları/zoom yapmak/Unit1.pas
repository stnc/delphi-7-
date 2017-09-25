unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls, jpeg;

type
  TForm1 = class(TForm)
    Image1: TImage;
    Button1: TButton;
    Timer1: TTimer;
    Panel1: TPanel;
    procedure Button1Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
//    procedure SetCanvasZoomFactor(Canvas: TCanvas; AZoomFactor: Integer);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure SetCanvasZoomFactor(Canvas: TCanvas; AZoomFactor: Integer);
var
  i: Integer;
begin
  if AZoomFactor = 100 then
    SetMapMode(Canvas.Handle, MM_TEXT)
  else begin
    SetMapMode(Canvas.Handle, MM_ISOTROPIC);
    SetWindowExtEx(Canvas.Handle, AZoomFactor, AZoomFactor, nil);
    SetViewportExtEx(Canvas.Handle, 100, 100, nil);
  end;
end;

procedure TForm1.Button1Click(Sender: TObject);
var
  bitmap: TBitmap;
begin
  bitmap := TBitmap.Create;
  try
    bitmap.Assign(Form1.image1.Picture.Bitmap);
    SetCanvasZoomFactor(bitmap.Canvas, 70);
    Canvas.Draw(30, 30, bitmap);
  finally
    bitmap.Free
  end;
     end;

procedure TForm1.Timer1Timer(Sender: TObject);
var
  Srect,Drect,PosForme:TRect;
  iWidth,iHeight,DmX,DmY:Integer;
  iTmpX,iTmpY:Real;
  C:TCanvas;
  Kursor:TPoint;
  ZoomFactor: Integer;
begin
   GetCursorPos(Kursor);
   PosForme:=Rect(Form1.Left,Form1.Top,Form1.Left+Form1.Width,Form1.Top+Form1.Height);
   If not PtInRect(PosForme,Kursor) then
   begin
     If Panel1.Visible=True then Panel1.Visible:=False;
     If Image1.Visible=False then Image1.Visible:=True;
     iWidth:=Image1.Width;
     iHeight:=Image1.Height;
     Drect:=Rect(0,0,iWidth,iHeight);

     { 2x kadar büyütür. 4x icin 2, ...}
     ZoomFactor := 1;
     iTmpX:=iWidth / (ZoomFactor * 4);
     iTmpY:=iHeight / (ZoomFactor * 4);

     Srect:=Rect(Kursor.x,Kursor.y,Kursor.x,Kursor.y);
     InflateRect(Srect,Round(iTmpX),Round(iTmpY));
    // move Srect if outside visible area of the screen
     If Srect.Left<0 then OffsetRect(Srect,-Srect.Left,0);
     If Srect.Top<0 then OffsetRect(Srect,0,-Srect.Top);
     If Srect.Right>Screen.Width then OffsetRect(Srect,-(Srect.Right-Screen.Width),0);
     If Srect.Bottom>Screen.Height then OffsetRect(Srect,0,-(Srect.Bottom-Screen.Height));
     C:=TCanvas.Create;
     try
       C.Handle:=GetDC(GetDesktopWindow);
       Image1.Canvas.CopyRect(Drect,C,Srect);
     finally
       C.Free;
     end;
     Application.ProcessMessages;
  end // Cursor Form'un icinde degil
  else
  begin  // cursor Form'un icinde
    If Panel1.Visible=False then Panel1.Visible:=True;
    If Image1.Visible=True then Image1.Visible:=False;
  end;
end;
end.
