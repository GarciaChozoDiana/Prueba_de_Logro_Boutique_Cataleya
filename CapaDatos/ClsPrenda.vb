Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClsPrenda

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDCataleya").ConnectionString)
    Public Function CD_listarPrenda() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Prenda", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_BuscarPrenda(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarPrenda", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_InsertarPrenda(tipo_prenda As String, talla_prenda As String)

        Dim da As New SqlCommand("SP_Set_AgregarPrenda", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@tipo_prenda", tipo_prenda)
        da.Parameters.AddWithValue("@talla_prenda", talla_prenda)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado correctamente la prenda")
        Catch ex As Exception
            MsgBox("Error al registrar la prenda")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarPrenda(id_pre As Integer)
        Dim da As New SqlCommand("SP_Set_EliminarPrenda", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@id_prenda", id_pre)
        cn.Open()
        Dim daa As Integer = da.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado la prenda")
        Catch ex As Exception
            MsgBox("Error al eliminar la prenda")
        End Try
        Return daa
    End Function

    Public Function CD_ActualizarPrenda(id_pre As Integer, tipo_prenda As String, talla_prenda As String)
        Dim da As New SqlCommand("SP_Set_ActualizarPrenda", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@id_prenda", id_pre)
        da.Parameters.AddWithValue("@tipo_prenda", tipo_prenda)
        da.Parameters.AddWithValue("@talla_prenda", talla_prenda)
        cn.Open()
        Dim daa As String = da.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado Prenda")
        Catch ex As Exception
            MsgBox("Error al actualizar Prenda")
        End Try
        Return daa
    End Function
End Class
