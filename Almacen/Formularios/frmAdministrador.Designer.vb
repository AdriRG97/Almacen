<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrador))
        Me.btnPedidos = New MetroFramework.Controls.MetroButton()
        Me.btnProductos = New MetroFramework.Controls.MetroButton()
        Me.btnUsuarios = New MetroFramework.Controls.MetroButton()
        Me.lstProductos = New MetroFramework.Controls.MetroListView()
        Me.lstPedidos = New MetroFramework.Controls.MetroListView()
        Me.lstUsuarios = New MetroFramework.Controls.MetroListView()
        Me.ptbAñadir = New System.Windows.Forms.PictureBox()
        CType(Me.ptbAñadir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPedidos
        '
        Me.btnPedidos.Location = New System.Drawing.Point(40, 29)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(208, 23)
        Me.btnPedidos.TabIndex = 3
        Me.btnPedidos.Text = "Pedidos"
        Me.btnPedidos.UseSelectable = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(337, 29)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(208, 23)
        Me.btnProductos.TabIndex = 4
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseSelectable = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Location = New System.Drawing.Point(643, 29)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(208, 23)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseSelectable = True
        '
        'lstProductos
        '
        Me.lstProductos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstProductos.FullRowSelect = True
        Me.lstProductos.Location = New System.Drawing.Point(337, 69)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.OwnerDraw = True
        Me.lstProductos.Size = New System.Drawing.Size(208, 326)
        Me.lstProductos.TabIndex = 6
        Me.lstProductos.UseCompatibleStateImageBehavior = False
        Me.lstProductos.UseSelectable = True
        '
        'lstPedidos
        '
        Me.lstPedidos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstPedidos.FullRowSelect = True
        Me.lstPedidos.Location = New System.Drawing.Point(40, 69)
        Me.lstPedidos.Name = "lstPedidos"
        Me.lstPedidos.OwnerDraw = True
        Me.lstPedidos.Size = New System.Drawing.Size(208, 326)
        Me.lstPedidos.TabIndex = 7
        Me.lstPedidos.UseCompatibleStateImageBehavior = False
        Me.lstPedidos.UseSelectable = True
        '
        'lstUsuarios
        '
        Me.lstUsuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstUsuarios.FullRowSelect = True
        Me.lstUsuarios.Location = New System.Drawing.Point(643, 69)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.OwnerDraw = True
        Me.lstUsuarios.Size = New System.Drawing.Size(208, 326)
        Me.lstUsuarios.TabIndex = 8
        Me.lstUsuarios.UseCompatibleStateImageBehavior = False
        Me.lstUsuarios.UseSelectable = True
        '
        'ptbAñadir
        '
        Me.ptbAñadir.Image = CType(resources.GetObject("ptbAñadir.Image"), System.Drawing.Image)
        Me.ptbAñadir.Location = New System.Drawing.Point(337, 401)
        Me.ptbAñadir.Name = "ptbAñadir"
        Me.ptbAñadir.Size = New System.Drawing.Size(47, 41)
        Me.ptbAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAñadir.TabIndex = 9
        Me.ptbAñadir.TabStop = False
        '
        'frmAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 461)
        Me.Controls.Add(Me.ptbAñadir)
        Me.Controls.Add(Me.lstUsuarios)
        Me.Controls.Add(Me.lstPedidos)
        Me.Controls.Add(Me.lstProductos)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnPedidos)
        Me.Name = "frmAdministrador"
        Me.Text = "frmAdministrador"
        CType(Me.ptbAñadir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPedidos As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProductos As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUsuarios As MetroFramework.Controls.MetroButton
    Friend WithEvents lstProductos As MetroFramework.Controls.MetroListView
    Friend WithEvents lstPedidos As MetroFramework.Controls.MetroListView
    Friend WithEvents lstUsuarios As MetroFramework.Controls.MetroListView
    Friend WithEvents ptbAñadir As PictureBox
End Class
