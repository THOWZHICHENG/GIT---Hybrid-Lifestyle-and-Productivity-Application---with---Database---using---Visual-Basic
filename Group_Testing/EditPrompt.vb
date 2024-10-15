Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class EditPrompt
    Dim con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim sql As String

    Dim time As String
    Dim content As String
    Dim day As String
    Dim timeSlotFull As String = "False"

    Private Sub ConnectToDB()
        con = New MySqlConnection("datasource = localhost; username=root; password=1234; database=git")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            ConnectToDB()
            con.Open()

            da = New MySqlDataAdapter(sql, con)
            Dim ds1 As New DataSet

            If rdbMonday.Checked Then
                day = "Monday"
                time = cbxTimeSlot.Text.ToString
                content = ""

                sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"

                Using cmd As New MySqlCommand(sql, con)
                    Using Reader As MySqlDataReader = cmd.ExecuteReader()
                        While Reader.Read()
                            timeSlotFull = Reader("timeSlot").ToString()
                        End While
                        Reader.Close()
                    End Using
                End Using

                If timeSlotFull = False Then
                    MessageBox.Show("There is already no task in this timeslot")
                Else

                    Dim ans As DialogResult = MessageBox.Show("Arey you sure you want to remove the task in this timeslot?",
                                                           "Alert", MessageBoxButtons.YesNo)
                    If (ans = DialogResult.Yes) Then
                        timeSlotFull = "False"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been removed")
                    End If
                End If

            ElseIf rdbTuesday.Checked Then
                day = "Tuesday"
                time = cbxTimeSlot.Text.ToString
                content = ""

                sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"

                Using cmd As New MySqlCommand(sql, con)
                    Using Reader As MySqlDataReader = cmd.ExecuteReader()
                        While Reader.Read()
                            timeSlotFull = Reader("timeSlot").ToString()
                        End While
                        Reader.Close()
                    End Using
                End Using

                If timeSlotFull = False Then
                    MessageBox.Show("There is already no task in this timeslot")
                Else

                    Dim ans As DialogResult = MessageBox.Show("Arey you sure you want to remove the task in this timeslot?",
                                                           "Alert", MessageBoxButtons.YesNo)
                    If (ans = DialogResult.Yes) Then
                        timeSlotFull = "False"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been removed")
                    End If
                End If

            ElseIf rdbWednesday.Checked Then
                day = "Wednesday"
                time = cbxTimeSlot.Text.ToString
                content = ""

                sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"

                Using cmd As New MySqlCommand(sql, con)
                    Using Reader As MySqlDataReader = cmd.ExecuteReader()
                        While Reader.Read()
                            timeSlotFull = Reader("timeSlot").ToString()
                        End While
                        Reader.Close()
                    End Using
                End Using

                If timeSlotFull = False Then
                    MessageBox.Show("There is already no task in this timeslot")
                Else

                    Dim ans As DialogResult = MessageBox.Show("Arey you sure you want to remove the event in this timeslot?",
                                                           "Alert", MessageBoxButtons.YesNo)
                    If (ans = DialogResult.Yes) Then
                        timeSlotFull = "False"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been removed")
                    End If
                End If

            ElseIf rdbThursday.Checked Then
                day = "Thursday"
                time = cbxTimeSlot.Text.ToString
                content = ""

                sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"

                Using cmd As New MySqlCommand(sql, con)
                    Using Reader As MySqlDataReader = cmd.ExecuteReader()
                        While Reader.Read()
                            timeSlotFull = Reader("timeSlot").ToString()
                        End While
                        Reader.Close()
                    End Using
                End Using

                If timeSlotFull = False Then
                    MessageBox.Show("There is already no task in this timeslot")
                Else

                    Dim ans As DialogResult = MessageBox.Show("Arey you sure you want to remove the task in this timeslot?",
                                                           "Alert", MessageBoxButtons.YesNo)
                    If (ans = DialogResult.Yes) Then
                        timeSlotFull = "False"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                        "', timeSlot = '" & timeSlotFull &
                        "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been removed")
                    End If
                End If
            ElseIf rdbFriday.Checked Then
                day = "Friday"
                time = cbxTimeSlot.Text.ToString
                content = ""

                sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"

                Using cmd As New MySqlCommand(sql, con)
                    Using Reader As MySqlDataReader = cmd.ExecuteReader()
                        While Reader.Read()
                            timeSlotFull = Reader("timeSlot").ToString()
                        End While
                        Reader.Close()
                    End Using
                End Using

                If timeSlotFull = False Then
                    MessageBox.Show("There is already no task in this timeslot")
                Else

                    Dim ans As DialogResult = MessageBox.Show("Arey you sure you want to remove the task in this timeslot?",
                                                           "Alert", MessageBoxButtons.YesNo)
                    If (ans = DialogResult.Yes) Then
                        timeSlotFull = "False"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been removed")
                    End If
                End If

            ElseIf rdbSaturday.Checked Then
                day = "Saturday"
                time = cbxTimeSlot.Text.ToString
                content = ""

                sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"

                Using cmd As New MySqlCommand(sql, con)
                    Using Reader As MySqlDataReader = cmd.ExecuteReader()
                        While Reader.Read()
                            timeSlotFull = Reader("timeSlot").ToString()
                        End While
                        Reader.Close()
                    End Using
                End Using

                If timeSlotFull = False Then
                    MessageBox.Show("There is already no task in this timeslot")
                Else

                    Dim ans As DialogResult = MessageBox.Show("Arey you sure you want to remove the task in this timeslot?",
                                                           "Alert", MessageBoxButtons.YesNo)
                    If (ans = DialogResult.Yes) Then
                        timeSlotFull = "False"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been removed")
                    End If
                End If

            ElseIf rdbSunday.Checked Then
                day = "Sunday"
                time = cbxTimeSlot.Text.ToString
                content = ""

                sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"

                Using cmd As New MySqlCommand(sql, con)
                    Using Reader As MySqlDataReader = cmd.ExecuteReader()
                        While Reader.Read()
                            timeSlotFull = Reader("timeSlot").ToString()
                        End While
                        Reader.Close()
                    End Using
                End Using

                If timeSlotFull = False Then
                    MessageBox.Show("There is already no task in this timeslot")
                Else

                    Dim ans As DialogResult = MessageBox.Show("Arey you sure you want to remove the task in this timeslot?",
                                                           "Alert", MessageBoxButtons.YesNo)
                    If (ans = DialogResult.Yes) Then
                        timeSlotFull = "False"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                        "', timeSlot = '" & timeSlotFull &
                        "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been removed")
                    End If

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            ConnectToDB()
            con.Open()

            da = New MySqlDataAdapter(sql, con)
            Dim ds1 As New DataSet


            If rdbMonday.Checked Then
                day = "Monday"
                time = cbxTimeSlot.Text.ToString
                content = txtContent.Text.ToString

                If content = "" Then
                    MessageBox.Show("Please enter the task")
                Else

                    sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"


                    Using cmd As New MySqlCommand(sql, con)
                        Using Reader As MySqlDataReader = cmd.ExecuteReader()
                            While Reader.Read()
                                timeSlotFull = Reader("timeSlot").ToString()
                            End While
                            Reader.Close()
                        End Using
                    End Using

                    If timeSlotFull = "False" Then
                        timeSlotFull = "True"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been added to the specified date")
                    Else
                        timeSlotFull = "True"
                        'Request for replace
                        Dim ans As DialogResult = MessageBox.Show("There is already an task at this timeslot, do you want to replace it?",
                                                               "Alert", MessageBoxButtons.YesNo)
                        If (ans = DialogResult.Yes) Then
                            sql = "UPDATE TIMETABLE SET content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Replaced Successfully")
                        End If

                    End If

                End If

            ElseIf rdbTuesday.Checked Then
                day = "Tuesday"
                time = cbxTimeSlot.Text.ToString
                content = txtContent.Text.ToString
                If content = "" Then
                    MessageBox.Show("Please enter the task")
                Else

                    sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"


                    Using cmd As New MySqlCommand(sql, con)
                        Using Reader As MySqlDataReader = cmd.ExecuteReader()
                            While Reader.Read()
                                timeSlotFull = Reader("timeSlot").ToString()
                            End While
                            Reader.Close()
                        End Using
                    End Using

                    If timeSlotFull = "False" Then
                        timeSlotFull = "True"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been added to the specified date")
                    Else
                        timeSlotFull = "True"
                        'Request for replace
                        Dim ans As DialogResult = MessageBox.Show("There is already an task at this timeslot, do you want to replace it?",
                                                               "Alert", MessageBoxButtons.YesNo)
                        If (ans = DialogResult.Yes) Then
                            sql = "UPDATE TIMETABLE SET content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Replaced Successfully")
                        End If
                    End If
                End If

            ElseIf rdbWednesday.Checked Then
                day = "Wednesday"
                time = cbxTimeSlot.Text.ToString
                content = txtContent.Text.ToString
                If content = "" Then
                    MessageBox.Show("Please enter the task")
                Else

                    sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"


                    Using cmd As New MySqlCommand(sql, con)
                        Using Reader As MySqlDataReader = cmd.ExecuteReader()
                            While Reader.Read()
                                timeSlotFull = Reader("timeSlot").ToString()
                            End While
                            Reader.Close()
                        End Using
                    End Using

                    If timeSlotFull = "False" Then
                        timeSlotFull = "True"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                        "', timeSlot = '" & timeSlotFull &
                        "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been added to the specified date")
                    Else
                        timeSlotFull = "True"
                        'Request for replace
                        Dim ans As DialogResult = MessageBox.Show("There is already an task at this timeslot, do you want to replace it?",
                                                           "Alert", MessageBoxButtons.YesNo)
                        If (ans = DialogResult.Yes) Then
                            sql = "UPDATE TIMETABLE SET content = '" & content &
                        "', timeSlot = '" & timeSlotFull &
                        "' WHERE day = '" & day & "'And time ='" & time & "'"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Replaced Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            ElseIf rdbThursday.Checked Then
                day = "Thursday"
                time = cbxTimeSlot.Text.ToString
                content = txtContent.Text.ToString

                If content = "" Then
                    MessageBox.Show("Please enter the task", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"


                    Using cmd As New MySqlCommand(sql, con)
                        Using Reader As MySqlDataReader = cmd.ExecuteReader()
                            While Reader.Read()
                                timeSlotFull = Reader("timeSlot").ToString()
                            End While
                            Reader.Close()
                        End Using
                    End Using

                    If timeSlotFull = "False" Then
                        timeSlotFull = "True"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                        "', timeSlot = '" & timeSlotFull &
                        "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been added to the specified date", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        timeSlotFull = "True"
                        'Request for replace
                        Dim ans As DialogResult = MessageBox.Show("There is already an task at this timeslot, do you want to replace it?",
                                                           "Alert", MessageBoxButtons.YesNo)
                        If (ans = DialogResult.Yes) Then
                            sql = "UPDATE TIMETABLE SET content = '" & content &
                        "', timeSlot = '" & timeSlotFull &
                        "' WHERE day = '" & day & "'And time ='" & time & "'"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Replaced Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            ElseIf rdbFriday.Checked Then
                day = "Friday"
                time = cbxTimeSlot.Text.ToString
                content = txtContent.Text.ToString

                If content = "" Then
                    MessageBox.Show("Please enter the task", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"


                    Using cmd As New MySqlCommand(sql, con)
                        Using Reader As MySqlDataReader = cmd.ExecuteReader()
                            While Reader.Read()
                                timeSlotFull = Reader("timeSlot").ToString()
                            End While
                            Reader.Close()
                        End Using
                    End Using

                    If timeSlotFull = "False" Then
                        timeSlotFull = "True"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been added to the specified date", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        timeSlotFull = "True"
                        'Request for replace
                        Dim ans As DialogResult = MessageBox.Show("There is already an task at this timeslot, do you want to replace it?",
                                                               "Alert", MessageBoxButtons.YesNo)
                        If (ans = DialogResult.Yes) Then
                            sql = "UPDATE TIMETABLE SET content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Replaced Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            ElseIf rdbSaturday.Checked Then
                day = "Saturday"
                time = cbxTimeSlot.Text.ToString
                content = txtContent.Text.ToString

                If content = "" Then
                    MessageBox.Show("Please enter the task", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"


                    Using cmd As New MySqlCommand(sql, con)
                        Using Reader As MySqlDataReader = cmd.ExecuteReader()
                            While Reader.Read()
                                timeSlotFull = Reader("timeSlot").ToString()
                            End While
                            Reader.Close()
                        End Using
                    End Using

                    If timeSlotFull = "False" Then
                        timeSlotFull = "True"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been added to the specified date")
                    Else
                        timeSlotFull = "True"
                        'Request for replace
                        Dim ans As DialogResult = MessageBox.Show("There is already an task at this timeslot, do you want to replace it?",
                                                               "Alert", MessageBoxButtons.YesNo)
                        If (ans = DialogResult.Yes) Then
                            sql = "UPDATE TIMETABLE SET content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Replaced Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            ElseIf rdbSunday.Checked Then
                day = "Sunday"
                time = cbxTimeSlot.Text.ToString
                content = txtContent.Text.ToString

                If content = "" Then
                    MessageBox.Show("Please enter the task", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    sql = "SELECT timeSlot FROM TIMETABLE WHERE day = '" & day & "'AND time ='" & time & "'"


                    Using cmd As New MySqlCommand(sql, con)
                        Using Reader As MySqlDataReader = cmd.ExecuteReader()
                            While Reader.Read()
                                timeSlotFull = Reader("timeSlot").ToString()
                            End While
                            Reader.Close()
                        End Using
                    End Using

                    If timeSlotFull = "False" Then
                        timeSlotFull = "True"

                        sql = "UPDATE TIMETABLE Set content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                        Dim command As New MySqlCommand(sql, con)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Task successfully been added to the specified date", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        timeSlotFull = "True"
                        'Request for replace
                        Dim ans As DialogResult = MessageBox.Show("There is already an task at this timeslot, do you want to replace it?",
                                                               "Alert", MessageBoxButtons.YesNo)
                        If (ans = DialogResult.Yes) Then
                            sql = "UPDATE TIMETABLE SET content = '" & content &
                            "', timeSlot = '" & timeSlotFull &
                            "' WHERE day = '" & day & "'And time ='" & time & "'"

                            Dim command As New MySqlCommand(sql, con)
                            command.ExecuteNonQuery()

                            MessageBox.Show("Replaced Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub EditPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class