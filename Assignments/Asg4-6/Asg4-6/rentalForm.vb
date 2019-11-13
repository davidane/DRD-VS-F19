'Dane Davids
'RCET0265
'Rental Form
'Provide coding for rental company with set discounts and rates per mile/kilometer

Option Strict On
Option Explicit On
Option Compare Binary

Public Class rentalForm
    Private Sub checkName(ByRef errorMessage As String, ByVal customerName As String)
        Try
            customerName = CStr(nameTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a Name containing only letters." & vbNewLine
            MessageBox.Show(errorMessage, "ERROR")
        End Try
    End Sub
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim errorMessage As String = ""
        Dim customerName As String
        checkName(errorMessage, customerName)
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Error")
        Else
            'Do Calculations; maybe add an elseif to check other text boxes
        End If
    End Sub
End Class
