Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cUsuariosTipo
    Dim oDatabase As Database


    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)

    End Sub

    Public Function UsuariosTiposBuscarPorId(ByVal IdTipoUsuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTiposBuscarPorId", IdTipoUsuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function UsuariosTiposBuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTiposBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function UsuariosTiposAgregar(ByVal Descripcion As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("UsuariosTiposAgregar", Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function UsuariosTiposModificar(ByVal IdTipoUsuario As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTiposModificar", IdTipoUsuario, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
