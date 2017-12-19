﻿Imports PoE_colorBlind.SettingsModels

''' <summary>
''' User Control for setting a One Socket Item Layout
''' </summary>
Public Class UC_S1

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

    End Sub

    Public Sub New()
        InitializeComponent()

        For Each c In Me.Controls.OfType(Of MaskedTextBox)
            AddHandler c.TextChanged, AddressOf OnValidation
        Next

    End Sub

End Class
