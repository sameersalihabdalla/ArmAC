Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmFixing



    Private Sub FrmFixing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_parts"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader






        dReader = cmd.ExecuteReader()
        Me.ProgressBar1.Maximum = dReader.FieldCount + 1
        Dim counter = 0
        Do While dReader.Read = True
            Dim myid = dReader(0)
            Dim mypartnumber = dReader(1)
            Dim mypartname = dReader(2)
            Dim myaircraftid = dReader(5)

            Me.DataGridView1.Rows.Add(dReader(0), dReader(2), dReader(1), dReader(5))



            'End If
            Me.ProgressBar1.Value = counter
            counter = counter + 1


        Loop
        dReader.Close()

        con.Close()



        Dim dgv As DataGridView = Me.DataGridView1

        For i As Integer = 0 To dgv.Rows.Count - 1

            '   MsgBox(dgv.Rows(i).Cells(1).Value.ToString)

            Dim newsql As String = "SELECT
    

     SUM(`using_time`) AS using_time
FROM
    `acdb`.`tbl_parts_log`
    
WHERE( 
part_id=" & Val(dgv.Rows(i).Cells(0).Value) & "
AND
part_number ='" & dgv.Rows(i).Cells(1).Value.ToString & "'
AND
aircraft_id =" & Val(dgv.Rows(i).Cells(3).Value) & "
AND
part_name ='" & dgv.Rows(i).Cells(2).Value & "'
)
;
"
            If con.State = ConnectionState.Open Then con.Close()
            Try
                myconect_pool()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show("حدث خطأ ما في الاتصال")
                Exit Sub
            End Try
            Dim myusingtime As Double = 0
            Dim newcmd As New MySql.Data.MySqlClient.MySqlCommand(newsql, con)
            Dim newdReader As MySqlDataReader
            newdReader = newcmd.ExecuteReader()
            If newdReader.Read() Then
                myusingtime = Val(newdReader(0).ToString)
            End If

            newdReader.Dispose()
            con.Close()



            Dim updatecmd As New MySqlCommand
            Dim result As Integer
            Dim updatesql As String = "update  tbl_parts  set `using_time`='" & myusingtime & "'" & " where id = '" & Val(dgv.Rows(i).Cells(0).Value) & "'"

            If con.State = ConnectionState.Open Then con.Close()
            Try
                myconect_pool()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show("حدث خطأ ما في الاتصال")
                Exit Sub
            End Try
            With updatecmd
                .Connection = con
                .CommandText = updatesql
            End With

            result = updatecmd.ExecuteNonQuery

            con.Close()


        Next
        MsgBox("Operation Done")
        Me.Close()

    End Sub
End Class
