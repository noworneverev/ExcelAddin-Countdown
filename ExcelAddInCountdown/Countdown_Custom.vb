Public Class Countdown_Custom

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New Countdown_Custom_Form
        obj.YearPass = TextBox1.Text
        obj.MonthPass = TextBox2.Text
        obj.DayPass = TextBox3.Text
        obj.Show()
        Me.Hide()
        obj.BringToFront()



    End Sub


End Class
