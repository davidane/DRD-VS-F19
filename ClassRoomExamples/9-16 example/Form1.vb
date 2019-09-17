Option Strict On
Option Explicit On


Public Class Form1

    'PascalCase FirstLetterOfEachWord
    'Objects

    'camelCase
    'variablesUseCamelCase

    'ALLCAPS
    'CONSTANTS

    'snake_case
    'used in python have not seen on .NET

    Sub VariablesAndConstants()

        'variables can be changed
        Dim someNumber As Integer
        Dim result As Integer

        'constants can not change
        Const SOMECONST = 7D
        Console.WriteLine("SOMECONST is... " & SOMECONST)

        someNumber = 5
        Console.WriteLine("some number is... " & someNumber)
        'somenumber = 6
        'Console.WriteLine(somenumber)

        result = someNumber + CInt(SOMECONST)
        Console.WriteLine("The result sum of somenumber and the constant is... " & result)



    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        VariablesAndConstants()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
