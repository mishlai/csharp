Imports Xunit

Public Class BinaryTest
    <Fact>
    Public Sub Binary_0_is_decimal_0()
        Assert.Equal(0, Binary.ToDecimal("0"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_1_is_decimal_1()
        Assert.Equal(1, Binary.ToDecimal("1"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_10_is_decimal_2()
        Assert.Equal(2, Binary.ToDecimal("10"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_11_is_decimal_3()
        Assert.Equal(3, Binary.ToDecimal("11"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_100_is_decimal_4()
        Assert.Equal(4, Binary.ToDecimal("100"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_1001_is_decimal_9()
        Assert.Equal(9, Binary.ToDecimal("1001"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_11010_is_decimal_26()
        Assert.Equal(26, Binary.ToDecimal("11010"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_10001101000_is_decimal_1128()
        Assert.Equal(1128, Binary.ToDecimal("10001101000"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_ignores_leading_zeros()
        Assert.Equal(31, Binary.ToDecimal("000011111"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Invalid_binary_2_converts_to_decimal_0()
        Assert.Equal(0, Binary.ToDecimal("2"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_number_containing_a_non_binary_digit_is_invalid()
        Assert.Equal(0, Binary.ToDecimal("01201"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_number_with_trailing_non_binary_characters_is_invalid()
        Assert.Equal(0, Binary.ToDecimal("10nope"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_number_with_leading_non_binary_characters_is_invalid()
        Assert.Equal(0, Binary.ToDecimal("nope10"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_number_with_internal_non_binary_characters_is_invalid()
        Assert.Equal(0, Binary.ToDecimal("10nope10"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub A_number_and_a_word_whitespace_separated_is_invalid()
        Assert.Equal(0, Binary.ToDecimal("001 nope"))
    End Sub
End Class
