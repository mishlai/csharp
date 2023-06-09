Public Module Bob
    Public Function Response(ByVal statement As String) As String
        If IsSilence(statement) Then Return "Fine. Be that way!"
        If IsYelling(statement) AndAlso IsQuestion(statement) Then Return "Calm down, I know what I'm doing!"
        If IsYelling(statement) Then Return "Whoa, chill out!"
        If IsQuestion(statement) Then Return "Sure."
        Return "Whatever."
    End Function

    Private Function IsSilence(ByVal statement As String) As Boolean
        Return Equals(statement.Trim(), "")
    End Function

    Private Function IsYelling(ByVal statement As String) As Boolean
        Return Equals(statement.ToUpper(), statement) AndAlso RegularExpressions.Regex.IsMatch(statement, "[a-zA-Z]+")
    End Function

    Private Function IsQuestion(ByVal statement As String) As Boolean
        Return statement.Trim().EndsWith("?")
    End Function
End Module
