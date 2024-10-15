Public Class EventRemovePrompt
    Public event1Remove As Boolean = False
    Public event2Remove As Boolean = False
    Public eventCancel As Boolean = False

    Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        eventCancel = True
        event1Remove = False
        event2Remove = False
        Me.Close()
    End Sub

    Sub btnEvent1_Click(sender As Object, e As EventArgs) Handles btnEvent1.Click
        event1Remove = True
        event2Remove = False
        Me.Close()
    End Sub

    Sub btnEvent2_Click(sender As Object, e As EventArgs) Handles btnEvent2.Click
        event2Remove = True
        event1Remove = False
        Me.Close()
    End Sub

    Sub btnEventBoth_Click(sender As Object, e As EventArgs) Handles btnEventBoth.Click
        event1Remove = True
        event2Remove = True
        Me.Close()
    End Sub
End Class