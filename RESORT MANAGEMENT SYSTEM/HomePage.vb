Imports System.Data.SqlClient
Imports System.IO

Public Class HomePage
    Dim Profile As Byte()
    Dim Stream As MemoryStream

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Cmb_UserType.Text = Cmb_UserType.Items(0)
        Lbl_HotelName.Text = HotelName
        Lbl_Inform.Left = Panel_Slide.Right
        Panel_Holder.Hide()
        Timer1.Start()
        Timer2.Start()

    End Sub
    '
    'Module Operations
    '
    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click
        Form1.Panel_Holder.BackgroundImage = Nothing
        If (Form1.WindowState = FormWindowState.Maximized) Then
            Form1.Size = New Size(1300, 800)
            Form1.WindowState = FormWindowState.Normal
            Form1.Panel_Holder.BackgroundImage = My.Resources.Wallpaper_2
        Else
            Form1.WindowState = FormWindowState.Maximized
            Form1.Panel_Holder.BackgroundImage = My.Resources.Wallpaper_2
        End If
    End Sub

    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click
        Form1.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Btn_Off_Click(sender As Object, e As EventArgs) Handles Btn_Off.Click
        Dim Result As MsgBoxResult
        Result = MsgBox("Are you sure you want to exit the application?", vbYesNo + vbDefaultButton2 + vbInformation)
        If (Result = vbYes) Then
            Call ShutDown()
        End If
    End Sub
    Private Sub ShutDown()
        Form1.Panel_Holder.Controls.Clear()
        Form1.Panel_Holder.BackgroundImage = Nothing
        Form1.WindowState = FormWindowState.Maximized
        Form1.Text = "Shutting Down..."
        Shut_Down = New ShutDown
        Form1.Panel_Holder.Controls.Add(Shut_Down)
        With Shut_Down
            .Size = Form1.Size
            .Dock = DockStyle.Fill
            .Initializer()
        End With
    End Sub
    Private Sub Cmb_UserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_UserType.SelectedIndexChanged
        If (Cmb_UserType.Text = Cmb_UserType.Items(0)) Then
            Grp_SystemUsers.Text = "System Administrator(s)"
            Call AdminAccounts()
        ElseIf (Cmb_UserType.Text = Cmb_UserType.Items(1)) Then
            Grp_SystemUsers.Text = "System Administrator(s)"
            Call AdminAccounts()
        ElseIf (Cmb_UserType.Text = Cmb_UserType.Items(2)) Then
            Grp_SystemUsers.Text = "System User(s)"
            Call UserAccounts()
        End If
    End Sub
    '
    'BUTTON ATTRIBUTES
    '
    Private Sub Button_Attributes()
        GradientButton = New Guna.UI2.WinForms.Guna2GradientButton
        With GradientButton
            .UseTransparentBackground = True
            .Anchor = AnchorStyles.Left
            .Animated = True
            .BackColor = Color.Transparent
            .BorderRadius = 10
            .BorderThickness = 2
            .BorderColor = Color.FromArgb(128, 128, 255)
            .Cursor = Cursors.Hand
            .ForeColor = Color.WhiteSmoke
            .FillColor = Color.Transparent
            .FillColor2 = Color.Transparent
            .Font = New Font("Trebuchet MS", 14, FontStyle.Regular)
            .HoverState.BorderColor = Color.Transparent
            .HoverState.ForeColor = Color.BlueViolet
            .HoverState.FillColor = Color.WhiteSmoke
            .HoverState.FillColor2 = Color.WhiteSmoke
            .HoverState.Font = New Font("Trebuchet MS", 14, FontStyle.Regular)
            .ImageAlign = HorizontalAlignment.Right
            .ImageSize = New Size(50, 50)
            .PressedColor = Color.BlueViolet
            .ShadowDecoration.Color = Color.WhiteSmoke
            .Size = New Size(193, 103)
            .TextAlign = HorizontalAlignment.Left
        End With
    End Sub
    Private Sub Open_Login()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [UserDetails] WHERE IDNumber = @IDNumber ", conn)
                Try
                    With Command
                        .Parameters.Add("@IDNumber", SqlDbType.Int).Value = CInt(GradientButton.Name)
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    Form1.Panel_Holder.Controls.Clear()
                    Form1.Panel_Holder.BackgroundImage = Nothing
                    Form1.WindowState = FormWindowState.Maximized
                    Form1.Text = "User Login"
                    log_in = New LogIn
                    With log_in
                        .Initializer()
                        .Dock = DockStyle.Fill
                        While Reader.Read
                            'Convert from binary to image file
                            Dim Profile As Byte() = Reader(2)
                            Dim stream As New MemoryStream(Profile)
                            .Pic_User.Image = System.Drawing.Image.FromStream(stream)
                            .Lbl_UserName.Text = Trim(Reader(3)) & " " & Trim(Reader(4)) & " " & Trim(Reader(5))
                        End While
                    End With
                    Form1.Panel_Holder.Controls.Add(log_in)
                End Using
            End Using
        End Using
    End Sub
    '
    'SYSTEM ADMIN
    '
    Private Sub AdminAccounts()
        FLP_SystemUsers.Controls.Clear()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [UserDetails] WHERE UserType = 'System Administrator'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    Do While Reader.Read
                        Call Button_Attributes()
                        Profile = Reader(2)
                        Stream = New MemoryStream(Profile)
                        GradientButton.Image = System.Drawing.Image.FromStream(Stream)
                        GradientButton.Name = Reader(6)
                        GradientButton.Text = Trim(Reader(3)) & " " & Trim(Reader(4)) & " " & Trim(Reader(5))
                        If (Trim(Reader(7)) = "Male") Then
                            GradientButton.HoverState.Image = My.Resources.MaleAvatar
                        ElseIf (Reader(7) = "Female") Then
                            GradientButton.HoverState.Image = My.Resources.FemaleAvatar
                        End If
                        AddHandler GradientButton.Click, AddressOf Me.btn_SystemAdmin_Click
                        FLP_SystemUsers.Controls.Add(GradientButton)
                    Loop
                End Using
            End Using
        End Using
        If (FLP_SystemUsers.Controls.Count > 0) Then
            Lbl_Inform.Text = "Select Your Account To Proceed Logging In"
        Else
            Lbl_Inform.Text = "There are no accounts for the specified user type"
        End If
        FLP_SystemUsers.Controls.Add(Btn_AddAccount)
    End Sub

    Private Sub btn_SystemAdmin_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
        UserType = "A"
        SystemUserID = GradientButton.Name
        SystemUserName = StrConv(GradientButton.Text, VbStrConv.ProperCase)
        Call Open_Login()
    End Sub
    '
    'SYSTEM USER
    '
    Private Sub UserAccounts()
        FLP_SystemUsers.Controls.Clear()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [UserDetails] WHERE UserType = 'Normal System User'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    Do While Reader.Read
                        Call Button_Attributes()
                        Profile = Reader(2)
                        Stream = New MemoryStream(Profile)
                        GradientButton.Image = System.Drawing.Image.FromStream(Stream)
                        GradientButton.Name = Reader(6)
                        GradientButton.Text = Trim(Reader(3)) & " " & Trim(Reader(4)) & " " & Trim(Reader(5))
                        If (Trim(Reader(7)) = "Male") Then
                            GradientButton.HoverState.Image = My.Resources.MaleAvatar
                        ElseIf (Reader(7) = "Female") Then
                            GradientButton.HoverState.Image = My.Resources.FemaleAvatar
                        End If
                        AddHandler GradientButton.Click, AddressOf Me.btn_SystemUser_Click
                        FLP_SystemUsers.Controls.Add(GradientButton)
                    Loop
                End Using
            End Using
        End Using
        If (FLP_SystemUsers.Controls.Count > 0) Then
            Lbl_Inform.Text = "Select Your Account To Proceed Logging In"
        Else
            Lbl_Inform.Text = "There are no accounts for the specified user type"
        End If
    End Sub

    Private Sub btn_SystemUser_Click(ByVal sender As Object, ByVal e As EventArgs)
        GradientButton = sender
        UserType = "U"
        SystemUserID = GradientButton.Name
        SystemUserName = StrConv(GradientButton.Text, VbStrConv.ProperCase)
        Call Open_Login()
    End Sub

    Private Sub Btn_AddAccount_Click(sender As Object, e As EventArgs) Handles Btn_AddAccount.Click
        Form1.Panel_Holder.Controls.Clear()
        Form1.Panel_Holder.BackgroundImage = Nothing
        Form1.WindowState = FormWindowState.Maximized
        Form1.Text = "User SignUp"
        'signup_display = New SignUpDisplay
        With signup_display
            .Size = Form1.Size
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form1.Panel_Holder.Controls.Add(signup_display)
    End Sub

    Private Sub Btn_Operations_Click(sender As Object, e As EventArgs)

    End Sub
    '
    '||TIMER EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Time.Text = Date.Now.ToString("HH:mm:ss:tt")
        Lbl_Date.Text = Date.Now.ToLongDateString()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (Lbl_Inform.Right >= Panel_Slide.Left) Then
            Lbl_Inform.Left -= 1
        Else
            Lbl_Inform.Left = Panel_Slide.Right
        End If
    End Sub

End Class
