<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestDueInDialog
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
        Me.Panel_Bottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_TopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_Exit = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_TopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Bottom
        '
        Me.Panel_Bottom.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Bottom.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel_Bottom.Location = New System.Drawing.Point(0, 347)
        Me.Panel_Bottom.Name = "Panel_Bottom"
        Me.Panel_Bottom.Size = New System.Drawing.Size(719, 38)
        Me.Panel_Bottom.TabIndex = 90
        Me.Panel_Bottom.UseTransparentBackground = True
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
        Me.Panel_TopMenu.Size = New System.Drawing.Size(719, 30)
        Me.Panel_TopMenu.TabIndex = 89
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
        Me.Btn_Exit.Location = New System.Drawing.Point(679, 0)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Exit.Size = New System.Drawing.Size(40, 30)
        Me.Btn_Exit.TabIndex = 4
        Me.Btn_Exit.Text = "X"
        '
        'GuestDueInDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Panel_Bottom)
        Me.Controls.Add(Me.Panel_TopMenu)
        Me.Name = "GuestDueInDialog"
        Me.Size = New System.Drawing.Size(719, 385)
        Me.Panel_TopMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Bottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_TopMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Btn_Exit As Guna.UI2.WinForms.Guna2Button
End Class
