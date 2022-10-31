Imports System.Linq.Expressions

Public Class ClimateControlScreen
    Public frontOn As Boolean = False
    Public rearOn As Boolean = False
    Public driverSeatOn As Boolean = False
    Public passengerSeatOn As Boolean = False
    Public passengerLeftSeatOn As Boolean = False
    Public passengerRightSeatOn As Boolean = False
    Public Generator As System.Random = New System.Random()
    Public tempValue As Integer
    Private Sub ClimateControlScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tempValue = Generator.Next(16, 28)
        Me.InsideTempLabel.Text = "Cabin Temperature is: " + tempValue.ToString + "C"
        Me.OutsideTempLabel.Text = "Outside Temperature is: " + (tempValue + 3).ToString + "C"
    End Sub
    Private Sub FrontDefrost_Click(sender As Object, e As EventArgs) Handles FrontDefrost.Click
        If Not frontOn Then
            Me.FrontDefrost.Image = My.Resources.ProjectResources.frontDefrostOn
            Me.FrontDefrostLabel.ForeColor = Color.Red
            Me.frontOn = True
        Else
            Me.FrontDefrost.Image = My.Resources.ProjectResources.frontDefrost
            Me.FrontDefrostLabel.ForeColor = Color.White
            Me.frontOn = False
        End If
    End Sub

    Private Sub rearDefrost_Click(sender As Object, e As EventArgs) Handles rearDefrost.Click
        If Not rearOn Then
            Me.rearDefrost.Image = My.Resources.ProjectResources.rearDefrostOn
            Me.RearDefrostLabel.ForeColor = Color.Red
            Me.rearOn = True
        Else
            Me.rearDefrost.Image = My.Resources.ProjectResources.rearDefrost
            Me.RearDefrostLabel.ForeColor = Color.White
            Me.rearOn = False
        End If
    End Sub

    Private Sub TemperatureSlider_Scroll(sender As Object, e As EventArgs) Handles TemperatureSlider.Scroll
        Me.SettingClimateLabel.Text = "Setting the temperature to: " + TemperatureSlider.Value.ToString() + "C"
        If TemperatureSlider.Value.ToString() < Me.tempValue Then
            Me.SettingClimateLabel.ForeColor = Color.Blue
        Else
            Me.SettingClimateLabel.ForeColor = Color.Red
        End If
        Me.SettingClimateLabel.Left = (Me.SettingClimateLabel.Parent.Width \ 2) - (Me.SettingClimateLabel.Width \ 2)

        Me.SettingClimateLabel.Show()
    End Sub

    Private Sub DriverSeat_Click(sender As Object, e As EventArgs) Handles DriverSeat.Click, PassengerSeat.Click, BackLeftPass.Click, BackRightPass.Click
        Select Case sender.Name
            Case "DriverSeat"
                If Not Me.driverSeatOn Then
                    Me.DriverSeat.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.driverSeatOn = True
                    Me.DriverLabel.ForeColor = Color.Red
                Else
                    Me.DriverSeat.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.driverSeatOn = False
                    Me.DriverLabel.ForeColor = Color.White
                End If
            Case "PassengerSeat"
                If Not Me.passengerSeatOn Then
                    Me.PassengerSeat.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.passengerSeatOn = True
                    Me.PassFRLabel.ForeColor = Color.Red
                Else
                    Me.PassengerSeat.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.passengerSeatOn = False
                    Me.PassFRLabel.ForeColor = Color.White
                End If
            Case "BackLeftPass"
                If Not Me.passengerLeftSeatOn Then
                    Me.BackLeftPass.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.passengerLeftSeatOn = True
                    Me.PassBLLabel.ForeColor = Color.Red
                Else
                    Me.BackLeftPass.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.passengerLeftSeatOn = False
                    Me.PassBLLabel.ForeColor = Color.White
                End If
            Case "BackRightPass"
                If Not Me.passengerRightSeatOn Then
                    Me.BackRightPass.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.passengerRightSeatOn = True
                    Me.PassBRLabel.ForeColor = Color.Red
                Else
                    Me.BackRightPass.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.passengerRightSeatOn = False
                    Me.PassBRLabel.ForeColor = Color.White
                End If
        End Select

    End Sub
End Class
