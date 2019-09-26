'Asg1-3
'RCET 0265
'Dane Davids
'Pressing different buttons will present select sayings via labels


Public Class DisplayFourSayings
    Dim Saying1, Saying2, Saying3, Saying4, Defaultlabelsaying As String
    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying1Button.Click 'Sub calls display sub
        Call DisplaySaying1()
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying2Button.Click 'Sub calls display sub
        Call DisplaySaying2()
    End Sub
    Private Sub Saying3Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying3Button.Click 'Sub calls display sub
        Call DisplaySaying3()
    End Sub

    Private Sub Saying4Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying4Button.Click 'Sub calls display sub
        Call Displaysaying4()
    End Sub
    Private Sub DefaultLabelButton_Click(sender As Object, e As EventArgs) _
                        Handles DefaultLabelButton.Click 'Sub calls display sub
        Call Choosesaying()
    End Sub

    Sub DisplaySaying1() 'Gives value to the saying and sets the label text
        Saying1 = "When in doubt, throttle out..."
        DisplaySayingLabel.Text = Saying1
    End Sub
    Sub DisplaySaying2() 'Gives value to the saying and sets the label text
        Saying2 = "Each person creates their own reality, makes yours the way" _
                    & " YOU want it to be..."
        DisplaySayingLabel.Text = Saying2
    End Sub
    Sub DisplaySaying3() 'Gives value to the saying and sets the label text
        Saying3 = "Bones mend. Regret stays with you forever."
        DisplaySayingLabel.Text = Saying3
    End Sub
    Sub Displaysaying4() 'Gives value to the saying and sets the label text
        Saying4 = "It gets tiresome being spoken to as if you are a child, " _
                    & "even if you happen to be one."
        DisplaySayingLabel.Text = Saying4
    End Sub
    Sub Choosesaying() 'Gives value to the saying and sets the label text
        Defaultlabelsaying = "Choose a saying!"
        DisplaySayingLabel.Text = Defaultlabelsaying
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
                        ExitButton.Click 'Exits form
        Me.Close()
    End Sub

End Class
