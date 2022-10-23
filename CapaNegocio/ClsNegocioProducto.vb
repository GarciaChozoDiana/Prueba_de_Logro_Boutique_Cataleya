Imports CapaDatos

Public Class ClsNegocioProducto

    Private objBuscar As New ClsProducto
    Private objInsertar As New ClsProducto
    Private objListar As New ClsProducto
    Private objEliminar As New ClsProducto
    Private objActualizar As New ClsProducto
    Public Function N_BuscarProducto(Busqueda As String) As DataTable
        Return objBuscar.CD_BuscarProducto(Busqueda)
    End Function
    Public Function N_InsertarProducto(id_marca As Integer, id_prenda As Integer, id_proveedor As Integer, nom_producto As String, precio_producto As Integer)
        Return objInsertar.CD_InsertarProducto(id_marca, id_prenda, id_proveedor, nom_producto, precio_producto)
    End Function
    Public Function CN_ListarProducto() As DataTable
        Return objListar.CD_listarProducto
    End Function
    Public Function N_EliminarProducto(Eliminar As String)
        Return objEliminar.CD_EliminarProducto(Eliminar)
    End Function
    Public Function N_ActualizarProducto(id_producto As Integer, id_marca As Integer, id_prenda As Integer, id_proveedor As Integer, nom_producto As String, precio_producto As Integer)
        Return objActualizar.CD_ActualizarProducto(id_producto, id_marca, id_prenda, id_proveedor, nom_producto, precio_producto)
    End Function

End Class
