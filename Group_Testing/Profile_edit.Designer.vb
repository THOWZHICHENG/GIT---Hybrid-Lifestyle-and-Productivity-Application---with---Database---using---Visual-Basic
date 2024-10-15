<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile_edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_DOB = New System.Windows.Forms.DateTimePicker()
        Me.rdb_Female = New System.Windows.Forms.RadioButton()
        Me.rdb_Male = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_userName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Profile_Avatar = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Logo = New System.Windows.Forms.PictureBox()
        CType(Me.Profile_Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.Control
        Me.btn_save.Location = New System.Drawing.Point(1008, 588)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 50)
        Me.btn_save.TabIndex = 125
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cancel.Location = New System.Drawing.Point(1134, 588)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 50)
        Me.btn_cancel.TabIndex = 124
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(576, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 31)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Date of Birth:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_DOB
        '
        Me.dtp_DOB.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtp_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DOB.Location = New System.Drawing.Point(750, 473)
        Me.dtp_DOB.MaxDate = New Date(2025, 1, 26, 0, 0, 0, 0)
        Me.dtp_DOB.MinDate = New Date(1780, 1, 1, 0, 0, 0, 0)
        Me.dtp_DOB.Name = "dtp_DOB"
        Me.dtp_DOB.Size = New System.Drawing.Size(263, 30)
        Me.dtp_DOB.TabIndex = 121
        Me.dtp_DOB.Value = New Date(2024, 8, 8, 0, 0, 0, 0)
        '
        'rdb_Female
        '
        Me.rdb_Female.AutoSize = True
        Me.rdb_Female.BackColor = System.Drawing.Color.LightSteelBlue
        Me.rdb_Female.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rdb_Female.Location = New System.Drawing.Point(840, 407)
        Me.rdb_Female.Name = "rdb_Female"
        Me.rdb_Female.Size = New System.Drawing.Size(102, 29)
        Me.rdb_Female.TabIndex = 120
        Me.rdb_Female.TabStop = True
        Me.rdb_Female.Text = "Female"
        Me.rdb_Female.UseVisualStyleBackColor = False
        '
        'rdb_Male
        '
        Me.rdb_Male.AutoSize = True
        Me.rdb_Male.BackColor = System.Drawing.Color.LightSteelBlue
        Me.rdb_Male.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rdb_Male.Location = New System.Drawing.Point(750, 407)
        Me.rdb_Male.Name = "rdb_Male"
        Me.rdb_Male.Size = New System.Drawing.Size(80, 29)
        Me.rdb_Male.TabIndex = 119
        Me.rdb_Male.TabStop = True
        Me.rdb_Male.Text = "Male"
        Me.rdb_Male.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(576, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 31)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Gender:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(576, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 31)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Email:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Email
        '
        Me.txt_Email.BackColor = System.Drawing.Color.Azure
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_Email.Location = New System.Drawing.Point(581, 336)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.ReadOnly = True
        Me.txt_Email.Size = New System.Drawing.Size(527, 35)
        Me.txt_Email.TabIndex = 116
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(576, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 31)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Username:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_userName
        '
        Me.txt_userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_userName.Location = New System.Drawing.Point(581, 234)
        Me.txt_userName.Name = "txt_userName"
        Me.txt_userName.Size = New System.Drawing.Size(527, 35)
        Me.txt_userName.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(869, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 31)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Last Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_lastName
        '
        Me.txt_lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_lastName.Location = New System.Drawing.Point(874, 136)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(234, 35)
        Me.txt_lastName.TabIndex = 112
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(576, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(254, 31)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "First Name:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_firstName
        '
        Me.txt_firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_firstName.Location = New System.Drawing.Point(581, 136)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(236, 35)
        Me.txt_firstName.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(139, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1095, 534)
        Me.Label8.TabIndex = 123
        '
        'Profile_Avatar
        '
        Me.Profile_Avatar.Image = Global.Group_Testing.My.Resources.Resources.Avatar
        Me.Profile_Avatar.Location = New System.Drawing.Point(209, 92)
        Me.Profile_Avatar.Name = "Profile_Avatar"
        Me.Profile_Avatar.Size = New System.Drawing.Size(302, 322)
        Me.Profile_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Profile_Avatar.TabIndex = 107
        Me.Profile_Avatar.TabStop = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.Image = Global.Group_Testing.My.Resources.Resources.backButtonDesign2_100x501
        Me.btn_Back.Location = New System.Drawing.Point(2, 126)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(120, 61)
        Me.btn_Back.TabIndex = 153
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Logo
        '
        Me.btn_Logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Logo.Image = Global.Group_Testing.My.Resources.Resources.logoDesign3_1200x1200
        Me.btn_Logo.Location = New System.Drawing.Point(2, 3)
        Me.btn_Logo.Name = "btn_Logo"
        Me.btn_Logo.Size = New System.Drawing.Size(120, 120)
        Me.btn_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Logo.TabIndex = 152
        Me.btn_Logo.TabStop = False
        '
        'Profile_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1353, 720)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Logo)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_DOB)
        Me.Controls.Add(Me.rdb_Female)
        Me.Controls.Add(Me.rdb_Male)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_userName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_firstName)
        Me.Controls.Add(Me.Profile_Avatar)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Profile_edit"
        Me.Text = "Profile_edit"
        CType(Me.Profile_Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_DOB As DateTimePicker
    Friend WithEvents rdb_Female As RadioButton
    Friend WithEvents rdb_Male As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_userName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents Profile_Avatar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Logo As PictureBox
End Class
