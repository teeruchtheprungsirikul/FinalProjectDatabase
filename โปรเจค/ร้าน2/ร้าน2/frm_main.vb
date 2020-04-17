Public Class frm_main
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If confirm("จะออกจากระบบหรือไม่ ?") = vbNo Then Return
        Me.Close()
        Form1.Show()
        With Form1
            .txt_username.Text = ""
            .txt_password.Text = ""
            .txt_security_code.Text = ""
            .lbl_security_code.Text = rnd_security_code()

        End With
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        frm_mannage_coffee.Show()
        frm_mannage_coffee.MdiParent = Me
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        frm_coffeeSale.Show()
        frm_coffeeSale.MdiParent = Me
    End Sub
End Class