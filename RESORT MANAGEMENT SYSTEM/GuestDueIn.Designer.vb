<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestDueIn
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Enquiry = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Cmb_RoomType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel_Slide = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_LeftBlind = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_RightBlind = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txt_Contact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txt_CustomerEnquiry = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Dat_DateOfArrival = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Txt_Duration = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txt_NumberOfPeople = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txt_Email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Btn_Cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Txt_Name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.Cmb_EnquiryType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_Display = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_AllRooms = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Lbl_FLPTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_TotalDueIns = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_TotalGuests = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_TotalGuests1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Enquiry.SuspendLayout()
        Me.Panel_Slide.SuspendLayout()
        Me.Panel_Holder.SuspendLayout()
        Me.FLP_Display.SuspendLayout()
        Me.Panel_TotalDueIns.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'Panel_Enquiry
        '
        Me.Panel_Enquiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Enquiry.AutoScroll = True
        Me.Panel_Enquiry.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Enquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Enquiry.BorderColor = System.Drawing.Color.BlueViolet
        Me.Panel_Enquiry.BorderRadius = 5
        Me.Panel_Enquiry.BorderThickness = 1
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel_Enquiry.Controls.Add(Me.Cmb_RoomType)
        Me.Panel_Enquiry.Controls.Add(Me.Panel_Slide)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Panel_Enquiry.Controls.Add(Me.Txt_Contact)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel_Enquiry.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel_Enquiry.Controls.Add(Me.Txt_CustomerEnquiry)
        Me.Panel_Enquiry.Controls.Add(Me.Dat_DateOfArrival)
        Me.Panel_Enquiry.Controls.Add(Me.Txt_Duration)
        Me.Panel_Enquiry.Controls.Add(Me.Txt_NumberOfPeople)
        Me.Panel_Enquiry.Controls.Add(Me.Txt_Email)
        Me.Panel_Enquiry.Controls.Add(Me.Btn_Cancel)
        Me.Panel_Enquiry.Controls.Add(Me.Txt_Name)
        Me.Panel_Enquiry.Controls.Add(Me.Btn_Save)
        Me.Panel_Enquiry.Controls.Add(Me.Cmb_EnquiryType)
        Me.Panel_Enquiry.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Enquiry.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.Panel_Enquiry.Location = New System.Drawing.Point(673, 80)
        Me.Panel_Enquiry.Name = "Panel_Enquiry"
        Me.Panel_Enquiry.Size = New System.Drawing.Size(540, 688)
        Me.Panel_Enquiry.TabIndex = 21
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(66, 450)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel1.TabIndex = 74
        Me.Guna2HtmlLabel1.Text = "Room Type"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_RoomType
        '
        Me.Cmb_RoomType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmb_RoomType.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_RoomType.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_RoomType.BorderRadius = 5
        Me.Cmb_RoomType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_RoomType.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_RoomType.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_RoomType.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_RoomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_RoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_RoomType.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_RoomType.FocusedColor = System.Drawing.Color.BlueViolet
        Me.Cmb_RoomType.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_RoomType.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_RoomType.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_RoomType.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_RoomType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_RoomType.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_RoomType.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_RoomType.ItemHeight = 30
        Me.Cmb_RoomType.Items.AddRange(New Object() {"Select Room Type", "Single Room", "Double Room", "Triple Room", "Twin Room", "Juniour Suite", "Executive Suite", "Presidential Suite"})
        Me.Cmb_RoomType.Location = New System.Drawing.Point(66, 480)
        Me.Cmb_RoomType.Name = "Cmb_RoomType"
        Me.Cmb_RoomType.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_RoomType.Size = New System.Drawing.Size(410, 36)
        Me.Cmb_RoomType.TabIndex = 73
        '
        'Panel_Slide
        '
        Me.Panel_Slide.Controls.Add(Me.Lbl_LeftBlind)
        Me.Panel_Slide.Controls.Add(Me.Lbl_RightBlind)
        Me.Panel_Slide.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Slide.Location = New System.Drawing.Point(29, 19)
        Me.Panel_Slide.Name = "Panel_Slide"
        Me.Panel_Slide.Size = New System.Drawing.Size(480, 36)
        Me.Panel_Slide.TabIndex = 72
        '
        'Lbl_LeftBlind
        '
        Me.Lbl_LeftBlind.AutoSize = False
        Me.Lbl_LeftBlind.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_LeftBlind.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_LeftBlind.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LeftBlind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Lbl_LeftBlind.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_LeftBlind.Name = "Lbl_LeftBlind"
        Me.Lbl_LeftBlind.Size = New System.Drawing.Size(130, 36)
        Me.Lbl_LeftBlind.TabIndex = 67
        Me.Lbl_LeftBlind.Text = Nothing
        Me.Lbl_LeftBlind.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_RightBlind
        '
        Me.Lbl_RightBlind.AutoSize = False
        Me.Lbl_RightBlind.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RightBlind.Dock = System.Windows.Forms.DockStyle.Right
        Me.Lbl_RightBlind.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RightBlind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Lbl_RightBlind.Location = New System.Drawing.Point(340, 0)
        Me.Lbl_RightBlind.Name = "Lbl_RightBlind"
        Me.Lbl_RightBlind.Size = New System.Drawing.Size(140, 36)
        Me.Lbl_RightBlind.TabIndex = 66
        Me.Lbl_RightBlind.Text = Nothing
        Me.Lbl_RightBlind.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.BlueViolet
        Me.Lbl_Inform.Location = New System.Drawing.Point(188, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(292, 36)
        Me.Lbl_Inform.TabIndex = 57
        Me.Lbl_Inform.Text = "Due In Guest  Submission..."
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel9.AutoSize = False
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(66, 230)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(202, 24)
        Me.Guna2HtmlLabel9.TabIndex = 71
        Me.Guna2HtmlLabel9.Text = "Guest's Contact Details"
        Me.Guna2HtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Contact
        '
        Me.Txt_Contact.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Contact.Animated = True
        Me.Txt_Contact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Contact.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Contact.BorderRadius = 5
        Me.Txt_Contact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Contact.DefaultText = ""
        Me.Txt_Contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Contact.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Contact.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Contact.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Contact.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Contact.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_Contact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Contact.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Txt_Contact.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Contact.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Contact.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Contact.Location = New System.Drawing.Point(66, 261)
        Me.Txt_Contact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Contact.MaxLength = 10
        Me.Txt_Contact.Name = "Txt_Contact"
        Me.Txt_Contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Contact.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_Contact.PlaceholderText = "*Required"
        Me.Txt_Contact.SelectedText = ""
        Me.Txt_Contact.Size = New System.Drawing.Size(412, 36)
        Me.Txt_Contact.TabIndex = 70
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(276, 304)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel8.TabIndex = 69
        Me.Guna2HtmlLabel8.Text = "Expected Date Of Arrival"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel7.AutoSize = False
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(68, 524)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel7.TabIndex = 68
        Me.Guna2HtmlLabel7.Text = "Customer Enquiry"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(276, 376)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel6.TabIndex = 67
        Me.Guna2HtmlLabel6.Text = "Number Of Days"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(66, 376)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel5.TabIndex = 66
        Me.Guna2HtmlLabel5.Text = "Number Of People"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(66, 304)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel4.TabIndex = 65
        Me.Guna2HtmlLabel4.Text = "Guest Type"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(66, 156)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(202, 24)
        Me.Guna2HtmlLabel3.TabIndex = 64
        Me.Guna2HtmlLabel3.Text = "Guest's Email"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(66, 80)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(202, 24)
        Me.Guna2HtmlLabel2.TabIndex = 63
        Me.Guna2HtmlLabel2.Text = "Guest Name"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_CustomerEnquiry
        '
        Me.Txt_CustomerEnquiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_CustomerEnquiry.Animated = True
        Me.Txt_CustomerEnquiry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_CustomerEnquiry.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_CustomerEnquiry.BorderRadius = 5
        Me.Txt_CustomerEnquiry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_CustomerEnquiry.DefaultText = ""
        Me.Txt_CustomerEnquiry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_CustomerEnquiry.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_CustomerEnquiry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_CustomerEnquiry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_CustomerEnquiry.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_CustomerEnquiry.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_CustomerEnquiry.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_CustomerEnquiry.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_CustomerEnquiry.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_CustomerEnquiry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_CustomerEnquiry.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_CustomerEnquiry.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_CustomerEnquiry.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_CustomerEnquiry.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_CustomerEnquiry.Location = New System.Drawing.Point(68, 555)
        Me.Txt_CustomerEnquiry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_CustomerEnquiry.MaxLength = 500
        Me.Txt_CustomerEnquiry.Name = "Txt_CustomerEnquiry"
        Me.Txt_CustomerEnquiry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_CustomerEnquiry.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_CustomerEnquiry.PlaceholderText = "Your Queries"
        Me.Txt_CustomerEnquiry.SelectedText = ""
        Me.Txt_CustomerEnquiry.Size = New System.Drawing.Size(412, 69)
        Me.Txt_CustomerEnquiry.TabIndex = 62
        '
        'Dat_DateOfArrival
        '
        Me.Dat_DateOfArrival.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dat_DateOfArrival.BorderColor = System.Drawing.Color.BlueViolet
        Me.Dat_DateOfArrival.BorderRadius = 5
        Me.Dat_DateOfArrival.BorderThickness = 1
        Me.Dat_DateOfArrival.Checked = True
        Me.Dat_DateOfArrival.FillColor = System.Drawing.Color.White
        Me.Dat_DateOfArrival.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_DateOfArrival.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dat_DateOfArrival.Location = New System.Drawing.Point(276, 334)
        Me.Dat_DateOfArrival.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Dat_DateOfArrival.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Dat_DateOfArrival.Name = "Dat_DateOfArrival"
        Me.Dat_DateOfArrival.Size = New System.Drawing.Size(202, 36)
        Me.Dat_DateOfArrival.TabIndex = 61
        Me.Dat_DateOfArrival.Value = New Date(2023, 12, 8, 22, 5, 35, 766)
        '
        'Txt_Duration
        '
        Me.Txt_Duration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Duration.Animated = True
        Me.Txt_Duration.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.Txt_Duration.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Duration.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Duration.BorderRadius = 5
        Me.Txt_Duration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Duration.DefaultText = ""
        Me.Txt_Duration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Duration.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Duration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Duration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Duration.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Duration.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Duration.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Duration.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Duration.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_Duration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Duration.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Txt_Duration.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Duration.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Duration.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Duration.Location = New System.Drawing.Point(276, 407)
        Me.Txt_Duration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Duration.MaxLength = 3
        Me.Txt_Duration.Name = "Txt_Duration"
        Me.Txt_Duration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Duration.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_Duration.PlaceholderText = "*Required"
        Me.Txt_Duration.SelectedText = ""
        Me.Txt_Duration.Size = New System.Drawing.Size(202, 36)
        Me.Txt_Duration.TabIndex = 60
        '
        'Txt_NumberOfPeople
        '
        Me.Txt_NumberOfPeople.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_NumberOfPeople.Animated = True
        Me.Txt_NumberOfPeople.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.Txt_NumberOfPeople.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_NumberOfPeople.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_NumberOfPeople.BorderRadius = 5
        Me.Txt_NumberOfPeople.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_NumberOfPeople.DefaultText = ""
        Me.Txt_NumberOfPeople.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_NumberOfPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_NumberOfPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_NumberOfPeople.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_NumberOfPeople.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_NumberOfPeople.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_NumberOfPeople.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_NumberOfPeople.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_NumberOfPeople.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_NumberOfPeople.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_NumberOfPeople.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Txt_NumberOfPeople.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_NumberOfPeople.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_NumberOfPeople.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_NumberOfPeople.Location = New System.Drawing.Point(66, 407)
        Me.Txt_NumberOfPeople.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_NumberOfPeople.MaxLength = 2
        Me.Txt_NumberOfPeople.Name = "Txt_NumberOfPeople"
        Me.Txt_NumberOfPeople.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_NumberOfPeople.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_NumberOfPeople.PlaceholderText = "*Required"
        Me.Txt_NumberOfPeople.SelectedText = ""
        Me.Txt_NumberOfPeople.Size = New System.Drawing.Size(200, 36)
        Me.Txt_NumberOfPeople.TabIndex = 59
        '
        'Txt_Email
        '
        Me.Txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Email.Animated = True
        Me.Txt_Email.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Email.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.BorderRadius = 5
        Me.Txt_Email.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Email.DefaultText = ""
        Me.Txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Email.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Email.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Email.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Email.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Email.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Txt_Email.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Email.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Email.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Email.Location = New System.Drawing.Point(66, 187)
        Me.Txt_Email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Email.MaxLength = 50
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Email.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_Email.PlaceholderText = "*Required (example@gmail.com)"
        Me.Txt_Email.SelectedText = ""
        Me.Txt_Email.Size = New System.Drawing.Size(412, 36)
        Me.Txt_Email.TabIndex = 58
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
        Me.Btn_Cancel.Location = New System.Drawing.Point(273, 640)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.PressedColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Cancel.TabIndex = 56
        Me.Btn_Cancel.Text = "CANCEL"
        '
        'Txt_Name
        '
        Me.Txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Name.Animated = True
        Me.Txt_Name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Name.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Name.BorderRadius = 5
        Me.Txt_Name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Name.DefaultText = ""
        Me.Txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Name.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Name.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Name.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Name.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Name.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Name.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Txt_Name.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Name.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Name.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Name.Location = New System.Drawing.Point(68, 111)
        Me.Txt_Name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Name.MaxLength = 50
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Name.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_Name.PlaceholderText = "*Required"
        Me.Txt_Name.SelectedText = ""
        Me.Txt_Name.Size = New System.Drawing.Size(410, 36)
        Me.Txt_Name.TabIndex = 54
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
        Me.Btn_Save.Location = New System.Drawing.Point(406, 640)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.PressedColor = System.Drawing.Color.White
        Me.Btn_Save.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Save.TabIndex = 55
        Me.Btn_Save.Text = "SUBMIT"
        '
        'Cmb_EnquiryType
        '
        Me.Cmb_EnquiryType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmb_EnquiryType.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_EnquiryType.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_EnquiryType.BorderRadius = 5
        Me.Cmb_EnquiryType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_EnquiryType.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_EnquiryType.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_EnquiryType.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_EnquiryType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_EnquiryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_EnquiryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_EnquiryType.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_EnquiryType.FocusedColor = System.Drawing.Color.BlueViolet
        Me.Cmb_EnquiryType.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_EnquiryType.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_EnquiryType.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_EnquiryType.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_EnquiryType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_EnquiryType.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_EnquiryType.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_EnquiryType.ItemHeight = 30
        Me.Cmb_EnquiryType.Items.AddRange(New Object() {"Select Guest Type", "Leisure Traveller", "Business Traveller", "Luxury Traveller", "Wellness Traveller", "Solo Traveller", "Group Traveller", ""})
        Me.Cmb_EnquiryType.Location = New System.Drawing.Point(66, 334)
        Me.Cmb_EnquiryType.Name = "Cmb_EnquiryType"
        Me.Cmb_EnquiryType.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_EnquiryType.Size = New System.Drawing.Size(202, 36)
        Me.Cmb_EnquiryType.TabIndex = 52
        '
        'Panel_Holder
        '
        Me.Panel_Holder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Holder.BorderColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.BorderRadius = 5
        Me.Panel_Holder.BorderThickness = 1
        Me.Panel_Holder.Controls.Add(Me.FLP_Display)
        Me.Panel_Holder.Controls.Add(Me.Lbl_FLPTitle)
        Me.Panel_Holder.FillColor = System.Drawing.Color.Silver
        Me.Panel_Holder.Location = New System.Drawing.Point(100, 80)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(554, 688)
        Me.Panel_Holder.TabIndex = 23
        '
        'FLP_Display
        '
        Me.FLP_Display.AutoScroll = True
        Me.FLP_Display.BackColor = System.Drawing.Color.Transparent
        Me.FLP_Display.Controls.Add(Me.Panel_TotalDueIns)
        Me.FLP_Display.Controls.Add(Me.Btn_AllRooms)
        Me.FLP_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Display.Location = New System.Drawing.Point(0, 34)
        Me.FLP_Display.Name = "FLP_Display"
        Me.FLP_Display.Size = New System.Drawing.Size(554, 654)
        Me.FLP_Display.TabIndex = 24
        '
        'Btn_AllRooms
        '
        Me.Btn_AllRooms.Animated = True
        Me.Btn_AllRooms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AllRooms.BorderRadius = 5
        Me.Btn_AllRooms.BorderThickness = 2
        Me.Btn_AllRooms.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.Btn_AllRooms.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AllRooms.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_AllRooms.HoverState.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllRooms.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_AllRooms.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.HotelIcon
        Me.Btn_AllRooms.ImageSize = New System.Drawing.Size(70, 60)
        Me.Btn_AllRooms.Location = New System.Drawing.Point(269, 3)
        Me.Btn_AllRooms.Name = "Btn_AllRooms"
        Me.Btn_AllRooms.PressedColor = System.Drawing.Color.White
        Me.Btn_AllRooms.Size = New System.Drawing.Size(260, 140)
        Me.Btn_AllRooms.TabIndex = 75
        Me.Btn_AllRooms.Text = "Due On : 1/1/1111 Due In Guest Name"
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
        Me.Lbl_FLPTitle.Size = New System.Drawing.Size(554, 34)
        Me.Lbl_FLPTitle.TabIndex = 17
        Me.Lbl_FLPTitle.Text = "Guests Expected"
        Me.Lbl_FLPTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_TotalDueIns
        '
        Me.Panel_TotalDueIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_TotalDueIns.BorderColor = System.Drawing.Color.White
        Me.Panel_TotalDueIns.BorderRadius = 5
        Me.Panel_TotalDueIns.BorderThickness = 2
        Me.Panel_TotalDueIns.Controls.Add(Me.Lbl_TotalGuests1)
        Me.Panel_TotalDueIns.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_TotalDueIns.Location = New System.Drawing.Point(3, 3)
        Me.Panel_TotalDueIns.Name = "Panel_TotalDueIns"
        Me.Panel_TotalDueIns.Size = New System.Drawing.Size(260, 140)
        Me.Panel_TotalDueIns.TabIndex = 77
        '
        'Lbl_TotalGuests
        '
        Me.Lbl_TotalGuests.AutoSize = False
        Me.Lbl_TotalGuests.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TotalGuests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_TotalGuests.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalGuests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lbl_TotalGuests.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_TotalGuests.Name = "Lbl_TotalGuests"
        Me.Lbl_TotalGuests.Size = New System.Drawing.Size(260, 140)
        Me.Lbl_TotalGuests.TabIndex = 58
        Me.Lbl_TotalGuests.Text = "...Expected guests."
        Me.Lbl_TotalGuests.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_TotalGuests1
        '
        Me.Lbl_TotalGuests1.AutoSize = False
        Me.Lbl_TotalGuests1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TotalGuests1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_TotalGuests1.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalGuests1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lbl_TotalGuests1.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_TotalGuests1.Name = "Lbl_TotalGuests1"
        Me.Lbl_TotalGuests1.Size = New System.Drawing.Size(260, 140)
        Me.Lbl_TotalGuests1.TabIndex = 58
        Me.Lbl_TotalGuests1.Text = "Expected Guest(s)"
        Me.Lbl_TotalGuests1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GuestDueIn
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Holder)
        Me.Controls.Add(Me.Panel_Enquiry)
        Me.Name = "GuestDueIn"
        Me.Size = New System.Drawing.Size(1300, 850)
        Me.Panel_Enquiry.ResumeLayout(False)
        Me.Panel_Slide.ResumeLayout(False)
        Me.Panel_Holder.ResumeLayout(False)
        Me.FLP_Display.ResumeLayout(False)
        Me.Panel_TotalDueIns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel_Enquiry As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel_Slide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_LeftBlind As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RightBlind As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Txt_Contact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Txt_CustomerEnquiry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Dat_DateOfArrival As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Txt_Duration As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txt_NumberOfPeople As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txt_Email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Btn_Cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Txt_Name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Cmb_EnquiryType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FLP_Display As FlowLayoutPanel
    Friend WithEvents Btn_AllRooms As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Lbl_FLPTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Cmb_RoomType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel_TotalDueIns As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_TotalGuests As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_TotalGuests1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
