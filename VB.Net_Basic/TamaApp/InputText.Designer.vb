<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputText
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
		Me.txtFirstName = New System.Windows.Forms.TextBox()
		Me.lblFirstName = New System.Windows.Forms.Label()
		Me.lblLastName = New System.Windows.Forms.Label()
		Me.txtLastName = New System.Windows.Forms.TextBox()
		Me.lblGender = New System.Windows.Forms.Label()
		Me.txtGender = New System.Windows.Forms.TextBox()
		Me.btnProcess = New System.Windows.Forms.Button()
		Me.lstOccupation = New System.Windows.Forms.ListBox()
		Me.lblOccupation = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'txtFirstName
		'
		Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtFirstName.Location = New System.Drawing.Point(233, 42)
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(149, 26)
		Me.txtFirstName.TabIndex = 0
		'
		'lblFirstName
		'
		Me.lblFirstName.AutoSize = true
		Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblFirstName.Location = New System.Drawing.Point(141, 45)
		Me.lblFirstName.Name = "lblFirstName"
		Me.lblFirstName.Size = New System.Drawing.Size(86, 20)
		Me.lblFirstName.TabIndex = 1
		Me.lblFirstName.Text = "First Name"
		'
		'lblLastName
		'
		Me.lblLastName.AutoSize = true
		Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblLastName.Location = New System.Drawing.Point(141, 88)
		Me.lblLastName.Name = "lblLastName"
		Me.lblLastName.Size = New System.Drawing.Size(86, 20)
		Me.lblLastName.TabIndex = 3
		Me.lblLastName.Text = "Last Name"
		'
		'txtLastName
		'
		Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtLastName.Location = New System.Drawing.Point(233, 85)
		Me.txtLastName.Name = "txtLastName"
		Me.txtLastName.Size = New System.Drawing.Size(149, 26)
		Me.txtLastName.TabIndex = 2
		'
		'lblGender
		'
		Me.lblGender.AutoSize = true
		Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblGender.Location = New System.Drawing.Point(141, 132)
		Me.lblGender.Name = "lblGender"
		Me.lblGender.Size = New System.Drawing.Size(63, 20)
		Me.lblGender.TabIndex = 5
		Me.lblGender.Text = "Gender"
		'
		'txtGender
		'
		Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtGender.Location = New System.Drawing.Point(233, 129)
		Me.txtGender.Name = "txtGender"
		Me.txtGender.Size = New System.Drawing.Size(149, 26)
		Me.txtGender.TabIndex = 4
		'
		'btnProcess
		'
		Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnProcess.Location = New System.Drawing.Point(233, 198)
		Me.btnProcess.Name = "btnProcess"
		Me.btnProcess.Size = New System.Drawing.Size(149, 27)
		Me.btnProcess.TabIndex = 6
		Me.btnProcess.Text = "Process"
		Me.btnProcess.UseVisualStyleBackColor = true
		'
		'lstOccupation
		'
		Me.lstOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lstOccupation.FormattingEnabled = true
		Me.lstOccupation.ItemHeight = 18
		Me.lstOccupation.Items.AddRange(New Object() {"Police", "Doctor", "Programmer", "Pilot", "Driver", "Butcher", "Teacher", "Student"})
		Me.lstOccupation.Location = New System.Drawing.Point(429, 75)
		Me.lstOccupation.Name = "lstOccupation"
		Me.lstOccupation.Size = New System.Drawing.Size(197, 148)
		Me.lstOccupation.TabIndex = 7
		'
		'lblOccupation
		'
		Me.lblOccupation.AutoSize = true
		Me.lblOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblOccupation.Location = New System.Drawing.Point(425, 42)
		Me.lblOccupation.Name = "lblOccupation"
		Me.lblOccupation.Size = New System.Drawing.Size(90, 20)
		Me.lblOccupation.TabIndex = 8
		Me.lblOccupation.Text = "Occupation"
		'
		'InputText
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.lblOccupation)
		Me.Controls.Add(Me.lstOccupation)
		Me.Controls.Add(Me.btnProcess)
		Me.Controls.Add(Me.lblGender)
		Me.Controls.Add(Me.txtGender)
		Me.Controls.Add(Me.lblLastName)
		Me.Controls.Add(Me.txtLastName)
		Me.Controls.Add(Me.lblFirstName)
		Me.Controls.Add(Me.txtFirstName)
		Me.Name = "InputText"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "InputTextForm"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Friend WithEvents txtFirstName As TextBox
	Friend WithEvents lblFirstName As Label
	Friend WithEvents lblLastName As Label
	Friend WithEvents txtLastName As TextBox
	Friend WithEvents lblGender As Label
	Friend WithEvents txtGender As TextBox
	Friend WithEvents btnProcess As Button
	Friend WithEvents lstOccupation As ListBox
	Friend WithEvents lblOccupation As Label
End Class
