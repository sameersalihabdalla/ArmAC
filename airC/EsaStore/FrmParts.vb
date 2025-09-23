Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class FrmParts


    Private Sub FrmCatogery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trace("open parts Screen by : " & username)
        TableLayoutPanel1.Enabled = False

        Gbx1.Enabled = False
        cmbMainCat.Enabled = True
        If con.State = ConnectionState.Open Then con.Close()
        myconect_pool()
        Dim sql As String = "select * from tbl_aircraft where aircraft_is_active=1 order by aircraft_type"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        myAdapter.SelectCommand = cmd
        myAdapter.Fill(myData)

        cmbMainCat.DisplayMember = "Text"
        cmbMainCat.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        For Each drRow As DataRow In myData.Rows
            tb.Rows.Add(drRow.Item("aircraft_type") & " / " & drRow.Item("aircraft_number"), Val(drRow.Item("id")))



        Next
        cmbMainCat.DataSource = tb

        Me.cmbMainCat.SelectedIndex = 0

        con.Close()

        btn_add.Enabled = True
        btn_save.Enabled = False

        btn_save.Text = "Save"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txt_part_name.Enabled = False
        Me.txt_part_number.Enabled = False
        Gbx2.Visible = False
        btnUnlock.Enabled = False
        btnLock.Enabled = True

        '  loading_full_data()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        cmbMainCat.Enabled = False
        Gbx1.Enabled = True
        btnUnlock.Enabled = True
        btnLock.Enabled = False
        Gbx2.Enabled = True
        Gbx2.Visible = True

        TableLayoutPanel1.Enabled = True
        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "Save"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txt_part_name.Enabled = False
        Me.txt_part_number.Enabled = False
        Me.txt_max_time.Enabled = False
        Me.txt_current_time.Enabled = False

        loading_full_data()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        Gbx1.Enabled = False
        cmbMainCat.Enabled = True
        btnUnlock.Enabled = False

        btnLock.Enabled = True
        Gbx2.Enabled = False
        TableLayoutPanel1.Enabled = False
        loading_full_data()
        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Gbx2.Visible = False

    End Sub



    Sub loading_full_data()

        myconect_pool()

        Dim sql As String = "select * from tbl_parts where aircraft_id='" & txt_id.Text & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader



        Try


            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                Me.DataGridView1.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
            Loop
            dReader.Close()

        Catch ex As Exception

        End Try
        con.Close()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)


    End Sub


    Sub fill_mydata()
        On Error Resume Next


        With Me.DataGridView1.CurrentRow
            Me.txt_part_id.Text = .Cells(0).Value
            Me.txt_part_name.Text = .Cells(1).Value
            Me.Gbx2.Text = "Selected Part " & .Cells(1).Value
            Me.txt_part_number.Text = .Cells(2).Value
            Me.txt_max_time.Value = .Cells(3).Value
            Me.txt_current_time.Value = .Cells(4).Value

        End With


    End Sub
    Private Sub clearing_fields()
        Me.txt_part_id.Text = ""
        Me.txt_part_name.Text = ""
        Me.txt_part_number.Text = ""
        Me.Gbx2.Text = "Selected Part "


    End Sub






    Private Sub txt_user_id_TextChanged(sender As Object, e As EventArgs)
        If txt_part_id.Text = "" Then
            btn_edit.Enabled = False
            btn_delete.Enabled = False
        Else
            btn_edit.Enabled = True
            btn_delete.Enabled = True


        End If
    End Sub






    Private Sub btn_close_Click_1(sender As Object, e As EventArgs)
        Close()
    End Sub





    Private Sub cmbMainCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMainCat.SelectedIndexChanged
        txt_id.Text = cmbMainCat.SelectedValue
        DataGridView1.Rows.Clear()


        clearing_fields()

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clearing_fields()
        fill_mydata()

    End Sub









    Private Sub FrmCatogery_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        trace("Try to Delete part from list by " & username)
        Dim x = txt_part_id.Text
        Dim sure = MsgBox("هل تريد االفئة " & Me.txt_part_name.Text, vbYesNo, "")
        If sure = vbYes Then
            myconect_pool()

            If x <> "" Then
                Dim sql As String = "delete from tbl_products where pid='" & x & "'"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("تم الحذف بنجاح", vbInformation)
                con.Close()
                clearing_fields()
                btn_add.Enabled = True
                btn_save.Enabled = False
                btn_save.Text = "Save"
                btn_cancel.Enabled = False
                Me.DataGridView1.Enabled = True
                Me.DataGridView1.Rows.Clear()
                loading_full_data()
            Else
                MsgBox("يرجى تحديد الفئة  المراد حذفها")
            End If
        Else
            clearing_fields()
            btn_add.Enabled = True
            btn_save.Enabled = False
            btn_save.Text = "Save"
            btn_cancel.Enabled = False
            Me.DataGridView1.Enabled = True
            Me.DataGridView1.Rows.Clear()
            Me.txt_part_name.Enabled = False

            Me.txt_part_number.Enabled = False
            loading_full_data()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        trace("try to Edit part by :" & username)
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_delete.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_save.Text = "Save Edit"
        Me.btn_cancel.Enabled = True
        Me.txt_part_name.Enabled = True
        Me.txt_part_number.Enabled = True

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        trace("try To add New Part by" & username)
        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_cancel.Enabled = True
        Me.txt_part_name.Focus()
        Me.txt_part_name.Enabled = True
        Me.txt_part_number.Enabled = True
        Me.txt_current_time.Enabled = True
        Me.txt_max_time.Enabled = True

    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "Save"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txt_part_name.Enabled = False
        Me.txt_max_time.Enabled = False
        Me.txt_current_time.Enabled = False

        Me.txt_part_number.Enabled = False
        loading_full_data()
    End Sub

    Private Sub btn_close_Click_2(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()

    End Sub

    Private Sub Gbx2_Enter(sender As Object, e As EventArgs) Handles Gbx2.Enter

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        trace("try to save new part by :" & username)
        myconect_pool()

        If Me.txt_part_name.Text = "" Then
            MsgBox("Enter Airctaft Name")
            Exit Sub
        End If
        If Me.txt_part_number.Text = "" Then
            MsgBox("Enter Aircraft Model / Type")
            Exit Sub

        End If
        Try


            If Me.txt_part_id.Text = "" And btn_save.Text = "Save" Then

                Dim cmd As New MySqlCommand
                Dim result As Integer
                Dim sql As String = "insert tbl_parts(
    `part_name`
    , `part_number`
    , `max_time`
    , `current_time`
    , `aircraft_id`)  values
('" & Me.txt_part_name.Text & "', '" & Me.txt_part_number.Text & "' ,'" & Me.txt_max_time.Value & "','" & Me.txt_current_time.Value & "'," & Me.txt_id.Text & ")"
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
                    Me.txt_part_name.Enabled = False
                    Me.txt_part_number.Enabled = False
                    Me.txt_max_time.Enabled = False
                    Me.txt_current_time.Enabled = False
                    Me.DataGridView1.Enabled = True
                    clearing_fields()
                    con.Close()
                    loading_full_data()

                End If
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class