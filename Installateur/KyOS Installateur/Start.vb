Public Class Start
    Private Sub ThemeTimer_Tick(sender As Object, e As EventArgs) Handles ThemeTimer.Tick
        If ThemeBtn.Checked = True Then
            Me.BackColor = Color.FromArgb(64, 64, 64)
            KyOSIL.ForeColor = Color.White
            CloseInstall.ForeColor = Color.White
            ThemeT.ForeColor = Color.White
        Else
            Me.BackColor = Color.WhiteSmoke
            KyOSIL.ForeColor = Color.FromArgb(64, 64, 64)
            CloseInstall.ForeColor = Color.FromArgb(64, 64, 64)
            ThemeT.ForeColor = Color.FromArgb(64, 64, 64)
        End If
    End Sub

    Private Sub CloseInstall_Click(sender As Object, e As EventArgs) Handles CloseInstall.Click
        Close()
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeTimer.Start()
    End Sub
End Class