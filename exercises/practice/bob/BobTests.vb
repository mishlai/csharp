Imports Xunit

Public Class BobTests
    <Fact>
    Public Sub Stating_something()
        Assert.Equal("Whatever.", Response("Tom-ay-to, tom-aaaah-to."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Shouting()
        Assert.Equal("Whoa, chill out!", Response("WATCH OUT!"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Shouting_gibberish()
        Assert.Equal("Whoa, chill out!", Response("FCECDFCAAB"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Asking_a_question()
        Assert.Equal("Sure.", Response("Does this cryogenic chamber make me look fat?"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Asking_a_numeric_question()
        Assert.Equal("Sure.", Response("You are, what, like 15?"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Asking_gibberish()
        Assert.Equal("Sure.", Response("fffbbcbeab?"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Talking_forcefully()
        Assert.Equal("Whatever.", Response("Hi there!"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Using_acronyms_in_regular_speech()
        Assert.Equal("Whatever.", Response("It's OK if you don't want to go work for NASA."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Forceful_question()
        Assert.Equal("Calm down, I know what I'm doing!", Response("WHAT'S GOING ON?"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Shouting_numbers()
        Assert.Equal("Whoa, chill out!", Response("1, 2, 3 GO!"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub No_letters()
        Assert.Equal("Whatever.", Response("1, 2, 3"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Question_with_no_letters()
        Assert.Equal("Sure.", Response("4?"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Shouting_with_special_characters()
        Assert.Equal("Whoa, chill out!", Response("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Shouting_with_no_exclamation_mark()
        Assert.Equal("Whoa, chill out!", Response("I HATE THE DENTIST"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Statement_containing_question_mark()
        Assert.Equal("Whatever.", Response("Ending with ? means a question."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Non_letters_with_question()
        Assert.Equal("Sure.", Response(":) ?"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Prattling_on()
        Assert.Equal("Sure.", Response("Wait! Hang on. Are you going to be OK?"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Silence()
        Assert.Equal("Fine. Be that way!", Response(""))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Prolonged_silence()
        Assert.Equal("Fine. Be that way!", Response("          "))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Alternate_silence()
        Assert.Equal("Fine. Be that way!", Response(vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Multiple_line_question()
        Assert.Equal("Whatever.", Response(vbLf & "Does this cryogenic chamber make me look fat?" & vbLf & "No."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Starting_with_whitespace()
        Assert.Equal("Whatever.", Response("         hmmmmmmm..."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Ending_with_whitespace()
        Assert.Equal("Sure.", Response("Okay if like my  spacebar  quite a bit?   "))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Other_whitespace()
        Assert.Equal("Fine. Be that way!", Response(vbLf & vbCr & " " & vbTab))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Non_question_ending_with_whitespace()
        Assert.Equal("Whatever.", Response("This is a statement ending with whitespace      "))
    End Sub
End Class
