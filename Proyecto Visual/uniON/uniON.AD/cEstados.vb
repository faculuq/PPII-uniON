﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class cEstados
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EstadosBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorCategoria(ByVal IdCategoria As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EstadosBuscarPorCategoria", IdCategoria)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID(ByVal IdEstado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EstadosBuscarPorId", IdEstado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal IdEstado As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("EstadosAgregar", IdEstado, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdDescripcion As Integer, ByVal IdEstado As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("EstadosModificar", IdDescripcion, IdEstado, Descripcion, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class