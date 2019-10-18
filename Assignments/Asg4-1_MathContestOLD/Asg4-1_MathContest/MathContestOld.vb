'Dane Davids
'RCET0265
'Math Contest
'Have a student answer math questions and display a summary

Option Explicit On
Option Strict On

Public Class MathContestOld

    Dim exitForm As Boolean 'class variable was added because exitting was _
    'Not allowed when no values were changed in the text boxes of the _
    'StudentInformationGroupBox

    'values were added so that multiple students could use the program _
    'without having To Exit the form altogether; only a clear Or summary _
    'will reset Boolean values of these variables
    Dim firstNameTxtBoxChanged As Boolean
    Dim lastNameTxtBoxChanged As Boolean
    Dim gradeTxtBoxChanged As Boolean
    Dim ageTxtBoxChanged As Boolean

    'correct answers were made class level so that they could be cleared and _
    'Set globally. Another way, maybe better, would be To Dim them As a list _
    'And alter that via another method
    Dim correctAnswers As Integer
    Dim incorrectAnswers As Integer



    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles _
            SubmitBtn.Click

        'names, age, and grade were dimmed for ease of coding; could probably _
        'get away with not doing it, but...
        Dim firstName As String
        Dim lastName As String
        Dim grade As Integer
        Dim age As Integer

        'error message was dimmed as a string in the case that multiple text _
        'boxes were Not entered correctly; And initiallized With a "" because _
        'at the End Of the Sub, the errorMessage <> "" means that if the _
        'error message was changed that it will do something
        Dim errorMessage As String = ""


        Dim studentAnswer As Double
        Dim generatedAnswer As Double
        Dim numberOne As Double = CDbl(FirstNumberTxtBox.Text)
        Dim numberTwo As Double = CDbl(SecondNumberTxtBox.Text)

        Try
            studentAnswer = CDbl(StudentAnswerTxtBox.Text)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter a valid number with " _
                & "number rounded to nearest tenths"
        End Try

        Try
            age = CInt(AgeTxtBox.Text) And CInt(age < 7) And CInt(age > 11)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter an age between 7 and" _
                & " 11" & vbNewLine
            AgeTxtBox.Select()
            AgeTxtBox.Clear()
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
        Select Case True
            Case AddRBtn.Checked
                generatedAnswer = (numberOne + numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05
                    )) Or studentAnswer < (generatedAnswer - (generatedAnswer _
                      * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer was incorrect, the correct answer was " & generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName & ", your answer was correct")
                    correctAnswers = +1
                End If
            Case SubtractRBtn.Checked
                generatedAnswer = (numberOne - numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05)) Or studentAnswer < (generatedAnswer - (generatedAnswer * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer was incorrect, the correct answer was " & generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName & ", your answer was correct")
                    correctAnswers = +1
                End If
            Case MultiplyRBtn.Checked
                generatedAnswer = (numberOne * numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05)) Or studentAnswer < (generatedAnswer - (generatedAnswer * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer was incorrect, the correct answer was " & generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName & ", your answer was correct")
                    correctAnswers = +1
                End If
            Case DivideRBtn.Checked
                generatedAnswer = (numberOne / numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05)) Or studentAnswer < (generatedAnswer - (generatedAnswer * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer was incorrect, the correct answer was " & generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName & ", your answer was correct")
                    correctAnswers = +1
                End If
        End Select
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Something went wrong...")

        Else

        End If
        randomNumbers()

    End Sub

    Private Sub randomNumbers()
        Dim randomGen As Random = New Random(DateTime.Now.Millisecond)
        Dim randomNumberOne As Integer = randomGen.Next(1, 10)
        Dim randomNumberTwo As Integer = randomGen.Next(1, 10)
        FirstNumberTxtBox.Text = CStr(randomNumberOne)
        SecondNumberTxtBox.Text = CStr(randomNumberTwo)
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

    Private Sub ClearAllFields()
        FirstNameTxtBox.Text = ""
        LastNameTxtBox.Text = ""
        GradeTxtBox.Text = ""
        AgeTxtBox.Text = ""
        FirstNumberTxtBox.Text = ""
        SecondNumberTxtBox.Text = ""
        StudentAnswerTxtBox.Text = ""
        firstNameTxtBoxChanged = False
        lastNameTxtBoxChanged = False
        gradeTxtBoxChanged = False
        ageTxtBoxChanged = False
    End Sub


    Private Sub DisplaySummary()

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

    Private Sub ExitSub()
        Me.Close()
    End Sub

    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles _
            Me.Load
        MathContestLoadAndRestart()
    End Sub

    Private Sub MathContestLoadAndRestart() 'restart is refering to when the summary _
        'Button Is pressed, will reset code as if the program relaoded.
        SubmitBtnDisabled()
        SummaryBtnDisabled()
        AddRBtn.Select() 'could also do AddRBtn.Checked = True
        exitForm = False
        FirstNameTxtBox.Select()
        lastNameTxtBoxChanged = False
        firstNameTxtBoxChanged = False
        ageTxtBoxChanged = False
        gradeTxtBoxChanged = False
        'FirstNumberTxtBox.Text = CStr(randomNumberOne)
        'SecondNumberTxtBox.Text = CStr(randNumberTwo)
        SubmitBtnDisabled()
        SummaryBtnDisabled()
        randomNumbers()
    End Sub

    Private Sub StudentInfoGroupBox_Leave(sender As Object, e As EventArgs) _
                Handles StudentInfoGroupBox.Leave
        If firstNameTxtBoxChanged = True AndAlso lastNameTxtBoxChanged = True _
                AndAlso ageTxtBoxChanged = True AndAlso
                gradeTxtBoxChanged = True Then
            SubmitBtnEnabled()
            SummaryBtnEnabled()
            'FirstNumberTxtBox.Text = CStr(randomNumberOne)
            'SecondNumberTxtBox.Text = CStr(randNumberTwo)
            randomNumbers()
        End If
    End Sub

    Private Sub SubmitBtnEnabled()
        SubmitBtn.Enabled = True
    End Sub


    Private Sub SummaryBtnEnabled()
        SummaryBtn.Enabled = True
    End Sub

    Private Sub SummaryBtnDisabled()
        SummaryBtn.Enabled = False
    End Sub

    Private Sub SubmitBtnDisabled()
        SubmitBtn.Enabled = False
    End Sub
End Class


'need to set up summary and remaining math functions