<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetingSystem
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Logo = New System.Windows.Forms.PictureBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_alert = New System.Windows.Forms.Label()
        Me.lbl_totalExpenses = New System.Windows.Forms.Label()
        Me.Splitter3 = New System.Windows.Forms.Splitter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_maximumBudget = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_expenses = New System.Windows.Forms.Button()
        Me.btn_income = New System.Windows.Forms.Button()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Back.Image = Global.Group_Testing.My.Resources.Resources.backButtonDesign2_100x501
        Me.btn_Back.Location = New System.Drawing.Point(3, 122)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(120, 61)
        Me.btn_Back.TabIndex = 152
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Logo
        '
        Me.btn_Logo.Image = Global.Group_Testing.My.Resources.Resources.logoDesign3_1200x1200
        Me.btn_Logo.Location = New System.Drawing.Point(3, 0)
        Me.btn_Logo.Name = "btn_Logo"
        Me.btn_Logo.Size = New System.Drawing.Size(120, 120)
        Me.btn_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Logo.TabIndex = 153
        Me.btn_Logo.TabStop = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Location = New System.Drawing.Point(199, 263)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(138, 45)
        Me.btn_clear.TabIndex = 165
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(281, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 32)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "To"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(327, 202)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.MaxDate = New Date(2025, 1, 26, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(1780, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(224, 51)
        Me.DateTimePicker2.TabIndex = 162
        Me.DateTimePicker2.Value = New Date(2024, 8, 8, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(50, 202)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.MaxDate = New Date(2025, 1, 26, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1780, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(224, 51)
        Me.DateTimePicker1.TabIndex = 161
        Me.DateTimePicker1.Value = New Date(2024, 8, 8, 0, 0, 0, 0)
        '
        'lbl_alert
        '
        Me.lbl_alert.AutoSize = True
        Me.lbl_alert.BackColor = System.Drawing.Color.Transparent
        Me.lbl_alert.Font = New System.Drawing.Font("Segoe UI", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alert.ForeColor = System.Drawing.Color.Red
        Me.lbl_alert.Location = New System.Drawing.Point(1098, 731)
        Me.lbl_alert.Name = "lbl_alert"
        Me.lbl_alert.Size = New System.Drawing.Size(316, 21)
        Me.lbl_alert.TabIndex = 157
        Me.lbl_alert.Text = "*Please Update Your Balance Amount !!!*"
        Me.lbl_alert.Visible = False
        '
        'lbl_totalExpenses
        '
        Me.lbl_totalExpenses.AutoSize = True
        Me.lbl_totalExpenses.BackColor = System.Drawing.Color.Khaki
        Me.lbl_totalExpenses.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalExpenses.ForeColor = System.Drawing.Color.Goldenrod
        Me.lbl_totalExpenses.Location = New System.Drawing.Point(15, 179)
        Me.lbl_totalExpenses.Name = "lbl_totalExpenses"
        Me.lbl_totalExpenses.Size = New System.Drawing.Size(202, 65)
        Me.lbl_totalExpenses.TabIndex = 2
        Me.lbl_totalExpenses.Text = "RM0.00"
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.Color.Khaki
        Me.Splitter3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter3.Location = New System.Drawing.Point(0, 160)
        Me.Splitter3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(406, 100)
        Me.Splitter3.TabIndex = 1
        Me.Splitter3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Khaki
        Me.Label7.Location = New System.Drawing.Point(17, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 45)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Expenses"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel5.Controls.Add(Me.lbl_totalExpenses)
        Me.Panel5.Controls.Add(Me.Splitter3)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(562, 468)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(406, 260)
        Me.Panel5.TabIndex = 159
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.BackColor = System.Drawing.Color.MistyRose
        Me.lbl_balance.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_balance.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_balance.Location = New System.Drawing.Point(16, 179)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(202, 65)
        Me.lbl_balance.TabIndex = 2
        Me.lbl_balance.Text = "RM0.00"
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.Color.MistyRose
        Me.Splitter2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 160)
        Me.Splitter2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(406, 100)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MistyRose
        Me.Label5.Location = New System.Drawing.Point(18, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 45)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Balance Amount"
        '
        'lbl_maximumBudget
        '
        Me.lbl_maximumBudget.AutoSize = True
        Me.lbl_maximumBudget.BackColor = System.Drawing.Color.LightCyan
        Me.lbl_maximumBudget.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maximumBudget.ForeColor = System.Drawing.Color.CadetBlue
        Me.lbl_maximumBudget.Location = New System.Drawing.Point(15, 179)
        Me.lbl_maximumBudget.Name = "lbl_maximumBudget"
        Me.lbl_maximumBudget.Size = New System.Drawing.Size(202, 65)
        Me.lbl_maximumBudget.TabIndex = 2
        Me.lbl_maximumBudget.Text = "RM0.00"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.LightCyan
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 160)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(406, 100)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Tomato
        Me.Panel4.Controls.Add(Me.lbl_balance)
        Me.Panel4.Controls.Add(Me.Splitter2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(1058, 468)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(406, 260)
        Me.Panel4.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 45)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Maximum Budget"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.lbl_maximumBudget)
        Me.Panel3.Controls.Add(Me.Splitter1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(66, 468)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(406, 260)
        Me.Panel3.TabIndex = 158
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Black
        Me.lbl_username.Location = New System.Drawing.Point(25, 29)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(302, 45)
        Me.lbl_username.TabIndex = 4
        Me.lbl_username.Text = "Budgeting System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(343, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(874, 128)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Budgeting System"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_username)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 807)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1516, 94)
        Me.Panel2.TabIndex = 156
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.Transparent
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_report.ForeColor = System.Drawing.Color.White
        Me.btn_report.Location = New System.Drawing.Point(573, 4)
        Me.btn_report.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(281, 177)
        Me.btn_report.TabIndex = 3
        Me.btn_report.Text = "REPORT"
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'btn_expenses
        '
        Me.btn_expenses.BackColor = System.Drawing.Color.Transparent
        Me.btn_expenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_expenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_expenses.FlatAppearance.BorderSize = 0
        Me.btn_expenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btn_expenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_expenses.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_expenses.ForeColor = System.Drawing.Color.White
        Me.btn_expenses.Location = New System.Drawing.Point(288, 4)
        Me.btn_expenses.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_expenses.Name = "btn_expenses"
        Me.btn_expenses.Size = New System.Drawing.Size(279, 177)
        Me.btn_expenses.TabIndex = 2
        Me.btn_expenses.Text = "EXPENSES"
        Me.btn_expenses.UseVisualStyleBackColor = False
        '
        'btn_income
        '
        Me.btn_income.BackColor = System.Drawing.Color.Transparent
        Me.btn_income.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_income.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_income.FlatAppearance.BorderSize = 0
        Me.btn_income.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive
        Me.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_income.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_income.ForeColor = System.Drawing.Color.White
        Me.btn_income.Location = New System.Drawing.Point(3, 4)
        Me.btn_income.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_income.Name = "btn_income"
        Me.btn_income.Size = New System.Drawing.Size(279, 177)
        Me.btn_income.TabIndex = 1
        Me.btn_income.Text = "INCOME"
        Me.btn_income.UseVisualStyleBackColor = False
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_time.Location = New System.Drawing.Point(155, 74)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(102, 38)
        Me.lbl_time.TabIndex = 5
        Me.lbl_time.Text = "Label3"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_date.Location = New System.Drawing.Point(154, 26)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(121, 45)
        Me.lbl_date.TabIndex = 4
        Me.lbl_date.Text = "Label8"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_report, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_expenses, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_income, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(659, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(857, 185)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_filter
        '
        Me.btn_filter.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_filter.FlatAppearance.BorderSize = 0
        Me.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_filter.ForeColor = System.Drawing.Color.White
        Me.btn_filter.Location = New System.Drawing.Point(50, 263)
        Me.btn_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(128, 45)
        Me.btn_filter.TabIndex = 164
        Me.btn_filter.Text = "FILTER"
        Me.btn_filter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lbl_time)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btn_Logo)
        Me.Panel1.Controls.Add(Me.btn_Back)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1516, 185)
        Me.Panel1.TabIndex = 154
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BudgetingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1516, 901)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_alert)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BudgetingSystem"
        Me.Text = "BudgetingSystem"
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Logo As PictureBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_alert As Label
    Friend WithEvents lbl_totalExpenses As Label
    Friend WithEvents Splitter3 As Splitter
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_balance As Label
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_maximumBudget As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_username As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_expenses As Button
    Friend WithEvents btn_income As Button
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_filter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
End Class
