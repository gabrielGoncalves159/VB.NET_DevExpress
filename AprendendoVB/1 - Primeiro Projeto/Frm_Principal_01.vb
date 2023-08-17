Public Class Frm_TelaPrincipal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        MsgBox("Hello, World!!!", MsgBoxStyle.Critical, "Mensagem Teste")

    End Sub
End Class
