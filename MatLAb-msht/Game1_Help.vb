Public Class Game1_Help
    Private Sub MQHelp_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "تعداد ارقام صحيح و اعشار را مشخص کنيد"
        Label2.Text = "نوع بازي و زمان را مشخص کنيد"
        Label3.Text = "براي تقسيم پاسخ با يک رقم اعشار کافيست"
        Label4.Text = "با همکاري پويا شريفي دانش آموز ششم دبستان بنياد امام صادق اصفهان واحد توحيد "
        Label5.Text = "MathPlay: by Majid and Pouya Sharifi-Tehrani (2021; 1400)"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Close()

    End Sub
End Class