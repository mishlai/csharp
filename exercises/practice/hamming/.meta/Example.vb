Imports System
Imports System.Linq

Public Module Hamming
    Public Function Distance(ByVal firstStrand As String, ByVal secondStrand As String) As Integer
        If firstStrand.Length <> secondStrand.Length Then
            Throw New ArgumentException("strand lengths must be equal")
        End If

        Return firstStrand.Where(Function(x, i) x <> secondStrand(i)).Count()
    End Function
End Module
