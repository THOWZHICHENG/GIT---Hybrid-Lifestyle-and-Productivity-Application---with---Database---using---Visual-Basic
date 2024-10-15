
Public Class Diet_BMI
    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim height As Double
        Dim weight As Double

        If Not Double.TryParse(txt_height.Text.Trim(), height) OrElse Not Double.TryParse(txt_weight.Text.Trim(), weight) Then
            MessageBox.Show("Please enter valid numeric values for height and weight.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If height <= 0 OrElse weight <= 0 Then
            MessageBox.Show("height and weight must be greater than zero.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            height /= 100

            Dim bmi As Double = weight / (height * height)
            txt_BMI.Text = bmi.ToString("F2")
            Select Case bmi
                Case < 18.5
                    lbl_classification.Text = "Underweight"
                Case 18.5 To 24.9
                    lbl_classification.Text = "Normal weight"
                Case 25 To 29.9
                    lbl_classification.Text = "Overweight"
                Case Else
                    lbl_classification.Text = "Obesity"
            End Select
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txt_height.Clear()
        txt_weight.Clear()
        txt_BMI.Clear()
        lbl_classification.Text = ""
        txt_height.Focus()
    End Sub

    Private Sub btn_calories_Click_1(sender As Object, e As EventArgs) Handles btn_calories.Click
        Me.Close()
        Diet_Drinks.Show()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub btn_Logo_Click_1(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Close()
        HomePage.Show()
    End Sub

End Class
