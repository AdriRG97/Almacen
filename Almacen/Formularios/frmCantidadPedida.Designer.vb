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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCantidadPedida))
        Me.grbPedidos = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'grbPedidos
        '
        Me.grbPedidos.Location = New System.Drawing.Point(34, 23)
        Me.grbPedidos.Name = "grbPedidos"
        Me.grbPedidos.Size = New System.Drawing.Size(447, 370)
        Me.grbPedidos.TabIndex = 0
        Me.grbPedidos.TabStop = False
        Me.grbPedidos.Text = "Productos pedidos:"
        '
        'frmCantidadPedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbPedidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCantidadPedida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbPedidos As GroupBox
End Class
