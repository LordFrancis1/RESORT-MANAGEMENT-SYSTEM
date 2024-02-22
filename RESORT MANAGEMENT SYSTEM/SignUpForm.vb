Imports System.Data.SqlClient
Imports System.IO


Public Class SignUpForm
    Dim Profile As Image
    Dim Prof_Pic() As Byte
    Dim Pass, ConfirmPass As String

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Call Clear_Ctrls()

    End Sub
    Private Sub Clear_Ctrls()
        Profile = Nothing
        Pic_User.Image = Nothing
        txt_surname.Clear()
        txt_firstname.Clear()
        txt_lastname.Clear()
        txt_IDNumber.Clear()
        txt_PhoneNumber.Clear()
        cmb_gender.Text = cmb_gender.Items(0)
        cmb_manegerialevel.Text = cmb_manegerialevel.Items(0)
        cmb_department.Text = cmb_department.Items(0)
        cmb_station.Text = cmb_station.Items(0)
        Rb_SystemAdministrator.Checked = True
        txt_UserID.Enabled = True
        txt_UserID.Clear()
        txt_UserID.Enabled = False
        txt_email.Clear()
        txt_Password.Clear()
        txt_ConfirmPassword.Clear()
        toggle_pass_encrypt.Checked = True

    End Sub
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim summon As DialogResult = OpenFileDialog1.ShowDialog
        If (summon = Windows.Forms.DialogResult.OK) Then
            If (OpenFileDialog1.FileName IsNot Nothing) Or (OpenFileDialog1.FileName <> String.Empty) Then
                Pic_User.Image = Image.FromFile(OpenFileDialog1.FileName)
                Profile = Pic_User.Image
            End If
        End If
    End Sub
    Private Sub cmb_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_gender.SelectedIndexChanged
        If (cmb_gender.Text = cmb_gender.Items(0)) Then
            If (Profile IsNot Nothing) Then
                Pic_User.Image = Profile
            ElseIf (Profile Is Nothing) Then
                Pic_User.Image = Nothing
            End If
        ElseIf (cmb_gender.Text = cmb_gender.Items(1)) Then
            If (Profile IsNot Nothing) Then
                Pic_User.Image = Profile
            ElseIf (Profile Is Nothing) Then
                Pic_User.Image = My.Resources.MaleAvatar
            End If
        ElseIf (cmb_gender.Text = cmb_gender.Items(2)) Then
            If (Profile IsNot Nothing) Then
                Pic_User.Image = Profile
            ElseIf (Profile Is Nothing) Then
                Pic_User.Image = My.Resources.FemaleAvatar
            End If
        End If
    End Sub
    Private Sub Btn_AutogenID_Click(sender As Object, e As EventArgs) Handles Btn_AutogenID.Click
        txt_UserID.Enabled = True
        Call Generate_Userid()
        txt_UserID.Enabled = False
    End Sub
    Private Sub Generate_Userid()
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(UserID) FROM [UserDetails]", conn)
                Dim TempHolder_AdmNumber As String = Command.ExecuteScalar().ToString()
                Dim Max_UserID As Integer
                If (TempHolder_AdmNumber = "") Then
                    Max_UserID = 1
                    txt_UserID.Text = Max_UserID
                ElseIf (TempHolder_AdmNumber <> "") Then
                    Max_UserID = Command.ExecuteScalar()
                    Do While (Max_UserID <= 10000)
                        Max_UserID += 1
                        txt_UserID.Text = Max_UserID
                        Exit Do
                    Loop
                End If
            End Using
        End Using
    End Sub
    Private Sub cmb_department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_department.SelectedIndexChanged
        If (cmb_department.Text = cmb_department.Items(1)) Then
            Call Accounts()
        ElseIf (cmb_department.Text = cmb_department.Items(2)) Then
            Call Front_Office()
        ElseIf (cmb_department.Text = cmb_department.Items(3)) Then
            Call HouseKeeping()
        ElseIf (cmb_department.Text = cmb_department.Items(4)) Then
            Call FoodAndBeverage()
        ElseIf (cmb_department.Text = cmb_department.Items(5)) Then
            Call Maintenance()
        ElseIf (cmb_department.Text = cmb_department.Items(6)) Then
            Call Security()
        End If
    End Sub
    Sub Accounts()
        cmb_station.Items.Clear()
        cmb_station.Items.Add("Select Station?")
        cmb_station.Text = cmb_station.Items(0)
        cmb_station.Items.Add("Accountant")
        cmb_station.Items.Add("Clerk")

    End Sub
    Sub Front_Office()
        cmb_station.Items.Clear()
        cmb_station.Items.Add("Select Station?")
        cmb_station.Text = cmb_station.Items(0)
        cmb_station.Items.Add("Receptionist")
    End Sub
    Sub HouseKeeping()
        cmb_station.Items.Clear()
        cmb_station.Items.Add("Select Station?")
        cmb_station.Text = cmb_station.Items(0)
        cmb_station.Items.Add("House Keeper")
    End Sub
    Sub FoodAndBeverage()
        cmb_station.Items.Clear()
        cmb_station.Items.Add("Select Station?")
        cmb_station.Text = cmb_station.Items(0)
        cmb_station.Items.Add("Chief Chef")
        cmb_station.Items.Add("Chef")
        cmb_station.Items.Add("Waiter")
    End Sub
    Sub Maintenance()
        cmb_station.Items.Clear()
        cmb_station.Items.Add("Select Station?")
        cmb_station.Text = cmb_station.Items(0)
        cmb_station.Items.Add("Computer Technician")
        cmb_station.Items.Add("Electrical Eng")
        cmb_station.Items.Add("Software Eng")
        cmb_station.Items.Add("Database Administrator")
        cmb_station.Items.Add("Plumber")
    End Sub
    Sub Security()
        cmb_station.Items.Clear()
        cmb_station.Items.Add("Select Station?")
        cmb_station.Text = cmb_station.Items(0)
        cmb_station.Items.Add("Chief Security Officer")
        cmb_station.Items.Add("CCTV Operator")
        cmb_station.Items.Add("Guard")
    End Sub
    Private Sub txt_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged
        Pass = txt_Password.Text
    End Sub

    Private Sub txt_ConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txt_ConfirmPassword.TextChanged
        ConfirmPass = txt_ConfirmPassword.Text
        txt_ConfirmPassword.BorderColor = Color.FromArgb(192, 192, 255)
        txt_ConfirmPassword.BorderThickness = 1
        Timer1.Stop()
    End Sub
    Private Sub toggle_pass_encrypt_CheckedChanged(sender As Object, e As EventArgs) Handles toggle_pass_encrypt.CheckedChanged
        If (toggle_pass_encrypt.Checked = True) Then
            txt_Password.UseSystemPasswordChar = True
            txt_ConfirmPassword.UseSystemPasswordChar = True
            txt_Password.HoverState.BorderColor = Color.BlueViolet
            txt_ConfirmPassword.HoverState.BorderColor = Color.BlueViolet
            lbl_encrypt.Text = "Password Encrypted..."
            lbl_encrypt.ForeColor = Color.Blue
        ElseIf (toggle_pass_encrypt.Checked = False) Then
            txt_Password.UseSystemPasswordChar = False
            txt_ConfirmPassword.UseSystemPasswordChar = False
            txt_Password.HoverState.BorderColor = Color.Red 'Salmon
            txt_ConfirmPassword.HoverState.BorderColor = Color.Red 'Salmon
            lbl_encrypt.Text = "Password Decrypted..."
            lbl_encrypt.ForeColor = Color.Red 'Salmon
        End If
    End Sub
    Sub Password_Error()
        MsgBox("Mismatch in the Passwords field.Kindly check.", vbCritical)
        txt_ConfirmPassword.BorderColor = Color.Red
        txt_ConfirmPassword.BorderThickness = 2
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (txt_ConfirmPassword.BorderColor = Color.Red) Then
            txt_ConfirmPassword.BorderColor = Color.Transparent
        ElseIf (txt_ConfirmPassword.BorderColor = Color.Transparent) Then
            txt_ConfirmPassword.BorderColor = Color.Red
        End If
    End Sub
    Private Sub Image_Conversion()
        'convert image to binary format
        Dim filesize As New UInt32
        Dim mstream As New MemoryStream()
        Pic_User.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Prof_Pic = mstream.GetBuffer
        filesize = mstream.Length
        mstream.Close()
    End Sub
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Select Case btn_submit.Text
            Case "SIGN UP"
                If (Pass <> ConfirmPass) Then
                    Call Password_Error()
                ElseIf (Pass = ConfirmPass) Then
                    Call Save_Records()
                    'Btn_Exit.PerformClick()
                End If
            Case "MODIFY"
                If (Pass <> ConfirmPass) Then
                    Call Password_Error()
                ElseIf (Pass = ConfirmPass) Then
                    ' Call Modify_Records()
                End If
        End Select
    End Sub
    Private Sub Save_Records()
        If (txt_UserID.Text = "" Or txt_surname.Text = "" Or txt_firstname.Text = "" Or txt_lastname.Text = "" Or txt_IDNumber.Text = "" Or txt_PhoneNumber.Text = "" Or cmb_gender.Text = cmb_gender.Items(0) Or cmb_manegerialevel.Text = cmb_manegerialevel.Items(0) Or cmb_department.Text = cmb_department.Items(0) Or cmb_station.Text = cmb_station.Items(0) Or txt_email.Text = "" Or txt_ConfirmPassword.Text = "") Then
            MsgBox("Ensure all fields are filled to proceed.", vbCritical)
        Else
            Call Image_Conversion()
            Using conn As New SqlConnection(CONNECTION)
                If (conn.State <> ConnectionState.Open) Then
                    conn.Open()
                End If
                Using Command As New SqlCommand("INSERT INTO [UserDetails] (UserType, UserID, Profile, SurName, FirstName, MiddleName, IDNumber, EmailAddress, Gender, PhoneNumber, ManegerialLevel, Department, Station, Password, Status, Attempt) VALUES (@UserType, @UserID, @Profile, @SurName, @FirstName, @MiddleName, @IDNumber, @EmailAddress, @Gender, @PhoneNumber, @ManegerialLevel, @Department, @Station, @Password, @Status, @Attempt)", conn)
                    Try
                        With Command
                            If (Rb_SystemAdministrator.Checked = True) Then
                                .Parameters.Add("@UserType", SqlDbType.VarChar).Value = Rb_SystemAdministrator.Text.ToString()
                            ElseIf (Rb_NormalUser.Checked = True) Then
                                .Parameters.Add("@UserType", SqlDbType.VarChar).Value = Rb_NormalUser.Text.ToString()
                            End If
                            .Parameters.Add("@UserID", SqlDbType.Int).Value = txt_UserID.Text
                            .Parameters.Add("@Profile", SqlDbType.Image).Value = Prof_Pic
                            .Parameters.Add("@SurName", SqlDbType.VarChar).Value = txt_surname.Text
                            .Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txt_firstname.Text
                            .Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = txt_lastname.Text
                            .Parameters.Add("@IDNumber", SqlDbType.Int).Value = CInt(txt_IDNumber.Text)
                            .Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = txt_email.Text
                            .Parameters.Add("@Gender", SqlDbType.VarChar).Value = cmb_gender.Text
                            .Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = CInt(txt_PhoneNumber.Text)
                            .Parameters.Add("@ManegerialLevel", SqlDbType.VarChar).Value = cmb_manegerialevel.Text
                            .Parameters.Add("@Department", SqlDbType.VarChar).Value = cmb_department.Text
                            .Parameters.Add("@Station", SqlDbType.VarChar).Value = cmb_station.Text
                            .Parameters.Add("@Password", SqlDbType.VarChar).Value = txt_ConfirmPassword.Text
                            .Parameters.Add("@Status", SqlDbType.TinyInt).Value = 1
                            .Parameters.Add("@Attempt", SqlDbType.Int).Value = 0
                            .ExecuteNonQuery()
                            MsgBox("Account Saved.", vbInformation)
                        End With
                    Catch ex As SqlException
                        MsgBox(ex.Message, vbCritical)
                    End Try
                End Using
            End Using
            Call Clear_Ctrls()
            Call signup_display.AccountRecoveryProtocols()
        End If
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call Clear_Ctrls()
    End Sub
    Private Sub btn_google_Click(sender As Object, e As EventArgs) Handles btn_google.Click

    End Sub

End Class
