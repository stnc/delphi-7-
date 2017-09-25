object Form3: TForm3
  Left = 265
  Top = 143
  BorderIcons = [biMinimize, biMaximize]
  BorderStyle = bsSingle
  Caption = 'Ozelle'#351'tirilecek Klasoru Se'#231'iniz'
  ClientHeight = 368
  ClientWidth = 224
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object yol_klaor: TLabel
    Left = 0
    Top = 424
    Width = 3
    Height = 13
  end
  object ShellTreeView1: TShellTreeView
    Left = -8
    Top = 0
    Width = 233
    Height = 305
    ObjectTypes = [otFolders]
    Root = 'rfDesktop'
    UseShellImages = True
    AutoRefresh = False
    Indent = 19
    ParentColor = False
    RightClickSelect = True
    ShowRoot = False
    TabOrder = 0
  end
  object tamam: TBitBtn
    Left = 16
    Top = 328
    Width = 75
    Height = 25
    Caption = 'Tamam'
    TabOrder = 1
    OnClick = tamamClick
  end
  object iptal: TBitBtn
    Left = 112
    Top = 328
    Width = 75
    Height = 25
    Caption = #304'ptal'
    TabOrder = 2
    OnClick = iptalClick
  end
end
