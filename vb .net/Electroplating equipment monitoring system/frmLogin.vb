Imports DL
Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnSelectReg.Enabled = False
            Select_Click(btnSelectLogin, New EventArgs)
            btnSelectLogin.Select()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If String.IsNullOrWhiteSpace(txtUserName.Text.Trim) Then
                MsgBox("Enter username")
                Exit Sub
            ElseIf String.IsNullOrWhiteSpace(txtPassWord.Text.Trim) Then
                MsgBox("Enter password")
                Exit Sub
            End If
            Dim dt As DataTable = modDataLayer.GETDATATABLE("SELECT 1 FROM useradmin.tbl_user_mst Where chvUsername = '" & txtUserName.Text.Trim & "' and chvPassword = '" & txtPassWord.Text.Trim & "';")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                LoginUserDetails.LoginUserName = txtUserName.Text.Trim
                MsgBox("Login successfully")
                frmMdiMainScreen.Show()
                Me.Hide()
            Else
                MsgBox("incorrect username or password")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkLoginShowPass.CheckedChanged, chkUserShowPassWord.CheckedChanged, chkShowPassChangePass.CheckedChanged
        Try
            If Not chkLoginShowPass.Checked Then txtPassWord.PasswordChar = "*" Else txtPassWord.PasswordChar = ""
            If Not chkUserShowPassWord.Checked Then
                txtAddUserRePass.PasswordChar = "*"
                txtAddUserPass.PasswordChar = "*"
            Else
                txtAddUserRePass.PasswordChar = ""
                txtAddUserPass.PasswordChar = ""
            End If
            If Not chkShowPassChangePass.Checked Then
                txtChangeRePass.PasswordChar = "*"
                txtChangeOldPass.PasswordChar = "*"
                txtChangeNewPass.PasswordChar = "*"
            Else
                txtChangeRePass.PasswordChar = ""
                txtChangeOldPass.PasswordChar = ""
                txtChangeNewPass.PasswordChar = ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Select_Click(sender As Object, e As EventArgs) Handles btnSelectReg.Click, btnSelectLogin.Click, btnSelectForgot.Click
        Try
            If sender.name = "btnSelectLogin" Then
                btnSelectLogin.BackgroundImage = My.Resources.Login_user_got_Focous
                TabControl1.SelectedIndex = 0
            ElseIf sender.name = "btnSelectReg" Then
                btnSelectReg.BackgroundImage = My.Resources.user_add__Got_Focous
                TabControl1.SelectedIndex = 1
            ElseIf sender.name = "btnSelectForgot" Then
                btnSelectForgot.BackgroundImage = My.Resources.Forgot_got_Focous
                TabControl1.SelectedIndex = 2
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            If sender.SelectedIndex = 0 Then
                btnSelectLogin.BackgroundImage = My.Resources.Login_user_got_Focous
            Else
                btnSelectLogin.BackgroundImage = My.Resources.Login_user_Lost_Focous
            End If
            If sender.SelectedIndex = 1 Then
                btnSelectReg.BackgroundImage = My.Resources.user_add__Got_Focous
            Else
                btnSelectReg.BackgroundImage = My.Resources.user_add__Lost_Focous
            End If
            If sender.SelectedIndex = 2 Then
                btnSelectForgot.BackgroundImage = My.Resources.Forgot_got_Focous
            Else
                btnSelectForgot.BackgroundImage = My.Resources.Forgot_Lost_Focous
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            frmSplashScreen.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class