Imports System.Data

Module Modulo_Gral
    'declaración de variables globales
    Public conexion As New SqlClient.SqlConnection("Data Source=LVCIOS-PC\SQLEXPRESS;Initial Catalog=EantGo;Integrated Security=True")
    Public FormMenu As New Form_Menu
    Public FormAcceso As New Form_Acceso
    Public FormPedido As New Form_Pedido
    Public FormCliente As New Form_Cliente
    Public FormProducto As New Form_Producto
    Public FormFondo As New Form_Fondo
    Public FormAgregarCliente As New Form_AgregaCliente
End Module
