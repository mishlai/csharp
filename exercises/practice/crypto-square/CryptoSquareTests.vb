Imports Xunit

Public Class CryptoSquareTests
    <Fact>
    Public Sub Empty_plaintext_results_in_an_empty_ciphertext()
        Dim plaintext = ""
        Dim expected = ""
        Assert.Equal(expected, Ciphertext(plaintext))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Lowercase()
        Dim plaintext = "A"
        Dim expected = "a"
        Assert.Equal(expected, Ciphertext(plaintext))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Remove_spaces()
        Dim plaintext = "  b "
        Dim expected = "b"
        Assert.Equal(expected, Ciphertext(plaintext))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Remove_punctuation()
        Dim plaintext = "@1,%!"
        Dim expected = "1"
        Assert.Equal(expected, Ciphertext(plaintext))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Number_9_character_plaintext_results_in_3_chunks_of_3_characters()
        Dim plaintext = "This is fun!"
        Dim expected = "tsf hiu isn"
        Assert.Equal(expected, Ciphertext(plaintext))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Number_8_character_plaintext_results_in_3_chunks_the_last_one_with_a_trailing_space()
        Dim plaintext = "Chill out."
        Dim expected = "clu hlt io "
        Assert.Equal(expected, Ciphertext(plaintext))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Number_54_character_plaintext_results_in_7_chunks_the_last_two_with_trailing_spaces()
        Dim plaintext = "If man was meant to stay on the ground, god would have given us roots."
        Dim expected = "imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn  sseoau "
        Assert.Equal(expected, Ciphertext(plaintext))
    End Sub
End Class
