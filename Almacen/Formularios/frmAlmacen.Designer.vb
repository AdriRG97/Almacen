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
        Me.lblCuadernosT = New System.Windows.Forms.Label()
        Me.lblSubrayadoresT = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCuadernosQ = New System.Windows.Forms.Label()
        Me.lblSubrayadoresQ = New System.Windows.Forms.Label()
        Me.lblGrapadorasQ = New System.Windows.Forms.Label()
        Me.lblCarpetasQ = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnFinalizar = New MetroFramework.Controls.MetroButton()
        Me.pbBolis = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBolisQ = New System.Windows.Forms.Label()
        Me.lblCalculadorasQ = New System.Windows.Forms.Label()
        Me.lblCalculadoras = New System.Windows.Forms.Label()
        Me.pbCalculadoras = New System.Windows.Forms.PictureBox()
        Me.lblLapicesQ = New System.Windows.Forms.Label()
        Me.lblLapices = New System.Windows.Forms.Label()
        Me.pbLapices = New System.Windows.Forms.PictureBox()
        Me.lblTelefonoQ = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.pbTelefono = New System.Windows.Forms.PictureBox()
        Me.lblPerforadoraQ = New System.Windows.Forms.Label()
        Me.lblPerforadora = New System.Windows.Forms.Label()
        Me.pbPerforadora = New System.Windows.Forms.PictureBox()
        Me.copiaCuaderno = New System.Windows.Forms.PictureBox()
        Me.copiaSubrayadores = New System.Windows.Forms.PictureBox()
        Me.copiaBolis = New System.Windows.Forms.PictureBox()
        Me.copiaLapices = New System.Windows.Forms.PictureBox()
        Me.copiaGrapadoras = New System.Windows.Forms.PictureBox()
        Me.copiaCarpetas = New System.Windows.Forms.PictureBox()
        Me.copiaCalculadoras = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.copiaTelefono = New System.Windows.Forms.PictureBox()
        Me.copiaPerforadora = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.btnVerPedido = New MetroFramework.Controls.MetroButton()
        Me.btnStock = New MetroFramework.Controls.MetroButton()
        Me.btnTutorial = New MetroFramework.Controls.MetroButton()
        CType(Me.pbCuadernos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSubrayadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCarpetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGrapadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBolis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCalculadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLapices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPerforadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaCuaderno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaSubrayadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaBolis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaLapices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaGrapadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaCarpetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaCalculadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.copiaPerforadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCuadernos
        '
        Me.pbCuadernos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCuadernos.Image = CType(resources.GetObject("pbCuadernos.Image"), System.Drawing.Image)
        Me.pbCuadernos.Location = New System.Drawing.Point(58, 400)
        Me.pbCuadernos.Name = "pbCuadernos"
        Me.pbCuadernos.Size = New System.Drawing.Size(148, 140)
        Me.pbCuadernos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCuadernos.TabIndex = 2
        Me.pbCuadernos.TabStop = False
        Me.pbCuadernos.Tag = "5"
        '
        'pbSubrayadores
        '
        Me.pbSubrayadores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbSubrayadores.Image = CType(resources.GetObject("pbSubrayadores.Image"), System.Drawing.Image)
        Me.pbSubrayadores.Location = New System.Drawing.Point(387, 400)
        Me.pbSubrayadores.Name = "pbSubrayadores"
        Me.pbSubrayadores.Size = New System.Drawing.Size(136, 140)
        Me.pbSubrayadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSubrayadores.TabIndex = 1
        Me.pbSubrayadores.TabStop = False
        Me.pbSubrayadores.Tag = "3"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1531, 282)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(333, 368)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'pbCarpetas
        '
        Me.pbCarpetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCarpetas.Image = CType(resources.GetObject("pbCarpetas.Image"), System.Drawing.Image)
        Me.pbCarpetas.Location = New System.Drawing.Point(367, 664)
        Me.pbCarpetas.Name = "pbCarpetas"
        Me.pbCarpetas.Size = New System.Drawing.Size(197, 143)
        Me.pbCarpetas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCarpetas.TabIndex = 3
        Me.pbCarpetas.TabStop = False
        Me.pbCarpetas.Tag = "10"
        '
        'pbGrapadoras
        '
        Me.pbGrapadoras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbGrapadoras.Image = CType(resources.GetObject("pbGrapadoras.Image"), System.Drawing.Image)
        Me.pbGrapadoras.Location = New System.Drawing.Point(57, 667)
        Me.pbGrapadoras.Name = "pbGrapadoras"
        Me.pbGrapadoras.Size = New System.Drawing.Size(147, 137)
        Me.pbGrapadoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGrapadoras.TabIndex = 4
        Me.pbGrapadoras.TabStop = False
        Me.pbGrapadoras.Tag = "2"
        '
        'lblCuadernosT
        '
        Me.lblCuadernosT.AutoSize = True
        Me.lblCuadernosT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuadernosT.Location = New System.Drawing.Point(33, 352)
        Me.lblCuadernosT.Name = "lblCuadernosT"
        Me.lblCuadernosT.Size = New System.Drawing.Size(205, 20)
        Me.lblCuadernosT.TabIndex = 7
        Me.lblCuadernosT.Text = "Paquete de 5 cuadernos"
        '
        'lblSubrayadoresT
        '
        Me.lblSubrayadoresT.AutoSize = True
        Me.lblSubrayadoresT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubrayadoresT.Location = New System.Drawing.Point(335, 352)
        Me.lblSubrayadoresT.Name = "lblSubrayadoresT"
        Me.lblSubrayadoresT.Size = New System.Drawing.Size(229, 20)
        Me.lblSubrayadoresT.TabIndex = 8
        Me.lblSubrayadoresT.Text = "Paquete de 3 subrayadores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 623)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Paquete de 2 grapadoras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(362, 626)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Paquete de 10 carpetas"
        '
        'lblCuadernosQ
        '
        Me.lblCuadernosQ.AutoSize = True
        Me.lblCuadernosQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuadernosQ.ForeColor = System.Drawing.Color.Teal
        Me.lblCuadernosQ.Location = New System.Drawing.Point(54, 557)
        Me.lblCuadernosQ.Name = "lblCuadernosQ"
        Me.lblCuadernosQ.Size = New System.Drawing.Size(148, 18)
        Me.lblCuadernosQ.TabIndex = 11
        Me.lblCuadernosQ.Text = "Quedan X cuadernos"
        '
        'lblSubrayadoresQ
        '
        Me.lblSubrayadoresQ.AutoSize = True
        Me.lblSubrayadoresQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubrayadoresQ.ForeColor = System.Drawing.Color.Teal
        Me.lblSubrayadoresQ.Location = New System.Drawing.Point(370, 557)
        Me.lblSubrayadoresQ.Name = "lblSubrayadoresQ"
        Me.lblSubrayadoresQ.Size = New System.Drawing.Size(168, 18)
        Me.lblSubrayadoresQ.TabIndex = 12
        Me.lblSubrayadoresQ.Text = "Quedan X subrayadores"
        '
        'lblGrapadorasQ
        '
        Me.lblGrapadorasQ.AutoSize = True
        Me.lblGrapadorasQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrapadorasQ.ForeColor = System.Drawing.Color.Teal
        Me.lblGrapadorasQ.Location = New System.Drawing.Point(51, 814)
        Me.lblGrapadorasQ.Name = "lblGrapadorasQ"
        Me.lblGrapadorasQ.Size = New System.Drawing.Size(153, 18)
        Me.lblGrapadorasQ.TabIndex = 13
        Me.lblGrapadorasQ.Text = "Quedan X grapadoras"
        '
        'lblCarpetasQ
        '
        Me.lblCarpetasQ.AutoSize = True
        Me.lblCarpetasQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarpetasQ.ForeColor = System.Drawing.Color.Teal
        Me.lblCarpetasQ.Location = New System.Drawing.Point(392, 814)
        Me.lblCarpetasQ.Name = "lblCarpetasQ"
        Me.lblCarpetasQ.Size = New System.Drawing.Size(135, 18)
        Me.lblCarpetasQ.TabIndex = 14
        Me.lblCarpetasQ.Text = "Quedan X carpetas"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitulo.Location = New System.Drawing.Point(576, 48)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(481, 73)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Juego almacén"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnFinalizar.Highlight = True
        Me.btnFinalizar.Location = New System.Drawing.Point(545, 961)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(262, 52)
        Me.btnFinalizar.TabIndex = 18
        Me.btnFinalizar.Text = "Finalizar pedido"
        Me.btnFinalizar.UseSelectable = True
        '
        'pbBolis
        '
        Me.pbBolis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBolis.Image = CType(resources.GetObject("pbBolis.Image"), System.Drawing.Image)
        Me.pbBolis.Location = New System.Drawing.Point(707, 400)
        Me.pbBolis.Name = "pbBolis"
        Me.pbBolis.Size = New System.Drawing.Size(135, 140)
        Me.pbBolis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBolis.TabIndex = 19
        Me.pbBolis.TabStop = False
        Me.pbBolis.Tag = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(674, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Paquete de 10 bolígrafos"
        '
        'lblBolisQ
        '
        Me.lblBolisQ.AutoSize = True
        Me.lblBolisQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBolisQ.ForeColor = System.Drawing.Color.Teal
        Me.lblBolisQ.Location = New System.Drawing.Point(720, 557)
        Me.lblBolisQ.Name = "lblBolisQ"
        Me.lblBolisQ.Size = New System.Drawing.Size(109, 18)
        Me.lblBolisQ.TabIndex = 21
        Me.lblBolisQ.Text = "Quedan X bolis"
        '
        'lblCalculadorasQ
        '
        Me.lblCalculadorasQ.AutoSize = True
        Me.lblCalculadorasQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculadorasQ.ForeColor = System.Drawing.Color.Teal
        Me.lblCalculadorasQ.Location = New System.Drawing.Point(693, 811)
        Me.lblCalculadorasQ.Name = "lblCalculadorasQ"
        Me.lblCalculadorasQ.Size = New System.Drawing.Size(168, 18)
        Me.lblCalculadorasQ.TabIndex = 24
        Me.lblCalculadorasQ.Text = "Quedan X subrayadores"
        '
        'lblCalculadoras
        '
        Me.lblCalculadoras.AutoSize = True
        Me.lblCalculadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculadoras.Location = New System.Drawing.Point(674, 626)
        Me.lblCalculadoras.Name = "lblCalculadoras"
        Me.lblCalculadoras.Size = New System.Drawing.Size(222, 20)
        Me.lblCalculadoras.TabIndex = 23
        Me.lblCalculadoras.Text = "Paquete de 3 calculadoras"
        '
        'pbCalculadoras
        '
        Me.pbCalculadoras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCalculadoras.Image = CType(resources.GetObject("pbCalculadoras.Image"), System.Drawing.Image)
        Me.pbCalculadoras.Location = New System.Drawing.Point(707, 664)
        Me.pbCalculadoras.Name = "pbCalculadoras"
        Me.pbCalculadoras.Size = New System.Drawing.Size(135, 140)
        Me.pbCalculadoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCalculadoras.TabIndex = 22
        Me.pbCalculadoras.TabStop = False
        Me.pbCalculadoras.Tag = "3"
        '
        'lblLapicesQ
        '
        Me.lblLapicesQ.AutoSize = True
        Me.lblLapicesQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLapicesQ.ForeColor = System.Drawing.Color.Teal
        Me.lblLapicesQ.Location = New System.Drawing.Point(1004, 557)
        Me.lblLapicesQ.Name = "lblLapicesQ"
        Me.lblLapicesQ.Size = New System.Drawing.Size(124, 18)
        Me.lblLapicesQ.TabIndex = 27
        Me.lblLapicesQ.Text = "Quedan X lápices"
        '
        'lblLapices
        '
        Me.lblLapices.AutoSize = True
        Me.lblLapices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLapices.Location = New System.Drawing.Point(980, 352)
        Me.lblLapices.Name = "lblLapices"
        Me.lblLapices.Size = New System.Drawing.Size(177, 20)
        Me.lblLapices.TabIndex = 26
        Me.lblLapices.Text = "Paquete de 5 lápices"
        '
        'pbLapices
        '
        Me.pbLapices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbLapices.Image = CType(resources.GetObject("pbLapices.Image"), System.Drawing.Image)
        Me.pbLapices.Location = New System.Drawing.Point(997, 400)
        Me.pbLapices.Name = "pbLapices"
        Me.pbLapices.Size = New System.Drawing.Size(135, 140)
        Me.pbLapices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLapices.TabIndex = 25
        Me.pbLapices.TabStop = False
        Me.pbLapices.Tag = "5"
        '
        'lblTelefonoQ
        '
        Me.lblTelefonoQ.AutoSize = True
        Me.lblTelefonoQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoQ.ForeColor = System.Drawing.Color.Teal
        Me.lblTelefonoQ.Location = New System.Drawing.Point(978, 810)
        Me.lblTelefonoQ.Name = "lblTelefonoQ"
        Me.lblTelefonoQ.Size = New System.Drawing.Size(168, 18)
        Me.lblTelefonoQ.TabIndex = 30
        Me.lblTelefonoQ.Text = "Quedan X subrayadores"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(1029, 626)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(79, 20)
        Me.lblTelefono.TabIndex = 29
        Me.lblTelefono.Text = "Teléfono"
        '
        'pbTelefono
        '
        Me.pbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbTelefono.Image = CType(resources.GetObject("pbTelefono.Image"), System.Drawing.Image)
        Me.pbTelefono.Location = New System.Drawing.Point(997, 662)
        Me.pbTelefono.Name = "pbTelefono"
        Me.pbTelefono.Size = New System.Drawing.Size(135, 140)
        Me.pbTelefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTelefono.TabIndex = 28
        Me.pbTelefono.TabStop = False
        Me.pbTelefono.Tag = "1"
        '
        'lblPerforadoraQ
        '
        Me.lblPerforadoraQ.AutoSize = True
        Me.lblPerforadoraQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerforadoraQ.ForeColor = System.Drawing.Color.Teal
        Me.lblPerforadoraQ.Location = New System.Drawing.Point(1263, 652)
        Me.lblPerforadoraQ.Name = "lblPerforadoraQ"
        Me.lblPerforadoraQ.Size = New System.Drawing.Size(163, 18)
        Me.lblPerforadoraQ.TabIndex = 33
        Me.lblPerforadoraQ.Text = "Quedan X perforadoras"
        '
        'lblPerforadora
        '
        Me.lblPerforadora.AutoSize = True
        Me.lblPerforadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerforadora.Location = New System.Drawing.Point(1284, 447)
        Me.lblPerforadora.Name = "lblPerforadora"
        Me.lblPerforadora.Size = New System.Drawing.Size(104, 20)
        Me.lblPerforadora.TabIndex = 32
        Me.lblPerforadora.Text = "Perforadora"
        '
        'pbPerforadora
        '
        Me.pbPerforadora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPerforadora.Image = CType(resources.GetObject("pbPerforadora.Image"), System.Drawing.Image)
        Me.pbPerforadora.Location = New System.Drawing.Point(1276, 495)
        Me.pbPerforadora.Name = "pbPerforadora"
        Me.pbPerforadora.Size = New System.Drawing.Size(135, 140)
        Me.pbPerforadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPerforadora.TabIndex = 31
        Me.pbPerforadora.TabStop = False
        Me.pbPerforadora.Tag = "1"
        '
        'copiaCuaderno
        '
        Me.copiaCuaderno.Image = CType(resources.GetObject("copiaCuaderno.Image"), System.Drawing.Image)
        Me.copiaCuaderno.Location = New System.Drawing.Point(58, 400)
        Me.copiaCuaderno.Name = "copiaCuaderno"
        Me.copiaCuaderno.Size = New System.Drawing.Size(148, 140)
        Me.copiaCuaderno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaCuaderno.TabIndex = 35
        Me.copiaCuaderno.TabStop = False
        '
        'copiaSubrayadores
        '
        Me.copiaSubrayadores.Image = CType(resources.GetObject("copiaSubrayadores.Image"), System.Drawing.Image)
        Me.copiaSubrayadores.Location = New System.Drawing.Point(387, 400)
        Me.copiaSubrayadores.Name = "copiaSubrayadores"
        Me.copiaSubrayadores.Size = New System.Drawing.Size(136, 140)
        Me.copiaSubrayadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaSubrayadores.TabIndex = 36
        Me.copiaSubrayadores.TabStop = False
        '
        'copiaBolis
        '
        Me.copiaBolis.Image = CType(resources.GetObject("copiaBolis.Image"), System.Drawing.Image)
        Me.copiaBolis.Location = New System.Drawing.Point(707, 400)
        Me.copiaBolis.Name = "copiaBolis"
        Me.copiaBolis.Size = New System.Drawing.Size(135, 140)
        Me.copiaBolis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaBolis.TabIndex = 45
        Me.copiaBolis.TabStop = False
        '
        'copiaLapices
        '
        Me.copiaLapices.Image = CType(resources.GetObject("copiaLapices.Image"), System.Drawing.Image)
        Me.copiaLapices.Location = New System.Drawing.Point(997, 400)
        Me.copiaLapices.Name = "copiaLapices"
        Me.copiaLapices.Size = New System.Drawing.Size(135, 140)
        Me.copiaLapices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaLapices.TabIndex = 46
        Me.copiaLapices.TabStop = False
        '
        'copiaGrapadoras
        '
        Me.copiaGrapadoras.Image = CType(resources.GetObject("copiaGrapadoras.Image"), System.Drawing.Image)
        Me.copiaGrapadoras.Location = New System.Drawing.Point(57, 667)
        Me.copiaGrapadoras.Name = "copiaGrapadoras"
        Me.copiaGrapadoras.Size = New System.Drawing.Size(147, 137)
        Me.copiaGrapadoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaGrapadoras.TabIndex = 47
        Me.copiaGrapadoras.TabStop = False
        '
        'copiaCarpetas
        '
        Me.copiaCarpetas.Image = CType(resources.GetObject("copiaCarpetas.Image"), System.Drawing.Image)
        Me.copiaCarpetas.Location = New System.Drawing.Point(367, 666)
        Me.copiaCarpetas.Name = "copiaCarpetas"
        Me.copiaCarpetas.Size = New System.Drawing.Size(196, 141)
        Me.copiaCarpetas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaCarpetas.TabIndex = 48
        Me.copiaCarpetas.TabStop = False
        '
        'copiaCalculadoras
        '
        Me.copiaCalculadoras.Image = CType(resources.GetObject("copiaCalculadoras.Image"), System.Drawing.Image)
        Me.copiaCalculadoras.Location = New System.Drawing.Point(707, 664)
        Me.copiaCalculadoras.Name = "copiaCalculadoras"
        Me.copiaCalculadoras.Size = New System.Drawing.Size(135, 140)
        Me.copiaCalculadoras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaCalculadoras.TabIndex = 49
        Me.copiaCalculadoras.TabStop = False
        '
        'copiaTelefono
        '
        Me.copiaTelefono.Image = CType(resources.GetObject("copiaTelefono.Image"), System.Drawing.Image)
        Me.copiaTelefono.Location = New System.Drawing.Point(997, 662)
        Me.copiaTelefono.Name = "copiaTelefono"
        Me.copiaTelefono.Size = New System.Drawing.Size(135, 140)
        Me.copiaTelefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaTelefono.TabIndex = 51
        Me.copiaTelefono.TabStop = False
        '
        'copiaPerforadora
        '
        Me.copiaPerforadora.Image = CType(resources.GetObject("copiaPerforadora.Image"), System.Drawing.Image)
        Me.copiaPerforadora.Location = New System.Drawing.Point(1276, 495)
        Me.copiaPerforadora.Name = "copiaPerforadora"
        Me.copiaPerforadora.Size = New System.Drawing.Size(135, 140)
        Me.copiaPerforadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.copiaPerforadora.TabIndex = 52
        Me.copiaPerforadora.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSalir.Highlight = True
        Me.btnSalir.Location = New System.Drawing.Point(859, 961)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(262, 52)
        Me.btnSalir.TabIndex = 54
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'btnVerPedido
        '
        Me.btnVerPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerPedido.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnVerPedido.Highlight = True
        Me.btnVerPedido.Location = New System.Drawing.Point(1282, 798)
        Me.btnVerPedido.Name = "btnVerPedido"
        Me.btnVerPedido.Size = New System.Drawing.Size(247, 87)
        Me.btnVerPedido.TabIndex = 55
        Me.btnVerPedido.Text = "Ver como va nuestro pedido"
        Me.btnVerPedido.UseSelectable = True
        '
        'btnStock
        '
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnStock.Highlight = True
        Me.btnStock.Location = New System.Drawing.Point(1591, 798)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(247, 87)
        Me.btnStock.TabIndex = 56
        Me.btnStock.Text = "Recargar Stock"
        Me.btnStock.UseSelectable = True
        '
        'btnTutorial
        '
        Me.btnTutorial.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTutorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutorial.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnTutorial.Highlight = True
        Me.btnTutorial.Location = New System.Drawing.Point(1266, 94)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(154, 88)
        Me.btnTutorial.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnTutorial.TabIndex = 57
        Me.btnTutorial.Text = "¿Cómo se juega?"
        Me.btnTutorial.UseCustomBackColor = True
        Me.btnTutorial.UseCustomForeColor = True
        Me.btnTutorial.UseSelectable = True
        '
        'frmAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnVerPedido)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblPerforadoraQ)
        Me.Controls.Add(Me.lblPerforadora)
        Me.Controls.Add(Me.pbPerforadora)
        Me.Controls.Add(Me.lblTelefonoQ)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.pbTelefono)
        Me.Controls.Add(Me.lblLapicesQ)
        Me.Controls.Add(Me.lblLapices)
        Me.Controls.Add(Me.pbLapices)
        Me.Controls.Add(Me.lblCalculadorasQ)
        Me.Controls.Add(Me.lblCalculadoras)
        Me.Controls.Add(Me.pbCalculadoras)
        Me.Controls.Add(Me.lblBolisQ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbBolis)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblCarpetasQ)
        Me.Controls.Add(Me.lblGrapadorasQ)
        Me.Controls.Add(Me.lblSubrayadoresQ)
        Me.Controls.Add(Me.lblCuadernosQ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSubrayadoresT)
        Me.Controls.Add(Me.lblCuadernosT)
        Me.Controls.Add(Me.pbGrapadoras)
        Me.Controls.Add(Me.pbCarpetas)
        Me.Controls.Add(Me.pbCuadernos)
        Me.Controls.Add(Me.copiaCuaderno)
        Me.Controls.Add(Me.pbSubrayadores)
        Me.Controls.Add(Me.copiaSubrayadores)
        Me.Controls.Add(Me.copiaBolis)
        Me.Controls.Add(Me.copiaLapices)
        Me.Controls.Add(Me.copiaGrapadoras)
        Me.Controls.Add(Me.copiaCarpetas)
        Me.Controls.Add(Me.copiaTelefono)
        Me.Controls.Add(Me.copiaPerforadora)
        Me.Controls.Add(Me.copiaCalculadoras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "r5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbCuadernos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSubrayadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCarpetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGrapadoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBolis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCalculadoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLapices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPerforadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaCuaderno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaSubrayadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaBolis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaLapices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaGrapadoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaCarpetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaCalculadoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.copiaPerforadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbCuadernos As PictureBox
    Friend WithEvents pbSubrayadores As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbCarpetas As PictureBox
    Friend WithEvents pbGrapadoras As PictureBox
    Friend WithEvents lblCuadernosT As Label
    Friend WithEvents lblSubrayadoresT As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCuadernosQ As Label
    Friend WithEvents lblSubrayadoresQ As Label
    Friend WithEvents lblGrapadorasQ As Label
    Friend WithEvents lblCarpetasQ As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnFinalizar As MetroFramework.Controls.MetroButton
    Friend WithEvents pbBolis As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBolisQ As Label
    Friend WithEvents lblCalculadorasQ As Label
    Friend WithEvents lblCalculadoras As Label
    Friend WithEvents pbCalculadoras As PictureBox
    Friend WithEvents lblLapicesQ As Label
    Friend WithEvents lblLapices As Label
    Friend WithEvents pbLapices As PictureBox
    Friend WithEvents lblTelefonoQ As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents pbTelefono As PictureBox
    Friend WithEvents lblPerforadoraQ As Label
    Friend WithEvents lblPerforadora As Label
    Friend WithEvents pbPerforadora As PictureBox
    Friend WithEvents copiaCuaderno As PictureBox
    Friend WithEvents copiaSubrayadores As PictureBox
    Friend WithEvents copiaBolis As PictureBox
    Friend WithEvents copiaLapices As PictureBox
    Friend WithEvents copiaGrapadoras As PictureBox
    Friend WithEvents copiaCarpetas As PictureBox
    Friend WithEvents copiaCalculadoras As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents copiaTelefono As PictureBox
    Friend WithEvents copiaPerforadora As PictureBox
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVerPedido As MetroFramework.Controls.MetroButton
    Friend WithEvents btnStock As MetroFramework.Controls.MetroButton
    Friend WithEvents btnTutorial As MetroFramework.Controls.MetroButton
End Class
