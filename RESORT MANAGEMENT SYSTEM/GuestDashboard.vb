Imports System.Data.SqlClient
Imports System.IO

Public Class GuestDashboard
    Public Sub Initializer()
        Lbl_HotelSlogan.Left = Panel_HotelInfo.Right
        Timer1.Start()
        Call HotelDetails()
        Call GuestDetails()

    End Sub
    Private Sub HotelDetails()
        Pic_HotelIcon.Image = HotelLogo
        Lbl_HotelName.Text = HotelName
        Lbl_HotelSlogan.Text = "..." & HotelSlogan & "..."
        BtnPic_RoomType.HoverState.Image = HotelLogo
    End Sub
    Private Sub GuestDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub GuestDetails()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [GuestIn] WHERE SerialNumber = '" & GradientButton.Name & "'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Lbl_GuestName.Text = Trim(Reader(1))
                        Lbl_GuestEmail.Text = Trim(Reader(2))
                        Lbl_GuestContact.Text = "+254 " & Reader(3)
                        Lbl_GuestType.Text = Trim(Reader(4))
                        Lbl_ArrivalDate.Text = CDate(Reader(5)).ToLongDateString()
                        Lbl_StayDuration.Text = Reader(6) & " Night(s)."
                        Lbl_DepartureDate.Text = CDate(Reader(7)).ToLongDateString()
                        Lbl_TravelCompany.Text = Reader(8) & " Person(s)."
                        If (Trim(Reader(9)) = "") Then
                            Lbl_GuestEnqueries.ForeColor = Color.Red
                            Lbl_GuestEnqueries.Text = "Null Enquires."
                        Else
                            Lbl_GuestEnqueries.ForeColor = Color.Green
                            Lbl_GuestEnqueries.Text = Trim(Reader(9))
                        End If
                        Lbl_RoomNumber.Text = "Room " & Reader(10)
                        Lbl_DueAmount.Text = "Ksh " & Reader(12)
                        Lbl_RoomType.Text = Trim(Reader(11))
                    End While
                End Using
            End Using
            Using Command2 As New SqlCommand("SELECT * FROM [HotelRoom] WHERE RoomType = '" & Trim(Lbl_RoomType.Text) & "'", conn)
                Using Reader2 As SqlDataReader = Command2.ExecuteReader()
                    While Reader2.Read
                        Dim RoomPic As Byte() = Reader2(3)
                        Dim stream As New MemoryStream(RoomPic)
                        BtnPic_RoomType.Image = System.Drawing.Image.FromStream(stream)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Btn_Receipt_Click(sender As Object, e As EventArgs) Handles Btn_Receipt.Click
        Form4.Panel_Holder.Controls.Clear()
        PrintType = New PrintTypeQuery
        With PrintType
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form4.Text = "Print Operations..."
        Form4.Size = PrintType.Size
        Form4.Panel_Holder.Controls.Add(PrintType)
        Form4.ShowDialog()
    End Sub
    '
    '|| TIMER EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_HotelSlogan.Right >= Panel_Pic.Right) Then
            Lbl_HotelSlogan.Left -= 1

        Else
            Lbl_HotelSlogan.Left = Panel_HotelInfo.Right
        End If
    End Sub


End Class
