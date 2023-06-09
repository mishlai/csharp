Imports System
Imports System.Linq

Public Class Binary
    Public Shared Function ToDecimal(ByVal binary As String) As Integer
        If Binary.IsNotValidBinary(binary) Then Return 0

        Return Enumerable.Select(Of Char, Global.System.Int32)(binary, CType(Function(c, i) CInt(Integer.Parse(CStr(c.ToString())) * Binary.TwoToThePowerOf(CInt(binary.Length - i - 1))), Func(Of Char, Integer, Integer))).Sum()
    End Function

    Private Shared Function IsNotValidBinary(ByVal binary As String) As Boolean
        Return Not binary.All(Function(x) Char.IsDigit(x) AndAlso Integer.Parse(x.ToString()) < 2)
    End Function

    Private Shared Function TwoToThePowerOf(ByVal power As Integer) As Integer
        Return Math.Pow(2, power)
    End Function
End Class
