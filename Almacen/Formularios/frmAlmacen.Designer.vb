<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmacen))
        Me.pbCuadernos = New System.Windows.Forms.PictureBox()
        Me.pbSubrayadores = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbCarpetas = New System.Windows.Forms.PictureBox()
        Me.pbGrapadoras = New System.Windows.Forms.PictureBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCuadernosT = New System.Windows.Forms.Label()
        Me.lblSubrayadoresT = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCuadernosQ = New System.Windows.Forms.Label()
        Me.lblSubrayadoresQ = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbCuadernos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSubrayadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCarpetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGrapadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbCuadernos
        '
        Me.pbCuadernos.Image = CType(resources.GetObject("pbCuadernos.Image"), System.Drawing.Image)
        Me.pbCuadernos.Location = New System.Drawing.Point(67, 208)
        Me.pbCuadernos.Name = "pbCuadernos"
        Me.pbCuadernos.Size = New System.Drawing.Size(148, 140)
        Me.pbCuadernos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCuadernos.TabIndex = 2
        Me.pbCuadernos.TabStop = False
        '
        'pbSubrayadores
        '
        Me.pbSubrayadores.Image = CType(resources.GetObject("pbSubrayadores.Image"), System.Drawing.Image)
        Me.pbSubrayadores.Location = New System.Drawing.Point(292, 217)
        Me.pbSubrayadores.Name = "pbSubrayadores"
        Me.pbSubrayadores.Size = New System.Drawing.Size(125, 131)
        Me.pbSubrayadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSubrayadores.TabIndex = 1
        Me.pbSubrayadores.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(333, 368)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'pbCarpetas
        '
        Me.pbCarpetas.Image = CType(resources.GetObject("pbCarpetas.Image"), System.Drawing.Image)
        Me.pbCarpetas.Location = New System.Drawing.Point(265, 499)
        Me.pbCarpetas.Name = "pbCarpetas"
        Me.pbCarpetas.Size = New System.Drawing.Size(163, 103)
        Me.pbCarpetas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCarpetas.TabIndex = 3
        Me.pbCarpetas.TabStop = False
        '
        'pbGrapadoras
        '
        Me.pbGrapadoras.Image = CType(resources.GetObject("pbGrapadoras.Image"), System.Drawing.Image)
        Me.pbGrapadoras.Location = New System.Drawing.Point(68, 477)
        Me.pbGrapadoras.Name = "pbGrapadoras"
        Me.pbGrapadoras.Size = New System.Drawing.Size(147, 137)
        Me.pbGrapadoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGrapadoras.TabIndex = 4
        Me.pbGrapadoras.TabStop = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnFinalizar.Location = New System.Drawing.Point(495, 717)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(166, 83)
        Me.btnFinalizar.TabIndex = 5
        Me.btnFinalizar.Text = "Finalizar pedido"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(715, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 419)
        Me.Panel1.TabIndex = 6
        '
        'lblCuadernosT
        '
        Me.lblCuadernosT.AutoSize = True
        Me.lblCuadernosT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuadernosT.Location = New System.Drawing.Point(64, 181)
        Me.lblCuadernosT.Name = "lblCuadernosT"
        Me.lblCuadernosT.Size = New System.Drawing.Size(146, 13)
        Me.lblCuadernosT.TabIndex = 7
        Me.lblCuadernosT.Text = "Paquete de 5 cuadernos"
        '
        'lblSubrayadoresT
        '
        Me.lblSubrayadoresT.AutoSize = True
        Me.lblSubrayadoresT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubrayadoresT.Location = New System.Drawing.Point(280, 181)
        Me.lblSubrayadoresT.Name = "lblSubrayadoresT"
        Me.lblSubrayadoresT.Size = New System.Drawing.Size(162, 13)
        Me.lblSubrayadoresT.TabIndex = 8
        Me.lblSubrayadoresT.Text = "Paquete de 3 subrayadores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Paquete de 2 grapadoras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Paquete de 10 carpetas"
        '
        'lblCuadernosQ
        '
        Me.lblCuadernosQ.AutoSize = True
        Me.lblCuadernosQ.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCuadernosQ.Location = New System.Drawing.Point(79, 360)
        Me.lblCuadernosQ.Name = "lblCuadernosQ"
        Me.lblCuadernosQ.Size = New System.Drawing.Size(108, 13)
        Me.lblCuadernosQ.TabIndex = 11
        Me.lblCuadernosQ.Text = "Quedan X cuadernos"
        '
        'lblSubrayadoresQ
        '
        Me.lblSubrayadoresQ.AutoSize = True
        Me.lblSubrayadoresQ.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSubrayadoresQ.Location = New System.Drawing.Point(289, 360)
        Me.lblSubrayadoresQ.Name = "lblSubrayadoresQ"
        Me.lblSubrayadoresQ.Size = New System.Drawing.Size(121, 13)
        Me.lblSubrayadoresQ.TabIndex = 12
        Me.lblSubrayadoresQ.Text = "Quedan X subrayadores"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Location = New System.Drawing.Point(79, 617)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Quedan X grapadoras"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Location = New System.Drawing.Point(289, 617)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Quedan X carpetas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Penultimate", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label1.Location = New System.Drawing.Point(184, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 53)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Juego almacén"
        '
        'frmAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 856)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSubrayadoresQ)
        Me.Controls.Add(Me.lblCuadernosQ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSubrayadoresT)
        Me.Controls.Add(Me.lblCuadernosT)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.pbGrapadoras)
        Me.Controls.Add(Me.pbCarpetas)
        Me.Controls.Add(Me.pbCuadernos)
        Me.Controls.Add(Me.pbSubrayadores)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego Almacén"
        CType(Me.pbCuadernos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSubrayadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCarpetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGrapadoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbCuadernos As PictureBox
    Friend WithEvents pbSubrayadores As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbCarpetas As PictureBox
    Friend WithEvents pbGrapadoras As PictureBox
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCuadernosT As Label
    Friend WithEvents lblSubrayadoresT As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCuadernosQ As Label
    Friend WithEvents lblSubrayadoresQ As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
End Class
