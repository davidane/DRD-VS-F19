<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInputForm
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
        Me.UserInputTxtBox = New System.Windows.Forms.TextBox()
        Me.GetInputBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.EnterNumberlbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserInputTxtBox
        '
        Me.UserInputTxtBox.Location = New System.Drawing.Point(169, 100)
        Me.UserInputTxtBox.Name = "UserInputTxtBox"
        Me.UserInputTxtBox.Size = New System.Drawing.Size(191, 20)
        Me.UserInputTxtBox.TabIndex = 0
        '
        'GetInputBtn
        '
        Me.GetInputBtn.Location = New System.Drawing.Point(88, 147)
        Me.GetInputBtn.Name = "GetInputBtn"
        Me.GetInputBtn.Size = New System.Drawing.Size(75, 23)
        Me.GetInputBtn.TabIndex = 1
        Me.GetInputBtn.Text = "Get Input"
        Me.GetInputBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.Location = New System.Drawing.Point(713, 415)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 2
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'EnterNumberlbl
        '
        Me.EnterNumberlbl.AutoSize = True
        Me.EnterNumberlbl.Location = New System.Drawing.Point(84, 100)
        Me.EnterNumberlbl.Name = "EnterNumberlbl"
        Me.EnterNumberlbl.Size = New System.Drawing.Size(79, 13)
        Me.EnterNumberlbl.TabIndex = 3
        Me.EnterNumberlbl.Text = "Enter a number"
        '
        'UserInputForm
        '
        Me.AcceptButton = Me.GetInputBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EnterNumberlbl)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.GetInputBtn)
        Me.Controls.Add(Me.UserInputTxtBox)
        Me.Name = "UserInputForm"
        Me.Text = "UserInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserInputTxtBox As TextBox
    Friend WithEvents GetInputBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents EnterNumberlbl As Label
End Class
