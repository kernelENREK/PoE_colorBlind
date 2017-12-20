Namespace SettingsModels

    <Serializable()>
    Public Class SocketsLayouts

        ''' <summary>
        ''' Radius for our overlayed circles.
        ''' </summary>
        ''' <returns></returns>
        Public Property Radius As Integer

        ''' <summary>
        ''' Font size for the 'R', 'G', 'B' and 'W' characters we will overlay on game screen
        ''' </summary>
        ''' <returns></returns>
        Public Property FontSize As Integer

        ''' <summary>
        ''' offset to 'X-center' the 'R', 'G', 'B' or 'W' characters on overlayed circle
        ''' </summary>
        ''' <returns></returns>
        Public Property CharOffsetX As Integer

        ''' <summary>
        ''' offset to 'Y-center' the 'R', 'G', 'B' or 'W' characters on overlayed circle
        ''' </summary>
        ''' <returns></returns>
        Public Property CharOffsetY As Integer

        ' Sockets positions for all possible items ------------------------------------------------
        Public S1 As List(Of SocketPosition)
        Public S2_Horizontal As List(Of SocketPosition)
        Public S2_Vertical As List(Of SocketPosition)
        Public S3_L As List(Of SocketPosition)
        Public S3_Vertical As List(Of SocketPosition)
        Public S4 As List(Of SocketPosition)
        Public S5 As List(Of SocketPosition)
        Public S6 As List(Of SocketPosition)
        Public VoriciBenchCenter As List(Of SocketPosition)

        Public Sub New()

            Radius = 12
            FontSize = 22
            CharOffsetX = 6
            CharOffsetY = 12

            S1 = New List(Of SocketPosition)()
            S2_Horizontal = New List(Of SocketPosition)()
            S2_Vertical = New List(Of SocketPosition)()
            S3_L = New List(Of SocketPosition)()
            S3_Vertical = New List(Of SocketPosition)()
            S4 = New List(Of SocketPosition)()
            S5 = New List(Of SocketPosition)()
            S6 = New List(Of SocketPosition)()
            VoriciBenchCenter = New List(Of SocketPosition)()

        End Sub
    End Class

    <Serializable()>
    Public Class SocketPosition
        Public Property X As Integer
        Public Property Y As Integer
    End Class

End Namespace
