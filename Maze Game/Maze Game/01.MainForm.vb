Public Class MainForm
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        If Label1.Text > 0 Then
            Label1.Text = ("00")
        End If
        Timer1.Enabled = True
        AboutPanel.Close()
        Game1.TopLevel = False
        Game1.TopMost = True
        Me.Panel1.Controls.Add(Game1)
        Game1.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Timer1.Stop()
        MsgBox("1. Choose your Path." & vbCrLf & "2. To win move your cursor towards 'Finish'." & vbCrLf & "3. If your cursor touches any wall or boundary then your cursor will be moved at 'Starting Point'.")
        If Label1.Text > 0 Then
            Label1.Text = ("00")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Timer1.Stop()
        Game1.Close()
        AboutPanel.TopLevel = False
        AboutPanel.TopMost = True
        Me.Panel1.Controls.Add(AboutPanel)
        AboutPanel.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Game1.Close()
        AboutPanel.Close()
        Timer1.Stop()
        If Label1.Text > 0 Then
            Label1.Text = ("00")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Val(Label1.Text) + 1
        If Label1.Text = 0 Then Timer1.Enabled = False
    End Sub
End Class
