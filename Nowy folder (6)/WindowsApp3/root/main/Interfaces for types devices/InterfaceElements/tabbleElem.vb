Public Class tabbleElem
    Public added As Boolean = False
    Private LastMessage As Message = New Message("", "", "")
    Private VerifyVal As Integer = 0
    Private Sub TabbleElem_Load(sender As Object, e As EventArgs)

    End Sub
    Private Function mySensor() As String

    End Function
    Public Sub Status_change() Handles Value.TextChanged
        If Status.Text = "no section" Then
            NoSectionMethod()
        End If
        If Status.Text = "no sensor" Then
            NoSectionMethod()
        End If
        If Status.Text.IndexOf(" A") >= 0 Then
            NormalCurrentMethod()
        End If
    End Sub
    Private Sub NormalCurrentMethod()
        Dim newNewmessage As Message = New Message("Message", "", SensorType.Text + " from " + Base.Text + " is in a state '" + Status.Text + "'")
        If validationСheck() Then
            If LastMessage.Type = "Alert" Then
                My.Forms.Workspace.Log1.SendMessagesFunction(newNewmessage)
            Else
                If LastMessage.BodyMessage <> newNewmessage.BodyMessage Then
                    My.Forms.Workspace.Log1.SendMessagesFunction(newNewmessage)
                End If
            End If
            LastMessage = newNewmessage
        End If

        VerifyVal = 0
    End Sub
    Private Sub NoSectionMethod()
        If validationСheck() Then
            Dim newNewmessage As Message = New Message("Alert", "", SensorType.Text + " from " + Base.Text + " is in a state '" + Status.Text + "'")
            If LastMessage.BodyMessage = newNewmessage.BodyMessage Then
                If My.Forms.Workspace.AllertConfig1.ResendValue > 0 And My.Forms.Workspace.AllertConfig1.ResendValue <> VerifyVal And My.Forms.Workspace.AllertConfig1.CheckBox1.Checked Then
                    My.Forms.Workspace.Log1.SendMessagesFunction(LastMessage)
                End If
            Else
                My.Forms.Workspace.Log1.SendMessagesFunction(newNewmessage)
            End If
            LastMessage = newNewmessage
        End If

        VerifyVal = My.Forms.Workspace.AllertConfig1.ResendValue
    End Sub
    Private Function validationСheck() As Boolean
        If MyClass.Name = "Ampermeter1Table" Then
            If MyClass.Base.Text = "PDU A" Then
                If User.TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter1L Then
                    Return True
                End If
            End If
            If MyClass.Base.Text = "PDU B" Then
                If User.TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter1L Then
                    Return True
                End If
            End If
        End If
        If MyClass.Name = "Ampermeter2Table" Then
            If MyClass.Base.Text = "PDU A" Then
                If User.TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter2L Then
                    Return True
                End If
            End If
            If MyClass.Base.Text = "PDU B" Then
                If User.TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter2L Then
                    Return True
                End If
            End If
        End If
        If MyClass.Name = "Ampermeter3Table" Then
            If MyClass.Base.Text = "PDU A" Then
                If User.TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter3L Then
                    Return True
                End If
            End If
            If MyClass.Base.Text = "PDU B" Then
                If User.TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter3L Then
                    Return True
                End If
            End If
        End If
        If MyClass.Name = "Ampermeter4Table" Then
            If MyClass.Base.Text = "PDU A" Then
                If User.TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter4L Then
                    Return True
                End If
            End If
            If MyClass.Base.Text = "PDU B" Then
                If User.TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter4L Then
                    Return True
                End If
            End If
        End If
        If MyClass.Name = "Ampermeter5Table" Then
            If MyClass.Base.Text = "PDU A" Then
                If User.TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter5L Then
                    Return True
                End If
            End If
            If MyClass.Base.Text = "PDU B" Then
                If User.TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter5L Then
                    Return True
                End If
            End If
        End If
        If MyClass.Name = "Ampermeter6Table" Then
            If MyClass.Base.Text = "PDU A" Then
                If User.TempProfile.Data.PDUA.SensorList.LogCard.Ampermeter6L Then
                    Return True
                End If
            End If
            If MyClass.Base.Text = "PDU B" Then
                If User.TempProfile.Data.PDUB.SensorList.LogCard.Ampermeter6L Then
                    Return True
                End If
            End If
        End If
        If MyClass.Name = "TemperatureTable" Then
            If MyClass.Base.Text = "PDU A" Then
                If User.TempProfile.Data.PDUA.SensorList.LogCard.TermometerL Then
                    Return True
                End If
            End If
            If MyClass.Base.Text = "PDU B" Then
                If User.TempProfile.Data.PDUB.SensorList.LogCard.TermometerL Then
                    Return True
                End If
            End If
        End If
    End Function
    Private Sub Status_change(sender As Object, e As EventArgs) Handles Status.BackColorChanged

    End Sub
End Class
