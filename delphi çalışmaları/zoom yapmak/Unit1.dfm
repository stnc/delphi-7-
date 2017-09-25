object Form1: TForm1
  Left = 285
  Top = 127
  Width = 955
  Height = 716
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Image1: TImage
    Left = 16
    Top = 8
    Width = 385
    Height = 313
    Stretch = True
  end
  object Button1: TButton
    Left = 696
    Top = 392
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Panel1: TPanel
    Left = 440
    Top = 176
    Width = 569
    Height = 465
    Caption = 'Panel1'
    TabOrder = 1
  end
  object Timer1: TTimer
    Interval = 25
    OnTimer = Timer1Timer
    Left = 552
    Top = 112
  end
end
