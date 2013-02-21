Imports System.Data

Public Class Form_Pedido

    Private Sub Form_Pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ActivateMdiChild(FormMenu)
        Me.MaximizeBox = False
        Me.MdiParent = FormMenu
        Call llena_clientes()
        Call llena_folios()
        Call llena_lista()

    End Sub
    Private Sub llena_clientes()
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT nombre,id_cliente,app_pat,app_mat FROM Cliente", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        combo_cliente.DataSource = rscliente.Tables(0)
        combo_cliente.DisplayMember = "nombre"
        combo_cliente.ValueMember = "id_cliente"
        conexion.Close()
    End Sub
    Private Sub llena_folios()
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT folio_pedido FROM Pedido_Cliente", conexion)
        Dim rsfolio As New Data.DataSet
        rsconsulta.Fill(rsfolio)
        combo_folio.DataSource = rsfolio.Tables(0)
        combo_folio.DisplayMember = "folio_pedido"
        combo_folio.ValueMember = "folio_pedido"
        conexion.Close()
    End Sub

    Private Sub cmd_folio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_folio.Click
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor", conexion)
        Dim rsproducto As New Data.DataSet
        rsconsulta.Fill(rsproducto)
        Tabla_Pedido.DataSource = rsproducto.Tables(0)
        conexion.Close()
    End Sub
    Private Sub combo_folio_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_folio.SelectionChangeCommitted
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor WHERE Pedido_Cliente.folio_pedido = '" + combo_folio.SelectedValue + "'", conexion)
        Dim rsfolio As New Data.DataSet
        rsconsulta.Fill(rsfolio)
        Tabla_Pedido.DataSource = rsfolio.Tables(0)
        Dim rsproxped As New SqlClient.SqlDataAdapter("SELECT Producto.nombre_producto AS Producto, Pedido_Producto.cnt_producto as Cantidad FROM Producto,Pedido_Producto WHERE Pedido_Producto.folio_pedido = '" + (Tabla_Pedido.Item(0, Tabla_Pedido.CurrentRow.Index).Value) + "' AND Pedido_Producto.id_producto = Producto.id_producto", conexion)
        Dim rsproductos As New Data.DataSet
        rsproxped.Fill(rsproductos)
        Tabla_Producto.DataSource = rsproductos.Tables(0)
        Dim rsingxped As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente AS Ingrediente, Pedido_Ingrediente.cnt_ingrediente AS Cantidad FROM Ingrediente, Pedido_Ingrediente WHERE Pedido_Ingrediente.folio_pedido = '" + (Tabla_Pedido.Item(0, Tabla_Pedido.CurrentRow.Index).Value) + "' AND Pedido_Ingrediente.id_ingrediente = Ingrediente.Id_ingrediente", conexion)
        Dim rsingredientes As New Data.DataSet
        rsingxped.Fill(rsingredientes)
        Tabla_Ingrediente.DataSource = rsingredientes.Tables(0)
        conexion.Close()
    End Sub

    Private Sub combo_cliente_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_cliente.SelectionChangeCommitted
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor WHERE Cliente.id_cliente = '" + combo_cliente.SelectedValue + "'", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Tabla_Pedido.DataSource = rscliente.Tables(0)
        Try
            Dim rsproxped As New SqlClient.SqlDataAdapter("SELECT Producto.nombre_producto AS Producto, Pedido_Producto.cnt_producto as Cantidad FROM Producto,Pedido_Producto WHERE Pedido_Producto.folio_pedido = '" + (Tabla_Pedido.Item(0, Tabla_Pedido.CurrentRow.Index).Value) + "' AND Pedido_Producto.id_producto = Producto.id_producto", conexion)
            Dim rsproductos As New Data.DataSet
            rsproxped.Fill(rsproductos)
            Tabla_Producto.DataSource = rsproductos.Tables(0)
            Dim rsingxped As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente AS Ingrediente, Pedido_Ingrediente.cnt_ingrediente AS Cantidad FROM Ingrediente, Pedido_Ingrediente WHERE Pedido_Ingrediente.folio_pedido = '" + (Tabla_Pedido.Item(0, Tabla_Pedido.CurrentRow.Index).Value) + "' AND Pedido_Ingrediente.id_ingrediente = Ingrediente.Id_ingrediente", conexion)
            Dim rsingredientes As New Data.DataSet
            rsingxped.Fill(rsingredientes)
            Tabla_Ingrediente.DataSource = rsingredientes.Tables(0)
        Catch
            MsgBox("El cliente seleccionado no ha hecho pedidos")
        End Try
        conexion.Close()
    End Sub

    Private Sub calendario_fecha_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calendario_fecha.DateSelected
        'MsgBox(calendario_fecha.)
    End Sub

    Private Sub cmd_mayor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_mayor.Click
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor WHERE Pedido_Cliente.monto_pedido >= '" + txt_monto.Text + "'", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Tabla_Pedido.DataSource = rscliente.Tables(0)
        conexion.Close()
    End Sub

    Private Sub cmd_menor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_menor.Click
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor WHERE Pedido_Cliente.monto_pedido <= '" + txt_monto.Text + "'", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Tabla_Pedido.DataSource = rscliente.Tables(0)
        conexion.Close()
    End Sub

    Private Sub Tabla_Pedido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabla_Pedido.Click
        conexion.Open()
        'Dim rsingxpro As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente, Ingrediente.precio_ingrediente, Producto_Ingrediente.id_producto FROM Ingrediente INNER JOIN Producto_Ingrediente ON Ingrediente.id_ingrediente = Producto_Ingrediente.id_ingrediente INNER JOIN Producto ON Producto_Ingrediente.id_producto = Producto.id_producto WHERE (Producto.precio_producto = '" + txt_precio.Text + "')", conexion)
        Try
            Dim rsproxped As New SqlClient.SqlDataAdapter("SELECT Producto.nombre_producto AS Producto, Pedido_Producto.cnt_producto as Cantidad FROM Producto,Pedido_Producto WHERE Pedido_Producto.folio_pedido = '" + (Tabla_Pedido.Item(0, Tabla_Pedido.CurrentRow.Index).Value) + "' AND Pedido_Producto.id_producto = Producto.id_producto", conexion)
            Dim rsproductos As New Data.DataSet
            rsproxped.Fill(rsproductos)
            Tabla_Producto.DataSource = rsproductos.Tables(0)
            Dim rsingxped As New SqlClient.SqlDataAdapter("SELECT Ingrediente.nombre_ingrediente AS Ingrediente, Pedido_Ingrediente.cnt_ingrediente AS Cantidad FROM Ingrediente, Pedido_Ingrediente WHERE Pedido_Ingrediente.folio_pedido = '" + (Tabla_Pedido.Item(0, Tabla_Pedido.CurrentRow.Index).Value) + "' AND Pedido_Ingrediente.id_ingrediente = Ingrediente.Id_ingrediente", conexion)
            Dim rsingredientes As New Data.DataSet
            rsingxped.Fill(rsingredientes)
            Tabla_Ingrediente.DataSource = rsingredientes.Tables(0)
        Catch
            MsgBox("No es una selección valida")
        End Try
        conexion.Close()
    End Sub

    Private Sub combo_folio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_folio.SelectedIndexChanged

    End Sub

    Private Sub combo_folio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_folio.TextChanged
        
    End Sub

    Private Sub calendario_fecha_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calendario_fecha.DateChanged
        'MsgBox(calendario_fecha.SelectionRange.Start)
        'TextBox1.Text = calendario_fecha.SelectionRange.Start
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor WHERE Pedido_Cliente.fecha_pedido = '" + calendario_fecha.SelectionRange.Start + "'", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Tabla_Pedido.DataSource = rscliente.Tables(0)
        conexion.Close()
    End Sub

    Private Sub txt_folio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_folio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

      
    End Sub

    Private Sub txt_folio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_folio.TextChanged
        If txt_folio.Text = "" Then
            Call llena_lista()
        Else
            conexion.Open()
            Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor WHERE Pedido_Cliente.folio_pedido = '" + txt_folio.Text + "'", conexion)
            Dim rsfolio As New Data.DataSet
            rsconsulta.Fill(rsfolio)
            Tabla_Pedido.DataSource = rsfolio.Tables(0)
            conexion.Close()
        End If
    End Sub

    Private Sub combo_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_cliente.SelectedIndexChanged

    End Sub
    Private Sub llena_lista()
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor", conexion)
        Dim rsfolio As New Data.DataSet
        rsconsulta.Fill(rsfolio)
        Tabla_Pedido.DataSource = rsfolio.Tables(0)
        conexion.Close()
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
            Call llena_lista()
        Else
            conexion.Open()
            Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT Pedido_Cliente.folio_pedido AS Folio, Cliente.nombre AS Cliente, Cliente.app_pat AS [Apellido Paterno], Cliente.app_mat AS [Apellido Materno], Repartidor.nombre_repartidor AS Repartidor, Repartidor.appat_repartidor AS [Apellido Paterno], Repartidor.apmat_repartidor AS [Apellido Materno], Pedido_Cliente.fecha_pedido AS Fecha, Pedido_Cliente.hora_pedido AS Hora, Pedido_Cliente.monto_pedido AS Monto FROM Cliente INNER JOIN Pedido_Cliente ON Cliente.id_cliente = Pedido_Cliente.id_cliente INNER JOIN Repartidor ON Pedido_Cliente.id_repartidor = Repartidor.id_repartidor WHERE Cliente.nombre = '" + txt_nombre.Text + "'", conexion)
            Dim rsfolio As New Data.DataSet
            rsconsulta.Fill(rsfolio)
            Tabla_Pedido.DataSource = rsfolio.Tables(0)
            conexion.Close()
        End If
    End Sub

    Private Sub txt_monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_monto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txt_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_monto.TextChanged

    End Sub

End Class