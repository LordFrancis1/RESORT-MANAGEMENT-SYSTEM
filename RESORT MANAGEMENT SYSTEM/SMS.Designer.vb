<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMS
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
        Me.Tab_Messaging = New Guna.UI2.WinForms.Guna2TabControl()
        Me.Page_Email = New System.Windows.Forms.TabPage()
        Me.Page_SMS = New System.Windows.Forms.TabPage()
        Me.Tab_Messaging.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Messaging
        '
        Me.Tab_Messaging.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab_Messaging.Controls.Add(Me.Page_Email)
        Me.Tab_Messaging.Controls.Add(Me.Page_SMS)
        Me.Tab_Messaging.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tab_Messaging.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Messaging.ItemSize = New System.Drawing.Size(120, 35)
        Me.Tab_Messaging.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Messaging.Margin = New System.Windows.Forms.Padding(0)
        Me.Tab_Messaging.Name = "Tab_Messaging"
        Me.Tab_Messaging.SelectedIndex = 0
        Me.Tab_Messaging.ShowToolTips = True
        Me.Tab_Messaging.Size = New System.Drawing.Size(1141, 746)
        Me.Tab_Messaging.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Messaging.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Messaging.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Messaging.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Tab_Messaging.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Tab_Messaging.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Messaging.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Messaging.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Messaging.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Tab_Messaging.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Tab_Messaging.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Messaging.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Tab_Messaging.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Tab_Messaging.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Tab_Messaging.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Tab_Messaging.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tab_Messaging.TabButtonSize = New System.Drawing.Size(120, 35)
        Me.Tab_Messaging.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Tab_Messaging.TabIndex = 15
        Me.Tab_Messaging.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'Page_Email
        '
        Me.Page_Email.BackColor = System.Drawing.Color.LightGray
        Me.Page_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_Email.Location = New System.Drawing.Point(124, 4)
        Me.Page_Email.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_Email.Name = "Page_Email"
        Me.Page_Email.Size = New System.Drawing.Size(1013, 738)
        Me.Page_Email.TabIndex = 0
        Me.Page_Email.Text = "E-Mail"
        '
        'Page_SMS
        '
        Me.Page_SMS.BackColor = System.Drawing.Color.LightGray
        Me.Page_SMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Page_SMS.Location = New System.Drawing.Point(124, 4)
        Me.Page_SMS.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_SMS.Name = "Page_SMS"
        Me.Page_SMS.Size = New System.Drawing.Size(1015, 731)
        Me.Page_SMS.TabIndex = 1
        Me.Page_SMS.Text = "SMS"
        '
        'SMS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Tab_Messaging)
        Me.Name = "SMS"
        Me.Size = New System.Drawing.Size(1141, 746)
        Me.Tab_Messaging.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_Messaging As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents Page_Email As TabPage
    Friend WithEvents Page_SMS As TabPage
End Class
