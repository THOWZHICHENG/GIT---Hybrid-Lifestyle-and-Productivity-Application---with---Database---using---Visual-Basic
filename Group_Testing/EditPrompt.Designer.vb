<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPrompt
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbSunday = New System.Windows.Forms.RadioButton()
        Me.rdbSaturday = New System.Windows.Forms.RadioButton()
        Me.rdbFriday = New System.Windows.Forms.RadioButton()
        Me.rdbThursday = New System.Windows.Forms.RadioButton()
        Me.rdbWednesday = New System.Windows.Forms.RadioButton()
        Me.rdbTuesday = New System.Windows.Forms.RadioButton()
        Me.rdbMonday = New System.Windows.Forms.RadioButton()
        Me.cbxTimeSlot = New System.Windows.Forms.ComboBox()
        Me.lblSelectTime = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lblEnterContent = New System.Windows.Forms.Label()
        Me.lblEnterDay = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(233, 374)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(84, 46)
        Me.btnRemove.TabIndex = 39
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(126, 374)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 46)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(22, 374)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(84, 46)
        Me.btnConfirm.TabIndex = 37
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbSunday)
        Me.GroupBox1.Controls.Add(Me.rdbSaturday)
        Me.GroupBox1.Controls.Add(Me.rdbFriday)
        Me.GroupBox1.Controls.Add(Me.rdbThursday)
        Me.GroupBox1.Controls.Add(Me.rdbWednesday)
        Me.GroupBox1.Controls.Add(Me.rdbTuesday)
        Me.GroupBox1.Controls.Add(Me.rdbMonday)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(356, 112)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'rdbSunday
        '
        Me.rdbSunday.AutoSize = True
        Me.rdbSunday.Location = New System.Drawing.Point(223, 5)
        Me.rdbSunday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdbSunday.Name = "rdbSunday"
        Me.rdbSunday.Size = New System.Drawing.Size(88, 24)
        Me.rdbSunday.TabIndex = 13
        Me.rdbSunday.Text = "Sunday"
        Me.rdbSunday.UseVisualStyleBackColor = True
        '
        'rdbSaturday
        '
        Me.rdbSaturday.AutoSize = True
        Me.rdbSaturday.Location = New System.Drawing.Point(120, 70)
        Me.rdbSaturday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdbSaturday.Name = "rdbSaturday"
        Me.rdbSaturday.Size = New System.Drawing.Size(98, 24)
        Me.rdbSaturday.TabIndex = 12
        Me.rdbSaturday.Text = "Saturday"
        Me.rdbSaturday.UseVisualStyleBackColor = True
        '
        'rdbFriday
        '
        Me.rdbFriday.AutoSize = True
        Me.rdbFriday.Location = New System.Drawing.Point(120, 38)
        Me.rdbFriday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdbFriday.Name = "rdbFriday"
        Me.rdbFriday.Size = New System.Drawing.Size(77, 24)
        Me.rdbFriday.TabIndex = 11
        Me.rdbFriday.Text = "Friday"
        Me.rdbFriday.UseVisualStyleBackColor = True
        '
        'rdbThursday
        '
        Me.rdbThursday.AutoSize = True
        Me.rdbThursday.Location = New System.Drawing.Point(120, 5)
        Me.rdbThursday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdbThursday.Name = "rdbThursday"
        Me.rdbThursday.Size = New System.Drawing.Size(99, 24)
        Me.rdbThursday.TabIndex = 10
        Me.rdbThursday.Text = "Thursday"
        Me.rdbThursday.UseVisualStyleBackColor = True
        '
        'rdbWednesday
        '
        Me.rdbWednesday.AutoSize = True
        Me.rdbWednesday.Location = New System.Drawing.Point(3, 70)
        Me.rdbWednesday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdbWednesday.Name = "rdbWednesday"
        Me.rdbWednesday.Size = New System.Drawing.Size(118, 24)
        Me.rdbWednesday.TabIndex = 9
        Me.rdbWednesday.Text = "Wednesday"
        Me.rdbWednesday.UseVisualStyleBackColor = True
        '
        'rdbTuesday
        '
        Me.rdbTuesday.AutoSize = True
        Me.rdbTuesday.Location = New System.Drawing.Point(3, 38)
        Me.rdbTuesday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdbTuesday.Name = "rdbTuesday"
        Me.rdbTuesday.Size = New System.Drawing.Size(94, 24)
        Me.rdbTuesday.TabIndex = 8
        Me.rdbTuesday.Text = "Tuesday"
        Me.rdbTuesday.UseVisualStyleBackColor = True
        '
        'rdbMonday
        '
        Me.rdbMonday.AutoSize = True
        Me.rdbMonday.Checked = True
        Me.rdbMonday.Location = New System.Drawing.Point(3, 5)
        Me.rdbMonday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdbMonday.Name = "rdbMonday"
        Me.rdbMonday.Size = New System.Drawing.Size(90, 24)
        Me.rdbMonday.TabIndex = 7
        Me.rdbMonday.TabStop = True
        Me.rdbMonday.Text = "Monday"
        Me.rdbMonday.UseVisualStyleBackColor = True
        '
        'cbxTimeSlot
        '
        Me.cbxTimeSlot.FormattingEnabled = True
        Me.cbxTimeSlot.Items.AddRange(New Object() {"0000 - 0200", "0200 - 0400", "0400 - 0600", "0600 - 0800", "0800 - 1000", "1000 - 1200", "1200 - 1400", "1400 - 1600", "1600 - 1800", "1800 - 2000", "2000 - 2200", "2200 - 0000"})
        Me.cbxTimeSlot.Location = New System.Drawing.Point(22, 227)
        Me.cbxTimeSlot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxTimeSlot.Name = "cbxTimeSlot"
        Me.cbxTimeSlot.Size = New System.Drawing.Size(136, 28)
        Me.cbxTimeSlot.TabIndex = 35
        Me.cbxTimeSlot.Text = "0000 - 0200"
        '
        'lblSelectTime
        '
        Me.lblSelectTime.AutoSize = True
        Me.lblSelectTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectTime.Location = New System.Drawing.Point(12, 182)
        Me.lblSelectTime.Name = "lblSelectTime"
        Me.lblSelectTime.Size = New System.Drawing.Size(345, 38)
        Me.lblSelectTime.TabIndex = 34
        Me.lblSelectTime.Text = "Please select the time "
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContent.Location = New System.Drawing.Point(19, 318)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(357, 35)
        Me.txtContent.TabIndex = 33
        '
        'lblEnterContent
        '
        Me.lblEnterContent.AutoSize = True
        Me.lblEnterContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterContent.Location = New System.Drawing.Point(12, 274)
        Me.lblEnterContent.Name = "lblEnterContent"
        Me.lblEnterContent.Size = New System.Drawing.Size(370, 38)
        Me.lblEnterContent.TabIndex = 32
        Me.lblEnterContent.Text = "Please enter the content"
        '
        'lblEnterDay
        '
        Me.lblEnterDay.AutoSize = True
        Me.lblEnterDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterDay.Location = New System.Drawing.Point(12, 9)
        Me.lblEnterDay.Name = "lblEnterDay"
        Me.lblEnterDay.Size = New System.Drawing.Size(316, 38)
        Me.lblEnterDay.TabIndex = 31
        Me.lblEnterDay.Text = "Please enter the day"
        '
        'EditPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 464)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbxTimeSlot)
        Me.Controls.Add(Me.lblSelectTime)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.lblEnterContent)
        Me.Controls.Add(Me.lblEnterDay)
        Me.Name = "EditPrompt"
        Me.Text = "EditPrompt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbSunday As RadioButton
    Friend WithEvents rdbSaturday As RadioButton
    Friend WithEvents rdbFriday As RadioButton
    Friend WithEvents rdbThursday As RadioButton
    Friend WithEvents rdbWednesday As RadioButton
    Friend WithEvents rdbTuesday As RadioButton
    Friend WithEvents rdbMonday As RadioButton
    Friend WithEvents cbxTimeSlot As ComboBox
    Friend WithEvents lblSelectTime As Label
    Friend WithEvents txtContent As TextBox
    Friend WithEvents lblEnterContent As Label
    Friend WithEvents lblEnterDay As Label
End Class
