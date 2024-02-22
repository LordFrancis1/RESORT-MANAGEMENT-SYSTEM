<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepartmentReservation
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
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_RefreshModule = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip_Reservation = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Panel_Top = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_ActionBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbl_HotelName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Tab_Reservation = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Page_CheckIn = New System.Windows.Forms.TabPage()
        Me.Page_CheckOut = New System.Windows.Forms.TabPage()
        Me.Page_DueIn = New System.Windows.Forms.TabPage()
        Me.Page_GuestAllocation = New System.Windows.Forms.TabPage()
        Me.Page_GuestRooms = New System.Windows.Forms.TabPage()
        Me.ToolTip_Refresh = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Panel_Top.SuspendLayout()
        Me.FLP_ActionBar.SuspendLayout()
        Me.Tab_Reservation.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip_Exit
        '
        Me.ToolTip_Exit.AllowLinksHandling = True
        Me.ToolTip_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip_Exit.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Exit.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Exit.ForeColor = System.Drawing.Color.Black
        Me.ToolTip_Exit.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Animated = True
        Me.Btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.BorderColor = System.Drawing.Color.White
        Me.Btn_Exit.BorderRadius = 5
        Me.Btn_Exit.BorderThickness = 1
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Exit.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Exit.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Exit.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Exit.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Exit.TabIndex = 65
        Me.Btn_Exit.Text = "X"
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Exit, "Exit Reservation")
        '
        'Btn_RefreshModule
        '
        Me.Btn_RefreshModule.Animated = True
        Me.Btn_RefreshModule.BackColor = System.Drawing.Color.Transparent
        Me.Btn_RefreshModule.BorderColor = System.Drawing.Color.White
        Me.Btn_RefreshModule.BorderRadius = 5
        Me.Btn_RefreshModule.BorderThickness = 1
        Me.Btn_RefreshModule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_RefreshModule.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_RefreshModule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_RefreshModule.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_RefreshModule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_RefreshModule.FillColor = System.Drawing.Color.Transparent
        Me.Btn_RefreshModule.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_RefreshModule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_RefreshModule.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_RefreshModule.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_RefreshModule.HoverState.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_RefreshModule.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Refresh
        Me.Btn_RefreshModule.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_RefreshModule.Location = New System.Drawing.Point(49, 3)
        Me.Btn_RefreshModule.Name = "Btn_RefreshModule"
        Me.Btn_RefreshModule.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_RefreshModule.Size = New System.Drawing.Size(40, 40)
        Me.Btn_RefreshModule.TabIndex = 66
        Me.ToolTip_Refresh.SetToolTip(Me.Btn_RefreshModule, "Refresh Reservation")
        '
        'ToolTip_Reservation
        '
        Me.ToolTip_Reservation.AllowLinksHandling = True
        Me.ToolTip_Reservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolTip_Reservation.BorderColor = System.Drawing.Color.Black
        Me.ToolTip_Reservation.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Reservation.ForeColor = System.Drawing.Color.Black
        Me.ToolTip_Reservation.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Top.BorderColor = System.Drawing.Color.White
        Me.Panel_Top.BorderRadius = 5
        Me.Panel_Top.BorderThickness = 1
        Me.Panel_Top.Controls.Add(Me.FLP_ActionBar)
        Me.Panel_Top.Controls.Add(Me.Lbl_HotelName)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1473, 50)
        Me.Panel_Top.TabIndex = 12
        Me.Panel_Top.UseTransparentBackground = True
        '
        'FLP_ActionBar
        '
        Me.FLP_ActionBar.Controls.Add(Me.Btn_Exit)
        Me.FLP_ActionBar.Controls.Add(Me.Btn_RefreshModule)
        Me.FLP_ActionBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.FLP_ActionBar.Location = New System.Drawing.Point(0, 0)
        Me.FLP_ActionBar.Name = "FLP_ActionBar"
        Me.FLP_ActionBar.Size = New System.Drawing.Size(95, 50)
        Me.FLP_ActionBar.TabIndex = 68
        '
        'Lbl_HotelName
        '
        Me.Lbl_HotelName.AutoSize = False
        Me.Lbl_HotelName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_HotelName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_HotelName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_HotelName.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_HotelName.ForeColor = System.Drawing.Color.White
        Me.Lbl_HotelName.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_HotelName.Name = "Lbl_HotelName"
        Me.Lbl_HotelName.Size = New System.Drawing.Size(1473, 50)
        Me.Lbl_HotelName.TabIndex = 67
        Me.Lbl_HotelName.Text = "Hotel Name"
        Me.Lbl_HotelName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tab_Reservation
        '
        Me.Tab_Reservation.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab_Reservation.Controls.Add(Me.Page_CheckIn)
        Me.Tab_Reservation.Controls.Add(Me.Page_CheckOut)
        Me.Tab_Reservation.Controls.Add(Me.Page_DueIn)
        Me.Tab_Reservation.Controls.Add(Me.Page_GuestAllocation)
        Me.Tab_Reservation.Controls.Add(Me.Page_GuestRooms)
        Me.Tab_Reservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tab_Reservation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Reservation.ItemSize = New System.Drawing.Size(150, 40)
        Me.Tab_Reservation.Location = New System.Drawing.Point(0, 50)
        Me.Tab_Reservation.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab_Reservation.Name = "Tab_Reservation"
        Me.Tab_Reservation.SelectedIndex = 0
        Me.Tab_Reservation.ShowToolTips = True
        Me.Tab_Reservation.Size = New System.Drawing.Size(1473, 850)
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
        Me.Tab_Reservation.TabButtonSize = New System.Drawing.Size(150, 40)
        Me.Tab_Reservation.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Reservation.TabIndex = 13
        Me.Tab_Reservation.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'Page_CheckIn
        '
        Me.Page_CheckIn.BackColor = System.Drawing.Color.LightGray
        Me.Page_CheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_CheckIn.Location = New System.Drawing.Point(154, 4)
        Me.Page_CheckIn.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_CheckIn.Name = "Page_CheckIn"
        Me.Page_CheckIn.Size = New System.Drawing.Size(1315, 842)
        Me.Page_CheckIn.TabIndex = 0
        Me.Page_CheckIn.Text = "Guest Check Ins"
        '
        'Page_CheckOut
        '
        Me.Page_CheckOut.BackColor = System.Drawing.Color.LightGray
        Me.Page_CheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_CheckOut.Location = New System.Drawing.Point(154, 4)
        Me.Page_CheckOut.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_CheckOut.Name = "Page_CheckOut"
        Me.Page_CheckOut.Size = New System.Drawing.Size(1315, 842)
        Me.Page_CheckOut.TabIndex = 1
        Me.Page_CheckOut.Text = "Guest Check Outs"
        '
        'Page_DueIn
        '
        Me.Page_DueIn.BackColor = System.Drawing.Color.LightGray
        Me.Page_DueIn.Location = New System.Drawing.Point(154, 4)
        Me.Page_DueIn.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_DueIn.Name = "Page_DueIn"
        Me.Page_DueIn.Size = New System.Drawing.Size(1315, 842)
        Me.Page_DueIn.TabIndex = 2
        Me.Page_DueIn.Text = "Guest Due Ins"
        '
        'Page_GuestAllocation
        '
        Me.Page_GuestAllocation.BackColor = System.Drawing.Color.LightGray
        Me.Page_GuestAllocation.Location = New System.Drawing.Point(154, 4)
        Me.Page_GuestAllocation.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_GuestAllocation.Name = "Page_GuestAllocation"
        Me.Page_GuestAllocation.Size = New System.Drawing.Size(1315, 842)
        Me.Page_GuestAllocation.TabIndex = 3
        Me.Page_GuestAllocation.Text = "Guest Allocations"
        '
        'Page_GuestRooms
        '
        Me.Page_GuestRooms.BackColor = System.Drawing.Color.LightGray
        Me.Page_GuestRooms.Location = New System.Drawing.Point(154, 4)
        Me.Page_GuestRooms.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_GuestRooms.Name = "Page_GuestRooms"
        Me.Page_GuestRooms.Size = New System.Drawing.Size(1315, 842)
        Me.Page_GuestRooms.TabIndex = 4
        Me.Page_GuestRooms.Text = "Guest Rooms"
        '
        'ToolTip_Refresh
        '
        Me.ToolTip_Refresh.AllowLinksHandling = True
        Me.ToolTip_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip_Refresh.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Refresh.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Refresh.ForeColor = System.Drawing.Color.Black
        Me.ToolTip_Refresh.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'DepartmentReservation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Tab_Reservation)
        Me.Controls.Add(Me.Panel_Top)
        Me.Name = "DepartmentReservation"
        Me.Size = New System.Drawing.Size(1473, 900)
        Me.Panel_Top.ResumeLayout(False)
        Me.FLP_ActionBar.ResumeLayout(False)
        Me.Tab_Reservation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgr_icon As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_Reservation As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Panel_Top As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Tab_Reservation As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Page_CheckIn As TabPage
    Friend WithEvents Page_CheckOut As TabPage
    Friend WithEvents Page_DueIn As TabPage
    Friend WithEvents Page_GuestAllocation As TabPage
    Friend WithEvents Page_GuestRooms As TabPage
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Lbl_HotelName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FLP_ActionBar As FlowLayoutPanel
    Friend WithEvents Btn_RefreshModule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip_Refresh As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
