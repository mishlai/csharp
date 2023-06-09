Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Module Change
    Public Function FindFewestCoins(ByVal coins As Integer(), ByVal target As Integer) As Integer()
        If target < 0 Then
            Throw New ArgumentException("Target amount cannot be negative.")
        End If
        If target > 0 AndAlso target < coins.Min() Then
            Throw New ArgumentException("Target amount cannot be less than minimal coin value.")
        End If

        Dim minimalCoinsMapSeed = New Dictionary(Of Integer, List(Of Integer)) From {
    {0, New List(Of Integer)(0)}
}

        Dim minimalCoinsMap = Enumerable.Range(1, target).Aggregate(minimalCoinsMapSeed, New Func(Of Dictionary(Of Integer, List(Of Integer)), Integer, Dictionary(Of Integer, List(Of Integer)))(AddressOf UpdateMinimalCoinsMap))

        Dim minimalCoins As List(Of Integer) = Nothing
        If minimalCoinsMap.TryGetValue(target, minimalCoins) Then Return minimalCoins.OrderBy(Function(x) x).ToArray()

        Throw New ArgumentException()
                ''' Cannot convert LocalFunctionStatementSyntax, CONVERSION ERROR: Conversion for LocalFunctionStatement not implemented, please report this issue in 'System.Collections.Generic....' at character 1007
''' 
''' 
''' Input:
''' 
        System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> UpdateMinimalCoinsMap(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> current, int subTarget)
        {
            var subTargetMinimalCoins = MinimalCoins(current, subTarget);
            if (subTargetMinimalCoins != null)
                current.Add(subTarget, subTargetMinimalCoins);

            return current;
        }

''' 
        Dim subTargetMinimalCoins As List(Of Integer) = Nothing
                ''' Cannot convert LocalFunctionStatementSyntax, CONVERSION ERROR: Conversion for LocalFunctionStatement not implemented, please report this issue in 'System.Collections.Generic....' at character 1457
''' 
''' 
''' Input:
''' 
        System.Collections.Generic.List<int> MinimalCoins(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> current, int subTarget)
        {
            return coins
                .Where(coin => coin <= subTarget)
                .Select(coin => current.TryGetValue(subTarget - coin, out var subTargetMinimalCoins)
                    ? subTargetMinimalCoins.Append(coin).ToList()
                    : null)
                .Where(subTargetMinimalCoins => subTargetMinimalCoins != null)
                .OrderBy(subTargetMinimalCoins => subTargetMinimalCoins.Count)
                .FirstOrDefault();
        }

''' 
    End Function
End Module
