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
        Me.GoRespondBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SelectionGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BadDayRadioButton = New System.Windows.Forms.RadioButton()
        Me.MehRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreatDayRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SelectionGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GoRespondBtn
        '
        Me.GoRespondBtn.Location = New System.Drawing.Point(12, 339)
        Me.GoRespondBtn.Name = "GoRespondBtn"
        Me.GoRespondBtn.Size = New System.Drawing.Size(175, 99)
        Me.GoRespondBtn.TabIndex = 0
        Me.GoRespondBtn.Text = "Go/Respond"
        Me.GoRespondBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(594, 339)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(194, 99)
        Me.ExitBtn.TabIndex = 1
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'SelectionGroupBox1
        '
        Me.SelectionGroupBox1.Controls.Add(Me.GreatDayRadioButton)
        Me.SelectionGroupBox1.Controls.Add(Me.MehRadioButton)
        Me.SelectionGroupBox1.Controls.Add(Me.BadDayRadioButton)
        Me.SelectionGroupBox1.Location = New System.Drawing.Point(433, 67)
        Me.SelectionGroupBox1.Name = "SelectionGroupBox1"
        Me.SelectionGroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.SelectionGroupBox1.TabIndex = 3
        Me.SelectionGroupBox1.TabStop = False
        Me.SelectionGroupBox1.Text = "SelectionGroupBox"
        '
        'BadDayRadioButton
        '
        Me.BadDayRadioButton.AutoSize = True
        Me.BadDayRadioButton.Location = New System.Drawing.Point(51, 24)
        Me.BadDayRadioButton.Name = "BadDayRadioButton"
        Me.BadDayRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.BadDayRadioButton.TabIndex = 4
        Me.BadDayRadioButton.TabStop = True
        Me.BadDayRadioButton.Text = "Bad Day"
        Me.BadDayRadioButton.UseVisualStyleBackColor = True
        '
        'MehRadioButton
        '
        Me.MehRadioButton.AutoSize = True
        Me.MehRadioButton.Location = New System.Drawing.Point(51, 47)
        Me.MehRadioButton.Name = "MehRadioButton"
        Me.MehRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.MehRadioButton.TabIndex = 5
        Me.MehRadioButton.TabStop = True
        Me.MehRadioButton.Text = "Meh"
        Me.MehRadioButton.UseVisualStyleBackColor = True
        '
        'GreatDayRadioButton
        '
        Me.GreatDayRadioButton.AutoSize = True
        Me.GreatDayRadioButton.Location = New System.Drawing.Point(51, 70)
        Me.GreatDayRadioButton.Name = "GreatDayRadioButton"
        Me.GreatDayRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.GreatDayRadioButton.TabIndex = 6
        Me.GreatDayRadioButton.TabStop = True
        Me.GreatDayRadioButton.Text = "Great Da"
        Me.GreatDayRadioButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(310, 339)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(192, 99)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SelectionGroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.GoRespondBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SelectionGroupBox1.ResumeLayout(False)
        Me.SelectionGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoRespondBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SelectionGroupBox1 As GroupBox
    Friend WithEvents GreatDayRadioButton As RadioButton
    Friend WithEvents MehRadioButton As RadioButton
    Friend WithEvents BadDayRadioButton As RadioButton
    Friend WithEvents ClearButton As Button
End Class
