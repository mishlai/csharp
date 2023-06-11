Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Xunit

Public Class AccumulateTests
    <Fact>
    Public Sub Empty_accumulation_produces_empty_accumulation()
        Assert.Equal(New Integer(-1) {}, New Integer(-1) {}.Accumulate(Function(x) x * x))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Accumulate_squares()
        Assert.Equal({1, 4, 9}, {1, 2, 3}.Accumulate(Function(x) x * x))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Accumulate_upcases()
        Assert.Equal(New List(Of String) From {
            "HELLO",
            "WORLD"
        }, New List(Of String) From {
            "hello",
            "world"
        }.Accumulate(Function(x) x.ToUpper()))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Accumulate_reversed_strings()
        Assert.Equal("eht kciuq nworb xof cte".Split(" "c), "the quick brown fox etc".Split(" "c).Accumulate(New Func(Of String, String)(AddressOf Reverse)))
    End Sub

    Private Function Reverse(ByVal value As String) As String
        Dim array = value.ToCharArray()
        System.Array.Reverse(array)
        Return New String(array)
    End Function

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Accumulate_within_accumulate()
        Dim actual = {"a", "b", "c"}.Accumulate(Function(c) String.Join(" ", {"1", "2", "3"}.Accumulate(Function(d) c & d)))
        Assert.Equal({"a1 a2 a3", "b1 b2 b3", "c1 c2 c3"}, actual)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Accumulate_is_lazy()
        Dim counter = 0
        Dim accumulation = {1, 2, 3}.Accumulate(Function(x) x * Math.Min(Threading.Interlocked.Increment(counter), counter - 1))

        Assert.Equal(0, counter)
        accumulation.ToList()
        Assert.Equal(3, counter)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Accumulate_allows_different_return_type()
        Assert.Equal({"1", "2", "3"}, {1, 2, 3}.Accumulate(Function(x) x.ToString()))
    End Sub
End Class
