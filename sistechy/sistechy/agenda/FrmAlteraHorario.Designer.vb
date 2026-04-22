<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlteraHorario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlteraHorario))
        Me.txtCodAgendamento = New System.Windows.Forms.TextBox()
        Me.lbCodAgendamento = New System.Windows.Forms.Label()
        Me.lbDataAgendamento = New System.Windows.Forms.Label()
        Me.lbCodAnimal = New System.Windows.Forms.Label()
        Me.lbCodCli = New System.Windows.Forms.Label()
        Me.lbCodFunc = New System.Windows.Forms.Label()
        Me.lbTipoAtendimento = New System.Windows.Forms.Label()
        Me.lbStatusAgendamento = New System.Windows.Forms.Label()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.txtCodAnimal = New System.Windows.Forms.TextBox()
        Me.txtCodFunc = New System.Windows.Forms.TextBox()
        Me.MtxtDataAgendamento = New System.Windows.Forms.MaskedTextBox()
        Me.cmbStatusAgendamento = New System.Windows.Forms.ComboBox()
        Me.cmbTipoAtendimento = New System.Windows.Forms.ComboBox()
        Me.btnAlterarHorario = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodAgendamento
        '
        Me.txtCodAgendamento.Enabled = False
        Me.txtCodAgendamento.Location = New System.Drawing.Point(21, 83)
        Me.txtCodAgendamento.Name = "txtCodAgendamento"
        Me.txtCodAgendamento.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAgendamento.TabIndex = 0
        '
        'lbCodAgendamento
        '
        Me.lbCodAgendamento.AutoSize = True
        Me.lbCodAgendamento.Location = New System.Drawing.Point(18, 67)
        Me.lbCodAgendamento.Name = "lbCodAgendamento"
        Me.lbCodAgendamento.Size = New System.Drawing.Size(108, 13)
        Me.lbCodAgendamento.TabIndex = 1
        Me.lbCodAgendamento.Text = "Código agendamento"
        '
        'lbDataAgendamento
        '
        Me.lbDataAgendamento.AutoSize = True
        Me.lbDataAgendamento.Location = New System.Drawing.Point(18, 170)
        Me.lbDataAgendamento.Name = "lbDataAgendamento"
        Me.lbDataAgendamento.Size = New System.Drawing.Size(99, 13)
        Me.lbDataAgendamento.TabIndex = 2
        Me.lbDataAgendamento.Text = "Data Agendamento"
        '
        'lbCodAnimal
        '
        Me.lbCodAnimal.AutoSize = True
        Me.lbCodAnimal.Location = New System.Drawing.Point(146, 120)
        Me.lbCodAnimal.Name = "lbCodAnimal"
        Me.lbCodAnimal.Size = New System.Drawing.Size(88, 13)
        Me.lbCodAnimal.TabIndex = 3
        Me.lbCodAnimal.Text = "Código do animal"
        '
        'lbCodCli
        '
        Me.lbCodCli.AutoSize = True
        Me.lbCodCli.Location = New System.Drawing.Point(18, 120)
        Me.lbCodCli.Name = "lbCodCli"
        Me.lbCodCli.Size = New System.Drawing.Size(89, 13)
        Me.lbCodCli.TabIndex = 4
        Me.lbCodCli.Text = "Código do cliente"
        '
        'lbCodFunc
        '
        Me.lbCodFunc.AutoSize = True
        Me.lbCodFunc.Location = New System.Drawing.Point(272, 120)
        Me.lbCodFunc.Name = "lbCodFunc"
        Me.lbCodFunc.Size = New System.Drawing.Size(110, 13)
        Me.lbCodFunc.TabIndex = 5
        Me.lbCodFunc.Text = "Código do funcionário"
        '
        'lbTipoAtendimento
        '
        Me.lbTipoAtendimento.AutoSize = True
        Me.lbTipoAtendimento.Location = New System.Drawing.Point(281, 170)
        Me.lbTipoAtendimento.Name = "lbTipoAtendimento"
        Me.lbTipoAtendimento.Size = New System.Drawing.Size(89, 13)
        Me.lbTipoAtendimento.TabIndex = 6
        Me.lbTipoAtendimento.Text = "Tipo atendimento"
        '
        'lbStatusAgendamento
        '
        Me.lbStatusAgendamento.AutoSize = True
        Me.lbStatusAgendamento.Location = New System.Drawing.Point(129, 170)
        Me.lbStatusAgendamento.Name = "lbStatusAgendamento"
        Me.lbStatusAgendamento.Size = New System.Drawing.Size(105, 13)
        Me.lbStatusAgendamento.TabIndex = 7
        Me.lbStatusAgendamento.Text = "Status agendamento"
        '
        'txtCodCli
        '
        Me.txtCodCli.Location = New System.Drawing.Point(21, 136)
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCli.TabIndex = 1
        '
        'txtCodAnimal
        '
        Me.txtCodAnimal.Location = New System.Drawing.Point(149, 136)
        Me.txtCodAnimal.Name = "txtCodAnimal"
        Me.txtCodAnimal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAnimal.TabIndex = 2
        '
        'txtCodFunc
        '
        Me.txtCodFunc.Location = New System.Drawing.Point(275, 136)
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFunc.TabIndex = 3
        '
        'MtxtDataAgendamento
        '
        Me.MtxtDataAgendamento.Location = New System.Drawing.Point(21, 186)
        Me.MtxtDataAgendamento.Mask = "00/00/0000"
        Me.MtxtDataAgendamento.Name = "MtxtDataAgendamento"
        Me.MtxtDataAgendamento.Size = New System.Drawing.Size(72, 20)
        Me.MtxtDataAgendamento.TabIndex = 4
        Me.MtxtDataAgendamento.ValidatingType = GetType(Date)
        '
        'cmbStatusAgendamento
        '
        Me.cmbStatusAgendamento.FormattingEnabled = True
        Me.cmbStatusAgendamento.Location = New System.Drawing.Point(132, 186)
        Me.cmbStatusAgendamento.Name = "cmbStatusAgendamento"
        Me.cmbStatusAgendamento.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatusAgendamento.TabIndex = 5
        '
        'cmbTipoAtendimento
        '
        Me.cmbTipoAtendimento.FormattingEnabled = True
        Me.cmbTipoAtendimento.Location = New System.Drawing.Point(284, 186)
        Me.cmbTipoAtendimento.Name = "cmbTipoAtendimento"
        Me.cmbTipoAtendimento.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoAtendimento.TabIndex = 6
        '
        'btnAlterarHorario
        '
        Me.btnAlterarHorario.BackColor = System.Drawing.Color.White
        Me.btnAlterarHorario.BackgroundImage = Global.sistechy.My.Resources.Resources.atualizar_dados_fw
        Me.btnAlterarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlterarHorario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAlterarHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAlterarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnAlterarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterarHorario.Location = New System.Drawing.Point(271, 229)
        Me.btnAlterarHorario.Name = "btnAlterarHorario"
        Me.btnAlterarHorario.Size = New System.Drawing.Size(179, 50)
        Me.btnAlterarHorario.TabIndex = 7
        Me.btnAlterarHorario.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(86, 229)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(179, 50)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_alterar_horario_fw
        Me.pbxBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Location = New System.Drawing.Point(-2, -2)
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.Size = New System.Drawing.Size(465, 55)
        Me.pbxBanner.TabIndex = 14
        Me.pbxBanner.TabStop = False
        '
        'FrmAlteraHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(462, 291)
        Me.Controls.Add(Me.btnAlterarHorario)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.cmbTipoAtendimento)
        Me.Controls.Add(Me.cmbStatusAgendamento)
        Me.Controls.Add(Me.MtxtDataAgendamento)
        Me.Controls.Add(Me.txtCodFunc)
        Me.Controls.Add(Me.txtCodAnimal)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.lbStatusAgendamento)
        Me.Controls.Add(Me.lbTipoAtendimento)
        Me.Controls.Add(Me.lbCodFunc)
        Me.Controls.Add(Me.lbCodCli)
        Me.Controls.Add(Me.lbCodAnimal)
        Me.Controls.Add(Me.lbDataAgendamento)
        Me.Controls.Add(Me.lbCodAgendamento)
        Me.Controls.Add(Me.txtCodAgendamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAlteraHorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar horário"
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodAgendamento As System.Windows.Forms.TextBox
    Friend WithEvents lbCodAgendamento As System.Windows.Forms.Label
    Friend WithEvents lbDataAgendamento As System.Windows.Forms.Label
    Friend WithEvents lbCodAnimal As System.Windows.Forms.Label
    Friend WithEvents lbCodCli As System.Windows.Forms.Label
    Friend WithEvents lbCodFunc As System.Windows.Forms.Label
    Friend WithEvents lbTipoAtendimento As System.Windows.Forms.Label
    Friend WithEvents lbStatusAgendamento As System.Windows.Forms.Label
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAnimal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents MtxtDataAgendamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbStatusAgendamento As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoAtendimento As System.Windows.Forms.ComboBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAlterarHorario As System.Windows.Forms.Button
End Class
