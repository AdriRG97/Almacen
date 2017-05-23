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
        Me.btnCrearUsuario = New WindowsFormsControlLibrary1.BunifuThinButton()
        Me.btnSalir = New WindowsFormsControlLibrary1.BunifuThinButton()
        Me.lblCrearUsuario = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.txtContraseña = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
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
        Me.btnCrearUsuario.Location = New System.Drawing.Point(154, 305)
        Me.btnCrearUsuario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(233, 39)
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
        Me.btnSalir.Location = New System.Drawing.Point(154, 368)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(233, 39)
        Me.btnSalir.TabIndex = 3
        '
        'lblCrearUsuario
        '
        Me.lblCrearUsuario.BackColor = System.Drawing.Color.Purple
        Me.lblCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCrearUsuario.Location = New System.Drawing.Point(134, 37)
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
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(53, 143)
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
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(53, 226)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(128, 27)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "Contraseña"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.CustomButton.Image = Nothing
        Me.txtUsuario.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtUsuario.CustomButton.Name = ""
        Me.txtUsuario.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsuario.CustomButton.TabIndex = 1
        Me.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.CustomButton.UseSelectable = True
        Me.txtUsuario.CustomButton.Visible = False
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(233, 143)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.ShortcutsEnabled = True
        Me.txtUsuario.Size = New System.Drawing.Size(250, 23)
        Me.txtUsuario.TabIndex = 7
        Me.txtUsuario.UseSelectable = True
        Me.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtContraseña
        '
        '
        '
        '
        Me.txtContraseña.CustomButton.Image = Nothing
        Me.txtContraseña.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtContraseña.CustomButton.Name = ""
        Me.txtContraseña.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContraseña.CustomButton.TabIndex = 1
        Me.txtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContraseña.CustomButton.UseSelectable = True
        Me.txtContraseña.CustomButton.Visible = False
        Me.txtContraseña.Lines = New String(-1) {}
        Me.txtContraseña.Location = New System.Drawing.Point(233, 226)
        Me.txtContraseña.MaxLength = 32767
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.SelectionLength = 0
        Me.txtContraseña.SelectionStart = 0
        Me.txtContraseña.ShortcutsEnabled = True
        Me.txtContraseña.Size = New System.Drawing.Size(250, 23)
        Me.txtContraseña.TabIndex = 8
        Me.txtContraseña.UseSelectable = True
        Me.txtContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContraseña.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmAñadirUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(561, 427)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.lblCrearUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAñadirUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAñadirUsuario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrearUsuario As WindowsFormsControlLibrary1.BunifuThinButton
    Friend WithEvents btnSalir As WindowsFormsControlLibrary1.BunifuThinButton
    Friend WithEvents lblCrearUsuario As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContraseña As MetroFramework.Controls.MetroTextBox
End Class
