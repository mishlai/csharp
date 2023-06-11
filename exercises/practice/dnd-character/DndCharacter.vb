Imports System

Public Class DndCharacter
    Public ReadOnly Property Strength As Integer
    Public ReadOnly Property Dexterity As Integer
    Public ReadOnly Property Constitution As Integer
    Public ReadOnly Property Intelligence As Integer
    Public ReadOnly Property Wisdom As Integer
    Public ReadOnly Property Charisma As Integer
    Public ReadOnly Property Hitpoints As Integer

    Public Function Modifier(ByVal score As Integer) As Integer
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function Ability() As Integer
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function Generate() As DndCharacter
        Throw New NotImplementedException("You need to implement this function.")
    End Function
End Class
