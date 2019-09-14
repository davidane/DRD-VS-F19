<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayFourSayings
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Saying2Button = New System.Windows.Forms.Button()
        Me.Saying3Button = New System.Windows.Forms.Button()
        Me.Saying4Button = New System.Windows.Forms.Button()
        Me.Saying1Button = New System.Windows.Forms.Button()
        Me.OwnerNameLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DisplaySayingLabel = New System.Windows.Forms.Label()
        Me.DefaultLabelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(757, 380)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(98, 58)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Saying2Button
        '
        Me.Saying2Button.Location = New System.Drawing.Point(12, 307)
        Me.Saying2Button.Name = "Saying2Button"
        Me.Saying2Button.Size = New System.Drawing.Size(191, 36)
        Me.Saying2Button.TabIndex = 1
        Me.Saying2Button.Text = "Display Saying #&2"
        Me.ToolTip1.SetToolTip(Me.Saying2Button, "Display Second Saying")
        Me.Saying2Button.UseVisualStyleBackColor = True
        '
        'Saying3Button
        '
        Me.Saying3Button.Location = New System.Drawing.Point(12, 349)
        Me.Saying3Button.Name = "Saying3Button"
        Me.Saying3Button.Size = New System.Drawing.Size(191, 36)
        Me.Saying3Button.TabIndex = 2
        Me.Saying3Button.Text = "Display Saying #&3"
        Me.ToolTip1.SetToolTip(Me.Saying3Button, "Display Third Saying")
        Me.Saying3Button.UseVisualStyleBackColor = True
        '
        'Saying4Button
        '
        Me.Saying4Button.Location = New System.Drawing.Point(12, 391)
        Me.Saying4Button.Name = "Saying4Button"
        Me.Saying4Button.Size = New System.Drawing.Size(191, 36)
        Me.Saying4Button.TabIndex = 3
        Me.Saying4Button.Text = "Display Saying #&4"
        Me.ToolTip1.SetToolTip(Me.Saying4Button, "Display Fourth Saying")
        Me.Saying4Button.UseVisualStyleBackColor = True
        '
        'Saying1Button
        '
        Me.Saying1Button.Location = New System.Drawing.Point(12, 265)
        Me.Saying1Button.Name = "Saying1Button"
        Me.Saying1Button.Size = New System.Drawing.Size(191, 36)
        Me.Saying1Button.TabIndex = 4
        Me.Saying1Button.Text = "Display Saying #&1"
        Me.ToolTip1.SetToolTip(Me.Saying1Button, "Display First Saying")
        Me.Saying1Button.UseVisualStyleBackColor = True
        '
        'OwnerNameLabel
        '
        Me.OwnerNameLabel.AutoSize = True
        Me.OwnerNameLabel.Location = New System.Drawing.Point(273, 425)
        Me.OwnerNameLabel.Name = "OwnerNameLabel"
        Me.OwnerNameLabel.Size = New System.Drawing.Size(126, 13)
        Me.OwnerNameLabel.TabIndex = 5
        Me.OwnerNameLabel.Text = "Created by: Dane Davids"
        '
        'DisplaySayingLabel
        '
        Me.DisplaySayingLabel.AutoSize = True
        Me.DisplaySayingLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySayingLabel.Location = New System.Drawing.Point(7, 48)
        Me.DisplaySayingLabel.Name = "DisplaySayingLabel"
        Me.DisplaySayingLabel.Size = New System.Drawing.Size(331, 29)
        Me.DisplaySayingLabel.TabIndex = 6
        Me.DisplaySayingLabel.Text = "Choose a saying to be displayed!"
        Me.ToolTip1.SetToolTip(Me.DisplaySayingLabel, "Words go here")
        '
        'DefaultLabelButton
        '
        Me.DefaultLabelButton.Location = New System.Drawing.Point(757, 307)
        Me.DefaultLabelButton.Name = "DefaultLabelButton"
        Me.DefaultLabelButton.Size = New System.Drawing.Size(98, 58)
        Me.DefaultLabelButton.TabIndex = 7
        Me.DefaultLabelButton.Text = "&Default Label"
        Me.DefaultLabelButton.UseVisualStyleBackColor = True
        '
        'DisplayFourSayings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 450)
        Me.Controls.Add(Me.DefaultLabelButton)
        Me.Controls.Add(Me.DisplaySayingLabel)
        Me.Controls.Add(Me.OwnerNameLabel)
        Me.Controls.Add(Me.Saying1Button)
        Me.Controls.Add(Me.Saying4Button)
        Me.Controls.Add(Me.Saying3Button)
        Me.Controls.Add(Me.Saying2Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "DisplayFourSayings"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents Saying2Button As Button
    Friend WithEvents Saying3Button As Button
    Friend WithEvents Saying4Button As Button
    Friend WithEvents Saying1Button As Button
    Friend WithEvents OwnerNameLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DisplaySayingLabel As Label
    Friend WithEvents DefaultLabelButton As Button
End Class
