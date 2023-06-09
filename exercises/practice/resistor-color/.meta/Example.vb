Imports System

Public Module ResistorColor
    Private ReadOnly AllColors As String() = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"}

    Public Function ColorCodeMethod(ByVal color As String) As Integer
        Return Array.IndexOf(AllColors, color)
    End Function

    Public Function ColorsMethod() As String()
        Return AllColors
    End Function
End Module
