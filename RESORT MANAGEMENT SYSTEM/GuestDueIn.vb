Imports System.Data.SqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class GuestDueIn
    Dim RoomPrice As Decimal

    Public Sub Initializer()
        Call DueInGuests()
        Call Clear_Ctrls()
        Lbl_Inform.Left = Panel_Slide.Right
        Timer1.Start()

    End Sub
    Private Sub GuestDueIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub DueInGuests()
        FLP_Display.Controls.Clear()
        FLP_Display.Controls.Add(Panel_TotalDueIns)

        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT COUNT(*) FROM [GuestDueIn]", conn)
                Lbl_TotalGuests1.Text = Command.ExecuteScalar() & " Expected Guest(s)."
            End Using
        End Using

        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [GuestDueIn] ORDER BY SerialNumber ASC", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        GradientButton = New Guna.UI2.WinForms.Guna2GradientButton
                        With GradientButton
                            .Size = New Size(260, 140)
                            .Name = Reader(0)
                            .Image = HotelLogo
                            .ImageSize = New Size(70, 60)
                            .ImageAlign = ContentAlignment.MiddleCenter
                            .Text = vbNewLine & StrConv(Trim(Reader(1)), VbStrConv.ProperCase) & vbNewLine & "Due On : " & CDate(Reader(5)).ToShortDateString()
                            .TextAlign = ContentAlignment.MiddleCenter
                            .Anchor = AnchorStyles.Left
                            .Animated = True
                            .BackColor = Color.Transparent
                            .BorderRadius = 5
                            .BorderThickness = 2
                            .BorderColor = Color.FromArgb(33, 42, 57)
                            .Cursor = Cursors.Hand
                            .ForeColor = Color.FromArgb(33, 42, 57)
                            .FillColor = Color.Transparent
                            .FillColor2 = Color.Transparent
                            .Font = New Font("Garamond", 15, FontStyle.Regular)
                            .HoverState.BorderColor = Color.White
                            .HoverState.ForeColor = Color.FromArgb(255, 192, 128)
                            .HoverState.FillColor = Color.FromArgb(33, 42, 57)
                            .HoverState.FillColor2 = Color.FromArgb(33, 42, 57)
                            .HoverState.Font = New Font("Garamond", 16, FontStyle.Regular)
                            .PressedColor = Color.White
                            .ShadowDecoration.Color = Color.FromArgb(33, 42, 57)
                            .ShadowDecoration.Depth = 30
                            .UseTransparentBackground = True
                        End With
                        AddHandler GradientButton.Click, AddressOf Me.DueInGuest_Click
                        Me.Controls.Add(GradientButton)
                        FLP_Display.Controls.Add(GradientButton)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub DueInGuest_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
        Form4.Panel_Holder.Controls.Clear()
        GuestDueInSub = New GuestDueInDialog
        With GuestDueInSub
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form4.Text = " Guest Due In Report"
        Form4.Size = GuestDueInSub.Size
        Form4.Panel_Holder.Controls.Add(GuestDueInSub)
        Form4.ShowDialog()
    End Sub
    Private Sub Clear_Ctrls()
        Txt_Name.Clear()
        Txt_Email.Clear()
        Txt_Contact.Clear()
        Cmb_EnquiryType.Text = Cmb_EnquiryType.Items(0)
        Dat_DateOfArrival.Value = Date.Today
        Txt_NumberOfPeople.Clear()
        Txt_Duration.Clear()
        Txt_CustomerEnquiry.Clear()
        Cmb_RoomType.Text = Cmb_RoomType.Items(0)
    End Sub
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Call Clear_Ctrls()
    End Sub
    '
    '||DUE IN GUEST
    '
    Private Sub Cmb_RoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_RoomType.SelectedIndexChanged
        If (Cmb_RoomType.Text <> Cmb_RoomType.Items(0)) Then
            Using conn As New SqlConnection(CONNECTION)
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If
                Using Command As New SqlCommand("SELECT * FROM [HotelRoom]", conn)
                    Using Reader As SqlDataReader = Command.ExecuteReader
                        While Reader.Read
                            If (Trim(Reader(1)) = Trim(Cmb_RoomType.Text)) Then
                                RoomPrice = Reader(4)
                            Else
                                MsgBox("Type of room selected is not yet updated.Kindly pick another.", vbCritical)
                                Cmb_RoomType.Text = Cmb_RoomType.Items(0)
                            End If
                        End While
                    End Using
                End Using
            End Using
        End If
    End Sub
    Private Sub Generate_SNo()
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(SerialNumber) FROM [GuestDueIn]", conn)
                Dim TempHolder_SerialNumber As String = Command.ExecuteScalar().ToString()
                If (TempHolder_SerialNumber = "") Then
                    DueInGuestSerialNumber = 1
                ElseIf (TempHolder_SerialNumber <> "") Then
                    DueInGuestSerialNumber = Command.ExecuteScalar()
                    Do While (GuestSerialNumber <= 10000000)
                        DueInGuestSerialNumber += 1
                        Exit Do
                    Loop
                End If
            End Using
        End Using
    End Sub
    Private Sub Submit()
        Call Generate_SNo()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("INSERT INTO [GuestDueIn] (SerialNumber, Name, Email, Contact, GuestType, ExpectedArrivalDate, ExpectedStayDuration, ExpectedDepartureDate, NumberOfPeople, Enquiries, RoomType, DueAmount) VALUES (@SerialNumber, @Name, @Email, @Contact, @GuestType, @ExpectedArrivalDate, @ExpectedStayDuration, @ExpectedDepartureDate, @NumberOfPeople, @Enquiries, @RoomType, @DueAmount)", conn)
                Try
                    With Command
                        .Parameters.Add("@SerialNumber", SqlDbType.Int).Value = DueInGuestSerialNumber
                        .Parameters.Add("@Name", SqlDbType.VarChar).Value = Txt_Name.Text
                        .Parameters.Add("@Email", SqlDbType.VarChar).Value = Txt_Email.Text
                        .Parameters.Add("@Contact", SqlDbType.Int).Value = CInt(Txt_Contact.Text)
                        .Parameters.Add("@GuestType", SqlDbType.VarChar).Value = Cmb_EnquiryType.Text
                        .Parameters.Add("@ExpectedArrivalDate", SqlDbType.DateTime).Value = Dat_DateOfArrival.Value
                        .Parameters.Add("@ExpectedStayDuration", SqlDbType.Int).Value = Txt_Duration.Text
                        .Parameters.Add("@ExpectedDepartureDate", SqlDbType.DateTime).Value = Dat_DateOfArrival.Value.AddDays(CInt(Txt_Duration.Text))
                        .Parameters.Add("@NumberOfPeople", SqlDbType.Int).Value = Txt_NumberOfPeople.Text
                        .Parameters.Add("@Enquiries", SqlDbType.VarChar).Value = Txt_CustomerEnquiry.Text
                        .Parameters.Add("@RoomType", SqlDbType.VarChar).Value = Cmb_RoomType.Text
                        .Parameters.Add("@DueAmount", SqlDbType.Decimal).Value = Val(RoomPrice * CInt(Txt_Duration.Text))
                        .ExecuteNonQuery()
                        MsgBox("Due In Guest Saved.", vbInformation)
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
            End Using
        End Using
        Call Clear_Ctrls()
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If (Txt_Name.Text = "" Or Txt_Email.Text = "" Or Txt_Contact.Text = "" Or Cmb_EnquiryType.Text = Cmb_EnquiryType.Items(0) Or Txt_NumberOfPeople.Text = "" Or Txt_Duration.Text = "") Then
            MsgBox("Ensure all fields are filled to proceed.", vbCritical)
        Else
            Call Submit()
            Call DueInGuests()
        End If
    End Sub
    '
    '||TIMER EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_Inform.Right >= Panel_Slide.Left) Then
            Lbl_Inform.Left -= 2
        Else
            Lbl_Inform.Left = Panel_Slide.Right
        End If
    End Sub

End Class
