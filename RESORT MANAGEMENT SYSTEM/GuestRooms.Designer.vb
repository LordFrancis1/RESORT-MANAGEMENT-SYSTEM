<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestRooms
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
        Me.Panel_Title = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FLP_RoomButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.Grp_SingleRooms = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_SingleRooms = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Room1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton21 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Grp_DoubleRooms = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_DoubleRooms = New System.Windows.Forms.FlowLayoutPanel()
        Me.Grp_TripleRooms = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_TripleRooms = New System.Windows.Forms.FlowLayoutPanel()
        Me.Grp_TwinRooms = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_TwinRooms = New System.Windows.Forms.FlowLayoutPanel()
        Me.Grp_JuniourSuite = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_JuniourSuite = New System.Windows.Forms.FlowLayoutPanel()
        Me.Grp_ExecutiveSuite = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_ExecutiveSuite = New System.Windows.Forms.FlowLayoutPanel()
        Me.Grp_PresidentialSuite = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.FLP_PresidentialSuite = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Title.SuspendLayout()
        Me.FLP_RoomButtons.SuspendLayout()
        Me.Grp_SingleRooms.SuspendLayout()
        Me.FLP_SingleRooms.SuspendLayout()
        Me.Grp_DoubleRooms.SuspendLayout()
        Me.Grp_TripleRooms.SuspendLayout()
        Me.Grp_TwinRooms.SuspendLayout()
        Me.Grp_JuniourSuite.SuspendLayout()
        Me.Grp_ExecutiveSuite.SuspendLayout()
        Me.Grp_PresidentialSuite.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Title.Controls.Add(Me.Lbl_Title)
        Me.Panel_Title.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1450, 25)
        Me.Panel_Title.TabIndex = 85
        Me.Panel_Title.UseTransparentBackground = True
        Me.Panel_Title.Visible = False
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
        Me.Lbl_Title.Size = New System.Drawing.Size(237, 25)
        Me.Lbl_Title.TabIndex = 19
        Me.Lbl_Title.Text = "Hotel Guest Rooms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Inform.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Inform.Location = New System.Drawing.Point(1026, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(421, 25)
        Me.Lbl_Inform.TabIndex = 18
        Me.Lbl_Inform.Text = "Hotel Name"
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FLP_RoomButtons
        '
        Me.FLP_RoomButtons.AutoScroll = True
        Me.FLP_RoomButtons.Controls.Add(Me.Grp_SingleRooms)
        Me.FLP_RoomButtons.Controls.Add(Me.Grp_DoubleRooms)
        Me.FLP_RoomButtons.Controls.Add(Me.Grp_TripleRooms)
        Me.FLP_RoomButtons.Controls.Add(Me.Grp_TwinRooms)
        Me.FLP_RoomButtons.Controls.Add(Me.Grp_JuniourSuite)
        Me.FLP_RoomButtons.Controls.Add(Me.Grp_ExecutiveSuite)
        Me.FLP_RoomButtons.Controls.Add(Me.Grp_PresidentialSuite)
        Me.FLP_RoomButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_RoomButtons.Location = New System.Drawing.Point(0, 25)
        Me.FLP_RoomButtons.Name = "FLP_RoomButtons"
        Me.FLP_RoomButtons.Size = New System.Drawing.Size(1450, 1175)
        Me.FLP_RoomButtons.TabIndex = 86
        '
        'Grp_SingleRooms
        '
        Me.Grp_SingleRooms.BackColor = System.Drawing.Color.Transparent
        Me.Grp_SingleRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Grp_SingleRooms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_SingleRooms.BorderRadius = 5
        Me.Grp_SingleRooms.Controls.Add(Me.FLP_SingleRooms)
        Me.Grp_SingleRooms.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_SingleRooms.FillColor = System.Drawing.Color.Transparent
        Me.Grp_SingleRooms.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_SingleRooms.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_SingleRooms.Location = New System.Drawing.Point(3, 3)
        Me.Grp_SingleRooms.Name = "Grp_SingleRooms"
        Me.Grp_SingleRooms.Size = New System.Drawing.Size(455, 363)
        Me.Grp_SingleRooms.TabIndex = 53
        Me.Grp_SingleRooms.Text = "Single Rooms"
        Me.Grp_SingleRooms.UseTransparentBackground = True
        '
        'FLP_SingleRooms
        '
        Me.FLP_SingleRooms.AutoScroll = True
        Me.FLP_SingleRooms.Controls.Add(Me.Btn_Room1)
        Me.FLP_SingleRooms.Controls.Add(Me.Guna2GradientButton21)
        Me.FLP_SingleRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_SingleRooms.Location = New System.Drawing.Point(0, 40)
        Me.FLP_SingleRooms.Name = "FLP_SingleRooms"
        Me.FLP_SingleRooms.Size = New System.Drawing.Size(455, 323)
        Me.FLP_SingleRooms.TabIndex = 16
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
        Me.Btn_Room1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Room1.ForeColor = System.Drawing.Color.White
        Me.Btn_Room1.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Room1.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Btn_Room1.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Btn_Room1.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Room1.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Room1.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Room1.Name = "Btn_Room1"
        Me.Btn_Room1.PressedColor = System.Drawing.Color.White
        Me.Btn_Room1.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Room1.TabIndex = 51
        Me.Btn_Room1.Text = "Room 1"
        '
        'Guna2GradientButton21
        '
        Me.Guna2GradientButton21.Animated = True
        Me.Guna2GradientButton21.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton21.BorderRadius = 5
        Me.Guna2GradientButton21.BorderThickness = 1
        Me.Guna2GradientButton21.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton21.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton21.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton21.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton21.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton21.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton21.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton21.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton21.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton21.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Guna2GradientButton21.HoverState.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton21.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton21.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton21.Location = New System.Drawing.Point(109, 3)
        Me.Guna2GradientButton21.Name = "Guna2GradientButton21"
        Me.Guna2GradientButton21.PressedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2GradientButton21.Size = New System.Drawing.Size(100, 50)
        Me.Guna2GradientButton21.TabIndex = 72
        Me.Guna2GradientButton21.Text = "Room 2"
        '
        'Grp_DoubleRooms
        '
        Me.Grp_DoubleRooms.BackColor = System.Drawing.Color.Transparent
        Me.Grp_DoubleRooms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_DoubleRooms.BorderRadius = 5
        Me.Grp_DoubleRooms.Controls.Add(Me.FLP_DoubleRooms)
        Me.Grp_DoubleRooms.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_DoubleRooms.FillColor = System.Drawing.Color.Transparent
        Me.Grp_DoubleRooms.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_DoubleRooms.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_DoubleRooms.Location = New System.Drawing.Point(464, 3)
        Me.Grp_DoubleRooms.Name = "Grp_DoubleRooms"
        Me.Grp_DoubleRooms.Size = New System.Drawing.Size(455, 363)
        Me.Grp_DoubleRooms.TabIndex = 54
        Me.Grp_DoubleRooms.Text = "Double Rooms"
        '
        'FLP_DoubleRooms
        '
        Me.FLP_DoubleRooms.AutoScroll = True
        Me.FLP_DoubleRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_DoubleRooms.Location = New System.Drawing.Point(0, 40)
        Me.FLP_DoubleRooms.Name = "FLP_DoubleRooms"
        Me.FLP_DoubleRooms.Size = New System.Drawing.Size(455, 323)
        Me.FLP_DoubleRooms.TabIndex = 16
        '
        'Grp_TripleRooms
        '
        Me.Grp_TripleRooms.BackColor = System.Drawing.Color.Transparent
        Me.Grp_TripleRooms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_TripleRooms.BorderRadius = 5
        Me.Grp_TripleRooms.Controls.Add(Me.FLP_TripleRooms)
        Me.Grp_TripleRooms.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_TripleRooms.FillColor = System.Drawing.Color.Transparent
        Me.Grp_TripleRooms.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_TripleRooms.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_TripleRooms.Location = New System.Drawing.Point(925, 3)
        Me.Grp_TripleRooms.Name = "Grp_TripleRooms"
        Me.Grp_TripleRooms.Size = New System.Drawing.Size(455, 363)
        Me.Grp_TripleRooms.TabIndex = 55
        Me.Grp_TripleRooms.Text = "Triple Rooms"
        '
        'FLP_TripleRooms
        '
        Me.FLP_TripleRooms.AutoScroll = True
        Me.FLP_TripleRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_TripleRooms.Location = New System.Drawing.Point(0, 40)
        Me.FLP_TripleRooms.Name = "FLP_TripleRooms"
        Me.FLP_TripleRooms.Size = New System.Drawing.Size(455, 323)
        Me.FLP_TripleRooms.TabIndex = 16
        '
        'Grp_TwinRooms
        '
        Me.Grp_TwinRooms.BackColor = System.Drawing.Color.Transparent
        Me.Grp_TwinRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Grp_TwinRooms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_TwinRooms.BorderRadius = 5
        Me.Grp_TwinRooms.Controls.Add(Me.FLP_TwinRooms)
        Me.Grp_TwinRooms.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_TwinRooms.FillColor = System.Drawing.Color.Transparent
        Me.Grp_TwinRooms.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_TwinRooms.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_TwinRooms.Location = New System.Drawing.Point(3, 372)
        Me.Grp_TwinRooms.Name = "Grp_TwinRooms"
        Me.Grp_TwinRooms.Size = New System.Drawing.Size(455, 363)
        Me.Grp_TwinRooms.TabIndex = 56
        Me.Grp_TwinRooms.Text = "Twin Rooms"
        Me.Grp_TwinRooms.UseTransparentBackground = True
        '
        'FLP_TwinRooms
        '
        Me.FLP_TwinRooms.AutoScroll = True
        Me.FLP_TwinRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_TwinRooms.Location = New System.Drawing.Point(0, 40)
        Me.FLP_TwinRooms.Name = "FLP_TwinRooms"
        Me.FLP_TwinRooms.Size = New System.Drawing.Size(455, 323)
        Me.FLP_TwinRooms.TabIndex = 16
        '
        'Grp_JuniourSuite
        '
        Me.Grp_JuniourSuite.BackColor = System.Drawing.Color.Transparent
        Me.Grp_JuniourSuite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_JuniourSuite.BorderRadius = 5
        Me.Grp_JuniourSuite.Controls.Add(Me.FLP_JuniourSuite)
        Me.Grp_JuniourSuite.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_JuniourSuite.FillColor = System.Drawing.Color.Transparent
        Me.Grp_JuniourSuite.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_JuniourSuite.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_JuniourSuite.Location = New System.Drawing.Point(464, 372)
        Me.Grp_JuniourSuite.Name = "Grp_JuniourSuite"
        Me.Grp_JuniourSuite.Size = New System.Drawing.Size(455, 363)
        Me.Grp_JuniourSuite.TabIndex = 57
        Me.Grp_JuniourSuite.Text = "Juniour Suite"
        '
        'FLP_JuniourSuite
        '
        Me.FLP_JuniourSuite.AutoScroll = True
        Me.FLP_JuniourSuite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_JuniourSuite.Location = New System.Drawing.Point(0, 40)
        Me.FLP_JuniourSuite.Name = "FLP_JuniourSuite"
        Me.FLP_JuniourSuite.Size = New System.Drawing.Size(455, 323)
        Me.FLP_JuniourSuite.TabIndex = 16
        '
        'Grp_ExecutiveSuite
        '
        Me.Grp_ExecutiveSuite.BackColor = System.Drawing.Color.Transparent
        Me.Grp_ExecutiveSuite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_ExecutiveSuite.BorderRadius = 5
        Me.Grp_ExecutiveSuite.Controls.Add(Me.FLP_ExecutiveSuite)
        Me.Grp_ExecutiveSuite.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_ExecutiveSuite.FillColor = System.Drawing.Color.Transparent
        Me.Grp_ExecutiveSuite.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_ExecutiveSuite.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_ExecutiveSuite.Location = New System.Drawing.Point(925, 372)
        Me.Grp_ExecutiveSuite.Name = "Grp_ExecutiveSuite"
        Me.Grp_ExecutiveSuite.Size = New System.Drawing.Size(455, 363)
        Me.Grp_ExecutiveSuite.TabIndex = 58
        Me.Grp_ExecutiveSuite.Text = "Executive Suite"
        '
        'FLP_ExecutiveSuite
        '
        Me.FLP_ExecutiveSuite.AutoScroll = True
        Me.FLP_ExecutiveSuite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_ExecutiveSuite.Location = New System.Drawing.Point(0, 40)
        Me.FLP_ExecutiveSuite.Name = "FLP_ExecutiveSuite"
        Me.FLP_ExecutiveSuite.Size = New System.Drawing.Size(455, 323)
        Me.FLP_ExecutiveSuite.TabIndex = 16
        '
        'Grp_PresidentialSuite
        '
        Me.Grp_PresidentialSuite.BackColor = System.Drawing.Color.Transparent
        Me.Grp_PresidentialSuite.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_PresidentialSuite.BorderRadius = 5
        Me.Grp_PresidentialSuite.Controls.Add(Me.FLP_PresidentialSuite)
        Me.Grp_PresidentialSuite.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_PresidentialSuite.FillColor = System.Drawing.Color.Transparent
        Me.Grp_PresidentialSuite.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_PresidentialSuite.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_PresidentialSuite.Location = New System.Drawing.Point(3, 741)
        Me.Grp_PresidentialSuite.Name = "Grp_PresidentialSuite"
        Me.Grp_PresidentialSuite.Size = New System.Drawing.Size(455, 363)
        Me.Grp_PresidentialSuite.TabIndex = 59
        Me.Grp_PresidentialSuite.Text = "Presidential Suite"
        '
        'FLP_PresidentialSuite
        '
        Me.FLP_PresidentialSuite.AutoScroll = True
        Me.FLP_PresidentialSuite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_PresidentialSuite.Location = New System.Drawing.Point(0, 40)
        Me.FLP_PresidentialSuite.Name = "FLP_PresidentialSuite"
        Me.FLP_PresidentialSuite.Size = New System.Drawing.Size(455, 323)
        Me.FLP_PresidentialSuite.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'GuestRooms
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.FLP_RoomButtons)
        Me.Controls.Add(Me.Panel_Title)
        Me.Name = "GuestRooms"
        Me.Size = New System.Drawing.Size(1450, 1200)
        Me.Panel_Title.ResumeLayout(False)
        Me.FLP_RoomButtons.ResumeLayout(False)
        Me.Grp_SingleRooms.ResumeLayout(False)
        Me.FLP_SingleRooms.ResumeLayout(False)
        Me.Grp_DoubleRooms.ResumeLayout(False)
        Me.Grp_TripleRooms.ResumeLayout(False)
        Me.Grp_TwinRooms.ResumeLayout(False)
        Me.Grp_JuniourSuite.ResumeLayout(False)
        Me.Grp_ExecutiveSuite.ResumeLayout(False)
        Me.Grp_PresidentialSuite.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FLP_RoomButtons As FlowLayoutPanel
    Friend WithEvents Grp_SingleRooms As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FLP_SingleRooms As FlowLayoutPanel
    Friend WithEvents Btn_Room1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton21 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Grp_DoubleRooms As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FLP_DoubleRooms As FlowLayoutPanel
    Friend WithEvents Grp_TripleRooms As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FLP_TripleRooms As FlowLayoutPanel
    Friend WithEvents Grp_TwinRooms As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FLP_TwinRooms As FlowLayoutPanel
    Friend WithEvents Grp_JuniourSuite As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FLP_JuniourSuite As FlowLayoutPanel
    Friend WithEvents Grp_ExecutiveSuite As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FLP_ExecutiveSuite As FlowLayoutPanel
    Friend WithEvents Grp_PresidentialSuite As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FLP_PresidentialSuite As FlowLayoutPanel
    Friend WithEvents Lbl_Title As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
