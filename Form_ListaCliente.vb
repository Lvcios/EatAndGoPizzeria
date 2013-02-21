Imports System.Data
Public Class Form_ListaCliente

    Private Sub Form_ListaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Llena_Lista()

    End Sub

    Private Sub Llena_Lista()
        conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM Cliente", conexion)
        'SqlClient.SqlDataAdapter
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Lista_Clientes.DataSource = rscliente.Tables(0)
        conexion.Close()
    End Sub
End Class