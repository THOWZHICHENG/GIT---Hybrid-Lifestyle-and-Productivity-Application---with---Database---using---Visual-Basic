<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diet_BMI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Diet_BMI))
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.lbl_classification = New System.Windows.Forms.Label()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.txt_height = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_BMI = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_Logo = New System.Windows.Forms.PictureBox()
        Me.btn_calories = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.Control
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.Location = New System.Drawing.Point(277, 621)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(96, 33)
        Me.btn_clear.TabIndex = 134
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_calculate
        '
        Me.btn_calculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_calculate.Location = New System.Drawing.Point(838, 568)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(181, 55)
        Me.btn_calculate.TabIndex = 131
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'lbl_classification
        '
        Me.lbl_classification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_classification.Location = New System.Drawing.Point(158, 531)
        Me.lbl_classification.Name = "lbl_classification"
        Me.lbl_classification.Size = New System.Drawing.Size(215, 58)
        Me.lbl_classification.TabIndex = 130
        '
        'txt_weight
        '
        Me.txt_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_weight.Location = New System.Drawing.Point(660, 428)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(273, 41)
        Me.txt_weight.TabIndex = 129
        '
        'txt_height
        '
        Me.txt_height.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_height.Location = New System.Drawing.Point(660, 249)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(273, 41)
        Me.txt_height.TabIndex = 128
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline)
        Me.Label7.Location = New System.Drawing.Point(653, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 65)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Weight (kg)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline)
        Me.Label6.Location = New System.Drawing.Point(653, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 65)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Height (cm)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(428, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(388, 93)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "BMI Calculator"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(158, 490)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(215, 31)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Classification"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(158, 393)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(215, 31)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "BMI"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_BMI
        '
        Me.txt_BMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_BMI.Location = New System.Drawing.Point(158, 427)
        Me.txt_BMI.Name = "txt_BMI"
        Me.txt_BMI.ReadOnly = True
        Me.txt_BMI.Size = New System.Drawing.Size(215, 30)
        Me.txt_BMI.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(124, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(298, 350)
        Me.Label8.TabIndex = 136
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(124, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(298, 363)
        Me.Label10.TabIndex = 135
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Group_Testing.My.Resources.Resources.bmiButton_1200x600
        Me.PictureBox3.Location = New System.Drawing.Point(198, 136)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(153, 77)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 155
        Me.PictureBox3.TabStop = False
        '
        'btn_Logo
        '
        Me.btn_Logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Logo.Image = Global.Group_Testing.My.Resources.Resources.logoDesign3_1200x1200
        Me.btn_Logo.Location = New System.Drawing.Point(0, 0)
        Me.btn_Logo.Name = "btn_Logo"
        Me.btn_Logo.Size = New System.Drawing.Size(120, 120)
        Me.btn_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Logo.TabIndex = 150
        Me.btn_Logo.TabStop = False
        '
        'btn_calories
        '
        Me.btn_calories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calories.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_calories.Image = CType(resources.GetObject("btn_calories.Image"), System.Drawing.Image)
        Me.btn_calories.Location = New System.Drawing.Point(198, 27)
        Me.btn_calories.Name = "btn_calories"
        Me.btn_calories.Size = New System.Drawing.Size(153, 77)
        Me.btn_calories.TabIndex = 145
        Me.btn_calories.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.Image = Global.Group_Testing.My.Resources.Resources.backButtonDesign2_100x501
        Me.btn_Back.Location = New System.Drawing.Point(0, 126)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(120, 61)
        Me.btn_Back.TabIndex = 144
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Group_Testing.My.Resources.Resources.bmiWeightIcon_1200x1200
        Me.PictureBox2.Location = New System.Drawing.Point(478, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 126
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Group_Testing.My.Resources.Resources.bmiHeight_1200x1200
        Me.PictureBox1.Location = New System.Drawing.Point(478, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'Diet_BMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1031, 716)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_Logo)
        Me.Controls.Add(Me.btn_calories)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.lbl_classification)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.txt_height)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_BMI)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Diet_BMI"
        Me.Text = "Diet_BMI"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_calculate As Button
    Friend WithEvents lbl_classification As Label
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents txt_height As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_BMI As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_calories As Button
    Friend WithEvents btn_Logo As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
