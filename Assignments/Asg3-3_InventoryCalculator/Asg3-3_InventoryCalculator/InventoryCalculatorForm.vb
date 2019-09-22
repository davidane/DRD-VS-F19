'Dane Davids
'RCET0265
'Asg3-3_InventoryCalculator 
'

Option Strict On
Option Explicit On

Public Class InventoryCalculatorForm
    'Dim beginningInventory As Decimal
    'Dim endingInventory As Decimal
    'Dim costOfGoods As Double
    Dim averageInventory As Decimal
    Dim turnOver As Double

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        averageInventory = ((CDec(BeginningInvTxtBox.Text) + CDec(EndingInvTxtBox.Text)) / 2)
        turnOver = (CDec(CostofGoodsTxtBox.Text) / averageInventory)
        AverageInvTxtBox.Text = CStr(averageInventory)
        TurnoverTxtBox.Text = CStr(turnOver)

    End Sub
End Class
