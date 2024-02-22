<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PassCode
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
        Me.panel_holder = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.panel_frontview = New Guna.UI2.WinForms.Guna2Panel()
        Me.panel_front_holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.panel_main = New Guna.UI2.WinForms.Guna2Panel()
        Me.panel_message = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_message = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pic_info = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.panel_frontbuttons = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_proceed = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.prg_passcode = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.panel_exit = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmb_admintype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2Button()
        Me.panel_buttons = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_next = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_3 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_6 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_5 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_9 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_0 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_4 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_8 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_7 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.panel_display = New Guna.UI2.WinForms.Guna2Panel()
        Me.txt_passcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_clear = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_set = New Guna.UI2.WinForms.Guna2Button()
        Me.tooltip_passcode = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_holder.SuspendLayout()
        Me.panel_frontview.SuspendLayout()
        Me.panel_front_holder.SuspendLayout()
        Me.panel_main.SuspendLayout()
        Me.panel_message.SuspendLayout()
        CType(Me.pic_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_frontbuttons.SuspendLayout()
        Me.panel_exit.SuspendLayout()
        Me.panel_buttons.SuspendLayout()
        Me.panel_display.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'panel_holder
        '
        Me.panel_holder.BackColor = System.Drawing.Color.Transparent
        Me.panel_holder.Controls.Add(Me.panel_frontview)
        Me.panel_holder.Controls.Add(Me.panel_exit)
        Me.panel_holder.Controls.Add(Me.panel_buttons)
        Me.panel_holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_holder.FillColor = System.Drawing.Color.Brown
        Me.panel_holder.FillColor2 = System.Drawing.Color.Gray
        Me.panel_holder.Location = New System.Drawing.Point(0, 0)
        Me.panel_holder.Name = "panel_holder"
        Me.panel_holder.Size = New System.Drawing.Size(386, 588)
        Me.panel_holder.TabIndex = 0
        '
        'panel_frontview
        '
        Me.panel_frontview.BackColor = System.Drawing.Color.Gray
        Me.panel_frontview.Controls.Add(Me.panel_front_holder)
        Me.panel_frontview.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_frontview.FillColor = System.Drawing.Color.Gray
        Me.panel_frontview.Location = New System.Drawing.Point(0, 34)
        Me.panel_frontview.Name = "panel_frontview"
        Me.panel_frontview.Size = New System.Drawing.Size(386, 400)
        Me.panel_frontview.TabIndex = 4
        '
        'panel_front_holder
        '
        Me.panel_front_holder.Controls.Add(Me.panel_main)
        Me.panel_front_holder.Controls.Add(Me.prg_passcode)
        Me.panel_front_holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_front_holder.FillColor = System.Drawing.Color.Gray
        Me.panel_front_holder.Location = New System.Drawing.Point(0, 0)
        Me.panel_front_holder.Name = "panel_front_holder"
        Me.panel_front_holder.Size = New System.Drawing.Size(386, 400)
        Me.panel_front_holder.TabIndex = 0
        '
        'panel_main
        '
        Me.panel_main.BorderColor = System.Drawing.Color.Maroon
        Me.panel_main.BorderRadius = 10
        Me.panel_main.BorderThickness = 1
        Me.panel_main.Controls.Add(Me.panel_message)
        Me.panel_main.Controls.Add(Me.panel_frontbuttons)
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_main.Location = New System.Drawing.Point(0, 203)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.ShadowDecoration.BorderRadius = 10
        Me.panel_main.ShadowDecoration.Color = System.Drawing.Color.Maroon
        Me.panel_main.Size = New System.Drawing.Size(386, 197)
        Me.panel_main.TabIndex = 5
        '
        'panel_message
        '
        Me.panel_message.BorderColor = System.Drawing.Color.Maroon
        Me.panel_message.BorderRadius = 10
        Me.panel_message.BorderThickness = 1
        Me.panel_message.Controls.Add(Me.lbl_message)
        Me.panel_message.Controls.Add(Me.pic_info)
        Me.panel_message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_message.FillColor = System.Drawing.Color.Gray
        Me.panel_message.Location = New System.Drawing.Point(0, 0)
        Me.panel_message.Name = "panel_message"
        Me.panel_message.Size = New System.Drawing.Size(386, 134)
        Me.panel_message.TabIndex = 10
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = False
        Me.lbl_message.BackColor = System.Drawing.Color.Transparent
        Me.lbl_message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_message.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_message.ForeColor = System.Drawing.Color.Black
        Me.lbl_message.Location = New System.Drawing.Point(112, 0)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(274, 134)
        Me.lbl_message.TabIndex = 2
        Me.lbl_message.Text = "To delete the information, you first have to grant the system a passcode." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defaul" &
    "t passcode is '1234'. To create a new one click on the 'Update button', else cli" &
    "ck 'Proceed'."
        Me.lbl_message.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_info
        '
        Me.pic_info.BackColor = System.Drawing.Color.Transparent
        Me.pic_info.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_info.FillColor = System.Drawing.Color.Transparent
        Me.pic_info.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.vbinformation
        Me.pic_info.ImageRotate = 0!
        Me.pic_info.Location = New System.Drawing.Point(0, 0)
        Me.pic_info.Name = "pic_info"
        Me.pic_info.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pic_info.Size = New System.Drawing.Size(112, 134)
        Me.pic_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_info.TabIndex = 1
        Me.pic_info.TabStop = False
        Me.pic_info.UseTransparentBackground = True
        '
        'panel_frontbuttons
        '
        Me.panel_frontbuttons.Controls.Add(Me.btn_proceed)
        Me.panel_frontbuttons.Controls.Add(Me.btn_update)
        Me.panel_frontbuttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_frontbuttons.FillColor = System.Drawing.Color.Gray
        Me.panel_frontbuttons.Location = New System.Drawing.Point(0, 134)
        Me.panel_frontbuttons.Name = "panel_frontbuttons"
        Me.panel_frontbuttons.Size = New System.Drawing.Size(386, 63)
        Me.panel_frontbuttons.TabIndex = 9
        '
        'btn_proceed
        '
        Me.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_proceed.BorderColor = System.Drawing.Color.Maroon
        Me.btn_proceed.BorderRadius = 5
        Me.btn_proceed.BorderThickness = 1
        Me.btn_proceed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_proceed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_proceed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_proceed.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_proceed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_proceed.FillColor = System.Drawing.Color.DimGray
        Me.btn_proceed.FillColor2 = System.Drawing.Color.DimGray
        Me.btn_proceed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proceed.ForeColor = System.Drawing.Color.Black
        Me.btn_proceed.HoverState.BorderColor = System.Drawing.Color.White
        Me.btn_proceed.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btn_proceed.HoverState.FillColor2 = System.Drawing.Color.Maroon
        Me.btn_proceed.HoverState.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proceed.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_proceed.Location = New System.Drawing.Point(154, 5)
        Me.btn_proceed.Name = "btn_proceed"
        Me.btn_proceed.Size = New System.Drawing.Size(106, 45)
        Me.btn_proceed.TabIndex = 1
        Me.btn_proceed.Text = "Proceed"
        '
        'btn_update
        '
        Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_update.BorderColor = System.Drawing.Color.Maroon
        Me.btn_update.BorderRadius = 5
        Me.btn_update.BorderThickness = 1
        Me.btn_update.DisabledState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btn_update.DisabledState.FillColor2 = System.Drawing.Color.Maroon
        Me.btn_update.DisabledState.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btn_update.Enabled = False
        Me.btn_update.FillColor = System.Drawing.Color.Gray
        Me.btn_update.FillColor2 = System.Drawing.Color.Maroon
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.HoverState.BorderColor = System.Drawing.Color.White
        Me.btn_update.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.HoverState.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.HoverState.ForeColor = System.Drawing.Color.Maroon
        Me.btn_update.Location = New System.Drawing.Point(268, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(106, 45)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "Update"
        '
        'prg_passcode
        '
        Me.prg_passcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prg_passcode.Animated = True
        Me.prg_passcode.AnimationSpeed = 0.8!
        Me.prg_passcode.BackColor = System.Drawing.Color.Transparent
        Me.prg_passcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prg_passcode.FillColor = System.Drawing.Color.DimGray
        Me.prg_passcode.FillThickness = 9
        Me.prg_passcode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.prg_passcode.ForeColor = System.Drawing.Color.White
        Me.prg_passcode.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.VBPasscode
        Me.prg_passcode.ImageSize = New System.Drawing.Size(120, 120)
        Me.prg_passcode.Location = New System.Drawing.Point(105, 7)
        Me.prg_passcode.Minimum = 0
        Me.prg_passcode.Name = "prg_passcode"
        Me.prg_passcode.ProgressColor = System.Drawing.Color.Gray
        Me.prg_passcode.ProgressColor2 = System.Drawing.Color.Maroon
        Me.prg_passcode.ProgressEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
        Me.prg_passcode.ProgressThickness = 8
        Me.prg_passcode.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.prg_passcode.Size = New System.Drawing.Size(178, 178)
        Me.prg_passcode.TabIndex = 3
        Me.prg_passcode.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value
        Me.prg_passcode.Value = 100
        '
        'panel_exit
        '
        Me.panel_exit.BackColor = System.Drawing.Color.Transparent
        Me.panel_exit.Controls.Add(Me.cmb_admintype)
        Me.panel_exit.Controls.Add(Me.btn_exit)
        Me.panel_exit.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_exit.FillColor = System.Drawing.Color.Gray
        Me.panel_exit.Location = New System.Drawing.Point(0, 0)
        Me.panel_exit.Name = "panel_exit"
        Me.panel_exit.Size = New System.Drawing.Size(386, 34)
        Me.panel_exit.TabIndex = 3
        '
        'cmb_admintype
        '
        Me.cmb_admintype.BackColor = System.Drawing.Color.Transparent
        Me.cmb_admintype.BorderColor = System.Drawing.Color.Gray
        Me.cmb_admintype.BorderThickness = 2
        Me.cmb_admintype.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmb_admintype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_admintype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_admintype.FillColor = System.Drawing.Color.Gray
        Me.cmb_admintype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_admintype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_admintype.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.cmb_admintype.ForeColor = System.Drawing.Color.Black
        Me.cmb_admintype.ItemHeight = 30
        Me.cmb_admintype.Items.AddRange(New Object() {"Admin Type", "All Admins"})
        Me.cmb_admintype.Location = New System.Drawing.Point(0, 0)
        Me.cmb_admintype.Name = "cmb_admintype"
        Me.cmb_admintype.Size = New System.Drawing.Size(202, 36)
        Me.cmb_admintype.TabIndex = 48
        '
        'btn_exit
        '
        Me.btn_exit.Animated = True
        Me.btn_exit.AnimatedGIF = True
        Me.btn_exit.BorderRadius = 5
        Me.btn_exit.BorderThickness = 1
        Me.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_exit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_exit.FillColor = System.Drawing.Color.Transparent
        Me.btn_exit.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!)
        Me.btn_exit.ForeColor = System.Drawing.Color.Maroon
        Me.btn_exit.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_exit.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btn_exit.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(334, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(52, 34)
        Me.btn_exit.TabIndex = 47
        Me.btn_exit.Text = "X"
        Me.tooltip_passcode.SetToolTip(Me.btn_exit, "Exit Passcode")
        '
        'panel_buttons
        '
        Me.panel_buttons.Controls.Add(Me.btn_back)
        Me.panel_buttons.Controls.Add(Me.btn_next)
        Me.panel_buttons.Controls.Add(Me.btn_2)
        Me.panel_buttons.Controls.Add(Me.btn_3)
        Me.panel_buttons.Controls.Add(Me.btn_6)
        Me.panel_buttons.Controls.Add(Me.btn_1)
        Me.panel_buttons.Controls.Add(Me.btn_5)
        Me.panel_buttons.Controls.Add(Me.btn_9)
        Me.panel_buttons.Controls.Add(Me.btn_0)
        Me.panel_buttons.Controls.Add(Me.btn_4)
        Me.panel_buttons.Controls.Add(Me.btn_8)
        Me.panel_buttons.Controls.Add(Me.btn_7)
        Me.panel_buttons.Controls.Add(Me.panel_display)
        Me.panel_buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_buttons.FillColor = System.Drawing.Color.Transparent
        Me.panel_buttons.Location = New System.Drawing.Point(0, 157)
        Me.panel_buttons.Name = "panel_buttons"
        Me.panel_buttons.Size = New System.Drawing.Size(386, 431)
        Me.panel_buttons.TabIndex = 0
        '
        'btn_back
        '
        Me.btn_back.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btn_back.BorderRadius = 5
        Me.btn_back.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_back.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_back.FillColor = System.Drawing.Color.Transparent
        Me.btn_back.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!)
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.HoverState.FillColor = System.Drawing.Color.Silver
        Me.btn_back.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.HoverState.ForeColor = System.Drawing.Color.Maroon
        Me.btn_back.Location = New System.Drawing.Point(6, 368)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(82, 50)
        Me.btn_back.TabIndex = 48
        Me.btn_back.Text = "BACK"
        '
        'btn_next
        '
        Me.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_next.BorderRadius = 5
        Me.btn_next.DisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_next.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_next.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_next.FillColor = System.Drawing.Color.Transparent
        Me.btn_next.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!)
        Me.btn_next.ForeColor = System.Drawing.Color.Maroon
        Me.btn_next.HoverState.FillColor = System.Drawing.Color.DimGray
        Me.btn_next.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.VbSend
        Me.btn_next.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_next.Location = New System.Drawing.Point(292, 368)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(82, 50)
        Me.btn_next.TabIndex = 47
        Me.tooltip_passcode.SetToolTip(Me.btn_next, "Next")
        '
        'btn_2
        '
        Me.btn_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_2.Animated = True
        Me.btn_2.AnimatedGIF = True
        Me.btn_2.BackColor = System.Drawing.Color.Transparent
        Me.btn_2.BorderColor = System.Drawing.Color.Maroon
        Me.btn_2.BorderThickness = 1
        Me.btn_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_2.DisabledState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_2.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_2.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_2.FillColor = System.Drawing.Color.Transparent
        Me.btn_2.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_2.ForeColor = System.Drawing.Color.Black
        Me.btn_2.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_2.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.btn_2.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(154, 249)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_2.Size = New System.Drawing.Size(76, 74)
        Me.btn_2.TabIndex = 11
        Me.btn_2.Text = "2"
        Me.btn_2.UseTransparentBackground = True
        '
        'btn_3
        '
        Me.btn_3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_3.Animated = True
        Me.btn_3.AnimatedGIF = True
        Me.btn_3.BackColor = System.Drawing.Color.Transparent
        Me.btn_3.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_3.BorderThickness = 1
        Me.btn_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_3.DisabledState.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_3.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_3.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_3.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_3.FillColor = System.Drawing.Color.Transparent
        Me.btn_3.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_3.ForeColor = System.Drawing.Color.Black
        Me.btn_3.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_3.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btn_3.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_3.Location = New System.Drawing.Point(271, 264)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_3.Size = New System.Drawing.Size(76, 74)
        Me.btn_3.TabIndex = 10
        Me.btn_3.Text = "3"
        Me.btn_3.UseTransparentBackground = True
        '
        'btn_6
        '
        Me.btn_6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_6.Animated = True
        Me.btn_6.AnimatedGIF = True
        Me.btn_6.BackColor = System.Drawing.Color.Transparent
        Me.btn_6.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_6.BorderThickness = 1
        Me.btn_6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_6.DisabledState.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_6.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_6.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_6.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_6.FillColor = System.Drawing.Color.Transparent
        Me.btn_6.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_6.ForeColor = System.Drawing.Color.Black
        Me.btn_6.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_6.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btn_6.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_6.Location = New System.Drawing.Point(271, 169)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_6.Size = New System.Drawing.Size(76, 74)
        Me.btn_6.TabIndex = 9
        Me.btn_6.Text = "6"
        Me.btn_6.UseTransparentBackground = True
        '
        'btn_1
        '
        Me.btn_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_1.Animated = True
        Me.btn_1.AnimatedGIF = True
        Me.btn_1.BackColor = System.Drawing.Color.Transparent
        Me.btn_1.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_1.BorderThickness = 1
        Me.btn_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_1.DisabledState.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_1.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_1.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_1.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_1.FillColor = System.Drawing.Color.Transparent
        Me.btn_1.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_1.ForeColor = System.Drawing.Color.Black
        Me.btn_1.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_1.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btn_1.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_1.Location = New System.Drawing.Point(32, 264)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_1.Size = New System.Drawing.Size(76, 74)
        Me.btn_1.TabIndex = 8
        Me.btn_1.Text = "1"
        Me.btn_1.UseTransparentBackground = True
        '
        'btn_5
        '
        Me.btn_5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_5.Animated = True
        Me.btn_5.AnimatedGIF = True
        Me.btn_5.BackColor = System.Drawing.Color.Transparent
        Me.btn_5.BorderColor = System.Drawing.Color.Maroon
        Me.btn_5.BorderThickness = 1
        Me.btn_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_5.DisabledState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_5.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_5.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_5.FillColor = System.Drawing.Color.Transparent
        Me.btn_5.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_5.ForeColor = System.Drawing.Color.Black
        Me.btn_5.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_5.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.btn_5.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(154, 158)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_5.Size = New System.Drawing.Size(76, 74)
        Me.btn_5.TabIndex = 7
        Me.btn_5.Text = "5"
        Me.btn_5.UseTransparentBackground = True
        '
        'btn_9
        '
        Me.btn_9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_9.Animated = True
        Me.btn_9.AnimatedGIF = True
        Me.btn_9.BackColor = System.Drawing.Color.Transparent
        Me.btn_9.BorderColor = System.Drawing.Color.Maroon
        Me.btn_9.BorderThickness = 1
        Me.btn_9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_9.DisabledState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_9.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_9.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_9.FillColor = System.Drawing.Color.Transparent
        Me.btn_9.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_9.ForeColor = System.Drawing.Color.Black
        Me.btn_9.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_9.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.btn_9.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(271, 80)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_9.Size = New System.Drawing.Size(76, 74)
        Me.btn_9.TabIndex = 6
        Me.btn_9.Text = "9"
        Me.btn_9.UseTransparentBackground = True
        '
        'btn_0
        '
        Me.btn_0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_0.Animated = True
        Me.btn_0.AnimatedGIF = True
        Me.btn_0.BackColor = System.Drawing.Color.Transparent
        Me.btn_0.BorderColor = System.Drawing.Color.Maroon
        Me.btn_0.BorderThickness = 1
        Me.btn_0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_0.DisabledState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_0.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_0.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_0.FillColor = System.Drawing.Color.Transparent
        Me.btn_0.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_0.ForeColor = System.Drawing.Color.Black
        Me.btn_0.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_0.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.btn_0.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(154, 344)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_0.Size = New System.Drawing.Size(76, 74)
        Me.btn_0.TabIndex = 5
        Me.btn_0.Text = "0"
        Me.btn_0.UseTransparentBackground = True
        '
        'btn_4
        '
        Me.btn_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_4.Animated = True
        Me.btn_4.AnimatedGIF = True
        Me.btn_4.BackColor = System.Drawing.Color.Transparent
        Me.btn_4.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_4.BorderThickness = 1
        Me.btn_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_4.DisabledState.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_4.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_4.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_4.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_4.FillColor = System.Drawing.Color.Transparent
        Me.btn_4.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_4.ForeColor = System.Drawing.Color.Black
        Me.btn_4.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_4.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btn_4.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_4.Location = New System.Drawing.Point(32, 169)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_4.Size = New System.Drawing.Size(76, 74)
        Me.btn_4.TabIndex = 4
        Me.btn_4.Text = "4"
        Me.btn_4.UseTransparentBackground = True
        '
        'btn_8
        '
        Me.btn_8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_8.Animated = True
        Me.btn_8.AnimatedGIF = True
        Me.btn_8.BackColor = System.Drawing.Color.Transparent
        Me.btn_8.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_8.BorderThickness = 1
        Me.btn_8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_8.DisabledState.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_8.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_8.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_8.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_8.FillColor = System.Drawing.Color.Transparent
        Me.btn_8.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_8.ForeColor = System.Drawing.Color.Black
        Me.btn_8.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_8.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btn_8.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_8.Location = New System.Drawing.Point(154, 67)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_8.Size = New System.Drawing.Size(76, 74)
        Me.btn_8.TabIndex = 3
        Me.btn_8.Text = "8"
        Me.btn_8.UseTransparentBackground = True
        '
        'btn_7
        '
        Me.btn_7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_7.Animated = True
        Me.btn_7.AnimatedGIF = True
        Me.btn_7.BackColor = System.Drawing.Color.Transparent
        Me.btn_7.BorderColor = System.Drawing.Color.Maroon
        Me.btn_7.BorderThickness = 1
        Me.btn_7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_7.DisabledState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_7.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_7.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.btn_7.FillColor = System.Drawing.Color.Transparent
        Me.btn_7.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!)
        Me.btn_7.ForeColor = System.Drawing.Color.Black
        Me.btn_7.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_7.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.btn_7.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(32, 80)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_7.Size = New System.Drawing.Size(76, 74)
        Me.btn_7.TabIndex = 2
        Me.btn_7.Text = "7"
        Me.btn_7.UseTransparentBackground = True
        '
        'panel_display
        '
        Me.panel_display.Controls.Add(Me.txt_passcode)
        Me.panel_display.Controls.Add(Me.Guna2TextBox2)
        Me.panel_display.Controls.Add(Me.Guna2TextBox1)
        Me.panel_display.Controls.Add(Me.btn_clear)
        Me.panel_display.Controls.Add(Me.btn_set)
        Me.panel_display.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_display.Location = New System.Drawing.Point(0, 0)
        Me.panel_display.Name = "panel_display"
        Me.panel_display.Size = New System.Drawing.Size(386, 44)
        Me.panel_display.TabIndex = 1
        '
        'txt_passcode
        '
        Me.txt_passcode.Animated = True
        Me.txt_passcode.BorderColor = System.Drawing.Color.Brown
        Me.txt_passcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_passcode.DefaultText = ""
        Me.txt_passcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_passcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_passcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_passcode.FillColor = System.Drawing.Color.Brown
        Me.txt_passcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passcode.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passcode.ForeColor = System.Drawing.Color.Black
        Me.txt_passcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passcode.Location = New System.Drawing.Point(0, 0)
        Me.txt_passcode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_passcode.MaxLength = 4
        Me.txt_passcode.Name = "txt_passcode"
        Me.txt_passcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_passcode.PlaceholderForeColor = System.Drawing.Color.White
        Me.txt_passcode.PlaceholderText = "Enter Passcode"
        Me.txt_passcode.SelectedText = ""
        Me.txt_passcode.Size = New System.Drawing.Size(231, 44)
        Me.txt_passcode.TabIndex = 53
        Me.txt_passcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = "Enter Passcode"
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.Maroon
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TextBox2.MaxLength = 4
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.White
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(231, 44)
        Me.Guna2TextBox2.TabIndex = 52
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TextBox1.MaxLength = 4
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.PlaceholderText = "Enter Passcode"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(231, 44)
        Me.Guna2TextBox1.TabIndex = 51
        '
        'btn_clear
        '
        Me.btn_clear.Animated = True
        Me.btn_clear.AnimatedGIF = True
        Me.btn_clear.BorderRadius = 5
        Me.btn_clear.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_clear.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_clear.DisabledState.ForeColor = System.Drawing.Color.Maroon
        Me.btn_clear.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_clear.FillColor = System.Drawing.Color.Transparent
        Me.btn_clear.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!)
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_clear.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.btn_clear.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.HoverState.ForeColor = System.Drawing.Color.Maroon
        Me.btn_clear.Location = New System.Drawing.Point(231, 0)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(81, 44)
        Me.btn_clear.TabIndex = 50
        Me.btn_clear.Text = "CLEAR"
        '
        'btn_set
        '
        Me.btn_set.Animated = True
        Me.btn_set.AnimatedGIF = True
        Me.btn_set.BorderRadius = 5
        Me.btn_set.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btn_set.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btn_set.DisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btn_set.DisabledState.ForeColor = System.Drawing.Color.Maroon
        Me.btn_set.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_set.FillColor = System.Drawing.Color.Brown
        Me.btn_set.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!)
        Me.btn_set.ForeColor = System.Drawing.Color.White
        Me.btn_set.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btn_set.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.btn_set.HoverState.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_set.HoverState.ForeColor = System.Drawing.Color.Maroon
        Me.btn_set.Location = New System.Drawing.Point(312, 0)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(74, 44)
        Me.btn_set.TabIndex = 49
        Me.btn_set.Text = "SET"
        '
        'tooltip_passcode
        '
        Me.tooltip_passcode.AllowLinksHandling = True
        Me.tooltip_passcode.BackColor = System.Drawing.Color.Silver
        Me.tooltip_passcode.BorderColor = System.Drawing.Color.DimGray
        Me.tooltip_passcode.ForeColor = System.Drawing.Color.Maroon
        Me.tooltip_passcode.MaximumSize = New System.Drawing.Size(0, 0)
        Me.tooltip_passcode.TitleFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tooltip_passcode.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'PassCode
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.panel_holder)
        Me.Name = "PassCode"
        Me.Size = New System.Drawing.Size(386, 588)
        Me.panel_holder.ResumeLayout(False)
        Me.panel_frontview.ResumeLayout(False)
        Me.panel_front_holder.ResumeLayout(False)
        Me.panel_main.ResumeLayout(False)
        Me.panel_message.ResumeLayout(False)
        CType(Me.pic_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_frontbuttons.ResumeLayout(False)
        Me.panel_exit.ResumeLayout(False)
        Me.panel_buttons.ResumeLayout(False)
        Me.panel_display.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents panel_holder As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents panel_buttons As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_3 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_6 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_5 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_9 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_0 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_4 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_8 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_7 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents panel_display As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tooltip_passcode As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents btn_next As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panel_exit As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panel_frontview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panel_front_holder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prg_passcode As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents panel_main As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panel_message As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_message As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pic_info As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents panel_frontbuttons As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_proceed As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_clear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_set As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_passcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents cmb_admintype As Guna.UI2.WinForms.Guna2ComboBox
End Class
