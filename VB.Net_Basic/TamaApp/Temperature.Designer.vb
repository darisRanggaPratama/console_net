<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temperature
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
		Me.txtTemperature = New System.Windows.Forms.TextBox()
		Me.lblTemperature = New System.Windows.Forms.Label()
		Me.btnTemperature = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtTemperature
		'
		Me.txtTemperature.Location = New System.Drawing.Point(298, 91)
		Me.txtTemperature.Name = "txtTemperature"
		Me.txtTemperature.Size = New System.Drawing.Size(117, 20)
		Me.txtTemperature.TabIndex = 0
		'
		'lblTemperature
		'
		Me.lblTemperature.AutoSize = true
		Me.lblTemperature.Location = New System.Drawing.Point(324, 64)
		Me.lblTemperature.Name = "lblTemperature"
		Me.lblTemperature.Size = New System.Drawing.Size(67, 13)
		Me.lblTemperature.TabIndex = 1
		Me.lblTemperature.Text = "Temperature"
		'
		'btnTemperature
		'
		Me.btnTemperature.Location = New System.Drawing.Point(298, 128)
		Me.btnTemperature.Name = "btnTemperature"
		Me.btnTemperature.Size = New System.Drawing.Size(117, 23)
		Me.btnTemperature.TabIndex = 2
		Me.btnTemperature.Text = "Check Temperature"
		Me.btnTemperature.UseVisualStyleBackColor = true
		'
		'Temperature
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnTemperature)
		Me.Controls.Add(Me.lblTemperature)
		Me.Controls.Add(Me.txtTemperature)
		Me.Name = "Temperature"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Temperature"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents txtTemperature As TextBox
	Friend WithEvents lblTemperature As Label
	Friend WithEvents btnTemperature As Button
End Class
