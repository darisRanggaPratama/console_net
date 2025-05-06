<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conditional
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
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.txtMessage = New System.Windows.Forms.TextBox()
		Me.btnMessage = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'lblMessage
		'
		Me.lblMessage.AutoSize = true
		Me.lblMessage.Location = New System.Drawing.Point(234, 91)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(67, 13)
		Me.lblMessage.TabIndex = 0
		Me.lblMessage.Text = "Your country"
		'
		'txtMessage
		'
		Me.txtMessage.Location = New System.Drawing.Point(372, 88)
		Me.txtMessage.Name = "txtMessage"
		Me.txtMessage.Size = New System.Drawing.Size(205, 20)
		Me.txtMessage.TabIndex = 1
		'
		'btnMessage
		'
		Me.btnMessage.Location = New System.Drawing.Point(372, 139)
		Me.btnMessage.Name = "btnMessage"
		Me.btnMessage.Size = New System.Drawing.Size(205, 58)
		Me.btnMessage.TabIndex = 2
		Me.btnMessage.Text = "Message"
		Me.btnMessage.UseVisualStyleBackColor = true
		'
		'Conditional
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnMessage)
		Me.Controls.Add(Me.txtMessage)
		Me.Controls.Add(Me.lblMessage)
		Me.Name = "Conditional"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Conditional"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents lblMessage As Label
	Friend WithEvents txtMessage As TextBox
	Friend WithEvents btnMessage As Button
End Class
