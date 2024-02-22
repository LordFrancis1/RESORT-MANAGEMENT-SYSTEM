<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BantuAfricaResort_Calculator
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
        Me.lbl_title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_equation = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_answer = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panel_operators = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_add = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_divide = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_multiply = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_subtract = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_CE = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_backspace = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_equals = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_dp = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_negate = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_3 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_5 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_6 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_7 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_8 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_9 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_4 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_0 = New Guna.UI2.WinForms.Guna2Button()
        Me.tooltip_calculator = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_operators.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = False
        Me.lbl_title.BackColor = System.Drawing.Color.Gray
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(470, 25)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "|| Standard Calculator"
        Me.lbl_title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.tooltip_calculator.SetToolTip(Me.lbl_title, "Bantu Africa Resort System Calculator")
        '
        'lbl_equation
        '
        Me.lbl_equation.AutoSize = False
        Me.lbl_equation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_equation.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_equation.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_equation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_equation.Location = New System.Drawing.Point(0, 25)
        Me.lbl_equation.Name = "lbl_equation"
        Me.lbl_equation.Size = New System.Drawing.Size(470, 37)
        Me.lbl_equation.TabIndex = 1
        Me.lbl_equation.Text = "Equation..."
        Me.lbl_equation.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_answer
        '
        Me.lbl_answer.AutoSize = False
        Me.lbl_answer.BackColor = System.Drawing.Color.Silver
        Me.lbl_answer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_answer.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_answer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_answer.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_answer.Location = New System.Drawing.Point(0, 62)
        Me.lbl_answer.Name = "lbl_answer"
        Me.lbl_answer.Size = New System.Drawing.Size(470, 49)
        Me.lbl_answer.TabIndex = 2
        Me.lbl_answer.Text = "B.A.R.M.I.S Calculator"
        Me.lbl_answer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_operators
        '
        Me.panel_operators.BackColor = System.Drawing.Color.Transparent
        Me.panel_operators.Controls.Add(Me.btn_add)
        Me.panel_operators.Controls.Add(Me.btn_divide)
        Me.panel_operators.Controls.Add(Me.btn_multiply)
        Me.panel_operators.Controls.Add(Me.btn_subtract)
        Me.panel_operators.Controls.Add(Me.btn_CE)
        Me.panel_operators.Controls.Add(Me.btn_delete)
        Me.panel_operators.Controls.Add(Me.btn_backspace)
        Me.panel_operators.Controls.Add(Me.btn_equals)
        Me.panel_operators.Controls.Add(Me.btn_dp)
        Me.panel_operators.Controls.Add(Me.btn_negate)
        Me.panel_operators.Controls.Add(Me.btn_1)
        Me.panel_operators.Controls.Add(Me.btn_2)
        Me.panel_operators.Controls.Add(Me.btn_3)
        Me.panel_operators.Controls.Add(Me.btn_5)
        Me.panel_operators.Controls.Add(Me.btn_6)
        Me.panel_operators.Controls.Add(Me.btn_7)
        Me.panel_operators.Controls.Add(Me.btn_8)
        Me.panel_operators.Controls.Add(Me.btn_9)
        Me.panel_operators.Controls.Add(Me.btn_4)
        Me.panel_operators.Controls.Add(Me.btn_0)
        Me.panel_operators.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_operators.FillColor = System.Drawing.Color.Gray
        Me.panel_operators.FillColor2 = System.Drawing.Color.Transparent
        Me.panel_operators.Location = New System.Drawing.Point(0, 111)
        Me.panel_operators.Name = "panel_operators"
        Me.panel_operators.Size = New System.Drawing.Size(470, 309)
        Me.panel_operators.TabIndex = 3
        Me.panel_operators.UseTransparentBackground = True
        '
        'btn_add
        '
        Me.btn_add.BorderRadius = 10
        Me.btn_add.BorderThickness = 1
        Me.btn_add.CheckedState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_add.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_add.CheckedState.FillColor2 = System.Drawing.Color.DimGray
        Me.btn_add.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btn_add.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.Black
        Me.btn_add.DisabledState.FillColor = System.Drawing.Color.Maroon
        Me.btn_add.DisabledState.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_add.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btn_add.FillColor = System.Drawing.Color.Maroon
        Me.btn_add.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_add.FocusedColor = System.Drawing.Color.Transparent
        Me.btn_add.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_add.Location = New System.Drawing.Point(363, 71)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(95, 40)
        Me.btn_add.TabIndex = 23
        Me.btn_add.Text = "+"
        Me.tooltip_calculator.SetToolTip(Me.btn_add, "Operator : Add")
        Me.btn_add.UseTransparentBackground = True
        '
        'btn_divide
        '
        Me.btn_divide.BorderRadius = 10
        Me.btn_divide.BorderThickness = 1
        Me.btn_divide.CheckedState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_divide.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_divide.CheckedState.FillColor2 = System.Drawing.Color.DimGray
        Me.btn_divide.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btn_divide.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btn_divide.DisabledState.CustomBorderColor = System.Drawing.Color.Black
        Me.btn_divide.DisabledState.FillColor = System.Drawing.Color.Maroon
        Me.btn_divide.DisabledState.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_divide.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btn_divide.FillColor = System.Drawing.Color.Maroon
        Me.btn_divide.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_divide.FocusedColor = System.Drawing.Color.Transparent
        Me.btn_divide.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_divide.ForeColor = System.Drawing.Color.White
        Me.btn_divide.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_divide.Location = New System.Drawing.Point(363, 253)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(95, 40)
        Me.btn_divide.TabIndex = 22
        Me.btn_divide.Text = "/"
        Me.tooltip_calculator.SetToolTip(Me.btn_divide, "Operator : Divide")
        Me.btn_divide.UseTransparentBackground = True
        '
        'btn_multiply
        '
        Me.btn_multiply.BorderRadius = 10
        Me.btn_multiply.BorderThickness = 1
        Me.btn_multiply.CheckedState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_multiply.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_multiply.CheckedState.FillColor2 = System.Drawing.Color.DimGray
        Me.btn_multiply.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btn_multiply.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btn_multiply.DisabledState.CustomBorderColor = System.Drawing.Color.Black
        Me.btn_multiply.DisabledState.FillColor = System.Drawing.Color.Maroon
        Me.btn_multiply.DisabledState.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_multiply.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btn_multiply.FillColor = System.Drawing.Color.Maroon
        Me.btn_multiply.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_multiply.FocusedColor = System.Drawing.Color.Transparent
        Me.btn_multiply.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiply.ForeColor = System.Drawing.Color.White
        Me.btn_multiply.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_multiply.Location = New System.Drawing.Point(363, 195)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(95, 40)
        Me.btn_multiply.TabIndex = 21
        Me.btn_multiply.Text = "X"
        Me.tooltip_calculator.SetToolTip(Me.btn_multiply, "Operator : Multiply")
        Me.btn_multiply.UseTransparentBackground = True
        '
        'btn_subtract
        '
        Me.btn_subtract.BorderRadius = 10
        Me.btn_subtract.BorderThickness = 1
        Me.btn_subtract.CheckedState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_subtract.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_subtract.CheckedState.FillColor2 = System.Drawing.Color.DimGray
        Me.btn_subtract.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btn_subtract.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btn_subtract.DisabledState.CustomBorderColor = System.Drawing.Color.Black
        Me.btn_subtract.DisabledState.FillColor = System.Drawing.Color.Maroon
        Me.btn_subtract.DisabledState.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_subtract.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btn_subtract.FillColor = System.Drawing.Color.Maroon
        Me.btn_subtract.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_subtract.FocusedColor = System.Drawing.Color.Transparent
        Me.btn_subtract.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_subtract.ForeColor = System.Drawing.Color.White
        Me.btn_subtract.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_subtract.Location = New System.Drawing.Point(363, 135)
        Me.btn_subtract.Name = "btn_subtract"
        Me.btn_subtract.Size = New System.Drawing.Size(95, 40)
        Me.btn_subtract.TabIndex = 20
        Me.btn_subtract.Text = "-"
        Me.tooltip_calculator.SetToolTip(Me.btn_subtract, "Operator : Subtract")
        Me.btn_subtract.UseTransparentBackground = True
        '
        'btn_CE
        '
        Me.btn_CE.BorderColor = System.Drawing.Color.Maroon
        Me.btn_CE.BorderRadius = 10
        Me.btn_CE.BorderThickness = 1
        Me.btn_CE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_CE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_CE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_CE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_CE.FillColor = System.Drawing.Color.Transparent
        Me.btn_CE.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!)
        Me.btn_CE.ForeColor = System.Drawing.Color.Black
        Me.btn_CE.Location = New System.Drawing.Point(13, 15)
        Me.btn_CE.Name = "btn_CE"
        Me.btn_CE.Size = New System.Drawing.Size(53, 40)
        Me.btn_CE.TabIndex = 19
        Me.btn_CE.Text = "CE"
        '
        'btn_delete
        '
        Me.btn_delete.BorderColor = System.Drawing.Color.Maroon
        Me.btn_delete.BorderRadius = 10
        Me.btn_delete.BorderThickness = 1
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.Transparent
        Me.btn_delete.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(198, 15)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(120, 40)
        Me.btn_delete.TabIndex = 18
        Me.btn_delete.Text = "Delete"
        '
        'btn_backspace
        '
        Me.btn_backspace.BorderColor = System.Drawing.Color.Maroon
        Me.btn_backspace.BorderRadius = 10
        Me.btn_backspace.BorderThickness = 1
        Me.btn_backspace.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_backspace.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_backspace.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_backspace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_backspace.FillColor = System.Drawing.Color.Transparent
        Me.btn_backspace.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backspace.ForeColor = System.Drawing.Color.Black
        Me.btn_backspace.Location = New System.Drawing.Point(72, 15)
        Me.btn_backspace.Name = "btn_backspace"
        Me.btn_backspace.Size = New System.Drawing.Size(120, 40)
        Me.btn_backspace.TabIndex = 17
        Me.btn_backspace.Text = "BackSpace"
        '
        'btn_equals
        '
        Me.btn_equals.BorderRadius = 10
        Me.btn_equals.BorderThickness = 1
        Me.btn_equals.CheckedState.BorderColor = System.Drawing.Color.Maroon
        Me.btn_equals.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btn_equals.CheckedState.FillColor2 = System.Drawing.Color.DimGray
        Me.btn_equals.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btn_equals.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btn_equals.DisabledState.CustomBorderColor = System.Drawing.Color.Black
        Me.btn_equals.DisabledState.FillColor = System.Drawing.Color.Maroon
        Me.btn_equals.DisabledState.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_equals.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btn_equals.FillColor = System.Drawing.Color.Maroon
        Me.btn_equals.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_equals.FocusedColor = System.Drawing.Color.Transparent
        Me.btn_equals.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equals.ForeColor = System.Drawing.Color.White
        Me.btn_equals.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_equals.Location = New System.Drawing.Point(363, 15)
        Me.btn_equals.Name = "btn_equals"
        Me.btn_equals.Size = New System.Drawing.Size(95, 40)
        Me.btn_equals.TabIndex = 16
        Me.btn_equals.Text = "="
        Me.tooltip_calculator.SetToolTip(Me.btn_equals, "Operator : Assign")
        Me.btn_equals.UseTransparentBackground = True
        '
        'btn_dp
        '
        Me.btn_dp.BorderColor = System.Drawing.Color.White
        Me.btn_dp.BorderRadius = 10
        Me.btn_dp.BorderThickness = 1
        Me.btn_dp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_dp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_dp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_dp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_dp.FillColor = System.Drawing.Color.Transparent
        Me.btn_dp.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dp.ForeColor = System.Drawing.Color.Maroon
        Me.btn_dp.Location = New System.Drawing.Point(13, 253)
        Me.btn_dp.Name = "btn_dp"
        Me.btn_dp.Size = New System.Drawing.Size(91, 40)
        Me.btn_dp.TabIndex = 12
        Me.btn_dp.Text = "."
        Me.tooltip_calculator.SetToolTip(Me.btn_dp, "Decimal Point")
        '
        'btn_negate
        '
        Me.btn_negate.BorderColor = System.Drawing.Color.White
        Me.btn_negate.BorderRadius = 10
        Me.btn_negate.BorderThickness = 1
        Me.btn_negate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_negate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_negate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_negate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_negate.FillColor = System.Drawing.Color.Transparent
        Me.btn_negate.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_negate.ForeColor = System.Drawing.Color.Maroon
        Me.btn_negate.Location = New System.Drawing.Point(227, 253)
        Me.btn_negate.Name = "btn_negate"
        Me.btn_negate.Size = New System.Drawing.Size(91, 40)
        Me.btn_negate.TabIndex = 11
        Me.btn_negate.Text = "+/_"
        Me.tooltip_calculator.SetToolTip(Me.btn_negate, "Negate")
        '
        'btn_1
        '
        Me.btn_1.Animated = True
        Me.btn_1.BorderColor = System.Drawing.Color.White
        Me.btn_1.BorderRadius = 10
        Me.btn_1.BorderThickness = 1
        Me.btn_1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_1.FillColor = System.Drawing.Color.Transparent
        Me.btn_1.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_1.ForeColor = System.Drawing.Color.Maroon
        Me.btn_1.Location = New System.Drawing.Point(13, 195)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(91, 40)
        Me.btn_1.TabIndex = 10
        Me.btn_1.Text = "1"
        '
        'btn_2
        '
        Me.btn_2.Animated = True
        Me.btn_2.BorderColor = System.Drawing.Color.White
        Me.btn_2.BorderRadius = 10
        Me.btn_2.BorderThickness = 1
        Me.btn_2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_2.FillColor = System.Drawing.Color.Transparent
        Me.btn_2.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_2.ForeColor = System.Drawing.Color.Maroon
        Me.btn_2.Location = New System.Drawing.Point(121, 195)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(91, 40)
        Me.btn_2.TabIndex = 9
        Me.btn_2.Text = "2"
        '
        'btn_3
        '
        Me.btn_3.Animated = True
        Me.btn_3.BorderColor = System.Drawing.Color.White
        Me.btn_3.BorderRadius = 10
        Me.btn_3.BorderThickness = 1
        Me.btn_3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_3.FillColor = System.Drawing.Color.Transparent
        Me.btn_3.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_3.ForeColor = System.Drawing.Color.Maroon
        Me.btn_3.Location = New System.Drawing.Point(227, 195)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(91, 40)
        Me.btn_3.TabIndex = 8
        Me.btn_3.Text = "3"
        '
        'btn_5
        '
        Me.btn_5.Animated = True
        Me.btn_5.BorderColor = System.Drawing.Color.White
        Me.btn_5.BorderRadius = 10
        Me.btn_5.BorderThickness = 1
        Me.btn_5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_5.FillColor = System.Drawing.Color.Transparent
        Me.btn_5.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_5.ForeColor = System.Drawing.Color.Maroon
        Me.btn_5.Location = New System.Drawing.Point(121, 135)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(91, 40)
        Me.btn_5.TabIndex = 7
        Me.btn_5.Text = "5"
        '
        'btn_6
        '
        Me.btn_6.Animated = True
        Me.btn_6.BorderColor = System.Drawing.Color.White
        Me.btn_6.BorderRadius = 10
        Me.btn_6.BorderThickness = 1
        Me.btn_6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_6.FillColor = System.Drawing.Color.Transparent
        Me.btn_6.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_6.ForeColor = System.Drawing.Color.Maroon
        Me.btn_6.Location = New System.Drawing.Point(227, 135)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(91, 40)
        Me.btn_6.TabIndex = 6
        Me.btn_6.Text = "6"
        '
        'btn_7
        '
        Me.btn_7.Animated = True
        Me.btn_7.BorderColor = System.Drawing.Color.White
        Me.btn_7.BorderRadius = 10
        Me.btn_7.BorderThickness = 1
        Me.btn_7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_7.FillColor = System.Drawing.Color.Transparent
        Me.btn_7.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_7.ForeColor = System.Drawing.Color.Maroon
        Me.btn_7.Location = New System.Drawing.Point(13, 71)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(91, 40)
        Me.btn_7.TabIndex = 5
        Me.btn_7.Text = "7"
        '
        'btn_8
        '
        Me.btn_8.Animated = True
        Me.btn_8.BorderColor = System.Drawing.Color.White
        Me.btn_8.BorderRadius = 10
        Me.btn_8.BorderThickness = 1
        Me.btn_8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_8.FillColor = System.Drawing.Color.Transparent
        Me.btn_8.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_8.ForeColor = System.Drawing.Color.Maroon
        Me.btn_8.Location = New System.Drawing.Point(121, 71)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(91, 40)
        Me.btn_8.TabIndex = 4
        Me.btn_8.Text = "8"
        '
        'btn_9
        '
        Me.btn_9.Animated = True
        Me.btn_9.BorderColor = System.Drawing.Color.White
        Me.btn_9.BorderRadius = 10
        Me.btn_9.BorderThickness = 1
        Me.btn_9.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_9.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_9.FillColor = System.Drawing.Color.Transparent
        Me.btn_9.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_9.ForeColor = System.Drawing.Color.Maroon
        Me.btn_9.Location = New System.Drawing.Point(227, 71)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(91, 40)
        Me.btn_9.TabIndex = 3
        Me.btn_9.Text = "9"
        '
        'btn_4
        '
        Me.btn_4.Animated = True
        Me.btn_4.BorderColor = System.Drawing.Color.White
        Me.btn_4.BorderRadius = 10
        Me.btn_4.BorderThickness = 1
        Me.btn_4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_4.FillColor = System.Drawing.Color.Transparent
        Me.btn_4.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!)
        Me.btn_4.ForeColor = System.Drawing.Color.Maroon
        Me.btn_4.Location = New System.Drawing.Point(13, 135)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(91, 40)
        Me.btn_4.TabIndex = 2
        Me.btn_4.Text = "4"
        '
        'btn_0
        '
        Me.btn_0.Animated = True
        Me.btn_0.BorderColor = System.Drawing.Color.White
        Me.btn_0.BorderRadius = 10
        Me.btn_0.BorderThickness = 1
        Me.btn_0.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_0.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_0.FillColor = System.Drawing.Color.Transparent
        Me.btn_0.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.ForeColor = System.Drawing.Color.Maroon
        Me.btn_0.Location = New System.Drawing.Point(121, 253)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(91, 40)
        Me.btn_0.TabIndex = 0
        Me.btn_0.Text = "0"
        '
        'tooltip_calculator
        '
        Me.tooltip_calculator.AllowLinksHandling = True
        Me.tooltip_calculator.BackColor = System.Drawing.Color.Silver
        Me.tooltip_calculator.BorderColor = System.Drawing.Color.DimGray
        Me.tooltip_calculator.ForeColor = System.Drawing.Color.Maroon
        Me.tooltip_calculator.MaximumSize = New System.Drawing.Size(0, 0)
        Me.tooltip_calculator.TitleFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tooltip_calculator.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'BantuAfricaResort_Calculator
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.panel_operators)
        Me.Controls.Add(Me.lbl_answer)
        Me.Controls.Add(Me.lbl_equation)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "BantuAfricaResort_Calculator"
        Me.Size = New System.Drawing.Size(470, 420)
        Me.panel_operators.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_equation As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_answer As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panel_operators As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btn_7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_0 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_equals As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_dp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_negate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tooltip_calculator As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_backspace As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_CE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_add As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_divide As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_multiply As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_subtract As Guna.UI2.WinForms.Guna2GradientButton
End Class
