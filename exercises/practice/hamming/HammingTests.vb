Imports System
Imports Xunit

Public Class HammingTests
    <Fact>
    Public Sub Empty_strands()
        Assert.Equal(0, Distance("", ""))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Single_letter_identical_strands()
        Assert.Equal(0, Distance("A", "A"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Single_letter_different_strands()
        Assert.Equal(1, Distance("G", "T"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Long_identical_strands()
        Assert.Equal(0, Distance("GGACTGAAATCTG", "GGACTGAAATCTG"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Long_different_strands()
        Assert.Equal(9, Distance("GGACGGATTCTG", "AGGACGGATTCT"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Disallow_first_strand_longer()
        Assert.Throws(Of ArgumentException)(Function() Distance("AATG", "AAA"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Disallow_second_strand_longer()
        Assert.Throws(Of ArgumentException)(Function() Distance("ATA", "AGTG"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Disallow_empty_first_strand()
        Assert.Throws(Of ArgumentException)(Function() Distance("", "G"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Disallow_empty_second_strand()
        Assert.Throws(Of ArgumentException)(Function() Distance("G", ""))
    End Sub
End Class
