Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form2

    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundcorners(Me)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Roundbutton1_Click(sender As Object, e As EventArgs) Handles Roundbutton1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"
        Dim username As String = txt_user.Text.Trim()
        Dim passwords As String = txt_pwd.Text.Trim()
        Dim nome As String = txt_nome.Text.Trim()
        Dim morada As String = txt_morada.Text.Trim()
        Dim contato As Integer = txt_tlf.Text.Trim()
        Dim email As String = txt_email.Text.Trim()

        ' validaçao de user existente
        Dim userExists As Boolean = False

        Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM contas WHERE username=@username OR email=@email", conn)
            checkCmd.Parameters.AddWithValue("@username", txt_user.Text)
            checkCmd.Parameters.AddWithValue("@email", txt_email.Text)

            conn.Open()

            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If count > 0 Then
                userExists = True
            End If

            conn.Close()
        End Using

        If userExists Then
            MessageBox.Show("Username não dispinível", "Error")
        Else
            Try
                conn.Open()


                Using cmd As New MySqlCommand("INSERT INTO contas (username, passwords, nome, morada, contato, email) VALUES (@username, @passwords, @nome, @morada, @contato, @email)", conn)
                    cmd.Parameters.AddWithValue("@username", txt_user.Text)
                    cmd.Parameters.AddWithValue("@passwords", txt_pwd.Text)
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
                    cmd.Parameters.AddWithValue("@morada", txt_morada.Text)
                    cmd.Parameters.AddWithValue("@contato", txt_tlf.Text)
                    cmd.Parameters.AddWithValue("@email", txt_email.Text)

                    cmd.ExecuteNonQuery() ' Insere os dados na base de dados

                    MessageBox.Show("User Registado", "Registo efetuado")
                    conn.Close()
                    Me.Close()
                    Form1.Show()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()

            End Try




            conn.Close()

        End If















    End Sub

    Private Sub txt_morada_TextChanged(sender As Object, e As EventArgs) Handles txt_morada.TextChanged

    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub
End Class