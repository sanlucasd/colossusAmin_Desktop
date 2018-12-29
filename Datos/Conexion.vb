Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion

    Public Function Conectar(username As String, password As String) As SqlConnection
        Dim sqlcon As New SqlConnection("data source = DESKTOP-KVPULH9; initial catalog = colossus01 ; user id = " & username & "; password =" & password)
        If (sqlcon.State = ConnectionState.Closed) Then
            sqlcon.Open()
        End If
        Return sqlcon
    End Function

    Public Function Desconectar(conex As SqlConnection) As SqlConnection
        If conex.State = ConnectionState.Open Then
            conex.Close()
        End If
        Return conex
    End Function

    Public Function test(user As String, pass As String) As Boolean

        Try
            Dim conn = Conectar(user, pass)
            If conn.State = ConnectionState.Open Then
                Return True

            Else
                Return False
            End If
            '  Command.CommandText = "SELECT username, tipo  FROM usuarios "
            ' dataReader = Command.ExecuteReader
            'DataTable.Load(dataReader)

        Catch ex As Exception
            Return False

        End Try

    End Function

End Class
