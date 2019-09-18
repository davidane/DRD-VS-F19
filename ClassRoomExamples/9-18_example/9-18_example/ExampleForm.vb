Option Strict On
Option Explicit On

Public Class ExampleForm

    Private Sub RunBtn_Click(sender As Object, e As EventArgs) Handles RunBtn.Click

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim errorMessage As String = ""
        loadTestData() 'load sample data remove for product test

        Try
            'try something that might throw out 

            secondNumber = CInt(TextBox2.Text)

        Catch anyException As Exception
            'exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the second textbox." & vbNewLine

            TextBox2.Select()
            TextBox2.Clear()
        Finally

        End Try


        Try
            'try something that might throw out 
            firstNumber = CInt(TextBox1.Text)
        Catch anyException As Exception
            'exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the first textbox." & vbNewLine

            TextBox1.Select()
            TextBox1.Clear()
        Finally

        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "We have problem")
        End If

    End Sub

    Private Sub loadTestData()
        Dim sample As Integer
        'need to go over static varibles for class on 9-19
        For sample = 1 To 4 Step 1
            Select Case sample
                Case = 1

                    TextBox1.Text = "5"
                    TextBox2.Text = "6"
                    Exit For
                Case = 2
                    TextBox1.Text = "bad"
                    TextBox2.Text = "6"
                    Exit For
                Case = 3
                    TextBox1.Text = "5"
                    TextBox2.Text = "bad"
                    Exit For
                Case = 4
                    TextBox1.Text = "bad"
                    TextBox2.Text = "bad"
                    Exit For
                Case Else
                    'some unexpected thing

            End Select
        Next sample
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
