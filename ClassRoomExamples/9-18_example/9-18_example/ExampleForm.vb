Option Strict On
Option Explicit On

Public Class ExampleForm

    Private Sub RunBtn_Click(sender As Object, e As EventArgs) Handles RunBtn.Click

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim errorMessage As String = ""
        Dim result As Integer
        'loadTestData() 'load sample data remove for product test
        'loadtestdata was added to test numbers and code functionality
        Try
            'try something that might throw out 

            secondNumber = CInt(TextBox2.Text)

        Catch anyException As FormatException
            'exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the second textbox." & vbNewLine

            TextBox2.Select()
            TextBox2.Clear()
        Catch ex As Exception 'catch unexpected errors
            Console.WriteLine(ex.Message)

        End Try


        Try
            'try something that might throw out 
            firstNumber = CInt(TextBox1.Text)
        Catch anyException As FormatException
            'exception thrown so do stuff
            errorMessage = errorMessage & "Please enter a number in the first textbox." & vbNewLine

            TextBox1.Select()
            TextBox1.Clear()
        Catch ex As Exception 'catch unexpected errors
            Console.WriteLine(ex.Message)

        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "We have problem")
        Else
            result = firstNumber + secondNumber
            TextBox3.Text = result.ToString("C")

        End If

    End Sub

    Private Sub loadTestData()
        Static sample As Integer
        'need to go over static varibles for class on 9-19

        'by default, sample initializes to zero

        Select Case sample
            Case = 0

                TextBox1.Text = "5"
                TextBox2.Text = "6"
                
            Case = 1
                TextBox1.Text = "bad"
                TextBox2.Text = "6"

            Case = 2
                TextBox1.Text = "5"
                TextBox2.Text = "bad"

            Case = 3
                TextBox1.Text = "bad"
                TextBox2.Text = "bad"

            Case Else
                'some unexpected thing

        End Select
        If sample >= 3 Then
            sample = 0
        Else sample += 1
            End If

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
