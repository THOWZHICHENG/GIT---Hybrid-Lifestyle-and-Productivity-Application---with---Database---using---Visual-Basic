<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenses
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.tbx_remarks = New System.Windows.Forms.TextBox()
        Me.tbx_amount = New System.Windows.Forms.TextBox()
        Me.cbx_categories = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Date:"
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(62, 54)
        Me.dtp_date.MaxDate = New Date(2025, 1, 26, 0, 0, 0, 0)
        Me.dtp_date.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(343, 35)
        Me.dtp_date.TabIndex = 18
        Me.dtp_date.Value = New Date(2024, 8, 8, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 29)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Remarks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Amount (RM):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Category:"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(62, 375)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(343, 61)
        Me.btn_save.TabIndex = 14
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'tbx_remarks
        '
        Me.tbx_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbx_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbx_remarks.Location = New System.Drawing.Point(62, 289)
        Me.tbx_remarks.Multiline = True
        Me.tbx_remarks.Name = "tbx_remarks"
        Me.tbx_remarks.Size = New System.Drawing.Size(343, 71)
        Me.tbx_remarks.TabIndex = 13
        '
        'tbx_amount
        '
        Me.tbx_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbx_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbx_amount.Location = New System.Drawing.Point(62, 211)
        Me.tbx_amount.Name = "tbx_amount"
        Me.tbx_amount.Size = New System.Drawing.Size(343, 35)
        Me.tbx_amount.TabIndex = 12
        '
        'cbx_categories
        '
        Me.cbx_categories.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbx_categories.FormattingEnabled = True
        Me.cbx_categories.Location = New System.Drawing.Point(62, 130)
        Me.cbx_categories.Margin = New System.Windows.Forms.Padding(4)
        Me.cbx_categories.Name = "cbx_categories"
        Me.cbx_categories.Size = New System.Drawing.Size(343, 37)
        Me.cbx_categories.TabIndex = 11
        '
        'Expenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(476, 466)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.tbx_remarks)
        Me.Controls.Add(Me.tbx_amount)
        Me.Controls.Add(Me.cbx_categories)
        Me.Name = "Expenses"
        Me.Text = "Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents tbx_remarks As TextBox
    Friend WithEvents tbx_amount As TextBox
    Friend WithEvents cbx_categories As ComboBox
End Class
