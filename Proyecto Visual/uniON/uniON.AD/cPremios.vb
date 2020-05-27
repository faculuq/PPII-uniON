Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cPremios

    Dim oDatabase As Database


    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)

    End Sub

    Public Function BuscarPorId(ByVal IdPremio As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PremiosBuscarPorId", IdPremio)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PremiosBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ByVal IdEmpresa As Integer, ByVal IdTipoPremio As Integer, ByVal Titulo As String, ByVal Descripcion As String, ByVal Cantidad As String, ByVal IdEstado As Integer, ByVal CostoPuntos As String) As Double
        Try
            Return oDatabase.ExecuteScalar("PremiosAgregar", IdEmpresa, IdTipoPremio, Titulo, Descripcion, Cantidad, IdEstado, CostoPuntos)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal IdPremio As Integer, ByVal IdEmpresa As Integer, ByVal IdTipoPremio As Integer, ByVal Titulo As String, ByVal Descripcion As String, ByVal Cantidad As String, ByVal IdEstado As Integer, ByVal CostoPuntos As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PremiosModificar", IdPremio, IdEmpresa, IdTipoPremio, Titulo, Descripcion, Cantidad, IdEstado, CostoPuntos)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function CargarDatos(ByVal IdTipoPremio As Integer, ByVal Titulo As String, ByVal Descripcion As String, ByVal Cantidad As String, ByVal IdEstado As Integer, ByVal CostoPuntos As String)
        Return oDatabase.ExecuteScalar("PersonasCargarDatos", IdTipoPremio, Titulo, Descripcion, Cantidad, IdEstado, CostoPuntos)
    End Function



End Class

