'Dane Davids
'RCET 0265
'Sprint-1 & Sprint-2
'Convert string to integer

Option Explicit On
Option Strict On
Option Compare Binary
Public Class SprintForm
    Private Sub TestValidateAndConvert() Handles Me.Load
        Dim count As Integer = 0
        Dim result As Integer = 0
        Dim pad As Integer = 15
        Dim report As String = ""
        Dim temp As String = ""
        Dim testData = New String(4, 4) {{"5", "2", "17", "8", "42"}, {"6.7", "3.14", "5.4", "5.5", "0.125"}, {"-21", "-32.1", "-4", "-4.5", "-4.4"}, {"", "", "", "", ""}, {"True", "False", "lOOlO", "9O2lO", "dog"}}
        For row = 0 To 4
            For column = 0 To 4
                result = 0
                temp = ValidateAndConvert(testData(row, column), result)
                report &= ("Trying: " & testData(row, column)).PadRight(pad)
                If row < 3 Then
                    If CStr(CInt(testData(row, column))) <> CStr(result) Or temp <> "" Then
                        report &= " TEST FAIL" & vbNewLine
                        report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                        report &= ("Should be: " & CStr(CInt(testData(row, column)))).PadRight(pad) & " : " & "<Empty>" & vbNewLine
                    Else
                        report &= " TEST PASS" & vbNewLine
                        count += 1
                    End If
                ElseIf temp <> "is empty" And row = 3 Then
                    report &= " TEST FAIL" & vbNewLine
                    report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                    report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "is empty" & vbNewLine
                ElseIf temp <> "Must contain a number" And row > 3 Then
                    report &= " TEST FAIL" & vbNewLine
                    report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                    report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "Must contain a number" & vbNewLine
                Else
                    report &= " TEST PASS" & vbNewLine
                    count += 1
                End If
            Next
        Next
        Console.WriteLine(report & "Passed " & CStr(count) & " of 25 tests. Score: " & CStr((count / 25) * 100) & "%")
        MessageBox.Show("Passed " & CStr(count) & " of 25 tests. Score: " & CStr((count / 25) * 100) & "%")
    End Sub

    Private Function ValidateAndConvert(ByRef convertThisString As String,
                                        ByRef toThisInteger As Integer) As String

        'Try and catch attemps to convert a string to integer
        Try
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception

            'If statement is placed to check if string is empty, or else the _
            'output will tell the user to input a number
            If convertThisString = "" Then

                ValidateAndConvert = "is empty"
            Else

                ValidateAndConvert = "Must contain a number"
            End If
            If ValidateAndConvert = "" Then

            End If
        End Try

        Return (ValidateAndConvert)
    End Function

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs)
        'converThisString and toThisInteger are Dimension to meet the _
        'arguments in the sub it Is calling; arguments were placed because _
        'of instructions
        Dim convertThisString As String, toThisInteger As Integer
        ValidateAndConvert(convertThisString, toThisInteger)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles _
            ExitButton.Click
        Me.Close()
    End Sub
End Class
