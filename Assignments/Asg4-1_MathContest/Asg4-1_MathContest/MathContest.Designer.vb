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
        Me.AgeTxtBox = New System.Windows.Forms.TextBox()
        Me.GradeTxtBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTxtBox = New System.Windows.Forms.TextBox()
        Me.AgeLbl = New System.Windows.Forms.Label()
        Me.LastNameTxtBox = New System.Windows.Forms.TextBox()
        Me.GradeLbl = New System.Windows.Forms.Label()
        Me.FirstNameLbl = New System.Windows.Forms.Label()
        Me.LastNameLbl = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MathFunctionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRBtn = New System.Windows.Forms.RadioButton()
        Me.MultiplyRBtn = New System.Windows.Forms.RadioButton()
        Me.AddRBtn = New System.Windows.Forms.RadioButton()
        Me.SubtractRBtn = New System.Windows.Forms.RadioButton()
        Me.FirstNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.GivenNumbersGroupBox = New System.Windows.Forms.GroupBox()
        Me.FirstNumberLbl = New System.Windows.Forms.Label()
        Me.SecondNumberLbl = New System.Windows.Forms.Label()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SummaryBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.StudentAnswerTxtBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLbl = New System.Windows.Forms.Label()
        Me.StudentAnswerGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.MathFunctionsGroupBox.SuspendLayout()
        Me.GivenNumbersGroupBox.SuspendLayout()
        Me.StudentAnswerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTxtBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTxtBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.FirstNameTxtBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLbl)
        Me.StudentInfoGroupBox.Controls.Add(Me.LastNameTxtBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLbl)
        Me.StudentInfoGroupBox.Controls.Add(Me.FirstNameLbl)
        Me.StudentInfoGroupBox.Controls.Add(Me.LastNameLbl)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(37, 33)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(202, 157)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'AgeTxtBox
        '
        Me.AgeTxtBox.Location = New System.Drawing.Point(85, 113)
        Me.AgeTxtBox.MaxLength = 2
        Me.AgeTxtBox.Name = "AgeTxtBox"
        Me.AgeTxtBox.Size = New System.Drawing.Size(25, 20)
        Me.AgeTxtBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.AgeTxtBox, "Enter Age")
        '
        'GradeTxtBox
        '
        Me.GradeTxtBox.Location = New System.Drawing.Point(85, 87)
        Me.GradeTxtBox.MaxLength = 1
        Me.GradeTxtBox.Name = "GradeTxtBox"
        Me.GradeTxtBox.Size = New System.Drawing.Size(25, 20)
        Me.GradeTxtBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.GradeTxtBox, "Enter Grade")
        '
        'FirstNameTxtBox
        '
        Me.FirstNameTxtBox.Location = New System.Drawing.Point(75, 20)
        Me.FirstNameTxtBox.Name = "FirstNameTxtBox"
        Me.FirstNameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTxtBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.FirstNameTxtBox, "Enter First Name")
        '
        'AgeLbl
        '
        Me.AgeLbl.AutoSize = True
        Me.AgeLbl.Location = New System.Drawing.Point(11, 113)
        Me.AgeLbl.Name = "AgeLbl"
        Me.AgeLbl.Size = New System.Drawing.Size(26, 13)
        Me.AgeLbl.TabIndex = 3
        Me.AgeLbl.Text = "Age"
        Me.ToolTip1.SetToolTip(Me.AgeLbl, "Enter Age")
        '
        'LastNameTxtBox
        '
        Me.LastNameTxtBox.Location = New System.Drawing.Point(75, 54)
        Me.LastNameTxtBox.Name = "LastNameTxtBox"
        Me.LastNameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTxtBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.LastNameTxtBox, "Enter Last Name")
        '
        'GradeLbl
        '
        Me.GradeLbl.AutoSize = True
        Me.GradeLbl.Location = New System.Drawing.Point(11, 87)
        Me.GradeLbl.Name = "GradeLbl"
        Me.GradeLbl.Size = New System.Drawing.Size(60, 13)
        Me.GradeLbl.TabIndex = 2
        Me.GradeLbl.Text = "Grade (1-6)"
        Me.ToolTip1.SetToolTip(Me.GradeLbl, "Enter Grade")
        '
        'FirstNameLbl
        '
        Me.FirstNameLbl.AutoSize = True
        Me.FirstNameLbl.Location = New System.Drawing.Point(11, 20)
        Me.FirstNameLbl.Name = "FirstNameLbl"
        Me.FirstNameLbl.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLbl.TabIndex = 7
        Me.FirstNameLbl.Text = "First Name"
        Me.ToolTip1.SetToolTip(Me.FirstNameLbl, "Enter First Name")
        '
        'LastNameLbl
        '
        Me.LastNameLbl.AutoSize = True
        Me.LastNameLbl.Location = New System.Drawing.Point(11, 54)
        Me.LastNameLbl.Name = "LastNameLbl"
        Me.LastNameLbl.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLbl.TabIndex = 1
        Me.LastNameLbl.Text = "Last Name"
        Me.ToolTip1.SetToolTip(Me.LastNameLbl, "Enter Last Name")
        '
        'MathFunctionsGroupBox
        '
        Me.MathFunctionsGroupBox.Controls.Add(Me.DivideRBtn)
        Me.MathFunctionsGroupBox.Controls.Add(Me.MultiplyRBtn)
        Me.MathFunctionsGroupBox.Controls.Add(Me.AddRBtn)
        Me.MathFunctionsGroupBox.Controls.Add(Me.SubtractRBtn)
        Me.MathFunctionsGroupBox.Location = New System.Drawing.Point(262, 219)
        Me.MathFunctionsGroupBox.Name = "MathFunctionsGroupBox"
        Me.MathFunctionsGroupBox.Size = New System.Drawing.Size(90, 136)
        Me.MathFunctionsGroupBox.TabIndex = 1
        Me.MathFunctionsGroupBox.TabStop = False
        Me.MathFunctionsGroupBox.Text = "Math Functions"
        Me.ToolTip1.SetToolTip(Me.MathFunctionsGroupBox, "Select Math Function To Be Used")
        '
        'DivideRBtn
        '
        Me.DivideRBtn.AutoSize = True
        Me.DivideRBtn.Location = New System.Drawing.Point(15, 96)
        Me.DivideRBtn.Name = "DivideRBtn"
        Me.DivideRBtn.Size = New System.Drawing.Size(55, 17)
        Me.DivideRBtn.TabIndex = 5
        Me.DivideRBtn.TabStop = True
        Me.DivideRBtn.Text = "Divide"
        Me.ToolTip1.SetToolTip(Me.DivideRBtn, "Divide")
        Me.DivideRBtn.UseVisualStyleBackColor = True
        '
        'MultiplyRBtn
        '
        Me.MultiplyRBtn.AutoSize = True
        Me.MultiplyRBtn.Location = New System.Drawing.Point(15, 73)
        Me.MultiplyRBtn.Name = "MultiplyRBtn"
        Me.MultiplyRBtn.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyRBtn.TabIndex = 4
        Me.MultiplyRBtn.TabStop = True
        Me.MultiplyRBtn.Text = "Multiply"
        Me.ToolTip1.SetToolTip(Me.MultiplyRBtn, "Multiply")
        Me.MultiplyRBtn.UseVisualStyleBackColor = True
        '
        'AddRBtn
        '
        Me.AddRBtn.AutoSize = True
        Me.AddRBtn.Location = New System.Drawing.Point(15, 27)
        Me.AddRBtn.Name = "AddRBtn"
        Me.AddRBtn.Size = New System.Drawing.Size(44, 17)
        Me.AddRBtn.TabIndex = 2
        Me.AddRBtn.TabStop = True
        Me.AddRBtn.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.AddRBtn, "Add")
        Me.AddRBtn.UseVisualStyleBackColor = True
        '
        'SubtractRBtn
        '
        Me.SubtractRBtn.AutoSize = True
        Me.SubtractRBtn.Location = New System.Drawing.Point(15, 50)
        Me.SubtractRBtn.Name = "SubtractRBtn"
        Me.SubtractRBtn.Size = New System.Drawing.Size(65, 17)
        Me.SubtractRBtn.TabIndex = 3
        Me.SubtractRBtn.TabStop = True
        Me.SubtractRBtn.Text = "Subtract"
        Me.ToolTip1.SetToolTip(Me.SubtractRBtn, "Subtract")
        Me.SubtractRBtn.UseVisualStyleBackColor = True
        '
        'FirstNumberTxtBox
        '
        Me.FirstNumberTxtBox.Location = New System.Drawing.Point(94, 20)
        Me.FirstNumberTxtBox.Name = "FirstNumberTxtBox"
        Me.FirstNumberTxtBox.ReadOnly = True
        Me.FirstNumberTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNumberTxtBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.FirstNumberTxtBox, "First Given Number")
        '
        'SecondNumberTxtBox
        '
        Me.SecondNumberTxtBox.Location = New System.Drawing.Point(94, 46)
        Me.SecondNumberTxtBox.Name = "SecondNumberTxtBox"
        Me.SecondNumberTxtBox.ReadOnly = True
        Me.SecondNumberTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondNumberTxtBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.SecondNumberTxtBox, "Second Given Number")
        '
        'GivenNumbersGroupBox
        '
        Me.GivenNumbersGroupBox.Controls.Add(Me.SecondNumberTxtBox)
        Me.GivenNumbersGroupBox.Controls.Add(Me.FirstNumberTxtBox)
        Me.GivenNumbersGroupBox.Controls.Add(Me.FirstNumberLbl)
        Me.GivenNumbersGroupBox.Controls.Add(Me.SecondNumberLbl)
        Me.GivenNumbersGroupBox.Location = New System.Drawing.Point(39, 211)
        Me.GivenNumbersGroupBox.Name = "GivenNumbersGroupBox"
        Me.GivenNumbersGroupBox.Size = New System.Drawing.Size(200, 86)
        Me.GivenNumbersGroupBox.TabIndex = 2
        Me.GivenNumbersGroupBox.TabStop = False
        Me.GivenNumbersGroupBox.Text = "Given Numbers"
        Me.ToolTip1.SetToolTip(Me.GivenNumbersGroupBox, "Given Numbers")
        '
        'FirstNumberLbl
        '
        Me.FirstNumberLbl.AutoSize = True
        Me.FirstNumberLbl.Location = New System.Drawing.Point(4, 20)
        Me.FirstNumberLbl.Name = "FirstNumberLbl"
        Me.FirstNumberLbl.Size = New System.Drawing.Size(66, 13)
        Me.FirstNumberLbl.TabIndex = 3
        Me.FirstNumberLbl.Text = "First Number"
        Me.ToolTip1.SetToolTip(Me.FirstNumberLbl, "First Given Number")
        '
        'SecondNumberLbl
        '
        Me.SecondNumberLbl.AutoSize = True
        Me.SecondNumberLbl.Location = New System.Drawing.Point(4, 46)
        Me.SecondNumberLbl.Name = "SecondNumberLbl"
        Me.SecondNumberLbl.Size = New System.Drawing.Size(84, 13)
        Me.SecondNumberLbl.TabIndex = 4
        Me.SecondNumberLbl.Text = "Second Number"
        Me.ToolTip1.SetToolTip(Me.SecondNumberLbl, "Second Given Number")
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(574, 29)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(194, 79)
        Me.SubmitBtn.TabIndex = 3
        Me.SubmitBtn.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitBtn, "Click To Submit Answer")
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(574, 114)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(194, 79)
        Me.ClearBtn.TabIndex = 4
        Me.ClearBtn.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearBtn, "Clear All Data For Current Student")
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'SummaryBtn
        '
        Me.SummaryBtn.Location = New System.Drawing.Point(574, 199)
        Me.SummaryBtn.Name = "SummaryBtn"
        Me.SummaryBtn.Size = New System.Drawing.Size(194, 79)
        Me.SummaryBtn.TabIndex = 5
        Me.SummaryBtn.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryBtn, "Click To View Summary Of All 5 Questions")
        Me.SummaryBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(574, 284)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(194, 79)
        Me.ExitBtn.TabIndex = 6
        Me.ExitBtn.Text = "Exit Form"
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Click To Exit Form")
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'StudentAnswerTxtBox
        '
        Me.StudentAnswerTxtBox.Location = New System.Drawing.Point(94, 21)
        Me.StudentAnswerTxtBox.Name = "StudentAnswerTxtBox"
        Me.StudentAnswerTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentAnswerTxtBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.StudentAnswerTxtBox, "Enter Student Answer")
        '
        'StudentAnswerLbl
        '
        Me.StudentAnswerLbl.AutoSize = True
        Me.StudentAnswerLbl.Location = New System.Drawing.Point(6, 21)
        Me.StudentAnswerLbl.Name = "StudentAnswerLbl"
        Me.StudentAnswerLbl.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLbl.TabIndex = 8
        Me.StudentAnswerLbl.Text = "Student Answer"
        Me.ToolTip1.SetToolTip(Me.StudentAnswerLbl, "Enter Student Answer")
        '
        'StudentAnswerGroupBox
        '
        Me.StudentAnswerGroupBox.Controls.Add(Me.StudentAnswerTxtBox)
        Me.StudentAnswerGroupBox.Controls.Add(Me.StudentAnswerLbl)
        Me.StudentAnswerGroupBox.Location = New System.Drawing.Point(39, 314)
        Me.StudentAnswerGroupBox.Name = "StudentAnswerGroupBox"
        Me.StudentAnswerGroupBox.Size = New System.Drawing.Size(200, 49)
        Me.StudentAnswerGroupBox.TabIndex = 9
        Me.StudentAnswerGroupBox.TabStop = False
        Me.StudentAnswerGroupBox.Text = "Student Answer"
        Me.ToolTip1.SetToolTip(Me.StudentAnswerGroupBox, "Enter Student Answer")
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StudentAnswerGroupBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.SummaryBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.GivenNumbersGroupBox)
        Me.Controls.Add(Me.MathFunctionsGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContest"
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
    Friend WithEvents LastNameLbl As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GradeLbl As Label
    Friend WithEvents AgeLbl As Label
    Friend WithEvents LastNameTxtBox As TextBox
    Friend WithEvents GradeTxtBox As TextBox
    Friend WithEvents AgeTxtBox As TextBox
    Friend WithEvents FirstNameLbl As Label
    Friend WithEvents FirstNameTxtBox As TextBox
    Friend WithEvents MathFunctionsGroupBox As GroupBox
    Friend WithEvents DivideRBtn As RadioButton
    Friend WithEvents MultiplyRBtn As RadioButton
    Friend WithEvents AddRBtn As RadioButton
    Friend WithEvents SubtractRBtn As RadioButton
    Friend WithEvents GivenNumbersGroupBox As GroupBox
    Friend WithEvents FirstNumberLbl As Label
    Friend WithEvents SecondNumberLbl As Label
    Friend WithEvents FirstNumberTxtBox As TextBox
    Friend WithEvents SecondNumberTxtBox As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents SummaryBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents StudentAnswerTxtBox As TextBox
    Friend WithEvents StudentAnswerLbl As Label
    Friend WithEvents StudentAnswerGroupBox As GroupBox
End Class
