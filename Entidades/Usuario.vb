
Public Class Usuario
    Private _username As String
    Private _passwordH As String
    Private _tipo As Byte

    Public Property username As String
        Get
            Return _username

        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property passwordH As String
        Get
            Return _passwordH
        End Get
        Set(value As String)
            _passwordH = value
        End Set
    End Property

    Public Property tipo As Byte
        Get
            Return _tipo
        End Get
        Set(value As Byte)
            _tipo = value
        End Set
    End Property


    Public Function iniciarSesion() As Boolean
        Return True
    End Function

    Public Function cerrarSesion() As Boolean
        Return True
    End Function

End Class
