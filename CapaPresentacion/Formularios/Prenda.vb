Imports CapaNegocio

Public Class Prenda


    Dim ObjBuscar As New ClsNegocioPrenda
    Dim ObjInsertar As New ClsNegocioPrenda
    Dim ObjListar As New ClsNegocioPrenda
    Dim ObjEliminar As New ClsNegocioPrenda
    Dim ObjActualizar As New ClsNegocioPrenda

    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGPrenda.DataSource = ObjListar.CN_ListarPrenda
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPrenda.CellContentClick
        lblCodigo.Text = DGPrenda.Item(0, e.RowIndex).Value
        txtTipo.Text = DGPrenda.Item(1, e.RowIndex).Value
        txtTalla.Text = DGPrenda.Item(2, e.RowIndex).Value

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscarPrenda.Text
        DGPrenda.DataSource = ObjBuscar.N_BuscarPrenda(txtBuscarPrenda.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjInsertar.N_InsertarPrenda(txtTipo.Text, txtTalla.Text)
        DGPrenda.DataSource = ObjInsertar.CN_ListarPrenda
        lblCodigo.Text = ""
        txtTipo.Text = ""
        txtTalla.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjEliminar.N_EliminarPrenda(lblCodigo.Text)
        DGPrenda.DataSource = ObjEliminar.CN_ListarPrenda
        lblCodigo.Text = ""
        txtTipo.Text = ""
        txtTalla.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjActualizar.N_ActualizarPrenda(lblCodigo.Text, txtTipo.Text, txtTalla.Text)
        DGPrenda.DataSource = ObjActualizar.CN_ListarPrenda
        lblCodigo.Text = ""
        txtTipo.Text = ""
        txtTalla.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        lblCodigo.Text = ""
        txtTipo.Text = ""
        txtTalla.Text = ""
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipo.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class