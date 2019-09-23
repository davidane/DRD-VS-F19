'Dane Davids
'RCET0265
'Asg3-3_InventoryCalculator 
'https://github.com/davidane/DRD-VS-F19/tree/master/Assignments/Asg3-3 _
'_InventoryCalculator/ Asg3 - 3_InventoryCalculator

Option Strict On
Option Explicit On

Public Class InventoryCalculatorForm

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles _
            CalculateBtn.Click
        Dim beginningInventory As Decimal
        Dim endingInventory As Decimal
        Dim costOfGoods As Double
        Dim averageInventory As Decimal
        Dim turnOver As Double
        Dim errorMessage As String = ""
        'dims all variables without a value -except for errorMessage- decimal _
        'For accuracy And double for currency conversion.


        Try
            costOfGoods = CDbl(CostofGoodsTxtBox.Text)
        Catch formatEx As System.InvalidCastException
            errorMessage = errorMessage & "Please enter a decimal value into" _
            & " the cost of goods box; example: 1234.56..." & vbNewLine
            CostofGoodsTxtBox.Clear()
            CostofGoodsTxtBox.Select()

        Catch anyex As Exception
            errorMessage = errorMessage & "Something unexpected happened..." _
            & vbNewLine
        End Try 'try and catch looks for invalid casts and any other _
        'exceptions that are unknown; debugging console helped _
        'determine the invalid cast portion of the catch.
        Try
            endingInventory = CDec(EndingInvTxtBox.Text)
        Catch formatEx As System.InvalidCastException
            errorMessage = errorMessage & "Please enter a decimal value into" _
            & " the ending inventory box; example: 1234.56..." & vbNewLine
            EndingInvTxtBox.Clear()
            EndingInvTxtBox.Select()
        Catch anyex As Exception
            errorMessage = errorMessage & "Something unexpected happened..." _
                & vbNewLine
        End Try 'try and catch looks for invalid casts and any other _
        'exceptions that are unknown; debugging console helped determine _
        'the invalid cast portion of the catch.
        Try
            beginningInventory = CDec(BeginningInvTxtBox.Text)
        Catch formatEx As System.InvalidCastException
            errorMessage = errorMessage & "Please enter a decimal value into" _
            & " the beginning inventory box; example: 1234.56..." & vbNewLine
            BeginningInvTxtBox.Clear()
            BeginningInvTxtBox.Select()
        Catch anyex As Exception
            errorMessage = errorMessage & "Something unexpected happened..." _
                & vbNewLine
        End Try 'try and catch looks for invalid casts and any other _
        'exceptions that are unknown; debugging console helped determine _
        'the invalid cast portion of the catch.

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "We have a problem")
        Else
            averageInventory = ((beginningInventory + endingInventory) / 2)
            turnOver = (costOfGoods / averageInventory)
            AverageInvTxtBox.Text = FormatCurrency(CStr(averageInventory))
            TurnoverTxtBox.Text = FormatCurrency(CStr(turnOver))
        End If 'if/then statement determines whether to show the error- _
        'message box Or continue solving the math

    End Sub



    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles _
            ClearBtn.Click
        BeginningInvTxtBox.Text = ""
        EndingInvTxtBox.Text = ""
        CostofGoodsTxtBox.Text = ""
        AverageInvTxtBox.Text = ""
        TurnoverTxtBox.Text = ""
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles _
            ExitBtn.Click
        Me.Close()
    End Sub

End Class
