Imports System
Imports System.Linq
Imports System.Collections.Generic

Public Class Anagram
    Private baseWord As String

    Public Sub New(ByVal baseWord As String)
        Me.baseWord = baseWord
    End Sub

    Public Function FindAnagrams(ByVal potentialMatches As String()) As String()
        Dim matches As List(Of String) = New List(Of String)()

        For Each word In potentialMatches
            If IsWordAnagramOfBaseWord(word) Then
                matches.Add(word)
            End If
        Next

        Return matches.ToArray()
    End Function

    Private Function IsWordAnagramOfBaseWord(ByVal word As String) As Boolean
        Return IsNotTheSameWordAsBaseWord(word) AndAlso HasSameLettersAsBaseWord(word)
    End Function

    Private Function IsNotTheSameWordAsBaseWord(ByVal word As String) As Boolean
        Return Not baseWord.Equals(word, StringComparison.OrdinalIgnoreCase)
    End Function

    Private Function HasSameLettersAsBaseWord(ByVal word As String) As Boolean
        Return SortedCharArrayForString(baseWord).Equals(SortedCharArrayForString(word))
    End Function

    Private Function SortedCharArrayForString(ByVal word As String) As String
        Return String.Concat(word.ToLower().OrderBy(Function(letter) letter))
    End Function
End Class
