Imports Xunit

Public Class TwoFerTests
    <Fact>
    Public Sub No_name_given()
        Assert.Equal("One for you, one for me.", Speak())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_name_given()
        Assert.Equal("One for Alice, one for me.", Speak("Alice"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Another_name_given()
        Assert.Equal("One for Bob, one for me.", Speak("Bob"))
    End Sub
End Class
