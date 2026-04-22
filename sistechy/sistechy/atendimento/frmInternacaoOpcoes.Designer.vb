<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternacaoOpcoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternacaoOpcoes))
        Me.btnCadastrarNovoLeito = New System.Windows.Forms.Button()
        Me.btnInternarAnimal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCadastrarNovoLeito
        '
        Me.btnCadastrarNovoLeito.BackColor = System.Drawing.Color.White
        Me.btnCadastrarNovoLeito.BackgroundImage = Global.sistechy.My.Resources.Resources.cadastrar_novo_leito_fw
        Me.btnCadastrarNovoLeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastrarNovoLeito.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCadastrarNovoLeito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastrarNovoLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCadastrarNovoLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarNovoLeito.Location = New System.Drawing.Point(28, 16)
        Me.btnCadastrarNovoLeito.Name = "btnCadastrarNovoLeito"
        Me.btnCadastrarNovoLeito.Size = New System.Drawing.Size(329, 57)
        Me.btnCadastrarNovoLeito.TabIndex = 1
        Me.btnCadastrarNovoLeito.UseVisualStyleBackColor = False
        '
        'btnInternarAnimal
        '
        Me.btnInternarAnimal.BackColor = System.Drawing.Color.White
        Me.btnInternarAnimal.BackgroundImage = Global.sistechy.My.Resources.Resources.internar_animal_fw
        Me.btnInternarAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInternarAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInternarAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnInternarAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnInternarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInternarAnimal.Location = New System.Drawing.Point(28, 79)
        Me.btnInternarAnimal.Name = "btnInternarAnimal"
        Me.btnInternarAnimal.Size = New System.Drawing.Size(329, 57)
        Me.btnInternarAnimal.TabIndex = 2
        Me.btnInternarAnimal.UseVisualStyleBackColor = False
        '
        'frmInternacaoOpcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(385, 153)
        Me.Controls.Add(Me.btnCadastrarNovoLeito)
        Me.Controls.Add(Me.btnInternarAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInternacaoOpcoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecione uma opção"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInternarAnimal As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarNovoLeito As System.Windows.Forms.Button
End Class
