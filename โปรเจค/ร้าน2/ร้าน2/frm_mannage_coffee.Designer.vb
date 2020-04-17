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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.openfile_coffee = New System.Windows.Forms.OpenFileDialog()
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid_coffee
        '
        Me.datagrid_coffee.AllowUserToAddRows = False
        Me.datagrid_coffee.AllowUserToDeleteRows = False
        Me.datagrid_coffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_coffee.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.datagrid_coffee.Location = New System.Drawing.Point(12, 76)
        Me.datagrid_coffee.Name = "datagrid_coffee"
        Me.datagrid_coffee.ReadOnly = True
        Me.datagrid_coffee.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Angsana New", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.datagrid_coffee.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid_coffee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_coffee.Size = New System.Drawing.Size(433, 547)
        Me.datagrid_coffee.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Angsana New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.Location = New System.Drawing.Point(88, 18)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(357, 48)
        Me.txt_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(542, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 596)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(640, 570)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่มกาแฟ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_addnew
        '
        Me.btn_addnew.Location = New System.Drawing.Point(305, 527)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(100, 37)
        Me.btn_addnew.TabIndex = 13
        Me.btn_addnew.Text = "บันทึก"
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'btn_select_picture
        '
        Me.btn_select_picture.Location = New System.Drawing.Point(541, 483)
        Me.btn_select_picture.Name = "btn_select_picture"
        Me.btn_select_picture.Size = New System.Drawing.Size(82, 28)
        Me.btn_select_picture.TabIndex = 12
        Me.btn_select_picture.Text = "เลือกภาพ"
        Me.btn_select_picture.UseVisualStyleBackColor = True
        '
        'pic_add
        '
        Me.pic_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_add.Location = New System.Drawing.Point(353, 218)
        Me.pic_add.Name = "pic_add"
        Me.pic_add.Size = New System.Drawing.Size(270, 259)
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
        Me.GroupBox1.Location = New System.Drawing.Point(38, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 273)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ราคากาแฟ"
        '
        'txt_add_cool
        '
        Me.txt_add_cool.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_cool.Location = New System.Drawing.Point(152, 127)
        Me.txt_add_cool.Name = "txt_add_cool"
        Me.txt_add_cool.Size = New System.Drawing.Size(121, 45)
        Me.txt_add_cool.TabIndex = 9
        '
        'txt_add_spin
        '
        Me.txt_add_spin.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_spin.Location = New System.Drawing.Point(152, 215)
        Me.txt_add_spin.Name = "txt_add_spin"
        Me.txt_add_spin.Size = New System.Drawing.Size(125, 45)
        Me.txt_add_spin.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 37)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ราคาปั่น"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ราคาเย็น"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 37)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ราคาร้อน"
        '
        'txt_add_hot
        '
        Me.txt_add_hot.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_hot.Location = New System.Drawing.Point(152, 46)
        Me.txt_add_hot.Name = "txt_add_hot"
        Me.txt_add_hot.Size = New System.Drawing.Size(125, 45)
        Me.txt_add_hot.TabIndex = 4
        '
        'txt_add_name
        '
        Me.txt_add_name.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_name.Location = New System.Drawing.Point(166, 116)
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(301, 45)
        Me.txt_add_name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ชื่อกาแฟ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัส"
        '
        'txt_add_id
        '
        Me.txt_add_id.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_add_id.Location = New System.Drawing.Point(166, 28)
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.Size = New System.Drawing.Size(301, 45)
        Me.txt_add_id.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(640, 570)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไขกาแฟ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(640, 570)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบกาแฟ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'openfile_coffee
        '
        Me.openfile_coffee.Filter = "JPEG |*.jpg"
        '
        'frm_mannage_coffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1257, 643)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.datagrid_coffee)
        Me.Name = "frm_mannage_coffee"
        Me.Text = "จัดการกาแฟ"
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
