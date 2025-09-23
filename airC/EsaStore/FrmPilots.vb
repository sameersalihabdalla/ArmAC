Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmPilots



    Sub loading_full_data()
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_pilots"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader





        dReader = cmd.ExecuteReader()
        Do While dReader.Read = True
            Me.DataGridView1.Rows.Add(dReader(0), dReader(1))
        Loop
        dReader.Close()

        con.Close()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)


    End Sub


    Sub fill_mydata()
        Try
            With Me.DataGridView1.CurrentRow
                Me.aircraft_id.Text = .Cells(0).Value
                Me.txt_aircaft_name.Text = .Cells(1).Value
                Me.GroupBox2.Text = "Current  Pilot" & .Cells(1).Value


            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub clearing_fields()
        Me.aircraft_id.Text = ""
        Me.txt_aircaft_name.Text = ""

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clearing_fields()
        fill_mydata()

    End Sub





    Private Sub txt_user_id_TextChanged(sender As Object, e As EventArgs) Handles aircraft_id.TextChanged
        If aircraft_id.Text = "" Then
            btn_edit.Enabled = False
            btn_delete.Enabled = False
        Else
            btn_edit.Enabled = True
            btn_delete.Enabled = True


        End If
    End Sub









    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        trace("Try Add new Pilot to list by :" & username)

        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_cancel.Enabled = True
        Me.txt_aircaft_name.Focus()
        Me.txt_aircaft_name.Enabled = True

    End Sub

    Private Sub cactive_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        myconect_pool()
        trace("Try To Save new Pilot by :" & username)

        If Me.txt_aircaft_name.Text = "" Then
            MsgBox("Enter Pilot Name")
            Exit Sub
        End If

        Try


            If aircraft_id.Text = "" And btn_save.Text = "Save" Then

                Dim cmd As New MySqlCommand
                Dim result As Integer
                Dim sql As String = "insert tbl_Pilots(
    `Pilot_name`)  values
('" & Me.txt_aircaft_name.Text & "')"
                cmd.Connection = con
                cmd.CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data Does Not Saved")


                Else

                    MsgBox(" Data Has Been Saved Succeffuly")


                    btn_add.Enabled = True
                    btn_save.Enabled = False
                    btn_save.Text = "Save"
                    btn_cancel.Enabled = False
                    Me.DataGridView1.Rows.Clear()
                    Me.aircraft_id.Enabled = False
                    Me.txt_aircaft_name.Enabled = False
                    Me.DataGridView1.Enabled = True
                    clearing_fields()
                    con.Close()
                    loading_full_data()

                End If
            End If



        Catch ex As Exception

        End Try








    End Sub

    Private Sub FrmAirCrafts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "Save"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txt_aircaft_name.Enabled = False
        trace("Open Pilot Screen by :" & username)
        loading_full_data()
    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        trace("Try to Edit Pilot from List by " & username)
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_delete.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_save.Text = "Save Edit"
        trace("Try Edit Pilots List by" & username)
        Me.btn_cancel.Enabled = True
        Me.txt_aircaft_name.Enabled = True


    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "Save"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()


        loading_full_data()
    End Sub
End Class
