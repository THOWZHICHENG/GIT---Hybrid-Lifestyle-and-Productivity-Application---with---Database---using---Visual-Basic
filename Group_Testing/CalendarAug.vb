Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class CalendarJul
    Dim con As MySqlConnection
    Dim con2 As MySqlConnection

    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Dim sql As String
    Dim sql2 As String

    Dim day As String
    Dim week As String
    Dim month As String
    Dim year As String
    Dim eventCount As Integer
    Dim event1 As String
    Dim event2 As String
    Dim event1Full As Boolean
    Dim event2Full As Boolean

    Dim eventFull As Boolean = False

    Private Sub connectToDB()
        'Establish connection 
        con = New MySqlConnection("datasource = localhost;  username=root; password=1234;database=git")
        con2 = New MySqlConnection("datasource = localhost;  username=root; password=1234;database=git")

    End Sub

    'Week1
    Private Sub JulyWeek1Sun()
        'Week1
        sql = "SELECT * FROM CALENDAR WHERE day = 'Sunday' AND week = 'Week1' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek1SunLoad()
        connectToDB()
        con.Open()

        JulyWeek1Sun()

        If event1Full = True And event2Full = False Then
            e1Week1Sun.Visible = True
            Label86.Visible = True
            Label86.Text = event1.ToString

            e2Week1Sun.Visible = False
            Label87.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week1Sun.Visible = False
            Label86.Visible = False

            e2Week1Sun.Visible = True
            Label87.Visible = True
            Label87.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week1Sun.Visible = True
            Label86.Visible = True
            Label86.Text = event1.ToString

            e2Week1Sun.Visible = True
            Label87.Visible = True
            Label87.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week1Sun.Visible = False
            Label80.Visible = False

            e2Week1Sun.Visible = False
            Label87.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek1Mon()
        'Week1
        sql = "SELECT * FROM CALENDAR WHERE day = 'Monday' AND week = 'Week1' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek1MonLoad()
        connectToDB()
        con.Open()

        JulyWeek1Mon()

        If event1Full = True And event2Full = False Then
            e1Week1Mon.Visible = True
            Label84.Visible = True
            Label84.Text = event1.ToString

            e2Week1Mon.Visible = False
            Label85.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week1Mon.Visible = False
            Label84.Visible = False

            e2Week1Mon.Visible = True
            Label85.Visible = True
            Label85.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week1Mon.Visible = True
            Label84.Visible = True
            Label84.Text = event1.ToString

            e2Week1Mon.Visible = True
            Label85.Visible = True
            Label85.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week1Mon.Visible = False
            Label84.Visible = False

            e2Week1Mon.Visible = False
            Label85.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek1Tue()
        'Week1
        sql = "SELECT * FROM CALENDAR WHERE day = 'Tuesday' AND week = 'Week1' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek1TueLoad()
        connectToDB()
        con.Open()

        JulyWeek1Tue()

        If event1Full = True And event2Full = False Then
            e1Week1Tue.Visible = True
            Label82.Visible = True
            Label82.Text = event1.ToString

            e2Week1Tue.Visible = False
            Label83.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week1Tue.Visible = False
            Label82.Visible = False

            e2Week1Tue.Visible = True
            Label83.Visible = True
            Label83.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week1Tue.Visible = True
            Label82.Visible = True
            Label82.Text = event1.ToString

            e2Week1Tue.Visible = True
            Label83.Visible = True
            Label83.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week1Tue.Visible = False
            Label82.Visible = False

            e2Week1Tue.Visible = False
            Label83.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek1Wed()
        'Week1
        sql = "SELECT * FROM CALENDAR WHERE day = 'Wednesday' AND week = 'Week1' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek1WedLoad()
        connectToDB()
        con.Open()

        JulyWeek1Wed()

        If event1Full = True And event2Full = False Then
            e1Week1Wed.Visible = True
            Label80.Visible = True
            Label80.Text = event1.ToString

            e2Week1Wed.Visible = False
            Label81.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week1Wed.Visible = False
            Label80.Visible = False

            e2Week1Wed.Visible = True
            Label81.Visible = True
            Label81.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week1Wed.Visible = True
            Label80.Visible = True
            Label80.Text = event1.ToString

            e2Week1Wed.Visible = True
            Label81.Visible = True
            Label81.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week1Wed.Visible = False
            Label80.Visible = False

            e2Week1Wed.Visible = False
            Label81.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek1Thu()
        'Week1
        sql = "SELECT * FROM CALENDAR WHERE day = 'Thursday' AND week = 'Week1' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek1ThuLoad()
        connectToDB()
        con.Open()

        JulyWeek1Thu()

        If event1Full = True And event2Full = False Then
            e1Week1Thu.Visible = True
            Label78.Visible = True
            Label78.Text = event1.ToString

            e2Week1Thu.Visible = False
            Label79.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week1Thu.Visible = False
            Label78.Visible = False

            e2Week1Thu.Visible = True
            Label79.Visible = True
            Label79.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week1Thu.Visible = True
            Label78.Visible = True
            Label78.Text = event1.ToString

            e2Week1Thu.Visible = True
            Label79.Visible = True
            Label79.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week1Thu.Visible = False
            Label78.Visible = False

            e2Week1Thu.Visible = False
            Label79.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek1Fri()
        'Week1
        sql = "SELECT * FROM CALENDAR WHERE day = 'Friday' AND week = 'Week1' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek1FriLoad()
        connectToDB()
        con.Open()

        JulyWeek1Fri()

        If event1Full = True And event2Full = False Then
            e1Week1Fri.Visible = True
            Label76.Visible = True
            Label76.Text = event1.ToString

            e2Week1Fri.Visible = False
            Label77.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week1Fri.Visible = False
            Label76.Visible = False

            e2Week1Fri.Visible = True
            Label77.Visible = True
            Label77.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week1Fri.Visible = True
            Label76.Visible = True
            Label76.Text = event1.ToString

            e2Week1Fri.Visible = True
            Label77.Visible = True
            Label77.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week1Fri.Visible = False
            Label76.Visible = False

            e2Week1Fri.Visible = False
            Label77.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek1Sat()
        'Week1
        sql = "SELECT * FROM CALENDAR WHERE day = 'Saturday' AND week = 'Week1' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek1SatLoad()
        connectToDB()
        con.Open()

        JulyWeek1Sat()

        If event1Full = True And event2Full = False Then
            e1Week1Sat.Visible = True
            Label74.Visible = True
            Label74.Text = event1.ToString

            e2Week1Sat.Visible = False
            Label75.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week1Sat.Visible = False
            Label74.Visible = False

            e2Week1Sat.Visible = True
            Label75.Visible = True
            Label75.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week1Sat.Visible = True
            Label74.Visible = True
            Label74.Text = event1.ToString

            e2Week1Sat.Visible = True
            Label75.Visible = True
            Label75.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week1Sat.Visible = False
            Label74.Visible = False

            e2Week1Sat.Visible = False
            Label75.Visible = False

        End If

        con.Close()

    End Sub

    'Week2
    Private Sub JulyWeek2Sun()
        'Week2
        sql = "SELECT * FROM CALENDAR WHERE day = 'Sunday' AND week = 'Week2' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek2SunLoad()
        connectToDB()
        con.Open()

        JulyWeek2Sun()

        If event1Full = True And event2Full = False Then
            e1Week2Sun.Visible = True
            Label50.Visible = True
            Label50.Text = event1.ToString

            e2Week2Sun.Visible = False
            Label49.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week2Sun.Visible = False
            Label50.Visible = False

            e2Week2Sun.Visible = True
            Label49.Visible = True
            Label49.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week2Sun.Visible = True
            Label50.Visible = True
            Label50.Text = event1.ToString

            e2Week2Sun.Visible = True
            Label49.Visible = True
            Label49.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week2Sun.Visible = False
            Label50.Visible = False

            e2Week2Sun.Visible = False
            Label49.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek2Mon()
        'Week2
        sql = "SELECT * FROM CALENDAR WHERE day = 'Monday' AND week = 'Week2' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek2MonLoad()
        connectToDB()
        con.Open()

        JulyWeek2Mon()

        If event1Full = True And event2Full = False Then
            e1Week2Mon.Visible = True
            Label48.Visible = True
            Label48.Text = event1.ToString

            e2Week2Mon.Visible = False
            Label47.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week2Mon.Visible = False
            Label48.Visible = False

            e2Week2Mon.Visible = True
            Label47.Visible = True
            Label47.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week2Mon.Visible = True
            Label48.Visible = True
            Label48.Text = event1.ToString

            e2Week2Mon.Visible = True
            Label47.Visible = True
            Label47.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week2Mon.Visible = False
            Label48.Visible = False

            e2Week2Mon.Visible = False
            Label47.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek2Tue()
        'Week2
        sql = "SELECT * FROM CALENDAR WHERE day = 'Tuesday' AND week = 'Week2' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek2TueLoad()
        connectToDB()
        con.Open()

        JulyWeek2Tue()

        If event1Full = True And event2Full = False Then
            e1Week2Tue.Visible = True
            Label43.Visible = True
            Label43.Text = event1.ToString

            e2Week2Tue.Visible = False
            Label45.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week2Tue.Visible = False
            Label43.Visible = False

            e2Week2Tue.Visible = True
            Label45.Visible = True
            Label45.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week2Tue.Visible = True
            Label43.Visible = True
            Label43.Text = event1.ToString

            e2Week2Tue.Visible = True
            Label45.Visible = True
            Label45.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week2Tue.Visible = False
            Label43.Visible = False

            e2Week2Tue.Visible = False
            Label45.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek2Wed()
        'Week2
        sql = "SELECT * FROM CALENDAR WHERE day = 'Wednesday' AND week = 'Week2' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek2WedLoad()
        connectToDB()
        con.Open()

        JulyWeek2Wed()

        If event1Full = True And event2Full = False Then
            e1Week2Wed.Visible = True
            Label52.Visible = True
            Label52.Text = event1.ToString

            e2Week2Wed.Visible = False
            Label51.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week2Wed.Visible = False
            Label52.Visible = False

            e2Week2Wed.Visible = True
            Label51.Visible = True
            Label51.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week2Wed.Visible = True
            Label52.Visible = True
            Label52.Text = event1.ToString

            e2Week2Wed.Visible = True
            Label51.Visible = True
            Label51.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week2Wed.Visible = False
            Label52.Visible = False

            e2Week2Wed.Visible = False
            Label51.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek2Thu()
        'Week2
        sql = "SELECT * FROM CALENDAR WHERE day = 'Thursday' AND week = 'Week2' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek2ThuLoad()
        connectToDB()
        con.Open()

        JulyWeek2Thu()

        If event1Full = True And event2Full = False Then
            e1Week2Thu.Visible = True
            Label54.Visible = True
            Label54.Text = event1.ToString

            e2Week2Thu.Visible = False
            Label53.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week2Thu.Visible = False
            Label54.Visible = False

            e2Week2Thu.Visible = True
            Label53.Visible = True
            Label53.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week2Thu.Visible = True
            Label54.Visible = True
            Label54.Text = event1.ToString

            e2Week2Thu.Visible = True
            Label53.Visible = True
            Label53.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week2Thu.Visible = False
            Label54.Visible = False

            e2Week2Thu.Visible = False
            Label53.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek2Fri()
        'Week2
        sql = "SELECT * FROM CALENDAR WHERE day = 'Friday' AND week = 'Week2' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek2FriLoad()
        connectToDB()
        con.Open()

        JulyWeek2Fri()

        If event1Full = True And event2Full = False Then
            e1Week2Fri.Visible = True
            Label56.Visible = True
            Label56.Text = event1.ToString

            e2Week2Fri.Visible = False
            Label55.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week2Thu.Visible = False
            Label56.Visible = False

            e2Week2Thu.Visible = True
            Label55.Visible = True
            Label55.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week2Thu.Visible = True
            Label56.Visible = True
            Label56.Text = event1.ToString

            e2Week2Thu.Visible = True
            Label55.Visible = True
            Label55.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week2Thu.Visible = False
            Label56.Visible = False

            e2Week2Thu.Visible = False
            Label55.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek2Sat()
        'Week2
        sql = "SELECT * FROM CALENDAR WHERE day = 'Saturday' AND week = 'Week2' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek2SatLoad()
        connectToDB()
        con.Open()

        JulyWeek2Sat()

        If event1Full = True And event2Full = False Then
            e1Week2Sat.Visible = True
            Label58.Visible = True
            Label58.Text = event1.ToString

            e2Week2Sat.Visible = False
            Label57.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week2Sat.Visible = False
            Label58.Visible = False

            e2Week2Sat.Visible = True
            Label57.Visible = True
            Label57.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week2Sat.Visible = True
            Label58.Visible = True
            Label58.Text = event1.ToString

            e2Week2Sat.Visible = True
            Label57.Visible = True
            Label57.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week2Sat.Visible = False
            Label58.Visible = False

            e2Week2Sat.Visible = False
            Label57.Visible = False

        End If

        con.Close()
    End Sub

    'Week 3
    Private Sub JulyWeek3Sun()
        'Week3
        sql = "SELECT * FROM CALENDAR WHERE day = 'Sunday' AND week = 'Week3' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek3SunLoad()
        connectToDB()
        con.Open()

        JulyWeek3Sun()

        If event1Full = True And event2Full = False Then
            e1Week3Sun.Visible = True
            Label61.Visible = True
            Label61.Text = event1.ToString

            e2Week3Sun.Visible = False
            Label62.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week3Sun.Visible = False
            Label61.Visible = False

            e2Week3Sun.Visible = True
            Label62.Visible = True
            Label62.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week3Sun.Visible = True
            Label61.Visible = True
            Label61.Text = event1.ToString

            e2Week3Sun.Visible = True
            Label62.Visible = True
            Label62.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week3Sun.Visible = False
            Label61.Visible = False

            e2Week3Sun.Visible = False
            Label62.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek3Mon()
        'Week3
        sql = "SELECT * FROM CALENDAR WHERE day = 'Monday' AND week = 'Week3' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek3MonLoad()
        connectToDB()
        con.Open()

        JulyWeek3Mon()

        If event1Full = True And event2Full = False Then
            e1Week3Mon.Visible = True
            Label59.Visible = True
            Label59.Text = event1.ToString

            e2Week3Mon.Visible = False
            Label60.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week3Mon.Visible = False
            Label59.Visible = False

            e2Week3Mon.Visible = True
            Label60.Visible = True
            Label60.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week3Mon.Visible = True
            Label59.Visible = True
            Label59.Text = event1.ToString

            e2Week3Mon.Visible = True
            Label60.Visible = True
            Label60.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week3Mon.Visible = False
            Label59.Visible = False

            e2Week3Mon.Visible = False
            Label60.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek3Tue()
        'Week3
        sql = "SELECT * FROM CALENDAR WHERE day = 'Tuesday' AND week = 'Week3' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek3TueLoad()
        connectToDB()
        con.Open()

        JulyWeek3Tue()

        If event1Full = True And event2Full = False Then
            e1Week3Tue.Visible = True
            Label42.Visible = True
            Label42.Text = event1.ToString

            e2Week3Tue.Visible = False
            Label40.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week3Tue.Visible = False
            Label42.Visible = False

            e2Week3Tue.Visible = True
            Label40.Visible = True
            Label40.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week3Tue.Visible = True
            Label42.Visible = True
            Label42.Text = event1.ToString

            e2Week3Tue.Visible = True
            Label40.Visible = True
            Label40.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week3Tue.Visible = False
            Label42.Visible = False

            e2Week3Tue.Visible = False
            Label40.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek3Wed()
        'Week3
        sql = "SELECT * FROM CALENDAR WHERE day = 'Wednesday' AND week = 'Week3' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek3WedLoad()
        connectToDB()
        con.Open()

        JulyWeek3Wed()

        If event1Full = True And event2Full = False Then
            e1Week3Wed.Visible = True
            Label63.Visible = True
            Label63.Text = event1.ToString

            e2Week3Wed.Visible = False
            Label64.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week3Wed.Visible = False
            Label63.Visible = False

            e2Week3Wed.Visible = True
            Label64.Visible = True
            Label64.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week3Wed.Visible = True
            Label63.Visible = True
            Label63.Text = event1.ToString

            e2Week3Wed.Visible = True
            Label64.Visible = True
            Label64.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week3Wed.Visible = False
            Label63.Visible = False

            e2Week3Wed.Visible = False
            Label64.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek3Thu()
        'Week3
        sql = "SELECT * FROM CALENDAR WHERE day = 'Thursday' AND week = 'Week3' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek3ThuLoad()
        connectToDB()
        con.Open()

        JulyWeek3Thu()

        If event1Full = True And event2Full = False Then
            e1Week3Thu.Visible = True
            Label65.Visible = True
            Label65.Text = event1.ToString

            e2Week3Thu.Visible = False
            Label66.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week3Sun.Visible = False
            Label65.Visible = False

            e2Week3Sun.Visible = True
            Label66.Visible = True
            Label66.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week3Sun.Visible = True
            Label65.Visible = True
            Label61.Text = event1.ToString

            e2Week3Sun.Visible = True
            Label66.Visible = True
            Label66.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week3Sun.Visible = False
            Label65.Visible = False

            e2Week3Sun.Visible = False
            Label66.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek3Fri()
        'Week3
        sql = "SELECT * FROM CALENDAR WHERE day = 'Friday' AND week = 'Week3' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek3FriLoad()
        connectToDB()
        con.Open()

        JulyWeek3Fri()

        If event1Full = True And event2Full = False Then
            e1Week3Fri.Visible = True
            Label67.Visible = True
            Label67.Text = event1.ToString

            e2Week3Fri.Visible = False
            Label68.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week3Sun.Visible = False
            Label67.Visible = False

            e2Week3Sun.Visible = True
            Label68.Visible = True
            Label68.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week3Sun.Visible = True
            Label67.Visible = True
            Label67.Text = event1.ToString

            e2Week3Sun.Visible = True
            Label68.Visible = True
            Label68.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week3Sun.Visible = False
            Label67.Visible = False

            e2Week3Sun.Visible = False
            Label68.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek3Sat()
        'Week3
        sql = "SELECT * FROM CALENDAR WHERE day = 'Saturday' AND week = 'Week3' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek3SatLoad()
        connectToDB()
        con.Open()

        JulyWeek3Sat()

        If event1Full = True And event2Full = False Then
            e1Week3Sat.Visible = True
            Label69.Visible = True
            Label69.Text = event1.ToString

            e2Week3Sat.Visible = False
            Label70.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week3Sat.Visible = False
            Label69.Visible = False

            e2Week3Sat.Visible = True
            Label70.Visible = True
            Label70.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week3Sat.Visible = True
            Label69.Visible = True
            Label69.Text = event1.ToString

            e2Week3Sat.Visible = True
            Label70.Visible = True
            Label70.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week3Sat.Visible = False
            Label69.Visible = False

            e2Week3Sat.Visible = False
            Label70.Visible = False

        End If

        con.Close()
    End Sub

    'Week 4
    Private Sub JulyWeek4Sun()
        'Week4
        sql = "SELECT * FROM CALENDAR WHERE day = 'Sunday' AND week = 'Week4' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek4SunLoad()
        connectToDB()
        con.Open()

        JulyWeek4Sun()

        If event1Full = True And event2Full = False Then
            e1Week4Sun.Visible = True
            Label96.Visible = True
            Label96.Text = event1.ToString

            e2Week4Sun.Visible = False
            Label97.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week4Sun.Visible = False
            Label96.Visible = False

            e2Week4Sun.Visible = True
            Label97.Visible = True
            Label97.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week4Sun.Visible = True
            Label96.Visible = True
            Label96.Text = event1.ToString

            e2Week4Sun.Visible = True
            Label97.Visible = True
            Label97.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week4Sun.Visible = False
            Label96.Visible = False

            e2Week4Sun.Visible = False
            Label97.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek4Mon()
        'Week4
        sql = "SELECT * FROM CALENDAR WHERE day = 'Monday' AND week = 'Week4' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek4MonLoad()
        connectToDB()
        con.Open()

        JulyWeek4Mon()

        If event1Full = True And event2Full = False Then
            e1Week4Mon.Visible = True
            Label94.Visible = True
            Label94.Text = event1.ToString

            e2Week4Mon.Visible = False
            Label95.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week4Mon.Visible = False
            Label94.Visible = False

            e2Week4Mon.Visible = True
            Label95.Visible = True
            Label95.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week4Mon.Visible = True
            Label94.Visible = True
            Label94.Text = event1.ToString

            e2Week4Mon.Visible = True
            Label95.Visible = True
            Label95.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week4Mon.Visible = False
            Label94.Visible = False

            e2Week4Mon.Visible = False
            Label95.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek4Tue()
        'Week4
        sql = "SELECT * FROM CALENDAR WHERE day = 'Tuesday' AND week = 'Week4' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If
    End Sub

    Private Sub JulyWeek4TueLoad()
        connectToDB()
        con.Open()

        JulyWeek4Tue()

        If event1Full = True And event2Full = False Then
            e1Week4Tue.Visible = True
            Label92.Visible = True
            Label92.Text = event1.ToString

            e2Week4Tue.Visible = False
            Label93.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week4Tue.Visible = False
            Label92.Visible = False

            e2Week4Tue.Visible = True
            Label93.Visible = True
            Label93.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week4Tue.Visible = True
            Label92.Visible = True
            Label92.Text = event1.ToString

            e2Week4Tue.Visible = True
            Label93.Visible = True
            Label93.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week4Tue.Visible = False
            Label92.Visible = False

            e2Week4Tue.Visible = False
            Label93.Visible = False

        End If

        con.Close()
    End Sub

    Private Sub JulyWeek4Wed()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Wednesday' AND week = 'Week4' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek4WedLoad()
        connectToDB()
        con.Open()

        JulyWeek4Wed()

        If event1Full = True And event2Full = False Then
            e1Week4Wed.Visible = True
            Label90.Visible = True
            Label90.Text = event1.ToString

            e2Week4Wed.Visible = False
            Label91.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week4Wed.Visible = False
            Label90.Visible = False

            e2Week4Wed.Visible = True
            Label91.Visible = True
            Label91.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week4Wed.Visible = True
            Label90.Visible = True
            Label90.Text = event1.ToString

            e2Week4Wed.Visible = True
            Label91.Visible = True
            Label91.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week4Wed.Visible = False
            Label90.Visible = False

            e2Week4Wed.Visible = False
            Label91.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek4Thu()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Thursday' AND week = 'Week4' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek4ThuLoad()
        connectToDB()
        con.Open()

        JulyWeek4Thu()

        If event1Full = True And event2Full = False Then
            e1Week4Thu.Visible = True
            Label88.Visible = True
            Label88.Text = event1.ToString

            e2Week4Thu.Visible = False
            Label89.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week4Thu.Visible = False
            Label88.Visible = False

            e2Week4Thu.Visible = True
            Label89.Visible = True
            Label89.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week4Thu.Visible = True
            Label88.Visible = True
            Label88.Text = event1.ToString

            e2Week4Thu.Visible = True
            Label89.Visible = True
            Label89.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week4Thu.Visible = False
            Label88.Visible = False

            e2Week4Thu.Visible = False
            Label89.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek4Fri()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Friday' AND week = 'Week4' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek4FriLoad()
        connectToDB()
        con.Open()

        JulyWeek4Fri()

        If event1Full = True And event2Full = False Then
            e1Week4Fri.Visible = True
            Label71.Visible = True
            Label71.Text = event1.ToString

            e2Week4Fri.Visible = False
            Label72.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week4Fri.Visible = False
            Label71.Visible = False

            e2Week4Fri.Visible = True
            Label72.Visible = True
            Label72.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week4Fri.Visible = True
            Label71.Visible = True
            Label71.Text = event1.ToString

            e2Week4Fri.Visible = True
            Label72.Visible = True
            Label72.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week4Fri.Visible = False
            Label71.Visible = False

            e2Week4Fri.Visible = False
            Label72.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek4Sat()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Saturday' AND week = 'Week4' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek4SatLoad()
        connectToDB()
        con.Open()

        JulyWeek4Sat()

        If event1Full = True And event2Full = False Then
            e1Week4Sat.Visible = True
            Label44.Visible = True
            Label44.Text = event1.ToString

            e2Week4Sat.Visible = False
            Label73.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week4Sat.Visible = False
            Label44.Visible = False

            e2Week4Sat.Visible = True
            Label73.Visible = True
            Label73.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week4Sat.Visible = True
            Label44.Visible = True
            Label44.Text = event1.ToString

            e2Week4Sat.Visible = True
            Label73.Visible = True
            Label73.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week4Sat.Visible = False
            Label44.Visible = False

            e2Week4Sat.Visible = False
            Label73.Visible = False

        End If

        con.Close()

    End Sub

    'Week5
    Private Sub JulyWeek5Sun()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Sunday' AND week = 'Week5' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek5SunLoad()
        connectToDB()
        con.Open()

        JulyWeek5Sun()

        If event1Full = True And event2Full = False Then
            e1Week5Sun.Visible = True
            Label98.Visible = True
            Label98.Text = event1.ToString

            e2Week5Sun.Visible = False
            Label99.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week5Sun.Visible = False
            Label98.Visible = False

            e2Week5Sun.Visible = True
            Label99.Visible = True
            Label99.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week5Sun.Visible = True
            Label98.Visible = True
            Label98.Text = event1.ToString

            e2Week5Sun.Visible = True
            Label99.Visible = True
            Label99.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week5Sun.Visible = False
            Label98.Visible = False

            e2Week5Sun.Visible = False
            Label99.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek5Mon()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Monday' AND week = 'Week5' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek5MonLoad()
        connectToDB()
        con.Open()

        JulyWeek5Mon()

        If event1Full = True And event2Full = False Then
            e1Week5Mon.Visible = True
            Label100.Visible = True
            Label100.Text = event1.ToString

            e2Week5Mon.Visible = False
            Label101.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week5Mon.Visible = False
            Label100.Visible = False

            e2Week5Mon.Visible = True
            Label101.Visible = True
            Label101.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week5Mon.Visible = True
            Label100.Visible = True
            Label100.Text = event1.ToString

            e2Week5Mon.Visible = True
            Label101.Visible = True
            Label101.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week5Mon.Visible = False
            Label100.Visible = False

            e2Week5Mon.Visible = False
            Label101.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek5Tue()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Tuesday' AND week = 'Week5' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek5TueLoad()
        connectToDB()
        con.Open()

        JulyWeek5Tue()

        If event1Full = True And event2Full = False Then
            e1Week5Tue.Visible = True
            Label102.Visible = True
            Label102.Text = event1.ToString

            e2Week5Tue.Visible = False
            Label103.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week5Tue.Visible = False
            Label102.Visible = False

            e2Week5Tue.Visible = True
            Label103.Visible = True
            Label103.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week5Tue.Visible = True
            Label102.Visible = True
            Label102.Text = event1.ToString

            e2Week5Tue.Visible = True
            Label103.Visible = True
            Label103.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week5Tue.Visible = False
            Label102.Visible = False

            e2Week5Tue.Visible = False
            Label103.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub JulyWeek5Wed()
        'Week5
        sql = "SELECT * FROM CALENDAR WHERE day = 'Wednesday' AND week = 'Week5' AND months = 'July' AND year = '2024'"

        da = New MySqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da.Fill(ds1, "CJuly")

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("day")) = False Then
            day = ds1.Tables("CJuly").Rows(0).Item("day")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("week")) = False Then
            week = ds1.Tables("CJuly").Rows(0).Item("week")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("months")) = False Then
            month = ds1.Tables("CJuly").Rows(0).Item("months")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("year")) = False Then
            year = ds1.Tables("CJuly").Rows(0).Item("year")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("eventCount")) = False Then
            eventCount = Integer.Parse(ds1.Tables("CJuly").Rows(0).Item("eventCount"))
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1")) = False Then
            event1 = ds1.Tables("CJuly").Rows(0).Item("event1")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2")) = False Then
            event2 = ds1.Tables("CJuly").Rows(0).Item("event2")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event1Full")) = False Then
            event1Full = ds1.Tables("CJuly").Rows(0).Item("event1Full")
        End If

        If IsDBNull(ds1.Tables("CJuly").Rows(0).Item("event2Full")) = False Then
            event2Full = ds1.Tables("CJuly").Rows(0).Item("event2Full")
        End If

    End Sub

    Private Sub JulyWeek5WedLoad()
        connectToDB()
        con.Open()

        JulyWeek5Wed()

        If event1Full = True And event2Full = False Then
            e1Week5Wed.Visible = True
            Label104.Visible = True
            Label104.Text = event1.ToString

            e2Week5Wed.Visible = False
            Label105.Visible = False

        ElseIf event1Full = False And event2Full = True Then
            e1Week5Wed.Visible = False
            Label104.Visible = False

            e2Week5Wed.Visible = True
            Label105.Visible = True
            Label105.Text = event2.ToString

        ElseIf event1Full = True And event2Full = True Then
            e1Week5Wed.Visible = True
            Label104.Visible = True
            Label104.Text = event1.ToString

            e2Week5Wed.Visible = True
            Label105.Visible = True
            Label105.Text = event2.ToString

        ElseIf event1Full = False And event2Full = False Then
            e1Week5Wed.Visible = False
            Label104.Visible = False

            e2Week5Wed.Visible = False
            Label105.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub eventVerification()

        If eventCount >= 2 Then
            eventFull = True
            EventFullPrompt.ShowDialog()
            If EventFullPrompt.optionYes = True Then
                Remove()

            ElseIf EventFullPrompt.optionNo = True Then
                MessageBox.Show("No changes")
            End If

        ElseIf eventCount = 1 Then
            eventFull = False
            EventPrompt1.ShowDialog()

            If event1Full = True Then
                If EventPrompt1.eventConfirmed = True Then
                    'Gets event2 info
                    eventCount += 1
                    event2 = EventPrompt1.tempEvent
                    event2Full = True

                    sql = "UPDATE CALENDAR SET eventCount =" & eventCount &
                 ", event2 ='" & event2 &
                 "', event2Full =" & event2Full &
                 " WHERE day ='" & day &
                 "' AND week ='" & week &
                 "' AND months ='" & month & "'"

                    Dim cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Event Successfully added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    EventPrompt1.eventConfirmed = False
                    EventPrompt1.eventConfirmed = False

                End If

                If EventPrompt1.eventRemoveAttempt = True Then
                    Remove()
                End If

            ElseIf event2Full = True Then
                If EventPrompt1.eventConfirmed = True Then
                    'Gets event1 info
                    event1 = EventPrompt1.tempEvent
                    eventCount += 1
                    event1Full = True

                    sql = "UPDATE CALENDAR SET eventCount =" & eventCount &
             ", event1 ='" & event1 &
             "', event1Full =" & event1Full &
             " WHERE day ='" & day &
             "' AND week ='" & week &
             "' AND months ='" & month & "'"

                    Dim cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Event Successfully added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    EventPrompt1.eventConfirmed = False
                    EventPrompt1.eventConfirmed = False
                End If

                If EventPrompt1.eventRemoveAttempt = True Then
                    Remove()
                End If

            End If


        ElseIf eventCount = 0 Then
            eventFull = False
            EventPrompt1.ShowDialog()

            If eventFull = False Then
                If EventPrompt1.eventConfirmed = True Then
                    event1 = EventPrompt1.tempEvent
                    eventCount += 1
                    event1Full = True

                    sql = "UPDATE CALENDAR SET eventCount =" & eventCount &
                 ", event1 ='" & event1 &
                 "', event1Full =" & event1Full &
                 " WHERE day ='" & day &
                 "' AND week ='" & week &
                 "' AND months ='" & month & "'"

                    Dim cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Event Successfully added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    EventPrompt1.eventConfirmed = False
                    EventPrompt1.eventConfirmed = False
                End If

                If EventPrompt1.eventRemoveAttempt = True Then
                    Remove()

                End If

            End If

        Else
            MessageBox.Show("Event is over 2, there is an error somewhere within the system." & vbCrLf &
                         "Please notify the administrators", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Reload()

    End Sub
    Private Sub Remove()
        EventRemovePrompt.ShowDialog()
        If EventRemovePrompt.event1Remove = True And EventRemovePrompt.event2Remove = True Then
            If event1Full = False And event2Full = False And EventRemovePrompt.event1Remove = True And EventRemovePrompt.event2Remove = True Then
                MessageBox.Show("Both event slot are empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            ElseIf event1Full = False And event2Full = True And EventRemovePrompt.event1Remove = True And EventRemovePrompt.event2Remove = True Then
                MessageBox.Show("Event 1 slot is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub


            ElseIf event2Full = False And event1Full = True And EventRemovePrompt.event1Remove = True And EventRemovePrompt.event2Remove = True Then
                MessageBox.Show("Event 2 slot is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            eventCount = 0
            event1Full = False
            event2Full = False
            sql2 = "UPDATE CALENDAR SET eventCount =" & eventCount &
     ", event1 ='" &
     "', event2 ='" &
     "', event1Full =" & "False" &
     ", event2Full =" & "False" &
     " WHERE day ='" & day &
     "' AND week ='" & week &
     "' AND months ='" & month & "'"

            Dim cmd2 = New MySqlCommand(sql2, con2)
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Both Event Successfully Removed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

            EventRemovePrompt.event1Remove = False
            EventRemovePrompt.event2Remove = False

        ElseIf EventRemovePrompt.event1Remove = True And EventRemovePrompt.event2Remove = False Then
            If event1Full = False And event2Full = False And EventRemovePrompt.event1Remove = True And EventRemovePrompt.event2Remove = False Then
                MessageBox.Show("Both event slot are empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            ElseIf event1Full = False And event2Full = True And EventRemovePrompt.event1Remove = True And EventRemovePrompt.event2Remove = False Then
                MessageBox.Show("Event 1 slot is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub



            End If
            eventCount -= 1
            event1Full = 1
            sql2 = "UPDATE CALENDAR SET eventCount =" & eventCount &
     ", event1 ='" &
     "', event1Full =" & "False" &
     " WHERE day ='" & day &
     "' AND week ='" & week &
     "' AND months ='" & month & "'"

            Dim cmd2 = New MySqlCommand(sql2, con2)
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Event Successfully Removed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

            EventRemovePrompt.event1Remove = False
            EventRemovePrompt.event2Remove = False

        ElseIf EventRemovePrompt.event2Remove = True And EventRemovePrompt.event1Remove = False Then
            If event1Full = False And event2Full = False And EventRemovePrompt.event2Remove = True And EventRemovePrompt.event1Remove = False Then
                MessageBox.Show("Both event slot are empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub




            ElseIf event2Full = False And event1Full = True And EventRemovePrompt.event2Remove = True And EventRemovePrompt.event1Remove = False Then
                MessageBox.Show("Event 2 slot is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            eventCount -= 1
            event2Full = 2
            sql2 = "UPDATE CALENDAR SET eventCount =" & eventCount &
     ", event2 ='" &
     "', event2Full =" & "False" &
     " WHERE day ='" & day &
     "' AND week ='" & week &
     "' AND months ='" & month & "'"

            Dim cmd2 = New MySqlCommand(sql2, con2)
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Event Successfully Removed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

            EventRemovePrompt.event1Remove = False
            EventRemovePrompt.event2Remove = False

        ElseIf EventRemovePrompt.eventCancel = True Then
            MessageBox.Show("Event Removal Process Aborted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub Reload()
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1MonLoad()
            JulyWeek1TueLoad()
            JulyWeek1WedLoad()
            JulyWeek1ThuLoad()
            JulyWeek1FriLoad()
            JulyWeek1SatLoad()

            JulyWeek2SunLoad()
            JulyWeek2MonLoad()
            JulyWeek2TueLoad()
            JulyWeek2WedLoad()
            JulyWeek2ThuLoad()
            JulyWeek2FriLoad()
            JulyWeek2SatLoad()

            JulyWeek3SunLoad()
            JulyWeek3MonLoad()
            JulyWeek3TueLoad()
            JulyWeek3WedLoad()
            JulyWeek3ThuLoad()
            JulyWeek3FriLoad()
            JulyWeek3SatLoad()

            JulyWeek4SunLoad()
            JulyWeek4MonLoad()
            JulyWeek4TueLoad()
            JulyWeek4WedLoad()
            JulyWeek4ThuLoad()
            JulyWeek4FriLoad()
            JulyWeek4SatLoad()

            JulyWeek5SunLoad()
            JulyWeek5MonLoad()
            JulyWeek5TueLoad()
            JulyWeek5WedLoad()

            con2.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub CalendarJuly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1MonLoad()
            JulyWeek1TueLoad()
            JulyWeek1WedLoad()
            JulyWeek1ThuLoad()
            JulyWeek1FriLoad()
            JulyWeek1SatLoad()

            JulyWeek2SunLoad()
            JulyWeek2MonLoad()
            JulyWeek2TueLoad()
            JulyWeek2WedLoad()
            JulyWeek2ThuLoad()
            JulyWeek2FriLoad()
            JulyWeek2SatLoad()

            JulyWeek3SunLoad()
            JulyWeek3MonLoad()
            JulyWeek3TueLoad()
            JulyWeek3WedLoad()
            JulyWeek3ThuLoad()
            JulyWeek3FriLoad()
            JulyWeek3SatLoad()

            JulyWeek4SunLoad()
            JulyWeek4MonLoad()
            JulyWeek4TueLoad()
            JulyWeek4WedLoad()
            JulyWeek4ThuLoad()
            JulyWeek4FriLoad()
            JulyWeek4SatLoad()

            JulyWeek5SunLoad()
            JulyWeek5MonLoad()
            JulyWeek5TueLoad()
            JulyWeek5WedLoad()

            con2.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        MessageBox.Show("The upcoming month's data is currently unavailable.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        MessageBox.Show("Data for the previous month is currently unavailable.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub panelWeek1Mon_Click(sender As Object, e As EventArgs) Handles panelWeek1Mon.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1Mon()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek1Tue_Click(sender As Object, e As EventArgs) Handles panelWeek1Tue.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1Tue()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek1Wed_Click(sender As Object, e As EventArgs) Handles panelWeek1Wed.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1Wed()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek1Thu_Click(sender As Object, e As EventArgs) Handles panelWeek1Thu.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1Thu()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek1Fri_Click(sender As Object, e As EventArgs) Handles panelWeek1Fri.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1Fri()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek1Sat_Click(sender As Object, e As EventArgs) Handles panelWeek1Sat.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek1Sat()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek2Sun_Click(sender As Object, e As EventArgs) Handles panelWeek2Sun.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek2Sun()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek2Mon_Click(sender As Object, e As EventArgs) Handles panelWeek2Mon.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek2Mon()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek2Tue_Click(sender As Object, e As EventArgs) Handles panelWeek2Tue.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek2Tue()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek2Wed_Click(sender As Object, e As EventArgs) Handles panelWeek2Wed.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek2Wed()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek2Thu_Click(sender As Object, e As EventArgs) Handles panelWeek2Thu.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek2Thu()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek2Fri_Click(sender As Object, e As EventArgs) Handles panelWeek2Fri.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek2Fri()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub panelWeek2Sat_Click(sender As Object, e As EventArgs) Handles panelWeek2Sat.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek2Sat()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek3Sun_Click(sender As Object, e As EventArgs) Handles panelWeek3Sun.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek3Sun()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek3Mon_Click(sender As Object, e As EventArgs) Handles panelWeek3Mon.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek3Mon()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek3Tue_Click(sender As Object, e As EventArgs) Handles panelWeek3Tue.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek3Tue()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek3Wed_Click(sender As Object, e As EventArgs) Handles panelWeek3Wed.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek3Wed()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek3Thu_Click(sender As Object, e As EventArgs) Handles panelWeek3Thu.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek3Thu()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek3Fri_Click(sender As Object, e As EventArgs) Handles panelWeek3Fri.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek3Fri()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek3Sat_Click(sender As Object, e As EventArgs) Handles panelWeek3Sat.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek3Sat()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek4Sun_Click(sender As Object, e As EventArgs) Handles panelWeek4Sun.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek4Sun()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek4Mon_Click(sender As Object, e As EventArgs) Handles panelWeek4Mon.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek4Mon()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek4Tue_Click(sender As Object, e As EventArgs) Handles panelWeek4Tue.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek4Tue()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek4Wed_Click(sender As Object, e As EventArgs) Handles panelWeek4Wed.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek4Wed()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek4Thu_Click(sender As Object, e As EventArgs) Handles panelWeek4Thu.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek4Thu()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek4Fri_Click(sender As Object, e As EventArgs) Handles panelWeek4Fri.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek4Fri()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek4Sat_Click(sender As Object, e As EventArgs) Handles panelWeek4Sat.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek4Sat()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek5Sun_Click(sender As Object, e As EventArgs) Handles panelWeek5Sun.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek5Sun()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek5Mon_Click(sender As Object, e As EventArgs) Handles panelWeek5Mon.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek5Mon()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek5Tue_Click(sender As Object, e As EventArgs) Handles panelWeek5Tue.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek5Tue()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub panelWeek5Wed_Click(sender As Object, e As EventArgs) Handles panelWeek5Wed.Click
        Try
            connectToDB()
            con.Open()
            con2.Open()

            JulyWeek5Wed()

            eventVerification()

            con2.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
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
End Class

