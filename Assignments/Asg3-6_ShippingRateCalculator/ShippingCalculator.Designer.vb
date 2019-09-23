<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingCalculator
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
        Me.UserinputGroupBox = New System.Windows.Forms.GroupBox()
        Me.OuncesTxtBox = New System.Windows.Forms.TextBox()
        Me.PoundsTxtBox = New System.Windows.Forms.TextBox()
        Me.PinCodeTxtBox = New System.Windows.Forms.TextBox()
        Me.OuncesLbl = New System.Windows.Forms.Label()
        Me.PoundsLbl = New System.Windows.Forms.Label()
        Me.IDCodeLbl = New System.Windows.Forms.Label()
        Me.PackageWeightLbl = New System.Windows.Forms.Label()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ShippingChargeLbl = New System.Windows.Forms.Label()
        Me.ShippingChargeTxtBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.UserinputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserinputGroupBox
        '
        Me.UserinputGroupBox.Controls.Add(Me.OuncesTxtBox)
        Me.UserinputGroupBox.Controls.Add(Me.PoundsTxtBox)
        Me.UserinputGroupBox.Controls.Add(Me.PinCodeTxtBox)
        Me.UserinputGroupBox.Controls.Add(Me.OuncesLbl)
        Me.UserinputGroupBox.Controls.Add(Me.PoundsLbl)
        Me.UserinputGroupBox.Controls.Add(Me.IDCodeLbl)
        Me.UserinputGroupBox.Controls.Add(Me.PackageWeightLbl)
        Me.UserinputGroupBox.Location = New System.Drawing.Point(68, 38)
        Me.UserinputGroupBox.Name = "UserinputGroupBox"
        Me.UserinputGroupBox.Size = New System.Drawing.Size(322, 195)
        Me.UserinputGroupBox.TabIndex = 0
        Me.UserinputGroupBox.TabStop = False
        Me.UserinputGroupBox.Text = "User Input"
        '
        'OuncesTxtBox
        '
        Me.OuncesTxtBox.Location = New System.Drawing.Point(181, 126)
        Me.OuncesTxtBox.Name = "OuncesTxtBox"
        Me.OuncesTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.OuncesTxtBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.OuncesTxtBox, "enter weight in ounces")
        '
        'PoundsTxtBox
        '
        Me.PoundsTxtBox.Location = New System.Drawing.Point(55, 126)
        Me.PoundsTxtBox.Name = "PoundsTxtBox"
        Me.PoundsTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.PoundsTxtBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.PoundsTxtBox, "Enter weight in pounds")
        '
        'PinCodeTxtBox
        '
        Me.PinCodeTxtBox.Location = New System.Drawing.Point(90, 23)
        Me.PinCodeTxtBox.MaxLength = 6
        Me.PinCodeTxtBox.Name = "PinCodeTxtBox"
        Me.PinCodeTxtBox.Size = New System.Drawing.Size(76, 20)
        Me.PinCodeTxtBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.PinCodeTxtBox, "Enter 6-pin code")
        '
        'OuncesLbl
        '
        Me.OuncesLbl.AutoSize = True
        Me.OuncesLbl.Location = New System.Drawing.Point(178, 110)
        Me.OuncesLbl.Name = "OuncesLbl"
        Me.OuncesLbl.Size = New System.Drawing.Size(66, 13)
        Me.OuncesLbl.TabIndex = 8
        Me.OuncesLbl.Text = "Ounces (Oz)"
        Me.ToolTip1.SetToolTip(Me.OuncesLbl, "enter weight in ounces")
        '
        'PoundsLbl
        '
        Me.PoundsLbl.AutoSize = True
        Me.PoundsLbl.Location = New System.Drawing.Point(52, 110)
        Me.PoundsLbl.Name = "PoundsLbl"
        Me.PoundsLbl.Size = New System.Drawing.Size(69, 13)
        Me.PoundsLbl.TabIndex = 7
        Me.PoundsLbl.Text = "Pounds (Lbs)"
        Me.ToolTip1.SetToolTip(Me.PoundsLbl, "Enter weight in pounds")
        '
        'IDCodeLbl
        '
        Me.IDCodeLbl.AutoSize = True
        Me.IDCodeLbl.Location = New System.Drawing.Point(6, 23)
        Me.IDCodeLbl.Name = "IDCodeLbl"
        Me.IDCodeLbl.Size = New System.Drawing.Size(73, 13)
        Me.IDCodeLbl.TabIndex = 5
        Me.IDCodeLbl.Text = "6-Pin ID Code"
        Me.ToolTip1.SetToolTip(Me.IDCodeLbl, "Enter 6-pin code")
        '
        'PackageWeightLbl
        '
        Me.PackageWeightLbl.AutoSize = True
        Me.PackageWeightLbl.Location = New System.Drawing.Point(10, 81)
        Me.PackageWeightLbl.Name = "PackageWeightLbl"
        Me.PackageWeightLbl.Size = New System.Drawing.Size(101, 13)
        Me.PackageWeightLbl.TabIndex = 6
        Me.PackageWeightLbl.Text = "Weight of package:"
        Me.ToolTip1.SetToolTip(Me.PackageWeightLbl, "Enter weight of package")
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.ShippingChargeLbl)
        Me.OutputGroupBox.Controls.Add(Me.ShippingChargeTxtBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(473, 61)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(240, 71)
        Me.OutputGroupBox.TabIndex = 10
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Output "
        '
        'ShippingChargeLbl
        '
        Me.ShippingChargeLbl.AutoSize = True
        Me.ShippingChargeLbl.Location = New System.Drawing.Point(28, 26)
        Me.ShippingChargeLbl.Name = "ShippingChargeLbl"
        Me.ShippingChargeLbl.Size = New System.Drawing.Size(85, 26)
        Me.ShippingChargeLbl.TabIndex = 9
        Me.ShippingChargeLbl.Text = "Shipping Charge" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "@ $0.12 /oz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.ShippingChargeLbl, "Cost of shipping")
        '
        'ShippingChargeTxtBox
        '
        Me.ShippingChargeTxtBox.Location = New System.Drawing.Point(119, 32)
        Me.ShippingChargeTxtBox.Name = "ShippingChargeTxtBox"
        Me.ShippingChargeTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ShippingChargeTxtBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.ShippingChargeTxtBox, "Cost of shipping")
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(98, 347)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(172, 91)
        Me.CalculateBtn.TabIndex = 3
        Me.CalculateBtn.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateBtn, "Press ti cakculate")
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(323, 347)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(172, 91)
        Me.ClearBtn.TabIndex = 4
        Me.ClearBtn.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearBtn, "Press to clear fields")
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(541, 347)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(172, 91)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Press to exit form")
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'ShippingCalculator
        '
        Me.AcceptButton = Me.CalculateBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.UserinputGroupBox)
        Me.Name = "ShippingCalculator"
        Me.Text = "Shipping Calculator"
        Me.UserinputGroupBox.ResumeLayout(False)
        Me.UserinputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserinputGroupBox As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents IDCodeLbl As Label
    Friend WithEvents PackageWeightLbl As Label
    Friend WithEvents PoundsLbl As Label
    Friend WithEvents OuncesLbl As Label
    Friend WithEvents OuncesTxtBox As TextBox
    Friend WithEvents PoundsTxtBox As TextBox
    Friend WithEvents PinCodeTxtBox As TextBox
    Friend WithEvents ShippingChargeLbl As Label
    Friend WithEvents ShippingChargeTxtBox As TextBox
End Class
