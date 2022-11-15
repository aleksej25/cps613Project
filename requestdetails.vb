Public Class requestdetails
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub requestdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tripdetails.Text = "Name: " + Booking.RiderName + vbCrLf + "From: " + Booking.FromLocation + vbCrLf + "To: " + Booking.ToLocation + vbCrLf + "Number of people: " + Booking.NumberOfPeople.ToString() + vbCrLf + "Start time: " + Booking.FromTime + vbCrLf + "End time: " + Booking.ToTime
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tripdetails.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.Hide()

    End Sub

    Private Sub Goback_Click(sender As Object, e As EventArgs) Handles Goback.Click
        Me.Hide()
    End Sub
End Class
