Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Const ConnectionString As String = "Data Source=JJJO\SQLEXPRESS;Initial Catalog=stim;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtusuario.Text.Trim()
        Dim contrasena As String = txtcontraseñaa.Text.Trim()

        ' Validar que los campos no estén vacíos
        If usuario = "" Or contrasena = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Conectar con la base de datos
        Using conexion As New SqlConnection(ConnectionString)
            Try
                conexion.Open()

                Dim consulta As String = "SELECT COUNT(*) FROM usuarios WHERE email = @usuario AND contrasena = @contrasena"

                Using comando As New SqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@usuario", usuario)
                    comando.Parameters.AddWithValue("@contrasena", contrasena)

                    Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar())

                    If resultado > 0 Then

                        MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()


                        Dim form2 As New Form2()
                        form2.Show()
                        conexion.Close()
                    Else
                        MessageBox.Show("Inicio de sesión rechazado. Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub
End Class
