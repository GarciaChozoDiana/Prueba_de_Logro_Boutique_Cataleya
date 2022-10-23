Imports System.Data
Imports System.Data.SqlClient
Public Class clsConexion
	'Public conexion As SqlConnection = New SqlConnection("Data Source = LENOVO; Initial Catalog = BDCataleya; User Id = sa; Password = DIOSMEAMA12")
	'Public Sub conectar()
	'Try
	'		conexion.Open()
	'		MessageBox.Show("CONECTADO")
	'Catch ex As Exception
	'		MessageBox.Show("CONECTADO")
	'Finally
	'		conexion.Close()
	'
	'End Try
	'End Sub
	'Public Function listarCategoria() As DataTable
	'Dim dt As New DataTable
	'Dim da As New SqlDataAdapter("SP_LISTAR_CATEGORIA", conexion)
	'	da.SelectCommand.CommandType = CommandType.StoredProcedure
	'	da.Fill(dt)
	'Return dt
	'End Function

	'Public Function listarArticulo() As DataTable
	'Dim dt As New DataTable
	'Dim da As New SqlDataAdapter("SP_Get_Listar_Articulo", conexion)
	'	da.SelectCommand.CommandType = CommandType.StoredProcedure
	'	da.Fill(dt)
	'Return dt
	'End Function

	'Public Function listarVenta() As DataTable
	'Dim dt As New DataTable
	'Dim da As New SqlDataAdapter("SP_LISTAR_VENTA", conexion)
	'	da.SelectCommand.CommandType = CommandType.StoredProcedure
	'	da.Fill(dt)
	'Return dt
	'End Function


	'Public Function listarClientes() As DataTable
	'Dim dt As New DataTable
	'Dim da As New SqlDataAdapter("SP_LISTAR_CLIENTE", conexion)
	'	da.SelectCommand.CommandType = CommandType.StoredProcedure
	'	da.Fill(dt)
	'Return dt
	'End Function

	'Public Function listarUsuario() As DataTable
	'Dim dt As New DataTable
	'Dim da As New SqlDataAdapter("SP_LISTAR_USUARIO", conexion)
	'	da.SelectCommand.CommandType = CommandType.StoredProcedure
	'	da.Fill(dt)
	'Return dt
	'End Function



End Class