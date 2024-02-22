Imports System.Data.SqlClient
Imports System.IO

Public Class SelectedRoom
    Public RoomType As String
    Public RoomPrice As Integer
    Public Duration As Integer
    Public Sub Initializer()
        Call ReadGuest()
        Call ReadRoom()
        Call Inform()
    End Sub
    Private Sub SelectedRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ReadGuest()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [GuestIn] WHERE SerialNumber = '" & GuestSerialNumber & "'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Duration = Reader(6)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub ReadRoom()
        Lbl_RoomNumber.Text = "Room " & GradientButton.Name
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [HotelRoom] WHERE RoomNumber = '" & GradientButton.Name & "' ", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        'Convert from binary to image file
                        Dim Pic As Byte() = Reader(3)
                        Dim stream As New MemoryStream(Pic)
                        Pic_Room.Image = System.Drawing.Image.FromStream(stream)
                        '
                        If (Reader(8) = 0) Then
                            Lbl_RoomStatus.Text = "Vacant"
                            Btn_BookRoom.Enabled = True
                        Else
                            Lbl_RoomStatus.Text = "Booked"
                            Btn_BookRoom.Enabled = False
                        End If
                        RoomType = Trim(Reader(1))
                        Lbl_RoomType.Text = RoomType
                        RoomPrice = CInt(Reader(4))
                        Lbl_RoomPrice.Text = "Ksh " & RoomPrice
                    End While
                End Using
            End Using
                Using Command As New SqlCommand("SELECT * FROM [GuestIn] WHERE RoomNumber = '" & GradientButton.Name & "' ", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Lbl_GuestName.Text = StrConv(Trim(Reader(1)), VbStrConv.ProperCase)
                        Lbl_StayDuration.Text = Reader(6) & " Night(s)."
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Inform()
        Lbl_Inform.Left = Panel_Title.Right
        Lbl_Inform.Text = "This Room is Currently " & Lbl_RoomStatus.Text
        Timer1.Start()
    End Sub
    Public Sub AllocateRoom()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("UPDATE [GuestIn] SET RoomNumber = @RoomNumber, RoomType = @RoomType, DueAmount = @DueAmount, Status = @Status WHERE SerialNumber = @SerialNumber", conn)
                Try
                    With Command
                        .Parameters.Add("@SerialNumber", SqlDbType.Int).Value = GuestSerialNumber
                        .Parameters.Add("@RoomNumber", SqlDbType.Int).Value = GradientButton.Name
                        .Parameters.Add("@RoomType", SqlDbType.VarChar).Value = RoomType
                        .Parameters.Add("@DueAmount", SqlDbType.Decimal).Value = Val(RoomPrice * Duration)
                        .Parameters.Add("@Status", SqlDbType.TinyInt).Value = 1
                        .ExecuteNonQuery()
                        MsgBox("Room Allocated.", vbInformation)
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
            End Using
        End Using
    End Sub
    Public Sub UpdateRoomStatus()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("UPDATE [HotelRoom] SET RoomStatus = @RoomStatus  WHERE RoomNumber = @RoomNumber", conn)
                Try
                    With Command
                        .Parameters.Add("@RoomNumber", SqlDbType.Int).Value = GradientButton.Name
                        .Parameters.Add("@RoomStatus", SqlDbType.TinyInt).Value = 1
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
            End Using
        End Using
    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Form4.Dispose()
    End Sub

    Private Sub Btn_GoBack_Click(sender As Object, e As EventArgs) Handles Btn_GoBack.Click
        With RoomBooking
            .Controls.Remove(RoomSelected)
            .Controls.Add(.Panel_Holder)
            .Panel_Holder.Dock = DockStyle.Fill
            .Initializer()
        End With
    End Sub
    Private Sub Btn_BookRoom_Click(sender As Object, e As EventArgs) Handles Btn_BookRoom.Click
        Call AllocateRoom()
        Call UpdateRoomStatus()
        Form4.Dispose()
        Call GuestReservation.Initializer()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_Inform.Right >= Panel_Title.Left) Then
            Lbl_Inform.Left -= 2
        Else
            Lbl_Inform.Left = Panel_Title.Right
        End If
    End Sub
End Class
