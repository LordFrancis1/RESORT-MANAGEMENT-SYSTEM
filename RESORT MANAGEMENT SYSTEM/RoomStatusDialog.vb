Imports System.Data.SqlClient
Imports System.IO

Public Class RoomStatusDialog
    Public Sub Initializer()
        Lbl_Inform.Left = Panel_Title.Right
        Call HotelDetails()
        Call RoomInfo()
        Timer1.Start()
    End Sub
    Private Sub RoomStatusDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub HotelDetails()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [Hotel]", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Lbl_Inform.Text = StrConv(Trim(Reader(2)), VbStrConv.ProperCase)
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub RoomInfo()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [HotelRoom] WHERE RoomNumber = '" & ImageButton.Name & "' ", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        'Convert from binary to image file
                        Dim Pic As Byte() = Reader(3)
                        Dim stream As New MemoryStream(Pic)
                        Pic_Room.Image = System.Drawing.Image.FromStream(stream)
                        Lbl_Inform.Text = Lbl_Inform.Text & " " & StrConv(Trim(Reader(1)), VbStrConv.ProperCase)
                        Lbl_RoomType.Text = StrConv(Trim(Reader(1)), VbStrConv.Uppercase)
                        Lbl_RoomDescription.Text = Trim(Reader(5))
                        Lbl_RoomPrice.Text = "Ksh " & Reader(4) & " Per Night."
                        If (Reader(8) = 0) Then

                        Else

                        End If
                    End While
                End Using
            End Using
        End Using
        Call RoomInfo2()
    End Sub
    Private Sub RoomInfo2()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT COUNT(*) FROM [HotelRoom] WHERE RoomType = '" & Trim(Lbl_RoomType.Text) & "' ", conn)
                Lbl_NumberOfRooms.Text = Command.ExecuteScalar().ToString() & "  Available Room(s)."
            End Using
        End Using
    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Form4.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Lbl_Inform.Right >= Panel_Title.Left) Then
            Lbl_Inform.Left -= 2
        Else
            Lbl_Inform.Left = Panel_Title.Right
        End If
    End Sub
End Class
