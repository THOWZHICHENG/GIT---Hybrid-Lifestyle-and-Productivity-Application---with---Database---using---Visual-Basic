Imports MySql.Data.MySqlClient

Public Class Profile_edit
    Dim con As MySqlConnection
    Dim sql As String

    Private Sub connectToDB()
        con = New MySqlConnection("datasource=localhost;username=root;password=1234;database=git")
    End Sub

    Private Sub ReloadTable()
        If Clothing.publicClothImage = False Then
            Profile_Avatar.Image = Group_Testing.My.Resources.Resources.Avatar
        Else
            Profile_Avatar.Image = Clothing.publicMannequin
        End If
        Try
            Dim gender As String

            txt_firstName.Text = ""
            txt_lastName.Text = ""
            txt_userName.Text = ""
            txt_Email.Text = ""

            rdb_Male.Checked = False
            rdb_Female.Checked = False

            connectToDB()
            con.Open()

            sql = "SELECT fName, lName, username, email, gender, dob FROM PROFILE WHERE uID = 1"
            Using cmd As New MySqlCommand(sql, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txt_firstName.Text = reader("fName").ToString()
                        txt_lastName.Text = reader("lName").ToString()
                        txt_userName.Text = reader("username").ToString()
                        txt_Email.Text = reader("email").ToString()
                        gender = reader("gender").ToString()
                        dtp_DOB.Value = Convert.ToDateTime(reader("dob").ToString())
                    End If
                End Using
            End Using

            If gender = "M" Then
                rdb_Male.Checked = True
            ElseIf gender = "F" Then
                rdb_Female.Checked = True
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            connectToDB()
            con.Open()

            Dim gender As String
            If rdb_Male.Checked Then
                gender = "M"
            ElseIf rdb_Female.Checked Then
                gender = "F"
            Else
                gender = ""
            End If

            Dim str = MessageBox.Show("Confirm to save record?", "Alert", MessageBoxButtons.YesNo)
            If str = DialogResult.Yes Then
                sql = "UPDATE PROFILE SET fName = @fName, lName = @lName, username = @username, email = @Email, dob = @dob, gender = @gender WHERE uID = 1"
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@fName", txt_firstName.Text.Trim())
                    cmd.Parameters.AddWithValue("@lName", txt_lastName.Text.Trim())
                    cmd.Parameters.AddWithValue("@username", txt_userName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txt_Email.Text.Trim())
                    cmd.Parameters.AddWithValue("@dob", dtp_DOB.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@gender", gender)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Record saved successfully!")

                Dim fProfile = New Profile_label
                fProfile.Show()
                Me.Hide()
            Else
                MessageBox.Show("Save operation cancelled.")
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Profile_label.Show()
        Me.Close()
    End Sub

    Private Sub Profile_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadTable()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Profile_label.Show()
        Me.Close()
    End Sub

    Private Sub btn_Logo_Click(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Close()
        HomePage.Show()
    End Sub

End Class