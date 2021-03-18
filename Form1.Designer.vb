<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSMTP = New System.Windows.Forms.TextBox()
        Me.txtPorta = New System.Windows.Forms.TextBox()
        Me.txrSenha = New System.Windows.Forms.TextBox()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.btnSair)
        Me.GroupBox.Controls.Add(Me.btnEnviar)
        Me.GroupBox.Controls.Add(Me.txtMensagem)
        Me.GroupBox.Controls.Add(Me.txtAssunto)
        Me.GroupBox.Controls.Add(Me.txrSenha)
        Me.GroupBox.Controls.Add(Me.txtPorta)
        Me.GroupBox.Controls.Add(Me.txtSMTP)
        Me.GroupBox.Controls.Add(Me.txtEmail)
        Me.GroupBox.Controls.Add(Me.txtDisplay)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(505, 300)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = false
        Me.GroupBox.Text = "Configuração"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Display:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(37, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(34, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SMTP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(40, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Porta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(34, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Senha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(27, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Assunto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(13, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mensagem:"
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(81, 28)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(234, 20)
        Me.txtDisplay.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(81, 52)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(394, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtSMTP
        '
        Me.txtSMTP.Location = New System.Drawing.Point(81, 75)
        Me.txtSMTP.Name = "txtSMTP"
        Me.txtSMTP.Size = New System.Drawing.Size(394, 20)
        Me.txtSMTP.TabIndex = 9
        '
        'txtPorta
        '
        Me.txtPorta.Location = New System.Drawing.Point(81, 97)
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(122, 20)
        Me.txtPorta.TabIndex = 10
        '
        'txrSenha
        '
        Me.txrSenha.Location = New System.Drawing.Point(81, 119)
        Me.txrSenha.Name = "txrSenha"
        Me.txrSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txrSenha.Size = New System.Drawing.Size(122, 20)
        Me.txrSenha.TabIndex = 11
        '
        'txtAssunto
        '
        Me.txtAssunto.Location = New System.Drawing.Point(81, 142)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(394, 20)
        Me.txtAssunto.TabIndex = 12
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(81, 165)
        Me.txtMensagem.Multiline = true
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagem.Size = New System.Drawing.Size(394, 98)
        Me.txtMensagem.TabIndex = 13
        '
        'btnEnviar
        '
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEnviar.Location = New System.Drawing.Point(400, 269)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 14
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = true
        '
        'btnSair
        '
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSair.Location = New System.Drawing.Point(319, 269)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 15
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 317)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox.ResumeLayout(false)
        Me.GroupBox.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents btnSair As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtMensagem As TextBox
    Friend WithEvents txtAssunto As TextBox
    Friend WithEvents txrSenha As TextBox
    Friend WithEvents txtPorta As TextBox
    Friend WithEvents txtSMTP As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
