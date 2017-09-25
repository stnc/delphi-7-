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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtCultureEdit = New System.Windows.Forms.TextBox
        Me.btnSwitchButton = New System.Windows.Forms.Button
        Me.lblShowUICulture = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtCultureEdit
        '
        resources.ApplyResources(Me.txtCultureEdit, "txtCultureEdit")
        Me.txtCultureEdit.Name = "txtCultureEdit"
        Me.ToolTip1.SetToolTip(Me.txtCultureEdit, resources.GetString("txtCultureEdit.ToolTip"))
        '
        'btnSwitchButton
        '
        resources.ApplyResources(Me.btnSwitchButton, "btnSwitchButton")
        Me.btnSwitchButton.Name = "btnSwitchButton"
        '
        'lblShowUICulture
        '
        resources.ApplyResources(Me.lblShowUICulture, "lblShowUICulture")
        Me.lblShowUICulture.Name = "lblShowUICulture"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.lblShowUICulture)
        Me.Controls.Add(Me.btnSwitchButton)
        Me.Controls.Add(Me.txtCultureEdit)
        Me.Name = "Form1"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

    Private Sub txtCultureEdit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCultureEdit.TextChanged

    End Sub
End Class
