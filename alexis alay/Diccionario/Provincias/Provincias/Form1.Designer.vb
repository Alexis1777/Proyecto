<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbx_agregar = New System.Windows.Forms.GroupBox()
        Me.txt_poblacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_menor = New System.Windows.Forms.Button()
        Me.btn_mayor = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_provincia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbx_provincias = New System.Windows.Forms.GroupBox()
        Me.lv_provincias = New System.Windows.Forms.ListView()
        Me.gbx_agregar.SuspendLayout()
        Me.gbx_provincias.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_agregar
        '
        Me.gbx_agregar.BackColor = System.Drawing.Color.Transparent
        Me.gbx_agregar.Controls.Add(Me.txt_poblacion)
        Me.gbx_agregar.Controls.Add(Me.Label3)
        Me.gbx_agregar.Controls.Add(Me.btn_menor)
        Me.gbx_agregar.Controls.Add(Me.btn_mayor)
        Me.gbx_agregar.Controls.Add(Me.btn_agregar)
        Me.gbx_agregar.Controls.Add(Me.txt_codigo)
        Me.gbx_agregar.Controls.Add(Me.txt_provincia)
        Me.gbx_agregar.Controls.Add(Me.Label1)
        Me.gbx_agregar.Controls.Add(Me.Label2)
        Me.gbx_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_agregar.ForeColor = System.Drawing.Color.White
        Me.gbx_agregar.Location = New System.Drawing.Point(35, 15)
        Me.gbx_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_agregar.Name = "gbx_agregar"
        Me.gbx_agregar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_agregar.Size = New System.Drawing.Size(668, 279)
        Me.gbx_agregar.TabIndex = 3
        Me.gbx_agregar.TabStop = False
        Me.gbx_agregar.Text = "AGREGAR"
        '
        'txt_poblacion
        '
        Me.txt_poblacion.Location = New System.Drawing.Point(8, 234)
        Me.txt_poblacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_poblacion.Name = "txt_poblacion"
        Me.txt_poblacion.Size = New System.Drawing.Size(417, 37)
        Me.txt_poblacion.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(102, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Población:"
        '
        'btn_menor
        '
        Me.btn_menor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_menor.Location = New System.Drawing.Point(485, 142)
        Me.btn_menor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_menor.Name = "btn_menor"
        Me.btn_menor.Size = New System.Drawing.Size(148, 47)
        Me.btn_menor.TabIndex = 6
        Me.btn_menor.Text = "Menor"
        Me.btn_menor.UseVisualStyleBackColor = False
        '
        'btn_mayor
        '
        Me.btn_mayor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_mayor.Location = New System.Drawing.Point(485, 76)
        Me.btn_mayor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_mayor.Name = "btn_mayor"
        Me.btn_mayor.Size = New System.Drawing.Size(148, 47)
        Me.btn_mayor.TabIndex = 5
        Me.btn_mayor.Text = "Mayor"
        Me.btn_mayor.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(485, 197)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(148, 47)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(8, 147)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(417, 37)
        Me.txt_codigo.TabIndex = 3
        '
        'txt_provincia
        '
        Me.txt_provincia.Location = New System.Drawing.Point(8, 62)
        Me.txt_provincia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(417, 37)
        Me.txt_provincia.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Provincia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(112, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod:"
        '
        'gbx_provincias
        '
        Me.gbx_provincias.BackColor = System.Drawing.Color.Transparent
        Me.gbx_provincias.Controls.Add(Me.lv_provincias)
        Me.gbx_provincias.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_provincias.ForeColor = System.Drawing.Color.White
        Me.gbx_provincias.Location = New System.Drawing.Point(711, 15)
        Me.gbx_provincias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_provincias.Name = "gbx_provincias"
        Me.gbx_provincias.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_provincias.Size = New System.Drawing.Size(550, 279)
        Me.gbx_provincias.TabIndex = 4
        Me.gbx_provincias.TabStop = False
        Me.gbx_provincias.Text = "LISTA"
        '
        'lv_provincias
        '
        Me.lv_provincias.FullRowSelect = True
        Me.lv_provincias.GridLines = True
        Me.lv_provincias.HideSelection = False
        Me.lv_provincias.Location = New System.Drawing.Point(30, 38)
        Me.lv_provincias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lv_provincias.Name = "lv_provincias"
        Me.lv_provincias.Size = New System.Drawing.Size(491, 227)
        Me.lv_provincias.TabIndex = 5
        Me.lv_provincias.UseCompatibleStateImageBehavior = False
        Me.lv_provincias.View = System.Windows.Forms.View.List
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1256, 315)
        Me.Controls.Add(Me.gbx_provincias)
        Me.Controls.Add(Me.gbx_agregar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbx_agregar.ResumeLayout(False)
        Me.gbx_agregar.PerformLayout()
        Me.gbx_provincias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_agregar As GroupBox
    Friend WithEvents txt_poblacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_menor As Button
    Friend WithEvents btn_mayor As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_provincia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbx_provincias As GroupBox
    Friend WithEvents lv_provincias As ListView
End Class
