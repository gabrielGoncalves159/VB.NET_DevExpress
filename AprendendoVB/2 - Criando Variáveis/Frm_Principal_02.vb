Public Class Frm_Principal_02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnNumerosInteiros(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim idade As Integer
        idade = 12

        MsgBox("O valor da idade é: " + idade.ToString, MsgBoxStyle.Exclamation)

        idade = 12 * 5
        MsgBox($"O valor da idade multiplicado por 5 é {idade}", MsgBoxStyle.Information)

        idade = (12 * 5) + 10
        MsgBox($"O valor da iadde multiplicado por 5 e somado a 10 é {idade}", MsgBoxStyle.Critical)

    End Sub

    Private Sub btnNumerosDoubles(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Double

        valor = 9.5
        MsgBox($"A variável valor é igual a {valor}", MsgBoxStyle.Exclamation)

        valor = 5 / 2
        MsgBox($"A variável valor 5 / 2 é {valor}", MsgBoxStyle.Information)

        valor = 2
        MsgBox($"A variável valor é igual a {valor}", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub btnConversaoNumeros_Click(sender As Object, e As EventArgs) Handles btnConversaoNumeros.Click
        Dim SalarioPrincipal As Double = 1500.56
        MsgBox($"O valor do salario principal é {SalarioPrincipal}", MsgBoxStyle.Exclamation)

        Dim SalarioInteiro As Integer = 1500.56
        MsgBox($"O valor do salario principal é {SalarioInteiro}", MsgBoxStyle.Exclamation)

        Dim valorLong As Long = 1500000000000000000
        MsgBox($"O valor do valor long é {valorLong}", MsgBoxStyle.Exclamation)

        Dim valorInteger As Integer = 1500000000
        MsgBox($"O valor do valor integer é {valorInteger}", MsgBoxStyle.Exclamation)

        Dim valorShort As Short = 15000
        MsgBox($"O valor do valor short é {valorShort}", MsgBoxStyle.Exclamation)

        Dim valorDouble As Double = 1500.560545465 * 2
        MsgBox($"O valor do valor double é {valorDouble}", MsgBoxStyle.Exclamation)

        Dim valorDecimal As Decimal = 1500.560545465 * 2
        MsgBox($"O valor do valor decimal é {valorDecimal}", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub ButtonCalculo_Click(sender As Object, e As EventArgs) Handles ButtonCalculo.Click

        Dim numerador As Decimal
        Dim denominador As Decimal

        numerador = txtNumerador.Text
        denominador = txtDenominador.Text

        Dim resultadoDecimal As Decimal
        resultadoDecimal = numerador / denominador

        Dim resultadoDouble As Double
        resultadoDouble = numerador / denominador

        txtResultadoDecimal.Text = resultadoDecimal
        txtResultadoDouble.Text = resultadoDouble

        'MsgBox($"O valor da divisao de {numerador} por {denominador} é "
        '    + resultado.ToString, MsgBoxStyle.Exclamation)



    End Sub
End Class
