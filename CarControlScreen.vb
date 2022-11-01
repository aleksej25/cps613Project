Public Class CarControlScreen
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.ECarControls.Show()
    End Sub
End Class
