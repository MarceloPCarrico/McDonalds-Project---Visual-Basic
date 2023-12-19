
Imports MySql.Data.MySqlClient


Public Class basededados
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"

        Try
            conn.Open()
            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter(TextBox1.Text, conn)
            adapter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try

    End Sub

    Private Sub basededados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.00.1;userid=root;password='yourpassword';database=mcdonalds"

        Try
            conn.Open()
            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter(TextBox1.Text, conn)
            adapter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()

        Catch ex As Exception
            MsgBox("Server não existente")
            conn.Close()

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=rot;password='yourpassword';database=mcdonalds"

        Try
            conn.Open()
            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter(TextBox1.Text, conn)
            adapter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()

        Catch ex As Exception
            MsgBox("User Id Errado")
            conn.Close()

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='yourpassword';database=mcdonalds"

        Try
            conn.Open()
            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter(TextBox1.Text, conn)
            adapter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()

        Catch ex As Exception
            MsgBox("Password errada")
            conn.Close()

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        SplashScreen1.ProgressBar1.Value = 0
        SplashScreen1.Show()
        SplashScreen1.Timer1.Start()



    End Sub
End Class