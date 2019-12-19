<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.White
        Me.btn_agregar.Location = New System.Drawing.Point(30, 13)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(332, 80)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(30, 196)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(332, 71)
        Me.btn_eliminar.TabIndex = 1
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_listar
        '
        Me.btn_listar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_listar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listar.ForeColor = System.Drawing.Color.White
        Me.btn_listar.Location = New System.Drawing.Point(30, 101)
        Me.btn_listar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(332, 71)
        Me.btn_listar.TabIndex = 2
        Me.btn_listar.Text = "Listar"
        Me.btn_listar.UseVisualStyleBackColor = False
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(392, 281)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_menu"
        Me.Text = "frm_menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_listar As Button
End Class
