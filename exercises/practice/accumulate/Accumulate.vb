Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Public Module AccumulateExtensions
    <Extension()>
    Public Function Accumulate(Of T, U)(ByVal collection As IEnumerable(Of T), ByVal func As Func(Of T, U)) As IEnumerable(Of U)
        Throw New NotImplementedException("You need to implement this function.")
    End Function
End Module
