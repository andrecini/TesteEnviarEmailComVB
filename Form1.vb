Imports System.Net
Imports System.Net.Mail

Public Class Form1
    Private Function EnviarEmail(ByVal strDestino As string, ByVal strNome As String) As Boolean
        Dim objEnvio As SmtpClient = Nothing
        Dim objEmail As MailMessage = Nothing

        Dim blnRetorno As Boolean = False

        Try
            objEnvio = New SmtpClient(txtSMTP.Text, txtPorta.Text)
            objEmail = New MailMessage

            'Email destino:
            objEmail.To.Add(New MailAddress(strDestino, strNome))
            
            'Email remetente:
            objEmail.From = New MailAddress(txtEmail.Text, txtDisplay.Text)

            'Define Assunto
            objEmail.Subject = txtAssunto.Text

            'Define Prioridade
            objEmail.Priority = MailPriority.High

            'Define configuração de leitura
            objEmail.Headers.Add("Disposition-Notification-To ", txtEmail.Text)

            'Define mensagem de texto
            Dim mensagem As AlternateView = AlternateView.CreateAlternateViewFromString(txtMensagem.Text, _
                                                                                                 Nothing, _
                                                                            Mime.MediaTypeNames.Text.Plain)
            objEmail.AlternateViews.Add(mensagem)
            'Define credenciais
            Dim credencial As New NetworkCredential(txtEmail.Text, txrSenha.Text)
            objEnvio.Send(objEmail)

            'Define Retorno
            blnRetorno = True

            MessageBox.Show("Email enviado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objEmail = Nothing
            objEnvio = Nothing
        End Try

        Return blnRetorno
    End Function

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        EnviarEmail(txtEmail.Text, "André")
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Hide()
    End Sub
End Class
