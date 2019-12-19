<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Agregar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbx_agregar = New System.Windows.Forms.GroupBox()
        Me.pbx_imagen = New System.Windows.Forms.PictureBox()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_imagen = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_definicion = New System.Windows.Forms.TextBox()
        Me.txt_palabra = New System.Windows.Forms.TextBox()
        Me.gbx_agregar.SuspendLayout()
        CType(Me.pbx_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(103, 34)
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
        Me.Label2.Location = New System.Drawing.Point(90, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Definición:"
        '
        'gbx_agregar
        '
        Me.gbx_agregar.BackColor = System.Drawing.Color.Transparent
        Me.gbx_agregar.Controls.Add(Me.pbx_imagen)
        Me.gbx_agregar.Controls.Add(Me.btn_menu)
        Me.gbx_agregar.Controls.Add(Me.btn_imagen)
        Me.gbx_agregar.Controls.Add(Me.btn_agregar)
        Me.gbx_agregar.Controls.Add(Me.txt_definicion)
        Me.gbx_agregar.Controls.Add(Me.txt_palabra)
        Me.gbx_agregar.Controls.Add(Me.Label1)
        Me.gbx_agregar.Controls.Add(Me.Label2)
        Me.gbx_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_agregar.ForeColor = System.Drawing.Color.White
        Me.gbx_agregar.Location = New System.Drawing.Point(16, 57)
        Me.gbx_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_agregar.Name = "gbx_agregar"
        Me.gbx_agregar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_agregar.Size = New System.Drawing.Size(581, 274)
        Me.gbx_agregar.TabIndex = 2
        Me.gbx_agregar.TabStop = False
        Me.gbx_agregar.Text = "Agregar Palabra"
        '
        'pbx_imagen
        '
        Me.pbx_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx_imagen.Location = New System.Drawing.Point(20, 236)
        Me.pbx_imagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbx_imagen.Name = "pbx_imagen"
        Me.pbx_imagen.Size = New System.Drawing.Size(161, 30)
        Me.pbx_imagen.TabIndex = 7
        Me.pbx_imagen.TabStop = False
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.Magenta
        Me.btn_menu.Location = New System.Drawing.Point(401, 175)
        Me.btn_menu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(148, 47)
        Me.btn_menu.TabIndex = 6
        Me.btn_menu.Text = "Menú"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'btn_imagen
        '
        Me.btn_imagen.BackColor = System.Drawing.Color.Magenta
        Me.btn_imagen.Location = New System.Drawing.Point(401, 34)
        Me.btn_imagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_imagen.Name = "btn_imagen"
        Me.btn_imagen.Size = New System.Drawing.Size(148, 47)
        Me.btn_imagen.TabIndex = 5
        Me.btn_imagen.Text = "Imagen"
        Me.btn_imagen.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Magenta
        Me.btn_agregar.Location = New System.Drawing.Point(401, 105)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(148, 47)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txt_definicion
        '
        Me.txt_definicion.Location = New System.Drawing.Point(8, 185)
        Me.txt_definicion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_definicion.Name = "txt_definicion"
        Me.txt_definicion.Size = New System.Drawing.Size(306, 37)
        Me.txt_definicion.TabIndex = 3
        '
        'txt_palabra
        '
        Me.txt_palabra.Location = New System.Drawing.Point(8, 95)
        Me.txt_palabra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_palabra.Name = "txt_palabra"
        Me.txt_palabra.Size = New System.Drawing.Size(306, 37)
        Me.txt_palabra.TabIndex = 2
        '
        'frm_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 348)
        Me.Controls.Add(Me.gbx_agregar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_Agregar"
        Me.Text = "Diccionario"
        Me.gbx_agregar.ResumeLayout(False)
        Me.gbx_agregar.PerformLayout()
        CType(Me.pbx_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbx_agregar As GroupBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_definicion As TextBox
    Friend WithEvents txt_palabra As TextBox
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_imagen As Button
    Friend WithEvents pbx_imagen As PictureBox
End Class
