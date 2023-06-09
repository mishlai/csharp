Imports Xunit

Public Class AnagramTests
    <Fact>
    Public Sub No_matches()
        Dim candidates = {"hello", "world", "zombies", "pants"}
        Dim sut = New Anagram("diaper")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Detects_two_anagrams()
        Dim candidates = {"lemons", "cherry", "melons"}
        Dim sut = New Anagram("solemn")
        Dim expected = {"lemons", "melons"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Does_not_detect_anagram_subsets()
        Dim candidates = {"dog", "goody"}
        Dim sut = New Anagram("good")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Detects_anagram()
        Dim candidates = {"enlists", "google", "inlets", "banana"}
        Dim sut = New Anagram("listen")
        Dim expected = {"inlets"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Detects_three_anagrams()
        Dim candidates = {"gallery", "ballerina", "regally", "clergy", "largely", "leading"}
        Dim sut = New Anagram("allergy")
        Dim expected = {"gallery", "regally", "largely"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Detects_multiple_anagrams_with_different_case()
        Dim candidates = {"Eons", "ONES"}
        Dim sut = New Anagram("nose")
        Dim expected = {"Eons", "ONES"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Does_not_detect_non_anagrams_with_identical_checksum()
        Dim candidates = {"last"}
        Dim sut = New Anagram("mass")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Detects_anagrams_case_insensitively()
        Dim candidates = {"cashregister", "Carthorse", "radishes"}
        Dim sut = New Anagram("Orchestra")
        Dim expected = {"Carthorse"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Detects_anagrams_using_case_insensitive_subject()
        Dim candidates = {"cashregister", "carthorse", "radishes"}
        Dim sut = New Anagram("Orchestra")
        Dim expected = {"carthorse"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Detects_anagrams_using_case_insensitive_possible_matches()
        Dim candidates = {"cashregister", "Carthorse", "radishes"}
        Dim sut = New Anagram("orchestra")
        Dim expected = {"Carthorse"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Does_not_detect_an_anagram_if_the_original_word_is_repeated()
        Dim candidates = {"go Go GO"}
        Dim sut = New Anagram("go")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Anagrams_must_use_all_letters_exactly_once()
        Dim candidates = {"patter"}
        Dim sut = New Anagram("tapper")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Words_are_not_anagrams_of_themselves()
        Dim candidates = {"BANANA"}
        Dim sut = New Anagram("BANANA")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Words_are_not_anagrams_of_themselves_even_if_letter_case_is_partially_different()
        Dim candidates = {"Banana"}
        Dim sut = New Anagram("BANANA")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Words_are_not_anagrams_of_themselves_even_if_letter_case_is_completely_different()
        Dim candidates = {"banana"}
        Dim sut = New Anagram("BANANA")
        Assert.Empty(sut.FindAnagrams(candidates))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Words_other_than_themselves_can_be_anagrams()
        Dim candidates = {"LISTEN", "Silent"}
        Dim sut = New Anagram("LISTEN")
        Dim expected = {"Silent"}
        Assert.Equal(expected, sut.FindAnagrams(candidates))
    End Sub
End Class
