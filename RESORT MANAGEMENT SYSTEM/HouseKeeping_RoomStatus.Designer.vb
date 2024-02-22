<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HouseKeeping_RoomStatus
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Tab_Reservation = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Page_GuestStatus = New System.Windows.Forms.TabPage()
        Me.Page_HsKeepingStatus = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tab_Reservation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Reservation
        '
        Me.Tab_Reservation.Controls.Add(Me.Page_GuestStatus)
        Me.Tab_Reservation.Controls.Add(Me.Page_HsKeepingStatus)
        Me.Tab_Reservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tab_Reservation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Reservation.ItemSize = New System.Drawing.Size(150, 35)
        Me.Tab_Reservation.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Reservation.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab_Reservation.Name = "Tab_Reservation"
        Me.Tab_Reservation.SelectedIndex = 0
        Me.Tab_Reservation.ShowToolTips = True
        Me.Tab_Reservation.Size = New System.Drawing.Size(1141, 739)
        Me.Tab_Reservation.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Reservation.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Reservation.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Reservation.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Tab_Reservation.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Reservation.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Reservation.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Reservation.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Reservation.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Tab_Reservation.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Reservation.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Reservation.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Reservation.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Tab_Reservation.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Reservation.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Tab_Reservation.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tab_Reservation.TabButtonSize = New System.Drawing.Size(150, 35)
        Me.Tab_Reservation.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Reservation.TabIndex = 13
        Me.Tab_Reservation.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Reservation.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Page_GuestStatus
        '
        Me.Page_GuestStatus.BackColor = System.Drawing.Color.LightGray
        Me.Page_GuestStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_GuestStatus.Location = New System.Drawing.Point(4, 39)
        Me.Page_GuestStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_GuestStatus.Name = "Page_GuestStatus"
        Me.Page_GuestStatus.Size = New System.Drawing.Size(1133, 696)
        Me.Page_GuestStatus.TabIndex = 0
        Me.Page_GuestStatus.Text = "Guest Room Status"
        '
        'Page_HsKeepingStatus
        '
        Me.Page_HsKeepingStatus.BackColor = System.Drawing.Color.LightGray
        Me.Page_HsKeepingStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_HsKeepingStatus.Location = New System.Drawing.Point(4, 39)
        Me.Page_HsKeepingStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_HsKeepingStatus.Name = "Page_HsKeepingStatus"
        Me.Page_HsKeepingStatus.Size = New System.Drawing.Size(1133, 696)
        Me.Page_HsKeepingStatus.TabIndex = 1
        Me.Page_HsKeepingStatus.Text = "HouseKeeping Status"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'HouseKeeping_RoomStatus
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Tab_Reservation)
        Me.Name = "HouseKeeping_RoomStatus"
        Me.Size = New System.Drawing.Size(1141, 739)
        Me.Tab_Reservation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_Reservation As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Page_GuestStatus As TabPage
    Friend WithEvents Page_HsKeepingStatus As TabPage
    Friend WithEvents Timer1 As Timer
End Class
