Imports System.Drawing.Printing

Public Class Notepad
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim answer As Integer = MessageBox.Show("Open A New File ?", "Alert", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation,
                                                MessageBoxDefaultButton.Button2)

        If answer = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("New File Created !")
            rtxt_notepad.Clear()
        Else

        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtxt_notepad.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rtxt_notepad.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim answer As Integer = MessageBox.Show("Print File ?", "Alert", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation,
                                                MessageBoxDefaultButton.Button2)

        If answer = Windows.Forms.DialogResult.Yes Then
            PrintDocument1.Print()
        Else

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim horizontalPrintLocation As Single = e.MarginBounds.Left
        Dim verticalPrintLocation As Single = e.MarginBounds.Top

        ' Create a bitmap to draw the RichTextBox content
        Dim bmp As New Bitmap(rtxt_notepad.Width, rtxt_notepad.Height)
        rtxt_notepad.DrawToBitmap(bmp, New Rectangle(0, 0, rtxt_notepad.Width, rtxt_notepad.Height))

        ' Draw the bitmap on the print document
        e.Graphics.DrawImage(bmp, horizontalPrintLocation, verticalPrintLocation)
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        rtxt_notepad.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        rtxt_notepad.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        rtxt_notepad.Cut()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        rtxt_notepad.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        rtxt_notepad.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        rtxt_notepad.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = rtxt_notepad.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                rtxt_notepad.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = rtxt_notepad.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                rtxt_notepad.ForeColor = dlg.Color
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub btn_Logo_Click(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Hide()
        HomePage.Show()
    End Sub
End Class