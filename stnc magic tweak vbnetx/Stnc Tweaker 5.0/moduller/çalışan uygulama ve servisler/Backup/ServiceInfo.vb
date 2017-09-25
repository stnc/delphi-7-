
'This Form is only used to show services or drivers properties
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace WindowsApplication1
    _


    '    Summary description for ServiceInfo.
    '	  Show some service's properties
    Public Class ServiceInfo
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
        '    Required designer variable
        Private components As System.ComponentModel.Container
        Friend WithEvents ButtonClose As System.Windows.Forms.Button
        Friend WithEvents ListInfo As System.Windows.Forms.ListBox

        'Explicit constructor
        Public Sub New(ByVal TempServCtrl As System.ServiceProcess.ServiceController)

            InitializeComponent()
            ShowInfo(TempServCtrl)

        End Sub 'New


        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        '    Required method for Designer support - do not modify
        '    the contents of this method with the code editor
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ButtonClose = New System.Windows.Forms.Button()
            Me.ListInfo = New System.Windows.Forms.ListBox()
            '@design Me.TrayHeight = 0
            '@design Me.TrayLargeIcon = False
            '@design Me.TrayAutoArrange = True
            Me.Text = "ServiceInfo"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(672, 517)
            ButtonClose.Location = New System.Drawing.Point(280, 464)
            ButtonClose.Size = New System.Drawing.Size(112, 24)
            ButtonClose.TabIndex = 1
            ButtonClose.Text = "Close"
            ListInfo.Location = New System.Drawing.Point(8, 8)
            ListInfo.Size = New System.Drawing.Size(656, 429)
            ListInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold)
            ListInfo.TabIndex = 0
            Me.Controls.Add(ButtonClose)
            Me.Controls.Add(ListInfo)
        End Sub 'InitializeComponent
#End Region

        Protected Sub ButtonClose_Click(ByVal Sender As Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
            Me.Close()
        End Sub 'ButtonClose_Click

        'Get some Service Info
        Private Sub ShowInfo(ByVal TempSrvCtrl As System.ServiceProcess.ServiceController)
            Try
                ListInfo.Items.Add(("ServiceName: " + TempSrvCtrl.ServiceName))
                ListInfo.Items.Add(("Service Status: " + TempSrvCtrl.Status.ToString()))
                ListInfo.Items.Add(("DisplayName: " + TempSrvCtrl.DisplayName))
                ListInfo.Items.Add(("MachineName: " + TempSrvCtrl.MachineName))
                ListInfo.Items.Add(("CanPauseAndContinue: " + TempSrvCtrl.CanPauseAndContinue.ToString()))
                ListInfo.Items.Add(("CanShutdown: " + TempSrvCtrl.CanShutdown.ToString()))
                ListInfo.Items.Add("*************** Dependent Services ********************")
                'Check for the Dependent services (if any)
                Dim ServerProcess As System.ServiceProcess.ServiceController
                For Each ServerProcess In TempSrvCtrl.DependentServices
                    ListInfo.Items.Add((ServerProcess.ServiceName + " is " + ServerProcess.Status.ToString()))
                Next ServerProcess

            Catch

            End Try
        End Sub 'ShowInfo

    End Class 'ServiceInfo

End Namespace 'WindowsApplication1