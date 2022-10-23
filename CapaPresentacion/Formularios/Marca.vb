Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CapaNegocio

Public Class Marca


    Dim ObjNegocio As New cls_CapaNegocio
    Dim ObjRegis As New cls_CapaNegocio
    Dim objElim As New cls_CapaNegocio
    Dim objAct As New cls_CapaNegocio
    Dim objList As New cls_CapaNegocio

    Private Sub FormUSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGMarca.DataSource = objList.CN_ListarMarca()

    End Sub

    Private Sub DGCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMarca.CellContentClick
        lblCodigo.Text = DGMarca.Item(0, e.RowIndex).Value
        txtNombre.Text = DGMarca.Item(1, e.RowIndex).Value

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscar.Text
        DGMarca.DataSource = ObjNegocio.N_BuscarMarca(txtBuscar.Text)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegis.N_InsertarMarca(txtNombre.Text)
        DGMarca.DataSource = ObjRegis.CN_ListarMarca
        lblCodigo.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        lblCodigo.Text = ""
        txtNombre.Text = ""

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        objElim.N_EliminarMarca(lblCodigo.Text)
        DGMarca.DataSource = objElim.CN_ListarMarca
        lblCodigo.Text = ""
        txtNombre.Text = ""

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        objAct.N_ActualizarMarca(lblCodigo.Text, txtNombre.Text)
        DGMarca.DataSource = objAct.CN_ListarMarca
        lblCodigo.Text = ""
        txtNombre.Text = ""

    End Sub
End Class