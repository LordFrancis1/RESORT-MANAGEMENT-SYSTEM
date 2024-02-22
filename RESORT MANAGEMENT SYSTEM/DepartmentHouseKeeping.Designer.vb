<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepartmentHouseKeeping
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_ActionBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_RefreshModule = New Guna.UI2.WinForms.Guna2Button()
        Me.Lbl_HotelName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Tab_HouseKeeping = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Page_AddRooms = New System.Windows.Forms.TabPage()
        Me.Page_RoomInformation = New System.Windows.Forms.TabPage()
        Me.Page_HouseKeeperTasks = New System.Windows.Forms.TabPage()
        Me.Page_RoomStatus = New System.Windows.Forms.TabPage()
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ToolTip_Refresh = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ToolTip_HouseKeeping = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Guna2Panel1.SuspendLayout()
        Me.FLP_ActionBar.SuspendLayout()
        Me.Tab_HouseKeeping.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.FLP_ActionBar)
        Me.Guna2Panel1.Controls.Add(Me.Lbl_HotelName)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1406, 50)
        Me.Guna2Panel1.TabIndex = 14
        Me.Guna2Panel1.UseTransparentBackground = True
        '
        'FLP_ActionBar
        '
        Me.FLP_ActionBar.Controls.Add(Me.Btn_Exit)
        Me.FLP_ActionBar.Controls.Add(Me.Btn_RefreshModule)
        Me.FLP_ActionBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.FLP_ActionBar.Location = New System.Drawing.Point(0, 0)
        Me.FLP_ActionBar.Name = "FLP_ActionBar"
        Me.FLP_ActionBar.Size = New System.Drawing.Size(97, 50)
        Me.FLP_ActionBar.TabIndex = 69
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
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Exit, "Exit HouseKeeping")
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
        Me.ToolTip_Refresh.SetToolTip(Me.Btn_RefreshModule, "Refresh HouseKeeping")
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
        Me.Lbl_HotelName.Size = New System.Drawing.Size(1406, 50)
        Me.Lbl_HotelName.TabIndex = 67
        Me.Lbl_HotelName.Text = "Hotel Name"
        Me.Lbl_HotelName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tab_HouseKeeping
        '
        Me.Tab_HouseKeeping.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab_HouseKeeping.Controls.Add(Me.Page_AddRooms)
        Me.Tab_HouseKeeping.Controls.Add(Me.Page_RoomInformation)
        Me.Tab_HouseKeeping.Controls.Add(Me.Page_HouseKeeperTasks)
        Me.Tab_HouseKeeping.Controls.Add(Me.Page_RoomStatus)
        Me.Tab_HouseKeeping.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tab_HouseKeeping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_HouseKeeping.ItemSize = New System.Drawing.Size(150, 40)
        Me.Tab_HouseKeeping.Location = New System.Drawing.Point(0, 50)
        Me.Tab_HouseKeeping.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab_HouseKeeping.Name = "Tab_HouseKeeping"
        Me.Tab_HouseKeeping.SelectedIndex = 0
        Me.Tab_HouseKeeping.ShowToolTips = True
        Me.Tab_HouseKeeping.Size = New System.Drawing.Size(1406, 750)
        Me.Tab_HouseKeeping.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_HouseKeeping.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_HouseKeeping.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_HouseKeeping.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Tab_HouseKeeping.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_HouseKeeping.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_HouseKeeping.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_HouseKeeping.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_HouseKeeping.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Tab_HouseKeeping.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_HouseKeeping.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_HouseKeeping.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_HouseKeeping.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Tab_HouseKeeping.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_HouseKeeping.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Tab_HouseKeeping.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tab_HouseKeeping.TabButtonSize = New System.Drawing.Size(150, 40)
        Me.Tab_HouseKeeping.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_HouseKeeping.TabIndex = 15
        Me.Tab_HouseKeeping.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'Page_AddRooms
        '
        Me.Page_AddRooms.BackColor = System.Drawing.Color.LightGray
        Me.Page_AddRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_AddRooms.Location = New System.Drawing.Point(154, 4)
        Me.Page_AddRooms.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_AddRooms.Name = "Page_AddRooms"
        Me.Page_AddRooms.Size = New System.Drawing.Size(1248, 742)
        Me.Page_AddRooms.TabIndex = 0
        Me.Page_AddRooms.Text = "Room Additions"
        '
        'Page_RoomInformation
        '
        Me.Page_RoomInformation.Location = New System.Drawing.Point(154, 4)
        Me.Page_RoomInformation.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_RoomInformation.Name = "Page_RoomInformation"
        Me.Page_RoomInformation.Size = New System.Drawing.Size(1248, 742)
        Me.Page_RoomInformation.TabIndex = 1
        Me.Page_RoomInformation.Text = "Room Information"
        Me.Page_RoomInformation.UseVisualStyleBackColor = True
        '
        'Page_HouseKeeperTasks
        '
        Me.Page_HouseKeeperTasks.Location = New System.Drawing.Point(154, 4)
        Me.Page_HouseKeeperTasks.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_HouseKeeperTasks.Name = "Page_HouseKeeperTasks"
        Me.Page_HouseKeeperTasks.Size = New System.Drawing.Size(1248, 742)
        Me.Page_HouseKeeperTasks.TabIndex = 2
        Me.Page_HouseKeeperTasks.Text = "House Keeper Tasks"
        Me.Page_HouseKeeperTasks.UseVisualStyleBackColor = True
        '
        'Page_RoomStatus
        '
        Me.Page_RoomStatus.BackColor = System.Drawing.Color.LightGray
        Me.Page_RoomStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_RoomStatus.Location = New System.Drawing.Point(154, 4)
        Me.Page_RoomStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_RoomStatus.Name = "Page_RoomStatus"
        Me.Page_RoomStatus.Size = New System.Drawing.Size(1248, 742)
        Me.Page_RoomStatus.TabIndex = 4
        Me.Page_RoomStatus.Text = "Room Status"
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
        'ToolTip_Refresh
        '
        Me.ToolTip_Refresh.AllowLinksHandling = True
        Me.ToolTip_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip_Refresh.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Refresh.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Refresh.ForeColor = System.Drawing.Color.Black
        Me.ToolTip_Refresh.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'ToolTip_HouseKeeping
        '
        Me.ToolTip_HouseKeeping.AllowLinksHandling = True
        Me.ToolTip_HouseKeeping.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolTip_HouseKeeping.BorderColor = System.Drawing.Color.Black
        Me.ToolTip_HouseKeeping.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_HouseKeeping.ForeColor = System.Drawing.Color.Black
        Me.ToolTip_HouseKeeping.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'DepartmentHouseKeeping
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Tab_HouseKeeping)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "DepartmentHouseKeeping"
        Me.Size = New System.Drawing.Size(1406, 800)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.FLP_ActionBar.ResumeLayout(False)
        Me.Tab_HouseKeeping.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_HotelName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Tab_HouseKeeping As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Page_AddRooms As TabPage
    Friend WithEvents Page_RoomInformation As TabPage
    Friend WithEvents Page_HouseKeeperTasks As TabPage
    Friend WithEvents Page_RoomStatus As TabPage
    Friend WithEvents FLP_ActionBar As FlowLayoutPanel
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_RefreshModule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_Refresh As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_HouseKeeping As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
