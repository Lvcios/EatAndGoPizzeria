<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Form_Acceso
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents Txt_Contra As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Acceso))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.Txt_Contra = New System.Windows.Forms.TextBox
        Me.Cmd_Aceptar = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.Combo_Usuario = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(222, 83)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(221, 134)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Contra
        '
        Me.Txt_Contra.Location = New System.Drawing.Point(224, 160)
        Me.Txt_Contra.Name = "Txt_Contra"
        Me.Txt_Contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Contra.Size = New System.Drawing.Size(220, 20)
        Me.Txt_Contra.TabIndex = 3
        '
        'Cmd_Aceptar
        '
        Me.Cmd_Aceptar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Cmd_Aceptar.Location = New System.Drawing.Point(247, 220)
        Me.Cmd_Aceptar.Name = "Cmd_Aceptar"
        Me.Cmd_Aceptar.Size = New System.Drawing.Size(94, 23)
        Me.Cmd_Aceptar.TabIndex = 4
        Me.Cmd_Aceptar.Text = "&Aceptar"
        Me.Cmd_Aceptar.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(350, 220)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'Combo_Usuario
        '
        Me.Combo_Usuario.DisplayMember = "apmat_usuario"
        Me.Combo_Usuario.FormattingEnabled = True
        Me.Combo_Usuario.Location = New System.Drawing.Point(225, 110)
        Me.Combo_Usuario.Name = "Combo_Usuario"
        Me.Combo_Usuario.Size = New System.Drawing.Size(217, 21)
        Me.Combo_Usuario.TabIndex = 6
        Me.Combo_Usuario.ValueMember = "apmat_usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Pizzeria.My.Resources.Resources.logo
        Me.PictureBox1.ErrorImage = Global.Pizzeria.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(178, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 63)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Pizzeria.My.Resources.Resources.pizza_margarita
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(182, 260)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Form_Acceso
        '
        Me.AcceptButton = Me.Cmd_Aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(571, 252)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Combo_Usuario)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Cmd_Aceptar)
        Me.Controls.Add(Me.Txt_Contra)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Acceso"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso a Usuarios Eant Go"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Combo_Usuario As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
