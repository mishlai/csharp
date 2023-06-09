Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Public Module Strain
    <Extension()>
    Public Function KeepMethod(Of T)(ByVal collection As IEnumerable(Of T), ByVal predicate As Func(Of T, Boolean)) As IEnumerable(Of T)
        Return ApplyPredicate(collection, predicate)
    End Function

    <Extension()>
    Public Function DiscardMethod(Of T)(ByVal collection As IEnumerable(Of T), ByVal predicate As Func(Of T, Boolean)) As IEnumerable(Of T)
        Return ApplyPredicate(collection, Function(x) Not predicate(x))
    End Function

    Private Function ApplyPredicate(Of T)(ByVal collection As IEnumerable(Of T), ByVal predicate As Func(Of T, Boolean)) As IEnumerable(Of T)
        ' could knock this down to a simple LINQ expression but restriction prevents that
        Dim filtered = New List(Of T)()
        For Each item In collection
            If predicate(item) Then filtered.Add(item)
        Next
        Return filtered
    End Function
End Module
