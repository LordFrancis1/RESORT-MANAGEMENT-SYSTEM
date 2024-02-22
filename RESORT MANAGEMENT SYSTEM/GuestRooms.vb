Imports System.Data.SqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class GuestRooms
    Public Sub Initializer()
        Call Clear_FLPS()
        Call RoomButtons()
        Call TimeLoop()
    End Sub
    Private Sub GuestRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TimeLoop()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [Hotel]", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Lbl_Inform.Text = StrConv(Trim(Reader(2)), VbStrConv.ProperCase) & " Hotel Rooms"
                    End While
                End Using
            End Using
        End Using
        Lbl_Inform.Left = Panel_Title.Right
        Timer1.Start()
    End Sub
    Private Sub Clear_FLPS()
        FLP_SingleRooms.Controls.Clear()
        FLP_DoubleRooms.Controls.Clear()
        FLP_TripleRooms.Controls.Clear()
        FLP_TwinRooms.Controls.Clear()
        FLP_JuniourSuite.Controls.Clear()
        FLP_ExecutiveSuite.Controls.Clear()
        FLP_PresidentialSuite.Controls.Clear()
        ' For Each CTRLS As Control In Me.Controls
        ' If (TypeOf CTRLS Is FlowLayoutPanel) Then
        'For Each ctrl As Control In CTRLS.Controls
        ' ctrl.Controls.Clear()
        ' Next
        'End If
        ' Next
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
            .Font = New Font("Trebuchet MS", 14, FontStyle.Regular)
            .HoverState.BorderColor = Color.White
            .HoverState.ForeColor = Color.Black
            .HoverState.FillColor = Color.Gray
            .HoverState.FillColor2 = Color.Gray
            .HoverState.Font = New Font("Trebuchet MS", 11, FontStyle.Regular)
            .PressedColor = Color.White
            .ShadowDecoration.Color = Color.FromArgb(33, 42, 57)
            .ShadowDecoration.Depth = 30
            .Size = New Size(100, 50)
            .TextAlign = HorizontalAlignment.Center
        End With
        AddHandler GradientButton.Click, AddressOf Me.RoomBtns_Click
        Me.Controls.Add(GradientButton)
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
            .Font = New Font("Trebuchet MS", 14, FontStyle.Regular)
            .HoverState.BorderColor = Color.White
            .HoverState.ForeColor = Color.Black
            .HoverState.FillColor = Color.Gray
            .HoverState.FillColor2 = Color.Gray
            .HoverState.Font = New Font("Trebuchet MS", 11, FontStyle.Regular)
            .PressedColor = Color.FromArgb(33, 42, 57)
            .ShadowDecoration.Color = Color.White
            .ShadowDecoration.Depth = 30
            .Size = New Size(100, 50)
            .TextAlign = HorizontalAlignment.Center
        End With
        AddHandler GradientButton.Click, AddressOf Me.RoomBtns_Click
        Me.Controls.Add(GradientButton)
    End Sub
    Private Sub RoomButtons()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [HotelRoom]", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    Do While Reader.Read
                        Select Case Trim(Reader(1))
                            Case "Single Room"
                                If (Reader(8) = 0) Then
                                    Call Vacant_Button_Attributes()
                                Else
                                    Call Booked_Button_Attributes()
                                End If
                                GradientButton.Name = Reader(0)
                                GradientButton.Text = "Room " & GradientButton.Name
                                FLP_SingleRooms.Controls.Add(GradientButton)
                            Case "Double Room"
                                If (Reader(8) = 0) Then
                                    Call Vacant_Button_Attributes()
                                Else
                                    Call Booked_Button_Attributes()
                                End If
                                GradientButton.Name = Reader(0)
                                GradientButton.Text = "Room " & GradientButton.Name
                                FLP_DoubleRooms.Controls.Add(GradientButton)
                            Case "Triple Room"
                                If (Reader(8) = 0) Then
                                    Call Vacant_Button_Attributes()
                                Else
                                    Call Booked_Button_Attributes()
                                End If
                                GradientButton.Name = Reader(0)
                                GradientButton.Text = "Room " & GradientButton.Name
                                FLP_TripleRooms.Controls.Add(GradientButton)
                            Case "Twin Room"
                                If (Reader(8) = 0) Then
                                    Call Vacant_Button_Attributes()
                                Else
                                    Call Booked_Button_Attributes()
                                End If
                                GradientButton.Name = Reader(0)
                                GradientButton.Text = "Room " & GradientButton.Name
                                FLP_TwinRooms.Controls.Add(GradientButton)
                            Case "Juniour Suite"
                                If (Reader(8) = 0) Then
                                    Call Vacant_Button_Attributes()
                                Else
                                    Call Booked_Button_Attributes()
                                End If
                                GradientButton.Name = Reader(0)
                                GradientButton.Text = "Room " & GradientButton.Name
                                FLP_JuniourSuite.Controls.Add(GradientButton)
                            Case "Executive Suite"
                                If (Reader(8) = 0) Then
                                    Call Vacant_Button_Attributes()
                                Else
                                    Call Booked_Button_Attributes()
                                End If
                                GradientButton.Name = Reader(0)
                                GradientButton.Text = "Room " & GradientButton.Name
                                FLP_ExecutiveSuite.Controls.Add(GradientButton)
                            Case "Presidential Suite"
                                If (Reader(8) = 0) Then
                                    Call Vacant_Button_Attributes()
                                Else
                                    Call Booked_Button_Attributes()
                                End If
                                GradientButton.Name = Reader(0)
                                GradientButton.Text = "Room " & GradientButton.Name
                                FLP_PresidentialSuite.Controls.Add(GradientButton)
                        End Select
                    Loop
                End Using
            End Using
        End Using
    End Sub
    Private Sub RoomBtns_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
        Call SelectedRoom()
    End Sub
    Private Sub SelectedRoom()
        Form4.Panel_Holder.Controls.Clear()
        RoomSelected = New SelectedRoom
        With RoomSelected
            .Dock = DockStyle.Fill
            .Initializer()
            .FLP_Buttons.Hide()
        End With
        Form4.Text = "Room State"
        Form4.Size = RoomSelected.Size
        Form4.Panel_Holder.Controls.Add(RoomSelected)
        Form4.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_Inform.Right >= Panel_Title.Left) Then
            Lbl_Inform.Left -= 2
        Else
            Lbl_Inform.Left = Panel_Title.Right
        End If
    End Sub
End Class
