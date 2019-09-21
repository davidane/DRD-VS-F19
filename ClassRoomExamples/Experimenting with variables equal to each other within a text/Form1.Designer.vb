<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Special1Button = New System.Windows.Forms.Button()
        Me.Special2Button = New System.Windows.Forms.Button()
        Me.Special3Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Special1Button
        '
        Me.Special1Button.Location = New System.Drawing.Point(12, 317)
        Me.Special1Button.Name = "Special1Button"
        Me.Special1Button.Size = New System.Drawing.Size(75, 23)
        Me.Special1Button.TabIndex = 0
        Me.Special1Button.Text = "Special1"
        Me.Special1Button.UseVisualStyleBackColor = True
        '
        'Special2Button
        '
        Me.Special2Button.Location = New System.Drawing.Point(12, 346)
        Me.Special2Button.Name = "Special2Button"
        Me.Special2Button.Size = New System.Drawing.Size(75, 23)
        Me.Special2Button.TabIndex = 1
        Me.Special2Button.Text = "Special2"
        Me.Special2Button.UseVisualStyleBackColor = True
        '
        'Special3Button
        '
        Me.Special3Button.Location = New System.Drawing.Point(12, 374)
        Me.Special3Button.Name = "Special3Button"
        Me.Special3Button.Size = New System.Drawing.Size(75, 23)
        Me.Special3Button.TabIndex = 2
        Me.Special3Button.Text = "Special3"
        Me.Special3Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(713, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Special3Button)
        Me.Controls.Add(Me.Special2Button)
        Me.Controls.Add(Me.Special1Button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Special1Button As Button
    Friend WithEvents Special2Button As Button
    Friend WithEvents Special3Button As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
End Class
