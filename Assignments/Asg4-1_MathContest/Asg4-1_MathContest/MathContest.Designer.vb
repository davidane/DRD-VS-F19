<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
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
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MathFunctionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.GivenNumbersGroupBox = New System.Windows.Forms.GroupBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StudentAnswerTxtBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.MathFunctionsGroupBox.SuspendLayout()
        Me.GivenNumbersGroupBox.SuspendLayout()
        Me.StudentAnswerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.LastNameLabel)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(37, 33)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(202, 157)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(85, 113)
        Me.AgeTextBox.MaxLength = 2
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(25, 20)
        Me.AgeTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.AgeTextBox, "Enter Age")
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(85, 87)
        Me.GradeTextBox.MaxLength = 1
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(25, 20)
        Me.GradeTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.GradeTextBox, "Enter Grade")
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(75, 20)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FirstNameTextBox, "Enter First Name")
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(11, 113)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 3
        Me.AgeLabel.Text = "Age"
        Me.ToolTip1.SetToolTip(Me.AgeLabel, "Enter Age")
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(75, 54)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.LastNameTextBox, "Enter Last Name")
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(11, 87)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(60, 13)
        Me.GradeLabel.TabIndex = 2
        Me.GradeLabel.Text = "Grade (1-4)"
        Me.ToolTip1.SetToolTip(Me.GradeLabel, "Enter Grade")
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(11, 20)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 7
        Me.FirstNameLabel.Text = "First Name"
        Me.ToolTip1.SetToolTip(Me.FirstNameLabel, "Enter First Name")
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(11, 54)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 1
        Me.LastNameLabel.Text = "Last Name"
        Me.ToolTip1.SetToolTip(Me.LastNameLabel, "Enter Last Name")
        '
        'MathFunctionsGroupBox
        '
        Me.MathFunctionsGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathFunctionsGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathFunctionsGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathFunctionsGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathFunctionsGroupBox.Location = New System.Drawing.Point(262, 219)
        Me.MathFunctionsGroupBox.Name = "MathFunctionsGroupBox"
        Me.MathFunctionsGroupBox.Size = New System.Drawing.Size(140, 136)
        Me.MathFunctionsGroupBox.TabIndex = 5
        Me.MathFunctionsGroupBox.TabStop = False
        Me.MathFunctionsGroupBox.Text = "Math Functions"
        Me.ToolTip1.SetToolTip(Me.MathFunctionsGroupBox, "Select Math Function To Be Used")
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(15, 96)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(95, 17)
        Me.DivideRadioButton.TabIndex = 9
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide (#1/#2)"
        Me.ToolTip1.SetToolTip(Me.DivideRadioButton, "Divide")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(15, 73)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyRadioButton.TabIndex = 8
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.ToolTip1.SetToolTip(Me.MultiplyRadioButton, "Multiply")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(15, 27)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.AddRadioButton.TabIndex = 6
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.AddRadioButton, "Add")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(15, 50)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(103, 17)
        Me.SubtractRadioButton.TabIndex = 7
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract (#1-#2)"
        Me.ToolTip1.SetToolTip(Me.SubtractRadioButton, "Subtract")
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(94, 20)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.ReadOnly = True
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNumberTextBox.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.FirstNumberTextBox, "First Given Number")
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(94, 46)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.ReadOnly = True
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondNumberTextBox.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.SecondNumberTextBox, "Second Given Number")
        '
        'GivenNumbersGroupBox
        '
        Me.GivenNumbersGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.GivenNumbersGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.GivenNumbersGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.GivenNumbersGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.GivenNumbersGroupBox.Location = New System.Drawing.Point(39, 211)
        Me.GivenNumbersGroupBox.Name = "GivenNumbersGroupBox"
        Me.GivenNumbersGroupBox.Size = New System.Drawing.Size(200, 86)
        Me.GivenNumbersGroupBox.TabIndex = 16
        Me.GivenNumbersGroupBox.TabStop = False
        Me.GivenNumbersGroupBox.Text = "Given Numbers"
        Me.ToolTip1.SetToolTip(Me.GivenNumbersGroupBox, "Given Numbers")
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(4, 20)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(66, 13)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "First Number"
        Me.ToolTip1.SetToolTip(Me.FirstNumberLabel, "First Given Number")
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(4, 46)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(84, 13)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "Second Number"
        Me.ToolTip1.SetToolTip(Me.SecondNumberLabel, "Second Given Number")
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(574, 29)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(194, 79)
        Me.SubmitButton.TabIndex = 12
        Me.SubmitButton.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Click To Submit Answer")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(574, 114)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(194, 79)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear All Data For Current Student")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Enabled = False
        Me.SummaryButton.Location = New System.Drawing.Point(574, 199)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(194, 79)
        Me.SummaryButton.TabIndex = 14
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Click To View Summary Of All 5 Questions")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(574, 284)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(194, 79)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.Text = "Exit Form"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click To Exit Form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StudentAnswerTxtBox
        '
        Me.StudentAnswerTxtBox.Location = New System.Drawing.Point(94, 21)
        Me.StudentAnswerTxtBox.Name = "StudentAnswerTxtBox"
        Me.StudentAnswerTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentAnswerTxtBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.StudentAnswerTxtBox, "Enter Student Answer")
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 21)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 8
        Me.StudentAnswerLabel.Text = "Student Answer"
        Me.ToolTip1.SetToolTip(Me.StudentAnswerLabel, "Enter Student Answer")
        '
        'StudentAnswerGroupBox
        '
        Me.StudentAnswerGroupBox.Controls.Add(Me.StudentAnswerTxtBox)
        Me.StudentAnswerGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.StudentAnswerGroupBox.Location = New System.Drawing.Point(39, 314)
        Me.StudentAnswerGroupBox.Name = "StudentAnswerGroupBox"
        Me.StudentAnswerGroupBox.Size = New System.Drawing.Size(200, 49)
        Me.StudentAnswerGroupBox.TabIndex = 10
        Me.StudentAnswerGroupBox.TabStop = False
        Me.StudentAnswerGroupBox.Text = "Student Answer"
        Me.ToolTip1.SetToolTip(Me.StudentAnswerGroupBox, "Enter Student Answer")
        '
        'MathContestOld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StudentAnswerGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.GivenNumbersGroupBox)
        Me.Controls.Add(Me.MathFunctionsGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContestOld"
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.MathFunctionsGroupBox.ResumeLayout(False)
        Me.MathFunctionsGroupBox.PerformLayout()
        Me.GivenNumbersGroupBox.ResumeLayout(False)
        Me.GivenNumbersGroupBox.PerformLayout()
        Me.StudentAnswerGroupBox.ResumeLayout(False)
        Me.StudentAnswerGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents MathFunctionsGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents GivenNumbersGroupBox As GroupBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StudentAnswerTxtBox As TextBox
    Friend WithEvents StudentAnswerGroupBox As GroupBox
    Friend WithEvents StudentAnswerLabel As Label
End Class
