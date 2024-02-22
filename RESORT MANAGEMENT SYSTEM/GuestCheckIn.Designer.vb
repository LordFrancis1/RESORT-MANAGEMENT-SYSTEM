<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestCheckIn
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
        Me.Panel_Display = New Guna.UI2.WinForms.Guna2Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel_Layer2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_HsKeepingStatus = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2GradientButton14 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton16 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton15 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.FLP_RoomButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_AllRooms = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Btn_Room1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Btn_Room2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Dirty = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Prg_Dirty = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Lbl_Cleaning = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Prg_Cleaning = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Lbl_Cleaned = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Prg_Cleaned = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Lbl_Vacant = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Prg_Vacant = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Lbl_Booked = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Prg_Booked = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FLP_Display1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Pic_Wall1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.FLP_Display2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Pic_Wall2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Pic_Wall3 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Pic_Wall4 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Pic_Wall5 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Lbl_FLPTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn_Cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_Guest = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_SearchGuest = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Buttons = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_Display.SuspendLayout()
        Me.Panel_Layer2.SuspendLayout()
        Me.FLP_HsKeepingStatus.SuspendLayout()
        Me.FLP_RoomButtons.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.FLP_Display1.SuspendLayout()
        Me.FLP_Display2.SuspendLayout()
        Me.Panel_Guest.SuspendLayout()
        Me.Panel_Buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Display
        '
        Me.Panel_Display.AutoScroll = True
        Me.Panel_Display.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Display.BorderColor = System.Drawing.Color.Transparent
        Me.Panel_Display.BorderThickness = 1
        Me.Panel_Display.Controls.Add(Me.MonthCalendar1)
        Me.Panel_Display.Controls.Add(Me.Panel_Layer2)
        Me.Panel_Display.Controls.Add(Me.FLP_Display1)
        Me.Panel_Display.Controls.Add(Me.Lbl_FLPTitle)
        Me.Panel_Display.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Display.FillColor = System.Drawing.Color.DarkGray
        Me.Panel_Display.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Display.Name = "Panel_Display"
        Me.Panel_Display.Size = New System.Drawing.Size(700, 780)
        Me.Panel_Display.TabIndex = 8
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MonthCalendar1.Location = New System.Drawing.Point(473, 530)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 22
        '
        'Panel_Layer2
        '
        Me.Panel_Layer2.Controls.Add(Me.FLP_HsKeepingStatus)
        Me.Panel_Layer2.Controls.Add(Me.FLP_RoomButtons)
        Me.Panel_Layer2.Controls.Add(Me.Guna2Panel1)
        Me.Panel_Layer2.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Panel_Layer2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Layer2.Location = New System.Drawing.Point(0, 300)
        Me.Panel_Layer2.Name = "Panel_Layer2"
        Me.Panel_Layer2.Size = New System.Drawing.Size(700, 230)
        Me.Panel_Layer2.TabIndex = 21
        '
        'FLP_HsKeepingStatus
        '
        Me.FLP_HsKeepingStatus.AutoScroll = True
        Me.FLP_HsKeepingStatus.Controls.Add(Me.Guna2GradientButton14)
        Me.FLP_HsKeepingStatus.Controls.Add(Me.Guna2GradientButton16)
        Me.FLP_HsKeepingStatus.Controls.Add(Me.Guna2GradientButton15)
        Me.FLP_HsKeepingStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_HsKeepingStatus.Location = New System.Drawing.Point(350, 30)
        Me.FLP_HsKeepingStatus.Name = "FLP_HsKeepingStatus"
        Me.FLP_HsKeepingStatus.Size = New System.Drawing.Size(350, 170)
        Me.FLP_HsKeepingStatus.TabIndex = 23
        '
        'Guna2GradientButton14
        '
        Me.Guna2GradientButton14.Animated = True
        Me.Guna2GradientButton14.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton14.BorderRadius = 5
        Me.Guna2GradientButton14.BorderThickness = 1
        Me.Guna2GradientButton14.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton14.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton14.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton14.FillColor = System.Drawing.Color.Green
        Me.Guna2GradientButton14.FillColor2 = System.Drawing.Color.Green
        Me.Guna2GradientButton14.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Guna2GradientButton14.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton14.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton14.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Guna2GradientButton14.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton14.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton14.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton14.Location = New System.Drawing.Point(3, 3)
        Me.Guna2GradientButton14.Name = "Guna2GradientButton14"
        Me.Guna2GradientButton14.PressedColor = System.Drawing.Color.White
        Me.Guna2GradientButton14.Size = New System.Drawing.Size(95, 35)
        Me.Guna2GradientButton14.TabIndex = 51
        Me.Guna2GradientButton14.Text = "Room 1"
        '
        'Guna2GradientButton16
        '
        Me.Guna2GradientButton16.Animated = True
        Me.Guna2GradientButton16.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton16.BorderRadius = 5
        Me.Guna2GradientButton16.BorderThickness = 1
        Me.Guna2GradientButton16.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton16.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton16.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton16.FillColor = System.Drawing.Color.Blue
        Me.Guna2GradientButton16.FillColor2 = System.Drawing.Color.Blue
        Me.Guna2GradientButton16.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Guna2GradientButton16.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton16.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton16.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Guna2GradientButton16.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton16.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton16.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton16.Location = New System.Drawing.Point(104, 3)
        Me.Guna2GradientButton16.Name = "Guna2GradientButton16"
        Me.Guna2GradientButton16.PressedColor = System.Drawing.Color.White
        Me.Guna2GradientButton16.Size = New System.Drawing.Size(95, 35)
        Me.Guna2GradientButton16.TabIndex = 53
        Me.Guna2GradientButton16.Text = "Room 2"
        '
        'Guna2GradientButton15
        '
        Me.Guna2GradientButton15.Animated = True
        Me.Guna2GradientButton15.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton15.BorderRadius = 5
        Me.Guna2GradientButton15.BorderThickness = 1
        Me.Guna2GradientButton15.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton15.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton15.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton15.FillColor = System.Drawing.Color.Brown
        Me.Guna2GradientButton15.FillColor2 = System.Drawing.Color.Brown
        Me.Guna2GradientButton15.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Guna2GradientButton15.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton15.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton15.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Guna2GradientButton15.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton15.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton15.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton15.Location = New System.Drawing.Point(205, 3)
        Me.Guna2GradientButton15.Name = "Guna2GradientButton15"
        Me.Guna2GradientButton15.PressedColor = System.Drawing.Color.White
        Me.Guna2GradientButton15.Size = New System.Drawing.Size(95, 35)
        Me.Guna2GradientButton15.TabIndex = 54
        Me.Guna2GradientButton15.Text = "Room 3"
        '
        'FLP_RoomButtons
        '
        Me.FLP_RoomButtons.AutoScroll = True
        Me.FLP_RoomButtons.Controls.Add(Me.Btn_AllRooms)
        Me.FLP_RoomButtons.Controls.Add(Me.Btn_Room1)
        Me.FLP_RoomButtons.Controls.Add(Me.Btn_Room2)
        Me.FLP_RoomButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.FLP_RoomButtons.Location = New System.Drawing.Point(0, 30)
        Me.FLP_RoomButtons.Name = "FLP_RoomButtons"
        Me.FLP_RoomButtons.Size = New System.Drawing.Size(350, 170)
        Me.FLP_RoomButtons.TabIndex = 16
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
        Me.Btn_AllRooms.Location = New System.Drawing.Point(3, 3)
        Me.Btn_AllRooms.Name = "Btn_AllRooms"
        Me.Btn_AllRooms.PressedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AllRooms.Size = New System.Drawing.Size(312, 70)
        Me.Btn_AllRooms.TabIndex = 54
        Me.Btn_AllRooms.Text = "VIEW REPORT"
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
        Me.Btn_Room1.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Btn_Room1.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Btn_Room1.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Room1.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Room1.Location = New System.Drawing.Point(3, 79)
        Me.Btn_Room1.Name = "Btn_Room1"
        Me.Btn_Room1.PressedColor = System.Drawing.Color.White
        Me.Btn_Room1.Size = New System.Drawing.Size(100, 35)
        Me.Btn_Room1.TabIndex = 51
        Me.Btn_Room1.Text = "Room 1"
        '
        'Btn_Room2
        '
        Me.Btn_Room2.Animated = True
        Me.Btn_Room2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Room2.BorderRadius = 5
        Me.Btn_Room2.BorderThickness = 1
        Me.Btn_Room2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Room2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Room2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Room2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Room2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Room2.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Room2.FillColor2 = System.Drawing.Color.Transparent
        Me.Btn_Room2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Btn_Room2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Room2.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Room2.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Btn_Room2.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Btn_Room2.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Room2.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Room2.Location = New System.Drawing.Point(109, 79)
        Me.Btn_Room2.Name = "Btn_Room2"
        Me.Btn_Room2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_Room2.Size = New System.Drawing.Size(100, 35)
        Me.Btn_Room2.TabIndex = 52
        Me.Btn_Room2.Text = "Room 2"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Lbl_Dirty)
        Me.Guna2Panel1.Controls.Add(Me.Prg_Dirty)
        Me.Guna2Panel1.Controls.Add(Me.Lbl_Cleaning)
        Me.Guna2Panel1.Controls.Add(Me.Prg_Cleaning)
        Me.Guna2Panel1.Controls.Add(Me.Lbl_Cleaned)
        Me.Guna2Panel1.Controls.Add(Me.Prg_Cleaned)
        Me.Guna2Panel1.Controls.Add(Me.Lbl_Vacant)
        Me.Guna2Panel1.Controls.Add(Me.Prg_Vacant)
        Me.Guna2Panel1.Controls.Add(Me.Lbl_Booked)
        Me.Guna2Panel1.Controls.Add(Me.Prg_Booked)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 200)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(700, 30)
        Me.Guna2Panel1.TabIndex = 21
        '
        'Lbl_Dirty
        '
        Me.Lbl_Dirty.AutoSize = False
        Me.Lbl_Dirty.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Dirty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Dirty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_Dirty.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Dirty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Dirty.Location = New System.Drawing.Point(665, 0)
        Me.Lbl_Dirty.Name = "Lbl_Dirty"
        Me.Lbl_Dirty.Size = New System.Drawing.Size(35, 30)
        Me.Lbl_Dirty.TabIndex = 28
        Me.Lbl_Dirty.Text = "10"
        Me.Lbl_Dirty.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prg_Dirty
        '
        Me.Prg_Dirty.BorderColor = System.Drawing.Color.Transparent
        Me.Prg_Dirty.BorderThickness = 1
        Me.Prg_Dirty.Dock = System.Windows.Forms.DockStyle.Left
        Me.Prg_Dirty.FillColor = System.Drawing.Color.Transparent
        Me.Prg_Dirty.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_Dirty.ForeColor = System.Drawing.Color.White
        Me.Prg_Dirty.Location = New System.Drawing.Point(580, 0)
        Me.Prg_Dirty.Name = "Prg_Dirty"
        Me.Prg_Dirty.ProgressColor = System.Drawing.Color.Brown
        Me.Prg_Dirty.ProgressColor2 = System.Drawing.Color.Brown
        Me.Prg_Dirty.ShowText = True
        Me.Prg_Dirty.Size = New System.Drawing.Size(85, 30)
        Me.Prg_Dirty.TabIndex = 27
        Me.Prg_Dirty.Text = "Dirty"
        Me.Prg_Dirty.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        Me.Prg_Dirty.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Prg_Dirty.UseTransparentBackground = True
        Me.Prg_Dirty.Value = 10
        '
        'Lbl_Cleaning
        '
        Me.Lbl_Cleaning.AutoSize = False
        Me.Lbl_Cleaning.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Cleaning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Cleaning.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_Cleaning.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cleaning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Cleaning.Location = New System.Drawing.Point(550, 0)
        Me.Lbl_Cleaning.Name = "Lbl_Cleaning"
        Me.Lbl_Cleaning.Size = New System.Drawing.Size(30, 30)
        Me.Lbl_Cleaning.TabIndex = 26
        Me.Lbl_Cleaning.Text = "10"
        Me.Lbl_Cleaning.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prg_Cleaning
        '
        Me.Prg_Cleaning.BorderColor = System.Drawing.Color.Transparent
        Me.Prg_Cleaning.BorderThickness = 1
        Me.Prg_Cleaning.Dock = System.Windows.Forms.DockStyle.Left
        Me.Prg_Cleaning.FillColor = System.Drawing.Color.Transparent
        Me.Prg_Cleaning.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_Cleaning.ForeColor = System.Drawing.Color.White
        Me.Prg_Cleaning.Location = New System.Drawing.Point(465, 0)
        Me.Prg_Cleaning.Name = "Prg_Cleaning"
        Me.Prg_Cleaning.ProgressColor = System.Drawing.Color.Blue
        Me.Prg_Cleaning.ProgressColor2 = System.Drawing.Color.Blue
        Me.Prg_Cleaning.ShowText = True
        Me.Prg_Cleaning.Size = New System.Drawing.Size(85, 30)
        Me.Prg_Cleaning.TabIndex = 25
        Me.Prg_Cleaning.Text = "Cleaning..."
        Me.Prg_Cleaning.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        Me.Prg_Cleaning.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Prg_Cleaning.UseTransparentBackground = True
        Me.Prg_Cleaning.Value = 10
        '
        'Lbl_Cleaned
        '
        Me.Lbl_Cleaned.AutoSize = False
        Me.Lbl_Cleaned.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Cleaned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Cleaned.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_Cleaned.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cleaned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Cleaned.Location = New System.Drawing.Point(435, 0)
        Me.Lbl_Cleaned.Name = "Lbl_Cleaned"
        Me.Lbl_Cleaned.Size = New System.Drawing.Size(30, 30)
        Me.Lbl_Cleaned.TabIndex = 24
        Me.Lbl_Cleaned.Text = "10"
        Me.Lbl_Cleaned.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prg_Cleaned
        '
        Me.Prg_Cleaned.BorderColor = System.Drawing.Color.Transparent
        Me.Prg_Cleaned.BorderThickness = 1
        Me.Prg_Cleaned.Dock = System.Windows.Forms.DockStyle.Left
        Me.Prg_Cleaned.FillColor = System.Drawing.Color.Transparent
        Me.Prg_Cleaned.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_Cleaned.ForeColor = System.Drawing.Color.White
        Me.Prg_Cleaned.Location = New System.Drawing.Point(350, 0)
        Me.Prg_Cleaned.Name = "Prg_Cleaned"
        Me.Prg_Cleaned.ProgressColor = System.Drawing.Color.Green
        Me.Prg_Cleaned.ProgressColor2 = System.Drawing.Color.Green
        Me.Prg_Cleaned.ShowText = True
        Me.Prg_Cleaned.Size = New System.Drawing.Size(85, 30)
        Me.Prg_Cleaned.TabIndex = 23
        Me.Prg_Cleaned.Text = "Cleaned"
        Me.Prg_Cleaned.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        Me.Prg_Cleaned.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Prg_Cleaned.UseTransparentBackground = True
        Me.Prg_Cleaned.Value = 10
        '
        'Lbl_Vacant
        '
        Me.Lbl_Vacant.AutoSize = False
        Me.Lbl_Vacant.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Vacant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Vacant.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_Vacant.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Vacant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Vacant.Location = New System.Drawing.Point(320, 0)
        Me.Lbl_Vacant.Name = "Lbl_Vacant"
        Me.Lbl_Vacant.Size = New System.Drawing.Size(30, 30)
        Me.Lbl_Vacant.TabIndex = 22
        Me.Lbl_Vacant.Text = "0"
        Me.Lbl_Vacant.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prg_Vacant
        '
        Me.Prg_Vacant.BorderColor = System.Drawing.Color.Transparent
        Me.Prg_Vacant.BorderThickness = 1
        Me.Prg_Vacant.Dock = System.Windows.Forms.DockStyle.Left
        Me.Prg_Vacant.FillColor = System.Drawing.Color.Transparent
        Me.Prg_Vacant.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_Vacant.ForeColor = System.Drawing.Color.White
        Me.Prg_Vacant.Location = New System.Drawing.Point(175, 0)
        Me.Prg_Vacant.Name = "Prg_Vacant"
        Me.Prg_Vacant.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Prg_Vacant.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Prg_Vacant.ShowText = True
        Me.Prg_Vacant.Size = New System.Drawing.Size(145, 30)
        Me.Prg_Vacant.TabIndex = 21
        Me.Prg_Vacant.Text = "Vacant"
        Me.Prg_Vacant.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        Me.Prg_Vacant.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Prg_Vacant.UseTransparentBackground = True
        Me.Prg_Vacant.Value = 10
        '
        'Lbl_Booked
        '
        Me.Lbl_Booked.AutoSize = False
        Me.Lbl_Booked.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Booked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Booked.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_Booked.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Booked.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Booked.Location = New System.Drawing.Point(145, 0)
        Me.Lbl_Booked.Name = "Lbl_Booked"
        Me.Lbl_Booked.Size = New System.Drawing.Size(30, 30)
        Me.Lbl_Booked.TabIndex = 21
        Me.Lbl_Booked.Text = "0"
        Me.Lbl_Booked.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prg_Booked
        '
        Me.Prg_Booked.BorderColor = System.Drawing.Color.Transparent
        Me.Prg_Booked.BorderThickness = 1
        Me.Prg_Booked.Dock = System.Windows.Forms.DockStyle.Left
        Me.Prg_Booked.FillColor = System.Drawing.Color.Transparent
        Me.Prg_Booked.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_Booked.ForeColor = System.Drawing.Color.White
        Me.Prg_Booked.Location = New System.Drawing.Point(0, 0)
        Me.Prg_Booked.Name = "Prg_Booked"
        Me.Prg_Booked.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Prg_Booked.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Prg_Booked.ShowText = True
        Me.Prg_Booked.Size = New System.Drawing.Size(145, 30)
        Me.Prg_Booked.TabIndex = 20
        Me.Prg_Booked.Text = "Booked"
        Me.Prg_Booked.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        Me.Prg_Booked.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Prg_Booked.UseTransparentBackground = True
        Me.Prg_Booked.Value = 10
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.AutoSize = False
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(700, 30)
        Me.Guna2HtmlLabel10.TabIndex = 20
        Me.Guna2HtmlLabel10.Text = "Room Status"
        Me.Guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'FLP_Display1
        '
        Me.FLP_Display1.AutoScroll = True
        Me.FLP_Display1.Controls.Add(Me.Pic_Wall1)
        Me.FLP_Display1.Controls.Add(Me.FLP_Display2)
        Me.FLP_Display1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FLP_Display1.Location = New System.Drawing.Point(0, 30)
        Me.FLP_Display1.Name = "FLP_Display1"
        Me.FLP_Display1.Size = New System.Drawing.Size(700, 270)
        Me.FLP_Display1.TabIndex = 20
        '
        'Pic_Wall1
        '
        Me.Pic_Wall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Wall1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall1.HoverState.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.HotelIcon
        Me.Pic_Wall1.HoverState.ImageSize = New System.Drawing.Size(330, 250)
        Me.Pic_Wall1.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Wallpaper_2
        Me.Pic_Wall1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Pic_Wall1.ImageRotate = 0!
        Me.Pic_Wall1.ImageSize = New System.Drawing.Size(330, 250)
        Me.Pic_Wall1.Location = New System.Drawing.Point(3, 3)
        Me.Pic_Wall1.Name = "Pic_Wall1"
        Me.Pic_Wall1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Pic_Wall1.ShadowDecoration.Enabled = True
        Me.Pic_Wall1.Size = New System.Drawing.Size(300, 240)
        Me.Pic_Wall1.TabIndex = 72
        Me.Pic_Wall1.UseTransparentBackground = True
        '
        'FLP_Display2
        '
        Me.FLP_Display2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FLP_Display2.Controls.Add(Me.Pic_Wall2)
        Me.FLP_Display2.Controls.Add(Me.Pic_Wall3)
        Me.FLP_Display2.Controls.Add(Me.Pic_Wall4)
        Me.FLP_Display2.Controls.Add(Me.Pic_Wall5)
        Me.FLP_Display2.Location = New System.Drawing.Point(309, 3)
        Me.FLP_Display2.Name = "FLP_Display2"
        Me.FLP_Display2.Size = New System.Drawing.Size(371, 240)
        Me.FLP_Display2.TabIndex = 73
        '
        'Pic_Wall2
        '
        Me.Pic_Wall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Wall2.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall2.HoverState.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.HotelIcon
        Me.Pic_Wall2.HoverState.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall2.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Wallpaper_2
        Me.Pic_Wall2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Pic_Wall2.ImageRotate = 0!
        Me.Pic_Wall2.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall2.Location = New System.Drawing.Point(3, 3)
        Me.Pic_Wall2.Name = "Pic_Wall2"
        Me.Pic_Wall2.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Pic_Wall2.Size = New System.Drawing.Size(170, 120)
        Me.Pic_Wall2.TabIndex = 71
        '
        'Pic_Wall3
        '
        Me.Pic_Wall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Wall3.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall3.HoverState.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.HotelIcon
        Me.Pic_Wall3.HoverState.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall3.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Wallpaper_2
        Me.Pic_Wall3.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Pic_Wall3.ImageRotate = 0!
        Me.Pic_Wall3.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall3.Location = New System.Drawing.Point(179, 3)
        Me.Pic_Wall3.Name = "Pic_Wall3"
        Me.Pic_Wall3.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Pic_Wall3.Size = New System.Drawing.Size(170, 120)
        Me.Pic_Wall3.TabIndex = 72
        '
        'Pic_Wall4
        '
        Me.Pic_Wall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Wall4.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall4.HoverState.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.HotelIcon
        Me.Pic_Wall4.HoverState.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall4.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Wallpaper_2
        Me.Pic_Wall4.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Pic_Wall4.ImageRotate = 0!
        Me.Pic_Wall4.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall4.Location = New System.Drawing.Point(3, 129)
        Me.Pic_Wall4.Name = "Pic_Wall4"
        Me.Pic_Wall4.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Pic_Wall4.Size = New System.Drawing.Size(170, 120)
        Me.Pic_Wall4.TabIndex = 73
        '
        'Pic_Wall5
        '
        Me.Pic_Wall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Wall5.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall5.HoverState.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.HotelIcon
        Me.Pic_Wall5.HoverState.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall5.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Wallpaper_2
        Me.Pic_Wall5.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Pic_Wall5.ImageRotate = 0!
        Me.Pic_Wall5.ImageSize = New System.Drawing.Size(170, 120)
        Me.Pic_Wall5.Location = New System.Drawing.Point(179, 129)
        Me.Pic_Wall5.Name = "Pic_Wall5"
        Me.Pic_Wall5.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Pic_Wall5.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Pic_Wall5.Size = New System.Drawing.Size(170, 120)
        Me.Pic_Wall5.TabIndex = 74
        '
        'Lbl_FLPTitle
        '
        Me.Lbl_FLPTitle.AutoSize = False
        Me.Lbl_FLPTitle.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FLPTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_FLPTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_FLPTitle.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FLPTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_FLPTitle.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_FLPTitle.Name = "Lbl_FLPTitle"
        Me.Lbl_FLPTitle.Size = New System.Drawing.Size(700, 30)
        Me.Lbl_FLPTitle.TabIndex = 16
        Me.Lbl_FLPTitle.Text = "Types Of Rooms"
        Me.Lbl_FLPTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Cancel.Animated = True
        Me.Btn_Cancel.BorderColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.BorderRadius = 5
        Me.Btn_Cancel.BorderThickness = 1
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Cancel.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Cancel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.HoverState.BorderColor = System.Drawing.Color.Red
        Me.Btn_Cancel.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Cancel.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.HoverState.ForeColor = System.Drawing.Color.Red
        Me.Btn_Cancel.Location = New System.Drawing.Point(383, 13)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.PressedColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Cancel.TabIndex = 56
        Me.Btn_Cancel.Text = "CANCEL"
        '
        'Btn_Save
        '
        Me.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Save.Animated = True
        Me.Btn_Save.BorderColor = System.Drawing.Color.White
        Me.Btn_Save.BorderRadius = 5
        Me.Btn_Save.BorderThickness = 1
        Me.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Save.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_Save.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.HoverState.BorderColor = System.Drawing.Color.Green
        Me.Btn_Save.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Save.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.HoverState.ForeColor = System.Drawing.Color.Green
        Me.Btn_Save.Location = New System.Drawing.Point(507, 13)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.PressedColor = System.Drawing.Color.White
        Me.Btn_Save.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Save.TabIndex = 55
        Me.Btn_Save.Text = "CHECK IN"
        '
        'Panel_Guest
        '
        Me.Panel_Guest.Controls.Add(Me.Btn_SearchGuest)
        Me.Panel_Guest.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Guest.Location = New System.Drawing.Point(700, 0)
        Me.Panel_Guest.Name = "Panel_Guest"
        Me.Panel_Guest.Size = New System.Drawing.Size(650, 40)
        Me.Panel_Guest.TabIndex = 74
        '
        'Btn_SearchGuest
        '
        Me.Btn_SearchGuest.Animated = True
        Me.Btn_SearchGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_SearchGuest.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_SearchGuest.BorderRadius = 5
        Me.Btn_SearchGuest.BorderThickness = 1
        Me.Btn_SearchGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SearchGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_SearchGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_SearchGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_SearchGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_SearchGuest.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_SearchGuest.FillColor = System.Drawing.Color.Transparent
        Me.Btn_SearchGuest.Font = New System.Drawing.Font("Garamond", 14.25!)
        Me.Btn_SearchGuest.ForeColor = System.Drawing.Color.Black
        Me.Btn_SearchGuest.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_SearchGuest.HoverState.FillColor = System.Drawing.Color.White
        Me.Btn_SearchGuest.HoverState.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SearchGuest.HoverState.ForeColor = System.Drawing.Color.Green
        Me.Btn_SearchGuest.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Search
        Me.Btn_SearchGuest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_SearchGuest.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_SearchGuest.Location = New System.Drawing.Point(0, 0)
        Me.Btn_SearchGuest.Name = "Btn_SearchGuest"
        Me.Btn_SearchGuest.PressedColor = System.Drawing.Color.BlueViolet
        Me.Btn_SearchGuest.Size = New System.Drawing.Size(178, 40)
        Me.Btn_SearchGuest.TabIndex = 73
        Me.Btn_SearchGuest.Text = "Search Guest"
        Me.Btn_SearchGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Panel_Buttons
        '
        Me.Panel_Buttons.Controls.Add(Me.Btn_Cancel)
        Me.Panel_Buttons.Controls.Add(Me.Btn_Save)
        Me.Panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Buttons.Location = New System.Drawing.Point(700, 720)
        Me.Panel_Buttons.Name = "Panel_Buttons"
        Me.Panel_Buttons.Size = New System.Drawing.Size(650, 60)
        Me.Panel_Buttons.TabIndex = 76
        '
        'Panel_Holder
        '
        Me.Panel_Holder.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Holder.BorderRadius = 20
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.Location = New System.Drawing.Point(700, 40)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(650, 680)
        Me.Panel_Holder.TabIndex = 77
        Me.Panel_Holder.UseTransparentBackground = True
        '
        'GuestCheckIn
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.Panel_Holder)
        Me.Controls.Add(Me.Panel_Guest)
        Me.Controls.Add(Me.Panel_Buttons)
        Me.Controls.Add(Me.Panel_Display)
        Me.Name = "GuestCheckIn"
        Me.Size = New System.Drawing.Size(1350, 780)
        Me.Panel_Display.ResumeLayout(False)
        Me.Panel_Layer2.ResumeLayout(False)
        Me.FLP_HsKeepingStatus.ResumeLayout(False)
        Me.FLP_RoomButtons.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.FLP_Display1.ResumeLayout(False)
        Me.FLP_Display2.ResumeLayout(False)
        Me.Panel_Guest.ResumeLayout(False)
        Me.Panel_Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Display As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_FLPTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Btn_Cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FLP_Display1 As FlowLayoutPanel
    Friend WithEvents Pic_Wall1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents FLP_Display2 As FlowLayoutPanel
    Friend WithEvents Pic_Wall2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Pic_Wall3 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Pic_Wall4 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Pic_Wall5 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Panel_Layer2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FLP_RoomButtons As FlowLayoutPanel
    Friend WithEvents Btn_Room1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Btn_Room2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_Dirty As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Prg_Dirty As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Lbl_Cleaning As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Prg_Cleaning As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Lbl_Cleaned As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Prg_Cleaned As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Lbl_Vacant As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Prg_Vacant As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Lbl_Booked As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Prg_Booked As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents FLP_HsKeepingStatus As FlowLayoutPanel
    Friend WithEvents Guna2GradientButton14 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton16 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton15 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btn_AllRooms As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Btn_SearchGuest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Guest As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_Buttons As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
End Class
