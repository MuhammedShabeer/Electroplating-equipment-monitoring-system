<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPNoperation
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblHeaderName = New System.Windows.Forms.Label()
        Me.dgvItemAndDate = New System.Windows.Forms.DataGridView()
        Me.btnEnquiry = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFeed = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.colCreateddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvItemAndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = Global.Electroplating_equipment_monitoring_system.My.Resources.Resources.Mesa_de_trabajo_1
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.lblHeaderName)
        Me.Panel4.Controls.Add(Me.dgvItemAndDate)
        Me.Panel4.Controls.Add(Me.btnEnquiry)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnFeed)
        Me.Panel4.Controls.Add(Me.txtQty)
        Me.Panel4.Controls.Add(Me.txtItem)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label52)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(467, 336)
        Me.Panel4.TabIndex = 12
        '
        'lblHeaderName
        '
        Me.lblHeaderName.AutoSize = True
        Me.lblHeaderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderName.Location = New System.Drawing.Point(20, 19)
        Me.lblHeaderName.Name = "lblHeaderName"
        Me.lblHeaderName.Size = New System.Drawing.Size(0, 20)
        Me.lblHeaderName.TabIndex = 13
        '
        'dgvItemAndDate
        '
        Me.dgvItemAndDate.AllowUserToAddRows = False
        Me.dgvItemAndDate.AllowUserToDeleteRows = False
        Me.dgvItemAndDate.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvItemAndDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemAndDate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCreateddate, Me.ColItemName})
        Me.dgvItemAndDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvItemAndDate.GridColor = System.Drawing.Color.White
        Me.dgvItemAndDate.Location = New System.Drawing.Point(0, 160)
        Me.dgvItemAndDate.Name = "dgvItemAndDate"
        Me.dgvItemAndDate.ReadOnly = True
        Me.dgvItemAndDate.Size = New System.Drawing.Size(467, 176)
        Me.dgvItemAndDate.TabIndex = 12
        '
        'btnEnquiry
        '
        Me.btnEnquiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnquiry.Location = New System.Drawing.Point(357, 101)
        Me.btnEnquiry.Name = "btnEnquiry"
        Me.btnEnquiry.Size = New System.Drawing.Size(84, 24)
        Me.btnEnquiry.TabIndex = 5
        Me.btnEnquiry.Text = "Enquiry"
        Me.btnEnquiry.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(267, 101)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 24)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnFeed
        '
        Me.btnFeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeed.Location = New System.Drawing.Point(177, 102)
        Me.btnFeed.Name = "btnFeed"
        Me.btnFeed.Size = New System.Drawing.Size(84, 24)
        Me.btnFeed.TabIndex = 5
        Me.btnFeed.Text = "Feed"
        Me.btnFeed.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(63, 103)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(108, 22)
        Me.txtQty.TabIndex = 4
        '
        'txtItem
        '
        Me.txtItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(63, 63)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(378, 22)
        Me.txtItem.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Qty"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(20, 66)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(37, 16)
        Me.Label52.TabIndex = 3
        Me.Label52.Text = "PN :"
        '
        'colCreateddate
        '
        Me.colCreateddate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCreateddate.DataPropertyName = "dtmCreateTime"
        Me.colCreateddate.HeaderText = "Created date"
        Me.colCreateddate.Name = "colCreateddate"
        Me.colCreateddate.Width = 114
        '
        'ColItemName
        '
        Me.ColItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColItemName.DataPropertyName = "chvItemName"
        Me.ColItemName.HeaderText = "Item name"
        Me.ColItemName.Name = "ColItemName"
        '
        'frmPNoperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 336)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(483, 375)
        Me.Name = "frmPNoperation"
        Me.Text = "PN Operation"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvItemAndDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnquiry As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnFeed As Button
    Friend WithEvents dgvItemAndDate As DataGridView
    Friend WithEvents lblHeaderName As Label
    Friend WithEvents colCreateddate As DataGridViewTextBoxColumn
    Friend WithEvents ColItemName As DataGridViewTextBoxColumn
End Class
