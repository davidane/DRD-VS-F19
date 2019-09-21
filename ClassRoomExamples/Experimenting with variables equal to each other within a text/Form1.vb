Option Explicit On
Option Strict On


Public Class Form1
    Dim Saying1 As Integer = 1
    Dim saying2 As Integer = 5
    Dim saying3 As Integer = 11
    Dim result As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Diner's specials are... "
    End Sub

    Private Sub Special1Button_Click(sender As Object, e As EventArgs) Handles Special1Button.Click
        If result = 5 AndAlso result = 11 AndAlso result = 16 AndAlso result = 0 Then
            Label1.Text = Label1.Text & "Specail1 "
        End If
        result = result + Saying1
    End Sub

    Private Sub Special2Button_Click(sender As Object, e As EventArgs) Handles Special2Button.Click
        result = result + saying2
        If result = 0 AndAlso result = 1 AndAlso result = 11 AndAlso result = 12 Then
            Label1.Text = Label1.Text & "Specail2 "
        End If
    End Sub

    Private Sub Special3Button_Click(sender As Object, e As EventArgs) Handles Special3Button.Click
        result = result + saying3
        If result = 1 AndAlso result = 6 AndAlso result = 5 AndAlso result = 0 Then
            Label1.Text = Label1.Text & "Special3 "
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
