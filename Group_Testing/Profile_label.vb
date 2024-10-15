Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Profile_label
    Dim con As MySqlConnection
    Dim sql As String
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Profile_edit.Show()
        Me.Hide()
    End Sub

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
            Dim gender As String = ""

            txt_fName.Text = ""
            txt_lName.Text = ""
            txt_userName.Text = ""
            txt_Email.Text = ""

            connectToDB()
            con.Open()

            sql = "SELECT fName, lName, username, email, gender, dob FROM PROFILE WHERE uID = 1"
            Using cmd As New MySqlCommand(sql, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txt_fName.Text = reader("fName").ToString()
                        txt_lName.Text = reader("lName").ToString()
                        txt_userName.Text = reader("username").ToString()
                        txt_Email.Text = reader("email").ToString()
                        lbl_gender.Text = reader("gender").ToString()
                        lbl_DOB.Text = reader("dob").ToString()
                    End If
                End Using
            End Using

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Profile_label_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadTable()
    End Sub

    Private Sub btn_Logo_Click(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub btn_Back_Click_1(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        HomePage.Show()
    End Sub
End Class