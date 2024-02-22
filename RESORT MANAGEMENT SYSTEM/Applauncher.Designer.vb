<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Applauncher
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
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Pic_HotelIcon = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Btn_Begin = New Guna.UI2.WinForms.Guna2Button()
        Me.Lbl_Top = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Prg_Launch = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_Holder.SuspendLayout()
        CType(Me.Pic_HotelIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 150
        '
        'Panel_Holder
        '
        Me.Panel_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Holder.BorderColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel_Holder.Controls.Add(Me.Pic_HotelIcon)
        Me.Panel_Holder.Controls.Add(Me.Btn_Begin)
        Me.Panel_Holder.Controls.Add(Me.Lbl_Top)
        Me.Panel_Holder.Controls.Add(Me.Prg_Launch)
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(1133, 645)
        Me.Panel_Holder.TabIndex = 0
        '
        'Pic_HotelIcon
        '
        Me.Pic_HotelIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_HotelIcon.FillColor = System.Drawing.Color.Transparent
        Me.Pic_HotelIcon.ImageRotate = 0!
        Me.Pic_HotelIcon.Location = New System.Drawing.Point(314, 196)
        Me.Pic_HotelIcon.Name = "Pic_HotelIcon"
        Me.Pic_HotelIcon.Size = New System.Drawing.Size(177, 132)
        Me.Pic_HotelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_HotelIcon.TabIndex = 5
        Me.Pic_HotelIcon.TabStop = False
        Me.Pic_HotelIcon.UseTransparentBackground = True
        '
        'Btn_Begin
        '
        Me.Btn_Begin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Begin.Animated = True
        Me.Btn_Begin.BorderColor = System.Drawing.Color.White
        Me.Btn_Begin.BorderRadius = 10
        Me.Btn_Begin.BorderThickness = 1
        Me.Btn_Begin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Begin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Begin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Begin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Begin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Begin.FillColor = System.Drawing.Color.MidnightBlue
        Me.Btn_Begin.Font = New System.Drawing.Font("Trebuchet MS", 15.75!)
        Me.Btn_Begin.ForeColor = System.Drawing.Color.White
        Me.Btn_Begin.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Btn_Begin.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Btn_Begin.HoverState.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Begin.HoverState.ForeColor = System.Drawing.Color.Lime
        Me.Btn_Begin.Location = New System.Drawing.Point(314, 368)
        Me.Btn_Begin.Name = "Btn_Begin"
        Me.Btn_Begin.Size = New System.Drawing.Size(626, 45)
        Me.Btn_Begin.TabIndex = 4
        Me.Btn_Begin.Text = "...BEGIN APPLICATION..."
        '
        'Lbl_Top
        '
        Me.Lbl_Top.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Top.AutoSize = False
        Me.Lbl_Top.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Top.Font = New System.Drawing.Font("Garamond", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Top.ForeColor = System.Drawing.Color.White
        Me.Lbl_Top.Location = New System.Drawing.Point(497, 196)
        Me.Lbl_Top.Name = "Lbl_Top"
        Me.Lbl_Top.Size = New System.Drawing.Size(443, 76)
        Me.Lbl_Top.TabIndex = 1
        Me.Lbl_Top.Text = "HOTEL"
        Me.Lbl_Top.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Prg_Launch
        '
        Me.Prg_Launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Prg_Launch.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Prg_Launch.BorderRadius = 5
        Me.Prg_Launch.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Prg_Launch.FillColor = System.Drawing.Color.Transparent
        Me.Prg_Launch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prg_Launch.ForeColor = System.Drawing.Color.White
        Me.Prg_Launch.Location = New System.Drawing.Point(0, 626)
        Me.Prg_Launch.Name = "Prg_Launch"
        Me.Prg_Launch.ProgressColor = System.Drawing.Color.MidnightBlue
        Me.Prg_Launch.ProgressColor2 = System.Drawing.Color.MidnightBlue
        Me.Prg_Launch.ShowText = True
        Me.Prg_Launch.Size = New System.Drawing.Size(1133, 19)
        Me.Prg_Launch.TabIndex = 0
        Me.Prg_Launch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Prg_Launch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(497, 287)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(443, 41)
        Me.Guna2HtmlLabel1.TabIndex = 6
        Me.Guna2HtmlLabel1.Text = "MANAGEMENT APPLICATION SOFTWARE"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Applauncher
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Holder)
        Me.Name = "Applauncher"
        Me.Size = New System.Drawing.Size(1133, 645)
        Me.Panel_Holder.ResumeLayout(False)
        CType(Me.Pic_HotelIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Prg_Launch As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Lbl_Top As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Btn_Begin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Pic_HotelIcon As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
