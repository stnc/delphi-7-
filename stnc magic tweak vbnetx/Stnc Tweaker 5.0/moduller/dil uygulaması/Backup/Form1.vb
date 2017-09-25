Imports System.Globalization
Imports System.Threading

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        lblShowUICulture.Text = Thread.CurrentThread.CurrentUICulture.NativeName 'Display the CurrentUICulture in the label

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents txtCultureEdit As System.Windows.Forms.TextBox
    Friend WithEvents btnSwitchButton As System.Windows.Forms.Button
    Friend WithEvents lblShowUICulture As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.txtCultureEdit = New System.Windows.Forms.TextBox()
        Me.btnSwitchButton = New System.Windows.Forms.Button()
        Me.lblShowUICulture = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtCultureEdit
        '
        Me.txtCultureEdit.AccessibleDescription = CType(resources.GetObject("txtCultureEdit.AccessibleDescription"), String)
        Me.txtCultureEdit.AccessibleName = CType(resources.GetObject("txtCultureEdit.AccessibleName"), String)
        Me.txtCultureEdit.Anchor = CType(resources.GetObject("txtCultureEdit.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtCultureEdit.AutoSize = CType(resources.GetObject("txtCultureEdit.AutoSize"), Boolean)
        Me.txtCultureEdit.BackgroundImage = CType(resources.GetObject("txtCultureEdit.BackgroundImage"), System.Drawing.Image)
        Me.txtCultureEdit.Cursor = CType(resources.GetObject("txtCultureEdit.Cursor"), System.Windows.Forms.Cursor)
        Me.txtCultureEdit.Dock = CType(resources.GetObject("txtCultureEdit.Dock"), System.Windows.Forms.DockStyle)
        Me.txtCultureEdit.Enabled = CType(resources.GetObject("txtCultureEdit.Enabled"), Boolean)
        Me.txtCultureEdit.Font = CType(resources.GetObject("txtCultureEdit.Font"), System.Drawing.Font)
        Me.txtCultureEdit.ImeMode = CType(resources.GetObject("txtCultureEdit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtCultureEdit.Location = CType(resources.GetObject("txtCultureEdit.Location"), System.Drawing.Point)
        Me.txtCultureEdit.MaxLength = CType(resources.GetObject("txtCultureEdit.MaxLength"), Integer)
        Me.txtCultureEdit.Multiline = CType(resources.GetObject("txtCultureEdit.Multiline"), Boolean)
        Me.txtCultureEdit.Name = "txtCultureEdit"
        Me.txtCultureEdit.PasswordChar = CType(resources.GetObject("txtCultureEdit.PasswordChar"), Char)
        Me.txtCultureEdit.RightToLeft = CType(resources.GetObject("txtCultureEdit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtCultureEdit.ScrollBars = CType(resources.GetObject("txtCultureEdit.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtCultureEdit.Size = CType(resources.GetObject("txtCultureEdit.Size"), System.Drawing.Size)
        Me.txtCultureEdit.TabIndex = CType(resources.GetObject("txtCultureEdit.TabIndex"), Integer)
        Me.txtCultureEdit.Text = resources.GetString("txtCultureEdit.Text")
        Me.txtCultureEdit.TextAlign = CType(resources.GetObject("txtCultureEdit.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ToolTip1.SetToolTip(Me.txtCultureEdit, resources.GetString("txtCultureEdit.ToolTip"))
        Me.txtCultureEdit.Visible = CType(resources.GetObject("txtCultureEdit.Visible"), Boolean)
        Me.txtCultureEdit.WordWrap = CType(resources.GetObject("txtCultureEdit.WordWrap"), Boolean)
        '
        'btnSwitchButton
        '
        Me.btnSwitchButton.AccessibleDescription = CType(resources.GetObject("btnSwitchButton.AccessibleDescription"), String)
        Me.btnSwitchButton.AccessibleName = CType(resources.GetObject("btnSwitchButton.AccessibleName"), String)
        Me.btnSwitchButton.Anchor = CType(resources.GetObject("btnSwitchButton.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnSwitchButton.BackgroundImage = CType(resources.GetObject("btnSwitchButton.BackgroundImage"), System.Drawing.Image)
        Me.btnSwitchButton.Cursor = CType(resources.GetObject("btnSwitchButton.Cursor"), System.Windows.Forms.Cursor)
        Me.btnSwitchButton.Dock = CType(resources.GetObject("btnSwitchButton.Dock"), System.Windows.Forms.DockStyle)
        Me.btnSwitchButton.Enabled = CType(resources.GetObject("btnSwitchButton.Enabled"), Boolean)
        Me.btnSwitchButton.FlatStyle = CType(resources.GetObject("btnSwitchButton.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnSwitchButton.Font = CType(resources.GetObject("btnSwitchButton.Font"), System.Drawing.Font)
        Me.btnSwitchButton.Image = CType(resources.GetObject("btnSwitchButton.Image"), System.Drawing.Image)
        Me.btnSwitchButton.ImageAlign = CType(resources.GetObject("btnSwitchButton.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnSwitchButton.ImageIndex = CType(resources.GetObject("btnSwitchButton.ImageIndex"), Integer)
        Me.btnSwitchButton.ImeMode = CType(resources.GetObject("btnSwitchButton.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnSwitchButton.Location = CType(resources.GetObject("btnSwitchButton.Location"), System.Drawing.Point)
        Me.btnSwitchButton.Name = "btnSwitchButton"
        Me.btnSwitchButton.RightToLeft = CType(resources.GetObject("btnSwitchButton.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnSwitchButton.Size = CType(resources.GetObject("btnSwitchButton.Size"), System.Drawing.Size)
        Me.btnSwitchButton.TabIndex = CType(resources.GetObject("btnSwitchButton.TabIndex"), Integer)
        Me.btnSwitchButton.Text = resources.GetString("btnSwitchButton.Text")
        Me.btnSwitchButton.TextAlign = CType(resources.GetObject("btnSwitchButton.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.btnSwitchButton, resources.GetString("btnSwitchButton.ToolTip"))
        Me.btnSwitchButton.Visible = CType(resources.GetObject("btnSwitchButton.Visible"), Boolean)
        '
        'lblShowUICulture
        '
        Me.lblShowUICulture.AccessibleDescription = CType(resources.GetObject("lblShowUICulture.AccessibleDescription"), String)
        Me.lblShowUICulture.AccessibleName = CType(resources.GetObject("lblShowUICulture.AccessibleName"), String)
        Me.lblShowUICulture.Anchor = CType(resources.GetObject("lblShowUICulture.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblShowUICulture.AutoSize = CType(resources.GetObject("lblShowUICulture.AutoSize"), Boolean)
        Me.lblShowUICulture.Cursor = CType(resources.GetObject("lblShowUICulture.Cursor"), System.Windows.Forms.Cursor)
        Me.lblShowUICulture.Dock = CType(resources.GetObject("lblShowUICulture.Dock"), System.Windows.Forms.DockStyle)
        Me.lblShowUICulture.Enabled = CType(resources.GetObject("lblShowUICulture.Enabled"), Boolean)
        Me.lblShowUICulture.Font = CType(resources.GetObject("lblShowUICulture.Font"), System.Drawing.Font)
        Me.lblShowUICulture.Image = CType(resources.GetObject("lblShowUICulture.Image"), System.Drawing.Image)
        Me.lblShowUICulture.ImageAlign = CType(resources.GetObject("lblShowUICulture.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblShowUICulture.ImageIndex = CType(resources.GetObject("lblShowUICulture.ImageIndex"), Integer)
        Me.lblShowUICulture.ImeMode = CType(resources.GetObject("lblShowUICulture.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblShowUICulture.Location = CType(resources.GetObject("lblShowUICulture.Location"), System.Drawing.Point)
        Me.lblShowUICulture.Name = "lblShowUICulture"
        Me.lblShowUICulture.RightToLeft = CType(resources.GetObject("lblShowUICulture.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblShowUICulture.Size = CType(resources.GetObject("lblShowUICulture.Size"), System.Drawing.Size)
        Me.lblShowUICulture.TabIndex = CType(resources.GetObject("lblShowUICulture.TabIndex"), Integer)
        Me.lblShowUICulture.Text = resources.GetString("lblShowUICulture.Text")
        Me.lblShowUICulture.TextAlign = CType(resources.GetObject("lblShowUICulture.TextAlign"), System.Drawing.ContentAlignment)
        Me.ToolTip1.SetToolTip(Me.lblShowUICulture, resources.GetString("lblShowUICulture.ToolTip"))
        Me.lblShowUICulture.Visible = CType(resources.GetObject("lblShowUICulture.Visible"), Boolean)
        '
        'Form1
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblShowUICulture, Me.btnSwitchButton, Me.txtCultureEdit})
        Me.Cursor = CType(resources.GetObject("$this.Cursor"), System.Windows.Forms.Cursor)
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "Form1"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSwitchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSwitchButton.Click
        Try
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(txtCultureEdit.Text, False) 'Set the CurrentUICulture to the language specified in the CultureEdit textbox
        Catch
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("", False) 'Fallback to fallback resources if entered culture is not valid
        End Try
        Dim f As New Form1() 'Create and show a new form using the new culture
        f.Show()



    End Sub
End Class
