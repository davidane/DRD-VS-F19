Option Explicit On 'forces the compiler to make sure programmer is naming _ 
'variables
Option Strict On '

Public Class UserInputForm
    Private Sub GetInputBtn_Click(sender As Object, e As EventArgs) Handles _
            GetInputBtn.Click

        Dim firstNumber As Integer 'variables are in camelCase
        Dim secondNumber As Integer = 7 'variables are in camelCase
        Dim resultNumber As Integer 'variables are in camelCase

        Try
            'firstNumber = CInt(UserInputTxtBox.Text)
            firstNumber = Integer.Parse(UserInputTxtBox.Text) '2 ways to convert
            Console.WriteLine("In the try code... ")
        Catch ex As Exception
            Console.WriteLine("In the catch code... ")
            MsgBox("Please enter a valid number")
            UserInputTxtBox.Text = ""
            UserInputTxtBox.Select()

        Finally
            Console.WriteLine("In the finally code... ")
        End Try


        resultNumber = firstNumber + secondNumber

        UserInputTxtBox.Text = CStr(resultNumber)

        Console.WriteLine("7 + " & UserInputTxtBox.Text & " = " &
                          resultNumber & ".")

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles _
            ExitBtn.Click
        Me.Close()
    End Sub

End Class
