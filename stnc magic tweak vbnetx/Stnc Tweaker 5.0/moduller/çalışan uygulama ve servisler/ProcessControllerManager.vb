
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ServiceProcess
Imports System.Diagnostics
Imports System.DirectoryServices

Namespace WindowsApplication1
    _

    '    Summary description for ProcessControllerManager.
    '	This class is used to handle all the processes on a machine
    Public Class ProcessControllerManager
        Private MachineName As String
        Private ListCurrent As ListBox = Nothing
        Private ListPcsRun, ListPcs As ListBox
        Private SelProcess As String = ""
        Private SelectProcess As Process
        Private Processes As New System.Collections.Hashtable()
        Private WatchDog As New System.Windows.Forms.Timer()

        'Clear all the collections
        Public Sub Clear()
            MachineName = ""
            If Not (ListPcsRun Is Nothing) Then
                ListPcsRun.Items.Clear()
                RemoveHandler ListPcsRun.SelectedIndexChanged, AddressOf Me.SelectedProcess
                RemoveHandler ListPcsRun.MouseDown, AddressOf Me.ListOptions
            End If

            If Not (ListPcs Is Nothing) Then
                ListPcs.Items.Clear()
                RemoveHandler ListPcs.SelectedIndexChanged, AddressOf Me.SelectedProcess
                RemoveHandler ListPcs.MouseDown, AddressOf Me.ListOptions
            End If

            Processes.Clear()
        End Sub 'Clear

        Public Sub New()

        End Sub 'New

        'Class explicit constructor
        Public Sub New(ByVal TempPcsRun As ListBox, ByVal TempPcs As ListBox, ByVal TempMachineName As String)
            MachineName = TempMachineName

            Processes.Clear()
            'Adding the events handlers to the controls
            ListPcs = TempPcs
            AddHandler ListPcs.SelectedIndexChanged, AddressOf Me.SelectedProcess
            AddHandler ListPcs.MouseDown, AddressOf Me.ListOptions
            ListPcsRun = TempPcsRun
            AddHandler ListPcsRun.SelectedIndexChanged, AddressOf Me.SelectedProcess
            AddHandler ListPcsRun.MouseDown, AddressOf Me.ListOptions

            LoadProcesses()
        End Sub 'New

        'Launch the selected process
        Public Sub StartProcess(ByVal ProcName As String)

            Dim TempProcess As New Process()
            AddHandler TempProcess.Exited, AddressOf Me.ProcessExited
            TempProcess.EnableRaisingEvents = True
            TempProcess.StartInfo.FileName = ProcName
            Try
                TempProcess.Start()
                While Not TempProcess.Responding
                    System.Windows.Forms.Application.DoEvents()
                End While
                LoadProcesses()
            Catch
            End Try
        End Sub 'StartProcess

        'Add/remove options from the popup menu
        Private Sub ListOptions(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            ListCurrent = CType(Sender, ListBox)
            If e.Button = System.Windows.Forms.MouseButtons.Right And ListCurrent.Equals(ListPcsRun) Then

                ListCurrent = CType(Sender, ListBox)

                ListCurrent.ContextMenu = New System.Windows.Forms.ContextMenu()

                If ListCurrent.Equals(ListPcs) Then
                    SelProcess = ListCurrent.SelectedItem.ToString()
                Else
                    ListCurrent.ContextMenu.MenuItems.Add(New System.Windows.Forms.MenuItem("&Terminate Process", New EventHandler(AddressOf Me.KillProcess)))
                End If
                ListCurrent.ContextMenu.Show(ListCurrent, New Point(e.X, e.Y))
            End If
        End Sub 'ListOptions

        'Try to stop a process
        Private Sub KillProcess(ByVal Sender As Object, ByVal e As EventArgs)
            Try
                Dim ProcName As String = ListCurrent.SelectedItem.ToString()

                If Not (SelectProcess Is Nothing) Then
                    Try
                        'Try to terminate the process
                        SelectProcess.Kill()
                        If Processes.Contains(SelectProcess.Id.ToString()) Then
                            Processes.Remove(SelectProcess.Id.ToString())
                            ListPcsRun.Items.Remove((SelectProcess.ProcessName + "  ID: " + SelectProcess.Id.ToString()))
                        End If
                    Catch
                    End Try
                End If
                ListPcs.Items.Clear()
            Catch
            End Try
        End Sub 'KillProcess

        'no listItem was selected
        'Fills up the Process Info list
        Private Sub ShowProcessInfo(ByVal Sender As Object, ByVal e As EventArgs)
            Dim Item As String = ListCurrent.SelectedItem.ToString()
            Dim Key As String = Item.Substring((Item.IndexOf("ID:") + 3)).Trim()

            Dim TempProcess As Process = Nothing
            If Key <> "" Then
                Try
                    TempProcess = Process.GetProcessById(Int32.Parse(Key), MachineName)
                Catch
                End Try

                ListPcs.Items.Clear()
                'Adding the Process info to the list
                Try

                    ListPcs.Items.Add(("Process Name: " + TempProcess.ProcessName))

                    ListPcs.Items.Add(("Arguments: " + TempProcess.StartInfo.Arguments))

                    ListPcs.Items.Add(("Running on: " + TempProcess.MachineName))
                    Try
                        ListPcs.Items.Add(("Main Window title: " + TempProcess.MainWindowTitle))
                    Catch
                    End Try

                    ListPcs.Items.Add(("Start Time: " + TempProcess.StartTime.ToString()))

                    ListPcs.Items.Add(("NonpagedSystemMemorySize: " + TempProcess.NonpagedSystemMemorySize.ToString()))
                    ListPcs.Items.Add(("PagedMemorySize: " + TempProcess.PagedMemorySize.ToString()))
                    ListPcs.Items.Add(("PrivateMemorySize: " + TempProcess.PrivateMemorySize.ToString()))
                    ListPcs.Items.Add(("PrivilegedProcessorTime: " + TempProcess.PrivilegedProcessorTime.ToString()))
                    ListPcs.Items.Add(("PeakPagedMemorySize: " + TempProcess.PeakPagedMemorySize.ToString()))
                    ListPcs.Items.Add(("PeakVirtualMemorySize: " + TempProcess.PeakVirtualMemorySize.ToString()))
                    ListPcs.Items.Add(("PeakPagedMemorySize: " + TempProcess.PeakPagedMemorySize.ToString()))
                    ListPcs.Items.Add(("PeakWorkingSet: " + TempProcess.PeakWorkingSet.ToString()))

                    Try
                        ListPcs.Items.Add(("PriorityClass: " + TempProcess.PriorityClass.ToString()))
                    Catch

                    End Try

                    Try
                        ListPcs.Items.Add(("BasePriority: " + TempProcess.BasePriority.ToString()))
                    Catch

                    End Try

                    Try
                        ListPcs.Items.Add(("ProcessorAffinity: " + TempProcess.ProcessorAffinity.ToString()))
                    Catch

                    End Try
                    ListPcs.Items.Add(("ID: " + TempProcess.Id))

                    ListPcs.Items.Add(("WorkingDirectory: " + TempProcess.StartInfo.WorkingDirectory))
                    ListPcs.Items.Add("")
                    ListPcs.Items.Add("********************* Modules in use by this process ***************** ")
                    ListPcs.Items.Add("")
                    Dim TempPM As System.Diagnostics.ProcessModule
                    For Each TempPM In TempProcess.Modules
                        Try
                            ListPcs.Items.Add(("Module Name: " + TempPM.FileName))
                        Catch
                        End Try
                    Next TempPM
                Catch
                End Try
            End If 'Some did not work
        End Sub 'ShowProcessInfo

        'Remove the process from the processes list
        Private Sub ProcessExited(ByVal Sender As Object, ByVal e As EventArgs)
            Dim TempProcess As Process = CType(Sender, Process)
            Processes.Remove(TempProcess.Id.ToString())
            ListPcsRun.Items.Remove((TempProcess.ProcessName + "  ID: " + TempProcess.Id.ToString()))
        End Sub 'ProcessExited

        'Check the selected process
        Private Sub SelectedProcess(ByVal Sender As Object, ByVal e As EventArgs)
            ListCurrent = CType(Sender, ListBox)
            SelProcess = ListCurrent.SelectedItem.ToString()
            If ListCurrent.Equals(ListPcsRun) Then
                Dim ProcessID As String = ListCurrent.SelectedItem.ToString()
                ProcessID = ProcessID.Substring((ProcessID.IndexOf("ID: ") + 4)).Trim()
                SelectProcess = CType(Processes(ProcessID), Process)
                ShowProcessInfo(Sender, e)
            End If
        End Sub 'SelectProcess

        'Load all the processes on the given machine
        Private Sub LoadProcesses()
            WatchDog.Enabled = False
            ListPcsRun.Items.Clear()
            Processes.Clear()
            Processes = New System.Collections.Hashtable()
            Try
                'Use the Static: GetProcesses to have the array of currently running processes.
                Dim ArrayProcess As Process() = Process.GetProcesses(MachineName)
                Dim TempProcess As Process
                For Each TempProcess In ArrayProcess
                    'Assign ProcessExited event to each process in the list
                    AddHandler TempProcess.Exited, AddressOf ProcessExited
                    If Not Processes.Contains(TempProcess.Id.ToString()) Then
                        ListPcsRun.Items.Add((TempProcess.ProcessName + "  ID: " + TempProcess.Id.ToString()))
                        Processes.Add(TempProcess.Id.ToString(), TempProcess)
                    End If
                Next TempProcess
            Catch
            End Try
            'Enable the RaisingEvents for each process
            Dim TempProcess2 As Process
            For Each TempProcess2 In Processes.Values
                Try
                    TempProcess2.EnableRaisingEvents = True
                Catch
                End Try
            Next TempProcess2
            WatchDog.Enabled = True
        End Sub 'LoadProcesses

    End Class 'ProcessControllerManager

End Namespace 'WindowsApplication1