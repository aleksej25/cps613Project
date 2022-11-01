Public Class ECarControls
    Private Sub MediaControlBox_Click(sender As Object, e As EventArgs) Handles MediaControlBox.Click
        Me.Hide()
        Form1.MediaControls1.Show()
    End Sub

    Private Sub ClimateControlBox_Click(sender As Object, e As EventArgs) Handles ClimateControlBox.Click
        Me.Hide()
        Form1.ClimateControlScreen1.Show()
    End Sub

    Private Sub MyCarBox_Click(sender As Object, e As EventArgs) Handles MyCarBox.Click
        Me.Hide()
        Form1.CarControlScreen.Show()
    End Sub

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.OwnerMainScreen1.Show()
    End Sub
End Class
