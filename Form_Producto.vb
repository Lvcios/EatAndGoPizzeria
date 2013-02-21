Imports System.Data

Public Class Form_Producto

    Private Sub cmd_nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmd_precio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        If txt_nombre.Text = "" Then
            Call llena_listas()
        Else
            conexion.Open()
            Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM Producto WHERE nombre_producto = '" + txt_nombre.Text + "'", conexion)
            Dim rsproducto As New Data.DataSet
            rsconsulta.Fill(rsproducto)
            Tabla_producto.DataSource = rsproducto.Tables(0)
            'Dim rsingxpro As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente, Ingrediente.precio_ingrediente FROM  Ingrediente WHERE Ingrediente.id_ingrediente = Producto_Ingrediente.id_ingrediente AND Producto_Ingrediente.id_producto = Producto.id_producto AND Producto.id_producto = '" + txt_nombre.Text + "'", conexion)
            Dim rsingxpro As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente, Ingrediente.precio_ingrediente, Producto_Ingrediente.id_producto FROM Ingrediente INNER JOIN Producto_Ingrediente ON Ingrediente.id_ingrediente = Producto_Ingrediente.id_ingrediente INNER JOIN Producto ON Producto_Ingrediente.id_producto = Producto.id_producto WHERE (Producto.nombre_producto = '" + txt_nombre.Text + "')", conexion)
            Dim rsingredientes As New Data.DataSet
            rsingxpro.Fill(rsingredientes)
            Tabla_Ingrediente.DataSource = rsingredientes.Tables(0)
            conexion.Close()
        End If
    End Sub

    Private Sub txt_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    

    Private Sub txt_precio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_precio.TextChanged
        If txt_precio.Text = "" Then
            Call llena_listas()
        Else
            conexion.Open()
            Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM Producto WHERE precio_producto = '" + txt_precio.Text + "'", conexion)
            Dim rsproducto As New Data.DataSet
            rsconsulta.Fill(rsproducto)
            Tabla_producto.DataSource = rsproducto.Tables(0)
            conexion.Close()
        End If
    End Sub

    Private Sub Tabla_producto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabla_producto.CellContentClick
        
    End Sub

    Private Sub combo_nombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub combo_nombre_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM Producto WHERE nombre_producto = '" + txt_nombre.Text + "'", conexion)
        Dim rsproducto As New Data.DataSet
        rsconsulta.Fill(rsproducto)
        Tabla_producto.DataSource = rsproducto.Tables(0)
        'Dim rsingxpro As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente, Ingrediente.precio_ingrediente FROM  Ingrediente WHERE Ingrediente.id_ingrediente = Producto_Ingrediente.id_ingrediente AND Producto_Ingrediente.id_producto = Producto.id_producto AND Producto.id_producto = '" + txt_nombre.Text + "'", conexion)
        Dim rsingxpro As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente, Ingrediente.precio_ingrediente, Producto_Ingrediente.id_producto FROM Ingrediente INNER JOIN Producto_Ingrediente ON Ingrediente.id_ingrediente = Producto_Ingrediente.id_ingrediente INNER JOIN Producto ON Producto_Ingrediente.id_producto = Producto.id_producto WHERE (Producto.nombre_producto = '" + txt_nombre.Text + "')", conexion)
        Dim rsingredientes As New Data.DataSet
        rsingxpro.Fill(rsingredientes)
        Tabla_Ingrediente.DataSource = rsingredientes.Tables(0)
        conexion.Close()
    End Sub

    Private Sub Form_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FormMenu
        Call llena_listas()
    End Sub
    Public Sub llena_listas()
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM Producto", conexion)
        Dim rsproducto As New Data.DataSet
        rsconsulta.Fill(rsproducto)
        Tabla_producto.DataSource = rsproducto.Tables(0)
        'Dim rsingxpro As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente, Ingrediente.precio_ingrediente FROM  Ingrediente WHERE Ingrediente.id_ingrediente = Producto_Ingrediente.id_ingrediente AND Producto_Ingrediente.id_producto = Producto.id_producto AND Producto.id_producto = '" + txt_nombre.Text + "'", conexion)
        conexion.Close()
    End Sub

    Private Sub Tabla_producto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabla_producto.Click
        conexion.Open()
        Try
            Dim rsingxpro As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente, Ingrediente.precio_ingrediente, Producto_Ingrediente.id_producto FROM Ingrediente INNER JOIN Producto_Ingrediente ON Ingrediente.id_ingrediente = Producto_Ingrediente.id_ingrediente INNER JOIN Producto ON Producto_Ingrediente.id_producto = Producto.id_producto WHERE (Producto.nombre_producto = '" + (Tabla_producto.Item(1, Tabla_producto.CurrentRow.Index).Value) + "')", conexion)
            Dim rsingredientes As New Data.DataSet
            rsingxpro.Fill(rsingredientes)
            Tabla_Ingrediente.DataSource = rsingredientes.Tables(0)
        Catch
            MsgBox("Selección no valida")
        End Try
        conexion.Close()
    End Sub
End Class