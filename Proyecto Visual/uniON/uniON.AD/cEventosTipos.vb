Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cEventosTipos
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorId(ByVal IdTipoEvento As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EventosTiposBuscarPorId", IdTipoEvento)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EventosTiposBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Descripcion As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("EventosTiposAgregar", Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdTipoEvento As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EventosTiposModificar", IdTipoEvento, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Eliminar(ByVal IdTipoEvento As Integer) As Double
        Return oDatabase.ExecuteScalar("EventosTiposEliminar", IdTipoEvento)
    End Function

End Class


