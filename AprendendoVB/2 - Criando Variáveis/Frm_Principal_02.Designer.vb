<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_02
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConversaoNumeros = New System.Windows.Forms.Button()
        Me.txtNumerador = New System.Windows.Forms.TextBox()
        Me.txtDenominador = New System.Windows.Forms.TextBox()
        Me.ButtonCalculo = New System.Windows.Forms.Button()
        Me.txtResultadoDouble = New System.Windows.Forms.TextBox()
        Me.txtResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.SystemColors.Control
        Me.btnClick.CausesValidation = False
        Me.btnClick.Location = New System.Drawing.Point(33, 53)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(130, 61)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Exemplo Números Inteiros"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "2 - Criando Variável"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.CausesValidation = False
        Me.Button1.Location = New System.Drawing.Point(33, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 61)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exemplo Números Ponto Flutuante"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnConversaoNumeros
        '
        Me.btnConversaoNumeros.BackColor = System.Drawing.SystemColors.Control
        Me.btnConversaoNumeros.CausesValidation = False
        Me.btnConversaoNumeros.Location = New System.Drawing.Point(33, 194)
        Me.btnConversaoNumeros.Name = "btnConversaoNumeros"
        Me.btnConversaoNumeros.Size = New System.Drawing.Size(130, 61)
        Me.btnConversaoNumeros.TabIndex = 3
        Me.btnConversaoNumeros.Text = "Exemplo de Conversão de Números"
        Me.btnConversaoNumeros.UseVisualStyleBackColor = False
        '
        'txtNumerador
        '
        Me.txtNumerador.Location = New System.Drawing.Point(282, 74)
        Me.txtNumerador.Name = "txtNumerador"
        Me.txtNumerador.Size = New System.Drawing.Size(154, 20)
        Me.txtNumerador.TabIndex = 4
        '
        'txtDenominador
        '
        Me.txtDenominador.Location = New System.Drawing.Point(282, 100)
        Me.txtDenominador.Name = "txtDenominador"
        Me.txtDenominador.Size = New System.Drawing.Size(154, 20)
        Me.txtDenominador.TabIndex = 5
        '
        'ButtonCalculo
        '
        Me.ButtonCalculo.Location = New System.Drawing.Point(282, 126)
        Me.ButtonCalculo.Name = "ButtonCalculo"
        Me.ButtonCalculo.Size = New System.Drawing.Size(154, 23)
        Me.ButtonCalculo.TabIndex = 6
        Me.ButtonCalculo.Text = "Calcular"
        Me.ButtonCalculo.UseVisualStyleBackColor = True
        '
        'txtResultadoDouble
        '
        Me.txtResultadoDouble.Location = New System.Drawing.Point(282, 259)
        Me.txtResultadoDouble.Name = "txtResultadoDouble"
        Me.txtResultadoDouble.Size = New System.Drawing.Size(233, 20)
        Me.txtResultadoDouble.TabIndex = 8
        '
        'txtResultadoDecimal
        '
        Me.txtResultadoDecimal.Location = New System.Drawing.Point(282, 215)
        Me.txtResultadoDecimal.Name = "txtResultadoDecimal"
        Me.txtResultadoDecimal.Size = New System.Drawing.Size(233, 20)
        Me.txtResultadoDecimal.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Resultado Decimal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Resultado Double:"
        '
        'Frm_Principal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 382)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtResultadoDouble)
        Me.Controls.Add(Me.txtResultadoDecimal)
        Me.Controls.Add(Me.ButtonCalculo)
        Me.Controls.Add(Me.txtDenominador)
        Me.Controls.Add(Me.txtNumerador)
        Me.Controls.Add(Me.btnConversaoNumeros)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Frm_Principal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnConversaoNumeros As Button
    Friend WithEvents txtNumerador As TextBox
    Friend WithEvents txtDenominador As TextBox
    Friend WithEvents ButtonCalculo As Button
    Friend WithEvents txtResultadoDouble As TextBox
    Friend WithEvents txtResultadoDecimal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
