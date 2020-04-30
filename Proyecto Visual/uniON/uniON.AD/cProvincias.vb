Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cProvincias
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProvinciasBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorPais(ByVal IdPais As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProvinciasBuscarPorPais", IdPais)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID(ByVal IdProvincia As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProvinciaBuscarPorId", IdProvincia)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal IdPais As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("ProvinciasAgregar", IdPais, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdProvincia As Integer, ByVal IdPais As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProvinciaModificar", IdProvincia, IdPais, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
