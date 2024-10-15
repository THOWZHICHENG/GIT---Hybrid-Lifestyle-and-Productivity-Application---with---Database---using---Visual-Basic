Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class BudgetingSystem
    Dim con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim sql As String
    Dim count As Integer = 0

    Private Sub dbConnect()
        con = New MySqlConnection("datasource = localhost; username=root; password=1234; database=git")
    End Sub

    Public Sub RelaodPageMain()
        Dim maximumBudget2 As Decimal
        Dim totalExpenses2 As Decimal
        Try
            dbConnect()

            con.Open()

            sql = "SELECT username FROM PROFILE WHERE uID = 1" 'change 1 to ? for unknown people

            da = New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds, "ProfileTable")

            If (IsDBNull(ds.Tables("ProfileTable").Rows(0).Item("username")) = False) Then
                lbl_username.Text = "Username : " & (ds.Tables("ProfileTable").Rows(0).Item("username")) & "          Session Time : " & Date.Now.ToString("hh:mm:ss tt")
            End If

            sql = "SELECT SUM(amount)As max_budget FROM budget_saving WHERE uID=1" 'change 1 to ? for unknown people
            da = New MySqlDataAdapter(sql, con)
            Dim ds1 As New DataSet
            da.Fill(ds1, "budget_savingTable")

            If (IsDBNull(ds1.Tables("budget_savingTable").Rows(0).Item("max_budget")) = False) Then
                Dim maximumBudget As Decimal = CDec(ds1.Tables("budget_savingTable").Rows(0).Item("max_budget"))
                lbl_maximumBudget.Text = maximumBudget.ToString("C2")
                maximumBudget2 = maximumBudget
            End If

            sql = "SELECT SUM(amount)As total_expenses FROM budget_expenses WHERE uID=1" 'change 1 to ? for unknown people
            da = New MySqlDataAdapter(sql, con)
            Dim ds2 As New DataSet
            da.Fill(ds2, "budget_expensesTable")

            If (IsDBNull(ds2.Tables("budget_expensesTable").Rows(0).Item("total_expenses")) = False) Then
                Dim totalExpenses As Decimal = CDec(ds2.Tables("budget_expensesTable").Rows(0).Item("total_expenses"))
                lbl_totalExpenses.Text = totalExpenses.ToString("C2")
                totalExpenses2 = totalExpenses
            End If


            Dim balance As Decimal = maximumBudget2 - totalExpenses2
            lbl_balance.Text = balance.ToString("C2")

            If (balance < 0) Then
                lbl_alert.Visible = True
            Else
                lbl_alert.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub BudgetingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If HomePage.countBudget = 0 Then
            Income.ShowDialog()
            Expenses.ShowDialog()
            RelaodPageMain()
        Else
            RelaodPageMain()
        End If

    End Sub

    Private Sub btn_income_Click(sender As Object, e As EventArgs) Handles btn_income.Click
        Income.ShowDialog()
    End Sub

    Private Sub btn_expenses_Click(sender As Object, e As EventArgs) Handles btn_expenses.Click
        Expenses.ShowDialog()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Report.ShowDialog()
    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        DateTimePicker1.Text = Now.ToString("d/M/yyyy")
        DateTimePicker2.Text = Now.ToString("d/M/yyyy")

        RelaodPageMain()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim date1 As DateTime = DateTimePicker1.Value
        Dim date2 As DateTime = DateTimePicker2.Value

        If date1 > date2 Then
            MessageBox.Show("The start date must be before the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            dbConnect()
            con.Open()

            Dim date1Str As String = date1.ToString("yyyy-MM-dd")
            Dim date2Str As String = date2.ToString("yyyy-MM-dd")

            Dim sql As String = "SELECT SUM(amount) As max_budget FROM budget_saving WHERE uID=1 AND STR_TO_DATE(date, '%d/%m/%Y') BETWEEN '" & date1Str & "' AND '" & date2Str & "' ORDER BY STR_TO_DATE(date, '%d/%m/%Y') ASC"
            Dim da As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            da.Fill(ds, "budget_savingTable")

            If ds.Tables("budget_savingTable").Rows.Count > 0 AndAlso Not IsDBNull(ds.Tables("budget_savingTable").Rows(0).Item("max_budget")) Then
                Dim maximumBudget As Decimal = CDec(ds.Tables("budget_savingTable").Rows(0).Item("max_budget"))
                lbl_maximumBudget.Text = maximumBudget.ToString("C2")
            Else
                lbl_maximumBudget.Text = "RM0.00"
            End If

            sql = "SELECT SUM(amount) As total_expenses FROM budget_expenses WHERE uID=1 AND STR_TO_DATE(date, '%d/%m/%Y') BETWEEN '" & date1Str & "' AND '" & date2Str & "' ORDER BY STR_TO_DATE(date, '%d/%m/%Y') ASC"
            da = New MySqlDataAdapter(sql, con)
            Dim ds2 As New DataSet
            da.Fill(ds2, "budget_expensesTable")

            If ds2.Tables("budget_expensesTable").Rows.Count > 0 AndAlso Not IsDBNull(ds2.Tables("budget_expensesTable").Rows(0).Item("total_expenses")) Then
                Dim totalExpenses As Decimal = CDec(ds2.Tables("budget_expensesTable").Rows(0).Item("total_expenses"))
                lbl_totalExpenses.Text = totalExpenses.ToString("C2")
            Else
                lbl_totalExpenses.Text = "RM0.00"
            End If

            Try
                Dim balance As Decimal = CDec(lbl_maximumBudget.Text) - CDec(lbl_totalExpenses.Text)
                lbl_balance.Text = balance.ToString("C2")

                lbl_alert.Visible = (balance < 0)


            Catch ex As Exception

            End Try


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_Logo_Click(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now.ToString("hh:mm:ss:tt")
        lbl_time.Text = Date.Now.ToString("dd-MMMM-yyyy dddd")
    End Sub
End Class
