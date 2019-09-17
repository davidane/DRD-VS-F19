'Asg1-5_Diner
'Dane Davids
'RCET 0265
'Selecting buttons will display daily specials
'https://github.com/davidane/DRD-VS-F19/tree/master/Assignments/Asg1-5_Diner

Option Explicit On
Option Strict On

Public Class DinerForm
    Dim Special As String 'Dimming the special in the class portion will' _
    'make it possible for me to change its value over the whole form'
    Dim SSpecial As Boolean 'sets class variable to edit over multiple subs
    Dim Cspecial As Boolean 'sets class variable to edit over multiple subs
    Dim FSpecial As Boolean 'sets class variable to edit over multiple subs

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles _
            SoupButton.Click 'calls sub at click of button
        Call Soup()
    End Sub

    Private Sub ChefButton_Click(sender As Object, e As EventArgs) Handles _
            ChefButton.Click 'calls sub at click of button
        Call Chef()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles _
            FishButton.Click 'calls sub at click of button
        Call Fish()
    End Sub

    Sub Soup()
        If SSpecial = False Then SpecialLabel.Text = SpecialLabel.Text &
            " Soup: Cream of potato and bacon."
        'when sub is called, if statement checks whether the _
        'statement has been written already; through boolean
        SSpecial = True 'sets boolean to true so statement will not repeat 
    End Sub
    Sub Chef()
        If Cspecial = False Then SpecialLabel.Text = SpecialLabel.Text &
            " Chef's: Italian BMT with pepperjack cheese."
        'when sub is called, if statement checks whether the _
        'statement has been written already; through boolean
        Cspecial = True 'sets boolean to true so statement will not repeat 
    End Sub
    Sub Fish()
        If FSpecial = False Then SpecialLabel.Text = SpecialLabel.Text &
            " Fish: King(Chinook) Salmon Steak w/ one side."
        'when sub is called, if statement checks whether the _
        'statement has been written already; through boolean
        FSpecial = True 'sets boolean to true so statement will not repeat 
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
            ExitButton.Click 'closes form at click of button
        Me.Close()
    End Sub

End Class
