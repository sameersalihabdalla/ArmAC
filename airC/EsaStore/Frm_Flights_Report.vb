Imports System.Net.Security
Imports System.Windows.Forms

Public Class Frm_Flights_Report
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            myconect_pool()
            Dim d1, d2
            d1 = Format(DateTimePicker1.Value, "yyy-MM-dd")

            d2 = Format(DateTimePicker2.Value, "yyy-MM-dd")

            Dim searchqry As String = "select * from tbl_flights where flight_date >= '" & d1 & "' and flight_date<='" & d2 & "' order by flight_id"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)

            'DataGridView1.DataSource = table
            Dim rp As New Rep_flights

            rp.DataSourceConnections.Clear()
            Rep_flights1.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = "Flights Report"
            rp.SummaryInfo.ReportComments = "_______________________________"
            rp.SummaryInfo.ReportAuthor = "Flights From : " & d1 & " To : " & d2

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_Flights_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = Nothing

        If Me.lbl_operation.Text <> "" Then
            Me.GroupBox1.Visible = False

            Try

                myconect_pool()
                Dim searchqry As String = "select * from tbl_flights where flight_number = '" & Me.lbl_operation.Text & "'"

                Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
                Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)

                'DataGridView1.DataSource = table
                Dim rp As New Rep_flights

                rp.DataSourceConnections.Clear()
                Rep_flights1.SetDataSource(table)
                rp.SummaryInfo.ReportTitle = "Flights Report"
                rp.SummaryInfo.ReportComments = "_______________________________"

                rp.SetDataSource(table)
                rp.Refresh()
                CrystalReportViewer1.ReportSource = rp

                Me.CrystalReportViewer1.Refresh()
            Catch ex As Exception

            End Try


            Me.lbl_operation.Text = ""
        Else
            Me.GroupBox1.Visible = True

        End If
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
