Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Public Module AccumulateExtensions
    <Extension()>
    Public Iterator Function Accumulate(Of T, U)(ByVal collection As IEnumerable(Of T), ByVal func As Func(Of T, U)) As IEnumerable(Of U)
        For Each item In collection
            Yield func(item)
        Next
    End Function
End Module
