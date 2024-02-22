<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppIntroduction
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
        Me.Btn_Minimize = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Maximize = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Off = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel_Top = New Guna.UI2.WinForms.Guna2Panel()
        Me.FLP_Menu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Txt_TelephoneLine3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txt_TelephoneLine2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txt_TelephoneLine1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Btn_BrowseIcon = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Pic_Icon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txt_Location = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txt_HotelSlogan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txt_Address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txt_Email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txt_hotelname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ToolTip_Maximize = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ToolTip_Minimize = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Top.SuspendLayout()
        Me.FLP_Menu.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel_Holder.SuspendLayout()
        CType(Me.Pic_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimize.Animated = True
        Me.Btn_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Minimize.BorderColor = System.Drawing.Color.White
        Me.Btn_Minimize.BorderRadius = 5
        Me.Btn_Minimize.BorderThickness = 1
        Me.Btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Minimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Minimize.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Minimize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Minimize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Minimize.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Btn_Minimize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.minimize
        Me.Btn_Minimize.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Minimize.Size = New System.Drawing.Size(40, 34)
        Me.Btn_Minimize.TabIndex = 21
        Me.ToolTip_Minimize.SetToolTip(Me.Btn_Minimize, "Minimize")
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximize.Animated = True
        Me.Btn_Maximize.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Maximize.BorderColor = System.Drawing.Color.White
        Me.Btn_Maximize.BorderRadius = 5
        Me.Btn_Maximize.BorderThickness = 1
        Me.Btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Maximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Maximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Maximize.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Maximize.Font = New System.Drawing.Font("Castellar", 14.25!)
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.Black
        Me.Btn_Maximize.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Maximize.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Btn_Maximize.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.maximize
        Me.Btn_Maximize.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_Maximize.Location = New System.Drawing.Point(49, 3)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.PressedColor = System.Drawing.Color.Maroon
        Me.Btn_Maximize.Size = New System.Drawing.Size(40, 34)
        Me.Btn_Maximize.TabIndex = 20
        Me.ToolTip_Maximize.SetToolTip(Me.Btn_Maximize, "Maximize")
        '
        'Btn_Off
        '
        Me.Btn_Off.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Off.Animated = True
        Me.Btn_Off.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Off.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Off.BorderRadius = 5
        Me.Btn_Off.BorderThickness = 1
        Me.Btn_Off.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Off.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Off.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Off.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Off.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Off.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Off.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Btn_Off.ForeColor = System.Drawing.Color.Black
        Me.Btn_Off.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Off.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Btn_Off.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Btn_Off.Image = Global.RESORT_MANAGEMENT_SYSTEM.My.Resources.Resources.power_off
        Me.Btn_Off.ImageSize = New System.Drawing.Size(25, 25)
        Me.Btn_Off.Location = New System.Drawing.Point(95, 3)
        Me.Btn_Off.Name = "Btn_Off"
        Me.Btn_Off.Size = New System.Drawing.Size(40, 34)
        Me.Btn_Off.TabIndex = 19
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Off, "Exit Application")
        Me.Btn_Off.UseTransparentBackground = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Top.Controls.Add(Me.FLP_Menu)
        Me.Panel_Top.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1500, 40)
        Me.Panel_Top.TabIndex = 57
        '
        'FLP_Menu
        '
        Me.FLP_Menu.Controls.Add(Me.Btn_Minimize)
        Me.FLP_Menu.Controls.Add(Me.Btn_Maximize)
        Me.FLP_Menu.Controls.Add(Me.Btn_Off)
        Me.FLP_Menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.FLP_Menu.Location = New System.Drawing.Point(1360, 0)
        Me.FLP_Menu.Name = "FLP_Menu"
        Me.FLP_Menu.Size = New System.Drawing.Size(140, 40)
        Me.FLP_Menu.TabIndex = 67
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.White
        Me.Lbl_Inform.Location = New System.Drawing.Point(740, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(614, 36)
        Me.Lbl_Inform.TabIndex = 66
        Me.Lbl_Inform.Text = "The following hotel details are required to initialize the application. Kindly Fi" &
    "ll"
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.Btn_Save)
        Me.Guna2Panel1.Controls.Add(Me.Btn_Cancel)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 950)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1500, 50)
        Me.Guna2Panel1.TabIndex = 58
        '
        'Btn_Save
        '
        Me.Btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Btn_Save.HoverState.FillColor = System.Drawing.Color.White
        Me.Btn_Save.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.HoverState.ForeColor = System.Drawing.Color.Green
        Me.Btn_Save.Location = New System.Drawing.Point(1377, 8)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.PressedColor = System.Drawing.Color.White
        Me.Btn_Save.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Save.TabIndex = 55
        Me.Btn_Save.Text = "SAVE"
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancel.Animated = True
        Me.Btn_Cancel.BorderColor = System.Drawing.Color.White
        Me.Btn_Cancel.BorderRadius = 5
        Me.Btn_Cancel.BorderThickness = 1
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Cancel.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Cancel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancel.HoverState.BorderColor = System.Drawing.Color.Red
        Me.Btn_Cancel.HoverState.FillColor = System.Drawing.Color.White
        Me.Btn_Cancel.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.HoverState.ForeColor = System.Drawing.Color.Red
        Me.Btn_Cancel.Location = New System.Drawing.Point(1253, 8)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.PressedColor = System.Drawing.Color.BlueViolet
        Me.Btn_Cancel.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Cancel.TabIndex = 56
        Me.Btn_Cancel.Text = "CANCEL"
        '
        'Panel_Holder
        '
        Me.Panel_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Holder.BorderColor = System.Drawing.Color.White
        Me.Panel_Holder.BorderRadius = 5
        Me.Panel_Holder.BorderThickness = 1
        Me.Panel_Holder.Controls.Add(Me.Txt_TelephoneLine3)
        Me.Panel_Holder.Controls.Add(Me.Txt_TelephoneLine2)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Panel_Holder.Controls.Add(Me.Txt_TelephoneLine1)
        Me.Panel_Holder.Controls.Add(Me.Btn_BrowseIcon)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel_Holder.Controls.Add(Me.Pic_Icon)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel_Holder.Controls.Add(Me.Txt_Location)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel_Holder.Controls.Add(Me.Txt_HotelSlogan)
        Me.Panel_Holder.Controls.Add(Me.Txt_Address)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel_Holder.Controls.Add(Me.Txt_Email)
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel_Holder.Controls.Add(Me.Txt_hotelname)
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(1500, 910)
        Me.Panel_Holder.TabIndex = 59
        '
        'Txt_TelephoneLine3
        '
        Me.Txt_TelephoneLine3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_TelephoneLine3.Animated = True
        Me.Txt_TelephoneLine3.BackColor = System.Drawing.Color.White
        Me.Txt_TelephoneLine3.BorderColor = System.Drawing.Color.White
        Me.Txt_TelephoneLine3.BorderRadius = 5
        Me.Txt_TelephoneLine3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_TelephoneLine3.DefaultText = ""
        Me.Txt_TelephoneLine3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_TelephoneLine3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_TelephoneLine3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_TelephoneLine3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_TelephoneLine3.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_TelephoneLine3.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine3.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_TelephoneLine3.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_TelephoneLine3.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine3.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine3.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_TelephoneLine3.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine3.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_TelephoneLine3.Location = New System.Drawing.Point(928, 656)
        Me.Txt_TelephoneLine3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_TelephoneLine3.MaxLength = 10
        Me.Txt_TelephoneLine3.Name = "Txt_TelephoneLine3"
        Me.Txt_TelephoneLine3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_TelephoneLine3.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_TelephoneLine3.PlaceholderText = "Additional Contact"
        Me.Txt_TelephoneLine3.SelectedText = ""
        Me.Txt_TelephoneLine3.Size = New System.Drawing.Size(510, 36)
        Me.Txt_TelephoneLine3.TabIndex = 63
        '
        'Txt_TelephoneLine2
        '
        Me.Txt_TelephoneLine2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_TelephoneLine2.Animated = True
        Me.Txt_TelephoneLine2.BackColor = System.Drawing.Color.White
        Me.Txt_TelephoneLine2.BorderColor = System.Drawing.Color.White
        Me.Txt_TelephoneLine2.BorderRadius = 5
        Me.Txt_TelephoneLine2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_TelephoneLine2.DefaultText = ""
        Me.Txt_TelephoneLine2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_TelephoneLine2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_TelephoneLine2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_TelephoneLine2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_TelephoneLine2.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_TelephoneLine2.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine2.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_TelephoneLine2.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_TelephoneLine2.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine2.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_TelephoneLine2.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine2.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_TelephoneLine2.Location = New System.Drawing.Point(928, 556)
        Me.Txt_TelephoneLine2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_TelephoneLine2.MaxLength = 10
        Me.Txt_TelephoneLine2.Name = "Txt_TelephoneLine2"
        Me.Txt_TelephoneLine2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_TelephoneLine2.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Txt_TelephoneLine2.PlaceholderText = "Additional Contact"
        Me.Txt_TelephoneLine2.SelectedText = ""
        Me.Txt_TelephoneLine2.Size = New System.Drawing.Size(510, 36)
        Me.Txt_TelephoneLine2.TabIndex = 62
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel9.AutoSize = False
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Red
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(195, 382)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(510, 36)
        Me.Guna2HtmlLabel9.TabIndex = 65
        Me.Guna2HtmlLabel9.Text = "* Required"
        Me.Guna2HtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_TelephoneLine1
        '
        Me.Txt_TelephoneLine1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_TelephoneLine1.Animated = True
        Me.Txt_TelephoneLine1.BackColor = System.Drawing.Color.White
        Me.Txt_TelephoneLine1.BorderColor = System.Drawing.Color.White
        Me.Txt_TelephoneLine1.BorderRadius = 5
        Me.Txt_TelephoneLine1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_TelephoneLine1.DefaultText = ""
        Me.Txt_TelephoneLine1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_TelephoneLine1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_TelephoneLine1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_TelephoneLine1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_TelephoneLine1.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_TelephoneLine1.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine1.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_TelephoneLine1.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_TelephoneLine1.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine1.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_TelephoneLine1.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_TelephoneLine1.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_TelephoneLine1.Location = New System.Drawing.Point(928, 459)
        Me.Txt_TelephoneLine1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_TelephoneLine1.MaxLength = 10
        Me.Txt_TelephoneLine1.Name = "Txt_TelephoneLine1"
        Me.Txt_TelephoneLine1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_TelephoneLine1.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Txt_TelephoneLine1.PlaceholderText = "* Required"
        Me.Txt_TelephoneLine1.SelectedText = ""
        Me.Txt_TelephoneLine1.Size = New System.Drawing.Size(510, 36)
        Me.Txt_TelephoneLine1.TabIndex = 61
        '
        'Btn_BrowseIcon
        '
        Me.Btn_BrowseIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_BrowseIcon.Animated = True
        Me.Btn_BrowseIcon.BorderColor = System.Drawing.Color.White
        Me.Btn_BrowseIcon.BorderRadius = 5
        Me.Btn_BrowseIcon.BorderThickness = 1
        Me.Btn_BrowseIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BrowseIcon.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_BrowseIcon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_BrowseIcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_BrowseIcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_BrowseIcon.FillColor = System.Drawing.Color.Transparent
        Me.Btn_BrowseIcon.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.Btn_BrowseIcon.ForeColor = System.Drawing.Color.Black
        Me.Btn_BrowseIcon.HoverState.BorderColor = System.Drawing.Color.White
        Me.Btn_BrowseIcon.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Btn_BrowseIcon.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BrowseIcon.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_BrowseIcon.Location = New System.Drawing.Point(61, 459)
        Me.Btn_BrowseIcon.Name = "Btn_BrowseIcon"
        Me.Btn_BrowseIcon.PressedColor = System.Drawing.Color.White
        Me.Btn_BrowseIcon.Size = New System.Drawing.Size(264, 233)
        Me.Btn_BrowseIcon.TabIndex = 64
        Me.Btn_BrowseIcon.Text = "Browse Icon"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(745, 656)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(158, 36)
        Me.Guna2HtmlLabel6.TabIndex = 60
        Me.Guna2HtmlLabel6.Text = "Telephone Line 3"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_Icon
        '
        Me.Pic_Icon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_Icon.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Icon.BorderRadius = 5
        Me.Pic_Icon.FillColor = System.Drawing.Color.Gainsboro
        Me.Pic_Icon.ImageRotate = 0!
        Me.Pic_Icon.Location = New System.Drawing.Point(331, 459)
        Me.Pic_Icon.Name = "Pic_Icon"
        Me.Pic_Icon.Size = New System.Drawing.Size(374, 233)
        Me.Pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Icon.TabIndex = 63
        Me.Pic_Icon.TabStop = False
        Me.Pic_Icon.UseTransparentBackground = True
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(745, 556)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(158, 36)
        Me.Guna2HtmlLabel5.TabIndex = 59
        Me.Guna2HtmlLabel5.Text = "Telephone Line 2"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(61, 382)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(127, 36)
        Me.Guna2HtmlLabel8.TabIndex = 62
        Me.Guna2HtmlLabel8.Text = "Hotel  Icon"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(745, 459)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(158, 36)
        Me.Guna2HtmlLabel3.TabIndex = 58
        Me.Guna2HtmlLabel3.Text = "Telephone Line 1"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Location
        '
        Me.Txt_Location.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Location.Animated = True
        Me.Txt_Location.BackColor = System.Drawing.Color.White
        Me.Txt_Location.BorderColor = System.Drawing.Color.White
        Me.Txt_Location.BorderRadius = 5
        Me.Txt_Location.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Location.DefaultText = ""
        Me.Txt_Location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Location.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Location.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Location.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Location.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Location.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Location.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_Location.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Location.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Location.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Location.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Location.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Location.Location = New System.Drawing.Point(928, 382)
        Me.Txt_Location.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Location.MaxLength = 100
        Me.Txt_Location.Name = "Txt_Location"
        Me.Txt_Location.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Location.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Txt_Location.PlaceholderText = "* Required"
        Me.Txt_Location.SelectedText = ""
        Me.Txt_Location.Size = New System.Drawing.Size(510, 36)
        Me.Txt_Location.TabIndex = 61
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel10.AutoSize = False
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(745, 288)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(158, 36)
        Me.Guna2HtmlLabel10.TabIndex = 57
        Me.Guna2HtmlLabel10.Text = "Hotel  Address"
        Me.Guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(745, 205)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(158, 36)
        Me.Guna2HtmlLabel4.TabIndex = 57
        Me.Guna2HtmlLabel4.Text = "Hotel  Email"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel7.AutoSize = False
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(745, 382)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(158, 36)
        Me.Guna2HtmlLabel7.TabIndex = 60
        Me.Guna2HtmlLabel7.Text = "Hotel Location"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_HotelSlogan
        '
        Me.Txt_HotelSlogan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_HotelSlogan.Animated = True
        Me.Txt_HotelSlogan.BackColor = System.Drawing.Color.White
        Me.Txt_HotelSlogan.BorderColor = System.Drawing.Color.White
        Me.Txt_HotelSlogan.BorderRadius = 5
        Me.Txt_HotelSlogan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_HotelSlogan.DefaultText = ""
        Me.Txt_HotelSlogan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_HotelSlogan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_HotelSlogan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_HotelSlogan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_HotelSlogan.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_HotelSlogan.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_HotelSlogan.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_HotelSlogan.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_HotelSlogan.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_HotelSlogan.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_HotelSlogan.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_HotelSlogan.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_HotelSlogan.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_HotelSlogan.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_HotelSlogan.Location = New System.Drawing.Point(195, 288)
        Me.Txt_HotelSlogan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_HotelSlogan.MaxLength = 200
        Me.Txt_HotelSlogan.Name = "Txt_HotelSlogan"
        Me.Txt_HotelSlogan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_HotelSlogan.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Txt_HotelSlogan.PlaceholderText = "* Required"
        Me.Txt_HotelSlogan.SelectedText = ""
        Me.Txt_HotelSlogan.Size = New System.Drawing.Size(510, 36)
        Me.Txt_HotelSlogan.TabIndex = 59
        '
        'Txt_Address
        '
        Me.Txt_Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Address.Animated = True
        Me.Txt_Address.BackColor = System.Drawing.Color.White
        Me.Txt_Address.BorderColor = System.Drawing.Color.White
        Me.Txt_Address.BorderRadius = 5
        Me.Txt_Address.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Address.DefaultText = ""
        Me.Txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Address.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Address.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Address.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Address.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Address.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_Address.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Address.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Address.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Address.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Address.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Address.Location = New System.Drawing.Point(928, 288)
        Me.Txt_Address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Address.MaxLength = 50
        Me.Txt_Address.Name = "Txt_Address"
        Me.Txt_Address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Address.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Txt_Address.PlaceholderText = "* Required"
        Me.Txt_Address.SelectedText = ""
        Me.Txt_Address.Size = New System.Drawing.Size(510, 36)
        Me.Txt_Address.TabIndex = 54
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(61, 288)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(127, 36)
        Me.Guna2HtmlLabel2.TabIndex = 58
        Me.Guna2HtmlLabel2.Text = "Hotel Slogan"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Email
        '
        Me.Txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_Email.Animated = True
        Me.Txt_Email.BackColor = System.Drawing.Color.White
        Me.Txt_Email.BorderColor = System.Drawing.Color.White
        Me.Txt_Email.BorderRadius = 5
        Me.Txt_Email.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Email.DefaultText = ""
        Me.Txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Email.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_Email.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Email.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_Email.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.HoverState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.HoverState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Email.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_Email.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Email.Location = New System.Drawing.Point(928, 205)
        Me.Txt_Email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Email.MaxLength = 50
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Email.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Txt_Email.PlaceholderText = "* Required"
        Me.Txt_Email.SelectedText = ""
        Me.Txt_Email.Size = New System.Drawing.Size(510, 36)
        Me.Txt_Email.TabIndex = 54
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(61, 205)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(127, 36)
        Me.Guna2HtmlLabel1.TabIndex = 57
        Me.Guna2HtmlLabel1.Text = "Hotel  Name"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_hotelname
        '
        Me.Txt_hotelname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt_hotelname.Animated = True
        Me.Txt_hotelname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_hotelname.BorderColor = System.Drawing.Color.White
        Me.Txt_hotelname.BorderRadius = 5
        Me.Txt_hotelname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_hotelname.DefaultText = ""
        Me.Txt_hotelname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_hotelname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_hotelname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_hotelname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_hotelname.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_hotelname.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_hotelname.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_hotelname.FocusedState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_hotelname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_hotelname.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_hotelname.HoverState.BorderColor = System.Drawing.Color.White
        Me.Txt_hotelname.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Txt_hotelname.HoverState.ForeColor = System.Drawing.Color.BlueViolet
        Me.Txt_hotelname.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_hotelname.Location = New System.Drawing.Point(195, 205)
        Me.Txt_hotelname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_hotelname.MaxLength = 100
        Me.Txt_hotelname.Name = "Txt_hotelname"
        Me.Txt_hotelname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_hotelname.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Txt_hotelname.PlaceholderText = "* Required"
        Me.Txt_hotelname.SelectedText = ""
        Me.Txt_hotelname.Size = New System.Drawing.Size(510, 36)
        Me.Txt_hotelname.TabIndex = 54
        '
        'ToolTip_Maximize
        '
        Me.ToolTip_Maximize.AllowLinksHandling = True
        Me.ToolTip_Maximize.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolTip_Maximize.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Maximize.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Maximize.ForeColor = System.Drawing.Color.White
        Me.ToolTip_Maximize.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'ToolTip_Minimize
        '
        Me.ToolTip_Minimize.AllowLinksHandling = True
        Me.ToolTip_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolTip_Minimize.BorderColor = System.Drawing.Color.White
        Me.ToolTip_Minimize.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip_Minimize.ForeColor = System.Drawing.Color.Black
        Me.ToolTip_Minimize.MaximumSize = New System.Drawing.Size(0, 0)
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
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'AppIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.Panel_Holder)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel_Top)
        Me.Name = "AppIntroduction"
        Me.Size = New System.Drawing.Size(1500, 1000)
        Me.Panel_Top.ResumeLayout(False)
        Me.FLP_Menu.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel_Holder.ResumeLayout(False)
        CType(Me.Pic_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Minimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Maximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Off As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel_Top As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Txt_TelephoneLine3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txt_TelephoneLine2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Txt_TelephoneLine1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Btn_BrowseIcon As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Pic_Icon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Txt_Location As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Txt_HotelSlogan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txt_Address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Txt_Email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Txt_hotelname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ToolTip_Minimize As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_Maximize As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FLP_Menu As FlowLayoutPanel
End Class
