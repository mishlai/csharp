Imports System
Imports System.Collections.Generic

Public Class SpaceAge
    Private Enum Planet
        Earth
        Mercury
        Venus
        Mars
        Jupiter
        Saturn
        Uranus
        Neptune
    End Enum

    Private ReadOnly seconds As Integer

    Private ReadOnly earthYearToPlanetPeriod As Dictionary(Of Planet, Double) = New Dictionary(Of Planet, Double) From {
    {Planet.Earth, 1},
    {Planet.Mercury, 0.2408467},
    {Planet.Venus, 0.61519726},
    {Planet.Mars, 1.8808158},
    {Planet.Jupiter, 11.862615},
    {Planet.Saturn, 29.447498},
    {Planet.Uranus, 84.016846},
    {Planet.Neptune, 164.79132}
}

    Public Sub New(ByVal seconds As Integer)
        Me.seconds = seconds
    End Sub

    Private Function CalculateAge(ByVal periodInEarthYears As Double) As Double
        Const EARTH_ORBIT_IN_SECONDS As Double = 31557600
        Return Math.Round(seconds / (EARTH_ORBIT_IN_SECONDS * periodInEarthYears), 2)
    End Function

    Public Function OnEarthMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Earth))
    End Function

    Public Function OnMercuryMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Mercury))
    End Function

    Public Function OnVenusMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Venus))
    End Function

    Public Function OnMarsMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Mars))
    End Function

    Public Function OnJupiterMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Jupiter))
    End Function

    Public Function OnSaturnMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Saturn))
    End Function

    Public Function OnUranusMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Uranus))
    End Function

    Public Function OnNeptuneMethod() As Double
        Return CalculateAge(earthYearToPlanetPeriod(Planet.Neptune))
    End Function
End Class
