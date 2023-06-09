Imports System
Imports System.Collections.Generic

Public Module ListOps
    Public Function LengthMethod(Of T)(ByVal input As List(Of T)) As Integer
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function ReverseMethod(Of T)(ByVal input As List(Of T)) As List(Of T)
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function MapMethod(Of TIn, TOut)(ByVal input As List(Of TIn), ByVal map As Func(Of TIn, TOut)) As List(Of TOut)
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function FilterMethod(Of T)(ByVal input As List(Of T), ByVal predicate As Func(Of T, Boolean)) As List(Of T)
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function FoldlMethod(Of TIn, TOut)(ByVal input As List(Of TIn), ByVal start As TOut, ByVal func As Func(Of TOut, TIn, TOut)) As TOut
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function FoldrMethod(Of TIn, TOut)(ByVal input As List(Of TIn), ByVal start As TOut, ByVal func As Func(Of TIn, TOut, TOut)) As TOut
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function ConcatMethod(Of T)(ByVal input As List(Of List(Of T))) As List(Of T)
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function AppendMethod(Of T)(ByVal left As List(Of T), ByVal right As List(Of T)) As List(Of T)
        Throw New NotImplementedException("You need to implement this function.")
    End Function
End Module
