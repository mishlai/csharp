Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Module AtbashCipher
    Private Const BlockSize As Integer = 5
    Private Const Plain As String = "abcdefghijklmnopqrstuvwxyz0123456789"
    Private Const Cipher As String = "zyxwvutsrqponmlkjihgfedcba0123456789"

    Public Function Encode(ByVal plainValue As String) As String
        Return String.Join(" ", EncodeInBlocks(GetEncodedCharacters(plainValue)))
    End Function

    Public Function Decode(ByVal encodedValue As String) As String
        Return New String(encodedValue.Replace(" ", "").[Select](New Func(Of Char, Char)(AddressOf Decode)).ToArray())
    End Function

    Private Function GetEncodedCharacters(ByVal words As String) As IEnumerable(Of Char)
        Return GetValidCharacters(words).[Select](New Func(Of Char, Char)(AddressOf Encode))
    End Function

    Private Function GetValidCharacters(ByVal words As String) As IEnumerable(Of Char)
        Return words.ToLowerInvariant().Where(New Func(Of Char, Boolean)(AddressOf Char.IsLetterOrDigit))
    End Function

    Private Function Encode(ByVal c As Char) As Char
        Return Cipher(Plain.IndexOf(c))
    End Function

    Private Function Decode(ByVal c As Char) As Char
        Return Plain(Cipher.IndexOf(c))
    End Function

    Private Iterator Function EncodeInBlocks(ByVal value As IEnumerable(Of Char)) As IEnumerable(Of String)
        Dim valueAsString = New String(value.ToArray())

        Dim i = 0

        While i < valueAsString.Length
            Yield valueAsString.Substring(i, Math.Min(BlockSize, valueAsString.Length - i))
            i += BlockSize
        End While
    End Function
End Module
