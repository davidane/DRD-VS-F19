'Dane Davids
'RCET 0265
'Sprint-1 & Sprint-2
'Convert string to integer

Option Explicit On
Option Strict On
Option Compare Binary
Public Class SprintForm
    Private Function IsWayTooLong(ByVal numberFromZeroToFifteen As Integer) As String
        If numberFromZeroToFifteen = 0 Then
            Return "Your number is: Zero"
        End If
        If numberFromZeroToFifteen = 1 Then
            Return "Your number is: One"
        End If
        If numberFromZeroToFifteen = 2 Then
            Return "Your number is: Two"
        End If
        If numberFromZeroToFifteen = 3 Then
            Return "Your number is: Three"
        End If
        If numberFromZeroToFifteen = 4 Then
            Return "Your number is: Four"
        End If
        If numberFromZeroToFifteen = 5 Then
            Return "Your number is: Five"
        End If
        If numberFromZeroToFifteen = 6 Then
            Return "Your number is: Six"
        End If
        If numberFromZeroToFifteen = 7 Then
            Return "Your number is: Seven"
        End If
        If numberFromZeroToFifteen = 8 Then
            Return "Your number is: Eight"
        End If
        If numberFromZeroToFifteen = 9 Then
            Return "Your number is: Nine"
        End If
        If numberFromZeroToFifteen = 10 Then
            Return "Your number is: Ten"
        End If
        If numberFromZeroToFifteen = 11 Then
            Return "Your number is: Eleven"
        End If
        If numberFromZeroToFifteen = 12 Then
            Return "Your number is: Twelve"
        End If
        If numberFromZeroToFifteen = 13 Then
            Return "Your number is: Thirteen"
        End If
        If numberFromZeroToFifteen = 14 Then
            Return "Your number is: Fourteen"
        End If
        If numberFromZeroToFifteen = 15 Then
            Return "Your number is: Fifteen"
        End If
        If numberFromZeroToFifteen < 0 Then

            Return "Your number is: Too Low"
        End If
        If numberFromZeroToFifteen > 15 Then
            Return "Your number is: Too High"
        End If
    End Function
    'This is the working code from Sprints 1 and 2
    Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String
        Dim message As String = ""
        Try
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception
            message = "Must contain a number"
            If convertThisString = "" Then message = "is empty"
        End Try
        Return message
    End Function
    'Do Not change this code other that comment/uncomment the lines indicated
    Private Sub GetUserInput() Handles Me.Load
        Me.Hide()
        Dim tempNum As Integer = 0
        Dim userMessage As String = "Please Enter A Number Between 0 and 15" _
& vbNewLine & "Type Q to Quit"
        Do
            userMessage = InputBox(userMessage, "Hello", "")
            If userMessage <> "Q" And userMessage <> "" Then
                userMessage = ValidateAndConvert(userMessage, tempNum)
                'If userMessage = "" Then userMessage = IsWayTooLong(tempNum) 'Replace this Line
                If userMessage = "" Then userMessage = ShortAndSweet(tempNum) 'With this one
            End If
        Loop Until userMessage = "Q" Or userMessage = ""
        Me.Close()
    End Sub
    'In as few lines as possible produce the same results as the function IsWayTooLong()
    'Hint use a loop and a List or Array
    'Also only have one return statement at the end
    Private Function ShortAndSweet(ByVal numberFromZeroToFifteen As Integer) As String
        'Your code here      
        If numberFromZeroToFifteen = 1 Then, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            Return "Your number is: " & numberFromZeroToFifteen
        ElseIf numberFromZeroToFifteen < 0 Then
            Return "Your number is: Too Low"
        End If
    End Function


    'Lines below are code that was written by me. Function works similarly to _
    'the one given by Tim In sprint 3, but because Of the dimmed message; I _
    'believe his will work more efficiently than mine, As well As being _
    'easier To determine what Is happening.

    'Private Sub TestValidateAndConvert() Handles Me.Load
    '    Dim count As Integer = 0
    '    Dim result As Integer = 0
    '    Dim pad As Integer = 15
    '    Dim report As String = ""
    '    Dim temp As String = ""
    '    Dim testData = New String(4, 4) {{"5", "2", "17", "8", "42"}, {"6.7", "3.14", "5.4", "5.5", "0.125"}, {"-21", "-32.1", "-4", "-4.5", "-4.4"}, {"", "", "", "", ""}, {"True", "False", "lOOlO", "9O2lO", "dog"}}
    '    For row = 0 To 4
    '        For column = 0 To 4
    '            result = 0
    '            temp = ValidateAndConvert(testData(row, column), result)
    '            report &= ("Trying: " & testData(row, column)).PadRight(pad)
    '            If row < 3 Then
    '                If CStr(CInt(testData(row, column))) <> CStr(result) Or temp <> "" Then
    '                    report &= " TEST FAIL" & vbNewLine
    '                    report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
    '                    report &= ("Should be: " & CStr(CInt(testData(row, column)))).PadRight(pad) & " : " & "<Empty>" & vbNewLine
    '                Else
    '                    report &= " TEST PASS" & vbNewLine
    '                    count += 1
    '                End If
    '            ElseIf temp <> "is empty" And row = 3 Then
    '                report &= " TEST FAIL" & vbNewLine
    '                report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
    '                report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "is empty" & vbNewLine
    '            ElseIf temp <> "Must contain a number" And row > 3 Then
    '                report &= " TEST FAIL" & vbNewLine
    '                report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
    '                report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "Must contain a number" & vbNewLine
    '            Else
    '                report &= " TEST PASS" & vbNewLine
    '                count += 1
    '            End If
    '        Next
    '    Next
    '    Console.WriteLine(report & "Passed " & CStr(count) & " of 25 tests. Score: " & CStr((count / 25) * 100) & "%")
    '    MessageBox.Show("Passed " & CStr(count) & " of 25 tests. Score: " & CStr((count / 25) * 100) & "%")
    'End Sub

    'Private Function ValidateAndConvert(ByRef convertThisString As String,
    '                                    ByRef toThisInteger As Integer) As String

    '    'Try and catch attemps to convert a string to integer
    '    Try
    '        toThisInteger = CInt(convertThisString)
    '    Catch ex As Exception

    '        'If statement is placed to check if string is empty, or else the _
    '        'output will tell the user to input a number
    '        If convertThisString = "" Then

    '            ValidateAndConvert = "is empty"
    '        Else

    '            ValidateAndConvert = "Must contain a number"
    '        End If
    '        If ValidateAndConvert = "" Then

    '        End If
    '    End Try

    '    Return (ValidateAndConvert)
    'End Function

    'Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
    '        ExitButton.Click
    '    Me.Close()
    'End Sub
End Class
