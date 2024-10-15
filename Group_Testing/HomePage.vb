Public Class HomePage
    Dim pl As Integer = 60
    Private isExpanded As Boolean = False
    Public countBudget As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isExpanded = False Then
            If pl >= 450 Then
                Timer1.Stop()
                isExpanded = True
            Else
                pl += 15
                Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl)
            End If
        Else
            If pl <= 60 Then
                Timer1.Stop()
                isExpanded = False
            Else
                pl -= 30
                Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl)
            End If
        End If
    End Sub

    Private Sub btn_Calender_Click(sender As Object, e As EventArgs) Handles btn_Calender.Click
        Me.Hide()
        CalendarJul.Show()
    End Sub

    Private Sub btn_Diet_Click(sender As Object, e As EventArgs) Handles btn_Diet.Click
        Me.Hide()
        Diet_Drinks.Show()
    End Sub


    Private Sub btn_Profile_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Profile_label.Show()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl)
    End Sub

    Private Sub btn_BudgetSystem_Click_1(sender As Object, e As EventArgs) Handles btn_BudgetSystem.Click
        Me.Hide()
        BudgetingSystem.Show()
    End Sub

    Private Sub btn_TimeTable_Click_1(sender As Object, e As EventArgs) Handles btn_TimeTable.Click
        Me.Hide()
        Timetable.Show()
    End Sub

    Private Sub btn_Notepad_Click_1(sender As Object, e As EventArgs) Handles btn_Notepad.Click
        Me.Hide()
        Notepad.Show()
    End Sub

    Private Sub btn_ToDoList_Click_1(sender As Object, e As EventArgs) Handles btn_ToDoList.Click
        Me.Hide()
        ToDoList.Show()
    End Sub

    Private Sub btn_Cloth_Click(sender As Object, e As EventArgs) Handles btn_Cloth.Click
        Me.Hide()
        Clothing.Show()
    End Sub

    Private Sub pic_ToDoList_Click(sender As Object, e As EventArgs) Handles pic_ToDoList.Click
        Me.Hide()
        ToDoList.Show()
    End Sub

    Private Sub pic_Calender_Click(sender As Object, e As EventArgs) Handles pic_Calender.Click
        Me.Hide()
        CalendarJul.Show()
    End Sub

    Private Sub btn_Profile_Click_1(sender As Object, e As EventArgs) Handles btn_Profile.Click
        Me.Hide()
        Profile_label.Show()
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        Timer1.Start()
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        txt_dropbox.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        txt_dropbox.Visible = False
    End Sub

    Private Sub btn_Calender_MouseHover(sender As Object, e As EventArgs) Handles btn_Calender.MouseHover
        txt_Calendar.Visible = True
    End Sub

    Private Sub btn_Calender_MouseLeave(sender As Object, e As EventArgs) Handles btn_Calender.MouseLeave
        txt_Calendar.Visible = False
    End Sub

    Private Sub btn_TimeTable_MouseHover(sender As Object, e As EventArgs) Handles btn_TimeTable.MouseHover
        txt_TimeTable.Visible = True
    End Sub

    Private Sub btn_TimeTable_MouseLeave(sender As Object, e As EventArgs) Handles btn_TimeTable.MouseLeave
        txt_TimeTable.Visible = False
    End Sub

    Private Sub btn_Notepad_MouseHover(sender As Object, e As EventArgs) Handles btn_Notepad.MouseHover
        txt_Notepad.Visible = True
    End Sub

    Private Sub btn_Notepad_MouseLeave(sender As Object, e As EventArgs) Handles btn_Notepad.MouseLeave
        txt_Notepad.Visible = False
    End Sub

    Private Sub btn_ToDoList_MouseHover(sender As Object, e As EventArgs) Handles btn_ToDoList.MouseHover
        txt_ToDoList.Visible = True
    End Sub

    Private Sub btn_ToDoList_MouseLeave(sender As Object, e As EventArgs) Handles btn_ToDoList.MouseLeave
        txt_ToDoList.Visible = False
    End Sub

    Private Sub btn_Diet_MouseHover(sender As Object, e As EventArgs) Handles btn_Diet.MouseHover
        txt_DietSystem.Visible = True
    End Sub

    Private Sub btn_Diet_MouseLeave(sender As Object, e As EventArgs) Handles btn_Diet.MouseLeave
        txt_DietSystem.Visible = False
    End Sub

    Private Sub btn_Cloth_MouseHover(sender As Object, e As EventArgs) Handles btn_Cloth.MouseHover
        txt_ClothingSystem.Visible = True
    End Sub

    Private Sub btn_Cloth_MouseLeave(sender As Object, e As EventArgs) Handles btn_Cloth.MouseLeave
        txt_ClothingSystem.Visible = False
    End Sub

    Private Sub btn_BudgetSystem_MouseHover(sender As Object, e As EventArgs) Handles btn_BudgetSystem.MouseHover
        txt_BudgetSystem.Visible = True
    End Sub

    Private Sub btn_BudgetSystem_MouseLeave(sender As Object, e As EventArgs) Handles btn_BudgetSystem.MouseLeave
        txt_BudgetSystem.Visible = False
    End Sub

    Private Sub btn_Profile_MouseHover(sender As Object, e As EventArgs) Handles btn_Profile.MouseHover
        txt_Profile.Visible = True
    End Sub

    Private Sub btn_Profile_MouseLeave(sender As Object, e As EventArgs) Handles btn_Profile.MouseLeave
        txt_Profile.Visible = False
    End Sub


    'Timer1.Stop()
    'pl = 50
    'Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl)
End Class