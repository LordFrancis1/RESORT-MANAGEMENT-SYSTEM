Public Class ShutDown
    Dim Counter As Integer
    Private Sub ShutDown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Prg_ShuttingDown.AutoStart = True
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Counter += 1
        If (Counter >= 40) Then
            Prg_ShuttingDown.AutoStart = False
            If (Counter >= 50) Then
                Application.Exit()
            End If
        End If
    End Sub
End Class
