Public Class GM2
    Public A, B, F1, F2, x1, x2 As Integer
    Public intLevel, intFrom, intTo As Integer
    Public tmpx As String
    Public Ex, strQ As String
    Public Q, nQ As Integer     'Q:TotalQuestions nQ:Q(i)
    Public T, Tr, nCorrect, nWrong As Integer
    Public TimeOver As Boolean
    Public Ans, myAnsw As Double
    Public strAns As String                     'Print Answer (as string) to file 
    Public strDigits As String                  'show digits as aa.bb
    Public R As Double                          'Percent of correct answers
    Public Clck, Timex, TimerMode As Integer
    Public i As Integer

    Private Sub GM2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoPrepareGame2()
        nCorrect = 0
        nWrong = 0

    End Sub

    Sub DoPrepareGame2()
        Timer2.Enabled = False
        Label8.Text = "."
        Label7.Text = "."
        For i = 1 To 4
            tmpx = "L" & Trim(Str(i))
            Me.Controls(tmpx).Text = "-"
        Next i
        TxtAnsw.Text = "?"
        nQ = 0
        Q = Int(Val(txtQ.Text))
        Timex = Int(Val(Text_Time.Text))
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        DoPrepareGame2()

        tmpx = "********************************************  " & PlayerName & vbCrLf
        tmpx = tmpx & "Questions: " & Q & "  Level: " & txtLevel.Text & "  Time: "
        If Timex > 0 Then
            tmpx = tmpx & Timex & " *" & Q & " =" & Timex * Q & vbCrLf
        Else
            tmpx = tmpx & " unlimited" & vbCrLf
        End If

        My.Computer.FileSystem.WriteAllText(strFlnm, tmpx, True)
        DoAskGame2()

    End Sub

    Sub DoAskGame2()
        If nQ >= Q Then
            DoPrepareGame2()
            ShowStats()
            Exit Sub
        End If

        Label8.Text = "."
        GenRandomElements()
        L1.Text = A
        For i = 2 To 4
            Select Case F1 + F2
                Case 13 : B = (A + x1) * x2
                Case 23 : B = (A - x1) * x2
                Case 31 : B = (A * x1) + x2
                Case 32 : B = (A * x1) - x2
            End Select
            tmpx = "L" & Trim(Str(i)) : Me.Controls(tmpx).Text = B
            A = B
        Next i
        Select Case F1 + F2
            Case 13 : Ans = (A + x1) * x2
            Case 23 : Ans = (A - x1) * x2
            Case 31 : Ans = (A * x1) + x2
            Case 32 : Ans = (A * x1) - x2
        End Select
        nQ = nQ + 1
        Label7.Text = nQ
        TxtAnsw.Text = ""
        TxtAnsw.Select()
        Me.AcceptButton = cmd_Answ
        If Int(Val(Text_Time.Text)) = 0 Then
            TimerMode = 1
            Clck = 0
        Else
            TimerMode = 2
            Clck = Int(Val(Text_Time.Text))
        End If
        Timer2.Enabled = True
    End Sub

    Sub GenRandomElements()
        intLevel = Int(Val(txtLevel.Text))
        If intLevel > 3 Then intLevel = 3
        Select Case intLevel
            Case 1 : intFrom = 2 : intTo = 5
            Case 2 : intFrom = 2 : intTo = 7
            Case 3 : intFrom = 3 : intTo = 10
        End Select
        Randomize() : A = Int((intTo - intFrom + 1) * Rnd() + intFrom) ' (U - L + 1) * RND() + L    U=10, L=2
        Randomize() : x1 = Int((intTo - intFrom + 1) * Rnd() + intFrom)
        Randomize() : x2 = Int((intTo - intFrom + 1) * Rnd() + intFrom)
        Randomize() : F1 = Int(3 * Rnd() + 1) * 10 ' 10:+ 20:- 30:*
        Select Case F1
            Case 10, 20 : F2 = 3 ' 3:*
            Case 30 : Randomize() : F2 = Int(2 * Rnd() + 1) ' 1:+ 2:-
        End Select

    End Sub

    Private Sub cmd_Answ_Click(sender As Object, e As EventArgs) Handles cmd_Answ.Click
        Timer2.Enabled = False
        DopPrintAnswer()
        myAnsw = Int(Val(TxtAnsw.Text))
        tmpx = "YourAnsw: " & TxtAnsw.Text
        If myAnsw = Ans Then
            nCorrect = nCorrect + 1
            tmpx = tmpx & " (Correct!)"
        Else
            nWrong = nWrong + 1
            tmpx = tmpx & " (WRONG!)"
        End If

        If TimerMode = 1 Then 'FreeTime
            tmpx = tmpx & " Time: " & Clck
        Else 'CountDown Timer
            tmpx = tmpx & " Time: (" & Timex - Clck & "/" & Timex & ")"
        End If
        My.Computer.FileSystem.WriteAllText(strFlnm, tmpx & vbCrLf, True)

        DoAskGame2()
    End Sub

    Private Sub DopPrintAnswer()
        tmpx = "Q" & nQ & ": "
        Select Case F1 + F2
            Case 13 : tmpx = tmpx + "(N +" & x1 & ") *" & x2
            Case 23 : tmpx = tmpx + "(N -" & x1 & ") *" & x2
            Case 23 : tmpx = tmpx + "(N -" & x1 & ") *" & x2
            Case 31 : tmpx = tmpx + "(N *" & x1 & ") +" & x2
            Case 32 : tmpx = tmpx + "(N *" & x1 & ") -" & x2
        End Select
        tmpx = tmpx & " : " & L1.Text & ", " & L2.Text & ", " & L3.Text & ", " & L4.Text & "   >   " & Ans & "  "
        My.Computer.FileSystem.WriteAllText(strFlnm, tmpx, True)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If TimerMode = 1 Then
            Clck = Clck + 1
        Else 'TimerMode = 2
            Clck = Clck - 1
        End If
        Label8.Text = Clck

        If TimerMode = 2 And Clck <= 0 Then
            TimeOver = True
            Timer2.Enabled = False
            DopPrintAnswer()
            My.Computer.FileSystem.WriteAllText(strFlnm, "YourAnsw:- (TimeOver!)" & vbCrLf, True)
            If nQ >= Q Then
                ShowStats()
                DoPrepareGame2()
            Else
                DoAskGame2()
            End If
        End If
    End Sub
    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Timer2.Enabled = False
        Select Case F1 + F2
            Case 13 : tmpx = "(N +" & x1 & ") *" & x2
            Case 23 : tmpx = "(N -" & x1 & ") *" & x2
            Case 23 : tmpx = "(N -" & x1 & ") *" & x2
            Case 31 : tmpx = "(N *" & x1 & ") +" & x2
            Case 32 : tmpx = "(N *" & x1 & ") -" & x2
        End Select
        tmpx = tmpx & " : " & L1.Text & ", " & L2.Text & ", " & L3.Text & ", " & L4.Text & "   >   " & Ans
        MsgBox(tmpx)

        DopPrintAnswer()
        My.Computer.FileSystem.WriteAllText(strFlnm, " *** help" & vbCrLf, True)
        DoAskGame2()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        FrmMenu.Show()
        Me.Close()

    End Sub
    Public Sub ShowStats()
        R = Int(10000 * nCorrect / Q) / 100
        My.Computer.FileSystem.WriteAllText(strFlnm, vbCrLf & nCorrect & "/" & Q & " (" & R & " %)", True)
        Process.Start(strFlnm)

    End Sub
End Class