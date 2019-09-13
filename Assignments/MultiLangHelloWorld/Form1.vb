'Assignment: Asg1:1
'RCET0265
'Dane Davids
'Hello World Program

Option Explicit On
Public Class MultiLangHelloWorldForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EnglishHelloWorldButton.Click
        Call HelloWorld() 'Calls English Hello World to display in text box by click of button
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles EspanolHelloWorldButton.Click
        Call HelloWorldSpanish() 'Calls Spanish Hello World to display in text box by click of button
    End Sub

    Private Sub FrenchHelloWorldButton_Click(sender As Object, e As EventArgs) Handles FrenchHelloWorldButton.Click
        Call HelloWorldFrench() 'Calls French Hello World to display in text box by click of button
    End Sub

    Private Sub ExitFormButton_Click(sender As Object, e As EventArgs) Handles ExitFormButton.Click
        Call exitform() 'Calls exit/close sub by click of button
    End Sub
    Public Sub HelloWorld()
        Dim EngHello As String 'sets variable as string

        EngHello = "Hello World" 'gives a value to string
        HelloWorldTextBox.Text = EngHello 'makes tect box equal to string value

    End Sub

    Public Sub HelloWorldSpanish()
        Dim EspanHello As String 'sets variable as string

        EspanHello = "Hola Mundo" 'gives a value to string
        HelloWorldTextBox.Text = EspanHello 'makes tect box equal to string value
    End Sub

    Public Sub HelloWorldFrench()
        Dim FrenHello As String 'sets variable as string
        FrenHello = "Bonjour tout le monde" 'gives a value to string
        HelloWorldTextBox.Text = FrenHello 'makes tect box equal to string value
    End Sub

    Public Sub exitform()
        Close() 'closes form
    End Sub

End Class


