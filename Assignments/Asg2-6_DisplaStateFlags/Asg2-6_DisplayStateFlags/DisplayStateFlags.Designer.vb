<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayStateFlags
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
        Me.StateFlagDisplayPicBox = New System.Windows.Forms.PictureBox()
        Me.IdahoStateFlagBtn = New System.Windows.Forms.Button()
        Me.AlaskaStateFlagBtn = New System.Windows.Forms.Button()
        Me.HawaiiStateFlagBtn = New System.Windows.Forms.Button()
        Me.FloridaStateFlagBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.StateFlagDisplayPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StateFlagDisplayPicBox
        '
        Me.StateFlagDisplayPicBox.InitialImage = Nothing
        Me.StateFlagDisplayPicBox.Location = New System.Drawing.Point(12, 12)
        Me.StateFlagDisplayPicBox.Name = "StateFlagDisplayPicBox"
        Me.StateFlagDisplayPicBox.Size = New System.Drawing.Size(500, 331)
        Me.StateFlagDisplayPicBox.TabIndex = 0
        Me.StateFlagDisplayPicBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.StateFlagDisplayPicBox, "Flag Image Displays Here")
        '
        'IdahoStateFlagBtn
        '
        Me.IdahoStateFlagBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.IdahoStateFlagBtn.Location = New System.Drawing.Point(552, 7)
        Me.IdahoStateFlagBtn.Name = "IdahoStateFlagBtn"
        Me.IdahoStateFlagBtn.Size = New System.Drawing.Size(141, 82)
        Me.IdahoStateFlagBtn.TabIndex = 1
        Me.IdahoStateFlagBtn.Text = "Idaho State Flag"
        Me.ToolTip1.SetToolTip(Me.IdahoStateFlagBtn, "Click to view Idaho State Flag")
        Me.IdahoStateFlagBtn.UseVisualStyleBackColor = True
        '
        'AlaskaStateFlagBtn
        '
        Me.AlaskaStateFlagBtn.Location = New System.Drawing.Point(552, 92)
        Me.AlaskaStateFlagBtn.Name = "AlaskaStateFlagBtn"
        Me.AlaskaStateFlagBtn.Size = New System.Drawing.Size(141, 82)
        Me.AlaskaStateFlagBtn.TabIndex = 2
        Me.AlaskaStateFlagBtn.Text = "Alaska State Flag"
        Me.ToolTip1.SetToolTip(Me.AlaskaStateFlagBtn, "Click to view the Alaska State Flag")
        Me.AlaskaStateFlagBtn.UseVisualStyleBackColor = True
        '
        'HawaiiStateFlagBtn
        '
        Me.HawaiiStateFlagBtn.Location = New System.Drawing.Point(552, 178)
        Me.HawaiiStateFlagBtn.Name = "HawaiiStateFlagBtn"
        Me.HawaiiStateFlagBtn.Size = New System.Drawing.Size(141, 82)
        Me.HawaiiStateFlagBtn.TabIndex = 3
        Me.HawaiiStateFlagBtn.Text = "Hawaii State Flag"
        Me.ToolTip1.SetToolTip(Me.HawaiiStateFlagBtn, "Click to view the Hawaii State Flag")
        Me.HawaiiStateFlagBtn.UseVisualStyleBackColor = True
        '
        'FloridaStateFlagBtn
        '
        Me.FloridaStateFlagBtn.Location = New System.Drawing.Point(552, 263)
        Me.FloridaStateFlagBtn.Name = "FloridaStateFlagBtn"
        Me.FloridaStateFlagBtn.Size = New System.Drawing.Size(141, 82)
        Me.FloridaStateFlagBtn.TabIndex = 4
        Me.FloridaStateFlagBtn.Text = "Florida State Flag"
        Me.ToolTip1.SetToolTip(Me.FloridaStateFlagBtn, "Click to view the Florida State Flag")
        Me.FloridaStateFlagBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitBtn.Location = New System.Drawing.Point(552, 351)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(206, 87)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'DisplayStateFlags
        '
        Me.AcceptButton = Me.IdahoStateFlagBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitBtn
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.FloridaStateFlagBtn)
        Me.Controls.Add(Me.HawaiiStateFlagBtn)
        Me.Controls.Add(Me.AlaskaStateFlagBtn)
        Me.Controls.Add(Me.IdahoStateFlagBtn)
        Me.Controls.Add(Me.StateFlagDisplayPicBox)
        Me.Name = "DisplayStateFlags"
        Me.Text = "Display State Flags"
        CType(Me.StateFlagDisplayPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StateFlagDisplayPicBox As PictureBox
    Friend WithEvents IdahoStateFlagBtn As Button
    Friend WithEvents AlaskaStateFlagBtn As Button
    Friend WithEvents HawaiiStateFlagBtn As Button
    Friend WithEvents FloridaStateFlagBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
