Imports PoE_colorBlind.SettingsModels

''' <summary>
''' User Control for setting a Six Soket Item Layout
''' </summary>
Public Class UC_S6

    Private bSkipValidation As Boolean

    Private _socketsPositions As List(Of SocketPosition)

    Public Property SocketsPositions As List(Of SocketPosition)
        Get
            Return _socketsPositions
        End Get
        Set(value As List(Of SocketPosition))
            If (value IsNot Nothing) Then
                _socketsPositions = value

                bSkipValidation = True

                TXT_1X.Text = value(0).X
                TXT_1Y.Text = value(0).Y

                TXT_2X.Text = value(1).X
                TXT_2Y.Text = value(1).Y

                TXT_3X.Text = value(2).X
                TXT_3Y.Text = value(2).Y

                TXT_4X.Text = value(3).X
                TXT_4Y.Text = value(3).Y

                TXT_5X.Text = value(4).X
                TXT_5Y.Text = value(4).Y

                TXT_6X.Text = value(5).X
                TXT_6Y.Text = value(5).Y

                bSkipValidation = False

                OnValidation()
            End If

        End Set
    End Property

    Private _validationOK As Boolean
    Public ReadOnly Property ValidationOK As Boolean
        Get
            Return _validationOK
        End Get
    End Property

    Private Sub OnValidation()
        If (bSkipValidation) Then Exit Sub

        _validationOK = True
        ' 1 ----
        If (Not String.IsNullOrWhiteSpace(TXT_1X.Text)) Then
            _socketsPositions(0).X = Convert.ToInt32(TXT_1X.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TXT_1Y.Text)) Then
            _socketsPositions(0).Y = Convert.ToInt32(TXT_1Y.Text)
        Else
            _validationOK = False
        End If
        ' 2 ----
        If (Not String.IsNullOrWhiteSpace(TXT_2X.Text)) Then
            _socketsPositions(1).X = Convert.ToInt32(TXT_2X.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TXT_2Y.Text)) Then
            _socketsPositions(1).Y = Convert.ToInt32(TXT_2Y.Text)
        Else
            _validationOK = False
        End If
        ' 3 ----
        If (Not String.IsNullOrWhiteSpace(TXT_3X.Text)) Then
            _socketsPositions(2).X = Convert.ToInt32(TXT_3X.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TXT_3Y.Text)) Then
            _socketsPositions(2).Y = Convert.ToInt32(TXT_3Y.Text)
        Else
            _validationOK = False
        End If
        ' 4 ----
        If (Not String.IsNullOrWhiteSpace(TXT_4X.Text)) Then
            _socketsPositions(3).X = Convert.ToInt32(TXT_4X.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TXT_4Y.Text)) Then
            _socketsPositions(3).Y = Convert.ToInt32(TXT_4Y.Text)
        Else
            _validationOK = False
        End If
        ' 5 ----
        If (Not String.IsNullOrWhiteSpace(TXT_5X.Text)) Then
            _socketsPositions(4).X = Convert.ToInt32(TXT_5X.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TXT_5Y.Text)) Then
            _socketsPositions(4).Y = Convert.ToInt32(TXT_5Y.Text)
        Else
            _validationOK = False
        End If
        ' 6 ----
        If (Not String.IsNullOrWhiteSpace(TXT_6X.Text)) Then
            _socketsPositions(5).X = Convert.ToInt32(TXT_6X.Text)
        Else
            _validationOK = False
        End If
        If (Not String.IsNullOrWhiteSpace(TXT_6Y.Text)) Then
            _socketsPositions(5).Y = Convert.ToInt32(TXT_6Y.Text)
        Else
            _validationOK = False
        End If
    End Sub

    Public Sub New()
        InitializeComponent()

        For Each c In Me.Controls.OfType(Of MaskedTextBox)
            AddHandler c.TextChanged, AddressOf OnValidation
        Next

    End Sub

End Class
