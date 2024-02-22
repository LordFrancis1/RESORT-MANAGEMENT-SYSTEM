Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class PasswordReset
    Dim NewPass, ConfirmPass As String
    Private Sub PasswordReset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Call Clear_Ctrls()
        Call Load_SystemUser()

    End Sub
    Private Sub Load_SystemUser()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [UserDetails] WHERE IDNumber = @IDNumber ", conn)
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
                        'Convert from binary to image file
                        Dim Profile As Byte() = Reader(2)
                        Dim stream As New MemoryStream(Profile)
                        Pic_User.Image = System.Drawing.Image.FromStream(stream)
                        Lbl_UserName.Text = Trim(Reader(3)) & " " & Trim(Reader(4)) & " " & Trim(Reader(5))
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Clear_Ctrls()
        Pic_User.Image = Nothing
        Lbl_UserName.Text = "User Name"
        txt_NewPassword.Clear()
        txt_ConfirmPassword.Clear()
        toggle_newpass.Checked = True
        toggle_confirmpass.Checked = True

    End Sub
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        txt_NewPassword.Clear()
        txt_ConfirmPassword.Clear()
        toggle_newpass.Checked = True
        toggle_confirmpass.Checked = True
    End Sub
    Private Sub txt_NewPassword_TextChanged(sender As Object, e As EventArgs) Handles txt_NewPassword.TextChanged
        NewPass = txt_NewPassword.Text
    End Sub
    Private Sub toggle_newpass_CheckedChanged(sender As Object, e As EventArgs) Handles toggle_newpass.CheckedChanged
        If (toggle_newpass.Checked = True) Then
            txt_NewPassword.UseSystemPasswordChar = True
            txt_NewPassword.BorderColor = Color.BlueViolet
            txt_NewPassword.ForeColor = Color.Blue
        Else
            txt_NewPassword.UseSystemPasswordChar = False
            txt_NewPassword.BorderColor = Color.Red
            txt_NewPassword.ForeColor = Color.Red
        End If
    End Sub
    Private Sub txt_ConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txt_ConfirmPassword.TextChanged
        ConfirmPass = txt_ConfirmPassword.Text
        txt_ConfirmPassword.BorderColor = Color.FromArgb(192, 192, 255)
        txt_ConfirmPassword.BorderThickness = 1
        Timer1.Stop()
    End Sub
    Private Sub toggle_confirmpass_CheckedChanged(sender As Object, e As EventArgs) Handles toggle_confirmpass.CheckedChanged
        If (toggle_confirmpass.Checked = True) Then
            txt_ConfirmPassword.UseSystemPasswordChar = True
            txt_ConfirmPassword.BorderColor = Color.BlueViolet
            txt_ConfirmPassword.ForeColor = Color.Blue
        Else
            txt_ConfirmPassword.UseSystemPasswordChar = False
            txt_ConfirmPassword.BorderColor = Color.Red
            txt_ConfirmPassword.ForeColor = Color.Red
        End If
    End Sub
    Sub Password_Error()
        txt_ConfirmPassword.BorderColor = Color.Red
        txt_ConfirmPassword.BorderThickness = 2
        Timer1.Start()
        MsgBox("Mismatch in the Passwords field.Kindly check.", vbCritical)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (txt_ConfirmPassword.BorderColor = Color.Red) Then
            txt_ConfirmPassword.BorderColor = Color.WhiteSmoke
        ElseIf (txt_ConfirmPassword.BorderColor = Color.WhiteSmoke) Then
            txt_ConfirmPassword.BorderColor = Color.Red
        End If
    End Sub
    Private Sub Modify()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("UPDATE [UserDetails] SET Password = @Password WHERE IDNumber = @IDNumber", conn)
                Try
                    With Command
                        .Parameters.Add("@Password", SqlDbType.VarChar).Value = txt_ConfirmPassword.Text
                        .Parameters.Add("@IDNumber", SqlDbType.Int).Value = SystemUserID
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
                MsgBox("Password Changed succesfully. Login with the new password.", vbInformation)
            End Using
        End Using
    End Sub
    Private Sub Btn_Modify_Click(sender As Object, e As EventArgs) Handles Btn_Modify.Click
        If (txt_NewPassword.Text = "" Or txt_ConfirmPassword.Text = "") Then
            MsgBox("Ensure all the Password fields are null.", vbCritical)
        Else
            If (NewPass <> ConfirmPass) Then
                Call Password_Error()
            ElseIf (NewPass = ConfirmPass) Then
                Call Modify()
                Call Clear_Ctrls()
                Call LoginPage()
            End If
        End If
    End Sub
    Private Sub LoginPage()
        Form1.Panel_Holder.Controls.Clear()
        Form1.Panel_Holder.BackgroundImage = Nothing
        Form1.WindowState = FormWindowState.Maximized
        Form1.Text = "User Login"
        Form1.Panel_Holder.Controls.Add(log_in)
        With log_in
            .Dock = DockStyle.Fill
            .Initializer()
        End With
    End Sub
    Private Sub Ll_RememberedPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Ll_RememberedPassword.LinkClicked
        Call LoginPage()
    End Sub
End Class
