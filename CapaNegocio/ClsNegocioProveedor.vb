Imports CapaDatos
Public Class ClsNegocioProveedor

    Private objBuscar As New ClsProveedor
    Private objInsertar As New ClsProveedor
    Private objListar As New ClsProveedor
    Private objEliminar As New ClsProveedor
    Private objActualizar As New ClsProveedor
    Public Function N_BuscarProveedor(Busqueda As String) As DataTable
        Return objBuscar.CD_BuscarProveedor(Busqueda)
    End Function
    Public Function N_InsertarProveedor(nom_proveedor As String)
        Return objInsertar.CD_InsertarProveedor(nom_proveedor)
    End Function
    Public Function CN_ListarProveedor() As DataTable
        Return objListar.CD_listarProveedor
    End Function
    Public Function N_EliminarProveedor(Eliminar As String)
        Return objEliminar.CD_EliminarProveedor(Eliminar)
    End Function
    Public Function N_ActualizarProveedor(id_proveedor As Integer, nom_proveedor As String)
        Return objActualizar.CD_ActualizarProveedor(id_proveedor, nom_proveedor)
    End Function

End Class
