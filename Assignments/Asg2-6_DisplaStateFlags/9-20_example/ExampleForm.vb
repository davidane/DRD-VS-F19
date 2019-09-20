
'Dane Davids
'RCET0265
'Friday(9 / 20) Example

Option Strict On
Option Explicit On

Public Class ExampleForm

    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click

        Dim i As Integer 'Loop counter: index, column, row counter --- whatever you are looping
        Dim j As Integer 'nested loop counter
        Dim outerLoopMax As Integer = CInt(OuterLoopMaxTxtBox.Text)
        Dim innerLoopMax As Integer = CInt(InnerLoopMaxTxtBox.Text)
        Dim outerLoopMin As Integer = CInt(OuterLoopMinTxtBox.Text)
        Dim innerLoopMin As Integer = CInt(InnerLoopMinTxtBox.Text)




        'from 1 to 100 increments of 1
        'i or loopcounter variable gets assigned by and incremented by the loop structure

        For i = outerLoopMin To outerLoopMax Step 1 'outer loop 

            For j = innerLoopMin To innerLoopMax Step 1 'inner loop

                Console.WriteLine("outer loop(i) = " & Str(i) & " inner loop(j) = " & Str(j))

            Next

        Next

    End Sub


End Class
