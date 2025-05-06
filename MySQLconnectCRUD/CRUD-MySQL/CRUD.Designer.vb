<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
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
		Me.dgvContacts = New System.Windows.Forms.DataGridView()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblPhone = New System.Windows.Forms.Label()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.btnUpload = New System.Windows.Forms.Button()
		Me.btnDownload = New System.Windows.Forms.Button()
		Me.nudPageSize = New System.Windows.Forms.NumericUpDown()
		Me.lblPageInfo = New System.Windows.Forms.Label()
		Me.lblPageSize = New System.Windows.Forms.Label()
		Me.btnPrevPage = New System.Windows.Forms.Button()
		Me.btnNextPage = New System.Windows.Forms.Button()
		CType(Me.dgvContacts,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudPageSize,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dgvContacts
		'
		Me.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvContacts.Location = New System.Drawing.Point(16, 104)
		Me.dgvContacts.Name = "dgvContacts"
		Me.dgvContacts.Size = New System.Drawing.Size(784, 664)
		Me.dgvContacts.TabIndex = 0
		'
		'txtName
		'
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtName.Location = New System.Drawing.Point(80, 16)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(100, 23)
		Me.txtName.TabIndex = 1
		'
		'txtPhone
		'
		Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPhone.Location = New System.Drawing.Point(80, 56)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(100, 23)
		Me.txtPhone.TabIndex = 2
		'
		'lblName
		'
		Me.lblName.AutoSize = true
		Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblName.Location = New System.Drawing.Point(24, 24)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(45, 17)
		Me.lblName.TabIndex = 3
		Me.lblName.Text = "Name"
		'
		'lblPhone
		'
		Me.lblPhone.AutoSize = true
		Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblPhone.Location = New System.Drawing.Point(24, 64)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(49, 17)
		Me.lblPhone.TabIndex = 4
		Me.lblPhone.Text = "Phone"
		'
		'btnUpdate
		'
		Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnUpdate.Location = New System.Drawing.Point(208, 56)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 5
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = true
		'
		'btnClear
		'
		Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClear.Location = New System.Drawing.Point(312, 56)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 6
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = true
		'
		'btnAdd
		'
		Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnAdd.Location = New System.Drawing.Point(208, 16)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 7
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = true
		'
		'btnSearch
		'
		Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSearch.Location = New System.Drawing.Point(312, 16)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(75, 23)
		Me.btnSearch.TabIndex = 8
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = true
		'
		'btnReset
		'
		Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnReset.Location = New System.Drawing.Point(416, 56)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(75, 23)
		Me.btnReset.TabIndex = 9
		Me.btnReset.Text = "Reset"
		Me.btnReset.UseVisualStyleBackColor = true
		'
		'btnUpload
		'
		Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnUpload.Location = New System.Drawing.Point(528, 16)
		Me.btnUpload.Name = "btnUpload"
		Me.btnUpload.Size = New System.Drawing.Size(88, 23)
		Me.btnUpload.TabIndex = 10
		Me.btnUpload.Text = "UploadCSV"
		Me.btnUpload.UseVisualStyleBackColor = true
		'
		'btnDownload
		'
		Me.btnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDownload.Location = New System.Drawing.Point(528, 56)
		Me.btnDownload.Name = "btnDownload"
		Me.btnDownload.Size = New System.Drawing.Size(88, 23)
		Me.btnDownload.TabIndex = 11
		Me.btnDownload.Text = "DownloadCSV"
		Me.btnDownload.UseVisualStyleBackColor = true
		'
		'nudPageSize
		'
		Me.nudPageSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.nudPageSize.Location = New System.Drawing.Point(680, 56)
		Me.nudPageSize.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
		Me.nudPageSize.Name = "nudPageSize"
		Me.nudPageSize.Size = New System.Drawing.Size(120, 23)
		Me.nudPageSize.TabIndex = 12
		Me.nudPageSize.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'lblPageInfo
		'
		Me.lblPageInfo.AutoSize = true
		Me.lblPageInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblPageInfo.Location = New System.Drawing.Point(16, 784)
		Me.lblPageInfo.Name = "lblPageInfo"
		Me.lblPageInfo.Size = New System.Drawing.Size(155, 17)
		Me.lblPageInfo.TabIndex = 13
		Me.lblPageInfo.Text = "Page 1 of 1 (0 records)"
		'
		'lblPageSize
		'
		Me.lblPageSize.AutoSize = true
		Me.lblPageSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblPageSize.Location = New System.Drawing.Point(680, 24)
		Me.lblPageSize.Name = "lblPageSize"
		Me.lblPageSize.Size = New System.Drawing.Size(72, 17)
		Me.lblPageSize.TabIndex = 14
		Me.lblPageSize.Text = "Page Size"
		'
		'btnPrevPage
		'
		Me.btnPrevPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPrevPage.Location = New System.Drawing.Point(352, 776)
		Me.btnPrevPage.Name = "btnPrevPage"
		Me.btnPrevPage.Size = New System.Drawing.Size(75, 23)
		Me.btnPrevPage.TabIndex = 15
		Me.btnPrevPage.Text = "Previous"
		Me.btnPrevPage.UseVisualStyleBackColor = true
		'
		'btnNextPage
		'
		Me.btnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnNextPage.Location = New System.Drawing.Point(440, 776)
		Me.btnNextPage.Name = "btnNextPage"
		Me.btnNextPage.Size = New System.Drawing.Size(75, 23)
		Me.btnNextPage.TabIndex = 16
		Me.btnNextPage.Text = "Next"
		Me.btnNextPage.UseVisualStyleBackColor = true
		'
		'Display
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(814, 810)
		Me.Controls.Add(Me.btnNextPage)
		Me.Controls.Add(Me.btnPrevPage)
		Me.Controls.Add(Me.lblPageSize)
		Me.Controls.Add(Me.lblPageInfo)
		Me.Controls.Add(Me.nudPageSize)
		Me.Controls.Add(Me.btnDownload)
		Me.Controls.Add(Me.btnUpload)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.lblPhone)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.txtPhone)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.dgvContacts)
		Me.Name = "Display"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CRUD"
		CType(Me.dgvContacts,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudPageSize,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents dgvContacts As DataGridView
	Friend WithEvents txtName As TextBox
	Friend WithEvents txtPhone As TextBox
	Friend WithEvents lblName As Label
	Friend WithEvents lblPhone As Label
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnAdd As Button
	Friend WithEvents btnSearch As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents btnUpload As Button
	Friend WithEvents btnDownload As Button
	Friend WithEvents nudPageSize As NumericUpDown
	Friend WithEvents lblPageInfo As Label
	Friend WithEvents lblPageSize As Label
	Friend WithEvents btnPrevPage As Button
	Friend WithEvents btnNextPage As Button
End Class
