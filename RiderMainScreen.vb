Public Class RiderMainScreen
    'Rider Main Screen'

    Private Sub BackBox_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.InitalScreen1.Show()
    End Sub

    Public Sub bookCheck()
        If Form1.riderBooking.BookingStatus = True Then
            StatusLabel.Text = "On trip"
            StatusLabel.ForeColor = Color.Green
            CurrentTripButton.Enabled = True
            CurrentTripButton.Show()
            BookTripButton.Enabled = False
        End If
    End Sub

    Public Sub tripStopped()
        StatusLabel.Text = "Not on trip"
        StatusLabel.ForeColor = Color.Red
        CurrentTripButton.Enabled = False
        CurrentTripButton.Hide()
        BookTripButton.Enabled = True
        Form1.riderBooking.Reset()
    End Sub

    Private Sub BookTripButton_Click(sender As Object, e As EventArgs) Handles BookTripButton.Click
        Me.Hide()
        Form1.BookTripScreen1.BringToFront()
        Form1.BookTripScreen1.Show()
    End Sub

    Private Sub RiderLogOutButton_Click(sender As Object, e As EventArgs) Handles RiderLogOutButton.Click
        Me.Hide()
        Form1.InitalScreen1.BringToFront()
        Form1.InitalScreen1.Show()
    End Sub

    Private Sub RiderRatingsButton_Click(sender As Object, e As EventArgs) Handles RiderRatingsButton.Click
        Me.Hide()
        Form1.RiderRatingsControl1.BringToFront()
        Form1.RiderRatingsControl1.Show()
    End Sub

    Private Sub CurrentTripButton_Click(sender As Object, e As EventArgs) Handles CurrentTripButton.Click
        Me.Hide()
        Form1.CurrentTripControl1.BringToFront()
        Form1.CurrentTripControl1.Show()
    End Sub
End Class
