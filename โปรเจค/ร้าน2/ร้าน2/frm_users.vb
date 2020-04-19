Public Class frm_users
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect_open()
        sql = "select * from users where users_username='" & txt_username.Text & "'"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Dim dts As DataTable = DS.Tables("table")
        If dts.Rows.Count > 0 Then
            msg_error("มี username นี้อยู่แล้วในระบบ")
            Return
        End If

        If confirm("คุณต้องการจะเพิ่มพนักงานหรือไม่") = vbNo Then Return
        connect_open()
        sql = "Insert into users values(@username, @password, @name, @lastname, @tel, @email)"
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("username", txt_username.Text)
        cmd.Parameters.AddWithValue("password", txt_password.Text)
        cmd.Parameters.AddWithValue("name", txt_name.Text)
        cmd.Parameters.AddWithValue("lastname", txt_lastname.Text)
        cmd.Parameters.AddWithValue("tel", txt_tel.Text)
        cmd.Parameters.AddWithValue("email", txt_email.Text)
        If cmd.ExecuteNonQuery >= 1 Then
            msg_ok("เพิ่มสำเร็จ")
        Else
            msg_error("เพิ่มไม่สำเร็จ")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If confirm("คุณต้องการดคลียร์หรือไม่ ?") = vbNo Then Return
        txt_email.Text = ""
        txt_username.Text = ""
        txt_tel.Text = ""
        txt_password.Text = ""
        txt_name.Text = ""
        txt_lastname.Text = ""
    End Sub
End Class