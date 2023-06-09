Imports Xunit

Public Class HexadecimalTest
    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_1_is_decimal_1()
        Assert.Equal(1, Hexadecimal.ToDecimal("1"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_c_is_decimal_12()
        Assert.Equal(12, Hexadecimal.ToDecimal("c"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_10_is_decimal_16()
        Assert.Equal(16, Hexadecimal.ToDecimal("10"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_af_is_decimal_175()
        Assert.Equal(175, Hexadecimal.ToDecimal("af"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_100_is_decimal_256()
        Assert.Equal(256, Hexadecimal.ToDecimal("100"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_19ace_is_decimal_105166()
        Assert.Equal(105166, Hexadecimal.ToDecimal("19ace"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_carrot_is_decimal_0()
        Assert.Equal(0, Hexadecimal.ToDecimal("carrot"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_000000_is_decimal_0()
        Assert.Equal(0, Hexadecimal.ToDecimal("000000"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_ffffff_is_decimal_16777215()
        Assert.Equal(16777215, Hexadecimal.ToDecimal("ffffff"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_ffff00_is_decimal_16776960()
        Assert.Equal(16776960, Hexadecimal.ToDecimal("ffff00"))
    End Sub

End Class
