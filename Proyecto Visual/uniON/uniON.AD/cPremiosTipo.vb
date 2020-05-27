
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cPremiosTipo

    Dim oDatabase As Database


    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)

    End Sub

    Public Function BuscarPorId(ByVal IdTipoPremio As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PremiosTiposBuscarPorId", IdTipoPremio)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PremiosTiposBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ByVal Descripcion As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("PremiosTiposAgregar", Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal IdTipoPremio As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PremiosTiposModificar", IdTipoPremio, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    'Public Function CargarDatosByVal(IdTipoPremio As Integer, ByVal Descripcion As String, ByVal Activo As Boolean)
    '    Return oDatabase.ExecuteScalar("PremiosTiposCargarDatos", IdTipoPremio, Descripcion, Activo)
    'End Function



End Class
