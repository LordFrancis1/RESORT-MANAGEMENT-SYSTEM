<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomStatusDialog
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
        Me.Panel_Bottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_Title = New Guna.UI2.WinForms.Guna2Panel()
        Me.Pic_Room = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Lbl_Inform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip_Exit = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2Panel()
        Me.Lbl_RoomType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_RoomDescription = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_RoomPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl_NumberOfRooms = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel_TopMenu.SuspendLayout()
        Me.Panel_Title.SuspendLayout()
        CType(Me.Pic_Room, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Holder.SuspendLayout()
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
        Me.Panel_TopMenu.Size = New System.Drawing.Size(680, 30)
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
        Me.Btn_Exit.Location = New System.Drawing.Point(640, 0)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Exit.Size = New System.Drawing.Size(40, 30)
        Me.Btn_Exit.TabIndex = 5
        Me.Btn_Exit.Text = "X"
        Me.ToolTip_Exit.SetToolTip(Me.Btn_Exit, "Exit Dialog")
        '
        'Panel_Bottom
        '
        Me.Panel_Bottom.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Bottom.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Bottom.Location = New System.Drawing.Point(0, 363)
        Me.Panel_Bottom.Name = "Panel_Bottom"
        Me.Panel_Bottom.Size = New System.Drawing.Size(680, 40)
        Me.Panel_Bottom.TabIndex = 87
        Me.Panel_Bottom.UseTransparentBackground = True
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Title.Controls.Add(Me.Lbl_Inform)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Title.Location = New System.Drawing.Point(0, 30)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(680, 30)
        Me.Panel_Title.TabIndex = 88
        Me.Panel_Title.UseTransparentBackground = True
        '
        'Pic_Room
        '
        Me.Pic_Room.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pic_Room.FillColor = System.Drawing.Color.Silver
        Me.Pic_Room.ImageRotate = 0!
        Me.Pic_Room.Location = New System.Drawing.Point(0, 60)
        Me.Pic_Room.Name = "Pic_Room"
        Me.Pic_Room.Size = New System.Drawing.Size(340, 303)
        Me.Pic_Room.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Room.TabIndex = 89
        Me.Pic_Room.TabStop = False
        '
        'Lbl_Inform
        '
        Me.Lbl_Inform.AutoSize = False
        Me.Lbl_Inform.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Inform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Inform.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Inform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_Inform.Location = New System.Drawing.Point(194, 0)
        Me.Lbl_Inform.Name = "Lbl_Inform"
        Me.Lbl_Inform.Size = New System.Drawing.Size(482, 30)
        Me.Lbl_Inform.TabIndex = 20
        Me.Lbl_Inform.Text = "....."
        Me.Lbl_Inform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
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
        'Panel_Holder
        '
        Me.Panel_Holder.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Holder.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Holder.Controls.Add(Me.Lbl_NumberOfRooms)
        Me.Panel_Holder.Controls.Add(Me.Lbl_RoomPrice)
        Me.Panel_Holder.Controls.Add(Me.Lbl_RoomDescription)
        Me.Panel_Holder.Controls.Add(Me.Lbl_RoomType)
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.FillColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.Location = New System.Drawing.Point(340, 60)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(340, 303)
        Me.Panel_Holder.TabIndex = 90
        Me.Panel_Holder.UseTransparentBackground = True
        '
        'Lbl_RoomType
        '
        Me.Lbl_RoomType.AutoSize = False
        Me.Lbl_RoomType.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_RoomType.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_RoomType.Location = New System.Drawing.Point(15, 29)
        Me.Lbl_RoomType.Name = "Lbl_RoomType"
        Me.Lbl_RoomType.Size = New System.Drawing.Size(312, 30)
        Me.Lbl_RoomType.TabIndex = 21
        Me.Lbl_RoomType.Text = "Room Type"
        Me.Lbl_RoomType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_RoomDescription
        '
        Me.Lbl_RoomDescription.AutoSize = False
        Me.Lbl_RoomDescription.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_RoomDescription.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_RoomDescription.Location = New System.Drawing.Point(15, 78)
        Me.Lbl_RoomDescription.Name = "Lbl_RoomDescription"
        Me.Lbl_RoomDescription.Size = New System.Drawing.Size(312, 81)
        Me.Lbl_RoomDescription.TabIndex = 22
        Me.Lbl_RoomDescription.Text = "Room Description"
        Me.Lbl_RoomDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_RoomPrice
        '
        Me.Lbl_RoomPrice.AutoSize = False
        Me.Lbl_RoomPrice.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoomPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_RoomPrice.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoomPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_RoomPrice.Location = New System.Drawing.Point(15, 165)
        Me.Lbl_RoomPrice.Name = "Lbl_RoomPrice"
        Me.Lbl_RoomPrice.Size = New System.Drawing.Size(312, 30)
        Me.Lbl_RoomPrice.TabIndex = 23
        Me.Lbl_RoomPrice.Text = "Room Price"
        Me.Lbl_RoomPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_NumberOfRooms
        '
        Me.Lbl_NumberOfRooms.AutoSize = False
        Me.Lbl_NumberOfRooms.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_NumberOfRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_NumberOfRooms.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NumberOfRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Lbl_NumberOfRooms.Location = New System.Drawing.Point(15, 201)
        Me.Lbl_NumberOfRooms.Name = "Lbl_NumberOfRooms"
        Me.Lbl_NumberOfRooms.Size = New System.Drawing.Size(312, 30)
        Me.Lbl_NumberOfRooms.TabIndex = 24
        Me.Lbl_NumberOfRooms.Text = "Number Of Rooms"
        Me.Lbl_NumberOfRooms.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoomStatusDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Holder)
        Me.Controls.Add(Me.Pic_Room)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_Bottom)
        Me.Controls.Add(Me.Panel_TopMenu)
        Me.Name = "RoomStatusDialog"
        Me.Size = New System.Drawing.Size(680, 403)
        Me.Panel_TopMenu.ResumeLayout(False)
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.Pic_Room, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Holder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_TopMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_Bottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Pic_Room As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Lbl_Inform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip_Exit As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Lbl_NumberOfRooms As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomDescription As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl_RoomType As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
