<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel_Holder = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'Timer2
        '
        Me.Timer2.Interval = 1200
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 900
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.BlueViolet
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Panel_Holder
        '
        Me.Panel_Holder.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Holder.BorderColor = System.Drawing.Color.Transparent
        Me.Panel_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Holder.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Holder.Name = "Panel_Holder"
        Me.Panel_Holder.Size = New System.Drawing.Size(1396, 854)
        Me.Panel_Holder.TabIndex = 1
        Me.Panel_Holder.UseTransparentBackground = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1396, 854)
        Me.Controls.Add(Me.Panel_Holder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel_Holder As Guna.UI2.WinForms.Guna2GradientPanel
End Class
