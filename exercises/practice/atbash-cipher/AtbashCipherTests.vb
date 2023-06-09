Imports Xunit

Public Class AtbashCipherTests
    <Fact>
    Public Sub Encode_yes()
        Assert.Equal("bvh", Encode("yes"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Encode_no()
        Assert.Equal("ml", Encode("no"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Encode_omg()
        Assert.Equal("lnt", Encode("OMG"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Encode_spaces()
        Assert.Equal("lnt", Encode("O M G"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Encode_mindblowingly()
        Assert.Equal("nrmwy oldrm tob", Encode("mindblowingly"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Encode_numbers()
        Assert.Equal("gvhgr mt123 gvhgr mt", Encode("Testing,1 2 3, testing."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Encode_deep_thought()
        Assert.Equal("gifgs rhurx grlm", Encode("Truth is fiction."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Encode_all_the_letters()
        Assert.Equal("gsvjf rxpyi ldmul cqfnk hlevi gsvoz abwlt", Encode("The quick brown fox jumps over the lazy dog."))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Decode_exercism()
        Assert.Equal("exercism", Decode("vcvix rhn"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Decode_a_sentence()
        Assert.Equal("anobstacleisoftenasteppingstone", Decode("zmlyh gzxov rhlug vmzhg vkkrm thglm v"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Decode_numbers()
        Assert.Equal("testing123testing", Decode("gvhgr mt123 gvhgr mt"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Decode_all_the_letters()
        Assert.Equal("thequickbrownfoxjumpsoverthelazydog", Decode("gsvjf rxpyi ldmul cqfnk hlevi gsvoz abwlt"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Decode_with_too_many_spaces()
        Assert.Equal("exercism", Decode("vc vix    r hn"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Decode_with_no_spaces()
        Assert.Equal("anobstacleisoftenasteppingstone", Decode("zmlyhgzxovrhlugvmzhgvkkrmthglmv"))
    End Sub
End Class
