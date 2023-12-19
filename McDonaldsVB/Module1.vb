Imports MySql.Data.MySqlClient

Module Module1

    Public labeltotal As Double = 0
    Public total As Double = 0
    Public max, medio, min, p As Double


    Public Sub roundcorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None

        Dim dgp As New Drawing2D.GraphicsPath
        dgp.StartFigure()

        'Canto sup esquerdo
        dgp.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        dgp.AddLine(40, 0, obj.Width - 40, 0)
        'Canto sup direito
        dgp.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        dgp.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)
        'Canto inferior direito
        dgp.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        dgp.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)
        'Canto inferior esquerdo
        dgp.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        dgp.CloseFigure()

        obj.Region = New Region(dgp)

    End Sub



End Module
