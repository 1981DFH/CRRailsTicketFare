Public Class Form1
    Public Const BasicFare = 0.05861

    Dim SeatType As Integer, TrainType As Integer, AirCond As Integer
    Dim Dist
    Dim Inf As String




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("1981DFH编写，使用Visual Basic .NET制作 2024年", vbOKOnly + vbInformation, "作者信息")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TrainType = 1   REM 普客 
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TrainType = 2 REM 普快
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TrainType = 3 REM 快速
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        SeatType = 1 REM YZ
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        SeatType = 2 REM RZ 
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        SeatType = 11 REM YWS
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        SeatType = 12 REM YWZ
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        SeatType = 13 REM YWX
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        SeatType = 21 REM RWS
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        SeatType = 23 REM RWX
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        AirCond = 0
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        AirCond = 1
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        AirCond = 114514
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dist = TextBox1.Text
        REM 含递远递减的基本费率和票价区段的处理
        If 1 <= Dist < 200 Then
            Dist = Math.Floor(Dist / 10) * 10
        ElseIf 200 < Dist < 400 Then
            Dist = Math.Floor(Dist / 10) * 10 + 5
        ElseIf 400 < Dist < 700 Then
            Dist = Math.Floor(Dist / 10) * 10 + 10
        ElseIf 700 < Dist < 1100 Then
            Dist = Math.Floor(Dist / 10) * 10 + 15
        ElseIf 1100 < Dist < 1600 Then
            Dist = Math.Floor(Dist / 10) * 10 + 20
        ElseIf 1600 < Dist < 2200 Then
            Dist = Math.Floor(Dist / 10) * 10 + 25
        ElseIf 2200 < Dist < 2900 Then
            Dist = Math.Floor(Dist / 10) * 10 + 30
        ElseIf 2900 < Dist < 3700 Then
            Dist = Math.Floor(Dist / 10) * 10 + 35
        ElseIf 3700 < Dist < 4600 Then
            Dist = Math.Floor(Dist / 10) * 10 + 40
        ElseIf Dist > 4600 Then
            Dist = Math.Floor(Dist / 10) * 10 + 45
        End If
        Dim BasicPrice As Double
        BasicPrice = BasicFare * (0.75 * Dist - 0.05 * (Math.Abs(Dist - 200) + Math.Abs(Dist - 500) + Math.Abs(Dist - 1000) + Math.Abs(Dist - 1500) + Math.Abs(Dist - 2500)) + 285)
        BasicPrice = Math.Round(BasicPrice)

        REM 保险费
        Dim Ins As Double
        Ins = Math.Ceiling(Math.Max(BasicPrice, 1.1722) * 0.02 * 2) / 2

        REM 软席附加费
        Dim SoftPrice As Double
        If SeatType = 2 Or SeatType = 21 Or SeatType = 23 Then
            SoftPrice = BasicPrice
        Else
            SoftPrice = 0
        End If

        REM 总客票票价
        Dim SumPasPrice As Double
        SumPasPrice = BasicPrice + SoftPrice + Ins


        REM 杂费
        Dim OthFare As Single

        Dim ComTicketFare As Single
        If SumPasPrice <= 5 Then
            ComTicketFare = 0.5
        Else
            ComTicketFare = 1
        End If
        Dim WaitAirCond As Single
        If SeatType = 1 Or SeatType = 12 Or SeatType = 13 Then
            If Dist > 200 Then
                WaitAirCond = 1
            Else
                WaitAirCond = 0
            End If
        End If
        Dim SleeperBook
        If SeatType = 11 Or SeatType = 12 Or SeatType = 13 Or SeatType = 21 Or SeatType = 23 Then
            SleeperBook = 10
        Else
            SleeperBook = 0
        End If

        OthFare = ComTicketFare + WaitAirCond + SleeperBook


        REM 附加费计算
        Dim RapidF As Double
        If TrainType = 2 Then
            RapidF = 0.2 * Math.Max(BasicPrice, 5.861)
        ElseIf TrainType = 3 Then
            RapidF = 0.4 * Math.Max(BasicPrice, 5.861)
        Else
            RapidF = 0
        End If
        RapidF = Math.Round(RapidF)

        Dim AF As Double
        If AirCond <> 0 Then
            AF = BasicPrice * 0.25
        Else
            AF = 0
        End If
        AF = Math.Round(AF)

        Dim SleeperF As Double
        If SeatType = 11 Then
            SleeperF = Math.Max(BasicPrice, 23.444) * 1.1
        ElseIf SeatType = 12 Then
            SleeperF = Math.Max(BasicPrice, 23.444) * 1.2
        ElseIf SeatType = 13 Then
            SleeperF = Math.Max(BasicPrice, 23.444) * 1.3
        ElseIf SeatType = 21 Then
            SleeperF = Math.Max(BasicPrice, 23.444) * 1.75
        ElseIf SeatType = 23 Then
            SleeperF = Math.Max(BasicPrice, 23.444) * 1.95
        Else
            SleeperF = 0
        End If
        SleeperF = Math.Round(SleeperF)

        Dim SUMF
        SUMF = SleeperF + AF + RapidF

        REM 新空调的处理和综合计算
        Dim NAirCPCT
        If AirCond = 114514 Then
            NAirCPCT = 0.5
        Else
            NAirCPCT = 0
        End If


        Dim SUMPRICE
        SUMPRICE = (BasicPrice + SoftPrice + Ins + SUMF) * (1 + NAirCPCT) + OthFare - Ins
        SUMPRICE = Math.Round(SUMPRICE * 2) / 2
        Dim ChildP
        ChildP = (BasicPrice * 0.5 + SoftPrice * 0.5 + Ins * 0.5 + SleeperF + AF * 0.5 + 0.5 * RapidF) * (1 + NAirCPCT) + OthFare * 0.5 - 0.5 * Ins
        REM 输出
        SUMPRICE = NumericUpDown1.Value * SUMPRICE + NumericUpDown2.Value * ChildP
        Label9.Text = SUMPRICE
    End Sub
End Class