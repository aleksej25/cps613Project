Public Class CarControlScreen
    Public trunkOpen As Boolean = False
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.ECarControls.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles trunkBox.Click
        If Not Me.trunkOpen Then
            Me.trunkOpen = True
            Me.trunkBox.Image = My.Resources.ProjectResources.closeTrunk
            Me.trunkOCLabel.Text = "Trunk Open"
        Else
            Me.trunkOpen = False
            Me.trunkBox.Image = My.Resources.ProjectResources.openTrunk
            Me.trunkOCLabel.Text = "Trunk Closed"
        End If
    End Sub
End Class
