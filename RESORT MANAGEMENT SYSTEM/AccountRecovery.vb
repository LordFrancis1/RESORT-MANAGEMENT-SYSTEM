Imports System.Data.SqlClient
Imports System.IO

Public Class AccountRecovery
    Private Sub AccountRecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Call Clear_Ctrls()
        Call load_UserID()
        Select Case AccountQuest
            Case "Setup"
                Lbl_Title.Text = "Choose the Security Questions to help in password recovery"
                Btn_RecoverAccount.Hide()
                Btn_Cancel.Show()
                Btn_Save.Show()
                Call Clear_Ctrls()
                Call load_UserID()
                Call Enable_Queries()

            Case "Recover"
                Lbl_Title.Text = "Kindly fill in the questions to recover account"
                Btn_Cancel.Hide()
                Btn_Save.Hide()
                Btn_RecoverAccount.Show()
                Using conn As New SqlConnection(CONNECTION)
                    If (conn.State <> ConnectionState.Open) Then
                        conn.Open()
                    End If
                    Using Command As New SqlCommand("SELECT * FROM [AccountRecovery] WHERE AccountID = @AccountID ", conn)
                        Try
                            With Command
                                .Parameters.Add("@AccountID", SqlDbType.Int).Value = SystemUserID
                                .ExecuteNonQuery()
                            End With
                        Catch ex As SqlException
                            MsgBox(ex.Message, vbCritical)
                        End Try
                        Using Reader As SqlDataReader = Command.ExecuteReader()
                            While Reader.Read
                                Cmb_UserID.Text = Reader(0)
                                Cmb_Question1.Text = Trim(Reader(1))
                                Cmb_Question2.Text = Trim(Reader(3))
                                Cmb_Question3.Text = Trim(Reader(5))
                            End While
                        End Using
                    End Using
                End Using
                Call Disable_Queries()
        End Select
    End Sub
    Private Sub Enable_Queries()
        Cmb_UserID.Enabled = True
        Cmb_Question1.Enabled = True
        Cmb_Question2.Enabled = True
        Cmb_Question3.Enabled = True
    End Sub
    Private Sub Disable_Queries()
        Cmb_UserID.Enabled = False
        Cmb_Question1.Enabled = False
        Cmb_Question2.Enabled = False
        Cmb_Question3.Enabled = False
    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Call Homepage()
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
    Private Sub Loginpage()
        Form1.Panel_Holder.Controls.Clear()
        Form1.Panel_Holder.BackgroundImage = Nothing
        Form1.WindowState = FormWindowState.Maximized
        Form1.Text = "User Login"
        With log_in
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form1.Panel_Holder.Controls.Add(log_in)
    End Sub
    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click
        If (Form1.WindowState = FormWindowState.Maximized) Then
            Form1.Size = New Size(1300, 800)
            Form1.WindowState = FormWindowState.Normal
        Else
            Form1.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click
        Form1.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Btn_RecoverAccount_Click(sender As Object, e As EventArgs) Handles Btn_RecoverAccount.Click
        If (txt_Response1.Text = "" Or txt_Response2.Text = "" Or txt_Response3.Text = "") Then
            MsgBox("To continue, ensure the null fields are filled", vbCritical)
        Else
            Using conn As New SqlConnection(CONNECTION)
                If (conn.State <> ConnectionState.Open) Then
                    conn.Open()
                End If
                Using Command As New SqlCommand("SELECT * FROM [AccountRecovery] WHERE AccountID = @AccountID", conn)
                    Try
                        With Command
                            .Parameters.Add("@AccountID", SqlDbType.Int).Value = SystemUserID
                            .ExecuteNonQuery()
                        End With
                    Catch ex As SqlException
                        MsgBox(ex.Message, vbCritical)
                    End Try
                    Using Reader As SqlDataReader = Command.ExecuteReader()
                        While Reader.Read
                            Try
                                If (txt_Response1.Text = Trim(Reader(2)) And txt_Response2.Text = Trim(Reader(4)) And txt_Response3.Text = Trim(Reader(6))) Then
                                    Call UnBlock_Account()
                                    MsgBox("The account has been unblocked successfully.", vbInformation)
                                Else
                                    MsgBox("Sorry your Responses are incorrect.Try again.", vbCritical)
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
    Private Sub UnBlock_Account()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("UPDATE [UserDetails] SET Status = @Status, Attempt = @Attempt WHERE IDNumber = @IDNumber", conn)
                Try
                    With Command
                        .Parameters.Add("@Attempt", SqlDbType.Int).Value = 0
                        .Parameters.Add("@Status", SqlDbType.TinyInt).Value = 1
                        .Parameters.Add("@IDNumber", SqlDbType.Int).Value = SystemUserID
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
            End Using
        End Using
        Call Clear_Ctrls()
        Call log_in.AllowAccess()
        Call Loginpage()
    End Sub
    Private Sub Clear_Ctrls()
        ' Cmb_UserID.Text = Cmb_UserID.Items(0)
        Cmb_Question1.Text = Cmb_Question1.Items(0)
        Cmb_Question2.Text = Cmb_Question2.Items(0)
        Cmb_Question3.Text = Cmb_Question3.Items(0)
        txt_Response1.Clear()
        txt_Response2.Clear()
        txt_Response3.Clear()
    End Sub
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Call Clear_Ctrls()
    End Sub
    Private Sub Save()
        If (Cmb_UserID.Text = Cmb_UserID.Items(0)) Then
            MsgBox("User ID is null", vbCritical)
        Else
            If (Cmb_Question1.Text = Cmb_Question1.Items(0) Or Cmb_Question2.Text = Cmb_Question2.Items(0) Or Cmb_Question3.Text = Cmb_Question3.Items(0) Or txt_Response1.Text = "" Or txt_Response2.Text = "" Or txt_Response3.Text = "") Then
                MsgBox("Kindly fill out all the fields to continue.", vbCritical)
            Else
                Using conn As New SqlConnection(CONNECTION)
                    If (conn.State <> ConnectionState.Open) Then
                        conn.Open()
                    End If
                    Using Command As New SqlCommand("INSERT INTO [AccountRecovery] (AccountID, Question1, Response1, Question2, Response2, Question3, Response3) VALUES (@AccountID, @Question1, @Response1, @Question2, @Response2, @Question3, @Response3)", conn)
                        Try
                            With Command
                                .Parameters.Add("@AccountID", SqlDbType.Int).Value = Cmb_UserID.Text
                                .Parameters.Add("@Question1", SqlDbType.VarChar).Value = Cmb_Question1.Text
                                .Parameters.Add("@Response1", SqlDbType.VarChar).Value = txt_Response1.Text
                                .Parameters.Add("@Question2", SqlDbType.VarChar).Value = Cmb_Question2.Text
                                .Parameters.Add("@Response2", SqlDbType.VarChar).Value = txt_Response2.Text
                                .Parameters.Add("@Question3", SqlDbType.VarChar).Value = Cmb_Question3.Text
                                .Parameters.Add("@Response3", SqlDbType.VarChar).Value = txt_Response3.Text
                                .ExecuteNonQuery()
                                MsgBox("Details Saved.", vbInformation)
                            End With
                        Catch ex As SqlException
                            MsgBox(ex.Message, vbCritical)
                        End Try
                    End Using
                End Using
                Call Clear_Ctrls()
            End If
        End If
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Call Save()
    End Sub
    Private Sub load_UserID()
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [UserDetails]", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    Cmb_UserID.Items.Clear()
                    Cmb_UserID.Items.Add("Select User ID")
                    Cmb_UserID.Text = Cmb_UserID.Items(0)
                    Do While Reader.Read
                        Try
                            Cmb_UserID.Items.Add(Reader(6))
                        Catch ex As SqlException
                            MsgBox(ex.Message, vbCritical)
                        End Try
                    Loop
                End Using
            End Using
        End Using
    End Sub


End Class
