'Dane Davids
'RCET 0265
'Sprint-1
'Convert string to integer

Option Explicit On
Option Strict On
Option Compare Binary
Public Class Sprint1Form

    Private Function ValidateAndConvert(ByRef convertThisString As String,
                                        ByRef toThisInteger As Integer) As String

        'Try and catch attemps to convert a string to integer
        Try
            convertThisString = ConvertingTextBox.Text
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception

            'If statement is placed to check if string is empty, or else the _
            'output will tell the user to input a number
            If ConvertingTextBox.Text = "" Then
                'OutputLabel.Text = "is empty"
                ValidateAndConvert = "is empty"
            Else
                'OutputLabel.Text = "Must contain a number"
                ValidateAndConvert = "Must contain a number"
            End If
            'ConvertingTextBox.Select()
            'ConvertingTextBox.Clear()
        End Try

        Return (ValidateAndConvert)
    End Function

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles _
            ConvertButton.Click
        'converThisString and toThisInteger are Dimension to meet the _
        'arguments in the sub it Is calling; arguments were placed because _
        'of instructions
        Dim convertThisString As String, toThisInteger As Integer
        ValidateAndConvert(convertThisString, toThisInteger)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
            ExitButton.Click
        Me.Close()
    End Sub
End Class
