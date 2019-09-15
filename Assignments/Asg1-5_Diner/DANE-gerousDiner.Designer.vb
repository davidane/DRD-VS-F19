<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerForm
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
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.ChefButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SpecialLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(25, 379)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(165, 59)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Daily Soup"
        Me.ToolTip1.SetToolTip(Me.SoupButton, "Display Special")
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'ChefButton
        '
        Me.ChefButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChefButton.Location = New System.Drawing.Point(196, 379)
        Me.ChefButton.Name = "ChefButton"
        Me.ChefButton.Size = New System.Drawing.Size(165, 59)
        Me.ChefButton.TabIndex = 1
        Me.ChefButton.Text = "Chef's Special"
        Me.ToolTip1.SetToolTip(Me.ChefButton, "Display Special")
        Me.ChefButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.Location = New System.Drawing.Point(367, 379)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(165, 59)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Daily fish"
        Me.ToolTip1.SetToolTip(Me.FishButton, "Display Special")
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(727, 409)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(61, 29)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SpecialLabel
        '
        Me.SpecialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialLabel.Location = New System.Drawing.Point(12, 9)
        Me.SpecialLabel.Name = "SpecialLabel"
        Me.SpecialLabel.Size = New System.Drawing.Size(776, 81)
        Me.SpecialLabel.TabIndex = 4
        Me.SpecialLabel.Text = "DANE-gerous Diner's specials for today are... "
        '
        'DinerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SpecialLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.ChefButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "DinerForm"
        Me.Text = "DANE-gerousDinerForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents ChefButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SpecialLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
