﻿Imports MySql.Data.MySqlClient

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

                ' Abrir el Form2 y pasar el nombre
                Dim form2 As New Form2()
                form2.lblBienvenido.Text = If(ComboBox1.SelectedItem.ToString() = "English", $"Welcome, {nombre}", $"Bienvenido, {nombre}")
                form2.StartPosition = FormStartPosition.CenterScreen ' Asegurar que aparezca centrado
                form2.ShowDialog() ' Usar ShowDialog para que sea modal

                ' Ocultar el Form1 
                Me.Hide()
            Else
                ' Si no se encontró ningún usuario, mostrar mensaje de error
                Dim mensajeError As String
                If ComboBox1.SelectedItem.ToString() = "English" Then
                    mensajeError = "User does not exist or password is incorrect."
                Else
                    mensajeError = "Usuario inexistente o contraseña incorrecta"
                End If

                Dim tituloError As String = If(ComboBox1.SelectedItem.ToString() = "English", "Login Error", "Error de inicio de sesión")
                MessageBox.Show(mensajeError, tituloError, MessageBoxButtons.OK, MessageBoxIcon.Error)

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

