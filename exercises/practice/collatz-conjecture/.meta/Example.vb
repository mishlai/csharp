Imports System

Public Module CollatzConjecture
    Public Function Steps(ByVal number As Integer) As Integer
        If number <= 0 Then
            Throw New ArgumentOutOfRangeException("Only positive numbers are allowed")
        End If

        Dim stepCount = 0

        While number <> 1
            If number Mod 2 = 0 Then
                number /= 2
            Else
                number = number * 3 + 1
            End If

            stepCount += 1
        End While

        Return stepCount
    End Function
End Module
