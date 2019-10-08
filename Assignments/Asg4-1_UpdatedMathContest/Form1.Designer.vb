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
        Me.StudentAnswerGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.GivenNumbersGroupBox = New System.Windows.Forms.GroupBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.MathFunctionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerGroupBox.SuspendLayout()
        Me.GivenNumbersGroupBox.SuspendLayout()
        Me.MathFunctionsGroupBox.SuspendLayout()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentAnswerGroupBox
        '
        Me.StudentAnswerGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.StudentAnswerGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.StudentAnswerGroupBox.Location = New System.Drawing.Point(37, 343)
        Me.StudentAnswerGroupBox.Name = "StudentAnswerGroupBox"
        Me.StudentAnswerGroupBox.Size = New System.Drawing.Size(200, 49)
        Me.StudentAnswerGroupBox.TabIndex = 19
        Me.StudentAnswerGroupBox.TabStop = False
        Me.StudentAnswerGroupBox.Text = "Student Answer"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(94, 21)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentAnswerTextBox.TabIndex = 11
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 21)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 8
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(572, 313)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(194, 79)
        Me.ExitButton.TabIndex = 23
        Me.ExitButton.Text = "Exit Form"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Enabled = False
        Me.SummaryButton.Location = New System.Drawing.Point(572, 227)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(194, 79)
        Me.SummaryButton.TabIndex = 22
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(572, 143)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(194, 79)
        Me.ClearButton.TabIndex = 21
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(572, 58)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(194, 79)
        Me.SubmitButton.TabIndex = 20
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'GivenNumbersGroupBox
        '
        Me.GivenNumbersGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.GivenNumbersGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.GivenNumbersGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.GivenNumbersGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.GivenNumbersGroupBox.Location = New System.Drawing.Point(37, 240)
        Me.GivenNumbersGroupBox.Name = "GivenNumbersGroupBox"
        Me.GivenNumbersGroupBox.Size = New System.Drawing.Size(200, 86)
        Me.GivenNumbersGroupBox.TabIndex = 24
        Me.GivenNumbersGroupBox.TabStop = False
        Me.GivenNumbersGroupBox.Text = "Given Numbers"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(94, 46)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.ReadOnly = True
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondNumberTextBox.TabIndex = 18
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(94, 20)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.ReadOnly = True
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNumberTextBox.TabIndex = 17
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(4, 20)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(66, 13)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "First Number"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(4, 46)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(84, 13)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'MathFunctionsGroupBox
        '
        Me.MathFunctionsGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathFunctionsGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathFunctionsGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathFunctionsGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathFunctionsGroupBox.Location = New System.Drawing.Point(260, 248)
        Me.MathFunctionsGroupBox.Name = "MathFunctionsGroupBox"
        Me.MathFunctionsGroupBox.Size = New System.Drawing.Size(140, 136)
        Me.MathFunctionsGroupBox.TabIndex = 18
        Me.MathFunctionsGroupBox.TabStop = False
        Me.MathFunctionsGroupBox.Text = "Math Functions"
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
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
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
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(35, 62)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(202, 157)
        Me.StudentInfoGroupBox.TabIndex = 17
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
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(85, 87)
        Me.GradeTextBox.MaxLength = 1
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(25, 20)
        Me.GradeTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(75, 20)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(11, 113)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 3
        Me.AgeLabel.Text = "Age"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(75, 54)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 2
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(11, 87)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(60, 13)
        Me.GradeLabel.TabIndex = 2
        Me.GradeLabel.Text = "Grade (1-4)"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(11, 20)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 7
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(11, 54)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 1
        Me.LastNameLabel.Text = "Last Name"
        '
        'Form1
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StudentAnswerGroupBox.ResumeLayout(False)
        Me.StudentAnswerGroupBox.PerformLayout()
        Me.GivenNumbersGroupBox.ResumeLayout(False)
        Me.GivenNumbersGroupBox.PerformLayout()
        Me.MathFunctionsGroupBox.ResumeLayout(False)
        Me.MathFunctionsGroupBox.PerformLayout()
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentAnswerGroupBox As GroupBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents GivenNumbersGroupBox As GroupBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents MathFunctionsGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
End Class
