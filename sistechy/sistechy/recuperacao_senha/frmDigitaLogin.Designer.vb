<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDigitaLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDigitaLogin))
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnProsseguir = New System.Windows.Forms.Button()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnFecharForm = New System.Windows.Forms.Button()
        Me.lbTexto1 = New System.Windows.Forms.Label()
        Me.lbTexto2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbLogin
        '
        Me.lbLogin.AutoSize = True
        Me.lbLogin.Location = New System.Drawing.Point(13, 52)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(36, 13)
        Me.lbLogin.TabIndex = 0
        Me.lbLogin.Text = "Login:"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(16, 69)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(225, 20)
        Me.txtLogin.TabIndex = 3
        '
        'btnProsseguir
        '
        Me.btnProsseguir.Location = New System.Drawing.Point(258, 67)
        Me.btnProsseguir.Name = "btnProsseguir"
        Me.btnProsseguir.Size = New System.Drawing.Size(75, 23)
        Me.btnProsseguir.TabIndex = 4
        Me.btnProsseguir.Text = "Prosseguir"
        Me.btnProsseguir.UseVisualStyleBackColor = True
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Location = New System.Drawing.Point(16, 69)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtNovaSenha.TabIndex = 5
        Me.txtNovaSenha.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(16, 69)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Visible = False
        '
        'btnFecharForm
        '
        Me.btnFecharForm.BackColor = System.Drawing.Color.White
        Me.btnFecharForm.BackgroundImage = Global.sistechy.My.Resources.Resources.fechar
        Me.btnFecharForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFecharForm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFecharForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnFecharForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharForm.Location = New System.Drawing.Point(293, 8)
        Me.btnFecharForm.Name = "btnFecharForm"
        Me.btnFecharForm.Size = New System.Drawing.Size(35, 35)
        Me.btnFecharForm.TabIndex = 30
        Me.btnFecharForm.UseVisualStyleBackColor = False
        '
        'lbTexto1
        '
        Me.lbTexto1.AutoSize = True
        Me.lbTexto1.Location = New System.Drawing.Point(13, 8)
        Me.lbTexto1.Name = "lbTexto1"
        Me.lbTexto1.Size = New System.Drawing.Size(234, 13)
        Me.lbTexto1.TabIndex = 31
        Me.lbTexto1.Text = "Este é o formulário para recuperação de senha, "
        '
        'lbTexto2
        '
        Me.lbTexto2.AutoSize = True
        Me.lbTexto2.Location = New System.Drawing.Point(13, 23)
        Me.lbTexto2.Name = "lbTexto2"
        Me.lbTexto2.Size = New System.Drawing.Size(238, 13)
        Me.lbTexto2.TabIndex = 32
        Me.lbTexto2.Text = "apenas digite seu login e o resto a gente resolve!"
        '
        'frmDigitaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(345, 104)
        Me.Controls.Add(Me.lbTexto2)
        Me.Controls.Add(Me.lbTexto1)
        Me.Controls.Add(Me.btnFecharForm)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNovaSenha)
        Me.Controls.Add(Me.btnProsseguir)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lbLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDigitaLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperação senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogin As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnProsseguir As System.Windows.Forms.Button
    Friend WithEvents txtNovaSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnFecharForm As System.Windows.Forms.Button
    Friend WithEvents lbTexto1 As System.Windows.Forms.Label
    Friend WithEvents lbTexto2 As System.Windows.Forms.Label
End Class
