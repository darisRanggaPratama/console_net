<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input
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
		Me.btnInput = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'btnInput
		'
		Me.btnInput.Location = New System.Drawing.Point(237, 38)
		Me.btnInput.Name = "btnInput"
		Me.btnInput.Size = New System.Drawing.Size(93, 43)
		Me.btnInput.TabIndex = 0
		Me.btnInput.Text = "Input"
		Me.btnInput.UseVisualStyleBackColor = true
		'
		'Input
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnInput)
		Me.Name = "Input"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "InputForm"
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents btnInput As Button
End Class
