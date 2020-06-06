Public Class Scale
    Private Sub Scale_Load(sender As Object, e As EventArgs)
        minnoncrittresh.Text = 50
        maxnoncrittresh.Text = 70
        mincrittresh.Text = 20
        maxcrittresh.Text = 90
        SetCursor(50)
        setWarn1(minnoncrittresh.Text)
        setNormal(maxnoncrittresh.Text)
        setAlarm1(mincrittresh.Text)
        setWarn2(maxcrittresh.Text)
    End Sub
    Public Sub setWarn1(Percent As Integer)
        Dim start As Integer = MinLine.Location.X
        Dim ende As Integer = MaxLine.Location.X
        Dim onePercent As Double = (ende - start) / 100

        WarnButton1.Location = New Point(start + (Percent * onePercent), WarnButton1.Location.Y)
        WarnIndicaror1.Size = New Size(Percent * onePercent, WarnIndicaror1.Size.Height)
        minnoncrittresh.Text = (maxValue / 100) * Percent
    End Sub
    Public Sub setAlarm1(Percent As String)
        Dim start As Integer = MinLine.Location.X
        Dim ende As Integer = MaxLine.Location.X
        Dim onePercent As Double = (ende - start) / 100

        AlarmButton1.Location = New Point(start + (Percent * onePercent), AlarmButton1.Location.Y)
        AlarmIndicator1.Size = New Size(Percent * onePercent, AlarmIndicator1.Size.Height)
        mincrittresh.Text = (maxValue / 100) * Percent
    End Sub
    Public Sub setNormal(Percent As String)
        Dim start As Integer = MinLine.Location.X
        Dim ende As Integer = MaxLine.Location.X
        Dim onePercent As Double = (ende - start) / 100

        NormalButton.Location = New Point(start + (Percent * onePercent), NormalButton.Location.Y)
        NormalIndicator.Size = New Size(Percent * onePercent, NormalIndicator.Size.Height)
        maxnoncrittresh.Text = (maxValue / 100) * Percent
    End Sub
    Public Sub setWarn2(Percent As Integer)
        Dim start As Integer = MinLine.Location.X
        Dim ende As Integer = MaxLine.Location.X
        Dim onePercent As Double = (ende - start) / 100

        WarnButton2.Location = New Point(start + (Percent * onePercent), WarnButton2.Location.Y)
        WarnIndicator2.Size = New Size(Percent * onePercent, WarnIndicator2.Size.Height)
        maxcrittresh.Text = (maxValue / 100) * Percent
    End Sub
    Private mode = "ReadWrite"
    Public Function setMode(input As String)
        If input = "1" Then
            WarnIndicaror1.Visible = False
            WarnButton1.Visible = False
            WarnIndicator2.Visible = False
            NormalButton.Visible = False
        End If
        If input = "Read" Then
            mode = "Read"
            mincrittresh.Enabled = False
            maxcrittresh.Enabled = False
            minnoncrittresh.Enabled = False
            maxnoncrittresh.Enabled = False
        End If
        If input = "ReadWrite" Then
            mode = "ReadWrite"
            mincrittresh.Enabled = True
            maxcrittresh.Enabled = True
            minnoncrittresh.Enabled = True
            maxnoncrittresh.Enabled = True
        End If
    End Function

    Public maxValue As Integer = 100
    Public Sub setScaleValue(maxVal As Integer, Nominal As String)
        maxValue = maxVal
        value1.Text = (0).ToString + " " + Nominal
        value2.Text = ((maxVal / 4) * 1).ToString + " " + Nominal
        value3.Text = ((maxVal / 4) * 2).ToString + " " + Nominal
        value4.Text = ((maxVal / 4) * 3).ToString + " " + Nominal
        value5.Text = (maxVal).ToString + " " + Nominal
    End Sub

    Public Sub SetCursor(Percents As Double)
        Dim min As Integer = MinLine.Location.X
        Dim max As Integer = MaxLine.Location.X
        Dim onePercentInPix As Double = (max - min) / 100
        Dim result = (Percents * onePercentInPix) + min
        cursor1.Location = New Point(result, cursor1.Location.Y)
        cursor2.Location = New Point(result, cursor2.Location.Y)
    End Sub
    '============================================================================================================
    Private AlarmButton1Click As Boolean = False
    Private Sub AlarmButton1_MouseDownClick(sender As Object, e As MouseEventArgs) Handles AlarmButton1.MouseDown
        If mode = "Read" Then
        Else
            AlarmButton1Click = True
        End If
    End Sub
    Private Sub AlarmButton1_MouseUpClick(sender As Object, e As MouseEventArgs) Handles AlarmButton1.MouseUp
        AlarmButton1Click = False
    End Sub
    Private Sub AlarmButton1_MouseEnter(sender As Object, e As EventArgs) Handles AlarmButton1.MouseEnter
        If mode = "Read" Then
        Else
            AlarmButton1.Image = im2
        End If
    End Sub
    Private Sub AlarmButton1_MouseLeave(sender As Object, e As EventArgs) Handles AlarmButton1.MouseLeave
        AlarmButton1.Image = Background1
    End Sub
    Private Sub AlarmButton1_MouseMove(sender As Object, e As MouseEventArgs) Handles AlarmButton1.MouseMove
        If AlarmButton1Click Then
            Dim result = AlarmButton1.Location.X + e.X
            If result <= linear.Location.X Then
                result = linear.Location.X
            End If

            If result >= WarnButton1.Location.X - WarnButton1.Size.Width Then
                result = WarnButton1.Location.X - WarnButton1.Size.Width
            End If

            If result >= linear.Location.X + linear.Size.Width - AlarmButton1.Size.Width Then
                result = linear.Location.X + linear.Size.Width - AlarmButton1.Size.Width
            End If
            AlarmButton1.Location = New Point(result, AlarmButton1.Location.Y)
            Dim indicatorsize = result - linear.Location.X
            AlarmIndicator1.Size = New Size(indicatorsize, AlarmIndicator1.Size.Height)
            Dim val1Percents As Double = AlarmIndicator1.Size.Width / (443 / 100)
            Dim val2 As Double = (maxValue / 100) * val1Percents


            val2 = Mid(val2.ToString, 1, 5)
            mincrittresh.Text = converter(val2)

        End If
    End Sub
    '============================================================================================================
    '============================================================================================================
    Private Sub WarnButton1_MouseEnter(sender As Object, e As EventArgs) Handles WarnButton1.MouseEnter
        If mode = "Read" Then
        Else
            WarnButton1.Image = im2
        End If
    End Sub
    Private Sub WarnButton1_MouseLeave(sender As Object, e As EventArgs) Handles WarnButton1.MouseLeave
        WarnButton1.Image = Background1
    End Sub
    Private WarnButton1Click As Boolean = False
    Private Sub WarnButton1_MouseDownClick(sender As Object, e As MouseEventArgs) Handles WarnButton1.MouseDown
        If mode = "Read" Then
        Else
            WarnButton1Click = True
        End If
    End Sub
    Private Sub WarnButton1_MouseUpClick(sender As Object, e As MouseEventArgs) Handles WarnButton1.MouseUp
        WarnButton1Click = False
    End Sub
    Private Sub WarnButton1_MouseMove(sender As Object, e As MouseEventArgs) Handles WarnButton1.MouseMove
        If WarnButton1Click Then
            Dim result = WarnButton1.Location.X + e.X
            If result <= linear.Location.X Then
                result = linear.Location.X
            End If

            If result <= AlarmButton1.Location.X + AlarmButton1.Size.Width Then
                result = AlarmButton1.Location.X + AlarmButton1.Size.Width
            End If
            If result >= NormalButton.Location.X - NormalButton.Size.Width Then
                result = NormalButton.Location.X - NormalButton.Size.Width
            End If

            If result >= linear.Location.X + linear.Size.Width - WarnButton1.Size.Width Then
                result = linear.Location.X + linear.Size.Width - WarnButton1.Size.Width
            End If
            WarnButton1.Location = New Point(result, WarnButton1.Location.Y)
            Dim indicatorsize = result - linear.Location.X
            WarnIndicaror1.Size = New Size(indicatorsize, WarnIndicaror1.Size.Height)

            Dim val1Percents As Double = WarnIndicaror1.Size.Width / (443 / 100)
            Dim val2 As Double = (maxValue / 100) * val1Percents

            val2 = Mid(val2.ToString, 1, 5)
            minnoncrittresh.Text = converter(val2)
        End If
    End Sub
    '============================================================================================================
    '============================================================================================================
    Private Sub NormalButton_MouseEnter(sender As Object, e As EventArgs) Handles NormalButton.MouseEnter
        If mode = "Read" Then
        Else
            NormalButton.Image = im2
        End If
    End Sub
    Private Sub NormalButton_MouseLeave(sender As Object, e As EventArgs) Handles NormalButton.MouseLeave
        NormalButton.Image = Background1
    End Sub
    Private NormalButtonClick As Boolean = False
    Private Sub NormalButton_MouseDownClick(sender As Object, e As MouseEventArgs) Handles NormalButton.MouseDown
        If mode = "Read" Then
        Else
            NormalButtonClick = True
        End If

    End Sub
    Private Sub NormalButton_MouseUpClick(sender As Object, e As MouseEventArgs) Handles NormalButton.MouseUp
        NormalButtonClick = False
    End Sub
    Private Sub NormalButton_MouseMove(sender As Object, e As MouseEventArgs) Handles NormalButton.MouseMove
        If NormalButtonClick Then
            Dim result = NormalButton.Location.X + e.X
            If result <= linear.Location.X Then
                result = linear.Location.X
            End If
            If result <= WarnButton1.Location.X + WarnButton1.Size.Width Then
                result = WarnButton1.Location.X + AlarmButton1.Size.Width
            End If
            If result >= WarnButton2.Location.X - WarnButton2.Size.Width Then
                result = WarnButton2.Location.X - WarnButton2.Size.Width
            End If

            If result >= linear.Location.X + linear.Size.Width - NormalButton.Size.Width Then
                result = linear.Location.X + linear.Size.Width - NormalButton.Size.Width
            End If
            NormalButton.Location = New Point(result, NormalButton.Location.Y)
            Dim indicatorsize = result - linear.Location.X
            NormalIndicator.Size = New Size(indicatorsize, NormalIndicator.Size.Height)

            Dim val1Percents As Double = NormalIndicator.Size.Width / (443 / 100)
            Dim val2 As Double = (maxValue / 100) * val1Percents

            val2 = Mid(val2.ToString, 1, 5)
            maxnoncrittresh.Text = converter(val2)
        End If
    End Sub
    '============================================================================================================
    '============================================================================================================
    Private Sub WarnButton2_MouseEnter(sender As Object, e As EventArgs) Handles WarnButton2.MouseEnter
        If mode = "Read" Then
            else
            WarnButton2.Image = im2
        End If

    End Sub
    Private Sub WarnButton2_MouseLeave(sender As Object, e As EventArgs) Handles WarnButton2.MouseLeave
        WarnButton2.Image = Background1
    End Sub
    Private WarnButton2Click As Boolean = False
    Private Sub WarnButton2_MouseDownClick(sender As Object, e As MouseEventArgs) Handles WarnButton2.MouseDown
        If mode = "Read" Then
        Else
            WarnButton2Click = True
        End If
    End Sub
    Private Sub WarnButton2_MouseUpClick(sender As Object, e As MouseEventArgs) Handles WarnButton2.MouseUp
        WarnButton2Click = False
    End Sub
    Private Sub WarnButton2_MouseMove(sender As Object, e As MouseEventArgs) Handles WarnButton2.MouseMove
        If WarnButton2Click Then
            Dim result = WarnButton2.Location.X + e.X
            If result <= linear.Location.X Then
                result = linear.Location.X
            End If

            If result <= NormalButton.Location.X + NormalButton.Size.Width Then
                result = NormalButton.Location.X + NormalButton.Size.Width
            End If

            If result >= linear.Location.X + linear.Size.Width - WarnButton2.Size.Width Then
                result = linear.Location.X + linear.Size.Width - WarnButton2.Size.Width
            End If
            WarnButton2.Location = New Point(result, WarnButton2.Location.Y)
            Dim indicatorsize = result - linear.Location.X
            WarnIndicator2.Size = New Size(indicatorsize, WarnIndicator2.Size.Height)

            Dim val1Percents As Double = WarnIndicator2.Size.Width / (443 / 100)
            Dim val2 As Double = (maxValue / 100) * val1Percents

            val2 = Mid(val2.ToString, 1, 5)
            maxcrittresh.Text = converter(val2)
        End If
    End Sub
    '============================================================================================================
    '============================================================================================================
    Private Sub mincrittresh_Leave(sender As Object, e As EventArgs) Handles mincrittresh.Leave
        If mincrittresh.Text = "" Then
            Exit Sub
        End If
        mincrittresh.Text = converter(mincrittresh.Text)
        If Convert.ToDouble(mincrittresh.Text) < 0 Then
            mincrittresh.Text = "0"
            setAlarm1("0")
        End If
        If Convert.ToDouble(mincrittresh.Text) >= Convert.ToDouble(minnoncrittresh.Text) Then
            mincrittresh.Text = Convert.ToDouble(minnoncrittresh.Text) - 0.14
            setAlarm1((Convert.ToDouble(mincrittresh.Text)) / (maxValue / 100))
        Else
            setAlarm1((Convert.ToDouble(mincrittresh.Text)) / (maxValue / 100))
        End If
    End Sub
    Private Sub minnoncrittresh_Leave(sender As Object, e As EventArgs) Handles minnoncrittresh.Leave
        If minnoncrittresh.Text = "" Then
            Exit Sub
        End If
        minnoncrittresh.Text = converter(minnoncrittresh.Text)
        If Convert.ToDouble(minnoncrittresh.Text) < Convert.ToDouble(mincrittresh.Text) Then
            minnoncrittresh.Text = Convert.ToDouble(mincrittresh.Text) + 0.14
            setWarn1((Convert.ToDouble(minnoncrittresh.Text)) / (maxValue / 100))
        End If
        If Convert.ToDouble(minnoncrittresh.Text) >= Convert.ToDouble(maxnoncrittresh.Text) Then
            minnoncrittresh.Text = Convert.ToDouble(maxnoncrittresh.Text) - 0.14
            setWarn1((Convert.ToDouble(minnoncrittresh.Text)) / (maxValue / 100))
        Else
            setWarn1((Convert.ToDouble(minnoncrittresh.Text)) / (maxValue / 100))
        End If
    End Sub
    Private Sub maxnoncrittresh_Leave(sender As Object, e As EventArgs) Handles maxnoncrittresh.Leave
        If maxnoncrittresh.Text = "" Then
            Exit Sub
        End If
        maxnoncrittresh.Text = converter(maxnoncrittresh.Text)
        If Convert.ToDouble(maxnoncrittresh.Text) < Convert.ToDouble(minnoncrittresh.Text) Then
            maxnoncrittresh.Text = Convert.ToDouble(minnoncrittresh.Text) + 0.14
            setNormal((Convert.ToInt16(maxnoncrittresh.Text)) / (maxValue / 100))
        End If
        If Convert.ToDouble(maxnoncrittresh.Text) >= Convert.ToDouble(maxcrittresh.Text) Then
            maxnoncrittresh.Text = Convert.ToDouble(maxcrittresh.Text) - 0.14
            setNormal((Convert.ToDouble(maxnoncrittresh.Text)) / (maxValue / 100))
        Else
            setNormal((Convert.ToDouble(maxnoncrittresh.Text)) / (maxValue / 100))
        End If
    End Sub
    Private Sub maxcrittresh_Leave(sender As Object, e As EventArgs) Handles maxcrittresh.Leave
        If maxcrittresh.Text = "" Then
            Exit Sub
        End If
        maxcrittresh.Text = converter(maxcrittresh.Text)
        If Convert.ToDouble(maxcrittresh.Text) < Convert.ToDouble(maxnoncrittresh.Text) Then
            maxcrittresh.Text = Convert.ToDouble(maxnoncrittresh.Text) + 0.14
            setWarn2((Convert.ToDouble(maxcrittresh.Text)) / (maxValue / 100))
        End If
        If Convert.ToDouble(maxcrittresh.Text) >= maxValue * 0.993 Then
            maxcrittresh.Text = maxValue * 0.993
            setWarn2((Convert.ToDouble(maxcrittresh.Text)) / (maxValue / 100))
        Else
            setWarn2((Convert.ToDouble(maxcrittresh.Text)) / (maxValue / 100))
        End If
    End Sub
    Private Function converter(input As String) As String
        If input.Length = 1 Then
            Return input + ",0"
        End If
        If input.Length = 2 Then
            Return input + ",0"
        End If
        If input.Length = 3 And input.IndexOf(",") = 1 Then
            Return input
        End If
        If input.Length = 4 And input.IndexOf(",") = 2 Then
            Return input
        End If
        If input.Length = 4 And input.IndexOf(",") = 1 Then
            Return Mid(input, 1, 3)
        End If
        If input.Length = 5 And input.IndexOf(",") = 2 Then
            Return Mid(input, 1, 4)
        End If
        Return input
    End Function


    Private Sub Minnoncrittresh_TextChanged(sender As Object, e As EventArgs) Handles minnoncrittresh.Leave
        Dim StrToInt As String = minnoncrittresh.Text
        StrToInt = StrToInt.Replace(".", ",")
        Dim StrToInt2 As Double = Convert.ToDouble(StrToInt)
        Dim percent As Double = StrToInt2 / (maxValue / 100)
        setWarn1(percent)
    End Sub

    Private Sub Maxnoncrittresh_TextChanged(sender As Object, e As EventArgs) Handles maxnoncrittresh.Leave
        Dim StrToInt As String = maxnoncrittresh.Text
        StrToInt = StrToInt.Replace(".", ",")
        Dim StrToInt2 As Double = Convert.ToDouble(StrToInt)
        Dim percent As Double = StrToInt2 / (maxValue / 100)
        setNormal(percent)
    End Sub

    Private Sub Mincrittresh_TextChanged(sender As Object, e As EventArgs) Handles mincrittresh.Leave
        Dim StrToInt As String = mincrittresh.Text
        StrToInt = StrToInt.Replace(".", ",")
        Dim StrToInt2 As Double = Convert.ToDouble(StrToInt)
        Dim percent As Double = StrToInt2 / (maxValue / 100)
        setAlarm1(percent)
    End Sub

    Private Sub Maxcrittresh_TextChanged(sender As Object, e As EventArgs) Handles maxcrittresh.Leave
        Dim StrToInt As String = maxcrittresh.Text
        StrToInt = StrToInt.Replace(".", ",")
        Dim StrToInt2 As Double = Convert.ToDouble(StrToInt)
        Dim percent As Double = StrToInt2 / (maxValue / 100)
        setWarn2(percent)
    End Sub

    Private Sub Scale_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Minnoncrittresh_TextChanged_1(sender As Object, e As EventArgs) Handles minnoncrittresh.TextChanged

    End Sub
End Class
