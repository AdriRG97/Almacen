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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instrucciones))
        Me.TxtBox_instrucciones = New System.Windows.Forms.TextBox()
        Me.Label_instrucciones = New System.Windows.Forms.Label()
        Me.Btn_Entendido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBox_instrucciones
        '
        Me.TxtBox_instrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.45!)
        Me.TxtBox_instrucciones.Location = New System.Drawing.Point(138, 106)
        Me.TxtBox_instrucciones.Multiline = True
        Me.TxtBox_instrucciones.Name = "TxtBox_instrucciones"
        Me.TxtBox_instrucciones.Size = New System.Drawing.Size(409, 190)
        Me.TxtBox_instrucciones.TabIndex = 0
        Me.TxtBox_instrucciones.Text = resources.GetString("TxtBox_instrucciones.Text")
        '
        'Label_instrucciones
        '
        Me.Label_instrucciones.AutoSize = True
        Me.Label_instrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label_instrucciones.Location = New System.Drawing.Point(250, 64)
        Me.Label_instrucciones.Name = "Label_instrucciones"
        Me.Label_instrucciones.Size = New System.Drawing.Size(196, 25)
        Me.Label_instrucciones.TabIndex = 1
        Me.Label_instrucciones.Text = "INSTRUCCIONES"
        Me.Label_instrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Entendido
        '
        Me.Btn_Entendido.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btn_Entendido.FlatAppearance.BorderSize = 6
        Me.Btn_Entendido.Location = New System.Drawing.Point(287, 319)
        Me.Btn_Entendido.Name = "Btn_Entendido"
        Me.Btn_Entendido.Size = New System.Drawing.Size(104, 31)
        Me.Btn_Entendido.TabIndex = 2
        Me.Btn_Entendido.Text = "Entendido"
        Me.Btn_Entendido.UseVisualStyleBackColor = False
        '
        'Instrucciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 387)
        Me.Controls.Add(Me.Btn_Entendido)
        Me.Controls.Add(Me.Label_instrucciones)
        Me.Controls.Add(Me.TxtBox_instrucciones)
        Me.Name = "Instrucciones"
        Me.Text = "Instrucciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBox_instrucciones As TextBox
    Friend WithEvents Label_instrucciones As Label
    Friend WithEvents Btn_Entendido As Button
End Class
