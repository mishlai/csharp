Public Module Leap
    Public Function IsLeapYear(ByVal year As Integer) As Boolean
        If year Mod 100 = 0 Then Return year Mod 400 = 0
        Return year Mod 4 = 0
    End Function
End Module
