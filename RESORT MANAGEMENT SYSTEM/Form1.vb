Imports System.Data.SqlClient
Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Initializer()
    End Sub
    Public Sub Initializer()
        Call HotelDetails()

    End Sub
    Public Sub Form_Position()
        Me.CenterToScreen()
    End Sub
    Private Sub HotelDetails()
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(SNo) FROM [Hotel]", conn)
                Dim SerialNumber As String = Command.ExecuteScalar().ToString()
                If (SerialNumber = "") Then
                    Call Open_AppLauncher()
                Else
                    If (Command.ExecuteScalar() = 1) Then
                        Using Command2 As New SqlCommand("SELECT * FROM [Hotel]", conn)
                            Using Reader As SqlDataReader = Command2.ExecuteReader()
                                While Reader.Read
                                    Dim Icon As Byte() = Reader(1)
                                    Dim stream As New MemoryStream(Icon)
                                    HotelLogo = System.Drawing.Image.FromStream(stream)
                                    HotelName = StrConv(Trim(Reader(2)), VbStrConv.Uppercase)
                                    HotelSlogan = StrConv(Trim(Reader(3)), VbStrConv.ProperCase)
                                    HotelEmail = StrConv(Trim(Reader(4)), VbStrConv.Lowercase)
                                    HotelAddress = StrConv(Trim(Reader(5)), VbStrConv.ProperCase)
                                    HotelLocation = StrConv(Trim(Reader(6)), VbStrConv.ProperCase)
                                    TelephoneLine1 = Reader(7)
                                    TelephoneLine2 = Reader(8)
                                    TelephoneLine3 = Reader(9)
                                End While
                            End Using
                        End Using
                    End If
                    Call Open_AppLauncher()
                End If
            End Using
        End Using
    End Sub
    Private Sub Open_AppLauncher()
        launch = New Applauncher
        With launch
            .Size = Me.Size
            .Dock = DockStyle.Fill
            .Initializer()
            .Pic_HotelIcon.Image = HotelLogo
        End With
        Me.Panel_Holder.Controls.Add(launch)
    End Sub
End Class
