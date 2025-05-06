<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinearSearch
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
        Me.btnLinear = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btnLinear
        '
        Me.btnLinear.Font = New System.Drawing.Font("JetBrains Mono NL", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnLinear.Location = New System.Drawing.Point(188, 85)
        Me.btnLinear.Name = "btnLinear"
        Me.btnLinear.Size = New System.Drawing.Size(90, 68)
        Me.btnLinear.TabIndex = 0
        Me.btnLinear.Text = "Linear Search"
        Me.btnLinear.UseVisualStyleBackColor = true
        AddHandler Me.btnLinear.Click, AddressOf Me.btnLinear_Click
        '
        'LinearSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 271)
        Me.Controls.Add(Me.btnLinear)
        Me.Name = "LinearSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LinearSearch"
        Me.ResumeLayout(false)

End Sub

	Friend WithEvents btnLinear As Button
End Class
