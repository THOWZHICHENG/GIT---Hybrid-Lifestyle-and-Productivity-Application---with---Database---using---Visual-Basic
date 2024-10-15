Imports MySql.Data.MySqlClient

Public Class Expenses
    Dim con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim sql As String

    Private Sub dbConnect()
        con = New MySqlConnection("datasource = localhost; username=root; password=1234; database=git")
    End Sub

    Private Sub ReloadTable()
        cbx_categories.Items.Clear()
        Try
            dbConnect()

            con.Open()

            sql = "SELECT DISTINCT Categories FROM budget_expenses WHERE uID=1" 'change 1 to ? for unknown people

            da = New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds, "budget_expensesTable")

            Dim rows As Integer = ds.Tables("budget_expensesTable").Rows.Count

            Try 'First time
                For i As Integer = 0 To rows - 1
                    cbx_categories.Items.Add(ds.Tables("budget_expensesTable").Rows(i).Item("categories")) 'only loop the data from salesId and return it
                Next

                cbx_categories.Text = cbx_categories.Items(0)
            Catch ex As Exception
            End Try

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            dbConnect()

            con.Open()

            Dim ans As MessageBoxButtons = MessageBox.Show("Confirm to Save Expensed?",
                                                           "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If (ans = 1) Then
                If cbx_categories.Text = "" Or tbx_amount.Text = "" Then
                    MessageBox.Show("Please Don't Leave Any Empty Boxs!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        Dim dateStr As String = dtp_date.Text.Trim
                        Dim category As String = cbx_categories.Text.Trim
                        Dim checkAmount As Decimal = CDec(tbx_amount.Text.Trim)
                        Dim remarks As String = tbx_remarks.Text.Trim

                        If (checkAmount > 0) Then
                            Dim expensesAmount As Decimal = checkAmount
                            sql = "SELECT SUM(amount)As total_amount FROM budget_expenses WHERE uID=1" 'change 1 to ? for unknown people

                            da = New MySqlDataAdapter(sql, con)
                            Dim ds As New DataSet
                            da.Fill(ds, "budget_expensesTable")
                            Dim totalExpensesAmount As Decimal

                            Try
                                totalExpensesAmount = CDec(ds.Tables("budget_expensesTable").Rows(0).Item("total_amount"))
                            Catch ex As Exception
                                totalExpensesAmount = 0
                            End Try

                            totalExpensesAmount += expensesAmount
                            MessageBox.Show("You have expensed " & expensesAmount.ToString("C2") & " on " & dateStr & ControlChars.NewLine & "Category: " & category & ControlChars.NewLine & "Remarks: " & remarks, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MessageBox.Show("Your total expensed: " & totalExpensesAmount.ToString("C2"), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            sql = "INSERT INTO budget_expenses (date,categories,amount,remarks,uID) VALUES ('" & dateStr &
                                  "','" & category &
                                  "'," & expensesAmount &
                                  ",'" & remarks & "',1)"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()    'execute the Statement Same like JAVA
                            MessageBox.Show("Amount Saved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            tbx_amount.Text = ""
                            tbx_remarks.Text = ""
                            dtp_date.Text = Now.ToString("d/M/yyyy")

                            HomePage.countBudget += 1

                            Me.Hide()
                            BudgetingSystem.RelaodPageMain()
                        Else
                            MessageBox.Show("Please Enter a Valid Amount!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Please Enter Integer Number for Amount!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadTable()
    End Sub
End Class