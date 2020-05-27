Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cCiudades
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CiudadesBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


        Try
            Return oDatabase.ExecuteDataSet("CiudadesBuscarPorIdProvincia", IdProvincia)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID(ByVal IdCiudad As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CiudadesBuscarPorId", IdCiudad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal IdProvincia As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("CiudadesAgregar", IdProvincia, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdCiudad As Integer, ByVal IdProvincia As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CiudadesModificar", IdCiudad, IdProvincia, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal IdCiudad As Integer) As Double
        Return oDatabase.ExecuteScalar("CiudadEliminar", IdCiudad)
    End Function

End Class



