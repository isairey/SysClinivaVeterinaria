<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
        Me.btnConsultaAnimal = New System.Windows.Forms.Button()
        Me.btnConsultaForne = New System.Windows.Forms.Button()
        Me.btnConsultaFunc = New System.Windows.Forms.Button()
        Me.btnConsultaCliente = New System.Windows.Forms.Button()
        Me.txtNivelAcesso = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnConsultaAnimal
        '
        Me.btnConsultaAnimal.BackColor = System.Drawing.Color.White
        Me.btnConsultaAnimal.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_animal_fw
        Me.btnConsultaAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultaAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultaAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaAnimal.Location = New System.Drawing.Point(40, 87)
        Me.btnConsultaAnimal.Name = "btnConsultaAnimal"
        Me.btnConsultaAnimal.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultaAnimal.TabIndex = 2
        Me.btnConsultaAnimal.UseVisualStyleBackColor = False
        '
        'btnConsultaForne
        '
        Me.btnConsultaForne.BackColor = System.Drawing.Color.White
        Me.btnConsultaForne.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_fornecedor_fw
        Me.btnConsultaForne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultaForne.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultaForne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaForne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaForne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaForne.Location = New System.Drawing.Point(40, 213)
        Me.btnConsultaForne.Name = "btnConsultaForne"
        Me.btnConsultaForne.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultaForne.TabIndex = 4
        Me.btnConsultaForne.UseVisualStyleBackColor = False
        '
        'btnConsultaFunc
        '
        Me.btnConsultaFunc.BackColor = System.Drawing.Color.White
        Me.btnConsultaFunc.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_funcionario_fw
        Me.btnConsultaFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultaFunc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultaFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaFunc.Location = New System.Drawing.Point(40, 150)
        Me.btnConsultaFunc.Name = "btnConsultaFunc"
        Me.btnConsultaFunc.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultaFunc.TabIndex = 3
        Me.btnConsultaFunc.UseVisualStyleBackColor = False
        '
        'btnConsultaCliente
        '
        Me.btnConsultaCliente.BackColor = System.Drawing.Color.White
        Me.btnConsultaCliente.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_cliente_fw
        Me.btnConsultaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultaCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaCliente.Location = New System.Drawing.Point(40, 24)
        Me.btnConsultaCliente.Name = "btnConsultaCliente"
        Me.btnConsultaCliente.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultaCliente.TabIndex = 1
        Me.btnConsultaCliente.UseVisualStyleBackColor = False
        '
        'txtNivelAcesso
        '
        Me.txtNivelAcesso.Location = New System.Drawing.Point(269, 276)
        Me.txtNivelAcesso.Name = "txtNivelAcesso"
        Me.txtNivelAcesso.Size = New System.Drawing.Size(100, 20)
        Me.txtNivelAcesso.TabIndex = 6
        Me.txtNivelAcesso.Visible = False
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(414, 308)
        Me.Controls.Add(Me.txtNivelAcesso)
        Me.Controls.Add(Me.btnConsultaAnimal)
        Me.Controls.Add(Me.btnConsultaForne)
        Me.Controls.Add(Me.btnConsultaFunc)
        Me.Controls.Add(Me.btnConsultaCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecione uma consulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultaCliente As System.Windows.Forms.Button
    Friend WithEvents btnConsultaFunc As System.Windows.Forms.Button
    Friend WithEvents btnConsultaForne As System.Windows.Forms.Button
    Friend WithEvents btnConsultaAnimal As System.Windows.Forms.Button
    Friend WithEvents txtNivelAcesso As System.Windows.Forms.TextBox
End Class
