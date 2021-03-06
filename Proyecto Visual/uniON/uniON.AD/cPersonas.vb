﻿Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cPersonas

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal IdUsuario As Integer) As Double
        Return oDatabase.ExecuteScalar("PersonasAgregar", IdUsuario)
    End Function

    Public Function CargarDatos(ByVal IdPersona As Integer, ByVal IdCiudad As Integer, ByVal Nombre As String, ByVal Apellido As String)
        Return oDatabase.ExecuteScalar("PersonasCargarDatos", IdPersona, IdCiudad, Nombre, Apellido)
    End Function

    Public Function BuscarPorId(ByVal IdPersona As Integer)
        Return oDatabase.ExecuteDataSet("PersonasBuscarPorId", IdPersona)
    End Function

    Public Function ModificarDatos(ByVal IdPersona As Integer, ByVal IdCiudad As Integer, ByVal Nombre As String, ByVal Apellido As String)
        Return oDatabase.ExecuteScalar("PersonasModificarDatos", IdPersona, IdCiudad, Nombre, Apellido)
    End Function

    Public Function BuscarPorIdUsuario(ByVal IdUsuario As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("PersonasBuscarPorIdUsuario", IdUsuario)
    End Function

End Class
