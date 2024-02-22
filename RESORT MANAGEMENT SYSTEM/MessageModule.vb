Public Class MessageModule
    Public Sub Initializer()
        Call MailModule()
        Call SMSModule()

    End Sub
    Private Sub MessageModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub MailModule()
        Page_Email.Controls.Clear()
        E_Mail = New Mail
        With E_Mail
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_Email.Controls.Add(E_Mail)
    End Sub
    Private Sub SMSModule()
        Page_SMS.Controls.Clear()
        s_m_s = New SMS
        With s_m_s
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_SMS.Controls.Add(s_m_s)
    End Sub
End Class
