<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAñadirPedido
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
        Me.grbProductos = New System.Windows.Forms.GroupBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstPedidos = New MetroFramework.Controls.MetroListView()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnAñadir = New MetroFramework.Controls.MetroTile()
        Me.btnGuardar = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblProductoSeleccionado = New MetroFramework.Controls.MetroLabel()
        Me.grbProductos.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbProductos
        '
        Me.grbProductos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.grbProductos.Controls.Add(Me.PictureBox9)
        Me.grbProductos.Controls.Add(Me.PictureBox8)
        Me.grbProductos.Controls.Add(Me.PictureBox7)
        Me.grbProductos.Controls.Add(Me.PictureBox6)
        Me.grbProductos.Controls.Add(Me.PictureBox5)
        Me.grbProductos.Controls.Add(Me.PictureBox4)
        Me.grbProductos.Controls.Add(Me.PictureBox3)
        Me.grbProductos.Controls.Add(Me.PictureBox2)
        Me.grbProductos.Controls.Add(Me.PictureBox1)
        Me.grbProductos.Location = New System.Drawing.Point(12, 12)
        Me.grbProductos.Name = "grbProductos"
        Me.grbProductos.Size = New System.Drawing.Size(182, 410)
        Me.grbProductos.TabIndex = 1
        Me.grbProductos.TabStop = False
        Me.grbProductos.Text = "Productos"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Formularios.My.Resources.Resources.tlf
        Me.PictureBox9.Location = New System.Drawing.Point(6, 250)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 1
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "Telefono"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Formularios.My.Resources.Resources.calculadoras
        Me.PictureBox8.Location = New System.Drawing.Point(92, 173)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "Calculadoras"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Formularios.My.Resources.Resources.carpetas
        Me.PictureBox7.Location = New System.Drawing.Point(6, 173)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "Carpetas"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Formularios.My.Resources.Resources.grapadoras
        Me.PictureBox6.Location = New System.Drawing.Point(92, 250)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "Grapadoras"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Formularios.My.Resources.Resources.perforadora
        Me.PictureBox5.Location = New System.Drawing.Point(92, 96)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Perforadora"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Formularios.My.Resources.Resources.lapices
        Me.PictureBox4.Location = New System.Drawing.Point(6, 96)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "Lapices"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Formularios.My.Resources.Resources.pack_10_boligrafos_paper_mate_s0957191
        Me.PictureBox3.Location = New System.Drawing.Point(50, 327)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Bolis"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Formularios.My.Resources.Resources.marcadores_fluorescentes_stabilo_boss_original_70_500x500
        Me.PictureBox2.Location = New System.Drawing.Point(92, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Subrayadores"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Formularios.My.Resources.Resources.Libretas_Duquesa_en_varios_colores_para_regalos_de_empresa_o_merchandising
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Cuadernos"
        '
        'lstPedidos
        '
        Me.lstPedidos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstPedidos.FullRowSelect = True
        Me.lstPedidos.Location = New System.Drawing.Point(200, 19)
        Me.lstPedidos.Name = "lstPedidos"
        Me.lstPedidos.OwnerDraw = True
        Me.lstPedidos.Size = New System.Drawing.Size(272, 283)
        Me.lstPedidos.Style = MetroFramework.MetroColorStyle.Orange
        Me.lstPedidos.TabIndex = 2
        Me.lstPedidos.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lstPedidos.UseCompatibleStateImageBehavior = False
        Me.lstPedidos.UseSelectable = True
        Me.lstPedidos.UseStyleColors = True
        Me.lstPedidos.View = System.Windows.Forms.View.List
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(391, 313)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(200, 308)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(185, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Cantidad de productos"
        Me.MetroLabel1.UseStyleColors = True
        '
        'btnAñadir
        '
        Me.btnAñadir.ActiveControl = Nothing
        Me.btnAñadir.Location = New System.Drawing.Point(233, 413)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(90, 36)
        Me.btnAñadir.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnAñadir.TabIndex = 5
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAñadir.UseSelectable = True
        Me.btnAñadir.UseStyleColors = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ActiveControl = Nothing
        Me.btnGuardar.Location = New System.Drawing.Point(352, 413)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 36)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(200, 355)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Producto seleccionado"
        Me.MetroLabel2.UseStyleColors = True
        '
        'lblProductoSeleccionado
        '
        Me.lblProductoSeleccionado.Location = New System.Drawing.Point(352, 355)
        Me.lblProductoSeleccionado.Name = "lblProductoSeleccionado"
        Me.lblProductoSeleccionado.Size = New System.Drawing.Size(120, 23)
        Me.lblProductoSeleccionado.TabIndex = 8
        Me.lblProductoSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAñadirPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.lblProductoSeleccionado)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lstPedidos)
        Me.Controls.Add(Me.grbProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAñadirPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAñadirPedido"
        Me.grbProductos.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbProductos As GroupBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstPedidos As MetroFramework.Controls.MetroListView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAñadir As MetroFramework.Controls.MetroTile
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProductoSeleccionado As MetroFramework.Controls.MetroLabel
End Class
