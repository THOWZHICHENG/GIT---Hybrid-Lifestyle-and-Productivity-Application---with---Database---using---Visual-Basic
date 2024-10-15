Public Class EventPrompt1
    Public tempEvent As String
    Public eventConfirmed As Boolean = False
    Public eventRemoveAttempt As Boolean = False

    Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrEmpty(tbEvent1Prompt.Text) = False Then
            eventConfirmed = True
            tempEvent = tbEvent1Prompt.Text
            eventRemoveAttempt = False

            Me.Close()
        Else
            MessageBox.Show("Please enter event")
        End If


    End Sub



    Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        eventRemoveAttempt = True
        Me.Close()

    End Sub

    Private Sub EventPrompt1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbEvent1Prompt.Text = ""
    End Sub
End Class