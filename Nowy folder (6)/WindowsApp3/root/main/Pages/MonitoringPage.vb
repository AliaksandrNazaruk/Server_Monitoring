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
        User.LoginnedProfile.Data.MB.SensorListForMB.MonitoringSensorList
        If ListMb.Count > 0 Then
            TableForMB.Visible = True
            TableForMB.DeviceName.Text = Module2.MonitoringBase.dataFile.DeviceInformation.DeviceModel
            For i As Integer = 0 To ListMb.Count - 1
                TableForMB.ContainerForTableElements.Controls.Add(New tabbleElem(ListMb(i)))
            Next
        Else
            TableForMB.Visible = False
        End If
    End Sub
End Class

