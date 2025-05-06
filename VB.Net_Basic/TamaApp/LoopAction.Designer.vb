<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoopAction
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
		Me.btnCount = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'btnCount
		'
		Me.btnCount.Font = New System.Drawing.Font("JetBrains Mono NL", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnCount.Location = New System.Drawing.Point(303, 133)
		Me.btnCount.Name = "btnCount"
		Me.btnCount.Size = New System.Drawing.Size(165, 98)
		Me.btnCount.TabIndex = 0
		Me.btnCount.Text = "Hitung Ganjil-Genap"
		Me.btnCount.UseVisualStyleBackColor = true
		'
		'LoopAction
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnCount)
		Me.Name = "LoopAction"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "LoopAction"
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents btnCount As Button
End Class
