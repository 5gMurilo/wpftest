Imports MySql.Data.MySqlClient
Class MainWindow
    Private Sub buttonLogin_Click(sender As Object, e As RoutedEventArgs) Handles buttonLogin.Click
        Dim conn As New MySqlConnection
        Dim myCommand As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql As String

        conn.ConnectionString = "server=localhost;user=root;password=America_Rental;database=americarental;port=3306"

        sql = $"SELECT nome_usuario, senha FROM users WHERE nome_usuario = '{txt_username.Text}' AND senha = '{txt_password.Text}'"

        Try
            conn.Open()
            myCommand = New MySqlCommand(sql, conn)

            If txt_username.Text.Length.Equals(0) Or txt_password.Text.Length.Equals(0) Then
                MsgBox("Você deve inserir o nome de usuário e senha para prosseguir")
            Else
                reader = myCommand.ExecuteReader()

                If reader.Read() Then
                    MsgBox($"Bem-vindo {reader.GetString(0)}!")
                    'home.Show()
                    'Me.Hide()
                Else
                    MsgBox("Usuário ou senha estão incorretos, verifique suas credenciais!", 0, "Erro!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
