Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class ToDoList
    Dim con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim sql As String

    Private Sub connectToDB()
        con = New MySqlConnection("datasource=localhost; username=root; password=1234; database=git")
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_status.Items.AddRange(New String() {"Pending", "In Progress", "Completed"})
        cbx_priority.Items.AddRange(New String() {"Low", "Medium", "High"})
        cbx_filter.Items.AddRange(New String() {"All", "Pending", "In Progress", "Completed"})
        SetupDataGridView()
        LoadToDoList()
        AddHandler cbx_filter.SelectedIndexChanged, AddressOf FilterToDoListByStatus
    End Sub

    Private Sub SetupDataGridView()
        ' Set properties for the DataGridView
        With dataGridViewToDoList
            .ColumnCount = 4
            .Columns(0).Name = "ID"
            .Columns(1).Name = "Objective"
            .Columns(2).Name = "Status"
            .Columns(3).Name = "Priority"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False ' Disable the empty row for adding new records

            ' Design properties for a minimalist look
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.SteelBlue

            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .EnableHeadersVisualStyles = False
            .GridColor = Color.LightGray
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.None
        End With
    End Sub

    Private Sub LoadToDoList()
        dataGridViewToDoList.Rows.Clear()
        Try
            connectToDB()
            con.Open()

            sql = "SELECT * FROM to_do_list"
            da = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds, "to_do_listTbl")

            For Each row As DataRow In ds.Tables("to_do_listTbl").Rows
                dataGridViewToDoList.Rows.Add(row("tdID"), row("objective"), row("status"), row("priority"))
            Next

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        FilterToDoListByStatus()
    End Sub

    Private Sub FilterToDoListByStatus()
        Dim filter As String = cbx_filter.SelectedItem?.ToString()

        If String.IsNullOrEmpty(filter) OrElse filter = "All" Then
            ' No filter or "All" selected, show all rows
            For Each row As DataGridViewRow In dataGridViewToDoList.Rows
                row.Visible = True
            Next
        Else
            ' Filter rows based on the selected status
            For Each row As DataGridViewRow In dataGridViewToDoList.Rows
                If row.Cells("Status").Value.ToString() = filter Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            Next
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim objective As String = txt_objective.Text.Trim()
        Dim status As String = cbx_status.SelectedItem
        Dim priority As String = cbx_priority.SelectedItem

        If String.IsNullOrEmpty(objective) Or String.IsNullOrEmpty(status) Or String.IsNullOrEmpty(priority) Then
            MessageBox.Show("Please enter all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this objective?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            connectToDB()
            con.Open()

            ' Insert new item with the correct ID
            Dim getMaxIdQuery As String = "SELECT COALESCE(MAX(tdID), 0) + 1 FROM to_do_list"
            Dim getMaxIdCmd As New MySqlCommand(getMaxIdQuery, con)
            Dim newId As Integer = Convert.ToInt32(getMaxIdCmd.ExecuteScalar())

            Dim insertQuery As String = "INSERT INTO to_do_list (tdID, objective, status, priority) VALUES (@Id, @Objective, @Status, @Priority)"
            Dim insertCmd As New MySqlCommand(insertQuery, con)
            insertCmd.Parameters.AddWithValue("@Id", newId)
            insertCmd.Parameters.AddWithValue("@Objective", objective)
            insertCmd.Parameters.AddWithValue("@Status", status)
            insertCmd.Parameters.AddWithValue("@Priority", priority)
            insertCmd.ExecuteNonQuery()

            con.Close()
            LoadToDoList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dataGridViewToDoList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = dataGridViewToDoList.SelectedRows(0)
        Dim toDoListId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this objective?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            connectToDB()
            con.Open()

            Dim transaction As MySqlTransaction = con.BeginTransaction()

            Try
                ' Delete the selected item
                Dim deleteQuery As String = "DELETE FROM to_do_list WHERE tdID = @Id"
                Dim deleteCmd As New MySqlCommand(deleteQuery, con, transaction)
                deleteCmd.Parameters.AddWithValue("@Id", toDoListId)
                deleteCmd.ExecuteNonQuery()

                ' Check if the table is empty and reset auto-increment if needed
                Dim countQuery As String = "SELECT COUNT(*) FROM to_do_list"
                Dim countCmd As New MySqlCommand(countQuery, con, transaction)
                Dim itemCount As Integer = Convert.ToInt32(countCmd.ExecuteScalar())

                If itemCount = 0 Then
                    ' Reset the auto-increment value to 1 if the table is empty
                    Dim resetAutoIncrementQuery As String = "ALTER TABLE to_do_list AUTO_INCREMENT = 1"
                    Dim resetCmd As New MySqlCommand(resetAutoIncrementQuery, con, transaction)
                    resetCmd.ExecuteNonQuery()
                End If

                ' Commit transaction
                transaction.Commit()
            Catch ex As Exception
                ' Rollback transaction on error
                transaction.Rollback()
                Throw
            Finally
                con.Close()
            End Try

            LoadToDoList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If dataGridViewToDoList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = dataGridViewToDoList.SelectedRows(0)
        Dim toDoListId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)
        Dim objective As String = txt_objective.Text.Trim()
        Dim status As String = cbx_status.SelectedItem
        Dim priority As String = cbx_priority.SelectedItem

        If String.IsNullOrEmpty(objective) Or String.IsNullOrEmpty(status) Or String.IsNullOrEmpty(priority) Then
            MessageBox.Show("Please enter all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this objective?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            connectToDB()
            con.Open()

            Dim updateQuery As String = "UPDATE to_do_list SET objective = @Objective, status = @Status, priority = @Priority WHERE tdID = @Id"
            Dim updateCmd As New MySqlCommand(updateQuery, con)
            updateCmd.Parameters.AddWithValue("@Id", toDoListId)
            updateCmd.Parameters.AddWithValue("@Objective", objective)
            updateCmd.Parameters.AddWithValue("@Status", status)
            updateCmd.Parameters.AddWithValue("@Priority", priority)
            updateCmd.ExecuteNonQuery()

            con.Close()
            LoadToDoList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btn_clearAllObjective.Click
        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all objectives?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Try
            connectToDB()
            con.Open()

            Dim transaction As MySqlTransaction = con.BeginTransaction()

            Try
                ' Delete all items from the to_do_list table
                Dim deleteQuery As String = "DELETE FROM to_do_list"
                Dim deleteCmd As New MySqlCommand(deleteQuery, con, transaction)
                deleteCmd.ExecuteNonQuery()

                ' Reset the auto-increment value to 1
                Dim resetAutoIncrementQuery As String = "ALTER TABLE to_do_list AUTO_INCREMENT = 1"
                Dim resetCmd As New MySqlCommand(resetAutoIncrementQuery, con, transaction)
                resetCmd.ExecuteNonQuery()

                ' Commit transaction
                transaction.Commit()
            Catch ex As Exception
                ' Rollback transaction on error
                transaction.Rollback()
                Throw
            Finally
                con.Close()
            End Try

            LoadToDoList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ' Clear the textboxes and ComboBoxes
        txt_objective.Clear()
        cbx_status.SelectedIndex = -1
        cbx_priority.SelectedIndex = -1
    End Sub


    Private Sub btn_Logo_Click(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        HomePage.Show()
    End Sub
End Class
