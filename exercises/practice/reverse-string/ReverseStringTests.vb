Imports Xunit

Public Class ReverseStringTests
    <Fact>
    Public Sub An_empty_string()
        Assert.Equal("", Reverse(""))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_word()
        Assert.Equal("tobor", Reverse("robot"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_capitalized_word()
        Assert.Equal("nemaR", Reverse("Ramen"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_sentence_with_punctuation()
        Assert.Equal("!yrgnuh m'I", Reverse("I'm hungry!"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_palindrome()
        Assert.Equal("racecar", Reverse("racecar"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub An_even_sized_word()
        Assert.Equal("reward", Reverse("drawer"))
    End Sub
End Class
