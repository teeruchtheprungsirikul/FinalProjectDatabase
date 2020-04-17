<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_security_code = New System.Windows.Forms.TextBox()
        Me.lbl_security_code = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(666, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Brown
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1029, 74)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "@เข้าสู่ระบบ@"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_security_code)
        Me.Panel1.Controls.Add(Me.lbl_security_code)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.txt_username)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(141, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 454)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(19, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 51)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "security code"
        '
        'txt_security_code
        '
        Me.txt_security_code.Font = New System.Drawing.Font("Angsana New", 21.75!, System.Drawing.FontStyle.Bold)
        Me.txt_security_code.Location = New System.Drawing.Point(234, 250)
        Me.txt_security_code.Name = "txt_security_code"
        Me.txt_security_code.Size = New System.Drawing.Size(353, 48)
        Me.txt_security_code.TabIndex = 9
        '
        'lbl_security_code
        '
        Me.lbl_security_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_security_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_security_code.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_security_code.Location = New System.Drawing.Point(238, 189)
        Me.lbl_security_code.Name = "lbl_security_code"
        Me.lbl_security_code.Size = New System.Drawing.Size(218, 58)
        Me.lbl_security_code.TabIndex = 8
        Me.lbl_security_code.Text = "SC"
        Me.lbl_security_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox1.Location = New System.Drawing.Point(234, 137)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "แสดง"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Red
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_exit.Location = New System.Drawing.Point(411, 384)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(176, 50)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Lime
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_login.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_login.Location = New System.Drawing.Point(73, 384)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(170, 50)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Angsana New", 21.75!, System.Drawing.FontStyle.Bold)
        Me.txt_password.Location = New System.Drawing.Point(234, 83)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(353, 48)
        Me.txt_password.TabIndex = 4
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Angsana New", 21.75!, System.Drawing.FontStyle.Bold)
        Me.txt_username.Location = New System.Drawing.Point(234, 18)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(353, 48)
        Me.txt_username.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(19, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 50)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(19, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 50)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Username"
        '
        'Form1
        '
        Me.AcceptButton = Me.btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(1029, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_security_code As TextBox
    Friend WithEvents lbl_security_code As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
