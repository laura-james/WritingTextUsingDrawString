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

    REM Trying out Structures
    Structure Book
        Dim title As String
        Dim releaseYear As Integer
        Dim author As String

    End Structure

    Dim Hobbit As New Book

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hobbit.title = "The Hobbit"
        Hobbit.author = "JRR Tolkein"
        Hobbit.releaseYear = "1950"
        MsgBox(Hobbit.title)
    End Sub
End Class
