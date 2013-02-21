<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Pedido))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.combo_folio = New System.Windows.Forms.ComboBox
        Me.combo_cliente = New System.Windows.Forms.ComboBox
        Me.txt_monto = New System.Windows.Forms.TextBox
        Me.Tabla_Pedido = New System.Windows.Forms.DataGridView
        Me.cmd_folio = New System.Windows.Forms.Button
        Me.cmd_mayor = New System.Windows.Forms.Button
        Me.cmd_menor = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Tabla_Producto = New System.Windows.Forms.DataGridView
        Me.Tabla_Ingrediente = New System.Windows.Forms.DataGridView
        Me.txt_folio = New System.Windows.Forms.TextBox
        Me.calendario_fecha = New System.Windows.Forms.MonthCalendar
        Me.txt_nombre = New System.Windows.Forms.TextBox
        CType(Me.Tabla_Pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla_Ingrediente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(584, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formulario de consulta de pedidos, puede visualizar la información de los pedidos" & _
            "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Por folio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Por fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(584, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Por cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(785, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Por monto"
        '
        'combo_folio
        '
        Me.combo_folio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_folio.FormattingEnabled = True
        Me.combo_folio.Location = New System.Drawing.Point(15, 87)
        Me.combo_folio.Name = "combo_folio"
        Me.combo_folio.Size = New System.Drawing.Size(109, 21)
        Me.combo_folio.TabIndex = 5
        '
        'combo_cliente
        '
        Me.combo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_cliente.FormattingEnabled = True
        Me.combo_cliente.Location = New System.Drawing.Point(543, 87)
        Me.combo_cliente.Name = "combo_cliente"
        Me.combo_cliente.Size = New System.Drawing.Size(121, 21)
        Me.combo_cliente.TabIndex = 7
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(765, 87)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(93, 20)
        Me.txt_monto.TabIndex = 8
        '
        'Tabla_Pedido
        '
        Me.Tabla_Pedido.AllowUserToAddRows = False
        Me.Tabla_Pedido.AllowUserToDeleteRows = False
        Me.Tabla_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Pedido.Location = New System.Drawing.Point(12, 260)
        Me.Tabla_Pedido.Name = "Tabla_Pedido"
        Me.Tabla_Pedido.ReadOnly = True
        Me.Tabla_Pedido.Size = New System.Drawing.Size(871, 170)
        Me.Tabla_Pedido.TabIndex = 9
        '
        'cmd_folio
        '
        Me.cmd_folio.Location = New System.Drawing.Point(566, 197)
        Me.cmd_folio.Name = "cmd_folio"
        Me.cmd_folio.Size = New System.Drawing.Size(75, 51)
        Me.cmd_folio.TabIndex = 10
        Me.cmd_folio.Text = "Consulta General"
        Me.cmd_folio.UseVisualStyleBackColor = True
        '
        'cmd_mayor
        '
        Me.cmd_mayor.Location = New System.Drawing.Point(765, 129)
        Me.cmd_mayor.Name = "cmd_mayor"
        Me.cmd_mayor.Size = New System.Drawing.Size(75, 23)
        Me.cmd_mayor.TabIndex = 11
        Me.cmd_mayor.Text = "Mayor que"
        Me.cmd_mayor.UseVisualStyleBackColor = True
        '
        'cmd_menor
        '
        Me.cmd_menor.Location = New System.Drawing.Point(765, 180)
        Me.cmd_menor.Name = "cmd_menor"
        Me.cmd_menor.Size = New System.Drawing.Size(75, 23)
        Me.cmd_menor.TabIndex = 12
        Me.cmd_menor.Text = "Menor que"
        Me.cmd_menor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(150, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Productos del pedido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(528, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ingredientes del pedido"
        '
        'Tabla_Producto
        '
        Me.Tabla_Producto.AllowUserToAddRows = False
        Me.Tabla_Producto.AllowUserToDeleteRows = False
        Me.Tabla_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Producto.Location = New System.Drawing.Point(103, 476)
        Me.Tabla_Producto.Name = "Tabla_Producto"
        Me.Tabla_Producto.ReadOnly = True
        Me.Tabla_Producto.Size = New System.Drawing.Size(240, 150)
        Me.Tabla_Producto.TabIndex = 15
        '
        'Tabla_Ingrediente
        '
        Me.Tabla_Ingrediente.AllowUserToAddRows = False
        Me.Tabla_Ingrediente.AllowUserToDeleteRows = False
        Me.Tabla_Ingrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Ingrediente.Location = New System.Drawing.Point(514, 476)
        Me.Tabla_Ingrediente.Name = "Tabla_Ingrediente"
        Me.Tabla_Ingrediente.ReadOnly = True
        Me.Tabla_Ingrediente.Size = New System.Drawing.Size(255, 150)
        Me.Tabla_Ingrediente.TabIndex = 16
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(15, 129)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(100, 20)
        Me.txt_folio.TabIndex = 17
        '
        'calendario_fecha
        '
        Me.calendario_fecha.Location = New System.Drawing.Point(249, 86)
        Me.calendario_fecha.Name = "calendario_fecha"
        Me.calendario_fecha.TabIndex = 6
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(543, 128)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 20
        '
        'Form_Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.Pizzeria.My.Resources.Resources.pizzahut
        Me.ClientSize = New System.Drawing.Size(939, 658)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Tabla_Ingrediente)
        Me.Controls.Add(Me.Tabla_Producto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmd_menor)
        Me.Controls.Add(Me.cmd_mayor)
        Me.Controls.Add(Me.cmd_folio)
        Me.Controls.Add(Me.Tabla_Pedido)
        Me.Controls.Add(Me.txt_monto)
        Me.Controls.Add(Me.combo_cliente)
        Me.Controls.Add(Me.calendario_fecha)
        Me.Controls.Add(Me.combo_folio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Tabla_Pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla_Ingrediente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combo_folio As System.Windows.Forms.ComboBox
    Friend WithEvents combo_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents Tabla_Pedido As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_folio As System.Windows.Forms.Button
    Friend WithEvents cmd_mayor As System.Windows.Forms.Button
    Friend WithEvents cmd_menor As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tabla_Producto As System.Windows.Forms.DataGridView
    Friend WithEvents Tabla_Ingrediente As System.Windows.Forms.DataGridView
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents calendario_fecha As System.Windows.Forms.MonthCalendar
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
End Class
