<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_users))
        Me.datagrid_search = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_show_email = New System.Windows.Forms.TextBox()
        Me.txt_show_tel = New System.Windows.Forms.TextBox()
        Me.txt_show_username = New System.Windows.Forms.TextBox()
        Me.txt_show_password = New System.Windows.Forms.TextBox()
        Me.txt_show_lastname = New System.Windows.Forms.TextBox()
        Me.txt_show_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear_edit = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txt_edit_email = New System.Windows.Forms.TextBox()
        Me.txt_edit_tel = New System.Windows.Forms.TextBox()
        Me.txt_edit_username = New System.Windows.Forms.TextBox()
        Me.txt_edit_password = New System.Windows.Forms.TextBox()
        Me.txt_edit_lastname = New System.Windows.Forms.TextBox()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid_search
        '
        Me.datagrid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_search.Dock = System.Windows.Forms.DockStyle.Left
        Me.datagrid_search.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_search.Name = "datagrid_search"
        Me.datagrid_search.Size = New System.Drawing.Size(339, 594)
        Me.datagrid_search.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(339, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(541, 594)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_show_email)
        Me.TabPage1.Controls.Add(Me.txt_show_tel)
        Me.TabPage1.Controls.Add(Me.txt_show_username)
        Me.TabPage1.Controls.Add(Me.txt_show_password)
        Me.TabPage1.Controls.Add(Me.txt_show_lastname)
        Me.TabPage1.Controls.Add(Me.txt_show_name)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(533, 568)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "แสดงข้อมูล"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_show_email
        '
        Me.txt_show_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_show_email.Location = New System.Drawing.Point(209, 244)
        Me.txt_show_email.Name = "txt_show_email"
        Me.txt_show_email.Size = New System.Drawing.Size(225, 29)
        Me.txt_show_email.TabIndex = 24
        '
        'txt_show_tel
        '
        Me.txt_show_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_show_tel.Location = New System.Drawing.Point(209, 292)
        Me.txt_show_tel.Name = "txt_show_tel"
        Me.txt_show_tel.Size = New System.Drawing.Size(225, 29)
        Me.txt_show_tel.TabIndex = 23
        '
        'txt_show_username
        '
        Me.txt_show_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_show_username.Location = New System.Drawing.Point(209, 346)
        Me.txt_show_username.Name = "txt_show_username"
        Me.txt_show_username.Size = New System.Drawing.Size(225, 29)
        Me.txt_show_username.TabIndex = 22
        '
        'txt_show_password
        '
        Me.txt_show_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_show_password.Location = New System.Drawing.Point(209, 398)
        Me.txt_show_password.Name = "txt_show_password"
        Me.txt_show_password.Size = New System.Drawing.Size(225, 29)
        Me.txt_show_password.TabIndex = 21
        '
        'txt_show_lastname
        '
        Me.txt_show_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_show_lastname.Location = New System.Drawing.Point(209, 192)
        Me.txt_show_lastname.Name = "txt_show_lastname"
        Me.txt_show_lastname.Size = New System.Drawing.Size(225, 29)
        Me.txt_show_lastname.TabIndex = 20
        '
        'txt_show_name
        '
        Me.txt_show_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_show_name.Location = New System.Drawing.Point(209, 142)
        Me.txt_show_name.Name = "txt_show_name"
        Me.txt_show_name.Size = New System.Drawing.Size(225, 29)
        Me.txt_show_name.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(99, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 24)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(99, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "เบอร์โทร"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(99, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 24)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "อีเมล"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(99, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 24)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "นามสกุล"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(99, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 24)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "ชื่อ"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(533, 568)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "เพิ่มข้อมูล"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.txt_tel)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.txt_lastname)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 420)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(222, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 44)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 44)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_email.Location = New System.Drawing.Point(134, 123)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(225, 29)
        Me.txt_email.TabIndex = 12
        '
        'txt_tel
        '
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(134, 171)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(225, 29)
        Me.txt_tel.TabIndex = 11
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_username.Location = New System.Drawing.Point(134, 225)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(225, 29)
        Me.txt_username.TabIndex = 10
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_password.Location = New System.Drawing.Point(134, 277)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(225, 29)
        Me.txt_password.TabIndex = 8
        '
        'txt_lastname
        '
        Me.txt_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_lastname.Location = New System.Drawing.Point(134, 71)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(225, 29)
        Me.txt_lastname.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name.Location = New System.Drawing.Point(134, 21)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(225, 29)
        Me.txt_name.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "เบอร์โทร"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "อีเมล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "นามสกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_delete)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(533, 568)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบข้อมูล"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(142, 189)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(219, 78)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "ลบ"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(533, 568)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "แก้ข้อมูล"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.btn_clear_edit)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.txt_edit_email)
        Me.GroupBox2.Controls.Add(Me.txt_edit_tel)
        Me.GroupBox2.Controls.Add(Me.txt_edit_username)
        Me.GroupBox2.Controls.Add(Me.txt_edit_password)
        Me.GroupBox2.Controls.Add(Me.txt_edit_lastname)
        Me.GroupBox2.Controls.Add(Me.txt_edit_name)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 420)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'btn_clear_edit
        '
        Me.btn_clear_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_clear_edit.Location = New System.Drawing.Point(222, 350)
        Me.btn_clear_edit.Name = "btn_clear_edit"
        Me.btn_clear_edit.Size = New System.Drawing.Size(128, 44)
        Me.btn_clear_edit.TabIndex = 14
        Me.btn_clear_edit.Text = "clear"
        Me.btn_clear_edit.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(28, 350)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(128, 44)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "save"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'txt_edit_email
        '
        Me.txt_edit_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_email.Location = New System.Drawing.Point(134, 123)
        Me.txt_edit_email.Name = "txt_edit_email"
        Me.txt_edit_email.Size = New System.Drawing.Size(225, 29)
        Me.txt_edit_email.TabIndex = 12
        '
        'txt_edit_tel
        '
        Me.txt_edit_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_tel.Location = New System.Drawing.Point(134, 171)
        Me.txt_edit_tel.Name = "txt_edit_tel"
        Me.txt_edit_tel.Size = New System.Drawing.Size(225, 29)
        Me.txt_edit_tel.TabIndex = 11
        '
        'txt_edit_username
        '
        Me.txt_edit_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_username.Location = New System.Drawing.Point(134, 225)
        Me.txt_edit_username.Name = "txt_edit_username"
        Me.txt_edit_username.Size = New System.Drawing.Size(225, 29)
        Me.txt_edit_username.TabIndex = 10
        '
        'txt_edit_password
        '
        Me.txt_edit_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_password.Location = New System.Drawing.Point(134, 277)
        Me.txt_edit_password.Name = "txt_edit_password"
        Me.txt_edit_password.Size = New System.Drawing.Size(225, 29)
        Me.txt_edit_password.TabIndex = 8
        '
        'txt_edit_lastname
        '
        Me.txt_edit_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_lastname.Location = New System.Drawing.Point(134, 71)
        Me.txt_edit_lastname.Name = "txt_edit_lastname"
        Me.txt_edit_lastname.Size = New System.Drawing.Size(225, 29)
        Me.txt_edit_lastname.TabIndex = 7
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_edit_name.Location = New System.Drawing.Point(134, 21)
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(225, 29)
        Me.txt_edit_name.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 24)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 223)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 24)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "username"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 24)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "เบอร์โทร"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 24)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "อีเมล"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 24)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "นามสกุล"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 24)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "ชื่อ"
        '
        'frm_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(880, 594)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.datagrid_search)
        Me.Name = "frm_users"
        Me.Text = "frm_users"
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagrid_search As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_show_email As TextBox
    Friend WithEvents txt_show_tel As TextBox
    Friend WithEvents txt_show_username As TextBox
    Friend WithEvents txt_show_password As TextBox
    Friend WithEvents txt_show_lastname As TextBox
    Friend WithEvents txt_show_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_delete As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_clear_edit As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents txt_edit_email As TextBox
    Friend WithEvents txt_edit_tel As TextBox
    Friend WithEvents txt_edit_username As TextBox
    Friend WithEvents txt_edit_password As TextBox
    Friend WithEvents txt_edit_lastname As TextBox
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
