Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Login
    Dim con As MySqlConnection
    Dim sql As String

    Private Sub connectToDB()
        con = New MySqlConnection("datasource = localhost; username=root;" &
                                  "password=1234;database=git")
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim email As String = txt_email.Text
        Dim password As String = txt_password.Text

        If String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        

        SaveToDatabase(email, password)

    End Sub

    Private Sub SaveToDatabase(email As String, password As String)
        sql = "SELECT COUNT(*) FROM profile WHERE email = @Email AND password = @Password"

        Try
            connectToDB()
            con.Open()

            Dim command As New MySqlCommand(sql, con)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Password", password)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                HomePage.Show()
            Else
                MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class