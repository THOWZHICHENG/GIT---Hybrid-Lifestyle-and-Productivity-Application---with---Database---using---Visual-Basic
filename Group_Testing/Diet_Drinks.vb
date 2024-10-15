Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Diet_Drinks
    Dim con As MySqlConnection
    Dim sql As String
    Dim subtotal As Integer = 0

    Private Sub connectToDB()
        con = New MySqlConnection("datasource=localhost;username=root;password=1234;database=git")
    End Sub

    Private Sub LoadImage(button As Button, query As String, noRecordMessage As String)
        Using cmd As New MySqlCommand(query, con)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim imgPath As String = reader("drinkImg").ToString()
                    If File.Exists(imgPath) Then
                        button.BackgroundImage = Image.FromFile(imgPath)
                        button.BackgroundImageLayout = ImageLayout.Stretch
                    Else
                        button.BackgroundImage = Nothing
                        MessageBox.Show("Image file not found: " & imgPath)
                    End If
                Else
                    MessageBox.Show(noRecordMessage)
                End If
            End Using
        End Using
    End Sub

    Private Sub ReloadTable()
        Try
            txt_Calories.Text = ""
            txt_totalCalories.Text = ""
            txt_suggestCalories.Text = ""

            connectToDB()
            con.Open()

            Dim buttons As Button() = {Button1, Button2, Button3, Button4}
            Dim types As New List(Of String)

            Using cmd As New MySqlCommand("SELECT type FROM DRINK ORDER BY dID LIMIT 4", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        types.Add(reader("type").ToString())
                    End While
                End Using
            End Using

            If types.Count < 4 Then
                MessageBox.Show("Not enough types found in DRINK table", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim queries As String() = {
                "SELECT * FROM DRINK WHERE type = '" & types(0) & "'",
                "SELECT * FROM DRINK WHERE type = '" & types(1) & "'",
                "SELECT * FROM DRINK WHERE type = '" & types(2) & "'",
                "SELECT * FROM DRINK WHERE type = '" & types(3) & "'"
            }

            For i As Integer = 0 To buttons.Length - 1
                LoadImage(buttons(i), queries(i), "No record found for type = " & types(i))
            Next

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Diet_Drinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadCalories(5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadCalories(6)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadCalories(7)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadCalories(8)
    End Sub

    Private Sub LoadCalories(dId As Integer)
        Try
            connectToDB()
            con.Open()

            sql = "SELECT * FROM DRINK WHERE dID = " & dId
            Using cmd As New MySqlCommand(sql, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txt_Calories.Text = reader("calories").ToString()
                    Else
                        MessageBox.Show("No record found with dID = " & dId, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_BMI_Click(sender As Object, e As EventArgs) Handles btn_BMI.Click
        Me.Close()
        Diet_BMI.Show()
    End Sub

    Public count As Integer = 0

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim calories As Integer = txt_Calories.Text
            subtotal += calories
            txt_totalCalories.Text = subtotal.ToString("F")
            txt_suggestCalories.Text = SuggestCalories(subtotal.ToString("F"))
        Catch ex As Exception
            MessageBox.Show("Cannot be null !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_Calories.Clear()
        txt_totalCalories.Clear()
        txt_suggestCalories.Clear()
        subtotal = 0
    End Sub

    Private Function SuggestCalories(totalCalories As Integer) As String
        Dim minSuggestedCalories As Integer = 2400
        Dim maxSuggestedCalories As Integer = 3000

        If totalCalories > maxSuggestedCalories Then
            Return "3000"
        ElseIf totalCalories >= minSuggestedCalories Then
            Return "2500"
        Else
            Return "2000"
        End If
    End Function

    Private Sub btn_Logo_Click(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub btn_Foods_Click_1(sender As Object, e As EventArgs) Handles btn_Foods.Click
        Me.Close()
        Diet_Foods.Show()
        txt_totalCalories.Text = ""
        txt_Calories.Text = ""
        txt_suggestCalories.Text = ""
        count = 0
    End Sub
End Class