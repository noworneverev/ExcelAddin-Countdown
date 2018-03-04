Public Class Countdown_Custom_Form
    Public Property YearPass As String
    Public Property MonthPass As String
    Public Property DayPass As String
    Private Sub Countdown_Custom_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Parsetime As String = YearPass & "-" & MonthPass & "-" & DayPass & " " & "18:00"


        Dim startdate As DateTime = DateTime.Parse(Date.Now)
        Dim enddate As DateTime = DateTime.Parse(Parsetime)
        Dim ts As TimeSpan = enddate.Subtract(startdate)


        If ts.Seconds <= 0 And ts.Minutes <= 0 And ts.Days <= 0 Then
            Label1.Text = "0" & " 天 " & "0" & " 時 " & vbCrLf & "0" & " 分 " & "0" & " 秒！"
            Timer1.Enabled = False
            MsgBox("恭喜你已登出",, "離職成功")
        Else
            Label1.Text = CStr(ts.Days) & " 天 " & CStr(ts.Hours) & " 時 " & vbCrLf & CStr(ts.Minutes) & " 分 " & CStr(ts.Seconds) & " 秒！"
        End If
    End Sub


End Class