object Form1: TForm1
  Left = 192
  Top = 107
  Width = 696
  Height = 480
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Button1: TButton
    Left = 600
    Top = 32
    Width = 73
    Height = 33
    Caption = 'Button1'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 616
    Top = 88
    Width = 57
    Height = 33
    Caption = 'Button2'
    TabOrder = 1
    OnClick = Button2Click
  end
  object memo1: TMemo
    Left = 56
    Top = 16
    Width = 353
    Height = 377
    Lines.Strings = (
      'memo1')
    ReadOnly = True
    TabOrder = 2
  end
  object ListBox1: TListBox
    Left = 456
    Top = 152
    Width = 153
    Height = 209
    ItemHeight = 13
    TabOrder = 3
  end
end
