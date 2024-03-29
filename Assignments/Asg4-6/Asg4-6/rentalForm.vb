﻿'Dane Davids
'RCET0265
'Rental Form
'Provide coding for rental company with set discounts and rates per mile/kilometer

Option Strict On
Option Explicit On
Option Compare Binary

Public Class rentalForm
    Private Sub SummaryTotals(ByVal distanceDriven As Double, ByVal totalCost As Double, ByVal summaryButtonCheck As Boolean)
        Static totalMiles As Double
        Static totalCharges As Double
        Static numberOfCustomers As Integer
        If summaryButtonCheck = True Then
            MessageBox.Show("Total Miles Charged For Today: " & totalMiles & vbNewLine & "Total Charges Today: " & FormatCurrency(totalCharges) & vbNewLine & "Total Customers Today: " & numberOfCustomers)
            totalMiles = 0
            totalCharges = 0
            summaryButtonCheck = False
        Else
            totalMiles += distanceDriven
            totalCharges += totalCost
            numberOfCustomers += 1
        End If
    End Sub

    Private Sub CheckName(ByRef errorMessage As String, ByRef customerName As String)
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
    Private Sub CheckAddress(ByRef errorMessage As String, ByRef address As String)
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
    Private Sub CheckCity(ByRef errorMessage As String, ByRef city As String)
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
    Private Sub CheckState(ByRef errorMessage As String, ByRef state As String)
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
    Private Sub CheckZipCode(ByRef errorMessage As String, ByRef zipCode As Integer)
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
    Private Sub DisplayLabelTextBoxes(ByVal distanceDriven As Double, ByRef mileageCharge As Double)
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
    Private Sub DayChargeDisplay(ByVal days As Integer, ByRef dayCharge As Double)
        dayCharge = 15 * days
        dayChargeLabel.Text = CStr(FormatCurrency(dayCharge))
    End Sub
    Private Sub Discount(ByVal totalCost As Double, ByRef discountAmount As Double)
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
    Private Sub YouOwe(ByVal discountAmount As Double, ByRef amountOwed As Double, ByVal totalCost As Double)
        amountOwed = totalCost - discountAmount
        youOweLabel.Text = CStr(FormatCurrency(amountOwed))
    End Sub
    Private Sub clearLabelsAndTextBoxes()
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
        Dim dayCharge As Double 'amount charged per day of having the vehicle
        Dim totalCost As Double 'cost of renting the vehicle before discount/s applied
        Dim discountAmount As Double
        Dim amountOwed As Double
        Dim currentCustomerInfo As String = ""
        Static summaryButtonCheck As Boolean = False
        'Dim distanceDrivenMilesTotal As Double
        'Dim totalChargesSummary As Double
        'Dim numberOfCustomers As Integer
        CheckDays(errorMessage, days)
        CheckEndOdometer(errorMessage, endOdometer)
        CheckBeginOdometer(errorMessage, beginOdometer)
        CheckZipCode(errorMessage, zipCode)
        CheckState(errorMessage, state)
        CheckCity(errorMessage, city)
        CheckAddress(errorMessage, address)
        CheckName(errorMessage, customerName)
        If beginOdometer > endOdometer Then
            errorMessage = "Beginning odometer reading must be larger than ending odometer reading."
            beginOdometerTextBox.Clear()
            endOdometerTextBox.Clear()
            beginOdometerTextBox.Select()
        End If
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Error")
        Else
            'numberOfCustomers += 1
            distanceDriven = (endOdometer - beginOdometer)
            DisplayLabelTextBoxes(distanceDriven, mileageCharge)
            DayChargeDisplay(days, dayCharge)
            totalCost = mileageCharge + dayCharge
            Discount(totalCost, discountAmount)
            YouOwe(discountAmount, amountOwed, totalCost)
            SummaryTotals(distanceDriven, totalCost, summaryButtonCheck)
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearLabelsAndTextBoxes()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        ''Dim forSureExit As String = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo)
        'Dim message, title, response As String
        'Dim style As Integer
        'message = "Are you sure you want to exit?"
        'style = vbYesNo + vbCritical + vbDefaultButton2
        'title = "Exit"
        'response = MessageBox(message, style, title)
        'Dim Msg, Style, Title, Help, Ctxt, Response, MyString
        'Msg = "Do you want to continue ?"    ' Define message.
        'Style = vbYesNo + vbCritical + vbDefaultButton2    ' Define buttons.
        'Title = "MsgBox Demonstration"    ' Define title.
        'Help = "DEMO.HLP"    ' Define Help file.
        'Ctxt = 1000    ' Define topic context. 
        '' Display message.
        'Response = MsgBox(Msg, Style, Title, Help, Ctxt)
        'If Response = vbYes Then    ' User chose Yes.
        '    MyString = "Yes"    ' Perform some action.
        'Else    ' User chose No.
        '    MyString = "No"    ' Perform some action.
        'End If
        MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo)
        If MessageBox.Equals = "Yes" Then

    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        Static distanceDriven As Double
        Static totalCost As Double
        Static summaryButtonCheck As Boolean
        summaryButtonCheck = True
        SummaryTotals(distanceDriven, totalCost, summaryButtonCheck)
    End Sub
End Class
