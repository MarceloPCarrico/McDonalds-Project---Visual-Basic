Imports Mysqlx.XDevAPI.Relational
Imports System.Drawing.Printing

Public Class faturaPedido

    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Dim FontDialog1 As New FontDialog()

    Sub abrir()
        Dim abreF As New OpenFileDialog
        abreF.Filter = "txt files (*.txt)|*.txt"
        abreF.FilterIndex = 2
        abreF.RestoreDirectory = False

        If abreF.ShowDialog() = DialogResult.OK Then
            TextBox1.Clear()
            txtboxNome.Text = IO.File.ReadAllText(abreF.FileName)
        End If
    End Sub

    Sub guardar()
        Dim guardaF As New SaveFileDialog
        guardaF.Filter = "txt files (*.txt)|*.txt"
        guardaF.FilterIndex = 2
        guardaF.RestoreDirectory = False

        If guardaF.ShowDialog() = DialogResult.OK Then

            IO.File.WriteAllText(guardaF.FileName, "Pedido nº" & TextBox1.Text & vbCrLf & txtboxNome.Text & lbl_total.Text)

        End If
    End Sub

    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
    End Sub

    Private Sub cmd_open_Click(sender As Object, e As EventArgs) Handles cmd_open.Click
        abrir()
    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        guardar()
    End Sub

    Private Sub cmd_print_Click(sender As Object, e As EventArgs) Handles cmd_print.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bm, New Rectangle(0, 0, Me.Width, Me.Height))

        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub faturaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtboxNome_TextChanged(sender As Object, e As EventArgs) Handles txtboxNome.TextChanged

    End Sub

    Private Sub lbl_total_Click(sender As Object, e As EventArgs) Handles lbl_total.Click

    End Sub
End Class