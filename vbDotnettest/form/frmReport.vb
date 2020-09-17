Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports WindowsApp1.Report_Users
Public Class frmReport
    Public Pdt As DataTable
    Dim rpt As ReportDocument

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()

    End Sub

    Private Sub LoadReport()

        Dim ds As DataSet = New DataSet()
        Dim dt As DataTable = Nothing

        Try

            dt = New DataTable
            dt = Pdt


            If Not dt Is Nothing Then

                dt.TableName = "hiwin_users"
                ds.Tables.Add(dt)

                rpt = New Report_Users
                rpt.SetDataSource(ds)
                ds.Dispose()
                Me.CrystalReportViewer1.ReportSource = Nothing
                Me.CrystalReportViewer1.ReportSource = rpt
            End If


        Catch ex As Exception

            rpt.Dispose()
            ds.Dispose()
            MsgBox("Error print Report.", MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
End Class