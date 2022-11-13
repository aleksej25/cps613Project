Public Class Booking

    Public Shared RiderName As String
    Public Shared FromLocation As String
    Public Shared ToLocation As String
    Public Shared NumberOfPeople As Integer
    Public Shared AdditionalDestination As String
    Public Shared BookingStatus As Boolean
    Public Shared FromTime As String
    Public Shared ToTime As String

    Public Sub New()
        RiderName = "Rider"
        BookingStatus = False
    End Sub

    Public Sub Reset()
        FromLocation = ""
        ToLocation = ""
        NumberOfPeople = ""
        AdditionalDestination = ""
        BookingStatus = False
        FromTime = ""
        ToTime = ""
    End Sub
End Class
