<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Princial_03
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.SystemColors.Control
        Me.btnClick.CausesValidation = False
        Me.btnClick.Location = New System.Drawing.Point(116, 174)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(326, 23)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Texto Botão"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'lbl_NomeProjeto
        '
        Me.lbl_NomeProjeto.AutoSize = True
        Me.lbl_NomeProjeto.Location = New System.Drawing.Point(12, 20)
        Me.lbl_NomeProjeto.Name = "lbl_NomeProjeto"
        Me.lbl_NomeProjeto.Size = New System.Drawing.Size(63, 13)
        Me.lbl_NomeProjeto.TabIndex = 2
        Me.lbl_NomeProjeto.Text = "Texto Label"
        '
        'Frm_Princial_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 351)
        Me.Controls.Add(Me.lbl_NomeProjeto)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Frm_Princial_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents lbl_NomeProjeto As Label

End Class
