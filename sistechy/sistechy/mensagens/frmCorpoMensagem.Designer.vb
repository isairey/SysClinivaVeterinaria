<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorpoMensagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorpoMensagem))
        Me.lbRemetente = New System.Windows.Forms.Label()
        Me.lbDestinatario = New System.Windows.Forms.Label()
        Me.txtRemetente = New System.Windows.Forms.TextBox()
        Me.txtDestinatario = New System.Windows.Forms.TextBox()
        Me.lbMensagem = New System.Windows.Forms.Label()
        Me.txtMensagem = New System.Windows.Forms.RichTextBox()
        Me.txtIdMensagem = New System.Windows.Forms.TextBox()
        Me.btnResponder = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnFecharForm = New System.Windows.Forms.Button()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbRemetente
        '
        Me.lbRemetente.AutoSize = True
        Me.lbRemetente.Location = New System.Drawing.Point(12, 61)
        Me.lbRemetente.Name = "lbRemetente"
        Me.lbRemetente.Size = New System.Drawing.Size(59, 13)
        Me.lbRemetente.TabIndex = 0
        Me.lbRemetente.Text = "Remetente"
        '
        'lbDestinatario
        '
        Me.lbDestinatario.AutoSize = True
        Me.lbDestinatario.Location = New System.Drawing.Point(12, 110)
        Me.lbDestinatario.Name = "lbDestinatario"
        Me.lbDestinatario.Size = New System.Drawing.Size(63, 13)
        Me.lbDestinatario.TabIndex = 1
        Me.lbDestinatario.Text = "Destinatário"
        '
        'txtRemetente
        '
        Me.txtRemetente.Enabled = False
        Me.txtRemetente.Location = New System.Drawing.Point(12, 77)
        Me.txtRemetente.Name = "txtRemetente"
        Me.txtRemetente.Size = New System.Drawing.Size(100, 20)
        Me.txtRemetente.TabIndex = 2
        '
        'txtDestinatario
        '
        Me.txtDestinatario.Enabled = False
        Me.txtDestinatario.Location = New System.Drawing.Point(12, 126)
        Me.txtDestinatario.Name = "txtDestinatario"
        Me.txtDestinatario.Size = New System.Drawing.Size(100, 20)
        Me.txtDestinatario.TabIndex = 3
        '
        'lbMensagem
        '
        Me.lbMensagem.AutoSize = True
        Me.lbMensagem.Location = New System.Drawing.Point(12, 167)
        Me.lbMensagem.Name = "lbMensagem"
        Me.lbMensagem.Size = New System.Drawing.Size(59, 13)
        Me.lbMensagem.TabIndex = 4
        Me.lbMensagem.Text = "Mensagem"
        '
        'txtMensagem
        '
        Me.txtMensagem.Enabled = False
        Me.txtMensagem.Location = New System.Drawing.Point(15, 183)
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(512, 235)
        Me.txtMensagem.TabIndex = 5
        Me.txtMensagem.Text = ""
        '
        'txtIdMensagem
        '
        Me.txtIdMensagem.Location = New System.Drawing.Point(145, 77)
        Me.txtIdMensagem.Name = "txtIdMensagem"
        Me.txtIdMensagem.Size = New System.Drawing.Size(100, 20)
        Me.txtIdMensagem.TabIndex = 6
        Me.txtIdMensagem.Visible = False
        '
        'btnResponder
        '
        Me.btnResponder.BackColor = System.Drawing.Color.White
        Me.btnResponder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnResponder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnResponder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResponder.Location = New System.Drawing.Point(435, 426)
        Me.btnResponder.Name = "btnResponder"
        Me.btnResponder.Size = New System.Drawing.Size(92, 23)
        Me.btnResponder.TabIndex = 7
        Me.btnResponder.Text = "Responder"
        Me.btnResponder.UseVisualStyleBackColor = False
        '
        'btnApagar
        '
        Me.btnApagar.BackColor = System.Drawing.Color.White
        Me.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.Location = New System.Drawing.Point(354, 426)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(75, 23)
        Me.btnApagar.TabIndex = 8
        Me.btnApagar.Text = "Apagar"
        Me.btnApagar.UseVisualStyleBackColor = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_corpo_mensagem_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-2, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(543, 55)
        Me.pbxBanner.TabIndex = 12
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
        Me.btnFecharForm.Location = New System.Drawing.Point(487, 59)
        Me.btnFecharForm.Name = "btnFecharForm"
        Me.btnFecharForm.Size = New System.Drawing.Size(40, 40)
        Me.btnFecharForm.TabIndex = 30
        Me.btnFecharForm.UseVisualStyleBackColor = False
        '
        'frmCorpoMensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(539, 461)
        Me.Controls.Add(Me.btnFecharForm)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.btnApagar)
        Me.Controls.Add(Me.btnResponder)
        Me.Controls.Add(Me.txtIdMensagem)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.lbMensagem)
        Me.Controls.Add(Me.txtDestinatario)
        Me.Controls.Add(Me.txtRemetente)
        Me.Controls.Add(Me.lbDestinatario)
        Me.Controls.Add(Me.lbRemetente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCorpoMensagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensagem"
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbRemetente As System.Windows.Forms.Label
    Friend WithEvents lbDestinatario As System.Windows.Forms.Label
    Friend WithEvents txtRemetente As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinatario As System.Windows.Forms.TextBox
    Friend WithEvents lbMensagem As System.Windows.Forms.Label
    Friend WithEvents txtMensagem As System.Windows.Forms.RichTextBox
    Friend WithEvents txtIdMensagem As System.Windows.Forms.TextBox
    Friend WithEvents btnResponder As System.Windows.Forms.Button
    Friend WithEvents btnApagar As System.Windows.Forms.Button
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents btnFecharForm As System.Windows.Forms.Button
End Class
