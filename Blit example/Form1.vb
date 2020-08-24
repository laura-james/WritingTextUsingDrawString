Public Class Form1

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.DrawString("This writes text on form paint",
        New Font("Courier New", 20), Brushes.Firebrick, 0, 0)
        ' MyBase.OnPaint(e)
    End Sub

    'A gloabl variable to store the position
    Dim pos As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pos = pos + 10
        Dim g = Me.CreateGraphics
        g.DrawString("Hello world!", New Font("Times New Roman", pos), Brushes.DarkGray, pos, 0)

    End Sub


End Class
