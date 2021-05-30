Imports System.IO

Public Class frmOperatorRecord
    Private Sub frmOperatorRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Tag = ""
    End Sub

    Private Sub Record_Click(sender As Object, e As EventArgs) Handles btnSystemLoginRecord.Click, btnOperatorItemRecord.Click, btnItemEditRecord.Click, btnfeedingRecord.Click
        Try
            Dim StrPath As String = ""
            RichTextBox1.Text = ""
            Select Case sender.name
                Case "btnSystemLoginRecord"
                    StrPath = Application.StartupPath & "\logFiles\SystemLoginRecord.txt"
                Case "btnOperatorItemRecord"
                    StrPath = Application.StartupPath & "\OperatorItemRecord.txt"
                Case "btnItemEditRecord"
                    StrPath = Application.StartupPath & "\logFiles\PN Log.txt"
                Case "btnfeedingRecord"
                    StrPath = Application.StartupPath & "\logFiles\feedingRecord.txt"
            End Select
            ReadFile(StrPath)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ReadFile(ByVal strPath As String)
        Try
            btnDelete.Tag = ""
            If File.Exists(strPath) Then
                Using read As IO.StreamReader = IO.File.OpenText(strPath)
                    RichTextBox1.Text = read.ReadToEnd()
                    read.Close()
                End Using
                btnDelete.Tag = strPath
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If File.Exists(btnDelete.Tag) Then
                Using Writer As New StreamWriter(btnDelete.Tag, False)
                    Writer.Write("")
                End Using
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class