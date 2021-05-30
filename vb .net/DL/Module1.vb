Module Module1
    '    Option Explicit On
    '    'ÉùÃ÷Ò»¸öAPIº¯Êý£¬ÓÃÓÚÊµÏÖÊ¹´°ÌåÖÃÇ°»¹ÊÇÈ¡Ïû´°ÌåÖÃÇ°µÄ¹¦ÄÜ
    '    Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
    '    Public fso As FileSystemObject, fil As File, fild As TextStream
    '    Public rtn
    '    Public conn As New ADODB.Connection
    '    Public cat As New ADODB.Connection
    '    Public userID As String
    '    Public userpow As String
    '    Public userpass As String
    '    Public TIN_01 As Boolean
    '    Public TIN_02 As Boolean
    '    Public TIN_03 As Boolean
    '    Public a_instr As Variant
    '    Public m_t As Variant
    '    Public m_l As Variant
    '    Public MA As Integer
    '    Public MB As Integer
    '    Public vv As Integer
    '    Public r(7) As String
    '    Public o(9) As String
    '    Public intport As Integer
    '    Public setting As String
    '    Public serialno As Integer
    '    Public ss1 As String
    '    Public ss2 As String
    '    Public ss3 As String
    '    Public ssss As String
    '    Public errec As String
    '    Public qbch As Boolean
    '    Public bn(3) As Boolean
    '    Public bnn(3) As Boolean
    '    Public r0q As Boolean
    '    Public qsr0 As Boolean
    '    Public qsr1 As Boolean
    '    Public qsr2 As Boolean
    '    Public RID(28, 9) As String
    '    Public Ntim_1(69) As String
    '    Public Ncode_1(120) As String
    '    Public Ncode(150) As String
    '    Public NAm_1(73) As String
    '    Public Nfb_1(30) As String
    '    Public NAm(73) As String
    '    Public Nfb(30) As String
    '    Public Ntim(69) As String
    '    Public D_NAO(11) As String
    '    Public a(10) As String
    '    Public estr As String
    '    Public dr As Variant
    '    Public Input_dr As String
    '    Public Input_a As String
    '    Public Input_b As String
    '    Public pindex As Integer
    '    Public d_umber As Variant
    '    Public hn As String
    '    Public add_n(9) As String
    '    Public Data_1 As String
    '    Public look_b As Boolean
    '    Public like_time As String
    '    Public bbbb As Boolean
    '    Public bbbb_1 As Boolean

    '    Public Curmonth As String
    '    Public Curday As String
    '    Public Q_User As String

    '    Sub Main()
    '        Dim connectionstring As String
    '        If App.PrevInstance Then
    '            MsgBox "²»³äÐíÖØ¸´ÔËÐÐ£¡" &
    '          vbCrLf & "³ÌÊ½¼´½«¹Ø±Õ£¡"
    '   End
    '        End If
    '        connectionstring = "provider=Microsoft.Jet.oledb.4.0;" &
    '                   "data source=DMSÊý¾Ý¿â.mdb"
    '        conn.Open connectionstring
    'intport = Val(GetSetting("zxdms", "settings", "port", "1"))
    '        setting = GetSetting("zxdms", "settings", "setting", "9600,e,7,2")
    '        Curmonth = Format(Month(Now), "00")
    '        Curday = Format(Day(Now), "00")
    '        welcome.Show
    '    End Sub

    '    Public Sub B_Check()
    '        Dim xx As String
    '        Dim strr1 As String
    '        Dim i, q As Integer
    '        Dim cher0 As String
    '        Dim cher1 As String
    '        xx = Right(ss3, 4)
    '        If Mid(xx, 3, 1) = "*" Then
    '            strr1 = Left(ss3, Len(ss3) - 4)
    '            cher0 = Left(xx, 2)
    '        Else
    '            strr1 = Left(ss3, Len(ss3) - 3)
    '            cher0 = Mid(xx, 2, 2)
    '        End If
    '        For i = 1 To Len(strr1)
    '            q = Asc(Mid(strr1, i, 1)) Xor q
    '        Next i
    '        cher1 = Hex(q)
    '        If Len(cher1) < 2 Then cher1 = "0" + cher1
    '        If cher1 <> cher0 Then
    '            qbch = True
    '            'qsr0 = False
    '        End If
    '    End Sub
    '    Public Sub S_Check()
    '        Dim i, q As Integer
    '        Dim cher1 As String
    '        If o(2) <> "" And Not qsr0 Then
    '            q = 0
    '            For i = 1 To Len(o(2))
    '                q = Asc(Mid(o(2), i, 1)) Xor q
    '            Next i
    '            cher1 = Hex(q)
    '            If Len(cher1) < 2 Then cher1 = "0" + cher1
    '            o(2) = o(2) + cher1 + "*" + o(0)
    '        ElseIf Not qsr0 Then
    '            For i = 1 To Len(o(1))
    '                q = Asc(Mid(o(1), i, 1)) Xor q
    '            Next i
    '            cher1 = Hex(q)
    '            If Len(cher1) < 2 Then cher1 = "0" + cher1
    '            o(1) = o(1) + cher1 + "*" + o(0)
    '        End If
    '    End Sub
    '    Public Sub Ms_Do()
    '        Dim mt As Integer
    '        Dim ddd, dds As String
    '        Dim tt, k As Integer
    '        r(0) = "" : r(1) = ""
    '        If ss1 <> "" Then
    '            Do
    '                mt = InStr(ss1, Chr(13))
    '                If mt = 0 Then mt = InStr(ss1, "*")
    '                ss3 = Left(ss1, mt)
    '                tt = Len(ss1)
    '                ss1 = Right(ss1, tt - mt)
    '                Call B_Check()
    '                If qbch = True Then ss1 = "" : Exit Sub
    '                ss3 = Left(ss3, Len(ss3) - 3)
    '                'ddd = o(1): dds = o(2)
    '                If qsr0 Then
    '                    r(0) = r(0) + ss3
    '                ElseIf qsr1 Then
    '                    r(1) = r(1) + ss3
    '                End If
    '            Loop While ss1 <> ""
    '            Call assay()
    '        End If
    '    End Sub

    '    Public Sub assay()
    '        Dim i, k As Integer
    '        i = 0 : k = 0
    '        If qsr0 And r(0) <> "" Then
    '            Min.Text5.Text = ""
    '            r(2) = Mid(r(0), 8, Len(r(0)) - 8)
    '            Do
    '                RID(i, k) = Left(r(2), 4)
    '                If Len(r(2)) > 3 Then r(2) = Right(r(2), Len(r(2)) - 4) Else r(2) = ""
    '                Min.Text5.Text = Min.Text5.Text + RID(i, k) + "  "
    '                k = k + 1
    '                If k > 9 Then k = 0 : i = i + 1
    '            Loop While r(2) <> ""
    '            r0q = True : r(0) = ""
    '        ElseIf qsr1 Then
    '            If Left(r(1), 3) = "@00" And Mid(r(1), 6, 2) = "00" Then o(2) = "" : qsr1 = False
    '        End If
    '    End Sub

    '    Public Sub AfroB()
    '        Dim i As Integer
    '        If TIN_01 = True Then
    '            Min.MSFlexGrid1.Col = 4
    '            For i = 1 To 22
    '                Min.MSFlexGrid1.Row = i
    '                If i < 9 Or i > 12 Then
    '                    Min.MSFlexGrid1.CellBackColor = &H80FFFF
    '                    Min.MSFlexGrid1.TextMatrix(0, 4) = "Item--(B)"
    '                    Add_liao.Label3.Caption = "B side"
    '                End If
    '            Next
    '        Else
    '            For i = 1 To vv
    '                Min.MSFlexGrid1.Row = i
    '                Min.MSFlexGrid1.CellBackColor = &HFFFFFF
    '                Min.MSFlexGrid1.TextMatrix(0, 4) = "Item--(A)"
    '                Add_liao.Label3.Caption = "A side"
    '            Next i
    '        End If
    '    End Sub
    '    Public Sub d_lock()
    '        JI_LOCK.DataGrid1.Columns(0).Width = 0
    '        JI_LOCK.DataGrid1.Columns(1).Width = 500
    '        JI_LOCK.DataGrid1.Columns(2).Width = 1800
    '        JI_LOCK.DataGrid1.Columns(3).Width = 500
    '        JI_LOCK.DataGrid1.Columns(4).Width = 700
    '        JI_LOCK.DataGrid1.Columns(5).Width = 700
    '        JI_LOCK.DataGrid1.Columns(6).Width = 800
    '        JI_LOCK.DataGrid1.Columns(7).Width = 2000
    '        JI_LOCK.DataGrid1.Columns(8).Width = 2000
    '        JI_LOCK.DataGrid1.Columns(9).Width = 800
    '    End Sub
    '    Public Sub year_date_time()
    '        Dim cat_now As Object
    '        If Val(Month(Now)) = 1 And Val(Day(Now)) = 1 Then
    '            Data_1 = Val(Year(Now)) - 1 & "Äê" & 12 & "ÔÂ" & 31 & "ÈÕ"
    '        Else
    '            If Val(Day(Now)) = 1 Then
    '                If Val(Month(Now)) = 5 Or Val(Month(Now)) = 7 Or Val(Month(Now)) = 10 Or Val(Month(Now)) = 12 Then
    '                    Data_1 = Year(Now) & "Äê" & Val(Month(Now)) - 1 & "ÔÂ" & 30 & "ÈÕ"
    '                Else
    '                    If Val(Month(Now)) = 2 Or Val(Month(Now)) = 4 Or Val(Month(Now)) = 6 Or Val(Month(Now)) = 8 Or Val(Month(Now)) = 9 Or Val(Month(Now)) = 11 Then
    '                        Data_1 = Year(Now) & "Äê" & Val(Month(Now)) - 1 & "ÔÂ" & 31 & "ÈÕ"
    '                    Else
    '                        If Val(Month(Now)) = 3 Then
    '                            cat_now = Val(Year(Now)) / 4
    '                            If Right(Format(cat_now, "0000.0"), 1) <> 0 Then
    '                                Data_1 = Year(Now) & "Äê" & Val(Month(Now)) - 1 & "ÔÂ" & 28 & "ÈÕ"
    '                            Else
    '                                Data_1 = Year(Now) & "Äê" & Val(Month(Now)) - 1 & "ÔÂ" & 29 & "ÈÕ"
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            Else
    '                Data_1 = Year(Now) & "Äê" & Month(Now) & "ÔÂ" & Val(Day(Now)) - 1 & "ÈÕ"
    '            End If
    '        End If
    '    End Sub




End Module
