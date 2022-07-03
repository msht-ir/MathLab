Public Class FrmMenu

    Private Sub cmdGame1_Click(sender As Object, e As EventArgs) Handles cmdGame1.Click
        setPlayer()
        GM1.Show()
        Me.Close()

    End Sub

    Private Sub cmdGame2_Click(sender As Object, e As EventArgs) Handles cmdGame2.Click
        setPlayer()
        GM2.Show()
        Me.Close()
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        MsgBox("MathGames program written by M&PSHT", vbInformation, "MathGames")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'setPlayer()
        'GM3.Show()
        'Me.Close()

    End Sub
    Private Sub setPlayer()
        PlayerName = Trim(TextBox_n.Text)
        strFlnm = "D:\MathPlay_" & PlayerName & ".txt"

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PlayerName = "" Then PlayerName = "Player"
        TextBox_n.Text = PlayerName

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End

    End Sub
End Class