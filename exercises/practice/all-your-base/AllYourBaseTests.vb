Imports System
Imports Xunit

Public Class AllYourBaseTests
    <Fact>
    Public Sub Single_bit_one_to_decimal()
        Dim inputBase = 2
        Dim digits = {1}
        Dim outputBase = 10
        Dim expected = {1}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_to_single_decimal()
        Dim inputBase = 2
        Dim digits = {1, 0, 1}
        Dim outputBase = 10
        Dim expected = {5}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Single_decimal_to_binary()
        Dim inputBase = 10
        Dim digits = {5}
        Dim outputBase = 2
        Dim expected = {1, 0, 1}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Binary_to_multiple_decimal()
        Dim inputBase = 2
        Dim digits = {1, 0, 1, 0, 1, 0}
        Dim outputBase = 10
        Dim expected = {4, 2}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Decimal_to_binary()
        Dim inputBase = 10
        Dim digits = {4, 2}
        Dim outputBase = 2
        Dim expected = {1, 0, 1, 0, 1, 0}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Trinary_to_hexadecimal()
        Dim inputBase = 3
        Dim digits = {1, 1, 2, 0}
        Dim outputBase = 16
        Dim expected = {2, 10}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Hexadecimal_to_trinary()
        Dim inputBase = 16
        Dim digits = {2, 10}
        Dim outputBase = 3
        Dim expected = {1, 1, 2, 0}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Number_15_bit_integer()
        Dim inputBase = 97
        Dim digits = {3, 46, 60}
        Dim outputBase = 73
        Dim expected = {6, 10, 45}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Empty_list()
        Dim inputBase = 2
        Dim digits = Array.Empty(Of Integer)()
        Dim outputBase = 10
        Dim expected = {0}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Single_zero()
        Dim inputBase = 10
        Dim digits = {0}
        Dim outputBase = 2
        Dim expected = {0}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Multiple_zeros()
        Dim inputBase = 10
        Dim digits = {0, 0, 0}
        Dim outputBase = 2
        Dim expected = {0}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Leading_zeros()
        Dim inputBase = 7
        Dim digits = {0, 6, 0}
        Dim outputBase = 10
        Dim expected = {4, 2}
        Assert.Equal(expected, Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Input_base_is_one()
        Dim inputBase = 1
        Dim digits = {0}
        Dim outputBase = 10
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Input_base_is_zero()
        Dim inputBase = 0
        Dim digits = Array.Empty(Of Integer)()
        Dim outputBase = 10
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Input_base_is_negative()
        Dim inputBase = -2
        Dim digits = {1}
        Dim outputBase = 10
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Negative_digit()
        Dim inputBase = 2
        Dim digits = {1, -1, 1, 0, 1, 0}
        Dim outputBase = 10
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Invalid_positive_digit()
        Dim inputBase = 2
        Dim digits = {1, 2, 1, 0, 1, 0}
        Dim outputBase = 10
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Output_base_is_one()
        Dim inputBase = 2
        Dim digits = {1, 0, 1, 0, 1, 0}
        Dim outputBase = 1
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Output_base_is_zero()
        Dim inputBase = 10
        Dim digits = {7}
        Dim outputBase = 0
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Output_base_is_negative()
        Dim inputBase = 2
        Dim digits = {1}
        Dim outputBase = -7
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Both_bases_are_negative()
        Dim inputBase = -2
        Dim digits = {1}
        Dim outputBase = -7
        Assert.Throws(Of ArgumentException)(Function() Rebase(inputBase, digits, outputBase))
    End Sub
End Class
