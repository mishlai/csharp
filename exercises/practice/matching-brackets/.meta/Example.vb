Imports System.Linq

Public Module MatchingBrackets
    Public Function IsPaired(ByVal input As String) As Boolean
        Dim brackets = New String(input.Where(Function(c) "[]{}()".Contains(c)).ToArray())
        Dim previousLength = brackets.Length

        While brackets.Length > 0
            brackets = brackets.Replace("[]", "").Replace("{}", "").Replace("()", "")

            If brackets.Length = previousLength Then Return False

            previousLength = brackets.Length
        End While

        Return True
    End Function
End Module
