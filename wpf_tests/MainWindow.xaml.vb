Imports MySql.Data.MySqlClient
Class MainWindow
    Dim conn As MySqlConnection

    Private Sub txt_username_OnFocus() Handles txt_username.GotFocus
        MsgBox("Você focou a textBox", 0, "Oba!")

    End Sub
End Class
