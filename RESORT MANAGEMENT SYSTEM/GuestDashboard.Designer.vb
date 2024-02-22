<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestDashboard
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
        Me.Btn_Receipt = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_Bottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_GuestBoard = New System.Windows.Forms.FlowLayoutPanel()
        Me.Grp_GuestData = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Lbl_GuestEnqueries = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_HotelInfo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_HotelName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Pic = New Guna.UI2.WinForms.Guna2Panel()
        Me.Pic_HotelIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Lbl_HotelSlogan = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_TravelCompany = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_DepartureDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_StayDuration = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_ArrivalDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_GuestType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_GuestContact = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_GuestEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_GuestName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Grp_Miscallaneous = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Tab_Miscallaneous = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Page_RoomInfo = New System.Windows.Forms.TabPage()
        Me.Lbl_RoomType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnPic_RoomType = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Lbl_DueAmount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_RoomNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Page_RestaurantInfo = New System.Windows.Forms.TabPage()
        Me.Grp_Operations = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Bottom.SuspendLayout()
        Me.FLP_GuestBoard.SuspendLayout()
        Me.Grp_GuestData.SuspendLayout()
        Me.Panel_HotelInfo.SuspendLayout()
        Me.Panel_Pic.SuspendLayout()
        CType(Me.Pic_HotelIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_Miscallaneous.SuspendLayout()
        Me.Tab_Miscallaneous.SuspendLayout()
        Me.Page_RoomInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Receipt
        '
        Me.Btn_Receipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Receipt.Animated = True
        Me.Btn_Receipt.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Receipt.BorderColor = System.Drawing.Color.White
        Me.Btn_Receipt.BorderRadius = 5
        Me.Btn_Receipt.BorderThickness = 1
        Me.Btn_Receipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Receipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Receipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Receipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Receipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Receipt.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Receipt.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_Receipt.ForeColor = System.Drawing.Color.White
        Me.Btn_Receipt.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Btn_Receipt.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Receipt.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Receipt.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Receipt.Location = New System.Drawing.Point(1302, 6)
        Me.Btn_Receipt.Name = "Btn_Receipt"
        Me.Btn_Receipt.PressedColor = System.Drawing.Color.White
        Me.Btn_Receipt.Size = New System.Drawing.Size(212, 30)
        Me.Btn_Receipt.TabIndex = 77
        Me.Btn_Receipt.Text = "GENERATE RECEIPT"
        '
        'Panel_Bottom
        '
        Me.Panel_Bottom.Controls.Add(Me.Btn_Receipt)
        Me.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Bottom.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Bottom.Location = New System.Drawing.Point(0, 687)
        Me.Panel_Bottom.Name = "Panel_Bottom"
        Me.Panel_Bottom.Size = New System.Drawing.Size(1520, 40)
        Me.Panel_Bottom.TabIndex = 79
        '
        'FLP_GuestBoard
        '
        Me.FLP_GuestBoard.AutoScroll = True
        Me.FLP_GuestBoard.Controls.Add(Me.Grp_GuestData)
        Me.FLP_GuestBoard.Controls.Add(Me.Grp_Miscallaneous)
        Me.FLP_GuestBoard.Controls.Add(Me.Grp_Operations)
        Me.FLP_GuestBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_GuestBoard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_GuestBoard.Location = New System.Drawing.Point(0, 0)
        Me.FLP_GuestBoard.Name = "FLP_GuestBoard"
        Me.FLP_GuestBoard.Size = New System.Drawing.Size(1520, 687)
        Me.FLP_GuestBoard.TabIndex = 80
        '
        'Grp_GuestData
        '
        Me.Grp_GuestData.BackColor = System.Drawing.Color.Transparent
        Me.Grp_GuestData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Grp_GuestData.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_GuestData.BorderRadius = 5
        Me.Grp_GuestData.Controls.Add(Me.Lbl_GuestEnqueries)
        Me.Grp_GuestData.Controls.Add(Me.Panel_HotelInfo)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_TravelCompany)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_DepartureDate)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_StayDuration)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_ArrivalDate)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_GuestType)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_GuestContact)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_GuestEmail)
        Me.Grp_GuestData.Controls.Add(Me.Lbl_GuestName)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Grp_GuestData.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Grp_GuestData.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_GuestData.FillColor = System.Drawing.Color.Transparent
        Me.Grp_GuestData.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_GuestData.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_GuestData.Location = New System.Drawing.Point(3, 3)
        Me.Grp_GuestData.Name = "Grp_GuestData"
        Me.Grp_GuestData.Size = New System.Drawing.Size(580, 656)
        Me.Grp_GuestData.TabIndex = 54
        Me.Grp_GuestData.Text = "Guest Information"
        Me.Grp_GuestData.UseTransparentBackground = True
        '
        'Lbl_GuestEnqueries
        '
        Me.Lbl_GuestEnqueries.AutoSize = False
        Me.Lbl_GuestEnqueries.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GuestEnqueries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_GuestEnqueries.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GuestEnqueries.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_GuestEnqueries.Location = New System.Drawing.Point(241, 568)
        Me.Lbl_GuestEnqueries.Name = "Lbl_GuestEnqueries"
        Me.Lbl_GuestEnqueries.Size = New System.Drawing.Size(310, 78)
        Me.Lbl_GuestEnqueries.TabIndex = 88
        Me.Lbl_GuestEnqueries.Text = "..... ..... ..... ..... "
        '
        'Panel_HotelInfo
        '
        Me.Panel_HotelInfo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_HotelInfo.BorderThickness = 1
        Me.Panel_HotelInfo.Controls.Add(Me.Lbl_HotelName)
        Me.Panel_HotelInfo.Controls.Add(Me.Panel_Pic)
        Me.Panel_HotelInfo.Controls.Add(Me.Lbl_HotelSlogan)
        Me.Panel_HotelInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_HotelInfo.Location = New System.Drawing.Point(0, 40)
        Me.Panel_HotelInfo.Name = "Panel_HotelInfo"
        Me.Panel_HotelInfo.Size = New System.Drawing.Size(580, 70)
        Me.Panel_HotelInfo.TabIndex = 69
        '
        'Lbl_HotelName
        '
        Me.Lbl_HotelName.AutoSize = False
        Me.Lbl_HotelName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_HotelName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_HotelName.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_HotelName.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_HotelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_HotelName.Location = New System.Drawing.Point(80, 0)
        Me.Lbl_HotelName.Name = "Lbl_HotelName"
        Me.Lbl_HotelName.Size = New System.Drawing.Size(500, 35)
        Me.Lbl_HotelName.TabIndex = 90
        Me.Lbl_HotelName.Text = "Hotel Name"
        Me.Lbl_HotelName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Pic
        '
        Me.Panel_Pic.Controls.Add(Me.Pic_HotelIcon)
        Me.Panel_Pic.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Pic.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Pic.Name = "Panel_Pic"
        Me.Panel_Pic.Size = New System.Drawing.Size(80, 70)
        Me.Panel_Pic.TabIndex = 89
        '
        'Pic_HotelIcon
        '
        Me.Pic_HotelIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pic_HotelIcon.FillColor = System.Drawing.Color.Transparent
        Me.Pic_HotelIcon.ImageRotate = 0!
        Me.Pic_HotelIcon.Location = New System.Drawing.Point(0, 0)
        Me.Pic_HotelIcon.Name = "Pic_HotelIcon"
        Me.Pic_HotelIcon.Size = New System.Drawing.Size(80, 70)
        Me.Pic_HotelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_HotelIcon.TabIndex = 87
        Me.Pic_HotelIcon.TabStop = False
        Me.Pic_HotelIcon.UseTransparentBackground = True
        '
        'Lbl_HotelSlogan
        '
        Me.Lbl_HotelSlogan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_HotelSlogan.AutoSize = False
        Me.Lbl_HotelSlogan.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_HotelSlogan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_HotelSlogan.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_HotelSlogan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_HotelSlogan.Location = New System.Drawing.Point(80, 32)
        Me.Lbl_HotelSlogan.Name = "Lbl_HotelSlogan"
        Me.Lbl_HotelSlogan.Size = New System.Drawing.Size(497, 35)
        Me.Lbl_HotelSlogan.TabIndex = 70
        Me.Lbl_HotelSlogan.Text = "Hotel Slogan"
        Me.Lbl_HotelSlogan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_TravelCompany
        '
        Me.Lbl_TravelCompany.AutoSize = False
        Me.Lbl_TravelCompany.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TravelCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_TravelCompany.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TravelCompany.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_TravelCompany.Location = New System.Drawing.Point(241, 512)
        Me.Lbl_TravelCompany.Name = "Lbl_TravelCompany"
        Me.Lbl_TravelCompany.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_TravelCompany.TabIndex = 87
        Me.Lbl_TravelCompany.Text = "..... ..... ..... ..... "
        Me.Lbl_TravelCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_DepartureDate
        '
        Me.Lbl_DepartureDate.AutoSize = False
        Me.Lbl_DepartureDate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DepartureDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_DepartureDate.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DepartureDate.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_DepartureDate.Location = New System.Drawing.Point(241, 457)
        Me.Lbl_DepartureDate.Name = "Lbl_DepartureDate"
        Me.Lbl_DepartureDate.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_DepartureDate.TabIndex = 86
        Me.Lbl_DepartureDate.Text = "..... ..... ..... ..... "
        Me.Lbl_DepartureDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_StayDuration
        '
        Me.Lbl_StayDuration.AutoSize = False
        Me.Lbl_StayDuration.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_StayDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_StayDuration.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_StayDuration.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_StayDuration.Location = New System.Drawing.Point(241, 403)
        Me.Lbl_StayDuration.Name = "Lbl_StayDuration"
        Me.Lbl_StayDuration.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_StayDuration.TabIndex = 85
        Me.Lbl_StayDuration.Text = "..... ..... ..... ..... "
        Me.Lbl_StayDuration.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_ArrivalDate
        '
        Me.Lbl_ArrivalDate.AutoSize = False
        Me.Lbl_ArrivalDate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ArrivalDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_ArrivalDate.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ArrivalDate.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_ArrivalDate.Location = New System.Drawing.Point(241, 345)
        Me.Lbl_ArrivalDate.Name = "Lbl_ArrivalDate"
        Me.Lbl_ArrivalDate.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_ArrivalDate.TabIndex = 84
        Me.Lbl_ArrivalDate.Text = "..... ..... ..... ..... "
        Me.Lbl_ArrivalDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_GuestType
        '
        Me.Lbl_GuestType.AutoSize = False
        Me.Lbl_GuestType.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GuestType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_GuestType.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GuestType.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_GuestType.Location = New System.Drawing.Point(241, 293)
        Me.Lbl_GuestType.Name = "Lbl_GuestType"
        Me.Lbl_GuestType.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_GuestType.TabIndex = 83
        Me.Lbl_GuestType.Text = "..... ..... ..... ..... "
        Me.Lbl_GuestType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_GuestContact
        '
        Me.Lbl_GuestContact.AutoSize = False
        Me.Lbl_GuestContact.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GuestContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_GuestContact.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GuestContact.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_GuestContact.Location = New System.Drawing.Point(241, 237)
        Me.Lbl_GuestContact.Name = "Lbl_GuestContact"
        Me.Lbl_GuestContact.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_GuestContact.TabIndex = 82
        Me.Lbl_GuestContact.Text = "..... ..... ..... ..... "
        Me.Lbl_GuestContact.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_GuestEmail
        '
        Me.Lbl_GuestEmail.AutoSize = False
        Me.Lbl_GuestEmail.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GuestEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_GuestEmail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GuestEmail.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_GuestEmail.Location = New System.Drawing.Point(241, 185)
        Me.Lbl_GuestEmail.Name = "Lbl_GuestEmail"
        Me.Lbl_GuestEmail.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_GuestEmail.TabIndex = 81
        Me.Lbl_GuestEmail.Text = "..... ..... ..... ..... "
        Me.Lbl_GuestEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_GuestName
        '
        Me.Lbl_GuestName.AutoSize = False
        Me.Lbl_GuestName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GuestName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_GuestName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GuestName.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_GuestName.Location = New System.Drawing.Point(241, 128)
        Me.Lbl_GuestName.Name = "Lbl_GuestName"
        Me.Lbl_GuestName.Size = New System.Drawing.Size(310, 35)
        Me.Lbl_GuestName.TabIndex = 80
        Me.Lbl_GuestName.Text = "..... ..... ..... ..... "
        Me.Lbl_GuestName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.AutoSize = False
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(42, 568)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel9.TabIndex = 79
        Me.Guna2HtmlLabel9.Text = "Guest Enquires"
        Me.Guna2HtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(42, 512)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel8.TabIndex = 78
        Me.Guna2HtmlLabel8.Text = "Travel Company"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.AutoSize = False
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(42, 457)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel7.TabIndex = 77
        Me.Guna2HtmlLabel7.Text = "Departure Date"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(42, 403)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel6.TabIndex = 76
        Me.Guna2HtmlLabel6.Text = "Stay Duration"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(42, 293)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel5.TabIndex = 75
        Me.Guna2HtmlLabel5.Text = "Guest Type"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(42, 345)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel4.TabIndex = 74
        Me.Guna2HtmlLabel4.Text = "Arrival Date"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(42, 237)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel3.TabIndex = 73
        Me.Guna2HtmlLabel3.Text = "Guest Contact"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(42, 185)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel2.TabIndex = 72
        Me.Guna2HtmlLabel2.Text = "Guest Email"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(42, 128)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel1.TabIndex = 71
        Me.Guna2HtmlLabel1.Text = "Guest Name"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Grp_Miscallaneous
        '
        Me.Grp_Miscallaneous.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Miscallaneous.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_Miscallaneous.BorderRadius = 5
        Me.Grp_Miscallaneous.Controls.Add(Me.Tab_Miscallaneous)
        Me.Grp_Miscallaneous.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_Miscallaneous.FillColor = System.Drawing.Color.Transparent
        Me.Grp_Miscallaneous.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Miscallaneous.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_Miscallaneous.Location = New System.Drawing.Point(589, 3)
        Me.Grp_Miscallaneous.Name = "Grp_Miscallaneous"
        Me.Grp_Miscallaneous.Size = New System.Drawing.Size(800, 330)
        Me.Grp_Miscallaneous.TabIndex = 56
        Me.Grp_Miscallaneous.Text = "Miscallaneous"
        '
        'Tab_Miscallaneous
        '
        Me.Tab_Miscallaneous.Controls.Add(Me.Page_RoomInfo)
        Me.Tab_Miscallaneous.Controls.Add(Me.Page_RestaurantInfo)
        Me.Tab_Miscallaneous.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tab_Miscallaneous.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Miscallaneous.ItemSize = New System.Drawing.Size(150, 35)
        Me.Tab_Miscallaneous.Location = New System.Drawing.Point(0, 40)
        Me.Tab_Miscallaneous.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab_Miscallaneous.Name = "Tab_Miscallaneous"
        Me.Tab_Miscallaneous.SelectedIndex = 0
        Me.Tab_Miscallaneous.ShowToolTips = True
        Me.Tab_Miscallaneous.Size = New System.Drawing.Size(800, 290)
        Me.Tab_Miscallaneous.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Miscallaneous.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Miscallaneous.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Miscallaneous.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Tab_Miscallaneous.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Miscallaneous.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Miscallaneous.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Miscallaneous.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Miscallaneous.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Tab_Miscallaneous.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Miscallaneous.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Miscallaneous.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Miscallaneous.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Tab_Miscallaneous.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Miscallaneous.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Tab_Miscallaneous.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tab_Miscallaneous.TabButtonSize = New System.Drawing.Size(150, 35)
        Me.Tab_Miscallaneous.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Miscallaneous.TabIndex = 14
        Me.Tab_Miscallaneous.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Miscallaneous.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'Page_RoomInfo
        '
        Me.Page_RoomInfo.BackColor = System.Drawing.Color.LightGray
        Me.Page_RoomInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_RoomInfo.Controls.Add(Me.Lbl_RoomType)
        Me.Page_RoomInfo.Controls.Add(Me.BtnPic_RoomType)
        Me.Page_RoomInfo.Controls.Add(Me.Lbl_DueAmount)
        Me.Page_RoomInfo.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Page_RoomInfo.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Page_RoomInfo.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Page_RoomInfo.Controls.Add(Me.Lbl_RoomNumber)
        Me.Page_RoomInfo.Location = New System.Drawing.Point(4, 39)
        Me.Page_RoomInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_RoomInfo.Name = "Page_RoomInfo"
        Me.Page_RoomInfo.Size = New System.Drawing.Size(792, 247)
        Me.Page_RoomInfo.TabIndex = 0
        Me.Page_RoomInfo.Text = "Room Information"
        '
        'Lbl_RoomType
        '
        Me.Lbl_RoomType.AutoSize = False
        Me.Lbl_RoomType.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_RoomType.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomType.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_RoomType.Location = New System.Drawing.Point(511, 28)
        Me.Lbl_RoomType.Name = "Lbl_RoomType"
        Me.Lbl_RoomType.Size = New System.Drawing.Size(219, 35)
        Me.Lbl_RoomType.TabIndex = 85
        Me.Lbl_RoomType.Text = "..... ..... ..... ..... "
        Me.Lbl_RoomType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPic_RoomType
        '
        Me.BtnPic_RoomType.BackColor = System.Drawing.Color.Transparent
        Me.BtnPic_RoomType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPic_RoomType.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnPic_RoomType.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPic_RoomType.HoverState.ImageSize = New System.Drawing.Size(299, 247)
        Me.BtnPic_RoomType.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Wallpaper_2
        Me.BtnPic_RoomType.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnPic_RoomType.ImageRotate = 0!
        Me.BtnPic_RoomType.ImageSize = New System.Drawing.Size(299, 247)
        Me.BtnPic_RoomType.Location = New System.Drawing.Point(0, 0)
        Me.BtnPic_RoomType.Name = "BtnPic_RoomType"
        Me.BtnPic_RoomType.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnPic_RoomType.ShadowDecoration.Color = System.Drawing.Color.LightGray
        Me.BtnPic_RoomType.ShadowDecoration.Enabled = True
        Me.BtnPic_RoomType.Size = New System.Drawing.Size(299, 247)
        Me.BtnPic_RoomType.TabIndex = 73
        Me.BtnPic_RoomType.UseTransparentBackground = True
        '
        'Lbl_DueAmount
        '
        Me.Lbl_DueAmount.AutoSize = False
        Me.Lbl_DueAmount.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DueAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_DueAmount.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DueAmount.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_DueAmount.Location = New System.Drawing.Point(511, 158)
        Me.Lbl_DueAmount.Name = "Lbl_DueAmount"
        Me.Lbl_DueAmount.Size = New System.Drawing.Size(219, 35)
        Me.Lbl_DueAmount.TabIndex = 84
        Me.Lbl_DueAmount.Text = "..... ..... ..... ..... "
        Me.Lbl_DueAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.AutoSize = False
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(368, 28)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(137, 35)
        Me.Guna2HtmlLabel10.TabIndex = 80
        Me.Guna2HtmlLabel10.Text = "Room Type"
        Me.Guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.AutoSize = False
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(368, 90)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(137, 35)
        Me.Guna2HtmlLabel11.TabIndex = 81
        Me.Guna2HtmlLabel11.Text = "Room Number"
        Me.Guna2HtmlLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.AutoSize = False
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(368, 158)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(137, 35)
        Me.Guna2HtmlLabel12.TabIndex = 82
        Me.Guna2HtmlLabel12.Text = "Due Amount"
        Me.Guna2HtmlLabel12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_RoomNumber
        '
        Me.Lbl_RoomNumber.AutoSize = False
        Me.Lbl_RoomNumber.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_RoomNumber.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomNumber.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_RoomNumber.Location = New System.Drawing.Point(511, 90)
        Me.Lbl_RoomNumber.Name = "Lbl_RoomNumber"
        Me.Lbl_RoomNumber.Size = New System.Drawing.Size(219, 35)
        Me.Lbl_RoomNumber.TabIndex = 83
        Me.Lbl_RoomNumber.Text = "..... ..... ..... ..... "
        Me.Lbl_RoomNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Page_RestaurantInfo
        '
        Me.Page_RestaurantInfo.BackColor = System.Drawing.Color.LightGray
        Me.Page_RestaurantInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_RestaurantInfo.Location = New System.Drawing.Point(4, 39)
        Me.Page_RestaurantInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_RestaurantInfo.Name = "Page_RestaurantInfo"
        Me.Page_RestaurantInfo.Size = New System.Drawing.Size(792, 247)
        Me.Page_RestaurantInfo.TabIndex = 1
        Me.Page_RestaurantInfo.Text = "Restaurant Information"
        '
        'Grp_Operations
        '
        Me.Grp_Operations.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Operations.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_Operations.BorderRadius = 5
        Me.Grp_Operations.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Grp_Operations.FillColor = System.Drawing.Color.Transparent
        Me.Grp_Operations.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Operations.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grp_Operations.Location = New System.Drawing.Point(589, 339)
        Me.Grp_Operations.Name = "Grp_Operations"
        Me.Grp_Operations.Size = New System.Drawing.Size(800, 320)
        Me.Grp_Operations.TabIndex = 57
        Me.Grp_Operations.Text = "Other Operations"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'GuestDashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.FLP_GuestBoard)
        Me.Controls.Add(Me.Panel_Bottom)
        Me.Name = "GuestDashboard"
        Me.Size = New System.Drawing.Size(1520, 727)
        Me.Panel_Bottom.ResumeLayout(False)
        Me.FLP_GuestBoard.ResumeLayout(False)
        Me.Grp_GuestData.ResumeLayout(False)
        Me.Panel_HotelInfo.ResumeLayout(False)
        Me.Panel_Pic.ResumeLayout(False)
        CType(Me.Pic_HotelIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_Miscallaneous.ResumeLayout(False)
        Me.Tab_Miscallaneous.ResumeLayout(False)
        Me.Page_RoomInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Receipt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Bottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FLP_GuestBoard As FlowLayoutPanel
    Friend WithEvents Grp_GuestData As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel_HotelInfo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_HotelSlogan As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_DepartureDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_StayDuration As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_ArrivalDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_GuestType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_GuestContact As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_GuestEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_GuestName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_TravelCompany As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_GuestEnqueries As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel_Pic As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_HotelName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Pic_HotelIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Grp_Miscallaneous As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Tab_Miscallaneous As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Page_RoomInfo As TabPage
    Friend WithEvents Lbl_RoomType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnPic_RoomType As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Lbl_DueAmount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Page_RestaurantInfo As TabPage
    Friend WithEvents Grp_Operations As Guna.UI2.WinForms.Guna2GroupBox
End Class
