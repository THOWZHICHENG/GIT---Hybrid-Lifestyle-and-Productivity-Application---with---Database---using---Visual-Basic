Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.IO
Public Class Diet_Foods
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
                    Dim imgPath As String = reader("foodImg").ToString()
                    If File.Exists(imgPath) Then
                        button.BackgroundImage = Image.FromFile(imgPath)
                        button.BackgroundImageLayout = ImageLayout.Stretch
                    Else
                        button.BackgroundImage = Nothing
                        MessageBox.Show("Image file not found: " & imgPath, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            ' Fetch the types from DIET_ITEM and then use them to load images
            Dim buttons As Button() = {Button1, Button2, Button3, Button4}
            Dim types As New List(Of String)

            Using cmd As New MySqlCommand("SELECT type FROM DIET_ITEM ORDER BY diID LIMIT 4", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        types.Add(reader("type").ToString())
                    End While
                End Using
            End Using

            If types.Count < 4 Then
                MessageBox.Show("Not enough types found in DIET_ITEM")
                Exit Sub
            End If

            Dim queries As String() = {
                "SELECT * FROM Food WHERE type = '" & types(0) & "'",
                "SELECT * FROM Food WHERE type = '" & types(1) & "'",
                "SELECT * FROM Food WHERE type = '" & types(2) & "'",
                "SELECT * FROM Food WHERE type = '" & types(3) & "'"
            }

            For i As Integer = 0 To buttons.Length - 1
                LoadImage(buttons(i), queries(i), "No record found for type = " & types(i))
            Next

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Diet_Foods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadCalories(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadCalories(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadCalories(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadCalories(4)
    End Sub

    Private Sub LoadCalories(fId As Integer)
        Try
            connectToDB()
            con.Open()

            sql = "SELECT * FROM Food WHERE fID = " & fId
            Using cmd As New MySqlCommand(sql, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txt_Calories.Text = reader("calories").ToString()
                    Else
                        MessageBox.Show("No record found with fId = " & fId, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btn_BMI_Click_1(sender As Object, e As EventArgs) Handles btn_BMI.Click
        Me.Hide()
        Diet_BMI.Show()
    End Sub

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

    Private Sub btn_Drinks_Click(sender As Object, e As EventArgs) Handles btn_Drinks.Click
        Me.Close()
        Diet_Drinks.Show()
        txt_totalCalories.Text = ""
        txt_Calories.Text = ""
        txt_suggestCalories.Text = ""

    End Sub
End Class