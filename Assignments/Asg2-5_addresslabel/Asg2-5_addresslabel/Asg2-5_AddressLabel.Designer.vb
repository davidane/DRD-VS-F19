<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelForm
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
        Me.DisplayBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FirstNameTxtBox = New System.Windows.Forms.TextBox()
        Me.LastNameTxtBox = New System.Windows.Forms.TextBox()
        Me.StateTxtBox = New System.Windows.Forms.TextBox()
        Me.CityTxtBox = New System.Windows.Forms.TextBox()
        Me.ZipTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.FirstNameLbl = New System.Windows.Forms.Label()
        Me.LastNameLbl = New System.Windows.Forms.Label()
        Me.CityLbl = New System.Windows.Forms.Label()
        Me.StateLbl = New System.Windows.Forms.Label()
        Me.ZipLbl = New System.Windows.Forms.Label()
        Me.AddressLbl = New System.Windows.Forms.Label()
        Me.StreetAddressTxtBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DisplayBtn
        '
        Me.DisplayBtn.Location = New System.Drawing.Point(12, 363)
        Me.DisplayBtn.Name = "DisplayBtn"
        Me.DisplayBtn.Size = New System.Drawing.Size(189, 75)
        Me.DisplayBtn.TabIndex = 6
        Me.DisplayBtn.Text = "&Display"
        Me.ToolTip1.SetToolTip(Me.DisplayBtn, "Display Filled Entry Boxes")
        Me.DisplayBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(309, 363)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(189, 75)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearBtn, "Clear Boxes and Label")
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.Location = New System.Drawing.Point(599, 363)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(189, 75)
        Me.ExitBtn.TabIndex = 8
        Me.ExitBtn.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitBtn, "Click to exit form")
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'FirstNameTxtBox
        '
        Me.FirstNameTxtBox.Location = New System.Drawing.Point(101, 38)
        Me.FirstNameTxtBox.Name = "FirstNameTxtBox"
        Me.FirstNameTxtBox.Size = New System.Drawing.Size(171, 20)
        Me.FirstNameTxtBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstNameTxtBox, "Enter first name")
        '
        'LastNameTxtBox
        '
        Me.LastNameTxtBox.Location = New System.Drawing.Point(101, 64)
        Me.LastNameTxtBox.Name = "LastNameTxtBox"
        Me.LastNameTxtBox.Size = New System.Drawing.Size(171, 20)
        Me.LastNameTxtBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LastNameTxtBox, "Enter last name")
        '
        'StateTxtBox
        '
        Me.StateTxtBox.Location = New System.Drawing.Point(101, 147)
        Me.StateTxtBox.Name = "StateTxtBox"
        Me.StateTxtBox.Size = New System.Drawing.Size(171, 20)
        Me.StateTxtBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.StateTxtBox, "Enter name of state")
        '
        'CityTxtBox
        '
        Me.CityTxtBox.Location = New System.Drawing.Point(101, 121)
        Me.CityTxtBox.Name = "CityTxtBox"
        Me.CityTxtBox.Size = New System.Drawing.Size(171, 20)
        Me.CityTxtBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CityTxtBox, "Enter name of city")
        '
        'ZipTxtBox
        '
        Me.ZipTxtBox.Location = New System.Drawing.Point(101, 173)
        Me.ZipTxtBox.Mask = "00000"
        Me.ZipTxtBox.Name = "ZipTxtBox"
        Me.ZipTxtBox.Size = New System.Drawing.Size(39, 20)
        Me.ZipTxtBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ZipTxtBox, "Enter zipcode")
        Me.ZipTxtBox.ValidatingType = GetType(Integer)
        '
        'FirstNameLbl
        '
        Me.FirstNameLbl.AutoSize = True
        Me.FirstNameLbl.Location = New System.Drawing.Point(9, 38)
        Me.FirstNameLbl.Name = "FirstNameLbl"
        Me.FirstNameLbl.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLbl.TabIndex = 8
        Me.FirstNameLbl.Text = "First Name"
        Me.FirstNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LastNameLbl
        '
        Me.LastNameLbl.AutoSize = True
        Me.LastNameLbl.Location = New System.Drawing.Point(9, 64)
        Me.LastNameLbl.Name = "LastNameLbl"
        Me.LastNameLbl.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLbl.TabIndex = 9
        Me.LastNameLbl.Text = "Last Name"
        '
        'CityLbl
        '
        Me.CityLbl.AutoSize = True
        Me.CityLbl.Location = New System.Drawing.Point(9, 121)
        Me.CityLbl.Name = "CityLbl"
        Me.CityLbl.Size = New System.Drawing.Size(24, 13)
        Me.CityLbl.TabIndex = 10
        Me.CityLbl.Text = "City"
        '
        'StateLbl
        '
        Me.StateLbl.AutoSize = True
        Me.StateLbl.Location = New System.Drawing.Point(9, 147)
        Me.StateLbl.Name = "StateLbl"
        Me.StateLbl.Size = New System.Drawing.Size(32, 13)
        Me.StateLbl.TabIndex = 11
        Me.StateLbl.Text = "State"
        '
        'ZipLbl
        '
        Me.ZipLbl.AutoSize = True
        Me.ZipLbl.Location = New System.Drawing.Point(9, 176)
        Me.ZipLbl.Name = "ZipLbl"
        Me.ZipLbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ZipLbl.Size = New System.Drawing.Size(50, 13)
        Me.ZipLbl.TabIndex = 12
        Me.ZipLbl.Text = "Zip Code"
        '
        'AddressLbl
        '
        Me.AddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLbl.Location = New System.Drawing.Point(414, 18)
        Me.AddressLbl.Name = "AddressLbl"
        Me.AddressLbl.Size = New System.Drawing.Size(374, 280)
        Me.AddressLbl.TabIndex = 13
        '
        'StreetAddressTxtBox
        '
        Me.StreetAddressTxtBox.Location = New System.Drawing.Point(101, 95)
        Me.StreetAddressTxtBox.Name = "StreetAddressTxtBox"
        Me.StreetAddressTxtBox.Size = New System.Drawing.Size(171, 20)
        Me.StreetAddressTxtBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.StreetAddressTxtBox, "Enter street address")
        '
        'StreetAddressLbl
        '
        Me.StreetAddressLbl.AutoSize = True
        Me.StreetAddressLbl.Location = New System.Drawing.Point(9, 95)
        Me.StreetAddressLbl.Name = "StreetAddressLbl"
        Me.StreetAddressLbl.Size = New System.Drawing.Size(76, 13)
        Me.StreetAddressLbl.TabIndex = 15
        Me.StreetAddressLbl.Text = "Street Address"
        '
        'AddressLabelForm
        '
        Me.AcceptButton = Me.DisplayBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StreetAddressLbl)
        Me.Controls.Add(Me.StreetAddressTxtBox)
        Me.Controls.Add(Me.AddressLbl)
        Me.Controls.Add(Me.ZipLbl)
        Me.Controls.Add(Me.StateLbl)
        Me.Controls.Add(Me.CityLbl)
        Me.Controls.Add(Me.LastNameLbl)
        Me.Controls.Add(Me.FirstNameLbl)
        Me.Controls.Add(Me.ZipTxtBox)
        Me.Controls.Add(Me.StateTxtBox)
        Me.Controls.Add(Me.CityTxtBox)
        Me.Controls.Add(Me.LastNameTxtBox)
        Me.Controls.Add(Me.FirstNameTxtBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.DisplayBtn)
        Me.Name = "AddressLabelForm"
        Me.Text = "AddressLabel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents FirstNameTxtBox As TextBox
    Friend WithEvents LastNameTxtBox As TextBox
    Friend WithEvents StateTxtBox As TextBox
    Friend WithEvents CityTxtBox As TextBox
    Friend WithEvents ZipTxtBox As MaskedTextBox
    Friend WithEvents FirstNameLbl As Label
    Friend WithEvents LastNameLbl As Label
    Friend WithEvents CityLbl As Label
    Friend WithEvents StateLbl As Label
    Friend WithEvents ZipLbl As Label
    Friend WithEvents AddressLbl As Label
    Friend WithEvents StreetAddressTxtBox As TextBox
    Friend WithEvents StreetAddressLbl As Label
End Class
