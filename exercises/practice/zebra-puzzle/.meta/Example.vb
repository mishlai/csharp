Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.CompilerServices

Public Enum ColorType
    Red
    Green
    Ivory
    Yellow
    Blue
End Enum

Public Enum NationalityType
    Englishman
    Spaniard
    Ukranian
    Japanese
    Norwegian
End Enum

Public Enum PetType
    Dog
    Snails
    Fox
    Horse
    Zebra
End Enum

Public Enum DrinkType
    Coffee
    Tea
    Milk
    OrangeJuice
    Water
End Enum

Public Enum SmokeType
    OldGold
    Kools
    Chesterfields
    LuckyStrike
    Parliaments
End Enum

Public Module ZebraPuzzle
    Private ReadOnly Colors As Color() = CType([Enum].GetValues(GetType(Color)), Color())
    Private ReadOnly Nationalities As Nationality() = CType([Enum].GetValues(GetType(Nationality)), Nationality())
    Private ReadOnly Pets As Pet() = CType([Enum].GetValues(GetType(Pet)), Pet())
    Private ReadOnly Drinks As Drink() = CType([Enum].GetValues(GetType(Drink)), Drink())
    Private ReadOnly Smokes As Smoke() = CType([Enum].GetValues(GetType(Smoke)), Smoke())

    <Extension()>
    Private Function Permutations(Of T)(ByVal input As T()) As IEnumerable(Of T())
        Return input.Permutations(input.Length)
    End Function
    <Extension()>
    Private Function Permutations(Of T)(ByVal input As T(), ByVal length As Integer) As IEnumerable(Of T())
        If length = 1 Then
            Return input.[Select](Function(t) {t})
        End If

        Return input.Permutations(length - 1).SelectMany(Function(t) input.Where(Function(e) Not t.Contains(e)), Function(t1, t2) t1.Concat({t2}).ToArray())
    End Function

    Private Structure Solution
        Public Colors As Color()
        Public Nationalities As Nationality()
        Public Pets As Pet()
        Public Drinks As Drink()
        Public Smokes As Smoke()
    End Structure

    Private Function MatchesColorRules(ByVal colors As Color()) As Boolean
        Dim greenRightOfIvoryHouse = Array.IndexOf(colors, Color.Ivory) = Array.IndexOf(colors, Color.Green) - 1 ' #6
        Return greenRightOfIvoryHouse
    End Function

    Private Function MatchesNationalityRules(ByVal colors As Color(), ByVal nationalities As Nationality()) As Boolean
        Dim englishManInRedHouse = IsIndexMatch(nationalities, Nationality.Englishman, colors, Color.Red) ' #2
        Dim norwegianInFirstHouse = nationalities(0) = Nationality.Norwegian ' #10
        Dim norwegianLivesNextToBlueHouse = IsAdjacentMatch(nationalities, Nationality.Norwegian, colors, Color.Blue) ' #15

        Return englishManInRedHouse AndAlso norwegianInFirstHouse AndAlso norwegianLivesNextToBlueHouse
    End Function

    Private Function MatchesPetRules(ByVal nationalities As Nationality(), ByVal pets As Pet()) As Boolean
        Dim spaniardOwnsDog = IsIndexMatch(nationalities, Nationality.Spaniard, pets, Pet.Dog) ' #3
        Return spaniardOwnsDog
    End Function

    Private Function MatchesDrinkRules(ByVal colors As Color(), ByVal nationalities As Nationality(), ByVal drinks As Drink()) As Boolean
        Dim coffeeDrunkInGreenHouse = IsIndexMatch(colors, Color.Green, drinks, Drink.Coffee) ' #4
        Dim ukranianDrinksTee = IsIndexMatch(nationalities, Nationality.Ukranian, drinks, Drink.Tea) ' #5
        Dim milkDrunkInMiddleHouse = drinks(2) = Drink.Milk ' #9

        Return coffeeDrunkInGreenHouse AndAlso ukranianDrinksTee AndAlso milkDrunkInMiddleHouse
    End Function

    Private Function MatchesSmokeRules(ByVal colors As Color(), ByVal nationalities As Nationality(), ByVal drinks As Drink(), ByVal pets As Pet(), ByVal smokes As Smoke()) As Boolean
        Dim oldGoldSmokesOwnsSnails = IsIndexMatch(smokes, Smoke.OldGold, pets, Pet.Snails) ' #7
        Dim koolsSmokedInYellowHouse = IsIndexMatch(colors, Color.Yellow, smokes, Smoke.Kools) ' #8
        Dim chesterfieldsSmokedNextToHouseWithFox = IsAdjacentMatch(smokes, Smoke.Chesterfields, pets, Pet.Fox) ' #11
        Dim koolsSmokedNextToHouseWithHorse = IsAdjacentMatch(smokes, Smoke.Kools, pets, Pet.Horse) ' #12

        Dim luckyStrikeSmokerDrinksOrangeJuice = IsIndexMatch(smokes, Smoke.LuckyStrike, drinks, Drink.OrangeJuice) ' #13
        Dim japaneseSmokesParliaments = IsIndexMatch(nationalities, Nationality.Japanese, smokes, Smoke.Parliaments) ' #14

        Return oldGoldSmokesOwnsSnails AndAlso koolsSmokedInYellowHouse AndAlso chesterfieldsSmokedNextToHouseWithFox AndAlso koolsSmokedNextToHouseWithHorse AndAlso luckyStrikeSmokerDrinksOrangeJuice AndAlso japaneseSmokesParliaments
    End Function

    Private Function Solutions() As IEnumerable(Of Solution)
        Return From validColors In Colors.Permutations().Where(New Func(Of Color(), Boolean)(AddressOf MatchesColorRules)) From validNationalities In Nationalities.Permutations().Where(Function(nationalities) MatchesNationalityRules(validColors, nationalities)) From validPets In Pets.Permutations().Where(Function(pets) MatchesPetRules(validNationalities, pets)) From validDrinks In Drinks.Permutations().Where(Function(drinks) MatchesDrinkRules(validColors, validNationalities, drinks)) From validSmokes In Smokes.Permutations().Where(Function(smokes) MatchesSmokeRules(validColors, validNationalities, validDrinks, validPets, smokes)) Select New Solution With {
.Colors = validColors,
.Nationalities = validNationalities,
.Pets = validPets,
.Drinks = validDrinks,
.Smokes = validSmokes
}
    End Function

    Private Function Solve() As Solution
        Return Solutions().First()
    End Function

    Public Function DrinksWaterMethod() As Nationality
        Dim solution = Solve()
        Return solution.Nationalities(Array.IndexOf(solution.Drinks, Drink.Water))
    End Function

    Public Function OwnsZebraMethod() As Nationality
        Dim solution = Solve()
        Return solution.Nationalities(Array.IndexOf(solution.Pets, Pet.Zebra))
    End Function

    Private Function IsIndexMatch(Of T1, T2)(ByVal values1 As T1(), ByVal value1 As T1, ByVal values2 As T2(), ByVal value2 As T2) As Boolean
        Return values2(Array.IndexOf(values1, value1)).Equals(value2)
    End Function

    Private Function IsAdjacentMatch(Of T1, T2)(ByVal values1 As T1(), ByVal value1 As T1, ByVal values2 As T2(), ByVal value2 As T2) As Boolean
        Dim index = Array.IndexOf(values1, value1)
        Return index > 0 AndAlso values2(index - 1).Equals(value2) OrElse index < values2.Length - 1 AndAlso values2(index + 1).Equals(value2)
    End Function
End Module
