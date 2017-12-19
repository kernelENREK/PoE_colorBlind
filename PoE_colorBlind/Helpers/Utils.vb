Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Namespace Helpers

    Public NotInheritable Class Utils

        Public Shared Function GeorgeClooneyObject(Of T)(obj As T) As T
            Using ms = New MemoryStream()
                Dim formatter = New BinaryFormatter()
                formatter.Serialize(ms, obj)
                ms.Position = 0

                Return DirectCast(formatter.Deserialize(ms), T)
            End Using
        End Function

    End Class

End Namespace
