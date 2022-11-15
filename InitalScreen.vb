Public Class InitalScreen
    'Initial Screen'
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles riderButton.Click
        Me.Hide()
        Form1.RiderMainScreen1.Show()
        Form1.riderAccess = True
    End Sub

    Private Sub ownerButton_Click(sender As Object, e As EventArgs) Handles ownerButton.Click
        Me.Hide()
        Form1.OwnerMainScreen1.Show()
        Form1.riderAccess = False
        'Form1.OwnerMainScreen1.timerStatus = 0
        Form1.OwnerMainScreen1.Timer1.Start()
    End Sub

End Class
