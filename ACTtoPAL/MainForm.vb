Public Class MainForm

    Private Sub Form_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter, Label1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Form_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop, Label1.DragDrop
        DropFile = CType(e.Data.GetData(DataFormats.FileDrop), String())
        ConvertPaL(DropFile(0))
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Text = "Done!"
        Timer.Interval = 2000
        Timer.Enabled = True
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Label1.ForeColor = Color.Black
        Label1.Text = "Drag and Drop ACT File"
        Timer.Enabled = False
    End Sub

    Private Sub Form_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
