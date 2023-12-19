Public NotInheritable Class SplashScreen1


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        roundcorners(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 4
        Else
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
