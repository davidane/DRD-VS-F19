'Dane Davids
'RCET0265
'Math Contest
'Have a student answer math questions and display a summary

Option Explicit On
Option Strict On

Public Class MathContest



    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ClearAllFields()
    End Sub

    Sub ClearAllFields()
        FirstNameTxtBox.Text = ""
        LastNameTxtBox.Text = ""
        GradeTxtBox.Text = ""
        AgeTxtBox.Text = ""
        FirstNumberTxtBox.Text = ""
        SecondNumberTxtBox.Text = ""
        StudentAnswerTxtBox.Text = ""
    End Sub

    Sub SubmitBtnDisabled()
        SubmitBtn.Enabled = False
    End Sub

    Sub SubmitBtnEnabled()
        SubmitBtn.Enabled = True
    End Sub

    Sub DisplaySummary()

    End Sub
    Private Sub SummaryBtn_Click(sender As Object, e As EventArgs) Handles SummaryBtn.Click

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub FirstNameTxtBox_Leave(sender As Object, e As EventArgs) Handles FirstNameTxtBox.Leave

        Dim firstName As String

        If firstName = "" Then MessageBox.Show("Please Enter A Name...", "Something Went Wrong") ElseIf firstname 

        End If

        'Try
        '    firstName = FirstNameTxtBox.Text

        'Catch ex As Exception
        '    Console.WriteLine("Something went wrong")

        'End Try
    End Sub
End Class
