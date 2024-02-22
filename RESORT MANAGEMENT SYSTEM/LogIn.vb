Imports System.Data.SqlClient

Public Class LogIn
    Dim Password As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Call Check_AccountStatus()

    End Sub
    Private Sub Btn_HomePage_Click(sender As Object, e As EventArgs) Handles Btn_HomePage.Click
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
    Private Sub txt_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged
        Password = txt_Password.Text
    End Sub
    Private Sub txt_Password_Enter(sender As Object, e As EventArgs) Handles txt_Password.Enter

    End Sub

    Private Sub toggle_pass_encrypt_CheckedChanged(sender As Object, e As EventArgs) Handles toggle_pass_encrypt.CheckedChanged
        If (toggle_pass_encrypt.Checked = True) Then
            txt_Password.UseSystemPasswordChar = True
            txt_Password.BorderColor = Color.BlueViolet
        ElseIf (toggle_pass_encrypt.Checked = False) Then
            txt_Password.UseSystemPasswordChar = False
            txt_Password.BorderColor = Color.Red
        End If
    End Sub
    Private Sub Clear_Ctrls()
        Password = ""
        Pic_User.Image = Nothing
        txt_Password.Clear()
        toggle_pass_encrypt.Checked = True
    End Sub
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Call Login()
    End Sub

    Private Sub Login()
        If (txt_Password.Text = "") Then
            MsgBox("Text field is null.Kindly type in a user password.", vbCritical)
        Else
            Using conn As New SqlConnection(CONNECTION)
                If (conn.State <> ConnectionState.Open) Then
                    conn.Open()
                End If
                Using Command As New SqlCommand("SELECT * FROM [UserDetails] WHERE IDNumber = @IDNumber", conn)
                    Try
                        With Command
                            .Parameters.Add("@IDNumber", SqlDbType.Int).Value = SystemUserID
                            .ExecuteNonQuery()
                        End With
                    Catch ex As SqlException
                        MsgBox(ex.Message, vbCritical)
                    End Try
                    Using Reader As SqlDataReader = Command.ExecuteReader()
                        While Reader.Read
                            Try
                                If (Password = Trim(Reader(13))) Then
                                    If (Trim(Reader(0)) = "System Administrator") Then
                                        MsgBox("Login successful.Access Granted.", vbInformation, "Welcome")
                                        Form1.Hide()
                                        Form3.Show()
                                        Form3.Initializer()
                                    Else
                                        MsgBox("Login successful.Access Granted.", vbInformation, "Welcome")
                                        Form1.Hide()
                                        Form2.Show()

                                    End If
                                    Call Clear_Ctrls()
                                ElseIf (Password <> Trim(Reader(13))) Then
                                    Call Trial_Attempts()
                                End If
                            Catch ex As SqlException
                                MsgBox(ex.Message, vbCritical)
                            End Try
                        End While
                    End Using
                End Using
            End Using
        End If
    End Sub
    Private Sub Trial_Attempts()
        txt_Password.Clear()
        Dim Attempt As Integer
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(Attempt) FROM [UserDetails] WHERE IDNumber = @IDNumber", conn)
                Try
                    With Command
                        .Parameters.Add("@IDNumber", SqlDbType.Int).Value = SystemUserID
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
                Attempt = Command.ExecuteScalar()
                Do While (Attempt <= 5)
                    Attempt += 1
                    Exit Do
                Loop
                Using Command2 As New SqlCommand("UPDATE [UserDetails] SET Attempt = @Attempt WHERE IDNumber = @IDNumber", conn)
                    Try
                        With Command2
                            .Parameters.Add("@Attempt", SqlDbType.Int).Value = Attempt
                            .Parameters.Add("@IDNumber", SqlDbType.Int).Value = SystemUserID
                            .ExecuteNonQuery()
                        End With
                    Catch ex As SqlException
                        MsgBox(ex.Message, vbCritical)
                    End Try
                    If (Attempt = 1) Then
                        MsgBox("Incorrect Password.Four more attempts and you will block this account.", MessageBoxIcon.Warning)
                    ElseIf (Attempt = 2) Then
                        MsgBox("Incorrect Password.Three more attempts and you will block this account.", MessageBoxIcon.Warning)
                    ElseIf (Attempt = 3) Then
                        MsgBox("Incorrect Password.Two more attempts and you will block this account.", MessageBoxIcon.Warning)
                    ElseIf (Attempt = 4) Then
                        MsgBox("Incorrect Password.One more attempt and you will block this account.", MessageBoxIcon.Warning)
                    ElseIf (Attempt = 5) Then
                        'Block The Account
                        'Set Account Status to Offline
                        Using Command3 As New SqlCommand("UPDATE [UserDetails] SET Status = @Status WHERE IDNumber = @IDNumber", conn)
                            Try
                                With Command3
                                    .Parameters.Add("@Status", SqlDbType.TinyInt).Value = 0
                                    .Parameters.Add("@IDNumber", SqlDbType.Int).Value = SystemUserID
                                    .ExecuteNonQuery()
                                End With
                            Catch ex As SqlException
                                MsgBox(ex.Message, vbCritical)
                            End Try
                        End Using
                        Call DenyAccess()
                        MsgBox("Account Blocked.", vbCritical)
                    End If
                End Using
            End Using
        End Using
    End Sub
    Public Sub AllowAccess()
        lbl_Feedback.Text = "Account Feedback"
        lbl_Feedback.Hide()
        Ll_AccessControl.Text = "Forgot Password"
        txt_Password.Enabled = True
        toggle_pass_encrypt.Enabled = True
        Btn_Login.Enabled = True
        toggle_pass_encrypt.BackColor = Color.WhiteSmoke
        Btn_Login.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub DenyAccess()
        lbl_Feedback.Text = "This Account is blocked!!!"
        lbl_Feedback.Show()
        Ll_AccessControl.Text = "Recover Account"
        txt_Password.Enabled = False
        toggle_pass_encrypt.Enabled = False
        Btn_Login.Enabled = False
        toggle_pass_encrypt.BackColor = Color.Gainsboro
        Btn_Login.BackColor = Color.Gainsboro
    End Sub
    Private Sub Check_AccountStatus()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [UserDetails] WHERE IDNumber = @IDNumber", conn)
                Try
                    With Command
                        .Parameters.Add("@IDNumber", SqlDbType.Int).Value = SystemUserID
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Try
                            If (Reader(14) = 1) Then
                                'Online
                                Call AllowAccess()
                            ElseIf (Reader(14) = 0) Then
                                'Offline
                                Call DenyAccess()
                            End If
                        Catch ex As SqlException
                            MsgBox(ex.Message, vbCritical)
                        End Try
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Ll_AccessControl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Ll_AccessControl.LinkClicked
        Select Case Ll_AccessControl.Text
            Case "Forgot Password"
                Form1.Panel_Holder.Controls.Clear()
                Form1.Panel_Holder.BackgroundImage = Nothing
                Form1.WindowState = FormWindowState.Maximized
                Form1.Text = "Reset Password"
                Password_Reset = New PasswordReset
                With Password_Reset
                    .Dock = DockStyle.Fill
                    .Initializer()
                End With
                Form1.Panel_Holder.Controls.Add(Password_Reset)
            Case "Recover Account"
                AccountQuest = "Recover"
                Form1.Panel_Holder.Controls.Clear()
                Form1.Panel_Holder.BackgroundImage = Nothing
                Form1.WindowState = FormWindowState.Maximized
                Form1.Text = "Account Recovery"
                Account_Recovery = New AccountRecovery
                With Account_Recovery
                    .Dock = DockStyle.Fill
                    .Initializer()
                End With
                Form1.Panel_Holder.Controls.Add(Account_Recovery)
        End Select
    End Sub
End Class
