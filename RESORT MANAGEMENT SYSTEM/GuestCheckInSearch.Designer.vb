<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestCheckInSearch
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
        Me.Panel_TopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Title = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_Slide = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_Title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Buttons = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Txt_ContactSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_TopMenu.SuspendLayout()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Slide.SuspendLayout()
        Me.Panel_Buttons.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel_TopMenu.Size = New System.Drawing.Size(850, 30)
        Me.Panel_TopMenu.TabIndex = 84
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
        Me.Btn_Exit.Location = New System.Drawing.Point(810, 0)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Exit.Size = New System.Drawing.Size(40, 30)
        Me.Btn_Exit.TabIndex = 4
        Me.Btn_Exit.Text = "X"
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Exit, "Exit Module")
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Title.Controls.Add(Me.Panel_Slide)
        Me.Panel_Title.Controls.Add(Me.Lbl_Title)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Title.Location = New System.Drawing.Point(0, 30)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(850, 32)
        Me.Panel_Title.TabIndex = 85
        Me.Panel_Title.UseTransparentBackground = True
        '
        'Panel_Slide
        '
        Me.Panel_Slide.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Slide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Slide.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Slide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Slide.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Slide.Location = New System.Drawing.Point(186, 0)
        Me.Panel_Slide.Name = "Panel_Slide"
        Me.Panel_Slide.Size = New System.Drawing.Size(664, 32)
        Me.Panel_Slide.TabIndex = 86
        Me.Panel_Slide.UseTransparentBackground = True
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Inform.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Inform.Location = New System.Drawing.Point(182, 1)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(482, 30)
        Me.Lbl_Inform.TabIndex = 18
        Me.Lbl_Inform.Text = "Enter the Guest's  phone number to search for details..."
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Lbl_Title.Size = New System.Drawing.Size(186, 32)
        Me.Lbl_Title.TabIndex = 19
        Me.Lbl_Title.Text = "Already a Guest ?"
        Me.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Buttons
        '
        Me.Panel_Buttons.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Buttons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Buttons.Controls.Add(Me.Btn_Cancel)
        Me.Panel_Buttons.Controls.Add(Me.Btn_Save)
        Me.Panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Buttons.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Buttons.Location = New System.Drawing.Point(0, 790)
        Me.Panel_Buttons.Name = "Panel_Buttons"
        Me.Panel_Buttons.Size = New System.Drawing.Size(850, 60)
        Me.Panel_Buttons.TabIndex = 86
        Me.Panel_Buttons.UseTransparentBackground = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.Btn_Cancel.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Cancel.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancel.HoverState.ForeColor = System.Drawing.Color.Red
        Me.Btn_Cancel.Location = New System.Drawing.Point(595, 12)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.PressedColor = System.Drawing.Color.White
        Me.Btn_Cancel.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Cancel.TabIndex = 58
        Me.Btn_Cancel.Text = "CANCEL"
        '
        'Btn_Save
        '
        Me.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.Btn_Save.Location = New System.Drawing.Point(719, 12)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.PressedColor = System.Drawing.Color.White
        Me.Btn_Save.Size = New System.Drawing.Size(118, 36)
        Me.Btn_Save.TabIndex = 57
        Me.Btn_Save.Text = "CHECK IN"
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
        'Txt_ContactSearch
        '
        Me.Txt_ContactSearch.Animated = True
        Me.Txt_ContactSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_ContactSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Txt_ContactSearch.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_ContactSearch.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Txt_ContactSearch.DefaultText = ""
        Me.Txt_ContactSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_ContactSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_ContactSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_ContactSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_ContactSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_ContactSearch.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_ContactSearch.FocusedState.BorderColor = System.Drawing.Color.BlueViolet
        Me.Txt_ContactSearch.FocusedState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_ContactSearch.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_ContactSearch.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Txt_ContactSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_ContactSearch.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Txt_ContactSearch.HoverState.FillColor = System.Drawing.Color.Gainsboro
        Me.Txt_ContactSearch.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Txt_ContactSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_ContactSearch.Location = New System.Drawing.Point(0, 62)
        Me.Txt_ContactSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_ContactSearch.MaxLength = 10
        Me.Txt_ContactSearch.Name = "Txt_ContactSearch"
        Me.Txt_ContactSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ContactSearch.PlaceholderForeColor = System.Drawing.Color.Red
        Me.Txt_ContactSearch.PlaceholderText = "*Required ( Primary Contact Details )"
        Me.Txt_ContactSearch.SelectedText = ""
        Me.Txt_ContactSearch.Size = New System.Drawing.Size(850, 30)
        Me.Txt_ContactSearch.TabIndex = 90
        Me.Txt_ContactSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_Holder
        '
        Me.Panel_Holder.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.Location = New System.Drawing.Point(0, 92)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(850, 698)
        Me.Panel_Holder.TabIndex = 91
        Me.Panel_Holder.UseTransparentBackground = True
        '
        'GuestCheckInSearch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Holder)
        Me.Controls.Add(Me.Txt_ContactSearch)
        Me.Controls.Add(Me.Panel_Buttons)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_TopMenu)
        Me.Name = "GuestCheckInSearch"
        Me.Size = New System.Drawing.Size(850, 850)
        Me.Panel_TopMenu.ResumeLayout(False)
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Slide.ResumeLayout(False)
        Me.Panel_Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_TopMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_Title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_Title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel_Buttons As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_Slide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Btn_Cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Txt_ContactSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
End Class
