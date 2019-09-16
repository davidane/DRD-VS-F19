'Asg1-5_Diner
'Dane Davids
'RCET 0265
'Selecting buttons will display daily specials

Option Explicit On
Option Strict On

Public Class DinerForm
    Dim Special As String 'Dimming the special in the class portion will' _
    'make it possible for me to change its value over the whole form'
    Dim SSpecial As Boolean
    Dim Cspecial As Boolean
    Dim FSpecial As Boolean

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles _
            SoupButton.Click
        Call Soup()
    End Sub

    Private Sub ChefButton_Click(sender As Object, e As EventArgs) Handles _
            ChefButton.Click
        Call Chef()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles _
            FishButton.Click
        Call Fish()
    End Sub

    Sub Soup()
        If SSpecial = False Then SpecialLabel.Text = SpecialLabel.Text & " Soup: Cream of potato and bacon."
        SSpecial = True
    End Sub
    Sub Chef()
        If Cspecial = False Then SpecialLabel.Text = SpecialLabel.Text & " Chef's: Italian BMT with pepperjack cheese."
        Cspecial = True
    End Sub
    Sub Fish()
        If FSpecial = False Then SpecialLabel.Text = SpecialLabel.Text & " Fish: King(Chinook) Salmon Steak w/ one side."
        FSpecial = True
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
            ExitButton.Click
        Me.Close()
    End Sub



    'Private Sub DinerForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    'End Sub 'Working on making it so after there is something already present in the text label, it will
End Class
