﻿'Dane Davids
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
    Private Sub CheckBeginOdometer(ByRef errorMessage As String, ByRef beginOdometer As Double)
        Try
            beginOdometer = CDbl(beginOdometerTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a number value for, can include decimal values." & vbNewLine
            beginOdometerTextBox.Select()
            beginOdometerTextBox.Clear()
        End Try
    End Sub
    Private Sub CheckEndOdometer(ByRef errorMessage As String, ByRef endOdometer As Double)
        Try
            endOdometer = CDbl(endOdometerTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a number value, can include decimal values." & vbNewLine
            endOdometerTextBox.Select()
            endOdometerTextBox.Clear()
        End Try
    End Sub
    Private Sub CheckDays(ByRef errorMessage As String, ByRef days As Integer)
        Try
            days = CInt(daysTextBox.Text)
        Catch ex As Exception
            errorMessage += "Please enter a number of days, first day is counted as 24 hours after taking vehicle. Round up; if you have a vehicle 2 hours into the next day, count the day as a whole." & vbNewLine
            daysTextBox.Select()
            daysTextBox.Clear()
        End Try
        If days < 1 Or days > 45 Then
            errorMessage += "Number of days must be greater than 0 and less than 45." & vbNewLine
            daysTextBox.Select()
            daysTextBox.Clear()
        End If
    End Sub
    Private Sub displayLabelTextBoxes(ByVal distanceDriven As Double, ByRef mileageCharge As Double)
        Dim tenCentsMiles As Double
        Dim twelveCentsMiles As Double
        Dim freeMiles As Double = 200
        'Dim milesForMathSimplification As Double
        'Dim caseMileage As Integer
        'caseMileage = CInt(distanceDriven)
        'Select Case distanceDriven
        '    Case
        'End Select

        If milesRadioButton.Checked = True Then
            distanceDriven = distanceDriven
        Else
            distanceDriven = 0.62 * distanceDriven
        End If
        milesDrivenLabel.Text = CStr(distanceDriven)
        If distanceDriven < 201 Then
            mileageCharge = 0
        ElseIf distanceDriven > 200 And distanceDriven < 501 Then
            twelveCentsMiles = (distanceDriven - freeMiles)
            mileageCharge = (0.12 * twelveCentsMiles)
        ElseIf distanceDriven > 500 Then
            twelveCentsMiles = 300
            tenCentsMiles = distanceDriven - twelveCentsMiles - freeMiles
            mileageCharge = ((0.1 * tenCentsMiles) + (0.12 * twelveCentsMiles))
        End If
        mileChargeLabel.Text = CStr(FormatCurrency(mileageCharge))
    End Sub
    Private Sub dayChargeDisplay(ByVal days As Integer, ByRef dayCharge As Double)
        dayCharge = 15 * days
        dayChargeLabel.Text = CStr(FormatCurrency(dayCharge))
    End Sub
    Private Sub discount(ByVal totalCost As Double, ByRef discountAmount As Double)
        If aaaCheckBox.Checked = True And seniorCheckBox.Checked = True Then
            discountAmount = 0.08 * totalCost
        ElseIf seniorCheckBox.Checked = True Then
            discountAmount = 0.03 * totalCost
        ElseIf aaaCheckBox.Checked = True Then
            discountAmount = 0.05 * totalCost
        Else
            discountAmount = 0
        End If
        discountLabel.Text = CStr(FormatCurrency(discountAmount))
    End Sub
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim errorMessage As String = ""
        Dim customerName As String 'no limits put on this other than something must be entered into the textbox
        Dim address As String 'no limits put on this other than something must be entered into the textbox
        Dim city As String 'city name, no limits put on this other than something must be entered into the textbox
        Dim state As String 'state name, would be interesting to add a dropdown list box of all 50 states. No limits put on this other than something must be entered into the textbox
        Dim zipCode As Integer 'zipcode, no max or min length is set
        Dim beginOdometer As Double 'begin odometer reading
        Dim endOdometer As Double 'end odometer reading
        Dim days As Integer 'number of days driven, must be a whole number from 1 to 45
        Dim distanceDriven As Double 'distance driven; value will be changed to miles when calculate, but not changed in textbox
        Dim mileageCharge As Double 'cost of total distance driven
        'Dim chargedMiles As Double 'amount of miles being charged for
        Dim dayCharge As Double 'amount charged per day of having the vehicle
        Dim totalCost As Double 'cost of renting the vehicle before discount/s applied
        Dim discountAmount As Double
        Dim amountOwed As Double
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
            distanceDriven = (endOdometer - beginOdometer)
            displayLabelTextBoxes(distanceDriven, mileageCharge)
            dayChargeDisplay(days, dayCharge)
            totalCost = mileageCharge + dayCharge
            discount(totalCost, discountAmount)
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
        MessageBox.Show(milesRadioButton.Checked.ToString)
    End Sub

    Private Sub rentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
