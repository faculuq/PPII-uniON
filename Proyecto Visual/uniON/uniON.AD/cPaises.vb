Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cPaises
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorId(ByVal IdPais As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PaisesBuscarPorId", IdPais)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PaisesBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("PaisesAgregar", Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdPais As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("PaisesModificar", IdPais, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
