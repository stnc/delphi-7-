object Form1: TForm1
  Left = 384
  Top = 155
  BorderStyle = bsDialog
  Caption = 'SELMAN TUN'#199' YAZILIM Basit Hesap MAkinesi'
  ClientHeight = 307
  ClientWidth = 320
  Color = clSilver
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clHotLight
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Edit1: TEdit
    Left = 16
    Top = 16
    Width = 289
    Height = 21
    TabOrder = 0
  end
  object Button_4: TButton
    Left = 128
    Top = 192
    Width = 75
    Height = 25
    Caption = '4'
    TabOrder = 1
    OnClick = Button_4Click
  end
  object Button_3: TButton
    Left = 32
    Top = 232
    Width = 75
    Height = 25
    Caption = '3'
    TabOrder = 2
    OnClick = Button_3Click
  end
  object Button_6: TButton
    Left = 128
    Top = 152
    Width = 75
    Height = 25
    Caption = '6'
    TabOrder = 3
    OnClick = Button_6Click
  end
  object Button_8: TButton
    Left = 32
    Top = 112
    Width = 75
    Height = 25
    Caption = '8'
    TabOrder = 4
    OnClick = Button_8Click
  end
  object Button_2: TButton
    Left = 128
    Top = 232
    Width = 75
    Height = 25
    Caption = '2'
    TabOrder = 5
    OnClick = Button_2Click
  end
  object Button_5: TButton
    Left = 32
    Top = 192
    Width = 75
    Height = 25
    Caption = '5'
    TabOrder = 6
    OnClick = Button_5Click
  end
  object Button_7: TButton
    Left = 32
    Top = 152
    Width = 75
    Height = 25
    Caption = '7'
    TabOrder = 7
    OnClick = Button_7Click
  end
  object Button_9: TButton
    Left = 128
    Top = 112
    Width = 75
    Height = 25
    Caption = '9'
    TabOrder = 8
    OnClick = Button_9Click
  end
  object kapali: TButton
    Left = 216
    Top = 64
    Width = 75
    Height = 25
    Caption = #199#305'k'#305#351
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 9
    OnClick = kapaliClick
  end
  object temizle: TButton
    Left = 128
    Top = 64
    Width = 75
    Height = 25
    Caption = 'c'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 10
    OnClick = temizleClick
  end
  object eksi: TButton
    Left = 216
    Top = 112
    Width = 75
    Height = 25
    Caption = '-'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 11
    OnClick = eksiClick
  end
  object arti: TButton
    Left = 216
    Top = 152
    Width = 75
    Height = 25
    Caption = '+'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clHotLight
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 12
    OnClick = artiClick
  end
  object carp: TButton
    Left = 216
    Top = 192
    Width = 75
    Height = 25
    Caption = '*'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 13
    OnClick = carpClick
  end
  object esittir: TButton
    Left = 216
    Top = 272
    Width = 75
    Height = 25
    Caption = '='
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 14
    OnClick = esittirClick
  end
  object Button_0: TButton
    Left = 128
    Top = 272
    Width = 75
    Height = 25
    Caption = '0'
    TabOrder = 15
    OnClick = Button_0Click
  end
  object Button_1: TButton
    Left = 32
    Top = 272
    Width = 75
    Height = 25
    Caption = '1'
    TabOrder = 16
    OnClick = Button_1Click
  end
  object bolum: TButton
    Left = 216
    Top = 232
    Width = 75
    Height = 25
    Caption = '/'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clRed
    Font.Height = -24
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 17
    OnClick = bolumClick
  end
  object Button2: TButton
    Left = 24
    Top = 328
    Width = 75
    Height = 25
    Caption = 'hex E '#199'evir'
    TabOrder = 18
  end
  object XPManifest1: TXPManifest
    Left = 304
    Top = 288
  end
end
