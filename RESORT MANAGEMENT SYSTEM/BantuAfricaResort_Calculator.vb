Public Class BantuAfricaResort_Calculator
    '||GLOBAL VARIABLES
    Dim Left_Operand As Integer, Right_Operand As Integer
    Dim O_perator As String
    Dim Left_Operand_and_Operator As String
    Dim Result As Double
    Dim History As String

    Private Sub BantuAfricaResort_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call initializer()
    End Sub
    Sub initializer()
        Call Disable_operators()

    End Sub
    Sub enable_operators()
        btn_equals.Enabled = True
        btn_add.Enabled = True
        btn_subtract.Enabled = True
        btn_multiply.Enabled = True
        btn_divide.Enabled = True
    End Sub
    Sub Disable_operators()
        btn_equals.Enabled = False
        btn_add.Enabled = False
        btn_subtract.Enabled = False
        btn_multiply.Enabled = False
        btn_divide.Enabled = False
    End Sub
    Sub clear_variables()
        Left_Operand = Nothing
        Right_Operand = Nothing
        O_perator = Nothing
        Left_Operand_and_Operator = Nothing
        Result = Nothing
        History = Nothing
    End Sub

    Private Sub btn_CE_Click(sender As Object, e As EventArgs) Handles btn_CE.Click
        lbl_equation.Font = New Font("Segoe Script", 14, FontStyle.Regular)
        lbl_equation.Text = "Equation..."
        lbl_answer.Text = "B.A.R.M.I.S Calculator"
        Call clear_variables()
        Call Disable_operators()
    End Sub

    Private Sub btn_backspace_Click(sender As Object, e As EventArgs) Handles btn_backspace.Click
        lbl_equation.Font = New Font("Segoe Script", 14, FontStyle.Regular)
        If (lbl_equation.Text.Length > 0) Then
            lbl_equation.Text = lbl_equation.Text.Remove(lbl_equation.Text.Length - 1, 1)
        End If
        If (lbl_equation.Text = "") Then
            lbl_equation.Text = "Equation..."
            Call Disable_operators()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        lbl_equation.Font = New Font("Segoe Script", 14, FontStyle.Regular)
        lbl_equation.Text = "Equation..."
        lbl_answer.Text = "B.A.R.M.I.S Calculator"
        Call clear_variables()
        Call Disable_operators()
    End Sub
    Private Sub btn_dp_Click(sender As Object, e As EventArgs) Handles btn_dp.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            lbl_equation.Text = btn_dp.Text
        ElseIf (lbl_equation.Text <> "Equation...") Then
            lbl_equation.Text = lbl_equation.Text + btn_dp.Text
        End If
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_0.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_0.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_0.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_0.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_1.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_1.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_1.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_1.Text

                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_2.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_2.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_2.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_2.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_3.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_3.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_3.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_3.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_4.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_4.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_4.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_4.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_5.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_5.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_5.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_5.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_6.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_6.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_6.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_6.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_7.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_7.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_7.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_7.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_8.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_8.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_8.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_8.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        If (lbl_equation.Text = "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = btn_9.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = btn_9.Text
                lbl_equation.Text = Right_Operand
            End If
        ElseIf (lbl_equation.Text <> "Equation...") Then
            If (O_perator = "") Then
                Left_Operand = Left_Operand & btn_9.Text
                lbl_equation.Text = Left_Operand
            ElseIf (O_perator <> "") Then
                Right_Operand = Right_Operand & btn_9.Text
                lbl_equation.Text = Right_Operand
            End If
        End If
        Call enable_operators()
    End Sub
    '
    '|| OPERATORS
    '
    Private Sub btn_negate_Click(sender As Object, e As EventArgs) Handles btn_negate.Click
        If (lbl_equation.Text.Contains("-")) Then
            lbl_equation.Text = lbl_equation.Text.Remove(0, 1)
        Else
            lbl_equation.Text = "-" + lbl_equation.Text
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        O_perator = ""
        O_perator = btn_add.Text
        lbl_equation.Text = lbl_equation.Text + " " + O_perator + " "
        Left_Operand_and_Operator = lbl_equation.Text
    End Sub

    Private Sub btn_subtract_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        O_perator = ""
        O_perator = btn_subtract.Text
        lbl_equation.Text = lbl_equation.Text + " " + O_perator + " "
        Left_Operand_and_Operator = lbl_equation.Text
    End Sub

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        O_perator = ""
        O_perator = btn_multiply.Text
        lbl_equation.Text = lbl_equation.Text + " " + O_perator + " "
        Left_Operand_and_Operator = lbl_equation.Text
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        lbl_equation.Font = New Font("Lucida Handwriting", 14, FontStyle.Regular)
        O_perator = ""
        O_perator = btn_divide.Text
        lbl_equation.Text = lbl_equation.Text + " " + O_perator + " "
        Left_Operand_and_Operator = lbl_equation.Text
    End Sub

    '
    '|| ASSIGNMENT OPERATOR
    '
    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click
        lbl_equation.Text = ""
        History = Left_Operand_and_Operator & Right_Operand
        lbl_equation.Text = History
        Select Case O_perator
            Case "+"
                Result = Left_Operand + Right_Operand
                lbl_answer.Text = "The sum is" & " {" & Result & "}."
            Case "-"
                Result = Left_Operand - Right_Operand
                lbl_answer.Text = "The Difference is" & " {" & Result & "}."
            Case "X"
                Result = Left_Operand * Right_Operand
                lbl_answer.Text = "The Product is" & " {" & Result & "}."
            Case "/"
                Result = Left_Operand / Right_Operand
                lbl_answer.Text = "The Quotient is" & " {" & Result & "}."
        End Select
        'History
        Call calculation_history()
    End Sub

    Private Sub panel_operators_Paint(sender As Object, e As PaintEventArgs) Handles panel_operators.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Sub calculation_history()


    End Sub

End Class
