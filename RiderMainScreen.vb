Public Class RiderMainScreen
    'Rider Main Screen'

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.InitalScreen1.Show()
    End Sub

    Public Sub bookCheck()
        If Form1.riderBooking.BookingStatus = True Then
            StatusLabel.Text = "On trip"
            StatusLabel.ForeColor = Color.Green
        End If
    End Sub

    Private Sub BookTripButton_Click(sender As Object, e As EventArgs) Handles BookTripButton.Click
        Me.Hide()
        Form1.BookTripScreen1.Show()
    End Sub
End Class
