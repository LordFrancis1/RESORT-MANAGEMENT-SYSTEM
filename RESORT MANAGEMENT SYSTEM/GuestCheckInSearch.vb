Imports System.Data.SqlClient

Public Class GuestCheckInSearch
    Public Sub Initializer()
        Lbl_Inform.Left = Panel_Slide.Right
        Timer1.Start()
        Call Checkin_Form()

    End Sub
    Private Sub GuestCheckInSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Form5.Dispose()
    End Sub
    Private Sub Checkin_Form()
        CheckInForm = New GuestCheckinForm
        With CheckInForm
            .Dock = DockStyle.Fill
            .Initializer()
            .Disable_Ctrls()
        End With
        Panel_Holder.Controls.Add(CheckInForm)
    End Sub
    Private Sub Txt_Contact_TextChanged(sender As Object, e As EventArgs)
        If (Txt_ContactSearch.Text.Length = 10) Then
            Using conn As New SqlConnection(CONNECTION)
                If (conn.State <> ConnectionState.Open) Then
                    conn.Open()
                End If
                Using Command As New SqlCommand("SELECT * FROM [GuestIn] WHERE Contact = @Contact", conn)
                    Try
                        With Command
                            .Parameters.Add("@Contact", SqlDbType.Int).Value = CInt(Txt_ContactSearch.Text)
                            .ExecuteNonQuery()
                        End With
                    Catch ex As SqlException
                        MsgBox(ex.Message, vbCritical)
                    End Try
                    Using Reader As SqlDataReader = Command.ExecuteReader()
                        While Reader.Read
                            If (Reader(3) = CInt(Txt_ContactSearch.Text)) Then
                                CheckInForm.Txt_Name.Text = Trim(Reader(1))
                                CheckInForm.Txt_Email.Text = Trim(Reader(2))
                                CheckInForm.Txt_Contact.Text = "0" & Reader(3)
                            Else
                                MsgBox("Sorry,the guest details are not in the database.Try again.", vbCritical)
                            End If
                        End While
                    End Using
                End Using
            End Using
            Txt_ContactSearch.Clear()
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Txt_ContactSearch.Clear()
        CheckInForm.Enable_Ctrls()
        CheckInForm.Clear_Ctrls()
        CheckInForm.Disable_Ctrls()
        Timer1.Start()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If (CheckInForm.Txt_Name.Text = "" Or CheckInForm.Txt_Email.Text = "" Or CheckInForm.Txt_Contact.Text = "" Or CheckInForm.Cmb_GuestType.Text = CheckInForm.Cmb_GuestType.Items(0) Or CheckInForm.Txt_NumberOfPeople.Text = "" Or CheckInForm.Txt_Duration.Text = "") Then
            MsgBox("Ensure all fields are filled to proceed.", vbCritical)
        Else
            CheckInForm.Enable_Ctrls()
            Call CheckIn.CheckIn_Guest()
            CheckInForm.Disable_Ctrls()
        End If
    End Sub
    '
    'TIMER VISUAL EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (CheckInForm.Txt_Contact.Text = "") Then
            If (Lbl_Inform.Right >= Panel_Slide.Left) Then
                Lbl_Inform.Left -= 2
            Else
                Lbl_Inform.Left = Panel_Slide.Right
            End If
        Else
            Lbl_Inform.Left = Panel_Slide.Right
            Timer1.Stop()
        End If
    End Sub
End Class
