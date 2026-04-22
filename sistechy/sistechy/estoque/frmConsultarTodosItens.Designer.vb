<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarTodosItens
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarTodosItens))
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.btnOutros = New System.Windows.Forms.Button()
        Me.btnBrinquedos = New System.Windows.Forms.Button()
        Me.btnHigiene = New System.Windows.Forms.Button()
        Me.btnVacina = New System.Windows.Forms.Button()
        Me.btnMedicamento = New System.Windows.Forms.Button()
        Me.lbCritico = New System.Windows.Forms.Label()
        Me.lbModerado = New System.Windows.Forms.Label()
        Me.lbBom = New System.Windows.Forms.Label()
        Me.btnFecharForm = New System.Windows.Forms.Button()
        Me.pbxModerado = New System.Windows.Forms.PictureBox()
        Me.pbxSobrando = New System.Windows.Forms.PictureBox()
        Me.pbxCritico = New System.Windows.Forms.PictureBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxModerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSobrando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCritico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.EnableHeadersVisualStyles = False
        Me.dgvProdutos.Location = New System.Drawing.Point(221, 113)
        Me.dgvProdutos.MultiSelect = False
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(824, 501)
        Me.dgvProdutos.TabIndex = 2
        '
        'btnOutros
        '
        Me.btnOutros.BackColor = System.Drawing.Color.White
        Me.btnOutros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOutros.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnOutros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnOutros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnOutros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutros.Location = New System.Drawing.Point(25, 337)
        Me.btnOutros.Name = "btnOutros"
        Me.btnOutros.Size = New System.Drawing.Size(181, 50)
        Me.btnOutros.TabIndex = 14
        Me.btnOutros.Text = "Outros"
        Me.btnOutros.UseVisualStyleBackColor = False
        '
        'btnBrinquedos
        '
        Me.btnBrinquedos.BackColor = System.Drawing.Color.White
        Me.btnBrinquedos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrinquedos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBrinquedos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnBrinquedos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnBrinquedos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrinquedos.Location = New System.Drawing.Point(25, 281)
        Me.btnBrinquedos.Name = "btnBrinquedos"
        Me.btnBrinquedos.Size = New System.Drawing.Size(181, 50)
        Me.btnBrinquedos.TabIndex = 15
        Me.btnBrinquedos.Text = "Brinquedos"
        Me.btnBrinquedos.UseVisualStyleBackColor = False
        '
        'btnHigiene
        '
        Me.btnHigiene.BackColor = System.Drawing.Color.White
        Me.btnHigiene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHigiene.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHigiene.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnHigiene.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnHigiene.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHigiene.Location = New System.Drawing.Point(25, 225)
        Me.btnHigiene.Name = "btnHigiene"
        Me.btnHigiene.Size = New System.Drawing.Size(181, 50)
        Me.btnHigiene.TabIndex = 16
        Me.btnHigiene.Text = "Higiene"
        Me.btnHigiene.UseVisualStyleBackColor = False
        '
        'btnVacina
        '
        Me.btnVacina.BackColor = System.Drawing.Color.White
        Me.btnVacina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVacina.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVacina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnVacina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVacina.Location = New System.Drawing.Point(25, 169)
        Me.btnVacina.Name = "btnVacina"
        Me.btnVacina.Size = New System.Drawing.Size(181, 50)
        Me.btnVacina.TabIndex = 17
        Me.btnVacina.Text = "Vacinas"
        Me.btnVacina.UseVisualStyleBackColor = False
        '
        'btnMedicamento
        '
        Me.btnMedicamento.BackColor = System.Drawing.Color.White
        Me.btnMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMedicamento.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicamento.Location = New System.Drawing.Point(25, 113)
        Me.btnMedicamento.Name = "btnMedicamento"
        Me.btnMedicamento.Size = New System.Drawing.Size(181, 50)
        Me.btnMedicamento.TabIndex = 18
        Me.btnMedicamento.Text = "Medicamentos"
        Me.btnMedicamento.UseVisualStyleBackColor = False
        '
        'lbCritico
        '
        Me.lbCritico.AutoSize = True
        Me.lbCritico.Location = New System.Drawing.Point(61, 430)
        Me.lbCritico.Name = "lbCritico"
        Me.lbCritico.Size = New System.Drawing.Size(80, 13)
        Me.lbCritico.TabIndex = 24
        Me.lbCritico.Text = "Estoque Crítico"
        '
        'lbModerado
        '
        Me.lbModerado.AutoSize = True
        Me.lbModerado.Location = New System.Drawing.Point(61, 466)
        Me.lbModerado.Name = "lbModerado"
        Me.lbModerado.Size = New System.Drawing.Size(96, 13)
        Me.lbModerado.TabIndex = 25
        Me.lbModerado.Text = "Estoque moderado"
        '
        'lbBom
        '
        Me.lbBom.AutoSize = True
        Me.lbBom.Location = New System.Drawing.Point(61, 502)
        Me.lbBom.Name = "lbBom"
        Me.lbBom.Size = New System.Drawing.Size(69, 13)
        Me.lbBom.TabIndex = 26
        Me.lbBom.Text = "Estoque bom"
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
        Me.btnFecharForm.Location = New System.Drawing.Point(1000, 62)
        Me.btnFecharForm.Name = "btnFecharForm"
        Me.btnFecharForm.Size = New System.Drawing.Size(40, 40)
        Me.btnFecharForm.TabIndex = 30
        Me.btnFecharForm.UseVisualStyleBackColor = False
        '
        'pbxModerado
        '
        Me.pbxModerado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxModerado.Location = New System.Drawing.Point(25, 466)
        Me.pbxModerado.Name = "pbxModerado"
        Me.pbxModerado.Size = New System.Drawing.Size(30, 30)
        Me.pbxModerado.TabIndex = 23
        Me.pbxModerado.TabStop = False
        '
        'pbxSobrando
        '
        Me.pbxSobrando.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxSobrando.Location = New System.Drawing.Point(25, 502)
        Me.pbxSobrando.Name = "pbxSobrando"
        Me.pbxSobrando.Size = New System.Drawing.Size(30, 30)
        Me.pbxSobrando.TabIndex = 22
        Me.pbxSobrando.TabStop = False
        '
        'pbxCritico
        '
        Me.pbxCritico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxCritico.Location = New System.Drawing.Point(25, 430)
        Me.pbxCritico.Name = "pbxCritico"
        Me.pbxCritico.Size = New System.Drawing.Size(30, 30)
        Me.pbxCritico.TabIndex = 21
        Me.pbxCritico.TabStop = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_consultar_todos_itens_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-5, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(1069, 55)
        Me.pbxBanner.TabIndex = 9
        Me.pbxBanner.TabStop = False
        '
        'frmConsultarTodosItens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1057, 625)
        Me.Controls.Add(Me.btnFecharForm)
        Me.Controls.Add(Me.lbBom)
        Me.Controls.Add(Me.lbModerado)
        Me.Controls.Add(Me.lbCritico)
        Me.Controls.Add(Me.pbxModerado)
        Me.Controls.Add(Me.pbxSobrando)
        Me.Controls.Add(Me.pbxCritico)
        Me.Controls.Add(Me.btnMedicamento)
        Me.Controls.Add(Me.btnVacina)
        Me.Controls.Add(Me.btnHigiene)
        Me.Controls.Add(Me.btnBrinquedos)
        Me.Controls.Add(Me.btnOutros)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.dgvProdutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultarTodosItens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de todos itens"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxModerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSobrando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCritico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents btnOutros As System.Windows.Forms.Button
    Friend WithEvents btnBrinquedos As System.Windows.Forms.Button
    Friend WithEvents btnHigiene As System.Windows.Forms.Button
    Friend WithEvents btnVacina As System.Windows.Forms.Button
    Friend WithEvents btnMedicamento As System.Windows.Forms.Button
    Friend WithEvents pbxCritico As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSobrando As System.Windows.Forms.PictureBox
    Friend WithEvents pbxModerado As System.Windows.Forms.PictureBox
    Friend WithEvents lbCritico As System.Windows.Forms.Label
    Friend WithEvents lbModerado As System.Windows.Forms.Label
    Friend WithEvents lbBom As System.Windows.Forms.Label
    Friend WithEvents btnFecharForm As System.Windows.Forms.Button
End Class
