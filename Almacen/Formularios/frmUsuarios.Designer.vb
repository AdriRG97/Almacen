﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.txtUsuario = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txtContraseña = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblError = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAceptar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblErrorAdmin = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsuario.BackgroundImage = CType(resources.GetObject("txtUsuario.BackgroundImage"), System.Drawing.Image)
        Me.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUsuario.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtUsuario.Icon = CType(resources.GetObject("txtUsuario.Icon"), System.Drawing.Image)
        Me.txtUsuario.Location = New System.Drawing.Point(165, 141)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(250, 42)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.text = ""
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContraseña.BackgroundImage = CType(resources.GetObject("txtContraseña.BackgroundImage"), System.Drawing.Image)
        Me.txtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtContraseña.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtContraseña.Icon = CType(resources.GetObject("txtContraseña.Icon"), System.Drawing.Image)
        Me.txtContraseña.Location = New System.Drawing.Point(165, 244)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(250, 42)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.text = ""
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(27, 141)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(118, 42)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Usuario"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(27, 244)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(118, 42)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Contraseña"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Orchid
        Me.BunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(41, 32)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(409, 67)
        Me.BunifuCustomLabel3.TabIndex = 4
        Me.BunifuCustomLabel3.Text = "Iniciar sesión"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(66, 337)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(241, 23)
        Me.lblError.TabIndex = 5
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.BorderRadius = 2
        Me.btnAceptar.ButtonText = "               Aceptar"
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAceptar.Iconimage = CType(resources.GetObject("btnAceptar.Iconimage"), System.Drawing.Image)
        Me.btnAceptar.Iconimage_right = Nothing
        Me.btnAceptar.Iconimage_right_Selected = Nothing
        Me.btnAceptar.Iconimage_Selected = Nothing
        Me.btnAceptar.IconZoom = 90.0R
        Me.btnAceptar.IsTab = False
        Me.btnAceptar.Location = New System.Drawing.Point(66, 377)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAceptar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAceptar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAceptar.selected = False
        Me.btnAceptar.Size = New System.Drawing.Size(241, 48)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Textcolor = System.Drawing.Color.White
        Me.btnAceptar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(361, 299)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(71, 71)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 7
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'lblErrorAdmin
        '
        Me.lblErrorAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorAdmin.Location = New System.Drawing.Point(66, 314)
        Me.lblErrorAdmin.Name = "lblErrorAdmin"
        Me.lblErrorAdmin.Size = New System.Drawing.Size(241, 23)
        Me.lblErrorAdmin.TabIndex = 8
        Me.lblErrorAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorAdmin.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Location = New System.Drawing.Point(361, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 55)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 437)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblErrorAdmin)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsuario As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtContraseña As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblError As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAceptar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblErrorAdmin As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Button1 As Button
End Class
