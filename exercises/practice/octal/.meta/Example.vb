Imports System
Imports System.Linq

Public Class Octal
    Public Shared Function ToDecimal(ByVal octal As String) As Integer
        If Octal.IsNotValidOctal(octal) Then Return 0

        Return Enumerable.Select(Of Char, Global.System.Int32)(octal, CType(Function(c, i) CInt(Integer.Parse(CStr(c.ToString())) * Octal.EightToThePowerOf(CInt(octal.Length - i - 1))), Func(Of Char, Integer, Integer))).Sum()
    End Function

    Private Shared Function IsNotValidOctal(ByVal octal As String) As Boolean
        Return Not octal.All(Function(x) Char.IsDigit(x) AndAlso Integer.Parse(x.ToString()) < 8)
    End Function

    Private Shared Function EightToThePowerOf(ByVal power As Integer) As Integer
        Return Math.Pow(8, power)
    End Function
End Class
