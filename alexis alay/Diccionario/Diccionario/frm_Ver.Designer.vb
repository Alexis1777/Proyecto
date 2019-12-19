<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ver
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
        Me.gbx_ver = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.txt_definicion = New System.Windows.Forms.TextBox()
        Me.txt_palabra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbx_ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_ver
        '
        Me.gbx_ver.BackColor = System.Drawing.Color.Transparent
        Me.gbx_ver.Controls.Add(Me.btn_actualizar)
        Me.gbx_ver.Controls.Add(Me.txt_definicion)
        Me.gbx_ver.Controls.Add(Me.txt_palabra)
        Me.gbx_ver.Controls.Add(Me.Label1)
        Me.gbx_ver.Controls.Add(Me.Label2)
        Me.gbx_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbx_ver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_ver.ForeColor = System.Drawing.Color.White
        Me.gbx_ver.Location = New System.Drawing.Point(13, 13)
        Me.gbx_ver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_ver.Name = "gbx_ver"
        Me.gbx_ver.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_ver.Size = New System.Drawing.Size(683, 376)
        Me.gbx_ver.TabIndex = 3
        Me.gbx_ver.TabStop = False
        Me.gbx_ver.Text = "EDITAR"
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.Black
        Me.btn_actualizar.Location = New System.Drawing.Point(229, 247)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(262, 100)
        Me.btn_actualizar.TabIndex = 4
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'txt_definicion
        '
        Me.txt_definicion.Location = New System.Drawing.Point(158, 176)
        Me.txt_definicion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_definicion.Name = "txt_definicion"
        Me.txt_definicion.Size = New System.Drawing.Size(417, 37)
        Me.txt_definicion.TabIndex = 3
        '
        'txt_palabra
        '
        Me.txt_palabra.Location = New System.Drawing.Point(158, 81)
        Me.txt_palabra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_palabra.Name = "txt_palabra"
        Me.txt_palabra.Size = New System.Drawing.Size(417, 37)
        Me.txt_palabra.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(311, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Palabra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(291, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Definición:"
        '
        'frm_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(709, 402)
        Me.Controls.Add(Me.gbx_ver)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_Ver"
        Me.Text = "frm_Ver"
        Me.gbx_ver.ResumeLayout(False)
        Me.gbx_ver.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_ver As GroupBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents txt_definicion As TextBox
    Friend WithEvents txt_palabra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
