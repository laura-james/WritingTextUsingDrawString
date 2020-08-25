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
        MsgBox(InterfaceColors.MistyRose)
        Iterate()
    End Sub

    REM Trying out Enums
    'https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/enum-statement
    Public Enum InterfaceColors
        MistyRose = &HE1E4FF&
        SlateGray = &H908070&
        DodgerBlue = &HFF901E&
        DeepSkyBlue = &HFFBF00&
        SpringGreen = &H7FFF00&
        ForestGreen = &H228B22&
        Goldenrod = &H20A5DA&
        Firebrick = &H2222B2&
    End Enum
    Enum EggSizeEnum
        Jumbo
        ExtraLarge
        Large
        Medium
        Small
    End Enum

    Public Sub Iterate()
        Dim names = [Enum].GetNames(GetType(EggSizeEnum))
        For Each n In names
            Console.Write(n & " ")
        Next
        Console.WriteLine()
        ' Output: Jumbo ExtraLarge Large Medium Small 

        Dim values = [Enum].GetValues(GetType(EggSizeEnum))
        For Each value In values
            Console.Write(value & " ")
        Next
        Console.WriteLine()
        ' Output: 0 1 2 3 4 
    End Sub
    REM Downloading powerpacks
    'https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2013/cc488277(v=vs.120)
End Class
