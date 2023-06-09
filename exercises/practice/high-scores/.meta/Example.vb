Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class HighScores
    Private ReadOnly _list As List(Of Integer)

    Public Sub New(ByVal list As List(Of Integer))
        CSharpImpl.__Assign(_list, list)
    End Sub

    Public Function Scores() As List(Of Integer)
        Return _list
    End Function

    Public Function Latest() As Integer
        Return _list.Last()
    End Function

    Public Function PersonalBest() As Integer
        Return _list.Max()
    End Function

    Public Function PersonalTopThree() As List(Of Integer)
        Return _list.OrderByDescending(Function(score) score).Take(3).ToList()
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
