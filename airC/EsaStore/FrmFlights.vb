Imports System.ComponentModel
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmFlights

    Sub loading_full_data2()
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_flights"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader





        dReader = cmd.ExecuteReader()
        Do While dReader.Read = True
            Me.DataGridView1.Rows.Add(dReader(0), dReader(3), dReader(6), dReader(4), dReader(5), "View Datails", "Delete Flight")
        Loop
        dReader.Close()

        con.Close()

    End Sub

    Private Sub mission_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each tb As TextBox In Controls.OfType(Of TextBox)()
            AddHandler tb.Enter, Sub() tb.BackColor = Color.Red
            AddHandler tb.Enter, Sub() tb.ForeColor = Color.White

            AddHandler tb.Leave, Sub() tb.BackColor = Color.White
            AddHandler tb.Leave, Sub() tb.ForeColor = Color.Black

        Next



        For Each tbc As MaskedTextBox In Controls.OfType(Of MaskedTextBox)()
            AddHandler tbc.Enter, Sub() tbc.BackColor = Color.Red
            AddHandler tbc.Enter, Sub() tbc.ForeColor = Color.White

            AddHandler tbc.Leave, Sub() tbc.BackColor = Color.White
            AddHandler tbc.Leave, Sub() tbc.ForeColor = Color.Black

        Next




        ' txt_departue_time.Format = DateTimePickerFormat.Custom("")
        txt_arrival_time.ShowUpDown = True
        'txt_arrival_time.Format = DateTimePickerFormat.Time
        txt_departue_time.ShowUpDown = True
        Me.KeyPreview = True
        clearing()
        Enabling(False)

        clearing()
        Enabling(False)
        btn_add.Enabled = True
        btn_save.Enabled = False
        cmb_aircraft_no.Enabled = False
        loading_full_data2()

    End Sub


    Sub loading_full_data()
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_aircraft GROUP BY `aircraft_type`"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader





        dReader = cmd.ExecuteReader()
        Do While dReader.Read = True
            Me.cmb_aircraft_type.Items.Add(dReader(1))

        Loop
        dReader.Close()

        con.Close()

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        trace("try Add New Flight  : Username is :" & username)

        clearing()
        Enabling(True)
        loading_full_data()
        cmb_aircraft_no.Enabled = True
        cmb_pilots.Enabled = True
        cmb_emergency.Enabled = True
        cmb_pilots.Enabled = True
        txt_flight_location.Enabled = True
        btn_cancel.Enabled = True
        btn_add.Enabled = False
        btn_save.Enabled = True
        cmb_emergency.Items.Clear()

        cmb_emergency.Items.Add("Signal")
        cmb_emergency.Items.Add("GPS")
        cmb_emergency.Items.Add("COM")
        cmb_emergency.Items.Add("Battry")
        cmb_emergency.Items.Add("Engine Failure")
        cmb_emergency.Items.Add("Flight Location")

        cmb_mission_commander.Items.Clear()
        If con.State = ConnectionState.Open Then con.Close()

        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_commanders"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader

        dReader = cmd.ExecuteReader()
        Do While dReader.Read = True
            cmb_mission_commander.Items.Add(dReader(1))

        Loop
        dReader.Close()

        con.Close()





        'pilots



        cmb_pilots.Items.Clear()
        If con.State = ConnectionState.Open Then con.Close()

        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql2 = "select * from tbl_pilots"

        Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
        Dim dReader2 As MySqlDataReader




        dReader2 = cmd2.ExecuteReader()
        Do While dReader2.Read = True
            cmb_pilots.Items.Add(dReader2(1))

        Loop
        dReader2.Close()

        con.Close()

        timing()
        Try
            Me.cmb_aircraft_type.Focus()

        Catch ex As Exception

        End Try

    End Sub


    Sub clearing()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView2.Rows.Clear()

        Me.cmb_aircraft_no.Items.Clear()
        cmb_pilots.Items.Clear()
        Me.cmb_aircraft_type.Items.Clear()
        Me.cmb_mission_commander.Items.Clear()
        Me.txt_aircraft_weight.Text = ""
        Me.txt_arrival_time.Text = ""
        Me.txt_battary_r_l_after.Text = ""
        Me.txt_battary_r_l_before.Text = ""
        Me.txt_date.Value = Now.Date
        Me.txt_departue_time.Text = ""
        txt_flight_location.Text = ""
        Me.txt_engine_battary_after.Text = ""
        Me.txt_engine_battary_before.Text = ""
        Me.txt_farther_range.Text = ""
        Me.txt_flight_id.Text = ""
        Me.txt_flight_no.Text = ""
        Me.txt_flight_duration.Text = ""
        Me.txt_fuel_after.Text = ""
        Me.txt_fuel_before.Text = ""
        Me.txt_landing_no.Text = ""
        Me.txt_main_battary_after.Text = ""
        Me.txt_main_battary_before.Text = ""
        Me.txt_max_height.Text = ""
        Me.txt_humidity.Text = ""
        Me.txt_wind_speed.Text = ""
        Me.txt_gps.Text = ""
        Me.txt_precipition.Text = ""
        Me.txt_temperature.Text = ""
        txt_emergency_description.Text = ""
        Me.txt_temperature.Text = ""
        Me.DataGridView2.Rows.Clear()

    End Sub

    Sub Enabling(ByVal x As Boolean)
        Me.txt_gps.Enabled = x
        txt_humidity.Enabled = x
        Me.cmb_aircraft_type.Enabled = x
        Me.cmb_mission_commander.Enabled = x
        Me.txt_aircraft_weight.Enabled = x
        Me.txt_arrival_time.Enabled = x
        Me.txt_battary_r_l_after.Enabled = x
        Me.txt_battary_r_l_before.Enabled = x
        Me.txt_date.Enabled = x
        Me.txt_departue_time.Enabled = x
        Me.txt_engine_battary_after.Enabled = x
        Me.txt_engine_battary_before.Enabled = x
        Me.txt_farther_range.Enabled = x
        Me.txt_flight_id.Enabled = x
        Me.txt_flight_no.Enabled = x
        ' Me.txt_flight_duration.Enabled = x
        Me.txt_fuel_after.Enabled = x
        Me.txt_fuel_before.Enabled = x
        Me.txt_landing_no.Enabled = x
        Me.txt_main_battary_after.Enabled = x
        Me.txt_main_battary_before.Enabled = x
        Me.txt_max_height.Enabled = x
        Me.txt_temperature.Enabled = x
        Me.txt_precipition.Enabled = x
        Me.txt_wind_speed.Enabled = x
        Me.cmb_emergency.Enabled = x
        Me.txt_temperature.Enabled = x
        Me.txt_flight_location.Enabled = x
        Me.cmb_pilots.Enabled = x
        Me.cmb_mission_commander.Enabled = x
        Me.txt_emergency_description.Enabled = x

    End Sub


    Private Sub cmb_aircraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_aircraft_type.SelectedIndexChanged
        cmb_aircraft_no.Items.Clear()
        If con.State = ConnectionState.Open Then con.Close()

        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_aircraft where aircraft_type='" & Me.cmb_aircraft_type.Text & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader





        dReader = cmd.ExecuteReader()
        Do While dReader.Read = True
            Me.cmb_aircraft_no.Items.Add(dReader(2))

        Loop
        dReader.Close()

        con.Close()
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        trace("Cancel Add New Flight  : Username is :" & username)

        clearing()
        Enabling(False)
        btn_add.Enabled = True
        btn_save.Enabled = False
        cmb_aircraft_no.Enabled = False
        loading_full_data2()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'trace("try Save New Flight  : Username is :" & username)


        If btn_save.Text = "Save" Then

            If cmb_aircraft_type.Text = "" Then
                MsgBox("Select Aircraft Type")
                Me.cmb_aircraft_type.Focus()

                Exit Sub

            End If

            If cmb_aircraft_no.Text = "" Then
                MsgBox("Select Aircraft Number")
                cmb_aircraft_no.Focus()
                Exit Sub
            End If


            If txt_flight_no.Text = "" Then
                MsgBox("Please Select Flight NO")
                txt_flight_no.Focus()
                Exit Sub


            End If
            If Me.cmb_mission_commander.Text = "" Then
                MsgBox("Select Mission Commander")
                cmb_mission_commander.Focus()
                Exit Sub
            End If

            If cmb_pilots.Text = "" Then
                MsgBox("Select Pilot")
                cmb_pilots.Focus()
                Exit Sub
            End If


            If txt_flight_duration.Text = "" Then
                MsgBox("Enter Flighig Time")
                txt_flight_duration.Focus()
                Exit Sub
            End If


            If Me.txt_farther_range.Text = "" Then
                MsgBox("Enter Farther Range")
                txt_farther_range.Focus()
                Exit Sub

            End If



            If Me.txt_max_height.Text = "" Then
                MsgBox("Enter Max Height")
                txt_max_height.Focus()
                Exit Sub

            End If

            If Me.txt_landing_no.Text = "" Then
                MsgBox("Enter Landing NO")
                txt_landing_no.Focus()
                Exit Sub

            End If

            If Me.txt_flight_location.Text = "" Then
                MsgBox("Enter Flight Location")
                txt_flight_location.Focus()
                Exit Sub

            End If

            If Me.txt_temperature.Text = "" Then
                MsgBox("Enter Temperature")
                txt_temperature.Focus()
                Exit Sub

            End If


            If Me.txt_wind_speed.Text = "" Then
                MsgBox("Enter Wind Speed")
                txt_wind_speed.Focus()
                Exit Sub

            End If


            If Me.txt_precipition.Text = "" Then
                MsgBox("Enter Precipition")
                txt_precipition.Focus()
                Exit Sub

            End If



            If Me.txt_gps.Text = "" Then
                MsgBox("Enter GPS")
                txt_gps.Focus()
                Exit Sub

            End If

            If Me.txt_humidity.Text = "" Then
                MsgBox("Enter Humidity")
                txt_humidity.Focus()
                Exit Sub

            End If



            If Me.txt_humidity.Text = "" Then
                MsgBox("Enter Humidity")
                txt_humidity.Focus()
                Exit Sub

            End If

            If Me.txt_main_battary_before.Text = "" Then
                MsgBox("Enter Main Battary V Before")
                txt_main_battary_before.Focus()
                Exit Sub

            End If

            If Me.txt_main_battary_after.Text = "" Then
                MsgBox("Enter Main Battary V After")
                txt_main_battary_after.Focus()
                Exit Sub

            End If


            If Me.txt_battary_r_l_before.Text = "" Then
                MsgBox("Enter Battary V R/L Before")
                txt_battary_r_l_before.Focus()
                Exit Sub

            End If

            If Me.txt_battary_r_l_after.Text = "" Then
                MsgBox("Enter Battary V R/L After")
                txt_battary_r_l_after.Focus()
                Exit Sub

            End If


            If Me.txt_engine_battary_after.Text = "" Then
                MsgBox("Engine Battary After")
                txt_engine_battary_after.Focus()
                Exit Sub

            End If


            If Me.txt_engine_battary_before.Text = "" Then
                MsgBox("Engine Battary Before")
                txt_engine_battary_before.Focus()
                Exit Sub

            End If


            If Me.txt_fuel_after.Text = "" Then
                MsgBox("Enter Fuel After")
                txt_fuel_after.Focus()
                Exit Sub
            End If

            If Me.txt_fuel_after.Text = "" Then
                MsgBox("Enter Fuel After")
                txt_fuel_after.Focus()
                Exit Sub
            End If


            If Me.txt_fuel_before.Text = "" Then
                MsgBox("Enter Fuel Before")
                txt_fuel_before.Focus()
                Exit Sub
            End If


            If Me.txt_engine_battary_before.Text = "" Then
                MsgBox("Engine Battary Before")
                txt_engine_battary_before.Focus()
                Exit Sub

            End If




            If Me.txt_aircraft_weight.Text = "" Then
                MsgBox("Enter Aircraft Weight")
                txt_aircraft_weight.Focus()
                Exit Sub

            End If


            Dim x


            myconect_pool()


            Dim cmd As New MySqlCommand
            Dim result As Integer
            Dim sql As String = "insert tbl_flights(
     `flight_aircraft_type`
    , `flight_aircraft_number`
    , `flight_number`
    , `flight_commander`
    , `flight_pilot`
    , `flight_date`
    , `flight_depatrue_time`
    , `flight_arrival_time`
    , `flight_duration`
    , `flight_frther_range`
    , `flight_max_height`
    , `flight_landing_no`
    , `flight_location`
    , `flight_temperature`
    , `flight_wind_speed`
    , `flight_preciptions`
    , `flight_gps`
    , `flight_humidity`
    , `flight_m_b_v_b`
    , `flight_m_b_v_a`
    , `flight_b_v_r_l_b`
    , `flight_b_v_r_l_a`
    ,`flight_e_b_v_b`
    , `flight_e_b_v_a`
    , `flight_f_b`
    , `flight_f_a`
    , `flight_aircraft_weight`
    , `flight_emergency`
 , `flight_emergency_description`)  
values ('" & Me.cmb_aircraft_type.Text & "',
'" & Me.cmb_aircraft_no.Text & "',
'" & Me.txt_flight_no.Text & "',
'" & Me.cmb_mission_commander.Text & "',
'" & Me.cmb_pilots.Text & "',
'" & Format(Me.txt_date.Value, "yyyy-MM-dd") & "'
,'" & Format(Me.txt_departue_time.Value, "H:mm") & "'
,'" & Format(Me.txt_arrival_time.Value, "H:m") & "'
,'" & Me.txt_flight_duration.Text & "'
,'" & Me.txt_farther_range.Text & "'
,'" & Me.txt_max_height.Text & "'
,'" & Me.txt_landing_no.Text & "'
,'" & Me.txt_flight_location.Text & "'
,'" & Me.txt_temperature.Text & "'
,'" & Me.txt_wind_speed.Text & "'
,'" & Me.txt_precipition.Text & "'
,'" & Me.txt_gps.Text & "'
,'" & Me.txt_humidity.Text & "'
,'" & Me.txt_main_battary_before.Text & "'
,'" & Me.txt_main_battary_after.Text & "'
,'" & Me.txt_battary_r_l_before.Text & "'
,'" & Me.txt_battary_r_l_after.Text & "'
,'" & Me.txt_engine_battary_before.Text & "'
,'" & Me.txt_engine_battary_after.Text & "'
,'" & Me.txt_fuel_before.Text & "'
,'" & Me.txt_fuel_after.Text & "'
,'" & Me.txt_aircraft_weight.Text & "'
,'" & Me.cmb_emergency.Text & "'

,'" & Me.txt_emergency_description.Text & "')"
            cmd.Connection = con
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("Data Does Not Saved")





            Else


                Dim sql2 As String = "SELECT MAX(flight_id) FROM  tbl_flights"
                Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
                Dim dReader2 As MySqlDataReader
                dReader2 = cmd2.ExecuteReader()
                Dim xx As Integer
                xx = 0

                If dReader2.Read Then
                    xx = dReader2(0)

                    cmd2.Dispose()
                    dReader2.Close()


                    Dim dgv As DataGridView = Me.DataGridView2

                    For i As Integer = 0 To dgv.Rows.Count - 1

                        '   MsgBox(dgv.Rows(i).Cells(1).Value.ToString)

                        Dim cmd3 As New MySqlCommand
                        Dim result3 As Integer
                        Dim sql3 As String = "insert tbl_parts_log(
`part_name`
,`part_id`
,`part_number`
,`using_time`
,`aircraft_type`
,`aircraft_no`
,`aircraft_id`
,`flight_date`
,`flight_id`

)  values(
'" & dgv.Rows(i).Cells(1).Value.ToString & "'
,'" & dgv.Rows(i).Cells(0).Value & "'
,'" & dgv.Rows(i).Cells(2).Value & "'
,'" & Val(txt_flight_duration.Text) & "'
,'" & dgv.Rows(i).Cells(6).Value & "'
,'" & dgv.Rows(i).Cells(7).Value & "'
,'" & dgv.Rows(i).Cells(5).Value & "'
,'" & Format(Me.txt_date.Value, "yyyy-MM-dd") & "'
,'" & Val(xx) & "'

)"




                        cmd3.Connection = con
                        cmd3.CommandText = sql3
                        result3 = cmd3.ExecuteNonQuery
                        If result3 = 0 Then
                            MsgBox("Data Does Not Saved")


                        Else

                        End If
                        cmd3.Dispose()

                    Next

                End If

                Me.txt_arrival_time.Text = ""
                Me.txt_battary_r_l_after.Text = ""
                Me.txt_battary_r_l_before.Text = ""
                Me.txt_date.Value = Now.Date
                Me.txt_departue_time.Text = ""
                txt_flight_location.Text = ""
                Me.txt_engine_battary_after.Text = ""
                Me.txt_engine_battary_before.Text = ""
                Me.txt_farther_range.Text = ""
                Me.txt_flight_id.Text = ""
                Me.txt_flight_no.Text = ""
                Me.txt_flight_duration.Text = ""
                Me.txt_fuel_after.Text = ""
                Me.txt_fuel_before.Text = ""
                Me.txt_landing_no.Text = ""
                Me.txt_main_battary_after.Text = ""
                Me.txt_main_battary_before.Text = ""
                Me.txt_max_height.Text = ""
                Me.txt_humidity.Text = ""
                Me.txt_wind_speed.Text = ""
                Me.txt_gps.Text = ""
                Me.txt_precipition.Text = ""
                Me.txt_temperature.Text = ""
                txt_emergency_description.Text = ""
                Me.txt_temperature.Text = ""


                cmb_aircraft_no.Items.Clear()
                cmb_aircraft_type.Items.Clear()
                cmb_emergency.Items.Clear()
                cmb_mission_commander.Items.Clear()
                cmb_pilots.Items.Clear()
                'Me.txt_date.Value = Nothing
                'Me.txt_departue_time.Value=Nothing
                'Me.txt_arrival_time.Value=Nothing

                DataGridView2.Rows.Clear()

                Enabling(False)
                btn_add.Enabled = True
                btn_save.Enabled = False
                Me.btn_cancel.Enabled = False
                Me.btn_close.Enabled = True



            End If
        End If
        FrmFixing.ShowDialog()

    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        trace("Close Flights Screen  : Username is :" & username)

        Me.Close()

    End Sub

    Private Sub cmb_aircraft_no_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_aircraft_no.SelectedIndexChanged
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_aircraft where aircraft_type='" & Me.cmb_aircraft_type.Text & "' and aircraft_number='" & Me.cmb_aircraft_no.Text & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader



        Dim aircraft_id = 0
        Me.DataGridView2.Rows.Clear()

        dReader = cmd.ExecuteReader()
        If dReader.Read Then
            aircraft_id = dReader(0)
        End If

        dReader.Close()
        con.Close()



        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql2 As String = "select * from tbl_parts where aircraft_id=" & aircraft_id & ""
        Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
        Dim dReader2 As MySqlDataReader





        dReader2 = cmd2.ExecuteReader()
        Do While dReader2.Read = True
            Me.DataGridView2.Rows.Add(dReader2(0), dReader2(1), dReader2(2), dReader2(3) & "/H", dReader2(4) & "/H", dReader2(5), Me.cmb_aircraft_type.Text, Me.cmb_aircraft_no.Text, Val(dReader2(4) + dReader2(6)) & "/H")
        Loop
        dReader2.Close()

        con.Close()


        Dim dgv2 As DataGridView = Me.DataGridView2

        For ii As Integer = 0 To dgv2.Rows.Count - 1
            For ColNo As Integer = 4 To 5
                If Val(dgv2.Rows(ii).Cells(ColNo).Value) < 0 Then

                    dgv2.Rows(ii).Cells(ColNo).Style.BackColor = Color.Red

                    dgv2.Rows(ii).Cells(ColNo).Style.ForeColor = Color.White
                Else
                    dgv2.Rows(ii).Cells(ColNo).Style.BackColor = Color.DarkGreen

                    dgv2.Rows(ii).Cells(ColNo).Style.ForeColor = Color.White

                End If
            Next
        Next


    End Sub

    Private Sub txt_arrival_time_ValueChanged(sender As Object, e As EventArgs) Handles txt_arrival_time.ValueChanged

        timing()

    End Sub

    Sub timing()
        Dim hour As Long, min As Long, sec As Long
        sec = DateDiff("s", txt_departue_time.Value, txt_arrival_time.Value)

        If Val(sec) < 0 Then
            txt_flight_duration.Text = Format(((sec) / 3600) + 24, "##.##")
        ElseIf Val(sec) > 0 Then
            txt_flight_duration.Text = Format((sec / 3600), "##.##")
        Else
            txt_flight_duration.Text = 0
        End If

        'hour = Int(sec / 3600)
        'sec = sec - (hour * 3600)
        'min = Int(sec / 60)
        'sec = sec - (min * 60)
        'txt_flight_duration.Text = Format(hour, "00") & "." & Format(min, "00")
    End Sub

    Private Sub txt_departue_time_ValueChanged(sender As Object, e As EventArgs) Handles txt_departue_time.ValueChanged
        timing()

    End Sub

    Private Sub txt_arrival_time_Validating(sender As Object, e As CancelEventArgs) Handles txt_arrival_time.Validating
        timing()

    End Sub


    Private Sub txt_departue_time_Click(sender As Object, e As EventArgs) Handles txt_departue_time.Click
        timing()
    End Sub

    Private Sub txt_arrival_time_Click(sender As Object, e As EventArgs) Handles txt_arrival_time.Click
        timing()
    End Sub



    Private Sub cmb_aircraft_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_aircraft_type.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()


        End If
    End Sub

    Private Sub cmb_aircraft_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_aircraft_no.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()


        End If
    End Sub

    Private Sub txt_flight_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_flight_no.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()


        End If
    End Sub

    Private Sub cmb_mission_commander_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_mission_commander.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()


        End If
    End Sub

    Private Sub cmb_pilots_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_pilots.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_date_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_date.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_departue_time_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_departue_time.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_arrival_time_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_arrival_time.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_flight_duration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_flight_duration.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_farther_range_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_farther_range.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_max_height_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_max_height.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_landing_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_landing_no.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub


    Private Sub txt_flight_location_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_flight_location.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_temperature_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_temperature.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_wind_speed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_wind_speed.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_precipition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precipition.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_gps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_gps.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub


    Private Sub txt_humidity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_humidity.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_aircraft_weight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_aircraft_weight.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_main_battary_after_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_main_battary_after.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_main_battary_before_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_main_battary_before.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_fuel_before_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fuel_before.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_fuel_after_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fuel_after.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_battary_r_l_before_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_battary_r_l_before.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_battary_r_l_after_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_battary_r_l_after.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_engine_battary_before_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_engine_battary_before.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_engine_battary_after_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_engine_battary_after.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub



    Private Sub cmb_emergency_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_emergency.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub



    Private Sub txt_emergency_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_emergency_description.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")
            Beep()
        End If
    End Sub

    Private Sub txt_fuel_after_TextChanged(sender As Object, e As EventArgs) Handles txt_fuel_after.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        If e.ColumnIndex = 5 Then


            With DataGridView1.CurrentRow

                Frm_Flights_Report.lbl_operation.Text = .Cells(1).Value
                trace("try Open Flights Report  : Username is :" & username)


                Frm_Flights_Report.ShowDialog()


            End With


        End If


        If e.ColumnIndex = 6 Then


            With DataGridView1.CurrentRow

                Frm_Delete.lbl_operation.Text = .Cells(1).Value
                trace("try Delete Flight : Username is :" & username)

                Frm_Delete.ShowDialog()


            End With


        End If



    End Sub
End Class
