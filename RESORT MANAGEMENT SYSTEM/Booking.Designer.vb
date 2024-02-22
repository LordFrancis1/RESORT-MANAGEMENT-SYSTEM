<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_RoomButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Room1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel_Bottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_Menu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Cmb_RoomType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Btn_RefreshAll = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel_Title = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_TopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Panel_Holder.SuspendLayout()
        Me.FLP_RoomButtons.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_TopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Holder
        '
        Me.Panel_Holder.Controls.Add(Me.FLP_RoomButtons)
        Me.Panel_Holder.Controls.Add(Me.Panel_Bottom)
        Me.Panel_Holder.Controls.Add(Me.Panel_Menu)
        Me.Panel_Holder.Controls.Add(Me.Panel_Title)
        Me.Panel_Holder.Controls.Add(Me.Panel_TopMenu)
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(620, 398)
        Me.Panel_Holder.TabIndex = 68
        '
        'FLP_RoomButtons
        '
        Me.FLP_RoomButtons.AutoScroll = True
        Me.FLP_RoomButtons.Controls.Add(Me.Btn_Room1)
        Me.FLP_RoomButtons.Controls.Add(Me.Guna2GradientButton1)
        Me.FLP_RoomButtons.Controls.Add(Me.Guna2GradientButton2)
        Me.FLP_RoomButtons.Controls.Add(Me.Guna2GradientButton3)
        Me.FLP_RoomButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_RoomButtons.Location = New System.Drawing.Point(0, 102)
        Me.FLP_RoomButtons.Name = "FLP_RoomButtons"
        Me.FLP_RoomButtons.Size = New System.Drawing.Size(620, 251)
        Me.FLP_RoomButtons.TabIndex = 87
        '
        'Btn_Room1
        '
        Me.Btn_Room1.Animated = True
        Me.Btn_Room1.BorderColor = System.Drawing.Color.White
        Me.Btn_Room1.BorderRadius = 5
        Me.Btn_Room1.BorderThickness = 1
        Me.Btn_Room1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Room1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Room1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Room1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Room1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Room1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Room1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Room1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Btn_Room1.ForeColor = System.Drawing.Color.White
        Me.Btn_Room1.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Room1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Room1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Room1.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Room1.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Room1.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Room1.Name = "Btn_Room1"
        Me.Btn_Room1.PressedColor = System.Drawing.Color.White
        Me.Btn_Room1.Size = New System.Drawing.Size(95, 35)
        Me.Btn_Room1.TabIndex = 51
        Me.Btn_Room1.Text = "Room 1"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton1.BorderRadius = 5
        Me.Guna2GradientButton1.BorderThickness = 1
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(104, 3)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(95, 35)
        Me.Guna2GradientButton1.TabIndex = 52
        Me.Guna2GradientButton1.Text = "Room 2"
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.BorderRadius = 5
        Me.Guna2GradientButton2.BorderThickness = 1
        Me.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(205, 3)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.PressedColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(95, 35)
        Me.Guna2GradientButton2.TabIndex = 53
        Me.Guna2GradientButton2.Text = "Room 3"
        '
        'Guna2GradientButton3
        '
        Me.Guna2GradientButton3.Animated = True
        Me.Guna2GradientButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton3.BorderRadius = 5
        Me.Guna2GradientButton3.BorderThickness = 1
        Me.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton3.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Guna2GradientButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton3.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton3.Location = New System.Drawing.Point(306, 3)
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton3.Size = New System.Drawing.Size(95, 35)
        Me.Guna2GradientButton3.TabIndex = 54
        Me.Guna2GradientButton3.Text = "Room 4"
        '
        'Panel_Bottom
        '
        Me.Panel_Bottom.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Bottom.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Bottom.Location = New System.Drawing.Point(0, 353)
        Me.Panel_Bottom.Name = "Panel_Bottom"
        Me.Panel_Bottom.Size = New System.Drawing.Size(620, 45)
        Me.Panel_Bottom.TabIndex = 86
        Me.Panel_Bottom.UseTransparentBackground = True
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Menu.Controls.Add(Me.Cmb_RoomType)
        Me.Panel_Menu.Controls.Add(Me.Btn_RefreshAll)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Menu.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 66)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(620, 36)
        Me.Panel_Menu.TabIndex = 85
        Me.Panel_Menu.UseTransparentBackground = True
        '
        'Cmb_RoomType
        '
        Me.Cmb_RoomType.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_RoomType.BorderColor = System.Drawing.Color.LightGray
        Me.Cmb_RoomType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_RoomType.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_RoomType.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_RoomType.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_RoomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_RoomType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cmb_RoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_RoomType.FillColor = System.Drawing.Color.Silver
        Me.Cmb_RoomType.FocusedColor = System.Drawing.Color.White
        Me.Cmb_RoomType.FocusedState.BorderColor = System.Drawing.Color.White
        Me.Cmb_RoomType.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_RoomType.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_RoomType.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_RoomType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Cmb_RoomType.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Cmb_RoomType.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_RoomType.ItemHeight = 30
        Me.Cmb_RoomType.Items.AddRange(New Object() {"Select Room Type", "Single Room", "Double Room", "Triple Room", "Twin Room", "Juniour Suite", "Executive Suite", "Presidential Suite"})
        Me.Cmb_RoomType.Location = New System.Drawing.Point(199, 0)
        Me.Cmb_RoomType.Name = "Cmb_RoomType"
        Me.Cmb_RoomType.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_RoomType.Size = New System.Drawing.Size(421, 36)
        Me.Cmb_RoomType.TabIndex = 68
        '
        'Btn_RefreshAll
        '
        Me.Btn_RefreshAll.Animated = True
        Me.Btn_RefreshAll.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_RefreshAll.BorderRadius = 5
        Me.Btn_RefreshAll.BorderThickness = 1
        Me.Btn_RefreshAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_RefreshAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_RefreshAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_RefreshAll.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_RefreshAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_RefreshAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_RefreshAll.FillColor = System.Drawing.Color.Silver
        Me.Btn_RefreshAll.FillColor2 = System.Drawing.Color.Silver
        Me.Btn_RefreshAll.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_RefreshAll.ForeColor = System.Drawing.Color.Blue
        Me.Btn_RefreshAll.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_RefreshAll.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_RefreshAll.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_RefreshAll.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RefreshAll.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_RefreshAll.Location = New System.Drawing.Point(0, 0)
        Me.Btn_RefreshAll.Name = "Btn_RefreshAll"
        Me.Btn_RefreshAll.PressedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_RefreshAll.Size = New System.Drawing.Size(199, 36)
        Me.Btn_RefreshAll.TabIndex = 53
        Me.Btn_RefreshAll.Text = "Refresh All"
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Title.Controls.Add(Me.Lbl_Title)
        Me.Panel_Title.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Title.Location = New System.Drawing.Point(0, 30)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(620, 36)
        Me.Panel_Title.TabIndex = 84
        Me.Panel_Title.UseTransparentBackground = True
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = False
        Me.Lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_Title.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Title.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(171, 36)
        Me.Lbl_Title.TabIndex = 19
        Me.Lbl_Title.Text = "Room Booking"
        Me.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Inform.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Inform.Location = New System.Drawing.Point(199, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(421, 36)
        Me.Lbl_Inform.TabIndex = 18
        Me.Lbl_Inform.Text = "Click a Room Button to proceed with Booking..."
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_TopMenu
        '
        Me.Panel_TopMenu.BackColor = System.Drawing.Color.Transparent
        Me.Panel_TopMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TopMenu.Controls.Add(Me.Btn_Exit)
        Me.Panel_TopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TopMenu.Name = "Panel_TopMenu"
        Me.Panel_TopMenu.Size = New System.Drawing.Size(620, 30)
        Me.Panel_TopMenu.TabIndex = 83
        Me.Panel_TopMenu.UseTransparentBackground = True
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
        Me.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Exit.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Exit.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Exit.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Exit.Location = New System.Drawing.Point(580, 0)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Exit.Size = New System.Drawing.Size(40, 30)
        Me.Btn_Exit.TabIndex = 4
        Me.Btn_Exit.Text = "X"
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Exit, "Exit Dialog")
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
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
        'Booking
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Holder)
        Me.Name = "Booking"
        Me.Size = New System.Drawing.Size(620, 398)
        Me.Panel_Holder.ResumeLayout(False)
        Me.FLP_RoomButtons.ResumeLayout(False)
        Me.Panel_Menu.ResumeLayout(False)
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_TopMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_Bottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_Menu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Cmb_RoomType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Btn_RefreshAll As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel_Title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel_TopMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FLP_RoomButtons As FlowLayoutPanel
    Friend WithEvents Btn_Room1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Lbl_Title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
