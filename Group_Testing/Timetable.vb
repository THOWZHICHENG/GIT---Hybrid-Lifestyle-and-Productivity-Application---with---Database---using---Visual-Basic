Imports MySql.Data.MySqlClient

Public Class Timetable
    Dim con1 As MySqlConnection
    Dim con2 As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim sql As String

    Dim day As String
    Dim time As String
    Dim content As String

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditPrompt.Show()
    End Sub
    Private Sub ConnectToDB()
        con1 = New MySqlConnection("datasource = localhost; username=root; password=1234; database=git")
        con2 = New MySqlConnection("datasource = localhost; username=root; password=1234; database=git")

    End Sub

    Private Sub Timetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnectToDB()
            con1.Open()

            da = New MySqlDataAdapter(sql, con1)
            Dim ds1 As New DataSet

            sql = "SELECT * FROM TIMETABLE"

            Using cmd As New MySqlCommand(sql, con1)
                Using Reader As MySqlDataReader = cmd.ExecuteReader()
                    While Reader.Read()
                        day = Reader("day").ToString()
                        time = Reader("time").ToString()
                        content = Reader("content").ToString()

                        If day = "Monday" Then
                            If time = "0000 - 0200" Then
                                txtMonSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtMonSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtMonSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtMonSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtMonSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtMonSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtMonSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtMonSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtMonSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtMonSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtMonSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtMonSlot12.Text = content
                            End If
                        ElseIf day = "Tuesday" Then
                            If time = "0000 - 0200" Then
                                txtTueSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtTueSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtTueSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtTueSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtTueSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtTueSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtTueSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtTueSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtTueSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtTueSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtTueSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtTueSlot12.Text = content
                            End If
                        ElseIf day = "Wednesday" Then
                            If time = "0000 - 0200" Then
                                txtWedSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtWedSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtWedSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtWedSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtWedSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtWedSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtWedSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtWedSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtWedSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtWedSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtWedSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtWedSlot12.Text = content
                            End If
                        ElseIf day = "Thursday" Then
                            If time = "0000 - 0200" Then
                                txtThuSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtThuSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtThuSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtThuSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtThuSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtThuSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtThuSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtThuSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtThuSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtThuSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtThuSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtThuSlot12.Text = content
                            End If
                        ElseIf day = "Friday" Then
                            If time = "0000 - 0200" Then
                                txtFriSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtFriSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtFriSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtFriSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtFriSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtFriSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtFriSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtFriSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtFriSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtFriSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtFriSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtFriSlot12.Text = content
                            End If
                        ElseIf day = "Saturday" Then
                            If time = "0000 - 0200" Then
                                txtSatSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtSatSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtSatSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtSatSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtSatSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtSatSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtSatSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtSatSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtSatSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtSatSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtSatSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtSatSlot12.Text = content
                            End If
                        ElseIf day = "Sunday" Then
                            If time = "0000 - 0200" Then
                                txtSunSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtSunSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtSunSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtSunSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtSunSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtSunSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtSunSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtSunSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtSunSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtSunSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtSunSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtSunSlot12.Text = content
                            End If
                        End If

                    End While
                    Reader.Close()
                End Using
            End Using

            con1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            ConnectToDB()
            con2.Open()

            da = New MySqlDataAdapter(sql, con2)
            Dim ds2 As New DataSet


            sql = "SELECT * FROM TIMETABLE"

            Using cmd2 As New MySqlCommand(sql, con2)
                Using Reader2 As MySqlDataReader = cmd2.ExecuteReader()
                    While Reader2.Read()
                        day = Reader2("day").ToString()
                        time = Reader2("time").ToString()
                        content = Reader2("content").ToString()
                        If day = "Monday" Then
                            If time = "0000 - 0200" Then
                                txtMonSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtMonSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtMonSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtMonSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtMonSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtMonSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtMonSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtMonSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtMonSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtMonSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtMonSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtMonSlot12.Text = content
                            End If
                        ElseIf day = "Tuesday" Then
                            If time = "0000 - 0200" Then
                                txtTueSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtTueSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtTueSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtTueSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtTueSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtTueSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtTueSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtTueSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtTueSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtTueSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtTueSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtTueSlot12.Text = content
                            End If
                        ElseIf day = "Wednesday" Then
                            If time = "0000 - 0200" Then
                                txtWedSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtWedSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtWedSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtWedSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtWedSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtWedSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtWedSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtWedSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtWedSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtWedSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtWedSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtWedSlot12.Text = content
                            End If
                        ElseIf day = "Thursday" Then
                            If time = "0000 - 0200" Then
                                txtThuSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtThuSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtThuSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtThuSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtThuSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtThuSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtThuSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtThuSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtThuSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtThuSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtThuSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtThuSlot12.Text = content
                            End If
                        ElseIf day = "Friday" Then
                            If time = "0000 - 0200" Then
                                txtFriSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtFriSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtFriSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtFriSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtFriSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtFriSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtFriSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtFriSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtFriSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtFriSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtFriSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtFriSlot12.Text = content
                            End If
                        ElseIf day = "Saturday" Then
                            If time = "0000 - 0200" Then
                                txtSatSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtSatSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtSatSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtSatSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtSatSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtSatSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtSatSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtSatSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtSatSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtSatSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtSatSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtSatSlot12.Text = content
                            End If
                        ElseIf day = "Sunday" Then
                            If time = "0000 - 0200" Then
                                txtSunSlot1.Text = content
                            ElseIf time = "0200 - 0400" Then
                                txtSunSlot2.Text = content
                            ElseIf time = "0400 - 0600" Then
                                txtSunSlot3.Text = content
                            ElseIf time = "0600 - 0800" Then
                                txtSunSlot4.Text = content
                            ElseIf time = "0800 - 1000" Then
                                txtSunSlot5.Text = content
                            ElseIf time = "1000 - 1200" Then
                                txtSunSlot6.Text = content
                            ElseIf time = "1200 - 1400" Then
                                txtSunSlot7.Text = content
                            ElseIf time = "1400 - 1600" Then
                                txtSunSlot8.Text = content
                            ElseIf time = "1600 - 1800" Then
                                txtSunSlot9.Text = content
                            ElseIf time = "1800 - 2000" Then
                                txtSunSlot10.Text = content
                            ElseIf time = "2000 - 2200" Then
                                txtSunSlot11.Text = content
                            ElseIf time = "2200 - 0000" Then
                                txtSunSlot12.Text = content
                            End If
                        End If

                    End While
                    Reader2.Close()
                End Using
            End Using

            con2.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btn_Logo_Click_1(sender As Object, e As EventArgs) Handles btn_Logo.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub btn_Back_Click_1(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        HomePage.Show()
    End Sub
End Class