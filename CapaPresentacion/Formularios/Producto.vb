Imports CapaNegocio

Public Class Producto

    Dim ObjBuscar As New ClsNegocioProducto
    Dim ObjInsertar As New ClsNegocioProducto
    Dim ObjListar As New ClsNegocioProducto
    Dim ObjEliminar As New ClsNegocioProducto
    Dim ObjActualizar As New ClsNegocioProducto
    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGProducto.DataSource = ObjListar.CN_ListarProducto
    End Sub

    Private Sub DGProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducto.CellContentClick
        lblCodigo.Text = DGProducto.Item(0, e.RowIndex).Value
        txtMarca.Text = DGProducto.Item(1, e.RowIndex).Value
        txtPrenda.Text = DGProducto.Item(2, e.RowIndex).Value
        txtProveedor.Text = DGProducto.Item(3, e.RowIndex).Value
        txtNombre.Text = DGProducto.Item(4, e.RowIndex).Value
        txtPrecio.Text = DGProducto.Item(5, e.RowIndex).Value
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        Dim Buscar = txtBuscarProducto.Text
        DGProducto.DataSource = ObjBuscar.N_BuscarProducto(txtBuscarProducto.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        lblCodigo.Text = "0000"
        txtMarca.Text = ""
        txtPrenda.Text = ""
        txtProveedor.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjInsertar.N_InsertarProducto(txtMarca.Text, txtPrenda.Text, txtProveedor.Text, txtNombre.Text, txtPrecio.Text)
        DGProducto.DataSource = ObjInsertar.CN_ListarProducto
        lblCodigo.Text = "0000"
        txtMarca.Text = ""
        txtPrenda.Text = ""
        txtProveedor.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjEliminar.N_EliminarProducto(lblCodigo.Text)
        DGProducto.DataSource = ObjEliminar.CN_ListarProducto
        lblCodigo.Text = "0000"
        txtMarca.Text = ""
        txtPrenda.Text = ""
        txtProveedor.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjActualizar.N_ActualizarProducto(lblCodigo.Text, txtMarca.Text, txtPrenda.Text, txtProveedor.Text, txtNombre.Text, txtPrecio.Text)
        DGProducto.DataSource = ObjActualizar.CN_ListarProducto
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblCodigo_Click(sender As Object, e As EventArgs) Handles lblCodigo.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class