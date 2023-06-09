Imports Xunit

Public Class TrinaryTest
    <Fact>
    Public Sub Trinary_1_is_decimal_1()
        Assert.Equal(1, Trinary.ToDecimal("1"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_2_is_decimal_2()
        Assert.Equal(2, Trinary.ToDecimal("2"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_10_is_decimal_3()
        Assert.Equal(3, Trinary.ToDecimal("10"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_11_is_decimal_4()
        Assert.Equal(4, Trinary.ToDecimal("11"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_100_is_decimal_9()
        Assert.Equal(9, Trinary.ToDecimal("100"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_112_is_decimal_14()
        Assert.Equal(14, Trinary.ToDecimal("112"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_222_is_decimal_26()
        Assert.Equal(26, Trinary.ToDecimal("222"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_1122000120_is_decimal_32091()
        Assert.Equal(32091, Trinary.ToDecimal("1122000120"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Invalid_trinary_digits_returns_0()
        Assert.Equal(0, Trinary.ToDecimal("1234"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Invalid_word_as_input_returns_0()
        Assert.Equal(0, Trinary.ToDecimal("carrot"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Invalid_numbers_with_letters_as_input_returns_0()
        Assert.Equal(0, Trinary.ToDecimal("0a1b2c"))
    End Sub
End Class
