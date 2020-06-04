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

    Public Function CrearEventos(ByVal IdTipoEvento As Integer, ByVal IdCiudad As Integer, ByVal IdPersona As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal Puntos As Integer, ByVal Fecha As Date) As Double
        Return oDatabase.ExecuteScalar("EventosAgregar", IdTipoEvento, IdCiudad, IdPersona, Nombre, Descripcion, Puntos, Fecha)
    End Function
End Class
