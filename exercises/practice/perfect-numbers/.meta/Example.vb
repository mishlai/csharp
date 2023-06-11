Imports System

Public Enum Classification
    Perfect
    Abundant
    Deficient
End Enum

Public Module PerfectNumbers
    Public Function Classify(ByVal number As Integer) As Classification
        If number < 1 Then Throw New ArgumentOutOfRangeException()

        Dim sumOfFactors = 0

        For i = 1 To number - 1
            If number Mod i = 0 Then sumOfFactors += i
        Next

        If sumOfFactors < number Then Return Classification.Deficient

        If sumOfFactors = number Then Return Classification.Perfect

        Return Classification.Abundant
    End Function
End Module
