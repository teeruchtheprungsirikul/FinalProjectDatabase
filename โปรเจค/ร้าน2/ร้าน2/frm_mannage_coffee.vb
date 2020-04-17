Public Class frm_mannage_coffee
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub
    Public Sub refresh_coffee()
        sql = "select coffee_id, coffee_name, coffee_image from coffee"
        datagrid_coffee.DataSource = cmd_excuteDataTable()
        change_datagrid_column()
    End Sub
    Public Sub change_datagrid_column()
        Dim column_text() As String = {"รหัสกาแฟ", "ชื่อกาแฟ", "ภาพประกอบ"}
        For i As Integer = 0 To datagrid_coffee.ColumnCount - 1
            datagrid_coffee.Columns(i).HeaderText = column_text(i)
        Next
    End Sub

    Public Sub clear_form()
        txt_add_cool.Text = ""
        txt_add_hot.Text = ""
        txt_add_id.Text = ""
        txt_add_name.Text = ""
        txt_add_spin.Text = ""
        txt_search.Text = ""
        pic_add.Image = Nothing

    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        If confirm("คุณยืนยันที่จะเพิ่มกาแฟหรือไม่ ? ") = vbNo Then Return
        If txt_add_id.Text = "" Or txt_add_name.Text = "" Or txt_add_hot.Text = "" Or txt_add_cool.Text = "" Or txt_add_spin.Text = "" Then
            msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If pic_add.Image Is Nothing Then
            sql = "insert into coffee(coffee_id, coffee_name, coffee_hot, coffee_cool, coffee_spin) values(@id,@name,@hot,@cool,@spin)"
        Else
            sql = "insert into coffee(coffee_id, coffee_name, coffee_hot, coffee_cool, coffee_spin, coffee_image) values(@id,@name,@hot,@cool,@spin,@img)"

        End If
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txt_add_id.Text)
        cmd.Parameters.AddWithValue("name", txt_add_name.Text)
        cmd.Parameters.AddWithValue("hot", txt_add_hot.Text)
        cmd.Parameters.AddWithValue("cool", txt_add_cool.Text)
        cmd.Parameters.AddWithValue("spin", txt_add_spin.Text)
        If Not pic_add.Image Is Nothing Then

            Dim mem As New IO .MemoryStream
            pic_add .Image .Save (mem,Imaging.ImageFormat.Bmp)
            Dim pic_for_add() As Byte
            pic_for_add =mem.ToArray()
            cmd.Parameters.AddWithValue("img", pic_for_add)
        End If
        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("เพิ่มไม่สำเร็จ")
        Else
            msg_ok("เพิ่มสำเร็จ")
            refresh_coffee()
            clear_form()
        End If
    End Sub

    Private Sub btn_select_picture_Click(sender As Object, e As EventArgs) Handles btn_select_picture.Click
        If openfile_coffee.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(openfile_coffee.FileName)
            pic_add.Image = img
        End If
    End Sub

    Private Sub frm_mannage_coffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
    End Sub

    Private Sub datagrid_coffee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_coffee.CellContentClick

    End Sub
End Class