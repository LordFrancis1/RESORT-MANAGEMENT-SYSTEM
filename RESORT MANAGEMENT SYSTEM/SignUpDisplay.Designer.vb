<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpDisplay
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
        Me.Panel_Display = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Panel_HotelInfo = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lbl_Slogan = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_HotelName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Pic_Icon = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Btn_AccountRecovery = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Prg_Admins = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.FLP_Menu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Maximize = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ColorTransition13 = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.Guna2ColorTransition14 = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.Guna2ColorTransition15 = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.Guna2ColorTransition16 = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.Prg_SystemUsers = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Panel_Display.SuspendLayout()
        Me.Panel_HotelInfo.SuspendLayout()
        CType(Me.Pic_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.FLP_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Display
        '
        Me.Panel_Display.BackColor = System.Drawing.Color.Silver
        Me.Panel_Display.Controls.Add(Me.Prg_SystemUsers)
        Me.Panel_Display.Controls.Add(Me.Panel_HotelInfo)
        Me.Panel_Display.Controls.Add(Me.Btn_AccountRecovery)
        Me.Panel_Display.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel_Display.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel_Display.Controls.Add(Me.Prg_Admins)
        Me.Panel_Display.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Display.Location = New System.Drawing.Point(0, 41)
        Me.Panel_Display.Name = "Panel_Display"
        Me.Panel_Display.Size = New System.Drawing.Size(612, 959)
        Me.Panel_Display.TabIndex = 48
        '
        'Panel_HotelInfo
        '
        Me.Panel_HotelInfo.BackColor = System.Drawing.Color.Silver
        Me.Panel_HotelInfo.Controls.Add(Me.lbl_Slogan)
        Me.Panel_HotelInfo.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel_HotelInfo.Controls.Add(Me.Lbl_HotelName)
        Me.Panel_HotelInfo.Controls.Add(Me.Pic_Icon)
        Me.Panel_HotelInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_HotelInfo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_HotelInfo.Name = "Panel_HotelInfo"
        Me.Panel_HotelInfo.Size = New System.Drawing.Size(612, 136)
        Me.Panel_HotelInfo.TabIndex = 61
        '
        'lbl_Slogan
        '
        Me.lbl_Slogan.AutoSize = False
        Me.lbl_Slogan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Slogan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Slogan.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Slogan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_Slogan.Location = New System.Drawing.Point(142, 82)
        Me.lbl_Slogan.Name = "lbl_Slogan"
        Me.lbl_Slogan.Size = New System.Drawing.Size(470, 54)
        Me.lbl_Slogan.TabIndex = 63
        Me.lbl_Slogan.Text = "Hotel Slogan"
        Me.lbl_Slogan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(142, 41)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(470, 41)
        Me.Guna2HtmlLabel3.TabIndex = 62
        Me.Guna2HtmlLabel3.Text = "MANAGEMENT INFORMATION SYSTEM"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_HotelName
        '
        Me.Lbl_HotelName.AutoSize = False
        Me.Lbl_HotelName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_HotelName.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_HotelName.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_HotelName.ForeColor = System.Drawing.Color.Black
        Me.Lbl_HotelName.Location = New System.Drawing.Point(142, 0)
        Me.Lbl_HotelName.Name = "Lbl_HotelName"
        Me.Lbl_HotelName.Size = New System.Drawing.Size(470, 41)
        Me.Lbl_HotelName.TabIndex = 61
        Me.Lbl_HotelName.Text = "HOTEL NAME"
        Me.Lbl_HotelName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Pic_Icon
        '
        Me.Pic_Icon.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Icon.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pic_Icon.FillColor = System.Drawing.Color.Transparent
        Me.Pic_Icon.ImageRotate = 0!
        Me.Pic_Icon.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Icon.Name = "Pic_Icon"
        Me.Pic_Icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Pic_Icon.Size = New System.Drawing.Size(142, 136)
        Me.Pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Icon.TabIndex = 0
        Me.Pic_Icon.TabStop = False
        Me.Pic_Icon.UseTransparentBackground = True
        '
        'Btn_AccountRecovery
        '
        Me.Btn_AccountRecovery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AccountRecovery.Animated = True
        Me.Btn_AccountRecovery.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AccountRecovery.BorderRadius = 5
        Me.Btn_AccountRecovery.BorderThickness = 2
        Me.Btn_AccountRecovery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AccountRecovery.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AccountRecovery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AccountRecovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_AccountRecovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_AccountRecovery.FillColor = System.Drawing.Color.Transparent
        Me.Btn_AccountRecovery.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Btn_AccountRecovery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AccountRecovery.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_AccountRecovery.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AccountRecovery.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AccountRecovery.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_AccountRecovery.Location = New System.Drawing.Point(74, 579)
        Me.Btn_AccountRecovery.Name = "Btn_AccountRecovery"
        Me.Btn_AccountRecovery.PressedColor = System.Drawing.Color.White
        Me.Btn_AccountRecovery.Size = New System.Drawing.Size(464, 61)
        Me.Btn_AccountRecovery.TabIndex = 58
        Me.Btn_AccountRecovery.Text = "SETUP ACCOUNT RECOVERY"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(319, 174)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(219, 28)
        Me.Guna2HtmlLabel2.TabIndex = 52
        Me.Guna2HtmlLabel2.Text = "System Users"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(74, 174)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(239, 28)
        Me.Guna2HtmlLabel1.TabIndex = 51
        Me.Guna2HtmlLabel1.Text = "System Administrators" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Prg_Admins
        '
        Me.Prg_Admins.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Prg_Admins.Animated = True
        Me.Prg_Admins.FillColor = System.Drawing.Color.Transparent
        Me.Prg_Admins.FillThickness = 13
        Me.Prg_Admins.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_Admins.ForeColor = System.Drawing.Color.Black
        Me.Prg_Admins.Location = New System.Drawing.Point(98, 258)
        Me.Prg_Admins.Minimum = 0
        Me.Prg_Admins.Name = "Prg_Admins"
        Me.Prg_Admins.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Prg_Admins.ProgressColor2 = System.Drawing.Color.Gainsboro
        Me.Prg_Admins.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.Prg_Admins.ProgressThickness = 13
        Me.Prg_Admins.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Prg_Admins.ShowText = True
        Me.Prg_Admins.Size = New System.Drawing.Size(130, 130)
        Me.Prg_Admins.TabIndex = 49
        Me.Prg_Admins.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value
        Me.Prg_Admins.Value = 20
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.Silver
        Me.Guna2GradientPanel2.Controls.Add(Me.FLP_Menu)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(1500, 41)
        Me.Guna2GradientPanel2.TabIndex = 47
        '
        'FLP_Menu
        '
        Me.FLP_Menu.Controls.Add(Me.Btn_Minimize)
        Me.FLP_Menu.Controls.Add(Me.Btn_Maximize)
        Me.FLP_Menu.Controls.Add(Me.Btn_Exit)
        Me.FLP_Menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.FLP_Menu.Location = New System.Drawing.Point(1350, 0)
        Me.FLP_Menu.Name = "FLP_Menu"
        Me.FLP_Menu.Size = New System.Drawing.Size(150, 41)
        Me.FLP_Menu.TabIndex = 20
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.Animated = True
        Me.Btn_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.BorderRadius = 5
        Me.Btn_Minimize.BorderThickness = 1
        Me.Btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Minimize.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Minimize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Minimize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.minimize
        Me.Btn_Minimize.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Minimize.Size = New System.Drawing.Size(42, 32)
        Me.Btn_Minimize.TabIndex = 19
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Animated = True
        Me.Btn_Maximize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.BorderRadius = 5
        Me.Btn_Maximize.BorderThickness = 1
        Me.Btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Maximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Maximize.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.Font = New System.Drawing.Font("Castellar", 14.25!)
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Maximize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Maximize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.maximize
        Me.Btn_Maximize.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_Maximize.Location = New System.Drawing.Point(51, 3)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Maximize.Size = New System.Drawing.Size(42, 32)
        Me.Btn_Maximize.TabIndex = 18
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Animated = True
        Me.Btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.BorderRadius = 5
        Me.Btn_Exit.BorderThickness = 1
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Exit.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.ForeColor = System.Drawing.Color.Black
        Me.Btn_Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Exit.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Exit.Location = New System.Drawing.Point(99, 3)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Exit.Size = New System.Drawing.Size(42, 32)
        Me.Btn_Exit.TabIndex = 17
        Me.Btn_Exit.Text = "X"
        '
        'Panel_Holder
        '
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.Location = New System.Drawing.Point(612, 41)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(888, 959)
        Me.Panel_Holder.TabIndex = 49
        '
        'Guna2ColorTransition13
        '
        Me.Guna2ColorTransition13.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        '
        'Guna2ColorTransition14
        '
        Me.Guna2ColorTransition14.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        '
        'Guna2ColorTransition15
        '
        Me.Guna2ColorTransition15.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        '
        'Guna2ColorTransition16
        '
        Me.Guna2ColorTransition16.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        '
        'Prg_SystemUsers
        '
        Me.Prg_SystemUsers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Prg_SystemUsers.Animated = True
        Me.Prg_SystemUsers.FillColor = System.Drawing.Color.Transparent
        Me.Prg_SystemUsers.FillThickness = 13
        Me.Prg_SystemUsers.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_SystemUsers.ForeColor = System.Drawing.Color.Black
        Me.Prg_SystemUsers.Location = New System.Drawing.Point(369, 258)
        Me.Prg_SystemUsers.Minimum = 0
        Me.Prg_SystemUsers.Name = "Prg_SystemUsers"
        Me.Prg_SystemUsers.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Prg_SystemUsers.ProgressColor2 = System.Drawing.Color.Gainsboro
        Me.Prg_SystemUsers.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.Prg_SystemUsers.ProgressThickness = 13
        Me.Prg_SystemUsers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Prg_SystemUsers.ShowText = True
        Me.Prg_SystemUsers.Size = New System.Drawing.Size(130, 130)
        Me.Prg_SystemUsers.TabIndex = 50
        Me.Prg_SystemUsers.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value
        Me.Prg_SystemUsers.Value = 60
        '
        'SignUpDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Holder)
        Me.Controls.Add(Me.Panel_Display)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Name = "SignUpDisplay"
        Me.Size = New System.Drawing.Size(1500, 1000)
        Me.Panel_Display.ResumeLayout(False)
        Me.Panel_HotelInfo.ResumeLayout(False)
        CType(Me.Pic_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.FLP_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Display As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Btn_AccountRecovery As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Prg_Admins As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Pic_Icon As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Maximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_HotelInfo As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_Slogan As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_HotelName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ColorTransition13 As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents Guna2ColorTransition14 As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents Guna2ColorTransition15 As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents Guna2ColorTransition16 As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents FLP_Menu As FlowLayoutPanel
    Friend WithEvents Prg_SystemUsers As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
