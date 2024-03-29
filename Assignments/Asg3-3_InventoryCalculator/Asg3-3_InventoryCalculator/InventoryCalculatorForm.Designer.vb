﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryCalculatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BeginningInvLbl = New System.Windows.Forms.Label()
        Me.EndingInvLbl = New System.Windows.Forms.Label()
        Me.CostofGoodLbl = New System.Windows.Forms.Label()
        Me.BeginningInvTxtBox = New System.Windows.Forms.TextBox()
        Me.EndingInvTxtBox = New System.Windows.Forms.TextBox()
        Me.CostofGoodsTxtBox = New System.Windows.Forms.TextBox()
        Me.AverageInvTxtBox = New System.Windows.Forms.TextBox()
        Me.AverageInvLbl = New System.Windows.Forms.Label()
        Me.TurnoverTxtBox = New System.Windows.Forms.TextBox()
        Me.TurnoverLbl = New System.Windows.Forms.Label()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(170, 385)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(146, 53)
        Me.CalculateBtn.TabIndex = 3
        Me.CalculateBtn.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateBtn, "Press to calculate")
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(322, 385)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(146, 53)
        Me.ClearBtn.TabIndex = 4
        Me.ClearBtn.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.ClearBtn, "Press to clear all boxes")
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.Location = New System.Drawing.Point(474, 385)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(146, 53)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Press to exit form")
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'BeginningInvLbl
        '
        Me.BeginningInvLbl.AutoSize = True
        Me.BeginningInvLbl.Location = New System.Drawing.Point(11, 25)
        Me.BeginningInvLbl.Name = "BeginningInvLbl"
        Me.BeginningInvLbl.Size = New System.Drawing.Size(101, 13)
        Me.BeginningInvLbl.TabIndex = 3
        Me.BeginningInvLbl.Text = "Beginning Inventory"
        Me.ToolTip1.SetToolTip(Me.BeginningInvLbl, "Enter beginning inventory")
        '
        'EndingInvLbl
        '
        Me.EndingInvLbl.AutoSize = True
        Me.EndingInvLbl.Location = New System.Drawing.Point(11, 82)
        Me.EndingInvLbl.Name = "EndingInvLbl"
        Me.EndingInvLbl.Size = New System.Drawing.Size(87, 13)
        Me.EndingInvLbl.TabIndex = 5
        Me.EndingInvLbl.Text = "Ending Inventory"
        Me.ToolTip1.SetToolTip(Me.EndingInvLbl, "Enter ending inventory")
        '
        'CostofGoodLbl
        '
        Me.CostofGoodLbl.AutoSize = True
        Me.CostofGoodLbl.Location = New System.Drawing.Point(11, 148)
        Me.CostofGoodLbl.Name = "CostofGoodLbl"
        Me.CostofGoodLbl.Size = New System.Drawing.Size(98, 13)
        Me.CostofGoodLbl.TabIndex = 7
        Me.CostofGoodLbl.Text = "Cost of Goods Sold"
        Me.ToolTip1.SetToolTip(Me.CostofGoodLbl, "Enter cost of goods sold")
        '
        'BeginningInvTxtBox
        '
        Me.BeginningInvTxtBox.Location = New System.Drawing.Point(128, 25)
        Me.BeginningInvTxtBox.Name = "BeginningInvTxtBox"
        Me.BeginningInvTxtBox.Size = New System.Drawing.Size(118, 20)
        Me.BeginningInvTxtBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.BeginningInvTxtBox, "Enter beginning inventory")
        '
        'EndingInvTxtBox
        '
        Me.EndingInvTxtBox.Location = New System.Drawing.Point(128, 82)
        Me.EndingInvTxtBox.Name = "EndingInvTxtBox"
        Me.EndingInvTxtBox.Size = New System.Drawing.Size(118, 20)
        Me.EndingInvTxtBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EndingInvTxtBox, "Enter ending inventory")
        '
        'CostofGoodsTxtBox
        '
        Me.CostofGoodsTxtBox.Location = New System.Drawing.Point(128, 148)
        Me.CostofGoodsTxtBox.Name = "CostofGoodsTxtBox"
        Me.CostofGoodsTxtBox.Size = New System.Drawing.Size(118, 20)
        Me.CostofGoodsTxtBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CostofGoodsTxtBox, "Enter cost of goods sold")
        '
        'AverageInvTxtBox
        '
        Me.AverageInvTxtBox.Location = New System.Drawing.Point(112, 22)
        Me.AverageInvTxtBox.Name = "AverageInvTxtBox"
        Me.AverageInvTxtBox.Size = New System.Drawing.Size(118, 20)
        Me.AverageInvTxtBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.AverageInvTxtBox, "Displays average inventory")
        '
        'AverageInvLbl
        '
        Me.AverageInvLbl.AutoSize = True
        Me.AverageInvLbl.Location = New System.Drawing.Point(10, 22)
        Me.AverageInvLbl.Name = "AverageInvLbl"
        Me.AverageInvLbl.Size = New System.Drawing.Size(94, 13)
        Me.AverageInvLbl.TabIndex = 9
        Me.AverageInvLbl.Text = "Average Inventory"
        Me.ToolTip1.SetToolTip(Me.AverageInvLbl, "Displays average inventory")
        '
        'TurnoverTxtBox
        '
        Me.TurnoverTxtBox.Location = New System.Drawing.Point(112, 87)
        Me.TurnoverTxtBox.Name = "TurnoverTxtBox"
        Me.TurnoverTxtBox.Size = New System.Drawing.Size(118, 20)
        Me.TurnoverTxtBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TurnoverTxtBox, "Displays turnover from sold goods")
        '
        'TurnoverLbl
        '
        Me.TurnoverLbl.AutoSize = True
        Me.TurnoverLbl.Location = New System.Drawing.Point(10, 87)
        Me.TurnoverLbl.Name = "TurnoverLbl"
        Me.TurnoverLbl.Size = New System.Drawing.Size(50, 13)
        Me.TurnoverLbl.TabIndex = 11
        Me.TurnoverLbl.Text = "Turnover"
        Me.ToolTip1.SetToolTip(Me.TurnoverLbl, "Displays turnover from sold goods")
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.EndingInvTxtBox)
        Me.InputGroupBox.Controls.Add(Me.BeginningInvLbl)
        Me.InputGroupBox.Controls.Add(Me.BeginningInvTxtBox)
        Me.InputGroupBox.Controls.Add(Me.EndingInvLbl)
        Me.InputGroupBox.Controls.Add(Me.CostofGoodLbl)
        Me.InputGroupBox.Controls.Add(Me.CostofGoodsTxtBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(265, 181)
        Me.InputGroupBox.TabIndex = 12
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Input Group Box"
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.TurnoverTxtBox)
        Me.OutputGroupBox.Controls.Add(Me.AverageInvLbl)
        Me.OutputGroupBox.Controls.Add(Me.AverageInvTxtBox)
        Me.OutputGroupBox.Controls.Add(Me.TurnoverLbl)
        Me.OutputGroupBox.Location = New System.Drawing.Point(509, 12)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(279, 126)
        Me.OutputGroupBox.TabIndex = 13
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Output Group Box"
        '
        'InventoryCalculatorForm
        '
        Me.AcceptButton = Me.CalculateBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Name = "InventoryCalculatorForm"
        Me.Text = "Inventory Calculator"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CalculateBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BeginningInvLbl As Label
    Friend WithEvents BeginningInvTxtBox As TextBox
    Friend WithEvents EndingInvTxtBox As TextBox
    Friend WithEvents EndingInvLbl As Label
    Friend WithEvents CostofGoodsTxtBox As TextBox
    Friend WithEvents CostofGoodLbl As Label
    Friend WithEvents AverageInvTxtBox As TextBox
    Friend WithEvents AverageInvLbl As Label
    Friend WithEvents TurnoverTxtBox As TextBox
    Friend WithEvents TurnoverLbl As Label
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
End Class
