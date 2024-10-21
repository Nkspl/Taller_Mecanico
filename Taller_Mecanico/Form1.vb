Imports MySql.Data.MySqlClient

Public Class Form1
    ' Declarar la conexión sin inicializarla
    Dim conexion As MySqlConnection

    ' Evento Load del Formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar los idiomas al ComboBox1
        ComboBox1.Items.Add("Español")
        ComboBox1.Items.Add("English")

        ' Establecer "Español" como el idioma predeterminado
        ComboBox1.SelectedItem = "Español"

        ' Enmascarar la entrada de la contraseña
        txtContrasena.UseSystemPasswordChar = True
    End Sub

    ' Evento SelectedIndexChanged del ComboBox1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString() = "English" Then
            ' Cambiar los textos al inglés
            Label1.Text = "Welcome to Ultra Mechanics"
            Label2.Text = "Email"
            Label3.Text = "Password"
            btnIniciarSesion.Text = "Login"
            Label4.Text = "Select language"
            Label6.Text = "© Non-commercial product developed by Nikens Pierre and Joao Ureta 2024. All rights reserved."
        Else
            ' Cambiar los textos al español
            Label1.Text = "Bienvenido a Ultra Mechanics"
            Label2.Text = "Correo"
            Label3.Text = "Contraseña"
            btnIniciarSesion.Text = "Iniciar Sesión"
            Label4.Text = "Seleccionar idioma"
            Label6.Text = "© Producto no comercial desarrollado por Nikens Pierre y Joao Ureta 2024. Todos los derechos reservados."
        End If
    End Sub

    ' Evento Click del Botón Iniciar Sesión
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            ' Obtener los valores ingresados por el usuario
            Dim nombreUsuario As String = txtNombreUsuario.Text
            Dim contrasena As String = txtContrasena.Text

            ' Verificar si los campos están vacíos
            If String.IsNullOrWhiteSpace(nombreUsuario) Or String.IsNullOrWhiteSpace(contrasena) Then
                Dim mensajeError As String
                If ComboBox1.SelectedItem.ToString() = "English" Then
                    mensajeError = "Please fill in all fields."
                Else
                    mensajeError = "Por favor complete todos los campos."
                End If

                Dim tituloError As String = If(ComboBox1.SelectedItem.ToString() = "English", "Error", "Error")
                MessageBox.Show(mensajeError, tituloError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del evento
            End If

            ' Inicializar la conexión
            conexion = New MySqlConnection("Server=localhost;Database=taller;User ID='root';Password='';")

            ' Comando SQL para verificar si el usuario existe
            Dim userExistsQuery As String = "SELECT Contraseña FROM usuarios WHERE Correo = @NombreUsuario"
            Dim userExistsCommand As New MySqlCommand(userExistsQuery, conexion)
            userExistsCommand.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)

            ' Abrir la conexión
            conexion.Open()

            ' Ejecutar el comando
            Dim reader As MySqlDataReader = userExistsCommand.ExecuteReader()

            If reader.HasRows Then
                ' El usuario existe
                reader.Read()
                Dim storedPassword As String = reader("Contraseña").ToString()
                reader.Close()

                ' Verificar si la contraseña es correcta
                If storedPassword = contrasena Then
                    ' Contraseña correcta, iniciar sesión
                    ' Obtener el correo del usuario
                    Dim nombre As String = nombreUsuario

                    ' Cerrar la conexión
                    conexion.Close()

                    ' Abrir el Form2 y pasar el nombre
                    Dim form2 As New Form2()
                    form2.lblBienvenido.Text = If(ComboBox1.SelectedItem.ToString() = "English", $"Welcome, {nombre}", $"Bienvenido, {nombre}")
                    form2.StartPosition = FormStartPosition.CenterScreen ' Asegurar que aparezca centrado
                    form2.ShowDialog() ' Usar ShowDialog para que sea modal

                    ' Ocultar el Form1 
                    Me.Hide()
                Else
                    ' Contraseña incorrecta
                    Dim mensajeError As String
                    If ComboBox1.SelectedItem.ToString() = "English" Then
                        mensajeError = "Incorrect password."
                    Else
                        mensajeError = "Contraseña incorrecta."
                    End If
                    Dim tituloError As String = If(ComboBox1.SelectedItem.ToString() = "English", "Login Error", "Error de inicio de sesión")
                    MessageBox.Show(mensajeError, tituloError, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' Cerrar la conexión
                    conexion.Close()
                End If
            Else
                ' El usuario no existe
                Dim mensajeError As String
                If ComboBox1.SelectedItem.ToString() = "English" Then
                    mensajeError = "User does not exist."
                Else
                    mensajeError = "Usuario inexistente."
                End If
                Dim tituloError As String = If(ComboBox1.SelectedItem.ToString() = "English", "Login Error", "Error de inicio de sesión")
                MessageBox.Show(mensajeError, tituloError, MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Cerrar la conexión
                reader.Close()
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

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class