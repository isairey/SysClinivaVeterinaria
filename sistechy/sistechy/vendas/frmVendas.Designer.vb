<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.btnConsultarVendas = New System.Windows.Forms.Button()
        Me.btnRealizarVenda = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsultarVendas
        '
        Me.btnConsultarVendas.BackColor = System.Drawing.Color.White
        Me.btnConsultarVendas.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_venda_fw
        Me.btnConsultarVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultarVendas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultarVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultarVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarVendas.Location = New System.Drawing.Point(40, 87)
        Me.btnConsultarVendas.Name = "btnConsultarVendas"
        Me.btnConsultarVendas.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultarVendas.TabIndex = 6
        Me.btnConsultarVendas.UseVisualStyleBackColor = False
        '
        'btnRealizarVenda
        '
        Me.btnRealizarVenda.BackColor = System.Drawing.Color.White
        Me.btnRealizarVenda.BackgroundImage = Global.sistechy.My.Resources.Resources.realizar_venda_fw
        Me.btnRealizarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRealizarVenda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRealizarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnRealizarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnRealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizarVenda.Location = New System.Drawing.Point(40, 24)
        Me.btnRealizarVenda.Name = "btnRealizarVenda"
        Me.btnRealizarVenda.Size = New System.Drawing.Size(329, 57)
        Me.btnRealizarVenda.TabIndex = 5
        Me.btnRealizarVenda.UseVisualStyleBackColor = False
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(414, 172)
        Me.Controls.Add(Me.btnConsultarVendas)
        Me.Controls.Add(Me.btnRealizarVenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecione um item"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConsultarVendas As System.Windows.Forms.Button
    Friend WithEvents btnRealizarVenda As System.Windows.Forms.Button
End Class
