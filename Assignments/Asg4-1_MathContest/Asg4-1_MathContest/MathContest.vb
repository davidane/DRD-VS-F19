'Dane Davids
'RCET0265
'Math Contest
'Have a student answer math questions and display a summary

Option Explicit On
Option Strict On

Public Class MathContest
    Dim math As Integer 'add = 1; subtract = 2; multiply = 3; divide = 4
    Dim exitForm As Boolean
    Dim firstNameTxtBoxChanged As Boolean
    Dim lastNameTxtBoxChanged As Boolean
    Dim gradeTxtBoxChanged As Boolean
    Dim ageTxtBoxChanged As Boolean



    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles _
            SubmitBtn.Click
        Dim firstName As String
        Dim lastName As String
        Dim grade As Integer
        Dim age As Integer
        Dim errorMessage As String = ""



        Try
            age = CInt(AgeTxtBox.Text)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter an age between 7 and" _
                & " 11" & vbNewLine
        End Try
        Try
            grade = CInt(GradeTxtBox.Text)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter a grade between 1st and" _
                & " 4th" & vbNewLine
            GradeTxtBox.Select()
            GradeTxtBox.Clear()
        End Try

        Try
            lastName = LastNameTxtBox.Text
        Catch ex As Exception
            errorMessage = errorMessage & "Please enter the last name for " _
                & "student" & vbNewLine
            LastNameTxtBox.Select()
            LastNameTxtBox.Clear()
        End Try
        Try
            firstName = FirstNameTxtBox.Text
        Catch ex As Exception
            errorMessage = errorMessage & "Please enter a name for the " &
                "student" & vbNewLine
            FirstNameTxtBox.Select()
            FirstNameTxtBox.Clear()
        End Try
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Something went wrong...")
        End If
    End Sub

    Private Sub AgeTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles AgeTxtBox.TextChanged
        ageTxtBoxChanged = True
    End Sub

    Private Sub GradeTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles GradeTxtBox.TextChanged
        gradeTxtBoxChanged = True
    End Sub

    Private Sub LastNameTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles LastNameTxtBox.TextChanged
        lastNameTxtBoxChanged = True
    End Sub

    Private Sub FirstNameTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles FirstNameTxtBox.TextChanged
        firstNameTxtBoxChanged = True
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles _
            ClearBtn.Click
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


    Sub DisplaySummary()

    End Sub
    Private Sub SummaryBtn_Click(sender As Object, e As EventArgs) Handles _
            SummaryBtn.Click
        DisplaySummary()
        MathContestLoadAndRestart()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles _
            ExitBtn.Click
        exitForm = True
        ExitSub()
    End Sub

    Sub ExitSub()
        Me.Close()
    End Sub

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles _
            Me.Load
        MathContestLoadAndRestart()
    End Sub

    Sub MathContestLoadAndRestart() 'restart is refering to when the summary _
        'Button Is pressed, will reset code as if the program relaoded.
        SubmitBtnDisabled()
        SummaryBtnDisabled()
        AddRBtn.Select()
        exitForm = False
        FirstNameTxtBox.Select()
        lastNameTxtBoxChanged = False
        firstNameTxtBoxChanged = False
        ageTxtBoxChanged = False
        gradeTxtBoxChanged = False
    End Sub

    Private Sub StudentInfoGroupBox_Leave(sender As Object, e As EventArgs) _
                Handles StudentInfoGroupBox.Leave
        If firstNameTxtBoxChanged = True AndAlso lastNameTxtBoxChanged = True _
                AndAlso ageTxtBoxChanged = True AndAlso gradeTxtBoxChanged =
                True Then
            SubmitBtnEnabled()
            SummaryBtnEnabled()
        End If
    End Sub

    Sub SubmitBtnEnabled()
        SubmitBtn.Enabled = True
    End Sub

    Private Sub AddRBtn_MouseClick(sender As Object, e As MouseEventArgs) _
            Handles AddRBtn.MouseClick
        math = 1
    End Sub

    Sub SummaryBtnEnabled()
        SummaryBtn.Enabled = True
    End Sub

    Sub SummaryBtnDisabled()
        SummaryBtn.Enabled = False
    End Sub

    Sub SubmitBtnDisabled()
        SubmitBtn.Enabled = False
    End Sub

    Private Sub SubtractRBtn_MouseClick(sender As Object, e As MouseEventArgs) _
            Handles SubtractRBtn.MouseClick
        math = 2
    End Sub

    Private Sub MultiplyRBtn_MouseClick(sender As Object, e As MouseEventArgs) _
            Handles MultiplyRBtn.MouseClick
        math = 3
    End Sub

    Private Sub DivideRBtn_MouseClick(sender As Object, e As MouseEventArgs) _
            Handles DivideRBtn.MouseClick
        math = 4
    End Sub
End Class
