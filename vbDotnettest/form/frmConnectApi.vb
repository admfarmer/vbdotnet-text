Imports WindowsApp1.ApiConnect
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmConnectApi
    Dim dt As New DataTable
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtApi.TextChanged

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        loadToken()
        loadClear()
    End Sub

    Private Sub loadToken()
        Dim dictData As New Dictionary(Of String, Object)
        dictData.Add("userName", "max")
        dictData.Add("userPassword", "max")
        Me.txtToken.Text = getToken(Me.txtApi.Text & "login", dictData)
    End Sub


    Private Sub bunGetinfo_Click(sender As Object, e As EventArgs) Handles bunGetinfo.Click
        getInfo()
        loadClear()
    End Sub

    Private Sub getInfo()
        Dim strMethodType As String = "GET"
        Dim strRoute As String = "users/info"

        dt = getDatafromAPI(Me.txtApi.Text, strRoute, strMethodType, Me.txtToken.Text)
        If dt.Rows.Count > 0 Then
            Me.DataGridView1.DataSource = dt
            Me.lblTotal.Text = dt.Rows.Count
        End If
    End Sub


    Private Sub frmConnectApi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadToken()
        getInfo()
        loadClear()
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Dim user As String = Me.txtUser.Text
        Dim userPassword As String = Me.txtpassword.Text
        Dim userFullname As String = Me.txtFullname.Text
        Dim userCid As String = Me.txtCID.Text
        Dim userRolebase As String = Me.txtRole.Text
        Dim userStatus As String = Me.txtStatus.Text

        ' add data to Dictionary
        Dim dictData As New Dictionary(Of String, Object)
        dictData.Add("userName", user)
        dictData.Add("userPassword", userPassword)
        dictData.Add("userFullname", userFullname)
        dictData.Add("userCid", userCid)
        dictData.Add("userRolebase", userRolebase)
        dictData.Add("userStatus", userStatus)

        Dim strMethodType As String = "POST"
        Dim strRoute As String = "users/insert"

        addDataToAPI(Me.txtApi.Text,
                                        Me.txtToken.Text,
                                        strRoute,
                                        strMethodType,
                                        dictData)
        loadClear()
        getInfo()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            Me.btnUpdate.Enabled = True
            Me.btnDelete.Enabled = True

            Me.txtID.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            Me.txtUser.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            Me.txtpassword.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()

            Me.txtFullname.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            Me.txtCID.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Me.txtRole.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            Me.txtStatus.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateUser()
        getInfo()
        loadClear()

    End Sub

    Private Sub updateUser()
        Dim user As String = Me.txtUser.Text
        Dim userPassword As String = Me.txtpassword.Text
        Dim userFullname As String = Me.txtFullname.Text
        Dim userCid As String = Me.txtCID.Text
        Dim userRolebase As String = Me.txtRole.Text
        Dim userStatus As String = Me.txtStatus.Text
        Dim dictData As New Dictionary(Of String, Object)

        Dim strMethodType As String = "PUT"
        Dim strRoute As String = "users/update/"
        Try

            dictData.Add("userName", user)
            dictData.Add("userPassword", userPassword)
            dictData.Add("userFullname", userFullname)
            dictData.Add("userCid", userCid)
            dictData.Add("userRolebase", userRolebase)
            dictData.Add("userStatus", userStatus)

            If updateDataToAPI(Me.txtApi.Text,
                                 Me.txtToken.Text,
                                     strRoute,
                                 strMethodType,
                                  dictData,
                               Me.txtID.Text) = True Then

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub loadClear()
        Me.txtID.Text = ""
        Me.txtUser.Text = ""
        Me.txtpassword.Text = ""
        Me.txtFullname.Text = ""
        Me.txtCID.Text = ""
        Me.txtRole.Text = ""
        Me.txtStatus.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim strRoute As String = "users/delete/"

            If deleleteDataToAPI(Me.txtApi.Text, Me.txtToken.Text, strRoute, Me.txtID.Text) = True Then
                Me.getInfo()
                loadClear()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click

        Dim query As String = Me.txtQuery.Text

        Dim dictData As New Dictionary(Of String, Object)

        dictData.Add("query", query)

        Dim strMethodType As String = "POST"
        Dim strRoute As String = "users/user_query"
        Dim dt As New DataTable
        dt = queryDataAPI(Me.txtApi.Text, Me.txtToken.Text, strRoute, strMethodType, dictData)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            Me.DataGridView1.DataSource = dt
            Me.lblTotal.Text = dt.Rows.Count
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        printreport()
    End Sub

    Private Sub printreport()
        Try



            Dim fprint As New frmReport
            fprint.pdt = dt
            fprint.Show()



        Catch ex As Exception

        End Try
    End Sub


End Class