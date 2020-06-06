Public Class IPAddpessBox
    Public IPaddr As IPaddress = New IPaddress(0, 0, 0, 0)
    Public Sub clear()
        IPaddr = New IPaddress(0, 0, 0, 0)
        InpIPTextBox1.Clear()
        InpIPTextBox2.Clear()
        InpIPTextBox3.Clear()
        InpIPTextBox4.Clear()
    End Sub
    Dim Working As Boolean = False

    Private Function CheckFunction(Input As TextBox) As Boolean
        If Input.Text.Length = 0 Or Working = True Then
            Return False
        End If
        For j As Integer = 0 To Input.Text.Length - 1
            Dim corresponds As Boolean = False
            For i As Integer = 0 To 9
                If Input.Text(j) = i.ToString Then
                    corresponds = True
                    Exit For
                End If
            Next
            If corresponds <> True Then
                Working = True
                Input.Text = Input.Text.Replace(Input.Text(j), "")
                Working = False
                Return False
            End If
        Next


        If Convert.ToInt16(Input.Text) > 255 Then
            MsgBox("Value must not exceed 255")
            Input.Text = ""
            Return False
        End If
        For j As Integer = 0 To Input.Text.Length - 1
            If correctSymbols(Input.Text(j)) Then
            Else
                Input.Text = Input.Text.Remove(Input.Text.Count - 1, 1)
                Input.SelectionStart = Len(RTrim(Input.Text))
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub InpIPTextBox1_TextChanged(sender As Object, e As EventArgs) Handles InpIPTextBox1.TextChanged
        If CheckFunction(InpIPTextBox1) Then
            If Len(RTrim(InpIPTextBox1.Text)) = 3 Then
                InpIPTextBox2.Focus()
                InpIPTextBox2.SelectAll()
            End If
            IPaddr.Arg1 = InpIPTextBox1.Text
        End If
    End Sub

    Private Sub InpIPTextBox2_TextChanged(sender As Object, e As EventArgs) Handles InpIPTextBox2.TextChanged
        If CheckFunction(InpIPTextBox2) Then
            If Len(RTrim(InpIPTextBox2.Text)) = 3 Then
                InpIPTextBox3.Focus()
                InpIPTextBox3.SelectAll()
            End If
            IPaddr.Arg2 = InpIPTextBox2.Text
        End If
    End Sub

    Private Sub InpIPTextBox3_TextChanged(sender As Object, e As EventArgs) Handles InpIPTextBox3.TextChanged
        If CheckFunction(InpIPTextBox3) Then
            If Len(RTrim(InpIPTextBox3.Text)) = 3 Then
                InpIPTextBox4.Focus()
                InpIPTextBox4.SelectAll()
            End If
            IPaddr.Arg3 = InpIPTextBox3.Text
        End If
    End Sub

    Private Sub InpIPTextBox4_TextChanged(sender As Object, e As EventArgs) Handles InpIPTextBox4.TextChanged
        If CheckFunction(InpIPTextBox4) Then
            IPaddr.Arg4 = InpIPTextBox4.Text
        End If
    End Sub

    Private Function correctSymbols(inp As String)
        If inp = "1" Then
            Return True
        End If
        If inp = "2" Then
            Return True
        End If
        If inp = "3" Then
            Return True
        End If
        If inp = "4" Then
            Return True
        End If
        If inp = "5" Then
            Return True
        End If
        If inp = "6" Then
            Return True
        End If
        If inp = "7" Then
            Return True
        End If
        If inp = "8" Then
            Return True
        End If
        If inp = "9" Then
            Return True
        End If
        If inp = "0" Then
            Return True
        End If
        Return False
    End Function
End Class
