object Form1: TForm1
  Left = 0
  Top = 0
  Width = 651
  Height = 533
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Button1: TButton
    Left = 520
    Top = 456
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Panel1: TPanel
    Left = 32
    Top = 16
    Width = 433
    Height = 361
    Caption = 'Panel1'
    TabOrder = 1
  end
  object MediaPlayer1: TMediaPlayer
    Left = 40
    Top = 456
    Width = 253
    Height = 30
    TabOrder = 2
  end
  object s: TProgressBar
    Left = 40
    Top = 424
    Width = 150
    Height = 17
    TabOrder = 3
  end
  object ScrollBar1: TScrollBar
    Left = 40
    Top = 384
    Width = 417
    Height = 17
    PageSize = 0
    TabOrder = 4
    OnChange = ScrollBar1Change
  end
  object XPManifest1: TXPManifest
    Left = 560
    Top = 328
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 560
    Top = 360
  end
  object dialog: TOpenDialog
    Left = 560
    Top = 392
  end
end
