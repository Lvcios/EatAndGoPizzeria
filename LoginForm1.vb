Imports System.Data.SqlClient
Imports System.Data

Public Class Form_Acceso

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        'Txt_Contra.Text = Combo_Usuario.SelectedValue

    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim conexion As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\PizzasEantGo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        conexion.Open()
        'Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT nick_usuario, contra_usuario FROM Usuario WHEERE id_usuario " + TEXTBOXX.TEXT, conexion)
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT nick_usuario, contra_usuario FROM Usuario", conexion)
        Dim rsusuario As New Data.DataSet
        rsconsulta.Fill(rsusuario)
        Combo_Usuario.DataSource = rsusuario.Tables(0)
        Combo_Usuario.DisplayMember = "nick_usuario"
        Combo_Usuario.ValueMember = "contra_usuario"
        conexion.Close()
    End Sub

    Private Sub Cmd_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Aceptar.Click
        'MsgBox(Combo_Usuario.SelectedValue)
        If (Trim(Txt_Contra.Text) = Trim(Combo_Usuario.SelectedValue)) Then
            MsgBox("Acceso Autorizado")
            'Dim FormMenu As New Form_Menu
            Me.Hide()
            'Me.Close()
            FormMenu.Show()
        Else
            MsgBox("Contraseña incorrecta")
        End If
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class
