<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperatorRecord
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnOperatorItemRecord = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnItemEditRecord = New System.Windows.Forms.Button()
        Me.btnfeedingRecord = New System.Windows.Forms.Button()
        Me.btnSystemLoginRecord = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Electroplating_equipment_monitoring_system.My.Resources.Resources.Mesa_de_trabajo_1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BtnExit)
        Me.Panel1.Controls.Add(Me.btnOperatorItemRecord)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnItemEditRecord)
        Me.Panel1.Controls.Add(Me.btnfeedingRecord)
        Me.Panel1.Controls.Add(Me.btnSystemLoginRecord)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 499)
        Me.Panel1.TabIndex = 11
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(644, 14)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'btnOperatorItemRecord
        '
        Me.btnOperatorItemRecord.Location = New System.Drawing.Point(411, 14)
        Me.btnOperatorItemRecord.Name = "btnOperatorItemRecord"
        Me.btnOperatorItemRecord.Size = New System.Drawing.Size(145, 23)
        Me.btnOperatorItemRecord.TabIndex = 1
        Me.btnOperatorItemRecord.Text = "oprator item record"
        Me.btnOperatorItemRecord.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(563, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnItemEditRecord
        '
        Me.btnItemEditRecord.Location = New System.Drawing.Point(279, 14)
        Me.btnItemEditRecord.Name = "btnItemEditRecord"
        Me.btnItemEditRecord.Size = New System.Drawing.Size(126, 23)
        Me.btnItemEditRecord.TabIndex = 1
        Me.btnItemEditRecord.Text = "Item edit record"
        Me.btnItemEditRecord.UseVisualStyleBackColor = True
        '
        'btnfeedingRecord
        '
        Me.btnfeedingRecord.Location = New System.Drawing.Point(159, 14)
        Me.btnfeedingRecord.Name = "btnfeedingRecord"
        Me.btnfeedingRecord.Size = New System.Drawing.Size(114, 23)
        Me.btnfeedingRecord.TabIndex = 1
        Me.btnfeedingRecord.Text = "Feeding record"
        Me.btnfeedingRecord.UseVisualStyleBackColor = True
        '
        'btnSystemLoginRecord
        '
        Me.btnSystemLoginRecord.Location = New System.Drawing.Point(12, 14)
        Me.btnSystemLoginRecord.Name = "btnSystemLoginRecord"
        Me.btnSystemLoginRecord.Size = New System.Drawing.Size(141, 23)
        Me.btnSystemLoginRecord.TabIndex = 1
        Me.btnSystemLoginRecord.Text = "system login record"
        Me.btnSystemLoginRecord.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 43)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(707, 427)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'frmOperatorRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 499)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(747, 538)
        Me.Name = "frmOperatorRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents btnOperatorItemRecord As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnItemEditRecord As Button
    Friend WithEvents btnfeedingRecord As Button
    Friend WithEvents btnSystemLoginRecord As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
