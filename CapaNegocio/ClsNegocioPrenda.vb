Imports CapaDatos
Imports CapaEntidad
Public Class ClsNegocioPrenda
    Private objBuscar As New ClsPrenda
    Private objInsertar As New ClsPrenda
    Private objListar As New ClsPrenda
    Private objEliminar As New ClsPrenda
    Private objActualizar As New ClsPrenda
    Public Function N_BuscarPrenda(Busqueda As String) As DataTable
        Return objBuscar.CD_BuscarPrenda(Busqueda)
    End Function
    Public Function N_InsertarPrenda(tipo_prenda As String, talla_prenda As String)
        Return objInsertar.CD_InsertarPrenda(tipo_prenda, talla_prenda)
    End Function
    Public Function CN_ListarPrenda() As DataTable
        Return objListar.CD_listarPrenda
    End Function
    Public Function N_EliminarPrenda(Eliminar As String)
        Return objEliminar.CD_EliminarPrenda(Eliminar)
    End Function
    Public Function N_ActualizarPrenda(id_pre As Integer, tipo_prenda As String, talla_prenda As String)
        Return objActualizar.CD_ActualizarPrenda(id_pre, tipo_prenda, talla_prenda)
    End Function
End Class
