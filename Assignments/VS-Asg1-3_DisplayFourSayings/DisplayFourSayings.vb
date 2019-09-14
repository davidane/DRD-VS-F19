'Asg1-3
'RCET 0265
'Dane Davids
'Pressing different buttons will present select sayings via labels


Public Class DisplayFourSayings
    Dim Saying1, Saying2, Saying3, Saying4, Defaultlabelsaying As String
    'Sub DisplayFourSayings_load()
    'Call Choosesaying()
    'End Sub        'Was trying to get the form to load with default display
    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying1Button.Click
        Call DisplaySaying1()
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying2Button.Click
        Call DisplaySaying2()
    End Sub
    Private Sub Saying3Button_Click(sender As Object, e As EventArgs) Handles Saying3Button.Click
        Call DisplaySaying3()
    End Sub

    Private Sub Saying4Button_Click(sender As Object, e As EventArgs) Handles Saying4Button.Click
        Call Displaysaying4()
    End Sub
    Private Sub DefaultLabelButton_Click(sender As Object, e As EventArgs) _
                        Handles DefaultLabelButton.Click
        Call Choosesaying()
    End Sub

    Sub DisplaySaying1()
        Saying1 = "When in doubt, throttle out..."
        DisplaySayingLabel.Text = Saying1
    End Sub
    Sub DisplaySaying2()
        Saying2 = "Each person creates their own reality, makes yours the way" _
                    & " YOU want it to be..."
        DisplaySayingLabel.Text = Saying2
    End Sub
    Sub DisplaySaying3()
        Saying3 = "Bones mend. Regret stays with you forever."
        DisplaySayingLabel.Text = Saying3
    End Sub
    Sub Displaysaying4()
        Saying4 = "It gets tiresome being spoken to as if you are a child, " _
                    & "even if you happen to be one."
        DisplaySayingLabel.Text = Saying4
    End Sub
    Sub Choosesaying()
        Defaultlabelsaying = "Choose a saying!"
        DisplaySayingLabel.Text = Defaultlabelsaying
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
                        ExitButton.Click
        Me.Close()
    End Sub

End Class
