
Public Structure Clock
    Public Sub New(ByVal hours As Integer, ByVal Optional minutes As Integer = 0)
        Me.Hours = [Mod]((hours * 60 + minutes) / 60.0, 24)
        Me.Minutes = [Mod](minutes, 60)
    End Sub

    Public ReadOnly Property Hours As Integer

    Public ReadOnly Property Minutes As Integer

    Public Function Add(ByVal minutesToAdd As Integer) As Clock
        Return New Clock(Hours, Minutes + minutesToAdd)
    End Function

    Public Function Subtract(ByVal minutesToSubtract As Integer) As Clock
        Return New Clock(Hours, Minutes - minutesToSubtract)
    End Function

    Public Overrides Function ToString() As String
        Return $"{Hours:00}:{Minutes:00}"
    End Function

    Private Shared Function [Mod](ByVal x As Double, ByVal y As Double) As Integer
        Return (x Mod y + y) Mod y
    End Function
End Structure
