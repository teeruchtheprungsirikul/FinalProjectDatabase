<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_select_price
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_select_price))
        Me.rad_hot = New System.Windows.Forms.RadioButton()
        Me.rad_cool = New System.Windows.Forms.RadioButton()
        Me.rad_spin = New System.Windows.Forms.RadioButton()
        Me.lbl_hot = New System.Windows.Forms.Label()
        Me.lbl_cool = New System.Windows.Forms.Label()
        Me.lbl_spin = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_coffee_id = New System.Windows.Forms.Label()
        Me.lbl_coffee_name = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rad_hot
        '
        Me.rad_hot.AutoSize = True
        Me.rad_hot.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_hot.Location = New System.Drawing.Point(65, 140)
        Me.rad_hot.Margin = New System.Windows.Forms.Padding(4)
        Me.rad_hot.Name = "rad_hot"
        Me.rad_hot.Size = New System.Drawing.Size(78, 42)
        Me.rad_hot.TabIndex = 0
        Me.rad_hot.TabStop = True
        Me.rad_hot.Text = "ร้อน"
        Me.rad_hot.UseVisualStyleBackColor = True
        '
        'rad_cool
        '
        Me.rad_cool.AutoSize = True
        Me.rad_cool.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_cool.Location = New System.Drawing.Point(65, 229)
        Me.rad_cool.Margin = New System.Windows.Forms.Padding(4)
        Me.rad_cool.Name = "rad_cool"
        Me.rad_cool.Size = New System.Drawing.Size(74, 42)
        Me.rad_cool.TabIndex = 1
        Me.rad_cool.TabStop = True
        Me.rad_cool.Text = "เย็น"
        Me.rad_cool.UseVisualStyleBackColor = True
        '
        'rad_spin
        '
        Me.rad_spin.AutoSize = True
        Me.rad_spin.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_spin.Location = New System.Drawing.Point(67, 319)
        Me.rad_spin.Margin = New System.Windows.Forms.Padding(4)
        Me.rad_spin.Name = "rad_spin"
        Me.rad_spin.Size = New System.Drawing.Size(68, 42)
        Me.rad_spin.TabIndex = 2
        Me.rad_spin.TabStop = True
        Me.rad_spin.Text = "ปั่น"
        Me.rad_spin.UseVisualStyleBackColor = True
        '
        'lbl_hot
        '
        Me.lbl_hot.AutoSize = True
        Me.lbl_hot.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_hot.Location = New System.Drawing.Point(310, 140)
        Me.lbl_hot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_hot.Name = "lbl_hot"
        Me.lbl_hot.Size = New System.Drawing.Size(36, 39)
        Me.lbl_hot.TabIndex = 3
        Me.lbl_hot.Text = "0"
        '
        'lbl_cool
        '
        Me.lbl_cool.AutoSize = True
        Me.lbl_cool.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_cool.Location = New System.Drawing.Point(310, 218)
        Me.lbl_cool.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cool.Name = "lbl_cool"
        Me.lbl_cool.Size = New System.Drawing.Size(36, 39)
        Me.lbl_cool.TabIndex = 4
        Me.lbl_cool.Text = "0"
        '
        'lbl_spin
        '
        Me.lbl_spin.AutoSize = True
        Me.lbl_spin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_spin.Location = New System.Drawing.Point(310, 319)
        Me.lbl_spin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_spin.Name = "lbl_spin"
        Me.lbl_spin.Size = New System.Drawing.Size(36, 39)
        Me.lbl_spin.TabIndex = 5
        Me.lbl_spin.Text = "0"
        '
        'btn_select
        '
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.Font = New System.Drawing.Font("Microsoft JhengHei UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.Location = New System.Drawing.Point(35, 509)
        Me.btn_select.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(136, 55)
        Me.btn_select.TabIndex = 6
        Me.btn_select.Text = "เลือก"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "รหัส"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "รายการ"
        '
        'lbl_coffee_id
        '
        Me.lbl_coffee_id.AutoSize = True
        Me.lbl_coffee_id.Location = New System.Drawing.Point(133, 36)
        Me.lbl_coffee_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_coffee_id.Name = "lbl_coffee_id"
        Me.lbl_coffee_id.Size = New System.Drawing.Size(16, 17)
        Me.lbl_coffee_id.TabIndex = 10
        Me.lbl_coffee_id.Text = "0"
        '
        'lbl_coffee_name
        '
        Me.lbl_coffee_name.AutoSize = True
        Me.lbl_coffee_name.Location = New System.Drawing.Point(133, 74)
        Me.lbl_coffee_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_coffee_name.Name = "lbl_coffee_name"
        Me.lbl_coffee_name.Size = New System.Drawing.Size(16, 17)
        Me.lbl_coffee_name.TabIndex = 11
        Me.lbl_coffee_name.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 421)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "จำนวน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(308, 421)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "แก้ว"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(136, 419)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(143, 22)
        Me.txt_amount.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(217, 509)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 55)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ปิด"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_select_price
        '
        Me.AcceptButton = Me.btn_select
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(443, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_coffee_name)
        Me.Controls.Add(Me.lbl_coffee_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.lbl_spin)
        Me.Controls.Add(Me.lbl_cool)
        Me.Controls.Add(Me.lbl_hot)
        Me.Controls.Add(Me.rad_spin)
        Me.Controls.Add(Me.rad_cool)
        Me.Controls.Add(Me.rad_hot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_select_price"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกราคา"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rad_hot As RadioButton
    Friend WithEvents rad_cool As RadioButton
    Friend WithEvents rad_spin As RadioButton
    Friend WithEvents lbl_hot As Label
    Friend WithEvents lbl_cool As Label
    Friend WithEvents lbl_spin As Label
    Friend WithEvents btn_select As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_coffee_id As Label
    Friend WithEvents lbl_coffee_name As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents Button1 As Button
End Class
