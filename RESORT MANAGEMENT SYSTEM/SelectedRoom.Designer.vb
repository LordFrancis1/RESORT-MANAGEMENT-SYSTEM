<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectedRoom
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
        Me.Panel_Operations = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_Buttons = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_GoBack = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Btn_BookRoom = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel_TopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_Title = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Details = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_RoomStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_StayDuration = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_GuestName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_RoomPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_RoomType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_RoomNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Pic_Room = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Panel_Operations.SuspendLayout()
        Me.FLP_Buttons.SuspendLayout()
        Me.Panel_TopMenu.SuspendLayout()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Details.SuspendLayout()
        CType(Me.Pic_Room, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Operations
        '
        Me.Panel_Operations.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Operations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Operations.Controls.Add(Me.FLP_Buttons)
        Me.Panel_Operations.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Operations.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Operations.Location = New System.Drawing.Point(0, 353)
        Me.Panel_Operations.Name = "Panel_Operations"
        Me.Panel_Operations.Size = New System.Drawing.Size(620, 45)
        Me.Panel_Operations.TabIndex = 69
        Me.Panel_Operations.UseTransparentBackground = True
        '
        'FLP_Buttons
        '
        Me.FLP_Buttons.Controls.Add(Me.Btn_GoBack)
        Me.FLP_Buttons.Controls.Add(Me.Btn_BookRoom)
        Me.FLP_Buttons.Dock = System.Windows.Forms.DockStyle.Right
        Me.FLP_Buttons.Location = New System.Drawing.Point(359, 0)
        Me.FLP_Buttons.Name = "FLP_Buttons"
        Me.FLP_Buttons.Size = New System.Drawing.Size(261, 45)
        Me.FLP_Buttons.TabIndex = 55
        '
        'Btn_GoBack
        '
        Me.Btn_GoBack.Animated = True
        Me.Btn_GoBack.BorderColor = System.Drawing.Color.White
        Me.Btn_GoBack.BorderRadius = 5
        Me.Btn_GoBack.BorderThickness = 1
        Me.Btn_GoBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_GoBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_GoBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_GoBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_GoBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_GoBack.FillColor = System.Drawing.Color.Transparent
        Me.Btn_GoBack.FillColor2 = System.Drawing.Color.Transparent
        Me.Btn_GoBack.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Btn_GoBack.ForeColor = System.Drawing.Color.White
        Me.Btn_GoBack.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_GoBack.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Btn_GoBack.HoverState.FillColor2 = System.Drawing.Color.Transparent
        Me.Btn_GoBack.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GoBack.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_GoBack.Location = New System.Drawing.Point(3, 3)
        Me.Btn_GoBack.Name = "Btn_GoBack"
        Me.Btn_GoBack.PressedColor = System.Drawing.Color.White
        Me.Btn_GoBack.Size = New System.Drawing.Size(121, 35)
        Me.Btn_GoBack.TabIndex = 54
        Me.Btn_GoBack.Text = "Go Back"
        '
        'Btn_BookRoom
        '
        Me.Btn_BookRoom.Animated = True
        Me.Btn_BookRoom.BorderColor = System.Drawing.Color.White
        Me.Btn_BookRoom.BorderRadius = 5
        Me.Btn_BookRoom.BorderThickness = 1
        Me.Btn_BookRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_BookRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_BookRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_BookRoom.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_BookRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_BookRoom.FillColor = System.Drawing.Color.Transparent
        Me.Btn_BookRoom.FillColor2 = System.Drawing.Color.Transparent
        Me.Btn_BookRoom.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Btn_BookRoom.ForeColor = System.Drawing.Color.White
        Me.Btn_BookRoom.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.Btn_BookRoom.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Btn_BookRoom.HoverState.FillColor2 = System.Drawing.Color.Transparent
        Me.Btn_BookRoom.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BookRoom.HoverState.ForeColor = System.Drawing.Color.Lime
        Me.Btn_BookRoom.Location = New System.Drawing.Point(130, 3)
        Me.Btn_BookRoom.Name = "Btn_BookRoom"
        Me.Btn_BookRoom.PressedColor = System.Drawing.Color.White
        Me.Btn_BookRoom.Size = New System.Drawing.Size(121, 35)
        Me.Btn_BookRoom.TabIndex = 53
        Me.Btn_BookRoom.Text = "Book Room"
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
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Title.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Title.Location = New System.Drawing.Point(0, 30)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(620, 36)
        Me.Panel_Title.TabIndex = 84
        Me.Panel_Title.UseTransparentBackground = True
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Inform.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Inform.Location = New System.Drawing.Point(324, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(296, 36)
        Me.Lbl_Inform.TabIndex = 19
        Me.Lbl_Inform.Text = "This Room is Currently Vacant"
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Details
        '
        Me.Panel_Details.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Details.Controls.Add(Me.Lbl_RoomStatus)
        Me.Panel_Details.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel_Details.Controls.Add(Me.Lbl_StayDuration)
        Me.Panel_Details.Controls.Add(Me.Lbl_GuestName)
        Me.Panel_Details.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel_Details.Controls.Add(Me.Lbl_RoomPrice)
        Me.Panel_Details.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel_Details.Controls.Add(Me.Lbl_RoomType)
        Me.Panel_Details.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel_Details.Controls.Add(Me.Lbl_RoomNumber)
        Me.Panel_Details.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel_Details.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel_Details.Controls.Add(Me.Pic_Room)
        Me.Panel_Details.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Details.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Details.Location = New System.Drawing.Point(0, 66)
        Me.Panel_Details.Name = "Panel_Details"
        Me.Panel_Details.Size = New System.Drawing.Size(620, 287)
        Me.Panel_Details.TabIndex = 85
        Me.Panel_Details.UseTransparentBackground = True
        '
        'Lbl_RoomStatus
        '
        Me.Lbl_RoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_RoomStatus.AutoSize = False
        Me.Lbl_RoomStatus.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_RoomStatus.Location = New System.Drawing.Point(428, 18)
        Me.Lbl_RoomStatus.Name = "Lbl_RoomStatus"
        Me.Lbl_RoomStatus.Size = New System.Drawing.Size(170, 34)
        Me.Lbl_RoomStatus.TabIndex = 69
        Me.Lbl_RoomStatus.Text = "..... ..... ....."
        Me.Lbl_RoomStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(287, 18)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(135, 34)
        Me.Guna2HtmlLabel6.TabIndex = 69
        Me.Guna2HtmlLabel6.Text = "Room Status"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_StayDuration
        '
        Me.Lbl_StayDuration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_StayDuration.AutoSize = False
        Me.Lbl_StayDuration.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_StayDuration.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_StayDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_StayDuration.Location = New System.Drawing.Point(428, 225)
        Me.Lbl_StayDuration.Name = "Lbl_StayDuration"
        Me.Lbl_StayDuration.Size = New System.Drawing.Size(170, 34)
        Me.Lbl_StayDuration.TabIndex = 68
        Me.Lbl_StayDuration.Text = "..... ..... ....."
        Me.Lbl_StayDuration.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_GuestName
        '
        Me.Lbl_GuestName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_GuestName.AutoSize = False
        Me.Lbl_GuestName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GuestName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GuestName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_GuestName.Location = New System.Drawing.Point(428, 185)
        Me.Lbl_GuestName.Name = "Lbl_GuestName"
        Me.Lbl_GuestName.Size = New System.Drawing.Size(170, 34)
        Me.Lbl_GuestName.TabIndex = 67
        Me.Lbl_GuestName.Text = "..... ..... ....."
        Me.Lbl_GuestName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(287, 225)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(135, 34)
        Me.Guna2HtmlLabel5.TabIndex = 68
        Me.Guna2HtmlLabel5.Text = "Stay Duration"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_RoomPrice
        '
        Me.Lbl_RoomPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_RoomPrice.AutoSize = False
        Me.Lbl_RoomPrice.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomPrice.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_RoomPrice.Location = New System.Drawing.Point(428, 145)
        Me.Lbl_RoomPrice.Name = "Lbl_RoomPrice"
        Me.Lbl_RoomPrice.Size = New System.Drawing.Size(170, 34)
        Me.Lbl_RoomPrice.TabIndex = 66
        Me.Lbl_RoomPrice.Text = "..... ..... ....."
        Me.Lbl_RoomPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(287, 185)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(135, 34)
        Me.Guna2HtmlLabel4.TabIndex = 67
        Me.Guna2HtmlLabel4.Text = "Guest Name"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_RoomType
        '
        Me.Lbl_RoomType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_RoomType.AutoSize = False
        Me.Lbl_RoomType.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomType.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_RoomType.Location = New System.Drawing.Point(428, 105)
        Me.Lbl_RoomType.Name = "Lbl_RoomType"
        Me.Lbl_RoomType.Size = New System.Drawing.Size(170, 34)
        Me.Lbl_RoomType.TabIndex = 65
        Me.Lbl_RoomType.Text = "..... ..... ....."
        Me.Lbl_RoomType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(287, 145)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(135, 34)
        Me.Guna2HtmlLabel3.TabIndex = 66
        Me.Guna2HtmlLabel3.Text = "Room Price"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_RoomNumber
        '
        Me.Lbl_RoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_RoomNumber.AutoSize = False
        Me.Lbl_RoomNumber.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomNumber.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_RoomNumber.Location = New System.Drawing.Point(428, 65)
        Me.Lbl_RoomNumber.Name = "Lbl_RoomNumber"
        Me.Lbl_RoomNumber.Size = New System.Drawing.Size(170, 34)
        Me.Lbl_RoomNumber.TabIndex = 64
        Me.Lbl_RoomNumber.Text = "..... ..... ....."
        Me.Lbl_RoomNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(287, 105)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(135, 34)
        Me.Guna2HtmlLabel1.TabIndex = 65
        Me.Guna2HtmlLabel1.Text = "Room Type"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(287, 65)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(135, 34)
        Me.Guna2HtmlLabel2.TabIndex = 64
        Me.Guna2HtmlLabel2.Text = "Room Number"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_Room
        '
        Me.Pic_Room.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pic_Room.FillColor = System.Drawing.Color.Silver
        Me.Pic_Room.ImageRotate = 0!
        Me.Pic_Room.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Room.Name = "Pic_Room"
        Me.Pic_Room.Size = New System.Drawing.Size(281, 287)
        Me.Pic_Room.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Room.TabIndex = 0
        Me.Pic_Room.TabStop = False
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
        'SelectedRoom
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Details)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_TopMenu)
        Me.Controls.Add(Me.Panel_Operations)
        Me.Name = "SelectedRoom"
        Me.Size = New System.Drawing.Size(620, 398)
        Me.Panel_Operations.ResumeLayout(False)
        Me.FLP_Buttons.ResumeLayout(False)
        Me.Panel_TopMenu.ResumeLayout(False)
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Details.ResumeLayout(False)
        CType(Me.Pic_Room, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Operations As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_BookRoom As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Btn_GoBack As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel_TopMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_Details As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Pic_Room As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_StayDuration As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_GuestName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents FLP_Buttons As FlowLayoutPanel
End Class
