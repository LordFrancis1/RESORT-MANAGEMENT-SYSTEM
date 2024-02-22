Public Class PrintTypeQuery
    Public Sub Initializer()
        Rb_Booking.Checked = False
        Rb_Restaurant.Checked = False
        Rb_General.Checked = False
    End Sub
    Private Sub PrintTypeQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Form4.Dispose()
    End Sub
    Private Sub Rb_Booking_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Booking.CheckedChanged
        ReceiptType = Trim(Lbl_Booking.Text)
    End Sub
    Private Sub Rb_Restaurant_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Restaurant.CheckedChanged
        ReceiptType = Trim(Lbl_Restaurant.Text)
    End Sub
    Private Sub Rb_General_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_General.CheckedChanged
        ReceiptType = Trim(Lbl_General.Text)
    End Sub
    Private Sub Btn_Proceed_Click(sender As Object, e As EventArgs) Handles Btn_Proceed.Click
        If (Rb_Booking.Checked <> False Or Rb_Restaurant.Checked <> False Or Rb_General.Checked <> False) Then
            Form4.Dispose()
            Form5.Panel_Holder.Controls.Clear()
            Print = New PrintModule
            With Print
                .Dock = DockStyle.Fill
                .Initializer()
            End With
            Form5.Text = "Print Operations..."
            Form5.WindowState = FormWindowState.Maximized
            ' Form5.Size = Print.Size
            Form5.Panel_Holder.Controls.Add(Print)
            Form5.ShowDialog()
        Else
            MsgBox("Kindly make a selection you wish to generate receipt.", vbCritical)

        End If
    End Sub
End Class
