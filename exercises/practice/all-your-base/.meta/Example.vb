Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Module AllYourBase
    Public Function Rebase(ByVal inputBase As Integer, ByVal inputDigits As Integer(), ByVal outputBase As Integer) As Integer()
        If inputBase < 2 Then Throw New ArgumentException("Invalid input base.")
        If outputBase < 2 Then Throw New ArgumentException("Invalid output base.")

        Dim inputDigitsWithoutLeadingZeros = inputDigits.SkipWhile(Function(digit) digit = 0).ToArray()

        If inputDigitsWithoutLeadingZeros.Length = 0 Then Return {0}

        Return ToDigits(outputBase, FromDigits(inputBase, inputDigitsWithoutLeadingZeros))
    End Function

    Private Function FromDigits(ByVal fromBase As Integer, ByVal pFromDigits As Integer()) As Integer
        Return pFromDigits.Aggregate(0, Function(acc, x)
                                            If x < 0 OrElse x >= fromBase Then Throw New ArgumentException("Invalid input digit")

                                            Return acc * fromBase + x
                                        End Function)
    End Function

    Private Function ToDigits(ByVal toBase As Integer, ByVal x As Integer) As Integer()
        Dim digits = New List(Of Integer)()
        Dim remainder = x
        Dim multiplier = 1

        While remainder > 0
            multiplier *= toBase

            Dim value = remainder Mod multiplier
            Dim digit = value / (multiplier / toBase)

            digits.Add(digit)
            remainder -= value
        End While

        digits.Reverse()
        Return digits.ToArray()
    End Function
End Module
