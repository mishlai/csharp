Imports System
Imports System.Collections.Immutable

Public Class HangmanState
    Public ReadOnly Property MaskedWordProp As String
    Public ReadOnly Property GuessedCharsProp As ImmutableHashSet(Of Char)
    Public ReadOnly Property RemainingGuessesProp As Integer

    Public Sub New(ByVal maskedWord As String, ByVal guessedChars As ImmutableHashSet(Of Char), ByVal remainingGuesses As Integer)
        Me.MaskedWord = maskedWord
        Me.GuessedChars = guessedChars
        Me.RemainingGuesses = remainingGuesses
    End Sub
End Class

Public Class TooManyGuessesException
    Inherits Exception
End Class

Public Class Hangman
    Public ReadOnly Property StateObservableProp As IObservable(Of HangmanState)
        Get
            Return CSharpImpl.__Throw(Of Object)(New NotImplementedException("You need to implement this function."))
        End Get
    End Property
    Public ReadOnly Property GuessObserverProp As IObserver(Of Char)
        Get
            Return CSharpImpl.__Throw(Of Object)(New NotImplementedException("You need to implement this function."))
        End Get
    End Property

    Public Sub New(ByVal word As String)
        Throw New NotImplementedException("You need to implement this function.")
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal throw statements")>
        Shared Function __Throw(Of T)(ByVal e As Exception) As T
            Throw e
        End Function
    End Class
End Class
