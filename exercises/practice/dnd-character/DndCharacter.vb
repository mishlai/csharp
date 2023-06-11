Imports System

Public Class DndCharacter
    Public ReadOnly Property StrengthProp As Integer
    Public ReadOnly Property DexterityProp As Integer
    Public ReadOnly Property ConstitutionProp As Integer
    Public ReadOnly Property IntelligenceProp As Integer
    Public ReadOnly Property WisdomProp As Integer
    Public ReadOnly Property CharismaProp As Integer
    Public ReadOnly Property HitpointsProp As Integer

    Public Function ModifierMethod(ByVal score As Integer) As Integer
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function AbilityMethod() As Integer
        Throw New NotImplementedException("You need to implement this function.")
    End Function

    Public Function GenerateMethod() As DndCharacter
        Throw New NotImplementedException("You need to implement this function.")
    End Function
End Class
