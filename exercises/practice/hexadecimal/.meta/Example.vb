Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Public Class Hexadecimal
    Private Shared ReadOnly AlphaValues As Dictionary(Of Char, Integer) = New Dictionary(Of Char, Integer) From {
    {"a"c, 10},
    {"b"c, 11},
    {"c"c, 12},
    {"d"c, 13},
    {"e"c, 14},
    {"f"c, 15}
}

    Public Shared Function ToDecimal(ByVal value As String) As Integer
        If IsNotValidHexadecimal(value) Then Return 0

        Return Enumerable.Select(Of Char, Global.System.Int32)(value, CType(Function(c, i) CInt(GetNumericValue(CChar(c)) * SixteenToThePowerOf(CInt(value.Length - i - 1))), Func(Of Char, Integer, Integer))).Sum()
    End Function

    Private Shared Function IsNotValidHexadecimal(ByVal value As String) As Boolean
        Return Regex.IsMatch(value, "[^0-9abcdef]", RegexOptions.IgnoreCase)
    End Function

    Private Shared Function GetNumericValue(ByVal value As Char) As Integer
        If Char.IsNumber(value) Then Return Char.GetNumericValue(value)
        Return AlphaValues(value)
    End Function

    Private Shared Function SixteenToThePowerOf(ByVal power As Integer) As Integer
        Return Math.Pow(16, power)
    End Function
End Class
