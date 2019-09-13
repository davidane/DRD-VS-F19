<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiLangHelloWorldForm
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
        Me.EnglishHelloWorldButton = New System.Windows.Forms.Button()
        Me.HelloWorldTextBox = New System.Windows.Forms.TextBox()
        Me.EspanolHelloWorldButton = New System.Windows.Forms.Button()
        Me.FrenchHelloWorldButton = New System.Windows.Forms.Button()
        Me.ExitFormButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EnglishHelloWorldButton
        '
        Me.EnglishHelloWorldButton.Location = New System.Drawing.Point(117, 308)
        Me.EnglishHelloWorldButton.Name = "EnglishHelloWorldButton"
        Me.EnglishHelloWorldButton.Size = New System.Drawing.Size(75, 23)
        Me.EnglishHelloWorldButton.TabIndex = 0
        Me.EnglishHelloWorldButton.Text = "English"
        Me.EnglishHelloWorldButton.UseVisualStyleBackColor = True
        '
        'HelloWorldTextBox
        '
        Me.HelloWorldTextBox.Location = New System.Drawing.Point(173, 176)
        Me.HelloWorldTextBox.Name = "HelloWorldTextBox"
        Me.HelloWorldTextBox.Size = New System.Drawing.Size(149, 20)
        Me.HelloWorldTextBox.TabIndex = 1
        '
        'EspanolHelloWorldButton
        '
        Me.EspanolHelloWorldButton.Location = New System.Drawing.Point(198, 308)
        Me.EspanolHelloWorldButton.Name = "EspanolHelloWorldButton"
        Me.EspanolHelloWorldButton.Size = New System.Drawing.Size(75, 23)
        Me.EspanolHelloWorldButton.TabIndex = 2
        Me.EspanolHelloWorldButton.Text = "Espanol"
        Me.EspanolHelloWorldButton.UseVisualStyleBackColor = True
        '
        'FrenchHelloWorldButton
        '
        Me.FrenchHelloWorldButton.Location = New System.Drawing.Point(279, 308)
        Me.FrenchHelloWorldButton.Name = "FrenchHelloWorldButton"
        Me.FrenchHelloWorldButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FrenchHelloWorldButton.Size = New System.Drawing.Size(75, 23)
        Me.FrenchHelloWorldButton.TabIndex = 3
        Me.FrenchHelloWorldButton.Text = "French"
        Me.FrenchHelloWorldButton.UseVisualStyleBackColor = True
        '
        'ExitFormButton
        '
        Me.ExitFormButton.Location = New System.Drawing.Point(573, 415)
        Me.ExitFormButton.Name = "ExitFormButton"
        Me.ExitFormButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ExitFormButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitFormButton.TabIndex = 4
        Me.ExitFormButton.Text = "Exit"
        Me.ExitFormButton.UseVisualStyleBackColor = True
        '
        'MultiLangHelloWorldForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitFormButton)
        Me.Controls.Add(Me.FrenchHelloWorldButton)
        Me.Controls.Add(Me.EspanolHelloWorldButton)
        Me.Controls.Add(Me.HelloWorldTextBox)
        Me.Controls.Add(Me.EnglishHelloWorldButton)
        Me.Name = "MultiLangHelloWorldForm"
        Me.Text = "MultiLangHelloWorldForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnglishHelloWorldButton As Button
    Friend WithEvents HelloWorldTextBox As TextBox
    Friend WithEvents EspanolHelloWorldButton As Button
    Friend WithEvents FrenchHelloWorldButton As Button
    Friend WithEvents ExitFormButton As Button
End Class
