Imports MySql.Data.MySqlClient

Public Class MysqlConnect
    Public Shared objConn As New MySqlConnection()

    Public Shared Function OpenConnection() As MySqlConnection
        Dim strConnString As String
        Dim strServer As String = "122.155.190.34"
        Dim strUserDB As String = "root"
        Dim strDBname As String = "uhos"
        Dim strPasswordDB As String = "hi@2020"
        Dim intport As Integer = 3313

        strConnString = "Server=" & strServer & ";" &
                                  "Database=" & strDBname & ";" &
                                   "Uid=" & strUserDB & ";" &
                                  "Pwd=" & strPasswordDB & ";" &
                                  "Connect Timeout=1200;pooling=false;charset=tis620;port=" & intport & ";Convert Zero Datetime=True"

        Try
            With objConn

                If .State = ConnectionState.Closed Then
                    .ConnectionString = strConnString
                    .Open()
                End If

                Return objConn
            End With
        Catch ex As Exception
            Return Nothing

            MsgBox("Connect database Error", MsgBoxStyle.Critical)
        End Try

    End Function

    Public Shared Function _ExecuteNonQuery(ByVal strSql As String) As Boolean
        Dim cmd As New MySqlCommand()
        Try
            With cmd
                .CommandType = CommandType.Text
                .CommandTimeout = 0
                .CommandText = strSql
                .Connection = OpenConnection()
                .Prepare()
                Return .ExecuteScalar()
            End With

        Catch ex As Exception
            cmd.Connection.Close()
            Return Nothing

        End Try
    End Function

    Public Shared Function _ExecuteScalar(ByVal strSql As String) As Object
        Dim cmd As New MySqlCommand()
        Try
            With cmd
                .CommandType = CommandType.Text
                .CommandTimeout = 0
                .CommandText = strSql
                .Connection = OpenConnection()
                .Prepare()
                Return .ExecuteScalar()
            End With

        Catch ex As Exception
            cmd.Connection.Close()
            Return Nothing

        End Try
    End Function

    Public Shared Function _GetDataTable(ByVal strSql As String) As DataTable
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand()
        Dim datas As MySqlDataAdapter
        Try
            With cmd
                .CommandType = CommandType.Text
                .CommandTimeout = 0
                .CommandText = strSql
                .Connection = OpenConnection()
                .Prepare()

            End With

            datas = New MySqlDataAdapter(cmd)
            datas.Fill(dt)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt
                Else
                    Return Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("Error _GetDataTable() : " & ex.Message)
            cmd.Connection.Close()
            Return Nothing
        End Try
        Return Nothing
    End Function

End Class
