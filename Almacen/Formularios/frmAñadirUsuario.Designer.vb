<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAñadirUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAñadirUsuario))
        Me.txtUsuario = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txtContraseña = New Bunifu.Framework.UI.BunifuTextbox()
        Me.btnCrearUsuario = New WindowsFormsControlLibrary1.BunifuThinButton()
        Me.btnSalir = New WindowsFormsControlLibrary1.BunifuThinButton()
        Me.lblCrearUsuario = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Linen
        Me.txtUsuario.BackgroundImage = CType(resources.GetObject("txtUsuario.BackgroundImage"), System.Drawing.Image)
        Me.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUsuario.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtUsuario.Icon = CType(resources.GetObject("txtUsuario.Icon"), System.Drawing.Image)
        Me.txtUsuario.Location = New System.Drawing.Point(230, 142)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(250, 42)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.text = ""
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.Linen
        Me.txtContraseña.BackgroundImage = CType(resources.GetObject("txtContraseña.BackgroundImage"), System.Drawing.Image)
        Me.txtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtContraseña.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtContraseña.Icon = CType(resources.GetObject("txtContraseña.Icon"), System.Drawing.Image)
        Me.txtContraseña.Location = New System.Drawing.Point(230, 232)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(250, 42)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.text = ""
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCrearUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearUsuario.ButtonText = "Crear usuario"
        Me.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario.ForeColor = System.Drawing.Color.Black
        Me.btnCrearUsuario.ForeColorHoverState = System.Drawing.Color.Transparent
        Me.btnCrearUsuario.Iconimage = Nothing
        Me.btnCrearUsuario.IconVisible = True
        Me.btnCrearUsuario.IconZoom = 90.0R
        Me.btnCrearUsuario.ImageIconOverlay = False
        Me.btnCrearUsuario.Location = New System.Drawing.Point(58, 312)
        Me.btnCrearUsuario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(422, 39)
        Me.btnCrearUsuario.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Firebrick
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.ButtonText = "Salir"
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.ForeColorHoverState = System.Drawing.Color.Transparent
        Me.btnSalir.Iconimage = Nothing
        Me.btnSalir.IconVisible = True
        Me.btnSalir.IconZoom = 90.0R
        Me.btnSalir.ImageIconOverlay = False
        Me.btnSalir.Location = New System.Drawing.Point(58, 376)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(422, 39)
        Me.btnSalir.TabIndex = 3
        '
        'lblCrearUsuario
        '
        Me.lblCrearUsuario.BackColor = System.Drawing.Color.Purple
        Me.lblCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCrearUsuario.Location = New System.Drawing.Point(128, 44)
        Me.lblCrearUsuario.Name = "lblCrearUsuario"
        Me.lblCrearUsuario.Size = New System.Drawing.Size(291, 47)
        Me.lblCrearUsuario.TabIndex = 4
        Me.lblCrearUsuario.Text = "CREANDO UN NUEVO USUARIO"
        Me.lblCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(32, 150)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(128, 27)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Usuario"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(32, 249)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(128, 27)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Contraseña"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAñadirUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(561, 427)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.lblCrearUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAñadirUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAñadirUsuario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsuario As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtContraseña As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents btnCrearUsuario As WindowsFormsControlLibrary1.BunifuThinButton
    Friend WithEvents btnSalir As WindowsFormsControlLibrary1.BunifuThinButton
    Friend WithEvents lblCrearUsuario As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
