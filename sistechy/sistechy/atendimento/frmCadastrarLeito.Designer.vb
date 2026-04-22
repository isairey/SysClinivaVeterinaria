<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarLeito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarLeito))
        Me.lbCodigoLeito = New System.Windows.Forms.Label()
        Me.lbPorteLeito = New System.Windows.Forms.Label()
        Me.txtCodLeito = New System.Windows.Forms.TextBox()
        Me.cmbPorteLeito = New System.Windows.Forms.ComboBox()
        Me.lbEmUso = New System.Windows.Forms.Label()
        Me.txtStatusLeito = New System.Windows.Forms.TextBox()
        Me.pbxBanner = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastrarLeito = New System.Windows.Forms.Button()
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCodigoLeito
        '
        resources.ApplyResources(Me.lbCodigoLeito, "lbCodigoLeito")
        Me.lbCodigoLeito.Name = "lbCodigoLeito"
        '
        'lbPorteLeito
        '
        resources.ApplyResources(Me.lbPorteLeito, "lbPorteLeito")
        Me.lbPorteLeito.Name = "lbPorteLeito"
        '
        'txtCodLeito
        '
        resources.ApplyResources(Me.txtCodLeito, "txtCodLeito")
        Me.txtCodLeito.Name = "txtCodLeito"
        '
        'cmbPorteLeito
        '
        Me.cmbPorteLeito.FormattingEnabled = True
        resources.ApplyResources(Me.cmbPorteLeito, "cmbPorteLeito")
        Me.cmbPorteLeito.Name = "cmbPorteLeito"
        '
        'lbEmUso
        '
        resources.ApplyResources(Me.lbEmUso, "lbEmUso")
        Me.lbEmUso.Name = "lbEmUso"
        '
        'txtStatusLeito
        '
        resources.ApplyResources(Me.txtStatusLeito, "txtStatusLeito")
        Me.txtStatusLeito.Name = "txtStatusLeito"
        '
        'pbxBanner
        '
        Me.pbxBanner.BackgroundImage = Global.sistechy.My.Resources.Resources.banner_cadastrar_leito_fw
        resources.ApplyResources(Me.pbxBanner, "pbxBanner")
        Me.pbxBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxBanner.Name = "pbxBanner"
        Me.pbxBanner.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BackgroundImage = Global.sistechy.My.Resources.Resources.cancelar_fw
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCadastrarLeito
        '
        Me.btnCadastrarLeito.BackColor = System.Drawing.Color.White
        Me.btnCadastrarLeito.BackgroundImage = Global.sistechy.My.Resources.Resources.salva_cadastro_fw
        resources.ApplyResources(Me.btnCadastrarLeito, "btnCadastrarLeito")
        Me.btnCadastrarLeito.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastrarLeito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastrarLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastrarLeito.Name = "btnCadastrarLeito"
        Me.btnCadastrarLeito.UseVisualStyleBackColor = False
        '
        'frmCadastrarLeito
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.pbxBanner)
        Me.Controls.Add(Me.txtStatusLeito)
        Me.Controls.Add(Me.lbEmUso)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCadastrarLeito)
        Me.Controls.Add(Me.cmbPorteLeito)
        Me.Controls.Add(Me.txtCodLeito)
        Me.Controls.Add(Me.lbPorteLeito)
        Me.Controls.Add(Me.lbCodigoLeito)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadastrarLeito"
        CType(Me.pbxBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCodigoLeito As System.Windows.Forms.Label
    Friend WithEvents lbPorteLeito As System.Windows.Forms.Label
    Friend WithEvents txtCodLeito As System.Windows.Forms.TextBox
    Friend WithEvents cmbPorteLeito As System.Windows.Forms.ComboBox
    Friend WithEvents btnCadastrarLeito As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lbEmUso As System.Windows.Forms.Label
    Friend WithEvents txtStatusLeito As System.Windows.Forms.TextBox
    Friend WithEvents pbxBanner As System.Windows.Forms.PictureBox
End Class
