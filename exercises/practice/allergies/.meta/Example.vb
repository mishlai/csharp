Imports System
Imports System.Linq

<Flags>
Public Enum Allergen
    Eggs = 1 << 0
    Peanuts = 1 << 1
    Shellfish = 1 << 2
    Strawberries = 1 << 3
    Tomatoes = 1 << 4
    Chocolate = 1 << 5
    Pollen = 1 << 6
    Cats = 1 << 7
End Enum

Public Class Allergies
    Private ReadOnly score As Integer

    Public Sub New(ByVal score As Integer)
        CSharpImpl.__Assign(Me.score, score)
    End Sub

    Public Function IsAllergicTo(ByVal allergen As Allergen) As Boolean
        Return (score And allergen) <> 0
    End Function

    Public Function List() As Allergen()
        Return [Enum].GetValues(GetType(Allergen)).Cast(Of Allergen)().Where(New Func(Of Allergen, Boolean)(AddressOf IsAllergicTo)).ToArray()
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
