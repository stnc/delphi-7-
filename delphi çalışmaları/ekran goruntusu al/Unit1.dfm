object Form1: TForm1
  Left = 260
  Top = 175
  Width = 804
  Height = 586
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
    Left = 48
    Top = 112
    Width = 705
    Height = 401
    Stretch = True
  end
  object Edit1: TEdit
    Left = 80
    Top = 24
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Edit1'
  end
  object Button1: TButton
    Left = 96
    Top = 56
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 1
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 528
    Top = 32
    Width = 75
    Height = 25
    Caption = 'Button2'
    TabOrder = 2
    OnClick = Button2Click
  end
  object SavePictureDialog1: TSavePictureDialog
    DefaultExt = '.bmp'
    Left = 368
    Top = 40
  end
end
