<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmParts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParts))
        Me.Gbx1 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Partname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaxTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RSBName = New System.Windows.Forms.RadioButton()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.st_bar = New System.Windows.Forms.StatusStrip()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Gbx2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_current_time = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_max_time = New System.Windows.Forms.NumericUpDown()
        Me.txt_part_number = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_part_name = New System.Windows.Forms.TextBox()
        Me.txt_part_id = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbMainCat = New System.Windows.Forms.ComboBox()
        Me.Gbx1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Gbx2.SuspendLayout()
        CType(Me.txt_current_time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_max_time, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx1
        '
        Me.Gbx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx1.Controls.Add(Me.StatusStrip1)
        Me.Gbx1.Controls.Add(Me.DataGridView1)
        Me.Gbx1.Controls.Add(Me.RSBName)
        Me.Gbx1.Controls.Add(Me.TextBox5)
        Me.Gbx1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Gbx1.Location = New System.Drawing.Point(16, 310)
        Me.Gbx1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gbx1.Name = "Gbx1"
        Me.Gbx1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gbx1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Gbx1.Size = New System.Drawing.Size(699, 285)
        Me.Gbx1.TabIndex = 17
        Me.Gbx1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(4, 258)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(691, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Partname, Me.PartNumber, Me.MaxTime, Me.CurrentTime})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 53)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(681, 188)
        Me.DataGridView1.TabIndex = 20
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 51
        '
        'Partname
        '
        Me.Partname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Partname.HeaderText = "Part Name"
        Me.Partname.Name = "Partname"
        Me.Partname.ReadOnly = True
        Me.Partname.Width = 90
        '
        'PartNumber
        '
        Me.PartNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PartNumber.HeaderText = "Part Number"
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.ReadOnly = True
        Me.PartNumber.Width = 101
        '
        'MaxTime
        '
        Me.MaxTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.MaxTime.HeaderText = "Max Time"
        Me.MaxTime.Name = "MaxTime"
        Me.MaxTime.ReadOnly = True
        Me.MaxTime.Width = 86
        '
        'CurrentTime
        '
        Me.CurrentTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CurrentTime.HeaderText = "Current Time"
        Me.CurrentTime.Name = "CurrentTime"
        Me.CurrentTime.ReadOnly = True
        Me.CurrentTime.Width = 103
        '
        'RSBName
        '
        Me.RSBName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RSBName.Checked = True
        Me.RSBName.Location = New System.Drawing.Point(6, 26)
        Me.RSBName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RSBName.Name = "RSBName"
        Me.RSBName.Size = New System.Drawing.Size(94, 23)
        Me.RSBName.TabIndex = 8
        Me.RSBName.TabStop = True
        Me.RSBName.Text = "Search"
        Me.RSBName.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(79, 26)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox5.MaxLength = 255
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(611, 21)
        Me.TextBox5.TabIndex = 12
        '
        'st_bar
        '
        Me.st_bar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.st_bar.Location = New System.Drawing.Point(12, 578)
        Me.st_bar.Name = "st_bar"
        Me.st_bar.Padding = New System.Windows.Forms.Padding(22, 0, 1, 0)
        Me.st_bar.Size = New System.Drawing.Size(707, 22)
        Me.st_bar.TabIndex = 16
        Me.st_bar.Text = "StatusStrip1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Gbx2)
        Me.GroupBox2.Controls.Add(Me.btnUnlock)
        Me.GroupBox2.Controls.Add(Me.btnLock)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbMainCat)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GroupBox2.Size = New System.Drawing.Size(708, 288)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.Yellow
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_id.Location = New System.Drawing.Point(368, 51)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(78, 21)
        Me.txt_id.TabIndex = 1
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Gbx2
        '
        Me.Gbx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Gbx2.Controls.Add(Me.Label1)
        Me.Gbx2.Controls.Add(Me.Label4)
        Me.Gbx2.Controls.Add(Me.txt_current_time)
        Me.Gbx2.Controls.Add(Me.Label3)
        Me.Gbx2.Controls.Add(Me.txt_max_time)
        Me.Gbx2.Controls.Add(Me.txt_part_number)
        Me.Gbx2.Controls.Add(Me.Label2)
        Me.Gbx2.Controls.Add(Me.txt_part_name)
        Me.Gbx2.Controls.Add(Me.txt_part_id)
        Me.Gbx2.Controls.Add(Me.TableLayoutPanel1)
        Me.Gbx2.Enabled = False
        Me.Gbx2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Gbx2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx2.Location = New System.Drawing.Point(15, 100)
        Me.Gbx2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Gbx2.Name = "Gbx2"
        Me.Gbx2.Padding = New System.Windows.Forms.Padding(18, 15, 18, 15)
        Me.Gbx2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Gbx2.Size = New System.Drawing.Size(678, 188)
        Me.Gbx2.TabIndex = 35
        Me.Gbx2.TabStop = False
        Me.Gbx2.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 19)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Part Name"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(451, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 19)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Current Operating Time / Hours"
        '
        'txt_current_time
        '
        Me.txt_current_time.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_current_time.Location = New System.Drawing.Point(453, 91)
        Me.txt_current_time.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_current_time.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.txt_current_time.Name = "txt_current_time"
        Me.txt_current_time.Size = New System.Drawing.Size(194, 21)
        Me.txt_current_time.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(275, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Max Operating Time / Hours"
        '
        'txt_max_time
        '
        Me.txt_max_time.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_time.Location = New System.Drawing.Point(278, 91)
        Me.txt_max_time.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_max_time.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.txt_max_time.Name = "txt_max_time"
        Me.txt_max_time.Size = New System.Drawing.Size(164, 21)
        Me.txt_max_time.TabIndex = 64
        '
        'txt_part_number
        '
        Me.txt_part_number.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_part_number.Enabled = False
        Me.txt_part_number.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_part_number.Location = New System.Drawing.Point(12, 90)
        Me.txt_part_number.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_part_number.MaxLength = 255
        Me.txt_part_number.Name = "txt_part_number"
        Me.txt_part_number.Size = New System.Drawing.Size(256, 21)
        Me.txt_part_number.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 19)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Part Number"
        '
        'txt_part_name
        '
        Me.txt_part_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_part_name.Enabled = False
        Me.txt_part_name.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_part_name.Location = New System.Drawing.Point(9, 37)
        Me.txt_part_name.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_part_name.MaxLength = 255
        Me.txt_part_name.Name = "txt_part_name"
        Me.txt_part_name.Size = New System.Drawing.Size(220, 21)
        Me.txt_part_name.TabIndex = 60
        '
        'txt_part_id
        '
        Me.txt_part_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_part_id.Enabled = False
        Me.txt_part_id.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_part_id.Location = New System.Drawing.Point(239, 37)
        Me.txt_part_id.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_part_id.Name = "txt_part_id"
        Me.txt_part_id.Size = New System.Drawing.Size(114, 20)
        Me.txt_part_id.TabIndex = 62
        Me.txt_part_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.3662!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.60563!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.84507!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.3169!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.78873!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_close, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_edit, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 115)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(663, 61)
        Me.TableLayoutPanel1.TabIndex = 54
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(250, 7)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_cancel.Size = New System.Drawing.Size(95, 47)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.ImageKey = "delete.png"
        Me.btn_delete.ImageList = Me.ImageList1
        Me.btn_delete.Location = New System.Drawing.Point(141, 7)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_delete.Size = New System.Drawing.Size(91, 47)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "printer.ico")
        Me.ImageList1.Images.SetKeyName(1, "008_Reminder.ico")
        Me.ImageList1.Images.SetKeyName(2, "112_ArrowReturnLeft_Blue.ico")
        Me.ImageList1.Images.SetKeyName(3, "112_ArrowReturnRight_Blue.ico")
        Me.ImageList1.Images.SetKeyName(4, "112_LeftArrowShort_Blue.ico")
        Me.ImageList1.Images.SetKeyName(5, "112_LeftArrowShort_Green.ico")
        Me.ImageList1.Images.SetKeyName(6, "174_magnify_uncompressed.ico")
        Me.ImageList1.Images.SetKeyName(7, "1507_ParallelPort.ico")
        Me.ImageList1.Images.SetKeyName(8, "Annotate_Default.ico")
        Me.ImageList1.Images.SetKeyName(9, "Annotate_Error.ico")
        Me.ImageList1.Images.SetKeyName(10, "Saki-Snowish-Actions-edit-clear.ico")
        Me.ImageList1.Images.SetKeyName(11, "Icons8-Ios7-Ecommerce-Clear-Shopping-Cart.ico")
        Me.ImageList1.Images.SetKeyName(12, "Icons8-Ios7-Finance-Pos-Terminal.ico")
        Me.ImageList1.Images.SetKeyName(13, "Icons8-Ios7-Ecommerce-Barcode-Scanner.ico")
        Me.ImageList1.Images.SetKeyName(14, "112_Plus_Green.ico")
        Me.ImageList1.Images.SetKeyName(15, "delete.png")
        Me.ImageList1.Images.SetKeyName(16, "delete1.png")
        Me.ImageList1.Images.SetKeyName(17, "edit.png")
        Me.ImageList1.Images.SetKeyName(18, "login.png")
        Me.ImageList1.Images.SetKeyName(19, "logout.png")
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_close.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.ImageKey = "logout.png"
        Me.btn_close.ImageList = Me.ImageList1
        Me.btn_close.Location = New System.Drawing.Point(556, 7)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_close.Size = New System.Drawing.Size(99, 47)
        Me.btn_close.TabIndex = 19
        Me.btn_close.Text = "Exit"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(458, 7)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_edit.Size = New System.Drawing.Size(83, 47)
        Me.btn_edit.TabIndex = 18
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(356, 7)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_save.Size = New System.Drawing.Size(89, 47)
        Me.btn_save.TabIndex = 15
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.ImageKey = "login.png"
        Me.btn_add.ImageList = Me.ImageList1
        Me.btn_add.Location = New System.Drawing.Point(5, 7)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_add.Size = New System.Drawing.Size(118, 47)
        Me.btn_add.TabIndex = 14
        Me.btn_add.Text = "Add New"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUnlock
        '
        Me.btnUnlock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnUnlock.Image = Global.AirC.My.Resources.Resources.delete1
        Me.btnUnlock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUnlock.Location = New System.Drawing.Point(565, 51)
        Me.btnUnlock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(118, 29)
        Me.btnUnlock.TabIndex = 2
        Me.btnUnlock.Text = "Cancel"
        Me.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnLock.Image = CType(resources.GetObject("btnLock.Image"), System.Drawing.Image)
        Me.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLock.Location = New System.Drawing.Point(454, 51)
        Me.btnLock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(104, 29)
        Me.btnLock.TabIndex = 3
        Me.btnLock.Text = "Select"
        Me.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Aircraft Name"
        '
        'cmbMainCat
        '
        Me.cmbMainCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMainCat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbMainCat.FormattingEnabled = True
        Me.cmbMainCat.Location = New System.Drawing.Point(15, 53)
        Me.cmbMainCat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbMainCat.Name = "cmbMainCat"
        Me.cmbMainCat.Size = New System.Drawing.Size(344, 21)
        Me.cmbMainCat.TabIndex = 0
        '
        'FrmParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 610)
        Me.Controls.Add(Me.Gbx1)
        Me.Controls.Add(Me.st_bar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmParts"
        Me.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aircraft Parts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Gbx1.ResumeLayout(False)
        Me.Gbx1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Gbx2.ResumeLayout(False)
        Me.Gbx2.PerformLayout()
        CType(Me.txt_current_time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_max_time, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gbx1 As GroupBox
    Friend WithEvents st_bar As StatusStrip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RSBName As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnUnlock As Button
    Friend WithEvents btnLock As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbMainCat As ComboBox
    Friend WithEvents Gbx2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_id As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_current_time As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_max_time As NumericUpDown
    Friend WithEvents txt_part_number As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_part_name As TextBox
    Friend WithEvents txt_part_id As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Partname As DataGridViewTextBoxColumn
    Friend WithEvents PartNumber As DataGridViewTextBoxColumn
    Friend WithEvents MaxTime As DataGridViewTextBoxColumn
    Friend WithEvents CurrentTime As DataGridViewTextBoxColumn
End Class
