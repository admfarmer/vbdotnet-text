Public Class frmDatatable
    Dim dtPerson As DataTable = New DataTable()
    Dim blnValue As Boolean


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub frmDatatable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createTable()

    End Sub

    Private Sub createTable()
        Try
            dtPerson.Columns.Add("id", GetType(Integer))
            dtPerson.Columns.Add("HN", GetType(Integer))
            dtPerson.Columns.Add("Fname", GetType(String))
            dtPerson.Columns.Add("Lname", GetType(String))
            dtPerson.Columns.Add("CID", GetType(String))
            Me.DataGridView1.DataSource = dtPerson
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Save()
        Try
            dtPerson.Rows.Add(0, Me.txtHn.Text, Me.txtName.Text, Me.txtLastName.Text, Me.txtCid.Text)
            Me.DataGridView1.DataSource = dtPerson
            Me.Label5.Text = dtPerson.Rows.Count
            viewGrid()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
        addComboBox()

        Me.txtHn.Text = ""
        Me.txtName.Text = ""
        Me.txtLastName.Text = ""
        Me.txtCid.Text = ""
    End Sub

    Private Sub viewGrid()
        Try
            Dim j As Int16 = 1
            Dim dr As DataRow
            For i As Int16 = 0 To dtPerson.Rows.Count - 1
                dr = dtPerson.Rows(i)
                dr("id") = j
                j = j + 1

                dtPerson.AcceptChanges()
            Next
            Me.DataGridView1.DataSource = dtPerson
            Me.Label5.Text = dtPerson.Rows.Count
            drgFormat()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub drgFormat()


        If Me.DataGridView1.ColumnCount > 0 Then
            Me.DataGridView1.Columns(0).HeaderText = "No."
            Me.DataGridView1.Columns(1).HeaderText = "HN"
            Me.DataGridView1.Columns(2).HeaderText = "ชื่อ"
            Me.DataGridView1.Columns(3).HeaderText = "นามสกุล"
            Me.DataGridView1.Columns(4).HeaderText = "เลขบัตร"

            Me.DataGridView1.Columns(0).Width = 80
            Me.DataGridView1.Columns(1).Width = 100
            Me.DataGridView1.Columns(2).Width = 150
            Me.DataGridView1.Columns(3).Width = 200
            Me.DataGridView1.Columns(4).Width = 200
            If Me.DataGridView1.RowCount > 0 Then
                For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                    If blnValue = False Then
                        ' Me.drgINV.Rows(i).DefaultCellStyle.BackColor = Color.Black
                        Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
                        blnValue = True
                    Else
                        blnValue = False
                        Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
                    End If

                Next

            End If
            blnValue = False
        End If



    End Sub

    Private Sub addComboBox()
        Try

            If Not dtPerson Is Nothing AndAlso
                dtPerson.Rows.Count > 0 Then

                Me.cbbHn.DataSource = dtPerson
                Me.cbbHn.DisplayMember = "HN"
                Me.cbbHn.ValueMember = "HN"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub searchData()
        Try
            Dim dtTemp As DataTable
            dtTemp = dtPerson.Select("Fname like '" & Me.txtSearch.Text & "%'").CopyToDataTable
            Me.DataGridView1.DataSource = dtTemp
            Me.drgFormat()
        Catch ex As Exception

        End Try
    End Sub

    Dim strClickValue As String
    Dim intIndex As Integer

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        searchData()

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            intIndex = e.RowIndex
            strClickValue = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString

        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim resp As MsgBoxResult
            resp = MessageBox.Show("ยืนยัน", "ต้องการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            If resp = MsgBoxResult.Yes Then
                dtPerson.Rows.Remove(dtPerson.Rows(intIndex))
                Me.viewGrid()
            End If


        End If
    End Sub
End Class