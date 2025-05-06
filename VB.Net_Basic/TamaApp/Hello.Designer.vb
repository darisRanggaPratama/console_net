<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHello
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
		Me.btnSay = New System.Windows.Forms.Button()
		Me.btnVar = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'btnSay
		'
		Me.btnSay.BackColor = System.Drawing.Color.RosyBrown
		Me.btnSay.Location = New System.Drawing.Point(176, 53)
		Me.btnSay.Name = "btnSay"
		Me.btnSay.Size = New System.Drawing.Size(96, 52)
		Me.btnSay.TabIndex = 0
		Me.btnSay.Text = "Say Hi"
		Me.btnSay.UseVisualStyleBackColor = false
		'
		'btnVar
		'
		Me.btnVar.BackColor = System.Drawing.Color.Silver
		Me.btnVar.Location = New System.Drawing.Point(278, 53)
		Me.btnVar.Name = "btnVar"
		Me.btnVar.Size = New System.Drawing.Size(96, 52)
		Me.btnVar.TabIndex = 1
		Me.btnVar.Text = "Variable"
		Me.btnVar.UseVisualStyleBackColor = false
		'
		'FormHello
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnVar)
		Me.Controls.Add(Me.btnSay)
		Me.Name = "FormHello"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Welcome"
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents btnSay As Button
	Friend WithEvents btnVar As Button
End Class
