<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outlook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(outlook))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.baslik_label = New System.Windows.Forms.Label
        Me.sil_button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.yazi_TextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Outlok_exprees_check = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fon2
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.baslik_label)
        Me.GroupBox1.Controls.Add(Me.sil_button)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.yazi_TextBox)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Baþlýk Yazýsý"
        '
        'baslik_label
        '
        Me.baslik_label.AutoSize = True
        Me.baslik_label.BackColor = System.Drawing.Color.Transparent
        Me.baslik_label.Location = New System.Drawing.Point(17, 22)
        Me.baslik_label.Name = "baslik_label"
        Me.baslik_label.Size = New System.Drawing.Size(263, 13)
        Me.baslik_label.TabIndex = 4
        Me.baslik_label.Text = "Outlook Expressin Baþlýk daki Yazýsýný Deðiþtirebilirsiniz"
        '
        'sil_button
        '
        Me.sil_button.Location = New System.Drawing.Point(294, 52)
        Me.sil_button.Name = "sil_button"
        Me.sil_button.Size = New System.Drawing.Size(42, 23)
        Me.sil_button.TabIndex = 3
        Me.sil_button.Text = "Sil"
        Me.sil_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Yazý"
        '
        'yazi_TextBox
        '
        Me.yazi_TextBox.Location = New System.Drawing.Point(50, 54)
        Me.yazi_TextBox.Name = "yazi_TextBox"
        Me.yazi_TextBox.Size = New System.Drawing.Size(234, 20)
        Me.yazi_TextBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources._100
        Me.PictureBox3.Location = New System.Drawing.Point(14, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fon2
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Outlok_exprees_check)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 114)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outlook"
        '
        'Outlok_exprees_check
        '
        Me.Outlok_exprees_check.AutoSize = True
        Me.Outlok_exprees_check.BackColor = System.Drawing.Color.Transparent
        Me.Outlok_exprees_check.Location = New System.Drawing.Point(81, 35)
        Me.Outlok_exprees_check.Name = "Outlok_exprees_check"
        Me.Outlok_exprees_check.Size = New System.Drawing.Size(230, 17)
        Me.Outlok_exprees_check.TabIndex = 3
        Me.Outlok_exprees_check.Text = "Outlook Express in Açýlýþ Ekranýný Gösterme"
        Me.Outlok_exprees_check.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources._280
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(100, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Outlook Express'i Aç"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'outlook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.son_hali
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(403, 339)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "outlook"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outlook"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents baslik_label As System.Windows.Forms.Label
    Friend WithEvents sil_button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yazi_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Outlok_exprees_check As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
