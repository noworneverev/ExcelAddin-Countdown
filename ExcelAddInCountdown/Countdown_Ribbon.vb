Imports Microsoft.Office.Tools.Ribbon

Public Class Countdown_Ribbon

    Private Sub Countdown_Ribbon_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click
        Dim f As Countdown_Form = New Countdown_Form()
        f.Show()
        f.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click
        Dim f As Countdown7 = New Countdown7()
        f.Show()
        f.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As RibbonControlEventArgs) Handles Button3.Click
        Dim f As Countdown_Custom = New Countdown_Custom()
        f.Show()
        f.BringToFront()
    End Sub
End Class
