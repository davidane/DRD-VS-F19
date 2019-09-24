Option Strict On
Option Explicit On
Option Compare Text 'binary is default

Public Class Form1
    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click
        compareStrings()
    End Sub

    Sub compareNumbers()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim thirdNumber As Integer

        firstNumber = 1
        secondNumber = 4
        thirdNumber = 3

        'is third number between first and second number
        If thirdNumber > firstNumber And thirdNumber < secondNumber Then
            MessageBox.Show("True")
        Else
            MessageBox.Show("False")
        End If
    End Sub

    Sub compareStrings()
        Dim firstString As String = "abcd"
        Dim secondString As String = "abcde"
        Dim x As String '= Hex(90)
        x = Chr(90)



        Console.WriteLine(firstString > secondString)
        Console.WriteLine(x)


    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
