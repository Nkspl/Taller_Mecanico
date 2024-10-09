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
        Panel1 = New Panel()
        Panel2 = New Panel()
        lblBienvenido = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1116, 729)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        Panel2.Controls.Add(lblBienvenido)
        Panel2.Location = New Point(3, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1113, 39)
        Panel2.TabIndex = 0
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenido.ForeColor = SystemColors.AppWorkspace
        lblBienvenido.Location = New Point(83, 9)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(114, 23)
        lblBienvenido.TabIndex = 0
        lblBienvenido.Text = " Bienvenido, "
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1111, 727)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblBienvenido As Label
End Class
