Public Class AboutPanel
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new")
    End Sub
End Class