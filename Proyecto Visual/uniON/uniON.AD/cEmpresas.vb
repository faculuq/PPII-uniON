Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cEmpresas

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal IdUsuario As Integer) As Double
        Return oDatabase.ExecuteScalar("EmpresasAgregar", IdUsuario)
    End Function

    Public Function CargarDatos(ByVal IdEmpresa As Integer, ByVal Nombre As String, ByVal IdCiudad As Integer)
        Return oDatabase.ExecuteScalar("EmpresaCargarDatos", IdEmpresa, Nombre, IdCiudad)
    End Function

    Public Function BuscarPorId(ByVal IdEmpresa As Integer)
        Return oDatabase.ExecuteDataSet("EmpresasBuscarPorId", IdEmpresa)
    End Function

    Public Function ModificarDatos(ByVal IdEmpresa As Integer, ByVal Nombre As String, ByVal IdCiudad As Integer)
        Return oDatabase.ExecuteScalar("EmpresaModificar", IdEmpresa, Nombre, IdCiudad)
    End Function

    Public Function BuscarPorIdUsuario(ByVal IdUsuario As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("EmpresasBuscarPorIdUsuario", IdUsuario)
    End Function

End Class
