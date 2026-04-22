<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixaEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaixaEntrada))
        Me.dgvMensagens = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNaoLidas = New System.Windows.Forms.Button()
        Me.btnLidas = New System.Windows.Forms.Button()
        Me.btnEnviadas = New System.Windows.Forms.Button()
        Me.txtFiltroMensagem = New System.Windows.Forms.TextBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnNovaMensagem = New System.Windows.Forms.Button()
        CType(Me.dgvMensagens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMensagens
        '
        Me.dgvMensagens.AllowUserToAddRows = False
        Me.dgvMensagens.AllowUserToDeleteRows = False
        Me.dgvMensagens.AllowUserToResizeColumns = False
        Me.dgvMensagens.AllowUserToResizeRows = False
        Me.dgvMensagens.BackgroundColor = System.Drawing.Color.White
        Me.dgvMensagens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMensagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMensagens.Location = New System.Drawing.Point(205, 72)
        Me.dgvMensagens.MultiSelect = False
        Me.dgvMensagens.Name = "dgvMensagens"
        Me.dgvMensagens.ReadOnly = True
        Me.dgvMensagens.RowHeadersVisible = False
        Me.dgvMensagens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMensagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMensagens.Size = New System.Drawing.Size(486, 416)
        Me.dgvMensagens.TabIndex = 0
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(745, 468)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BackgroundImage = Global.sistechy.My.Resources.Resources.cancelar_fw
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(703, 118)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(144, 40)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNaoLidas
        '
        Me.btnNaoLidas.BackColor = System.Drawing.Color.White
        Me.btnNaoLidas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNaoLidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnNaoLidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnNaoLidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNaoLidas.Location = New System.Drawing.Point(14, 72)
        Me.btnNaoLidas.Name = "btnNaoLidas"
        Me.btnNaoLidas.Size = New System.Drawing.Size(179, 40)
        Me.btnNaoLidas.TabIndex = 6
        Me.btnNaoLidas.Text = "Não lidas"
        Me.btnNaoLidas.UseVisualStyleBackColor = False
        '
        'btnLidas
        '
        Me.btnLidas.BackColor = System.Drawing.Color.White
        Me.btnLidas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnLidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLidas.Location = New System.Drawing.Point(14, 118)
        Me.btnLidas.Name = "btnLidas"
        Me.btnLidas.Size = New System.Drawing.Size(179, 40)
        Me.btnLidas.TabIndex = 7
        Me.btnLidas.Text = "Lidas"
        Me.btnLidas.UseVisualStyleBackColor = False
        '
        'btnEnviadas
        '
        Me.btnEnviadas.BackColor = System.Drawing.Color.White
        Me.btnEnviadas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEnviadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnEnviadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnEnviadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviadas.Location = New System.Drawing.Point(14, 164)
        Me.btnEnviadas.Name = "btnEnviadas"
        Me.btnEnviadas.Size = New System.Drawing.Size(179, 40)
        Me.btnEnviadas.TabIndex = 8
        Me.btnEnviadas.Text = "Enviadas"
        Me.btnEnviadas.UseVisualStyleBackColor = False
        '
        'txtFiltroMensagem
        '
        Me.txtFiltroMensagem.Location = New System.Drawing.Point(745, 442)
        Me.txtFiltroMensagem.Name = "txtFiltroMensagem"
        Me.txtFiltroMensagem.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroMensagem.TabIndex = 9
        Me.txtFiltroMensagem.Visible = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_caixa_entrada_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-2, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(870, 55)
        Me.pbxBanner.TabIndex = 10
        Me.pbxBanner.TabStop = False
        '
        'btnNovaMensagem
        '
        Me.btnNovaMensagem.BackColor = System.Drawing.Color.White
        Me.btnNovaMensagem.BackgroundImage = Global.sistechy.My.Resources.Resources.nova_mensagem_fw
        Me.btnNovaMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNovaMensagem.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNovaMensagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnNovaMensagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnNovaMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovaMensagem.Location = New System.Drawing.Point(703, 72)
        Me.btnNovaMensagem.Name = "btnNovaMensagem"
        Me.btnNovaMensagem.Size = New System.Drawing.Size(144, 40)
        Me.btnNovaMensagem.TabIndex = 2
        Me.btnNovaMensagem.UseVisualStyleBackColor = False
        '
        'frmCaixaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(863, 502)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.txtFiltroMensagem)
        Me.Controls.Add(Me.btnEnviadas)
        Me.Controls.Add(Me.btnLidas)
        Me.Controls.Add(Me.btnNaoLidas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNovaMensagem)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.dgvMensagens)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCaixaEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensagens"
        CType(Me.dgvMensagens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMensagens As System.Windows.Forms.DataGridView
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnNovaMensagem As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNaoLidas As System.Windows.Forms.Button
    Friend WithEvents btnLidas As System.Windows.Forms.Button
    Friend WithEvents btnEnviadas As System.Windows.Forms.Button
    Friend WithEvents txtFiltroMensagem As System.Windows.Forms.TextBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
End Class
