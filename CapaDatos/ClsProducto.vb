Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClsProducto
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnBDCataleya").ConnectionString)
    Public Function CD_BuscarProducto(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarProducto", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_listarProducto() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Producto", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_InsertarProducto(id_marca As Integer, id_prenda As Integer, id_proveedor As Integer, nom_producto As String, precio_producto As Integer)
        Dim da As New SqlCommand("SP_Set_AgregarProducto", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@id_marca", id_marca)
        da.Parameters.AddWithValue("@id_prenda", id_prenda)
        da.Parameters.AddWithValue("@id_proveedor", id_proveedor)
        da.Parameters.AddWithValue("@nom_producto", nom_producto)
        da.Parameters.AddWithValue("@precio_producto", precio_producto)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado el Producto correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar el Producto")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarProducto(idprod As Integer)
        Dim prod As New SqlCommand("SP_Set_EliminarProducto", cn)
        prod.CommandType = CommandType.StoredProcedure
        prod.Parameters.AddWithValue("@id_producto", idprod)
        cn.Open()
        Dim prod1 As Integer = prod.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado el producto")
        Catch ex As Exception
            MsgBox("Error al eliminar el producto")
        End Try
        Return prod1
    End Function

    Public Function CD_ActualizarProducto(id_producto As Integer, id_marca As Integer, id_prenda As Integer, id_proveedor As Integer, nom_producto As String, precio_producto As Integer)
        Dim prod As New SqlCommand("SP_Set_ActualizarProducto", cn)
        prod.CommandType = CommandType.StoredProcedure
        prod.Parameters.AddWithValue("@id_producto", id_producto)
        prod.Parameters.AddWithValue("@id_marca", id_marca)
        prod.Parameters.AddWithValue("@id_prenda", id_prenda)
        prod.Parameters.AddWithValue("@id_proveedor", id_proveedor)
        prod.Parameters.AddWithValue("@nom_producto", nom_producto)
        prod.Parameters.AddWithValue("@precio_producto", precio_producto)
        cn.Open()
        Dim prod1 As String = prod.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha actualizado el producto")
        Catch ex As Exception
            MsgBox("Error al actualizar el producto")
        End Try
        Return prod1
    End Function
End Class
