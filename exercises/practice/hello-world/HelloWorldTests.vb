Imports Xunit

Public Class HelloWorldTests
    <Fact>
    Public Sub Say_hi_()
        Assert.Equal("Hello, World!", Hello())
    End Sub
End Class
