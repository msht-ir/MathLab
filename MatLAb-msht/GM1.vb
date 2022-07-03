Public Class GM1
    'Program flowchart :  DoPrepare - DoStart - AskQ - DoAnswer - ShowResults
    Public Ex, strQ As String
    Public A, B, C As Double
    Public Q, nQ, i1, i2, d1, d2 As Integer     'Q=TotalQuestions , nQ=Q(i)
    Public T, Tr, nCorrect, nWrong As Integer
    Public Clck, Timex, TimerMode As Integer
    Public TimeOver As Boolean
    Public ShowAllinText As Boolean
    Public Ans, myAnsw As Double
    Public strAns As String                     'Print Answer (as string) to file 
    Public strDigits As String                  'show digits as aa.bb
    Public R As Double                          'Percent of correct answers

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoPrepare()
    End Sub


    Private Sub cmdStart_All_Click(sender As Object, e As EventArgs) Handles cmdStart_All.Click
        DoPrepare()
        DoStart()
        ShowAllinText = True

        My.Computer.FileSystem.WriteAllText(strFlnm, "SHOW ALL QUESTIONS w/o ANSWERS" & vbCrLf & vbCrLf, True)
        While nQ < Q
            AskQ()
            My.Computer.FileSystem.WriteAllText(strFlnm, vbCrLf & vbCrLf, True)
        End While
        ShowResult()
        Exit Sub

    End Sub



    Private Sub DoPrepare()
        Timer1.Enabled = False
        TimeOver = False

        TextBox_i1.Enabled = True
        TextBox_d1.Enabled = True
        TextBox_i2.Enabled = True
        TextBox_d2.Enabled = True
        TextBox_q.Enabled = True
        Text_Time.Enabled = True
        GroupBox1.Enabled = True
        cmdStart.Enabled = True
        Button_Answer.Enabled = False
        TextBox_Answ.Enabled = False
        cmdHelp.Enabled = True

        TextBox_q.Select()
        TextBox_Answ.Text = ""
        Label3.Text = "Operators"
        Label7.Text = "."
        Label8.Text = "."
    End Sub


    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        DoStart()
        ShowAllinText = False
        AskQ()
    End Sub
    Private Sub DoStart()
        'START
        strDigits = ""
        If Val(Text_Time.Text) > 0 Then
            TimerMode = 2
            Clck = Val(Text_Time.Text)
            Timex = Val(Text_Time.Text)
        Else
            TimerMode = 1
            Clck = 0
        End If
        TimeOver = False
        nCorrect = 0
        nWrong = 0
        nQ = 0
        i1 = Val(TextBox_i1.Text)
        d1 = Val(TextBox_d1.Text)
        i2 = Val(TextBox_i2.Text)
        d2 = Val(TextBox_d2.Text)

        Q = Val(TextBox_q.Text)
        If Q = 0 Then
            TextBox_q.Select()
            Exit Sub
        End If

        If RadioButton1.Checked = True Then
            T = 1 : Ex = " + "
        ElseIf RadioButton2.Checked = True Then
            T = 2 : Ex = " - "
        ElseIf RadioButton3.Checked = True Then
            T = 3 : Ex = " x "
        ElseIf RadioButton4.Checked = True Then
            T = 4 : Ex = " / "
        ElseIf RadioButton5.Checked = True Then
            T = 5 : Ex = " ? "
        End If

        TextBox_i1.Enabled = False
        TextBox_d1.Enabled = False
        TextBox_i2.Enabled = False
        TextBox_d2.Enabled = False
        TextBox_q.Enabled = False
        Text_Time.Enabled = False
        GroupBox1.Enabled = False
        cmdStart.Enabled = False
        Button_Answer.Enabled = True
        TextBox_Answ.Enabled = True
        cmdHelp.Enabled = False

        For i = 1 To i1 : strDigits = strDigits & "a" : Next i
        strDigits = strDigits & "."
        For i = 1 To d1 : strDigits = strDigits & "a" : Next i
        strDigits = strDigits & Ex
        For i = 1 To i2 : strDigits = strDigits & "b" : Next i
        strDigits = strDigits & "."
        For i = 1 To d2 : strDigits = strDigits & "b" : Next i
        My.Computer.FileSystem.WriteAllText(strFlnm, "********************************************  " & PlayerName & vbCrLf & strDigits & vbCrLf, True)
        Timer1.Enabled = True
        Me.AcceptButton = Button_Answer


    End Sub


    Sub AskQ()
        'ASK
lbl_Ask_1:
        Randomize()
        A = Int(10 ^ (i1 + d1) * Rnd(1)) / (10 ^ d1)
        B = Int(10 ^ (i2 + d2) * Rnd(1)) / (10 ^ d2)
        If A = 0 Or B = 0 Then GoTo lbl_Ask_1
        If A < B Then C = A : A = B : B = C

        'Show Question
        Select Case T
            Case 1 : strQ = A & Ex & B : Label3.Text = strQ : Ans = A + B : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True) : Tr = T
            Case 2 : strQ = A & Ex & B : Label3.Text = strQ : Ans = A - B : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True) : Tr = T
            Case 3 : strQ = A & Ex & B : Label3.Text = strQ : Ans = A * B : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True) : Tr = T
            Case 4 : strQ = A & Ex & B : Label3.Text = strQ : Ans = Int(10 * A / B) / 10 : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True) : Tr = T
            Case 5
                Tr = Int(4 * Rnd(1)) + 1
                Select Case Tr
                    Case 1 : strQ = A & " + " & B : Label3.Text = strQ : Ans = A + B : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True)
                    Case 2 : strQ = A & " - " & B : Label3.Text = strQ : Ans = A - B : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True)
                    Case 3 : strQ = A & " x " & B : Label3.Text = strQ : Ans = A * B : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True)
                    Case 4 : strQ = A & " / " & B : Label3.Text = strQ : Ans = Int(10 * A / B) / 10 : My.Computer.FileSystem.WriteAllText(strFlnm, "Q" & nQ + 1 & ": " & strQ, True)
                End Select
        End Select
        nQ = nQ + 1
        Label7.Text = "Q: " & nQ
        TextBox_Answ.Select()
        TextBox_Answ.Text = ""

    End Sub


    Private Sub Button_Answer_Click(sender As Object, e As EventArgs) Handles Button_Answer.Click
        DoAnswer()
    End Sub
    Sub DoAnswer()

        If LCase(Trim(TextBox_Answ.Text)) = "quit" Or LCase(Trim(TextBox_Answ.Text)) = "exit" Then DoPrepare()
        myAnsw = Val(TextBox_Answ.Text)
        If TimeOver = True Then
            ShowResult()
            Exit Sub
        End If
        If Trim(TextBox_Answ.Text) = "" Then Exit Sub

        strAns = " -> " & myAnsw
        If Math.Abs(myAnsw - Ans) < 0.0000001 Then
            nCorrect = nCorrect + 1
            strAns = strAns & " (correct)"
        Else
            nWrong = nWrong + 1
            strAns = strAns & " (wrong!)         (Ans:" & Ans & ")"
        End If
        My.Computer.FileSystem.WriteAllText(strFlnm, strAns & vbCrLf, True)

        If nQ = Q Then
            ShowResult()
            Exit Sub
        Else
            If Not TimeOver Then
                AskQ()
            Else
                Exit Sub
            End If
        End If

    End Sub


    Sub ShowResult()
        'Show Result
        Timer1.Enabled = False
        TextBox_Answ.Text = ""

        If ShowAllinText = True Then
            My.Computer.FileSystem.WriteAllText(strFlnm, vbCrLf & "Dedicated Time: " & Timex & "s" & vbCrLf & vbCrLf, True)
        Else
            R = Int(10000 * nCorrect / Q) / 100
            Select Case TimerMode
                Case 1 'Free Time
                    My.Computer.FileSystem.WriteAllText(strFlnm, vbCrLf & nCorrect & "/" & Q & " (" & R & " %)" & vbCrLf & "Time: " & Int(Clck * 10) / 10 & "s" & vbCrLf & vbCrLf, True)
                Case 2 'Limited Time
                    My.Computer.FileSystem.WriteAllText(strFlnm, vbCrLf & nCorrect & "/" & Q & " (" & R & " %)" & vbCrLf & "Time: " & Timex - Int(Clck * 10) / 10 & "/" & Timex & "s  (saved: " & Int(Clck * 10) / 10 & "s)" & vbCrLf & vbCrLf, True)
            End Select
        End If
        Process.Start(strFlnm)
        DoPrepare()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If TimerMode = 1 Then
            Clck = Clck + 1
        Else
            Clck = Clck - 1
        End If

        Label8.Text = Clck
        If TimerMode = 2 And Clck <= 0 Then
            TimeOver = True
            Timer1.Enabled = False
            My.Computer.FileSystem.WriteAllText(strFlnm, vbCrLf, True)
        End If

    End Sub


    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Game1_Help.ShowDialog()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        FrmMenu.Show()
        Me.Close()

    End Sub
End Class

