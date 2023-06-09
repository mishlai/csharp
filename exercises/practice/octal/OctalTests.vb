Imports Xunit

Public Class OctalTest
    <Fact>
    Public Sub Octal_1_is_decimal_1()
        Assert.Equal(1, Octal.ToDecimal("1"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_10_is_decimal_8()
        Assert.Equal(8, Octal.ToDecimal("10"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_17_is_decimal_15()
        Assert.Equal(15, Octal.ToDecimal("17"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_11_is_decimal_9()
        Assert.Equal(9, Octal.ToDecimal("11"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_130_is_decimal_88()
        Assert.Equal(88, Octal.ToDecimal("130"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_2047_is_decimal_1063()
        Assert.Equal(1063, Octal.ToDecimal("2047"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_7777_is_decimal_4095()
        Assert.Equal(4095, Octal.ToDecimal("7777"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_1234567_is_decimal_342391()
        Assert.Equal(342391, Octal.ToDecimal("1234567"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_011_is_decimal_9()
        Assert.Equal(9, Octal.ToDecimal("011"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_carrot_is_decimal_0()
        Assert.Equal(0, Octal.ToDecimal("carrot"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_8_is_decimal_0()
        Assert.Equal(0, Octal.ToDecimal("8"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_9_is_decimal_0()
        Assert.Equal(0, Octal.ToDecimal("9"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_6789_is_decimal_0()
        Assert.Equal(0, Octal.ToDecimal("6789"))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Octal_abc1z_is_decimal_0()
        Assert.Equal(0, Octal.ToDecimal("abc1z"))
    End Sub
End Class
