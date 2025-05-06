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
		CType(Me.dgvContacts,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dgvContacts
		'
		Me.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvContacts.Location = New System.Drawing.Point(16, 104)
		Me.dgvContacts.Name = "dgvContacts"
		Me.dgvContacts.Size = New System.Drawing.Size(784, 264)
		Me.dgvContacts.TabIndex = 0
		'
		'txtName
		'
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtName.Location = New System.Drawing.Point(104, 16)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(100, 23)
		Me.txtName.TabIndex = 1
		'
		'txtPhone
		'
		Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPhone.Location = New System.Drawing.Point(104, 56)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(100, 23)
		Me.txtPhone.TabIndex = 2
		'
		'lblName
		'
		Me.lblName.AutoSize = true
		Me.lblName.Location = New System.Drawing.Point(48, 24)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(35, 13)
		Me.lblName.TabIndex = 3
		Me.lblName.Text = "Name"
		'
		'lblPhone
		'
		Me.lblPhone.AutoSize = true
		Me.lblPhone.Location = New System.Drawing.Point(48, 64)
		Me.lblPhone.Name = "lblPhone"
		Me.lblPhone.Size = New System.Drawing.Size(38, 13)
		Me.lblPhone.TabIndex = 4
		Me.lblPhone.Text = "Phone"
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(240, 56)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 5
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = true
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(360, 56)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 6
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = true
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(240, 16)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 7
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = true
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(360, 16)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(75, 23)
		Me.btnSearch.TabIndex = 8
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = true
		'
		'btnReset
		'
		Me.btnReset.Location = New System.Drawing.Point(456, 16)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(75, 23)
		Me.btnReset.TabIndex = 9
		Me.btnReset.Text = "Reset"
		Me.btnReset.UseVisualStyleBackColor = true
		'
		'btnUpload
		'
		Me.btnUpload.Location = New System.Drawing.Point(576, 16)
		Me.btnUpload.Name = "btnUpload"
		Me.btnUpload.Size = New System.Drawing.Size(75, 23)
		Me.btnUpload.TabIndex = 10
		Me.btnUpload.Text = "UploadCSV"
		Me.btnUpload.UseVisualStyleBackColor = true
		'
		'btnDownload
		'
		Me.btnDownload.Location = New System.Drawing.Point(576, 56)
		Me.btnDownload.Name = "btnDownload"
		Me.btnDownload.Size = New System.Drawing.Size(88, 23)
		Me.btnDownload.TabIndex = 11
		Me.btnDownload.Text = "DownloadCSV"
		Me.btnDownload.UseVisualStyleBackColor = true
		'
		'Display
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(820, 394)
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
End Class
