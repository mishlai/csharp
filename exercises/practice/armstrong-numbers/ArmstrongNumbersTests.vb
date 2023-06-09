Imports Xunit

Public Class ArmstrongNumbersTests
    <Fact>
    Public Sub Zero_is_an_armstrong_number()
        Assert.True(IsArmstrongNumber(0))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Single_digit_numbers_are_armstrong_numbers()
        Assert.True(IsArmstrongNumber(5))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub There_are_no_two_digit_armstrong_numbers()
        Assert.False(IsArmstrongNumber(10))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Three_digit_number_that_is_an_armstrong_number()
        Assert.True(IsArmstrongNumber(153))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Three_digit_number_that_is_not_an_armstrong_number()
        Assert.False(IsArmstrongNumber(100))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Four_digit_number_that_is_an_armstrong_number()
        Assert.True(IsArmstrongNumber(9474))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Four_digit_number_that_is_not_an_armstrong_number()
        Assert.False(IsArmstrongNumber(9475))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Seven_digit_number_that_is_an_armstrong_number()
        Assert.True(IsArmstrongNumber(9926315))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Seven_digit_number_that_is_not_an_armstrong_number()
        Assert.False(IsArmstrongNumber(9926314))
    End Sub
End Class
