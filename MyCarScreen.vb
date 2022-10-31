Public Class MyCarScreen
    Private Sub MediaControlBox_Click(sender As Object, e As EventArgs) Handles MediaControlBox.Click

    End Sub

    Private Sub ClimateControlBox_Click(sender As Object, e As EventArgs) Handles ClimateControlBox.Click
        Me.Hide()
        Form1.ClimateControlScreen1.Show()
    End Sub

    Private Sub MyCarBox_Click(sender As Object, e As EventArgs) Handles MyCarBox.Click

    End Sub
End Class
