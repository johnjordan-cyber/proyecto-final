Imports Windows.Win32.System
Imports System.Data.SqlClient
Public Class Form2
    Private Const ConnectionString As String = "Data Source=JJJO\SQLEXPRESS;Initial Catalog=stim;Integrated Security=True;TrustServerCertificate=True"
    Private ID_Seleccionado As Integer = -1
    Private txtusuario As Object

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Try
            Using conexion As New SqlConnection(ConnectionString)
                conexion.Open()
                Dim da As New SqlDataAdapter("SELECT id_usuario, nombre_completo, email, estado_cuenta FROM usuarios", conexion)
                Dim dt As New DataTable()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If DataGridView1.Rows(e.RowIndex).Cells("id_usuario").Value Is Nothing Then Exit Sub

        ID_Seleccionado = Convert.ToInt32(
        DataGridView1.Rows(e.RowIndex).Cells("id_usuario").Value
    )

        txtnombres.Text = DataGridView1.Rows(e.RowIndex).Cells("nombre_completo").Value.ToString()
        txtcorreo.Text = DataGridView1.Rows(e.RowIndex).Cells("email").Value.ToString()



    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtnombres.Text.Trim() = "" OrElse
       txtcorreo.Text.Trim() = "" OrElse
       txtcontraseña.Text.Trim() = "" Then

            MessageBox.Show("Complete todos los campos")
            Exit Sub
        End If

        Try
            Using conexion As New SqlConnection(ConnectionString)
                conexion.Open()

                Dim sql As String =
                "INSERT INTO usuarios (nombre_completo, email, contrasena) VALUES (@nombre, @email, @contrasena)"

                Using cmd As New SqlCommand(sql, conexion)
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombres.Text.Trim()
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtcorreo.Text.Trim()
                    cmd.Parameters.Add("@contrasena", SqlDbType.VarChar).Value =
                    GenerarHash(txtcontraseña.Text.Trim())

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Usuario agregado correctamente")
            CargarUsuarios()
            Limpiar()

        Catch ex As SqlException When ex.Number = 2627
            MessageBox.Show("Ese correo ya existe")
        Catch ex As Exception
            MessageBox.Show("Error al agregar: " & ex.Message)
        End Try

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If ID_Seleccionado = -1 Then
            MessageBox.Show("Seleccione un usuario")
            Exit Sub
        End If

        Try
            Using conexion As New SqlConnection(ConnectionString)
                conexion.Open()

                Dim sql As String

                If txtcontraseña.Text.Trim() = "" Then
                    ' No tocar contraseña
                    sql = "UPDATE usuarios 
                       SET nombre_completo=@nombre, email=@email 
                       WHERE id_usuario=@id"
                Else
                    ' Actualizar contraseña
                    sql = "UPDATE usuarios 
                       SET nombre_completo=@nombre, email=@email, contrasena=@contrasena 
                       WHERE id_usuario=@id"
                End If

                Using cmd As New SqlCommand(sql, conexion)
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombres.Text.Trim()
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtcorreo.Text.Trim()
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID_Seleccionado

                    If txtcontraseña.Text.Trim() <> "" Then
                        cmd.Parameters.Add("@contrasena", SqlDbType.VarChar).Value =
                        GenerarHash(txtcontraseña.Text.Trim())
                    End If

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Usuario actualizado correctamente")
            CargarUsuarios()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3btnEliminar_Click(sender As Object, e As EventArgs) Handles Button3btnEliminar.Click
        If ID_Seleccionado = -1 Then
            MessageBox.Show("Seleccione un usuario")
            Exit Sub
        End If

        If MessageBox.Show("¿Eliminar usuario y sus datos?", "Confirmar",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub

        Try
            Using conexion As New SqlConnection(ConnectionString)
                conexion.Open()

                Using trans As SqlTransaction = conexion.BeginTransaction()
                    Try
                        ' 1. Eliminar reviews del usuario
                        Dim sqlReviews As String = "DELETE FROM reviews WHERE id_usuario=@id"
                        Using cmd0 As New SqlCommand(sqlReviews, conexion, trans)
                            cmd0.Parameters.Add("@id", SqlDbType.Int).Value = ID_Seleccionado
                            cmd0.ExecuteNonQuery()
                        End Using

                        ' 2. Eliminar dependencias de biblioteca
                        Dim sqlBiblioteca As String = "DELETE FROM biblioteca WHERE id_usuario=@id"
                        Using cmd1 As New SqlCommand(sqlBiblioteca, conexion, trans)
                            cmd1.Parameters.Add("@id", SqlDbType.Int).Value = ID_Seleccionado
                            cmd1.ExecuteNonQuery()
                        End Using

                        ' 3. Eliminar usuario
                        Dim sqlUsuario As String = "DELETE FROM usuarios WHERE id_usuario=@id"
                        Using cmd2 As New SqlCommand(sqlUsuario, conexion, trans)
                            cmd2.Parameters.Add("@id", SqlDbType.Int).Value = ID_Seleccionado
                            cmd2.ExecuteNonQuery()
                        End Using

                        trans.Commit()
                    Catch
                        trans.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show("Usuario eliminado correctamente")
            CargarUsuarios()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try


    End Sub



    '================ LIMPIAR =================
    Private Sub Limpiar()
        txtnombres.Clear()
        txtcorreo.Clear()
        txtcontraseña.Clear()
        ID_Seleccionado = -1
    End Sub

    '================ HASH SIMPLE =================
    Private Function GenerarHash(texto As String) As String
        Using sha As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
            Dim bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(texto))
            Return Convert.ToBase64String(bytes)
        End Using
    End Function


End Class