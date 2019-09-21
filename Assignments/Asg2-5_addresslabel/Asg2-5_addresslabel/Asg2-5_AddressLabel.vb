'Dane Davids
'RCET 0265
'Asg2-5
'Address Label Display Program
'https://github.com/davidane/DRD-VS-F19/tree/master/Assignments

Option Explicit On
Option Strict On

Public Class AddressLabelForm
    Private Sub DisplayBtn_Click(sender As Object, e As EventArgs) Handles _
            DisplayBtn.Click

        AddressLbl.Text = FirstNameTxtBox.Text & " " & LastNameTxtBox.Text &
        vbCrLf & StreetAddressTxtBox.Text & vbCrLf & CityTxtBox.Text &
        ", " & StateTxtBox.Text & "  " & ZipTxtBox.Text
        'concatenates all inputs into one string; new lines are added

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles _
            ClearBtn.Click

        AddressLbl.Text = ""
        FirstNameTxtBox.Text = ""
        LastNameTxtBox.Text = ""
        StreetAddressTxtBox.Text = ""
        CityTxtBox.Text = ""
        StateTxtBox.Text = ""
        ZipTxtBox.Text = ""
        'Clears label and each user input, ready for new label

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles _
            ExitBtn.Click

        Me.Close()
        'closes Program

    End Sub
End Class
