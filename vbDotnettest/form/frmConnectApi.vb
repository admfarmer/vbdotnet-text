Imports WindowsApp1.ApiConnect

Public Class frmConnectApi
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtApi.TextChanged

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim dictData As New Dictionary(Of String, Object)
        dictData.Add("userName", "max")
        dictData.Add("userPassword", "max")
        Me.txtToken.Text = getToken(Me.txtApi.Text & "login", dictData)
    End Sub

    Private Sub bunGetinfo_Click(sender As Object, e As EventArgs) Handles bunGetinfo.Click
        getInfo()

    End Sub

    Private Sub getInfo()
        Dim strMethodType As String = "GET"
        Dim strRoute As String = "users/info"
        Dim dt As New DataTable
        dt = getDatafromAPI(Me.txtApi.Text, strRoute, strMethodType, Me.txtToken.Text)
        If dt.Rows.Count > 0 Then
            Me.DataGridView1.DataSource = dt
            Me.lblTotal.Text = dt.Rows.Count
        End If
    End Sub
End Class