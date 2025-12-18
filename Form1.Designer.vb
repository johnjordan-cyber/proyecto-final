<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        lblusuario = New Label()
        lblcontraseña = New Label()
        txtusuario = New TextBox()
        txtcontraseñaa = New TextBox()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.Cursor = Cursors.IBeam
        btnLogin.ForeColor = SystemColors.ActiveCaptionText
        btnLogin.Location = New Point(298, 241)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(166, 34)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Iniciar Sesión"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblusuario
        ' 
        lblusuario.AutoSize = True
        lblusuario.ForeColor = SystemColors.ControlText
        lblusuario.Location = New Point(288, 66)
        lblusuario.Name = "lblusuario"
        lblusuario.Size = New Size(75, 20)
        lblusuario.TabIndex = 1
        lblusuario.Text = "USUARIO "
        ' 
        ' lblcontraseña
        ' 
        lblcontraseña.AutoSize = True
        lblcontraseña.Location = New Point(288, 156)
        lblcontraseña.Name = "lblcontraseña"
        lblcontraseña.Size = New Size(104, 20)
        lblcontraseña.TabIndex = 2
        lblcontraseña.Text = "CONTRASEÑA"
        ' 
        ' txtusuario
        ' 
        txtusuario.BackColor = SystemColors.Menu
        txtusuario.BorderStyle = BorderStyle.FixedSingle
        txtusuario.Location = New Point(288, 89)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(198, 27)
        txtusuario.TabIndex = 3
        ' 
        ' txtcontraseñaa
        ' 
        txtcontraseñaa.BorderStyle = BorderStyle.FixedSingle
        txtcontraseñaa.Location = New Point(288, 179)
        txtcontraseñaa.Name = "txtcontraseñaa"
        txtcontraseñaa.Size = New Size(198, 27)
        txtcontraseñaa.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtcontraseñaa)
        Controls.Add(txtusuario)
        Controls.Add(lblcontraseña)
        Controls.Add(lblusuario)
        Controls.Add(btnLogin)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblcontraseña As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents txtcontraseñaa As TextBox

End Class
