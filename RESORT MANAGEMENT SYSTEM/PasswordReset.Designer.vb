<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordReset
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
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txt_ConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Ll_RememberedPassword = New System.Windows.Forms.LinkLabel()
        Me.Lbl_UserName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_NewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Pic_User = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Btn_Cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Modify = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.toggle_newpass = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.toggle_confirmpass = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Panel_Holder.SuspendLayout()
        CType(Me.Pic_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Holder
        '
        Me.Panel_Holder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Holder.BorderColor = System.Drawing.Color.BlueViolet
        Me.Panel_Holder.BorderRadius = 5
        Me.Panel_Holder.BorderThickness = 1
        Me.Panel_Holder.Controls.Add(Me.toggle_confirmpass)
        Me.Panel_Holder.Controls.Add(Me.toggle_newpass)
        Me.Panel_Holder.Controls.Add(Me.txt_ConfirmPassword)
        Me.Panel_Holder.Controls.Add(Me.Ll_RememberedPassword)
        Me.Panel_Holder.Controls.Add(Me.Lbl_UserName)
        Me.Panel_Holder.Controls.Add(Me.txt_NewPassword)
        Me.Panel_Holder.Controls.Add(Me.Pic_User)
        Me.Panel_Holder.Controls.Add(Me.Btn_Cancel)
        Me.Panel_Holder.Controls.Add(Me.Btn_Modify)
        Me.Panel_Holder.Location = New System.Drawing.Point(271, 117)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(617, 559)
        Me.Panel_Holder.TabIndex = 2
        '
        'txt_ConfirmPassword
        '
        Me.txt_ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ConfirmPassword.Animated = True
        Me.txt_ConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_ConfirmPassword.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_ConfirmPassword.BorderRadius = 5
        Me.txt_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ConfirmPassword.DefaultText = ""
        Me.txt_ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ConfirmPassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_ConfirmPassword.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_ConfirmPassword.FocusedState.ForeColor = System.Drawing.Color.Blue
        Me.txt_ConfirmPassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_ConfirmPassword.ForeColor = System.Drawing.Color.Blue
        Me.txt_ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_ConfirmPassword.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_ConfirmPassword.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.txt_ConfirmPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txt_ConfirmPassword.Location = New System.Drawing.Point(72, 377)
        Me.txt_ConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ConfirmPassword.MaxLength = 50
        Me.txt_ConfirmPassword.Name = "txt_ConfirmPassword"
        Me.txt_ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_ConfirmPassword.PlaceholderText = "Confirm Password"
        Me.txt_ConfirmPassword.SelectedText = ""
        Me.txt_ConfirmPassword.Size = New System.Drawing.Size(472, 45)
        Me.txt_ConfirmPassword.TabIndex = 61
        Me.txt_ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ll_RememberedPassword
        '
        Me.Ll_RememberedPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ll_RememberedPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ll_RememberedPassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ll_RememberedPassword.Location = New System.Drawing.Point(72, 523)
        Me.Ll_RememberedPassword.Name = "Ll_RememberedPassword"
        Me.Ll_RememberedPassword.Size = New System.Drawing.Size(472, 23)
        Me.Ll_RememberedPassword.TabIndex = 60
        Me.Ll_RememberedPassword.TabStop = True
        Me.Ll_RememberedPassword.Text = "Remembered Password ?"
        Me.Ll_RememberedPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_UserName.AutoSize = False
        Me.Lbl_UserName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_UserName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.ForeColor = System.Drawing.Color.BlueViolet
        Me.Lbl_UserName.Location = New System.Drawing.Point(72, 230)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(472, 40)
        Me.Lbl_UserName.TabIndex = 59
        Me.Lbl_UserName.Text = "User Name"
        Me.Lbl_UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_NewPassword
        '
        Me.txt_NewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_NewPassword.Animated = True
        Me.txt_NewPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_NewPassword.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_NewPassword.BorderRadius = 5
        Me.txt_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_NewPassword.DefaultText = ""
        Me.txt_NewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_NewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_NewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_NewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_NewPassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_NewPassword.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_NewPassword.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_NewPassword.FocusedState.ForeColor = System.Drawing.Color.Blue
        Me.txt_NewPassword.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_NewPassword.ForeColor = System.Drawing.Color.Blue
        Me.txt_NewPassword.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_NewPassword.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_NewPassword.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.txt_NewPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txt_NewPassword.Location = New System.Drawing.Point(72, 304)
        Me.txt_NewPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_NewPassword.MaxLength = 50
        Me.txt_NewPassword.Name = "txt_NewPassword"
        Me.txt_NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_NewPassword.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txt_NewPassword.PlaceholderText = "New Password"
        Me.txt_NewPassword.SelectedText = ""
        Me.txt_NewPassword.Size = New System.Drawing.Size(472, 45)
        Me.txt_NewPassword.TabIndex = 58
        Me.txt_NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pic_User
        '
        Me.Pic_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_User.BackColor = System.Drawing.Color.Transparent
        Me.Pic_User.ImageRotate = 0!
        Me.Pic_User.Location = New System.Drawing.Point(229, 38)
        Me.Pic_User.Name = "Pic_User"
        Me.Pic_User.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Pic_User.Size = New System.Drawing.Size(157, 169)
        Me.Pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_User.TabIndex = 57
        Me.Pic_User.TabStop = False
        Me.Pic_User.UseTransparentBackground = True
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
        Me.Btn_Cancel.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Cancel.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.Location = New System.Drawing.Point(168, 461)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.PressedColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Cancel.TabIndex = 56
        Me.Btn_Cancel.Text = "CANCEL"
        '
        'Btn_Modify
        '
        Me.Btn_Modify.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Modify.Animated = True
        Me.Btn_Modify.BorderColor = System.Drawing.Color.White
        Me.Btn_Modify.BorderRadius = 5
        Me.Btn_Modify.BorderThickness = 1
        Me.Btn_Modify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modify.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Modify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Modify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Modify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Modify.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_Modify.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_Modify.ForeColor = System.Drawing.Color.White
        Me.Btn_Modify.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Modify.HoverState.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_Modify.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modify.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Modify.Location = New System.Drawing.Point(347, 461)
        Me.Btn_Modify.Name = "Btn_Modify"
        Me.Btn_Modify.PressedColor = System.Drawing.Color.White
        Me.Btn_Modify.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Modify.TabIndex = 55
        Me.Btn_Modify.Text = "MODIFY"
        '
        'Timer1
        '
        '
        'toggle_newpass
        '
        Me.toggle_newpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.toggle_newpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.toggle_newpass.Checked = True
        Me.toggle_newpass.CheckedState.BorderColor = System.Drawing.Color.White
        Me.toggle_newpass.CheckedState.FillColor = System.Drawing.Color.BlueViolet
        Me.toggle_newpass.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_newpass.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle_newpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggle_newpass.Location = New System.Drawing.Point(497, 314)
        Me.toggle_newpass.Name = "toggle_newpass"
        Me.toggle_newpass.Size = New System.Drawing.Size(35, 25)
        Me.toggle_newpass.TabIndex = 62
        Me.toggle_newpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.toggle_newpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.toggle_newpass.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_newpass.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'toggle_confirmpass
        '
        Me.toggle_confirmpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.toggle_confirmpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.toggle_confirmpass.Checked = True
        Me.toggle_confirmpass.CheckedState.BorderColor = System.Drawing.Color.White
        Me.toggle_confirmpass.CheckedState.FillColor = System.Drawing.Color.BlueViolet
        Me.toggle_confirmpass.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_confirmpass.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle_confirmpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggle_confirmpass.Location = New System.Drawing.Point(497, 388)
        Me.toggle_confirmpass.Name = "toggle_confirmpass"
        Me.toggle_confirmpass.Size = New System.Drawing.Size(35, 25)
        Me.toggle_confirmpass.TabIndex = 63
        Me.toggle_confirmpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.toggle_confirmpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.toggle_confirmpass.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_confirmpass.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'PasswordReset
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Panel_Holder)
        Me.Name = "PasswordReset"
        Me.Size = New System.Drawing.Size(1140, 745)
        Me.Panel_Holder.ResumeLayout(False)
        CType(Me.Pic_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Btn_Cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Modify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Ll_RememberedPassword As LinkLabel
    Friend WithEvents Lbl_UserName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_NewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Pic_User As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txt_ConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents toggle_confirmpass As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle_newpass As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
