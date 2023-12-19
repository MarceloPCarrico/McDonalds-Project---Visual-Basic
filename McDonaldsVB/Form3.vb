Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Form3

    Dim pedidos As Integer = ultimopedido()



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundcorners(Me)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End

    End Sub






    Private Sub lbl_dia_Click(sender As Object, e As EventArgs) Handles lbl_dia.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        faturaPedido.Show()
        faturaPedido.TextBox1.Text = pedidos + 1



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        pic_cbo.Show()
        pic_bigmac.Show()
        pic_crispy.Show()
        pic_wrap.Hide()
        pic_royal.Hide()
        pic_happy.Hide()
        lbl_pcbo.Show()
        lbl_pbigmac.Show()
        lbl_pcrispy.Show()

        Label3.Enabled = False
        Label2.Enabled = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        pic_cbo.Hide()
        pic_bigmac.Hide()
        pic_crispy.Hide()
        pic_wrap.Show()
        pic_royal.Show()
        pic_happy.Show()
        lbl_pcbo.Hide()
        lbl_pbigmac.Hide()
        lbl_pcrispy.Hide()
        Label2.Enabled = False
        Label3.Enabled = True
        Label3.Show()
    End Sub

    Private Sub pic_wrap_Click(sender As Object, e As EventArgs) Handles pic_wrap.Click

        faturaPedido.txtboxNome.AppendText("Wrap" & Environment.NewLine)
        faturaPedido.txtBoxQuantidade.AppendText("1" & Environment.NewLine)
        faturaPedido.txtboxPreco.AppendText("3,20" & Environment.NewLine)


    End Sub

    Private Sub pic_royal_Click(sender As Object, e As EventArgs) Handles pic_royal.Click
        faturaPedido.txtboxNome.AppendText("Mc Royal" & Environment.NewLine)
        faturaPedido.txtBoxQuantidade.AppendText("1" & Environment.NewLine)
        faturaPedido.txtboxPreco.AppendText("6,50" & Environment.NewLine)

    End Sub

    Private Sub pic_happy_Click(sender As Object, e As EventArgs) Handles pic_happy.Click
        faturaPedido.txtboxNome.AppendText("Happy Meal" & Environment.NewLine)
        faturaPedido.txtBoxQuantidade.AppendText("1" & Environment.NewLine)
        faturaPedido.txtboxPreco.AppendText("4,95" & Environment.NewLine)
    End Sub

    Private Sub pic_cbo_Click(sender As Object, e As EventArgs) Handles pic_cbo.Click
        faturaPedido.txtboxNome.AppendText("CBO" & Environment.NewLine)
        faturaPedido.txtBoxQuantidade.AppendText("1" & Environment.NewLine)
        faturaPedido.txtboxPreco.AppendText("7,60" & Environment.NewLine)
    End Sub

    Private Sub pic_bigmac_Click(sender As Object, e As EventArgs) Handles pic_bigmac.Click
        faturaPedido.txtboxNome.AppendText("Big Mac" & Environment.NewLine)
        faturaPedido.txtBoxQuantidade.AppendText("1" & Environment.NewLine)
        faturaPedido.txtboxPreco.AppendText("5,70" & Environment.NewLine)
    End Sub

    Private Sub pic_crispy_Click(sender As Object, e As EventArgs) Handles pic_crispy.Click
        faturaPedido.txtboxNome.AppendText("Mc Crispy" & Environment.NewLine)
        faturaPedido.txtBoxQuantidade.AppendText("1" & Environment.NewLine)
        faturaPedido.txtboxPreco.AppendText("8,
30" & Environment.NewLine)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        estatistica.Show()

    End Sub
    '---Função para actualizar a var Pedidos, de modo a ter continuidade aoós fechar o form
    Function ultimopedido() As Integer
        Dim maxID As Integer = 0

        Dim connectionString As String = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim query As String = "SELECT MAX(id_fatura) FROM faturas"
            Using cmd As New MySqlCommand(query, conn)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    maxID = Convert.ToInt32(result)
                End If
            End Using

            conn.Close()
        End Using

        Return maxID

    End Function
    '--
    Private Sub Roundbutton2_Click(sender As Object, e As EventArgs) Handles Roundbutton2.Click

        Dim values As String() = faturaPedido.txtboxPreco.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim sum As Double

        For Each value As String In values
            Dim number As Double
            If Double.TryParse(value.Trim(), number) Then
                sum += number

            End If
        Next

        faturaPedido.lbl_total.Text = sum.ToString("F2") & "€"
        faturaPedido.TextBox1.Text = pedidos + 1
        estatistica.txt_vpedidos.AppendText(faturaPedido.lbl_total.Text & Environment.NewLine)
        estatistica.txt_tpedidos.Text = faturaPedido.TextBox1.Text
        labeltotal = sum.ToString("F2") & "€"
        total = (labeltotal + total).ToString("F2")


        pedidos = pedidos + 1


        '----- Udate das variaveis para valor Maior, 2º Maior e 3º Maior
        If labeltotal > max Then
            min = medio
            medio = max
            max = labeltotal
        ElseIf labeltotal > medio Then
            min = medio
            medio = labeltotal
        ElseIf labeltotal < medio Then
            min = labeltotal
        End If

        '----- Inserção de valores de pedidos na BD


        Dim connectionString As String = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"
        Dim conn As New MySqlConnection(connectionString)


        Try
            conn.Open()

            Using cmd As New MySqlCommand("INSERT INTO faturas (id_fatura, valor) VALUES (@idFatura,@valorTotal)", conn)
                cmd.Parameters.AddWithValue("@idFatura", faturaPedido.TextBox1.Text)
                cmd.Parameters.AddWithValue("@valorTotal", faturaPedido.lbl_total.Text)
                cmd.ExecuteNonQuery() ' Insere os dados na base de dados


                conn.Close()


            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try

        '-----

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        faturaPedido.TextBox1.Clear()
        faturaPedido.txtboxNome.Clear()
        faturaPedido.txtBoxQuantidade.Clear()
        faturaPedido.txtboxPreco.Clear()
        faturaPedido.lbl_total.Text = "--,--€"
    End Sub

    Private Sub lbl_pcbo_Click(sender As Object, e As EventArgs) Handles lbl_pcbo.Click

    End Sub
End Class