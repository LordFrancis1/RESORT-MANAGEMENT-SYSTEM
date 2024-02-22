<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestCheckinForm
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
        Me.Panel_Enquiry = New Guna.UI2.WinForms.Guna2GradientPanel()
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
        Me.Txt_Name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Cmb_GuestType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Enquiry.SuspendLayout()
        Me.Panel_Slide.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Enquiry
        '
        Me.Panel_Enquiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Enquiry.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Enquiry.BorderColor = System.Drawing.Color.BlueViolet
        Me.Panel_Enquiry.BorderRadius = 5
        Me.Panel_Enquiry.BorderThickness = 1
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
        Me.Panel_Enquiry.Controls.Add(Me.Txt_Name)
        Me.Panel_Enquiry.Controls.Add(Me.Cmb_GuestType)
        Me.Panel_Enquiry.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Enquiry.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.Panel_Enquiry.Location = New System.Drawing.Point(112, 36)
        Me.Panel_Enquiry.Name = "Panel_Enquiry"
        Me.Panel_Enquiry.Size = New System.Drawing.Size(589, 625)
        Me.Panel_Enquiry.TabIndex = 4
        '
        'Panel_Slide
        '
        Me.Panel_Slide.Controls.Add(Me.Lbl_LeftBlind)
        Me.Panel_Slide.Controls.Add(Me.Lbl_RightBlind)
        Me.Panel_Slide.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Slide.Location = New System.Drawing.Point(46, 18)
        Me.Panel_Slide.Name = "Panel_Slide"
        Me.Panel_Slide.Size = New System.Drawing.Size(500, 36)
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
        Me.Lbl_RightBlind.Location = New System.Drawing.Point(370, 0)
        Me.Lbl_RightBlind.Name = "Lbl_RightBlind"
        Me.Lbl_RightBlind.Size = New System.Drawing.Size(130, 36)
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
        Me.Lbl_Inform.Location = New System.Drawing.Point(194, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(303, 36)
        Me.Lbl_Inform.TabIndex = 57
        Me.Lbl_Inform.Text = "Guest Checking Submission..."
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel9.AutoSize = False
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(89, 230)
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
        Me.Txt_Contact.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Contact.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
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
        Me.Txt_Contact.Location = New System.Drawing.Point(89, 261)
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
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(299, 304)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel8.TabIndex = 69
        Me.Guna2HtmlLabel8.Text = "Date Of Arrival"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel7.AutoSize = False
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(89, 450)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(200, 24)
        Me.Guna2HtmlLabel7.TabIndex = 68
        Me.Guna2HtmlLabel7.Text = "Guest Enquiry"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(299, 376)
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
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(89, 376)
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
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(89, 304)
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
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(89, 156)
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
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(87, 82)
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
        Me.Txt_CustomerEnquiry.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_CustomerEnquiry.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_CustomerEnquiry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_CustomerEnquiry.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
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
        Me.Txt_CustomerEnquiry.Location = New System.Drawing.Point(87, 481)
        Me.Txt_CustomerEnquiry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_CustomerEnquiry.MaxLength = 500
        Me.Txt_CustomerEnquiry.Name = "Txt_CustomerEnquiry"
        Me.Txt_CustomerEnquiry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_CustomerEnquiry.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_CustomerEnquiry.PlaceholderText = "Your Queries"
        Me.Txt_CustomerEnquiry.SelectedText = ""
        Me.Txt_CustomerEnquiry.Size = New System.Drawing.Size(412, 109)
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
        Me.Dat_DateOfArrival.Location = New System.Drawing.Point(299, 334)
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
        Me.Txt_Duration.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Duration.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Duration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Duration.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
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
        Me.Txt_Duration.Location = New System.Drawing.Point(299, 407)
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
        Me.Txt_NumberOfPeople.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_NumberOfPeople.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_NumberOfPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_NumberOfPeople.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
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
        Me.Txt_NumberOfPeople.Location = New System.Drawing.Point(89, 407)
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
        Me.Txt_Email.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
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
        Me.Txt_Email.Location = New System.Drawing.Point(87, 187)
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
        'Txt_Name
        '
        Me.Txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Name.Animated = True
        Me.Txt_Name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Name.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Name.BorderRadius = 5
        Me.Txt_Name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Name.DefaultText = ""
        Me.Txt_Name.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Name.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray
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
        Me.Txt_Name.Location = New System.Drawing.Point(87, 113)
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
        'Cmb_GuestType
        '
        Me.Cmb_GuestType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmb_GuestType.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_GuestType.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_GuestType.BorderRadius = 5
        Me.Cmb_GuestType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_GuestType.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_GuestType.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_GuestType.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_GuestType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_GuestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_GuestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_GuestType.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_GuestType.FocusedColor = System.Drawing.Color.BlueViolet
        Me.Cmb_GuestType.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_GuestType.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_GuestType.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_GuestType.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_GuestType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_GuestType.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_GuestType.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_GuestType.ItemHeight = 30
        Me.Cmb_GuestType.Items.AddRange(New Object() {"Select Guest Type", "Leisure Traveller", "Business Traveller", "Luxury Traveller", "Wellness Traveller", "Solo Traveller", "Group Traveller", ""})
        Me.Cmb_GuestType.Location = New System.Drawing.Point(89, 334)
        Me.Cmb_GuestType.Name = "Cmb_GuestType"
        Me.Cmb_GuestType.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_GuestType.Size = New System.Drawing.Size(202, 36)
        Me.Cmb_GuestType.TabIndex = 52
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'GuestCheckinForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Enquiry)
        Me.Name = "GuestCheckinForm"
        Me.Size = New System.Drawing.Size(799, 706)
        Me.Panel_Enquiry.ResumeLayout(False)
        Me.Panel_Slide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents Txt_Name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Cmb_GuestType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Timer1 As Timer
End Class
