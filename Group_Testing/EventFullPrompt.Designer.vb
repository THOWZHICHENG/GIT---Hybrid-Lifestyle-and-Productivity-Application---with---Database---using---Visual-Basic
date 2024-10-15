<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventFullPrompt
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
        Me.lblEFPrompt2 = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.lblEFPrompt1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEFPrompt2
        '
        Me.lblEFPrompt2.AutoSize = True
        Me.lblEFPrompt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEFPrompt2.Location = New System.Drawing.Point(15, 82)
        Me.lblEFPrompt2.Name = "lblEFPrompt2"
        Me.lblEFPrompt2.Size = New System.Drawing.Size(370, 32)
        Me.lblEFPrompt2.TabIndex = 15
        Me.lblEFPrompt2.Text = "Would you like to remove 1?"
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(168, 151)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(84, 44)
        Me.btnNo.TabIndex = 14
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(20, 151)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(84, 44)
        Me.btnYes.TabIndex = 13
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'lblEFPrompt1
        '
        Me.lblEFPrompt1.AutoSize = True
        Me.lblEFPrompt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEFPrompt1.Location = New System.Drawing.Point(14, 29)
        Me.lblEFPrompt1.Name = "lblEFPrompt1"
        Me.lblEFPrompt1.Size = New System.Drawing.Size(569, 38)
        Me.lblEFPrompt1.TabIndex = 12
        Me.lblEFPrompt1.Text = "There are already 2 event for this date"
        '
        'EventFullPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(596, 225)
        Me.Controls.Add(Me.lblEFPrompt2)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblEFPrompt1)
        Me.Name = "EventFullPrompt"
        Me.Text = "EventFullPrompt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEFPrompt2 As Label
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents lblEFPrompt1 As Label
End Class
