Option Explicit On
Option Strict On

Public Class Form1

    Sub SetToDefault() 'reusable code
        FirstTxtBox.Clear()
        SecondTxtBox.Clear()
        ThirdTxtBox.Clear()
        GoBtn.Enabled = False
        FirstTxtBox.Select()
    End Sub

    Sub HasValidInteger(txtBox As TextBox)
        Dim number As Integer
        Try
            'number = CInt(stringData)
            number = CInt(txtBox.Text)
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter an integer for proper code functioning", "We have a problem")
        End Try
    End Sub

    Sub validateAlltextBoxes()
        'UserInputGroupBox.
    End Sub

    Function MyFunc() As Integer

        Return 0
    End Function

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SetToDefault()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetToDefault()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        HasValidInteger(FirstTxtBox)
    End Sub
End Class

'Tim's 10-2 example for reusable code is excellent for future assignments that consists of for loops, temporary data, and conditional statement.