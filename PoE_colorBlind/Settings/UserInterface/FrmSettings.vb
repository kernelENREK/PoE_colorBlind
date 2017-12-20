Public Class FrmSettings

#Region "Variables"

    ''' <summary>
    ''' The settings we 'inject' on constructor are stored on this object
    ''' </summary>
    Public _newSettings As Settings

    ''' <summary>
    ''' How many socket are we configuring
    ''' </summary>
    Private Enum eScktype
        S1 = 0
        S2H
        S2V
        S3L
        S3V
        S4
        S5
        S6
        VoriciBench
    End Enum

#Region "       Stuff for combobox control"

    Private Class tscktype
        Public Property eSckType As eScktype
        Public Property Description As String
    End Class

    Private scktCbo As List(Of tscktype)
    Private bSkipCboNumberSockets_SelectedIndexChanged As Boolean

#End Region

#End Region

#Region "Constructor"

    Public Sub New(cfg As Settings)
        InitializeComponent()

        ' store the settings passed from Main Window
        _newSettings = cfg

        Me.Icon = My.Resources.AppIcon
        Me.Text = "Path of Exile :: QoL colorblind tool - Settings"

        Me.BackgroundImage = My.Resources.backgroundSettings
        Me.DoubleBuffered = True

        ' Setting some handlers for 'checkbox' Hover effect (cursor changes)
        AddHandler PicChkDefault_S2.MouseEnter, AddressOf OnPicChkMouse_Enter
        AddHandler PicChkDefault_S3.MouseEnter, AddressOf OnPicChkMouse_Enter

        AddHandler PicChkDefault_S2.MouseLeave, AddressOf OnPicChkMouse_Leave
        AddHandler PicChkDefault_S3.MouseLeave, AddressOf OnPicChkMouse_Leave

        ' user controls location:
        UC_S11.Location = UC_S61.Location
        UC_S2H1.Location = UC_S61.Location
        UC_S2V1.Location = UC_S61.Location
        UC_S3V1.Location = UC_S61.Location
        UC_S3L1.Location = UC_S61.Location
        UC_S41.Location = UC_S61.Location
        UC_S51.Location = UC_S61.Location
        UC_Vorici1.Location = UC_S61.Location

        PicChkDefault_S2.Location = PicChkDefault_S3.Location
        LblChkDefault_S2.Location = LblChkDefault_S3.Location

        TxtPOEProcess.Text = _newSettings.PathOfExileProcess

        ' Set user control socket positions (and show that positions on TextBoxes controls)
        UC_S11.SocketsPositions = _newSettings.Layout.S1
        UC_S2H1.SocketsPositions = _newSettings.Layout.S2_Horizontal
        UC_S2V1.SocketsPositions = _newSettings.Layout.S2_Vertical
        UC_S3L1.SocketsPositions = _newSettings.Layout.S3_L
        UC_S3V1.SocketsPositions = _newSettings.Layout.S3_Vertical
        UC_S41.SocketsPositions = _newSettings.Layout.S4
        UC_S51.SocketsPositions = _newSettings.Layout.S5
        UC_S61.SocketsPositions = _newSettings.Layout.S6
        UC_Vorici1.SocketsPositions = _newSettings.Layout.VoriciBenchCenter

        ' Socket type combobox:
        scktCbo = New List(Of tscktype)()
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S1, .Description = "One socket"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S2H, .Description = "Two sockets (Horizontal)"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S2V, .Description = "Two sockets (Vertical)"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S3L, .Description = "Three sockets (L)"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S3V, .Description = "Three Sockets (Vertical)"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S4, .Description = "Four sockets"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S5, .Description = "Five sockets"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.S6, .Description = "Six sockets"})
        scktCbo.Add(New tscktype() With {.eSckType = eScktype.VoriciBench, .Description = "Vorici's bench"})

        bSkipCboNumberSockets_SelectedIndexChanged = True

        CboNumberSockets.Items.Clear()
        CboNumberSockets.DataSource = scktCbo
        CboNumberSockets.ValueMember = "eSckType"
        CboNumberSockets.DisplayMember = "Description"
        CboNumberSockets.SelectedIndex = -1

        bSkipCboNumberSockets_SelectedIndexChanged = False

        ' By default the combobox is setted to six socket item
        Dim tS = scktCbo.Find(Function(c) c.eSckType = eScktype.S6).eSckType
        CboNumberSockets.SelectedValue = tS

        ' Timer we use to refresh mouse coordinates info 
        TimerMouseCoord.Interval = 100
        TimerMouseCoord.Enabled = True

    End Sub

#End Region

#Region "Timer Tick for refresh the mouse coordinates info"

    Private Sub TimerMouseCoord_Tick(sender As Object, e As EventArgs) Handles TimerMouseCoord.Tick
        lblMouseCoordinates.Text = $"X: {MouseCoords.Coordinates.X}, Y:{MouseCoords.Coordinates.Y}"
    End Sub

#End Region

#Region "Move or drag Form with BorderStyle = None"

    ' Yes i know, here we could used some fancy WndProc trick with P/Invoke API calls, but
    ' this time we used .NET and forms events

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub FrmSettings_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If (e.Button = MouseButtons.Left) Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub FrmSettings_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If (e.Button = MouseButtons.Left) Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub FrmSettings_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If (IsFormBeingDragged) Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

#End Region

#Region "ComboBox SelectedIndexChanged: Socket Item Type"

    ' Each time we change the selected item (socket type) on combobox, we display the 'propertly' user control
    Private Sub CboNumberSockets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNumberSockets.SelectedIndexChanged
        If (bSkipCboNumberSockets_SelectedIndexChanged) Then Exit Sub

        Dim t = DirectCast(CboNumberSockets.SelectedValue, eScktype)

        UC_S11.Visible = False
        UC_S2H1.Visible = False
        UC_S2V1.Visible = False
        UC_S3L1.Visible = False
        UC_S3V1.Visible = False
        UC_S41.Visible = False
        UC_S51.Visible = False
        UC_S61.Visible = False
        UC_Vorici1.Visible = False

        PicChkDefault_S2.Visible = False
        LblChkDefault_S2.Visible = False
        PicChkDefault_S3.Visible = False
        LblChkDefault_S3.Visible = False

        Select Case t
            Case eScktype.S1
                UC_S11.Visible = True
            Case eScktype.S2H
                UC_S2H1.Visible = True
                PicChkDefault_S2.Visible = True
                PicChkDefault_S2.BringToFront()
                LblChkDefault_S2.Visible = True
                LblChkDefault_S2.BringToFront()

                If (Not _newSettings.S2_Vertical_Default) Then
                    PicChkDefault_S2.Image = My.Resources.Checked
                Else
                    PicChkDefault_S2.Image = My.Resources.UnChecked
                End If

            Case eScktype.S2V
                UC_S2V1.Visible = True
                PicChkDefault_S2.Visible = True
                PicChkDefault_S2.BringToFront()
                LblChkDefault_S2.Visible = True
                LblChkDefault_S2.BringToFront()

                If (_newSettings.S2_Vertical_Default) Then
                    PicChkDefault_S2.Image = My.Resources.Checked
                Else
                    PicChkDefault_S2.Image = My.Resources.UnChecked
                End If

            Case eScktype.S3L
                UC_S3L1.Visible = True
                PicChkDefault_S3.Visible = True
                PicChkDefault_S3.BringToFront()
                LblChkDefault_S3.Visible = True
                LblChkDefault_S3.BringToFront()

                If (Not _newSettings.S3_Vertical_Default) Then
                    PicChkDefault_S3.Image = My.Resources.Checked
                Else
                    PicChkDefault_S3.Image = My.Resources.UnChecked
                End If

            Case eScktype.S3V
                UC_S3V1.Visible = True
                PicChkDefault_S3.Visible = True
                PicChkDefault_S3.BringToFront()
                LblChkDefault_S3.Visible = True
                LblChkDefault_S3.BringToFront()

                If (_newSettings.S3_Vertical_Default) Then
                    PicChkDefault_S3.Image = My.Resources.Checked
                Else
                    PicChkDefault_S3.Image = My.Resources.UnChecked
                End If

            Case eScktype.S4
                UC_S41.Visible = True
            Case eScktype.S5
                UC_S51.Visible = True
            Case eScktype.S6
                UC_S61.Visible = True
            Case eScktype.VoriciBench
                UC_Vorici1.Visible = True
        End Select
    End Sub

#End Region

#Region "For Two socket items: Whitch is the default: Horizontal layout or Vertical layout?"

    Private Sub PicChkDefault_S2_Click(sender As Object, e As EventArgs) Handles PicChkDefault_S2.Click
        Dim tS = DirectCast(CboNumberSockets.SelectedValue, eScktype)
        _newSettings.S2_Vertical_Default = Not _newSettings.S2_Vertical_Default

        If (tS = eScktype.S2V) Then
            If (_newSettings.S2_Vertical_Default) Then
                PicChkDefault_S2.Image = My.Resources.Checked
            Else
                PicChkDefault_S2.Image = My.Resources.UnChecked
            End If
        Else
            If (Not _newSettings.S2_Vertical_Default) Then
                PicChkDefault_S2.Image = My.Resources.Checked
            Else
                PicChkDefault_S2.Image = My.Resources.UnChecked
            End If
        End If
    End Sub

#End Region

#Region "For Three socket items: Whitch is the default: 'L' layout or Vertical layout? "

    Private Sub PicChkDefault_S3_Click(sender As Object, e As EventArgs) Handles PicChkDefault_S3.Click
        Dim tS = DirectCast(CboNumberSockets.SelectedValue, eScktype)
        _newSettings.S3_Vertical_Default = Not _newSettings.S3_Vertical_Default

        If (tS = eScktype.S3V) Then
            If (_newSettings.S3_Vertical_Default) Then
                PicChkDefault_S3.Image = My.Resources.Checked
            Else
                PicChkDefault_S3.Image = My.Resources.UnChecked
            End If
        Else
            If (Not _newSettings.S3_Vertical_Default) Then
                PicChkDefault_S3.Image = My.Resources.Checked
            Else
                PicChkDefault_S3.Image = My.Resources.UnChecked
            End If
        End If
    End Sub

#End Region

#Region "Hover effects and picturebox images"

#Region "       Save button"

    Private Sub PicSave_MouseEnter(sender As Object, e As EventArgs) Handles PicSave.MouseEnter
        PicSave.Image = My.Resources.SaveLight
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PicSave_MouseLeave(sender As Object, e As EventArgs) Handles PicSave.MouseLeave
        PicSave.Image = My.Resources.SaveDark
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "       Close button"

    Private Sub PicClose_MouseEnter(sender As Object, e As EventArgs) Handles PicClose.MouseEnter
        PicClose.Image = My.Resources.CloseLight
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PicClose_MouseLeave(sender As Object, e As EventArgs) Handles PicClose.MouseLeave
        PicClose.Image = My.Resources.CloseDark
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "       'custom 'checkbox' for S2 or S3 default layout"

    Private Sub OnPicChkMouse_Leave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OnPicChkMouse_Enter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

#End Region

#End Region

#Region "CANCEL the settings (By pressing Close button)"

    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        TimerMouseCoord.Enabled = False
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

#Region "ACCEPT new settings (By pressing Save button)"

    Private Function ValidationOK() As Boolean
        If (Not UC_S11.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 1 socket  are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_S2H1.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 2 socket (horizontal) are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_S2V1.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 2 socket (vertical) are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_S3V1.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 3 socket (vertical) are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_S3L1.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 3 socket (L) are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_S41.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 4 socket are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_S51.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 5 socket are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_S61.ValidationOK) Then
            MessageBox.Show("Some coordinate values from 6 socket are missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (Not UC_Vorici1.ValidationOK) Then
            MessageBox.Show("Some coordinate values from Vorici's bench location missing or not valid values", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub PicSave_Click(sender As Object, e As EventArgs) Handles PicSave.Click
        If (ValidationOK()) Then
            _newSettings.PathOfExileProcess = TxtPOEProcess.Text.Trim()

            TimerMouseCoord.Enabled = False
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

#End Region


End Class