Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class Report
    Dim con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim sql As String

    Private strFormat As StringFormat
    Private arrColumnLefts As New ArrayList
    Private arrColumnWidths As New ArrayList
    Private iCellHeight As Integer = 0
    Private iTotalWidth As Integer = 0
    Private iRow As Integer = 0
    Private bFirstPage As Boolean = False
    Private bNewPage As Boolean = False
    Private iHeaderHeight As Integer = 0

    Private Sub dbConnect()
        con = New MySqlConnection("datasource = localhost; username=root; password=1234; database=git")
    End Sub

    Private Sub ReloadTableExpenses()
        DataGridView1.Rows.Clear()
        cbx_filterDate.Items.Clear()
        Try
            dbConnect()

            con.Open()

            sql = "SELECT beID,date,categories,amount,remarks FROM budget_expenses WHERE uID=1" 'change 1 to ? for unknown people

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(dr.Item("beID").ToString, dr.Item("date").ToString, dr.Item("categories").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While

            con.Close()

            con.Open()

            sql = "SELECT date FROM budget_expenses WHERE uID=1 GROUP BY date" 'change 1 to ? for unknown people

            da = New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds, "budget_expensesTable")

            Dim rows As Integer = ds.Tables("budget_expensesTable").Rows.Count

            Try
                For i As Integer = 0 To rows - 1
                    cbx_filterDate.Items.Add(ds.Tables("budget_expensesTable").Rows(i).Item("date")) 'only loop the data from salesId and return it
                Next

            Catch ex As Exception

            End Try
            'Display all the record
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowTemplate.Height = 30
        DataGridView2.RowTemplate.Height = 30

        'Expenses
        ReloadTableExpenses()
        TotalExpenses()

        'Saving(income)
        ReloadTableIncome()
        TotalIncome()
    End Sub

    Private Sub tbx_searchCategory_TextChanged(sender As Object, e As EventArgs) Handles tbx_searchCategory.TextChanged
        DataGridView1.Rows.Clear()
        Try
            dbConnect()

            con.Open()

            If (cbx_filterDate.Text.Trim = "") Then
                sql = "SELECT beID,date,categories,amount,remarks FROM budget_expenses WHERE uID=1 and categories LIKE '%" & tbx_searchCategory.Text.Trim & "%'" 'change 1 to ? for unknown people

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sql, con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read = True
                    DataGridView1.Rows.Add(dr.Item("beID").ToString, dr.Item("date").ToString, dr.Item("categories").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
                End While

                TotalExpenses()
            Else
                sql = "SELECT beID,date,categories,amount,remarks FROM budget_expenses WHERE uID=1 and categories LIKE '%" & tbx_searchCategory.Text.Trim & "%' and date ='" & cbx_filterDate.Text & "'" 'change 1 to ? for unknown people

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sql, con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read = True
                    DataGridView1.Rows.Add(dr.Item("beID").ToString, dr.Item("date").ToString, dr.Item("categories").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
                End While

                TotalExpenses()
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cbx_filterDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_filterDate.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        Try
            dbConnect()

            con.Open()

            If (tbx_searchCategory.Text = "") Then
                sql = "SELECT beID,date,categories,amount,remarks FROM budget_expenses WHERE uID=1 and date='" & cbx_filterDate.Text.Trim & "'" 'change 1 to ? for unknown people

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sql, con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read = True
                    DataGridView1.Rows.Add(dr.Item("beID").ToString, dr.Item("date").ToString, dr.Item("categories").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
                End While

                TotalExpenses()
            Else
                sql = "SELECT beID,date,categories,amount,remarks FROM budget_expenses WHERE uID=1 and categories LIKE '%" & tbx_searchCategory.Text.Trim & "%'" & "and date='" & cbx_filterDate.Text.Trim & "'" 'change 1 to ? for unknown people

                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(sql, con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read = True
                    DataGridView1.Rows.Add(dr.Item("beID").ToString, dr.Item("date").ToString, dr.Item("categories").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
                End While

                TotalExpenses()
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        For i As Integer = 0 To 5
            tbx_searchCategory.Text = ""
            cbx_filterDate.Text = ""
            DateTimePicker1.Text = Now.ToString("d/M/yyyy")
            DateTimePicker2.Text = Now.ToString("d/M/yyyy")
            ReloadTableExpenses()
            TotalExpenses()
        Next
    End Sub

    Private Sub btn_expensesFilter_Click(sender As Object, e As EventArgs) Handles btn_expensesFilter.Click
        Dim date1 As DateTime = DateTimePicker1.Value
        Dim date2 As DateTime = DateTimePicker2.Value

        If date1 > date2 Then
            MessageBox.Show("The start date must be before the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DataGridView1.Rows.Clear()
        cbx_filterDate.Items.Clear()

        Try
            dbConnect()
            con.Open()

            Dim sql As String = "SELECT beID, date, categories, amount, remarks FROM budget_expenses WHERE uID=1 AND STR_TO_DATE(date, '%d/%m/%Y') BETWEEN @date1 AND @date2 ORDER BY STR_TO_DATE(date, '%d/%m/%Y') ASC"
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@date1", date1.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@date2", date2.ToString("yyyy-MM-dd"))

            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.Item("beID").ToString(), dr.Item("date").ToString(), dr.Item("categories").ToString(), dr.Item("amount").ToString(), dr.Item("remarks").ToString())
            End While

            dr.Close()

            TotalExpenses()

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub TotalExpenses()
        Try
            Dim sum As Double = 0.00
            For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                sum = sum + DataGridView1.Rows(i).Cells(3).Value
            Next

            lbl_totalExpenses.Text = "Total Expenses: RM" & Format(sum, "#,##0.00")
            lbl_totalExpenses.TextAlign = ContentAlignment.TopRight
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub ReloadTableIncome()
        DataGridView2.Rows.Clear()
        cbx_incomeDate.Items.Clear()
        Try
            dbConnect()

            con.Open()

            sql = "SELECT bsID,date,amount FROM budget_saving WHERE uID=1" 'change 1 to ? for unknown people

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView2.Rows.Add(dr.Item("bsID").ToString, dr.Item("date").ToString, dr.Item("amount").ToString)
            End While

            con.Close()

            con.Open()

            sql = "SELECT date FROM budget_saving WHERE uID=1 GROUP BY date" 'change 1 to ? for unknown people

            da = New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds, "budget_savingTable")

            Dim rows As Integer = ds.Tables("budget_savingTable").Rows.Count

            Try
                For i As Integer = 0 To rows - 1
                    cbx_incomeDate.Items.Add(ds.Tables("budget_savingTable").Rows(i).Item("date")) 'only loop the data from salesId and return it
                Next

            Catch ex As Exception

            End Try
            'Display all the record
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cbx_incomeDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_incomeDate.SelectedIndexChanged
        DataGridView2.Rows.Clear()
        Try
            dbConnect()

            con.Open()

            sql = "SELECT bsID,date,amount FROM budget_saving WHERE uID=1 and date='" & cbx_incomeDate.Text.Trim & "'" 'change 1 to ? for unknown people

            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView2.Rows.Add(dr.Item("bsID").ToString, dr.Item("date").ToString, dr.Item("amount").ToString)
            End While

            TotalIncome()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_incomeClear_Click(sender As Object, e As EventArgs) Handles btn_incomeClear.Click
        For i As Integer = 0 To 5
            cbx_incomeDate.Text = ""
            ReloadTableIncome()
            TotalIncome()
        Next
    End Sub

    Private Sub TotalIncome()
        Try
            Dim sum As Double = 0.00
            For i As Integer = 0 To DataGridView2.Rows.Count() - 1 Step +1
                sum = sum + DataGridView2.Rows(i).Cells(2).Value
            Next

            lbl_totalIncome.Text = "Total Income: RM" & Format(sum, "#,##0.00")
            lbl_totalIncome.TextAlign = ContentAlignment.TopRight
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub btn_printPreview_Click(sender As Object, e As EventArgs) Handles btn_printPreview.Click
        Dim Print_Preview1 As New PrintPreviewDialog
        Print_Preview1.Document = PrintDocument1
        Print_Preview1.StartPosition = FormStartPosition.CenterScreen
        Print_Preview1.Size = Screen.PrimaryScreen.WorkingArea.Size
        Print_Preview1.ShowDialog()

        Dim Print_Preview2 As New PrintPreviewDialog
        Print_Preview2.Document = PrintDocument2
        Print_Preview2.StartPosition = FormStartPosition.CenterScreen
        Print_Preview2.Size = Screen.PrimaryScreen.WorkingArea.Size
        Print_Preview2.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Try
            strFormat = New StringFormat
            strFormat.Alignment = StringAlignment.Center
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Trimming = StringTrimming.EllipsisCharacter

            arrColumnLefts.Clear()
            arrColumnWidths.Clear()
            iCellHeight = 0
            iRow = 0
            bNewPage = True
            bFirstPage = True

            iTotalWidth = 0

            For Each dgGridCol As DataGridViewColumn In DataGridView1.Columns
                iTotalWidth += dgGridCol.Width
            Next dgGridCol
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim iLeftMargin As Integer = e.MarginBounds.Left
            Dim iTopMargin As Integer = e.MarginBounds.Top
            Dim bMorePagesToPrint As Boolean = False
            Dim iTmpWidth As Integer = 0

            If bFirstPage Then
                For Each GridCol As DataGridViewColumn In DataGridView1.Columns
                    iTmpWidth = CInt(Math.Floor(CDbl(GridCol.Width) / CDbl(iTotalWidth) * CDbl(e.MarginBounds.Width)))
                    iHeaderHeight = CInt(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11

                    arrColumnLefts.Add(iLeftMargin)
                    arrColumnWidths.Add(iTmpWidth)
                    iLeftMargin += iTmpWidth
                Next GridCol
            End If

            Do While iRow <= DataGridView1.Rows.Count - 1
                Dim GridRow As DataGridViewRow = DataGridView1.Rows(iRow)
                iCellHeight = GridRow.Height + 5
                Dim iCount As Integer = 0

                If iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    bNewPage = True
                    bFirstPage = False
                    bMorePagesToPrint = True
                    Exit Do
                Else
                    If bNewPage Then
                        Dim strDate As String = Date.Now.ToLongDateString() & " " & Date.Now.ToShortTimeString()
                        Dim Title As String = "Expenses Report: "

                        e.Graphics.DrawString(Title, New Font(DataGridView1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Datagridview Details", New Font(DataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        e.Graphics.DrawString(strDate, New Font(DataGridView1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(DataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Datagridview Details", New Font(DataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        e.Graphics.DrawString("Datagridview Details ", New Font(DataGridView1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top)

                        iTopMargin = e.MarginBounds.Top

                        For Each GridCol As DataGridViewColumn In DataGridView1.Columns
                            If iCount < arrColumnLefts.Count AndAlso iCount < arrColumnWidths.Count Then
                                e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iHeaderHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iHeaderHeight))
                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(GridCol.InheritedStyle.ForeColor), New RectangleF(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iHeaderHeight), strFormat)
                            End If
                            iCount += 1
                        Next GridCol

                        bNewPage = False
                        iTopMargin += iHeaderHeight
                    End If

                    iCount = 0

                    For Each cel As DataGridViewCell In GridRow.Cells
                        If iCount < arrColumnLefts.Count AndAlso iCount < arrColumnWidths.Count Then
                            If cel.Value IsNot Nothing Then
                                e.Graphics.DrawString(cel.Value.ToString(), cel.InheritedStyle.Font, New SolidBrush(cel.InheritedStyle.ForeColor), New RectangleF(DirectCast(arrColumnLefts(iCount), Integer), CSng(iTopMargin), DirectCast(arrColumnWidths(iCount), Integer), iCellHeight), strFormat)
                            End If
                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iCellHeight))
                        End If
                        iCount += 1
                    Next cel
                End If

                iRow += 1
                iTopMargin += iCellHeight
            Loop

            If bMorePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub PrintDocument2_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument2.BeginPrint
        Try
            strFormat = New StringFormat
            strFormat.Alignment = StringAlignment.Center
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Trimming = StringTrimming.EllipsisCharacter

            arrColumnLefts.Clear()
            arrColumnWidths.Clear()
            iCellHeight = 0
            iRow = 0
            bNewPage = True
            bFirstPage = True

            iTotalWidth = 0

            For Each dgGridCol As DataGridViewColumn In DataGridView2.Columns
                iTotalWidth += dgGridCol.Width
            Next dgGridCol
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Try
            Dim iLeftMargin As Integer = e.MarginBounds.Left
            Dim iTopMargin As Integer = e.MarginBounds.Top
            Dim bMorePagesToPrint As Boolean = False
            Dim iTmpWidth As Integer = 0

            If bFirstPage Then
                For Each GridCol As DataGridViewColumn In DataGridView2.Columns
                    iTmpWidth = CInt(Math.Floor(CDbl(GridCol.Width) / CDbl(iTotalWidth) * CDbl(e.MarginBounds.Width)))
                    iHeaderHeight = CInt(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11

                    arrColumnLefts.Add(iLeftMargin)
                    arrColumnWidths.Add(iTmpWidth)
                    iLeftMargin += iTmpWidth
                Next GridCol
            End If

            Do While iRow <= DataGridView2.Rows.Count - 1
                Dim GridRow As DataGridViewRow = DataGridView2.Rows(iRow)
                iCellHeight = GridRow.Height + 5
                Dim iCount As Integer = 0

                If iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    bNewPage = True
                    bFirstPage = False
                    bMorePagesToPrint = True
                    Exit Do
                Else
                    If bNewPage Then
                        Dim strDate As String = Date.Now.ToLongDateString() & " " & Date.Now.ToShortTimeString()
                        Dim Title As String = "Income Report: "

                        e.Graphics.DrawString(Title, New Font(DataGridView2.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Datagridview Details", New Font(DataGridView2.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        e.Graphics.DrawString(strDate, New Font(DataGridView2.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(DataGridView2.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Datagridview Details", New Font(DataGridView2.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        e.Graphics.DrawString("Datagridview Details ", New Font(DataGridView2.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top)

                        iTopMargin = e.MarginBounds.Top

                        For Each GridCol As DataGridViewColumn In DataGridView2.Columns
                            If iCount < arrColumnLefts.Count AndAlso iCount < arrColumnWidths.Count Then
                                e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iHeaderHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iHeaderHeight))
                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(GridCol.InheritedStyle.ForeColor), New RectangleF(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iHeaderHeight), strFormat)
                            End If
                            iCount += 1
                        Next GridCol

                        bNewPage = False
                        iTopMargin += iHeaderHeight
                    End If

                    iCount = 0

                    For Each cel As DataGridViewCell In GridRow.Cells
                        If iCount < arrColumnLefts.Count AndAlso iCount < arrColumnWidths.Count Then
                            If cel.Value IsNot Nothing Then
                                e.Graphics.DrawString(cel.Value.ToString(), cel.InheritedStyle.Font, New SolidBrush(cel.InheritedStyle.ForeColor), New RectangleF(DirectCast(arrColumnLefts(iCount), Integer), CSng(iTopMargin), DirectCast(arrColumnWidths(iCount), Integer), iCellHeight), strFormat)
                            End If
                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(DirectCast(arrColumnLefts(iCount), Integer), iTopMargin, DirectCast(arrColumnWidths(iCount), Integer), iCellHeight))
                        End If
                        iCount += 1
                    Next cel
                End If

                iRow += 1
                iTopMargin += iCellHeight
            Loop

            If bMorePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim ans As MessageBoxButtons = MessageBox.Show("Confirm to print expenses and income report.",
                                                           "Alert", MessageBoxButtons.OKCancel)
        If (ans = 1) Then
            PrintDocument1.Print()
            PrintDocument2.Print()
        End If
    End Sub

End Class
