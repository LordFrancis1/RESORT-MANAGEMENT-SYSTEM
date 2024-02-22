Public Class SignUpDisplay
    Public Sub Initializer()
        Pic_Icon.Image = HotelLogo
        Lbl_HotelName.Text = HotelName
        lbl_Slogan.Text = HotelSlogan
        Call SignUp_Form()
    End Sub
    Private Sub SignUpDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Count_Users()

    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
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
    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click
        If (Form1.WindowState = FormWindowState.Maximized) Then
            Form1.Size = New Size(1300, 800)
            Form1.WindowState = FormWindowState.Normal
            Call Form1.Form_Position()
        Else
            Form1.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click
        Form1.WindowState = FormWindowState.Minimized

    End Sub
    Private Sub SignUp_Form()
        Panel_Holder.Controls.Clear()
        sign_up = New SignUpForm
        With sign_up
            .Size = Form1.Size
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Panel_Holder.Controls.Add(sign_up)
    End Sub
    Public Sub AccountRecoveryProtocols()
        AccountQuest = "Setup"
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
    End Sub

    Private Sub Btn_AccountRecovery_Click(sender As Object, e As EventArgs) Handles Btn_AccountRecovery.Click
        Call AccountRecoveryProtocols()
    End Sub
End Class
