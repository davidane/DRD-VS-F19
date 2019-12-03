<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sprint1Form
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
        Me.ConvertingTextBox = New System.Windows.Forms.TextBox()
        Me.UserInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConvertLabel = New System.Windows.Forms.Label()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConvertingTextBox
        '
        Me.ConvertingTextBox.Location = New System.Drawing.Point(103, 19)
        Me.ConvertingTextBox.Name = "ConvertingTextBox"
        Me.ConvertingTextBox.Size = New System.Drawing.Size(138, 20)
        Me.ConvertingTextBox.TabIndex = 0
        '
        'UserInputGroupBox
        '
        Me.UserInputGroupBox.Controls.Add(Me.ConvertLabel)
        Me.UserInputGroupBox.Controls.Add(Me.ConvertButton)
        Me.UserInputGroupBox.Controls.Add(Me.ConvertingTextBox)
        Me.UserInputGroupBox.Location = New System.Drawing.Point(154, 12)
        Me.UserInputGroupBox.Name = "UserInputGroupBox"
        Me.UserInputGroupBox.Size = New System.Drawing.Size(260, 87)
        Me.UserInputGroupBox.TabIndex = 4
        Me.UserInputGroupBox.TabStop = False
        '
        'ConvertLabel
        '
        Me.ConvertLabel.AutoSize = True
        Me.ConvertLabel.Location = New System.Drawing.Point(6, 19)
        Me.ConvertLabel.Name = "ConvertLabel"
        Me.ConvertLabel.Size = New System.Drawing.Size(91, 13)
        Me.ConvertLabel.TabIndex = 5
        Me.ConvertLabel.Text = "Enter some words"
        '
        'ConvertButton
        '
        Me.ConvertButton.Location = New System.Drawing.Point(103, 45)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(75, 23)
        Me.ConvertButton.TabIndex = 1
        Me.ConvertButton.Text = "Convert"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(384, 105)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(146, 75)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Sprint1Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 204)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UserInputGroupBox)
        Me.Name = "Sprint1Form"
        Me.Text = "Sprint-1_Form"
        Me.UserInputGroupBox.ResumeLayout(False)
        Me.UserInputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConvertingTextBox As TextBox
    Friend WithEvents UserInputGroupBox As GroupBox
    Friend WithEvents ConvertLabel As Label
    Friend WithEvents ConvertButton As Button
    Friend WithEvents ExitButton As Button
End Class
