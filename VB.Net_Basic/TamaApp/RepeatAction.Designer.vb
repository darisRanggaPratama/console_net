<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepeatAction
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
		Me.btnProcess = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'btnProcess
		'
		Me.btnProcess.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnProcess.Location = New System.Drawing.Point(296, 132)
		Me.btnProcess.Name = "btnProcess"
		Me.btnProcess.Size = New System.Drawing.Size(200, 85)
		Me.btnProcess.TabIndex = 0
		Me.btnProcess.Text = "Process"
		Me.btnProcess.UseVisualStyleBackColor = true
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Button1.Location = New System.Drawing.Point(296, 243)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(200, 85)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Process"
		Me.Button1.UseVisualStyleBackColor = true
		'
		'RepeatAction
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnProcess)
		Me.Name = "RepeatAction"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "repeatAction"
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents btnProcess As Button
	Friend WithEvents Button1 As Button
End Class
