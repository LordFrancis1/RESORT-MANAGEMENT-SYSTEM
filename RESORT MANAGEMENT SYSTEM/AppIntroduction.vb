Imports System.Data.SqlClient
Imports System.IO
Imports System.Web

Public Class AppIntroduction
    Dim Icone() As Byte

    Private Sub Introduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Lbl_Inform.Left = Panel_Top.Right
        Timer1.Start()

    End Sub
    Private Sub Btn_Off_Click(sender As Object, e As EventArgs) Handles Btn_Off.Click
        Dim Result As MsgBoxResult
        Result = MsgBox("Are you sure you want to exit the application?", vbYesNo + vbInformation)
        If (Result = vbYes) Then
            Application.Exit()
        End If
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

    Private Sub Btn_BrowseIcon_Click(sender As Object, e As EventArgs) Handles Btn_BrowseIcon.Click
        Dim summon As DialogResult = OpenFileDialog1.ShowDialog
        If (summon = Windows.Forms.DialogResult.OK) Then
            If (OpenFileDialog1.FileName IsNot Nothing) Or (OpenFileDialog1.FileName <> String.Empty) Then
                Pic_Icon.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        End If
    End Sub
    Private Sub Clear_Ctrls()
        Pic_Icon.Image = Nothing
        Txt_hotelname.Clear()
        Txt_HotelSlogan.Clear()
        Txt_Email.Clear()
        Txt_Address.Clear()
        Txt_Location.Clear()
        Txt_TelephoneLine1.Clear()
        Txt_TelephoneLine2.Clear()
        Txt_TelephoneLine3.Clear()
    End Sub
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Call Clear_Ctrls()
    End Sub
    Private Sub Image_Conversion()
        'convert image to binary format
        Dim filesize As New UInt32
        Dim mstream As New MemoryStream()
        Pic_Icon.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Icone = mstream.GetBuffer
        filesize = mstream.Length
        mstream.Close()
    End Sub
    Private Sub save()
        If (Pic_Icon.Image Is Nothing And Txt_hotelname.Text = "" And Txt_HotelSlogan.Text = "" And Txt_Email.Text = "" And Txt_Address.Text = "" And Txt_Location.Text = "" And Txt_TelephoneLine1.Text = "") Then
            MsgBox("Kindly fill in all the required fields.", vbCritical)
        Else
            Call Image_Conversion()
            Using conn As New SqlConnection(CONNECTION)
                If (conn.State <> ConnectionState.Open) Then
                    conn.Open()
                End If
                Using Command As New SqlCommand("INSERT INTO [Hotel] (SNo, HotelLogo, HotelName, HotelSlogan, HotelEmail, HotelAddress, Location, TelephoneLine1, TelephoneLine2, TelephoneLine3) VALUES (@SNo, @HotelLogo, @HotelName, @HotelSlogan, @HotelEmail, @HotelAddress, @Location, @TelephoneLine1, @TelephoneLine2, @TelephoneLine3)", conn)
                    Try
                        With Command
                            .Parameters.Add("@SNo", SqlDbType.Int).Value = 1
                            .Parameters.Add("@HotelLogo", SqlDbType.Image).Value = Icone
                            .Parameters.Add("@HotelName", SqlDbType.VarChar).Value = Txt_hotelname.Text
                            .Parameters.Add("@HotelSlogan", SqlDbType.VarChar).Value = Txt_HotelSlogan.Text
                            .Parameters.Add("@HotelEmail", SqlDbType.VarChar).Value = Txt_Email.Text
                            .Parameters.Add("@HotelAddress", SqlDbType.VarChar).Value = Txt_Address.Text
                            .Parameters.Add("@Location", SqlDbType.VarChar).Value = Txt_Location.Text
                            .Parameters.Add("@TelephoneLine1", SqlDbType.Int).Value = CInt(Txt_TelephoneLine1.Text)
                            If (Txt_TelephoneLine2.Text = "") Then
                                .Parameters.Add("@TelephoneLine2", SqlDbType.Int).Value = 0
                            Else
                                .Parameters.Add("@TelephoneLine2", SqlDbType.Int).Value = CInt(Txt_TelephoneLine2.Text)
                            End If
                            If (Txt_TelephoneLine3.Text = "") Then
                                .Parameters.Add("@TelephoneLine3", SqlDbType.Int).Value = 0
                            Else
                                .Parameters.Add("@TelephoneLine3", SqlDbType.Int).Value = CInt(Txt_TelephoneLine3.Text)
                            End If
                            .ExecuteNonQuery()
                            MsgBox("Hotel Details Saved.", vbInformation)
                        End With
                    Catch ex As SqlException
                        MsgBox(ex.Message, vbCritical)
                    End Try
                End Using
            End Using
        End If
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Call save()
        Call Clear_Ctrls()
        Call launch.Homepage()
    End Sub
    '
    '||TIMER EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_Inform.Right >= Panel_Top.Left) Then
            Lbl_Inform.Left -= 1
        Else
            Lbl_Inform.Left = Panel_Top.Right
        End If
    End Sub
End Class
