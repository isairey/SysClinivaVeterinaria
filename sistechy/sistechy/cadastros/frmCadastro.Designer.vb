<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastro))
        Me.btnCadastroForne = New System.Windows.Forms.Button()
        Me.btnCadastroFunc = New System.Windows.Forms.Button()
        Me.btnCadastroAnimal = New System.Windows.Forms.Button()
        Me.btnCadastroCliente = New System.Windows.Forms.Button()
        Me.txtNivelAcesso = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCadastroForne
        '
        Me.btnCadastroForne.BackColor = System.Drawing.Color.White
        Me.btnCadastroForne.BackgroundImage = Global.sistechy.My.Resources.Resources.cadastro_fornecedor_fw
        Me.btnCadastroForne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastroForne.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastroForne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroForne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroForne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroForne.Location = New System.Drawing.Point(40, 213)
        Me.btnCadastroForne.Name = "btnCadastroForne"
        Me.btnCadastroForne.Size = New System.Drawing.Size(329, 57)
        Me.btnCadastroForne.TabIndex = 4
        Me.btnCadastroForne.UseVisualStyleBackColor = False
        '
        'btnCadastroFunc
        '
        Me.btnCadastroFunc.BackColor = System.Drawing.Color.White
        Me.btnCadastroFunc.BackgroundImage = Global.sistechy.My.Resources.Resources.cadastro_funcionario_fw
        Me.btnCadastroFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastroFunc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastroFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroFunc.Location = New System.Drawing.Point(40, 150)
        Me.btnCadastroFunc.Name = "btnCadastroFunc"
        Me.btnCadastroFunc.Size = New System.Drawing.Size(329, 57)
        Me.btnCadastroFunc.TabIndex = 3
        Me.btnCadastroFunc.UseVisualStyleBackColor = False
        '
        'btnCadastroAnimal
        '
        Me.btnCadastroAnimal.BackColor = System.Drawing.Color.White
        Me.btnCadastroAnimal.BackgroundImage = Global.sistechy.My.Resources.Resources.cadastro_animal_fw
        Me.btnCadastroAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastroAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastroAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroAnimal.Location = New System.Drawing.Point(40, 87)
        Me.btnCadastroAnimal.Name = "btnCadastroAnimal"
        Me.btnCadastroAnimal.Size = New System.Drawing.Size(329, 57)
        Me.btnCadastroAnimal.TabIndex = 2
        Me.btnCadastroAnimal.UseVisualStyleBackColor = False
        '
        'btnCadastroCliente
        '
        Me.btnCadastroCliente.BackColor = System.Drawing.Color.White
        Me.btnCadastroCliente.BackgroundImage = Global.sistechy.My.Resources.Resources.cadastro_cliente_fw
        Me.btnCadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastroCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroCliente.Location = New System.Drawing.Point(40, 24)
        Me.btnCadastroCliente.Name = "btnCadastroCliente"
        Me.btnCadastroCliente.Size = New System.Drawing.Size(329, 57)
        Me.btnCadastroCliente.TabIndex = 1
        Me.btnCadastroCliente.UseVisualStyleBackColor = False
        '
        'txtNivelAcesso
        '
        Me.txtNivelAcesso.Location = New System.Drawing.Point(269, 276)
        Me.txtNivelAcesso.Name = "txtNivelAcesso"
        Me.txtNivelAcesso.Size = New System.Drawing.Size(100, 20)
        Me.txtNivelAcesso.TabIndex = 6
        Me.txtNivelAcesso.Visible = False
        '
        'frmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(414, 296)
        Me.Controls.Add(Me.txtNivelAcesso)
        Me.Controls.Add(Me.btnCadastroForne)
        Me.Controls.Add(Me.btnCadastroFunc)
        Me.Controls.Add(Me.btnCadastroAnimal)
        Me.Controls.Add(Me.btnCadastroCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realize um cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCadastroCliente As System.Windows.Forms.Button
    Friend WithEvents btnCadastroAnimal As System.Windows.Forms.Button
    Friend WithEvents btnCadastroFunc As System.Windows.Forms.Button
    Friend WithEvents btnCadastroForne As System.Windows.Forms.Button
    Friend WithEvents txtNivelAcesso As System.Windows.Forms.TextBox
End Class
