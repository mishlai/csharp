Imports System
Imports Xunit
Imports Microsoft.Reactive.Testing
Imports System.Collections.Generic
Imports System.Collections.Immutable
Imports System.Reactive.Concurrency

Public Class HangmanTests
    Inherits ReactiveTest
    <Fact>
    Public Sub Initial_state_masks_the_word()
        Dim hangman = New Hangman("foo")
        Dim actual = ""

        ' +a->
        hangman.StateObservable.Subscribe(Sub(x) actual = x.MaskedWord, Sub(ex)
                                                                            Throw New Exception("Should not finish with too many tries")
                                                                        End Sub, Sub()
                                                                                     Throw New Exception("Should not win yet")
                                                                                 End Sub)
        Assert.Equal("___", actual)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Initial_state_has_9_remaining_guesses()
        Dim hangman = New Hangman("foo")
        Dim actual = 9

        ' +a->
        hangman.StateObservable.Subscribe(Sub(x) actual = x.RemainingGuesses)

        Assert.Equal(9, actual)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Initial_state_has_no_guessed_chars()
        Dim hangman = New Hangman("foo")
        Dim actual = New HashSet(Of Char) From {
            "x"c
        }.ToImmutableHashSet()

        ' +a->
        hangman.StateObservable.Subscribe(Sub(x) actual = x.GuessedChars)

        Assert.Equal(New HashSet(Of Char)().ToImmutableHashSet(), actual)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Guess_changes_state()
        Dim hangman = New Hangman("foo")
        Dim actual As HangmanState = Nothing
        hangman.StateObservable.Subscribe(Sub(x) actual = x)
        Dim initial = actual

        ' +--x->
        ' +a-b->
        hangman.GuessObserver.OnNext("x"c)

        Assert.NotEqual(initial, actual)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Wrong_guess_decrements_remaining_guesses()
        Dim hangman = New Hangman("foo")
        Dim actual As HangmanState = Nothing
        hangman.StateObservable.Subscribe(Sub(x) actual = x)
        Dim initial = actual

        ' +--x->
        ' +a-b->
        hangman.GuessObserver.OnNext("x"c)

        Assert.Equal(initial.RemainingGuesses - 1, actual.RemainingGuesses)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub After_10_incorrect_guesses_the_game_is_over()
        Dim scheduler = New TestScheduler()
                ''' Cannot convert LocalFunctionStatementSyntax, CONVERSION ERROR: Conversion for LocalFunctionStatement not implemented, please report this issue in 'System.IObservable<HangmanS...' at character 2657
''' 
''' 
''' Input:
'''         System.IObservable<HangmanState> Create()
        {
            var hangman = new Hangman("foo");
            for (var i = 1; i <= 10; i++)
            {
                scheduler.Schedule(System.TimeSpan.FromTicks(i * 100), () => hangman.GuessObserver.OnNext('x'));
            }

            return hangman.StateObservable;
        }

''' 

        Dim expected = {OnNext(Of HangmanState)(100, Function(hangmanState) hangmanState.RemainingGuesses = 9), OnNext(Of HangmanState)(200, Function(hangmanState) hangmanState.RemainingGuesses = 8), OnNext(Of HangmanState)(300, Function(hangmanState) hangmanState.RemainingGuesses = 7), OnNext(Of HangmanState)(400, Function(hangmanState) hangmanState.RemainingGuesses = 6), OnNext(Of HangmanState)(500, Function(hangmanState) hangmanState.RemainingGuesses = 5), OnNext(Of HangmanState)(600, Function(hangmanState) hangmanState.RemainingGuesses = 4), OnNext(Of HangmanState)(700, Function(hangmanState) hangmanState.RemainingGuesses = 3), OnNext(Of HangmanState)(800, Function(hangmanState) hangmanState.RemainingGuesses = 2), OnNext(Of HangmanState)(900, Function(hangmanState) hangmanState.RemainingGuesses = 1), OnNext(Of HangmanState)(1000, Function(hangmanState) hangmanState.RemainingGuesses = 0), OnError(Of HangmanState)(1100, Function(ex) TypeOf ex Is TooManyGuessesException)}

        ' +--x-x-x-x-x-x-x-x-x-x->
        ' +a-b-c-d-e-f-g-h-i-j-#
        Dim testableObserver As ITestableObserver(Of HangmanState) = scheduler.Start(New Func(Of IObservable(Of HangmanState))(AddressOf Create), 100, 100, 3000)

        ReactiveAssert.AreElementsEqual(expected, testableObserver.Messages)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Correctly_guessing_a_letter_unmasks_it()
        Dim scheduler = New TestScheduler()
                ''' Cannot convert LocalFunctionStatementSyntax, CONVERSION ERROR: Conversion for LocalFunctionStatement not implemented, please report this issue in 'System.IObservable<HangmanS...' at character 4566
''' 
''' 
''' Input:
'''         System.IObservable<HangmanState> Create()
        {
            var hangman = new Hangman("foobar");
            scheduler.Schedule(System.TimeSpan.FromTicks(100), () => hangman.GuessObserver.OnNext('b'));
            scheduler.Schedule(System.TimeSpan.FromTicks(200), () => hangman.GuessObserver.OnNext('o'));
            return hangman.StateObservable;
        }

''' 

        Dim expected = {OnNext(Of HangmanState)(100, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "______")), OnNext(Of HangmanState)(200, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "___b__")), OnNext(Of HangmanState)(300, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "_oob__"))}

        ' +--b-o->
        ' +a-b-c->
        Dim testableObserver As ITestableObserver(Of HangmanState) = scheduler.Start(New Func(Of IObservable(Of HangmanState))(AddressOf Create), 100, 100, 3000)

        ReactiveAssert.AreElementsEqual(expected, testableObserver.Messages)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Guessing_a_correct_letter_twice_counts_as_a_failure()
        Dim scheduler = New TestScheduler()
                ''' Cannot convert LocalFunctionStatementSyntax, CONVERSION ERROR: Conversion for LocalFunctionStatement not implemented, please report this issue in 'System.IObservable<HangmanS...' at character 5888
''' 
''' 
''' Input:
'''         System.IObservable<HangmanState> Create()
        {
            var hangman = new Hangman("foobar");
            scheduler.Schedule(System.TimeSpan.FromTicks(100), () => hangman.GuessObserver.OnNext('b'));
            scheduler.Schedule(System.TimeSpan.FromTicks(200), () => hangman.GuessObserver.OnNext('b'));
            return hangman.StateObservable;
        }

''' 

        Dim expected = {OnNext(Of HangmanState)(100, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "______")), OnNext(Of HangmanState)(200, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "___b__")), OnNext(Of HangmanState)(300, Function(hangmanState) hangmanState.RemainingGuesses = 8 AndAlso Equals(hangmanState.MaskedWord, "___b__"))}

        ' +--b-b->
        ' +a-b-c->
        Dim testableObserver As ITestableObserver(Of HangmanState) = scheduler.Start(New Func(Of IObservable(Of HangmanState))(AddressOf Create), 100, 100, 3000)

        ReactiveAssert.AreElementsEqual(expected, testableObserver.Messages)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Getting_all_the_letters_right_makes_for_a_win()
        Dim scheduler = New TestScheduler()
                ''' Cannot convert LocalFunctionStatementSyntax, CONVERSION ERROR: Conversion for LocalFunctionStatement not implemented, please report this issue in 'System.IObservable<HangmanS...' at character 7204
''' 
''' 
''' Input:
'''         System.IObservable<HangmanState> Create()
        {
            var hangman = new Hangman("hello");
            scheduler.Schedule(System.TimeSpan.FromTicks(100), () => hangman.GuessObserver.OnNext('b'));
            scheduler.Schedule(System.TimeSpan.FromTicks(200), () => hangman.GuessObserver.OnNext('e'));
            scheduler.Schedule(System.TimeSpan.FromTicks(300), () => hangman.GuessObserver.OnNext('l'));
            scheduler.Schedule(System.TimeSpan.FromTicks(400), () => hangman.GuessObserver.OnNext('o'));
            scheduler.Schedule(System.TimeSpan.FromTicks(500), () => hangman.GuessObserver.OnNext('h'));
            return hangman.StateObservable;
        }

''' 

        Dim expected = {OnNext(Of HangmanState)(100, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "_____")), OnNext(Of HangmanState)(200, Function(hangmanState) hangmanState.RemainingGuesses = 8 AndAlso Equals(hangmanState.MaskedWord, "_____")), OnNext(Of HangmanState)(300, Function(hangmanState) hangmanState.RemainingGuesses = 8 AndAlso Equals(hangmanState.MaskedWord, "_e___")), OnNext(Of HangmanState)(400, Function(hangmanState) hangmanState.RemainingGuesses = 8 AndAlso Equals(hangmanState.MaskedWord, "_ell_")), OnNext(Of HangmanState)(500, Function(hangmanState) hangmanState.RemainingGuesses = 8 AndAlso Equals(hangmanState.MaskedWord, "_ello")), OnCompleted(Of HangmanState)(600)}

        ' +--b-e-l-o-h->
        ' +a-b-c-d-e-|
        Dim testableObserver As ITestableObserver(Of HangmanState) = scheduler.Start(New Func(Of IObservable(Of HangmanState))(AddressOf Create), 100, 100, 3000)

        ReactiveAssert.AreElementsEqual(expected, testableObserver.Messages)
    End Sub

    ' Advanced mode on>
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Second_player_sees_the_same_game_already_started()
        Dim scheduler = New TestScheduler()
        Dim player2 = scheduler.CreateObserver(Of HangmanState)()
        Dim hangman = New Hangman("hello")

        Dim player1 = hangman.StateObservable
        Ready(player1)

        scheduler.Schedule(TimeSpan.FromTicks(100), Sub() hangman.GuessObserver.OnNext("e"c))
        scheduler.Schedule(TimeSpan.FromTicks(200), Sub() hangman.GuessObserver.OnNext("l"c))
        scheduler.Schedule(TimeSpan.FromTicks(150), Sub() hangman.StateObservable.Subscribe(player2))

        Dim expected = {OnNext(Of HangmanState)(150, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "_e___")), OnNext(Of HangmanState)(200, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "_ell_"))}

        ' +--e--l->
        ' +a-b--c->
        ' ...+b-c->
        scheduler.Start()

        ReactiveAssert.AreElementsEqual(expected, player2.Messages)
    End Sub

    Private Function Ready(ByVal player As IObservable(Of HangmanState)) As IDisposable
        Return player.Subscribe(Sub(x)
                                End Sub)
    End Function

    ' Expert mode on>
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Multiple_players_see_the_same_game_already_started()
        Dim scheduler = New TestScheduler()
        Dim player2 = scheduler.CreateObserver(Of HangmanState)()
        Dim player3 = scheduler.CreateObserver(Of HangmanState)()
        Dim hangman = New Hangman("hello")

        Dim player1 = hangman.StateObservable
        Ready(player1)

        scheduler.Schedule(TimeSpan.FromTicks(100), Sub() hangman.GuessObserver.OnNext("e"c))
        scheduler.Schedule(TimeSpan.FromTicks(200), Sub() hangman.GuessObserver.OnNext("l"c))
        scheduler.Schedule(TimeSpan.FromTicks(150), Sub()
                                                        hangman.StateObservable.Subscribe(player2)
                                                        hangman.StateObservable.Subscribe(player3)
                                                    End Sub)

        Dim expected = {OnNext(Of HangmanState)(150, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "_e___")), OnNext(Of HangmanState)(200, Function(hangmanState) hangmanState.RemainingGuesses = 9 AndAlso Equals(hangmanState.MaskedWord, "_ell_"))}

        ' +--e--l->
        ' +a-b--c->
        ' ...+b-c->
        ' ...+b-c->
        scheduler.Start()

        ReactiveAssert.AreElementsEqual(expected, player2.Messages)
        ReactiveAssert.AreElementsEqual(expected, player3.Messages)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Player_joins_after_other_players_quit()
        Dim scheduler = New TestScheduler()
        Dim player2 = scheduler.CreateObserver(Of HangmanState)()
        Dim hangman = New Hangman("a")

        Dim player1 = hangman.StateObservable
        Dim subscription = Ready(player1)

        scheduler.Schedule(TimeSpan.FromTicks(100), Sub() hangman.GuessObserver.OnNext("a"c))
        scheduler.Schedule(TimeSpan.FromTicks(300), Sub() hangman.StateObservable.Subscribe(player2))
        scheduler.Schedule(TimeSpan.FromTicks(200), Sub() subscription.Dispose())

        Dim expected = {OnCompleted(Of HangmanState)(300)}

        ' +--a-|
        ' +a-|
        ' .....+|
        scheduler.Start()

        ReactiveAssert.AreElementsEqual(expected, player2.Messages)
    End Sub
End Class
