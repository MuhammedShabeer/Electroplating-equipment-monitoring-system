Imports System.IO
Imports DL
Public Class frmManagmentSystem
    Public o(9) As String
    Public pindex As Integer
    Public MA As Integer
    Dim eros As String
    Public RID(28, 9) As String
    Public Ntim(69) As String
    Public Ncode(150) As String
    Public TIN_02 As Boolean
    Public Ntim_1(69) As String
    Public hn As String
    Public bn(3) As Boolean
    Public estr As String


    Private Sub frmManagmentSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable = GETDATATABLE("Select * from `useradmin`.`tbl_Monitorscreen_mst`")
            dgvMonitorScreen.DataSource = dt
            For Each dr As DataRow In dt.Rows
                ListBox1.Items.Add(dr("chvCraft"))
            Next
            dgvItemGrid.DataSource = GETDATATABLE("Select * from `useradmin`.`tbl_ItemNumberLibrary_mst`")

            'SerialPort1.OutBufferSize = 1024
            'SerialPort1.InBufferSize = 1024
            'If Not SerialPort1.PortOpen Then
            '    SerialPort1.CommPort = intport
            '    SerialPort1.Settings = setting
            '    SerialPort1.PortOpen = True
            'End If
            'SerialPort1.InputLen = 0
            'SerialPort1.InputMode = comInputModeText
            ''SerialPort1.RThreshold = 1
            'SerialPort1.Output = "@00XZ42*" & o(0)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsmPNOperation_Click(sender As Object, e As EventArgs) Handles tsmPNOperation.Click
        Try
            Dim PNoperation As New frmPNoperation
            PNoperation.lblHeaderName.Text = IIf(dgvMonitorScreen.Columns("colItemA").HeaderText = "Item--(B)", "B side", "A side")
            PNoperation.dgvRow = dgvMonitorScreen.SelectedRows(0)
            PNoperation.ShowDialog()
            dgvItemGrid.DataSource = GETDATATABLE("Select * from `useradmin`.`tbl_ItemNumberLibrary_mst`")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub dgvMonitorScreen_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvMonitorScreen.MouseDown
        Try
            If Not IsNothing(dgvMonitorScreen.SelectedRows(0)) Then

                dgvMonitorScreen.ContextMenuStrip = ContextMenuStrip1
                MA = dgvMonitorScreen.CurrentRow.Index + 400 \ 300
                input_index()
            Else
                dgvMonitorScreen.ContextMenuStrip = Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Dim TIN_01 As Boolean = True
    Public Sub AfroB()
        Dim i As Integer
        If TIN_01 = True Then
            For i = 1 To 22
                If i < 9 Or i > 12 Then
                    dgvMonitorScreen.Rows(i).Cells("colItemA").Style.BackColor = Color.FromArgb(128, 255, 255)
                    dgvMonitorScreen.Columns("colItemA").HeaderText = "Item--(B)"
                End If
            Next
        Else
            For i = 0 To dgvMonitorScreen.Rows.Count - 1
                dgvMonitorScreen.Rows(i).Cells("colItemA").Style.BackColor = Color.White
                dgvMonitorScreen.Columns("colItemA").HeaderText = "Item--(A)"
            Next i
        End If
        TIN_01 = Not TIN_01
    End Sub

    Private Sub tsmFlybarchange_Click(sender As Object, e As EventArgs) Handles tsmFlybarchange.Click
        Try
            AfroB()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmPnClean_Click(sender As Object, e As EventArgs) Handles tsmPnClean.Click
        Try
            Dim dgvRow As DataGridViewRow = dgvMonitorScreen.SelectedRows(0)
            If IsNothing(dgvRow.Cells("colItemA").Value) Or IsNothing(dgvRow.Cells("colQTY").Value) Then Exit Sub
            Dim Path As String = DirectoryForLogFile("feedingRecord.txt")
            If File.Exists(Path) Then
                Using Writer As New StreamWriter(Path, True)
                    Writer.WriteLine("Number slot :" & IIf(dgvMonitorScreen.Columns("colItemA").HeaderText = "Item--(B)", "B side", "A side") & " Deleted item : " & dgvRow.Cells("colItemA").Value & "QTY :" & dgvRow.Cells("colQTY").Value & DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt"))
                End Using
            End If
            dgvRow.Cells("colItemA").Value = "" : dgvRow.Cells("colQTY").Value = ""
            o(3) = "@00WD" & Trim(pindex) & "0000"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FeedItem_MouseDown(sender As Object, e As MouseEventArgs) Handles txtFeedItem5.MouseDown, txtFeedItem4.MouseDown, text7.MouseDown, Text6.MouseDown, txtFeedItem3.MouseDown, txtFeedItem2.MouseDown
        Try
            tsmFeedItem.Tag = ""
            cmsFeedItem.Tag = Nothing
            If e.Button = MouseButtons.Right Then
                cmsFeedItem.Tag = sender
                Select Case sender.name
                    Case "txtFeedItem0"
                        tsmFeedItem.Tag = "Feed Item ：A Flybar"
                        pindex = 4050
                    Case "txtFeedItem1"
                        tsmFeedItem.Tag = "Feed Item ：B Flybar"
                        pindex = 4100
                    Case "txtFeedItem2"
                        tsmFeedItem.Tag = "Feed Item ：A_A"
                        pindex = 4109
                    Case "txtFeedItem3"
                        tsmFeedItem.Tag = "Feed Item ：A_B"
                        pindex = 4110
                    Case "txtFeedItem4"
                        tsmFeedItem.Tag = "Feed Item ：B_A"
                        pindex = 4111
                    Case "txtFeedItem5"
                        tsmFeedItem.Tag = "Feed Item ：B_B"
                        pindex = 4112
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tsmFeedItem_Click(sender As Object, e As EventArgs) Handles tsmFeedItem.Click
        Try
            Dim PNoperation As New frmPNoperation
            PNoperation.txtFeeding = cmsFeedItem.Tag
            PNoperation.lblHeaderName.Text = tsmFeedItem.Tag
            PNoperation.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmDelete_Click(sender As Object, e As EventArgs) Handles tsmDelete.Click
        Try
            o(3) = "@00WD" & Trim(pindex) & "0000"
            CType(cmsFeedItem.Tag, TextBox).Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Public Sub input_index()
        Try
            If Not TIN_01 Then   ' = False
                pindex = 4050 + MA
            Else
                'If TIN_01 = True Then
                If MA > 8 And MA < 13 Then
                    pindex = 4050 + MA
                ElseIf MA > 22 Then
                    pindex = 4050 + MA
                Else
                    pindex = 4100 + MA
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkChooseTank_CheckedChanged(sender As Object, e As EventArgs) Handles chkChooseTank0.CheckedChanged, chkChooseTank5.CheckedChanged, chkChooseTank4.CheckedChanged, chkChooseTank11.CheckedChanged, chkChooseTank10.CheckedChanged, chkChooseTank9.CheckedChanged, chkChooseTank8.CheckedChanged, chkChooseTank3.CheckedChanged, chkChooseTank2.CheckedChanged, chkChooseTank13.CheckedChanged, chkChooseTank12.CheckedChanged, chkChooseTank7.CheckedChanged, chkChooseTank6.CheckedChanged, chkChooseTank1.CheckedChanged
        Try
            Dim a As String
            a = Trim(Str(600 + sender.tag))
            If sender.CheckState = 0 Then
                o(3) = "@00KSHR  000" & a
            Else
                o(3) = "@00KRHR  000" & a
            End If
            o(4) = "@00KC"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chkViberativeperatur_CheckedChanged(sender As Object, e As EventArgs) Handles chkViberativeperatur9.CheckedChanged, chkViberativeperatur8.CheckedChanged, chkViberativeperatur7.CheckedChanged, chkViberativeperatur6.CheckedChanged, chkViberativeperatur5.CheckedChanged, chkViberativeperatur4.CheckedChanged, chkViberativeperatur3.CheckedChanged, chkViberativeperatur2.CheckedChanged, chkViberativeperatur11.CheckedChanged, chkViberativeperatur10.CheckedChanged, chkViberativeperatur1.CheckedChanged, chkViberativeperatur0.CheckedChanged
        Try
            Dim a As String
            a = Trim(Str(400 + sender.tag))
            If sender.CheckState = 0 Then
                o(3) = "@00KSHR  000" & a
            Else
                o(3) = "@00KRHR  000" & a
            End If
            o(4) = "@00KC"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chkTempartureilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkTempartureilter9.CheckedChanged, chkTempartureilter8.CheckedChanged, chkTempartureilter7.CheckedChanged, chkTempartureilter6.CheckedChanged, chkTempartureilter5.CheckedChanged, chkTempartureilter4.CheckedChanged, chkTempartureilter3.CheckedChanged, chkTempartureilter2.CheckedChanged, chkTempartureilter11.CheckedChanged, chkTempartureilter10.CheckedChanged, chkTempartureilter1.CheckedChanged, chkTempartureilter0.CheckedChanged
        Try
            Dim a As String
            a = Trim(Str(8000 + sender.tag))
            If sender.CheckState = 0 Then
                o(3) = "@00KSHR  000" & a
            Else
                o(3) = "@00KRHR  000" & a
            End If
            o(4) = "@00KC"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chkFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilter9.CheckedChanged, chkFilter8.CheckedChanged, chkFilter7.CheckedChanged, chkFilter6.CheckedChanged, chkFilter5.CheckedChanged, chkFilter4.CheckedChanged, chkFilter3.CheckedChanged, chkFilter2.CheckedChanged, chkFilter13.CheckedChanged, chkFilter12.CheckedChanged, chkFilter11.CheckedChanged, chkFilter10.CheckedChanged, chkFilter1.CheckedChanged, chkFilter0.CheckedChanged
        Try
            Dim a As String
            a = Trim(Str(20600 + sender.tag))
            If sender.CheckState = 0 Then
                o(3) = "@00KSCIO 0" & a
            Else
                o(3) = "@00KRCIO 0" & a
            End If
            o(4) = "@00KC"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnACrame_MouseDown(sender As Object, e As MouseEventArgs) Handles btnACrame5.MouseDown, btnACrame4.MouseDown, btnACrame3.MouseDown, btnACrame2.MouseDown, btnACrame1.MouseDown, btnACrame0.MouseDown
        Try
            Select Case sender.tag
                Case 0
                    o(3) = "@00KSCIO 000410"
                Case 1
                    o(3) = "@00KSCIO 000514"
                Case 2
                    o(3) = "@00KSCIO 000411"
                Case 3
                    o(3) = "@00KSCIO 000515"
                Case 4
                    o(3) = "@00KSCIO 000412"
                Case 5
                    o(3) = "@00KSCIO 000413"
                Case 6
                    o(3) = "@00KSCIO 002909"
                    o(4) = "@00KRCIO 002909"
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnACrame_MouseUp(sender As Object, e As MouseEventArgs) Handles btnACrame5.MouseUp, btnACrame4.MouseUp, btnACrame3.MouseUp, btnACrame2.MouseUp, btnACrame1.MouseUp, btnACrame0.MouseUp
        Try
            If o(3) = "" Then o(3) = "@00KC" Else o(4) = "@00KC"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnBCrame_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBCrame5.MouseDown, btnBCrame4.MouseDown, btnBCrame3.MouseDown, btnBCrame2.MouseDown, btnBCrame1.MouseDown, btnBCrame0.MouseDown
        Select Case sender.tag
            Case 0
                o(3) = "@00KSCIO 000210"
            Case 1
                o(3) = "@00KSCIO 000312"
            Case 2
                o(3) = "@00KSCIO 000211"
            Case 3
                o(3) = "@00KSCIO 000313"
            Case 4
                o(3) = "@00KSCIO 000212"
            Case 5
                o(3) = "@00KSCIO 000213"
            Case 6
                o(3) = "@00KSCIO 002914"
                o(4) = "@00KRCIO 002914"
        End Select
    End Sub
    Private Sub btnBCrame_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBCrame5.MouseUp, btnBCrame4.MouseUp, btnBCrame3.MouseUp, btnBCrame2.MouseUp, btnBCrame1.MouseUp, btnBCrame0.MouseUp
        Try
            If o(3) = "" Then o(3) = "@00KC" Else o(4) = "@00KC"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            eros = ""
            Text10.Text = ""
            lstFaultDisply.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSystemControl_Click(sender As Object, e As EventArgs) Handles btnSystemControl4.Click, btnSystemControl3.Click, btnSystemControl2.Click, btnSystemControl1.Click, btnSystemControl0.Click
        Try
            Select Case sender.tag
                Case 0
                    o(3) = "@00KSCIO 000000"
                    o(4) = "@00KRCIO 000000"
                    o(5) = "@00KC"
                Case 1
                    o(3) = "@00KRCIO 000001"
                    o(4) = "@00KSCIO 000001"
                    o(5) = "@00KRHR  000514"
                    o(6) = "@00KC"
                Case 2
                    o(3) = "@00KSHR  000514"
                    o(4) = "@00KC"
                Case 3
                    If sender.text <> "Cont" Then o(3) = "@00KSHR  000414" Else o(3) = "@00KRHR  000414"
                    o(4) = "@00KC"
                Case 4
                    If sender.text <> "AG Open" Then o(3) = "@00KSHR  000512" Else o(3) = "@00KRHR  000512"
                    o(4) = "@00KC"
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub r0_display()
        On Error Resume Next
        Dim j, k, l As Integer
        Dim i, q, n, m As Integer
        Dim Ii(15, 9) As Boolean
        Dim AH(11) As String
        Dim stime(11) As String
        Dim AHand(11) As String
        Dim ddd, dd As String

        If RID(13, 4) = "" Or Val(RID(13, 4)) = 0 Then Exit Sub
        n = 0
        For i = 1 To 5
            For q = 0 To 9
                If n < 39 Then Ntim(n) = RID(i, q)
                If n < 39 Then Ncode(n) = RID(i + 5, q) Else Ncode(n) = ""
                If n < 23 Then Ncode(n + 50) = RID(i + 10, q)
                If n < 10 Then
                    AH(n) = RID(i + 18, q)
                    stime(n) = RID(i + 19, q)
                    AHand(i) = RID(Int(q / 5) + 20 + i, (q * 2) + 1) + RID(Int(q / 5) + 20 + i, (q * 2))
                End If
                n = n + 1
            Next q
            q = 0
        Next i

        TIN_02 = True
        For m = 0 To dgvMonitorScreen.Rows.Count - 1
            dgvMonitorScreen.Rows(m + 1).Cells(6).Value = Val(Ntim(m + 1))
            If Val(Ntim(m + 1)) <> 0 Then Ntim_1(m + 2) = Val(Ntim(m + 1))
            If TIN_01 = False And TIN_02 = True Then
                If Ncode(m + 1) = "0000" Then
                    dgvMonitorScreen.Rows(m + 1).Cells(4).Value = "" : dgvMonitorScreen.Rows(m + 1).Cells(5).Value = ""
                Else
                    For k = 1 To dgvMonitorScreen.Rows.Count - 1
                        If Val(Strings.Right(Ncode(m + 1), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                            dgvMonitorScreen.Rows(m + 1).Cells(4).Value = dgvMonitorScreen.Rows(k).Cells(0).Value
                            dgvMonitorScreen.Rows(m + 1).Cells(5).Value = Val(Strings.Left(Ncode(m + 1), 2))
                            Exit For
                        End If
                    Next
                End If
            Else
                If TIN_01 = True Then
                    If m < 8 Then
                        If Ncode(m + 51) = "0000" Then
                            dgvMonitorScreen.Rows(m + 1).Cells(4).Value = "" : dgvMonitorScreen.Rows(m + 1).Cells(5).Value = ""
                        Else
                            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                                If Val(Strings.Right(Ncode(m + 51), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                                    dgvMonitorScreen.Rows(m + 1).Cells(4).Value = dgvMonitorScreen.Rows(k).Cells(0).Value
                                    dgvMonitorScreen.Rows(m + 1).Cells(5).Value = Val(Strings.Left(Ncode(m + 51), 2))
                                    Exit For
                                End If
                            Next
                        End If
                    ElseIf m > 11 And m < 22 Then
                        If Ncode(m + 51) = "0000" Then
                            dgvMonitorScreen.Rows(m + 1).Cells(4).Value = "" : dgvMonitorScreen.Rows(m + 1).Cells(5).Value = ""
                        Else
                            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                                If Val(Strings.Right(Ncode(m + 51), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                                    dgvMonitorScreen.Rows(m + 1).Cells(4).Value = dgvMonitorScreen.Rows(k).Cells(0).Value
                                    dgvMonitorScreen.Rows(m + 1).Cells(5).Value = Val(Strings.Left(Ncode(m + 51), 2))
                                    Exit For
                                End If
                            Next
                        End If
                    Else
                        If Ncode(m + 1) = "0000" Then
                            dgvMonitorScreen.Rows(m + 1).Cells(4).Value = "" : dgvMonitorScreen.Rows(m + 1).Cells(5).Value = ""
                        Else
                            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                                If Val(Strings.Right(Ncode(m + 1), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                                    dgvMonitorScreen.Rows(m + 1).Cells(4).Value = dgvMonitorScreen.Rows(k).Cells(0).Value
                                    dgvMonitorScreen.Rows(m + 1).Cells(5).Value = Val(Strings.Left(Ncode(m + 1), 2))
                                    Exit For
                                End If
                            Next k
                        End If
                    End If
                End If
            End If
        Next

        For i = 0 To 3
            dgvMonitorScreen.Rows(i + 9).Cells(7).Value = Val(RID(Int((2 * i) / 10) + 14, 2 * i - Int((2 * i) / 10) * 10))
            dgvMonitorScreen.Rows(i + 9).Cells(8).Value = Val(RID(Int((2 * i + 1) / 10) + 14, 2 * i - Int((2 * i) / 10) * 10 + 1))
        Next

        For i = 4 To 23
            dgvMonitorScreen.Rows(i + 9).Cells(7).Value = Val(RID(Int((2 * i) / 10) + 14, 2 * i - Int((2 * i) / 10) * 10))
            dgvMonitorScreen.Rows(i + 9).Cells(8).Value = Val(RID(Int((2 * i + 1) / 10) + 14, 2 * i - Int((2 * i) / 10) * 10 + 1))
        Next

        dd = Int((2 * i + 1) / 10) + 14
        ddd = 2 * i - Int((2 * i) / 10) * 10 + 1

        If RID(6, 0) = "0000" Then
            txtUploadA.Text = "Without item"
        Else
            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                If Val(Strings.Right(RID(6, 0), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                    txtUploadA.Text = "(" & Val(Strings.Left(RID(6, 0), 2)) & ")" & dgvMonitorScreen.Rows(k).Cells(0).Value
                End If
            Next
        End If

        If RID(11, 0) = "0000" Then
            txtUploadB.Text = "without item "
        Else
            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                If Val(Strings.Right(RID(11, 0), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                    txtUploadB.Text = "(" & Val(Strings.Left(RID(11, 0), 2)) & ")" & dgvMonitorScreen.Rows(k).Cells(0).Value
                End If
            Next
        End If


        If RID(11, 9) = "0000" Then
            txtFeedItem2.Text = "without item"
        Else
            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                If Val(Strings.Right(RID(11, 9), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                    txtFeedItem2.Text = "(" & Val(Strings.Left(RID(11, 9), 2)) & ")" & dgvMonitorScreen.Rows(k).Cells(0).Value
                End If
            Next
        End If

        If RID(12, 0) = "0000" Then
            txtFeedItem3.Text = "without item"
        Else
            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                If Val(Strings.Right(RID(12, 0), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                    txtFeedItem3.Text = "(" & Val(Strings.Left(RID(12, 0), 2)) & ")" & dgvMonitorScreen.Rows(k).Cells(0).Value
                End If
            Next
        End If

        If RID(12, 1) = "0000" Then
            txtFeedItem4.Text = "without item"
        Else
            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                If Val(Strings.Right(RID(12, 1), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                    txtFeedItem4.Text = "(" & Val(Strings.Left(RID(12, 1), 2)) & ")" & dgvMonitorScreen.Rows(k).Cells(0).Value
                End If
            Next
        End If

        If RID(12, 2) = "0000" Then
            txtFeedItem5.Text = "without item"
        Else
            For k = 1 To dgvMonitorScreen.Rows.Count - 1
                If Val(Strings.Right(RID(12, 2), 2)) = Val(dgvMonitorScreen.Rows(k).Cells(11).Value) Then
                    txtFeedItem5.Text = "(" & Val(Strings.Left(RID(12, 2), 2)) & ")" & dgvMonitorScreen.Rows(k).Cells(0).Value
                End If
            Next
        End If

        Text1_1.Text = Val(Strings.Right(RID(0, 0), 2))
        Text1_0.Text = Val(Strings.Left(RID(0, 0), 2))
        Text2_0.Text = Val(Strings.Left((RID(0, 1)), 2))
        Text2_1.Text = Val(Strings.Right((RID(0, 1)), 2))
        Text9_0.Text = Str(Val(RID(0, 2))) & "s"
        Text9_1.Text = Str(Val(RID(0, 3))) & "s"
        Text11_0.Text = Str(Val(RID(5, 7)))
        Text11_1.Text = Str(Val(RID(5, 8)))
        Text11_2.Text = Str(Val(RID(5, 9)))
        Label5_0.Text = CStr(Val(RID(13, 8)))
        Label5_1.Text = CStr(Val(RID(13, 9)))
        Text6.Text = "process--- " & Strings.Left(RID(0, 5), 1)

        If Val(Mid(RID(0, 5), 2, 1)) = 0 Then
            text7.Text = "service"
            text7.ReadOnly = False
            btnSystemControl0.Enabled = False
            btnSystemControl1.Enabled = True
            btnSystemControl2.Enabled = False

            btnACrame0.Enabled = True
            btnACrame1.Enabled = True
            btnACrame2.Enabled = True
            btnACrame3.Enabled = True
            btnACrame4.Enabled = True
            btnACrame5.Enabled = True
            btnACrame6.Enabled = True

            btnBCrame0.Enabled = True
            btnBCrame1.Enabled = True
            btnBCrame2.Enabled = True
            btnBCrame3.Enabled = True
            btnBCrame4.Enabled = True
            btnBCrame5.Enabled = True
            btnBCrame6.Enabled = True

        ElseIf Val(Mid(RID(0, 5), 2, 1)) = 1 Then
            text7.Text = "Manu"
            text7.ReadOnly = True
            btnSystemControl0.Enabled = True
            btnSystemControl2.Enabled = True
            btnSystemControl1.Enabled = False

            btnACrame0.Enabled = True
            btnACrame1.Enabled = True
            btnACrame2.Enabled = True
            btnACrame3.Enabled = True

            btnBCrame0.Enabled = True
            btnBCrame1.Enabled = True
            btnBCrame2.Enabled = True
            btnBCrame3.Enabled = True

            btnACrame4.Enabled = False
            btnACrame5.Enabled = False

            btnBCrame4.Enabled = False
            btnBCrame5.Enabled = False

            btnACrame6.Enabled = True
            btnBCrame6.Enabled = True

        ElseIf Val(Mid(RID(0, 5), 2, 1)) = 2 Then
            text7.Text = "Auto"
            text7.ReadOnly = True
            btnSystemControl2.Enabled = False
            btnSystemControl0.Enabled = False
            btnSystemControl1.Enabled = True

            btnACrame0.Enabled = False
            btnACrame1.Enabled = False
            btnACrame2.Enabled = False
            btnACrame3.Enabled = False
            btnACrame4.Enabled = False
            btnACrame5.Enabled = False
            btnACrame6.Enabled = False

            btnBCrame0.Enabled = False
            btnBCrame1.Enabled = False
            btnBCrame2.Enabled = False
            btnBCrame3.Enabled = False
            btnBCrame4.Enabled = False
            btnBCrame5.Enabled = False
            btnBCrame6.Enabled = False

        End If

        If RID(0, 4) = "0000" Then
            Text10.Text = "Failure-free！"
        Else
            If eros <> RID(0, 4) Then
                Dim dt As DataTable = GETDATATABLE("Select * from useradmin.tbl_ErrorCode_mst where chvCode ='" & RID(0, 4) & "'")
                If dt Is Nothing Or dt.Rows.Count <= 0 Then
                    Text10.Text = dt.Rows(0).Item("chvContent")
                End If
                eros = RID(0, 4)
            End If
        End If

        Label7_0.Text = Val(AH(0))
        Label7_1.Text = Val(AH(1))
        Label7_2.Text = Val(AH(2))
        Label7_3.Text = Val(AH(3))
        Label7_4.Text = Val(AH(4))
        Label7_5.Text = Val(AH(5))
        Label7_6.Text = Val(AH(6))
        Label7_7.Text = Val(AH(7))
        Label7_8.Text = Val(AH(8))
        Label7_9.Text = Val(AH(9))

        Label8_0.Text = Val(stime(0))
        Label8_1.Text = Val(stime(1))
        Label8_2.Text = Val(stime(2))
        Label8_3.Text = Val(stime(3))
        Label8_4.Text = Val(stime(4))
        Label8_5.Text = Val(stime(5))
        Label8_6.Text = Val(stime(6))
        Label8_7.Text = Val(stime(7))
        Label8_8.Text = Val(stime(8))
        Label8_9.Text = Val(stime(9))

        Label9_0.Text = Val(AHand(0))
        Label9_1.Text = Val(AHand(1))
        Label9_2.Text = Val(AHand(2))
        Label9_3.Text = Val(AHand(3))
        Label9_4.Text = Val(AHand(4))
        Label9_5.Text = Val(AHand(5))
        Label9_6.Text = Val(AHand(6))
        Label9_7.Text = Val(AHand(7))
        Label9_8.Text = Val(AHand(8))
        Label9_9.Text = Val(AHand(9))

        For i = 1 To 4
            hn = Mid(RID(5, 2), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 2) = bn(0)
            Ii(15 + 3 - 4 * i, 2) = bn(1)
            Ii(15 + 2 - 4 * i, 2) = bn(2)
            Ii(15 + 1 - 4 * i, 2) = bn(3)
            hn = Mid(RID(5, 3), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 3) = bn(0)
            Ii(15 + 3 - 4 * i, 3) = bn(1)
            Ii(15 + 2 - 4 * i, 3) = bn(2)
            Ii(15 + 1 - 4 * i, 3) = bn(3)
            hn = Mid(RID(5, 4), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 4) = bn(0)
            Ii(15 + 3 - 4 * i, 4) = bn(1)
            Ii(15 + 2 - 4 * i, 4) = bn(2)
            Ii(15 + 1 - 4 * i, 4) = bn(3)
            hn = Mid(RID(5, 6), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 5) = bn(0)
            Ii(15 + 3 - 4 * i, 5) = bn(1)
            Ii(15 + 2 - 4 * i, 5) = bn(2)
            Ii(15 + 1 - 4 * i, 5) = bn(3)
            hn = Mid(RID(5, 5), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 6) = bn(0)
            Ii(15 + 3 - 4 * i, 6) = bn(1)
            Ii(15 + 2 - 4 * i, 6) = bn(2)
            Ii(15 + 1 - 4 * i, 6) = bn(3)
            hn = Mid(RID(13, 5), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 7) = bn(0)
            Ii(15 + 3 - 4 * i, 7) = bn(1)
            Ii(15 + 2 - 4 * i, 7) = bn(2)
            Ii(15 + 1 - 4 * i, 7) = bn(3)
            hn = Mid(RID(13, 6), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 8) = bn(0)
            Ii(15 + 3 - 4 * i, 8) = bn(1)
            Ii(15 + 2 - 4 * i, 8) = bn(2)
            Ii(15 + 1 - 4 * i, 8) = bn(3)
            hn = Mid(RID(13, 7), i, 1)
            Call hex_bin
            Ii(15 + 4 - 4 * i, 9) = bn(0)
            Ii(15 + 3 - 4 * i, 9) = bn(1)
            Ii(15 + 2 - 4 * i, 9) = bn(2)
            Ii(15 + 1 - 4 * i, 9) = bn(3)
        Next i

        chkChooseTank0.Checked = Ii(i, 6)
        chkChooseTank1.Checked = Ii(i, 6)
        chkChooseTank2.Checked = Ii(i, 6)
        chkChooseTank3.Checked = Ii(i, 6)
        chkChooseTank4.Checked = Ii(i, 6)
        chkChooseTank5.Checked = Ii(i, 6)
        chkChooseTank6.Checked = Ii(i, 6)
        chkChooseTank7.Checked = Ii(i, 6)
        chkChooseTank8.Checked = Ii(i, 6)
        chkChooseTank9.Checked = Ii(i, 6)
        chkChooseTank10.Checked = Ii(i, 6)
        chkChooseTank11.Checked = Ii(i, 6)
        chkChooseTank12.Checked = Ii(i, 6)
        chkChooseTank13.Checked = Ii(i, 6)

        chkViberativeperatur0.Checked = Ii(i, 4)
        chkViberativeperatur1.Checked = Ii(i, 4)
        chkViberativeperatur2.Checked = Ii(i, 4)
        chkViberativeperatur3.Checked = Ii(i, 4)
        chkViberativeperatur4.Checked = Ii(i, 4)
        chkViberativeperatur5.Checked = Ii(i, 4)
        chkViberativeperatur6.Checked = Ii(i, 4)
        chkViberativeperatur7.Checked = Ii(i, 4)
        chkViberativeperatur8.Checked = Ii(i, 4)
        chkViberativeperatur9.Checked = Ii(i, 4)
        chkViberativeperatur10.Checked = Ii(i, 4)
        chkViberativeperatur11.Checked = Ii(i, 4)

        chkTempartureilter0.Checked = Ii(i, 2)
        chkTempartureilter1.Checked = Ii(i, 2)
        chkTempartureilter2.Checked = Ii(i, 2)
        chkTempartureilter3.Checked = Ii(i, 2)
        chkTempartureilter4.Checked = Ii(i, 2)
        chkTempartureilter5.Checked = Ii(i, 2)
        chkTempartureilter6.Checked = Ii(i, 2)
        chkTempartureilter7.Checked = Ii(i, 2)
        chkTempartureilter8.Checked = Ii(i, 2)
        chkTempartureilter9.Checked = Ii(i, 2)
        chkTempartureilter10.Checked = Ii(i, 2)
        chkTempartureilter11.Checked = Ii(i, 2)

        Dim Alrm1BackColor As Color
        If Ii(i, 8) Then Alrm1BackColor = Color.Green Else Alrm1BackColor = Color.Red
        label12_11.BackColor = Alrm1BackColor : label12_10.BackColor = Alrm1BackColor : label12_9.BackColor = Alrm1BackColor : label12_8.BackColor = Alrm1BackColor : label12_7.BackColor = Alrm1BackColor : label12_6.BackColor = Alrm1BackColor : label12_5.BackColor = Alrm1BackColor : label12_4.BackColor = Alrm1BackColor : label12_3.BackColor = Alrm1BackColor : label12_2.BackColor = Alrm1BackColor : label12_1.BackColor = Alrm1BackColor : label12_0.BackColor = Alrm1BackColor

        check5_0.Checked = Ii(i, 5)
        check5_1.Checked = Ii(i, 5)
        check5_2.Checked = Ii(i, 5)
        check5_3.Checked = Ii(i, 5)
        check5_4.Checked = Ii(i, 5)
        check5_5.Checked = Ii(i, 5)
        check5_6.Checked = Ii(i, 5)
        check5_7.Checked = Ii(i, 5)
        check5_8.Checked = Ii(i, 5)
        check5_9.Checked = Ii(i, 5)

        Dim Label6BackColor As Color
        If Ii(i, 8) Then Label6BackColor = Color.Green Else Label6BackColor = Color.Red
        Label6_9.BackColor = Label6BackColor : Label6_8.BackColor = Label6BackColor : Label6_7.BackColor = Label6BackColor : Label6_6.BackColor = Label6BackColor : Label6_5.BackColor = Label6BackColor : Label6_4.BackColor = Label6BackColor : Label6_3.BackColor = Label6BackColor : Label6_2.BackColor = Label6BackColor : Label6_1.BackColor = Label6BackColor : Label6_0.BackColor = Label6BackColor

        chkFilter0.Checked = Ii(i, 3)
        chkFilter1.Checked = Ii(i, 3)
        chkFilter2.Checked = Ii(i, 3)
        chkFilter3.Checked = Ii(i, 3)
        chkFilter4.Checked = Ii(i, 3)
        chkFilter5.Checked = Ii(i, 3)
        chkFilter6.Checked = Ii(i, 3)
        chkFilter7.Checked = Ii(i, 3)
        chkFilter8.Checked = Ii(i, 3)
        chkFilter9.Checked = Ii(i, 3)
        chkFilter10.Checked = Ii(i, 3)
        chkFilter11.Checked = Ii(i, 3)
        chkFilter12.Checked = Ii(i, 3)
        chkFilter13.Checked = Ii(i, 3)

        Dim Label13BackColor As Color
        If Ii(i, 9) Then Label13BackColor = Color.Green Else Label13BackColor = Color.Red
        label13_13.BackColor = Label13BackColor : label13_12.BackColor = Label13BackColor : label13_11.BackColor = Label13BackColor : label13_10.BackColor = Label13BackColor : label13_9.BackColor = Label13BackColor : label13_8.BackColor = Label13BackColor : label13_7.BackColor = Label13BackColor : label13_6.BackColor = Label13BackColor : label13_5.BackColor = Label13BackColor : label13_4.BackColor = Label13BackColor : label13_3.BackColor = Label13BackColor : label13_2.BackColor = Label13BackColor : label13_1.BackColor = Label13BackColor : label13_0.BackColor = Label13BackColor

        If Ii(12, 5) Then btnSystemControl4.Text = "AGT-ON" Else btnSystemControl4.Text = "AGT-OFF"
        If Ii(14, 4) Then btnSystemControl3.Text = "Cont" Else btnSystemControl3.Text = "once"
        If Text7.Text <> "service" Then
            If Ii(15, 4) Then
                estr = "Auto"
            Else
                estr = "Manul"
            End If
        Else
            estr = "service"
        End If

        'If Ii(10, 6) Or Ii(11, 6) Then MsgBox "请把触摸屏电流控制上板料号开关关闭！", , "警告"  'If Ii(11, 6) Then MsgBox "请把触摸屏电流控制上板料号开关关闭！", , "警告"

        For i = 0 To dgvMonitorScreen.Rows.Count - 1
            If Val(Strings.Left(RID(0, 1), 2)) = i Then
                dgvMonitorScreen.Rows(i).Cells(3).Value = "A"
            ElseIf Val(strings.Right(RID(0, 1), 2)) = i Then
                dgvMonitorScreen.Rows(i).Cells(3).Value = "B"
            ElseIf Val(Strings.Left(RID(0, 0), 2)) = i Then
                If Val(Strings.Left(RID(0, 0), 2)) > Val(Strings.Left(RID(0, 1), 2)) Then
                    dgvMonitorScreen.Rows(i).Cells(3).Value = "▲"  '△▲▼▽
                Else
                    dgvMonitorScreen.Rows(i).Cells(3).Value = "▼"
                End If
            ElseIf Val(strings.Right(RID(0, 0), 2)) = i Then
                If Val(strings.Right(RID(0, 0), 2)) > Val(strings.Right(RID(0, 1), 2)) Then
                    dgvMonitorScreen.Rows(i).Cells(3).Value = "△"
                Else
                    dgvMonitorScreen.Rows(i).Cells(3).Value = "▽"
                End If
            Else
                If i <> Val(RID(0, 0)) Then
                    dgvMonitorScreen.Rows(i).Cells(3).Value = ""
                End If
            End If
        Next

        ' -----------------------------------------------------------------------------------------------

        'Timer10 = True
    End Sub
    Private Sub Timer6_Timer()
        'If Not Add_liao.Visible Then
        'If Text5.Text <> "load complete" Then Call r0_display() : 
        'r0q = False
        'End If
    End Sub
    Public Function hex_bin() As String
        hex_bin = ""
        Try
            Dim hnn As String = ""
            Select Case hn
                Case "F"
                    hnn = "1111"
                Case "E"
                    hnn = "1110"
                Case "D"
                    hnn = "1101"
                Case "C"
                    hnn = "1100"
                Case "B"
                    hnn = "1011"
                Case "A"
                    hnn = "1010"
                Case "9"
                    hnn = "1001"
                Case "8"
                    hnn = "1000"
                Case "7"
                    hnn = "0111"
                Case "6"
                    hnn = "0110"
                Case "5"
                    hnn = "0101"
                Case "4"
                    hnn = "0100"
                Case "3"
                    hnn = "0011"
                Case "2"
                    hnn = "0010"
                Case "1"
                    hnn = "0001"
                Case "0"
                    hnn = "0000"
            End Select
            Dim sf
            For i = 0 To 3
                sf = Mid(hnn, (i + 1), 1)
                If sf = 1 Then bn(i) = True Else bn(i) = False
            Next i
        Catch ex As Exception

        End Try
    End Function





End Class