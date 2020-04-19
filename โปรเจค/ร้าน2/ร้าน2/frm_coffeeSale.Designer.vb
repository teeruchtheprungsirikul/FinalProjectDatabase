<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_coffeeSale
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_sale_id = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_purchase = New System.Windows.Forms.Button()
        Me.btn_delete_all = New System.Windows.Forms.Button()
        Me.btn_select_delete = New System.Windows.Forms.Button()
        Me.listview_sale = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_date_sale = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.rad_cool = New System.Windows.Forms.RadioButton()
        Me.rad_spin = New System.Windows.Forms.RadioButton()
        Me.rad_hot = New System.Windows.Forms.RadioButton()
        Me.txt_coffee_amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_coffee_id = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbl_sale_id)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(660, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 738)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 59)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ค้นหา"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.Location = New System.Drawing.Point(95, 8)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(369, 40)
        Me.txt_search.TabIndex = 0
        '
        'lbl_sale_id
        '
        Me.lbl_sale_id.HideSelection = False
        Me.lbl_sale_id.LargeImageList = Me.ImageList1
        Me.lbl_sale_id.Location = New System.Drawing.Point(3, 65)
        Me.lbl_sale_id.Name = "lbl_sale_id"
        Me.lbl_sale_id.Size = New System.Drawing.Size(495, 580)
        Me.lbl_sale_id.TabIndex = 0
        Me.lbl_sale_id.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(100, 80)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_purchase)
        Me.Panel3.Controls.Add(Me.btn_delete_all)
        Me.Panel3.Controls.Add(Me.btn_select_delete)
        Me.Panel3.Controls.Add(Me.listview_sale)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(660, 738)
        Me.Panel3.TabIndex = 1
        '
        'btn_purchase
        '
        Me.btn_purchase.Location = New System.Drawing.Point(547, 689)
        Me.btn_purchase.Name = "btn_purchase"
        Me.btn_purchase.Size = New System.Drawing.Size(94, 26)
        Me.btn_purchase.TabIndex = 4
        Me.btn_purchase.Text = "คิดเงิน"
        Me.btn_purchase.UseVisualStyleBackColor = True
        '
        'btn_delete_all
        '
        Me.btn_delete_all.Location = New System.Drawing.Point(130, 689)
        Me.btn_delete_all.Name = "btn_delete_all"
        Me.btn_delete_all.Size = New System.Drawing.Size(94, 26)
        Me.btn_delete_all.TabIndex = 3
        Me.btn_delete_all.Text = "ลบทั้งหมด"
        Me.btn_delete_all.UseVisualStyleBackColor = True
        '
        'btn_select_delete
        '
        Me.btn_select_delete.Location = New System.Drawing.Point(11, 689)
        Me.btn_select_delete.Name = "btn_select_delete"
        Me.btn_select_delete.Size = New System.Drawing.Size(94, 26)
        Me.btn_select_delete.TabIndex = 2
        Me.btn_select_delete.Text = "ลบที่เลือก"
        Me.btn_select_delete.UseVisualStyleBackColor = True
        '
        'listview_sale
        '
        Me.listview_sale.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.listview_sale.FullRowSelect = True
        Me.listview_sale.GridLines = True
        Me.listview_sale.HideSelection = False
        Me.listview_sale.Location = New System.Drawing.Point(3, 198)
        Me.listview_sale.Name = "listview_sale"
        Me.listview_sale.Size = New System.Drawing.Size(647, 485)
        Me.listview_sale.TabIndex = 1
        Me.listview_sale.UseCompatibleStateImageBehavior = False
        Me.listview_sale.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "*"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "รหัส"
        Me.ColumnHeader9.Width = 59
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "รายการ"
        Me.ColumnHeader10.Width = 153
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "หน่วย"
        Me.ColumnHeader11.Width = 87
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "จำนวน"
        Me.ColumnHeader12.Width = 91
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "@ราคา"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 83
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ราคารวม"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 107
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.lbl_date_sale)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btn_add)
        Me.Panel4.Controls.Add(Me.rad_cool)
        Me.Panel4.Controls.Add(Me.rad_spin)
        Me.Panel4.Controls.Add(Me.rad_hot)
        Me.Panel4.Controls.Add(Me.txt_coffee_amount)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txt_coffee_id)
        Me.Panel4.Controls.Add(Me.txt_total)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(660, 192)
        Me.Panel4.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "..."
        '
        'lbl_date_sale
        '
        Me.lbl_date_sale.AutoSize = True
        Me.lbl_date_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_date_sale.Location = New System.Drawing.Point(464, 142)
        Me.lbl_date_sale.Name = "lbl_date_sale"
        Me.lbl_date_sale.Size = New System.Drawing.Size(28, 24)
        Me.lbl_date_sale.TabIndex = 12
        Me.lbl_date_sale.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(309, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "วัน/เดือน/ปี ที่ขาย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "รหัสการขาย"
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_add.Location = New System.Drawing.Point(578, 85)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(63, 26)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "เพิ่ม"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'rad_cool
        '
        Me.rad_cool.AutoSize = True
        Me.rad_cool.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_cool.Location = New System.Drawing.Point(480, 86)
        Me.rad_cool.Name = "rad_cool"
        Me.rad_cool.Size = New System.Drawing.Size(50, 24)
        Me.rad_cool.TabIndex = 7
        Me.rad_cool.Text = "เย็น"
        Me.rad_cool.UseVisualStyleBackColor = True
        '
        'rad_spin
        '
        Me.rad_spin.AutoSize = True
        Me.rad_spin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_spin.Location = New System.Drawing.Point(536, 86)
        Me.rad_spin.Name = "rad_spin"
        Me.rad_spin.Size = New System.Drawing.Size(45, 24)
        Me.rad_spin.TabIndex = 6
        Me.rad_spin.Text = "ปั่น"
        Me.rad_spin.UseVisualStyleBackColor = True
        '
        'rad_hot
        '
        Me.rad_hot.AutoSize = True
        Me.rad_hot.Checked = True
        Me.rad_hot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_hot.Location = New System.Drawing.Point(423, 86)
        Me.rad_hot.Name = "rad_hot"
        Me.rad_hot.Size = New System.Drawing.Size(51, 24)
        Me.rad_hot.TabIndex = 5
        Me.rad_hot.TabStop = True
        Me.rad_hot.Text = "ร้อน"
        Me.rad_hot.UseVisualStyleBackColor = True
        '
        'txt_coffee_amount
        '
        Me.txt_coffee_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_coffee_amount.Location = New System.Drawing.Point(313, 86)
        Me.txt_coffee_amount.Name = "txt_coffee_amount"
        Me.txt_coffee_amount.Size = New System.Drawing.Size(104, 38)
        Me.txt_coffee_amount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "จำนวน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสสินค้า"
        '
        'txt_coffee_id
        '
        Me.txt_coffee_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_coffee_id.Location = New System.Drawing.Point(93, 86)
        Me.txt_coffee_id.Name = "txt_coffee_id"
        Me.txt_coffee_id.Size = New System.Drawing.Size(147, 38)
        Me.txt_coffee_id.TabIndex = 1
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Lime
        Me.txt_total.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_total.Location = New System.Drawing.Point(0, 0)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(660, 80)
        Me.txt_total.TabIndex = 0
        Me.txt_total.Text = "0.00"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frm_coffeeSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 738)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_coffeeSale"
        Me.Text = "frm_coffeeSale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents lbl_sale_id As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_total As TextBox
    Friend WithEvents btn_purchase As Button
    Friend WithEvents btn_delete_all As Button
    Friend WithEvents btn_select_delete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_coffee_id As TextBox
    Friend WithEvents listview_sale As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents btn_add As Button
    Friend WithEvents rad_cool As RadioButton
    Friend WithEvents rad_spin As RadioButton
    Friend WithEvents rad_hot As RadioButton
    Friend WithEvents txt_coffee_amount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lbl_date_sale As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
