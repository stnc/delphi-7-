<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guvenlik_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guvenlik_form))
        Me.bil_kapat_sim = New System.Windows.Forms.CheckBox
        Me.ag_baglantilarim = New System.Windows.Forms.CheckBox
        Me.denetim_masa = New System.Windows.Forms.CheckBox
        Me.prg_ekle_kaldir_olmasin = New System.Windows.Forms.CheckBox
        Me.regedit_yasak = New System.Windows.Forms.CheckBox
        Me.reg_dos_dis_verme = New System.Windows.Forms.CheckBox
        Me.ms_dos_arabirim = New System.Windows.Forms.CheckBox
        Me.gorev_yonetici = New System.Windows.Forms.CheckBox
        Me.aktif_desktop = New System.Windows.Forms.CheckBox
        Me.usb_sur_gizle = New System.Windows.Forms.CheckBox
        Me.geri_don_kutu = New System.Windows.Forms.CheckBox
        Me.proxy_CheckBox = New System.Windows.Forms.CheckBox
        Me.ie_ana_sayfa = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ýmageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Cikis = New System.Windows.Forms.Button
        Me.Kaydet = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bil_kapat_sim
        '
        Me.bil_kapat_sim.AutoSize = True
        Me.bil_kapat_sim.BackColor = System.Drawing.Color.Transparent
        Me.bil_kapat_sim.ForeColor = System.Drawing.Color.Black
        Me.bil_kapat_sim.Location = New System.Drawing.Point(310, 63)
        Me.bil_kapat_sim.Name = "bil_kapat_sim"
        Me.bil_kapat_sim.Size = New System.Drawing.Size(176, 17)
        Me.bil_kapat_sim.TabIndex = 0
        Me.bil_kapat_sim.Text = "Bilgisayarý Kapat Simgesini Gizle"
        Me.bil_kapat_sim.UseVisualStyleBackColor = False
        '
        'ag_baglantilarim
        '
        Me.ag_baglantilarim.AutoSize = True
        Me.ag_baglantilarim.BackColor = System.Drawing.Color.Transparent
        Me.ag_baglantilarim.ForeColor = System.Drawing.Color.Black
        Me.ag_baglantilarim.Location = New System.Drawing.Point(309, 148)
        Me.ag_baglantilarim.Name = "ag_baglantilarim"
        Me.ag_baglantilarim.Size = New System.Drawing.Size(169, 17)
        Me.ag_baglantilarim.TabIndex = 1
        Me.ag_baglantilarim.Text = "Að Baðlantýlarým Ýconunu Gizle"
        Me.ag_baglantilarim.UseVisualStyleBackColor = False
        '
        'denetim_masa
        '
        Me.denetim_masa.AutoSize = True
        Me.denetim_masa.BackColor = System.Drawing.Color.Transparent
        Me.denetim_masa.ForeColor = System.Drawing.Color.Black
        Me.denetim_masa.Location = New System.Drawing.Point(40, 52)
        Me.denetim_masa.Name = "denetim_masa"
        Me.denetim_masa.Size = New System.Drawing.Size(186, 17)
        Me.denetim_masa.TabIndex = 3
        Me.denetim_masa.Text = "Denetim Masasýna Eriþimi Yasakla"
        Me.denetim_masa.UseVisualStyleBackColor = False
        '
        'prg_ekle_kaldir_olmasin
        '
        Me.prg_ekle_kaldir_olmasin.AutoSize = True
        Me.prg_ekle_kaldir_olmasin.BackColor = System.Drawing.Color.Transparent
        Me.prg_ekle_kaldir_olmasin.ForeColor = System.Drawing.Color.Black
        Me.prg_ekle_kaldir_olmasin.Location = New System.Drawing.Point(309, 182)
        Me.prg_ekle_kaldir_olmasin.Name = "prg_ekle_kaldir_olmasin"
        Me.prg_ekle_kaldir_olmasin.Size = New System.Drawing.Size(158, 17)
        Me.prg_ekle_kaldir_olmasin.TabIndex = 4
        Me.prg_ekle_kaldir_olmasin.Text = "Program Ekle Kaldýr Olmasýn"
        Me.prg_ekle_kaldir_olmasin.UseVisualStyleBackColor = False
        '
        'regedit_yasak
        '
        Me.regedit_yasak.AutoSize = True
        Me.regedit_yasak.BackColor = System.Drawing.Color.Transparent
        Me.regedit_yasak.ForeColor = System.Drawing.Color.Black
        Me.regedit_yasak.Location = New System.Drawing.Point(40, 302)
        Me.regedit_yasak.Name = "regedit_yasak"
        Me.regedit_yasak.Size = New System.Drawing.Size(311, 17)
        Me.regedit_yasak.TabIndex = 5
        Me.regedit_yasak.Text = "Registy Araçlarýnýn Registy Ulaþmasýný Engelle (Regedit.exe) "
        Me.regedit_yasak.UseVisualStyleBackColor = False
        '
        'reg_dos_dis_verme
        '
        Me.reg_dos_dis_verme.AutoSize = True
        Me.reg_dos_dis_verme.BackColor = System.Drawing.Color.Transparent
        Me.reg_dos_dis_verme.ForeColor = System.Drawing.Color.Black
        Me.reg_dos_dis_verme.Location = New System.Drawing.Point(40, 338)
        Me.reg_dos_dis_verme.Name = "reg_dos_dis_verme"
        Me.reg_dos_dis_verme.Size = New System.Drawing.Size(237, 17)
        Me.reg_dos_dis_verme.TabIndex = 6
        Me.reg_dos_dis_verme.Text = "Registry Dosyalarýný Dýþarý Verilmesini Engelle"
        Me.reg_dos_dis_verme.UseVisualStyleBackColor = False
        '
        'ms_dos_arabirim
        '
        Me.ms_dos_arabirim.AutoSize = True
        Me.ms_dos_arabirim.BackColor = System.Drawing.Color.Transparent
        Me.ms_dos_arabirim.ForeColor = System.Drawing.Color.Black
        Me.ms_dos_arabirim.Location = New System.Drawing.Point(40, 268)
        Me.ms_dos_arabirim.Name = "ms_dos_arabirim"
        Me.ms_dos_arabirim.Size = New System.Drawing.Size(240, 17)
        Me.ms_dos_arabirim.TabIndex = 8
        Me.ms_dos_arabirim.Text = "Ms-Dos Command Arabirimine Ulaþýmý Engelle"
        Me.ms_dos_arabirim.UseVisualStyleBackColor = False
        '
        'gorev_yonetici
        '
        Me.gorev_yonetici.AutoSize = True
        Me.gorev_yonetici.BackColor = System.Drawing.Color.Transparent
        Me.gorev_yonetici.ForeColor = System.Drawing.Color.Black
        Me.gorev_yonetici.Location = New System.Drawing.Point(40, 193)
        Me.gorev_yonetici.Name = "gorev_yonetici"
        Me.gorev_yonetici.Size = New System.Drawing.Size(216, 17)
        Me.gorev_yonetici.TabIndex = 9
        Me.gorev_yonetici.Text = "Görev Yöneticisini Kullanýlmaz Hale Getir"
        Me.gorev_yonetici.UseVisualStyleBackColor = False
        '
        'aktif_desktop
        '
        Me.aktif_desktop.AutoSize = True
        Me.aktif_desktop.BackColor = System.Drawing.Color.Transparent
        Me.aktif_desktop.ForeColor = System.Drawing.Color.Black
        Me.aktif_desktop.Location = New System.Drawing.Point(40, 158)
        Me.aktif_desktop.Name = "aktif_desktop"
        Me.aktif_desktop.Size = New System.Drawing.Size(158, 17)
        Me.aktif_desktop.TabIndex = 10
        Me.aktif_desktop.Text = "Klasör Seçeneklerini Ýptal Et"
        Me.aktif_desktop.UseVisualStyleBackColor = False
        '
        'usb_sur_gizle
        '
        Me.usb_sur_gizle.AutoSize = True
        Me.usb_sur_gizle.BackColor = System.Drawing.Color.Transparent
        Me.usb_sur_gizle.ForeColor = System.Drawing.Color.Black
        Me.usb_sur_gizle.Location = New System.Drawing.Point(309, 109)
        Me.usb_sur_gizle.Name = "usb_sur_gizle"
        Me.usb_sur_gizle.Size = New System.Drawing.Size(177, 17)
        Me.usb_sur_gizle.TabIndex = 11
        Me.usb_sur_gizle.Text = "Usb Sürücülerine Eriþimi Engelle"
        Me.usb_sur_gizle.UseVisualStyleBackColor = False
        '
        'geri_don_kutu
        '
        Me.geri_don_kutu.AutoSize = True
        Me.geri_don_kutu.BackColor = System.Drawing.Color.Transparent
        Me.geri_don_kutu.ForeColor = System.Drawing.Color.Black
        Me.geri_don_kutu.Location = New System.Drawing.Point(40, 228)
        Me.geri_don_kutu.Name = "geri_don_kutu"
        Me.geri_don_kutu.Size = New System.Drawing.Size(257, 17)
        Me.geri_don_kutu.TabIndex = 12
        Me.geri_don_kutu.Text = "Geri Dönüþüm Kutusunu Özelikler Simgesini Gizle"
        Me.geri_don_kutu.UseVisualStyleBackColor = False
        '
        'proxy_CheckBox
        '
        Me.proxy_CheckBox.AutoSize = True
        Me.proxy_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.proxy_CheckBox.ForeColor = System.Drawing.Color.Black
        Me.proxy_CheckBox.Location = New System.Drawing.Point(40, 121)
        Me.proxy_CheckBox.Name = "proxy_CheckBox"
        Me.proxy_CheckBox.Size = New System.Drawing.Size(200, 17)
        Me.proxy_CheckBox.TabIndex = 29
        Me.proxy_CheckBox.Text = "Proxy Ayarlarýnýn Deðiþmesini Engelle"
        Me.proxy_CheckBox.UseVisualStyleBackColor = False
        '
        'ie_ana_sayfa
        '
        Me.ie_ana_sayfa.AutoSize = True
        Me.ie_ana_sayfa.BackColor = System.Drawing.Color.Transparent
        Me.ie_ana_sayfa.ForeColor = System.Drawing.Color.Black
        Me.ie_ana_sayfa.Location = New System.Drawing.Point(40, 85)
        Me.ie_ana_sayfa.Name = "ie_ana_sayfa"
        Me.ie_ana_sayfa.Size = New System.Drawing.Size(197, 17)
        Me.ie_ana_sayfa.TabIndex = 28
        Me.ie_ana_sayfa.Text = "ÝE Ana Sayfasýnýn Deðiþimini Engelle"
        Me.ie_ana_sayfa.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.güvenlik__1_
        Me.PictureBox1.Location = New System.Drawing.Point(373, 280)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'ýmageList1
        '
        Me.ýmageList1.ImageStream = CType(resources.GetObject("ýmageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ýmageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ýmageList1.Images.SetKeyName(0, "158.ico")
        Me.ýmageList1.Images.SetKeyName(1, "159.ico")
        Me.ýmageList1.Images.SetKeyName(2, "160.ico")
        Me.ýmageList1.Images.SetKeyName(3, "161.ico")
        Me.ýmageList1.Images.SetKeyName(4, "162.ico")
        Me.ýmageList1.Images.SetKeyName(5, "163.ico")
        Me.ýmageList1.Images.SetKeyName(6, "164.ico")
        Me.ýmageList1.Images.SetKeyName(7, "165.ico")
        Me.ýmageList1.Images.SetKeyName(8, "166.ico")
        Me.ýmageList1.Images.SetKeyName(9, "167.ico")
        Me.ýmageList1.Images.SetKeyName(10, "168.ico")
        Me.ýmageList1.Images.SetKeyName(11, "169.ico")
        Me.ýmageList1.Images.SetKeyName(12, "170.ico")
        Me.ýmageList1.Images.SetKeyName(13, "171.ico")
        Me.ýmageList1.Images.SetKeyName(14, "172.ico")
        Me.ýmageList1.Images.SetKeyName(15, "174.ico")
        Me.ýmageList1.Images.SetKeyName(16, "175.ico")
        Me.ýmageList1.Images.SetKeyName(17, "176.ico")
        Me.ýmageList1.Images.SetKeyName(18, "177.ico")
        Me.ýmageList1.Images.SetKeyName(19, "178.ico")
        Me.ýmageList1.Images.SetKeyName(20, "179.ico")
        Me.ýmageList1.Images.SetKeyName(21, "180.ico")
        Me.ýmageList1.Images.SetKeyName(22, "181.ico")
        Me.ýmageList1.Images.SetKeyName(23, "182.ico")
        Me.ýmageList1.Images.SetKeyName(24, "183.ico")
        Me.ýmageList1.Images.SetKeyName(25, "184.ico")
        Me.ýmageList1.Images.SetKeyName(26, "185.ico")
        Me.ýmageList1.Images.SetKeyName(27, "186.ico")
        Me.ýmageList1.Images.SetKeyName(28, "187.ico")
        Me.ýmageList1.Images.SetKeyName(29, "188.ico")
        Me.ýmageList1.Images.SetKeyName(30, "190.ico")
        Me.ýmageList1.Images.SetKeyName(31, "191.ico")
        Me.ýmageList1.Images.SetKeyName(32, "192.ico")
        Me.ýmageList1.Images.SetKeyName(33, "193.ico")
        Me.ýmageList1.Images.SetKeyName(34, "194.ico")
        Me.ýmageList1.Images.SetKeyName(35, "195.ico")
        Me.ýmageList1.Images.SetKeyName(36, "196.ico")
        Me.ýmageList1.Images.SetKeyName(37, "197.ico")
        Me.ýmageList1.Images.SetKeyName(38, "199.ico")
        Me.ýmageList1.Images.SetKeyName(39, "200.ico")
        Me.ýmageList1.Images.SetKeyName(40, "201.ico")
        Me.ýmageList1.Images.SetKeyName(41, "202.ico")
        Me.ýmageList1.Images.SetKeyName(42, "204.ico")
        Me.ýmageList1.Images.SetKeyName(43, "205.ico")
        Me.ýmageList1.Images.SetKeyName(44, "206.ico")
        Me.ýmageList1.Images.SetKeyName(45, "207.ico")
        Me.ýmageList1.Images.SetKeyName(46, "208.ico")
        Me.ýmageList1.Images.SetKeyName(47, "209.ico")
        Me.ýmageList1.Images.SetKeyName(48, "210.ico")
        Me.ýmageList1.Images.SetKeyName(49, "211.ico")
        Me.ýmageList1.Images.SetKeyName(50, "212.ico")
        Me.ýmageList1.Images.SetKeyName(51, "213.ico")
        Me.ýmageList1.Images.SetKeyName(52, "214.ico")
        Me.ýmageList1.Images.SetKeyName(53, "215.ico")
        Me.ýmageList1.Images.SetKeyName(54, "216.ico")
        Me.ýmageList1.Images.SetKeyName(55, "217.ico")
        Me.ýmageList1.Images.SetKeyName(56, "218.ico")
        Me.ýmageList1.Images.SetKeyName(57, "219.ico")
        Me.ýmageList1.Images.SetKeyName(58, "220.ico")
        Me.ýmageList1.Images.SetKeyName(59, "222.ico")
        Me.ýmageList1.Images.SetKeyName(60, "224.ico")
        Me.ýmageList1.Images.SetKeyName(61, "225.ico")
        Me.ýmageList1.Images.SetKeyName(62, "227.ico")
        Me.ýmageList1.Images.SetKeyName(63, "228.ico")
        Me.ýmageList1.Images.SetKeyName(64, "229.ico")
        Me.ýmageList1.Images.SetKeyName(65, "231.ico")
        Me.ýmageList1.Images.SetKeyName(66, "232.ico")
        Me.ýmageList1.Images.SetKeyName(67, "233.ico")
        Me.ýmageList1.Images.SetKeyName(68, "234.ico")
        Me.ýmageList1.Images.SetKeyName(69, "235.ico")
        Me.ýmageList1.Images.SetKeyName(70, "236.ico")
        Me.ýmageList1.Images.SetKeyName(71, "237.ico")
        Me.ýmageList1.Images.SetKeyName(72, "238.ico")
        Me.ýmageList1.Images.SetKeyName(73, "239.ico")
        Me.ýmageList1.Images.SetKeyName(74, "240.ico")
        Me.ýmageList1.Images.SetKeyName(75, "241.ico")
        Me.ýmageList1.Images.SetKeyName(76, "243.ico")
        Me.ýmageList1.Images.SetKeyName(77, "244.ico")
        Me.ýmageList1.Images.SetKeyName(78, "245.ico")
        Me.ýmageList1.Images.SetKeyName(79, "246.ico")
        Me.ýmageList1.Images.SetKeyName(80, "247.ico")
        Me.ýmageList1.Images.SetKeyName(81, "248.ico")
        Me.ýmageList1.Images.SetKeyName(82, "249.ico")
        Me.ýmageList1.Images.SetKeyName(83, "250.ico")
        Me.ýmageList1.Images.SetKeyName(84, "251.ico")
        Me.ýmageList1.Images.SetKeyName(85, "252.ico")
        Me.ýmageList1.Images.SetKeyName(86, "253.ico")
        Me.ýmageList1.Images.SetKeyName(87, "254.ico")
        Me.ýmageList1.Images.SetKeyName(88, "255.ico")
        Me.ýmageList1.Images.SetKeyName(89, "256.ico")
        Me.ýmageList1.Images.SetKeyName(90, "257.ico")
        Me.ýmageList1.Images.SetKeyName(91, "258.ico")
        Me.ýmageList1.Images.SetKeyName(92, "259.ico")
        Me.ýmageList1.Images.SetKeyName(93, "260.ico")
        Me.ýmageList1.Images.SetKeyName(94, "261.ico")
        Me.ýmageList1.Images.SetKeyName(95, "262.ico")
        Me.ýmageList1.Images.SetKeyName(96, "263.ico")
        Me.ýmageList1.Images.SetKeyName(97, "264.ico")
        Me.ýmageList1.Images.SetKeyName(98, "265.ico")
        Me.ýmageList1.Images.SetKeyName(99, "266.ico")
        Me.ýmageList1.Images.SetKeyName(100, "267.ico")
        Me.ýmageList1.Images.SetKeyName(101, "268.ico")
        Me.ýmageList1.Images.SetKeyName(102, "269.ico")
        Me.ýmageList1.Images.SetKeyName(103, "270.ico")
        Me.ýmageList1.Images.SetKeyName(104, "271.ico")
        Me.ýmageList1.Images.SetKeyName(105, "272.ico")
        Me.ýmageList1.Images.SetKeyName(106, "273.ico")
        Me.ýmageList1.Images.SetKeyName(107, "275.ico")
        Me.ýmageList1.Images.SetKeyName(108, "276.ico")
        Me.ýmageList1.Images.SetKeyName(109, "277.ico")
        Me.ýmageList1.Images.SetKeyName(110, "278.ico")
        Me.ýmageList1.Images.SetKeyName(111, "279.ico")
        Me.ýmageList1.Images.SetKeyName(112, "280.ico")
        Me.ýmageList1.Images.SetKeyName(113, "281.ico")
        Me.ýmageList1.Images.SetKeyName(114, "282.ico")
        Me.ýmageList1.Images.SetKeyName(115, "283.ico")
        Me.ýmageList1.Images.SetKeyName(116, "284.ico")
        Me.ýmageList1.Images.SetKeyName(117, "285.ico")
        Me.ýmageList1.Images.SetKeyName(118, "286.ico")
        Me.ýmageList1.Images.SetKeyName(119, "287.ico")
        Me.ýmageList1.Images.SetKeyName(120, "288.ico")
        Me.ýmageList1.Images.SetKeyName(121, "290.ico")
        Me.ýmageList1.Images.SetKeyName(122, "291.ico")
        Me.ýmageList1.Images.SetKeyName(123, "293.ico")
        Me.ýmageList1.Images.SetKeyName(124, "297.ico")
        Me.ýmageList1.Images.SetKeyName(125, "298.ico")
        Me.ýmageList1.Images.SetKeyName(126, "303.ico")
        Me.ýmageList1.Images.SetKeyName(127, "görev yöneticisi (1).ico")
        Me.ýmageList1.Images.SetKeyName(128, "görev yöneticisi (2).ico")
        Me.ýmageList1.Images.SetKeyName(129, "görev yöneticisi (3).ico")
        Me.ýmageList1.Images.SetKeyName(130, "görev yöneticisi (4).ico")
        Me.ýmageList1.Images.SetKeyName(131, "görev yöneticisi (5).ico")
        Me.ýmageList1.Images.SetKeyName(132, "görev yöneticisi (6).ico")
        Me.ýmageList1.Images.SetKeyName(133, "görev yöneticisi.ico")
        Me.ýmageList1.Images.SetKeyName(134, "güvenlik (1).ico")
        Me.ýmageList1.Images.SetKeyName(135, "güvenlik (2).ico")
        Me.ýmageList1.Images.SetKeyName(136, "güvenlik (3).ico")
        Me.ýmageList1.Images.SetKeyName(137, "güvenlik (4).ico")
        Me.ýmageList1.Images.SetKeyName(138, "güvenlik (5).ico")
        Me.ýmageList1.Images.SetKeyName(139, "modül.ico")
        Me.ýmageList1.Images.SetKeyName(140, "network (1).ico")
        Me.ýmageList1.Images.SetKeyName(141, "network (2).ico")
        Me.ýmageList1.Images.SetKeyName(142, "network (3).ico")
        Me.ýmageList1.Images.SetKeyName(143, "network (4).ico")
        Me.ýmageList1.Images.SetKeyName(144, "network (5).ico")
        Me.ýmageList1.Images.SetKeyName(145, "network (6).ico")
        Me.ýmageList1.Images.SetKeyName(146, "network (7).ico")
        Me.ýmageList1.Images.SetKeyName(147, "network (8).ico")
        Me.ýmageList1.Images.SetKeyName(148, "network (9).ico")
        Me.ýmageList1.Images.SetKeyName(149, "network (10).ico")
        Me.ýmageList1.Images.SetKeyName(150, "network.ico")
        Me.ýmageList1.Images.SetKeyName(151, "reg.ico")
        Me.ýmageList1.Images.SetKeyName(152, "sd (4).ico")
        Me.ýmageList1.Images.SetKeyName(153, "sd (5).ico")
        Me.ýmageList1.Images.SetKeyName(154, "sd (8).ico")
        Me.ýmageList1.Images.SetKeyName(155, "sd (9).ico")
        Me.ýmageList1.Images.SetKeyName(156, "sd (10).ico")
        Me.ýmageList1.Images.SetKeyName(157, "sd (11).ico")
        Me.ýmageList1.Images.SetKeyName(158, "sd (12).ico")
        Me.ýmageList1.Images.SetKeyName(159, "sd (13).ico")
        Me.ýmageList1.Images.SetKeyName(160, "sd (14).ico")
        Me.ýmageList1.Images.SetKeyName(161, "sd (15).ico")
        Me.ýmageList1.Images.SetKeyName(162, "sd (16).ico")
        Me.ýmageList1.Images.SetKeyName(163, "sd (17).ico")
        Me.ýmageList1.Images.SetKeyName(164, "sd (18).ico")
        Me.ýmageList1.Images.SetKeyName(165, "sd (19).ico")
        Me.ýmageList1.Images.SetKeyName(166, "sd (20).ico")
        Me.ýmageList1.Images.SetKeyName(167, "sd (21).bmp")
        Me.ýmageList1.Images.SetKeyName(168, "sd (22).bmp")
        Me.ýmageList1.Images.SetKeyName(169, "sd (23).ico")
        Me.ýmageList1.Images.SetKeyName(170, "sd (24).ico")
        Me.ýmageList1.Images.SetKeyName(171, "sd (25).ico")
        Me.ýmageList1.Images.SetKeyName(172, "sd (27).bmp")
        Me.ýmageList1.Images.SetKeyName(173, "sd (28).ico")
        Me.ýmageList1.Images.SetKeyName(174, "sd (32).ico")
        Me.ýmageList1.Images.SetKeyName(175, "sd (33).ico")
        Me.ýmageList1.Images.SetKeyName(176, "sd (34).ico")
        Me.ýmageList1.Images.SetKeyName(177, "sd (36).ico")
        Me.ýmageList1.Images.SetKeyName(178, "sd (37).ico")
        Me.ýmageList1.Images.SetKeyName(179, "sd (38).ico")
        Me.ýmageList1.Images.SetKeyName(180, "sd (39).ico")
        Me.ýmageList1.Images.SetKeyName(181, "sd (40).ico")
        Me.ýmageList1.Images.SetKeyName(182, "sd (41).ico")
        Me.ýmageList1.Images.SetKeyName(183, "sd (42).ico")
        Me.ýmageList1.Images.SetKeyName(184, "sd (43).ico")
        Me.ýmageList1.Images.SetKeyName(185, "sd (46).ico")
        Me.ýmageList1.Images.SetKeyName(186, "sd (47).ico")
        Me.ýmageList1.Images.SetKeyName(187, "sd (48).ico")
        Me.ýmageList1.Images.SetKeyName(188, "sd (49).ico")
        Me.ýmageList1.Images.SetKeyName(189, "sd (50).ico")
        Me.ýmageList1.Images.SetKeyName(190, "sd (51).ico")
        Me.ýmageList1.Images.SetKeyName(191, "sd (52).ico")
        Me.ýmageList1.Images.SetKeyName(192, "sd (53).ico")
        Me.ýmageList1.Images.SetKeyName(193, "sd (54).ico")
        Me.ýmageList1.Images.SetKeyName(194, "sd (55).ico")
        Me.ýmageList1.Images.SetKeyName(195, "sd (57).ico")
        Me.ýmageList1.Images.SetKeyName(196, "sd (59).ico")
        Me.ýmageList1.Images.SetKeyName(197, "sd (60).ico")
        Me.ýmageList1.Images.SetKeyName(198, "sd (62).ico")
        Me.ýmageList1.Images.SetKeyName(199, "sd (63).ico")
        Me.ýmageList1.Images.SetKeyName(200, "sd (64).ico")
        Me.ýmageList1.Images.SetKeyName(201, "sd (65).ico")
        Me.ýmageList1.Images.SetKeyName(202, "sd (66).ico")
        Me.ýmageList1.Images.SetKeyName(203, "sd (68).ico")
        Me.ýmageList1.Images.SetKeyName(204, "sd (69).ico")
        Me.ýmageList1.Images.SetKeyName(205, "sd (70).ico")
        Me.ýmageList1.Images.SetKeyName(206, "sd (71).ico")
        Me.ýmageList1.Images.SetKeyName(207, "sd (72).ico")
        Me.ýmageList1.Images.SetKeyName(208, "sd (73).ico")
        Me.ýmageList1.Images.SetKeyName(209, "sd (75).ico")
        Me.ýmageList1.Images.SetKeyName(210, "sd (86).ico")
        Me.ýmageList1.Images.SetKeyName(211, "sd (87).ico")
        Me.ýmageList1.Images.SetKeyName(212, "sd (88).ico")
        Me.ýmageList1.Images.SetKeyName(213, "sd (89).ico")
        Me.ýmageList1.Images.SetKeyName(214, "sd (94).ico")
        Me.ýmageList1.Images.SetKeyName(215, "sd (96).bmp")
        Me.ýmageList1.Images.SetKeyName(216, "sd (97).bmp")
        Me.ýmageList1.Images.SetKeyName(217, "sd (99).ico")
        Me.ýmageList1.Images.SetKeyName(218, "sd (100).ico")
        Me.ýmageList1.Images.SetKeyName(219, "sd (101).ico")
        Me.ýmageList1.Images.SetKeyName(220, "sd (102).bmp")
        Me.ýmageList1.Images.SetKeyName(221, "sd (103).bmp")
        Me.ýmageList1.Images.SetKeyName(222, "sd (104).bmp")
        Me.ýmageList1.Images.SetKeyName(223, "sd (105).bmp")
        Me.ýmageList1.Images.SetKeyName(224, "sd (106).bmp")
        Me.ýmageList1.Images.SetKeyName(225, "sd (107).bmp")
        Me.ýmageList1.Images.SetKeyName(226, "sd (108).bmp")
        Me.ýmageList1.Images.SetKeyName(227, "sd (109).bmp")
        Me.ýmageList1.Images.SetKeyName(228, "sd (110).bmp")
        Me.ýmageList1.Images.SetKeyName(229, "sd (111).bmp")
        Me.ýmageList1.Images.SetKeyName(230, "sd (112).bmp")
        Me.ýmageList1.Images.SetKeyName(231, "sd (113).bmp")
        Me.ýmageList1.Images.SetKeyName(232, "sd (114).ico")
        Me.ýmageList1.Images.SetKeyName(233, "sd (115).ico")
        Me.ýmageList1.Images.SetKeyName(234, "sd (116).ico")
        Me.ýmageList1.Images.SetKeyName(235, "sd (117).ico")
        Me.ýmageList1.Images.SetKeyName(236, "sd (118).ico")
        Me.ýmageList1.Images.SetKeyName(237, "sd (120).ico")
        Me.ýmageList1.Images.SetKeyName(238, "sd (121).ico")
        Me.ýmageList1.Images.SetKeyName(239, "sd (122).ico")
        Me.ýmageList1.Images.SetKeyName(240, "sd (127).ico")
        Me.ýmageList1.Images.SetKeyName(241, "sd (128).ico")
        Me.ýmageList1.Images.SetKeyName(242, "sd (129).ico")
        Me.ýmageList1.Images.SetKeyName(243, "sd (130).ico")
        Me.ýmageList1.Images.SetKeyName(244, "sd (131).ico")
        Me.ýmageList1.Images.SetKeyName(245, "sd (132).ico")
        Me.ýmageList1.Images.SetKeyName(246, "sd (134).ico")
        Me.ýmageList1.Images.SetKeyName(247, "sd (135).ico")
        Me.ýmageList1.Images.SetKeyName(248, "sd (136).ico")
        Me.ýmageList1.Images.SetKeyName(249, "sd (137).ico")
        Me.ýmageList1.Images.SetKeyName(250, "sd (139).bmp")
        Me.ýmageList1.Images.SetKeyName(251, "sd (140).ico")
        Me.ýmageList1.Images.SetKeyName(252, "sd (142).ico")
        Me.ýmageList1.Images.SetKeyName(253, "sd (143).ico")
        Me.ýmageList1.Images.SetKeyName(254, "sd (144).ico")
        Me.ýmageList1.Images.SetKeyName(255, "sd (145).ico")
        Me.ýmageList1.Images.SetKeyName(256, "sd (146).ico")
        Me.ýmageList1.Images.SetKeyName(257, "sd (147).bmp")
        Me.ýmageList1.Images.SetKeyName(258, "sd (149).ico")
        Me.ýmageList1.Images.SetKeyName(259, "sd (150).ico")
        Me.ýmageList1.Images.SetKeyName(260, "sd (151).ico")
        Me.ýmageList1.Images.SetKeyName(261, "sd (152).ico")
        Me.ýmageList1.Images.SetKeyName(262, "sd (153).ico")
        Me.ýmageList1.Images.SetKeyName(263, "sd (154).ico")
        Me.ýmageList1.Images.SetKeyName(264, "sd (155).ico")
        Me.ýmageList1.Images.SetKeyName(265, "sd (156).ico")
        Me.ýmageList1.Images.SetKeyName(266, "sd (168).ico")
        Me.ýmageList1.Images.SetKeyName(267, "sd (170).ico")
        Me.ýmageList1.Images.SetKeyName(268, "sd (171).ico")
        Me.ýmageList1.Images.SetKeyName(269, "sd (173).ico")
        Me.ýmageList1.Images.SetKeyName(270, "sd (177).ico")
        Me.ýmageList1.Images.SetKeyName(271, "sd (178).ico")
        Me.ýmageList1.Images.SetKeyName(272, "sd (180).ico")
        Me.ýmageList1.Images.SetKeyName(273, "sd (181).ico")
        Me.ýmageList1.Images.SetKeyName(274, "sd (182).ico")
        Me.ýmageList1.Images.SetKeyName(275, "sd (183).ico")
        Me.ýmageList1.Images.SetKeyName(276, "sd (184).ico")
        Me.ýmageList1.Images.SetKeyName(277, "sd (185).ico")
        Me.ýmageList1.Images.SetKeyName(278, "sd (186).ico")
        Me.ýmageList1.Images.SetKeyName(279, "sd (187).ico")
        Me.ýmageList1.Images.SetKeyName(280, "sd (188).ico")
        Me.ýmageList1.Images.SetKeyName(281, "sd (189).ico")
        Me.ýmageList1.Images.SetKeyName(282, "sd (190).ico")
        Me.ýmageList1.Images.SetKeyName(283, "sd (193).ico")
        Me.ýmageList1.Images.SetKeyName(284, "sd (194).ico")
        Me.ýmageList1.Images.SetKeyName(285, "sd (196).ico")
        Me.ýmageList1.Images.SetKeyName(286, "sd (197).bmp")
        Me.ýmageList1.Images.SetKeyName(287, "sd (200).bmp")
        Me.ýmageList1.Images.SetKeyName(288, "sd (201).ico")
        Me.ýmageList1.Images.SetKeyName(289, "sd (202).ico")
        Me.ýmageList1.Images.SetKeyName(290, "sd (205).ico")
        Me.ýmageList1.Images.SetKeyName(291, "sd (207).ico")
        Me.ýmageList1.Images.SetKeyName(292, "sd (212).ico")
        Me.ýmageList1.Images.SetKeyName(293, "sd (213).ico")
        Me.ýmageList1.Images.SetKeyName(294, "sd (214).ico")
        Me.ýmageList1.Images.SetKeyName(295, "sd (215).ico")
        Me.ýmageList1.Images.SetKeyName(296, "sd (216).ico")
        Me.ýmageList1.Images.SetKeyName(297, "sd (217).ico")
        Me.ýmageList1.Images.SetKeyName(298, "sd (220).ico")
        Me.ýmageList1.Images.SetKeyName(299, "sd (221).ico")
        Me.ýmageList1.Images.SetKeyName(300, "sd (222).ico")
        Me.ýmageList1.Images.SetKeyName(301, "sd (224).ico")
        Me.ýmageList1.Images.SetKeyName(302, "sd (225).ico")
        Me.ýmageList1.Images.SetKeyName(303, "sd (226).ico")
        Me.ýmageList1.Images.SetKeyName(304, "ses (1).ico")
        Me.ýmageList1.Images.SetKeyName(305, "ses (2).ico")
        Me.ýmageList1.Images.SetKeyName(306, "ses (3).ico")
        Me.ýmageList1.Images.SetKeyName(307, "ses (4).ico")
        Me.ýmageList1.Images.SetKeyName(308, "ses (5).ico")
        Me.ýmageList1.Images.SetKeyName(309, "ses.ico")
        Me.ýmageList1.Images.SetKeyName(310, "Settings.ico")
        Me.ýmageList1.Images.SetKeyName(311, "user.ico")
        Me.ýmageList1.Images.SetKeyName(312, "1.ico")
        Me.ýmageList1.Images.SetKeyName(313, "1ee.ico")
        Me.ýmageList1.Images.SetKeyName(314, "2.ico")
        Me.ýmageList1.Images.SetKeyName(315, "2ee.ico")
        Me.ýmageList1.Images.SetKeyName(316, "3.ico")
        Me.ýmageList1.Images.SetKeyName(317, "4.ico")
        Me.ýmageList1.Images.SetKeyName(318, "68.ico")
        Me.ýmageList1.Images.SetKeyName(319, "69.ico")
        Me.ýmageList1.Images.SetKeyName(320, "70.ico")
        Me.ýmageList1.Images.SetKeyName(321, "71.ico")
        Me.ýmageList1.Images.SetKeyName(322, "72.ico")
        Me.ýmageList1.Images.SetKeyName(323, "73.ico")
        Me.ýmageList1.Images.SetKeyName(324, "74.ico")
        Me.ýmageList1.Images.SetKeyName(325, "75.ico")
        Me.ýmageList1.Images.SetKeyName(326, "76.ico")
        Me.ýmageList1.Images.SetKeyName(327, "77.ico")
        Me.ýmageList1.Images.SetKeyName(328, "78.ico")
        Me.ýmageList1.Images.SetKeyName(329, "79.ico")
        Me.ýmageList1.Images.SetKeyName(330, "80.ico")
        Me.ýmageList1.Images.SetKeyName(331, "81.ico")
        Me.ýmageList1.Images.SetKeyName(332, "82.ico")
        Me.ýmageList1.Images.SetKeyName(333, "83.ico")
        Me.ýmageList1.Images.SetKeyName(334, "85.ico")
        Me.ýmageList1.Images.SetKeyName(335, "86.ico")
        Me.ýmageList1.Images.SetKeyName(336, "87.ico")
        Me.ýmageList1.Images.SetKeyName(337, "88.ico")
        Me.ýmageList1.Images.SetKeyName(338, "89.ico")
        Me.ýmageList1.Images.SetKeyName(339, "90.ico")
        Me.ýmageList1.Images.SetKeyName(340, "91.ico")
        Me.ýmageList1.Images.SetKeyName(341, "92.ico")
        Me.ýmageList1.Images.SetKeyName(342, "93.ico")
        Me.ýmageList1.Images.SetKeyName(343, "94.ico")
        Me.ýmageList1.Images.SetKeyName(344, "95.ico")
        Me.ýmageList1.Images.SetKeyName(345, "96.ico")
        Me.ýmageList1.Images.SetKeyName(346, "98.ico")
        Me.ýmageList1.Images.SetKeyName(347, "99.ico")
        Me.ýmageList1.Images.SetKeyName(348, "100.ico")
        Me.ýmageList1.Images.SetKeyName(349, "101.ico")
        Me.ýmageList1.Images.SetKeyName(350, "102.ico")
        Me.ýmageList1.Images.SetKeyName(351, "103.ico")
        Me.ýmageList1.Images.SetKeyName(352, "104.ico")
        Me.ýmageList1.Images.SetKeyName(353, "105.ico")
        Me.ýmageList1.Images.SetKeyName(354, "106.ico")
        Me.ýmageList1.Images.SetKeyName(355, "107.ico")
        Me.ýmageList1.Images.SetKeyName(356, "109.ico")
        Me.ýmageList1.Images.SetKeyName(357, "110.ico")
        Me.ýmageList1.Images.SetKeyName(358, "111.ico")
        Me.ýmageList1.Images.SetKeyName(359, "112.ico")
        Me.ýmageList1.Images.SetKeyName(360, "113.ico")
        Me.ýmageList1.Images.SetKeyName(361, "114.ico")
        Me.ýmageList1.Images.SetKeyName(362, "119.ico")
        Me.ýmageList1.Images.SetKeyName(363, "120.ico")
        Me.ýmageList1.Images.SetKeyName(364, "121.ico")
        Me.ýmageList1.Images.SetKeyName(365, "122.ico")
        Me.ýmageList1.Images.SetKeyName(366, "123.ico")
        Me.ýmageList1.Images.SetKeyName(367, "124.ico")
        Me.ýmageList1.Images.SetKeyName(368, "125.ico")
        Me.ýmageList1.Images.SetKeyName(369, "126.ico")
        Me.ýmageList1.Images.SetKeyName(370, "127.ico")
        Me.ýmageList1.Images.SetKeyName(371, "128.ico")
        Me.ýmageList1.Images.SetKeyName(372, "129.ico")
        Me.ýmageList1.Images.SetKeyName(373, "130.ico")
        Me.ýmageList1.Images.SetKeyName(374, "131.ico")
        Me.ýmageList1.Images.SetKeyName(375, "133.ico")
        Me.ýmageList1.Images.SetKeyName(376, "135.ico")
        Me.ýmageList1.Images.SetKeyName(377, "136.ico")
        Me.ýmageList1.Images.SetKeyName(378, "137.ico")
        Me.ýmageList1.Images.SetKeyName(379, "138.ico")
        Me.ýmageList1.Images.SetKeyName(380, "139.ico")
        Me.ýmageList1.Images.SetKeyName(381, "140.ico")
        Me.ýmageList1.Images.SetKeyName(382, "141.ico")
        Me.ýmageList1.Images.SetKeyName(383, "142.ico")
        Me.ýmageList1.Images.SetKeyName(384, "144.ico")
        Me.ýmageList1.Images.SetKeyName(385, "145.ico")
        Me.ýmageList1.Images.SetKeyName(386, "146.ico")
        Me.ýmageList1.Images.SetKeyName(387, "147.ico")
        Me.ýmageList1.Images.SetKeyName(388, "148.ico")
        Me.ýmageList1.Images.SetKeyName(389, "149.ico")
        Me.ýmageList1.Images.SetKeyName(390, "150.ico")
        Me.ýmageList1.Images.SetKeyName(391, "151.ico")
        Me.ýmageList1.Images.SetKeyName(392, "152.ico")
        Me.ýmageList1.Images.SetKeyName(393, "153.ico")
        Me.ýmageList1.Images.SetKeyName(394, "154.ico")
        Me.ýmageList1.Images.SetKeyName(395, "155.ico")
        Me.ýmageList1.Images.SetKeyName(396, "156.ico")
        Me.ýmageList1.Images.SetKeyName(397, "157.ico")
        '
        'Cikis
        '
        Me.Cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cikis.ImageIndex = 192
        Me.Cikis.ImageList = Me.ýmageList1
        Me.Cikis.Location = New System.Drawing.Point(476, 340)
        Me.Cikis.Name = "Cikis"
        Me.Cikis.Size = New System.Drawing.Size(70, 30)
        Me.Cikis.TabIndex = 33
        Me.Cikis.Text = "Çýkýþ"
        Me.Cikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cikis.UseVisualStyleBackColor = True
        Me.Cikis.Visible = False
        '
        'Kaydet
        '
        Me.Kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Kaydet.ImageKey = "210.ico"
        Me.Kaydet.ImageList = Me.ýmageList1
        Me.Kaydet.Location = New System.Drawing.Point(476, 376)
        Me.Kaydet.Name = "Kaydet"
        Me.Kaydet.Size = New System.Drawing.Size(76, 30)
        Me.Kaydet.TabIndex = 32
        Me.Kaydet.Text = "Kaydet"
        Me.Kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Kaydet.UseVisualStyleBackColor = True
        Me.Kaydet.Visible = False
        '
        'guvenlik_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.son_hali
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 438)
        Me.Controls.Add(Me.Cikis)
        Me.Controls.Add(Me.Kaydet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.proxy_CheckBox)
        Me.Controls.Add(Me.ie_ana_sayfa)
        Me.Controls.Add(Me.geri_don_kutu)
        Me.Controls.Add(Me.usb_sur_gizle)
        Me.Controls.Add(Me.aktif_desktop)
        Me.Controls.Add(Me.gorev_yonetici)
        Me.Controls.Add(Me.ms_dos_arabirim)
        Me.Controls.Add(Me.reg_dos_dis_verme)
        Me.Controls.Add(Me.regedit_yasak)
        Me.Controls.Add(Me.prg_ekle_kaldir_olmasin)
        Me.Controls.Add(Me.denetim_masa)
        Me.Controls.Add(Me.ag_baglantilarim)
        Me.Controls.Add(Me.bil_kapat_sim)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "guvenlik_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Güvenlik Ayarlarý"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bil_kapat_sim As System.Windows.Forms.CheckBox
    Friend WithEvents ag_baglantilarim As System.Windows.Forms.CheckBox
    Friend WithEvents denetim_masa As System.Windows.Forms.CheckBox
    Friend WithEvents prg_ekle_kaldir_olmasin As System.Windows.Forms.CheckBox
    Friend WithEvents regedit_yasak As System.Windows.Forms.CheckBox
    Friend WithEvents reg_dos_dis_verme As System.Windows.Forms.CheckBox
    Friend WithEvents ms_dos_arabirim As System.Windows.Forms.CheckBox
    Friend WithEvents gorev_yonetici As System.Windows.Forms.CheckBox
    Friend WithEvents aktif_desktop As System.Windows.Forms.CheckBox
    Friend WithEvents usb_sur_gizle As System.Windows.Forms.CheckBox
    Friend WithEvents geri_don_kutu As System.Windows.Forms.CheckBox
    Friend WithEvents proxy_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ie_ana_sayfa As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ýmageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Cikis As System.Windows.Forms.Button
    Friend WithEvents Kaydet As System.Windows.Forms.Button
End Class
