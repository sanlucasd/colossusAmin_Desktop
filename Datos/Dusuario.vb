Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class Dusuario
    Private connection As SqlConnection
    Private dataReader As SqlDataReader
    Private dataTable As DataTable
    Private command As SqlCommand


    Public Function conectar(usuario As Usuario) As DataTable

        Try
            connection = New SqlConnection("data source = DESKTOP-KVPULH9; initial catalog = colossus01 ; user id = " & usuario.username & "; password =" & usuario.passwordH)
            connection.Open()
            command.CommandText = "SELECT username, tipo  FROM usuarios "
            dataReader = command.ExecuteReader
            dataTable.Load(dataReader)
            connection.Close()
            Return dataTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub desconectar()
        'connection.Close()
    End Sub
End Class
