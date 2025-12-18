<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button3btnEliminar = New Button()
        btnEditar = New Button()
        btnAgregar = New Button()
        DataGridView1 = New DataGridView()
        txtcorreo = New TextBox()
        txtcontraseña = New TextBox()
        txtnombres = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 18
        Label3.Text = "Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 17
        Label2.Text = "Correo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 16
        Label1.Text = "Nombre"
        ' 
        ' Button3btnEliminar
        ' 
        Button3btnEliminar.Location = New Point(26, 263)
        Button3btnEliminar.Name = "Button3btnEliminar"
        Button3btnEliminar.Size = New Size(94, 29)
        Button3btnEliminar.TabIndex = 15
        Button3btnEliminar.Text = "Eliminar"
        Button3btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(26, 228)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 14
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(26, 193)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 29)
        btnAgregar.TabIndex = 13
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(233, 33)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(613, 234)
        DataGridView1.TabIndex = 12
        ' 
        ' txtcorreo
        ' 
        txtcorreo.Location = New Point(26, 86)
        txtcorreo.Multiline = True
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(167, 27)
        txtcorreo.TabIndex = 9
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.Location = New Point(26, 147)
        txtcontraseña.Multiline = True
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.Size = New Size(167, 27)
        txtcontraseña.TabIndex = 10
        ' 
        ' txtnombres
        ' 
        txtnombres.Location = New Point(26, 33)
        txtnombres.Multiline = True
        txtnombres.Name = "txtnombres"
        txtnombres.Size = New Size(167, 27)
        txtnombres.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(858, 321)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnAgregar)
        Controls.Add(DataGridView1)
        Controls.Add(txtcorreo)
        Controls.Add(txtcontraseña)
        Controls.Add(txtnombres)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtcontraña As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents txtcontraseña As TextBox
End Class
