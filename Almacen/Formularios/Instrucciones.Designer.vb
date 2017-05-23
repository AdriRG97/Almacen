<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instrucciones
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
        Me.TxtBox_instrucciones = New System.Windows.Forms.TextBox()
        Me.Label_instrucciones = New System.Windows.Forms.Label()
        Me.Btn_Entendido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBox_instrucciones
        '
        Me.TxtBox_instrucciones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtBox_instrucciones.Font = New System.Drawing.Font("Nunito", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_instrucciones.Location = New System.Drawing.Point(143, 104)
        Me.TxtBox_instrucciones.Multiline = True
        Me.TxtBox_instrucciones.Name = "TxtBox_instrucciones"
        Me.TxtBox_instrucciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBox_instrucciones.Size = New System.Drawing.Size(378, 309)
        Me.TxtBox_instrucciones.TabIndex = 3
        Me.TxtBox_instrucciones.Text = "Lo importante está en el load xD"
        '
        'Label_instrucciones
        '
        Me.Label_instrucciones.AutoSize = True
        Me.Label_instrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_instrucciones.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_instrucciones.Location = New System.Drawing.Point(205, 34)
        Me.Label_instrucciones.Name = "Label_instrucciones"
        Me.Label_instrucciones.Size = New System.Drawing.Size(255, 31)
        Me.Label_instrucciones.TabIndex = 2
        Me.Label_instrucciones.Text = "INSTRUCCIONES"
        Me.Label_instrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Entendido
        '
        Me.Btn_Entendido.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Btn_Entendido.FlatAppearance.BorderSize = 6
        Me.Btn_Entendido.Location = New System.Drawing.Point(252, 456)
        Me.Btn_Entendido.Name = "Btn_Entendido"
        Me.Btn_Entendido.Size = New System.Drawing.Size(131, 64)
        Me.Btn_Entendido.TabIndex = 1
        Me.Btn_Entendido.Text = "Entendido"
        Me.Btn_Entendido.UseVisualStyleBackColor = False
        '
        'Instrucciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 580)
        Me.Controls.Add(Me.Btn_Entendido)
        Me.Controls.Add(Me.Label_instrucciones)
        Me.Controls.Add(Me.TxtBox_instrucciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Instrucciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instrucciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_instrucciones As Label
    Friend WithEvents Btn_Entendido As Button
    Friend WithEvents TxtBox_instrucciones As TextBox
End Class
