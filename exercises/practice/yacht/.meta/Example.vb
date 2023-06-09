Imports System.Collections.Generic
Imports System.Linq

Public Enum YachtCategoryType
    Ones = 1
    Twos = 2
    Threes = 3
    Fours = 4
    Fives = 5
    Sixes = 6
    FullHouse = 7
    FourOfAKind = 8
    LittleStraight = 9
    BigStraight = 10
    Choice = 11
    Yacht = 12
End Enum

Public Module YachtGame
    Public Function ScoreMethod(ByVal dice As Integer(), ByVal category As YachtCategory) As Integer
        Select Case category
            'Ones: Any combination. The sum of dice with the number 1.
            Case YachtCategory.Ones
                Return Enumerable.Where(dice, Function(x) x = 1).Sum()
            'Twos: Any combination. The sum of dice with the number 2. 
            Case YachtCategory.Twos
                Return Enumerable.Where(dice, Function(x) x = 2).Sum()
            'Threes: Any combination. The sum of dice with the number 3.
            Case YachtCategory.Threes
                Return Enumerable.Where(dice, Function(x) x = 3).Sum()
            'Fours: Any combination The sum of dice with the number 4.
            Case YachtCategory.Fours
                Return Enumerable.Where(dice, Function(x) x = 4).Sum()
            'Fives: Any combination. The sum of dice with the number 5.
            Case YachtCategory.Fives
                Return Enumerable.Where(dice, Function(x) x = 5).Sum()
            'Sixes: Any combination. The sum of dice with the number 6.
            Case YachtCategory.Sixes
                Return Enumerable.Where(dice, Function(x) x = 6).Sum()

            'Full House:  Three of one number and two of another.  Sum of all dice.
            Case YachtCategory.FullHouse
                Dim diceByValue = dice.ToLookup(Function(x) x)
                Return If(diceByValue.Count = 2 AndAlso diceByValue.First().Count() = 2 OrElse diceByValue.First().Count() = 3, dice.Sum(), 0)
            'Four-Of-A-Kind:  At least four dice showing the same face.   Sum of those four dice.
            Case YachtCategory.FourOfAKind
                Dim testDict = New Dictionary(Of Integer, Integer)()
                Enumerable.ToList(dice).ForEach(Sub(x)
                                                    If Not testDict.ContainsKey(x) Then
                                                        testDict.Add(x, 1)
                                                    Else
                                                        testDict(x) += 1
                                                    End If
                                                End Sub)
                If testDict.Count > 2 Then
                    Return 0
                ElseIf testDict.Count = 1 OrElse Enumerable.ElementAt(Of KeyValuePair(Of Global.System.Int32, Global.System.Int32))(testDict, CInt(0)).Value >= 4 Then
                    Return testDict.Keys.ElementAt(0) * 4
                ElseIf Enumerable.ElementAt(Of KeyValuePair(Of Global.System.Int32, Global.System.Int32))(testDict, CInt(1)).Value >= 4 Then
                    Return testDict.Keys.ElementAt(1) * 4
                Else
                    Return 0
                End If
            'Little Straight: 1 - 2 - 3 - 4 - 5. Score varies. Often 30.
            Case YachtCategory.LittleStraight
                Return If(dice.OrderBy(Function(x) x).SequenceEqual({1, 2, 3, 4, 5}), 30, 0)
            'Big Straight:    2 - 3 - 4 - 5 - 6. Score varies. Often 30.
            Case YachtCategory.BigStraight
                Return If(dice.OrderBy(Function(x) x).SequenceEqual({2, 3, 4, 5, 6}), 30, 0)
            'Choice: Any combination. Sum of all dice Dice.
            Case YachtCategory.Choice
                Return dice.Sum()
            'Yacht: All five dice showing the same face - scores 50.
            Case YachtCategory.Yacht
                Return If(dice.Distinct().Count() = 1, 50, 0)
            Case Else
                Return 0
        End Select
    End Function
End Module
