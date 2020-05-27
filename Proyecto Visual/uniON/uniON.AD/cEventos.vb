Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cEventos

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function CrearEventos(ByVal EventosTipos As String, ByVal IdCiudad As Integer, ByVal IdPersona As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal Puntos As Integer, ByVal fecha As Integer) As Double

        Try
            Return oDatabase.ExecuteScalar("CrearEventos", EventosTipos, IdCiudad, IdPersona, Nombre, Descripcion, Puntos, "", fecha)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
