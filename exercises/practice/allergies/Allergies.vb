Imports System

Public Enum AllergenType
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

    Public Function IsAllergicToMethod(ByVal allergen As Allergen) As Boolean
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function ListMethod() As Allergen()
        Throw New NotImplementedException("You need to implement this function.")
    End Function
End Class
