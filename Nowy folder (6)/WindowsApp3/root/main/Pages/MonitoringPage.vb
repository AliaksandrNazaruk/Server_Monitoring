Public Class MonitoringPage
    Private Sub MonitoringPage_Enabled(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If MyBase.Visible Then
            MBTableGenerator()
            PDUTableGenerator()
        End If
    End Sub
    Private Sub PDUTableGenerator()
        TableForPDUA.ContainerForTableElements.Controls.Clear()
        If Module1.PDUA.dataFile.table.TableType <> "" Then
            TableForPDUA.Visible = True
            TableForPDUA.DeviceName.Text = Module1.PDUA.dataFile.information.pduName
            If Module1.PDUA.dataFile.table.TableType = "PDUTypeP3A6T0" Then
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase1"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase1", "Ampermeter1"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase1", "Ampermeter2"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase2"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase2", "Ampermeter1"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase2", "Ampermeter2"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase3"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase3", "Ampermeter1"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Phase3", "Ampermeter2"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Termometer"))
                TableForPDUA.ContainerForTableElements.Controls.Add(New tabbleElem("PDUA", "Termometer", "Termometer1"))
            End If

        Else
                TableForPDUA.Visible = False
        End If
        If Module1.PDUB.dataFile.table.TableType = "" Then

        End If
    End Sub
    Private Sub MBTableGenerator()
        TableForMB.ContainerForTableElements.Controls.Clear()
        Dim TableVisebleSwitch As Boolean = False
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.Aux2SensorList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.Aux2SensorList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.Aux2SensorList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.AuxSensorList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.AuxSensorList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.AuxSensorList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.DigInputList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.DigInputList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.DigInputList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.ExtSensorList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.ExtSensorList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.ExtSensorList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.IntSensorList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.IntSensorList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.IntSensorList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.IPDevicesList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.IPDevicesList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.IPDevicesList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.ipSensorList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.ipSensorList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.ipSensorList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.MsgRegistersList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.MsgRegistersList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.MsgRegistersList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.OutRelayList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.OutRelayList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.OutRelayList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.PwrSupplyList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.PwrSupplyList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.PwrSupplyList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.remoteInputsList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.remoteInputsList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.remoteInputsList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.RemoteRelayList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.RemoteRelayList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.RemoteRelayList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.SensorsList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.SensorsList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.SensorsList(i)))
                TableVisebleSwitch = True
            End If
        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.smokeDetectorsList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.smokeDetectorsList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.smokeDetectorsList(i)))
                TableVisebleSwitch = True
            End If

        Next
        For i As Integer = 0 To User.LoginnedProfile.Data.MB.SensorListForMB.TacSensorList.Count - 1
            If User.LoginnedProfile.Data.MB.SensorListForMB.TacSensorList(i) Then
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(Module2.MonitoringBase.dataFile.SensorData.TacSensorList(i)))
                TableVisebleSwitch = True
            End If
        Next
        If TableVisebleSwitch Then
            TableForMB.Visible = True
        Else
            TableForMB.Visible = False
        End If
    End Sub
End Class

