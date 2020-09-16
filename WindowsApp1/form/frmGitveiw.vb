Imports WindowsApp1.MysqlConnect
Public Class frmGitveiw
    Private strClickValue As String
    Dim strTable As String = "cdep"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub insertdb()
        Try
            Dim strFields As String
            Dim strValues As String
            Dim strdepcode As String = Me.txtCode.Text
            Dim strdepname As String = Me.txtName.Text
            If strdepcode <> "" And strdepname <> "" Then
                Dim strSql As String = ""
                strFields = "dep_code,dep_name"
                strValues = "'" & strdepcode & "','" & strdepname & "'"
                strSql = "insert into " & strTable & "(" & strFields & ") values (" & strValues & ")"
                _ExecuteNonQuery(strSql)
            Else
                Me.txtCode.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub updatedb()
        Try
            Dim strSQL As String = ""
            strSQL = "UPDATE " & strTable &
                " SET dep_name='" & Me.txtName.Text & "' " &
            " WHERE dep_code='" & strClickValue & "'"
            '// บันทึกลงฐานข้อมูล
            _ExecuteNonQuery(strSQL)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deletedb()
        Try
            Dim strSQL As String = ""
            strSQL = "DELETE FROM   " & strTable &
            " WHERE dep_code='" & strClickValue & "'"
            '// บันทึกลงฐานข้อมูล
            _ExecuteNonQuery(strSQL)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub searchdb()
        Dim dt As New DataTable
        Try
            Dim strSql As String
            strSql = "select * from cdep ORDER BY dep_code"
            dt = _GetDataTable(strSql)
            If Not dt Is Nothing Then
                Me.dtCdep.DataSource = dt
                Me.lblTotal.Text = dt.Rows.Count
            End If
            Me.txtCode.Text = ""
            Me.txtName.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Me.btnSearch.Enabled = False
        Me.insertdb()
        Me.searchdb()

        Me.btnSearch.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.btnSearch.Enabled = False
        Me.updatedb()
        Me.searchdb()
        Me.btnSearch.Enabled = True
        Me.txtCode.Enabled = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.btnSearch.Enabled = False
        Me.deletedb()
        Me.searchdb()
        Me.btnSearch.Enabled = True
        Me.txtCode.Enabled = True

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.btnSearch.Enabled = False
        Me.searchdb()
        Me.btnSearch.Enabled = True
    End Sub

    Private Sub dtCdep_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCdep.CellClick
        Me.btnInsert.Enabled = False

        Try
            If e.RowIndex > -1 Then
                ' intIndex = e.RowIndex
                Me.txtCode.Enabled = False
                strClickValue = Me.dtCdep.Rows(e.RowIndex).Cells(0).Value.ToString()
                Me.txtCode.Text = Me.dtCdep.Rows(e.RowIndex).Cells(0).Value.ToString()
                Me.txtName.Text = Me.dtCdep.Rows(e.RowIndex).Cells(1).Value.ToString()
            End If

        Catch ex As Exception
            MsgBox("Error DataGridView1_CellClick")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.btnSearch.Enabled = True
        Me.btnInsert.Enabled = True
        Me.txtCode.Enabled = True

        Me.txtCode.Text = ""
        Me.txtName.Text = ""
    End Sub
End Class