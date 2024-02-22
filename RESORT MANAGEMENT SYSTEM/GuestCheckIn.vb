Imports System.Data.SqlClient
Imports System.IO

Public Class GuestCheckIn
    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Call Checkin_Form()
        Call Clear_FLPS()
        Call Clear_Progress()
        Call Check_HotelRooms()
        Call RoomsReport()
        Call RoomButtons()
        Call CountRooms()
        Timer1.Start()

    End Sub
    Private Sub Checkin_Form()
        CheckInForm = New GuestCheckinForm
        With CheckInForm
            .Dock = DockStyle.Fill
            .Initializer()
            .Enable_Ctrls()
        End With
        Panel_Holder.Controls.Add(CheckInForm)
    End Sub
    Private Sub Clear_FLPS()
        FLP_Display1.Controls.Clear()
        FLP_Display2.Controls.Clear()
        FLP_RoomButtons.Controls.Clear()
        'FLP_HsKeepingStatus.Controls.Clear()
    End Sub
    Private Sub Clear_Progress()
        Prg_Booked.Value = 0
        Prg_Vacant.Value = 0
        Prg_Cleaned.Value = 0
        Prg_Cleaning.Value = 0
        Prg_Dirty.Value = 0
    End Sub
    Private Sub Check_HotelRooms()
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(RoomNumber) FROM [HotelRoom]", conn)
                Dim RoomNumber As String = Command.ExecuteScalar().ToString()
                If (RoomNumber = "") Then
                    Call Label_Report()
                Else
                    If (Command.ExecuteScalar() = 1) Then
                        Call Gallery1()
                    End If
                End If
            End Using
        End Using
    End Sub
    Private Sub Label_Report()
        FLP_Display1.Controls.Clear()
        linklabel = New LinkLabel
        With linklabel
            .Text = "No Room Photos Available. Click here to add Hotel Rooms."
            .AutoSize = False
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.FromArgb(33, 42, 57)
            .Font = New Font("Garamond", 16, FontStyle.Regular)
            .Size = New Size(650, 250)
            AddHandler linklabel.Click, AddressOf Me.LLbl_AddRoom_Click
        End With
        FLP_Display1.Controls.Add(linklabel)
    End Sub
    Private Sub LLbl_AddRoom_Click(ByVal sender As Object, ByVal e As EventArgs)
        linklabel = sender
        Call Form3.Summon_HouseKeeping()
    End Sub
    Private Sub Gallery1()
        FLP_Display1.Controls.Clear()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [HotelRoom] WHERE RoomNumber ='1'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        ImageButton = New Guna.UI2.WinForms.Guna2ImageButton
                        'Attributes
                        With ImageButton
                            '//NORMAL STATE
                            'Convert from binary to image file
                            Dim Pic As Byte() = Reader(3)
                            Dim stream As New MemoryStream(Pic)
                            .Image = System.Drawing.Image.FromStream(stream)
                            .Size = New Size(300, 260)
                            .ImageSize = New Size(300, 260)
                            .Name = Reader(0)
                            .UseTransparentBackground = True
                            .Anchor = AnchorStyles.Left
                            .BackColor = Color.Transparent
                            .Cursor = Cursors.Hand
                            .ShadowDecoration.Depth = 30
                            .ShadowDecoration.Enabled = True
                            .ShadowDecoration.Color = Color.FromArgb(33, 42, 57)
                            '//HOVER STATE
                            .HoverState.Image = HotelLogo
                            .HoverState.ImageSize = New Size(300, 260)
                            '//PRESSED STATE
                            .PressedState.Image = HotelLogo
                            .PressedState.ImageSize = New Size(64, 64)
                        End With
                        AddHandler ImageButton.Click, AddressOf Me.ImgBtn_RoomPic_Click
                        Me.Controls.Add(ImageButton)
                        FLP_Display1.Controls.Add(ImageButton)
                    End While
                End Using
            End Using
        End Using
        Call AddHolder()
    End Sub
    Private Sub AddHolder()
        FLP = New FlowLayoutPanel
        With FLP
            .Name = "FLP_Display2"
            .FlowDirection = FlowDirection.LeftToRight
            .Size = New Size(380, 260)
            .AutoScroll = True
            .AutoSize = False
            .BackColor = Color.Transparent
        End With
        FLP_Display1.Controls.Add(FLP)
        Call Gallery2()
    End Sub
    Private Sub Gallery2()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [HotelRoom] WHERE NOT RoomNumber ='1'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    Do While Reader.Read
                        ImageButton = New Guna.UI2.WinForms.Guna2ImageButton
                        'Attributes
                        With ImageButton
                            '//NORMAL STATE
                            'Convert from binary to image file
                            Dim Pic As Byte() = Reader(3)
                            Dim stream As New MemoryStream(Pic)
                            .Image = System.Drawing.Image.FromStream(stream)
                            .Size = New Size(170, 124)
                            .ImageSize = New Size(170, 124)
                            .Name = Reader(0)
                            .UseTransparentBackground = True
                            .Anchor = AnchorStyles.Left
                            .BackColor = Color.Transparent
                            .Cursor = Cursors.Hand
                            .ShadowDecoration.Depth = 30
                            .ShadowDecoration.Enabled = True
                            .ShadowDecoration.Color = Color.FromArgb(33, 42, 57)
                            '//HOVER STATE
                            .HoverState.Image = HotelLogo
                            .HoverState.ImageSize = New Size(170, 124)
                            '//PRESSED STATE
                            .PressedState.Image = HotelLogo
                            .PressedState.ImageSize = New Size(64, 64)
                        End With
                        AddHandler ImageButton.Click, AddressOf Me.ImgBtn_RoomPic_Click
                        Me.Controls.Add(ImageButton)
                        FLP.Controls.Add(ImageButton)
                    Loop
                End Using
            End Using
        End Using
    End Sub
    Private Sub ImgBtn_RoomPic_Click(ByVal sender As Object, ByVal e As EventArgs)
        ImageButton = sender
        Call Room_Status()
    End Sub
    Private Sub Room_Status()
        Form4.Panel_Holder.Controls.Clear()
        RoomStatus = New RoomStatusDialog
        With RoomStatus
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form4.Text = "Hotel Room Status"
        Form4.Size = RoomStatus.Size
        Form4.Panel_Holder.Controls.Add(RoomStatus)
        Form4.ShowDialog()
    End Sub
    Private Sub Vacant_Button_Attributes()
        GradientButton = New Guna.UI2.WinForms.Guna2GradientButton
        With GradientButton
            .UseTransparentBackground = True
            .Anchor = AnchorStyles.Left
            .Animated = True
            .BackColor = Color.Transparent
            .BorderRadius = 5
            .BorderThickness = 1
            .BorderColor = Color.FromArgb(33, 42, 57)
            .Cursor = Cursors.Hand
            .Enabled = False
            .DisabledState.BorderColor = Color.FromArgb(33, 42, 57)
            .DisabledState.ForeColor = Color.FromArgb(33, 42, 57)
            .DisabledState.FillColor = Color.Transparent
            .DisabledState.FillColor2 = Color.Transparent
            .ForeColor = Color.FromArgb(33, 42, 57)
            .FillColor = Color.Transparent
            .FillColor2 = Color.Transparent
            .Font = New Font("Trebuchet MS", 11, FontStyle.Regular)
            .HoverState.BorderColor = Color.White
            .HoverState.ForeColor = Color.Black
            .HoverState.FillColor = Color.Gray
            .HoverState.FillColor2 = Color.Gray
            .HoverState.Font = New Font("Trebuchet MS", 11, FontStyle.Regular)
            .PressedColor = Color.FromArgb(33, 42, 57)
            .ShadowDecoration.Color = Color.White
            .ShadowDecoration.Depth = 30
            .Size = New Size(100, 35)
            .TextAlign = HorizontalAlignment.Center
        End With
        ' AddHandler GradientButton .Click, AddressOf Me.RoomBtns_Click
        Me.Controls.Add(GradientButton)
    End Sub
    Private Sub Booked_Button_Attributes()
        GradientButton = New Guna.UI2.WinForms.Guna2GradientButton
        With GradientButton
            .UseTransparentBackground = True
            .Anchor = AnchorStyles.Left
            .Animated = True
            .BackColor = Color.Transparent
            .BorderRadius = 5
            .BorderThickness = 1
            .BorderColor = Color.White
            .Cursor = Cursors.Hand
            .Enabled = False
            .DisabledState.BorderColor = Color.White
            .DisabledState.ForeColor = Color.White
            .DisabledState.FillColor = Color.FromArgb(33, 42, 57)
            .DisabledState.FillColor2 = Color.FromArgb(33, 42, 57)
            .ForeColor = Color.White
            .FillColor = Color.FromArgb(33, 42, 57)
            .FillColor2 = Color.FromArgb(33, 42, 57)
            .Font = New Font("Trebuchet MS", 11, FontStyle.Regular)
            .HoverState.BorderColor = Color.White
            .HoverState.ForeColor = Color.Black
            .HoverState.FillColor = Color.Gray
            .HoverState.FillColor2 = Color.Gray
            .HoverState.Font = New Font("Trebuchet MS", 11, FontStyle.Regular)
            .PressedColor = Color.White
            .ShadowDecoration.Color = Color.FromArgb(33, 42, 57)
            .ShadowDecoration.Depth = 30
            .Size = New Size(100, 35)
            .TextAlign = HorizontalAlignment.Center
        End With
        '  AddHandler GradientButton.Click, AddressOf Me.RoomBtns_Click
        Me.Controls.Add(GradientButton)
    End Sub
    Private Sub RoomBtns_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
    End Sub
    Private Sub RoomButtons()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [HotelRoom]", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    Do While Reader.Read
                        If (Reader(8) = 0) Then
                            Call Vacant_Button_Attributes()
                            GradientButton.Name = Reader(0)
                            GradientButton.Text = "Room " & GradientButton.Name
                            FLP_RoomButtons.Controls.Add(GradientButton)
                        Else
                            Call Booked_Button_Attributes()
                            GradientButton.Name = Reader(0)
                            GradientButton.Text = "Room " & GradientButton.Name
                            FLP_RoomButtons.Controls.Add(GradientButton)
                        End If
                    Loop
                End Using
            End Using
        End Using
    End Sub
    Private Sub RoomsReport()
        GradientButton = New Guna.UI2.WinForms.Guna2GradientButton
        With GradientButton
            .Text = "VIEW REPORT"
            .Anchor = AnchorStyles.Left
            .Animated = True
            .BackColor = Color.Transparent
            .BorderRadius = 5
            .BorderThickness = 1
            .BorderColor = Color.FromArgb(33, 42, 57)
            .Cursor = Cursors.Hand
            .ForeColor = Color.FromArgb(33, 42, 57)
            .FillColor = Color.Transparent
            .FillColor2 = Color.Transparent
            .Font = New Font("Garamond", 15, FontStyle.Regular)
            .HoverState.BorderColor = Color.White
            .HoverState.ForeColor = Color.White
            .HoverState.FillColor = Color.FromArgb(33, 42, 57)
            .HoverState.FillColor2 = Color.FromArgb(33, 42, 57)
            .HoverState.Font = New Font("Garamond", 16, FontStyle.Regular)
            .PressedColor = Color.White
            .ShadowDecoration.Color = Color.FromArgb(33, 42, 57)
            .ShadowDecoration.Depth = 30
            .Size = New Size(312, 120)
            .TextAlign = HorizontalAlignment.Center
            .UseTransparentBackground = True
        End With
        AddHandler GradientButton.Click, AddressOf Me.AllRooms_Click
        Me.Controls.Add(GradientButton)
        FLP_RoomButtons.Controls.Add(GradientButton)
    End Sub
    Private Sub AllRooms_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
        Form4.Panel_Holder.Controls.Clear()
        Guest_Report = New GuestReport
        With Guest_Report
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form4.Text = "Room Report"
        Form4.Size = Guest_Report.Size
        Form4.Panel_Holder.Controls.Add(Guest_Report)
        Form4.ShowDialog()
    End Sub
    Private Sub CountRooms()
        ' Booked Status
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT COUNT(*) FROM [HotelRoom] WHERE RoomStatus = '1'", conn)
                Lbl_Booked.Text = Command.ExecuteScalar()
            End Using
        End Using
        'Vacant Status
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT COUNT(*) FROM [HotelRoom] WHERE RoomStatus = '0'", conn)
                Lbl_Vacant.Text = Command.ExecuteScalar()
            End Using
        End Using
    End Sub
    '
    '||Search Guest Already In the System
    '
    Private Sub Btn_SearchGuest_Click(sender As Object, e As EventArgs) Handles Btn_SearchGuest.Click
        Form5.Panel_Holder.Controls.Clear()
        CheckInSearch = New GuestCheckInSearch
        With CheckInSearch
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form5.Text = "Search Guest..."
        Form5.Size = CheckInSearch.Size
        Form5.Panel_Holder.Controls.Add(CheckInSearch)
        Form5.ShowDialog()
    End Sub
    '
    'CHECK IN GUEST
    '
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Call CheckInForm.Clear_Ctrls()
    End Sub
    Private Sub Generate_SNo()
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(SerialNumber) FROM [GuestIn]", conn)
                Dim TempHolder_SerialNumber As String = Command.ExecuteScalar().ToString()
                If (TempHolder_SerialNumber = "") Then
                    GuestSerialNumber = 1
                ElseIf (TempHolder_SerialNumber <> "") Then
                    GuestSerialNumber = Command.ExecuteScalar()
                    Do While (GuestSerialNumber <= 10000000)
                        GuestSerialNumber += 1
                        Exit Do
                    Loop
                End If
            End Using
        End Using
    End Sub
    Public Sub CheckIn_Guest()
        Call Generate_SNo()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("INSERT INTO [GuestIn] (SerialNumber, Name, Email, Contact, GuestType, ArrivalDate, StayDuration, DepartureDate, NumberOfPeople, Enquiries, RoomNumber, RoomType, DueAmount, Status) VALUES (@SerialNumber, @Name, @Email, @Contact, @GuestType, @ArrivalDate, @StayDuration, @DepartureDate, @NumberOfPeople, @Enquiries, @RoomNumber, @RoomType, @DueAmount, @Status)", conn)
                Try
                    With Command
                        .Parameters.Add("@SerialNumber", SqlDbType.Int).Value = GuestSerialNumber
                        .Parameters.Add("@Name", SqlDbType.VarChar).Value = CheckInForm.Txt_Name.Text
                        .Parameters.Add("@Email", SqlDbType.VarChar).Value = CheckInForm.Txt_Email.Text
                        .Parameters.Add("@Contact", SqlDbType.Int).Value = CInt(CheckInForm.Txt_Contact.Text)
                        .Parameters.Add("@GuestType", SqlDbType.VarChar).Value = CheckInForm.Cmb_GuestType.Text
                        .Parameters.Add("@ArrivalDate", SqlDbType.DateTime).Value = CheckInForm.Dat_DateOfArrival.Value
                        .Parameters.Add("@StayDuration", SqlDbType.Int).Value = CheckInForm.Txt_Duration.Text
                        .Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CheckInForm.Dat_DateOfArrival.Value.AddDays(CInt(CheckInForm.Txt_Duration.Text))
                        .Parameters.Add("@NumberOfPeople", SqlDbType.Int).Value = CheckInForm.Txt_NumberOfPeople.Text
                        .Parameters.Add("@Enquiries", SqlDbType.VarChar).Value = CheckInForm.Txt_CustomerEnquiry.Text
                        .Parameters.Add("@RoomNumber", SqlDbType.Int).Value = 0
                        .Parameters.Add("@RoomType", SqlDbType.VarChar).Value = ""
                        .Parameters.Add("@DueAmount", SqlDbType.Decimal).Value = 0.00
                        .Parameters.Add("@Status", SqlDbType.TinyInt).Value = 0
                        .ExecuteNonQuery()
                        MsgBox("New Guest Checked In.", vbInformation)
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
            End Using
        End Using
        Call CheckInForm.Clear_Ctrls()
        Form5.Dispose()
        Call RoomBooking_Module()
    End Sub
    Public Sub RoomBooking_Module()
        Form4.Panel_Holder.Controls.Clear()
        RoomBooking = New Booking
        With RoomBooking
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form4.Text = "Room Booking"
        Form4.Size = RoomBooking.Size
        Form4.Panel_Holder.Controls.Add(RoomBooking)
        Form4.ShowDialog()
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If (CheckInForm.Txt_Name.Text = "" Or CheckInForm.Txt_Email.Text = "" Or CheckInForm.Txt_Contact.Text = "" Or CheckInForm.Cmb_GuestType.Text = CheckInForm.Cmb_GuestType.Items(0) Or CheckInForm.Txt_NumberOfPeople.Text = "" Or CheckInForm.Txt_Duration.Text = "") Then
            MsgBox("Ensure all fields are filled to proceed.", vbCritical)
        Else
            Call CheckIn_Guest()
        End If
    End Sub
    '
    'TIMER VISUAL EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '||BOOKED
        If (Prg_Booked.Value <= CInt(Lbl_Booked.Text)) Then
            Prg_Booked.Value += 1
        Else
            Prg_Booked.Value = 0
        End If
        '||VACANT
        If (Prg_Vacant.Value <= CInt(Lbl_Vacant.Text)) Then
            Prg_Vacant.Value += 1
        Else
            Prg_Vacant.Value = 0
        End If
        '|| CLEANED MODE
        If (Prg_Cleaned.Value <= CInt(Lbl_Cleaned.Text)) Then
            Prg_Cleaned.Value += 1
        Else
            Prg_Cleaned.Value = 0
        End If
        '|| IN-CLEANING MODE
        If (Prg_Cleaning.Value <= CInt(Lbl_Cleaning.Text)) Then
            Prg_Cleaning.Value += 1
        Else
            Prg_Cleaning.Value = 0
        End If
        '|| DIRTY MODE
        If (Prg_Dirty.Value <= CInt(Lbl_Dirty.Text)) Then
            Prg_Dirty.Value += 1
        Else
            Prg_Dirty.Value = 0
        End If
    End Sub

End Class
