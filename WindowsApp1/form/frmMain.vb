
Imports WindowsApp1.CUtility
Public Class frmMain
    Private Const intTotalMonth As Integer = 12
    Private intA As Int16
    Dim objUI As New CUtility
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim blSSO As Boolean = False
        Dim intSSO As Integer
        If Me.chksso.Checked = True Then
            blSSO = True
            intSSO = Me.txtsso.Text
        Else
            blSSO = False
            intSSO = 0


        End If
        objUI.intSSO_RATE = intSSO
        objUI.blSSO_STATE = blSSO

        If Me.txtsalary.Text <> "" And Me.txtbonus.Text <> "" Then

            If IsNumeric(Me.txtsalary.Text) And IsNumeric(Me.txtbonus.Text) Then
                'calsalary(Me.txtsalary.Text, Me.txtbonus.Text)

                objUI.calsalary(Me.txtsalary.Text, Me.txtbonus.Text, Me.lblsalary, Me.lblSalarywithbonus, intTotalMonth)
            Else
                MsgBox("กรอกตัวเลข", MsgBoxStyle.Information, "ERROR !!!")

            End If
        Else
            MsgBox("กรุณากรอกข้อมูล", MsgBoxStyle.Critical, "ERROR !!!")
        End If
    End Sub

    'Sub calsalary(ByVal intSalary As Integer, ByVal intBonus As Integer)
    '    Dim IntTotalsalary As Integer = 0
    '    Dim IntTotalsalarywithbonus As Integer = 0

    '    Try
    '        If blSSO_STATE = True Then
    '            IntTotalsalary = (intSalary * )
    '        End If

    '        IntTotalsalary = intSalary * intTotalMonth
    '        IntTotalsalarywithbonus = IntTotalsalary * intBonus
    '        Me.lblsalary.Text = IntTotalsalary
    '        Me.lblSalarywithbonus.Text = IntTotalsalarywithbonus

    '    Catch ex As Exception
    '        MsgBox("Error")
    '    End Try
    'End Sub

    Private Sub CloseFormMain()
        Dim resp As MsgBoxResult
        Try

            resp = MessageBox.Show("ยืนยัน", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If resp = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseFormMain()
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = " โปรแกมคำนวนเงินเดือน" & " | ผู้ใช้งาน : " & userLogin
        If userLogin = "admin" Then
            Me.btncal.Enabled = True
        Else
            Me.btncal.Enabled = False
        End If
    End Sub
End Class