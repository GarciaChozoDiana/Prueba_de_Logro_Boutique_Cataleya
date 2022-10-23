Imports System.Configuration
Imports System.Data.SqlClient
Public Class ClsProveedor
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDCataleya").ConnectionString)

    Public Function CD_listarProveedor() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Proveedor", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_BuscarProveedor(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarProveedor", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_InsertarProveedor(nom_proveedor As String)

        Dim da As New SqlCommand("SP_Set_AgregarProveedor", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@nom_proveedor", nom_proveedor)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado correctamente proveedor")
        Catch ex As Exception
            MsgBox("Error al registrar proveedor")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarProveedor(id_proveedor As Integer)
        Dim da As New SqlCommand("SP_Set_EliminarProveedor", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@id_proveedor", id_proveedor)
        cn.Open()
        Dim daa As Integer = da.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado proveedor")
        Catch ex As Exception
            MsgBox("Error al eliminar proveedor")
        End Try
        Return daa
    End Function

    Public Function CD_ActualizarProveedor(id_proveedor As Integer, nom_proveedor As String)
        Dim da As New SqlCommand("SP_Set_ActualizarProveedor", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@id_proveedor", id_proveedor)
        da.Parameters.AddWithValue("@nom_proveedor", nom_proveedor)

        cn.Open()
        Dim dad As String = da.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado proveedor")
        Catch ex As Exception
            MsgBox("Error al actualizar proveedor")
        End Try
        Return dad
    End Function
End Class
