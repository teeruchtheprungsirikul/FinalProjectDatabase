Public Class frm_select_price
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_cool.Click

    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Dim array_item(7) As String
        With frm_coffeeSale
            array_item(0) = .listview_sale.Items.Count + 1
            array_item(1) = .lbl_coffee_id.Text



        End With
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