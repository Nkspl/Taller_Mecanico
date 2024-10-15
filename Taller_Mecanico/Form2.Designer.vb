<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        Usuarios = New TabPage()
        DataGridView1 = New DataGridView()
        RUT = New DataGridViewTextBoxColumn()
        CORREO = New DataGridViewTextBoxColumn()
        Contraseña = New DataGridViewTextBoxColumn()
        Tipo = New DataGridViewTextBoxColumn()
        btnAgregar = New Button()
        btnEliminar = New Button()
        btnActualizar = New Button()
        Inventario = New TabPage()
        Ventas = New TabPage()
        Siniestros = New TabPage()
        Servicios = New TabPage()
        Panel2 = New Panel()
        btnCerrarSesion = New Button()
        lblBienvenido = New Label()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        Usuarios.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TabControl1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1366, 775)
        Panel1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Usuarios)
        TabControl1.Controls.Add(Inventario)
        TabControl1.Controls.Add(Ventas)
        TabControl1.Controls.Add(Siniestros)
        TabControl1.Controls.Add(Servicios)
        TabControl1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.ItemSize = New Size(150, 42)
        TabControl1.Location = New Point(3, 84)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1360, 688)
        TabControl1.TabIndex = 6
        ' 
        ' Usuarios
        ' 
        Usuarios.Controls.Add(DataGridView1)
        Usuarios.Controls.Add(btnAgregar)
        Usuarios.Controls.Add(btnEliminar)
        Usuarios.Controls.Add(btnActualizar)
        Usuarios.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Usuarios.Location = New Point(4, 46)
        Usuarios.Name = "Usuarios"
        Usuarios.Padding = New Padding(3)
        Usuarios.Size = New Size(1352, 638)
        Usuarios.TabIndex = 0
        Usuarios.Text = "Usuarios         "
        Usuarios.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {RUT, CORREO, Contraseña, Tipo})
        DataGridView1.Location = New Point(0, 15)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1349, 561)
        DataGridView1.TabIndex = 6
        ' 
        ' RUT
        ' 
        RUT.HeaderText = "Rut"
        RUT.MinimumWidth = 6
        RUT.Name = "RUT"
        RUT.Width = 300
        ' 
        ' CORREO
        ' 
        CORREO.HeaderText = "CORREO"
        CORREO.MinimumWidth = 6
        CORREO.Name = "CORREO"
        CORREO.Width = 400
        ' 
        ' Contraseña
        ' 
        Contraseña.HeaderText = "Contraseña"
        Contraseña.MinimumWidth = 6
        Contraseña.Name = "Contraseña"
        Contraseña.Width = 300
        ' 
        ' Tipo
        ' 
        Tipo.HeaderText = "Tipo"
        Tipo.MinimumWidth = 6
        Tipo.Name = "Tipo"
        Tipo.Width = 300
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Font = New Font("Segoe UI", 10.2F)
        btnAgregar.Location = New Point(359, 582)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(110, 29)
        btnAgregar.TabIndex = 2
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Segoe UI", 10.2F)
        btnEliminar.Location = New Point(869, 582)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(110, 29)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Font = New Font("Segoe UI", 10.2F)
        btnActualizar.Location = New Point(614, 582)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(110, 29)
        btnActualizar.TabIndex = 3
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' Inventario
        ' 
        Inventario.Location = New Point(4, 46)
        Inventario.Name = "Inventario"
        Inventario.Padding = New Padding(3)
        Inventario.Size = New Size(1352, 638)
        Inventario.TabIndex = 1
        Inventario.Text = "Inventario        "
        Inventario.UseVisualStyleBackColor = True
        ' 
        ' Ventas
        ' 
        Ventas.Location = New Point(4, 46)
        Ventas.Name = "Ventas"
        Ventas.Padding = New Padding(3)
        Ventas.Size = New Size(1352, 638)
        Ventas.TabIndex = 2
        Ventas.Text = "Ventas     "
        Ventas.UseVisualStyleBackColor = True
        ' 
        ' Siniestros
        ' 
        Siniestros.Location = New Point(4, 46)
        Siniestros.Name = "Siniestros"
        Siniestros.Padding = New Padding(3)
        Siniestros.Size = New Size(1352, 638)
        Siniestros.TabIndex = 3
        Siniestros.Text = "Siniestros         "
        Siniestros.UseVisualStyleBackColor = True
        ' 
        ' Servicios
        ' 
        Servicios.Location = New Point(4, 46)
        Servicios.Name = "Servicios"
        Servicios.Padding = New Padding(3)
        Servicios.Size = New Size(1352, 638)
        Servicios.TabIndex = 4
        Servicios.Text = "Servicios         "
        Servicios.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        Panel2.Controls.Add(btnCerrarSesion)
        Panel2.Controls.Add(lblBienvenido)
        Panel2.Location = New Point(-2, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1368, 48)
        Panel2.TabIndex = 0
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.BackgroundImage = My.Resources.Resources.cerrar_sesion
        btnCerrarSesion.BackgroundImageLayout = ImageLayout.Center
        btnCerrarSesion.Location = New Point(1313, 3)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(30, 33)
        btnCerrarSesion.TabIndex = 1
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenido.ForeColor = SystemColors.AppWorkspace
        lblBienvenido.Location = New Point(54, 9)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(114, 23)
        lblBienvenido.TabIndex = 0
        lblBienvenido.Text = " Bienvenido, "
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1362, 773)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        Usuarios.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblBienvenido As Label

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function

    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Usuarios As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Inventario As TabPage
    Friend WithEvents Ventas As TabPage
    Friend WithEvents RUT As DataGridViewTextBoxColumn
    Friend WithEvents CORREO As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Siniestros As TabPage
    Friend WithEvents Servicios As TabPage
End Class
