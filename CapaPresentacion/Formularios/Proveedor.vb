Imports CapaNegocio

Public Class Proveedor
    Dim objBusc As New ClsNegocioProveedor
    Dim ObjList As New ClsNegocioProveedor
    Dim ObjRegis As New ClsNegocioProveedor
    Dim ObjModi As New ClsNegocioProveedor
    Dim ObjElim As New ClsNegocioProveedor
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGReserva.DataSource = ObjList.CN_ListarProveedor
    End Sub

    Private Sub DGUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReserva.CellContentClick
        lblCodigo.Text = DGReserva.Item(0, e.RowIndex).Value
        txtProveedor.Text = DGReserva.Item(1, e.RowIndex).Value

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegis.N_InsertarProveedor(txtProveedor.Text)
        DGReserva.DataSource = ObjRegis.CN_ListarProveedor
        lblCodigo.Text = ""
        txtProveedor.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjRegis.N_ActualizarProveedor(lblCodigo.Text, txtProveedor.Text)
        DGReserva.DataSource = ObjRegis.CN_ListarProveedor
        lblCodigo.Text = ""
        txtProveedor.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjElim.N_EliminarProveedor(lblCodigo.Text)
        DGReserva.DataSource = ObjElim.CN_ListarProveedor
        lblCodigo.Text = ""
        txtProveedor.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscarProveedor.Text
        DGReserva.DataSource = objBusc.N_BuscarProveedor(txtBuscarProveedor.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProveedor.TextChanged

    End Sub
End Class