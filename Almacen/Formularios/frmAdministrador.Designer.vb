<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrador))
        Me.lstProductos = New MetroFramework.Controls.MetroListView()
        Me.lstPedidos = New MetroFramework.Controls.MetroListView()
        Me.lstUsuarios = New MetroFramework.Controls.MetroListView()
        Me.btnMostrarUsuarios = New MetroFramework.Controls.MetroButton()
        Me.btnMostrarPedido = New MetroFramework.Controls.MetroButton()
        Me.lblPedido = New MetroFramework.Controls.MetroLabel()
        Me.lblProductos = New MetroFramework.Controls.MetroLabel()
        Me.lblUsuarios = New MetroFramework.Controls.MetroLabel()
        Me.btnAñadirPedido = New System.Windows.Forms.Button()
        Me.ptbAñadir = New System.Windows.Forms.PictureBox()
        Me.btnAnadirEnunciado = New MetroFramework.Controls.MetroButton()
        CType(Me.ptbAñadir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstProductos
        '
        Me.lstProductos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstProductos.FullRowSelect = True
        Me.lstProductos.Location = New System.Drawing.Point(337, 69)
        Me.lstProductos.MultiSelect = False
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.OwnerDraw = True
        Me.lstProductos.Size = New System.Drawing.Size(208, 326)
        Me.lstProductos.TabIndex = 6
        Me.lstProductos.UseCompatibleStateImageBehavior = False
        Me.lstProductos.UseSelectable = True
        Me.lstProductos.View = System.Windows.Forms.View.List
        '
        'lstPedidos
        '
        Me.lstPedidos.CausesValidation = False
        Me.lstPedidos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstPedidos.FullRowSelect = True
        Me.lstPedidos.Location = New System.Drawing.Point(40, 69)
        Me.lstPedidos.MultiSelect = False
        Me.lstPedidos.Name = "lstPedidos"
        Me.lstPedidos.OwnerDraw = True
        Me.lstPedidos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstPedidos.Size = New System.Drawing.Size(208, 326)
        Me.lstPedidos.TabIndex = 7
        Me.lstPedidos.UseCompatibleStateImageBehavior = False
        Me.lstPedidos.UseSelectable = True
        Me.lstPedidos.View = System.Windows.Forms.View.List
        '
        'lstUsuarios
        '
        Me.lstUsuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstUsuarios.FullRowSelect = True
        Me.lstUsuarios.Location = New System.Drawing.Point(643, 69)
        Me.lstUsuarios.MultiSelect = False
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.OwnerDraw = True
        Me.lstUsuarios.Size = New System.Drawing.Size(208, 326)
        Me.lstUsuarios.TabIndex = 8
        Me.lstUsuarios.UseCompatibleStateImageBehavior = False
        Me.lstUsuarios.UseSelectable = True
        Me.lstUsuarios.View = System.Windows.Forms.View.List
        '
        'btnMostrarUsuarios
        '
        Me.btnMostrarUsuarios.Location = New System.Drawing.Point(643, 415)
        Me.btnMostrarUsuarios.Name = "btnMostrarUsuarios"
        Me.btnMostrarUsuarios.Size = New System.Drawing.Size(208, 22)
        Me.btnMostrarUsuarios.TabIndex = 10
        Me.btnMostrarUsuarios.Text = "Mostrar Usuarios"
        Me.btnMostrarUsuarios.UseSelectable = True
        '
        'btnMostrarPedido
        '
        Me.btnMostrarPedido.Location = New System.Drawing.Point(40, 415)
        Me.btnMostrarPedido.Name = "btnMostrarPedido"
        Me.btnMostrarPedido.Size = New System.Drawing.Size(208, 23)
        Me.btnMostrarPedido.TabIndex = 11
        Me.btnMostrarPedido.Text = "Mostrar Pedido"
        Me.btnMostrarPedido.UseSelectable = True
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Location = New System.Drawing.Point(113, 29)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(50, 19)
        Me.lblPedido.TabIndex = 12
        Me.lblPedido.Text = "Pedido"
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(404, 29)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(63, 19)
        Me.lblProductos.TabIndex = 13
        Me.lblProductos.Text = "Producto"
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Location = New System.Drawing.Point(729, 29)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(58, 19)
        Me.lblUsuarios.TabIndex = 14
        Me.lblUsuarios.Text = "Usuarios"
        '
        'btnAñadirPedido
        '
        Me.btnAñadirPedido.BackgroundImage = Global.Formularios.My.Resources.Resources.pencil
        Me.btnAñadirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAñadirPedido.Location = New System.Drawing.Point(254, 355)
        Me.btnAñadirPedido.Name = "btnAñadirPedido"
        Me.btnAñadirPedido.Size = New System.Drawing.Size(40, 40)
        Me.btnAñadirPedido.TabIndex = 15
        Me.btnAñadirPedido.UseVisualStyleBackColor = True
        '
        'ptbAñadir
        '
        Me.ptbAñadir.Image = CType(resources.GetObject("ptbAñadir.Image"), System.Drawing.Image)
        Me.ptbAñadir.Location = New System.Drawing.Point(409, 410)
        Me.ptbAñadir.Name = "ptbAñadir"
        Me.ptbAñadir.Size = New System.Drawing.Size(47, 41)
        Me.ptbAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAñadir.TabIndex = 9
        Me.ptbAñadir.TabStop = False
        '
        'btnAnadirEnunciado
        '
        Me.btnAnadirEnunciado.Location = New System.Drawing.Point(239, 12)
        Me.btnAnadirEnunciado.Name = "btnAnadirEnunciado"
        Me.btnAnadirEnunciado.Size = New System.Drawing.Size(113, 39)
        Me.btnAnadirEnunciado.TabIndex = 15
        Me.btnAnadirEnunciado.Text = "Añadir Enunciado"
        Me.btnAnadirEnunciado.UseSelectable = True
        '
        'frmAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 461)
        Me.Controls.Add(Me.btnAnadirEnunciado)
        Me.Controls.Add(Me.btnAñadirPedido)
        Me.Controls.Add(Me.lblUsuarios)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.lblPedido)
        Me.Controls.Add(Me.btnMostrarPedido)
        Me.Controls.Add(Me.btnMostrarUsuarios)
        Me.Controls.Add(Me.ptbAñadir)
        Me.Controls.Add(Me.lstUsuarios)
        Me.Controls.Add(Me.lstPedidos)
        Me.Controls.Add(Me.lstProductos)
        Me.Name = "frmAdministrador"
        Me.Text = "Administrador"
        CType(Me.ptbAñadir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstProductos As MetroFramework.Controls.MetroListView
    Friend WithEvents lstPedidos As MetroFramework.Controls.MetroListView
    Friend WithEvents lstUsuarios As MetroFramework.Controls.MetroListView
    Friend WithEvents ptbAñadir As PictureBox
    Friend WithEvents btnMostrarUsuarios As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrarPedido As MetroFramework.Controls.MetroButton
    Friend WithEvents lblPedido As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProductos As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUsuarios As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAñadirPedido As Button
    Friend WithEvents btnAnadirEnunciado As MetroFramework.Controls.MetroButton
End Class
