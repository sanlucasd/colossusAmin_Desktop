Imports Datos
Imports Entidades

Public Class Nusuario
    Public _dUsuario As New Dusuario
    Private _UsuarioV As Usuario = Nothing


    Public Function validarDatos(_usuario As Usuario) As Boolean
        If _usuario.username.Length > 0 And _usuario.passwordH.Length > 0 Then
            _UsuarioV = _usuario
            Return True
        Else
            Return False
        End If
    End Function

    Public Function datosUsuario() As DataTable
        Dim datatable As New DataTable
        datatable = Nothing

        If Not IsNothing(_UsuarioV) Then
            Try
                datatable = _dUsuario.conectar(_UsuarioV)
            Catch ex As Exception
                datatable = Nothing
            End Try

        End If
        Return datatable
    End Function

End Class
