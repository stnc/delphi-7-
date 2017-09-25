<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lstMultiSelect = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstSelected = New System.Windows.Forms.ListBox
        Me.lstSelectedItems = New System.Windows.Forms.ListBox
        Me.cboSelectionMode = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lstMultiSelect
        '
        Me.lstMultiSelect.FormattingEnabled = True
        Me.lstMultiSelect.Location = New System.Drawing.Point(30, 76)
        Me.lstMultiSelect.Name = "lstMultiSelect"
        Me.lstMultiSelect.Size = New System.Drawing.Size(222, 121)
        Me.lstMultiSelect.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstSelected
        '
        Me.lstSelected.FormattingEnabled = True
        Me.lstSelected.Location = New System.Drawing.Point(279, 42)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.Size = New System.Drawing.Size(120, 173)
        Me.lstSelected.TabIndex = 2
        '
        'lstSelectedItems
        '
        Me.lstSelectedItems.FormattingEnabled = True
        Me.lstSelectedItems.Location = New System.Drawing.Point(431, 43)
        Me.lstSelectedItems.Name = "lstSelectedItems"
        Me.lstSelectedItems.Size = New System.Drawing.Size(120, 173)
        Me.lstSelectedItems.TabIndex = 3
        '
        'cboSelectionMode
        '
        Me.cboSelectionMode.FormattingEnabled = True
        Me.cboSelectionMode.Location = New System.Drawing.Point(179, 233)
        Me.cboSelectionMode.Name = "cboSelectionMode"
        Me.cboSelectionMode.Size = New System.Drawing.Size(220, 21)
        Me.cboSelectionMode.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 266)
        Me.Controls.Add(Me.cboSelectionMode)
        Me.Controls.Add(Me.lstSelectedItems)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstMultiSelect)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstMultiSelect As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstSelected As System.Windows.Forms.ListBox
    Friend WithEvents lstSelectedItems As System.Windows.Forms.ListBox
    Friend WithEvents cboSelectionMode As System.Windows.Forms.ComboBox
End Class
