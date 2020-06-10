Public Class snmpBrowser
    Public IP As IPaddress = New IPaddress(0, 0, 0, 0)
    Public PORT As String = ""
    Public STATUS As String = ""
    Public LOGIN As String = ""
    Public PASS As String = ""
    Public Session As String = ""
    Public FILE As ExportDataFileforMB = New ExportDataFileforMB
    Public Function LoginFunc() As Boolean
        Return Logining()
    End Function
    Public Function Logining() As Boolean
        STATUS = "CHECKING_LOGIN"
        Dim buf As SnmpInfoCard = getSnmpInfoCard()
        If buf IsNot Nothing Then
            If buf.deviceModel IsNot Nothing Then
                If buf.deviceModel.Length > 2 Then
                    STATUS = "LOGIN_TRUE"
                    Return True
                End If
            End If
        End If
        STATUS = "LOGIN_FALSE"
        Return False
    End Function
    Public Function ResetFunction() As Boolean

        Return False
    End Function
    Public Function Converter(input As String(,))
        If input Is Nothing Then
            Return Nothing
        End If
        Dim result As String(,) = input
        Dim SensorCount As Integer = 0
        Dim calcVal As Integer = 1
        For i As Integer = 0 To (result.Length / 2) - 1
            If result(i, 0) Is Nothing Then
                Continue For
            Else
            End If
            If result(i, 0).Last = "1" Then
                calcVal = 1
            End If
            'MSGREGISTER
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.18.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            'AUX2 SENSOR
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.2.") >= 0 Then
                result(i, 0) = "Type"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.3.") >= 0 Then
                result(i, 0) = "Description"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.4.") >= 0 Then
                result(i, 0) = "Connector"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.5.") >= 0 Then
                result(i, 0) = "GroupNb"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.6.") >= 0 Then
                result(i, 0) = "Group"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.7.") >= 0 Then
                result(i, 0) = "Value"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.8.") >= 0 Then
                result(i, 0) = "Unit"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.9.") >= 0 Then
                result(i, 0) = "UnitName"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.10.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.11.") >= 0 Then
                result(i, 0) = "MinTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.12.") >= 0 Then
                result(i, 0) = "MaxTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.13.") >= 0 Then
                result(i, 0) = "MinWarnTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.17.1.1.14.") >= 0 Then
                result(i, 0) = "MaxWarnTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If

            'TACK SENSOR
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.2.") >= 0 Then
                result(i, 0) = "Type"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.3.") >= 0 Then
                result(i, 0) = "Description"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.4.") >= 0 Then
                result(i, 0) = "Connector"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.5.") >= 0 Then
                result(i, 0) = "GroupNb"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.6.") >= 0 Then
                result(i, 0) = "Group"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.7.") >= 0 Then
                result(i, 0) = "Value"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.8.") >= 0 Then
                result(i, 0) = "Unit"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.9.") >= 0 Then
                result(i, 0) = "UnitName"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.10.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.11.") >= 0 Then
                result(i, 0) = "MinTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.12.") >= 0 Then
                result(i, 0) = "MaxTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.13.") >= 0 Then
                result(i, 0) = "MinWarnTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.15.1.1.14.") >= 0 Then
                result(i, 0) = "MaxWarnTreshold"
                SensorCount = SensorCount + 1
                Continue For
            End If

            'SMOKE DETECTOR
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.14.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.14.1.1.2.") >= 0 Then
                result(i, 0) = "Description"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.14.1.1.3.") >= 0 Then
                result(i, 0) = "GroupNb"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.14.1.1.4.") >= 0 Then
                result(i, 0) = "Value"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.14.1.1.5.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            'REMOTE RELAY
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.13.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.13.1.1.2.") >= 0 Then
                result(i, 0) = "Description"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.13.1.1.3.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            'REMOTE INPUT
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.2.") >= 0 Then
                result(i, 0) = "Type"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.3.") >= 0 Then
                result(i, 0) = "Description"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.4.") >= 0 Then
                result(i, 0) = "Connector"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.5.") >= 0 Then
                result(i, 0) = "GroupNb"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.6.") >= 0 Then
                result(i, 0) = "Group"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.7.") >= 0 Then
                result(i, 0) = "Value"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.8.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.12.1.1.9.") >= 0 Then
                result(i, 0) = "NormalValue"
                SensorCount = SensorCount + 1
                Continue For
            End If
            'PWR SUPPLY
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.9.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.9.1.1.2.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            'OUTPUT RELAY
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.8.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.8.1.1.2.") >= 0 Then
                result(i, 0) = "Description"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.8.1.1.3.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            'DIGITAL INPUTS
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.2.") >= 0 Then
                result(i, 0) = "Type"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.3.") >= 0 Then
                result(i, 0) = "Description"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.4.") >= 0 Then
                result(i, 0) = "Connector"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.5.") >= 0 Then
                result(i, 0) = "GroupNb"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.6.") >= 0 Then
                result(i, 0) = "Group"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.7.") >= 0 Then
                result(i, 0) = "Value"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.8.") >= 0 Then
                result(i, 0) = "Status"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.6.1.1.9.") >= 0 Then
                result(i, 0) = "NormalValue"
                SensorCount = SensorCount + 1
                Continue For
            End If
            'EXT SENSOR
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                SensorCount = SensorCount + 1
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.2.") >= 0 Then
                result(i, 0) = "Type"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.3.") >= 0 Then
                result(i, 0) = "Description"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.4.") >= 0 Then
                result(i, 0) = "Connector"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.5.") >= 0 Then
                result(i, 0) = "GroupNb"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.6.") >= 0 Then
                result(i, 0) = "Group"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.7.") >= 0 Then
                result(i, 0) = "Value"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.8.") >= 0 Then
                result(i, 0) = "Unit"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.9.") >= 0 Then
                result(i, 0) = "UnitName"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.10.") >= 0 Then
                result(i, 0) = "Status"

                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.11.") >= 0 Then
                result(i, 0) = "MinTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.12.") >= 0 Then
                result(i, 0) = "MaxTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.13.") >= 0 Then
                result(i, 0) = "MinWarnTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.5.1.1.14.") >= 0 Then
                result(i, 0) = "MaxWarnTreshold"
                Continue For
            End If
            'AUX SENSOR
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.2.") >= 0 Then
                result(i, 0) = "Type"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.3.") >= 0 Then
                result(i, 0) = "Description"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.4.") >= 0 Then
                result(i, 0) = "Connector"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.5.") >= 0 Then
                result(i, 0) = "GroupNb"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.6.") >= 0 Then
                result(i, 0) = "Group"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.7.") >= 0 Then
                result(i, 0) = "Value"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.8.") >= 0 Then
                result(i, 0) = "Unit"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.9.") >= 0 Then
                result(i, 0) = "UnitName"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.10.") >= 0 Then
                result(i, 0) = "Status"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.11.") >= 0 Then
                result(i, 0) = "MinTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.12.") >= 0 Then
                result(i, 0) = "MaxTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.13.") >= 0 Then
                result(i, 0) = "MinWarnTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.4.1.1.14.") >= 0 Then
                result(i, 0) = "MaxWarnTreshold"
                Continue For
            End If
            'INT SENSOR
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.1.") >= 0 Then
                result(i, 0) = "Index"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.2.") >= 0 Then
                result(i, 0) = "Type"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.3.") >= 0 Then
                result(i, 0) = "Description"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.4.") >= 0 Then
                result(i, 0) = "GroupNb"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.5.") >= 0 Then
                result(i, 0) = "Group"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.6.") >= 0 Then
                result(i, 0) = "Value"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.7.") >= 0 Then
                result(i, 0) = "Unit"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.8.") >= 0 Then
                result(i, 0) = "UnitName"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.9.") >= 0 Then
                result(i, 0) = "Status"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.10.") >= 0 Then
                result(i, 0) = "MinTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.11.") >= 0 Then
                result(i, 0) = "MaxTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.12.") >= 0 Then
                result(i, 0) = "MinWarnTreshold"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.3.1.1.13.") >= 0 Then
                result(i, 0) = "MaxWarnTreshold"
                Continue For
            End If
            'NECONFIG FILE
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.1.0") >= 0 Then
                result(i, 0) = "IP4 Mode"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.2.0") >= 0 Then
                result(i, 0) = "IP4 address"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.3.0") >= 0 Then
                result(i, 0) = "IP4 Mask"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.4.0") >= 0 Then
                result(i, 0) = "IP4 Gateway"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.5.0") >= 0 Then
                result(i, 0) = "PreDNS"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.6.0") >= 0 Then
                result(i, 0) = "AltDNS"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.7.0") >= 0 Then
                result(i, 0) = "DNS Timeout"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.8.0") >= 0 Then
                result(i, 0) = "IPv6 Mode"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.9.0") >= 0 Then
                result(i, 0) = "IPv6 address"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.10.0") >= 0 Then
                result(i, 0) = "IPv6 Gateway"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.11.0") >= 0 Then
                result(i, 0) = "Enable 6 to 4 tunnel"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.12.0") >= 0 Then
                result(i, 0) = "Local IP address"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.13.0") >= 0 Then
                result(i, 0) = "Remote IP address"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.14.0") >= 0 Then
                result(i, 0) = "Vlan Enabled"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.15.0") >= 0 Then
                result(i, 0) = "Vlan"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.16.0") >= 0 Then
                result(i, 0) = "Save"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.20.17.0") >= 0 Then
                result(i, 0) = "EnableSecurity"
                Continue For
            End If
            'INFOFILE
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.1.0") >= 0 Then
                result(i, 0) = "Time"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.2.0") >= 0 Then
                result(i, 0) = "Name"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.3.0") >= 0 Then
                result(i, 0) = "Location"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.4.0") >= 0 Then
                result(i, 0) = "Branch"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.5.0") >= 0 Then
                result(i, 0) = "Rack"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.6.0") >= 0 Then
                result(i, 0) = "Contact Person"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.7.0") >= 0 Then
                result(i, 0) = "Phone Number"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.8.0") >= 0 Then
                result(i, 0) = "Version"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.9.0") >= 0 Then
                result(i, 0) = "Model"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.10.0") >= 0 Then
                result(i, 0) = "--"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.11.0") >= 0 Then
                result(i, 0) = "--"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.12.0") >= 0 Then
                result(i, 0) = "Revision"
                Continue For
            End If
            If result(i, 0).IndexOf("1.3.6.1.4.1.3699.1.1.9.1.1.13.0") >= 0 Then
                result(i, 0) = "Manufacturer"
                Continue For
            End If
        Next
        Return result
    End Function
    Public Function ExportBufToList(input As String(,), CodeWord As String) As List(Of String)
        Dim ReturnList As List(Of String) = New List(Of String)
        Dim count As Integer = 0
        Dim startIndex As Integer = 0
        Dim startIndexGrab As Boolean = False
        For i As Integer = 0 To input.Length / 2 - 1
            If input(i, 0) Is Nothing Then
                Continue For
            End If
            If CodeWord = input(i, 0) Then
                If startIndexGrab = False Then
                    startIndex = i
                    startIndexGrab = True
                End If
                count = count + 1
            End If
        Next
        For i As Integer = 0 To count - 1
            ReturnList.Add(input(startIndex + i, 1))
        Next
        Return ReturnList
    End Function

    Public Function getSnmpIntSensorCard() As SnmpIntSensorCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.3"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpIntSensorCard = New SnmpIntSensorCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.TypeList = ExportBufToList(buf, "Type")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.GroupList = ExportBufToList(buf, "Group")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.UnitList = ExportBufToList(buf, "Unit")
        newCard.UnitNameList = ExportBufToList(buf, "UnitName")
        newCard.StatusList = ExportBufToList(buf, "Status")
        newCard.MinTresholdList = ExportBufToList(buf, "MinTreshold")
        newCard.MaxTresholdList = ExportBufToList(buf, "MaxTreshold")
        newCard.MinWarnTresholdList = ExportBufToList(buf, "MinWarnTreshold")
        newCard.MaxWarnTresholdList = ExportBufToList(buf, "MaxWarnTreshold")
        Return newCard
    End Function
    Public Function getSnmpAux2SensorCard() As SnmpAux2SensorCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.17"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpAux2SensorCard = New SnmpAux2SensorCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.TypeList = ExportBufToList(buf, "Type")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.ConnectorList = ExportBufToList(buf, "Connector")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.GroupList = ExportBufToList(buf, "Group")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.UnitList = ExportBufToList(buf, "Unit")
        newCard.UnitNameList = ExportBufToList(buf, "UnitName")
        newCard.StatusList = ExportBufToList(buf, "Status")
        newCard.MinTresholdList = ExportBufToList(buf, "MinTreshold")
        newCard.MaxTresholdList = ExportBufToList(buf, "MaxTreshold")
        newCard.MinWarnTresholdList = ExportBufToList(buf, "MinWarnTreshold")
        newCard.MaxWarnTresholdList = ExportBufToList(buf, "MaxWarnTreshold")
        Return newCard
    End Function
    Public Function getSnmpAuxSensorCard() As SnmpAuxSensorCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.4.1"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpAuxSensorCard = New SnmpAuxSensorCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.TypeList = ExportBufToList(buf, "Type")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.ConnectorList = ExportBufToList(buf, "Connector")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.GroupList = ExportBufToList(buf, "Group")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.UnitList = ExportBufToList(buf, "Unit")
        newCard.UnitNameList = ExportBufToList(buf, "UnitName")
        newCard.StatusList = ExportBufToList(buf, "Status")
        newCard.MinTresholdList = ExportBufToList(buf, "MinTreshold")
        newCard.MaxTresholdList = ExportBufToList(buf, "MaxTreshold")
        newCard.MinWarnTresholdList = ExportBufToList(buf, "MinWarnTreshold")
        newCard.MaxWarnTresholdList = ExportBufToList(buf, "MaxWarnTreshold")
        Return newCard
    End Function
    Public Function getSnmpDigInputCard() As SnmpDigInputCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.6"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpDigInputCard = New SnmpDigInputCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.TypeList = ExportBufToList(buf, "Type")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.ConnectorList = ExportBufToList(buf, "Connector")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.GroupList = ExportBufToList(buf, "Group")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.StatusList = ExportBufToList(buf, "Status")
        newCard.NormalValueList = ExportBufToList(buf, "NormalValue")

        Return newCard
    End Function
    Public Function getSnmpExtSensorCard() As SnmpExtSensorCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.5"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpExtSensorCard = New SnmpExtSensorCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.TypeList = ExportBufToList(buf, "Type")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.ConnectorList = ExportBufToList(buf, "Connector")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.GroupList = ExportBufToList(buf, "Group")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.UnitList = ExportBufToList(buf, "Unit")
        newCard.UnitNameList = ExportBufToList(buf, "UnitName")
        newCard.StatusList = ExportBufToList(buf, "Status")
        newCard.MinTresholdList = ExportBufToList(buf, "MinTreshold")
        newCard.MaxTresholdList = ExportBufToList(buf, "MaxTreshold")
        newCard.MinWarnTresholdList = ExportBufToList(buf, "MinWarnTreshold")
        newCard.MaxWarnTresholdList = ExportBufToList(buf, "MaxWarnTreshold")
        Return newCard
    End Function
    Public Function getSnmpMsgRegistersCard() As SnmpMsgRegistersCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.18"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpMsgRegistersCard = New SnmpMsgRegistersCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        Return newCard
    End Function
    Public Function getSnmpOutRelayCard() As SnmpOutRelayCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.8"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpOutRelayCard = New SnmpOutRelayCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.StatusList = ExportBufToList(buf, "Status")
        Return newCard
    End Function
    Public Function getSnmpPwrSupplyCard() As SnmpPwrSupplyCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf  As String(,) = Converter( Walk("1.3.6.1.4.1.3699.1.1.9.1.9"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpPwrSupplyCard = New SnmpPwrSupplyCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.StatusList = ExportBufToList(buf, "Status")
        Return newCard
    End Function
    Public Function getSnmpRemoteInputCard() As SnmpRemoteInputCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.12"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpRemoteInputCard = New SnmpRemoteInputCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.TypeList = ExportBufToList(buf, "Type")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.ConnectorList = ExportBufToList(buf, "Connector")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.GroupList = ExportBufToList(buf, "Group")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.StatusList = ExportBufToList(buf, "Status")
        newCard.NormalValueList = ExportBufToList(buf, "NormalValue")
        Return newCard
    End Function
    Public Function getSnmpRemoteRelayCard() As SnmpRemoteRelayCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter( Walk("1.3.6.1.4.1.3699.1.1.9.1.13"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpRemoteRelayCard = New SnmpRemoteRelayCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.StatusList = ExportBufToList(buf, "Status")
        Return newCard
    End Function
    Public Function getSnmpSmokeDetectorCard() As SnmpSmokeDetectorCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf As String(,) = Converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.14"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpSmokeDetectorCard = New SnmpSmokeDetectorCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.StatusList = ExportBufToList(buf, "Status")
        Return newCard
    End Function
    Public Function getSnmpTackSensorCard() As SnmpTackSensorCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf  As String(,) = Converter( Walk("1.3.6.1.4.1.3699.1.1.9.1.15"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpTackSensorCard = New SnmpTackSensorCard
        newCard.IndexList = ExportBufToList(buf, "Index")
        newCard.TypeList = ExportBufToList(buf, "Type")
        newCard.DescriptionList = ExportBufToList(buf, "Description")
        newCard.ConnectorList = ExportBufToList(buf, "Connector")
        newCard.GroupNbList = ExportBufToList(buf, "GroupNb")
        newCard.GroupList = ExportBufToList(buf, "Group")
        newCard.ValueList = ExportBufToList(buf, "Value")
        newCard.UnitList = ExportBufToList(buf, "Unit")
        newCard.UnitNameList = ExportBufToList(buf, "UnitName")
        newCard.StatusList = ExportBufToList(buf, "Status")
        newCard.MinTresholdList = ExportBufToList(buf, "MinTreshold")
        newCard.MaxTresholdList = ExportBufToList(buf, "MaxTreshold")
        newCard.MinWarnTresholdList = ExportBufToList(buf, "MinWarnTreshold")
        newCard.MaxWarnTresholdList = ExportBufToList(buf, "MaxWarnTreshold")
        Return newCard
    End Function


    Public Function getSnmpInfoCard() As SnmpInfoCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf = converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.1"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpInfoCard = New SnmpInfoCard
        If buf Is Nothing Then
            Return Nothing
        End If
        newCard.sysTime = buf(1, 1)
        newCard.sysName = buf(2, 1)
        newCard.sysLocation = buf(3, 1)
        newCard.sysBranch = buf(4, 1)
        newCard.sysRack = buf(5, 1)
        newCard.sysContact = buf(6, 1)
        newCard.sysPhone = buf(7, 1)
        newCard.firmwareVersion = buf(8, 1)
        newCard.deviceModel = buf(9, 1)
        newCard.sysReset = buf(10, 1)
        newCard.devSerialNum = buf(11, 1)
        newCard.devHardwareRev = buf(12, 1)
        newCard.devManufactureR = buf(13, 1)
        Return newCard
    End Function


    Public Function getSnmpNetConfCard() As SnmpNetConfCard
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        Dim buf = converter(Walk("1.3.6.1.4.1.3699.1.1.9.1.20"))
        If buf Is Nothing Then
            Return Nothing
        End If
        Dim newCard As SnmpNetConfCard = New SnmpNetConfCard
        newCard.IP4Mode = buf(1, 1)
        newCard.IP4Addr = buf(2, 1)
        newCard.IP4Mask = buf(3, 1)
        newCard.IP4GateWay = buf(4, 1)
        newCard.PreDNS = buf(5, 1)
        newCard.AltDNS = buf(6, 1)
        newCard.DNSTimeOut = buf(7, 1)
        newCard.IPv6Mode = buf(8, 1)
        newCard.IPv6Addr = buf(9, 1)
        newCard.IPv6GateWay = buf(10, 1)
        newCard.Enable6To4Tunnel = buf(11, 1)
        newCard.LocalIPAddr = buf(12, 1)
        newCard.RemoteIPv4Addr = buf(13, 1)
        newCard.VlanEnabled = buf(14, 1)
        newCard.Vlan = buf(15, 1)
        newCard.Save = buf(16, 1)
        newCard.EnableSecurity = buf(17, 1)
        Return newCard

    End Function

    '    Public Function SnmpSet(input As String, command As Integer)
    '        If MonitoringBase.connectToDevice.SNMPConnection.IP.installed() <> True Then
    '            Return Nothing
    '        End If
    '        Dim host As String = IP
    '        Dim result As Dictionary(Of Oid, AsnType)
    '        'Create a set Pdu
    '        Dim Pdu = New Pdu()
    '        Pdu.Type = PduType.Set
    '        Dim setOid = New Oid(input)
    '        Dim setValue = New Integer32
    '        setValue.Value = command
    '        Pdu.VbList.Add(setOid, setValue)
    '        Dim snmp As SimpleSnmp = New SimpleSnmp(host, community)
    '        If Not snmp.Valid Then
    '            Exit Function
    '        End If
    '        result = snmp.Set(SnmpVersion.Ver2, Pdu)
    '        If result IsNot Nothing Then
    '            Dim kvp As KeyValuePair(Of Oid, AsnType)
    '            For Each kvp In result
    '
    '        Next
    '    Else
    '        MsgBox("Set operation failed.")
    '    End If
    'End Function

    '    Public Function SnmpSet(input As String, command As String)
    '        IP = My.Forms.Workspace.SensorsConfig1.InputIP.Text
    '       community = My.Forms.Workspace.SensorsConfig1.CommunityBox.Text
    '        If IP = "" Then
    '            Message = "Error IP."
    '            Return Nothing
    '        End If
    '        Dim host As String = IP
    '        Dim result As Dictionary(Of Oid, AsnType)
    '        Dim Pdu = New Pdu()
    '        Pdu.Type = PduType.Set
    '        Dim setOid = New Oid(input)
    '        Dim setValue = New OctetString(command)
    '        Pdu.VbList.Add(setOid, setValue)
    '        Dim snmp As SimpleSnmp = New SimpleSnmp(host, community)
    '        If Not snmp.Valid Then
    '            Exit Function
    '        End If
    '        result = snmp.Set(SnmpVersion.Ver2, Pdu)
    '        If result IsNot Nothing Then
    '            Dim kvp As KeyValuePair(Of Oid, AsnType)
    '            For Each kvp In result
    '
    '            Next
    '        Else
    '            MsgBox("Set operation failed.")
    '        End If
    '    End Function

    Public Function Walk(input As String) As String(,)
        If User.LoginnedProfile.Data.MB.IP.installed() <> True Then
            Return Nothing
        End If
        'MonitoringBase.online = MonitoringBase.connectToDevice.testConnection()
        If MonitoringBase.connectToDevice.testConnection() Then
            Dim ret(1000, 1) As String
            Dim host As String = IP.FullString()
            Dim result As Dictionary(Of Oid, AsnType)
            Dim snmp As SimpleSnmp = New SimpleSnmp(User.LoginnedProfile.Data.MB.IP.FullString, User.LoginnedProfile.Data.MB.Login)
            snmp.Timeout = 10000
            If Not snmp.Valid Then
                Return Nothing
            End If

            result = snmp.Walk(SnmpVersion.Ver1, input)

            If result IsNot Nothing Then
                Dim kvp As KeyValuePair(Of Oid, AsnType)

                Dim int As Integer = 0
                For Each kvp In result
                    int = int + 1
                    ret(int, 0) = kvp.Key.ToString()
                    ret(int, 1) = kvp.Value.ToString()
                Next
                Return ret
            Else
                Return Nothing
            End If
        Else
        End If
        Return Nothing
    End Function
    Public MonitoringStatus As Boolean
End Class
