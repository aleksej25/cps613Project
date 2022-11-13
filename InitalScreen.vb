Public Class InitalScreen
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If Me.UserNameBox.Text = "owner" And Me.PasswordBox.Text = "ownerpassword" Then
            Me.Hide()
            Form1.OwnerMainScreen1.Show()
            Me.UserNameBox.Text = ""
            Me.PasswordBox.Text = ""
            Me.InvalidLoginLabel.Hide()
        ElseIf Me.UserNameBox.Text = "rider" And Me.PasswordBox.Text = "riderpassword" Then
            Me.Hide()
            Form1.RiderMainScreen1.Show()
            Me.UserNameBox.Text = ""
            Me.PasswordBox.Text = ""
            Me.InvalidLoginLabel.Hide()
        Else
            Me.UserNameBox.Text = ""
            Me.PasswordBox.Text = ""
            Me.InvalidLoginLabel.Show()
        End If
    End Sub
End Class
