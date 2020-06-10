Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Module User
    <Serializable()>
    Public Class UserProfile
        Public FileName As String = "..\..\" + "Saved.bin"
        Sub New(adm As Boolean, opr As Boolean, NameUser As String, PasswordUser As String)
            AdminMode = adm '
            OperatorMode = opr '
            Login = NameUser '
            Password = PasswordUser '
            FileName = "..\..\" + Login + "Saved.bin"
        End Sub
        Public Sub Save()
            Dim TestFileStream As Stream = File.Create(FileName)
            Dim serializer As New BinaryFormatter
            serializer.Serialize(TestFileStream, User.LoginnedProfile)
            TestFileStream.Close()
        End Sub
        Public Sub Load()
            If File.Exists(FileName) Then
                Dim TestFileStream As Stream = File.OpenRead(FileName)
                Dim deserializer As New BinaryFormatter
                User.LoginnedProfile = CType(deserializer.Deserialize(TestFileStream), UserProfile)
                TestFileStream.Close()
            End If
        End Sub
        '//General Data
        Public AdminMode As Boolean
        Public OperatorMode As Boolean
        Public Login As String
        Public Password As String
        Public Data As DevicesDataFile = New DevicesDataFile

        '//Allert Configuration Settings
        Public AlertMessageSwitch As Boolean
        Public AnimatedAlertSwitch As Boolean
        Public SoundAlertSwitch As Boolean
        Public SendMessageToEmailSwitch As Boolean
        Public TestModeSwitch As Boolean

        '//User Configuration Settings
        Public Title As String '
        Public Departament As String '
        Public Company As String '
        Public Email As String '
        Public SMSNumber As String '
        Public Location As String '
        <Serializable()>
        Public Class DevicesDataFile
            Public PDUA As DeviceData = New DeviceData
            Public PDUB As DeviceData = New DeviceData
            Public MB As DeviceData = New DeviceData
            <Serializable()>
            Public Class DeviceData
                Public port As String = ""
                Public Type As String = ""
                Public IP As IPaddress = New IPaddress(0, 0, 0, 0)
                Public Login As String = ""
                Public Password As String = ""
                Public RememberCheckBOx As Boolean = False
                Public LocAddrCheckBox As Boolean = False
                Public SensorListForPDU As SensorMap = New SensorMap
                Public SensorListForMB As SensorMapMonitoringSystem
                Public Sub clear()
                    Type = ""
                    port = ""
                    IP = New IPaddress(0, 0, 0, 0)
                    Login = ""
                    Password = ""
                    RememberCheckBOx = False
                    SensorListForPDU = New SensorMap
                End Sub
            End Class
        End Class

    End Class
    Public LoginnedProfile As UserProfile = New UserProfile(True, True, "1kj213j1bkjB@@JKk2jbkbjsabdkDDAS", "23kjg42kj324jkh2kjhKJHKh4kjh34kjhKHkjh4kjhkKKased")
    Public Function GetUser(inpLogin As String) As UserProfile
        Dim tempUserProfile As UserProfile = LoadFunction("..\..\" + inpLogin + "Saved.bin")
        Return tempUserProfile
    End Function
    Public Function DeleteUserProfile(Login As String) As Boolean

    End Function
    Public Function Search() As List(Of UserProfile)
        Dim fold As String = "..\..\"
        Dim UserList As List(Of UserProfile) = New List(Of UserProfile)
        For i As Integer = 0 To System.IO.Directory.GetFiles(fold).Count - 1
            If System.IO.Directory.GetFiles(fold)(i).ToString.IndexOf("Saved.bin") >= 0 Then
                Dim UserName As String = System.IO.Directory.GetFiles(fold)(i).ToString
                UserName = UserName.Replace("Saved.bin", "").Replace("..\..\", "")
                Dim RetUser As UserProfile = GetUser(UserName)
                UserList.Add(RetUser)
            End If
        Next
        Return UserList
    End Function
    Public Sub SaveFunction(obj As Object, fileName As String)
        Dim TestFileStream As Stream = File.Create(fileName)
        Dim serializer As New BinaryFormatter
        serializer.Serialize(TestFileStream, obj)
        TestFileStream.Close()
    End Sub
    Public Function LoadFunction(FileName As String) As Object
        If File.Exists(FileName) Then
            Dim TestFileStream As Stream = File.OpenRead(FileName)
            Dim deserializer As New BinaryFormatter
            Return CType(deserializer.Deserialize(TestFileStream), Object)
            TestFileStream.Close()
        End If
        Return Nothing
    End Function
End Module
