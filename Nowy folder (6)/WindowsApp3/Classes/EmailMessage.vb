Public Class EmailMessage
    Public StateMeassage As String = ""
    Public LastMessage As String = ""
    Public LastScan As String = ""
    Public LastOK As String = ""
    Public LastError As String = ""
    Public SensorType As String = ""
    Public Interval As String = ""
    Public Function GenerateMessage() As String
        Return EmailRes.Head + "New state in " + TimeOfDay + ", " + DateString + "(Central European Standard Time):" +
               EmailRes.premessage + StateMeassage +
               EmailRes.preLastMessge + LastMessage +
               EmailRes.preLastScan + LastScan +
               EmailRes.preLastOK + LastOK +
               EmailRes.preLastError + LastError +
               EmailRes.preSensorType + SensorType +
               EmailRes.preInterval + Interval +
               EmailRes.Ende
    End Function
End Class
