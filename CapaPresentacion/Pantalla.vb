Imports FontAwesome.Sharp

Public Class Pantalla

    'Declaramos campos de forma privada para almacenar el botón y un panel
    'aplicar un borde izquierdo al botón
    Private btnActual As IconButton
    Private leftBorderBtn As Panel
    'Constructor'
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(8, 60)
        pnPrincipal.Controls.Add(leftBorderBtn)

    End Sub

    'Metodos'
    'Botón activo y color personalizado
    Private Sub ActivateButton(SenderBtn As Object, CustomColor As Color)
        If SenderBtn IsNot Nothing Then
            DisableButton()
            'Convertimos el tipo del objeto a tipo Icono
            btnActual = CType(SenderBtn, IconButton)
            btnActual.ForeColor = CustomColor
            btnActual.IconColor = CustomColor
            btnActual.TextAlign = ContentAlignment.MiddleCenter
            btnActual.ImageAlign = ContentAlignment.MiddleRight
            btnActual.TextImageRelation = TextImageRelation.TextBeforeImage

            'el border en el panel menu
            leftBorderBtn.BackColor = CustomColor
            leftBorderBtn.Location = New Point(0, btnActual.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            IconFormActual.IconChar = btnActual.IconChar
            IconFormActual.IconColor = CustomColor
            LabelFormActual.Text = btnActual.Text
            LabelFormActual.ForeColor = btnActual.ForeColor
        End If
    End Sub

    'Metodo para desactivar el botón anterior y regresar a su estado
    Private Sub DisableButton()
        If btnActual IsNot Nothing Then
            btnActual.BackColor = Color.AliceBlue
            btnActual.ForeColor = Color.Pink
            btnActual.IconColor = Color.Plum
            btnActual.TextAlign = ContentAlignment.MiddleCenter
            btnActual.ImageAlign = ContentAlignment.MiddleLeft
            btnActual.TextImageRelation = TextImageRelation.Overlay
        End If
    End Sub

    Private Sub switchPanel(ByVal pnPrincipal As Form)
        pnHome.Controls.Clear()
        pnPrincipal.TopLevel = False
        pnHome.Controls.Add(pnPrincipal)
        pnPrincipal.Show()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        ActivateButton(sender, Color.Purple)
        switchPanel(Producto)
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        ActivateButton(sender, Color.Purple)
        switchPanel(Marca)
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnPrenda.Click
        ActivateButton(sender, Color.Purple)
        switchPanel(Prenda)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        ActivateButton(sender, Color.Purple)
        switchPanel(Proveedor)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Está Seguro de Salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub pnHome_Paint(sender As Object, e As PaintEventArgs) Handles pnHome.Paint

    End Sub

    Private Sub Pantalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
