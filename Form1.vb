Public Class Form1
    Public Shared CarBooked As Boolean = False
    Public Shared riderAccess As Boolean
    Public Shared riderBooking As New Booking

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub cameraFailureBox_Click(sender As Object, e As EventArgs) Handles cameraFailureBox.Click
        Me.cameraFailureBox.Hide()
        Me.ErrorFixScreenControl1.errorLabel.Text = "Interior Camera Failure"
        Me.ErrorFixScreenControl1.errorLabel.Left = (Me.ErrorFixScreenControl1.errorLabel.Parent.Width \ 2) - (Me.ErrorFixScreenControl1.errorLabel.Width \ 2) - 3

        Me.ErrorFixScreenControl1.errorDescLabel.Text = "Cannot establish" + vbNewLine + "connection to camera."
        Me.ErrorFixScreenControl1.errorDescLabel.Left = (Me.ErrorFixScreenControl1.errorDescLabel.Parent.Width \ 2) - (Me.ErrorFixScreenControl1.errorDescLabel.Width \ 2) - 3
        Me.ErrorFixScreenControl1.fixButton.Show()
        Me.ErrorFixScreenControl1.Show()
    End Sub

    Private Sub breakInBox_Click(sender As Object, e As EventArgs) Handles breakInBox.Click
        Me.breakInBox.Hide()
        Me.ErrorFixScreenControl1.errorLabel.Text = "Possible Break In"
        Me.ErrorFixScreenControl1.errorLabel.Left = (Me.ErrorFixScreenControl1.errorLabel.Parent.Width \ 2) - (Me.ErrorFixScreenControl1.errorLabel.Width \ 2) - 3

        Me.ErrorFixScreenControl1.errorDescLabel.Text = "Senors are detecting" + vbNewLine + "a possible break-in." + vbNewLine + "Unautherized entry."
        Me.ErrorFixScreenControl1.errorDescLabel.Left = (Me.ErrorFixScreenControl1.errorDescLabel.Parent.Width \ 2) - (Me.ErrorFixScreenControl1.errorDescLabel.Width \ 2) - 3


        Me.ErrorFixScreenControl1.fixButton.Hide()
        Me.ErrorFixScreenControl1.notifyPoliceButton.Show()
        Me.ErrorFixScreenControl1.Show()
    End Sub

    Private Sub collisionBox_Click(sender As Object, e As EventArgs) Handles collisionBox.Click
        Me.collisionBox.Hide()
        Me.ErrorFixScreenControl1.errorLabel.Text = "Collision Dectected"
        Me.ErrorFixScreenControl1.errorLabel.Left = (Me.ErrorFixScreenControl1.errorLabel.Parent.Width \ 2) - (Me.ErrorFixScreenControl1.errorLabel.Width \ 2) - 3

        Me.ErrorFixScreenControl1.errorDescLabel.Text = "Senors around the car" + vbNewLine + "are detecting a possible" + vbNewLine + "collision." + vbNewLine + "Back Bumper Damage."
        Me.ErrorFixScreenControl1.errorDescLabel.Left = (Me.ErrorFixScreenControl1.errorDescLabel.Parent.Width \ 2) - (Me.ErrorFixScreenControl1.errorDescLabel.Width \ 2) - 3

        Me.ErrorFixScreenControl1.fixButton.Hide()
        Me.ErrorFixScreenControl1.ignoreButton.Hide()
        Me.ErrorFixScreenControl1.notifyPoliceButton.Show()
        Me.ErrorFixScreenControl1.notifyPoliceButton.Location = New System.Drawing.Point(92, 415)
        Me.ErrorFixScreenControl1.insuranceButton.Show()
        Me.ErrorFixScreenControl1.notifyBothButton.Show()
        Me.ErrorFixScreenControl1.Show()
    End Sub
End Class
