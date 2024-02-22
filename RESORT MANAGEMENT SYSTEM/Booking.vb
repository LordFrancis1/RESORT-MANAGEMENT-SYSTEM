Imports System.Data.SqlClient

Public Class Booking
    Dim RoomType As String
    Public Sub Initializer()
        Cmb_RoomType.Text = Cmb_RoomType.Items(0)

    End Sub
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Form4.Dispose()
    End Sub
    Private Sub Cmb_RoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_RoomType.SelectedIndexChanged
        If (Cmb_RoomType.Text = Cmb_RoomType.Items(0)) Then
            RoomType = ""
            Call RoomButtons()
            Lbl_Inform.Left = Panel_Title.Right
            Timer1.Start()
        Else
            RoomType = Trim(Cmb_RoomType.Text)
            Call RoomButtons()
        End If
    End Sub
    Private Sub Btn_RefreshAll_Click(sender As Object, e As EventArgs) Handles Btn_RefreshAll.Click
        Call Initializer()
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
            .Size = New Size(95, 35)
            .TextAlign = HorizontalAlignment.Center
        End With
        AddHandler GradientButton.Click, AddressOf Me.RoomBtns_Click
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
            .Size = New Size(95, 35)
            .TextAlign = HorizontalAlignment.Center
        End With
        AddHandler GradientButton.Click, AddressOf Me.RoomBtns_Click
        Me.Controls.Add(GradientButton)
    End Sub
    Private Sub RoomButtons()
        FLP_RoomButtons.Controls.Clear()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            If (RoomType = "") Then
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
            Else
                Using Command As New SqlCommand("SELECT * FROM [HotelRoom] WHERE RoomType = '" & RoomType & "' ", conn)
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
            End If
        End Using
    End Sub
    Private Sub RoomBtns_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
        RoomSelected = New SelectedRoom
        With RoomSelected
            .Dock = DockStyle.Fill
            .Initializer()
            .FLP_Buttons.Show()
        End With
        Me.Controls.Remove(Panel_Holder)
        Me.Controls.Add(RoomSelected)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_Inform.Right >= Panel_Title.Left) Then
            Lbl_Inform.Left -= 2
        Else
            Lbl_Inform.Left = Panel_Title.Right
        End If
    End Sub
End Class
