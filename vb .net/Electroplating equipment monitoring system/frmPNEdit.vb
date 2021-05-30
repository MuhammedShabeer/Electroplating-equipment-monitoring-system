Imports System.IO
Imports DL
Public Class frmPNEdit
    Public intItemNumberLibraryId As Integer
    Public dgvRow As DataGridViewRow = Nothing

    Private Sub frmPNEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvItemAndDate.AutoGenerateColumns = False
            Dim AutoItems As New AutoCompleteStringCollection
            Dim dt = GETDATATABLE("SELECT chvItemName FROM useradmin.tbl_PartNumberAreaAmmeter_mst")
            For Each dr As DataRow In dt.Rows
                AutoItems.Add(dr("chvItemName"))
            Next
            cboItem.AutoCompleteCustomSource = AutoItems
            cboItem.Select()
            AssignValidation(txt0, ValidationType.Only_Numbers)
            AssignValidation(txt1, ValidationType.Only_Numbers)
            AssignValidation(txt2, ValidationType.Only_Numbers)
            AssignValidation(txt3, ValidationType.Only_Numbers)
            AssignValidation(txt4, ValidationType.Only_Numbers)
            AssignValidation(txt5, ValidationType.Only_Numbers)
            AssignValidation(txt6, ValidationType.Only_Numbers)
            dgvItemAndDate.DataSource = Nothing
            dgvItemAndDate.AutoGenerateColumns = False
            dgvItemAndDate.DataSource = GETDATATABLE("SELECT * FROM useradmin.tbl_PartNumberAreaAmmeter_mst")
            dgvItemAndDate.Tag = dgvItemAndDate.DataSource
        Catch ex As Exception
            ' Throw ex
        End Try
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnFeed_Click(sender As Object, e As EventArgs) Handles btnFeed.Click
        Try
            If String.IsNullOrEmpty(cboItem.Text) Then
                MsgBox("Item should not be empty!")
                cboItem.Focus()
                Exit Sub
            End If

            Dim D_AXH As String
            Dim D_BXH As String
            Dim D_ATH As String
            Dim D_BTH As String
            Dim D_AXL As String
            Dim D_BXL As String
            Dim D_ATL As String
            Dim D_BTL As String

            D_AXH = Trim(Val(txt0.Text) * Val(txt3.Text))
            D_BXH = Trim(Val(txt1.Text) * Val(txt3.Text))
            D_AXL = Trim((Val(txt0.Text) * Val(txt3.Text)) * Val(txt2.Text))

            D_BXL = Trim((Val(txt1.Text) * Val(txt3.Text)) * Val(txt2.Text))
            D_ATH = Trim(Val(txt0.Text) * Val(txt4.Text))
            D_BTH = Trim(Val(txt1.Text) * Val(txt4.Text))

            D_ATL = Trim((Val(txt0.Text) * Val(txt4.Text)) * Val(txt2.Text))
            D_BTL = Trim((Val(txt1.Text) * Val(txt4.Text)) * Val(txt2.Text))
            Try
                Dim dt As DataTable = GETDATATABLE("SELECT * FROM useradmin.tbl_PartNumberAreaAmmeter_mst where chvItemName='" & cboItem.Text & "'")
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Or cboItem.Tag IsNot Nothing Then
                    Dim strQuery As String = "UPDATE useradmin.tbl_PartNumberAreaAmmeter_mst SET "
                    strQuery = strQuery & "chvItemName ='" & cboItem.Text & "',"    '0
                    strQuery = strQuery & "chvA_Area =" & txt0.Text & ","   '1  
                    strQuery = strQuery & "chvB_Area =" & txt1.Text & "," '2
                    strQuery = strQuery & "chvLowCoefficient =" & txt2.Text & "," '3
                    strQuery = strQuery & "chvTinDensity =" & txt3.Text & "," '4
                    strQuery = strQuery & "chvCopperDensity =" & txt4.Text & "," '5
                    strQuery = strQuery & "chvTinTime =" & txt5.Text & "," '6
                    strQuery = strQuery & "chvCopperHour =" & txt6.Text & "," '7
                    strQuery = strQuery & "chvA_TinHigh =" & Format(D_AXH, "000.0") & "," '8
                    strQuery = strQuery & "chvB_TinHigh =" & Format(D_BXH, "000.0") & "," '9
                    strQuery = strQuery & "chvA_TinLow =" & Format(D_AXL, "000.0") & "," '10
                    strQuery = strQuery & "chvB_TinLow =" & Format(D_BXL, "000.0") & "," '11
                    strQuery = strQuery & "chvA_CopperHigh =" & Format(D_ATH, "000.0") & "," '12
                    strQuery = strQuery & "chvB_CopperHigh =" & Format(D_BTH, "000.0") & "," '13
                    strQuery = strQuery & "chvA_CopperLow =" & Format(D_ATL, "000.0") & "," '14
                    strQuery = strQuery & "chvB_CopperLow =" & Format(D_BTL, "000.0") & "," '15
                    strQuery = strQuery & "dtmCreateTime = CURRENT_TIMESTAMP"
                    If cboItem.Tag IsNot Nothing Then
                        strQuery = strQuery & " Where intPartNumberAreaAmmeterId=" & cboItem.Tag
                    Else
                        strQuery = strQuery & " Where intPartNumberAreaAmmeterId=" & dt.Rows(0).Item("intPartNumberAreaAmmeterId")
                    End If
                    ExecuteNonQuery(strQuery)
                    MsgBox(cboItem.Text & " Updated successfully", MsgBoxStyle.Information)
                    WritelogFile(" Updated " & cboItem.Text & " Id = " & cboItem.Tag & " On ")
                Else
                    ExecuteNonQuery("INSERT INTO useradmin.tbl_PartNumberAreaAmmeter_mst (`chvItemName`,`chvA_Area`,`chvB_Area`,`chvLowCoefficient`,`chvTinDensity`,`chvCopperDensity`,`chvTinTime`,`chvCopperHour`,`chvA_TinHigh`,`chvB_TinHigh`,`chvA_TinLow`,`chvB_TinLow`,`chvA_CopperHigh`,`chvB_CopperHigh`,`chvA_CopperLow`,`chvB_CopperLow`) 
                Values ('" & cboItem.Text & "'," & txt0.Text & "," & txt1.Text &
                "," & txt2.Text & "," & txt3.Text & "," & txt4.Text & "," & txt5.Text & "," & txt6.Text & "," &
                Format(D_AXH, "000.0") & "," & Format(D_BXH, "000.0") & "," & Format(D_AXL, "000.0") & "," &
                Format(D_BXL, "000.0") & "," & Format(D_ATH, "000.0") & "," & Format(D_BTH, "000.0") & "," &
                Format(D_ATL, "000.0") & "," & Format(D_BTL, "000.0") & ");")
                    MsgBox("Saved successfully", MsgBoxStyle.Information)
                    WritelogFile(" Saved " & cboItem.Text & " On ")
                End If
                dgvItemAndDate.DataSource = Nothing
                dgvItemAndDate.AutoGenerateColumns = False
                dgvItemAndDate.DataSource = GETDATATABLE("SELECT * FROM useradmin.tbl_PartNumberAreaAmmeter_mst")
                dgvItemAndDate.Tag = dgvItemAndDate.DataSource
                btnCancel_Click(sender, e)
            Catch ex As Exception
                MsgBox("Saving failed", MsgBoxStyle.Critical)
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub WritelogFile(Content As String)
        Try
            Dim Path As String = DirectoryForLogFile("PN Log.txt")
            If File.Exists(Path) Then
                Using Writer As New StreamWriter(Path, True)
                    Writer.WriteLine(LoginUserDetails.LoginUserName & " " & Content & DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt"))
                End Using
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    'Private Sub dgvItemAndDate_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemAndDate.RowEnter
    '    Try
    '        Dim dr As DataRowView = dgvItemAndDate.CurrentRow.DataBoundItem
    '        cboItem.Text = dr(1)
    '        txt0.Text = dr(2)
    '        txt1.Text = dr(3)
    '        txt2.Text = dr(4)
    '        txt3.Text = dr(5)
    '        txt4.Text = dr(6)
    '        txt5.Text = dr(7)
    '        txt6.Text = dr(8)
    '        btnFeed.Text = "&Update"
    '        cboItem.Tag = dr(0)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            txt6.Clear() : txt5.Clear() : txt4.Clear() : txt3.Clear() : txt2.Clear() : txt1.Clear() : txt0.Clear()
            cboItem.Text = "" : cboItem.Tag = Nothing
            btnFeed.Text = "&Save"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click, Button1.Click
        Try
            System.Diagnostics.Process.Start("calc")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub dgvMonitorScreen_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvItemAndDate.MouseDown
        Try
            If Not IsNothing(dgvItemAndDate.SelectedRows(0)) Then
                dgvItemAndDate.ContextMenuStrip = ContextMenuStrip1
            Else
                dgvItemAndDate.ContextMenuStrip = Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            Dim dr As DataRowView = dgvItemAndDate.CurrentRow.DataBoundItem
            cboItem.Text = dr(1)
            txt0.Text = dr(2)
            txt1.Text = dr(3)
            txt2.Text = dr(4)
            txt3.Text = dr(5)
            txt4.Text = dr(6)
            txt5.Text = dr(7)
            txt6.Text = dr(8)
            btnFeed.Text = "&Update"
            cboItem.Tag = dr(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            ExecuteNonQuery("DELETE FROM useradmin.tbl_PartNumberAreaAmmeter_mst  WHERE intPartNumberAreaAmmeterId =" & CType(dgvItemAndDate.CurrentRow.DataBoundItem, DataRowView).Item(0))
            dgvItemAndDate.DataSource = Nothing
            dgvItemAndDate.DataSource = GETDATATABLE("SELECT * FROM useradmin.tbl_PartNumberAreaAmmeter_mst")
            dgvItemAndDate.Tag = dgvItemAndDate.DataSource
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        Try
            txt6.Clear() : txt5.Clear() : txt4.Clear() : txt3.Clear() : txt2.Clear() : txt1.Clear() : txt0.Clear()
            cboItem.Text = "" : cboItem.Tag = Nothing
            btnFeed.Text = "&Save"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txt6_Leave(sender As Object, e As EventArgs) Handles txt6.Leave, txt5.Leave, txt4.Leave, txt3.Leave, txt2.Leave, txt1.Leave, txt0.Leave
        Try
            'If String.IsNullOrEmpty(cboItem.Text) Then
            '    MsgBox("Item should not be empty!")
            '    cboItem.Focus()
            '    Exit Sub
            'End If
            If sender.text.length < 4 Then
                sender.text = "0" & sender.text
            End If
            Dim a_a As Integer
            Dim a_b As Integer
            a_b = 0
            Select Case sender.Name
                Case "txt0"
                    If Trim(txt0.Text) = "" Then
                        MsgBox("The plating area cannot be empty!")
                        txt0.Focus()
                        Exit Sub
                    End If

                    If Len(txt0.Text) > 4 Then MsgBox("Length should not be gerater than 4 !") : txt0.Focus() : Exit Sub
                    For i = 1 To 4
                        If Asc(Mid(txt0.Text, i, 1)) < 46 Or Asc(Mid(txt0.Text, i, 1)) > 57 Or Asc(Mid(txt0.Text, i, 1)) = 47 Then MsgBox("input error!") : txt0.Focus() : Exit Sub
                        a_a = Asc(Mid(txt0.Text, i, 1))
                        If a_a = 46 Then a_b = a_b + 1
                        If a_b > 1 Then MsgBox("input error!") : txt1.Focus() : Exit Sub
                    Next
                Case "txt1"
                    If Trim(txt1.Text) = "" Then MsgBox("The plating area cannot be empty!!") : txt1.Focus() : Exit Sub
                    If Len(txt1.Text) > 4 Then MsgBox("Length should not be gerater than 4 !") : txt1.Focus() : Exit Sub
                    For i = 1 To 4
                        If Asc(Mid(txt1.Text, i, 1)) < 46 Or Asc(Mid(txt1.Text, i, 1)) > 57 Or Asc(Mid(txt1.Text, i, 1)) = 47 Then MsgBox("input error!") : txt1.Focus() : Exit Sub
                        a_a = Asc(Mid(txt1.Text, i, 1))
                        If a_a = 46 Then a_b = a_b + 1
                        If a_b > 1 Then MsgBox("Input errow!") : txt1.Focus() : Exit Sub
                    Next
                Case "txt2"
                    If Trim(txt2.Text) = "" Then MsgBox("Please enter low current coefficien!") : txt2.Focus() : Exit Sub
                    If Val(txt2.Text) > 1 Then MsgBox("The low current protection factor can only be a number between 0 and 1, that is, within [0,1]!!") : txt2.Focus() : Exit Sub   '不能超过1,只能是小于1的小数
                    If Len(txt2.Text) > 4 Then MsgBox("Length should not be gerater than 4 !") : txt2.Focus() : Exit Sub
                    For i = 1 To 4
                        If Asc(Mid(txt2.Text, i, 1)) < 46 Or Asc(Mid(txt2.Text, i, 1)) > 57 Or Asc(Mid(txt2.Text, i, 1)) = 47 Then MsgBox("input error!") : txt2.Focus() : Exit Sub
                        a_a = Asc(Mid(txt2.Text, i, 1))
                        If a_a = 46 Then a_b = a_b + 1
                        If a_b > 1 Then MsgBox("input error!") : txt2.Focus() : Exit Sub
                    Next
                Case "txt3"
                    If Trim(txt3.Text) = "" Then MsgBox("Please enter tin tank density!") : txt3.Focus() : Exit Sub
                    If Len(txt3.Text) > 4 Then MsgBox("Length should not be gerater than 4 !") : txt3.Focus() : Exit Sub
                    For i = 1 To 4
                        If Asc(Mid(txt3.Text, i, 1)) < 46 Or Asc(Mid(txt3.Text, i, 1)) > 57 Or Asc(Mid(txt3.Text, i, 1)) = 47 Then MsgBox("input error!") : txt3.Focus() : Exit Sub
                        a_a = Asc(Mid(txt3.Text, i, 1))
                        If a_a = 46 Then a_b = a_b + 1
                        If a_b > 1 Then MsgBox("input error!") : txt3.Focus() : Exit Sub
                    Next
                Case "txt4"
                    If txt4.Text.Trim = "" Then MsgBox("请输入铜槽密度 please input copper density!") : txt4.Focus() : Exit Sub
                    If Len(txt4.Text) > 4 Then MsgBox("Length should not be gerater than 4 !") : txt4.Focus() : Exit Sub
                    For i = 1 To 4
                        If Asc(Mid(txt4.Text, i, 1)) < 46 Or Asc(Mid(txt4.Text, i, 1)) > 57 Or Asc(Mid(txt4.Text, i, 1)) = 47 Then MsgBox("input error!") : txt4.Focus() : Exit Sub
                        a_a = Asc(Mid(txt4.Text, i, 1))
                        If a_a = 46 Then a_b = a_b + 1
                        If a_b > 1 Then MsgBox("input error!") : txt4.Focus() : Exit Sub
                    Next
                Case "txt5"
                    If Trim(txt5.Text) = "" Then MsgBox("Input Tin plating time!") : txt5.Focus() : Exit Sub
                    If Len(txt5.Text) > 4 Then MsgBox("Length should not be gerater than 4 !") : txt5.Focus() : Exit Sub
                    For i = 1 To 4
                        If Asc(Mid(txt5.Text, i, 1)) < 46 Or Asc(Mid(txt5.Text, i, 1)) > 57 Or Asc(Mid(txt5.Text, i, 1)) = 47 Then MsgBox("input error!") : txt5.Focus() : Exit Sub
                        a_a = Asc(Mid(txt5.Text, i, 1))
                        If a_a = 46 Then a_b = a_b + 1
                        If a_b > 1 Then MsgBox("input error!") : txt5.Focus() : Exit Sub
                    Next
                Case "txt6"
                    If Trim(txt6.Text) = "" Then MsgBox("Input copper plating time!") : txt6.Focus() : Exit Sub
                    If Len(txt6.Text) > 4 Then MsgBox("Length should not be gerater than 4 !") : txt6.Focus() : Exit Sub
                    For i = 1 To 4
                        If Asc(Mid(txt6.Text, i, 1)) < 46 Or Asc(Mid(txt6.Text, i, 1)) > 57 Or Asc(Mid(txt6.Text, i, 1)) = 47 Then MsgBox("input error!") : txt6.Focus() : Exit Sub
                        a_a = Asc(Mid(txt6.Text, i, 1))
                        If a_a = 46 Then a_b = a_b + 1
                        If a_b > 1 Then MsgBox("input error!") : txt6.Focus() : Exit Sub
                    Next
            End Select
        Catch ex As Exception
            'Throw ex
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dtFilter As DataTable = New DataView(dgvItemAndDate.Tag, "chvItemName like '%" & TextBox1.Text.Trim & "%'", "", DataViewRowState.CurrentRows).ToTable()
            dgvItemAndDate.DataSource = Nothing
            dgvItemAndDate.DataSource = dtFilter
        Catch ex As Exception
        End Try
    End Sub

End Class