<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ListaCliente
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
        Me.Lista_Clientes = New System.Windows.Forms.DataGridView
        Me.Id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Domicilio_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Lista_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lista_Clientes
        '
        Me.Lista_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_cliente, Me.Nombre_Cliente, Me.Domicilio_Cliente})
        Me.Lista_Clientes.Location = New System.Drawing.Point(50, 100)
        Me.Lista_Clientes.Name = "Lista_Clientes"
        Me.Lista_Clientes.Size = New System.Drawing.Size(567, 150)
        Me.Lista_Clientes.TabIndex = 0
        '
        'Id_cliente
        '
        Me.Id_cliente.HeaderText = "Clave de Cliente"
        Me.Id_cliente.Name = "Id_cliente"
        '
        'Nombre_Cliente
        '
        Me.Nombre_Cliente.HeaderText = "Nombre"
        Me.Nombre_Cliente.Name = "Nombre_Cliente"
        '
        'Domicilio_Cliente
        '
        Me.Domicilio_Cliente.HeaderText = "Domicilio"
        Me.Domicilio_Cliente.Name = "Domicilio_Cliente"
        '
        'Form_ListaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 304)
        Me.Controls.Add(Me.Lista_Clientes)
        Me.Name = "Form_ListaCliente"
        Me.Text = "Lista de clientes"
        CType(Me.Lista_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lista_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Id_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
