Imports System.Linq
Imports System.Numerics
Imports Xunit

Public Class DiffieHellmanTests
    <Fact>
    Public Sub Private_key_is_greater_than_1_and_less_than_p()
        Dim p = New BigInteger(7919)
        Dim privateKeys = Enumerable.Range(0, 1000).[Select](Function(__) PrivateKey(p)).ToArray()
        For Each privateKey In privateKeys
            Assert.InRange(privateKey, New BigInteger(1), p)
        Next
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Private_key_is_random()
        Dim p = New BigInteger(7919)
        Dim privateKeys = Enumerable.Range(0, 1000).[Select](Function(__) PrivateKey(p)).ToArray()
        Assert.InRange(privateKeys.Distinct().Count(), privateKeys.Length - 100, privateKeys.Length)
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Can_calculate_public_key_using_private_key()
        Dim p = New BigInteger(23)
        Dim g = New BigInteger(5)
        Dim privateKey = New BigInteger(6)
        Assert.Equal(New BigInteger(8), PublicKey(p, g, privateKey))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Can_calculate_public_key_when_given_a_different_private_key()
        Dim p = New BigInteger(23)
        Dim g = New BigInteger(5)
        Dim privateKey = New BigInteger(15)
        Assert.Equal(New BigInteger(19), PublicKey(p, g, privateKey))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Can_calculate_secret_using_other_partys_public_key()
        Dim p = New BigInteger(23)
        Dim theirPublicKey = New BigInteger(19)
        Dim myPrivateKey = New BigInteger(6)
        Assert.Equal(New BigInteger(2), Secret(p, theirPublicKey, myPrivateKey))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Key_exchange()
        Dim p = New BigInteger(23)
        Dim g = New BigInteger(5)
        Dim alicePrivateKey = PrivateKey(p)
        Dim bobPrivateKey = PrivateKey(p)
        Dim alicePublicKey = PublicKey(p, g, alicePrivateKey)
        Dim bobPublicKey = PublicKey(p, g, bobPrivateKey)
        Dim secretA = Secret(p, bobPublicKey, alicePrivateKey)
        Dim secretB = Secret(p, alicePublicKey, bobPrivateKey)
        Assert.Equal(secretA, secretB)
    End Sub
End Class
