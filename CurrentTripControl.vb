Public Class CurrentTripControl

    Public Sub Book()
        StartDestinationLabel.Text = Form1.riderBooking.FromLocation
        DestinationLabel.Text = Form1.riderBooking.ToLocation

    End Sub
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.RiderMainScreen1.BringToFront()
        Form1.RiderMainScreen1.Show()
    End Sub

    Private Sub CarControlButton_Click(sender As Object, e As EventArgs) Handles CarControlButton.Click
        Form1.ECarControls.carBox.Enabled = False
        Me.Hide()
        Form1.ECarControls.BringToFront()
        Form1.ECarControls.Show()
    End Sub
End Class
