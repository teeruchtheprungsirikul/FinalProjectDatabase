Imports System.Data.Sql
Imports System.Data.SqlClient

Module code
    Friend cn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Coffeeshopproject;Integrated Security=True ")
    Friend cmd As New SqlCommand
    Friend DA As New SqlDataAdapter
    Friend sql As String
    Friend DS As DataSet

    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()

    End Sub
    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar
    End Function

    Friend Function cmd_excuteDataTable()
        connect_open()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function

    Friend Function rnd_security_code()
        Randomize()
        Dim i As Integer = 999999 * Rnd()
        Return i.ToString.PadLeft(6, "0")

    End Function

    Friend Function cmd_excuteNonquery()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery
    End Function
    Friend Sub msg_error(text As String, Optional title As String = "ผิดพลาด")
        MsgBox(text, vbCritical + vbOKOnly, title)

    End Sub
    Friend Sub msg_ok(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKOnly, title)

    End Sub

    Friend Function confirm(text As String, Optional title As String = "ยืนยัน")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function

End Module
