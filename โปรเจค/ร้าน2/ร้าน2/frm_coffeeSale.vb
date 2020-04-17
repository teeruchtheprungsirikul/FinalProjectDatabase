Public Class frm_coffeeSale
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub frm_coffeeSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh__coffee()

    End Sub

    Public Sub refresh__coffee()
        sql = "select coffee_id, coffee_name, coffee_image from coffee"
        Dim data_table As DataTable = cmd_excuteDataTable()

        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.default_coffee, "coffee_image", "coffee_id", "coffee_name")
    End Sub
End Class