Imports System

Public Enum Allergen
    Eggs
    Peanuts
    Shellfish
    Strawberries
    Tomatoes
    Chocolate
    Pollen
    Cats
End Enum

Public Class Allergies
    Public Sub New(ByVal mask As Integer)
    End Sub

    Public Function IsAllergicTo(ByVal allergen As Allergen) As Boolean
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function List() As Allergen()
        Throw New NotImplementedException("You need to implement this function.")
    End Function
End Class
