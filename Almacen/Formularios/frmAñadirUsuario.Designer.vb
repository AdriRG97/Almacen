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
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Linen
        Me.txtUsuario.BackgroundImage = CType(resources.GetObject("txtUsuario.BackgroundImage"), System.Drawing.Image)
        Me.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUsuario.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtUsuario.Icon = CType(resources.GetObject("txtUsuario.Icon"), System.Drawing.Image)
        Me.txtUsuario.Location = New System.Drawing.Point(64, 66)
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
        Me.txtContraseña.Location = New System.Drawing.Point(64, 177)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(250, 42)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.text = ""
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackColor = System.Drawing.Color.Gray
        Me.btnCrearUsuario.BackgroundImage = CType(resources.GetObject("btnCrearUsuario.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrearUsuario.ButtonText = "Crear usuario"
        Me.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearUsuario.ForeColor = System.Drawing.Color.White
        Me.btnCrearUsuario.ForeColorHoverState = System.Drawing.Color.White
        Me.btnCrearUsuario.Iconimage = Nothing
        Me.btnCrearUsuario.IconVisible = True
        Me.btnCrearUsuario.IconZoom = 90.0R
        Me.btnCrearUsuario.ImageIconOverlay = False
        Me.btnCrearUsuario.Location = New System.Drawing.Point(88, 297)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(184, 36)
        Me.btnCrearUsuario.TabIndex = 2
        '
        'frmAñadirUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(367, 367)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "frmAñadirUsuario"
        Me.Text = "frmAñadirUsuario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsuario As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtContraseña As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents btnCrearUsuario As WindowsFormsControlLibrary1.BunifuThinButton
End Class
