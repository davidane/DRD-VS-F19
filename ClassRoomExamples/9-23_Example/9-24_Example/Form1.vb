'Dane Davids
'9-24 & 9-25 Example

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
        Dim firstString As String = "     Hello      "
        Dim secondString As String = "abcde"
        Dim x As Integer '= Hex(90)
        'x = Chr(90)
        x = Len(firstString)

        Console.WriteLine("Before trim " & firstString)
        firstString = Trim(firstString)
        Console.WriteLine("After trim " & firstString)

        Console.WriteLine("before the loop" & Str(x))
        For i = 1 To 10
            firstString &= "!"
            Console.WriteLine(firstString)
        Next
        x = Len(firstString)
        Console.WriteLine("After the loop" & Str(x))
        Console.WriteLine(firstString)

        Console.WriteLine(Mid(firstString, 2, 3))

        'Console.WriteLine(firstString > secondString)
        'Console.WriteLine(x)

    End Sub

    'Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
    '    Console.WriteLine(e.KeyCode & vbNewLine & e.KeyData & vbNewLine & e.KeyValue & vbNewLine & e.Shift)

    'End Sub

    'Sub Beep()
    '    Beep(300)

    'End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class


