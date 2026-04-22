<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraficos
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGraficos))
        Me.ChartGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnGeraGrafico = New System.Windows.Forms.Button()
        Me.cmbFonteGrafico = New System.Windows.Forms.ComboBox()
        Me.cmbTipoGrafico = New System.Windows.Forms.ComboBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtJaneiro = New System.Windows.Forms.TextBox()
        Me.txtFevereiro = New System.Windows.Forms.TextBox()
        Me.txtMarco = New System.Windows.Forms.TextBox()
        Me.txtAbril = New System.Windows.Forms.TextBox()
        Me.txtMaio = New System.Windows.Forms.TextBox()
        Me.txtJunho = New System.Windows.Forms.TextBox()
        Me.txtJulho = New System.Windows.Forms.TextBox()
        Me.txtAgosto = New System.Windows.Forms.TextBox()
        Me.txtSetembro = New System.Windows.Forms.TextBox()
        Me.txtOutubro = New System.Windows.Forms.TextBox()
        Me.txtNovembro = New System.Windows.Forms.TextBox()
        Me.txtDezembro = New System.Windows.Forms.TextBox()
        Me.lbFonteGrafico = New System.Windows.Forms.Label()
        Me.lbAno = New System.Windows.Forms.Label()
        Me.lbTipoGrafico = New System.Windows.Forms.Label()
        Me.cmbDesignGrafico = New System.Windows.Forms.ComboBox()
        Me.lbDesignGrafico = New System.Windows.Forms.Label()
        Me.btnFecharForm = New System.Windows.Forms.Button()
        Me.btnSalvarGrafico = New System.Windows.Forms.Button()
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartGrafico
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartGrafico.Legends.Add(Legend1)
        Me.ChartGrafico.Location = New System.Drawing.Point(12, 71)
        Me.ChartGrafico.Name = "ChartGrafico"
        Me.ChartGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartGrafico.Series.Add(Series1)
        Me.ChartGrafico.Size = New System.Drawing.Size(1191, 517)
        Me.ChartGrafico.TabIndex = 0
        Me.ChartGrafico.Text = "Chart1"
        '
        'btnGeraGrafico
        '
        Me.btnGeraGrafico.BackColor = System.Drawing.Color.White
        Me.btnGeraGrafico.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGeraGrafico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnGeraGrafico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGeraGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeraGrafico.Location = New System.Drawing.Point(608, 23)
        Me.btnGeraGrafico.Name = "btnGeraGrafico"
        Me.btnGeraGrafico.Size = New System.Drawing.Size(75, 23)
        Me.btnGeraGrafico.TabIndex = 1
        Me.btnGeraGrafico.Text = "Gerar"
        Me.btnGeraGrafico.UseVisualStyleBackColor = False
        '
        'cmbFonteGrafico
        '
        Me.cmbFonteGrafico.FormattingEnabled = True
        Me.cmbFonteGrafico.Location = New System.Drawing.Point(12, 25)
        Me.cmbFonteGrafico.Name = "cmbFonteGrafico"
        Me.cmbFonteGrafico.Size = New System.Drawing.Size(121, 21)
        Me.cmbFonteGrafico.TabIndex = 2
        '
        'cmbTipoGrafico
        '
        Me.cmbTipoGrafico.FormattingEnabled = True
        Me.cmbTipoGrafico.Location = New System.Drawing.Point(158, 25)
        Me.cmbTipoGrafico.Name = "cmbTipoGrafico"
        Me.cmbTipoGrafico.Size = New System.Drawing.Size(149, 21)
        Me.cmbTipoGrafico.TabIndex = 5
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(333, 26)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 8
        Me.txtAno.Visible = False
        '
        'txtJaneiro
        '
        Me.txtJaneiro.Location = New System.Drawing.Point(12, 89)
        Me.txtJaneiro.Name = "txtJaneiro"
        Me.txtJaneiro.Size = New System.Drawing.Size(30, 20)
        Me.txtJaneiro.TabIndex = 9
        Me.txtJaneiro.Visible = False
        '
        'txtFevereiro
        '
        Me.txtFevereiro.Location = New System.Drawing.Point(48, 89)
        Me.txtFevereiro.Name = "txtFevereiro"
        Me.txtFevereiro.Size = New System.Drawing.Size(30, 20)
        Me.txtFevereiro.TabIndex = 10
        Me.txtFevereiro.Visible = False
        '
        'txtMarco
        '
        Me.txtMarco.Location = New System.Drawing.Point(84, 89)
        Me.txtMarco.Name = "txtMarco"
        Me.txtMarco.Size = New System.Drawing.Size(30, 20)
        Me.txtMarco.TabIndex = 11
        Me.txtMarco.Visible = False
        '
        'txtAbril
        '
        Me.txtAbril.Location = New System.Drawing.Point(120, 89)
        Me.txtAbril.Name = "txtAbril"
        Me.txtAbril.Size = New System.Drawing.Size(30, 20)
        Me.txtAbril.TabIndex = 12
        Me.txtAbril.Visible = False
        '
        'txtMaio
        '
        Me.txtMaio.Location = New System.Drawing.Point(158, 89)
        Me.txtMaio.Name = "txtMaio"
        Me.txtMaio.Size = New System.Drawing.Size(30, 20)
        Me.txtMaio.TabIndex = 13
        Me.txtMaio.Visible = False
        '
        'txtJunho
        '
        Me.txtJunho.Location = New System.Drawing.Point(194, 89)
        Me.txtJunho.Name = "txtJunho"
        Me.txtJunho.Size = New System.Drawing.Size(30, 20)
        Me.txtJunho.TabIndex = 14
        Me.txtJunho.Visible = False
        '
        'txtJulho
        '
        Me.txtJulho.Location = New System.Drawing.Point(230, 89)
        Me.txtJulho.Name = "txtJulho"
        Me.txtJulho.Size = New System.Drawing.Size(30, 20)
        Me.txtJulho.TabIndex = 15
        Me.txtJulho.Visible = False
        '
        'txtAgosto
        '
        Me.txtAgosto.Location = New System.Drawing.Point(266, 89)
        Me.txtAgosto.Name = "txtAgosto"
        Me.txtAgosto.Size = New System.Drawing.Size(30, 20)
        Me.txtAgosto.TabIndex = 16
        Me.txtAgosto.Visible = False
        '
        'txtSetembro
        '
        Me.txtSetembro.Location = New System.Drawing.Point(302, 89)
        Me.txtSetembro.Name = "txtSetembro"
        Me.txtSetembro.Size = New System.Drawing.Size(30, 20)
        Me.txtSetembro.TabIndex = 17
        Me.txtSetembro.Visible = False
        '
        'txtOutubro
        '
        Me.txtOutubro.Location = New System.Drawing.Point(338, 89)
        Me.txtOutubro.Name = "txtOutubro"
        Me.txtOutubro.Size = New System.Drawing.Size(30, 20)
        Me.txtOutubro.TabIndex = 18
        Me.txtOutubro.Visible = False
        '
        'txtNovembro
        '
        Me.txtNovembro.Location = New System.Drawing.Point(374, 89)
        Me.txtNovembro.Name = "txtNovembro"
        Me.txtNovembro.Size = New System.Drawing.Size(30, 20)
        Me.txtNovembro.TabIndex = 19
        Me.txtNovembro.Visible = False
        '
        'txtDezembro
        '
        Me.txtDezembro.Location = New System.Drawing.Point(410, 89)
        Me.txtDezembro.Name = "txtDezembro"
        Me.txtDezembro.Size = New System.Drawing.Size(30, 20)
        Me.txtDezembro.TabIndex = 20
        Me.txtDezembro.Visible = False
        '
        'lbFonteGrafico
        '
        Me.lbFonteGrafico.AutoSize = True
        Me.lbFonteGrafico.Location = New System.Drawing.Point(9, 9)
        Me.lbFonteGrafico.Name = "lbFonteGrafico"
        Me.lbFonteGrafico.Size = New System.Drawing.Size(84, 13)
        Me.lbFonteGrafico.TabIndex = 22
        Me.lbFonteGrafico.Text = "Fonte do gráfico"
        '
        'lbAno
        '
        Me.lbAno.AutoSize = True
        Me.lbAno.Location = New System.Drawing.Point(330, 10)
        Me.lbAno.Name = "lbAno"
        Me.lbAno.Size = New System.Drawing.Size(26, 13)
        Me.lbAno.TabIndex = 24
        Me.lbAno.Text = "Ano"
        Me.lbAno.Visible = False
        '
        'lbTipoGrafico
        '
        Me.lbTipoGrafico.AutoSize = True
        Me.lbTipoGrafico.Location = New System.Drawing.Point(155, 9)
        Me.lbTipoGrafico.Name = "lbTipoGrafico"
        Me.lbTipoGrafico.Size = New System.Drawing.Size(63, 13)
        Me.lbTipoGrafico.TabIndex = 25
        Me.lbTipoGrafico.Text = "Tipo gráfico"
        '
        'cmbDesignGrafico
        '
        Me.cmbDesignGrafico.FormattingEnabled = True
        Me.cmbDesignGrafico.Location = New System.Drawing.Point(458, 26)
        Me.cmbDesignGrafico.Name = "cmbDesignGrafico"
        Me.cmbDesignGrafico.Size = New System.Drawing.Size(121, 21)
        Me.cmbDesignGrafico.TabIndex = 26
        '
        'lbDesignGrafico
        '
        Me.lbDesignGrafico.AutoSize = True
        Me.lbDesignGrafico.Location = New System.Drawing.Point(455, 10)
        Me.lbDesignGrafico.Name = "lbDesignGrafico"
        Me.lbDesignGrafico.Size = New System.Drawing.Size(90, 13)
        Me.lbDesignGrafico.TabIndex = 27
        Me.lbDesignGrafico.Text = "Design do gráfico"
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
        Me.btnFecharForm.Location = New System.Drawing.Point(1163, 16)
        Me.btnFecharForm.Name = "btnFecharForm"
        Me.btnFecharForm.Size = New System.Drawing.Size(40, 40)
        Me.btnFecharForm.TabIndex = 29
        Me.btnFecharForm.UseVisualStyleBackColor = False
        '
        'btnSalvarGrafico
        '
        Me.btnSalvarGrafico.BackColor = System.Drawing.Color.White
        Me.btnSalvarGrafico.BackgroundImage = Global.sistechy.My.Resources.Resources.salvar_grafico_fw
        Me.btnSalvarGrafico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvarGrafico.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvarGrafico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarGrafico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSalvarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarGrafico.Location = New System.Drawing.Point(1007, 14)
        Me.btnSalvarGrafico.Name = "btnSalvarGrafico"
        Me.btnSalvarGrafico.Size = New System.Drawing.Size(130, 42)
        Me.btnSalvarGrafico.TabIndex = 28
        Me.btnSalvarGrafico.UseVisualStyleBackColor = False
        '
        'frmGraficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1215, 600)
        Me.Controls.Add(Me.btnFecharForm)
        Me.Controls.Add(Me.btnSalvarGrafico)
        Me.Controls.Add(Me.lbDesignGrafico)
        Me.Controls.Add(Me.cmbDesignGrafico)
        Me.Controls.Add(Me.lbTipoGrafico)
        Me.Controls.Add(Me.lbAno)
        Me.Controls.Add(Me.lbFonteGrafico)
        Me.Controls.Add(Me.txtDezembro)
        Me.Controls.Add(Me.txtNovembro)
        Me.Controls.Add(Me.txtOutubro)
        Me.Controls.Add(Me.txtSetembro)
        Me.Controls.Add(Me.txtAgosto)
        Me.Controls.Add(Me.txtJulho)
        Me.Controls.Add(Me.txtJunho)
        Me.Controls.Add(Me.txtMaio)
        Me.Controls.Add(Me.txtAbril)
        Me.Controls.Add(Me.txtMarco)
        Me.Controls.Add(Me.txtFevereiro)
        Me.Controls.Add(Me.txtJaneiro)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.cmbTipoGrafico)
        Me.Controls.Add(Me.cmbFonteGrafico)
        Me.Controls.Add(Me.btnGeraGrafico)
        Me.Controls.Add(Me.ChartGrafico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGraficos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gráficos"
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChartGrafico As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnGeraGrafico As System.Windows.Forms.Button
    Friend WithEvents cmbFonteGrafico As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoGrafico As System.Windows.Forms.ComboBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtJaneiro As System.Windows.Forms.TextBox
    Friend WithEvents txtFevereiro As System.Windows.Forms.TextBox
    Friend WithEvents txtMarco As System.Windows.Forms.TextBox
    Friend WithEvents txtAbril As System.Windows.Forms.TextBox
    Friend WithEvents txtMaio As System.Windows.Forms.TextBox
    Friend WithEvents txtJunho As System.Windows.Forms.TextBox
    Friend WithEvents txtJulho As System.Windows.Forms.TextBox
    Friend WithEvents txtAgosto As System.Windows.Forms.TextBox
    Friend WithEvents txtSetembro As System.Windows.Forms.TextBox
    Friend WithEvents txtOutubro As System.Windows.Forms.TextBox
    Friend WithEvents txtNovembro As System.Windows.Forms.TextBox
    Friend WithEvents txtDezembro As System.Windows.Forms.TextBox
    Friend WithEvents lbFonteGrafico As System.Windows.Forms.Label
    Friend WithEvents lbAno As System.Windows.Forms.Label
    Friend WithEvents lbTipoGrafico As System.Windows.Forms.Label
    Friend WithEvents cmbDesignGrafico As System.Windows.Forms.ComboBox
    Friend WithEvents lbDesignGrafico As System.Windows.Forms.Label
    Friend WithEvents btnSalvarGrafico As System.Windows.Forms.Button
    Friend WithEvents btnFecharForm As System.Windows.Forms.Button
End Class
