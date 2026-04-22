<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtendimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAtendimento))
        Me.btnVacinacao = New System.Windows.Forms.Button()
        Me.btnCirurgia = New System.Windows.Forms.Button()
        Me.btnInternacao = New System.Windows.Forms.Button()
        Me.btnConsultaGeral = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVacinacao
        '
        Me.btnVacinacao.BackColor = System.Drawing.Color.White
        Me.btnVacinacao.BackgroundImage = Global.sistechy.My.Resources.Resources.vacinacao_fw
        Me.btnVacinacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVacinacao.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVacinacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnVacinacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnVacinacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVacinacao.Location = New System.Drawing.Point(40, 87)
        Me.btnVacinacao.Name = "btnVacinacao"
        Me.btnVacinacao.Size = New System.Drawing.Size(329, 57)
        Me.btnVacinacao.TabIndex = 2
        Me.btnVacinacao.UseVisualStyleBackColor = False
        '
        'btnCirurgia
        '
        Me.btnCirurgia.BackColor = System.Drawing.Color.White
        Me.btnCirurgia.BackgroundImage = Global.sistechy.My.Resources.Resources.cirurgia_fw
        Me.btnCirurgia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCirurgia.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCirurgia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCirurgia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCirurgia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCirurgia.Location = New System.Drawing.Point(40, 213)
        Me.btnCirurgia.Name = "btnCirurgia"
        Me.btnCirurgia.Size = New System.Drawing.Size(329, 57)
        Me.btnCirurgia.TabIndex = 4
        Me.btnCirurgia.UseVisualStyleBackColor = False
        '
        'btnInternacao
        '
        Me.btnInternacao.BackColor = System.Drawing.Color.White
        Me.btnInternacao.BackgroundImage = Global.sistechy.My.Resources.Resources.internacao_fw
        Me.btnInternacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInternacao.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInternacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnInternacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnInternacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInternacao.Location = New System.Drawing.Point(40, 150)
        Me.btnInternacao.Name = "btnInternacao"
        Me.btnInternacao.Size = New System.Drawing.Size(329, 57)
        Me.btnInternacao.TabIndex = 3
        Me.btnInternacao.UseVisualStyleBackColor = False
        '
        'btnConsultaGeral
        '
        Me.btnConsultaGeral.BackColor = System.Drawing.Color.White
        Me.btnConsultaGeral.BackgroundImage = CType(resources.GetObject("btnConsultaGeral.BackgroundImage"), System.Drawing.Image)
        Me.btnConsultaGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultaGeral.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConsultaGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultaGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaGeral.Location = New System.Drawing.Point(40, 24)
        Me.btnConsultaGeral.Name = "btnConsultaGeral"
        Me.btnConsultaGeral.Size = New System.Drawing.Size(329, 57)
        Me.btnConsultaGeral.TabIndex = 1
        Me.btnConsultaGeral.UseVisualStyleBackColor = False
        '
        'frmAtendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(414, 291)
        Me.Controls.Add(Me.btnVacinacao)
        Me.Controls.Add(Me.btnCirurgia)
        Me.Controls.Add(Me.btnInternacao)
        Me.Controls.Add(Me.btnConsultaGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAtendimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecione um atendimento"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVacinacao As System.Windows.Forms.Button
    Friend WithEvents btnCirurgia As System.Windows.Forms.Button
    Friend WithEvents btnInternacao As System.Windows.Forms.Button
    Friend WithEvents btnConsultaGeral As System.Windows.Forms.Button
End Class
