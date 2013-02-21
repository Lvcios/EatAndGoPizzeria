Imports System.Data

Public Class Form_AgregaCliente

    Private Sub Form_AgregaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llena_clientes()
        'combo_sex.DisplayMember = "Masculino"
        'combo_sex.DisplayMember = "Femenino"
        combo_sex.Items.Add("Masculino")
        combo_sex.Items.Add("Femenino")
        Me.MdiParent = FormMenu
    End Sub
    Private Sub llena_clientes()
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT id_cliente AS Cliente,nombre AS Nombre, app_pat as [Apellido Paterno], app_mat AS [Apellido Materno], edad AS Edad, sexo AS Sexo, n_pedidos as [Número de Pedidos]FROM Cliente", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        lista_cliente.DataSource = rscliente.Tables(0)
        conexion.Close()
    End Sub

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If vacio() = True Then
            Try
                conexion.Open()
                Dim rsconsulta As New SqlClient.SqlDataAdapter("INSERT INTO Cliente VALUES('" + txt_clave.Text + "','" + txt_nombre.Text + "','" + txt_paterno.Text + "','" + txt_materno.Text + "','" + txt_edad.Text + "','" + combo_sex.Text + "','" + txt_pedidos.Text + "');", conexion)
                Dim rscliente As New Data.DataSet
                rsconsulta.Fill(rscliente)
                MsgBox("Cliente guardado")
            Catch
                MsgBox("Clave repetida, imposible guardar")
            End Try
            conexion.Close()
            Call llena_clientes()
        End If
    End Sub
    Private Function vacio()
        Dim retorno As Boolean
        retorno = True
        If txt_clave.Text = "" Then
            MsgBox("No ha establecido una clave de cliente")
            retorno = False
        ElseIf txt_nombre.Text = "" Then
            MsgBox("No ha establecido un nombre")
            retorno = False
        ElseIf txt_paterno.Text = "" Then
            MsgBox("No ha establecido un apellido paterno")
            retorno = False
        ElseIf txt_materno.Text = "" Then
            MsgBox("No ha establecido un apellido materno")
            retorno = False
        ElseIf txt_edad.Text = "" Then
            MsgBox("No ha establecido la edad")
            retorno = False
        ElseIf combo_sex.Text = "" Then
            MsgBox("No ha establecido un sexo")
            retorno = False
        End If
        Return retorno
    End Function

    Private Sub cmd_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_modificar.Click
        If vacio() = True Then
            Try
                conexion.Open()
                Dim rsconsulta As New SqlClient.SqlDataAdapter("UPDATE Cliente SET nombre='" + txt_nombre.Text + "',app_pat='" + txt_paterno.Text + "',app_mat='" + txt_materno.Text + "',edad='" + txt_edad.Text + "',sexo='" + combo_sex.Text + "',n_pedidos='" + txt_pedidos.Text + "' WHERE id_cliente = '" + txt_clave.Text + "';", conexion)
                Dim rscliente As New Data.DataSet
                rsconsulta.Fill(rscliente)
                MsgBox("Datos modificados")
            Catch
                MsgBox("Clave no encontrada")
            End Try
            conexion.Close()
            Call llena_clientes()
        End If
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If vacio() = True Then
            'DELETE Cliente WHERE id_cliente = '001';
            Try
                conexion.Open()
                Dim rsconsulta As New SqlClient.SqlDataAdapter("DELETE Cliente WHERE id_cliente = '" + txt_clave.Text + "';", conexion)
                Dim rscliente As New Data.DataSet
                rsconsulta.Fill(rscliente)
                MsgBox("Cliente borrado")
            Catch
                MsgBox("El cliente no se puede borrar porque ya hizo pedidos")
            End Try
            conexion.Close()
            Call llena_clientes()
        End If
    End Sub

    Private Sub lista_cliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lista_cliente.CellContentClick
        'Tabla_producto.Item(1, Tabla_producto.CurrentRow.Index).Value
        
    End Sub

    Private Sub lista_cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lista_cliente.Click
        txt_clave.Text = Trim(lista_cliente.Item(0, lista_cliente.CurrentRow.Index).Value)
        txt_nombre.Text = Trim(lista_cliente.Item(1, lista_cliente.CurrentRow.Index).Value)
        txt_paterno.Text = Trim(lista_cliente.Item(2, lista_cliente.CurrentRow.Index).Value)
        txt_materno.Text = Trim(lista_cliente.Item(3, lista_cliente.CurrentRow.Index).Value)
        txt_edad.Text = Trim(lista_cliente.Item(4, lista_cliente.CurrentRow.Index).Value)
        combo_sex.Text = Trim(lista_cliente.Item(5, lista_cliente.CurrentRow.Index).Value)
        txt_pedidos.Text = Trim(lista_cliente.Item(6, lista_cliente.CurrentRow.Index).Value)
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

    End Sub

    Private Sub txt_paterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_paterno.KeyPress
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

    Private Sub txt_paterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_paterno.TextChanged

    End Sub

    Private Sub txt_materno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_materno.KeyPress
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

    Private Sub txt_materno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_materno.TextChanged

    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        txt_clave.Text = ""
        txt_nombre.Text = ""
        txt_paterno.Text = ""
        txt_materno.Text = ""
        txt_edad.Text = ""
        combo_sex.Text = ""
        txt_pedidos.Text = "0"
        txt_clave.Focus()
    End Sub

    Private Sub combo_sex_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combo_sex.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub combo_sex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_sex.SelectedIndexChanged

    End Sub

    Private Sub txt_clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_clave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_clave.TextChanged

    End Sub

    Private Sub txt_pedidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pedidos.KeyPress
     
    End Sub

    Private Sub txt_pedidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pedidos.TextChanged

    End Sub
End Class