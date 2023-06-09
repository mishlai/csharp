Imports System
Imports System.Linq

Public Module ReverseString
    Public Function ReverseMethod(ByVal input As String) As String
        Return New String(input.ToCharArray().Reverse().ToArray())
    End Function
End Module
