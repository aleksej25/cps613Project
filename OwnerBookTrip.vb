Public Class OwnerBookTrip
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.OwnerMainScreen1.BringToFront()
        Form1.OwnerMainScreen1.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        StartLabel.Show()
        EndLabel.Show()
        StartBox.Show()
        EndBox.Show()
    End Sub

    Private Sub NowButton_CheckedChanged(sender As Object, e As EventArgs) Handles NowButton.CheckedChanged
        StartLabel.Hide()
        EndLabel.Hide()
        StartBox.Hide()
        EndBox.Hide()
    End Sub

    Private Sub DriveButton_Click(sender As Object, e As EventArgs) Handles DriveButton.Click

    End Sub
End Class
