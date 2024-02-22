<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grp_passwords = New System.Windows.Forms.GroupBox()
        Me.lbl_encrypt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.toggle_pass_encrypt = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.txt_ConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmb_gender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_PhoneNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_IDNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_surname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Pic_User = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btn_browse = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_google = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_AutogenID = New Guna.UI2.WinForms.Guna2Button()
        Me.cmb_station = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_department = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_manegerialevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Rb_NormalUser = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Rb_SystemAdministrator = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Panel_Buttons = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_submit = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_UserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.grp_passwords.SuspendLayout()
        CType(Me.Pic_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'grp_passwords
        '
        Me.grp_passwords.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grp_passwords.Controls.Add(Me.lbl_encrypt)
        Me.grp_passwords.Controls.Add(Me.toggle_pass_encrypt)
        Me.grp_passwords.Controls.Add(Me.txt_ConfirmPassword)
        Me.grp_passwords.Controls.Add(Me.txt_Password)
        Me.grp_passwords.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_passwords.ForeColor = System.Drawing.Color.Black
        Me.grp_passwords.Location = New System.Drawing.Point(73, 632)
        Me.grp_passwords.Name = "grp_passwords"
        Me.grp_passwords.Size = New System.Drawing.Size(356, 201)
        Me.grp_passwords.TabIndex = 55
        Me.grp_passwords.TabStop = False
        Me.grp_passwords.Text = "SetUp Your Password"
        '
        'lbl_encrypt
        '
        Me.lbl_encrypt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_encrypt.AutoSize = False
        Me.lbl_encrypt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_encrypt.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_encrypt.ForeColor = System.Drawing.Color.Blue
        Me.lbl_encrypt.Location = New System.Drawing.Point(11, 158)
        Me.lbl_encrypt.Name = "lbl_encrypt"
        Me.lbl_encrypt.Size = New System.Drawing.Size(296, 28)
        Me.lbl_encrypt.TabIndex = 45
        Me.lbl_encrypt.Text = "Password Encrypted..."
        Me.lbl_encrypt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toggle_pass_encrypt
        '
        Me.toggle_pass_encrypt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.toggle_pass_encrypt.Checked = True
        Me.toggle_pass_encrypt.CheckedState.BorderColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.CheckedState.BorderRadius = 5
        Me.toggle_pass_encrypt.CheckedState.BorderThickness = 1
        Me.toggle_pass_encrypt.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.toggle_pass_encrypt.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.CheckedState.InnerBorderThickness = 1
        Me.toggle_pass_encrypt.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggle_pass_encrypt.Location = New System.Drawing.Point(273, 107)
        Me.toggle_pass_encrypt.Name = "toggle_pass_encrypt"
        Me.toggle_pass_encrypt.Size = New System.Drawing.Size(57, 36)
        Me.toggle_pass_encrypt.TabIndex = 46
        Me.toggle_pass_encrypt.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.UncheckedState.BorderRadius = 5
        Me.toggle_pass_encrypt.UncheckedState.BorderThickness = 1
        Me.toggle_pass_encrypt.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.toggle_pass_encrypt.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.UncheckedState.InnerBorderThickness = 1
        Me.toggle_pass_encrypt.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'txt_ConfirmPassword
        '
        Me.txt_ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ConfirmPassword.Animated = True
        Me.txt_ConfirmPassword.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_ConfirmPassword.BorderRadius = 10
        Me.txt_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ConfirmPassword.DefaultText = ""
        Me.txt_ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ConfirmPassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ConfirmPassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_ConfirmPassword.ForeColor = System.Drawing.Color.Blue
        Me.txt_ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_ConfirmPassword.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_ConfirmPassword.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_ConfirmPassword.Location = New System.Drawing.Point(29, 98)
        Me.txt_ConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ConfirmPassword.MaxLength = 15
        Me.txt_ConfirmPassword.Name = "txt_ConfirmPassword"
        Me.txt_ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_ConfirmPassword.PlaceholderText = "Confirm Password"
        Me.txt_ConfirmPassword.SelectedText = ""
        Me.txt_ConfirmPassword.Size = New System.Drawing.Size(224, 45)
        Me.txt_ConfirmPassword.TabIndex = 17
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Password.Animated = True
        Me.txt_Password.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Password.BorderRadius = 10
        Me.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Password.DefaultText = ""
        Me.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Password.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Password.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.ForeColor = System.Drawing.Color.Blue
        Me.txt_Password.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Password.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_Password.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_Password.Location = New System.Drawing.Point(29, 45)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Password.MaxLength = 15
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Password.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_Password.PlaceholderText = "Password"
        Me.txt_Password.SelectedText = ""
        Me.txt_Password.Size = New System.Drawing.Size(224, 45)
        Me.txt_Password.TabIndex = 16
        '
        'txt_email
        '
        Me.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_email.Animated = True
        Me.txt_email.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_email.BorderRadius = 10
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultText = ""
        Me.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.Blue
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_email.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_email.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(84, 405)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_email.PlaceholderText = "E-Mail Address"
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(472, 45)
        Me.txt_email.TabIndex = 54
        '
        'cmb_gender
        '
        Me.cmb_gender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_gender.BackColor = System.Drawing.Color.Transparent
        Me.cmb_gender.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_gender.BorderRadius = 10
        Me.cmb_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_gender.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cmb_gender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_gender.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cmb_gender.ForeColor = System.Drawing.Color.Blue
        Me.cmb_gender.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_gender.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.cmb_gender.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmb_gender.ItemHeight = 30
        Me.cmb_gender.Items.AddRange(New Object() {"Select Your Gender ", "Male", "Female"})
        Me.cmb_gender.Location = New System.Drawing.Point(590, 328)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(224, 36)
        Me.cmb_gender.TabIndex = 53
        '
        'txt_PhoneNumber
        '
        Me.txt_PhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_PhoneNumber.Animated = True
        Me.txt_PhoneNumber.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_PhoneNumber.BorderRadius = 10
        Me.txt_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_PhoneNumber.DefaultText = ""
        Me.txt_PhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_PhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_PhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_PhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_PhoneNumber.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_PhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_PhoneNumber.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PhoneNumber.ForeColor = System.Drawing.Color.Blue
        Me.txt_PhoneNumber.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_PhoneNumber.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_PhoneNumber.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_PhoneNumber.Location = New System.Drawing.Point(332, 328)
        Me.txt_PhoneNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_PhoneNumber.MaxLength = 10
        Me.txt_PhoneNumber.Name = "txt_PhoneNumber"
        Me.txt_PhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_PhoneNumber.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_PhoneNumber.PlaceholderText = "Phone Number"
        Me.txt_PhoneNumber.SelectedText = ""
        Me.txt_PhoneNumber.Size = New System.Drawing.Size(224, 45)
        Me.txt_PhoneNumber.TabIndex = 52
        '
        'txt_IDNumber
        '
        Me.txt_IDNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_IDNumber.Animated = True
        Me.txt_IDNumber.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_IDNumber.BorderRadius = 10
        Me.txt_IDNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_IDNumber.DefaultText = ""
        Me.txt_IDNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_IDNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_IDNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_IDNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_IDNumber.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_IDNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_IDNumber.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDNumber.ForeColor = System.Drawing.Color.Blue
        Me.txt_IDNumber.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_IDNumber.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_IDNumber.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_IDNumber.Location = New System.Drawing.Point(84, 328)
        Me.txt_IDNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_IDNumber.MaxLength = 8
        Me.txt_IDNumber.Name = "txt_IDNumber"
        Me.txt_IDNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_IDNumber.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_IDNumber.PlaceholderText = "ID Number"
        Me.txt_IDNumber.SelectedText = ""
        Me.txt_IDNumber.Size = New System.Drawing.Size(224, 45)
        Me.txt_IDNumber.TabIndex = 51
        '
        'txt_lastname
        '
        Me.txt_lastname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_lastname.Animated = True
        Me.txt_lastname.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_lastname.BorderRadius = 10
        Me.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lastname.DefaultText = ""
        Me.txt_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastname.ForeColor = System.Drawing.Color.Blue
        Me.txt_lastname.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_lastname.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_lastname.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_lastname.Location = New System.Drawing.Point(590, 244)
        Me.txt_lastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_lastname.MaxLength = 16
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lastname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_lastname.PlaceholderText = "Last Name"
        Me.txt_lastname.SelectedText = ""
        Me.txt_lastname.Size = New System.Drawing.Size(224, 45)
        Me.txt_lastname.TabIndex = 50
        '
        'txt_firstname
        '
        Me.txt_firstname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_firstname.Animated = True
        Me.txt_firstname.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_firstname.BorderRadius = 10
        Me.txt_firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_firstname.DefaultText = ""
        Me.txt_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstname.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firstname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstname.ForeColor = System.Drawing.Color.Blue
        Me.txt_firstname.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_firstname.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_firstname.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_firstname.Location = New System.Drawing.Point(332, 244)
        Me.txt_firstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_firstname.MaxLength = 16
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_firstname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_firstname.PlaceholderText = "First Name"
        Me.txt_firstname.SelectedText = ""
        Me.txt_firstname.Size = New System.Drawing.Size(224, 45)
        Me.txt_firstname.TabIndex = 49
        '
        'txt_surname
        '
        Me.txt_surname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_surname.Animated = True
        Me.txt_surname.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_surname.BorderRadius = 10
        Me.txt_surname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_surname.DefaultText = ""
        Me.txt_surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_surname.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_surname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname.ForeColor = System.Drawing.Color.Blue
        Me.txt_surname.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_surname.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_surname.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_surname.Location = New System.Drawing.Point(84, 244)
        Me.txt_surname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_surname.MaxLength = 16
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_surname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_surname.PlaceholderText = "Sur Name"
        Me.txt_surname.SelectedText = ""
        Me.txt_surname.Size = New System.Drawing.Size(224, 45)
        Me.txt_surname.TabIndex = 48
        '
        'Pic_User
        '
        Me.Pic_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_User.BackColor = System.Drawing.Color.Transparent
        Me.Pic_User.ImageRotate = 0!
        Me.Pic_User.Location = New System.Drawing.Point(332, 71)
        Me.Pic_User.Name = "Pic_User"
        Me.Pic_User.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Pic_User.Size = New System.Drawing.Size(159, 152)
        Me.Pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_User.TabIndex = 47
        Me.Pic_User.TabStop = False
        Me.Pic_User.UseTransparentBackground = True
        '
        'btn_browse
        '
        Me.btn_browse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_browse.Animated = True
        Me.btn_browse.BorderColor = System.Drawing.Color.Transparent
        Me.btn_browse.BorderThickness = 1
        Me.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_browse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_browse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_browse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_browse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_browse.FillColor = System.Drawing.Color.White
        Me.btn_browse.Font = New System.Drawing.Font("Trebuchet MS", 15.75!)
        Me.btn_browse.ForeColor = System.Drawing.Color.Black
        Me.btn_browse.HoverState.BorderColor = System.Drawing.Color.White
        Me.btn_browse.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btn_browse.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.btn_browse.Location = New System.Drawing.Point(497, 175)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.PressedColor = System.Drawing.Color.White
        Me.btn_browse.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_browse.Size = New System.Drawing.Size(59, 48)
        Me.btn_browse.TabIndex = 46
        Me.btn_browse.Text = "+.."
        '
        'btn_google
        '
        Me.btn_google.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_google.Animated = True
        Me.btn_google.BorderColor = System.Drawing.Color.Lime
        Me.btn_google.BorderRadius = 10
        Me.btn_google.BorderThickness = 1
        Me.btn_google.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_google.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_google.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_google.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_google.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_google.FillColor = System.Drawing.Color.Transparent
        Me.btn_google.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.btn_google.ForeColor = System.Drawing.Color.Black
        Me.btn_google.HoverState.BorderColor = System.Drawing.Color.White
        Me.btn_google.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_google.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btn_google.Location = New System.Drawing.Point(21, 117)
        Me.btn_google.Name = "btn_google"
        Me.btn_google.PressedColor = System.Drawing.Color.White
        Me.btn_google.Size = New System.Drawing.Size(280, 45)
        Me.btn_google.TabIndex = 45
        Me.btn_google.Text = "Continue with Google"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Animated = True
        Me.btn_cancel.BorderColor = System.Drawing.Color.Red
        Me.btn_cancel.BorderRadius = 10
        Me.btn_cancel.BorderThickness = 1
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.FillColor = System.Drawing.Color.Transparent
        Me.btn_cancel.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.HoverState.BorderColor = System.Drawing.Color.White
        Me.btn_cancel.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancel.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(169, 51)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.PressedColor = System.Drawing.Color.White
        Me.btn_cancel.Size = New System.Drawing.Size(132, 45)
        Me.btn_cancel.TabIndex = 44
        Me.btn_cancel.Text = "CANCEL"
        '
        'Btn_AutogenID
        '
        Me.Btn_AutogenID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_AutogenID.Animated = True
        Me.Btn_AutogenID.BorderColor = System.Drawing.Color.BlueViolet
        Me.Btn_AutogenID.BorderRadius = 10
        Me.Btn_AutogenID.BorderThickness = 1
        Me.Btn_AutogenID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AutogenID.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AutogenID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_AutogenID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_AutogenID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_AutogenID.FillColor = System.Drawing.Color.Transparent
        Me.Btn_AutogenID.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_AutogenID.ForeColor = System.Drawing.Color.Black
        Me.Btn_AutogenID.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_AutogenID.HoverState.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_AutogenID.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_AutogenID.Location = New System.Drawing.Point(84, 558)
        Me.Btn_AutogenID.Name = "Btn_AutogenID"
        Me.Btn_AutogenID.PressedColor = System.Drawing.Color.White
        Me.Btn_AutogenID.Size = New System.Drawing.Size(224, 45)
        Me.Btn_AutogenID.TabIndex = 62
        Me.Btn_AutogenID.Text = "Generate User ID"
        '
        'cmb_station
        '
        Me.cmb_station.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_station.BackColor = System.Drawing.Color.Transparent
        Me.cmb_station.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_station.BorderRadius = 10
        Me.cmb_station.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_station.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cmb_station.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_station.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_station.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cmb_station.ForeColor = System.Drawing.Color.Blue
        Me.cmb_station.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_station.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.cmb_station.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmb_station.ItemHeight = 30
        Me.cmb_station.Items.AddRange(New Object() {"Select Station?"})
        Me.cmb_station.Location = New System.Drawing.Point(590, 489)
        Me.cmb_station.Name = "cmb_station"
        Me.cmb_station.Size = New System.Drawing.Size(224, 36)
        Me.cmb_station.TabIndex = 61
        '
        'cmb_department
        '
        Me.cmb_department.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_department.BackColor = System.Drawing.Color.Transparent
        Me.cmb_department.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_department.BorderRadius = 10
        Me.cmb_department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_department.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cmb_department.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_department.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_department.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cmb_department.ForeColor = System.Drawing.Color.Blue
        Me.cmb_department.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_department.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.cmb_department.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmb_department.ItemHeight = 30
        Me.cmb_department.Items.AddRange(New Object() {"Department?", "Accounts and Finance", "Front Office", "HouseKeeping", "Food and Beverage", "Maintenance", "Security"})
        Me.cmb_department.Location = New System.Drawing.Point(343, 489)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(213, 36)
        Me.cmb_department.TabIndex = 60
        '
        'cmb_manegerialevel
        '
        Me.cmb_manegerialevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_manegerialevel.BackColor = System.Drawing.Color.Transparent
        Me.cmb_manegerialevel.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_manegerialevel.BorderRadius = 10
        Me.cmb_manegerialevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_manegerialevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_manegerialevel.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cmb_manegerialevel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_manegerialevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_manegerialevel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.cmb_manegerialevel.ForeColor = System.Drawing.Color.Blue
        Me.cmb_manegerialevel.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.cmb_manegerialevel.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.cmb_manegerialevel.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmb_manegerialevel.ItemHeight = 30
        Me.cmb_manegerialevel.Items.AddRange(New Object() {"Managerial Level?", "Top Level", "Intermediate", "Supervisory"})
        Me.cmb_manegerialevel.Location = New System.Drawing.Point(84, 489)
        Me.cmb_manegerialevel.Name = "cmb_manegerialevel"
        Me.cmb_manegerialevel.Size = New System.Drawing.Size(224, 36)
        Me.cmb_manegerialevel.TabIndex = 59
        '
        'Rb_NormalUser
        '
        Me.Rb_NormalUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rb_NormalUser.Animated = True
        Me.Rb_NormalUser.CheckedState.BorderColor = System.Drawing.Color.Blue
        Me.Rb_NormalUser.CheckedState.BorderThickness = 1
        Me.Rb_NormalUser.CheckedState.FillColor = System.Drawing.Color.BlueViolet
        Me.Rb_NormalUser.CheckedState.InnerColor = System.Drawing.Color.Gainsboro
        Me.Rb_NormalUser.CheckedState.InnerOffset = -4
        Me.Rb_NormalUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rb_NormalUser.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Rb_NormalUser.Location = New System.Drawing.Point(590, 437)
        Me.Rb_NormalUser.Name = "Rb_NormalUser"
        Me.Rb_NormalUser.Size = New System.Drawing.Size(207, 26)
        Me.Rb_NormalUser.TabIndex = 58
        Me.Rb_NormalUser.Text = "Normal System User"
        Me.Rb_NormalUser.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Rb_NormalUser.UncheckedState.BorderThickness = 2
        Me.Rb_NormalUser.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Rb_NormalUser.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Rb_SystemAdministrator
        '
        Me.Rb_SystemAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rb_SystemAdministrator.Animated = True
        Me.Rb_SystemAdministrator.Checked = True
        Me.Rb_SystemAdministrator.CheckedState.BorderColor = System.Drawing.Color.Blue
        Me.Rb_SystemAdministrator.CheckedState.BorderThickness = 1
        Me.Rb_SystemAdministrator.CheckedState.FillColor = System.Drawing.Color.BlueViolet
        Me.Rb_SystemAdministrator.CheckedState.InnerColor = System.Drawing.Color.Gainsboro
        Me.Rb_SystemAdministrator.CheckedState.InnerOffset = -4
        Me.Rb_SystemAdministrator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rb_SystemAdministrator.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Rb_SystemAdministrator.Location = New System.Drawing.Point(590, 393)
        Me.Rb_SystemAdministrator.Name = "Rb_SystemAdministrator"
        Me.Rb_SystemAdministrator.Size = New System.Drawing.Size(207, 26)
        Me.Rb_SystemAdministrator.TabIndex = 57
        Me.Rb_SystemAdministrator.TabStop = True
        Me.Rb_SystemAdministrator.Text = "System Administrator"
        Me.Rb_SystemAdministrator.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Rb_SystemAdministrator.UncheckedState.BorderThickness = 2
        Me.Rb_SystemAdministrator.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Rb_SystemAdministrator.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Panel_Buttons
        '
        Me.Panel_Buttons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Buttons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Buttons.BorderColor = System.Drawing.Color.BlueViolet
        Me.Panel_Buttons.BorderThickness = 1
        Me.Panel_Buttons.Controls.Add(Me.btn_google)
        Me.Panel_Buttons.Controls.Add(Me.btn_cancel)
        Me.Panel_Buttons.Controls.Add(Me.btn_submit)
        Me.Panel_Buttons.Location = New System.Drawing.Point(496, 632)
        Me.Panel_Buttons.Name = "Panel_Buttons"
        Me.Panel_Buttons.Size = New System.Drawing.Size(318, 201)
        Me.Panel_Buttons.TabIndex = 56
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_submit.Animated = True
        Me.btn_submit.BorderColor = System.Drawing.Color.Blue
        Me.btn_submit.BorderRadius = 10
        Me.btn_submit.BorderThickness = 1
        Me.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_submit.FillColor = System.Drawing.Color.Transparent
        Me.btn_submit.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.btn_submit.ForeColor = System.Drawing.Color.Black
        Me.btn_submit.HoverState.BorderColor = System.Drawing.Color.White
        Me.btn_submit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_submit.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btn_submit.Location = New System.Drawing.Point(21, 51)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.PressedColor = System.Drawing.Color.White
        Me.btn_submit.Size = New System.Drawing.Size(132, 45)
        Me.btn_submit.TabIndex = 43
        Me.btn_submit.Text = "SIGN UP"
        '
        'txt_UserID
        '
        Me.txt_UserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_UserID.Animated = True
        Me.txt_UserID.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_UserID.BorderRadius = 10
        Me.txt_UserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_UserID.DefaultText = ""
        Me.txt_UserID.DisabledState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_UserID.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_UserID.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.txt_UserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_UserID.Enabled = False
        Me.txt_UserID.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_UserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_UserID.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_UserID.ForeColor = System.Drawing.Color.Blue
        Me.txt_UserID.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_UserID.HoverState.FillColor = System.Drawing.Color.LightGray
        Me.txt_UserID.HoverState.ForeColor = System.Drawing.Color.Black
        Me.txt_UserID.Location = New System.Drawing.Point(332, 558)
        Me.txt_UserID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_UserID.MaxLength = 8
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_UserID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_UserID.PlaceholderText = "User ID "
        Me.txt_UserID.SelectedText = ""
        Me.txt_UserID.Size = New System.Drawing.Size(224, 45)
        Me.txt_UserID.TabIndex = 63
        '
        'SignUpForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.grp_passwords)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.cmb_gender)
        Me.Controls.Add(Me.txt_PhoneNumber)
        Me.Controls.Add(Me.txt_IDNumber)
        Me.Controls.Add(Me.txt_lastname)
        Me.Controls.Add(Me.txt_firstname)
        Me.Controls.Add(Me.txt_surname)
        Me.Controls.Add(Me.Pic_User)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Btn_AutogenID)
        Me.Controls.Add(Me.cmb_station)
        Me.Controls.Add(Me.cmb_department)
        Me.Controls.Add(Me.cmb_manegerialevel)
        Me.Controls.Add(Me.Rb_NormalUser)
        Me.Controls.Add(Me.Rb_SystemAdministrator)
        Me.Controls.Add(Me.Panel_Buttons)
        Me.Controls.Add(Me.txt_UserID)
        Me.Name = "SignUpForm"
        Me.Size = New System.Drawing.Size(900, 900)
        Me.grp_passwords.ResumeLayout(False)
        CType(Me.Pic_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents grp_passwords As GroupBox
    Friend WithEvents lbl_encrypt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents toggle_pass_encrypt As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txt_ConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmb_gender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_PhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_IDNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_firstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_surname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Pic_User As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btn_browse As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_google As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_AutogenID As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmb_station As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_department As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_manegerialevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Rb_NormalUser As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Rb_SystemAdministrator As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Panel_Buttons As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_submit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_UserID As Guna.UI2.WinForms.Guna2TextBox
End Class
