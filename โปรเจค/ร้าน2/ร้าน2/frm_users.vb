Public Class frm_users
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If confirm("คุณต้องการดคลียร์หรือไม่ ?") = vbNo Then Return
        txt_email.Text = ""
        txt_username.Text = ""
        txt_tel.Text = ""
        txt_password.Text = ""
        txt_name.Text = ""
        txt_lastname.Text = ""
    End Sub

    Private Sub frm_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_empoyee()
    End Sub
    Public Sub load_empoyee()
        connect_open()
        sql = "select * from users"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_search.DataSource = DS.Tables("table")
    End Sub

    Private Sub datagrid_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellContentClick

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If confirm("คุณต้องการลบหรือไม่ ?") = vbNo Then Return
        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value

        sql = "delete from users where users_username='" & key & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery >= 1 Then
            msg_ok("ลบสำเร็จ")
            load_empoyee()
        Else
            msg_error("ลบผิดผลาด")
        End If
    End Sub

    Private Sub datagrid_search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellClick
        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value


        txt_show_username.Text = datagrid_search.Item(0, i).Value
        txt_show_password.Text = datagrid_search.Item(1, i).Value
        txt_show_name.Text = datagrid_search.Item(2, i).Value
        txt_show_lastname.Text = datagrid_search.Item(3, i).Value
        txt_show_tel.Text = datagrid_search.Item(4, i).Value
        txt_show_email.Text = datagrid_search.Item(5, i).Value

        txt_edit_username.Text = datagrid_search.Item(0, i).Value
        txt_edit_password.Text = datagrid_search.Item(1, i).Value
        txt_edit_name.Text = datagrid_search.Item(2, i).Value
        txt_edit_lastname.Text = datagrid_search.Item(3, i).Value
        txt_edit_tel.Text = datagrid_search.Item(4, i).Value
        txt_edit_email.Text = datagrid_search.Item(5, i).Value
    End Sub

    Private Sub btn_clear_edit_Click(sender As Object, e As EventArgs) Handles btn_clear_edit.Click
        If confirm("คุณต้องการดคลียร์หรือไม่ ?") = vbNo Then Return
        txt_edit_email.Text = ""
        txt_edit_username.Text = ""
        txt_edit_tel.Text = ""
        txt_edit_password.Text = ""
        txt_edit_name.Text = ""
        txt_edit_lastname.Text = ""
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If confirm("ต้องการแก้ใขหรือไม่ ?") = vbNo Then Return
        connect_open()
        sql = "update users set users_password=@password, users_name=@name, users_lastname=@lastname, users_tel=@tel, users_email=@email where users_username='" & txt_edit_username.Text & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("password", txt_edit_password.Text)
        cmd.Parameters.AddWithValue("name", txt_edit_name.Text)
        cmd.Parameters.AddWithValue("lastname", txt_edit_lastname.Text)
        cmd.Parameters.AddWithValue("tel", txt_edit_tel.Text)
        cmd.Parameters.AddWithValue("email", txt_edit_email.Text)
        If cmd.ExecuteNonQuery >= 1 Then
            msg_ok("แก้ไขข้อมูลสำเร็จ")
        Else
            msg_error("แก้ไขไม่สำเร็จ")
        End If

    End Sub
End Class