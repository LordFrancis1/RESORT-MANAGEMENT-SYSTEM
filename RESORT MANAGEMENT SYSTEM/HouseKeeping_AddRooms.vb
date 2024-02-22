Imports System.Data.SqlClient
Imports System.IO
Public Class HouseKeeping_AddRooms
    Dim RoomPhoto() As Byte
    Dim RoomTypeIndex As Integer
    Public Sub Initializer()
        Call Clear_Ctrls()
        Call SystemUser()
        Btn_RoomPicture.HoverState.Image = HotelLogo

    End Sub
    Private Sub HouseKeeping_AddRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SystemUser()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [UserDetails]", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Txt_SystemUser.Enabled = True
                        Txt_SystemUser.Text = Trim(Reader(3)) & " " & Trim(Reader(4)) & " " & Trim(Reader(5))
                        Txt_SystemUser.Enabled = False
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Btn_AutoGenRoomNo_Click(sender As Object, e As EventArgs) Handles Btn_AutoGenRoomNo.Click
        Txt_RoomNo.Enabled = True
        Call Generate_Userid()
        Txt_RoomNo.Enabled = False
    End Sub
    Private Sub Generate_Userid()
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(RoomNumber) FROM [HotelRoom]", conn)
                Dim TempHolder_RoomNumber As String = Command.ExecuteScalar().ToString()
                Dim Max_RoomNo As Integer
                If (TempHolder_RoomNumber = "") Then
                    Max_RoomNo = 1
                    Txt_RoomNo.Text = Max_RoomNo
                ElseIf (TempHolder_RoomNumber <> "") Then
                    Max_RoomNo = Command.ExecuteScalar()
                    Do While (Max_RoomNo <= 10000)
                        Max_RoomNo += 1
                        Txt_RoomNo.Text = Max_RoomNo
                        Exit Do
                    Loop
                End If
            End Using
        End Using
    End Sub
    Private Sub Cmb_RoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_RoomType.SelectedIndexChanged
        If (Cmb_RoomType.Text = Cmb_RoomType.Items(0)) Then
            lbl_RoomType.Text = "Room Type"
        Else
            lbl_RoomType.Text = Cmb_RoomType.Text
            If (Cmb_RoomType.Text = Cmb_RoomType.Items(1)) Then
                RoomTypeIndex = 1
            ElseIf (Cmb_RoomType.Text = Cmb_RoomType.Items(2)) Then
                RoomTypeIndex = 2
            ElseIf (Cmb_RoomType.Text = Cmb_RoomType.Items(3)) Then
                RoomTypeIndex = 3
            ElseIf (Cmb_RoomType.Text = Cmb_RoomType.Items(4)) Then
                RoomTypeIndex = 4
            ElseIf (Cmb_RoomType.Text = Cmb_RoomType.Items(5)) Then
                RoomTypeIndex = 5
            ElseIf (Cmb_RoomType.Text = Cmb_RoomType.Items(6)) Then
                RoomTypeIndex = 6
            ElseIf (Cmb_RoomType.Text = Cmb_RoomType.Items(7)) Then
                RoomTypeIndex = 7
            End If
        End If
    End Sub
    Private Sub Load_RoomPhoto()
        Dim summon As DialogResult = OpenFileDialog1.ShowDialog
        If (summon = Windows.Forms.DialogResult.OK) Then
            If (OpenFileDialog1.FileName IsNot Nothing) Or (OpenFileDialog1.FileName <> String.Empty) Then
                Btn_RoomPicture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        End If
    End Sub
    Private Sub Btn_BrowseHotelRoom_Click(sender As Object, e As EventArgs) Handles Btn_BrowseHotelRoom.Click
        Call Load_RoomPhoto()
    End Sub
    Private Sub Btn_RoomPicture_Click(sender As Object, e As EventArgs) Handles Btn_RoomPicture.Click
        Call Load_RoomPhoto()
    End Sub
    Private Sub Clear_Ctrls()
        Txt_RoomNo.Enabled = True
        Txt_RoomNo.Clear()
        Txt_RoomNo.Enabled = False
        Cmb_RoomType.Text = Cmb_RoomType.Items(0)
        Dat_DateRegistered.Value = Date.Today
        Txt_RoomPrice.Clear()
        Cmb_RoomDescription.Text = Cmb_RoomDescription.Items(0)
        Btn_RoomPicture.Image = My.Resources.imageicon
    End Sub
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Call Clear_Ctrls()
    End Sub
    Private Sub Image_Conversion()
        'convert image to binary format
        Dim filesize As New UInt32
        Dim mstream As New MemoryStream()
        Btn_RoomPicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        RoomPhoto = mstream.GetBuffer
        filesize = mstream.Length
        mstream.Close()
    End Sub
    Private Sub SaveRooms()
        Call Image_Conversion()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("INSERT INTO [HotelRoom] (RoomNumber, RoomType, RoomTypeIndex, RoomPhoto, RoomPrice, RoomDescription, DateRegistered, RegisteredBy, RoomStatus) VALUES (@RoomNumber, @RoomType, @RoomTypeIndex, @RoomPhoto, @RoomPrice, @RoomDescription, @DateRegistered, @RegisteredBy, @RoomStatus)", conn)
                Try
                    With Command
                        .Parameters.Add("@RoomNumber", SqlDbType.Int).Value = Txt_RoomNo.Text
                        .Parameters.Add("@RoomType", SqlDbType.VarChar).Value = Cmb_RoomType.Text
                        .Parameters.Add("@RoomTypeIndex", SqlDbType.Int).Value = RoomTypeIndex
                        .Parameters.Add("@RoomPhoto", SqlDbType.Image).Value = RoomPhoto
                        .Parameters.Add("@RoomPrice", SqlDbType.Decimal).Value = Txt_RoomPrice.Text
                        .Parameters.Add("@RoomDescription", SqlDbType.VarChar).Value = Cmb_RoomDescription.Text
                        .Parameters.Add("@DateRegistered", SqlDbType.DateTime).Value = Dat_DateRegistered.Value
                        .Parameters.Add("@RegisteredBy", SqlDbType.VarChar).Value = Txt_SystemUser.Text
                        .Parameters.Add("@RoomStatus", SqlDbType.TinyInt).Value = 0
                        .ExecuteNonQuery()
                        MsgBox("New Room Saved.", vbInformation)
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message, vbCritical)
                End Try
            End Using
        End Using
        Call Clear_Ctrls()
    End Sub
    Private Sub Btn_AddRoom_Click(sender As Object, e As EventArgs) Handles Btn_AddRoom.Click
        If (Btn_RoomPicture.Image Is My.Resources.imageicon Or Txt_RoomNo.Text = "" Or Cmb_RoomType.Text = Cmb_RoomType.Items(0) Or Txt_RoomPrice.Text = "" Or Cmb_RoomDescription.Text = Cmb_RoomDescription.Items(0)) Then
            MsgBox("Ensure all fields are filled to proceed.", vbCritical)
        Else
            Call SaveRooms()
        End If
    End Sub
End Class
