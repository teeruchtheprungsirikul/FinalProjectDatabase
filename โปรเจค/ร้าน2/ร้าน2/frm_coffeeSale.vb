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
    Public Sub search__coffee()
        sql = String.Format("select coffee_id, coffee_name, coffee_image from coffee where coffee_id like '%{0}%' OR coffee_name like '%{0}'", txt_search.Text)
        Dim data_table As DataTable = cmd_excuteDataTable()

        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.default_coffee, "coffee_image", "coffee_id", "coffee_name")
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub txt_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyData = Keys.Enter Then
            search__coffee()
        End If
    End Sub

    Private Sub listview_coffee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_coffee.SelectedIndexChanged
        Dim select_coffee As String = listview_coffee.FocusedItem.Text
        Dim coffee_split() As String = select_coffee.Split("|")
        coffee_split(0) = coffee_split(0).ToString.Trim


        sql = "select * from coffee where coffee_id='" & coffee_split(0) & "'"
        Dim data_table As DataTable = cmd_excuteDataTable()
        Dim hot, cool, spin As Integer
        hot = data_table.Rows(0)("coffee_hot")
        cool = data_table.Rows(0)("coffee_cool")
        spin = data_table.Rows(0)("coffee_spin")
        Dim coffee_id, coffee_name As String
        coffee_id = data_table.Rows(0)("coffee_id")
        coffee_name = data_table.Rows(0)("coffee_name")


        With frm_select_price
            .lbl_hot.Text = hot
            .lbl_cool.Text = cool
            .lbl_spin.Text = spin
            .lbl_coffee_id.Text = coffee_id
            .lbl_coffee_name.Text = coffee_name
        End With

        frm_select_price.TopMost = True
        frm_select_price.Show()

    End Sub

    Private Sub listview_sale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_sale.SelectedIndexChanged

    End Sub
End Class