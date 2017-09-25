
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ServiceProcess

Namespace WindowsApplication1
    _
    '    Summary description for DriverControllerManager.
    '    This class is used to handle the device drivers 
    Public Class DriverControllerManager

        'machine under test
        Private MachineName As String
        'The display name of the selected driver
        Private DisplayName As String = ""
        'the listBoxes used to show the drivers
        Private ListCurrent As ListBox = Nothing
        Private ListDrvRun, ListDrvStopped, ListDrvPaused As ListBox

        Public Sub New()
        End Sub 'New

        Public Sub New(ByVal TempDrvRun As ListBox, ByVal TempDrvStopped As ListBox, ByVal TempDrvPaused As ListBox, ByVal TempMachineName As String)
            MachineName = TempMachineName

            'Get the pointers to the ListBoxes from the MainForm UI.
            'Assign the correspondant EventHandlers
            ListDrvPaused = TempDrvPaused
            AddHandler ListDrvPaused.SelectedIndexChanged, AddressOf Me.lstDrv_SelectedIndexChanged
            AddHandler ListDrvPaused.MouseDown, AddressOf Me.lstDrv_MouseDown

            ListDrvStopped = TempDrvStopped
            AddHandler ListDrvStopped.SelectedIndexChanged, AddressOf Me.lstDrv_SelectedIndexChanged
            AddHandler ListDrvStopped.MouseDown, AddressOf Me.lstDrv_MouseDown

            ListDrvRun = TempDrvRun
            AddHandler ListDrvRun.SelectedIndexChanged, AddressOf Me.lstDrv_SelectedIndexChanged
            AddHandler ListDrvRun.MouseDown, AddressOf Me.lstDrv_MouseDown

            LoadDrivers()
        End Sub 'New

        ' Clear all the object collections
        Public Sub Clear()
            MachineName = ""
            DisplayName = ""
            If Not (ListDrvRun Is Nothing) Then
                ListDrvRun.Items.Clear()
                RemoveHandler ListDrvRun.SelectedIndexChanged, AddressOf Me.lstDrv_SelectedIndexChanged
                RemoveHandler ListDrvRun.MouseDown, AddressOf Me.lstDrv_MouseDown
            End If
            If Not (ListDrvStopped Is Nothing) Then
                ListDrvStopped.Items.Clear()
                RemoveHandler ListDrvStopped.SelectedIndexChanged, AddressOf Me.lstDrv_SelectedIndexChanged
                RemoveHandler ListDrvStopped.MouseDown, AddressOf Me.lstDrv_MouseDown
            End If
            If Not (ListDrvPaused Is Nothing) Then
                ListDrvPaused.Items.Clear()
                RemoveHandler ListDrvPaused.SelectedIndexChanged, AddressOf Me.lstDrv_SelectedIndexChanged
                RemoveHandler ListDrvPaused.MouseDown, AddressOf Me.lstDrv_MouseDown
            End If
        End Sub 'Clear

        ' event handler for all the ListBoxes
        ' Used to catch the name of the selected Driver
        Public Sub lstDrv_SelectedIndexChanged(ByVal Sender As Object, ByVal e As System.EventArgs)
            ListCurrent = CType(Sender, ListBox)
            DisplayName = ListCurrent.SelectedItem.ToString()
        End Sub 'lstDrv_SelectedIndexChanged

        ' event corresponding to the ListBox/mouseDown
        ' Used to PopUp the ContextMenu with its options
        Public Sub lstDrv_MouseDown(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                ListCurrent = CType(Sender, ListBox)
                'Create a new context menu
                ListCurrent.ContextMenu = New System.Windows.Forms.ContextMenu()
                'Insert the needed menuItems
                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("&Start Service", New EventHandler(AddressOf Me.MenuStart)))
                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("S&top Service", New EventHandler(AddressOf Me.MenuStop)))
                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("&Pause Service", New EventHandler(AddressOf Me.MenuPause)))
                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("S&how Driver Info", New EventHandler(AddressOf Me.ShowDriverInfo)))
                'Enable/Disable the right MenuItems depending on the selected display
                If ListCurrent.Equals(ListDrvRun) Then
                    ListCurrent.ContextMenu.MenuItems(0).Enabled = False
                Else
                    If ListCurrent.Equals(ListDrvStopped) Then
                        ListCurrent.ContextMenu.MenuItems(1).Enabled = False
                        ListCurrent.ContextMenu.MenuItems(2).Enabled = False
                    Else
                        ListCurrent.ContextMenu.MenuItems(2).Enabled = False
                    End If
                End If
                ListCurrent.ContextMenu.Show(ListCurrent, New Point(e.X, e.Y))
            End If
        End Sub 'lstDrv_MouseDown

        'The event assigned to Start driver MenuItem
        Private Sub MenuStart(ByVal Sender As Object, ByVal e As EventArgs)

            Dim TempServiceController As System.ServiceProcess.ServiceController
            TempServiceController = New System.ServiceProcess.ServiceController()
            TempServiceController.MachineName = MachineName
            TempServiceController.DisplayName = DisplayName
            Try
                If ListCurrent.Equals(ListDrvPaused) Then
                    TempServiceController.[Continue]()
                Else
                    TempServiceController.Start()
                End If
                'wait for the process to restart
                System.Threading.Thread.Sleep(500)
                While TempServiceController.Status = ServiceControllerStatus.ContinuePending
                    Application.DoEvents()
                End While
                If TempServiceController.Status = ServiceControllerStatus.Running Then
                    ListDrvRun.Items.Add(ListCurrent.SelectedItem.ToString())
                    ListCurrent.Items.Remove(ListCurrent.SelectedItem.ToString())
                    ListCurrent.Refresh()
                    ListDrvRun.Refresh()
                Else
                    MessageBox.Show(TempServiceController.ServiceName + " Cannot be started")
                End If
            Catch
                MessageBox.Show("Service: " + TempServiceController.ServiceName + " Could not be started ! ")
            End Try
        End Sub 'MenuStart

        'Try to stop a service.
        Private Sub MenuStop(ByVal Sender As Object, ByVal e As EventArgs)

            Dim TempServiceController As System.ServiceProcess.ServiceController
            TempServiceController = New System.ServiceProcess.ServiceController()
            TempServiceController.MachineName = MachineName
            TempServiceController.DisplayName = DisplayName
            Try
                If TempServiceController.CanStop Then
                    Try
                        TempServiceController.Stop()
                        System.Threading.Thread.Sleep(500)
                        'wait for the service to stop
                        While TempServiceController.Status = ServiceControllerStatus.StopPending
                            Application.DoEvents()
                        End While
                        ListDrvStopped.Items.Add(ListCurrent.SelectedItem.ToString())
                        ListCurrent.Items.Remove(ListCurrent.SelectedItem.ToString())
                        ListCurrent.Refresh()
                        ListDrvStopped.Refresh()
                    Catch
                        MessageBox.Show("The service: " + TempServiceController.DisplayName + " is not allowed to be stopped !")
                    End Try
                Else
                    MessageBox.Show("The service: " + TempServiceController.DisplayName + " is not allowed to be stopped !")
                End If
            Catch
            End Try
        End Sub 'MenuStop

        Private Sub MenuPause(ByVal Sender As Object, ByVal e As EventArgs)
            Dim TempServiceController As System.ServiceProcess.ServiceController
            TempServiceController = New System.ServiceProcess.ServiceController()
            TempServiceController.MachineName = MachineName
            TempServiceController.DisplayName = DisplayName
            Try
                TempServiceController.Pause()
                System.Threading.Thread.Sleep(500)
                'wait for the service to pause
                While TempServiceController.Status = ServiceControllerStatus.PausePending
                    Application.DoEvents()
                End While
                ListDrvPaused.Items.Add(ListCurrent.SelectedItem.ToString())
                ListCurrent.Items.Remove(ListCurrent.SelectedIndex)
                ListCurrent.Refresh()
                ListDrvPaused.Refresh()
            Catch
                MessageBox.Show("Service: " + DisplayName + " Could not be paused !")
            End Try
        End Sub 'MenuPause

        'Load all the drivers on the given machine
        Public Sub LoadDrivers()
            If Not MachineName.Equals("") Then
                Dim DriverCtrl() As ServiceController
                Try
                    'Get an array with all the devices on the machine
                    DriverCtrl = ServiceController.GetDevices(MachineName)
                    Dim TempString(DriverCtrl.GetUpperBound(0)) As String
                    Dim LoopIndex As Integer
                    For LoopIndex = 0 To (DriverCtrl.GetUpperBound(0)) - 1
                        TempString(LoopIndex + 1) = DriverCtrl(LoopIndex).ServiceName
                    Next LoopIndex
                    'Sort them by name
                    System.Array.Sort(TempString, DriverCtrl, 0, DriverCtrl.GetUpperBound(0))

                    ListDrvRun.Items.Clear()
                    ListDrvPaused.Items.Clear()
                    ListDrvStopped.Items.Clear()

                    'Check the status for each service/device
                    Dim TempServiceController As ServiceController
                    For Each TempServiceController In DriverCtrl
                        If TempServiceController.Status = ServiceControllerStatus.Running Then
                            ListDrvRun.Items.Add(TempServiceController.DisplayName)
                        Else
                            If TempServiceController.Status = ServiceControllerStatus.Paused Then
                                ListDrvPaused.Items.Add(TempServiceController.DisplayName)
                            Else
                                ListDrvStopped.Items.Add(TempServiceController.DisplayName)
                            End If
                        End If
                    Next TempServiceController
                    ListDrvPaused.Sorted = True
                    ListDrvRun.Sorted = True
                    ListDrvStopped.Sorted = True

                Catch Ex As Exception
                    MessageBox.Show(Ex.ToString())
                End Try
            End If
        End Sub 'LoadDrivers

        'Used to show the device info
        Public Sub ShowDriverInfo(ByVal Sender As Object, ByVal e As EventArgs)
            Dim TempServiceController As System.ServiceProcess.ServiceController
            TempServiceController = New System.ServiceProcess.ServiceController()
            TempServiceController.MachineName = MachineName
            TempServiceController.DisplayName = DisplayName
            Dim SrvInfo As New ServiceInfo(TempServiceController)
            SrvInfo.Show()
        End Sub 'ShowDriverInfo

    End Class 'DriverControllerManager

End Namespace 'WindowsApplication1