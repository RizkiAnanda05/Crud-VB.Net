Imports Mysql.Data.MySqlClient

Module Module1
    Dim connString As String
    Public MySQLReader As MySqlDataReader
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public myadapter As New MySqlDataAdapter
    Public datatable As New DataTable
    Public Sub koneksi()
        Dim server, username, password, dbname As String

        With My.Settings
            server = .DB_SERVER
            username = .DB_USER
            password = .DB_PASSWORD
            dbname = .DB_NAME
        End With

        connString = "server=" + server + ";user id=" + username + ";" &
            "password=" + password + ";" + "database=" + dbname
        conn.ConnectionString = connString

        Try
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
