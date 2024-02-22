Imports System.Data.SqlClient
Imports System.IO
Public Class PrintModule
    Public Sub Initializer()
        Call HotelDetails()
        Call Generate_ReceiptType()
        Call FetchCustomer()
        Timer1.Start()

    End Sub
    Private Sub PrintModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub HotelDetails()
        'HEADER DETAILS
        Pic_HotelIcon.Image = HotelLogo
        Lbl_HotelName.Text = HotelName
        Lbl_HotelSlogan.Text = "..." & HotelSlogan & "..."
        Lbl_HotelAddress.Text = "P.O BOX " & HotelAddress & " " & HotelLocation
        Lbl_HotelContacts.Text = "+254 " & TelephoneLine1
        If (TelephoneLine2 <> 0) Then
            Lbl_HotelContacts.Text = Lbl_HotelContacts.Text & ", +254 " & TelephoneLine2
        Else
            Lbl_HotelContacts.Text = Lbl_HotelContacts.Text
        End If
        If (TelephoneLine3 <> 0) Then
            Lbl_HotelContacts.Text = Lbl_HotelContacts.Text & ", +254 " & TelephoneLine3
        Else
            Lbl_HotelContacts.Text = Lbl_HotelContacts.Text
        End If
        Lbl_ReceiptType.Text = ReceiptType
        'FOOTER DETAILS
        Lbl_ServedBy.Text = Lbl_ServedBy.Text & " " & SystemUserName
    End Sub
    Private Sub Generate_ReceiptType()
        Select Case ReceiptType
            Case "Booking Receipt"
                MsgBox("Booking Receipt", vbInformation)
            Case "Restaurant Receipt"
                MsgBox("Restaurant Receipt", vbInformation)
            Case "General Receipt"
                MsgBox("General Receipt", vbInformation)
        End Select
    End Sub
    Private Sub FetchCustomer()
        Using conn As New SqlConnection(CONNECTION)
            If (conn.State <> ConnectionState.Open) Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT * FROM [GuestIn] WHERE SerialNumber = '" & GradientButton.Name & "'", conn)
                Using Reader As SqlDataReader = Command.ExecuteReader()
                    While Reader.Read
                        Lbl_CustomerName.Text = Trim(Reader(1))

                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Form5.Dispose()
    End Sub
    '
    '||TIMER EFFECTS
    '
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_DateTime.Text = "DATE TIME : " & Date.Now.ToShortDateString() & " " & Date.Now.ToString("HH:m:ss:tt")
    End Sub
End Class
