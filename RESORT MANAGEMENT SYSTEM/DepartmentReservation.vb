Imports System.Data.SqlClient
Imports System.IO

Public Class DepartmentReservation
    Public Sub Initializer()
        Lbl_HotelName.Text = StrConv(HotelName, VbStrConv.Uppercase) & " RESERVATION DEPARTMENT"
        Call GuestCheckIn_Module()
        Call GuestCheckOut_Module()
        Call GuestDueIn_Module()
        Call GuestAllocation_Module()
        Call GuestRooms_Module()
    End Sub
    Private Sub DepartmentReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    ''|| Guest Check In
    '
    Private Sub GuestCheckIn_Module()
        CheckIn = New GuestCheckIn
        Page_CheckIn.Controls.Clear()
        With CheckIn
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_CheckIn.Controls.Add(CheckIn)
    End Sub
    '
    ''|| Guest Check Out
    '
    Private Sub GuestCheckOut_Module()
        CheckOut = New GuestCheckOut
        Page_CheckOut.Controls.Clear()
        With CheckOut
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_CheckOut.Controls.Add(CheckOut)
    End Sub
    '
    ''|| Guest Due In
    '
    Private Sub GuestDueIn_Module()
        DueIn = New GuestDueIn
        Page_DueIn.Controls.Clear()
        With DueIn
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_DueIn.Controls.Add(DueIn)
    End Sub
    '
    ''|| Guest Allocation
    '
    Private Sub GuestAllocation_Module()
        Allocation = New GuestAllocations
        Page_GuestAllocation.Controls.Clear()
        With Allocation
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_GuestAllocation.Controls.Add(Allocation)
    End Sub
    '
    ''|| Guest Rooms
    '
    Private Sub GuestRooms_Module()
        ' HotelRooms = New GuestRooms
        Page_GuestRooms.Controls.Clear()
        With HotelRooms
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Page_GuestRooms.Controls.Add(HotelRooms)
    End Sub


End Class