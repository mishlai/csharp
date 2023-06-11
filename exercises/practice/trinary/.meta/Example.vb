Imports System
Imports System.Linq

Public Class Trinary
    Public Shared Function ToDecimal(ByVal trinary As String) As Integer
        If Trinary.IsNotValidTrinary(trinary) Then Return 0

        Return Enumerable.Select(Of Char, Global.System.Int32)(trinary, CType(Function(c, i) CInt(Integer.Parse(CStr(c.ToString())) * Trinary.ThreeToThePowerOf(CInt(trinary.Length - i - 1))), Func(Of Char, Integer, Integer))).Sum()
    End Function

    Private Shared Function IsNotValidTrinary(ByVal trinary As String) As Boolean
        Return Not trinary.All(Function(x) Char.IsDigit(x) AndAlso Integer.Parse(x.ToString()) < 3)
    End Function

    Private Shared Function ThreeToThePowerOf(ByVal power As Integer) As Integer
        Return Math.Pow(3, power)
    End Function
End Class
