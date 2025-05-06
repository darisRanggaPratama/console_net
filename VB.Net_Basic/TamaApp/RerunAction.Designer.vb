<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RerunAction
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
		Me.btnFor = New System.Windows.Forms.Button()
		Me.btnWhile = New System.Windows.Forms.Button()
		Me.btnUntil = New System.Windows.Forms.Button()
		Me.btnLoop = New System.Windows.Forms.Button()
		Me.btnLoopWhile = New System.Windows.Forms.Button()
		Me.btnRunLoop = New System.Windows.Forms.Button()
		Me.btnNumber = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'btnFor
		'
		Me.btnFor.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnFor.Location = New System.Drawing.Point(156, 37)
		Me.btnFor.Name = "btnFor"
		Me.btnFor.Size = New System.Drawing.Size(111, 36)
		Me.btnFor.TabIndex = 0
		Me.btnFor.Text = "For-Next"
		Me.btnFor.UseVisualStyleBackColor = true
		'
		'btnWhile
		'
		Me.btnWhile.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnWhile.Location = New System.Drawing.Point(156, 95)
		Me.btnWhile.Name = "btnWhile"
		Me.btnWhile.Size = New System.Drawing.Size(111, 36)
		Me.btnWhile.TabIndex = 1
		Me.btnWhile.Text = "Do-While"
		Me.btnWhile.UseVisualStyleBackColor = true
		'
		'btnUntil
		'
		Me.btnUntil.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnUntil.Location = New System.Drawing.Point(156, 164)
		Me.btnUntil.Name = "btnUntil"
		Me.btnUntil.Size = New System.Drawing.Size(111, 36)
		Me.btnUntil.TabIndex = 2
		Me.btnUntil.Text = "Do-Until"
		Me.btnUntil.UseVisualStyleBackColor = true
		'
		'btnLoop
		'
		Me.btnLoop.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLoop.Location = New System.Drawing.Point(156, 231)
		Me.btnLoop.Name = "btnLoop"
		Me.btnLoop.Size = New System.Drawing.Size(111, 36)
		Me.btnLoop.TabIndex = 3
		Me.btnLoop.Text = "Do-Loop"
		Me.btnLoop.UseVisualStyleBackColor = true
		'
		'btnLoopWhile
		'
		Me.btnLoopWhile.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLoopWhile.Location = New System.Drawing.Point(132, 295)
		Me.btnLoopWhile.Name = "btnLoopWhile"
		Me.btnLoopWhile.Size = New System.Drawing.Size(166, 36)
		Me.btnLoopWhile.TabIndex = 4
		Me.btnLoopWhile.Text = "Do-Loop-While"
		Me.btnLoopWhile.UseVisualStyleBackColor = true
		'
		'btnRunLoop
		'
		Me.btnRunLoop.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRunLoop.Location = New System.Drawing.Point(521, 37)
		Me.btnRunLoop.Name = "btnRunLoop"
		Me.btnRunLoop.Size = New System.Drawing.Size(110, 65)
		Me.btnRunLoop.TabIndex = 5
		Me.btnRunLoop.Text = "Enter a Name"
		Me.btnRunLoop.UseVisualStyleBackColor = true
		'
		'btnNumber
		'
		Me.btnNumber.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnNumber.Location = New System.Drawing.Point(521, 135)
		Me.btnNumber.Name = "btnNumber"
		Me.btnNumber.Size = New System.Drawing.Size(110, 65)
		Me.btnNumber.TabIndex = 6
		Me.btnNumber.Text = "Enter a Number"
		Me.btnNumber.UseVisualStyleBackColor = true
		'
		'RerunAction
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnNumber)
		Me.Controls.Add(Me.btnRunLoop)
		Me.Controls.Add(Me.btnLoopWhile)
		Me.Controls.Add(Me.btnLoop)
		Me.Controls.Add(Me.btnUntil)
		Me.Controls.Add(Me.btnWhile)
		Me.Controls.Add(Me.btnFor)
		Me.Name = "RerunAction"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "RerunAction"
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents btnFor As Button
	Friend WithEvents btnWhile As Button
	Friend WithEvents btnUntil As Button
	Friend WithEvents btnLoop As Button
	Friend WithEvents btnLoopWhile As Button
	Friend WithEvents btnRunLoop As Button
	Friend WithEvents btnNumber As Button
End Class
