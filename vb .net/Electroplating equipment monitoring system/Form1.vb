'MSFlexGrid1.TextMatrix(m + 1, 4) = "" : MSFlexGrid1.TextMatrix(m + 1, 5) = ""
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(Ncode(m + 1), 2)) = Val(min.MSFlexGrid2.TextMatrix(k, 11)) Then
'min.MSFlexGrid1.TextMatrix(m + 1, 4) = min.MSFlexGrid2.TextMatrix(k, 0)
'min.MSFlexGrid1.TextMatrix(m + 1, 5) = Val(Left(Ncode(m + 1), 2))
'Exit For
'End If
'Next k
'End If
'Else
'If TIN_01 = True Then
'If m < 8 Then
'If Ncode(m + 51) = "0000" Then
'MSFlexGrid1.TextMatrix(m + 1, 4) = "" : MSFlexGrid1.TextMatrix(m + 1, 5) = ""
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(Ncode(m + 51), 2)) = Val(min.MSFlexGrid2.TextMatrix(k, 11)) Then
'min.MSFlexGrid1.TextMatrix(m + 1, 4) = min.MSFlexGrid2.TextMatrix(k, 0)
'min.MSFlexGrid1.TextMatrix(m + 1, 5) = Val(Left(Ncode(m + 51), 2))
'Exit For
'End If
'Next k
'End If
'ElseIf m > 11 And m < 22 Then
'If Ncode(m + 51) = "0000" Then
'MSFlexGrid1.TextMatrix(m + 1, 4) = "" : MSFlexGrid1.TextMatrix(m + 1, 5) = ""
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(Ncode(m + 51), 2)) = Val(min.MSFlexGrid2.TextMatrix(k, 11)) Then
'min.MSFlexGrid1.TextMatrix(m + 1, 4) = min.MSFlexGrid2.TextMatrix(k, 0)
'min.MSFlexGrid1.TextMatrix(m + 1, 5) = Val(Left(Ncode(m + 51), 2))
'Exit For
'End If
'Next k
'End If
'Else
'If Ncode(m + 1) = "0000" Then
'MSFlexGrid1.TextMatrix(m + 1, 4) = "" : MSFlexGrid1.TextMatrix(m + 1, 5) = ""
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(Ncode(m + 1), 2)) = Val(min.MSFlexGrid2.TextMatrix(k, 11)) Then
'min.MSFlexGrid1.TextMatrix(m + 1, 4) = min.MSFlexGrid2.TextMatrix(k, 0)
'min.MSFlexGrid1.TextMatrix(m + 1, 5) = Val(Left(Ncode(m + 1), 2))
'Exit For
'End If
'Next k
'End If
'End If
'End If
'End If
'Next m
'For i = 0 To 3
'min.MSFlexGrid1.TextMatrix(i + 9, 7) = Val(RID(Int((2  i) / 10) + 14, 2  i - Int((2  i) / 10)  10))
'        min.MSFlexGrid1.TextMatrix(i + 9, 8) = Val(RID(Int((2  i + 1) / 10) + 14, 2  i - Int((2  i) / 10)  10 + 1))
'    Next i
'For i = 4 To 23
'min.MSFlexGrid1.TextMatrix(i + 19, 7) = Val(RID(Int((2  i) / 10) + 14, 2  i - Int((2  i) / 10)  10))
'        min.MSFlexGrid1.TextMatrix(i + 19, 8) = Val(RID(Int((2  i + 1) / 10) + 14, 2  i - Int((2  i) / 10)  10 + 1))
'    Next i
'dd = Int((2 * i + 1) / 10) + 14
'ddd = 2  i - Int((2  i) / 10) * 10 + 1
' If RID(6, 0) = "0000" Then
'min.Label2(0).Caption = "Without item"
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(RID(6, 0), 2)) = min.MSFlexGrid2.TextMatrix(k, 11) Then
'min.Label2(0).Caption = "(" & Val(Left(RID(6, 0), 2)) & ")" & min.MSFlexGrid2.TextMatrix(k, 0)
'End If
'Next
'End If
'If RID(11, 0) = "0000" Then
'min.Label2(1).Caption = "without item "
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(RID(11, 0), 2)) = min.MSFlexGrid2.TextMatrix(k, 11) Then
'min.Label2(1).Caption = "(" & Val(Left(RID(11, 0), 2)) & ")" & min.MSFlexGrid2.TextMatrix(k, 0)
'End If
'Next
'End If
'If RID(11, 9) = "0000" Then
'min.Label2(2).Caption = "without item"
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(RID(11, 9), 2)) = min.MSFlexGrid2.TextMatrix(k, 11) Then
'min.Label2(2).Caption = "(" & Val(Left(RID(11, 9), 2)) & ")" & min.MSFlexGrid2.TextMatrix(k, 0)
'End If
'Next
'End If
'If RID(12, 0) = "0000" Then
'min.Label2(3).Caption = "without item"
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(RID(12, 0), 2)) = min.MSFlexGrid2.TextMatrix(k, 11) Then
'min.Label2(3).Caption = "(" & Val(Left(RID(12, 0), 2)) & ")" & min.MSFlexGrid2.TextMatrix(k, 0)
'End If
'Next
'End If
'If RID(12, 1) = "0000" Then
'min.Label2(4).Caption = "without item"
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(RID(12, 1), 2)) = min.MSFlexGrid2.TextMatrix(k, 11) Then
'min.Label2(4).Caption = "(" & Val(Left(RID(12, 1), 2)) & ")" & min.MSFlexGrid2.TextMatrix(k, 0)
'End If
'Next
'End If
'If RID(12, 2) = "0000" Then
'min.Label2(5).Caption = "without item"
'Else
'For k = 1 To min.MSFlexGrid2.Rows - 1
'If Val(Right(RID(12, 2), 2)) = min.MSFlexGrid2.TextMatrix(k, 11) Then
'min.Label2(5).Caption = "(" & Val(Left(RID(12, 2), 2)) & ")" & min.MSFlexGrid2.TextMatrix(k, 0)
'End If
'Next
'End If
'min.text1(1).Text = Val(Right(RID(0, 0), 2))
'min.text1(0).Text = Val(Left(RID(0, 0), 2))
'min.Text2(0).Text = Val(Left((RID(0, 1)), 2))
'min.Text2(1).Text = Val(Right((RID(0, 1)), 2))
'min.Text9(0).Text = Str(Val(RID(0, 2))) & "s"
'min.Text9(1).Text = Str(Val(RID(0, 3))) & "s"
'min.Text11(0).Text = Str(Val(RID(5, 7)))
'min.Text11(1).Text = Str(Val(RID(5, 8)))
'min.Text11(2).Text = Str(Val(RID(5, 9)))
'min.Label5(0).Caption = CStr(Val(RID(13, 8)))
'min.Label5(1).Caption = CStr(Val(RID(13, 9)))
'min.Text6.Text = "process--- " & Left(RID(0, 5), 1)

'If Val(Mid(RID(0, 5), 2, 1)) = 0 Then
'min.Text7.Text = "service"
'min.Text7.Locked = False
'min.Command3(0).Enabled = False
'min.Command3(1).Enabled = True
'min.Command3(2).Enabled = False
'For i = 0 To 6
'min.Command1(i).Enabled = True
'min.Command11(i).Enabled = True
'Next i
'ElseIf Val(Mid(RID(0, 5), 2, 1)) = 1 Then
'min.Text7.Text = "Manu"
'min.Text7.Locked = True
'min.Command3(0).Enabled = True
'min.Command3(2).Enabled = True
'min.Command3(1).Enabled = False
'For i = 0 To 3
'min.Command1(i).Enabled = True
'min.Command11(i).Enabled = True
'Next i
'For i = 4 To 5
'min.Command1(i).Enabled = False
'min.Command11(i).Enabled = False
'Next i
'min.Command1(6).Enabled = True
'min.Command11(6).Enabled = True
'ElseIf Val(Mid(RID(0, 5), 2, 1)) = 2 Then
'min.Text7.Text = "Auto"
'min.Text7.Locked = True
'min.Command3(2).Enabled = False
'min.Command3(0).Enabled = False
'min.Command3(1).Enabled = True
'For i = 0 To 6
'min.Command1(i).Enabled = False
'min.Command11(i).Enabled = False
'Next i

'End If
'If RID(0, 4) = "0000" Then
'min.Text10.Text = "Failure-free！"
'Else
'Dim rs1 As New Recordset
'Dim sq1 As String
'If eros <> RID(0, 4) Then
'sq1 = "select * from 故障代码  where 代码 ='" & RID(0, 4) & "'"
'rs1.Open sq1, conn, adOpenKeyset, adLockPessimistic
'    Do While Not rs1.EOF
'min.Text10.Text = rs1.Fields(1)       ' & rs1.Fields(1)
'rs1.MoveNext
'Loop
'rs1.Close
'eros = RID(0, 4)
'End If
'End If
'For i = 0 To 9
'Me.Label7(i).Caption = Val(AH(i))
'Me.Label8(i).Caption = Val(stime(i))
'Me.Label9(i).Caption = Val(AHand(i))
'Next
'For i = 1 To 4
'hn = Mid(RID(5, 2), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 2) = bn(0)
'Ii(15 + 3 - 4 * i, 2) = bn(1)
'Ii(15 + 2 - 4 * i, 2) = bn(2)
'Ii(15 + 1 - 4 * i, 2) = bn(3)
'hn = Mid(RID(5, 3), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 3) = bn(0)
'Ii(15 + 3 - 4 * i, 3) = bn(1)
'Ii(15 + 2 - 4 * i, 3) = bn(2)
'Ii(15 + 1 - 4 * i, 3) = bn(3)
'hn = Mid(RID(5, 4), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 4) = bn(0)
'Ii(15 + 3 - 4 * i, 4) = bn(1)
'Ii(15 + 2 - 4 * i, 4) = bn(2)
'Ii(15 + 1 - 4 * i, 4) = bn(3)
'hn = Mid(RID(5, 6), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 5) = bn(0)
'Ii(15 + 3 - 4 * i, 5) = bn(1)
'Ii(15 + 2 - 4 * i, 5) = bn(2)
'Ii(15 + 1 - 4 * i, 5) = bn(3)
'hn = Mid(RID(5, 5), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 6) = bn(0)
'Ii(15 + 3 - 4 * i, 6) = bn(1)
'Ii(15 + 2 - 4 * i, 6) = bn(2)
'Ii(15 + 1 - 4 * i, 6) = bn(3)
'hn = Mid(RID(13, 5), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 7) = bn(0)
'Ii(15 + 3 - 4 * i, 7) = bn(1)
'Ii(15 + 2 - 4 * i, 7) = bn(2)
'Ii(15 + 1 - 4 * i, 7) = bn(3)
'hn = Mid(RID(13, 6), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 8) = bn(0)
'Ii(15 + 3 - 4 * i, 8) = bn(1)
'Ii(15 + 2 - 4 * i, 8) = bn(2)
'Ii(15 + 1 - 4 * i, 8) = bn(3)
'hn = Mid(RID(13, 7), i, 1)
'Call hex_bin
'Ii(15 + 4 - 4 * i, 9) = bn(0)
'Ii(15 + 3 - 4 * i, 9) = bn(1)
'Ii(15 + 2 - 4 * i, 9) = bn(2)
'Ii(15 + 1 - 4 * i, 9) = bn(3)
'Next i
'For i = 0 To 11
'If Ii(i, 6) Then min.Check1(i).Value = 1 Else min.Check1(i).Value = 0
'    If Ii(i, 4) Then min.Check2(i).Value = 1 Else min.Check2(i).Value = 0
'    If Ii(i, 2) Then min.Check3(i).Value = 1 Else min.Check3(i).Value = 0
'    If Ii(i, 8) Then Me.Label12(i).BackColor = &HFF& Else Me.Label12(i).BackColor = &HFF00&
'Next i
'For i = 0 To 9
'If Ii(i, 5) Then min.Check5(i).Value = 1 Else min.Check5(i).Value = 0
'    If Ii(i, 7) Then Me.Label6(i).BackColor = &HFF& Else Me.Label6(i).BackColor = &HFF00&
'Next i
'For i = 0 To 13
'If Ii(i, 3) Then min.Check4(i).Value = 1 Else min.Check4(i).Value = 0
'    If Ii(i, 9) Then Me.Label13(i).BackColor = &HFF& Else Me.Label13(i).BackColor = &HFF00&
'Next i
'If Ii(12, 5) Then Command3(4).Caption = "AGT-ON" Else Command3(4).Caption = "AGT-OFF"
'If Ii(14, 4) Then Command3(3).Caption = "Cont" Else Command3(3).Caption = "once"
'  If Text7.Text <> "service" Then
'If Ii(15, 4) Then
'estr = "Auto"
'Else
'estr = "Manul"
'End If
'Else
'estr = "service"
'End If
''If Ii(10, 6) Or Ii(11, 6) Then MsgBox "请把触摸屏电流控制上板料号开关关闭！", , "警告"  'If Ii(11, 6) Then MsgBox "请把触摸屏电流控制上板料号开关关闭！", , "警告"
'For i = 1 To vv
'min.MSFlexGrid1.TextStyle = 0
'min.MSFlexGrid1.CellPictureAlignment = 4
'min.MSFlexGrid1.FillStyle = flexFillSingle
'If Val(Left(RID(0, 1), 2)) = i Then
'min.MSFlexGrid1.TextMatrix(i, 3) = "A"
'ElseIf Val(Right(RID(0, 1), 2)) = i Then
'min.MSFlexGrid1.TextMatrix(i, 3) = "B"
'ElseIf Val(Left(RID(0, 0), 2)) = i Then
'If Val(Left(RID(0, 0), 2)) > Val(Left(RID(0, 1), 2)) Then
'min.MSFlexGrid1.TextMatrix(i, 3) = "▲"  '△▲▼▽
'Else
'min.MSFlexGrid1.TextMatrix(i, 3) = "▼"
'End If
'ElseIf Val(Right(RID(0, 0), 2)) = i Then
'If Val(Right(RID(0, 0), 2)) > Val(Right(RID(0, 1), 2)) Then
'min.MSFlexGrid1.TextMatrix(i, 3) = "△"
'Else
'min.MSFlexGrid1.TextMatrix(i, 3) = "▽"
'End If
'Else
'If i <> Val(RID(0, 0)) Then
'min.MSFlexGrid1.TextMatrix(i, 3) = ""
'End If
'End If
'Next i
'Timer10 = True
'End Sub
'Private Sub Timer6_Timer()
'    'If Not Add_liao.Visible Then
'    If Text5.Text <> "load complete" Then Call r0_display : r0q = False
'    'End If
'End Sub

'Private Sub Form_Unload(Cancel As Integer)
'    qsr0 = False
'    qsr1 = False
'    qsr2 = False
'    ss1 = ""
'    ss2 = ""
'    ss3 = ""
'    qbch = False
'    r(0) = "" : r(1) = ""
'    ssss = ""
'    For i = 0 To 3
'        bn(i) = False
'    Next
'    For i = 0 To 7
'        r(i) = ""
'    Next
'    For i = 0 To 9
'        o(9) = ""
'    Next
'    r0q = False
'    xx = ""
'    strr1 = ""
'    i = q = 0
'    cher0 = ""
'    cher1 = ""
'    If Me.MSComm1.PortOpen = True Then Me.MSComm1.PortOpen = False
'    Call REGEDIT()
'    Call T_exit()
'    MsgBox "你关掉后生产记录将会记录不准确！", 48, "提示"
'End
'End Sub
'Sub T_exit()
'    On Error Resume Next
'    Open(App.Path & "\STYLE\系统日志.ini") For Input As #1
'          Do While Not EOF(1)
'        Line Input #1, INTEXT
'               TSTR = TSTR + INTEXT + Chr(13) + Chr(10)
'    Loop
'    Close #1
'      TSTR = TSTR + "   " + userID + "               " + Format(Now, "yyyy-mm-dd hh:mm:ss") + "            " + "退出系统" + Chr(13) + Chr(10)
'    If Len(TSTR) > 10000 Then TSTR = Right(TSTR, 9800)
'    Open(App.Path & "\STYLE\系统日志.ini") For Output As #1
'      Print #1, TSTR
'      Close #1
'      End
'End Sub
'Sub T_in()
'    Dim s As Long
'    s = FileLen(App.Path & "\style\系统日志.ini")
'    Open(App.Path & "\style\系统日志.ini") For Input As #1
'    Do While Not EOF(1)
'        Line Input #1, INTEXT
'         TSTR = TSTR + INTEXT + Chr(13) + Chr(10)
'    Loop
'    Close #1
'If s > 10000 Then TSTR = Right(TSTR, 9971)
'    TSTR = TSTR + "   " + userID + "               " + Format(Now, "yyyy-mm-dd hh:mm:ss") + "            " + "系统登录" + Chr(13) + Chr(10)
'    If Len(TSTR) > 10000 Then TSTR = Right(TSTR, 9800)
'    Open(App.Path & "\style\系统日志.ini") For Output As #1
'      Print #1, TSTR
'Close #1
'End Sub
'Sub D_ING()
'    Open(App.Path & "\style\使用料号.ini") For Input As #4
'                          Do While Not EOF(4)
'        Line Input #4, INTEXT
'                               TSTR = TSTR + INTEXT + Chr(13) + Chr(10)
'    Loop
'    Close #4
'                      TSTR = TSTR + "   " + a_instr + "               " + Format(Now, "yyyy-mm-dd hh:mm:ss") + "            " + "删除操作" + Chr(13) + Chr(10)
'    If Len(TSTR) > 10000 Then TSTR = Right(TSTR, 9800)
'    Open(App.Path & "\style\使用料号.ini") For Output As #4
'                            Print #4, TSTR
'                      Close #4
'End Sub

'Private Sub Timer8_Timer()
'    min.Label3.Visible = False
'    min.Timer8.Enabled = False
'End Sub

'Private Sub Timer9_Timer()
'    If Me.MSComm1.PortOpen = True Then Me.MSComm1.PortOpen = False
'    qsr0 = False
'    Me.MSComm1.InBufferCount = 0
'    Me.MSComm1.OutBufferCount = 0
'    Form_Load()
'    Me.Timer9.Enabled = True
'End Sub
'Private Sub Timer10_Timer()
'    For m = 0 To vv
'        If 8 < m And m < 13 Or m > 22 Then
'            If Ncode_1(m) <> Ncode(m) Then
'                If Ncode(m + 0) <> "0000" Then '
'                    add_n(1) = min.MSFlexGrid1.TextMatrix(m + 0, 1)
'                    add_n(2) = min.MSFlexGrid1.TextMatrix(m + 0, 4)
'                    add_n(3) = min.MSFlexGrid1.TextMatrix(m + 0, 5)
'                    If 8 < m And m < 13 Then
'                        For k = 1 To min.MSFlexGrid2.Rows - 1
'                            If add_n(2) = Trim(min.MSFlexGrid2.TextMatrix(k, 0)) Then
'                                add_n(4) = Int(Val(min.MSFlexGrid2.TextMatrix(k, 1) * Val(Left(Ncode(m + 0), 2))))
'                                add_n(5) = Int(Val(min.MSFlexGrid2.TextMatrix(k, 2) * Val(Left(Ncode(m + 0), 2))))
'                                Exit For
'                            End If
'                        Next k
'                    Else
'                        For k = 1 To min.MSFlexGrid2.Rows - 1
'                            If add_n(2) = Trim(min.MSFlexGrid2.TextMatrix(k, 0)) Then
'                                add_n(4) = Int(Val(min.MSFlexGrid2.TextMatrix(k, 6) * Val(Left(Ncode(m + 0), 2))))
'                                add_n(5) = Int(Val(min.MSFlexGrid2.TextMatrix(k, 7) * Val(Left(Ncode(m + 0), 2))))
'                                Exit For
'                            End If
'                        Next k
'                    End If
'                    ' add_n(4) = min.MSFlexGrid1.TextMatrix(m + 0, 7)
'                    'add_n(5) = min.MSFlexGrid1.TextMatrix(m + 0, 8)
'                    If add_n(2) = "" Then add_n(2) = "Item is not clear"
'                    If add_n(3) = "" Then add_n(3) = "quanlity is not clear"
'                    If add_n(4) = "" Then add_n(4) = "Apere is not clear"
'                    If add_n(5) = "" Then add_n(5) = "Apere is not clear"
'                    add_n(6) = "processing "
'                    add_n(7) = Trim(Now)
'                    add_n(8) = "processing"
'                    add_n(9) = "processing"
'                    min.Adodc5.Refresh
'                    Do While (min.Adodc5.Recordset.EOF = False)
'                        If add_n(1) = min.Adodc5.Recordset.Fields(1) And add_n(2) = min.Adodc5.Recordset.Fields(2) And add_n(6) = min.Adodc5.Recordset.Fields(6) Then
'                            ad_b = True
'                            Exit Do
'                        Else
'                            ad_b = False
'                            min.Adodc5.Recordset.MoveNext
'                        End If
'                    Loop
'                    If ad_b = False Then
'                        min.Adodc5.Recordset.AddNew
'                        For k = 1 To 9
'                            min.Adodc5.Recordset.Fields(k) = add_n(k)
'                        Next k
'                        min.Adodc5.Recordset.Update
'                        On Error GoTo add_n
'                    End If
'                Else
'                    If Ncode(m + 0) = "0000" Then  'Ncode_1(m) <> Ncode(m)
'                        min.Adodc5.Refresh
'                        Do While (min.Adodc5.Recordset.EOF = False)
'                            If min.Adodc5.Recordset.Fields(1) = min.MSFlexGrid1.TextMatrix(m + 0, 1) And min.Adodc5.Recordset.Fields(6) = "待出板" Then
'                                add_n(1) = min.Adodc5.Recordset.Fields(1)
'                                add_n(2) = min.Adodc5.Recordset.Fields(2)
'                                add_n(3) = min.Adodc5.Recordset.Fields(3)
'                                add_n(4) = min.Adodc5.Recordset.Fields(4)
'                                add_n(5) = min.Adodc5.Recordset.Fields(5)
'                                add_n(7) = min.Adodc5.Recordset.Fields(7)
'                                add_n(8) = Trim(Now)
'                                add_n(6) = Ntim_1(m + 0)
'                                If Trim(add_n(6)) = "" Then add_n(6) = 0
'                                add_n(9) = Int(((Val(add_n(4)) + Val(add_n(5))) * Val(add_n(6))) / 3600)
'                                For k = 1 To 9
'                                    min.Adodc5.Recordset.Fields(k) = add_n(k)
'                                Next k
'                                On Error GoTo add_n
'                                min.Adodc5.Recordset.Update
'                                Exit Do
'                            Else
'                                min.Adodc5.Recordset.MoveNext
'                            End If
'                        Loop
'                    End If
'                End If
'                Ncode_1(m) = Ncode(m)
'            End If
'        End If
'    Next m
'    '   Me.Adodc5.Recordset.Close
'add_n:
'    Exit Sub 'MsgBox "生产记录出错", , ""
'End Sub

'Private Sub Timer11_Timer()
'    If Val(Hour(Time)) > 9 And bbbb_1 = False Then MsgBox "You must record the production record, open the production record direct point (record sorting)", 48, "Prompt action": bbbb = True
'    ggg = Val(Hour(Time))
'End Sub
'Private Sub Timer12_Timer()
'    Me.Label4.Caption = Trim(RID(12, 5))
'End Sub
'Private Sub Label4_Change()
'    Me.Timer13.Enabled = False
'    Me.Timer13.Enabled = True
'End Sub
'Private Sub Timer13_Timer()
'    Static otim As String
'    If otim <> RID(13, 4) Then otim = RID(13, 4) : Exit Sub
'    If Me.MSComm1.PortOpen = True Then Me.MSComm1.PortOpen = False
'    qsr0 = False
'    qsr1 = False
'    qsr2 = False
'    ss1 = ""
'    ss2 = ""
'    ss3 = ""
'    qbch = False
'    r(0) = "" : r(1) = ""
'    ssss = ""
'    For i = 0 To 3
'        bn(i) = False
'    Next
'    For i = 0 To 7
'        r(i) = ""
'    Next
'    r0q = False
'    xx = ""
'    strr1 = ""
'    i = q = 0
'    cher0 = ""
'    cher1 = ""
'    Form_Load()
'End Sub

'Private Sub Text5_Change()
'    Me.Timer13.Enabled = False
'    Me.Timer13.Enabled = True
'End Sub



'Private Sub Form_Load()
'    Dim rs1 As New Recordset
'    Call REGEDIT()
'    StatusBar1.Panels.Item(2) = Chr(9) & Chr(9) & "Current operator:" & Chr(9) & userID
'    Call T_in()

'    For i = 0 To 10
'        If i <> 4 Then MSFlexGrid1.ColAlignment(i) = 4 Else MSFlexGrid1.ColAlignment(i) = 1
'    Next
'    List1.Clear
'    sq1 = "select * from 监控画面"
'    rs1.Open sq1, conn, adOpenKeyset, adLockPessimistic
'  vv = rs1.RecordCount
'    Do While Not rs1.EOF
'        List1.AddItem rs1.Fields(1) ' & rs1.Fields(1)
'        rs1.MoveNext
'        'vv = vv + 1
'    Loop '
'    rs1.Close
'    MSFlexGrid1.RowHeight(0) = 400
'    Me.MSFlexGrid2.RowHeight(0) = 350
'    Me.MSFlexGrid2.RowHeight(0) = 350
'    List3.Clear
'    For i = 1 To vv
'        min.MSFlexGrid1.Col = 1
'        min.MSFlexGrid1.Row = i
'        min.MSFlexGrid1.CellBackColor = &H4488FF
'        min.MSFlexGrid1.Col = 2
'        min.MSFlexGrid1.Row = i
'        min.MSFlexGrid1.CellBackColor = &H44FF00
'        min.MSFlexGrid1.Col = 5
'        min.MSFlexGrid1.Row = i
'        min.MSFlexGrid1.CellBackColor = &HFFFF00
'        min.MSFlexGrid1.Col = 6
'        min.MSFlexGrid1.Row = i
'        min.MSFlexGrid1.CellBackColor = &HFF80FF
'        min.MSFlexGrid1.Col = 7
'        min.MSFlexGrid1.Row = i
'        min.MSFlexGrid1.CellBackColor = &H44FFFF
'        min.MSFlexGrid1.Col = 8
'        min.MSFlexGrid1.Row = i
'        min.MSFlexGrid1.CellBackColor = &H44FF88
'    Next

'    For i = 1 To vv
'        Me.MSFlexGrid1.RowHeight(i) = 300
'    Next
'    'Flash1.Movie = App.Path & "\mrkj.swf"
'    MSFlexGrid1.ColWidth(0) = GetSetting("zxdms", "settings", "colw0", "1")
'    MSFlexGrid1.ColWidth(1) = GetSetting("zxdms", "settings", "colw1", "1200")
'    MSFlexGrid1.ColWidth(2) = GetSetting("zxdms", "settings", "colw2", "2000")
'    MSFlexGrid1.ColWidth(3) = GetSetting("zxdms", "settings", "colw3", "1000")
'    MSFlexGrid1.ColWidth(4) = GetSetting("zxdms", "settings", "colw4", "2320")
'    MSFlexGrid1.ColWidth(5) = GetSetting("zxdms", "settings", "colw5", "1000")
'    MSFlexGrid1.ColWidth(6) = GetSetting("zxdms", "settings", "colw6", "830")
'    MSFlexGrid2.ColWidth(6) = 1830
'    MSFlexGrid1.ColWidth(7) = GetSetting("zxdms", "settings", "colw7", "1010")
'    MSFlexGrid1.ColWidth(8) = GetSetting("zxdms", "settings", "colw8", "1010")
'    MSFlexGrid1.ColWidth(9) = GetSetting("zxdms", "settings", "colw9", "1")
'    MSFlexGrid1.ColWidth(10) = GetSetting("zxdms", "settings", "colw10", "1")
'    MSFlexGrid1.TextMatrix(0, 1) = "Tank /N"
'    MSFlexGrid1.TextMatrix(0, 2) = "process"
'    MSFlexGrid1.TextMatrix(0, 3) = "crane "
'    'MSFlexGrid1.TextMatrix(0, 4) = "生产料号--(A飞靶)"
'    MSFlexGrid1.TextMatrix(0, 5) = "QTY"
'    MSFlexGrid1.TextMatrix(0, 6) = "Time"
'    MSFlexGrid1.TextMatrix(0, 7) = "A -A"
'    MSFlexGrid1.TextMatrix(0, 8) = "B- A"
'    For i = 1 To vv
'        MSFlexGrid1.Col = 3
'        MSFlexGrid1.Row = i
'        min.MSFlexGrid1.CellFontBold = False
'        min.MSFlexGrid1.CellFontSize = 16
'        min.MSFlexGrid1.CellForeColor = &HFF&
'    Next

'    For i = 1 To vv
'        MSFlexGrid1.TextMatrix(i, 1) = i
'    Next i
'    For i = 0 To vv - 1
'        MSFlexGrid1.TextMatrix(i + 1, 2) = List1.List(i)
'    Next

'    min.MSComm1.OutBufferSize = 1024
'    min.MSComm1.InBufferSize = 1024
'    If Not min.MSComm1.PortOpen Then
'        min.MSComm1.CommPort = intport
'        min.MSComm1.Settings = setting
'        min.MSComm1.PortOpen = True
'    End If
'    min.MSComm1.InputLen = 0
'    min.MSComm1.InputMode = comInputModeText
'    'min.MSComm1.RThreshold = 1
'    min.MSComm1.Output = "@00XZ42*" & o(0)
'    min.Text5 = "load complete"
'    min.Timer3.Enabled = True
'    min.Timer4.Enabled = True
'    min.Timer5.Enabled = True
'    min.Timer6.Enabled = True
'    Call lao_xin

'End Sub

'Public Sub REGEDIT()
'    intport = Val(GetSetting("zxdms", "settings", "port", "1"))
'    setting = GetSetting("zxdms", "settings", "setting", "9600,e,7,2")
'    serialno = GetSetting("zxdms", "settings", "SN", "5091")
'    SaveSetting "zxdms", "settings", "port", intport
' SaveSetting "zxdms", "settings", "setting", setting
' SaveSetting "zxdms", "settings", "SN", serialno
'End Sub