Public Class CUtility
    Public Shared userLogin As String
    Public intSSO_RATE As Integer
    Public blSSO_STATE As Boolean
    Public Sub calSalary(ByVal intSalary As Integer, ByVal intBonus As Integer,
                         ByVal objSalary As Label,
                         ByVal objSalarywithBonus As Label,
                         ByVal intTotalMonth As Integer)
        Dim intTotalSalary As Integer = 0
        Dim intTotalSalarywithBonus As Integer = 0


        Try
            If blSSO_STATE = True Then
                '******* หัก ปกส
                intTotalSalary = (intSalary * intTotalMonth)
                intTotalSalary = intTotalSalary / intSSO_RATE

                intTotalSalarywithBonus = intTotalSalary * intBonus
            Else
                ' ********** ไม่หัก
                intTotalSalary = (intSalary * intTotalMonth)
                intTotalSalarywithBonus = intTotalSalary * intBonus


            End If


            objSalary.Text = intTotalSalary
            objSalarywithBonus.Text = intTotalSalarywithBonus
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical)
        End Try

        calSalary2()

    End Sub

    Shared Sub calSalary2()
        Dim intTotalSalary As Integer = 0
        Dim intTotalSalarywithBonus As Integer = 0



    End Sub


End Class