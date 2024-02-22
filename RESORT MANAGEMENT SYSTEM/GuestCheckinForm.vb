Public Class GuestCheckinForm
    Public Sub Initializer()
        Call Clear_Ctrls()
        Lbl_Inform.Left = Panel_Slide.Right
        Timer1.Start()

    End Sub
    Private Sub GuestCheckinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Clear_Ctrls()
        Txt_Name.Clear()
        Txt_Email.Clear()
        Txt_Contact.Clear()
        Cmb_GuestType.Text = Cmb_GuestType.Items(0)
        Dat_DateOfArrival.Value = Date.Today
        Txt_NumberOfPeople.Clear()
        Txt_Duration.Clear()
        Txt_CustomerEnquiry.Clear()
    End Sub
    Public Sub Enable_Ctrls()
        Txt_Name.Enabled = True
        Txt_Email.Enabled = True
        Txt_Contact.Enabled = True
    End Sub
    Public Sub Disable_Ctrls()
        Txt_Name.Enabled = False
        Txt_Email.Enabled = False
        Txt_Contact.Enabled = False
    End Sub
    '
    'TIMER VISUAL EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_Inform.Right >= Panel_Slide.Left) Then
            Lbl_Inform.Left -= 1
        Else
            Lbl_Inform.Left = Panel_Slide.Right
        End If
    End Sub
End Class
