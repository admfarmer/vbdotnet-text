Imports WindowsApp1.CUtility
Public Class frmlogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtUser.Focus()
    End Sub




    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            Me.txtPassword.Focus()

        End If
    End Sub



    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            Me.btnlogin.Focus()

        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If Me.checknot_emty() = True Then


            Dim f As New frmmain
            f.Show()
        End If
    End Sub
    Function checknot_emty() As Boolean
        Try

            If Me.txtUser.Text <> "" And Me.txtPassword.Text <> "" Then
                userLogin = Me.txtUser.Text
                Return True
                'Me.txtUser.Focus()
            Else
                MsgBox("กรอกข้อมูลให้ครับด้วยค่ะ", 1, "ERROR !!!")
                Return False

            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseFormMain()
    End Sub
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
End Class
