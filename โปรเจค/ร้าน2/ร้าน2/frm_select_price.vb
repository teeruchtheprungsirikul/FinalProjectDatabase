Public Class frm_select_price
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_cool.Click

    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If txt_amount.Text = "" Or Not IsNumeric(txt_amount.Text) Then
            msg_error("กรุณากรอกจำนวนตัวเลขเท่านั้น")
            Return
        End If
        Dim array_item(7) As String
        With frm_coffeeSale
            array_item(0) = .listview_sale.Items.Count + 1
            array_item(1) = lbl_coffee_id.Text
            array_item(2) = lbl_coffee_name.Text
            array_item(3) = "แก้ว"
            array_item(4) = txt_amount.Text
            Dim price As Integer = 0
            If rad_hot.Checked = True Then
                price = lbl_hot.Text
            ElseIf rad_cool.Checked = True Then
                price = lbl_cool.Text
            Else
                price = lbl_spin.Text

            End If
            array_item(5) = price
            array_item(6) = array_item(4) * array_item(5)

        End With
        Dim itm As New ListViewItem(array_item)
        frm_coffeeSale.listview_sale.Items.Add(itm)
        Me.Hide()
        frm_coffeeSale.total_price()

    End Sub

    Private Sub rad_hot_CheckedChanged(sender As Object, e As EventArgs) Handles rad_hot.CheckedChanged
        txt_amount.Select()
    End Sub

    Private Sub rad_cool_CheckedChanged(sender As Object, e As EventArgs) Handles rad_cool.CheckedChanged
        txt_amount.Select()
    End Sub

    Private Sub rad_spin_CheckedChanged(sender As Object, e As EventArgs) Handles rad_spin.CheckedChanged
        txt_amount.Select()
    End Sub

    Private Sub lbl_coffee_id_Click(sender As Object, e As EventArgs) Handles lbl_coffee_id.Click

    End Sub
End Class