<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class denetim_masa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(denetim_masa))
        Me.tweak_TabControl = New System.Windows.Forms.TabControl
        Me.prg_ek_ta_pa = New System.Windows.Forms.TabPage
        Me.prg_eri_var_check = New System.Windows.Forms.CheckBox
        Me.prg_ekle_Button = New System.Windows.Forms.Button
        Me.ýmageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.win_bil_chk = New System.Windows.Forms.CheckBox
        Me.prg_deg_kal_chk = New System.Windows.Forms.CheckBox
        Me.yeni_prg_Chk = New System.Windows.Forms.CheckBox
        Me.prg_ekle_pic = New System.Windows.Forms.PictureBox
        Me.gor_tap_page = New System.Windows.Forms.TabPage
        Me.gor_sek_ac_but = New System.Windows.Forms.Button
        Me.Ayarlar = New System.Windows.Forms.CheckBox
        Me.gorunum = New System.Windows.Forms.CheckBox
        Me.Screen = New System.Windows.Forms.CheckBox
        Me.masa_ust = New System.Windows.Forms.CheckBox
        Me.tema_sek = New System.Windows.Forms.CheckBox
        Me.gor_pic = New System.Windows.Forms.PictureBox
        Me.int_opt_TabPage = New System.Windows.Forms.TabPage
        Me.int_oze_button = New System.Windows.Forms.Button
        Me.icerik_check = New System.Windows.Forms.CheckBox
        Me.gvenlik_check = New System.Windows.Forms.CheckBox
        Me.genel_sek_check = New System.Windows.Forms.CheckBox
        Me.gelismis_sek_check = New System.Windows.Forms.CheckBox
        Me.programlar_sek_check = New System.Windows.Forms.CheckBox
        Me.bag_check = New System.Windows.Forms.CheckBox
        Me.gizlilik_check = New System.Windows.Forms.CheckBox
        Me.int_pic = New System.Windows.Forms.PictureBox
        Me.Prg_ek_cikis_but = New System.Windows.Forms.Button
        Me.Prg_ek_kay_but = New System.Windows.Forms.Button
        Me.tweak_TabControl.SuspendLayout()
        Me.prg_ek_ta_pa.SuspendLayout()
        CType(Me.prg_ekle_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gor_tap_page.SuspendLayout()
        CType(Me.gor_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.int_opt_TabPage.SuspendLayout()
        CType(Me.int_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tweak_TabControl
        '
        Me.tweak_TabControl.Controls.Add(Me.prg_ek_ta_pa)
        Me.tweak_TabControl.Controls.Add(Me.gor_tap_page)
        Me.tweak_TabControl.Controls.Add(Me.int_opt_TabPage)
        Me.tweak_TabControl.ImageList = Me.ýmageList1
        Me.tweak_TabControl.Location = New System.Drawing.Point(37, 54)
        Me.tweak_TabControl.Name = "tweak_TabControl"
        Me.tweak_TabControl.SelectedIndex = 0
        Me.tweak_TabControl.Size = New System.Drawing.Size(495, 386)
        Me.tweak_TabControl.TabIndex = 0
        '
        'prg_ek_ta_pa
        '
        Me.prg_ek_ta_pa.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fon2
        Me.prg_ek_ta_pa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prg_ek_ta_pa.Controls.Add(Me.prg_eri_var_check)
        Me.prg_ek_ta_pa.Controls.Add(Me.prg_ekle_Button)
        Me.prg_ek_ta_pa.Controls.Add(Me.win_bil_chk)
        Me.prg_ek_ta_pa.Controls.Add(Me.prg_deg_kal_chk)
        Me.prg_ek_ta_pa.Controls.Add(Me.yeni_prg_Chk)
        Me.prg_ek_ta_pa.Controls.Add(Me.prg_ekle_pic)
        Me.prg_ek_ta_pa.ImageIndex = 354
        Me.prg_ek_ta_pa.Location = New System.Drawing.Point(4, 23)
        Me.prg_ek_ta_pa.Name = "prg_ek_ta_pa"
        Me.prg_ek_ta_pa.Padding = New System.Windows.Forms.Padding(3)
        Me.prg_ek_ta_pa.Size = New System.Drawing.Size(487, 359)
        Me.prg_ek_ta_pa.TabIndex = 0
        Me.prg_ek_ta_pa.Text = "Program Ekle Kaldýr"
        Me.prg_ek_ta_pa.UseVisualStyleBackColor = True
        '
        'prg_eri_var_check
        '
        Me.prg_eri_var_check.AutoSize = True
        Me.prg_eri_var_check.ForeColor = System.Drawing.Color.White
        Me.prg_eri_var_check.Location = New System.Drawing.Point(206, 130)
        Me.prg_eri_var_check.Name = "prg_eri_var_check"
        Me.prg_eri_var_check.Size = New System.Drawing.Size(279, 17)
        Me.prg_eri_var_check.TabIndex = 3
        Me.prg_eri_var_check.Text = "Program Eriþimi ve Varsayýlanlarý Ayarla Sayfasýný Gizle"
        Me.prg_eri_var_check.UseVisualStyleBackColor = True
        '
        'prg_ekle_Button
        '
        Me.prg_ekle_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.prg_ekle_Button.ImageKey = "106.ico"
        Me.prg_ekle_Button.ImageList = Me.ýmageList1
        Me.prg_ekle_Button.Location = New System.Drawing.Point(239, 199)
        Me.prg_ekle_Button.Name = "prg_ekle_Button"
        Me.prg_ekle_Button.Size = New System.Drawing.Size(146, 30)
        Me.prg_ekle_Button.TabIndex = 4
        Me.prg_ekle_Button.Text = "Program Ekle Kaldýrý Aç"
        Me.prg_ekle_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.prg_ekle_Button.UseVisualStyleBackColor = True
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
        'win_bil_chk
        '
        Me.win_bil_chk.AutoSize = True
        Me.win_bil_chk.ForeColor = System.Drawing.Color.White
        Me.win_bil_chk.Location = New System.Drawing.Point(206, 96)
        Me.win_bil_chk.Name = "win_bil_chk"
        Me.win_bil_chk.Size = New System.Drawing.Size(236, 17)
        Me.win_bil_chk.TabIndex = 2
        Me.win_bil_chk.Text = "Windows Bileþenlerini Ekle Veya Kaldýrý Gizle"
        Me.win_bil_chk.UseVisualStyleBackColor = True
        '
        'prg_deg_kal_chk
        '
        Me.prg_deg_kal_chk.AutoSize = True
        Me.prg_deg_kal_chk.ForeColor = System.Drawing.Color.White
        Me.prg_deg_kal_chk.Location = New System.Drawing.Point(206, 30)
        Me.prg_deg_kal_chk.Name = "prg_deg_kal_chk"
        Me.prg_deg_kal_chk.Size = New System.Drawing.Size(230, 17)
        Me.prg_deg_kal_chk.TabIndex = 0
        Me.prg_deg_kal_chk.Text = "Program Deðiþtir Veya Kaldýr Sayfasýný Gizle"
        Me.prg_deg_kal_chk.UseVisualStyleBackColor = True
        '
        'yeni_prg_Chk
        '
        Me.yeni_prg_Chk.AutoSize = True
        Me.yeni_prg_Chk.ForeColor = System.Drawing.Color.White
        Me.yeni_prg_Chk.Location = New System.Drawing.Point(206, 62)
        Me.yeni_prg_Chk.Name = "yeni_prg_Chk"
        Me.yeni_prg_Chk.Size = New System.Drawing.Size(191, 17)
        Me.yeni_prg_Chk.TabIndex = 1
        Me.yeni_prg_Chk.Text = "Yeni Program Ekleyi Sayfasýný Gizle"
        Me.yeni_prg_Chk.UseVisualStyleBackColor = True
        '
        'prg_ekle_pic
        '
        Me.prg_ekle_pic.Image = CType(resources.GetObject("prg_ekle_pic.Image"), System.Drawing.Image)
        Me.prg_ekle_pic.Location = New System.Drawing.Point(6, 6)
        Me.prg_ekle_pic.Name = "prg_ekle_pic"
        Me.prg_ekle_pic.Size = New System.Drawing.Size(185, 301)
        Me.prg_ekle_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.prg_ekle_pic.TabIndex = 0
        Me.prg_ekle_pic.TabStop = False
        '
        'gor_tap_page
        '
        Me.gor_tap_page.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fon2
        Me.gor_tap_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gor_tap_page.Controls.Add(Me.gor_sek_ac_but)
        Me.gor_tap_page.Controls.Add(Me.Ayarlar)
        Me.gor_tap_page.Controls.Add(Me.gorunum)
        Me.gor_tap_page.Controls.Add(Me.Screen)
        Me.gor_tap_page.Controls.Add(Me.masa_ust)
        Me.gor_tap_page.Controls.Add(Me.tema_sek)
        Me.gor_tap_page.Controls.Add(Me.gor_pic)
        Me.gor_tap_page.ImageIndex = 45
        Me.gor_tap_page.Location = New System.Drawing.Point(4, 23)
        Me.gor_tap_page.Name = "gor_tap_page"
        Me.gor_tap_page.Padding = New System.Windows.Forms.Padding(3)
        Me.gor_tap_page.Size = New System.Drawing.Size(487, 359)
        Me.gor_tap_page.TabIndex = 1
        Me.gor_tap_page.Text = "Görünüm"
        Me.gor_tap_page.UseVisualStyleBackColor = True
        '
        'gor_sek_ac_but
        '
        Me.gor_sek_ac_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gor_sek_ac_but.ImageKey = "81.ico"
        Me.gor_sek_ac_but.ImageList = Me.ýmageList1
        Me.gor_sek_ac_but.Location = New System.Drawing.Point(291, 321)
        Me.gor_sek_ac_but.Name = "gor_sek_ac_but"
        Me.gor_sek_ac_but.Size = New System.Drawing.Size(147, 27)
        Me.gor_sek_ac_but.TabIndex = 7
        Me.gor_sek_ac_but.Text = "Görünüm Sekmesini Aç"
        Me.gor_sek_ac_but.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.gor_sek_ac_but.UseVisualStyleBackColor = True
        '
        'Ayarlar
        '
        Me.Ayarlar.AutoSize = True
        Me.Ayarlar.ForeColor = System.Drawing.Color.White
        Me.Ayarlar.Location = New System.Drawing.Point(289, 184)
        Me.Ayarlar.Name = "Ayarlar"
        Me.Ayarlar.Size = New System.Drawing.Size(135, 17)
        Me.Ayarlar.TabIndex = 4
        Me.Ayarlar.Text = "Ayarlar Sekmesini Gizle"
        Me.Ayarlar.UseVisualStyleBackColor = True
        '
        'gorunum
        '
        Me.gorunum.AutoSize = True
        Me.gorunum.ForeColor = System.Drawing.Color.White
        Me.gorunum.Location = New System.Drawing.Point(289, 145)
        Me.gorunum.Name = "gorunum"
        Me.gorunum.Size = New System.Drawing.Size(146, 17)
        Me.gorunum.TabIndex = 3
        Me.gorunum.Text = "Görünüm Sekmesini Gizle"
        Me.gorunum.UseVisualStyleBackColor = True
        '
        'Screen
        '
        Me.Screen.AutoSize = True
        Me.Screen.ForeColor = System.Drawing.Color.White
        Me.Screen.Location = New System.Drawing.Point(289, 109)
        Me.Screen.Name = "Screen"
        Me.Screen.Size = New System.Drawing.Size(179, 17)
        Me.Screen.TabIndex = 2
        Me.Screen.Text = "Ekran Koruyucu Sekmesini Gizle"
        Me.Screen.UseVisualStyleBackColor = True
        '
        'masa_ust
        '
        Me.masa_ust.AutoSize = True
        Me.masa_ust.ForeColor = System.Drawing.Color.White
        Me.masa_ust.Location = New System.Drawing.Point(289, 69)
        Me.masa_ust.Name = "masa_ust"
        Me.masa_ust.Size = New System.Drawing.Size(149, 17)
        Me.masa_ust.TabIndex = 1
        Me.masa_ust.Text = "Masaüstü Sekmesini Gizle"
        Me.masa_ust.UseVisualStyleBackColor = True
        '
        'tema_sek
        '
        Me.tema_sek.AutoSize = True
        Me.tema_sek.ForeColor = System.Drawing.Color.White
        Me.tema_sek.Location = New System.Drawing.Point(289, 31)
        Me.tema_sek.Name = "tema_sek"
        Me.tema_sek.Size = New System.Drawing.Size(141, 17)
        Me.tema_sek.TabIndex = 0
        Me.tema_sek.Text = "Temalar Sekmesini Gizle"
        Me.tema_sek.UseVisualStyleBackColor = True
        '
        'gor_pic
        '
        Me.gor_pic.Image = CType(resources.GetObject("gor_pic.Image"), System.Drawing.Image)
        Me.gor_pic.Location = New System.Drawing.Point(10, 18)
        Me.gor_pic.Name = "gor_pic"
        Me.gor_pic.Size = New System.Drawing.Size(244, 330)
        Me.gor_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gor_pic.TabIndex = 0
        Me.gor_pic.TabStop = False
        '
        'int_opt_TabPage
        '
        Me.int_opt_TabPage.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fon2
        Me.int_opt_TabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.int_opt_TabPage.Controls.Add(Me.int_oze_button)
        Me.int_opt_TabPage.Controls.Add(Me.icerik_check)
        Me.int_opt_TabPage.Controls.Add(Me.gvenlik_check)
        Me.int_opt_TabPage.Controls.Add(Me.genel_sek_check)
        Me.int_opt_TabPage.Controls.Add(Me.gelismis_sek_check)
        Me.int_opt_TabPage.Controls.Add(Me.programlar_sek_check)
        Me.int_opt_TabPage.Controls.Add(Me.bag_check)
        Me.int_opt_TabPage.Controls.Add(Me.gizlilik_check)
        Me.int_opt_TabPage.Controls.Add(Me.int_pic)
        Me.int_opt_TabPage.ImageIndex = 333
        Me.int_opt_TabPage.Location = New System.Drawing.Point(4, 23)
        Me.int_opt_TabPage.Name = "int_opt_TabPage"
        Me.int_opt_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.int_opt_TabPage.Size = New System.Drawing.Size(487, 359)
        Me.int_opt_TabPage.TabIndex = 2
        Me.int_opt_TabPage.Text = "Ýnternet Seçenekleri"
        Me.int_opt_TabPage.UseVisualStyleBackColor = True
        '
        'int_oze_button
        '
        Me.int_oze_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.int_oze_button.ImageIndex = 333
        Me.int_oze_button.ImageList = Me.ýmageList1
        Me.int_oze_button.Location = New System.Drawing.Point(266, 266)
        Me.int_oze_button.Name = "int_oze_button"
        Me.int_oze_button.Size = New System.Drawing.Size(195, 33)
        Me.int_oze_button.TabIndex = 7
        Me.int_oze_button.Text = "Ýnternet Özellikleri Sekmesini Aç"
        Me.int_oze_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.int_oze_button.UseVisualStyleBackColor = True
        '
        'icerik_check
        '
        Me.icerik_check.AutoSize = True
        Me.icerik_check.ForeColor = System.Drawing.Color.White
        Me.icerik_check.Location = New System.Drawing.Point(287, 130)
        Me.icerik_check.Name = "icerik_check"
        Me.icerik_check.Size = New System.Drawing.Size(129, 17)
        Me.icerik_check.TabIndex = 3
        Me.icerik_check.Text = "Ýçerik Sekmesini Gizle"
        Me.icerik_check.UseVisualStyleBackColor = True
        '
        'gvenlik_check
        '
        Me.gvenlik_check.AutoSize = True
        Me.gvenlik_check.ForeColor = System.Drawing.Color.White
        Me.gvenlik_check.Location = New System.Drawing.Point(287, 68)
        Me.gvenlik_check.Name = "gvenlik_check"
        Me.gvenlik_check.Size = New System.Drawing.Size(145, 17)
        Me.gvenlik_check.TabIndex = 1
        Me.gvenlik_check.Text = "Güvenlik Sekmesini Gizle"
        Me.gvenlik_check.UseVisualStyleBackColor = True
        '
        'genel_sek_check
        '
        Me.genel_sek_check.AutoSize = True
        Me.genel_sek_check.ForeColor = System.Drawing.Color.White
        Me.genel_sek_check.Location = New System.Drawing.Point(287, 37)
        Me.genel_sek_check.Name = "genel_sek_check"
        Me.genel_sek_check.Size = New System.Drawing.Size(131, 17)
        Me.genel_sek_check.TabIndex = 0
        Me.genel_sek_check.Text = "Genel Sekmesini Gizle"
        Me.genel_sek_check.UseVisualStyleBackColor = True
        '
        'gelismis_sek_check
        '
        Me.gelismis_sek_check.AutoSize = True
        Me.gelismis_sek_check.ForeColor = System.Drawing.Color.White
        Me.gelismis_sek_check.Location = New System.Drawing.Point(287, 223)
        Me.gelismis_sek_check.Name = "gelismis_sek_check"
        Me.gelismis_sek_check.Size = New System.Drawing.Size(141, 17)
        Me.gelismis_sek_check.TabIndex = 6
        Me.gelismis_sek_check.Text = "Geliþmiþ Sekmesini Gizle"
        Me.gelismis_sek_check.UseVisualStyleBackColor = True
        '
        'programlar_sek_check
        '
        Me.programlar_sek_check.AutoSize = True
        Me.programlar_sek_check.ForeColor = System.Drawing.Color.White
        Me.programlar_sek_check.Location = New System.Drawing.Point(287, 192)
        Me.programlar_sek_check.Name = "programlar_sek_check"
        Me.programlar_sek_check.Size = New System.Drawing.Size(153, 17)
        Me.programlar_sek_check.TabIndex = 5
        Me.programlar_sek_check.Text = "Programlar Sekmesini Gizle"
        Me.programlar_sek_check.UseVisualStyleBackColor = True
        '
        'bag_check
        '
        Me.bag_check.AutoSize = True
        Me.bag_check.ForeColor = System.Drawing.Color.White
        Me.bag_check.Location = New System.Drawing.Point(287, 161)
        Me.bag_check.Name = "bag_check"
        Me.bag_check.Size = New System.Drawing.Size(152, 17)
        Me.bag_check.TabIndex = 4
        Me.bag_check.Text = "Baðlantýlar Sekmesini Gizle"
        Me.bag_check.UseVisualStyleBackColor = True
        '
        'gizlilik_check
        '
        Me.gizlilik_check.AutoSize = True
        Me.gizlilik_check.ForeColor = System.Drawing.Color.White
        Me.gizlilik_check.Location = New System.Drawing.Point(287, 99)
        Me.gizlilik_check.Name = "gizlilik_check"
        Me.gizlilik_check.Size = New System.Drawing.Size(126, 17)
        Me.gizlilik_check.TabIndex = 2
        Me.gizlilik_check.Text = "Gizlilik Sekmsini Gizle"
        Me.gizlilik_check.UseVisualStyleBackColor = True
        '
        'int_pic
        '
        Me.int_pic.Image = CType(resources.GetObject("int_pic.Image"), System.Drawing.Image)
        Me.int_pic.Location = New System.Drawing.Point(26, 13)
        Me.int_pic.Name = "int_pic"
        Me.int_pic.Size = New System.Drawing.Size(234, 340)
        Me.int_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.int_pic.TabIndex = 0
        Me.int_pic.TabStop = False
        '
        'Prg_ek_cikis_but
        '
        Me.Prg_ek_cikis_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Prg_ek_cikis_but.ImageIndex = 192
        Me.Prg_ek_cikis_but.ImageList = Me.ýmageList1
        Me.Prg_ek_cikis_but.Location = New System.Drawing.Point(514, 410)
        Me.Prg_ek_cikis_but.Name = "Prg_ek_cikis_but"
        Me.Prg_ek_cikis_but.Size = New System.Drawing.Size(70, 30)
        Me.Prg_ek_cikis_but.TabIndex = 6
        Me.Prg_ek_cikis_but.Text = "Çýkýþ"
        Me.Prg_ek_cikis_but.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Prg_ek_cikis_but.UseVisualStyleBackColor = True
        Me.Prg_ek_cikis_but.Visible = False
        '
        'Prg_ek_kay_but
        '
        Me.Prg_ek_kay_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Prg_ek_kay_but.ImageKey = "210.ico"
        Me.Prg_ek_kay_but.ImageList = Me.ýmageList1
        Me.Prg_ek_kay_but.Location = New System.Drawing.Point(495, 383)
        Me.Prg_ek_kay_but.Name = "Prg_ek_kay_but"
        Me.Prg_ek_kay_but.Size = New System.Drawing.Size(76, 30)
        Me.Prg_ek_kay_but.TabIndex = 5
        Me.Prg_ek_kay_but.Text = "Kaydet"
        Me.Prg_ek_kay_but.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Prg_ek_kay_but.UseVisualStyleBackColor = True
        Me.Prg_ek_kay_but.Visible = False
        '
        'denetim_masa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.son_hali
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(564, 482)
        Me.Controls.Add(Me.tweak_TabControl)
        Me.Controls.Add(Me.Prg_ek_kay_but)
        Me.Controls.Add(Me.Prg_ek_cikis_but)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "denetim_masa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Denetim Masasý (Tweak)"
        Me.tweak_TabControl.ResumeLayout(False)
        Me.prg_ek_ta_pa.ResumeLayout(False)
        Me.prg_ek_ta_pa.PerformLayout()
        CType(Me.prg_ekle_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gor_tap_page.ResumeLayout(False)
        Me.gor_tap_page.PerformLayout()
        CType(Me.gor_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.int_opt_TabPage.ResumeLayout(False)
        Me.int_opt_TabPage.PerformLayout()
        CType(Me.int_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tweak_TabControl As System.Windows.Forms.TabControl
    Friend WithEvents prg_ek_ta_pa As System.Windows.Forms.TabPage
    Friend WithEvents gor_tap_page As System.Windows.Forms.TabPage
    Friend WithEvents ýmageList1 As System.Windows.Forms.ImageList
    Friend WithEvents int_opt_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents prg_ekle_pic As System.Windows.Forms.PictureBox
    Friend WithEvents prg_deg_kal_chk As System.Windows.Forms.CheckBox
    Friend WithEvents yeni_prg_Chk As System.Windows.Forms.CheckBox
    Friend WithEvents gor_pic As System.Windows.Forms.PictureBox
    Friend WithEvents Screen As System.Windows.Forms.CheckBox
    Friend WithEvents masa_ust As System.Windows.Forms.CheckBox
    Friend WithEvents tema_sek As System.Windows.Forms.CheckBox
    Friend WithEvents int_pic As System.Windows.Forms.PictureBox
    Friend WithEvents win_bil_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Prg_ek_cikis_but As System.Windows.Forms.Button
    Friend WithEvents Prg_ek_kay_but As System.Windows.Forms.Button
    Friend WithEvents prg_eri_var_check As System.Windows.Forms.CheckBox
    Friend WithEvents prg_ekle_Button As System.Windows.Forms.Button
    Friend WithEvents Ayarlar As System.Windows.Forms.CheckBox
    Friend WithEvents gorunum As System.Windows.Forms.CheckBox
    Friend WithEvents gor_sek_ac_but As System.Windows.Forms.Button
    Friend WithEvents icerik_check As System.Windows.Forms.CheckBox
    Friend WithEvents gvenlik_check As System.Windows.Forms.CheckBox
    Friend WithEvents genel_sek_check As System.Windows.Forms.CheckBox
    Friend WithEvents gelismis_sek_check As System.Windows.Forms.CheckBox
    Friend WithEvents programlar_sek_check As System.Windows.Forms.CheckBox
    Friend WithEvents bag_check As System.Windows.Forms.CheckBox
    Friend WithEvents gizlilik_check As System.Windows.Forms.CheckBox
    Friend WithEvents int_oze_button As System.Windows.Forms.Button
End Class
