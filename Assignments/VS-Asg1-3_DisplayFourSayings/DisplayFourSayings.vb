'Asg1-3
'RCET 0265
'Dane Davids
'Pressing different buttons will present select sayings via labels


Public Class DisplayFourSayings
    Dim Saying1, Saying2, Saying3 As String


    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying1Button.Click
        Call DisplaySaying1()
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles _
                        Saying2Button.Click
        Call DisplaySaying2()
    End Sub

    Sub DisplaySaying1()
        Saying1 = "When in doubt, throttle out..."
        DisplaySayingLabel.Text = Saying1
    End Sub

    Sub DisplaySaying2()
        'DisplaySayingLabel.Text = " "
        Saying2 = "Each person creates their own reality, makes yours the way" _
                    & " YOU want it to be..."
        DisplaySayingLabel.Text = Saying2
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
                        ExitButton.Click
        Me.Close()
    End Sub

End Class
