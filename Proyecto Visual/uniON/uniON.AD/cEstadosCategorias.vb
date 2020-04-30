Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cEstadosCategorias
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorId(ByVal IdEstadoCategoria As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EstadosCategoriasBuscarPorId", IdEstadoCategoria)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EstadosCategoriasBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Descripcion As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("EstadosCategoriasAgregar", Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdEstadoCategoria As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EstadosCategoriasModificar", IdEstadoCategoria, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Eliminar(ByVal IdEstadoCategoria As Integer) As Double
        Return oDatabase.ExecuteScalar("EstadosCategoriasEliminar", IdEstadoCategoria)
    End Function


End Class
