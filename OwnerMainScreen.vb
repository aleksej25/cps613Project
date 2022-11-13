Public Class OwnerMainScreen
    Public timerStatus As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
    End Sub
    Private Sub MyCarButton_Click(sender As Object, e As EventArgs) Handles MyCarButton.Click
        Me.Hide()
        Form1.ECarControls.Show()
    End Sub

    Private Sub ScheduleButton_Click(sender As Object, e As EventArgs) Handles ScheduleButton.Click

        ' Me.Hide()
        ' Form1.ScheduleControl1.Show()
        Me.Hide()
        Form1.ScheduleControl1.Show()
        Dim day As String
        day = WeekdayName(Weekday(Now))
        If day = "Saturday" Then
            If Len(Form1.CalendarControl1.Label3.Text) > 0 Or Len(Form1.CalendarControl1.Label25.Text) > 0 Or Len(Form1.CalendarControl1.Label32.Text) > 0 Or Len(Form1.CalendarControl1.Label39.Text) > 0 Or Len(Form1.CalendarControl1.Label46.Text) > 0 Or Len(Form1.CalendarControl1.Label53.Text) > 0 Or Len(Form1.CalendarControl1.Label60.Text) > 0 Or Len(Form1.CalendarControl1.Label67.Text) > 0 Or Len(Form1.CalendarControl1.Label74.Text) > 0 Or Len(Form1.CalendarControl1.Label81.Text) > 0 Then

                Form1.ScheduleControl1.Label4.Hide()
                Dim Inte As Integer = Len(Form1.CalendarControl1.Label3.Text)
                Dim Stre As String = CStr(Inte)

            Else
                Form1.ScheduleControl1.Label2.Hide()
            End If

        ElseIf day = "Friday" Then


            If Len(Form1.CalendarControl1.Label18.Text) > 0 Or Len(Form1.CalendarControl1.Label19.Text) > 0 Or Len(Form1.CalendarControl1.Label26.Text) > 0 Or Len(Form1.CalendarControl1.Label33.Text) > 0 Or Len(Form1.CalendarControl1.Label40.Text) > 0 Or Len(Form1.CalendarControl1.Label47.Text) > 0 Or Len(Form1.CalendarControl1.Label54.Text) > 0 Or Len(Form1.CalendarControl1.Label61.Text) > 0 Or Len(Form1.CalendarControl1.Label68.Text) > 0 Or Len(Form1.CalendarControl1.Label75.Text) > 0 Then

                Form1.ScheduleControl1.Label4.Hide()

            End If

        ElseIf day = "Thursday" Then


            If Len(Form1.CalendarControl1.Label7.Text) > 0 Or Len(Form1.CalendarControl1.Label20.Text) > 0 Or Len(Form1.CalendarControl1.Label27.Text) > 0 Or Len(Form1.CalendarControl1.Label34.Text) > 0 Or Len(Form1.CalendarControl1.Label41.Text) > 0 Or Len(Form1.CalendarControl1.Label48.Text) > 0 Or Len(Form1.CalendarControl1.Label55.Text) > 0 Or Len(Form1.CalendarControl1.Label62.Text) > 0 Or Len(Form1.CalendarControl1.Label69.Text) > 0 Or Len(Form1.CalendarControl1.Label76.Text) > 0 Then

                Form1.ScheduleControl1.Label4.Hide()

            End If

        ElseIf day = "Wednesday" Then


            If Len(Form1.CalendarControl1.Label6.Text) > 0 Or Len(Form1.CalendarControl1.Label21.Text) > 0 Or Len(Form1.CalendarControl1.Label28.Text) > 0 Or Len(Form1.CalendarControl1.Label35.Text) > 0 Or Len(Form1.CalendarControl1.Label42.Text) > 0 Or Len(Form1.CalendarControl1.Label49.Text) > 0 Or Len(Form1.CalendarControl1.Label56.Text) > 0 Or Len(Form1.CalendarControl1.Label63.Text) > 0 Or Len(Form1.CalendarControl1.Label70.Text) > 0 Or Len(Form1.CalendarControl1.Label77.Text) > 0 Then

                Form1.ScheduleControl1.Label4.Hide()

            End If


        ElseIf day = "Tuesday" Then


            If Len(Form1.CalendarControl1.Label5.Text) > 0 Or Len(Form1.CalendarControl1.Label22.Text) > 0 Or Len(Form1.CalendarControl1.Label29.Text) > 0 Or Len(Form1.CalendarControl1.Label36.Text) > 0 Or Len(Form1.CalendarControl1.Label43.Text) > 0 Or Len(Form1.CalendarControl1.Label50.Text) > 0 Or Len(Form1.CalendarControl1.Label57.Text) > 0 Or Len(Form1.CalendarControl1.Label64.Text) > 0 Or Len(Form1.CalendarControl1.Label71.Text) > 0 Or Len(Form1.CalendarControl1.Label78.Text) > 0 Then

                Form1.ScheduleControl1.Label4.Hide()

            End If

        ElseIf day = "Monday" Then


            If Len(Form1.CalendarControl1.Label4.Text) > 0 Or Len(Form1.CalendarControl1.Label23.Text) > 0 Or Len(Form1.CalendarControl1.Label30.Text) > 0 Or Len(Form1.CalendarControl1.Label37.Text) > 0 Or Len(Form1.CalendarControl1.Label44.Text) > 0 Or Len(Form1.CalendarControl1.Label51.Text) > 0 Or Len(Form1.CalendarControl1.Label58.Text) > 0 Or Len(Form1.CalendarControl1.Label65.Text) > 0 Or Len(Form1.CalendarControl1.Label72.Text) > 0 Or Len(Form1.CalendarControl1.Label79.Text) > 0 Then

                Form1.ScheduleControl1.Label4.Hide()

            End If

        ElseIf day = "Sunday" Then


            If Len(Form1.CalendarControl1.Label2.Text) > 0 Or Len(Form1.CalendarControl1.Label24.Text) > 0 Or Len(Form1.CalendarControl1.Label31.Text) > 0 Or Len(Form1.CalendarControl1.Label38.Text) > 0 Or Len(Form1.CalendarControl1.Label45.Text) > 0 Or Len(Form1.CalendarControl1.Label52.Text) > 0 Or Len(Form1.CalendarControl1.Label59.Text) > 0 Or Len(Form1.CalendarControl1.Label66.Text) > 0 Or Len(Form1.CalendarControl1.Label73.Text) > 0 Or Len(Form1.CalendarControl1.Label80.Text) > 0 Then

                Form1.ScheduleControl1.Label4.Hide()
            End If

        Else

            Form1.ScheduleControl1.Label2.Hide()

        End If

    End Sub

    Private Sub BookingsButton_Click(sender As Object, e As EventArgs) Handles BookingsButton.Click

    End Sub

    Private Sub RatingsButton_Click(sender As Object, e As EventArgs) Handles RatingsButton.Click
        Me.Hide()
        Form1.RatingsControl1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.timerStatus += 1
        If Me.timerStatus = 45 Then
            Form1.cameraFailureBox.Show()
        ElseIf Me.timerStatus = 450 Then
            Form1.breakInBox.Show()
        ElseIf Me.timerStatus = 860 Then
            Form1.collisionBox.Show()
            Me.Timer1.Stop()
        End If
    End Sub

End Class
