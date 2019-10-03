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
        Me.UserInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ThirdTxtBox = New System.Windows.Forms.TextBox()
        Me.SecondTxtBox = New System.Windows.Forms.TextBox()
        Me.FirstTxtBox = New System.Windows.Forms.TextBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.UserInputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserInputGroupBox
        '
        Me.UserInputGroupBox.Controls.Add(Me.ThirdTxtBox)
        Me.UserInputGroupBox.Controls.Add(Me.SecondTxtBox)
        Me.UserInputGroupBox.Controls.Add(Me.FirstTxtBox)
        Me.UserInputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.UserInputGroupBox.Name = "UserInputGroupBox"
        Me.UserInputGroupBox.Size = New System.Drawing.Size(463, 248)
        Me.UserInputGroupBox.TabIndex = 0
        Me.UserInputGroupBox.TabStop = False
        '
        'ThirdTxtBox
        '
        Me.ThirdTxtBox.Location = New System.Drawing.Point(6, 71)
        Me.ThirdTxtBox.Name = "ThirdTxtBox"
        Me.ThirdTxtBox.Size = New System.Drawing.Size(305, 20)
        Me.ThirdTxtBox.TabIndex = 6
        '
        'SecondTxtBox
        '
        Me.SecondTxtBox.Location = New System.Drawing.Point(6, 45)
        Me.SecondTxtBox.Name = "SecondTxtBox"
        Me.SecondTxtBox.Size = New System.Drawing.Size(305, 20)
        Me.SecondTxtBox.TabIndex = 5
        '
        'FirstTxtBox
        '
        Me.FirstTxtBox.Location = New System.Drawing.Point(6, 19)
        Me.FirstTxtBox.Name = "FirstTxtBox"
        Me.FirstTxtBox.Size = New System.Drawing.Size(305, 20)
        Me.FirstTxtBox.TabIndex = 4
        '
        'GoBtn
        '
        Me.GoBtn.Location = New System.Drawing.Point(407, 363)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(123, 75)
        Me.GoBtn.TabIndex = 1
        Me.GoBtn.Text = "Go"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(536, 363)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(123, 75)
        Me.ClearBtn.TabIndex = 2
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(665, 363)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(123, 75)
        Me.ExitBtn.TabIndex = 3
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.UserInputGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.UserInputGroupBox.ResumeLayout(False)
        Me.UserInputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserInputGroupBox As GroupBox
    Friend WithEvents ThirdTxtBox As TextBox
    Friend WithEvents SecondTxtBox As TextBox
    Friend WithEvents FirstTxtBox As TextBox
    Friend WithEvents GoBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
