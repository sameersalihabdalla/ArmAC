Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmAirCrafts



    Sub loading_full_data()
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_aircraft"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader





        dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                Me.DataGridView1.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4))
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
                Me.GroupBox2.Text = "Current Aircraft " & .Cells(1).Value
                Me.txt_aircraft_model.Text = .Cells(2).Value
                Me.txt_description.Text = .Cells(3).Value
                Me.cactive.Checked = .Cells(4).Value

            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub clearing_fields()
        Me.aircraft_id.Text = ""
        Me.txt_aircaft_name.Text = ""
        Me.txt_aircraft_model.Text = ""
        Me.txt_description.Text = ""
        Me.cactive.Checked = False
        Me.max_hours.Value = 0
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
        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Enabled = False
        Me.max_hours.Enabled = True
        Me.btn_add.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_cancel.Enabled = True
        Me.txt_aircaft_name.Focus()
        Me.txt_aircaft_name.Enabled = True
        Me.txt_aircraft_model.Enabled = True
        Me.txt_description.Enabled = True
        Me.cactive.Enabled = True
        Me.max_hours.Enabled = True

    End Sub

    Private Sub cactive_CheckedChanged(sender As Object, e As EventArgs) Handles cactive.CheckedChanged

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        myconect_pool()

        If Me.txt_aircaft_name.Text = "" Then
            MsgBox("Enter Airctaft Type")
            Exit Sub
        End If
        If Me.txt_aircraft_model.Text = "" Then
            MsgBox("Enter Aircraf Number")
            Exit Sub

        End If
        Try


            If aircraft_id.Text = "" And btn_save.Text = "Save" Then

                Dim cmd As New MySqlCommand
                Dim result As Integer
                Dim sql As String = "insert tbl_aircraft(
    `aircraft_type`
    , `aircraft_number`
    , `aircraft_summary`
    , `aircraft_maximum_flying_hours`
    , `aircraft_is_active`)  values
('" & Me.txt_aircaft_name.Text & "', '" & Me.txt_aircraft_model.Text & "' ,'" & Me.txt_description.Text & "','" & Me.max_hours.Value & "'," & Me.cactive.CheckState & ")"
                cmd.Connection = con
                cmd.CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data Does Not Saved")


                Else

                    MsgBox("Aircraft Dara Has Been Saved Succeffuly")


                    btn_add.Enabled = True
                    btn_save.Enabled = False
                    btn_save.Text = "Save"
                    btn_cancel.Enabled = False
                    Me.DataGridView1.Rows.Clear()
                    Me.aircraft_id.Enabled = False
                    Me.txt_aircaft_name.Enabled = False
                    Me.txt_aircraft_model.Enabled = False
                    Me.cactive.Enabled = False
                    Me.txt_description.Enabled = False
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
        Me.txt_aircraft_model.Enabled = False
        Me.txt_description.Enabled = False
        Me.cactive.Enabled = False
        loading_full_data()
    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_delete.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_save.Text = "Save Edit"

        Me.btn_cancel.Enabled = True
        Me.txt_aircaft_name.Enabled = True
        Me.txt_aircraft_model.Enabled = True
        Me.txt_description.Enabled = True

        Me.cactive.Enabled = True

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "Save"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.cactive.Enabled = False
        Me.txt_aircaft_name.Enabled = False
        Me.txt_aircraft_model.Enabled = False
        Me.txt_description.Enabled = False
        Me.cactive.Enabled = False

        loading_full_data()
    End Sub
End Class
