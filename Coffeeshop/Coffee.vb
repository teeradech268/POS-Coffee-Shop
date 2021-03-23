Public Class Coffee

    Private _coffeeMenu, _toppingMenu As String

    Public Sub New()
        _coffeeMenu = ""
        _toppingMenu = ""
    End Sub

    Public Sub New(coffeeMenu As String, toppingMenu As String)
        _coffeeMenu = coffeeMenu
        _toppingMenu = toppingMenu
    End Sub

    Public Sub New(coffeeMenu As String)
        Me.New(coffeeMenu, "")
    End Sub

    Public Property coffeeMenu As String
        Get
            Return _coffeeMenu
        End Get
        Set(value As String)
            _coffeeMenu = value
        End Set
    End Property

    Public Property toppingMenu As String
        Get
            Return _toppingMenu
        End Get
        Set(value As String)
            _toppingMenu = value
        End Set
    End Property


End Class
