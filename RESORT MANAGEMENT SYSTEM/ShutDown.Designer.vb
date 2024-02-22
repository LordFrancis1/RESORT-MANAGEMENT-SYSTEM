<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShutDown
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
        Me.Lbl_Title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Prg_ShuttingDown = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Lbl_Title
        '
        Me.Lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Title.AutoSize = False
        Me.Lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Lbl_Title.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Title.Location = New System.Drawing.Point(55, 468)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(1051, 30)
        Me.Lbl_Title.TabIndex = 15
        Me.Lbl_Title.Text = "Shutting Down Application..."
        Me.Lbl_Title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prg_ShuttingDown
        '
        Me.Prg_ShuttingDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Prg_ShuttingDown.Location = New System.Drawing.Point(495, 251)
        Me.Prg_ShuttingDown.Name = "Prg_ShuttingDown"
        Me.Prg_ShuttingDown.ProgressColor = System.Drawing.Color.BlueViolet
        Me.Prg_ShuttingDown.Size = New System.Drawing.Size(177, 154)
        Me.Prg_ShuttingDown.TabIndex = 16
        '
        'ShutDown
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Prg_ShuttingDown)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Name = "ShutDown"
        Me.Size = New System.Drawing.Size(1137, 747)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbl_Title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Prg_ShuttingDown As Guna.UI2.WinForms.Guna2WinProgressIndicator
End Class
