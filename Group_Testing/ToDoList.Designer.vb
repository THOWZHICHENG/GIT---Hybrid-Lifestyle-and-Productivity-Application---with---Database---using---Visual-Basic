<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToDoList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_objective = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.cbx_status = New System.Windows.Forms.ComboBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cbx_priority = New System.Windows.Forms.ComboBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Logo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_filter = New System.Windows.Forms.ComboBox()
        Me.dataGridViewToDoList = New System.Windows.Forms.DataGridView()
        Me.btn_clearAllObjective = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridViewToDoList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_objective)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btn_update)
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.cbx_status)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.cbx_priority)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(794, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(686, 621)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 478)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 29)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Priority:"
        '
        'txt_objective
        '
        Me.txt_objective.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_objective.Location = New System.Drawing.Point(39, 116)
        Me.txt_objective.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_objective.Multiline = True
        Me.txt_objective.Name = "txt_objective"
        Me.txt_objective.Size = New System.Drawing.Size(379, 124)
        Me.txt_objective.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 29)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Status:"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.White
        Me.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(522, 512)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(123, 42)
        Me.btn_clear.TabIndex = 22
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Insert Objective:"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.White
        Me.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(522, 385)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(123, 42)
        Me.btn_update.TabIndex = 21
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.White
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(522, 251)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(123, 42)
        Me.btn_delete.TabIndex = 20
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'cbx_status
        '
        Me.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_status.FormattingEnabled = True
        Me.cbx_status.Location = New System.Drawing.Point(40, 350)
        Me.cbx_status.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbx_status.Name = "cbx_status"
        Me.cbx_status.Size = New System.Drawing.Size(198, 37)
        Me.cbx_status.TabIndex = 17
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.White
        Me.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(522, 115)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(123, 42)
        Me.btn_add.TabIndex = 19
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'cbx_priority
        '
        Me.cbx_priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_priority.FormattingEnabled = True
        Me.cbx_priority.ItemHeight = 29
        Me.cbx_priority.Location = New System.Drawing.Point(39, 534)
        Me.cbx_priority.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbx_priority.Name = "cbx_priority"
        Me.cbx_priority.Size = New System.Drawing.Size(198, 37)
        Me.cbx_priority.TabIndex = 18
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.Image = Global.Group_Testing.My.Resources.Resources.backButtonDesign2_100x501
        Me.btn_Back.Location = New System.Drawing.Point(1, 124)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(120, 61)
        Me.btn_Back.TabIndex = 155
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Logo
        '
        Me.btn_Logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Logo.Image = Global.Group_Testing.My.Resources.Resources.logoDesign3_1200x1200
        Me.btn_Logo.Location = New System.Drawing.Point(1, 1)
        Me.btn_Logo.Name = "btn_Logo"
        Me.btn_Logo.Size = New System.Drawing.Size(120, 120)
        Me.btn_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Logo.TabIndex = 154
        Me.btn_Logo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbx_filter)
        Me.GroupBox1.Controls.Add(Me.dataGridViewToDoList)
        Me.GroupBox1.Controls.Add(Me.btn_clearAllObjective)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(159, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(593, 870)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "To-Do-List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(290, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 29)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Filter:"
        '
        'cbx_filter
        '
        Me.cbx_filter.FormattingEnabled = True
        Me.cbx_filter.Location = New System.Drawing.Point(364, 28)
        Me.cbx_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbx_filter.Name = "cbx_filter"
        Me.cbx_filter.Size = New System.Drawing.Size(191, 37)
        Me.cbx_filter.TabIndex = 26
        Me.cbx_filter.Text = "All"
        '
        'dataGridViewToDoList
        '
        Me.dataGridViewToDoList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGridViewToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewToDoList.Location = New System.Drawing.Point(37, 98)
        Me.dataGridViewToDoList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dataGridViewToDoList.Name = "dataGridViewToDoList"
        Me.dataGridViewToDoList.RowHeadersWidth = 51
        Me.dataGridViewToDoList.RowTemplate.Height = 24
        Me.dataGridViewToDoList.Size = New System.Drawing.Size(519, 699)
        Me.dataGridViewToDoList.TabIndex = 25
        '
        'btn_clearAllObjective
        '
        Me.btn_clearAllObjective.BackColor = System.Drawing.Color.White
        Me.btn_clearAllObjective.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_clearAllObjective.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_clearAllObjective.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearAllObjective.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearAllObjective.Location = New System.Drawing.Point(227, 815)
        Me.btn_clearAllObjective.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clearAllObjective.Name = "btn_clearAllObjective"
        Me.btn_clearAllObjective.Size = New System.Drawing.Size(138, 48)
        Me.btn_clearAllObjective.TabIndex = 24
        Me.btn_clearAllObjective.Text = "Clear List"
        Me.btn_clearAllObjective.UseVisualStyleBackColor = False
        '
        'ToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1516, 901)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Logo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ToDoList"
        Me.Text = "ToDoList"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGridViewToDoList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_objective As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents cbx_status As ComboBox
    Friend WithEvents btn_add As Button
    Friend WithEvents cbx_priority As ComboBox
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Logo As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_filter As ComboBox
    Friend WithEvents dataGridViewToDoList As DataGridView
    Friend WithEvents btn_clearAllObjective As Button
End Class
