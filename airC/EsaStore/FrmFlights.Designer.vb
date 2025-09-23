<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFlights
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFlights))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_flight_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fuel_before = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_flight_duration = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_mission_commander = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_flight_no = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_landing_no = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_temperature = New System.Windows.Forms.TextBox()
        Me.txt_fuel_after = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_main_battary_before = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_main_battary_after = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_engine_battary_before = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_engine_battary_after = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_battary_r_l_before = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_battary_r_l_after = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_aircraft_weight = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_farther_range = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_max_height = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.cmb_aircraft_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_pilots = New System.Windows.Forms.ComboBox()
        Me.cmb_aircraft_no = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_gps = New System.Windows.Forms.TextBox()
        Me.txt_wind_speed = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_precipition = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmb_emergency = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_flight_location = New System.Windows.Forms.MaskedTextBox()
        Me.txt_humidity = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aircaft_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aircraft_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aircaft_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_emergency_description = New System.Windows.Forms.TextBox()
        Me.txt_departue_time = New System.Windows.Forms.DateTimePicker()
        Me.txt_arrival_time = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_flight_id
        '
        Me.txt_flight_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_flight_id.Enabled = False
        Me.txt_flight_id.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_flight_id.ForeColor = System.Drawing.Color.White
        Me.txt_flight_id.Location = New System.Drawing.Point(12, 59)
        Me.txt_flight_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_flight_id.Name = "txt_flight_id"
        Me.txt_flight_id.Size = New System.Drawing.Size(85, 29)
        Me.txt_flight_id.TabIndex = 0
        Me.txt_flight_id.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flight ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(389, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fuel Before"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_fuel_before
        '
        Me.txt_fuel_before.Enabled = False
        Me.txt_fuel_before.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fuel_before.Location = New System.Drawing.Point(389, 295)
        Me.txt_fuel_before.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fuel_before.Name = "txt_fuel_before"
        Me.txt_fuel_before.Size = New System.Drawing.Size(98, 29)
        Me.txt_fuel_before.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(352, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 35)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Flight Duration"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_flight_duration
        '
        Me.txt_flight_duration.Culture = New System.Globalization.CultureInfo("en-SD")
        Me.txt_flight_duration.Enabled = False
        Me.txt_flight_duration.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_flight_duration.Location = New System.Drawing.Point(352, 144)
        Me.txt_flight_duration.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_flight_duration.Name = "txt_flight_duration"
        Me.txt_flight_duration.Size = New System.Drawing.Size(113, 29)
        Me.txt_flight_duration.TabIndex = 9
        Me.txt_flight_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_flight_duration.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(599, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 34)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mission Commander"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_mission_commander
        '
        Me.cmb_mission_commander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mission_commander.Enabled = False
        Me.cmb_mission_commander.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mission_commander.FormattingEnabled = True
        Me.cmb_mission_commander.Location = New System.Drawing.Point(600, 59)
        Me.cmb_mission_commander.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_mission_commander.Name = "cmb_mission_commander"
        Me.cmb_mission_commander.Size = New System.Drawing.Size(164, 30)
        Me.cmb_mission_commander.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(423, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 34)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Flight NO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_flight_no
        '
        Me.txt_flight_no.Enabled = False
        Me.txt_flight_no.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_flight_no.Location = New System.Drawing.Point(423, 60)
        Me.txt_flight_no.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_flight_no.Name = "txt_flight_no"
        Me.txt_flight_no.Size = New System.Drawing.Size(177, 29)
        Me.txt_flight_no.TabIndex = 3
        '
        'txt_date
        '
        Me.txt_date.CustomFormat = "dd/MM/yyy"
        Me.txt_date.Enabled = False
        Me.txt_date.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(13, 144)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(134, 29)
        Me.txt_date.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(13, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 34)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(146, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 34)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Departue Time"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(255, 108)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 35)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Arrival Time"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_landing_no
        '
        Me.txt_landing_no.Culture = New System.Globalization.CultureInfo("en-SD")
        Me.txt_landing_no.Enabled = False
        Me.txt_landing_no.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_landing_no.Location = New System.Drawing.Point(654, 144)
        Me.txt_landing_no.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_landing_no.Name = "txt_landing_no"
        Me.txt_landing_no.Size = New System.Drawing.Size(102, 29)
        Me.txt_landing_no.TabIndex = 12
        Me.txt_landing_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_landing_no.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(654, 108)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 35)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Landing NO"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(13, 185)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 35)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Temperature"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_temperature
        '
        Me.txt_temperature.Enabled = False
        Me.txt_temperature.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_temperature.Location = New System.Drawing.Point(13, 225)
        Me.txt_temperature.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_temperature.Name = "txt_temperature"
        Me.txt_temperature.Size = New System.Drawing.Size(100, 29)
        Me.txt_temperature.TabIndex = 14
        '
        'txt_fuel_after
        '
        Me.txt_fuel_after.Enabled = False
        Me.txt_fuel_after.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fuel_after.Location = New System.Drawing.Point(481, 295)
        Me.txt_fuel_after.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fuel_after.Name = "txt_fuel_after"
        Me.txt_fuel_after.Size = New System.Drawing.Size(98, 29)
        Me.txt_fuel_after.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(481, 261)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 35)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Fuel After"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_main_battary_before
        '
        Me.txt_main_battary_before.Enabled = False
        Me.txt_main_battary_before.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_main_battary_before.Location = New System.Drawing.Point(12, 295)
        Me.txt_main_battary_before.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_main_battary_before.Name = "txt_main_battary_before"
        Me.txt_main_battary_before.Size = New System.Drawing.Size(186, 29)
        Me.txt_main_battary_before.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(12, 261)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 35)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Main Battary V Before"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_main_battary_after
        '
        Me.txt_main_battary_after.Enabled = False
        Me.txt_main_battary_after.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_main_battary_after.Location = New System.Drawing.Point(197, 295)
        Me.txt_main_battary_after.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_main_battary_after.Name = "txt_main_battary_after"
        Me.txt_main_battary_after.Size = New System.Drawing.Size(186, 29)
        Me.txt_main_battary_after.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(197, 261)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(186, 35)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Main Battary V After"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_engine_battary_before
        '
        Me.txt_engine_battary_before.Enabled = False
        Me.txt_engine_battary_before.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_engine_battary_before.Location = New System.Drawing.Point(13, 447)
        Me.txt_engine_battary_before.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_engine_battary_before.Name = "txt_engine_battary_before"
        Me.txt_engine_battary_before.Size = New System.Drawing.Size(185, 29)
        Me.txt_engine_battary_before.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(13, 408)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 35)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Engine Battary V Before"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_engine_battary_after
        '
        Me.txt_engine_battary_after.Enabled = False
        Me.txt_engine_battary_after.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_engine_battary_after.Location = New System.Drawing.Point(197, 447)
        Me.txt_engine_battary_after.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_engine_battary_after.Name = "txt_engine_battary_after"
        Me.txt_engine_battary_after.Size = New System.Drawing.Size(186, 29)
        Me.txt_engine_battary_after.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(197, 408)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(186, 35)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Engine Battary V After"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_battary_r_l_before
        '
        Me.txt_battary_r_l_before.Enabled = False
        Me.txt_battary_r_l_before.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_battary_r_l_before.Location = New System.Drawing.Point(12, 371)
        Me.txt_battary_r_l_before.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_battary_r_l_before.Name = "txt_battary_r_l_before"
        Me.txt_battary_r_l_before.Size = New System.Drawing.Size(186, 29)
        Me.txt_battary_r_l_before.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(12, 337)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(186, 35)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = " Battary V R/L Before"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_battary_r_l_after
        '
        Me.txt_battary_r_l_after.Enabled = False
        Me.txt_battary_r_l_after.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_battary_r_l_after.Location = New System.Drawing.Point(197, 371)
        Me.txt_battary_r_l_after.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_battary_r_l_after.Name = "txt_battary_r_l_after"
        Me.txt_battary_r_l_after.Size = New System.Drawing.Size(186, 29)
        Me.txt_battary_r_l_after.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(197, 337)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(186, 35)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Battary V R/L After"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_aircraft_weight
        '
        Me.txt_aircraft_weight.Enabled = False
        Me.txt_aircraft_weight.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aircraft_weight.Location = New System.Drawing.Point(591, 225)
        Me.txt_aircraft_weight.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_aircraft_weight.Name = "txt_aircraft_weight"
        Me.txt_aircraft_weight.Size = New System.Drawing.Size(117, 29)
        Me.txt_aircraft_weight.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(591, 185)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 35)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "AirCraft Weight"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_farther_range
        '
        Me.txt_farther_range.Enabled = False
        Me.txt_farther_range.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_farther_range.Location = New System.Drawing.Point(460, 144)
        Me.txt_farther_range.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_farther_range.Name = "txt_farther_range"
        Me.txt_farther_range.Size = New System.Drawing.Size(106, 29)
        Me.txt_farther_range.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(460, 108)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 35)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Farther Range"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_max_height
        '
        Me.txt_max_height.Enabled = False
        Me.txt_max_height.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_max_height.Location = New System.Drawing.Point(565, 144)
        Me.txt_max_height.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_max_height.Name = "txt_max_height"
        Me.txt_max_height.Size = New System.Drawing.Size(89, 29)
        Me.txt_max_height.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(565, 108)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 35)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Max Height"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(763, 25)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(175, 34)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Pilot / Technical"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.90062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.51553!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_close, 3, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(71, 500)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(805, 51)
        Me.TableLayoutPanel1.TabIndex = 48
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(141, 5)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(119, 41)
        Me.btn_cancel.TabIndex = 33
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(274, 5)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(122, 41)
        Me.btn_save.TabIndex = 30
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.Location = New System.Drawing.Point(10, 5)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(114, 41)
        Me.btn_add.TabIndex = 31
        Me.btn_add.Text = "Add New"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_close.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.Location = New System.Drawing.Point(407, 5)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(124, 41)
        Me.btn_close.TabIndex = 35
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_aircraft_type
        '
        Me.cmb_aircraft_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aircraft_type.Enabled = False
        Me.cmb_aircraft_type.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_aircraft_type.FormattingEnabled = True
        Me.cmb_aircraft_type.Location = New System.Drawing.Point(96, 59)
        Me.cmb_aircraft_type.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_aircraft_type.Name = "cmb_aircraft_type"
        Me.cmb_aircraft_type.Size = New System.Drawing.Size(160, 30)
        Me.cmb_aircraft_type.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(96, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 34)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "AirCraft Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_pilots
        '
        Me.cmb_pilots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pilots.Enabled = False
        Me.cmb_pilots.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pilots.FormattingEnabled = True
        Me.cmb_pilots.Location = New System.Drawing.Point(763, 59)
        Me.cmb_pilots.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_pilots.Name = "cmb_pilots"
        Me.cmb_pilots.Size = New System.Drawing.Size(175, 30)
        Me.cmb_pilots.TabIndex = 5
        '
        'cmb_aircraft_no
        '
        Me.cmb_aircraft_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aircraft_no.Enabled = False
        Me.cmb_aircraft_no.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_aircraft_no.FormattingEnabled = True
        Me.cmb_aircraft_no.Location = New System.Drawing.Point(257, 59)
        Me.cmb_aircraft_no.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_aircraft_no.Name = "cmb_aircraft_no"
        Me.cmb_aircraft_no.Size = New System.Drawing.Size(167, 30)
        Me.cmb_aircraft_no.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(255, 25)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(169, 34)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Aircraft NO"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(310, 185)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(162, 35)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "GPS PDOP"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_gps
        '
        Me.txt_gps.Enabled = False
        Me.txt_gps.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_gps.Location = New System.Drawing.Point(310, 225)
        Me.txt_gps.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_gps.Name = "txt_gps"
        Me.txt_gps.Size = New System.Drawing.Size(162, 29)
        Me.txt_gps.TabIndex = 17
        '
        'txt_wind_speed
        '
        Me.txt_wind_speed.Enabled = False
        Me.txt_wind_speed.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_wind_speed.Location = New System.Drawing.Point(112, 225)
        Me.txt_wind_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_wind_speed.Name = "txt_wind_speed"
        Me.txt_wind_speed.Size = New System.Drawing.Size(109, 29)
        Me.txt_wind_speed.TabIndex = 15
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(112, 185)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 35)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "Wind Speed"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_precipition
        '
        Me.txt_precipition.Enabled = False
        Me.txt_precipition.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_precipition.Location = New System.Drawing.Point(220, 225)
        Me.txt_precipition.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_precipition.Name = "txt_precipition"
        Me.txt_precipition.Size = New System.Drawing.Size(91, 29)
        Me.txt_precipition.TabIndex = 16
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(220, 185)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 35)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "Precipition"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(391, 408)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(237, 35)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "Emergency"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_emergency
        '
        Me.cmb_emergency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_emergency.Enabled = False
        Me.cmb_emergency.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_emergency.FormattingEnabled = True
        Me.cmb_emergency.Location = New System.Drawing.Point(391, 447)
        Me.cmb_emergency.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_emergency.Name = "cmb_emergency"
        Me.cmb_emergency.Size = New System.Drawing.Size(237, 30)
        Me.cmb_emergency.TabIndex = 28
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(755, 108)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(121, 35)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "Flight Loaction"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_flight_location
        '
        Me.txt_flight_location.Culture = New System.Globalization.CultureInfo("en-SD")
        Me.txt_flight_location.Enabled = False
        Me.txt_flight_location.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_flight_location.Location = New System.Drawing.Point(755, 144)
        Me.txt_flight_location.Name = "txt_flight_location"
        Me.txt_flight_location.Size = New System.Drawing.Size(121, 29)
        Me.txt_flight_location.TabIndex = 13
        '
        'txt_humidity
        '
        Me.txt_humidity.Enabled = False
        Me.txt_humidity.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_humidity.Location = New System.Drawing.Point(471, 225)
        Me.txt_humidity.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_humidity.Name = "txt_humidity"
        Me.txt_humidity.Size = New System.Drawing.Size(125, 29)
        Me.txt_humidity.TabIndex = 18
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Location = New System.Drawing.Point(471, 185)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(125, 35)
        Me.Label29.TabIndex = 66
        Me.Label29.Text = "Humidity "
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(627, 408)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(192, 35)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Emergency Description"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.aircaft_id, Me.aircraft_type, Me.aircaft_No, Me.Column1})
        Me.DataGridView2.Location = New System.Drawing.Point(967, 338)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(409, 418)
        Me.DataGridView2.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 51
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.HeaderText = "Part Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 105
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn3.HeaderText = "Part Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 118
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.HeaderText = "Max Time"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 101
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.HeaderText = "Starting Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 124
        '
        'aircaft_id
        '
        Me.aircaft_id.HeaderText = "Aircaft ID"
        Me.aircaft_id.Name = "aircaft_id"
        Me.aircaft_id.ReadOnly = True
        Me.aircaft_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'aircraft_type
        '
        Me.aircraft_type.HeaderText = "Aircraft  Type"
        Me.aircraft_type.Name = "aircraft_type"
        Me.aircraft_type.ReadOnly = True
        '
        'aircaft_No
        '
        Me.aircaft_No.HeaderText = "Aircraft No"
        Me.aircaft_No.Name = "aircaft_No"
        Me.aircaft_No.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Using Time"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'txt_emergency_description
        '
        Me.txt_emergency_description.Enabled = False
        Me.txt_emergency_description.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_emergency_description.Location = New System.Drawing.Point(627, 447)
        Me.txt_emergency_description.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_emergency_description.MaxLength = 1000
        Me.txt_emergency_description.Multiline = True
        Me.txt_emergency_description.Name = "txt_emergency_description"
        Me.txt_emergency_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_emergency_description.Size = New System.Drawing.Size(192, 30)
        Me.txt_emergency_description.TabIndex = 29
        '
        'txt_departue_time
        '
        Me.txt_departue_time.CustomFormat = "HH:mm"
        Me.txt_departue_time.Enabled = False
        Me.txt_departue_time.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_departue_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_departue_time.Location = New System.Drawing.Point(146, 144)
        Me.txt_departue_time.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_departue_time.Name = "txt_departue_time"
        Me.txt_departue_time.Size = New System.Drawing.Size(110, 29)
        Me.txt_departue_time.TabIndex = 7
        Me.txt_departue_time.Value = New Date(2023, 2, 7, 9, 3, 0, 0)
        '
        'txt_arrival_time
        '
        Me.txt_arrival_time.CustomFormat = "HH:mm"
        Me.txt_arrival_time.Enabled = False
        Me.txt_arrival_time.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_arrival_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_arrival_time.Location = New System.Drawing.Point(255, 144)
        Me.txt_arrival_time.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_arrival_time.Name = "txt_arrival_time"
        Me.txt_arrival_time.Size = New System.Drawing.Size(98, 29)
        Me.txt_arrival_time.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(1)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 41
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Column6, Me.Column7})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(967, 19)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.NullValue = Nothing
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(409, 305)
        Me.DataGridView1.TabIndex = 69
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 102
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.HeaderText = "Flight No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn9.FillWeight = 220.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Commander"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 112
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "###,##"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn10.HeaderText = "Pilot"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 63
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "###,##"
        DataGridViewCellStyle9.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column6.HeaderText = "View Report"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 112
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "###,##"
        DataGridViewCellStyle10.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column7.HeaderText = "Delete"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 75
        '
        'FrmFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1383, 770)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_arrival_time)
        Me.Controls.Add(Me.txt_departue_time)
        Me.Controls.Add(Me.txt_emergency_description)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txt_humidity)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txt_flight_location)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.cmb_emergency)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txt_precipition)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txt_wind_speed)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_gps)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmb_aircraft_no)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmb_pilots)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.cmb_aircraft_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_max_height)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_farther_range)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_aircraft_weight)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_battary_r_l_after)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_battary_r_l_before)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_engine_battary_after)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_engine_battary_before)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_main_battary_after)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_main_battary_before)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_fuel_after)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_temperature)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_landing_no)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_flight_no)
        Me.Controls.Add(Me.cmb_mission_commander)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_flight_duration)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_fuel_before)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_flight_id)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFlights"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Flights"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_flight_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_fuel_before As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_flight_duration As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_mission_commander As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_flight_no As TextBox
    Friend WithEvents txt_date As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_landing_no As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_temperature As TextBox
    Friend WithEvents txt_fuel_after As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_main_battary_before As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_main_battary_after As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_engine_battary_before As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_engine_battary_after As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_battary_r_l_before As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_battary_r_l_after As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_aircraft_weight As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_farther_range As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_max_height As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents cmb_aircraft_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_pilots As ComboBox
    Friend WithEvents cmb_aircraft_no As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_gps As TextBox
    Friend WithEvents txt_wind_speed As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_precipition As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cmb_emergency As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txt_flight_location As MaskedTextBox
    Friend WithEvents txt_humidity As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txt_emergency_description As TextBox
    Friend WithEvents txt_departue_time As DateTimePicker
    Friend WithEvents txt_arrival_time As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewButtonColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents aircaft_id As DataGridViewTextBoxColumn
    Friend WithEvents aircraft_type As DataGridViewTextBoxColumn
    Friend WithEvents aircaft_No As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
