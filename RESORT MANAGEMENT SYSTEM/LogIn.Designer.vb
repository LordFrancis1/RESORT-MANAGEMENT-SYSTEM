<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.txt_Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Pic_User = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.toggle_pass_encrypt = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Lbl_UserName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn_Login = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_HomePage = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip_Home = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Ll_AccessControl = New System.Windows.Forms.LinkLabel()
        Me.lbl_Feedback = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.Pic_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Password.Animated = True
        Me.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Password.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Password.BorderRadius = 5
        Me.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Password.DefaultText = ""
        Me.txt_Password.DisabledState.BorderColor = System.Drawing.Color.Red
        Me.txt_Password.DisabledState.FillColor = System.Drawing.Color.Gainsboro
        Me.txt_Password.DisabledState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_Password.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Password.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Password.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Password.FocusedState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Password.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_Password.ForeColor = System.Drawing.Color.Blue
        Me.txt_Password.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Password.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Password.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Password.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Password.Location = New System.Drawing.Point(344, 471)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Password.MaxLength = 15
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Password.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_Password.PlaceholderText = "User Password"
        Me.txt_Password.SelectedText = ""
        Me.txt_Password.Size = New System.Drawing.Size(472, 45)
        Me.txt_Password.TabIndex = 15
        Me.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pic_User
        '
        Me.Pic_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_User.BackColor = System.Drawing.Color.Transparent
        Me.Pic_User.ImageRotate = 0!
        Me.Pic_User.Location = New System.Drawing.Point(479, 174)
        Me.Pic_User.Name = "Pic_User"
        Me.Pic_User.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Pic_User.Size = New System.Drawing.Size(202, 201)
        Me.Pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_User.TabIndex = 14
        Me.Pic_User.TabStop = False
        Me.Pic_User.UseTransparentBackground = True
        '
        'toggle_pass_encrypt
        '
        Me.toggle_pass_encrypt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.toggle_pass_encrypt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.toggle_pass_encrypt.Checked = True
        Me.toggle_pass_encrypt.CheckedState.BorderColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.CheckedState.FillColor = System.Drawing.Color.BlueViolet
        Me.toggle_pass_encrypt.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggle_pass_encrypt.Location = New System.Drawing.Point(716, 481)
        Me.toggle_pass_encrypt.Name = "toggle_pass_encrypt"
        Me.toggle_pass_encrypt.Size = New System.Drawing.Size(35, 25)
        Me.toggle_pass_encrypt.TabIndex = 46
        Me.toggle_pass_encrypt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.toggle_pass_encrypt.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.toggle_pass_encrypt.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_pass_encrypt.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_UserName.AutoSize = False
        Me.Lbl_UserName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_UserName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.ForeColor = System.Drawing.Color.BlueViolet
        Me.Lbl_UserName.Location = New System.Drawing.Point(344, 410)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(472, 40)
        Me.Lbl_UserName.TabIndex = 47
        Me.Lbl_UserName.Text = "User Name"
        Me.Lbl_UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Login
        '
        Me.Btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Login.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Login.BorderColor = System.Drawing.Color.BlueViolet
        Me.Btn_Login.BorderRadius = 5
        Me.Btn_Login.BorderThickness = 1
        Me.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Login.DisabledState.BorderColor = System.Drawing.Color.Red
        Me.Btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Login.DisabledState.FillColor = System.Drawing.Color.Gainsboro
        Me.Btn_Login.DisabledState.ForeColor = System.Drawing.Color.Red
        Me.Btn_Login.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Login.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.Btn_Login.ForeColor = System.Drawing.Color.Black
        Me.Btn_Login.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Login.HoverState.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_Login.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Btn_Login.Location = New System.Drawing.Point(757, 481)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(47, 25)
        Me.Btn_Login.TabIndex = 48
        Me.Btn_Login.Text = "Go"
        '
        'Btn_HomePage
        '
        Me.Btn_HomePage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_HomePage.Animated = True
        Me.Btn_HomePage.BackColor = System.Drawing.Color.Transparent
        Me.Btn_HomePage.BorderColor = System.Drawing.Color.Gray
        Me.Btn_HomePage.BorderRadius = 5
        Me.Btn_HomePage.BorderThickness = 1
        Me.Btn_HomePage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_HomePage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_HomePage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_HomePage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_HomePage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_HomePage.FillColor = System.Drawing.Color.Transparent
        Me.Btn_HomePage.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Btn_HomePage.ForeColor = System.Drawing.Color.Black
        Me.Btn_HomePage.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_HomePage.HoverState.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_HomePage.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_HomePage.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.Home
        Me.Btn_HomePage.ImageSize = New System.Drawing.Size(25, 25)
        Me.Btn_HomePage.Location = New System.Drawing.Point(1091, 12)
        Me.Btn_HomePage.Name = "Btn_HomePage"
        Me.Btn_HomePage.Size = New System.Drawing.Size(40, 40)
        Me.Btn_HomePage.TabIndex = 49
        Me.ToolTip_Home.SetToolTip(Me.Btn_HomePage, "Home Page")
        Me.Btn_HomePage.UseTransparentBackground = True
        '
        'ToolTip_Home
        '
        Me.ToolTip_Home.AllowLinksHandling = True
        Me.ToolTip_Home.BackColor = System.Drawing.Color.BlueViolet
        Me.ToolTip_Home.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Home.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Home.ForeColor = System.Drawing.Color.White
        Me.ToolTip_Home.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Ll_AccessControl
        '
        Me.Ll_AccessControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ll_AccessControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ll_AccessControl.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ll_AccessControl.Location = New System.Drawing.Point(344, 537)
        Me.Ll_AccessControl.Name = "Ll_AccessControl"
        Me.Ll_AccessControl.Size = New System.Drawing.Size(472, 23)
        Me.Ll_AccessControl.TabIndex = 50
        Me.Ll_AccessControl.TabStop = True
        Me.Ll_AccessControl.Text = "Forgot Password"
        Me.Ll_AccessControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Feedback
        '
        Me.lbl_Feedback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Feedback.AutoSize = False
        Me.lbl_Feedback.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Feedback.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Feedback.ForeColor = System.Drawing.Color.Red
        Me.lbl_Feedback.Location = New System.Drawing.Point(19, 12)
        Me.lbl_Feedback.Name = "lbl_Feedback"
        Me.lbl_Feedback.Size = New System.Drawing.Size(1066, 40)
        Me.lbl_Feedback.TabIndex = 51
        Me.lbl_Feedback.Text = "Account Feedback"
        Me.lbl_Feedback.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lbl_Feedback)
        Me.Controls.Add(Me.Ll_AccessControl)
        Me.Controls.Add(Me.Btn_HomePage)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Lbl_UserName)
        Me.Controls.Add(Me.toggle_pass_encrypt)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.Pic_User)
        Me.Name = "Login"
        Me.Size = New System.Drawing.Size(1144, 742)
        CType(Me.Pic_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Pic_User As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents toggle_pass_encrypt As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Lbl_UserName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Btn_Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_HomePage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip_Home As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Ll_AccessControl As LinkLabel
    Friend WithEvents lbl_Feedback As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
