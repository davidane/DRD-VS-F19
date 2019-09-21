'Dane Davids
'Asg2-6_DisplaStateFlags
'RCET 0265
'

Option Explicit On
Option Strict On

Public Class DisplayStateFlags

    Private Sub IdahoStateFlagBtn_Click(sender As Object, e As EventArgs) _
            Handles IdahoStateFlagBtn.Click
        StateFlagDisplayPicBox.Image = My.Resources.flagofIdahostateflag
        'My.Resources.duckduckgo_wallpaper_1200_red
    End Sub

    Private Sub AlaskaStateFlagBtn_Click(sender As Object, e As EventArgs) _
            Handles AlaskaStateFlagBtn.Click
        StateFlagDisplayPicBox.Image = My.Resources.alaska_state_flag_2_x_3_14
    End Sub

    Private Sub HawaiiStateFlagBtn_Click(sender As Object, e As EventArgs) _
            Handles HawaiiStateFlagBtn.Click
        StateFlagDisplayPicBox.Image = My.Resources.hawaii_State_Flag
    End Sub

    Private Sub FloridaStateFlagBtn_Click(sender As Object, e As EventArgs) _
            Handles FloridaStateFlagBtn.Click
        StateFlagDisplayPicBox.Image = My.Resources.correctformat_floridastateflag
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles _
            ExitBtn.Click
        Me.Close()
    End Sub

End Class
