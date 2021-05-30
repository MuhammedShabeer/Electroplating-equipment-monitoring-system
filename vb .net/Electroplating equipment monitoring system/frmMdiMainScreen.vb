Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports DL
Public Class frmMdiMainScreen

    Private Sub OpearterRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpearterRecordsToolStripMenuItem.Click
        Try
            frmOperatorRecord.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMdiMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim frmManagmentSystem As New frmManagmentSystem
            frmManagmentSystem.WindowState = FormWindowState.Maximized
            CreateChildForms(frmManagmentSystem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmMdiMainScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Dim Path As String = DirectoryForLogFile("SystemLoginRecord.txt")
            If File.Exists(Path) Then
                Using Writer As New StreamWriter(Path, True)
                    Writer.WriteLine(LoginUserDetails.LoginUserName & "   " & DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt"))
                End Using
            End If
            frmLogin.Close()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub PNUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNUpdateToolStripMenuItem.Click
        Try
            frmPNEdit.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PNOperationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNOperationToolStripMenuItem.Click
        Try

        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsmPnClean_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManagmentSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagmentSystemToolStripMenuItem.Click
        Try
            Dim frmManagmentSystem As New frmManagmentSystem
            frmManagmentSystem.WindowState = FormWindowState.Maximized
            CreateChildForms(frmManagmentSystem)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CreateChildForms(ByRef child As Form)
        Try
            Dim frmCollection = Application.OpenForms
            For i As Int16 = 0I To frmCollection.Count - 1I
                If frmCollection.Item(i).Name = child.Name Then
                    frmCollection.Item(i).Activate()
                    Exit Sub
                End If
            Next i
            With child
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
