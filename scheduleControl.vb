Imports System.Reflection.Emit

Public Class scheduleControl
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.OwnerMainScreen1.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.CalendarControl1.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click






        'Label3.Text = "Scheduled for a ride" + Day
    End Sub
End Class
