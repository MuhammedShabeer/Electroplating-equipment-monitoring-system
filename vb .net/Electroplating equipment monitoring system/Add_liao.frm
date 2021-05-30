VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Add_liao 
   BackColor       =   &H00C0FFC0&
   Caption         =   "PN/operate"
   ClientHeight    =   3615
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4530
   Icon            =   "Add_liao.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3615
   ScaleWidth      =   4530
   StartUpPosition =   3  '窗口缺省
   Visible         =   0   'False
   Begin MSFlexGridLib.MSFlexGrid MSFlexGrid1 
      Height          =   1815
      Left            =   0
      TabIndex        =   9
      ToolTipText     =   "双击隐藏查询记录"
      Top             =   1800
      Width           =   4575
      _ExtentX        =   8070
      _ExtentY        =   3201
      _Version        =   393216
      BackColorFixed  =   -2147483639
      ForeColorFixed  =   -2147483640
      ForeColorSel    =   -2147483643
      BackColorBkg    =   12648384
      GridColor       =   0
      GridColorFixed  =   14737632
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Inquire"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   580
      Left            =   3480
      Picture         =   "Add_liao.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   8
      ToolTipText     =   "点取可以查询料号库料号"
      Top             =   960
      Width           =   975
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Cancel"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   580
      Left            =   2520
      Picture         =   "Add_liao.frx":058D
      Style           =   1  'Graphical
      TabIndex        =   6
      TabStop         =   0   'False
      ToolTipText     =   "退出料号操作"
      Top             =   960
      Width           =   975
   End
   Begin VB.TextBox Text2 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Left            =   840
      TabIndex        =   4
      TabStop         =   0   'False
      Text            =   "Text2"
      ToolTipText     =   "输入投板数数"
      Top             =   1080
      Width           =   615
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   375
      Left            =   840
      TabIndex        =   3
      Text            =   "Text1"
      ToolTipText     =   "在此可以输入你要的料号"
      Top             =   480
      Width           =   3495
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Feed"
      DisabledPicture =   "Add_liao.frx":09AB
      DownPicture     =   "Add_liao.frx":0CB5
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   580
      Left            =   1560
      MaskColor       =   &H00E0E0E0&
      Picture         =   "Add_liao.frx":0FBF
      Style           =   1  'Graphical
      TabIndex        =   0
      TabStop         =   0   'False
      ToolTipText     =   "投入料号到PLC"
      Top             =   960
      Width           =   975
   End
   Begin VB.Timer Timer2 
      Enabled         =   0   'False
      Left            =   3120
      Top             =   1200
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   300
      Left            =   3720
      Top             =   1080
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   330
      Left            =   120
      Top             =   1800
      Width           =   1200
      _ExtentX        =   2117
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   1
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DMS数据库.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DMS数据库.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "select FROM 料号面积电流表"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "宋体"
         Size            =   9
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Line Line1 
      BorderColor     =   &H008080FF&
      BorderWidth     =   2
      X1              =   0
      X2              =   4560
      Y1              =   1680
      Y2              =   1680
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      BackColor       =   &H00C0FFC0&
      Caption         =   "AB"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   14.25
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   285
      Left            =   3840
      TabIndex        =   7
      Top             =   60
      Width           =   330
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00C0FFC0&
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   210
      Left            =   240
      TabIndex        =   5
      Top             =   120
      Width           =   120
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackColor       =   &H00C0FFC0&
      Caption         =   "Qty"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   12
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   1
      Left            =   120
      TabIndex        =   2
      Top             =   1125
      Width           =   360
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackColor       =   &H00C0FFC0&
      Caption         =   "PN："
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   12
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   240
      Index           =   0
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   480
   End
End
Attribute VB_Name = "Add_liao"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
Dim j As Integer
Dim d_umber_1 As Integer
d_umber_1 = 1
 If Val(Text2.Text) = 0 Then MsgBox "没有输入数量", 48, "提示": Text2.SetFocus: Exit Sub
 Dim sq1 As String
 Dim rs_inadd As New ADODB.Recordset
 sq1 = "select * from 料号面积电流表"
 rs_inadd.Open sq1, conn, adOpenKeyset, adLockPessimistic
 While (rs_inadd.EOF = False)
       If Trim(rs_inadd.Fields(0)) = Trim(Text1.Text) Then
          D_NAO(0) = rs_inadd.Fields(0)
          D_NAO(1) = rs_inadd.Fields(8)
          D_NAO(2) = rs_inadd.Fields(9)
          D_NAO(3) = rs_inadd.Fields(10)
          D_NAO(4) = rs_inadd.Fields(11)
          D_NAO(5) = rs_inadd.Fields(6)
          D_NAO(6) = rs_inadd.Fields(12)
          D_NAO(7) = rs_inadd.Fields(13)
          D_NAO(8) = rs_inadd.Fields(14)
          D_NAO(9) = rs_inadd.Fields(15)
          D_NAO(10) = rs_inadd.Fields(7)
          If Val(D_NAO(1)) * Val(Me.Text2) > 500 Then MsgBox "锡槽输入电流超过了500A", 48, "提示": Exit Sub
          If Val(D_NAO(2)) * Val(Me.Text2) > 500 Then MsgBox "锡槽输入电流超过了500A", 48, "提示": Exit Sub
          If Val(D_NAO(6)) * Val(Me.Text2) > 650 Then MsgBox "铜槽输入电流超过了650A", 48, "提示": Exit Sub
          If Val(D_NAO(7)) * Val(Me.Text2) > 650 Then MsgBox "铜槽输入电流超过了650A", 48, "提示": Exit Sub
          For j = 1 To min.MSFlexGrid2.Rows - 1
          If D_NAO(0) = min.MSFlexGrid2.TextMatrix(j, 0) Then
            d_umber_1 = min.MSFlexGrid2.TextMatrix(j, 11)
            GoTo D_UMBEROUT:
            Else
            'J = J + 1
          End If
          Next j
           For i = 1 To min.MSFlexGrid2.Rows
            If d_umber_1 = Val(min.MSFlexGrid2.TextMatrix(i - 1, 11)) Then
               d_umber_1 = d_umber_1 + 1
               If d_umber_1 > 18 Then MsgBox "正在使用料号过多", 46, "提示": Exit Sub
               i = 1
             End If
            Next i
            GoTo D_UMBEROUT:
         Else
         rs_inadd.MoveNext
        End If
    Wend
    If rs_inadd.EOF = True Then MsgBox "没有此料号您必须先编辑才能使用！", 48, "提示": Exit Sub
D_UMBEROUT:
          D_NAO(11) = d_umber_1
          Call in_lao_1
          Exit Sub
 
 'min.Adodc2.Refresh
End Sub

Private Sub in_lao_1()
 min.Adodc2.Refresh
 If min.Adodc2.Recordset.RecordCount > 18 Then
 MsgBox "使用料号过多，请删除再用", 46, "提示"
 Else
 On Error GoTo liao_err
 While (min.Adodc2.Recordset.EOF = False)
If Trim(min.Adodc2.Recordset.Fields(0)) = Trim(D_NAO(0)) Then
 For i = 0 To 11
 min.Adodc2.Recordset.Fields(i) = D_NAO(i)
 Next
 min.Adodc2.Recordset.Update
 Call lao_xin
 Call input_o1
 Call D_liao_in
 MsgBox "料号投入成功！", 48, "提示"
 'Unload Me
 Exit Sub
Else
 min.Adodc2.Recordset.MoveNext
 End If
Wend
If min.Adodc2.Recordset.EOF = True Then
   min.Adodc2.Recordset.AddNew
   For i = 0 To 11
    min.Adodc2.Recordset.Fields(i) = D_NAO(i)
   Next i
    min.Adodc2.Recordset.Update
    Call lao_xin
    Call input_o1
    Call D_liao_in
    MsgBox "料号投入成功！", 48, "提示"
End If
'Unload Me
liao_err:  Exit Sub
End If
End Sub

Private Sub Command2_Click()
 Dim c_add01 As Integer
  MSFlexGrid1.ColWidth(0) = 2100
  MSFlexGrid1.ColWidth(1) = 2000
  MSFlexGrid1.ColAlignment(0) = 1
  MSFlexGrid1.ColAlignment(1) = 1
  Me.MSFlexGrid1.TextMatrix(0, 0) = "创建日期"
  Me.MSFlexGrid1.TextMatrix(0, 1) = "生产料号"
  Me.Height = 4020
 If Text1.Text = Chr(9) Then
 Me.Adodc1.RecordSource = "select * from 料号面积电流表 "
  Me.Adodc1.Refresh
  If Me.Adodc1.Recordset.RecordCount > 0 Then
  MSFlexGrid1.Rows = Me.Adodc1.Recordset.RecordCount + 1
  MSFlexGrid1.Cols = 2
  c_add01 = MSFlexGrid1.Rows - 1
  Me.Adodc1.Recordset.MoveFirst
 If (Not Me.Adodc1.Recordset.EOF) Then
  For i = 1 To c_add01
  MSFlexGrid1.TextMatrix(i, 0) = Me.Adodc1.Recordset.Fields(16)
  MSFlexGrid1.TextMatrix(i, 1) = Me.Adodc1.Recordset.Fields(0)
  Me.Adodc1.Recordset.MoveNext
   Next
  End If
  End If
 Else
 Me.Adodc1.RecordSource = "select * from 料号面积电流表 where 料号名称 Like '" + Trim(Text1.Text) + "%'"
 Me.Adodc1.Refresh
 If Me.Adodc1.Recordset.RecordCount > 0 Then
 MSFlexGrid1.Rows = Me.Adodc1.Recordset.RecordCount + 1
  MSFlexGrid1.Cols = 2
  c_add01 = MSFlexGrid1.Rows - 1
  Me.Adodc1.Recordset.MoveFirst
 If (Not Me.Adodc1.Recordset.EOF) Then
  For i = 1 To c_add01
  MSFlexGrid1.TextMatrix(i, 0) = Me.Adodc1.Recordset.Fields(16)
  MSFlexGrid1.TextMatrix(i, 1) = Me.Adodc1.Recordset.Fields(0)
  Me.Adodc1.Recordset.MoveNext
  Next
  End If
  End If
  End If
  Me.Adodc1.Recordset.Close
End Sub

Private Sub Command3_Click()
 Unload Me
End Sub

Private Sub Form_Load()
 Me.Height = 2010
Text1.Text = Chr(9)
Text2.Text = Chr(9)
n = 0
'Text1.SetFocus
Call AfroB 'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\dy\NEW DMS\DMS数据库.mdb;Persist Security Info=False
SetWindowPos Me.hwnd, -1, 0, 0, 0, 0, 3
End Sub
Private Sub Form_Unload(Cancel As Integer)
For i = 0 To 5
  min.Label2(i).BackColor = &H80000009
Next
'Me.Adodc1.Recordset.Close
End Sub

Private Sub MSFlexGrid1_Click()
  Text1.Text = Trim(Me.MSFlexGrid1.TextMatrix(Me.MSFlexGrid1.RowSel, 1))
End Sub

Private Sub MSFlexGrid1_DblClick()
Me.Height = 2010
End Sub

Private Sub Text1_Change()
 Dim c_add01 As Integer
  MSFlexGrid1.ColWidth(0) = 2100
  MSFlexGrid1.ColWidth(1) = 2000
  MSFlexGrid1.ColAlignment(0) = 1
  MSFlexGrid1.ColAlignment(1) = 1
  Me.MSFlexGrid1.TextMatrix(0, 0) = "创建日期"
  Me.MSFlexGrid1.TextMatrix(0, 1) = "生产料号"
  Me.Height = 4020
 Me.Adodc1.RecordSource = "select * from 料号面积电流表 where 料号名称 Like '" + Trim(Text1.Text) + "%'"
 Me.Adodc1.Refresh
 If Me.Adodc1.Recordset.RecordCount > 0 Then
 MSFlexGrid1.Rows = Me.Adodc1.Recordset.RecordCount + 1
  MSFlexGrid1.Cols = 2
  c_add01 = MSFlexGrid1.Rows - 1
  Me.Adodc1.Recordset.MoveFirst
 If (Not Me.Adodc1.Recordset.EOF) Then
  For i = 1 To c_add01
  MSFlexGrid1.TextMatrix(i, 0) = Me.Adodc1.Recordset.Fields(16)
  MSFlexGrid1.TextMatrix(i, 1) = Me.Adodc1.Recordset.Fields(0)
  Me.Adodc1.Recordset.MoveNext
  Next
  End If
  End If
  Me.Adodc1.Recordset.Close
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
  If KeyAscii = 13 Then
    Text2.SetFocus
  End If
End Sub

Private Sub Text2_GotFocus()
 Text2.SelStart = 0
 Text2.SelLength = Len(Text2.Text)
End Sub


Private Sub Text1_GotFocus()
 Text1.SelStart = 0
 Text1.SelLength = Len(Text1.Text)
End Sub

Private Sub Text1_LostFocus()
If Text1.Text = "" Then
    Text1.Text = Chr(9)
     MsgBox "料号没有输入！", 48, "提示"
     Text1.SetFocus
     Exit Sub
ElseIf Len(Text1.Text) > 16 Then
  MsgBox "您输入的料号过长超出范围！", 48, "提示"
  Text1.SetFocus
  Exit Sub
 End If
End Sub

Private Sub Text2_KeyPress(KeyAscii As Integer)
  If KeyAscii = 13 Then
    Command1_Click
  End If
End Sub

Private Sub Text2_LostFocus()
 Dim a As Integer
 If Trim(Text2.Text) = "" Then
     Text2.Text = "0"
     MsgBox "请输入数量！", 48, "提示"
      Text2.SetFocus
      Exit Sub
 ElseIf Len(Text2.Text) > 2 Then
      MsgBox "你输入的片数过多最多只能输入40片！", 48, "提示"
      Text2.SetFocus
      Exit Sub
 ElseIf Val(Text2.Text) > 40 Then
    MsgBox "你输入的片数过多最多只能输入40片！", 48, "提示"
    Text2.SetFocus
 Else
 If Asc(Left(Text2.Text, 1)) < 46 Or Asc(Left(Text2.Text, 1)) > 57 Or Asc(Left(Text2.Text, 1)) = 47 Then MsgBox "输入有误，非法字符！", 48, "提示": Text2.SetFocus: Exit Sub
 If Asc(Right(Text2.Text, 1)) < 46 Or Asc(Right(Text2.Text, 1)) > 57 Then MsgBox "输入有误，必须是数值！", 48, "提示": Text2.SetFocus: Exit Sub
 If Asc(Right(Text2.Text, 1)) = 46 Or Asc(Right(Text2.Text, 1)) = 46 Then MsgBox "输入有误，不能为小数！", 48, "提示": Text2.SetFocus: Exit Sub
 If Len(Text2.Text) = 1 Then Text2.Text = 0 & Trim(Text2.Text)
 End If
End Sub

Private Sub Timer1_Timer()
  Label2.Caption = "您现在选取要更改的槽是第" & "(" & MA & ")" & "槽"
  'Text1.Text = min.MSFlexGrid1.TextMatrix(MA, 4)
  'Text2.Text = min.MSFlexGrid1.TextMatrix(MA, 5)
  Timer1.Enabled = False
  Timer2.Enabled = True
  If Len(Text2.Text) = 1 Then Text2.Text = 0 & Trim(Text2.Text)
  If Text1.Text = "" Then Text1.Text = Chr(9)
End Sub

Private Sub Timer2_Timer()
On Error GoTo F_ERROR
  Text1.SetFocus
  Timer2.Enabled = False
F_ERROR:
 Exit Sub
End Sub

Sub D_liao_in()
  Dim TSTR As String
  Dim D_C As Variant
  Open (App.Path & "\style\投料.ini") For Input As #3
    Do While Not EOF(3)
      Line Input #3, INTEXT
      TSTR = TSTR + INTEXT + Chr(13) + Chr(10)
    Loop
  Close #3
  D_C = MA & "号槽" & Label3.Caption & " 投入料号是:" & Text1.Text & Chr(9) & Val(Text2.Text) & Chr(9) & Chr(9) & Format(Now, "yyyy-mm-dd hh:mm:ss") + Chr(13) + Chr(10)
  TSTR = TSTR + D_C
  If Len(TSTR) > 15000 Then TSTR = Right(TSTR, 14900)
    Open (App.Path & "\style\投料.ini") For Output As #3
    Print #3, TSTR
  Close #3
End Sub
Sub D_LIAO_IN1()
Dim D_C As Variant
Open (App.Path & "\style\投料.ini") For Input As #3
  Do While Not EOF(3)
    Line Input #3, INTEXT
    TSTR = TSTR + INTEXT + Chr(13) + Chr(10)
  Loop
Close #3
D_C = MA & "号槽" & Label3.Caption & " 删除料号是:" & Text1.Text & Chr(9) & Val(Text2.Text) & Chr(9) & Chr(9) & Format(Now, "yyyy-mm-dd hh:mm:ss") + Chr(13) + Chr(10)
TSTR = TSTR + D_C
Open (App.Path & "\style\投料.ini") For Output As #3
  Print #3, TSTR
Close #3
End Sub

