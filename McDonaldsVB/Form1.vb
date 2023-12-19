Imports MySql.Data.MySqlClient

Public Class Form1

    '-------------Codigo para poder fazer login ao carregar em Enter em vez do botão login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        roundcorners(Me)
        AddHandler txt_user.KeyDown, AddressOf TextBox_KeyDown
        AddHandler txt_password.KeyDown, AddressOf TextBox_KeyDown


    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Login() ' Call your login function
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Login()
        Dim connectionString As String = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"

        Using conn As New MySqlConnection(connectionString)
            ' Verificação se user existe
            Dim query As String = "SELECT COUNT(*) FROM contas WHERE username=@username AND passwords=@password"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txt_user.Text)
                cmd.Parameters.AddWithValue("@password", txt_password.Text)

                conn.Open()

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count = 1 Then
                    ' Login realizado
                    MessageBox.Show("Login realizado!", "Login")
                    Me.Close()
                    Form3.Show()

                Else
                    ' Login falhou
                    MessageBox.Show("User ou password errados!", "Login falhou.")
                End If

                conn.Close()
            End Using
        End Using
    End Sub
    '-----------------------------------------------------

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connectionString As String = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"

        Using conn As New MySqlConnection(connectionString)
            ' Verificação se user existe
            Dim query As String = "SELECT COUNT(*) FROM contas WHERE username=@username AND passwords=@password"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txt_user.Text)
                cmd.Parameters.AddWithValue("@password", txt_password.Text)

                conn.Open()

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count = 1 Then
                    ' Login realizado
                    MessageBox.Show("Login realizado!", "Login")


                    Form3.Show()
                    Me.Close()

                Else
                    ' Login falhou
                    MessageBox.Show("User ou password errados!", "Login falhou.")
                End If

                conn.Close()
            End Using
        End Using



    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        AboutBox1.Show()

    End Sub
End Class
