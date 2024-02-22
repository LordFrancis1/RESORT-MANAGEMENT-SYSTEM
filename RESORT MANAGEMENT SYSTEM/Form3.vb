Imports System.Data.SqlClient
Imports System.IO

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Initializer()
    End Sub
    Public Sub Initializer()
        Call HotelDetails()
    End Sub
    Private Sub Form_Position()
        Me.CenterToScreen()
    End Sub
    Private Sub HotelDetails()
        Pic_HotelIcon.Image = HotelLogo
        Lbl_Title.Text = "..." & HotelName & " MANAGEMENT INFORMATION SYSTEM..."

    End Sub
    Private Sub Homepage()
        Form1.Panel_Holder.BackgroundImage = Nothing
        Form1.Panel_Holder.Controls.Clear()
        Form1.Text = "Home Page"
        Home_Page = New HomePage
        With Home_Page
            .Size = Form1.Size
            .Dock = DockStyle.Fill
            .Initializer()
            .Panel_Holder.Show()
        End With
        Form1.Panel_Holder.Controls.Add(Home_Page)
        Form1.Panel_Holder.BackgroundImage = My.Resources.Theme_3
    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim Result As MsgBoxResult
        Result = MsgBox("Do you want to Log Out?", vbYesNo + vbDefaultButton2 + vbInformation)
        If (Result = vbYes) Then
            Me.Hide()
            Call Homepage()
            Form1.Show()
        End If
    End Sub
    Private Sub btn_Maximize_Click(sender As Object, e As EventArgs) Handles btn_Maximize.Click
        Me.BackgroundImage = Nothing
        If (Me.WindowState = FormWindowState.Maximized) Then
            Me.Size = New Size(1300, 800)
            Me.WindowState = FormWindowState.Normal
            Call Form_Position()
            Me.BackgroundImage = My.Resources.Wallpaper_8
        Else
            Me.WindowState = FormWindowState.Maximized
            Me.BackgroundImage = My.Resources.Wallpaper_8
        End If
    End Sub
    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    '
    '//RESERVATION
    '
    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        Panel_Holder.Controls.Clear()
        GuestReservation = New DepartmentReservation
        With GuestReservation
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Panel_Holder.Controls.Add(GuestReservation)
    End Sub

    Private Sub CheckInsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInsToolStripMenuItem.Click

    End Sub

    Private Sub CheckOutsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutsToolStripMenuItem.Click

    End Sub

    Private Sub DueInsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DueInsToolStripMenuItem.Click

    End Sub

    Private Sub GuestAllocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestAllocationsToolStripMenuItem.Click

    End Sub

    Private Sub RoomStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomStatusToolStripMenuItem.Click

    End Sub
    '
    '//HOUSEKEEPING
    '
    Private Sub HouseKeepingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HouseKeepingToolStripMenuItem.Click
        Call Summon_HouseKeeping()
    End Sub
    Public Sub Summon_HouseKeeping()
        Panel_Holder.Controls.Clear()
        RoomHouseKeeping = New DepartmentHouseKeeping
        Panel_Holder.Controls.Add(RoomHouseKeeping)
        With RoomHouseKeeping
            .Dock = DockStyle.Fill
            .Initializer()
        End With
    End Sub
End Class