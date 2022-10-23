Imports CapaDatos
Imports CapaEntidad
Public Class cls_CapaNegocio
	Private objDatos As New ClsMarca
	Private objBuscar As New ClsMarca
	Private dEmp As New ClsMarca
	Private Delim As New ClsMarca
	Private CAct As New ClsMarca

	Public Function N_InsertarMarca(nom_marca As String)
		Return dEmp.CD_InsertarMarca(nom_marca)
	End Function

	Public Function CN_ListarMarca() As DataTable
		Return objDatos.listarMarca()
	End Function

	Public Function N_BuscarMarca(Busqueda As String) As DataTable
		Return objBuscar.CD_BuscarMarca(Busqueda)
	End Function
	Public Function N_EliminarMarca(Eliminar As String)
		Return Delim.CD_EliminarMarca(Eliminar)
	End Function
	Public Function N_ActualizarMarca(id_marca As Integer, nom_marca As String)
		Return CAct.CD_ActualizarMarca(id_marca, nom_marca)
	End Function

End Class

