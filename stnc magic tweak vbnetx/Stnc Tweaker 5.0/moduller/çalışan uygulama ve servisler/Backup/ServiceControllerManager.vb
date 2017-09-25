
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ServiceProcess

Namespace WindowsApplication1
    _

    Public Class ServiceControllerManager
        'The machine under control
        Private MachineName As String

        'selected service display name
        Private DisplayName As String = ""

        'The listBoxes used to show Services data
        Private ListCurrent As ListBox = Nothing
        Private ListSrvRun, ListSrvStopped, ListSrvPaused As ListBox

        Public Sub New()
            'The default machine name
            MachineName = System.Environment.MachineName
        End Sub 'New

        Public Sub New(ByVal TempSrvRun As ListBox, ByVal TempSrvStopped As ListBox, ByVal TempSrvPaused As ListBox, ByVal TempMachineName As String)
            MachineName = TempMachineName

            'Add the right event handlers for the listboxes
            'Get the pointers to the ListBoxes from the MainForm UI.
            'Assign the correspondant EventHandlers
            ListSrvPaused = TempSrvPaused
            AddHandler ListSrvPaused.SelectedIndexChanged, AddressOf Me.lstSrv_SelectedIndexChanged
            AddHandler ListSrvPaused.MouseDown, AddressOf Me.lstSrv_MouseDown

            ListSrvStopped = TempSrvStopped
            AddHandler ListSrvStopped.SelectedIndexChanged, AddressOf Me.lstSrv_SelectedIndexChanged
            AddHandler ListSrvStopped.MouseDown, AddressOf Me.lstSrv_MouseDown

            ListSrvRun = TempSrvRun
            AddHandler ListSrvRun.SelectedIndexChanged, AddressOf Me.lstSrv_SelectedIndexChanged
            AddHandler ListSrvRun.MouseDown, AddressOf Me.lstSrv_MouseDown
            LoadServices()
        End Sub 'New

        ' Clear all the collections, arrays and eventhandlers
        Public Sub Clear()

            MachineName = ""
            DisplayName = ""

            If Not (ListSrvRun Is Nothing) Then
                'Clear the items in the list 
                'Remove the event handlers
                ListSrvRun.Items.Clear()
                RemoveHandler ListSrvRun.SelectedIndexChanged, AddressOf Me.lstSrv_SelectedIndexChanged
                RemoveHandler ListSrvRun.MouseDown, AddressOf Me.lstSrv_MouseDown
            End If
            If Not (ListSrvStopped Is Nothing) Then
                'Remove the event handlers
                ListSrvStopped.Items.Clear()
                RemoveHandler ListSrvStopped.SelectedIndexChanged, AddressOf Me.lstSrv_SelectedIndexChanged
                RemoveHandler ListSrvStopped.MouseDown, AddressOf Me.lstSrv_MouseDown
            End If
            If Not (ListSrvPaused Is Nothing) Then
                ListSrvPaused.Items.Clear()
                RemoveHandler ListSrvPaused.SelectedIndexChanged, AddressOf Me.lstSrv_SelectedIndexChanged
                RemoveHandler ListSrvPaused.MouseDown, AddressOf Me.lstSrv_MouseDown
            End If
        End Sub 'Clear

        ' Trap the name of the service selected by the user,
        ' as well as the listbox the selected listbox
        Public Sub lstSrv_SelectedIndexChanged(ByVal Sender As Object, ByVal e As System.EventArgs)

            ListCurrent = CType(Sender, ListBox)
            DisplayName = ListCurrent.SelectedItem.ToString()

        End Sub 'lstSrv_SelectedIndexChanged

        ' PopUp the context menu
        Public Sub lstSrv_MouseDown(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = System.Windows.Forms.MouseButtons.Right Then

                ListCurrent = CType(Sender, ListBox)
                'Create a new contextMenu
                ListCurrent.ContextMenu = New System.Windows.Forms.ContextMenu()

                'And add the needed MenuItems
                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("&Start Service", New EventHandler(AddressOf Me.MenuStart)))

                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("S&top Service", New EventHandler(AddressOf Me.MenuStop)))

                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("&Pause Service", New EventHandler(AddressOf Me.MenuPause)))

                ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("S&how Service Info", New EventHandler(AddressOf Me.ShowServiceInfo)))

                'check which menu should be active
                If ListCurrent.Equals(ListSrvRun) Then
                    ListCurrent.ContextMenu.MenuItems(0).Enabled = False
                Else
                    If ListCurrent.Equals(ListSrvStopped) Then
                        ListCurrent.ContextMenu.MenuItems(1).Enabled = False
                        ListCurrent.ContextMenu.MenuItems(2).Enabled = False
                    Else
                        ListCurrent.ContextMenu.MenuItems(2).Enabled = False
                    End If
                End If
                ListCurrent.ContextMenu.Show(ListCurrent, New Point(e.X, e.Y))
            End If
        End Sub 'lstSrv_MouseDown

        Private Sub MenuStart(ByVal Sender As Object, ByVal e As EventArgs)
            Dim TempSC As New System.ServiceProcess.ServiceController()
            TempSC.MachineName = MachineName
            TempSC.DisplayName = DisplayName
            Try
                'When a service is paused, it has to continue.
                'Start in this case is not possible.
                If ListCurrent.Equals(ListSrvPaused) Then
                    TempSC.Continue()
                Else
                    TempSC.Start()
                End If
                System.Threading.Thread.Sleep(500)
                'Loop while the service is pending the continue state
                While TempSC.Status = ServiceControllerStatus.ContinuePending
                    Application.DoEvents()
                End While
                'after starting the service, refresh the listBoxes
                If TempSC.Status = ServiceControllerStatus.Running Then
                    ListSrvRun.Items.Add(ListCurrent.SelectedItem.ToString())
                    ListCurrent.Items.Remove(ListCurrent.SelectedItem.ToString())
                    ListCurrent.Refresh()
                    ListSrvRun.Refresh()
                    'Perhaps it could not start...
                Else
                    MessageBox.Show(TempSC.ServiceName + " Cannot be started")
                End If
            Catch
                MessageBox.Show("Service: " + DisplayName + " Could not be started ! ")
            End Try
        End Sub 'MenuStart
        
        Private Sub MenuStop(ByVal Sender As Object, ByVal e As EventArgs)
            'Stop a service
            Dim TempSC As New System.ServiceProcess.ServiceController()
            TempSC.MachineName = MachineName
            TempSC.DisplayName = DisplayName
            Try
                If TempSC.CanStop Then
                    Try
                        TempSC.Stop()
                        System.Threading.Thread.Sleep(500)
                        While TempSC.Status = ServiceControllerStatus.StopPending
                            Application.DoEvents()
                        End While
                        ListSrvStopped.Items.Add(ListCurrent.SelectedItem.ToString())
                        ListCurrent.Items.Remove(ListCurrent.SelectedItem.ToString())
                        ListCurrent.Refresh()
                        ListSrvStopped.Refresh()
                    Catch
                        MessageBox.Show("The service: " + TempSC.DisplayName + " is not allowed to be stopped !")
                    End Try
                Else
                    MessageBox.Show("The service: " + TempSC.DisplayName + " is not allowed to be stopped !")
                End If
            Catch
            End Try
        End Sub 'MenuStop

        Private Sub MenuPause(ByVal Sender As Object, ByVal e As EventArgs)
            'Pause a service
            Dim TempSC As New System.ServiceProcess.ServiceController()
            TempSC.MachineName = MachineName
            TempSC.DisplayName = DisplayName
            Try
                'And refresh the listBoxes
                TempSC.Pause()
                ListSrvPaused.Items.Add(ListCurrent.SelectedItem.ToString())
                ListCurrent.Items.Remove(ListCurrent.SelectedItem.ToString())
                ListCurrent.Refresh()
                ListSrvPaused.Refresh()
            Catch
                MessageBox.Show("Service: " + DisplayName + " Could not be paused !")
            End Try
        End Sub 'MenuPause

        'or may be not possible to stop the service...
        ' Load all services on the machine
        Public Sub LoadServices()
            If Not MachineName.Equals("") Then
                Dim ArraySrvCtrl() As ServiceController
                Try
                    'That's enough to get all the services running on the machine
                    ArraySrvCtrl = ServiceController.GetServices(MachineName)
                    'Clear all the collections
                    ListSrvRun.Items.Clear()
                    ListSrvPaused.Items.Clear()
                    ListSrvStopped.Items.Clear()

                    'Fill up all the listBoxes
                    Dim TempSC As ServiceController
                    For Each TempSC In ArraySrvCtrl
                        If TempSC.Status = ServiceControllerStatus.Running Then
                            ListSrvRun.Items.Add(TempSC.DisplayName)

                        Else
                            If TempSC.Status = ServiceControllerStatus.Paused Then
                                ListSrvPaused.Items.Add(TempSC.DisplayName)
                            Else
                                ListSrvStopped.Items.Add(TempSC.DisplayName)
                            End If
                        End If
                    Next TempSC 'Sort them alphabeticaly

                    ListSrvPaused.Sorted = True
                    ListSrvRun.Sorted = True
                    ListSrvStopped.Sorted = True
                Catch

                End Try
            End If
        End Sub 'LoadServices

        ' Show the process info window
        Public Sub ShowServiceInfo(ByVal Sender As Object, ByVal e As EventArgs)
            Dim TempSC As System.ServiceProcess.ServiceController
            TempSC = New System.ServiceProcess.ServiceController()
            TempSC.MachineName = MachineName
            TempSC.DisplayName = DisplayName
            Dim Si As New ServiceInfo(TempSC)
            Si.Show()
        End Sub 'ShowServiceInfo

    End Class 'ServiceControllerManager

End Namespace 'WindowsApplication1