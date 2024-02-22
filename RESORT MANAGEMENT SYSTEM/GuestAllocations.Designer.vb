<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestAllocations
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tab_Allocations = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Page_Allocated = New System.Windows.Forms.TabPage()
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_GuestButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_AllRooms = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel_Menu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Email = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Btn_SMS = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Page_Pendings = New System.Windows.Forms.TabPage()
        Me.Dgv_PendingAllocations = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ToolTip_Email = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ToolTip_SMS = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Tab_Allocations.SuspendLayout()
        Me.Page_Allocated.SuspendLayout()
        Me.Panel_Holder.SuspendLayout()
        Me.FLP_GuestButtons.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        Me.Page_Pendings.SuspendLayout()
        CType(Me.Dgv_PendingAllocations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Tab_Allocations
        '
        Me.Tab_Allocations.Controls.Add(Me.Page_Allocated)
        Me.Tab_Allocations.Controls.Add(Me.Page_Pendings)
        Me.Tab_Allocations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tab_Allocations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Allocations.ItemSize = New System.Drawing.Size(150, 35)
        Me.Tab_Allocations.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Allocations.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab_Allocations.Name = "Tab_Allocations"
        Me.Tab_Allocations.SelectedIndex = 0
        Me.Tab_Allocations.ShowToolTips = True
        Me.Tab_Allocations.Size = New System.Drawing.Size(1139, 757)
        Me.Tab_Allocations.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Allocations.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Allocations.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Allocations.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Tab_Allocations.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Allocations.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Allocations.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Allocations.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Allocations.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Tab_Allocations.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Allocations.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Allocations.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Allocations.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Tab_Allocations.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Allocations.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Tab_Allocations.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tab_Allocations.TabButtonSize = New System.Drawing.Size(150, 35)
        Me.Tab_Allocations.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Allocations.TabIndex = 12
        Me.Tab_Allocations.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Allocations.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Page_Allocated
        '
        Me.Page_Allocated.BackColor = System.Drawing.Color.LightGray
        Me.Page_Allocated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_Allocated.Controls.Add(Me.Panel_Holder)
        Me.Page_Allocated.Controls.Add(Me.Panel_Menu)
        Me.Page_Allocated.Location = New System.Drawing.Point(4, 39)
        Me.Page_Allocated.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_Allocated.Name = "Page_Allocated"
        Me.Page_Allocated.Size = New System.Drawing.Size(1131, 714)
        Me.Page_Allocated.TabIndex = 0
        Me.Page_Allocated.Text = "Already Allocated"
        '
        'Panel_Holder
        '
        Me.Panel_Holder.Controls.Add(Me.FLP_GuestButtons)
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(1096, 714)
        Me.Panel_Holder.TabIndex = 19
        '
        'FLP_GuestButtons
        '
        Me.FLP_GuestButtons.AutoScroll = True
        Me.FLP_GuestButtons.Controls.Add(Me.Btn_AllRooms)
        Me.FLP_GuestButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_GuestButtons.Location = New System.Drawing.Point(0, 0)
        Me.FLP_GuestButtons.Name = "FLP_GuestButtons"
        Me.FLP_GuestButtons.Size = New System.Drawing.Size(1096, 714)
        Me.FLP_GuestButtons.TabIndex = 20
        '
        'Btn_AllRooms
        '
        Me.Btn_AllRooms.Animated = True
        Me.Btn_AllRooms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AllRooms.BorderRadius = 5
        Me.Btn_AllRooms.BorderThickness = 2
        Me.Btn_AllRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AllRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AllRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_AllRooms.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_AllRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_AllRooms.FillColor = System.Drawing.Color.Transparent
        Me.Btn_AllRooms.FillColor2 = System.Drawing.Color.Transparent
        Me.Btn_AllRooms.Font = New System.Drawing.Font("Garamond", 15.75!)
        Me.Btn_AllRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AllRooms.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_AllRooms.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Btn_AllRooms.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Btn_AllRooms.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllRooms.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_AllRooms.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.HotelIcon
        Me.Btn_AllRooms.ImageSize = New System.Drawing.Size(70, 60)
        Me.Btn_AllRooms.Location = New System.Drawing.Point(3, 3)
        Me.Btn_AllRooms.Name = "Btn_AllRooms"
        Me.Btn_AllRooms.PressedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AllRooms.Size = New System.Drawing.Size(330, 150)
        Me.Btn_AllRooms.TabIndex = 54
        Me.Btn_AllRooms.Text = " ROOM 1 SINGLE ROOM Guest Name"
        '
        'Panel_Menu
        '
        Me.Panel_Menu.Controls.Add(Me.Btn_Email)
        Me.Panel_Menu.Controls.Add(Me.Btn_SMS)
        Me.Panel_Menu.Controls.Add(Me.Btn_Exit)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Menu.Location = New System.Drawing.Point(1096, 0)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(35, 714)
        Me.Panel_Menu.TabIndex = 18
        '
        'Btn_Email
        '
        Me.Btn_Email.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Btn_Email.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Email.HoverState.ImageSize = New System.Drawing.Size(35, 35)
        Me.Btn_Email.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Mail
        Me.Btn_Email.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Btn_Email.ImageRotate = 0!
        Me.Btn_Email.ImageSize = New System.Drawing.Size(35, 35)
        Me.Btn_Email.Location = New System.Drawing.Point(0, 70)
        Me.Btn_Email.Name = "Btn_Email"
        Me.Btn_Email.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Btn_Email.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Email.TabIndex = 59
        Me.ToolTip_Email.SetToolTip(Me.Btn_Email, "Send An Email")
        '
        'Btn_SMS
        '
        Me.Btn_SMS.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Btn_SMS.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_SMS.HoverState.ImageSize = New System.Drawing.Size(35, 35)
        Me.Btn_SMS.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.SMS
        Me.Btn_SMS.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Btn_SMS.ImageRotate = 0!
        Me.Btn_SMS.ImageSize = New System.Drawing.Size(45, 45)
        Me.Btn_SMS.Location = New System.Drawing.Point(0, 35)
        Me.Btn_SMS.Name = "Btn_SMS"
        Me.Btn_SMS.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Btn_SMS.Size = New System.Drawing.Size(35, 35)
        Me.Btn_SMS.TabIndex = 58
        Me.ToolTip_SMS.SetToolTip(Me.Btn_SMS, "Send a Message")
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Animated = True
        Me.Btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.BorderColor = System.Drawing.Color.DimGray
        Me.Btn_Exit.BorderRadius = 5
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Exit.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Exit.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Exit.HoverState.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Exit.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Exit.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Exit.TabIndex = 56
        Me.Btn_Exit.Text = "X"
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Exit, "Exit GuestBoard")
        '
        'Page_Pendings
        '
        Me.Page_Pendings.BackColor = System.Drawing.Color.LightGray
        Me.Page_Pendings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_Pendings.Controls.Add(Me.Dgv_PendingAllocations)
        Me.Page_Pendings.Location = New System.Drawing.Point(4, 39)
        Me.Page_Pendings.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_Pendings.Name = "Page_Pendings"
        Me.Page_Pendings.Size = New System.Drawing.Size(1131, 714)
        Me.Page_Pendings.TabIndex = 1
        Me.Page_Pendings.Text = "Pending Allocations..."
        '
        'Dgv_PendingAllocations
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgv_PendingAllocations.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_PendingAllocations.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_PendingAllocations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_PendingAllocations.ColumnHeadersHeight = 30
        Me.Dgv_PendingAllocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Dgv_PendingAllocations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column12, Me.Column14, Me.Column13, Me.Column2, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column3, Me.Column4})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_PendingAllocations.DefaultCellStyle = DataGridViewCellStyle13
        Me.Dgv_PendingAllocations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_PendingAllocations.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_PendingAllocations.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_PendingAllocations.Name = "Dgv_PendingAllocations"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_PendingAllocations.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.Dgv_PendingAllocations.RowHeadersVisible = False
        Me.Dgv_PendingAllocations.Size = New System.Drawing.Size(1131, 714)
        Me.Dgv_PendingAllocations.TabIndex = 47
        Me.Dgv_PendingAllocations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Dgv_PendingAllocations.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Dgv_PendingAllocations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Dgv_PendingAllocations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Dgv_PendingAllocations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Dgv_PendingAllocations.ThemeStyle.BackColor = System.Drawing.Color.LightGray
        Me.Dgv_PendingAllocations.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_PendingAllocations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dgv_PendingAllocations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_PendingAllocations.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_PendingAllocations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Dgv_PendingAllocations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Dgv_PendingAllocations.ThemeStyle.HeaderStyle.Height = 30
        Me.Dgv_PendingAllocations.ThemeStyle.ReadOnly = False
        Me.Dgv_PendingAllocations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray
        Me.Dgv_PendingAllocations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Dgv_PendingAllocations.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv_PendingAllocations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Dgv_PendingAllocations.ThemeStyle.RowsStyle.Height = 22
        Me.Dgv_PendingAllocations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RosyBrown
        Me.Dgv_PendingAllocations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column5.HeaderText = "Allocate Guest"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 116
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column1.HeaderText = "Serial No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 103
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column12.HeaderText = "Guest's Name"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 127
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column14.HeaderText = "Guest's E-Mail Address"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 188
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column13.HeaderText = "Guest's Contact "
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 147
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column2.HeaderText = "Guest Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 111
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column15.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column15.HeaderText = "Arrival Date"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 118
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column16.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column16.HeaderText = "Stay Duration"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 128
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column17.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column17.HeaderText = "Departure Date"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 142
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column18.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column18.HeaderText = "Number Of People"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 163
        '
        'Column3
        '
        Me.Column3.HeaderText = "Enquiries"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Room Number"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ToolTip_Exit
        '
        Me.ToolTip_Exit.AllowLinksHandling = True
        Me.ToolTip_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ToolTip_Exit.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Exit.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip_Exit.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'ToolTip_Email
        '
        Me.ToolTip_Email.AllowLinksHandling = True
        Me.ToolTip_Email.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ToolTip_Email.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Email.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Email.ForeColor = System.Drawing.Color.White
        Me.ToolTip_Email.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'ToolTip_SMS
        '
        Me.ToolTip_SMS.AllowLinksHandling = True
        Me.ToolTip_SMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ToolTip_SMS.BorderColor = System.Drawing.Color.White
        Me.ToolTip_SMS.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_SMS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip_SMS.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'GuestAllocations
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.Tab_Allocations)
        Me.Name = "GuestAllocations"
        Me.Size = New System.Drawing.Size(1139, 757)
        Me.Tab_Allocations.ResumeLayout(False)
        Me.Page_Allocated.ResumeLayout(False)
        Me.Panel_Holder.ResumeLayout(False)
        Me.FLP_GuestButtons.ResumeLayout(False)
        Me.Panel_Menu.ResumeLayout(False)
        Me.Page_Pendings.ResumeLayout(False)
        CType(Me.Dgv_PendingAllocations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Tab_Allocations As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Page_Allocated As TabPage
    Friend WithEvents Page_Pendings As TabPage
    Friend WithEvents Dgv_PendingAllocations As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel_Menu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FLP_GuestButtons As FlowLayoutPanel
    Friend WithEvents Btn_AllRooms As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Btn_SMS As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Btn_Email As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents ToolTip_Email As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_SMS As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
