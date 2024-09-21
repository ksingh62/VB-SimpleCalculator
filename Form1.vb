Public Class Form1

    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String

    Dim hasDecimal As Boolean
    Dim tmpValue As Double

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "+"
    End Sub

    Private Sub cmdSubtract_Click(sender As Object, e As EventArgs) Handles cmdSubtract.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "-"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "*"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "/"
    End Sub

    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "%"
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "^"
    End Sub

    Private Sub cmdEquals_Click(sender As Object, e As EventArgs) Handles cmdEquals.Click
        Dim Result As Double
        Operand2 = Val(txtInput.Text)

        Select Case [Operator]
            Case "+"
                Result = Operand1 + Operand2
                txtInput.Text = Result.ToString()
            Case "-"
                Result = Operand1 - Operand2
                txtInput.Text = Result.ToString()
            Case "/"
                Result = Operand1 / Operand2
                txtInput.Text = Result.ToString()
            Case "*"
                Result = Operand1 * Operand2
                txtInput.Text = Result.ToString()
            Case "^"
                Result = Operand1 ^ Operand2
                txtInput.Text = Result.ToString()
            Case "%"
                Result = Operand1 * 1 / 100
                txtInput.Text = Result.ToString()
        End Select

        txtInput.Text = Result.ToString()
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        'Make sure the input box has a value
        If txtInput.Text.Length <> 0 Then
            'Assign our variable the value in the input box
            tmpValue = CType(txtInput.Text, Double)
            'Perform the square root
            tmpValue = System.Math.Sqrt(tmpValue)
            'Display the results in the input box
            txtInput.Text = CType(tmpValue, String)
            'Clear the decimal flag
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdDecimal_Click(sender As Object, e As EventArgs) Handles cmdDecimal.Click
        If InStr(txtInput.Text, ".") > 0 Then
            Exit Sub
        Else
            txtInput.Text = txtInput.Text & "."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If txtInput.Text.Length > 0 Then
            txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1)
        End If
    End Sub

    Private Sub btn1byx_Click(sender As Object, e As EventArgs) Handles btn1byx.Click
        If txtInput.Text.Length > 0 Then
            Dim value As Double = Val(txtInput.Text)

            ' Avoid division by zero
            If value <> 0 Then
                txtInput.Text = (1 / value).ToString()
            Else
                MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmdNegative_Click(sender As Object, e As EventArgs) Handles cmdNegative.Click
        ' Check if there is any text in the input box
        If txtInput.Text.Length > 0 Then
            ' Convert the text to a double
            Dim value As Double = Val(txtInput.Text)

            ' Toggle the sign of the number
            value = value * -1

            ' Display the new value in the input box
            txtInput.Text = value.ToString()
        End If
    End Sub
End Class
