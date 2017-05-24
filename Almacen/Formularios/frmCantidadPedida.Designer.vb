<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCantidadPedida
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCantidadPedida))
        Me.grbPedidos = New System.Windows.Forms.GroupBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.lblNuestroPedido = New MetroFramework.Controls.MetroLabel()
        Me.FrmAlmacenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrmAlmacenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grbPedidos.SuspendLayout()
        CType(Me.FrmAlmacenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmAlmacenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbPedidos
        '
        Me.grbPedidos.Controls.Add(Me.MetroLabel1)
        Me.grbPedidos.Location = New System.Drawing.Point(35, 107)
        Me.grbPedidos.Name = "grbPedidos"
        Me.grbPedidos.Size = New System.Drawing.Size(447, 370)
        Me.grbPedidos.TabIndex = 0
        Me.grbPedidos.TabStop = False
        Me.grbPedidos.Text = "Pedido:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(28, 20)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(393, 335)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "lblNuestroPedido"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnAceptar.Highlight = True
        Me.btnAceptar.Location = New System.Drawing.Point(205, 529)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(116, 44)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseCustomBackColor = True
        Me.btnAceptar.UseSelectable = True
        '
        'lblNuestroPedido
        '
        Me.lblNuestroPedido.BackColor = System.Drawing.SystemColors.Info
        Me.lblNuestroPedido.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblNuestroPedido.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblNuestroPedido.Location = New System.Drawing.Point(148, 27)
        Me.lblNuestroPedido.Name = "lblNuestroPedido"
        Me.lblNuestroPedido.Size = New System.Drawing.Size(215, 57)
        Me.lblNuestroPedido.TabIndex = 3
        Me.lblNuestroPedido.Text = "Así va nuestro pedido"
        Me.lblNuestroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNuestroPedido.UseCustomBackColor = True
        '
        'FrmAlmacenBindingSource
        '
        Me.FrmAlmacenBindingSource.DataSource = GetType(Formularios.frmAlmacen)
        '
        'FrmAlmacenBindingSource1
        '
        Me.FrmAlmacenBindingSource1.DataSource = GetType(Formularios.frmAlmacen)
        '
        'frmCantidadPedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(528, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNuestroPedido)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grbPedidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCantidadPedida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        Me.grbPedidos.ResumeLayout(False)
        CType(Me.FrmAlmacenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmAlmacenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbPedidos As GroupBox
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Private WithEvents lblNuestroPedido As MetroFramework.Controls.MetroLabel
    Friend WithEvents FrmAlmacenBindingSource As BindingSource
    Friend WithEvents FrmAlmacenBindingSource1 As BindingSource
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
