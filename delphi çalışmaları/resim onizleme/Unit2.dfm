object Form2: TForm2
  Left = 425
  Top = 138
  BorderIcons = [biMinimize]
  BorderStyle = bsSingle
  Caption = 'Resim Aranacak Klas'#246'r'#252' Se'#231'iniz'
  ClientHeight = 391
  ClientWidth = 217
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  Scaled = False
  PixelsPerInch = 96
  TextHeight = 13
  object ShellTreeView1: TShellTreeView
    Left = 0
    Top = 0
    Width = 217
    Height = 353
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
    Left = 24
    Top = 360
    Width = 75
    Height = 25
    Caption = 'Tamam'
    TabOrder = 1
    OnClick = tamamClick
  end
  object iptal: TBitBtn
    Left = 120
    Top = 360
    Width = 75
    Height = 25
    Caption = #304'ptal'
    TabOrder = 2
    OnClick = iptalClick
  end
  object Button1: TButton
    Left = 48
    Top = 368
    Width = 75
    Height = 25
    Caption = 'Button1'
    TabOrder = 3
  end
end
