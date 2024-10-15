<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventPrompt1
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblEventPrompt = New System.Windows.Forms.Label()
        Me.tbEvent1Prompt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "If you want to remove an event, click Remove"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(322, 142)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(84, 44)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(18, 142)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(84, 44)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblEventPrompt
        '
        Me.lblEventPrompt.AutoSize = True
        Me.lblEventPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventPrompt.Location = New System.Drawing.Point(12, 19)
        Me.lblEventPrompt.Name = "lblEventPrompt"
        Me.lblEventPrompt.Size = New System.Drawing.Size(515, 46)
        Me.lblEventPrompt.TabIndex = 11
        Me.lblEventPrompt.Text = "Please enter an event name"
        '
        'tbEvent1Prompt
        '
        Me.tbEvent1Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEvent1Prompt.Location = New System.Drawing.Point(18, 97)
        Me.tbEvent1Prompt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbEvent1Prompt.Name = "tbEvent1Prompt"
        Me.tbEvent1Prompt.Size = New System.Drawing.Size(388, 35)
        Me.tbEvent1Prompt.TabIndex = 10
        '
        'EventPrompt1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 292)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblEventPrompt)
        Me.Controls.Add(Me.tbEvent1Prompt)
        Me.Name = "EventPrompt1"
        Me.Text = "EventPrompt1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblEventPrompt As Label
    Friend WithEvents tbEvent1Prompt As TextBox
End Class
