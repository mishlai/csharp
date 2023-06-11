Imports System
Imports System.Linq
Imports System.Text.RegularExpressions

Public Class PhoneNumber
    Private Shared ReadOnly phoneNumberFormat As Regex = New Regex("^1?([2-9][0-9]{2}[2-9][0-9]{6})$")

    Public Shared Function Clean(ByVal phoneNumber As String) As String
        Dim digits = String.Join(String.Empty, phoneNumber.Where(Function(l) l >= "0"c AndAlso l <= "9"c))

        Dim match = PhoneNumber.phoneNumberFormat.Match(digits)

        If match.Success Then
            Return match.Groups(1).ToString()
        Else
            Throw New ArgumentException("invalid phone number")
        End If
    End Function
End Class
