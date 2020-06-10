Imports System.Net.Mail

Public Class LOGPage
    Public Function SendMail(subject As String, content As String)
        Try
            Dim mail As MailMessage = New MailMessage()
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com", 465)
			
            mail.From = New MailAddress("softwaremaxbert@gmail.com") '
            mail.To.Add(User.LoginnedProfile.Email)
			
            mail.Subject = subject
            mail.Body = content
			
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("softwaremaxbert@gmail.com", "softwaremaxbert48911")
            smtp.EnableSsl = True
            smtp.Send(mail)
            'MsgBox("mail send")
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Function
    Private Sub LOGbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LOGbox.Enter
        LOGbox.Select()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        SaveFileDialog1.Filter = "Text |*.txt"
        SaveFileDialog1.Title = "Save Log File"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.ShowDialog()
        Dim path = SaveFileDialog1.FileName
        If path.Length < 3 Then
            Exit Sub
        End If
        Dim info As Byte()
        Dim fs As System.IO.FileStream = System.IO.File.Create(path)
        Dim clearIndex As Integer = LOGbox.Items.Count
        For i As Integer = 0 To clearIndex - 1
            info = New System.Text.UTF8Encoding(True).GetBytes(LOGbox.Items.Item(i) & vbCrLf)
            fs.Write(info, 0, info.Length)
        Next
        fs.Close()
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim clearIndex As Integer = LOGbox.Items.Count
        For i As Integer = 0 To clearIndex - 1
            LOGbox.Items.RemoveAt(0)
        Next
    End Sub
    Public Function SendMessageToEmail() As String
        Dim newEmailMessage As EmailMessage = New EmailMessage
        newEmailMessage.StateMeassage = "State «Error» has ended (new state: «Unknown»)"
        Return newEmailMessage.GenerateMessage()
    End Function
    Public Sub SendMessagesFunction(inp As Message)
        If inp Is Nothing Then
            Exit Sub
        End If
        If LogHistory.IndexOf(inp) = -1 Then
            LogHistory.Add(inp)
        End If
        If inp.Type = "Alert" Then
            If My.Forms.Workspace.AllertConfig1.AllertMessageSwitch.Checked Then
                MsgBox(inp.BodyMessage)
            End If
        End If
        If My.Forms.Workspace.AllertConfig1.SendMessageToEmailSwitch.Checked Then
            SendMail("A new event has occurred in the monitoring system.", inp.BodyMessage)
        End If
        LOGbox.Items.Add(inp._Date.ToString + "   " + inp.Type.ToString + "   " + inp.BodyMessage)
    End Sub
    Private LogHistory As List(Of Message) = New List(Of Message)
    Private count As Integer = 0
End Class


