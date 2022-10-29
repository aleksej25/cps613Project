Public Class InitalScreen
    Private Sub OwnerButton_Click(sender As Object, e As EventArgs) Handles OwnerButton.Click
        Me.Visible = False
        ' Now load the owners screen
    End Sub

    Private Sub RiderButton_Click(sender As Object, e As EventArgs) Handles RiderButton.Click
        Me.Visible = False
        ' Now load the users screen
    End Sub
End Class
