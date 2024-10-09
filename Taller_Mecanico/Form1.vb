Imports MySql.Data.MySqlClient

Public Class Form1
    ' Declarar la conexión sin inicializarla
    Dim conexion As MySqlConnection

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            ' Inicializar la conexión dentro del Try
            conexion = New MySqlConnection("Server=localhost;Database=taller;User ID=root;Password=Hola.,123;SslMode=None;AllowPublicKeyRetrieval=True;")

            ' Obtener los valores ingresados por el usuario
            Dim nombreUsuario As String = txtNombreUsuario.Text
            Dim contrasena As String = txtContrasena.Text

            ' Comando SQL para verificar los datos del usuario
            Dim query As String = "SELECT Correo FROM usuarios WHERE Correo = @NombreUsuario AND Contraseña = @Contrasena"
            Dim comando As New MySqlCommand(query, conexion)

            ' Añadir los parámetros
            comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
            comando.Parameters.AddWithValue("@Contrasena", contrasena)

            ' Abrir la conexión
            conexion.Open()

            ' Ejecutar el comando
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            ' Verificar si el lector tiene filas (es decir, si se encontró un usuario)
            If lector.HasRows Then
                lector.Read() ' Leer los datos
                Dim nombre As String = lector("Correo").ToString()


                ' Cerrar el lector y la conexión
                lector.Close()
                conexion.Close()

                ' Abrir el Form2 y pasar el nombre y apellido
                Dim form2 As New Form2()
                form2.lblBienvenido.Text = $"Bienvenido, {nombre}"
                form2.StartPosition = FormStartPosition.CenterScreen ' Asegura que aparezca centrado
                form2.ShowDialog() ' Usar ShowDialog para que sea modal

                ' Ocultar el Form1 si quieres que desaparezca, de lo contrario, no lo ocultes.
                Me.Hide()
            Else
                ' Si no se encontró ningún usuario, mostrar un mensaje de error
                MessageBox.Show("Usuario inexistente o contraseña incorrecta", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Cerrar el lector y la conexión
                lector.Close()
                conexion.Close()
            End If
        Catch ex As MySqlException
            ' Mostrar mensaje de error si algo falla
            MessageBox.Show("Error en la conexión o consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegurar que la conexión se cierre en caso de error
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
End Class

