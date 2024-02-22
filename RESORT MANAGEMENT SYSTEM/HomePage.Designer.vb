<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Btn_Off = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Operations = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip_AddUser = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Btn_AddAccount = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ToolTip_Maximize = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Btn_Maximize = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip_Minimize = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_Top3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Top2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_HotelName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Date = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Time = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_Date = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Top = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_Menu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cmb_UserType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Grp_SystemUsers = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_SystemUsers = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel_Slide = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Holder.SuspendLayout()
        Me.Panel_Top3.SuspendLayout()
        Me.Panel_Top2.SuspendLayout()
        Me.Panel_Date.SuspendLayout()
        Me.Panel_Top.SuspendLayout()
        Me.FLP_Menu.SuspendLayout()
        Me.Grp_SystemUsers.SuspendLayout()
        Me.FLP_SystemUsers.SuspendLayout()
        Me.Panel_Slide.SuspendLayout()
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
        'Btn_Off
        '
        Me.Btn_Off.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Off.Animated = True
        Me.Btn_Off.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Off.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Off.BorderRadius = 5
        Me.Btn_Off.BorderThickness = 1
        Me.Btn_Off.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Off.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Off.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Off.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Off.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Off.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Off.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Btn_Off.ForeColor = System.Drawing.Color.Black
        Me.Btn_Off.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Off.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Btn_Off.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Off.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.power_off
        Me.Btn_Off.ImageSize = New System.Drawing.Size(23, 23)
        Me.Btn_Off.Location = New System.Drawing.Point(95, 3)
        Me.Btn_Off.Name = "Btn_Off"
        Me.Btn_Off.Size = New System.Drawing.Size(40, 30)
        Me.Btn_Off.TabIndex = 5
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Off, "Exit Application")
        Me.Btn_Off.UseTransparentBackground = True
        '
        'Btn_Operations
        '
        Me.Btn_Operations.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Operations.Animated = True
        Me.Btn_Operations.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Operations.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Operations.BorderRadius = 5
        Me.Btn_Operations.BorderThickness = 1
        Me.Btn_Operations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Operations.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Operations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Operations.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Operations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Operations.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Operations.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Btn_Operations.ForeColor = System.Drawing.Color.Black
        Me.Btn_Operations.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Operations.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Btn_Operations.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Operations.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.vbquestion
        Me.Btn_Operations.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_Operations.Location = New System.Drawing.Point(1357, 704)
        Me.Btn_Operations.Name = "Btn_Operations"
        Me.Btn_Operations.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Operations.TabIndex = 35
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Operations, "More Options")
        Me.Btn_Operations.UseTransparentBackground = True
        '
        'ToolTip_AddUser
        '
        Me.ToolTip_AddUser.AllowLinksHandling = True
        Me.ToolTip_AddUser.BackColor = System.Drawing.Color.BlueViolet
        Me.ToolTip_AddUser.BorderColor = System.Drawing.Color.White
        Me.ToolTip_AddUser.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_AddUser.ForeColor = System.Drawing.Color.White
        Me.ToolTip_AddUser.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Btn_AddAccount
        '
        Me.Btn_AddAccount.Animated = True
        Me.Btn_AddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_AddAccount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_AddAccount.BorderRadius = 10
        Me.Btn_AddAccount.BorderThickness = 2
        Me.Btn_AddAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AddAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_AddAccount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_AddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_AddAccount.FillColor = System.Drawing.Color.Transparent
        Me.Btn_AddAccount.FillColor2 = System.Drawing.Color.Transparent
        Me.Btn_AddAccount.Font = New System.Drawing.Font("Trebuchet MS", 36.0!)
        Me.Btn_AddAccount.ForeColor = System.Drawing.Color.Black
        Me.Btn_AddAccount.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_AddAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_AddAccount.HoverState.FillColor2 = System.Drawing.Color.BlueViolet
        Me.Btn_AddAccount.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_AddAccount.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.users
        Me.Btn_AddAccount.ImageSize = New System.Drawing.Size(75, 75)
        Me.Btn_AddAccount.Location = New System.Drawing.Point(3, 3)
        Me.Btn_AddAccount.Name = "Btn_AddAccount"
        Me.Btn_AddAccount.PressedColor = System.Drawing.Color.White
        Me.Btn_AddAccount.Size = New System.Drawing.Size(193, 103)
        Me.Btn_AddAccount.TabIndex = 4
        Me.Btn_AddAccount.Text = "+"
        Me.Btn_AddAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip_AddUser.SetToolTip(Me.Btn_AddAccount, "Add System User")
        '
        'ToolTip_Maximize
        '
        Me.ToolTip_Maximize.AllowLinksHandling = True
        Me.ToolTip_Maximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolTip_Maximize.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Maximize.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Maximize.ForeColor = System.Drawing.Color.White
        Me.ToolTip_Maximize.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximize.Animated = True
        Me.Btn_Maximize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Maximize.BorderColor = System.Drawing.Color.White
        Me.Btn_Maximize.BorderRadius = 5
        Me.Btn_Maximize.BorderThickness = 1
        Me.Btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Maximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Maximize.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Maximize.Font = New System.Drawing.Font("Castellar", 14.25!)
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Maximize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Maximize.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Btn_Maximize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.maximize
        Me.Btn_Maximize.ImageSize = New System.Drawing.Size(26, 26)
        Me.Btn_Maximize.Location = New System.Drawing.Point(49, 3)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Maximize.Size = New System.Drawing.Size(40, 30)
        Me.Btn_Maximize.TabIndex = 17
        Me.ToolTip_Maximize.SetToolTip(Me.Btn_Maximize, "Maximize")
        '
        'ToolTip_Minimize
        '
        Me.ToolTip_Minimize.AllowLinksHandling = True
        Me.ToolTip_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip_Minimize.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Minimize.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Minimize.ForeColor = System.Drawing.Color.Black
        Me.ToolTip_Minimize.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimize.Animated = True
        Me.Btn_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Minimize.BorderColor = System.Drawing.Color.White
        Me.Btn_Minimize.BorderRadius = 5
        Me.Btn_Minimize.BorderThickness = 1
        Me.Btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Minimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Minimize.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Minimize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Minimize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Minimize.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Btn_Minimize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.minimize
        Me.Btn_Minimize.ImageSize = New System.Drawing.Size(18, 18)
        Me.Btn_Minimize.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Minimize.Size = New System.Drawing.Size(40, 30)
        Me.Btn_Minimize.TabIndex = 18
        Me.ToolTip_Minimize.SetToolTip(Me.Btn_Minimize, "Minimize ")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Panel_Holder
        '
        Me.Panel_Holder.Controls.Add(Me.Panel_Top3)
        Me.Panel_Holder.Controls.Add(Me.Panel_Top2)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel_Holder.Controls.Add(Me.Panel_Date)
        Me.Panel_Holder.Controls.Add(Me.Panel_Top)
        Me.Panel_Holder.Controls.Add(Me.Cmb_UserType)
        Me.Panel_Holder.Controls.Add(Me.Btn_Operations)
        Me.Panel_Holder.Controls.Add(Me.Grp_SystemUsers)
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(1400, 750)
        Me.Panel_Holder.TabIndex = 0
        '
        'Panel_Top3
        '
        Me.Panel_Top3.Controls.Add(Me.Lbl_Title)
        Me.Panel_Top3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel_Top3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top3.Location = New System.Drawing.Point(0, 180)
        Me.Panel_Top3.Name = "Panel_Top3"
        Me.Panel_Top3.Size = New System.Drawing.Size(1400, 50)
        Me.Panel_Top3.TabIndex = 41
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = False
        Me.Lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_Title.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.White
        Me.Lbl_Title.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(1380, 50)
        Me.Lbl_Title.TabIndex = 34
        Me.Lbl_Title.Text = "MANAGEMENT INFORMATION SYSTEM"
        Me.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.LightGray
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(1380, 0)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(20, 50)
        Me.Guna2HtmlLabel6.TabIndex = 33
        Me.Guna2HtmlLabel6.Text = Nothing
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_Top2
        '
        Me.Panel_Top2.Controls.Add(Me.Lbl_HotelName)
        Me.Panel_Top2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel_Top2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top2.Location = New System.Drawing.Point(0, 140)
        Me.Panel_Top2.Name = "Panel_Top2"
        Me.Panel_Top2.Size = New System.Drawing.Size(1400, 40)
        Me.Panel_Top2.TabIndex = 40
        '
        'Lbl_HotelName
        '
        Me.Lbl_HotelName.AutoSize = False
        Me.Lbl_HotelName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_HotelName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_HotelName.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_HotelName.ForeColor = System.Drawing.Color.White
        Me.Lbl_HotelName.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_HotelName.Name = "Lbl_HotelName"
        Me.Lbl_HotelName.Size = New System.Drawing.Size(1380, 40)
        Me.Lbl_HotelName.TabIndex = 33
        Me.Lbl_HotelName.Text = "HOTEL NAME"
        Me.Lbl_HotelName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.LightGray
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(1380, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(20, 40)
        Me.Guna2HtmlLabel5.TabIndex = 32
        Me.Guna2HtmlLabel5.Text = Nothing
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(0, 80)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(1400, 60)
        Me.Guna2HtmlLabel4.TabIndex = 39
        Me.Guna2HtmlLabel4.Text = Nothing
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_Date
        '
        Me.Panel_Date.Controls.Add(Me.Lbl_Time)
        Me.Panel_Date.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel_Date.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel_Date.Controls.Add(Me.Lbl_Date)
        Me.Panel_Date.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel_Date.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Date.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Date.Name = "Panel_Date"
        Me.Panel_Date.Size = New System.Drawing.Size(1400, 40)
        Me.Panel_Date.TabIndex = 38
        '
        'Lbl_Time
        '
        Me.Lbl_Time.AutoSize = False
        Me.Lbl_Time.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Time.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_Time.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Time.ForeColor = System.Drawing.Color.LightGray
        Me.Lbl_Time.Location = New System.Drawing.Point(140, 0)
        Me.Lbl_Time.Name = "Lbl_Time"
        Me.Lbl_Time.Size = New System.Drawing.Size(162, 40)
        Me.Lbl_Time.TabIndex = 29
        Me.Lbl_Time.Text = "..... ..... ..... "
        Me.Lbl_Time.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.LightGray
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(15, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(125, 40)
        Me.Guna2HtmlLabel2.TabIndex = 28
        Me.Guna2HtmlLabel2.Text = "Time Now  : "
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(15, 40)
        Me.Guna2HtmlLabel1.TabIndex = 27
        Me.Guna2HtmlLabel1.Text = Nothing
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = False
        Me.Lbl_Date.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Date.Dock = System.Windows.Forms.DockStyle.Right
        Me.Lbl_Date.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Date.ForeColor = System.Drawing.Color.LightGray
        Me.Lbl_Date.Location = New System.Drawing.Point(1085, 0)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(300, 40)
        Me.Lbl_Date.TabIndex = 26
        Me.Lbl_Date.Text = "..... ..... ..... "
        Me.Lbl_Date.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.LightGray
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(1385, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(15, 40)
        Me.Guna2HtmlLabel3.TabIndex = 25
        Me.Guna2HtmlLabel3.Text = Nothing
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_Top
        '
        Me.Panel_Top.Controls.Add(Me.FLP_Menu)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1400, 40)
        Me.Panel_Top.TabIndex = 37
        '
        'FLP_Menu
        '
        Me.FLP_Menu.Controls.Add(Me.Btn_Minimize)
        Me.FLP_Menu.Controls.Add(Me.Btn_Maximize)
        Me.FLP_Menu.Controls.Add(Me.Btn_Off)
        Me.FLP_Menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.FLP_Menu.Location = New System.Drawing.Point(1260, 0)
        Me.FLP_Menu.Name = "FLP_Menu"
        Me.FLP_Menu.Size = New System.Drawing.Size(140, 40)
        Me.FLP_Menu.TabIndex = 0
        '
        'Cmb_UserType
        '
        Me.Cmb_UserType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmb_UserType.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_UserType.BorderColor = System.Drawing.Color.White
        Me.Cmb_UserType.BorderRadius = 5
        Me.Cmb_UserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_UserType.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmb_UserType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmb_UserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmb_UserType.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Cmb_UserType.ForeColor = System.Drawing.Color.Black
        Me.Cmb_UserType.ItemHeight = 30
        Me.Cmb_UserType.Items.AddRange(New Object() {"Select User Type", "System Administrator", "System User"})
        Me.Cmb_UserType.Location = New System.Drawing.Point(384, 243)
        Me.Cmb_UserType.Name = "Cmb_UserType"
        Me.Cmb_UserType.Size = New System.Drawing.Size(628, 36)
        Me.Cmb_UserType.TabIndex = 36
        '
        'Grp_SystemUsers
        '
        Me.Grp_SystemUsers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grp_SystemUsers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Grp_SystemUsers.BorderRadius = 5
        Me.Grp_SystemUsers.BorderThickness = 2
        Me.Grp_SystemUsers.Controls.Add(Me.FLP_SystemUsers)
        Me.Grp_SystemUsers.Controls.Add(Me.Panel_Slide)
        Me.Grp_SystemUsers.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Grp_SystemUsers.FillColor = System.Drawing.Color.Transparent
        Me.Grp_SystemUsers.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_SystemUsers.ForeColor = System.Drawing.Color.Black
        Me.Grp_SystemUsers.Location = New System.Drawing.Point(384, 297)
        Me.Grp_SystemUsers.Name = "Grp_SystemUsers"
        Me.Grp_SystemUsers.Size = New System.Drawing.Size(628, 295)
        Me.Grp_SystemUsers.TabIndex = 34
        Me.Grp_SystemUsers.Text = "System Administrator(s)"
        Me.Grp_SystemUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FLP_SystemUsers
        '
        Me.FLP_SystemUsers.AutoScroll = True
        Me.FLP_SystemUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FLP_SystemUsers.Controls.Add(Me.Btn_AddAccount)
        Me.FLP_SystemUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_SystemUsers.Location = New System.Drawing.Point(0, 70)
        Me.FLP_SystemUsers.Name = "FLP_SystemUsers"
        Me.FLP_SystemUsers.Size = New System.Drawing.Size(628, 225)
        Me.FLP_SystemUsers.TabIndex = 28
        '
        'Panel_Slide
        '
        Me.Panel_Slide.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Slide.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Slide.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Slide.Name = "Panel_Slide"
        Me.Panel_Slide.Size = New System.Drawing.Size(628, 30)
        Me.Panel_Slide.TabIndex = 27
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.White
        Me.Lbl_Inform.Location = New System.Drawing.Point(218, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(410, 30)
        Me.Lbl_Inform.TabIndex = 10
        Me.Lbl_Inform.Text = "Select Your Account To Proceed Logging In"
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomePage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Holder)
        Me.Name = "HomePage"
        Me.Size = New System.Drawing.Size(1400, 750)
        Me.Panel_Holder.ResumeLayout(False)
        Me.Panel_Top3.ResumeLayout(False)
        Me.Panel_Top2.ResumeLayout(False)
        Me.Panel_Date.ResumeLayout(False)
        Me.Panel_Top.ResumeLayout(False)
        Me.FLP_Menu.ResumeLayout(False)
        Me.Grp_SystemUsers.ResumeLayout(False)
        Me.FLP_SystemUsers.ResumeLayout(False)
        Me.Panel_Slide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_AddUser As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_Minimize As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_Maximize As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_Top3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_Title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel_Top2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_HotelName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel_Date As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_Time As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_Date As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel_Top As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FLP_Menu As FlowLayoutPanel
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Maximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Off As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Cmb_UserType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Btn_Operations As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Grp_SystemUsers As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FLP_SystemUsers As FlowLayoutPanel
    Friend WithEvents Btn_AddAccount As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel_Slide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
