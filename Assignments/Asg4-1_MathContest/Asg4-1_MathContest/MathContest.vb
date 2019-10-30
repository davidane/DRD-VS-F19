'Dane Davids
'RCET0265
'Math Contest
'Have a student answer math questions and display a summary

Option Explicit On
Option Strict On

Public Class MathContest

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

    'correctAnswers, incorrectAnswers and totalQuestions were made class level so that they could be cleared and _
    'Set globally. Another way, maybe better, would be To Dim them As a list _
    'And alter that via another method
    Dim correctAnswers As Integer
    Dim incorrectAnswers As Integer
    Dim totalQuestions As Integer = (incorrectAnswers + correctAnswers)



    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles _
            SubmitButton.Click

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
        Dim numberOne As Double = CDbl(FirstNumberTextBox.Text)
        Dim numberTwo As Double = CDbl(SecondNumberTextBox.Text)

        Try
            studentAnswer = CDbl(StudentAnswerTxtBox.Text)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter a valid number with " _
                & "number rounded to nearest tenths"
        End Try

        Try
            age = CInt(AgeTextBox.Text)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter an age between 7 and" _
                & " 11" & vbNewLine
            AgeTextBox.Select()
            AgeTextBox.Clear()
        End Try
        Try
            grade = CInt(GradeTextBox.Text)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter a grade between 1st and" _
                & " 4th" & vbNewLine
            GradeTextBox.Select()
            GradeTextBox.Clear()
        End Try
        Try
            lastName = LastNameTextBox.Text
        Catch ex As Exception
            errorMessage = errorMessage & "Please enter the last name for " _
                & "student" & vbNewLine
            LastNameTextBox.Select()
            LastNameTextBox.Clear()
        End Try
        Try
            firstName = FirstNameTextBox.Text
        Catch ex As Exception
            errorMessage = errorMessage & "Please enter a name for the " &
                "student" & vbNewLine
            FirstNameTextBox.Select()
            FirstNameTextBox.Clear()
        End Try
        'If age < 7 And age > 11 Then
        '    MessageBox.Show("Please enter and age between 7-11")
        '    AgeTxtBox.Select()
        '    AgeTxtBox.Clear()
        'ElseIf grade < 1 And grade > 4 Then
        '    MessageBox.Show("Please enter a grade between 1st-4th")
        '    GradeTxtBox.Clear()
        '    GradeTxtBox.Select()
        'End If
        Select Case True
            Case AddRadioButton.Checked
                generatedAnswer = (numberOne + numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05
                    )) Or studentAnswer < (generatedAnswer - (generatedAnswer _
                      * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer" _
                    & "was incorrect, the correct answer was " &
                        generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName _
                        & ", your answer was correct")
                    correctAnswers = +1
                End If
            Case SubtractRadioButton.Checked
                generatedAnswer = (numberOne - numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05
                    )) Or studentAnswer < (generatedAnswer - (generatedAnswer _
                        * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer " _
                    & "was incorrect, the correct answer was " &
                    generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName _
                                    & ", your answer was correct")
                    correctAnswers = +1
                End If
            Case MultiplyRadioButton.Checked
                generatedAnswer = (numberOne * numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05
                    )) Or studentAnswer < (generatedAnswer - (generatedAnswer _
                        * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer " _
                                    & "was incorrect, the correct answer was" _
                                        & " " & generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName _
                                    & ", your answer was correct")
                    correctAnswers = +1
                End If
            Case DivideRadioButton.Checked
                generatedAnswer = (numberOne / numberTwo)
                If studentAnswer > (generatedAnswer + (generatedAnswer * 0.05
                    )) Or studentAnswer < (generatedAnswer - (generatedAnswer _
                    * 0.05)) Then
                    MessageBox.Show(firstName & " " & lastName & "'s answer " _
                                    & "was incorrect, the correct answer was" _
                                        & " " & generatedAnswer)
                    incorrectAnswers = +1
                Else
                    MessageBox.Show("Good Job " & firstName & " " & lastName _
                                    & ", your answer was correct")
                    correctAnswers = +1
                End If
        End Select
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Something went wrong...")

        Else

        End If
        randomNumbers()
        StudentAnswerTxtBox.Text = ""
        StudentAnswerTxtBox.Select()

    End Sub

    Private Sub randomNumbers()
        Dim randomGen As Random = New Random(DateTime.Now.Millisecond)
        Dim randomNumberOne As Integer = randomGen.Next(1, 10)
        Dim randomNumberTwo As Integer = randomGen.Next(1, 10)
        FirstNumberTextBox.Text = CStr(randomNumberOne)
        SecondNumberTextBox.Text = CStr(randomNumberTwo)
    End Sub

    Private Sub AgeTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles AgeTextBox.TextChanged
        ageTxtBoxChanged = True
    End Sub

    Private Sub GradeTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles GradeTextBox.TextChanged
        gradeTxtBoxChanged = True
    End Sub

    Private Sub LastNameTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles LastNameTextBox.TextChanged
        lastNameTxtBoxChanged = True
    End Sub

    Private Sub FirstNameTxtBox_TextChanged(sender As Object, e As EventArgs) _
            Handles FirstNameTextBox.TextChanged
        firstNameTxtBoxChanged = True
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles _
            ClearButton.Click
        ClearAllFields()
    End Sub

    Private Sub ClearAllFields()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        GradeTextBox.Text = ""
        AgeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTxtBox.Text = ""
        firstNameTxtBoxChanged = False
        lastNameTxtBoxChanged = False
        gradeTxtBoxChanged = False
        ageTxtBoxChanged = False
    End Sub


    Private Sub DisplaySummary()
        MessageBox.Show(FirstNameTextBox.Text & " " & LastNameTextBox.Text &
            " got " & CStr(correctAnswers) & " out of " & totalQuestions &
            " questions correctly.")
        ClearAllFields()
        FirstNameTextBox.Select()
        correctAnswers = 0
        incorrectAnswers = 0
    End Sub
    Private Sub SummaryBtn_Click(sender As Object, e As EventArgs) Handles _
            SummaryButton.Click
        DisplaySummary()
        MathContestLoadAndRestart()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles _
            ExitButton.Click
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

    Private Sub MathContestLoadAndRestart() 'restart is refering to when the _
        'summary button Is pressed, will reset code as if the program relaoded.
        SubmitBtnDisabled()
        SummaryBtnDisabled()
        AddRadioButton.Select() 'could also do AddRBtn.Checked = True
        exitForm = False
        FirstNameTextBox.Select()
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
        'If CInt(AgeTextBox.Text) < 7 And CInt(AgeTextBox.Text) > 11 Then
        '    MessageBox.Show("Please enter an age between 7-11")
        '    AgeTextBox.Select()
        '    AgeTextBox.Clear()
        'ElseIf CInt(GradeTextBox.Text) < 1 And CInt(GradeTextBox.Text) > 4 Then
        '    MessageBox.Show("Please enter a grade between 1st-4th")
        '    GradeTextBox.Clear()
        '    GradeTextBox.Select()
        'ElseIf firstNameTxtBoxChanged = True AndAlso lastNameTxtBoxChanged = True _
        '        AndAlso ageTxtBoxChanged = True AndAlso
        '        gradeTxtBoxChanged = True Then
        '    SubmitBtnEnabled()
        '    SummaryBtnEnabled()
        '    'FirstNumberTxtBox.Text = CStr(randomNumberOne)
        '    'SecondNumberTxtBox.Text = CStr(randNumberTwo)
        '    randomNumbers()
        'Else
        '    MessageBox.Show("Please enter all required information for student")
        'End If
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
        SubmitButton.Enabled = True
    End Sub


    Private Sub SummaryBtnEnabled()
        SummaryButton.Enabled = True
    End Sub

    Private Sub SummaryBtnDisabled()
        SummaryButton.Enabled = False
    End Sub

    Private Sub SubmitBtnDisabled()
        SubmitButton.Enabled = False
    End Sub
End Class

'static numbers for global variables keeping track of incorrect/correct answers, and total questions. allowing the student to press submit when conversions are unsuccess