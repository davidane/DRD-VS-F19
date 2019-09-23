'Dane Davids
'RCET0265
'Asg3-6
'Shipping Calculator
'

Option Explicit On
Option Strict On

Public Class ShippingCalculator
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim poundsWeight As Double
        Dim ounceWeight As Double
        Dim errorMessage As String = ""
        Const shippingRate = 0.12

        Try
            ounceWeight = CDbl(OuncesTxtBox.Text)
        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter a number with no decimal into the ounces box..." & vbNewLine
            OuncesTxtBox.Clear()
            OuncesTxtBox.Select()
        Catch anyex As Exception
            errorMessage = errorMessage & "Something unexpected happened..."
        End Try
        Try
            poundsWeight = CDbl(PoundsTxtBox.Text)

        Catch ex As InvalidCastException
            errorMessage = errorMessage & "Please enter a number with no decimal into the pounds box..." & vbNewLine
            PoundsTxtBox.Clear()
            PoundsTxtBox.Select()
        Catch anyex As Exception
            errorMessage = errorMessage & "Something unexpected happened..."

        End Try
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Something went wrong")
        Else
            ShippingChargeTxtBox.Text = FormatCurrency(((ounceWeight) + (poundsWeight * 16)) * 0.12)
        End If

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        PinCodeTxtBox.Text = ""
        PoundsTxtBox.Text = ""
        OuncesTxtBox.Text = ""
        ShippingChargeTxtBox.Text = ""
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
