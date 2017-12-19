Imports PoE_colorBlind.SettingsModels

<Serializable()>
Public Class Settings

    ''' <summary>
    ''' Check for new releases on GitHub repo when start the app
    ''' </summary>
    ''' <returns></returns>
    Public Property CheckForNewReleases As Boolean

    ''' <summary>
    ''' For automatic mode, how much time we perform a CTRL + C if the mouse is over the currency 
    ''' tab item rectangle.
    ''' </summary>
    ''' <returns></returns>
    Public Property AutomodePollTime_ms As Integer

    ''' <summary>
    ''' Name of the process we 'overlay', Path of Exile game client in our scenario.
    ''' You can find the name of the process using Windows Taskmanager
    ''' </summary>
    ''' <returns></returns>
    Public Property PathOfExileProcess As String

    ''' <summary>
    ''' The default behaviour is: Start PoE >> Login >> Select Player >> Execute this tool
    ''' But, if you set this property fo false you could do:
    ''' Execute this tool >> Start PoE >> Login >> Select Player
    ''' If this property is setted to false and PoE process is not running, the tool autoclose itselft
    ''' if after <see cref="ProcessNotRunningTimeOut_seconds"/> seconds PoE process is not detected.
    ''' </summary>
    ''' <returns></returns>
    Public Property PoEMustBeRunning As Boolean

    ''' <summary>
    ''' This param only works if <see cref="PoEMustBeRunning"/> is false
    ''' </summary>
    ''' <returns></returns>
    Public Property ProcessNotRunningTimeOut_seconds As Integer

    ''' <summary>
    ''' There are two 'layouts' for a 2 socket items: 2 socket (linked or not linked) horizontally: 
    ''' helmets, shield, body armour, ect. And the we have other items with 2 sockets (linked or not linked)
    ''' vertically: Basically wands, daggers, 2H weapons, ect.
    ''' This parameter set the default dehaviour when a 2 socket item is detected
    ''' </summary>
    ''' <returns></returns>
    Public Property S2_Vertical_Default As Boolean

    ''' <summary>
    ''' Same idea as <see cref="S2_Vertical_Default"/> but applied to 3 socket items.
    ''' </summary>
    ''' <returns></returns>
    Public Property S3_Vertical_Default As Boolean

    ''' <summary>
    ''' Layout we will use for overlay the sockets
    ''' </summary>
    Public Layout As SocketsLayouts

    Public Sub New()

        CheckForNewReleases = True

        AutomodePollTime_ms = 500

        PathOfExileProcess = "PathOfExile_x64Steam"

        PoEMustBeRunning = True

        ProcessNotRunningTimeOut_seconds = 30

        S2_Vertical_Default = True
        S3_Vertical_Default = True

        Layout = New SocketsLayouts()

        ' Default Socket Layout for a 1920 x 1080 PoE game ----------------------------------------
        Layout.S1 = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 335, .Y = 524}
            }

        Layout.S2_Horizontal = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 314, .Y = 524},
                New SocketPosition() With {.X = 356, .Y = 524}
            }

        Layout.S2_Vertical = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 335, .Y = 502},
                New SocketPosition() With {.X = 335, .Y = 545}
            }

        Layout.S3_Vertical = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 335, .Y = 480},
                New SocketPosition() With {.X = 335, .Y = 524},
                New SocketPosition() With {.X = 335, .Y = 565}
            }

        Layout.S3_L = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 314, .Y = 502},
                New SocketPosition() With {.X = 356, .Y = 502},
                New SocketPosition() With {.X = 356, .Y = 545}
            }

        Layout.S4 = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 314, .Y = 502},
                New SocketPosition() With {.X = 356, .Y = 502},
                New SocketPosition() With {.X = 356, .Y = 545},
                New SocketPosition() With {.X = 314, .Y = 545}
            }

        Layout.S5 = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 314, .Y = 480},
                New SocketPosition() With {.X = 356, .Y = 480},
                New SocketPosition() With {.X = 356, .Y = 524},
                New SocketPosition() With {.X = 314, .Y = 524},
                New SocketPosition() With {.X = 314, .Y = 568}
            }

        Layout.S6 = New List(Of SocketPosition)() From
            {
                New SocketPosition() With {.X = 314, .Y = 480},
                New SocketPosition() With {.X = 356, .Y = 480},
                New SocketPosition() With {.X = 356, .Y = 524},
                New SocketPosition() With {.X = 314, .Y = 524},
                New SocketPosition() With {.X = 314, .Y = 568},
                New SocketPosition() With {.X = 356, .Y = 568}
            }
    End Sub

End Class
