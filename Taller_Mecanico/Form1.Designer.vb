﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtContrasena = New TextBox()
        txtNombreUsuario = New TextBox()
        ComboBox1 = New ComboBox()
        btnIniciarSesion = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-1, -2)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1194, 585)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtContrasena)
        Panel2.Controls.Add(txtNombreUsuario)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(btnIniciarSesion)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(267, 10)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(719, 446)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.mx_icon
        PictureBox1.Location = New Point(149, 154)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 118)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.AppWorkspace
        Label6.Location = New Point(149, 421)
        Label6.Name = "Label6"
        Label6.Size = New Size(471, 12)
        Label6.TabIndex = 19
        Label6.Text = "© Producto no comercial desarollado por Nikens Pierre y Joao Ureta 2024. Reservados todos los derechos."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.CornflowerBlue
        Label5.Location = New Point(137, 392)
        Label5.Name = "Label5"
        Label5.Size = New Size(508, 30)
        Label5.TabIndex = 18
        Label5.Text = "_______________________________________________________"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.AppWorkspace
        Label4.Location = New Point(417, 346)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 15)
        Label4.TabIndex = 17
        Label4.Text = "Seleccionar idioma:"
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(417, 235)
        txtContrasena.Margin = New Padding(3, 2, 3, 2)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(281, 23)
        txtContrasena.TabIndex = 16
        ' 
        ' txtNombreUsuario
        ' 
        txtNombreUsuario.Location = New Point(417, 168)
        txtNombreUsuario.Margin = New Padding(3, 2, 3, 2)
        txtNombreUsuario.Name = "txtNombreUsuario"
        txtNombreUsuario.Size = New Size(281, 23)
        txtNombreUsuario.TabIndex = 15
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(548, 340)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 23)
        ComboBox1.TabIndex = 14
        ' 
        ' btnIniciarSesion
        ' 
        btnIniciarSesion.BackColor = Color.FromArgb(CByte(3), CByte(77), CByte(136))
        btnIniciarSesion.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIniciarSesion.ForeColor = Color.White
        btnIniciarSesion.Location = New Point(590, 290)
        btnIniciarSesion.Margin = New Padding(3, 2, 3, 2)
        btnIniciarSesion.Name = "btnIniciarSesion"
        btnIniciarSesion.Size = New Size(108, 22)
        btnIniciarSesion.TabIndex = 13
        btnIniciarSesion.Text = "Iniciar sesión"
        btnIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.AppWorkspace
        Label3.Location = New Point(417, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 12
        Label3.Text = "Contraseña:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.AppWorkspace
        Label2.Location = New Point(417, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 11
        Label2.Text = "Correo:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(137, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 45)
        Label1.TabIndex = 10
        Label1.Text = "Bienvenido a Ultra Mecanica"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1192, 562)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
