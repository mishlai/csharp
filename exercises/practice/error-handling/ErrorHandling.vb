Imports System
Imports System.Runtime.InteropServices

Public Module ErrorHandling
    Public Sub HandleErrorByThrowingExceptionMethod()
        Throw New NotImplementedException("You need to implement this function.")
    End Sub

    Public Function HandleErrorByReturningNullableTypeMethod(ByVal input As String) As Integer?
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function HandleErrorWithOutParamMethod(ByVal input As String, <Out> ByRef result As Integer) As Boolean
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Sub DisposableResourcesAreDisposedWhenExceptionIsThrownMethod(ByVal disposableObject As IDisposable)
        Throw New NotImplementedException("You need to implement this function.")
    End Sub
End Module
