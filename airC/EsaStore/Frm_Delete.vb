Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Frm_Delete
    Public id As Integer



    Private Sub Frm_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsernameTextBox.Text = username


        Dim sql As String = "select flight_id from  tbl_flights where flight_number ='" & Me.lbl_operation.Text & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        Try
            myconect_pool()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Console.Beep(3000, 100)
            Exit Sub
        End Try

        Try
            dReader = cmd.ExecuteReader()

            If dReader.Read Then
                id = dReader(0)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        trace("try Delete Flight  : Username is :" & username)


        Dim sql As String = "select*from  tbl_users_data where username='" & Me.UsernameTextBox.Text & "' and password='" & GetHash(Me.PasswordTextBox.Text.ToString) & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        Try
            myconect_pool()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Console.Beep(3000, 100)
            Exit Sub
        End Try


        Try
            dReader = cmd.ExecuteReader()
            If dReader.Read Then
                dReader.Close()


                Dim sql2 As String = "delete from tbl_flights where flight_id='" & id & "'"
                Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()



                Dim sql3 As String = "delete from tbl_parts_log where flight_id='" & id & "'"
                Dim cmd3 As New MySql.Data.MySqlClient.MySqlCommand(sql3, con)
                cmd3.ExecuteNonQuery()
                cmd3.Dispose()



                MsgBox("Flight data has been Deleted", vbInformation)

                FrmFixing.Show()
                con.Close()
                id = 0
                Me.Close()
            Else
                MsgBox("Please Enter Correct Password To Delete Important Data", MsgBoxStyle.Critical)

            End If

        Catch ex As Exception
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class
