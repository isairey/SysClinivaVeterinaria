<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntradaEstoque))
        Me.btnConsultaTodosItens = New System.Windows.Forms.Button()
        Me.btnConsultarItem = New System.Windows.Forms.Button()
        Me.btnAdicionarItem = New System.Windows.Forms.Button()
        Me.btnReabastecerItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsultaTodosItens
        '
        Me.btnConsultaTodosItens.BackColor = System.Drawing.Color.White
        Me.btnConsultaTodosItens.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_todos_itens_fw
        Me.btnConsultaTodosItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultaTodosItens.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultaTodosItens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaTodosItens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaTodosItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaTodosItens.Location = New System.Drawing.Point(19, 212)
        Me.btnConsultaTodosItens.Name = "btnConsultaTodosItens"
        Me.btnConsultaTodosItens.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultaTodosItens.TabIndex = 4
        Me.btnConsultaTodosItens.UseVisualStyleBackColor = False
        '
        'btnConsultarItem
        '
        Me.btnConsultarItem.BackColor = System.Drawing.Color.White
        Me.btnConsultarItem.BackgroundImage = Global.sistechy.My.Resources.Resources.consultar_itens_fw
        Me.btnConsultarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultarItem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultarItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarItem.Location = New System.Drawing.Point(19, 149)
        Me.btnConsultarItem.Name = "btnConsultarItem"
        Me.btnConsultarItem.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultarItem.TabIndex = 3
        Me.btnConsultarItem.UseVisualStyleBackColor = False
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.BackColor = System.Drawing.Color.White
        Me.btnAdicionarItem.BackgroundImage = Global.sistechy.My.Resources.Resources.adicionar_item_fw
        Me.btnAdicionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionarItem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdicionarItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarItem.Location = New System.Drawing.Point(19, 23)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.Size = New System.Drawing.Size(329, 57)
        Me.btnAdicionarItem.TabIndex = 1
        Me.btnAdicionarItem.UseVisualStyleBackColor = False
        '
        'btnReabastecerItem
        '
        Me.btnReabastecerItem.BackColor = System.Drawing.Color.White
        Me.btnReabastecerItem.BackgroundImage = Global.sistechy.My.Resources.Resources.reabastecer_item_fw
        Me.btnReabastecerItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReabastecerItem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReabastecerItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnReabastecerItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReabastecerItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReabastecerItem.Location = New System.Drawing.Point(19, 86)
        Me.btnReabastecerItem.Name = "btnReabastecerItem"
        Me.btnReabastecerItem.Size = New System.Drawing.Size(329, 57)
        Me.btnReabastecerItem.TabIndex = 2
        Me.btnReabastecerItem.UseVisualStyleBackColor = False
        '
        'frmEntradaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(367, 290)
        Me.Controls.Add(Me.btnConsultaTodosItens)
        Me.Controls.Add(Me.btnConsultarItem)
        Me.Controls.Add(Me.btnAdicionarItem)
        Me.Controls.Add(Me.btnReabastecerItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEntradaEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de estoque"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReabastecerItem As System.Windows.Forms.Button
    Friend WithEvents btnAdicionarItem As System.Windows.Forms.Button
    Friend WithEvents btnConsultarItem As System.Windows.Forms.Button
    Friend WithEvents btnConsultaTodosItens As System.Windows.Forms.Button
End Class
