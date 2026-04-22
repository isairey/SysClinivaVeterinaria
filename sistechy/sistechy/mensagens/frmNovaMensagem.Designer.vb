<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovaMensagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovaMensagem))
        Me.txtRemetente = New System.Windows.Forms.TextBox()
        Me.txtDestinatario = New System.Windows.Forms.TextBox()
        Me.lbDestinatario = New System.Windows.Forms.Label()
        Me.lbRemetente = New System.Windows.Forms.Label()
        Me.lbMensagem = New System.Windows.Forms.Label()
        Me.txtMensagem = New System.Windows.Forms.RichTextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtStatusMensagem = New System.Windows.Forms.TextBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnFecharForm = New System.Windows.Forms.Button()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRemetente
        '
        Me.txtRemetente.Enabled = False
        Me.txtRemetente.Location = New System.Drawing.Point(74, 84)
        Me.txtRemetente.Name = "txtRemetente"
        Me.txtRemetente.Size = New System.Drawing.Size(100, 20)
        Me.txtRemetente.TabIndex = 0
        '
        'txtDestinatario
        '
        Me.txtDestinatario.Location = New System.Drawing.Point(74, 117)
        Me.txtDestinatario.Name = "txtDestinatario"
        Me.txtDestinatario.Size = New System.Drawing.Size(100, 20)
        Me.txtDestinatario.TabIndex = 1
        '
        'lbDestinatario
        '
        Me.lbDestinatario.AutoSize = True
        Me.lbDestinatario.Location = New System.Drawing.Point(9, 120)
        Me.lbDestinatario.Name = "lbDestinatario"
        Me.lbDestinatario.Size = New System.Drawing.Size(66, 13)
        Me.lbDestinatario.TabIndex = 2
        Me.lbDestinatario.Text = "Destinatário:"
        '
        'lbRemetente
        '
        Me.lbRemetente.AutoSize = True
        Me.lbRemetente.Location = New System.Drawing.Point(9, 87)
        Me.lbRemetente.Name = "lbRemetente"
        Me.lbRemetente.Size = New System.Drawing.Size(62, 13)
        Me.lbRemetente.TabIndex = 3
        Me.lbRemetente.Text = "Remetente:"
        '
        'lbMensagem
        '
        Me.lbMensagem.AutoSize = True
        Me.lbMensagem.Location = New System.Drawing.Point(9, 161)
        Me.lbMensagem.Name = "lbMensagem"
        Me.lbMensagem.Size = New System.Drawing.Size(59, 13)
        Me.lbMensagem.TabIndex = 4
        Me.lbMensagem.Text = "Mensagem"
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(12, 177)
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(525, 223)
        Me.txtMensagem.TabIndex = 5
        Me.txtMensagem.Text = ""
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.White
        Me.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Location = New System.Drawing.Point(462, 406)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'txtStatusMensagem
        '
        Me.txtStatusMensagem.Location = New System.Drawing.Point(212, 117)
        Me.txtStatusMensagem.Name = "txtStatusMensagem"
        Me.txtStatusMensagem.Size = New System.Drawing.Size(100, 20)
        Me.txtStatusMensagem.TabIndex = 8
        Me.txtStatusMensagem.Visible = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_nova_mensagem_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-1, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(554, 55)
        Me.pbxBanner.TabIndex = 11
        Me.pbxBanner.TabStop = False
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
        Me.btnFecharForm.Location = New System.Drawing.Point(497, 60)
        Me.btnFecharForm.Name = "btnFecharForm"
        Me.btnFecharForm.Size = New System.Drawing.Size(40, 40)
        Me.btnFecharForm.TabIndex = 30
        Me.btnFecharForm.UseVisualStyleBackColor = False
        '
        'frmNovaMensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(551, 441)
        Me.Controls.Add(Me.btnFecharForm)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.txtStatusMensagem)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.lbMensagem)
        Me.Controls.Add(Me.lbRemetente)
        Me.Controls.Add(Me.lbDestinatario)
        Me.Controls.Add(Me.txtDestinatario)
        Me.Controls.Add(Me.txtRemetente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNovaMensagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova mensagem"
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRemetente As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinatario As System.Windows.Forms.TextBox
    Friend WithEvents lbDestinatario As System.Windows.Forms.Label
    Friend WithEvents lbRemetente As System.Windows.Forms.Label
    Friend WithEvents lbMensagem As System.Windows.Forms.Label
    Friend WithEvents txtMensagem As System.Windows.Forms.RichTextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents txtStatusMensagem As System.Windows.Forms.TextBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents btnFecharForm As System.Windows.Forms.Button
End Class
