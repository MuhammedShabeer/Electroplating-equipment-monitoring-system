<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMdiMainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ManagmentSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpearterRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaultRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNUpdateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificationUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagmentSystemToolStripMenuItem, Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1230, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ManagmentSystemToolStripMenuItem
        '
        Me.ManagmentSystemToolStripMenuItem.Name = "ManagmentSystemToolStripMenuItem"
        Me.ManagmentSystemToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ManagmentSystemToolStripMenuItem.Text = "Managment system"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpearterRecordsToolStripMenuItem, Me.FaultRecordToolStripMenuItem, Me.ProductionToolStripMenuItem, Me.ExitSystemToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(54, 20)
        Me.FileMenu.Text = "&File (F)"
        '
        'OpearterRecordsToolStripMenuItem
        '
        Me.OpearterRecordsToolStripMenuItem.Name = "OpearterRecordsToolStripMenuItem"
        Me.OpearterRecordsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OpearterRecordsToolStripMenuItem.Text = "&Opearter Records"
        '
        'FaultRecordToolStripMenuItem
        '
        Me.FaultRecordToolStripMenuItem.Name = "FaultRecordToolStripMenuItem"
        Me.FaultRecordToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.FaultRecordToolStripMenuItem.Text = "&Fault Record"
        '
        'ProductionToolStripMenuItem
        '
        Me.ProductionToolStripMenuItem.Name = "ProductionToolStripMenuItem"
        Me.ProductionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ProductionToolStripMenuItem.Text = "&Production Record"
        '
        'ExitSystemToolStripMenuItem
        '
        Me.ExitSystemToolStripMenuItem.Name = "ExitSystemToolStripMenuItem"
        Me.ExitSystemToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExitSystemToolStripMenuItem.Text = "&Exit System"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PNUpdateToolStripMenuItem, Me.PNUpdateToolStripMenuItem1, Me.PNOperationToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(56, 20)
        Me.EditMenu.Text = "&Edit (E)"
        '
        'PNUpdateToolStripMenuItem
        '
        Me.PNUpdateToolStripMenuItem.Name = "PNUpdateToolStripMenuItem"
        Me.PNUpdateToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PNUpdateToolStripMenuItem.Text = "P/N Edit"
        '
        'PNUpdateToolStripMenuItem1
        '
        Me.PNUpdateToolStripMenuItem1.Name = "PNUpdateToolStripMenuItem1"
        Me.PNUpdateToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.PNUpdateToolStripMenuItem1.Text = "P/N Update"
        '
        'PNOperationToolStripMenuItem
        '
        Me.PNOperationToolStripMenuItem.Name = "PNOperationToolStripMenuItem"
        Me.PNOperationToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PNOperationToolStripMenuItem.Text = "P/N Operation"
        '
        'ViewMenu
        '
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(142, 20)
        Me.ViewMenu.Text = "&Process Information (L)"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.UserManagmentToolStripMenuItem, Me.AddUserToolStripMenuItem, Me.ModificationUserToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(144, 20)
        Me.ToolsMenu.Text = "&System Managment (A)"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OptionsToolStripMenuItem.Text = "Change User"
        '
        'UserManagmentToolStripMenuItem
        '
        Me.UserManagmentToolStripMenuItem.Name = "UserManagmentToolStripMenuItem"
        Me.UserManagmentToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UserManagmentToolStripMenuItem.Text = "User Managment"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'ModificationUserToolStripMenuItem
        '
        Me.ModificationUserToolStripMenuItem.Name = "ModificationUserToolStripMenuItem"
        Me.ModificationUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ModificationUserToolStripMenuItem.Text = "Modification User"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(64, 20)
        Me.HelpMenu.Text = "&Help (H)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AboutToolStripMenuItem.Text = "&About Zy(G)"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 634)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1230, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmMdiMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Electroplating_equipment_monitoring_system.My.Resources.Resources.banner1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1230, 656)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMdiMainScreen"
        Me.Text = "Electroplating equipment monitoring system"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpearterRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaultRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PNUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PNUpdateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserManagmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificationUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents colChineaseWord1 As DataGridViewTextBoxColumn
    Friend WithEvents PNOperationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagmentSystemToolStripMenuItem As ToolStripMenuItem
End Class
