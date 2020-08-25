Imports System.Math
Public Class Lines


    Private Sub Lines_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint


        'instantiate a new pen object using the color structure


        'draw the line on the form using the pen object
        ' e.Graphics.DrawLine(myPen, 100, 150, 150, 100)
        drawstar(200, 200, 150, e, 10, 5, Color.Blue)
        drawstar(500, 300, 70, e, 30, 3, Color.Azure)
        drawstar(100, 400, 50, e, 15, 4, Color.DarkGoldenrod)

        For i = 1 To 10
            drawstar(Rnd() * 400, Rnd() * 400, 70, e, 30, 3, Color.Gainsboro)
        Next
    End Sub
    Dim myPen As Pen
    Sub drawstar(x As Integer, y As Integer, r As Integer, e As Object, mystep As Integer, width As Integer, mycolor As Color)
        Dim convert As Double = 180 / Math.PI
        Dim x2, y2, rand, pos As Integer

        myPen = New Pen(mycolor, width)
        For i = 0 To 360 Step mystep
            'calc random wobble
            Randomize()
            rand = Rnd() * r / 5 'wobble will be the fifth of teh radius
            pos = Rnd()
            If pos = 1 Then
                rand = rand * -1
            End If
            Debug.WriteLine(rand)
            x2 = Math.Cos(i * convert) * r + x + rand
            y2 = Math.Sin(i * convert) * r + y + rand
            e.Graphics.DrawLine(myPen, x, y, x2, y2)
            e.Graphics.DrawEllipse(myPen, x2, y2, CInt(r / 20), CInt(r / 20))

        Next
    End Sub



End Class