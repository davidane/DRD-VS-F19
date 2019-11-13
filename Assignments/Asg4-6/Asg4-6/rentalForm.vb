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
            errorMessage += "Please enter a name containing only letters." & vbNewLine
            nameTextBox.Select()
            nameTextBox.Clear()
        End Try
        If customerName = "" Then
            errorMessage += "Please enter a name containing only letters." & vbNewLine
            nameTextBox.Select()
            nameTextBox.Clear()
        End If
    End Sub
    Private Sub checkAddress(ByRef errorMessage As String, ByVal address As String)
        Try
            address = CStr(addressTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter an address containing # and street name." & vbNewLine
            addressTextBox.Select()
            addressTextBox.Clear()
        End Try
        If CStr(addressTextBox.Text) = "" Then
            errorMessage += "Please enter an address containing # and street name." & vbNewLine
            addressTextBox.Select()
            addressTextBox.Clear()
        End If
    End Sub
    Private Sub checkCity(ByRef errorMessage As String, ByVal city As String)
        Try
            city = CStr(cityTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a city name." & vbNewLine
            cityTextBox.Select()
            cityTextBox.Clear()
        End Try
        If CStr(cityTextBox.Text) = "" Then
            errorMessage += "Please enter a city name." & vbNewLine
            cityTextBox.Select()
            cityTextBox.Clear()
        End If
    End Sub
    Private Sub checkState(ByRef errorMessage As String, ByVal state As String)
        Try
            state = CStr(stateTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a state." & vbNewLine
            stateTextBox.Select()
            stateTextBox.Clear()
        End Try
        If CStr(stateTextBox.Text) = "" Then
            errorMessage += "Please enter a state." & vbNewLine
            stateTextBox.Select()
            stateTextBox.Clear()
        End If
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim errorMessage As String = ""
        Dim customerName As String
        Dim address As String
        Dim city As String
        Dim state As String
        'Dim zipCode as integer do this later... similar to checkState and checkCity
        checkState(errorMessage, state)
        checkCity(errorMessage, city)
        checkAddress(errorMessage, address)
        checkName(errorMessage, customerName)
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Error")
        Else
            'Do Calculations; maybe add an elseif to check other text boxes
        End If
    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextBox.Clear()
        addressTextBox.Clear()
        cityTextBox.Clear()
        stateTextBox.Clear()
        zipCodeTextBox.Clear()
        beginOdometerTextBox.Clear()
        endOdometerTextBox.Clear()
        daysTextBox.Clear()
        milesDrivenLabel.Text = ""
        mileChargeLabel.Text = ""
        dayChargeLabel.Text = ""
        discountLabel.Text = ""
        youOweLabel.Text = ""
    End Sub

    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click

    End Sub
End Class
