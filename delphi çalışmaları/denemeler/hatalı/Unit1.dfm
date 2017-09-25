object Form1: TForm1
  Left = 192
  Top = 114
  Width = 783
  Height = 540
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
  object Label1: TLabel
    Left = 208
    Top = 64
    Width = 32
    Height = 13
    Caption = 'Label1'
  end
  object Button1: TButton
    Left = 424
    Top = 64
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 0
    OnClick = Button1Click
  end
  object ListBox1: TListBox
    Left = 336
    Top = 160
    Width = 193
    Height = 225
    ItemHeight = 13
    Items.Strings = (
      'ewr'
      'ewrwe'
      'wer'
      'werwe'
      'ewrer')
    TabOrder = 1
  end
  object CheckBox1: TCheckBox
    Left = 568
    Top = 96
    Width = 97
    Height = 17
    Caption = 'CheckBox1'
    TabOrder = 2
  end
  object Button2: TButton
    Left = 328
    Top = 24
    Width = 75
    Height = 25
    Caption = 'Button2'
    TabOrder = 3
    OnClick = Button2Click
  end
  object Edit1: TEdit
    Left = 120
    Top = 208
    Width = 121
    Height = 21
    TabOrder = 4
    Text = 'Edit1'
  end
  object Button3: TButton
    Left = 160
    Top = 320
    Width = 75
    Height = 25
    Caption = 'Button3'
    TabOrder = 5
    OnClick = Button3Click
  end
end
