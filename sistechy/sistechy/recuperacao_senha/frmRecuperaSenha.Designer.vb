<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperaSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperaSenha))
        Me.lbTexto1 = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbTexto2 = New System.Windows.Forms.Label()
        Me.btnEntendi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbTexto1
        '
        Me.lbTexto1.AutoSize = True
        Me.lbTexto1.Location = New System.Drawing.Point(12, 9)
        Me.lbTexto1.Name = "lbTexto1"
        Me.lbTexto1.Size = New System.Drawing.Size(173, 13)
        Me.lbTexto1.TabIndex = 1
        Me.lbTexto1.Text = "Uma nova senha foi enviada para: "
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Location = New System.Drawing.Point(12, 41)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(31, 13)
        Me.lbEmail.TabIndex = 2
        Me.lbEmail.Text = "email"
        '
        'lbTexto2
        '
        Me.lbTexto2.AutoSize = True
        Me.lbTexto2.Location = New System.Drawing.Point(12, 73)
        Me.lbTexto2.Name = "lbTexto2"
        Me.lbTexto2.Size = New System.Drawing.Size(228, 13)
        Me.lbTexto2.TabIndex = 3
        Me.lbTexto2.Text = "Verifique sua caixa de entrada e/ou sua lixeira!"
        '
        'btnEntendi
        '
        Me.btnEntendi.Location = New System.Drawing.Point(165, 99)
        Me.btnEntendi.Name = "btnEntendi"
        Me.btnEntendi.Size = New System.Drawing.Size(75, 23)
        Me.btnEntendi.TabIndex = 4
        Me.btnEntendi.Text = "Entendi!"
        Me.btnEntendi.UseVisualStyleBackColor = True
        '
        'frmRecuperaSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(253, 135)
        Me.Controls.Add(Me.btnEntendi)
        Me.Controls.Add(Me.lbTexto2)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbTexto1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecuperaSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbTexto1 As System.Windows.Forms.Label
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents lbTexto2 As System.Windows.Forms.Label
    Friend WithEvents btnEntendi As System.Windows.Forms.Button
End Class
