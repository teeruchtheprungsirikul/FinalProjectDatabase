Public Class frm_total
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub txt_receive_TextChanged(sender As Object, e As EventArgs) Handles txt_receive.TextChanged

    End Sub

    Private Sub txt_receive_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_receive.KeyDown
        If e.KeyData = Keys.Enter Then

            If Not IsNumeric(txt_receive.Text) Then
                msg_error("ต้องกรอกตัวเลขเท่านั้น")
                txt_receive.Text = ""
                txt_receive.Select()
                Return
            End If

            If Val(txt_receive.Text) < Val(txt_total) Then
                msg_error("ยอดที่ได้มาน้อยกว่ายอดชำระทั้งสิ้น")
                txt_receive.Text = ""
                txt_receive.Select()
                Return
            End If

            Dim total As Double = txt_total.Text
            Dim recive As Double = txt_receive.Text
            Dim refund As Double = total - recive
            txt_refund.Text = refund
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(txt_receive.Text) Then
            msg_error("ต้องกรอกตัวเลขเท่านั้น")
            txt_receive.Select()
            Return
        End If
        Dim total As Double = txt_total.Text
        Dim recive As Double = txt_receive.Text
        Dim refund As Double = recive - total
        txt_refund.Text = refund
        If refund < 0 Then
            msg_error("จ่ายเงินไม่ครบ")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "insert into sale_table(sale_full_id,coffee_id,coffee_amount,coffee_total,date_sale) values"
        Dim i As Integer = frm_coffeeSale.listview_sale.Items.Count - 1
        For j As Integer = 0 To i
            Dim coffee_id As String = frm_coffeeSale.listview_sale.Items(j).SubItems(1).Text
            Dim coffee_amount As Integer = frm_coffeeSale.listview_sale.Items(j).SubItems(4).Text
            Dim coffee_total As Integer = frm_coffeeSale.listview_sale.Items(j).SubItems(6).Text
            Dim date_sale As String = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day

            If j = i Then
                sql &= String.Format("('{0}','{1}','{2}','{3}','{4}')", frm_coffeeSale.Label5.Text, coffee_id, coffee_amount, coffee_total, date_sale)
            Else
                sql &= String.Format("('{0}','{1}','{2}','{3}','{4}') ,", frm_coffeeSale.Label5.Text, coffee_id, coffee_amount, coffee_total, date_sale)
            End If

        Next
        cmd = New SqlClient.SqlCommand(sql, cn)

        If cmd.ExecuteNonQuery = 0 Then
            msg_error("ไม่สามารถบันทึกได้")

        Else
            sql = "insert into sale_detail( sale_full_id, sale_total, discount, discount_condition, sale_net) values( @sale_full_id, @sale_total, @discount, @discount_condition, @sale_net)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("sale_full_id", frm_coffeeSale.Label5.Text)
            cmd.Parameters.AddWithValue("sale_total", txt_total.Text)
            cmd.Parameters.AddWithValue("discount", "0")
            cmd.Parameters.AddWithValue("discount_condition", "0")
            cmd.Parameters.AddWithValue("sale_net", txt_total.Text)

            If cmd.ExecuteNonQuery = 0 Then
                msg_error("ไม่สามารถเพิ่มได้")
            Else
                msg_ok("เพิ่มสำเร็จ")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()


    End Sub
End Class