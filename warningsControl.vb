Imports System.Threading

Public Class warningsControl
    Public timerTick As Integer = 0
    Private Sub ignoreButton_Click(sender As Object, e As EventArgs) Handles ignoreButton.Click
        Me.Hide()
    End Sub

    Private Sub fixButton_Click(sender As Object, e As EventArgs) Handles fixButton.Click
        Me.repairingBox.Show()
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.timerTick += 1
        If Me.timerTick >= 65 Then
            Me.errorDescLabel.Text = "Fixed!"
            Me.errorDescLabel.Font = New Font("Sitka Text", 16, FontStyle.Bold)
            Me.errorDescLabel.ForeColor = Color.LimeGreen
            Me.errorDescLabel.Left = (Me.errorLabel.Parent.Width \ 2) - (Me.errorLabel.Width \ 2) - 3
            Me.repairingBox.Hide()
            Me.timerTick = 0
            Me.Timer2.Start()
            Me.Timer1.Stop()
        End If
    End Sub

    Private Sub notifyPoliceButton_Click(sender As Object, e As EventArgs) Handles notifyPoliceButton.Click
        Me.errorDescLabel.Text = "Police Have" + vbNewLine + "Been Notified!"
        Me.errorDescLabel.Font = New Font("Sitka Text", 16, FontStyle.Bold)
        Me.errorDescLabel.ForeColor = Color.Red
        Me.errorDescLabel.Left = (Me.errorLabel.Parent.Width \ 2) - (Me.errorLabel.Width \ 2) - 3
        Me.timerTick = 0
        Me.Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.timerTick += 1
        If Me.timerTick = 40 Then
            Me.errorDescLabel.ForeColor = Color.White
            Me.Hide()
            Me.Timer2.Stop()
        End If
    End Sub

    Private Sub insuranceButton_Click(sender As Object, e As EventArgs) Handles insuranceButton.Click
        Me.errorDescLabel.Text = "Insurance Has Been" + vbNewLine + "Been Notified!"
        Me.errorDescLabel.Font = New Font("Sitka Text", 16, FontStyle.Bold)
        Me.errorDescLabel.ForeColor = Color.Red
        Me.errorDescLabel.Left = (Me.errorLabel.Parent.Width \ 2) - (Me.errorLabel.Width \ 2) - 3
        Me.timerTick = 0
        Me.Timer2.Start()
    End Sub
End Class
