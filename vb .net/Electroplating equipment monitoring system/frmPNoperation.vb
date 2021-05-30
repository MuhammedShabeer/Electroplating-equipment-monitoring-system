Imports DL
Public Class frmPNoperation
    Public intItemNumberLibraryId As Integer
    Public dgvRow As DataGridViewRow = Nothing
    Public txtFeeding As TextBox = Nothing
    Private Sub frmPNoperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim AutoItems As New AutoCompleteStringCollection
            Dim dt = GETDATATABLE("SELECT chvItemName,dtmCreateTime FROM useradmin.tbl_PartNumberAreaAmmeter_mst")
            For Each dr As DataRow In dt.Rows
                AutoItems.Add(dr("chvItemName"))
            Next
            txtItem.AutoCompleteCustomSource = AutoItems
            txtItem.Select()
            AssignValidation(txtQty, ValidationType.Only_Numbers)
            dgvItemAndDate.Tag = dt
            dgvItemAndDate.DataSource = Nothing
            dgvItemAndDate.AutoGenerateColumns = False
            dgvItemAndDate.DataSource = dt
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnFeed_Click(sender As Object, e As EventArgs) Handles btnFeed.Click
        Try
            AssignValidation(txtItem, ValidationType.Not_Null)
            AssignValidation(txtQty, ValidationType.Not_Null)
            Dim dt As DataTable = GETDATATABLE("Select * FROM useradmin.tbl_PartNumberAreaAmmeter_mst where chvItemName = '" & txtItem.Text & "'")
            If dt Is Nothing Or dt.Rows.Count <= 0 Then
                MsgBox("Enter a valid item")
                Exit Sub
            End If
            If Val(dt.Rows(0).Item("chvA_TinHigh")) * Val(txtQty.Text) > 500 Then MsgBox("The tin bath input current exceeds 500A.Tin tank input current exceeds 500A") : Exit Sub
            If Val(dt.Rows(0).Item("chvB_TinHigh")) * Val(txtQty.Text) > 500 Then MsgBox("The tin bath input current exceeds 500A .Tin tank input current exceeds 500A") : Exit Sub
            If Val(dt.Rows(0).Item("chvTinTime")) * Val(txtQty.Text) > 650 Then MsgBox("Copper tank input current exceeds  650A copper tank input current exceeds 650A") : Exit Sub
            If Val(dt.Rows(0).Item("chvCopperHour")) * Val(txtQty.Text) > 650 Then MsgBox("Copper tank input current exceeds  650A.copper tank input current exceeds 650A") : Exit Sub

            Dim dtItemNumberLibrary As DataTable = GETDATATABLE("Select * FROM useradmin.tbl_ItemNumberLibrary_mst where chvItemName = '" & txtItem.Text & "'")
            If dtItemNumberLibrary IsNot Nothing AndAlso dtItemNumberLibrary.Rows.Count > 0 Then
                If dtItemNumberLibrary.Rows(0).Item("intSerialNumber") > 18 Then MsgBox("productioning Item is more ") : Exit Sub
                Dim strQuery As String = "Update tbl_ItemNumberLibrary_mst Set "
                strQuery = strQuery & "chvItemName = '" & txtItem.Text & "', "
                strQuery = strQuery & "intTinA_H =" & dt.Rows(0).Item("chvA_TinHigh") & ", "
                strQuery = strQuery & "intTinB_H =" & dt.Rows(0).Item("chvB_TinHigh") & ", "
                strQuery = strQuery & "intTinA_L =" & dt.Rows(0).Item("chvA_TinLow") & ", "
                strQuery = strQuery & "intTinB_L =" & dt.Rows(0).Item("chvB_TinLow") & ", "
                strQuery = strQuery & "intTinningTime =" & dt.Rows(0).Item("chvTinTime") & ", "
                strQuery = strQuery & "intCopperA_H =" & dt.Rows(0).Item("chvA_CopperHigh") & ", "
                strQuery = strQuery & "intCopperB_H =" & dt.Rows(0).Item("chvB_CopperHigh") & ", "
                strQuery = strQuery & "intCopperA_L =" & dt.Rows(0).Item("chvA_CopperLow") & ", "
                strQuery = strQuery & "intCopperB_L =" & dt.Rows(0).Item("chvB_CopperLow") & ", "
                strQuery = strQuery & "intCopperPlatingTime =" & dt.Rows(0).Item("chvCopperHour") & ", "
                strQuery = strQuery & "intSerialNumber =" & dtItemNumberLibrary.Rows(0).Item("intSerialNumber") + 1 & ", "
                strQuery = strQuery & "dtmCreateTime = CURRENT_TIMESTAMP"
                ExecuteNonQuery(strQuery)
                MsgBox("Updated successfully", MsgBoxStyle.Information)
            Else
                Dim strQuery As String = "INSERT INTO useradmin.tbl_ItemNumberLibrary_mst (`chvItemName`,`intTinA_H`,`intTinB_H`, `intTinA_L`,`intTinB_L`,`intTinningTime`,`intCopperA_H`,`intCopperB_H`,`intCopperA_L`,`intCopperB_L`,`intCopperPlatingTime`,`intSerialNumber`,`dtmCreateTime`) VALUES "
                strQuery = strQuery & " ('" & dt.Rows(0).Item("chvItemName") & "', "
                strQuery = strQuery & dt.Rows(0).Item("chvA_TinHigh") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvB_TinHigh") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvA_TinLow") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvB_TinLow") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvTinTime") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvA_CopperHigh") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvB_CopperHigh") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvA_CopperLow") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvB_CopperLow") & ", "
                strQuery = strQuery & dt.Rows(0).Item("chvCopperHour") & ", "
                strQuery = strQuery & 1 & ", "
                strQuery = strQuery & " CURRENT_TIMESTAMP) "
                ExecuteNonQuery(strQuery)
                MsgBox("Saved successfully", MsgBoxStyle.Information)
            End If
            If dgvRow IsNot Nothing Then
                dgvRow.Cells("colItemA").Value = txtItem.Text
                dgvRow.Cells("colQTY").Value = txtQty.Text
            Else
                txtFeeding.Text = "(" & txtQty.Text & ") " & txtItem.Text
            End If
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
        Try
            Dim dtFilter As DataTable = New DataView(dgvItemAndDate.Tag, "chvItemName like '%" & txtItem.Text.Trim & "%'", "", DataViewRowState.CurrentRows).ToTable()
            dgvItemAndDate.DataSource = Nothing
            dgvItemAndDate.DataSource = dtFilter
        Catch ex As Exception
        End Try
    End Sub
End Class