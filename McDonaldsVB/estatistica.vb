Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Public Class estatistica
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_totalv.TextChanged

    End Sub

    Private Sub txt_maxmin_TextChanged(sender As Object, e As EventArgs) Handles txt_vpedidos.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_tpedidos.TextChanged



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()

            Using cmd As New MySqlCommand("SELECT SUM(valor) FROM faturas;", conn)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Dim total As Double = Convert.ToDouble(result)
                    txt_totalv.Text = total.ToString() & "€"
                Else

                    txt_totalv.Text = "0€"
                End If
            End Using

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbl_maximo.Text = max
        lbl_valormedio.Text = medio
        lbl_valor_minimo.Text = min
    End Sub

    Private Sub cmd_media_Click(sender As Object, e As EventArgs) Handles cmd_media.Click
        Dim connectionString As String = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()

            Using cmd As New MySqlCommand("SELECT avg(valor) FROM faturas;", conn)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Dim total As Double = Convert.ToDouble(result)
                    txt_media.Text = total.ToString() & "€"
                Else

                    txt_totalv.Text = "0€"
                End If
            End Using

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Hide()
        faturaPedido.Hide()
        basededados.Show()


    End Sub



    Private Sub estatistica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class