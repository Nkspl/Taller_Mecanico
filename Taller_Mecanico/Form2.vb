Public Class Form2

    ' Variable para almacenar el texto del botón
    Dim BTN1_Text As String = "Cerrar sesión"

    ' Evento Load del Formulario para inicializar los controles
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar el ToolTip para Button1
        ToolTip1.SetToolTip(Button1, "Haz clic para cerrar sesión")
    End Sub

    ' Manejador de eventos para cuando el ratón entra en Button1
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ' Mostrar el ToolTip
        ToolTip1.Show("Cerrar sesión", Button1, 0, -20, 2000) ' Muestra por 2 segundos
    End Sub

    ' Manejador de eventos para cuando el ratón sale de Button1
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        ' Ocultar el ToolTip
        ToolTip1.Hide(Button1)
    End Sub

    ' Manejador de eventos para el clic en Button1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Código para cerrar sesión

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
