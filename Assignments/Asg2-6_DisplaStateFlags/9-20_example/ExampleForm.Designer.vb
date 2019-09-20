<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExampleForm
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
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OuterLoopMaxTxtBox = New System.Windows.Forms.TextBox()
        Me.OuterLoopMinTxtBox = New System.Windows.Forms.TextBox()
        Me.InnerLoopMaxTxtBox = New System.Windows.Forms.TextBox()
        Me.InnerLoopMinTxtBox = New System.Windows.Forms.TextBox()
        Me.OuterLoopMaxLbl = New System.Windows.Forms.Label()
        Me.OuterLoopMinLbl = New System.Windows.Forms.Label()
        Me.InnerLoopMaxLbl = New System.Windows.Forms.Label()
        Me.InnerLoopMinLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GoBtn
        '
        Me.GoBtn.Location = New System.Drawing.Point(112, 354)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(130, 50)
        Me.GoBtn.TabIndex = 0
        Me.GoBtn.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.GoBtn, "Press to start coding")
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'OuterLoopMaxTxtBox
        '
        Me.OuterLoopMaxTxtBox.Location = New System.Drawing.Point(126, 68)
        Me.OuterLoopMaxTxtBox.Name = "OuterLoopMaxTxtBox"
        Me.OuterLoopMaxTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.OuterLoopMaxTxtBox.TabIndex = 1
        '
        'OuterLoopMinTxtBox
        '
        Me.OuterLoopMinTxtBox.Location = New System.Drawing.Point(126, 94)
        Me.OuterLoopMinTxtBox.Name = "OuterLoopMinTxtBox"
        Me.OuterLoopMinTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.OuterLoopMinTxtBox.TabIndex = 2
        '
        'InnerLoopMaxTxtBox
        '
        Me.InnerLoopMaxTxtBox.Location = New System.Drawing.Point(126, 120)
        Me.InnerLoopMaxTxtBox.Name = "InnerLoopMaxTxtBox"
        Me.InnerLoopMaxTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.InnerLoopMaxTxtBox.TabIndex = 3
        '
        'InnerLoopMinTxtBox
        '
        Me.InnerLoopMinTxtBox.Location = New System.Drawing.Point(126, 146)
        Me.InnerLoopMinTxtBox.Name = "InnerLoopMinTxtBox"
        Me.InnerLoopMinTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.InnerLoopMinTxtBox.TabIndex = 4
        '
        'OuterLoopMaxLbl
        '
        Me.OuterLoopMaxLbl.AutoSize = True
        Me.OuterLoopMaxLbl.Location = New System.Drawing.Point(12, 75)
        Me.OuterLoopMaxLbl.Name = "OuterLoopMaxLbl"
        Me.OuterLoopMaxLbl.Size = New System.Drawing.Size(83, 13)
        Me.OuterLoopMaxLbl.TabIndex = 5
        Me.OuterLoopMaxLbl.Text = "Outer Loop Max"
        '
        'OuterLoopMinLbl
        '
        Me.OuterLoopMinLbl.AutoSize = True
        Me.OuterLoopMinLbl.Location = New System.Drawing.Point(12, 97)
        Me.OuterLoopMinLbl.Name = "OuterLoopMinLbl"
        Me.OuterLoopMinLbl.Size = New System.Drawing.Size(80, 13)
        Me.OuterLoopMinLbl.TabIndex = 6
        Me.OuterLoopMinLbl.Text = "Outer Loop Min"
        '
        'InnerLoopMaxLbl
        '
        Me.InnerLoopMaxLbl.AutoSize = True
        Me.InnerLoopMaxLbl.Location = New System.Drawing.Point(12, 123)
        Me.InnerLoopMaxLbl.Name = "InnerLoopMaxLbl"
        Me.InnerLoopMaxLbl.Size = New System.Drawing.Size(81, 13)
        Me.InnerLoopMaxLbl.TabIndex = 7
        Me.InnerLoopMaxLbl.Text = "Inner Loop Max"
        '
        'InnerLoopMinLbl
        '
        Me.InnerLoopMinLbl.AutoSize = True
        Me.InnerLoopMinLbl.Location = New System.Drawing.Point(12, 149)
        Me.InnerLoopMinLbl.Name = "InnerLoopMinLbl"
        Me.InnerLoopMinLbl.Size = New System.Drawing.Size(78, 13)
        Me.InnerLoopMinLbl.TabIndex = 8
        Me.InnerLoopMinLbl.Text = "Inner Loop Min"
        '
        'ExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InnerLoopMinLbl)
        Me.Controls.Add(Me.InnerLoopMaxLbl)
        Me.Controls.Add(Me.OuterLoopMinLbl)
        Me.Controls.Add(Me.OuterLoopMaxLbl)
        Me.Controls.Add(Me.InnerLoopMinTxtBox)
        Me.Controls.Add(Me.InnerLoopMaxTxtBox)
        Me.Controls.Add(Me.OuterLoopMinTxtBox)
        Me.Controls.Add(Me.OuterLoopMaxTxtBox)
        Me.Controls.Add(Me.GoBtn)
        Me.Name = "ExampleForm"
        Me.Text = "Example Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OuterLoopMaxTxtBox As TextBox
    Friend WithEvents OuterLoopMinTxtBox As TextBox
    Friend WithEvents InnerLoopMaxTxtBox As TextBox
    Friend WithEvents InnerLoopMinTxtBox As TextBox
    Friend WithEvents OuterLoopMaxLbl As Label
    Friend WithEvents OuterLoopMinLbl As Label
    Friend WithEvents InnerLoopMaxLbl As Label
    Friend WithEvents InnerLoopMinLbl As Label
End Class
