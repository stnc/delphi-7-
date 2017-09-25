<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sistem_dos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sistem_dos))
        Me.sistem_dos_tab = New System.Windows.Forms.TabControl
        Me.boot_page = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.ýmageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.boot_RichTextBox = New System.Windows.Forms.RichTextBox
        Me.sistem_page = New System.Windows.Forms.TabPage
        Me.sistem_RichTextBox = New System.Windows.Forms.RichTextBox
        Me.win_ini_page = New System.Windows.Forms.TabPage
        Me.win_richtext = New System.Windows.Forms.RichTextBox
        Me.autoexec_pic = New System.Windows.Forms.TabPage
        Me.autoexec_RichTextBox = New System.Windows.Forms.RichTextBox
        Me.config_pic = New System.Windows.Forms.TabPage
        Me.config_RichTextBox = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.klasor_yeri = New System.Windows.Forms.Label
        Me.sistem_dos_tab.SuspendLayout()
        Me.boot_page.SuspendLayout()
        Me.sistem_page.SuspendLayout()
        Me.win_ini_page.SuspendLayout()
        Me.autoexec_pic.SuspendLayout()
        Me.config_pic.SuspendLayout()
        Me.SuspendLayout()
        '
        'sistem_dos_tab
        '
        Me.sistem_dos_tab.Controls.Add(Me.boot_page)
        Me.sistem_dos_tab.Controls.Add(Me.sistem_page)
        Me.sistem_dos_tab.Controls.Add(Me.win_ini_page)
        Me.sistem_dos_tab.Controls.Add(Me.autoexec_pic)
        Me.sistem_dos_tab.Controls.Add(Me.config_pic)
        Me.sistem_dos_tab.Location = New System.Drawing.Point(31, 71)
        Me.sistem_dos_tab.Name = "sistem_dos_tab"
        Me.sistem_dos_tab.SelectedIndex = 0
        Me.sistem_dos_tab.Size = New System.Drawing.Size(467, 390)
        Me.sistem_dos_tab.TabIndex = 0
        '
        'boot_page
        '
        Me.boot_page.Controls.Add(Me.Button1)
        Me.boot_page.Controls.Add(Me.boot_RichTextBox)
        Me.boot_page.Location = New System.Drawing.Point(4, 22)
        Me.boot_page.Name = "boot_page"
        Me.boot_page.Padding = New System.Windows.Forms.Padding(3)
        Me.boot_page.Size = New System.Drawing.Size(459, 364)
        Me.boot_page.TabIndex = 0
        Me.boot_page.Text = "Boot.ini"
        Me.boot_page.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageKey = "153.ico"
        Me.Button1.ImageList = Me.ýmageList1
        Me.Button1.Location = New System.Drawing.Point(130, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Düzenlemek Ýçin Not Defteri Ýle Aç"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ýmageList1
        '
        Me.ýmageList1.ImageStream = CType(resources.GetObject("ýmageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ýmageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ýmageList1.Images.SetKeyName(0, "107.ico")
        Me.ýmageList1.Images.SetKeyName(1, "153.ico")
        '
        'boot_RichTextBox
        '
        Me.boot_RichTextBox.Location = New System.Drawing.Point(6, 6)
        Me.boot_RichTextBox.Name = "boot_RichTextBox"
        Me.boot_RichTextBox.Size = New System.Drawing.Size(449, 324)
        Me.boot_RichTextBox.TabIndex = 0
        Me.boot_RichTextBox.Text = ""
        '
        'sistem_page
        '
        Me.sistem_page.Controls.Add(Me.sistem_RichTextBox)
        Me.sistem_page.Location = New System.Drawing.Point(4, 22)
        Me.sistem_page.Name = "sistem_page"
        Me.sistem_page.Padding = New System.Windows.Forms.Padding(3)
        Me.sistem_page.Size = New System.Drawing.Size(459, 364)
        Me.sistem_page.TabIndex = 1
        Me.sistem_page.Text = "System.ini"
        Me.sistem_page.UseVisualStyleBackColor = True
        '
        'sistem_RichTextBox
        '
        Me.sistem_RichTextBox.Location = New System.Drawing.Point(12, 8)
        Me.sistem_RichTextBox.Name = "sistem_RichTextBox"
        Me.sistem_RichTextBox.Size = New System.Drawing.Size(441, 329)
        Me.sistem_RichTextBox.TabIndex = 0
        Me.sistem_RichTextBox.Text = ""
        '
        'win_ini_page
        '
        Me.win_ini_page.Controls.Add(Me.win_richtext)
        Me.win_ini_page.Location = New System.Drawing.Point(4, 22)
        Me.win_ini_page.Name = "win_ini_page"
        Me.win_ini_page.Padding = New System.Windows.Forms.Padding(3)
        Me.win_ini_page.Size = New System.Drawing.Size(459, 364)
        Me.win_ini_page.TabIndex = 2
        Me.win_ini_page.Text = "Win.ini"
        Me.win_ini_page.UseVisualStyleBackColor = True
        '
        'win_richtext
        '
        Me.win_richtext.Location = New System.Drawing.Point(8, 10)
        Me.win_richtext.Name = "win_richtext"
        Me.win_richtext.Size = New System.Drawing.Size(445, 329)
        Me.win_richtext.TabIndex = 0
        Me.win_richtext.Text = ""
        '
        'autoexec_pic
        '
        Me.autoexec_pic.Controls.Add(Me.autoexec_RichTextBox)
        Me.autoexec_pic.Location = New System.Drawing.Point(4, 22)
        Me.autoexec_pic.Name = "autoexec_pic"
        Me.autoexec_pic.Padding = New System.Windows.Forms.Padding(3)
        Me.autoexec_pic.Size = New System.Drawing.Size(459, 364)
        Me.autoexec_pic.TabIndex = 3
        Me.autoexec_pic.Text = "Autoexec.nt"
        Me.autoexec_pic.UseVisualStyleBackColor = True
        '
        'autoexec_RichTextBox
        '
        Me.autoexec_RichTextBox.Location = New System.Drawing.Point(10, 12)
        Me.autoexec_RichTextBox.Name = "autoexec_RichTextBox"
        Me.autoexec_RichTextBox.Size = New System.Drawing.Size(443, 317)
        Me.autoexec_RichTextBox.TabIndex = 0
        Me.autoexec_RichTextBox.Text = ""
        '
        'config_pic
        '
        Me.config_pic.Controls.Add(Me.config_RichTextBox)
        Me.config_pic.Location = New System.Drawing.Point(4, 22)
        Me.config_pic.Name = "config_pic"
        Me.config_pic.Padding = New System.Windows.Forms.Padding(3)
        Me.config_pic.Size = New System.Drawing.Size(459, 364)
        Me.config_pic.TabIndex = 4
        Me.config_pic.Text = "Config.nt"
        Me.config_pic.UseVisualStyleBackColor = True
        '
        'config_RichTextBox
        '
        Me.config_RichTextBox.Location = New System.Drawing.Point(9, 10)
        Me.config_RichTextBox.Name = "config_RichTextBox"
        Me.config_RichTextBox.Size = New System.Drawing.Size(444, 335)
        Me.config_RichTextBox.TabIndex = 0
        Me.config_RichTextBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Yol"
        '
        'klasor_yeri
        '
        Me.klasor_yeri.AutoSize = True
        Me.klasor_yeri.Location = New System.Drawing.Point(80, 52)
        Me.klasor_yeri.Name = "klasor_yeri"
        Me.klasor_yeri.Size = New System.Drawing.Size(39, 13)
        Me.klasor_yeri.TabIndex = 2
        Me.klasor_yeri.Text = "Label2"
        '
        'sistem_dos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.son_hali
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(535, 502)
        Me.Controls.Add(Me.klasor_yeri)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sistem_dos_tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sistem_dos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Dosyalarý"
        Me.sistem_dos_tab.ResumeLayout(False)
        Me.boot_page.ResumeLayout(False)
        Me.sistem_page.ResumeLayout(False)
        Me.win_ini_page.ResumeLayout(False)
        Me.autoexec_pic.ResumeLayout(False)
        Me.config_pic.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sistem_dos_tab As System.Windows.Forms.TabControl
    Friend WithEvents boot_page As System.Windows.Forms.TabPage
    Friend WithEvents sistem_page As System.Windows.Forms.TabPage
    Friend WithEvents win_ini_page As System.Windows.Forms.TabPage
    Friend WithEvents autoexec_pic As System.Windows.Forms.TabPage
    Friend WithEvents config_pic As System.Windows.Forms.TabPage
    Friend WithEvents boot_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents sistem_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents win_richtext As System.Windows.Forms.RichTextBox
    Friend WithEvents autoexec_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents config_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents klasor_yeri As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ýmageList1 As System.Windows.Forms.ImageList
End Class
