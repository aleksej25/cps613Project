Public Class Booking
    'Booking Class'

    Public Shared RiderName As String
    Public Shared FromLocation As String
    Public Shared ToLocation As String
    Public Shared NumberOfPeople As Integer
    Public Shared AdditionalDestination As String
    Public Shared BookingStatus As Boolean
    Public Shared FromTime As String
    Public Shared ToTime As String
    Public Shared TripModified As Boolean
    Public Shared OldDestination As String
    Public Shared NewDestination As String
    Public Sub New()
        RiderName = "Rider"
        BookingStatus = False
        TripModified = False
    End Sub

    Public Sub Reset()
        FromLocation = ""
        ToLocation = ""
        NumberOfPeople = ""
        AdditionalDestination = ""
        BookingStatus = False
        TripModified = False
        FromTime = ""
        ToTime = ""
    End Sub
End Class
