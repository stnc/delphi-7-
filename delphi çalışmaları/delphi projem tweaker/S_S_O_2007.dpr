program S_S_O_2007;

uses
  Forms,
  baslatUnit in 'baslatUnit.pas' {baslat_form},
  guvenlikUnit in 'guvenlikUnit.pas' {guvenlik},
  guvenlik2 in 'guvenlik2.pas' {guvenlik_2},
  internet_explorer_unit in 'internet_explorer_unit.pas' {int_exp},
  internet_unit in 'internet_unit.pas' {internet_bil},
  sistem_bil_unit in 'sistem_bil_unit.pas' {sistem_bil},
  tweak_ui_unit in 'tweak_ui_unit.pas' {tweak_ui},
  ag_unit in 'ag_unit.pas' {Ag_net},
  bil_soft_unit in 'bil_soft_unit.pas' {bil_soft},
  donanim_unit in 'donanim_unit.pas' {donanim},
  gorunum_unit in 'gorunum_unit.pas' {gorunum},
  ayarlar_unit in 'ayarlar_unit.pas' {ayarlar},
  sistem_dos in 'sistem_dos.pas' {sistem_dosy},
  taskman_unit in 'taskman_unit.pas' {taskman_form},
  araclar in 'araclar.pas' {araclar_form},
  hakkinda in 'hakkinda.pas' {hakkinda_form},
  anamenu in 'anamenu.pas' {ana_mnu};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'Stnc Sistem Organizator';
  Application.CreateForm(Tana_mnu, ana_mnu);
  Application.CreateForm(Ttaskman_form, taskman_form);
  Application.CreateForm(Tbil_soft, bil_soft);
  Application.CreateForm(Tsistem_bil, sistem_bil);
  Application.CreateForm(Taraclar_form, araclar_form);
  Application.CreateForm(Tbaslat_form, baslat_form);
  Application.CreateForm(Tguvenlik, guvenlik);
  Application.CreateForm(Tguvenlik_2, guvenlik_2);
  Application.CreateForm(Tint_exp, int_exp);
  Application.CreateForm(Tinternet_bil, internet_bil);
  Application.CreateForm(Ttweak_ui, tweak_ui);
  Application.CreateForm(TAg_net, Ag_net);
  Application.CreateForm(Tdonanim, donanim);
  Application.CreateForm(Tgorunum, gorunum);
 Application.CreateForm(Tayarlar, ayarlar);
 Application.CreateForm(Tsistem_dosy, sistem_dosy);
  Application.CreateForm(Thakkinda_form, hakkinda_form);
  Application.Run;
end.
