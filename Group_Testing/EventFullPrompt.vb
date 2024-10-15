Public Class EventFullPrompt

    Public optionYes As Boolean = False
    Public optionNo As Boolean = False

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        optionYes = True
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        optionNo = True
        Me.Close()

    End Sub
End Class