Public Class TermsAndConditions
    Private Sub TermsAndConditions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_agree.Checked = False
        panel_controls.Height = 0
        btn_proceed.Enabled = False
    End Sub

    Private Sub chk_agree_CheckedChanged(sender As Object, e As EventArgs) Handles chk_agree.CheckedChanged
        If (chk_agree.Checked = True) Then
            btn_proceed.Enabled = True
        ElseIf (chk_agree.Checked = False) Then
            btn_proceed.Enabled = False
        End If
    End Sub
    Dim Scrolled_To_Bottom As Boolean = False
    Private Sub lst_termsandconditions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_termsandconditions.SelectedIndexChanged
        Dim RowVisible As Integer = lst_termsandconditions.ClientSize.Height / lst_termsandconditions.ItemHeight
        If (lst_termsandconditions.TopIndex >= lst_termsandconditions.Items.Count - RowVisible - 1) Then
            ' lst_termsandconditions.TopIndex = lst_termsandconditions.Items.Count - 1
            Timer1.Start()
        Else
            Timer1.Stop()
            panel_controls.Height = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (panel_controls.Height <= 100) Then
            panel_controls.Height += 3
        End If
        If (panel_controls.Height >= 100) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub btn_proceed_Click(sender As Object, e As EventArgs) Handles btn_proceed.Click
        Form4.Panel_Holder.Controls.Clear()
        Form4.Close()
        '
        '||MAIN SYSTEM
        '
        Form1.Show()
        Form1.Text = "HomePage"
        Form1.Location = New Point(250, 100)
        Form1.Size = New Size(width:=1067, height:=713)
    End Sub
End Class
