'Dane Davids
'RCET0265
'Rental Form
'Provide coding for rental company with set discounts and rates per mile/kilometer

Option Strict On
Option Explicit On
Option Compare Binary

Public Class rentalForm
    Private Sub CheckName(ByRef errorMessage As String, ByVal customerName As String)
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
    Private Sub CheckAddress(ByRef errorMessage As String, ByVal address As String)
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
    Private Sub CheckCity(ByRef errorMessage As String, ByVal city As String)
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
    Private Sub CheckState(ByRef errorMessage As String, ByVal state As String)
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
    Private Sub CheckZipCode(ByRef errorMessage As String, ByVal zipCode As Integer)
        Try
            zipCode = CInt(zipCodeTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter numbers for a Zip Code." & vbNewLine
            zipCodeTextBox.Select()
            zipCodeTextBox.Clear()
        End Try
    End Sub
    Private Sub CheckBeginOdometer(ByRef errorMessage As String, ByVal beginOdometer As Double)
        Try
            beginOdometer = CDbl(beginOdometerTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a number value for, can include decimal values." & vbNewLine
            beginOdometerTextBox.Select()
            beginOdometerTextBox.Clear()
        End Try
    End Sub
    Private Sub CheckEndOdometer(ByRef errorMessage As String, ByVal endOdometer As Double)
        Try
            endOdometer = CDbl(endOdometerTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a number value, can include decimal values." & vbNewLine
            endOdometerTextBox.Select()
            endOdometerTextBox.Clear()
        End Try
    End Sub
    Private Sub CheckDays(ByRef errorMessage As String, ByVal days As Integer)
        Try
            days = CInt(daysTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a number of days, first day is counted as 24 hours after taking vehicle. Round up; if you have a vehicle 2 hours into the next day, count the day as a whole." & vbNewLine
            daysTextBox.Select()
            daysTextBox.Clear()
        End Try
    End Sub
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim errorMessage As String = ""
        Dim customerName As String
        Dim address As String
        Dim city As String
        Dim state As String
        Dim zipCode As Integer
        Dim beginOdometer As Double
        Dim endOdometer As Double
        Dim days As Integer
        CheckDays(errorMessage, days)
        CheckEndOdometer(errorMessage, endOdometer)
        CheckBeginOdometer(errorMessage, beginOdometer)
        CheckZipCode(errorMessage, zipCode)
        CheckState(errorMessage, state)
        CheckCity(errorMessage, city)
        CheckAddress(errorMessage, address)
        CheckName(errorMessage, customerName)
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Error")
        Else

        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
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

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click

    End Sub
End Class
