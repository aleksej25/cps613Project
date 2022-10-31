Public Class InitalScreen
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If (UserNameBox.Text = "owner" And PasswordBox.Text = "ownerpassword") Then
            Me.InvalidLoginLabel.Visible = False
            Me.Visible = False
        ElseIf (UserNameBox.Text = "rider" And PasswordBox.Text = "riderpassword") Then
            Me.InvalidLoginLabel.Visible = False
            Me.Visible = False
        Else
            Me.InvalidLoginLabel.Visible = True
        End If

    End Sub
End Class
