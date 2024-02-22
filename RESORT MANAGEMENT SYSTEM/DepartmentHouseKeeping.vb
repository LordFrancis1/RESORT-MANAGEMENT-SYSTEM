Imports System.Data.SqlClient
Imports System.IO

Public Class DepartmentHouseKeeping
    Dim RoomPhoto() As Byte
    Dim RoomTypeIndex As Integer
    Private Sub DepartmentHouseKeeping_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Lbl_HotelName.Text = StrConv(HotelName, VbStrConv.Uppercase) & " HOUSE KEEPING DEPARTMENT"
        Call HouseKeepingAddRooms_Module()
        Call HouseKeepingStatus_Module()

    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Select Case UserType
            Case "A"
                Form3.Panel_Holder.Controls.Clear()
            Case "U"
                Form2.Panel_Holder.Controls.Clear()
            Case Else
                Form3.Panel_Holder.Controls.Clear()
        End Select
    End Sub
    Private Sub Btn_RefreshModule_Click(sender As Object, e As EventArgs) Handles Btn_RefreshModule.Click
        Call Initializer()
    End Sub
    '
    ''|| HouseKeeping Add Rooms
    '
    Private Sub HouseKeepingAddRooms_Module()
        AddRooms = New HouseKeeping_AddRooms
        Page_AddRooms.Controls.Clear()
        With AddRooms
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_AddRooms.Controls.Add(AddRooms)
    End Sub











    '
    ''|| HouseKeeping Room Status
    '
    Private Sub HouseKeepingStatus_Module()
        HsKeeping_Status = New HouseKeeping_RoomStatus
        Page_RoomStatus.Controls.Clear()
        With HsKeeping_Status
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_RoomStatus.Controls.Add(HsKeeping_Status)
    End Sub

End Class