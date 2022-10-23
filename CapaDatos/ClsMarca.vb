Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Imports System.Security.Policy
Imports System.Security.Cryptography

Public Class ClsMarca

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDCataleya").ConnectionString)

    Public Function listarMarca() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Marca", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_BuscarMarca(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarMarca", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_InsertarMarca(nom_marca As String)

        Dim da As New SqlCommand("SP_Set_AgregarMarca", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@nom_marca", nom_marca)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado correctamente la marca")
        Catch ex As Exception
            MsgBox("Error al registrar la marca")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarMarca(idmar As Integer)
        Dim da As New SqlCommand("SP_Set_EliminarMarca", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@id_marca", idmar)
        cn.Open()
        Dim daa As Integer = da.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado la Marca")
        Catch ex As Exception
            MsgBox("Error al eliminar la Marca")
        End Try
        Return daa
    End Function

    Public Function CD_ActualizarMarca(id_marca As Integer, nom_marca As String)
        Dim actMar As New SqlCommand("SP_Set_ActualizarMarca", cn)
        actMar.CommandType = CommandType.StoredProcedure
        actMar.Parameters.AddWithValue("@id_marca", id_marca)
        actMar.Parameters.AddWithValue("@nom_marca", nom_marca)
        cn.Open()
        Dim actMar1 As String = actMar.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado Marca")
        Catch ex As Exception
            MsgBox("Error al actualizar Marca")
        End Try
        Return actMar1
    End Function
End Class
