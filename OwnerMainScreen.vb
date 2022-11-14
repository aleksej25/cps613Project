Public Class OwnerMainScreen
    Public timerStatus As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
    End Sub
    Private Sub MyCarButton_Click(sender As Object, e As EventArgs) Handles MyCarButton.Click
        Me.Hide()
        Form1.ECarControls.Show()
    End Sub

    Private Sub ScheduleButton_Click(sender As Object, e As EventArgs) Handles ScheduleButton.Click
        Me.Hide()
        Form1.CalendarControl1.Show()
    End Sub

    Private Sub BookingsButton_Click(sender As Object, e As EventArgs) Handles BookingsButton.Click

    End Sub

    Private Sub RatingsButton_Click(sender As Object, e As EventArgs) Handles RatingsButton.Click
        Me.Hide()
        Form1.RatingsControl1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.timerStatus += 1
        If Me.timerStatus = 45 Then
            Form1.cameraFailureBox.Show()
        ElseIf Me.timerStatus = 450 Then
            Form1.breakInBox.Show()
        ElseIf Me.timerStatus = 860 Then
            Form1.collisionBox.Show()
            Me.Timer1.Stop()
        End If
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Me.Timer1.Stop()
        Me.Hide()
        Form1.InitalScreen1.Show()
    End Sub
End Class
