Imports System.Collections.Generic
Imports Xunit

Public Class HighScoresTests
    <Fact>
    Public Sub List_of_scores()
        Dim sut = New HighScores(New List(Of Integer) From {
            30,
            50,
            20,
            70
        })
        Assert.Equal(New List(Of Integer) From {
            30,
            50,
            20,
            70
        }, sut.Scores())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Latest_score()
        Dim sut = New HighScores(New List(Of Integer) From {
            100,
            0,
            90,
            30
        })
        Assert.Equal(30, sut.Latest())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Personal_best()
        Dim sut = New HighScores(New List(Of Integer) From {
            40,
            100,
            70
        })
        Assert.Equal(100, sut.PersonalBest())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Personal_top_three_from_a_list_of_scores()
        Dim sut = New HighScores(New List(Of Integer) From {
            10,
            30,
            90,
            30,
            100,
            20,
            10,
            0,
            30,
            40,
            40,
            70,
            70
        })
        Assert.Equal(New List(Of Integer) From {
            100,
            90,
            70
        }, sut.PersonalTopThree())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Personal_top_highest_to_lowest()
        Dim sut = New HighScores(New List(Of Integer) From {
            20,
            10,
            30
        })
        Assert.Equal(New List(Of Integer) From {
            30,
            20,
            10
        }, sut.PersonalTopThree())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Personal_top_when_there_is_a_tie()
        Dim sut = New HighScores(New List(Of Integer) From {
            40,
            20,
            40,
            30
        })
        Assert.Equal(New List(Of Integer) From {
            40,
            40,
            30
        }, sut.PersonalTopThree())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Personal_top_when_there_are_less_than_3()
        Dim sut = New HighScores(New List(Of Integer) From {
            30,
            70
        })
        Assert.Equal(New List(Of Integer) From {
            70,
            30
        }, sut.PersonalTopThree())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Personal_top_when_there_is_only_one()
        Dim sut = New HighScores(New List(Of Integer) From {
            40
        })
        Assert.Equal(New List(Of Integer) From {
            40
        }, sut.PersonalTopThree())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Latest_score_after_personal_top_scores()
        Dim sut = New HighScores(New List(Of Integer) From {
            70,
            50,
            20,
            30
        })
        Dim __ = sut.PersonalTopThree()
        Assert.Equal(30, sut.Latest())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Scores_after_personal_top_scores()
        Dim sut = New HighScores(New List(Of Integer) From {
            30,
            50,
            20,
            70
        })
        Dim __ = sut.PersonalTopThree()
        Assert.Equal(New List(Of Integer) From {
            30,
            50,
            20,
            70
        }, sut.Scores())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Latest_score_after_personal_best()
        Dim sut = New HighScores(New List(Of Integer) From {
            20,
            70,
            15,
            25,
            30
        })
        Dim __ = sut.PersonalBest()
        Assert.Equal(30, sut.Latest())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Scores_after_personal_best()
        Dim sut = New HighScores(New List(Of Integer) From {
            20,
            70,
            15,
            25,
            30
        })
        Dim __ = sut.PersonalBest()
        Assert.Equal(New List(Of Integer) From {
            20,
            70,
            15,
            25,
            30
        }, sut.Scores())
    End Sub
End Class
