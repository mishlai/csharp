Imports Xunit

Public Class AllergiesTests
    <Fact>
    Public Sub Testing_for_eggs_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Eggs))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_eggs_allergy_allergic_only_to_eggs()
        Dim sut = New Allergies(1)
        Assert.True(sut.IsAllergicTo(Allergen.Eggs))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_eggs_allergy_allergic_to_eggs_and_something_else()
        Dim sut = New Allergies(3)
        Assert.True(sut.IsAllergicTo(Allergen.Eggs))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_eggs_allergy_allergic_to_something_but_not_eggs()
        Dim sut = New Allergies(2)
        Assert.False(sut.IsAllergicTo(Allergen.Eggs))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_eggs_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Eggs))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_peanuts_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Peanuts))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_peanuts_allergy_allergic_only_to_peanuts()
        Dim sut = New Allergies(2)
        Assert.True(sut.IsAllergicTo(Allergen.Peanuts))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_peanuts_allergy_allergic_to_peanuts_and_something_else()
        Dim sut = New Allergies(7)
        Assert.True(sut.IsAllergicTo(Allergen.Peanuts))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_peanuts_allergy_allergic_to_something_but_not_peanuts()
        Dim sut = New Allergies(5)
        Assert.False(sut.IsAllergicTo(Allergen.Peanuts))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_peanuts_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Peanuts))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_shellfish_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Shellfish))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_shellfish_allergy_allergic_only_to_shellfish()
        Dim sut = New Allergies(4)
        Assert.True(sut.IsAllergicTo(Allergen.Shellfish))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_shellfish_allergy_allergic_to_shellfish_and_something_else()
        Dim sut = New Allergies(14)
        Assert.True(sut.IsAllergicTo(Allergen.Shellfish))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_shellfish_allergy_allergic_to_something_but_not_shellfish()
        Dim sut = New Allergies(10)
        Assert.False(sut.IsAllergicTo(Allergen.Shellfish))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_shellfish_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Shellfish))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_strawberries_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Strawberries))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_strawberries_allergy_allergic_only_to_strawberries()
        Dim sut = New Allergies(8)
        Assert.True(sut.IsAllergicTo(Allergen.Strawberries))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_strawberries_allergy_allergic_to_strawberries_and_something_else()
        Dim sut = New Allergies(28)
        Assert.True(sut.IsAllergicTo(Allergen.Strawberries))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_strawberries_allergy_allergic_to_something_but_not_strawberries()
        Dim sut = New Allergies(20)
        Assert.False(sut.IsAllergicTo(Allergen.Strawberries))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_strawberries_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Strawberries))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_tomatoes_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Tomatoes))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_tomatoes_allergy_allergic_only_to_tomatoes()
        Dim sut = New Allergies(16)
        Assert.True(sut.IsAllergicTo(Allergen.Tomatoes))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_tomatoes_allergy_allergic_to_tomatoes_and_something_else()
        Dim sut = New Allergies(56)
        Assert.True(sut.IsAllergicTo(Allergen.Tomatoes))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_tomatoes_allergy_allergic_to_something_but_not_tomatoes()
        Dim sut = New Allergies(40)
        Assert.False(sut.IsAllergicTo(Allergen.Tomatoes))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_tomatoes_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Tomatoes))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_chocolate_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Chocolate))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_chocolate_allergy_allergic_only_to_chocolate()
        Dim sut = New Allergies(32)
        Assert.True(sut.IsAllergicTo(Allergen.Chocolate))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_chocolate_allergy_allergic_to_chocolate_and_something_else()
        Dim sut = New Allergies(112)
        Assert.True(sut.IsAllergicTo(Allergen.Chocolate))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_chocolate_allergy_allergic_to_something_but_not_chocolate()
        Dim sut = New Allergies(80)
        Assert.False(sut.IsAllergicTo(Allergen.Chocolate))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_chocolate_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Chocolate))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_pollen_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Pollen))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_pollen_allergy_allergic_only_to_pollen()
        Dim sut = New Allergies(64)
        Assert.True(sut.IsAllergicTo(Allergen.Pollen))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_pollen_allergy_allergic_to_pollen_and_something_else()
        Dim sut = New Allergies(224)
        Assert.True(sut.IsAllergicTo(Allergen.Pollen))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_pollen_allergy_allergic_to_something_but_not_pollen()
        Dim sut = New Allergies(160)
        Assert.False(sut.IsAllergicTo(Allergen.Pollen))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_pollen_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Pollen))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_cats_allergy_not_allergic_to_anything()
        Dim sut = New Allergies(0)
        Assert.False(sut.IsAllergicTo(Allergen.Cats))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_cats_allergy_allergic_only_to_cats()
        Dim sut = New Allergies(128)
        Assert.True(sut.IsAllergicTo(Allergen.Cats))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_cats_allergy_allergic_to_cats_and_something_else()
        Dim sut = New Allergies(192)
        Assert.True(sut.IsAllergicTo(Allergen.Cats))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_cats_allergy_allergic_to_something_but_not_cats()
        Dim sut = New Allergies(64)
        Assert.False(sut.IsAllergicTo(Allergen.Cats))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Testing_for_cats_allergy_allergic_to_everything()
        Dim sut = New Allergies(255)
        Assert.True(sut.IsAllergicTo(Allergen.Cats))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub No_allergies()
        Dim sut = New Allergies(0)
        Assert.Empty(sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Just_eggs()
        Dim sut = New Allergies(1)
        Dim expected = {Allergen.Eggs}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Just_peanuts()
        Dim sut = New Allergies(2)
        Dim expected = {Allergen.Peanuts}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Just_strawberries()
        Dim sut = New Allergies(8)
        Dim expected = {Allergen.Strawberries}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Eggs_and_peanuts()
        Dim sut = New Allergies(3)
        Dim expected = {Allergen.Eggs, Allergen.Peanuts}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub More_than_eggs_but_not_peanuts()
        Dim sut = New Allergies(5)
        Dim expected = {Allergen.Eggs, Allergen.Shellfish}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Lots_of_stuff()
        Dim sut = New Allergies(248)
        Dim expected = {Allergen.Strawberries, Allergen.Tomatoes, Allergen.Chocolate, Allergen.Pollen, Allergen.Cats}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Everything()
        Dim sut = New Allergies(255)
        Dim expected = {Allergen.Eggs, Allergen.Peanuts, Allergen.Shellfish, Allergen.Strawberries, Allergen.Tomatoes, Allergen.Chocolate, Allergen.Pollen, Allergen.Cats}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub No_allergen_score_parts()
        Dim sut = New Allergies(509)
        Dim expected = {Allergen.Eggs, Allergen.Shellfish, Allergen.Strawberries, Allergen.Tomatoes, Allergen.Chocolate, Allergen.Pollen, Allergen.Cats}
        Assert.Equal(expected, sut.List())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub No_allergen_score_parts_without_highest_valid_score()
        Dim sut = New Allergies(257)
        Dim expected = {Allergen.Eggs}
        Assert.Equal(expected, sut.List())
    End Sub
End Class
