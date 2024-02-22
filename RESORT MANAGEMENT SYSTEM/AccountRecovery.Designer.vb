<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountRecovery
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
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Btn_RecoverAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.Cmb_UserID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Btn_Cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_Response3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Response2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Response1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Cmb_Question3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Lbl_Title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Cmb_Question2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Cmb_Question1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel_Top = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Maximize = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_Holder.SuspendLayout()
        Me.Panel_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Holder
        '
        Me.Panel_Holder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Holder.BorderColor = System.Drawing.Color.BlueViolet
        Me.Panel_Holder.BorderRadius = 5
        Me.Panel_Holder.BorderThickness = 1
        Me.Panel_Holder.Controls.Add(Me.Btn_RecoverAccount)
        Me.Panel_Holder.Controls.Add(Me.Cmb_UserID)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel_Holder.Controls.Add(Me.Btn_Cancel)
        Me.Panel_Holder.Controls.Add(Me.Btn_Save)
        Me.Panel_Holder.Controls.Add(Me.txt_Response3)
        Me.Panel_Holder.Controls.Add(Me.txt_Response2)
        Me.Panel_Holder.Controls.Add(Me.txt_Response1)
        Me.Panel_Holder.Controls.Add(Me.Cmb_Question3)
        Me.Panel_Holder.Controls.Add(Me.Lbl_Title)
        Me.Panel_Holder.Controls.Add(Me.Cmb_Question2)
        Me.Panel_Holder.Controls.Add(Me.Cmb_Question1)
        Me.Panel_Holder.Location = New System.Drawing.Point(278, 67)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(617, 634)
        Me.Panel_Holder.TabIndex = 1
        '
        'Btn_RecoverAccount
        '
        Me.Btn_RecoverAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_RecoverAccount.Animated = True
        Me.Btn_RecoverAccount.BorderColor = System.Drawing.Color.White
        Me.Btn_RecoverAccount.BorderRadius = 5
        Me.Btn_RecoverAccount.BorderThickness = 1
        Me.Btn_RecoverAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_RecoverAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_RecoverAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_RecoverAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_RecoverAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_RecoverAccount.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_RecoverAccount.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_RecoverAccount.ForeColor = System.Drawing.Color.White
        Me.Btn_RecoverAccount.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_RecoverAccount.HoverState.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_RecoverAccount.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RecoverAccount.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_RecoverAccount.Location = New System.Drawing.Point(24, 577)
        Me.Btn_RecoverAccount.Name = "Btn_RecoverAccount"
        Me.Btn_RecoverAccount.PressedColor = System.Drawing.Color.BlueViolet
        Me.Btn_RecoverAccount.Size = New System.Drawing.Size(261, 36)
        Me.Btn_RecoverAccount.TabIndex = 59
        Me.Btn_RecoverAccount.Text = "Recover Account"
        '
        'Cmb_UserID
        '
        Me.Cmb_UserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmb_UserID.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_UserID.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_UserID.BorderRadius = 5
        Me.Cmb_UserID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_UserID.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_UserID.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_UserID.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_UserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_UserID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_UserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_UserID.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_UserID.FocusedColor = System.Drawing.Color.BlueViolet
        Me.Cmb_UserID.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_UserID.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_UserID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_UserID.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_UserID.ItemHeight = 30
        Me.Cmb_UserID.Items.AddRange(New Object() {"Select User ID"})
        Me.Cmb_UserID.Location = New System.Drawing.Point(386, 40)
        Me.Cmb_UserID.Name = "Cmb_UserID"
        Me.Cmb_UserID.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_UserID.Size = New System.Drawing.Size(206, 36)
        Me.Cmb_UserID.TabIndex = 58
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.BlueViolet
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(24, 40)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(356, 36)
        Me.Guna2HtmlLabel1.TabIndex = 57
        Me.Guna2HtmlLabel1.Text = "Account Recovery Protocol for user ..."
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Btn_Cancel.Location = New System.Drawing.Point(341, 577)
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
        Me.Btn_Save.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_Save.HoverState.FillColor = System.Drawing.Color.BlueViolet
        Me.Btn_Save.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.Location = New System.Drawing.Point(474, 577)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.PressedColor = System.Drawing.Color.White
        Me.Btn_Save.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Save.TabIndex = 55
        Me.Btn_Save.Text = "SAVE"
        '
        'txt_Response3
        '
        Me.txt_Response3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Response3.Animated = True
        Me.txt_Response3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response3.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response3.BorderRadius = 5
        Me.txt_Response3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Response3.DefaultText = ""
        Me.txt_Response3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Response3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Response3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Response3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Response3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response3.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response3.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response3.FocusedState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Response3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_Response3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txt_Response3.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response3.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response3.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Response3.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Response3.Location = New System.Drawing.Point(24, 469)
        Me.txt_Response3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Response3.MaxLength = 50
        Me.txt_Response3.Name = "txt_Response3"
        Me.txt_Response3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Response3.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txt_Response3.PlaceholderText = "Response"
        Me.txt_Response3.SelectedText = ""
        Me.txt_Response3.Size = New System.Drawing.Size(568, 36)
        Me.txt_Response3.TabIndex = 54
        '
        'txt_Response2
        '
        Me.txt_Response2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Response2.Animated = True
        Me.txt_Response2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response2.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response2.BorderRadius = 5
        Me.txt_Response2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Response2.DefaultText = ""
        Me.txt_Response2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Response2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Response2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Response2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Response2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response2.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response2.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response2.FocusedState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Response2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_Response2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txt_Response2.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response2.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Response2.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Response2.Location = New System.Drawing.Point(24, 350)
        Me.txt_Response2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Response2.MaxLength = 50
        Me.txt_Response2.Name = "txt_Response2"
        Me.txt_Response2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Response2.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txt_Response2.PlaceholderText = "Response"
        Me.txt_Response2.SelectedText = ""
        Me.txt_Response2.Size = New System.Drawing.Size(568, 36)
        Me.txt_Response2.TabIndex = 54
        '
        'txt_Response1
        '
        Me.txt_Response1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Response1.Animated = True
        Me.txt_Response1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response1.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response1.BorderRadius = 5
        Me.txt_Response1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Response1.DefaultText = ""
        Me.txt_Response1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Response1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Response1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Response1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Response1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response1.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response1.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response1.FocusedState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Response1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txt_Response1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txt_Response1.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.txt_Response1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txt_Response1.HoverState.ForeColor = System.Drawing.Color.Blue
        Me.txt_Response1.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Response1.Location = New System.Drawing.Point(24, 228)
        Me.txt_Response1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Response1.MaxLength = 50
        Me.txt_Response1.Name = "txt_Response1"
        Me.txt_Response1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Response1.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txt_Response1.PlaceholderText = "Response"
        Me.txt_Response1.SelectedText = ""
        Me.txt_Response1.Size = New System.Drawing.Size(568, 36)
        Me.txt_Response1.TabIndex = 54
        '
        'Cmb_Question3
        '
        Me.Cmb_Question3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmb_Question3.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_Question3.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question3.BorderRadius = 5
        Me.Cmb_Question3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_Question3.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question3.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question3.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Question3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_Question3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_Question3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Question3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question3.FocusedColor = System.Drawing.Color.BlueViolet
        Me.Cmb_Question3.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_Question3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_Question3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_Question3.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_Question3.ItemHeight = 30
        Me.Cmb_Question3.Items.AddRange(New Object() {"Select a 'WH' Question ", "Which locality did you grow up in ?", "What is your mother's middle name ?", "What was your childhood nickname ?", "What was the name of the first school you attended ?", "What was your favorite highschool teacher ?"})
        Me.Cmb_Question3.Location = New System.Drawing.Point(24, 410)
        Me.Cmb_Question3.Name = "Cmb_Question3"
        Me.Cmb_Question3.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_Question3.Size = New System.Drawing.Size(568, 36)
        Me.Cmb_Question3.TabIndex = 52
        '
        'Lbl_Title
        '
        Me.Lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Title.AutoSize = False
        Me.Lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Title.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.BlueViolet
        Me.Lbl_Title.Location = New System.Drawing.Point(24, 106)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(568, 39)
        Me.Lbl_Title.TabIndex = 53
        Me.Lbl_Title.Text = "Choose the Security Questions to help in password recovery" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_Question2
        '
        Me.Cmb_Question2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmb_Question2.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_Question2.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question2.BorderRadius = 5
        Me.Cmb_Question2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_Question2.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question2.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question2.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Question2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_Question2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_Question2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Question2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question2.FocusedColor = System.Drawing.Color.BlueViolet
        Me.Cmb_Question2.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_Question2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_Question2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_Question2.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_Question2.ItemHeight = 30
        Me.Cmb_Question2.Items.AddRange(New Object() {"Select a 'WH' Question ", "Which locality did you grow up in ?", "What is your mother's middle name ?", "What was your childhood nickname ?", "What was the name of the first school you attended ?", "What was your favorite highschool teacher ?"})
        Me.Cmb_Question2.Location = New System.Drawing.Point(24, 291)
        Me.Cmb_Question2.Name = "Cmb_Question2"
        Me.Cmb_Question2.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_Question2.Size = New System.Drawing.Size(568, 36)
        Me.Cmb_Question2.TabIndex = 52
        '
        'Cmb_Question1
        '
        Me.Cmb_Question1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cmb_Question1.BackColor = System.Drawing.Color.Transparent
        Me.Cmb_Question1.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question1.BorderRadius = 5
        Me.Cmb_Question1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_Question1.DisabledState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question1.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question1.DisabledState.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Question1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_Question1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cmb_Question1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Question1.Enabled = False
        Me.Cmb_Question1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Cmb_Question1.FocusedColor = System.Drawing.Color.BlueViolet
        Me.Cmb_Question1.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Cmb_Question1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Cmb_Question1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Cmb_Question1.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Cmb_Question1.ItemHeight = 30
        Me.Cmb_Question1.Items.AddRange(New Object() {"Select a 'WH' Question ", "Which locality did you grow up in ?", "What is your mother's middle name ?", "What was your childhood nickname ?", "What was the name of the first school you attended ?", "What was your favorite highschool teacher ?"})
        Me.Cmb_Question1.Location = New System.Drawing.Point(24, 169)
        Me.Cmb_Question1.Name = "Cmb_Question1"
        Me.Cmb_Question1.ShadowDecoration.Color = System.Drawing.Color.BlueViolet
        Me.Cmb_Question1.Size = New System.Drawing.Size(568, 36)
        Me.Cmb_Question1.TabIndex = 52
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.Silver
        Me.Panel_Top.Controls.Add(Me.Btn_Minimize)
        Me.Panel_Top.Controls.Add(Me.Btn_Maximize)
        Me.Panel_Top.Controls.Add(Me.Btn_Exit)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1141, 41)
        Me.Panel_Top.TabIndex = 58
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.Animated = True
        Me.Btn_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.BorderRadius = 5
        Me.Btn_Minimize.BorderThickness = 1
        Me.Btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Minimize.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Minimize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Minimize.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Btn_Minimize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.minimize
        Me.Btn_Minimize.Location = New System.Drawing.Point(1012, 0)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Minimize.Size = New System.Drawing.Size(43, 41)
        Me.Btn_Minimize.TabIndex = 19
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Animated = True
        Me.Btn_Maximize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.BorderRadius = 5
        Me.Btn_Maximize.BorderThickness = 1
        Me.Btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Maximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Maximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Maximize.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.Font = New System.Drawing.Font("Castellar", 14.25!)
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Maximize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Maximize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.maximize
        Me.Btn_Maximize.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_Maximize.Location = New System.Drawing.Point(1055, 0)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Maximize.Size = New System.Drawing.Size(43, 41)
        Me.Btn_Maximize.TabIndex = 18
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Animated = True
        Me.Btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.BorderRadius = 5
        Me.Btn_Exit.BorderThickness = 1
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Exit.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.ForeColor = System.Drawing.Color.Black
        Me.Btn_Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Exit.HoverState.ForeColor = System.Drawing.Color.White
        Me.Btn_Exit.Location = New System.Drawing.Point(1098, 0)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Exit.Size = New System.Drawing.Size(43, 41)
        Me.Btn_Exit.TabIndex = 17
        Me.Btn_Exit.Text = "X"
        '
        'AccountRecovery
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Panel_Top)
        Me.Controls.Add(Me.Panel_Holder)
        Me.Name = "AccountRecovery"
        Me.Size = New System.Drawing.Size(1141, 741)
        Me.Panel_Holder.ResumeLayout(False)
        Me.Panel_Top.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Lbl_Title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Cmb_Question1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_Response1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Response3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Response2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Cmb_Question3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Cmb_Question2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Cmb_UserID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Btn_RecoverAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Top As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Maximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
End Class
