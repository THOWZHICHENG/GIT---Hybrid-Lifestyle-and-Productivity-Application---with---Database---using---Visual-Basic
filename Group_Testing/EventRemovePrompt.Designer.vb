<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventRemovePrompt
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEventBoth = New System.Windows.Forms.Button()
        Me.btnEvent2 = New System.Windows.Forms.Button()
        Me.btnEvent1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(497, 120)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 44)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEventBoth
        '
        Me.btnEventBoth.Location = New System.Drawing.Point(373, 120)
        Me.btnEventBoth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEventBoth.Name = "btnEventBoth"
        Me.btnEventBoth.Size = New System.Drawing.Size(84, 44)
        Me.btnEventBoth.TabIndex = 20
        Me.btnEventBoth.Text = "Both"
        Me.btnEventBoth.UseVisualStyleBackColor = True
        '
        'btnEvent2
        '
        Me.btnEvent2.Location = New System.Drawing.Point(230, 120)
        Me.btnEvent2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEvent2.Name = "btnEvent2"
        Me.btnEvent2.Size = New System.Drawing.Size(84, 44)
        Me.btnEvent2.TabIndex = 19
        Me.btnEvent2.Text = "Event 2"
        Me.btnEvent2.UseVisualStyleBackColor = True
        '
        'btnEvent1
        '
        Me.btnEvent1.Location = New System.Drawing.Point(93, 120)
        Me.btnEvent1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEvent1.Name = "btnEvent1"
        Me.btnEvent1.Size = New System.Drawing.Size(84, 44)
        Me.btnEvent1.TabIndex = 18
        Me.btnEvent1.Text = "Event 1"
        Me.btnEvent1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(583, 38)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Which event would you like to remove?"
        '
        'EventRemovePrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 218)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEventBoth)
        Me.Controls.Add(Me.btnEvent2)
        Me.Controls.Add(Me.btnEvent1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EventRemovePrompt"
        Me.Text = "EventRemovePrompt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEventBoth As Button
    Friend WithEvents btnEvent2 As Button
    Friend WithEvents btnEvent1 As Button
    Friend WithEvents Label1 As Label
End Class
