<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sistem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sistem))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.win_kisayol = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.kisayol_check = New System.Windows.Forms.CheckBox
        Me.kisayol_yazi = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.disk_kapasite = New System.Windows.Forms.CheckBox
        Me.hdd_uyari_label = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cleartype_radio = New System.Windows.Forms.RadioButton
        Me.standart_radio = New System.Windows.Forms.RadioButton
        Me.ekran_font_label = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fon2
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.win_kisayol)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.kisayol_check)
        Me.GroupBox1.Controls.Add(Me.kisayol_yazi)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kýsayol"
        '
        'win_kisayol
        '
        Me.win_kisayol.AutoSize = True
        Me.win_kisayol.BackColor = System.Drawing.Color.Transparent
        Me.win_kisayol.Location = New System.Drawing.Point(17, 112)
        Me.win_kisayol.Name = "win_kisayol"
        Me.win_kisayol.Size = New System.Drawing.Size(290, 13)
        Me.win_kisayol.TabIndex = 4
        Me.win_kisayol.Text = "Windowsun Kýsayol Ýconu Oluþturunu Kaldýrabilmenizi Saðlar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(20, 152)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(284, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Kýsayollardaki Kýsayol Oldugunu Belli Eden Ýconu Kaldýr"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'kisayol_check
        '
        Me.kisayol_check.AutoSize = True
        Me.kisayol_check.BackColor = System.Drawing.Color.Transparent
        Me.kisayol_check.Location = New System.Drawing.Point(20, 70)
        Me.kisayol_check.Name = "kisayol_check"
        Me.kisayol_check.Size = New System.Drawing.Size(130, 17)
        Me.kisayol_check.TabIndex = 1
        Me.kisayol_check.Text = "Kýsayol Ýbaresini Kaldýr"
        Me.kisayol_check.UseVisualStyleBackColor = False
        '
        'kisayol_yazi
        '
        Me.kisayol_yazi.AutoSize = True
        Me.kisayol_yazi.BackColor = System.Drawing.Color.Transparent
        Me.kisayol_yazi.Location = New System.Drawing.Point(17, 16)
        Me.kisayol_yazi.Name = "kisayol_yazi"
        Me.kisayol_yazi.Size = New System.Drawing.Size(326, 39)
        Me.kisayol_yazi.TabIndex = 0
        Me.kisayol_yazi.Text = "Windows Kýsayol Oluþtur Dedigiz Zaman Dosya Ýsmini ""Kýsayol ....."" " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dosya Gibi Y" & _
            "azmanýzý Saglar Fakat Sadece Dosya Ýsmi Yazmak Ýçin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bu Seçeneði Aktif Hale Geti" & _
            "rmeniz Gerekmektedir.  "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.disk_kapasite)
        Me.GroupBox2.Controls.Add(Me.hdd_uyari_label)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 83)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Harddisk Uyarýsý"
        '
        'disk_kapasite
        '
        Me.disk_kapasite.AutoSize = True
        Me.disk_kapasite.BackColor = System.Drawing.Color.Transparent
        Me.disk_kapasite.Location = New System.Drawing.Point(19, 60)
        Me.disk_kapasite.Name = "disk_kapasite"
        Me.disk_kapasite.Size = New System.Drawing.Size(194, 17)
        Me.disk_kapasite.TabIndex = 1
        Me.disk_kapasite.Text = "Disk Kapasitesi Dolu Uyarýsýný Kaldýr"
        Me.disk_kapasite.UseVisualStyleBackColor = False
        '
        'hdd_uyari_label
        '
        Me.hdd_uyari_label.AutoSize = True
        Me.hdd_uyari_label.BackColor = System.Drawing.Color.Transparent
        Me.hdd_uyari_label.Location = New System.Drawing.Point(6, 16)
        Me.hdd_uyari_label.Name = "hdd_uyari_label"
        Me.hdd_uyari_label.Size = New System.Drawing.Size(316, 26)
        Me.hdd_uyari_label.TabIndex = 0
        Me.hdd_uyari_label.Text = "Sürücünüzdeki Bilgi Miktarý Doldugu Zaman Sað Alt Köþede Uyarý" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Verir Buna Engel" & _
            "Olabilmenizi Saðlar."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.cleartype_radio)
        Me.GroupBox3.Controls.Add(Me.standart_radio)
        Me.GroupBox3.Controls.Add(Me.ekran_font_label)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 329)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 106)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ekran Fontlarý"
        '
        'cleartype_radio
        '
        Me.cleartype_radio.AutoSize = True
        Me.cleartype_radio.BackColor = System.Drawing.Color.Transparent
        Me.cleartype_radio.Location = New System.Drawing.Point(20, 80)
        Me.cleartype_radio.Name = "cleartype_radio"
        Me.cleartype_radio.Size = New System.Drawing.Size(76, 17)
        Me.cleartype_radio.TabIndex = 2
        Me.cleartype_radio.TabStop = True
        Me.cleartype_radio.Text = "Clear Type"
        Me.cleartype_radio.UseVisualStyleBackColor = False
        '
        'standart_radio
        '
        Me.standart_radio.AutoSize = True
        Me.standart_radio.BackColor = System.Drawing.Color.Transparent
        Me.standart_radio.Location = New System.Drawing.Point(20, 57)
        Me.standart_radio.Name = "standart_radio"
        Me.standart_radio.Size = New System.Drawing.Size(65, 17)
        Me.standart_radio.TabIndex = 1
        Me.standart_radio.TabStop = True
        Me.standart_radio.Text = "Standart"
        Me.standart_radio.UseVisualStyleBackColor = False
        '
        'ekran_font_label
        '
        Me.ekran_font_label.AutoSize = True
        Me.ekran_font_label.BackColor = System.Drawing.Color.Transparent
        Me.ekran_font_label.Location = New System.Drawing.Point(17, 16)
        Me.ekran_font_label.Name = "ekran_font_label"
        Me.ekran_font_label.Size = New System.Drawing.Size(321, 26)
        Me.ekran_font_label.TabIndex = 0
        Me.ekran_font_label.Text = "Ekran Fontlarýný Kullanýrken Yumuþak Veya Standart Font" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "olarak Kulanabilirsiniz " & _
            "Yumuþak (Clear Type) Genel Tercih Edilendir"
        '
        'sistem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.son_hali
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(433, 504)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sistem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Ayarlarý"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents kisayol_check As System.Windows.Forms.CheckBox
    Friend WithEvents kisayol_yazi As System.Windows.Forms.Label
    Friend WithEvents win_kisayol As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents hdd_uyari_label As System.Windows.Forms.Label
    Friend WithEvents disk_kapasite As System.Windows.Forms.CheckBox
    Friend WithEvents cleartype_radio As System.Windows.Forms.RadioButton
    Friend WithEvents standart_radio As System.Windows.Forms.RadioButton
    Friend WithEvents ekran_font_label As System.Windows.Forms.Label
End Class
