Imports Gma.System.MouseKeyHook     ' Credits to: https://github.com/gmamaladze/globalmousekeyhook  (added as NuGet Package)
Imports YatoOverlay                 ' Credits to: https://github.com/YatoDev/Yato.DirectXOverlay

Public Class FrmMain

#Region "Variables"

    ''' <summary>
    ''' File where we save and gets the Tool settings. This file is located on the same path as tool .exe
    ''' </summary>
    Private Const SETTINGS_FILE As String = "settings.xml"

    ''' <summary>
    ''' tool settings are stored here. We Serialize and deserialize this object into <see cref="SETTINGS_FILE"/>
    ''' </summary>
    Private _mySettings As Settings

    ''' <summary>
    ''' For hooking the CTRL + A keypress and mouse position 
    ''' </summary>
    Private m_GlobalHook As IKeyboardMouseEvents

    ' Overlay Objects -----------------------------------------------------------------------------
    Private manager As OverlayManager
    Private overlay As OverlayWindow
    ''' <summary>
    ''' Direct2Renderer for the overlay
    ''' </summary>
    Private d2d As Direct2DRenderer
    ' ---------------------------------------------------------------------------------------------

    ''' <summary>
    ''' Flag to know if we are in AutoMode
    ''' </summary>
    Private bAutoModeOn As Boolean = False

    ''' <summary>
    ''' Flag for detect we are pressing CTRL + A
    ''' </summary>
    Private bFlag As Boolean

    ''' <summary>
    ''' Time we use for avoid 'spaming' CTRL + C (copy) 
    ''' </summary>
    Private cbStart As DateTime?

    Private bFlagCB As Boolean

    Protected Enum eSocketColors
        White = 0
        Red
        Green
        Blue
    End Enum

    Private Class PoE_Item
        'Public Property Name As String
        'Public Property ItemLvl As Integer
        'Public Property BaseType As PoEBaseTypeItems
        Public Sockets As List(Of eSocketColors)

        Public Function SocketChar(color As eSocketColors) As String
            Select Case color
                Case eSocketColors.Blue
                    Return "B"
                Case eSocketColors.Green
                    Return "G"
                Case eSocketColors.Red
                    Return "R"
                Case Else ' white
                    Return "W"
            End Select
        End Function

        Public Sub New()
            Sockets = New List(Of eSocketColors)()
        End Sub
    End Class

    ''' <summary>
    ''' Item info we get after parsing the clipboard
    ''' </summary>
    Private _myPoE_Item As PoE_Item

#End Region

#Region "Constructor (Entry Point)"

    Public Sub New()
        InitializeComponent()

        Me.Icon = My.Resources.AppIcon
        Me.Text = "Path of Exile :: QoL colorblind tool"

        Try
            ' Settings initialization -------------------------------------------------------------
            If (IO.File.Exists(SETTINGS_FILE)) Then
                ' Gets the settings from the settings.xml file (stored on the same path as the assembly)
                _mySettings = Helpers.XMLserialization.Deserialize(Of Settings)(SETTINGS_FILE)
            Else ' No settings file found. Maybe first run?
                ' Create new settings with default values:
                _mySettings = New Settings()

                Dim _copySettings = Helpers.Utils.GeorgeClooneyObject(_mySettings)

                ' Show options Window 
                Dim f As FrmSettings = New FrmSettings(_copySettings)
                If (f.ShowDialog() = DialogResult.OK) Then ' We clicked "SAVE" on Options Window
                    Try
                        ' Save the settings to the file:
                        Helpers.XMLserialization.Serialize(SETTINGS_FILE, f._newSettings)
                        _mySettings = Helpers.Utils.GeorgeClooneyObject(f._newSettings)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End
                    End Try
                Else ' if we clicked "CLOSE" on Options window with no settings file found -> Ends the Tool
                    End
                End If
            End If

            ' Tool Initialization -----------------------------------------------------------------
            Dim poeProcess = Process.GetProcessesByName(_mySettings.PathOfExileProcess).FirstOrDefault()

            If (Not IsNothing(poeProcess)) Then
                ' Setup YatoOverlay stuff
                Dim rendererOptions = New Direct2DRendererOptions() With {.AntiAliasing = True, .Hwnd = IntPtr.Zero, .MeasureFps = False, .VSync = False}
                manager = New OverlayManager(poeProcess.MainWindowHandle, rendererOptions)
                overlay = manager.Window
                d2d = manager.Graphics

                ' Setup hook for CTRL + A and mouse
                HookSubscribe()
            Else
                Dim bShowWarning As Boolean = True
                If (Not _mySettings.PoEMustBeRunning) Then
                    Threading.Thread.Sleep(_mySettings.ProcessNotRunningTimeOut_seconds * 1000)

                    poeProcess = Process.GetProcessesByName(_mySettings.PathOfExileProcess).FirstOrDefault()

                    If (Not IsNothing(poeProcess)) Then
                        ' Setup YatoOverlay stuff
                        Dim rendererOptions = New Direct2DRendererOptions() With {.AntiAliasing = True, .Hwnd = IntPtr.Zero, .MeasureFps = False, .VSync = False}
                        manager = New OverlayManager(poeProcess.MainWindowHandle, rendererOptions)
                        overlay = manager.Window
                        d2d = manager.Graphics

                        ' Setup hook for CTRL + A and mouse
                        HookSubscribe()

                        bShowWarning = False
                    End If
                End If

                If (bShowWarning) Then
                    MessageBox.Show($"{_mySettings.PathOfExileProcess} not found. Path of Exile is running bro?!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim _copySettings = Helpers.Utils.GeorgeClooneyObject(_mySettings)
                    Dim f As FrmSettings = New FrmSettings(_copySettings)

                    If (f.ShowDialog() = DialogResult.OK) Then
                        Try
                            Helpers.XMLserialization.Serialize(SETTINGS_FILE, f._newSettings)
                            _mySettings = Helpers.Utils.GeorgeClooneyObject(f._newSettings)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                    End
                End If
            End If

            AddHandler PicChkBoxAutoMode.MouseEnter, AddressOf OnCursorChangeOnMouse_Enter
            AddHandler LblThreadPost.MouseEnter, AddressOf OnCursorChangeOnMouse_Enter
            AddHandler lblNewVersionAvailable.MouseEnter, AddressOf OnCursorChangeOnMouse_Enter

            AddHandler PicChkBoxAutoMode.MouseLeave, AddressOf OnCursorChangeOnMouse_Leave
            AddHandler LblThreadPost.MouseLeave, AddressOf OnCursorChangeOnMouse_Leave
            AddHandler lblNewVersionAvailable.MouseLeave, AddressOf OnCursorChangeOnMouse_Leave


            Me.BackgroundImage = My.Resources.backgroundMainQoL

            lblVersion.Text = $"version: {Application.ProductVersion}"

            If (_mySettings.CheckForNewReleases) Then
                CheckForNewVersion()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "FormClosing event"

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        bPoeItemProcessed = True

        HookUnsubscribe()

        d2d.Dispose()
        manager = Nothing
        overlay = Nothing

        TimerClipboard.Enabled = False
        TimerAutoMode.Enabled = False
    End Sub

#End Region

#Region "Move or drag Form with BorderStyle = None"

    ' Yes i know, here we could used some fancy WndProc trick with P/Invoke API calls, but
    ' this time we used .NET and forms events

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub FrmMain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FrmMain_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub FrmMain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

#End Region

#Region "Check for new versions available"

    Private Async Sub CheckForNewVersion()
        Dim url = "https://raw.githubusercontent.com/kernelENREK/PoE_colorBlind/master/PoE_colorBlind/My%20Project/AssemblyInfo.vb"

        Try
            Await RequestForNewAvailableVersion(url, Sub(asmInfo)
                                                         Dim data As String() = asmInfo.Split(vbLf)

                                                         For Each line In data
                                                             If (line.Trim.StartsWith("<Assembly: AssemblyVersion(")) Then
                                                                 Try
                                                                     Dim gitHub = line.Trim.Replace("<Assembly: AssemblyVersion(""", String.Empty)
                                                                     gitHub = gitHub.Replace(""")>", String.Empty)

                                                                     Dim gitHubVersion As Version = New Version(gitHub)
                                                                     Dim currentVersion As Version = New Version(Application.ProductVersion)

                                                                     Dim result = gitHubVersion.CompareTo(currentVersion)

                                                                     If (result > 0) Then
                                                                         lblNewVersionAvailable.Text = $"New version available: {gitHub}"
                                                                         lblNewVersionAvailable.Visible = True
                                                                     End If
                                                                 Catch ex As Exception
                                                                 End Try

                                                                 Exit For
                                                             End If

                                                         Next
                                                     End Sub)

        Catch ex As Exception
            MessageBox.Show($"CheckForNewVersion(): {ex.Message}{vbCrLf}{vbCrLf}url: {url} ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function RequestForNewAvailableVersion(url As String, action As Action(Of String)) As Task
        Try
            Using wc As Net.WebClient = New Net.WebClient()
                wc.Proxy = Nothing
                Dim s = Await wc.DownloadStringTaskAsync(url)
                action(s)
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

#Region "HOOK Stuff"

    Private Sub HookSubscribe()
        m_GlobalHook = Hook.GlobalEvents()
        AddHandler m_GlobalHook.KeyDown, AddressOf GlobalHookKeyDown
        AddHandler m_GlobalHook.KeyUp, AddressOf GlobalHookKeyUp
        AddHandler m_GlobalHook.MouseMove, AddressOf GlobalHookMouseMove
    End Sub

    Private Sub HookUnsubscribe()
        m_GlobalHook.Dispose()
    End Sub

    Private Sub GlobalHookKeyDown(sender As Object, e As KeyEventArgs)
        'Debug.Print($"GlobalHookKeyDown() KeyCode:{e.KeyCode} Modifiers:{e.Modifiers}")
        If (e.KeyCode = Keys.A And e.Modifiers = Keys.Control) Then
            If (Not bFlag) Then
                bFlag = True
                dbg_CTRL_A_Hold.Text = "ON"
                CBrun()
            End If
        End If
    End Sub

    Private Sub GlobalHookKeyUp(sender As Object, e As KeyEventArgs)
        If (e.KeyCode = Keys.A And bFlag) Then
            bFlag = False
            dbg_CTRL_A_Hold.Text = "OFF"
            cbStart = Nothing
            bPoeItemProcessed = False
            TimerClipboard.Enabled = False

            DoOverLay(True)
        End If
    End Sub

    Private Sub GlobalHookMouseMove(sender As Object, e As MouseEventArgs)
        Dim p As Point
        p.X = e.X
        p.Y = e.Y

        MouseCoords.Coordinates = p

        If (bAutoModeOn) Then
            Dim sctk1X As Integer = _mySettings.Layout.S1(0).X
            Dim sctk1Y As Integer = _mySettings.Layout.S1(0).Y

            Dim mouseRect As Rectangle = New Rectangle(e.X, e.Y, 1, 1)

            Dim rectAutoMode As Rectangle = New Rectangle(sctk1X - 50, sctk1Y - 100, 100, 200)
            Dim bMouseInRect As Boolean = mouseRect.IntersectsWith(rectAutoMode)

            dbg_RectAutomode.Text = bMouseInRect

            If (bMouseInRect) Then
                If (Not TimerAutoMode.Enabled) Then
                    bautoModeTick = False
                    TimerAutoMode.Interval = _mySettings.AutomodePollTime_ms
                    TimerAutoMode.Enabled = True
                End If
            Else
                TimerAutoMode.Enabled = False
            End If
        End If
    End Sub

#End Region

#Region "Send CTRL + C and parse the clipboard content"

    Private Sub CBrun()
        If (cbStart Is Nothing) Then
            Debug.Print("----------------------- C-B-run-------------")
            _myPoE_Item = New PoE_Item()

            cbStart = Now
            SendKeys.SendWait("^c")

            TimerClipboard.Interval = 250
            TimerClipboard.Enabled = True

            Do
                Application.DoEvents()
            Loop Until bPoeItemProcessed

            Debug.Print($"-------- _myPoE_Item.Sockets.Count: {_myPoE_Item.Sockets.Count}")
            If (_myPoE_Item.Sockets.Count > 0) Then
                DoOverLay(False)
            Else
                DoOverLay(True)
            End If

        End If
    End Sub

    Private bPoeItemProcessed As Boolean

    Private Sub TimerClipboard_Tick(sender As Object, e As EventArgs) Handles TimerClipboard.Tick
        Dim c = Clipboard.GetText()

        If (Not String.IsNullOrWhiteSpace(c)) Then
            ParseClipBoard(c)
            TimerClipboard.Enabled = False
            bPoeItemProcessed = True
            bautoModeTick = False
        Else
            Dim l = DateDiff(DateInterval.Second, cbStart.Value, Now)
            If (l > 3) Then
                Debug.Print("-------------TIME OUT------------------- TimerClipboard")
                TimerClipboard.Enabled = False
                bPoeItemProcessed = True
                bautoModeTick = False
            End If
        End If
    End Sub

    Private Sub ParseClipBoard(cbContent As String)
        dbg_TxtItemInfo.Text = String.Empty
        dbg_TxtItemInfo.Text = cbContent

        Dim itemInfoData As String() = cbContent.Split(vbCrLf)

        For Each line In itemInfoData
            Dim d = line.Replace(vbLf, "")
            If (d.ToLower.StartsWith("sockets:")) Then
                Dim sck = d.ToLower.Replace("sockets:", "").Trim.ToUpper() ' Here we get R-R G B-B-B
                sck = sck.Replace("-", "").Replace(" ", "") ' Here we get RRGBBB

                For i As Integer = 0 To sck.Length - 1
                    Dim c = sck.Substring(i, 1)
                    Select Case c.ToUpper
                        Case "W"
                            _myPoE_Item.Sockets.Add(eSocketColors.White)
                        Case "R"
                            _myPoE_Item.Sockets.Add(eSocketColors.Red)
                        Case "G"
                            _myPoE_Item.Sockets.Add(eSocketColors.Green)
                        Case "B"
                            _myPoE_Item.Sockets.Add(eSocketColors.Blue)
                    End Select
                Next
            End If
        Next
    End Sub

#End Region

#Region "AutoMode"

    Private bautoModeTick As Boolean

    Private Sub TimerAutoMode_Tick(sender As Object, e As EventArgs) Handles TimerAutoMode.Tick
        If (Not bautoModeTick) Then
            bautoModeTick = True
            cbStart = Nothing
            bPoeItemProcessed = False
            TimerClipboard.Enabled = False

            CBrun()
        End If
    End Sub

#End Region

#Region "Hover effects ans picturebox images"

    Private Sub PicOptions_MouseEnter(sender As Object, e As EventArgs) Handles PicOptions.MouseEnter
        PicOptions.Image = My.Resources.OptionsLight
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PicOptions_MouseLeave(sender As Object, e As EventArgs) Handles PicOptions.MouseLeave
        PicOptions.Image = My.Resources.OptionsDark
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PicClosing_MouseEnter(sender As Object, e As EventArgs) Handles PicClosing.MouseEnter
        Me.Cursor = Cursors.Hand
        PicClosing.Image = My.Resources.ClosingLight
    End Sub

    Private Sub PicClosing_MouseLeave(sender As Object, e As EventArgs) Handles PicClosing.MouseLeave
        Me.Cursor = Cursors.Default
        PicClosing.Image = My.Resources.ClosingDark
    End Sub

    Private Sub OnCursorChangeOnMouse_Enter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub OnCursorChangeOnMouse_Leave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "UI: Go to Options window, enable/disable automode, click on version labels (open default Web browser)"

    Private Sub PicOptions_Click(sender As Object, e As EventArgs) Handles PicOptions.Click
        Dim _copySettings = Helpers.Utils.GeorgeClooneyObject(_mySettings)
        Dim f As FrmSettings = New FrmSettings(_copySettings)
        If (f.ShowDialog() = DialogResult.OK) Then
            Try
                Helpers.XMLserialization.Serialize(SETTINGS_FILE, f._newSettings)
                _mySettings = Helpers.Utils.GeorgeClooneyObject(f._newSettings)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub PicChkBoxAutoMode_Click(sender As Object, e As EventArgs) Handles PicChkBoxAutoMode.Click
        bAutoModeOn = Not bAutoModeOn

        If (bAutoModeOn) Then
            PicChkBoxAutoMode.Image = My.Resources.Checked
        Else
            PicChkBoxAutoMode.Image = My.Resources.UnChecked
        End If

        bautoModeTick = False
        If (bAutoModeOn) Then
            CBrun()
        Else
            bFlag = False
            dbg_CTRL_A_Hold.Text = "OFF"
            cbStart = Nothing
            bPoeItemProcessed = False
            TimerClipboard.Enabled = False

            DoOverLay(True)
        End If
    End Sub

    Private Sub LblThreadPost_Click(sender As Object, e As EventArgs) Handles LblThreadPost.Click
        Try
            Process.Start(LblThreadPost.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblNewVersionAvailable_Click(sender As Object, e As EventArgs) Handles lblNewVersionAvailable.Click
        Try
            Process.Start("https://github.com/kernelENREK/PoE_colorBlind/releases")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PicClosing_Click(sender As Object, e As EventArgs) Handles PicClosing.Click
        Me.Close()
    End Sub

#End Region

#Region " --- OVERLAY ---"

    Private Sub DrawOverlay(positions As List(Of SettingsModels.SocketPosition), render As Direct2DRenderer, circleBrush As Direct2DBrush, font As Direct2DFont, fontBrush As Direct2DBrush)
        Dim index As Integer = 0
        For Each position In positions
            render.FillCircle(position.X, position.Y, _mySettings.Layout.Radius, circleBrush)
            Dim colorChar = _myPoE_Item.SocketChar(_myPoE_Item.Sockets(index))
            render.DrawText(colorChar, position.X - _mySettings.Layout.CharOffsetX, position.Y - _mySettings.Layout.CharOffsetY, font, fontBrush)

            index += 1
        Next
    End Sub

    Private Sub DoOverLay(clear As Boolean)
        Debug.Print($"{Now}: ************************** DoOverLay()")

        Dim clearColor = d2d.CreateBrush(0, 0, 0, 0) ' Fully transparent

        d2d.BeginScene()
        d2d.ClearScene(clearColor)

        If (Not clear) Then
            Dim font = d2d.CreateFont("Consolas", _mySettings.Layout.FontSize)
            Dim circleBrush = d2d.CreateBrush(255, 255, 255, 192)
            Dim fontBrush = d2d.CreateBrush(0, 0, 0, 255)

            Select Case _myPoE_Item.Sockets.Count
                Case 1
                    DrawOverlay(_mySettings.Layout.S1, d2d, circleBrush, font, fontBrush)
                Case 2
                    If (_mySettings.S2_Vertical_Default) Then
                        DrawOverlay(_mySettings.Layout.S2_Vertical, d2d, circleBrush, font, fontBrush)
                    Else
                        DrawOverlay(_mySettings.Layout.S2_Horizontal, d2d, circleBrush, font, fontBrush)
                    End If
                Case 3
                    If (_mySettings.S3_Vertical_Default) Then
                        DrawOverlay(_mySettings.Layout.S3_Vertical, d2d, circleBrush, font, fontBrush)
                    Else
                        DrawOverlay(_mySettings.Layout.S3_L, d2d, circleBrush, font, fontBrush)
                    End If
                Case 4
                    DrawOverlay(_mySettings.Layout.S4, d2d, circleBrush, font, fontBrush)
                Case 5
                    DrawOverlay(_mySettings.Layout.S5, d2d, circleBrush, font, fontBrush)
                Case 6
                    DrawOverlay(_mySettings.Layout.S6, d2d, circleBrush, font, fontBrush)
            End Select
        End If

        d2d.EndScene()
    End Sub

#End Region

End Class
