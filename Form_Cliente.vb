Imports System.Data

Public Class Form_Cliente
    Private Sub Form_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llena_clientes()
        Me.MdiParent = FormMenu
    End Sub

    Private Sub Cmd_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT id_cliente AS Cliente,nombre AS Nombre, app_pat as [Apellido Paterno], app_mat AS [Apellido Materno], edad AS Edad, sexo AS Sexo, n_pedidos as [Número de Pedidos]FROM Cliente WHERE app_pat = '" + txt_app.Text + "'", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Tabla_Clientes.DataSource = rscliente.Tables(0)
        conexion.Close()
    End Sub

    Private Sub llena_clientes()
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT id_cliente AS Cliente,nombre AS Nombre, app_pat as [Apellido Paterno], app_mat AS [Apellido Materno], edad AS Edad, sexo AS Sexo, n_pedidos as [Número de Pedidos]FROM Cliente", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Tabla_Clientes.DataSource = rscliente.Tables(0)
        conexion.Close()
    End Sub

    Private Sub txt_app_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_app.KeyPress
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

    Private Sub txt_app_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_app.TextChanged
        If txt_app.Text = "" Then
            Call llena_clientes()
        Else
            conexion.Open()
            Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT id_cliente AS Cliente,nombre AS Nombre, app_pat as [Apellido Paterno], app_mat AS [Apellido Materno], edad AS Edad, sexo AS Sexo, n_pedidos as [Número de Pedidos]FROM Cliente WHERE app_pat = '" + txt_app.Text + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Tabla_Clientes.DataSource = rscliente.Tables(0)
            conexion.Close()
        End If
    End Sub
End Class