<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mannage_coffee
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mannage_coffee))
        Me.datagrid_coffee = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.btn_select_picture = New System.Windows.Forms.Button()
        Me.pic_add = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_add_cool = New System.Windows.Forms.TextBox()
        Me.txt_add_spin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_add_hot = New System.Windows.Forms.TextBox()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_add_id = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn_save_edit = New System.Windows.Forms.Button()
        Me.btn_select_edit_picture = New System.Windows.Forms.Button()
        Me.pic_edit = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_edit_cool = New System.Windows.Forms.TextBox()
        Me.txt_edit_spin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_edit_hot = New System.Windows.Forms.TextBox()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_edit_id = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_confirm = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.openfile_coffee = New System.Windows.Forms.OpenFileDialog()
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.pic_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid_coffee
        '
        Me.datagrid_coffee.AllowUserToAddRows = False
        Me.datagrid_coffee.AllowUserToDeleteRows = False
        Me.datagrid_coffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_coffee.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.datagrid_coffee.Location = New System.Drawing.Point(16, 94)
        Me.datagrid_coffee.Margin = New System.Windows.Forms.Padding(4)
        Me.datagrid_coffee.Name = "datagrid_coffee"
        Me.datagrid_coffee.ReadOnly = True
        Me.datagrid_coffee.RowHeadersVisible = False
        Me.datagrid_coffee.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Angsana New", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.datagrid_coffee.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_coffee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_coffee.Size = New System.Drawing.Size(577, 673)
        Me.datagrid_coffee.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Angsana New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.Location = New System.Drawing.Point(117, 22)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(475, 58)
        Me.txt_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 47)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(723, 33)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 734)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.btn_addnew)
        Me.TabPage1.Controls.Add(Me.btn_select_picture)
        Me.TabPage1.Controls.Add(Me.pic_add)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txt_add_name)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_add_id)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(856, 705)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่มกาแฟ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_addnew
        '
        Me.btn_addnew.BackColor = System.Drawing.SystemColors.Control
        Me.btn_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addnew.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.Location = New System.Drawing.Point(405, 629)
        Me.btn_addnew.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(133, 46)
        Me.btn_addnew.TabIndex = 13
        Me.btn_addnew.Text = "บันทึก"
        Me.btn_addnew.UseVisualStyleBackColor = False
        '
        'btn_select_picture
        '
        Me.btn_select_picture.BackColor = System.Drawing.SystemColors.Control
        Me.btn_select_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select_picture.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select_picture.Location = New System.Drawing.Point(721, 594)
        Me.btn_select_picture.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_select_picture.Name = "btn_select_picture"
        Me.btn_select_picture.Size = New System.Drawing.Size(109, 45)
        Me.btn_select_picture.TabIndex = 12
        Me.btn_select_picture.Text = "เลือกภาพ"
        Me.btn_select_picture.UseVisualStyleBackColor = False
        '
        'pic_add
        '
        Me.pic_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_add.Location = New System.Drawing.Point(471, 268)
        Me.pic_add.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_add.Name = "pic_add"
        Me.pic_add.Size = New System.Drawing.Size(359, 318)
        Me.pic_add.TabIndex = 11
        Me.pic_add.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_add_cool)
        Me.GroupBox1.Controls.Add(Me.txt_add_spin)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_add_hot)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(51, 251)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(412, 336)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ราคากาแฟ"
        '
        'txt_add_cool
        '
        Me.txt_add_cool.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_cool.Location = New System.Drawing.Point(203, 156)
        Me.txt_add_cool.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_add_cool.Name = "txt_add_cool"
        Me.txt_add_cool.Size = New System.Drawing.Size(160, 54)
        Me.txt_add_cool.TabIndex = 9
        '
        'txt_add_spin
        '
        Me.txt_add_spin.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_spin.Location = New System.Drawing.Point(203, 265)
        Me.txt_add_spin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_add_spin.Name = "txt_add_spin"
        Me.txt_add_spin.Size = New System.Drawing.Size(165, 54)
        Me.txt_add_spin.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 265)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 47)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ราคาปั่น"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 47)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ราคาเย็น"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 47)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ราคาร้อน"
        '
        'txt_add_hot
        '
        Me.txt_add_hot.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_hot.Location = New System.Drawing.Point(203, 57)
        Me.txt_add_hot.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_add_hot.Name = "txt_add_hot"
        Me.txt_add_hot.Size = New System.Drawing.Size(165, 54)
        Me.txt_add_hot.TabIndex = 4
        '
        'txt_add_name
        '
        Me.txt_add_name.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_name.Location = New System.Drawing.Point(221, 143)
        Me.txt_add_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(400, 54)
        Me.txt_add_name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 47)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ชื่อกาแฟ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัส"
        '
        'txt_add_id
        '
        Me.txt_add_id.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_id.Location = New System.Drawing.Point(221, 34)
        Me.txt_add_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.Size = New System.Drawing.Size(400, 54)
        Me.txt_add_id.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(856, 705)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไขกาแฟ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(-5, -16)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(864, 734)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.Controls.Add(Me.btn_save_edit)
        Me.TabPage4.Controls.Add(Me.btn_select_edit_picture)
        Me.TabPage4.Controls.Add(Me.pic_edit)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.txt_edit_name)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.txt_edit_id)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(856, 705)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "เพิ่มกาแฟ"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btn_save_edit
        '
        Me.btn_save_edit.Location = New System.Drawing.Point(412, 638)
        Me.btn_save_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save_edit.Name = "btn_save_edit"
        Me.btn_save_edit.Size = New System.Drawing.Size(133, 46)
        Me.btn_save_edit.TabIndex = 13
        Me.btn_save_edit.Text = "แก้ไข"
        Me.btn_save_edit.UseVisualStyleBackColor = True
        '
        'btn_select_edit_picture
        '
        Me.btn_select_edit_picture.Location = New System.Drawing.Point(721, 594)
        Me.btn_select_edit_picture.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_select_edit_picture.Name = "btn_select_edit_picture"
        Me.btn_select_edit_picture.Size = New System.Drawing.Size(109, 34)
        Me.btn_select_edit_picture.TabIndex = 12
        Me.btn_select_edit_picture.Text = "เลือกภาพ"
        Me.btn_select_edit_picture.UseVisualStyleBackColor = True
        '
        'pic_edit
        '
        Me.pic_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_edit.Location = New System.Drawing.Point(471, 268)
        Me.pic_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_edit.Name = "pic_edit"
        Me.pic_edit.Size = New System.Drawing.Size(359, 318)
        Me.pic_edit.TabIndex = 11
        Me.pic_edit.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_edit_cool)
        Me.GroupBox2.Controls.Add(Me.txt_edit_spin)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_edit_hot)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(51, 251)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(412, 336)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ราคากาแฟ"
        '
        'txt_edit_cool
        '
        Me.txt_edit_cool.BackColor = System.Drawing.SystemColors.Control
        Me.txt_edit_cool.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_cool.Location = New System.Drawing.Point(203, 156)
        Me.txt_edit_cool.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_edit_cool.Name = "txt_edit_cool"
        Me.txt_edit_cool.Size = New System.Drawing.Size(160, 54)
        Me.txt_edit_cool.TabIndex = 9
        '
        'txt_edit_spin
        '
        Me.txt_edit_spin.BackColor = System.Drawing.SystemColors.Control
        Me.txt_edit_spin.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_spin.Location = New System.Drawing.Point(203, 265)
        Me.txt_edit_spin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_edit_spin.Name = "txt_edit_spin"
        Me.txt_edit_spin.Size = New System.Drawing.Size(165, 54)
        Me.txt_edit_spin.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 265)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 47)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ราคาปั่น"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 156)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 47)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ราคาเย็น"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 57)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 47)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "ราคาร้อน"
        '
        'txt_edit_hot
        '
        Me.txt_edit_hot.BackColor = System.Drawing.SystemColors.Control
        Me.txt_edit_hot.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_hot.Location = New System.Drawing.Point(203, 57)
        Me.txt_edit_hot.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_edit_hot.Name = "txt_edit_hot"
        Me.txt_edit_hot.Size = New System.Drawing.Size(165, 54)
        Me.txt_edit_hot.TabIndex = 4
        '
        'txt_edit_name
        '
        Me.txt_edit_name.BackColor = System.Drawing.SystemColors.Control
        Me.txt_edit_name.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_name.Location = New System.Drawing.Point(221, 143)
        Me.txt_edit_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(400, 54)
        Me.txt_edit_name.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 143)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 47)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "ชื่อกาแฟ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 34)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 47)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "รหัส"
        '
        'txt_edit_id
        '
        Me.txt_edit_id.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_id.Location = New System.Drawing.Point(221, 34)
        Me.txt_edit_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_edit_id.Name = "txt_edit_id"
        Me.txt_edit_id.ReadOnly = True
        Me.txt_edit_id.Size = New System.Drawing.Size(400, 54)
        Me.txt_edit_id.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Size = New System.Drawing.Size(856, 705)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "แก้ไขกาแฟ"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(856, 705)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "ลบกาแฟ"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_confirm)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.btn_delete)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(856, 705)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบกาแฟ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_confirm
        '
        Me.txt_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_confirm.Location = New System.Drawing.Point(235, 229)
        Me.txt_confirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_confirm.Name = "txt_confirm"
        Me.txt_confirm.Size = New System.Drawing.Size(351, 49)
        Me.txt_confirm.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(215, 84)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(413, 39)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "กรุณาพิมพ์คำว่า ""ยืนยันการลบ"""
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.Control
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(293, 522)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(216, 120)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'openfile_coffee
        '
        Me.openfile_coffee.Filter = "JPEG |*.jpg"
        '
        'frm_mannage_coffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1676, 791)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.datagrid_coffee)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_mannage_coffee"
        Me.Text = "จัดการกาแฟ"
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.pic_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagrid_coffee As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_select_picture As Button
    Friend WithEvents pic_add As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_add_cool As TextBox
    Friend WithEvents txt_add_spin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_add_hot As TextBox
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_add_id As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_addnew As Button
    Friend WithEvents openfile_coffee As OpenFileDialog
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btn_save_edit As Button
    Friend WithEvents btn_select_edit_picture As Button
    Friend WithEvents pic_edit As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_edit_cool As TextBox
    Friend WithEvents txt_edit_spin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_edit_hot As TextBox
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_edit_id As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txt_confirm As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_delete As Button
End Class
