Public Class CurrentTripControl

    Dim countDown As Integer = 0
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

    Private Sub StopTripButton_Click(sender As Object, e As EventArgs) Handles StopTripButton.Click
        Form1.RiderMainScreen1.tripStopped()
        Me.Hide()
        Form1.RiderMainScreen1.BringToFront()
        Form1.RiderMainScreen1.Show()
        Form1.riderBooking.Reset()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        countDown = countDown + 1000

        If countDown = 30000 Then

            Form1.riderBooking.RideEnded = True

            If Form1.riderBooking.RideEnded = True Then
                StopTripButton.Text = "Leave Car"
            Else
                StopTripButton.Text = "Stop Trip"
            End If
            ArrivedLabel.Show()
            ContinueTripButton.Enabled = True
            Timer.Stop()
        End If


    End Sub

    Private Sub TimerReset()
        countDown = 0
        Form1.riderBooking.RideEnded = False
        Timer.Start()
    End Sub
    Private Sub ModifyTripButton_Click(sender As Object, e As EventArgs) Handles ModifyTripButton.Click
        Me.Hide()
        Form1.ModifyTripControl1.BringToFront()
        Form1.ModifyTripControl1.Show()
    End Sub

    Private Sub ContinueTripButton_Click(sender As Object, e As EventArgs) Handles ContinueTripButton.Click
        StartDestinationLabel.Text = Form1.riderBooking.OldDestination
        DestinationLabel.Text = Form1.riderBooking.NewDestination
        ArrivedLabel.Hide()
        ContinueTripButton.Hide()
        ContinueTripButton.Enabled = False
        Form1.CurrentTripControl1.NextDestIndicator.Hide()
        Form1.CurrentTripControl1.ModifiedDestLabel.Hide()
        Me.TimerReset()

    End Sub
End Class
