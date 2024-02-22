Public Class HouseKeeping_RoomStatus
    Public Sub Initializer()
        Call GuestRooms_Module()

    End Sub
    Private Sub HouseKeeping_RoomStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub GuestRooms_Module()
        Page_GuestStatus.Controls.Clear()
        With HotelRooms
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_GuestStatus.Controls.Add(HotelRooms)
    End Sub



End Class
