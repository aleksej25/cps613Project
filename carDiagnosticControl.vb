Imports System.Threading

Public Class carDiagnosticControl
    Public ticker As Integer = 0
    Public selectedCamera As String = ""

    Private Sub diagnostic_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.interiorButton.Select()
        Me.selectedCamera = "interior"
    End Sub


    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.CarControlScreen.Show()
    End Sub

    Private Sub gearsBox_Click(sender As Object, e As EventArgs) Handles gearsBox.Click
        Me.ticker = 0
        Me.Timer1.Start()
        Me.gearsBox.Image = My.Resources.ProjectResources.spinningGear
        Me.diagnosticLabel.Text = "Running Diagnostic"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ticker += 1
        If Me.ticker >= 25 Then
            Me.ticker = 0
            Thread.Sleep(1500)
            Me.Timer2.Start()
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.ticker += 1
        Me.gearsBox.Image = My.Resources.ProjectResources.repairsIcon
        Me.diagnosticLabel.Text = "Diagnostic Complete"
        Me.diagnosticLabel.ForeColor = Color.LimeGreen
        Me.diagnosticReport.Text = "Nothing to Report"
        Me.diagnosticReport.ForeColor = Color.LimeGreen
        Me.diagnosticReport.Show()
        If Me.ticker >= 25 Then
            Me.diagnosticReport.Hide()
            Me.diagnosticLabel.Text = "Run Diagnostic"
            Me.diagnosticLabel.ForeColor = Color.White
            Me.Timer2.Stop()
        End If
    End Sub

    Private Sub exteriorButton_CheckedChanged(sender As Object, e As EventArgs) Handles exteriorButton.CheckedChanged
        Form1.CameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.camOutside
    End Sub

    Private Sub interiorButton_CheckedChanged(sender As Object, e As EventArgs) Handles interiorButton.CheckedChanged
        Form1.CameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.camInside
    End Sub

    Private Sub cameraBox_Click(sender As Object, e As EventArgs) Handles cameraBox.Click
        Me.Hide()
        Form1.CameraViewControl1.Show()
    End Sub
End Class
