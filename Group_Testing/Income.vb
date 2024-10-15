Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class Income
    Dim con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim sql As String

    Private Sub dbConnect()
        con = New MySqlConnection("datasource = localhost; username=root; password=1234; database=git")
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            dbConnect()

            con.Open()

            Dim ans As MessageBoxButtons = MessageBox.Show("Confirm to Save Income?",
                                                           "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If (ans = 1) Then
                Try
                    Dim checkAmount As Decimal = CDec(tbx_incomeAmount.Text.Trim)
                    If (checkAmount > 0) Then
                        Dim incomeAmount As Decimal = checkAmount
                        sql = "SELECT SUM(amount)As total_amount FROM budget_saving WHERE uID=1" 'change 1 to ? for unknown people

                        da = New MySqlDataAdapter(sql, con)
                        Dim ds As New DataSet
                        da.Fill(ds, "budget_savingTable")

                        Dim savingAmount As Decimal
                        Try
                            savingAmount = CDec(ds.Tables("budget_savingTable").Rows(0).Item("total_amount"))
                        Catch ex As Exception
                            savingAmount = 0
                        End Try


                        savingAmount += incomeAmount

                        Dim dateStr As String = Date.Now.ToString("d/M/yyyy")
                        MessageBox.Show("You have saved " & incomeAmount.ToString("C2") & " on " & dateStr, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MessageBox.Show("Your total saving: " & savingAmount.ToString("C2"), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        sql = "INSERT INTO budget_saving (date,amount,uID) VALUES ('" & dateStr &
                              "'," & incomeAmount & ",1)"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Amount Saved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        tbx_incomeAmount.Text = ""

                        HomePage.countBudget += 1

                        Me.Hide()
                        BudgetingSystem.RelaodPageMain()

                    Else
                        MessageBox.Show("Please Enter a Valid Amount!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Please Enter Integer number!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show(ex.ToString())
                End Try
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class