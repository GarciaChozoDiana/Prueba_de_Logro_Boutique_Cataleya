<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pantalla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla))
        Me.pnPrincipal = New System.Windows.Forms.Panel()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.btnVentas = New FontAwesome.Sharp.IconButton()
        Me.btnPrenda = New FontAwesome.Sharp.IconButton()
        Me.btnMarca = New FontAwesome.Sharp.IconButton()
        Me.btnProducto = New FontAwesome.Sharp.IconButton()
        Me.imgUSS = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.LabelFormActual = New System.Windows.Forms.Label()
        Me.IconFormActual = New FontAwesome.Sharp.IconPictureBox()
        Me.pnHome = New System.Windows.Forms.Panel()
        Me.pnPrincipal.SuspendLayout()
        CType(Me.imgUSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnPrincipal
        '
        Me.pnPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnPrincipal.BackColor = System.Drawing.Color.Pink
        Me.pnPrincipal.Controls.Add(Me.btnSalir)
        Me.pnPrincipal.Controls.Add(Me.btnVentas)
        Me.pnPrincipal.Controls.Add(Me.btnPrenda)
        Me.pnPrincipal.Controls.Add(Me.btnMarca)
        Me.pnPrincipal.Controls.Add(Me.btnProducto)
        Me.pnPrincipal.Controls.Add(Me.imgUSS)
        Me.pnPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(287, 612)
        Me.pnPrincipal.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.Font = New System.Drawing.Font("Pristina", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnSalir.IconColor = System.Drawing.Color.Crimson
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(3, 545)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(281, 60)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.Font = New System.Drawing.Font("Pristina", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Shopify
        Me.btnVentas.IconColor = System.Drawing.Color.Crimson
        Me.btnVentas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(3, 452)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(281, 60)
        Me.btnVentas.TabIndex = 10
        Me.btnVentas.Text = "Proveedor"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnPrenda
        '
        Me.btnPrenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrenda.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnPrenda.FlatAppearance.BorderSize = 0
        Me.btnPrenda.Font = New System.Drawing.Font("Pristina", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrenda.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnPrenda.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.btnPrenda.IconColor = System.Drawing.Color.Crimson
        Me.btnPrenda.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrenda.Location = New System.Drawing.Point(3, 359)
        Me.btnPrenda.Name = "btnPrenda"
        Me.btnPrenda.Size = New System.Drawing.Size(281, 60)
        Me.btnPrenda.TabIndex = 9
        Me.btnPrenda.Text = "Detalle Producto"
        Me.btnPrenda.UseVisualStyleBackColor = False
        '
        'btnMarca
        '
        Me.btnMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMarca.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnMarca.FlatAppearance.BorderSize = 0
        Me.btnMarca.Font = New System.Drawing.Font("Pristina", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarca.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnMarca.IconChar = FontAwesome.Sharp.IconChar.ListCheck
        Me.btnMarca.IconColor = System.Drawing.Color.Crimson
        Me.btnMarca.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarca.Location = New System.Drawing.Point(3, 269)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(281, 60)
        Me.btnMarca.TabIndex = 8
        Me.btnMarca.Text = "Marca"
        Me.btnMarca.UseVisualStyleBackColor = False
        '
        'btnProducto
        '
        Me.btnProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProducto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnProducto.FlatAppearance.BorderSize = 0
        Me.btnProducto.Font = New System.Drawing.Font("Pristina", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducto.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnProducto.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnProducto.IconColor = System.Drawing.Color.Crimson
        Me.btnProducto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.Location = New System.Drawing.Point(3, 175)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(281, 60)
        Me.btnProducto.TabIndex = 7
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.UseVisualStyleBackColor = False
        '
        'imgUSS
        '
        Me.imgUSS.BackColor = System.Drawing.Color.Pink
        Me.imgUSS.Cursor = System.Windows.Forms.Cursors.No
        Me.imgUSS.Image = CType(resources.GetObject("imgUSS.Image"), System.Drawing.Image)
        Me.imgUSS.Location = New System.Drawing.Point(27, 21)
        Me.imgUSS.Name = "imgUSS"
        Me.imgUSS.Size = New System.Drawing.Size(225, 122)
        Me.imgUSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUSS.TabIndex = 0
        Me.imgUSS.TabStop = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelPrincipal.BackColor = System.Drawing.Color.LightPink
        Me.PanelPrincipal.Controls.Add(Me.LabelFormActual)
        Me.PanelPrincipal.Controls.Add(Me.IconFormActual)
        Me.PanelPrincipal.Font = New System.Drawing.Font("Pristina", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPrincipal.Location = New System.Drawing.Point(305, 12)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(943, 77)
        Me.PanelPrincipal.TabIndex = 2
        '
        'LabelFormActual
        '
        Me.LabelFormActual.AutoSize = True
        Me.LabelFormActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormActual.Location = New System.Drawing.Point(388, 32)
        Me.LabelFormActual.Name = "LabelFormActual"
        Me.LabelFormActual.Size = New System.Drawing.Size(0, 20)
        Me.LabelFormActual.TabIndex = 1
        '
        'IconFormActual
        '
        Me.IconFormActual.BackColor = System.Drawing.Color.Pink
        Me.IconFormActual.Cursor = System.Windows.Forms.Cursors.No
        Me.IconFormActual.ForeColor = System.Drawing.Color.Plum
        Me.IconFormActual.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconFormActual.IconColor = System.Drawing.Color.Plum
        Me.IconFormActual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconFormActual.IconSize = 71
        Me.IconFormActual.Location = New System.Drawing.Point(3, 3)
        Me.IconFormActual.Name = "IconFormActual"
        Me.IconFormActual.Size = New System.Drawing.Size(93, 71)
        Me.IconFormActual.TabIndex = 0
        Me.IconFormActual.TabStop = False
        '
        'pnHome
        '
        Me.pnHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnHome.BackColor = System.Drawing.Color.DarkGray
        Me.pnHome.BackgroundImage = CType(resources.GetObject("pnHome.BackgroundImage"), System.Drawing.Image)
        Me.pnHome.Location = New System.Drawing.Point(305, 95)
        Me.pnHome.Name = "pnHome"
        Me.pnHome.Size = New System.Drawing.Size(943, 529)
        Me.pnHome.TabIndex = 1
        '
        'Pantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1260, 636)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.pnHome)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Pantalla"
        Me.Text = "Boutique Cataleya"
        Me.pnPrincipal.ResumeLayout(False)
        CType(Me.imgUSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnPrincipal As Panel
    Friend WithEvents imgUSS As PictureBox
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrenda As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMarca As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducto As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents IconFormActual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LabelFormActual As Label
    Friend WithEvents pnHome As Panel
End Class
