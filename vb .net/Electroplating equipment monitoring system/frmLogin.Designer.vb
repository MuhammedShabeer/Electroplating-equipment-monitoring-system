<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlMAin = New System.Windows.Forms.Panel()
        Me.btnSelectForgot = New System.Windows.Forms.Button()
        Me.btnSelectReg = New System.Windows.Forms.Button()
        Me.btnSelectLogin = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbReset = New System.Windows.Forms.TabPage()
        Me.PnlLogin = New System.Windows.Forms.Panel()
        Me.chkLoginShowPass = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassWord = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAdd = New System.Windows.Forms.TabPage()
        Me.pnlAddUser = New System.Windows.Forms.Panel()
        Me.chkUserShowPassWord = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.txtadduserNAme = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddUserRePass = New System.Windows.Forms.TextBox()
        Me.txtAddUserPass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbLogin = New System.Windows.Forms.TabPage()
        Me.pnlForgotPass = New System.Windows.Forms.Panel()
        Me.chkShowPassChangePass = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtChangeRePass = New System.Windows.Forms.TextBox()
        Me.txtChangeNewPass = New System.Windows.Forms.TextBox()
        Me.txtChangeOldPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlMAin.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbReset.SuspendLayout()
        Me.PnlLogin.SuspendLayout()
        Me.tbAdd.SuspendLayout()
        Me.pnlAddUser.SuspendLayout()
        Me.tbLogin.SuspendLayout()
        Me.pnlForgotPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMAin
        '
        Me.pnlMAin.BackColor = System.Drawing.Color.White
        Me.pnlMAin.Controls.Add(Me.btnSelectForgot)
        Me.pnlMAin.Controls.Add(Me.btnSelectReg)
        Me.pnlMAin.Controls.Add(Me.btnSelectLogin)
        Me.pnlMAin.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMAin.Location = New System.Drawing.Point(0, 0)
        Me.pnlMAin.Name = "pnlMAin"
        Me.pnlMAin.Size = New System.Drawing.Size(213, 300)
        Me.pnlMAin.TabIndex = 3
        '
        'btnSelectForgot
        '
        Me.btnSelectForgot.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnSelectForgot.BackgroundImage = CType(resources.GetObject("btnSelectForgot.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectForgot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectForgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectForgot.Location = New System.Drawing.Point(0, 200)
        Me.btnSelectForgot.Name = "btnSelectForgot"
        Me.btnSelectForgot.Size = New System.Drawing.Size(213, 99)
        Me.btnSelectForgot.TabIndex = 0
        Me.btnSelectForgot.Text = "Button1"
        Me.btnSelectForgot.UseVisualStyleBackColor = False
        '
        'btnSelectReg
        '
        Me.btnSelectReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnSelectReg.BackgroundImage = CType(resources.GetObject("btnSelectReg.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectReg.Location = New System.Drawing.Point(0, 100)
        Me.btnSelectReg.Name = "btnSelectReg"
        Me.btnSelectReg.Size = New System.Drawing.Size(213, 99)
        Me.btnSelectReg.TabIndex = 0
        Me.btnSelectReg.UseVisualStyleBackColor = False
        '
        'btnSelectLogin
        '
        Me.btnSelectLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btnSelectLogin.BackgroundImage = CType(resources.GetObject("btnSelectLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSelectLogin.Location = New System.Drawing.Point(0, 0)
        Me.btnSelectLogin.Name = "btnSelectLogin"
        Me.btnSelectLogin.Size = New System.Drawing.Size(213, 99)
        Me.btnSelectLogin.TabIndex = 0
        Me.btnSelectLogin.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbReset)
        Me.TabControl1.Controls.Add(Me.tbAdd)
        Me.TabControl1.Controls.Add(Me.tbLogin)
        Me.TabControl1.Location = New System.Drawing.Point(213, -20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(409, 320)
        Me.TabControl1.TabIndex = 5
        '
        'tbReset
        '
        Me.tbReset.Controls.Add(Me.PnlLogin)
        Me.tbReset.Location = New System.Drawing.Point(4, 22)
        Me.tbReset.Margin = New System.Windows.Forms.Padding(0)
        Me.tbReset.Name = "tbReset"
        Me.tbReset.Size = New System.Drawing.Size(401, 294)
        Me.tbReset.TabIndex = 1
        Me.tbReset.UseVisualStyleBackColor = True
        '
        'PnlLogin
        '
        Me.PnlLogin.BackColor = System.Drawing.Color.White
        Me.PnlLogin.BackgroundImage = Global.Electroplating_equipment_monitoring_system.My.Resources.Resources.Mesa_de_trabajo_1
        Me.PnlLogin.Controls.Add(Me.chkLoginShowPass)
        Me.PnlLogin.Controls.Add(Me.Label3)
        Me.PnlLogin.Controls.Add(Me.btnLogin)
        Me.PnlLogin.Controls.Add(Me.txtUserName)
        Me.PnlLogin.Controls.Add(Me.Label2)
        Me.PnlLogin.Controls.Add(Me.txtPassWord)
        Me.PnlLogin.Controls.Add(Me.Label1)
        Me.PnlLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.PnlLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlLogin.Name = "PnlLogin"
        Me.PnlLogin.Size = New System.Drawing.Size(401, 294)
        Me.PnlLogin.TabIndex = 4
        '
        'chkLoginShowPass
        '
        Me.chkLoginShowPass.AutoSize = True
        Me.chkLoginShowPass.Location = New System.Drawing.Point(241, 134)
        Me.chkLoginShowPass.Name = "chkLoginShowPass"
        Me.chkLoginShowPass.Size = New System.Drawing.Size(101, 17)
        Me.chkLoginShowPass.TabIndex = 5
        Me.chkLoginShowPass.Text = "Show password"
        Me.chkLoginShowPass.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Login Here"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(55, 190)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(291, 33)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(55, 101)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(291, 20)
        Me.txtUserName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(55, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(55, 155)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassWord.Size = New System.Drawing.Size(291, 20)
        Me.txtPassWord.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(55, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UserName"
        '
        'tbAdd
        '
        Me.tbAdd.Controls.Add(Me.pnlAddUser)
        Me.tbAdd.Location = New System.Drawing.Point(4, 22)
        Me.tbAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.tbAdd.Name = "tbAdd"
        Me.tbAdd.Size = New System.Drawing.Size(401, 294)
        Me.tbAdd.TabIndex = 2
        Me.tbAdd.UseVisualStyleBackColor = True
        '
        'pnlAddUser
        '
        Me.pnlAddUser.BackColor = System.Drawing.Color.White
        Me.pnlAddUser.BackgroundImage = Global.Electroplating_equipment_monitoring_system.My.Resources.Resources.Mesa_de_trabajo_1
        Me.pnlAddUser.Controls.Add(Me.chkUserShowPassWord)
        Me.pnlAddUser.Controls.Add(Me.Label8)
        Me.pnlAddUser.Controls.Add(Me.btnAddUser)
        Me.pnlAddUser.Controls.Add(Me.txtadduserNAme)
        Me.pnlAddUser.Controls.Add(Me.Label9)
        Me.pnlAddUser.Controls.Add(Me.Label10)
        Me.pnlAddUser.Controls.Add(Me.txtAddUserRePass)
        Me.pnlAddUser.Controls.Add(Me.txtAddUserPass)
        Me.pnlAddUser.Controls.Add(Me.Label11)
        Me.pnlAddUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddUser.Location = New System.Drawing.Point(0, 0)
        Me.pnlAddUser.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlAddUser.Name = "pnlAddUser"
        Me.pnlAddUser.Size = New System.Drawing.Size(401, 294)
        Me.pnlAddUser.TabIndex = 6
        '
        'chkUserShowPassWord
        '
        Me.chkUserShowPassWord.AutoSize = True
        Me.chkUserShowPassWord.BackColor = System.Drawing.Color.Transparent
        Me.chkUserShowPassWord.Location = New System.Drawing.Point(242, 103)
        Me.chkUserShowPassWord.Name = "chkUserShowPassWord"
        Me.chkUserShowPassWord.Size = New System.Drawing.Size(101, 17)
        Me.chkUserShowPassWord.TabIndex = 4
        Me.chkUserShowPassWord.Text = "Show password"
        Me.chkUserShowPassWord.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 33)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Add User"
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(55, 204)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(291, 33)
        Me.btnAddUser.TabIndex = 1
        Me.btnAddUser.Text = "&Add"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'txtadduserNAme
        '
        Me.txtadduserNAme.Location = New System.Drawing.Point(55, 75)
        Me.txtadduserNAme.Name = "txtadduserNAme"
        Me.txtadduserNAme.Size = New System.Drawing.Size(291, 20)
        Me.txtadduserNAme.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(55, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Reenter Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(55, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Password"
        '
        'txtAddUserRePass
        '
        Me.txtAddUserRePass.Location = New System.Drawing.Point(55, 174)
        Me.txtAddUserRePass.Name = "txtAddUserRePass"
        Me.txtAddUserRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddUserRePass.Size = New System.Drawing.Size(291, 20)
        Me.txtAddUserRePass.TabIndex = 0
        '
        'txtAddUserPass
        '
        Me.txtAddUserPass.Location = New System.Drawing.Point(55, 124)
        Me.txtAddUserPass.Name = "txtAddUserPass"
        Me.txtAddUserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAddUserPass.Size = New System.Drawing.Size(291, 20)
        Me.txtAddUserPass.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(55, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "UserName"
        '
        'tbLogin
        '
        Me.tbLogin.Controls.Add(Me.pnlForgotPass)
        Me.tbLogin.Location = New System.Drawing.Point(4, 22)
        Me.tbLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(401, 294)
        Me.tbLogin.TabIndex = 0
        Me.tbLogin.UseVisualStyleBackColor = True
        '
        'pnlForgotPass
        '
        Me.pnlForgotPass.BackColor = System.Drawing.Color.White
        Me.pnlForgotPass.BackgroundImage = Global.Electroplating_equipment_monitoring_system.My.Resources.Resources.Mesa_de_trabajo_1
        Me.pnlForgotPass.Controls.Add(Me.chkShowPassChangePass)
        Me.pnlForgotPass.Controls.Add(Me.Label4)
        Me.pnlForgotPass.Controls.Add(Me.btnChangePass)
        Me.pnlForgotPass.Controls.Add(Me.TextBox1)
        Me.pnlForgotPass.Controls.Add(Me.Label12)
        Me.pnlForgotPass.Controls.Add(Me.Label5)
        Me.pnlForgotPass.Controls.Add(Me.Label6)
        Me.pnlForgotPass.Controls.Add(Me.txtChangeRePass)
        Me.pnlForgotPass.Controls.Add(Me.txtChangeNewPass)
        Me.pnlForgotPass.Controls.Add(Me.txtChangeOldPass)
        Me.pnlForgotPass.Controls.Add(Me.Label7)
        Me.pnlForgotPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForgotPass.Location = New System.Drawing.Point(0, 0)
        Me.pnlForgotPass.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlForgotPass.Name = "pnlForgotPass"
        Me.pnlForgotPass.Size = New System.Drawing.Size(401, 294)
        Me.pnlForgotPass.TabIndex = 7
        '
        'chkShowPassChangePass
        '
        Me.chkShowPassChangePass.AutoSize = True
        Me.chkShowPassChangePass.BackColor = System.Drawing.Color.Transparent
        Me.chkShowPassChangePass.Location = New System.Drawing.Point(242, 93)
        Me.chkShowPassChangePass.Name = "chkShowPassChangePass"
        Me.chkShowPassChangePass.Size = New System.Drawing.Size(101, 17)
        Me.chkShowPassChangePass.TabIndex = 4
        Me.chkShowPassChangePass.Text = "Show password"
        Me.chkShowPassChangePass.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Change password"
        '
        'btnChangePass
        '
        Me.btnChangePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.Location = New System.Drawing.Point(55, 228)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(291, 25)
        Me.btnChangePass.TabIndex = 1
        Me.btnChangePass.Text = "&Change"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(291, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(55, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Reenter Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(55, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "New Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(55, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Old Password"
        '
        'txtChangeRePass
        '
        Me.txtChangeRePass.Location = New System.Drawing.Point(55, 202)
        Me.txtChangeRePass.Name = "txtChangeRePass"
        Me.txtChangeRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtChangeRePass.Size = New System.Drawing.Size(291, 20)
        Me.txtChangeRePass.TabIndex = 0
        '
        'txtChangeNewPass
        '
        Me.txtChangeNewPass.Location = New System.Drawing.Point(55, 157)
        Me.txtChangeNewPass.Name = "txtChangeNewPass"
        Me.txtChangeNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtChangeNewPass.Size = New System.Drawing.Size(291, 20)
        Me.txtChangeNewPass.TabIndex = 0
        '
        'txtChangeOldPass
        '
        Me.txtChangeOldPass.Location = New System.Drawing.Point(55, 113)
        Me.txtChangeOldPass.Name = "txtChangeOldPass"
        Me.txtChangeOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtChangeOldPass.Size = New System.Drawing.Size(291, 20)
        Me.txtChangeOldPass.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(55, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "User Name"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(622, 300)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlMAin)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(638, 339)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlMAin.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbReset.ResumeLayout(False)
        Me.PnlLogin.ResumeLayout(False)
        Me.PnlLogin.PerformLayout()
        Me.tbAdd.ResumeLayout(False)
        Me.pnlAddUser.ResumeLayout(False)
        Me.pnlAddUser.PerformLayout()
        Me.tbLogin.ResumeLayout(False)
        Me.pnlForgotPass.ResumeLayout(False)
        Me.pnlForgotPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassWord As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlMAin As Panel
    Friend WithEvents PnlLogin As Panel
    Friend WithEvents btnSelectForgot As Button
    Friend WithEvents btnSelectReg As Button
    Friend WithEvents btnSelectLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents chkLoginShowPass As CheckBox
    Friend WithEvents pnlAddUser As Panel
    Friend WithEvents chkUserShowPassWord As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddUser As Button
    Friend WithEvents txtadduserNAme As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAddUserRePass As TextBox
    Friend WithEvents txtAddUserPass As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlForgotPass As Panel
    Friend WithEvents chkShowPassChangePass As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnChangePass As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtChangeNewPass As TextBox
    Friend WithEvents txtChangeOldPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtChangeRePass As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbReset As TabPage
    Friend WithEvents tbAdd As TabPage
    Friend WithEvents tbLogin As TabPage
End Class
