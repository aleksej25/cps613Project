Public Class InitalScreen
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UserNameBox.Text = "owner" And PasswordBox.Text = "ownerpassword" Then
            Me.Hide()
            Form1.OwnerMainScreen1.Show()
        ElseIf UserNameBox.Text = "rider" And PasswordBox.Text = "riderpassword" Then
            Me.Hide()
            Form1.RiderMainScreen1.Show()
        Else
            Me.InvalidLoginLabel.Show()
        End If
    End Sub
End Class
