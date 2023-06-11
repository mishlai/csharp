Imports System
Imports System.Runtime.InteropServices

Public Module ErrorHandling
    Public Sub HandleErrorByThrowingException()
        Throw New NotImplementedException("You need to implement this function.")
    End Sub

    Public Function HandleErrorByReturningNullableType(ByVal input As String) As Integer?
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function HandleErrorWithOutParam(ByVal input As String, <Out> ByRef result As Integer) As Boolean
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Sub DisposableResourcesAreDisposedWhenExceptionIsThrown(ByVal disposableObject As IDisposable)
        Throw New NotImplementedException("You need to implement this function.")
    End Sub
End Module
