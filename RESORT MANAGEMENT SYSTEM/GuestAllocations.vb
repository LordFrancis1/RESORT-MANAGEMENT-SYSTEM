Imports System.Data.SqlClient
Public Class GuestAllocations
    Public Sub Initializer()
        Panel_Menu.Hide()
        Call AllocatedGuest()
        Call Load_PendingAllocations()

    End Sub
    Private Sub GuestAllocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '
    '||Already Allocated Guests
    '
    Public Sub AllocatedGuest()
        FLP_GuestButtons.Controls.Clear()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [GuestIn] WHERE NOT RoomNumber = '" & 0 & "' ORDER BY RoomNumber ASC", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        GradientButton = New Guna.UI2.WinForms.Guna2GradientButton
                        With GradientButton
                            .Size = New Size(330, 150)
                            .Name = Reader(0)
                            .Image = HotelLogo
                            .ImageSize = New Size(70, 60)
                            .ImageAlign = ContentAlignment.MiddleCenter
                            .Text = "ROOM " & Reader(10) & vbNewLine & StrConv(Trim(Reader(11)), VbStrConv.Uppercase) & vbNewLine & vbNewLine & StrConv(Trim(Reader(1)), VbStrConv.ProperCase)
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
                        AddHandler GradientButton.Click, AddressOf Me.AllocatedGuest_Click
                        Me.Controls.Add(GradientButton)
                        FLP_GuestButtons.Controls.Add(GradientButton)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub AllocatedGuest_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
        Panel_Menu.Show()
        Panel_Holder.Controls.Clear()
        GuestBoard = New GuestDashboard
        With GuestBoard
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Panel_Holder.Controls.Add(GuestBoard)
    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Panel_Menu.Hide()
        Panel_Holder.Controls.Clear()
        Panel_Holder.Controls.Add(FLP_GuestButtons)
    End Sub
    Private Sub Btn_SMS_Click(sender As Object, e As EventArgs) Handles Btn_SMS.Click

    End Sub

    Private Sub Btn_Email_Click(sender As Object, e As EventArgs) Handles Btn_Email.Click

    End Sub
    '
    '||Pending Allocations
    '
    Private Sub Dgv_PendingAllocations_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_PendingAllocations.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If (TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 0 AndAlso e.RowIndex >= 0) Then
            Dim ColumnValue As DataGridView = Dgv_PendingAllocations
            If (ColumnValue.SelectedRows.Item(0).Cells(1).Value = Nothing) Then
                MsgBox("Unspecified guest.", vbCritical)
            Else
                GuestSerialNumber = CInt(Dgv_PendingAllocations.SelectedRows.Item(0).Cells(1).Value)
                Call CheckIn.RoomBooking_Module()
            End If
        End If
    End Sub
    Public Sub Load_PendingAllocations()
        Dgv_PendingAllocations.Rows.Clear()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [GuestIn] WHERE RoomNumber = '" & 0 & "'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Try
                            With Command
                                Dgv_PendingAllocations.Rows.Add("Allocate", Reader(0), Trim(Reader(1)), Trim(Reader(2)), "+254 " & Reader(3), Trim(Reader(4)), CDate(Reader(5)).ToLongDateString(), Reader(6) & " Nights.", CDate(Reader(7)).ToLongDateString(), Reader(8) & " People.", Trim(Reader(9)), "Room " & Reader(10), Trim(Reader(11)), "Ksh " & Reader(12))
                            End With
                        Catch ex As SqlException
                            MsgBox(ex.Message, vbCritical)
                        End Try
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
