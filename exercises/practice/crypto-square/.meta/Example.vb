Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Module CryptoSquare
    Public Function NormalizedPlaintext(ByVal plaintext As String) As String
        Return New String(plaintext.ToLowerInvariant().Where(New Func(Of Char, Boolean)(AddressOf Char.IsLetterOrDigit)).ToArray())
    End Function

    Public Function PlaintextSegments(ByVal plaintext As String) As IEnumerable(Of String)
        Dim normalizedPlaintext = CryptoSquare.NormalizedPlaintext(plaintext)
        Return Chunks(normalizedPlaintext, Size(normalizedPlaintext))
    End Function

    Public Function Encoded(ByVal plaintext As String) As String
        Return String.Join("", Transpose(PlaintextSegments(plaintext)))
    End Function

    Public Function Ciphertext(ByVal plaintext As String) As String
        Return String.Join(" ", Transpose(PlaintextSegments(plaintext).Select(Function(x) x.PadRight(Size(NormalizedPlaintext(plaintext))))))
    End Function

    Private Function Size(ByVal normalizedPlaintext As String) As Integer
        Return Math.Ceiling(Math.Sqrt(normalizedPlaintext.Length))
    End Function

    Private Function Chunks(ByVal str As String, ByVal chunkSize As Integer) As IEnumerable(Of String)
        If str.Length = 0 Then Return Enumerable.Empty(Of String)()

        Return Enumerable.Range(0, Math.Ceiling(str.Length / chunkSize)).[Select](Function(i) str.Substring(i * chunkSize, Math.Min(str.Length - i * chunkSize, chunkSize)))
    End Function

    Private Function Transpose(ByVal input As IEnumerable(Of String)) As IEnumerable(Of String)
        Return input.SelectMany(Function(s) s.[Select](Function(c, i) Tuple.Create(i, c))).GroupBy(Function(x) x.Item1).[Select](Function(g) New String(g.[Select](Function(t) t.Item2).ToArray()))
    End Function
End Module
