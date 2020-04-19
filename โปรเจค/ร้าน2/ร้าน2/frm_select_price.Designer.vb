<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_price
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
        Me.rad_hot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_hot.Location = New System.Drawing.Point(59, 65)
        Me.rad_hot.Name = "rad_hot"
        Me.rad_hot.Size = New System.Drawing.Size(76, 33)
        Me.rad_hot.TabIndex = 0
        Me.rad_hot.TabStop = True
        Me.rad_hot.Text = "ร้อน"
        Me.rad_hot.UseVisualStyleBackColor = True
        '
        'rad_cool
        '
        Me.rad_cool.AutoSize = True
        Me.rad_cool.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_cool.Location = New System.Drawing.Point(59, 124)
        Me.rad_cool.Name = "rad_cool"
        Me.rad_cool.Size = New System.Drawing.Size(71, 33)
        Me.rad_cool.TabIndex = 1
        Me.rad_cool.TabStop = True
        Me.rad_cool.Text = "เย็น"
        Me.rad_cool.UseVisualStyleBackColor = True
        '
        'rad_spin
        '
        Me.rad_spin.AutoSize = True
        Me.rad_spin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_spin.Location = New System.Drawing.Point(59, 195)
        Me.rad_spin.Name = "rad_spin"
        Me.rad_spin.Size = New System.Drawing.Size(63, 33)
        Me.rad_spin.TabIndex = 2
        Me.rad_spin.TabStop = True
        Me.rad_spin.Text = "ปั่น"
        Me.rad_spin.UseVisualStyleBackColor = True
        '
        'lbl_hot
        '
        Me.lbl_hot.AutoSize = True
        Me.lbl_hot.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_hot.Location = New System.Drawing.Point(194, 67)
        Me.lbl_hot.Name = "lbl_hot"
        Me.lbl_hot.Size = New System.Drawing.Size(29, 31)
        Me.lbl_hot.TabIndex = 3
        Me.lbl_hot.Text = "0"
        '
        'lbl_cool
        '
        Me.lbl_cool.AutoSize = True
        Me.lbl_cool.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_cool.Location = New System.Drawing.Point(194, 126)
        Me.lbl_cool.Name = "lbl_cool"
        Me.lbl_cool.Size = New System.Drawing.Size(29, 31)
        Me.lbl_cool.TabIndex = 4
        Me.lbl_cool.Text = "0"
        '
        'lbl_spin
        '
        Me.lbl_spin.AutoSize = True
        Me.lbl_spin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_spin.Location = New System.Drawing.Point(194, 197)
        Me.lbl_spin.Name = "lbl_spin"
        Me.lbl_spin.Size = New System.Drawing.Size(29, 31)
        Me.lbl_spin.TabIndex = 5
        Me.lbl_spin.Text = "0"
        '
        'btn_select
        '
        Me.btn_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_select.Location = New System.Drawing.Point(12, 384)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(123, 67)
        Me.btn_select.TabIndex = 6
        Me.btn_select.Text = "เลือก"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "รหัส"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "รายการ"
        '
        'lbl_coffee_id
        '
        Me.lbl_coffee_id.AutoSize = True
        Me.lbl_coffee_id.Location = New System.Drawing.Point(125, 9)
        Me.lbl_coffee_id.Name = "lbl_coffee_id"
        Me.lbl_coffee_id.Size = New System.Drawing.Size(13, 13)
        Me.lbl_coffee_id.TabIndex = 10
        Me.lbl_coffee_id.Text = "0"
        '
        'lbl_coffee_name
        '
        Me.lbl_coffee_name.AutoSize = True
        Me.lbl_coffee_name.Location = New System.Drawing.Point(125, 34)
        Me.lbl_coffee_name.Name = "lbl_coffee_name"
        Me.lbl_coffee_name.Size = New System.Drawing.Size(13, 13)
        Me.lbl_coffee_name.TabIndex = 11
        Me.lbl_coffee_name.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "จำนวน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "แก้ว"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(102, 292)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(108, 20)
        Me.txt_amount.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(163, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 67)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ปิด"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_select_price
        '
        Me.AcceptButton = Me.btn_select
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 489)
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
