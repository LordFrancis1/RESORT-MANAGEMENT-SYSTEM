Imports System.Data.SqlClient
Imports System.IO

Public Class Applauncher
    Dim Counter As Integer
    Private Sub launch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Initializer()
        Form1.Text = "Loading..."
        Form1.Panel_Holder.BackgroundImage = My.Resources.Theme_8
        Btn_Begin.Visible = False
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Counter <= 100) Then
            Counter += 1
            Prg_Launch.Value = Counter
            Prg_Launch.Text = Prg_Launch.Value
        End If
        If (Counter >= 100) Then
            Timer1.Stop()
            Counter = Nothing
            Btn_Begin.Visible = True
        End If
    End Sub
    Private Sub Introduction()
        Form1.Panel_Holder.BackgroundImage = Nothing
        Form1.Panel_Holder.Controls.Clear()
        Form1.Text = "Introduction"
        Intro = New AppIntroduction
        With Intro
            .Size = Form1.Size
            .Dock = DockStyle.Fill
            .Initializer()
        End With
        Form1.Panel_Holder.Controls.Add(Intro)
    End Sub
    Public Sub Homepage()
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
    Private Sub Btn_Begin_Click(sender As Object, e As EventArgs) Handles Btn_Begin.Click
        Using conn As New SqlConnection(CONNECTION)
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Using Command As New SqlCommand("SELECT MAX(SNo) FROM [Hotel]", conn)
                Dim SerialNumber As String = Command.ExecuteScalar().ToString()
                If (SerialNumber = "") Then
                    Call Introduction()
                Else
                    If (Command.ExecuteScalar() = 1) Then
                        Call Homepage()
                    End If
                End If
            End Using
        End Using
    End Sub
End Class
